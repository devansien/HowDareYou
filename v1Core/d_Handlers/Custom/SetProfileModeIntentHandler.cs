using Newtonsoft.Json;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HowDareYou
{
    class SetProfileModeIntentHandler : Core, IRequestHandler
    {
        public async Task HandleRequest()
        {
            await RequestProcessManager.ProcessRequest($"{CustomRequest.SetProfileModeIntent}", async () =>
            {
                await Task.Run(() =>
                {
                    string input = InputManager.GetInputValue(ProfileModeEntity.Name);

                    if (!string.IsNullOrWhiteSpace(input) && ProfileModeEntity.Values.Contains(input))
                    {
                        Profile profile = new Profile
                        {
                            Mode = input,
                            Name = State.UserName,
                            Questions = new List<string> {
                                "A. Which game is your best choice? ",
                                "B. Who is your most hated person? ",
                                "C. What is your favorite food? ",
                                "D. What is your favorite paper? ",
                                "E. Who is your favorite hero? "
                            },
                            Answers = new List<string>() {
                
                            }
                        };

                        SessionManager.Set("Index", 0);
                        Response.SetSession();
                        Logger.Write(JsonConvert.SerializeObject(profile));

                        State.Profiles.Add(profile);

                        Response.SetSpeech(false, true, $"Okay, you have chosen {input} mode. The first question, {profile.Questions[0]}. ", "");
                    }
                });
            });
        }
    }
}
