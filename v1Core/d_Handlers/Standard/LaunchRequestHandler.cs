using System.Linq;
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
                        Response.SetSpeech(false, true,
                            SpeechManager.GetWelcomeSpeech() + SpeechManager.GetAskForUserNameSpeech() + SpeechManager.GetAskForUserNameReprompt(),
                            SpeechManager.GetAskForUserNameReprompt());
                    }
                    else
                    {
                        if (State.PendingChallanges.Any())
                        {
                            SessionManager.Set(SessionKey.UserMode, UserMode.Answer);
                            Response.SetSession();
                            Response.SetSpeech(false,true,
                                $"You have one pending challange to face bryan, are you ready to get wasted? ", "");
                        }
                        else if (State.Profiles == null || !State.Profiles.Any() || State.Profiles.Count < 1)
                        {
                            SessionManager.Set(SessionKey.UserMode, UserMode.Profile);
                            Response.SetSession();
                            Response.SetSpeech(false, true,
                                SpeechManager.GetWelcomeBackSpeech(State.UserName) + SpeechManager.GetFillUpProfileSpeech() + SpeechManager.GetFillUpProfileReprompt(),
                                SpeechManager.GetFillUpProfileReprompt());
                        }
                        else if (State.Friends == null || !State.Friends.Any() || State.Friends.Count < 1)
                        {

                        }

                        else
                        {

                        }
                        // you have no challanges today. if you want to send one, please add a friend with the sie digit code. 
                        // if you dont have a friend, stop now, go out, and make some friends, then comeback. or say random to get to know someone else
                    }
                });
            });
        }
    }
}
