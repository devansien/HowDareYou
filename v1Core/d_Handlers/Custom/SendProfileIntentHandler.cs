using System.Collections.Generic;
using System.Threading.Tasks;

namespace HowDareYou
{
    class SendProfileIntentHandler : Core, IRequestHandler
    {
        public async Task HandleRequest()
        {
            await RequestProcessManager.ProcessRequest($"{CustomRequest.SendProfileIntent}", async () =>
            {
                await Task.Run(async () =>
                {
                    State friend = await Database.GetFriend("bryan");

                    if (friend.PendingChallanges == null)
                    {
                        friend.PendingChallanges = new List<Profile>();
                    }

                    friend.PendingChallanges.Add(State.Profiles[0]);

                    await Database.SaveFriend(friend);
                    Response.SetSpeech(false, true, "Your profile has been sent to Bryan. ", "");

                });
            });
        }
    }
}
