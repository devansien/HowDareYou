using System;
using System.Threading.Tasks;

namespace HowDareYou
{
    class RequestProcessManager : Core
    {
        public static async Task ProcessRequest(string requestType, Func<Task> handler)
        {
            try
            {
                if (requestType.Equals(BuiltInRequest.LaunchRequest)
                    || requestType.Equals(CustomRequest.NewUserNameIntent) || requestType.Equals(BuiltInRequest.YesIntent)
                    || !string.IsNullOrWhiteSpace(State.UserName))
                {
                    Logger.Write($"[{requestType}] handling started");
                    await handler();
                    Logger.Write($"[{requestType}] handling completed");
                }
                else
                {
                    Response.SetSpeech(false, false,
                        SpeechManager.GetAskForUserNameSpeech() + SpeechManager.GetAskForUserNameReprompt(),
                        SpeechManager.GetAskForUserNameReprompt());
                }
            }
            catch (Exception ex)
            {
                Logger.Write($"Unable to process [{requestType}]");
                Logger.Write($"Exception detail: {ex}");
                Response.SetSpeech(true, false, SpeechManager.GetExceptionSpeech());
            }
        }
    }
}
