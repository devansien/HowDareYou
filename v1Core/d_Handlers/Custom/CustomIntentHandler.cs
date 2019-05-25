using System.Threading.Tasks;

namespace HowDareYou
{
    class CustomIntentHandler : Core, IRequestHandler
    {
        public async Task HandleRequest()
        {
            await RequestProcessManager.ProcessRequest($"{CustomRequest.CustomIntent}", async () =>
            {
                await Task.Run(() =>
                {

                });
            });
        }
    }
}
