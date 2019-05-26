using System.Threading.Tasks;

namespace HowDareYou
{
    class YesIntentHandler : Core, IRequestHandler
    {
        public async Task HandleRequest()
        {
            await RequestProcessManager.ProcessRequest($"{BuiltInRequest.YesIntent}", async () =>
            {
                await Task.Run(async () =>
                {
                    if (SessionManager.Contains(SessionKey.UserMode))
                    {
                        string userMode = SessionManager.Get<string>(SessionKey.UserMode);
                        switch (userMode)
                        {
                            case UserMode.Profile:
                                Response.SetSpeech(false, true,
                                    "Okay, profile is a series of questions about you. Later, you will be sending those profiles to your friends to take a challange. " +
                                    "Which relationship to you want to put through the challange?. You can choose family, friends, or lovers. ",
                                    "Which relationship to you want to put through the challange?. You can choose family, friends, or lovers ");
                                break;
                            case UserMode.Answer:
                                SessionManager.Set("AnswerIndex", 0);
                                Response.SetSession();
                                Response.SetSpeech(false, true,
                                    "Okay let's suffer. Question one, A. which game is ayush's best choice? ",
                                    ""
                                    );
                                break;
                            default:
                                await new FallbackIntentHandler().HandleRequest();
                                break;
                        }
                    }
                    else
                        await new FallbackIntentHandler().HandleRequest();
                });
            });
        }
    }
}
