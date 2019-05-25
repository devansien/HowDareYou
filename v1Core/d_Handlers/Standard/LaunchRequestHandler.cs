using System.Threading.Tasks;

namespace HowDareYou
{
    class LaunchRequestHandler : Core, IRequestHandler
    {
        public async Task HandleRequest()
        {
            await RequestProcessManager.ProcessRequest($"{BuiltInRequest.LaunchRequest}", async () =>
            {
                await Task.Run(() =>
                {
                    State.NumPlayed++;
                    State.NumPrompted = 0;

                    if (string.IsNullOrWhiteSpace(State.UserName))
                    {
                        Response.SetSpeech(false, false,
                            SpeechManager.GetWelcomeSpeech() + SpeechManager.GetAskForUserNameSpeech() + SpeechManager.GetAskForUserNameReprompt(),
                            SpeechManager.GetAskForUserNameReprompt());
                    }
                    else
                    {
                        // you have no challanges today. if you want to send one, please add a friend with the sie digit code. 
                        // if you dont have a friend, stop now, go out, and make some friends, then comeback. or say random to get to know someone else
                    }
                });
            });
        }
    }
}
