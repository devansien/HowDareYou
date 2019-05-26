using System.Collections.Generic;
using System.Threading.Tasks;

namespace HowDareYou
{
    class AnswerIntentHandler : Core, IRequestHandler
    {
        public async Task HandleRequest()
        {
            await RequestProcessManager.ProcessRequest($"{CustomRequest.AnswerIntent}", async () =>
            {
                await Task.Run(() =>
                {
                    string input = InputManager.GetInputValue("AnswerEntity");

                    if (!string.IsNullOrWhiteSpace(input))
                    {
                        if (SessionManager.Get<string>("UserMode") != UserMode.Answer)
                        {
                            int index = SessionManager.Get<int>("Index");

                            Profile profile = State.Profiles[0];
                            Logger.Write(index.ToString());

                            if (profile.Answers == null)
                            {
                                profile.Answers = new List<string>();
                            }

                            profile.Answers.Add(input);

                            index++;

                            SessionManager.Set("Index", index);
                            Response.SetSession();

                            if (index < 5)
                                Response.SetSpeech(false, true, $"Next question, {profile.Questions[index]}. ");
                            else
                            {
                                Response.SetSpeech(false, true, "Your profile has been set up. send it to your friend by saying make someone suffer. ", "");
                            }
                        }
                        else
                        {
                            int answerIndex = SessionManager.Get<int>("AnswerIndex");
                            if (input.Contains(State.PendingChallanges[0].Answers[answerIndex]))
                            {
                                answerIndex += 1;
                                SessionManager.Set("AnswerIndex", answerIndex);
                                Response.Response.SetSession();
                                Response.SetSpeech(false, true, $"you got it right, next question {State.PendingChallanges[0].Questions[answerIndex]}", "");
                            }
                            else
                            {
                                answerIndex += 1;
                                SessionManager.Set("AnswerIndex", answerIndex);
                                Response.Response.SetSession();
                                Response.SetSpeech(false, true, $"How dare you got this wrong? you better try your best! Next question, {State.PendingChallanges[0].Questions[answerIndex]}", "");
                            }


                        }
                    }
                });
            });
        }
    }
}
