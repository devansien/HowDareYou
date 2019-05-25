using System.Collections.Generic;

namespace HowDareYou
{
    class StateManager : Core
    {
        public static void InitState()
        {
            State.NumPrompted = 0;
        }

        public static State ValidateState(string userId, State save)
        {
            if (save == null)
                save = GetDefaultState(userId);

            return save;
        }

        public static State GetDefaultState(string userId)
        {
            State state = new State()
            {
                UserId = userId,
                UserName = string.Empty,
                NumPlayed = 0,
                NumPrompted = 0,
                Challanges = new List<Challange>(),
                Utterances = new List<Utterance>()
            };

            return state;
        }
    }
}
