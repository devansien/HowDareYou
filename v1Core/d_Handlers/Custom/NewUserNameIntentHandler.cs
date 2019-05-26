using System.Threading.Tasks;

namespace HowDareYou
{
    class NewUserNameIntentHandler : Core, IRequestHandler
    {
        public async Task HandleRequest()
        {
            await RequestProcessManager.ProcessRequest($"{CustomRequest.NewUserNameIntent}", async () =>
            {
                await Task.Run(async () =>
                {
                    string username = InputManager.GetInputValue(UserNameEntity.Name);
                    string target = InputManager.GetInputValue(NewUserNameEntity.Name);

                    if (NewUserNameEntity.Values.Contains(target) && !string.IsNullOrWhiteSpace(username))
                    {
                        State.UserName = username;
                        SessionManager.Set(SessionKey.UserMode, UserMode.Profile);
                        Response.SetSession();
                        Response.SetSpeech(false, false,
                            SpeechManager.GetUpdateUserNameSpeech(username) + SpeechManager.GetFillUpProfileSpeech()+SpeechManager.GetFillUpProfileReprompt(),
                            SpeechManager.GetWhatWouldYouDoSpeech());
                    }
                    else
                        await new FallbackIntentHandler().HandleRequest();
                });
            });
        }
    }
}
