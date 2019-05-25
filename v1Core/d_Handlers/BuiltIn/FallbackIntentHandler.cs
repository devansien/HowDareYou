using System.Threading.Tasks;

namespace HowDareYou
{
    class FallbackIntentHandler : Core, IRequestHandler
    {
        public async Task HandleRequest()
        {
            await RequestProcessManager.ProcessRequest($"{BuiltInRequest.FallbackIntent}", async () =>
            {
                await Task.Run(() =>
                {
                    State.NumPrompted++;

                    if (State.NumPrompted % 3 == 0)
                    {
                        Response.SetSpeech(true, false,
                            SpeechManager.GetExceptionSpeech());
                    }
                    else
                        Response.SetSpeech(false, false,
                            SpeechManager.GetNotUnderstandSpeech() + SpeechManager.GetTryAgainSpeech() + SpeechManager.GetWhatWouldYouDoSpeech(),
                            SpeechManager.GetShortHelpSpeech() + SpeechManager.GetWhatWouldYouDoSpeech());
                });
            });
        }
    }
}
