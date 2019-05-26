using System.Collections.Generic;

namespace HowDareYou
{
    class EnPlainSpeech
    {
        private const string WelcomeA = "Welcome to #. "; // change to ssml audio saying HOW DARE YOU!, can be multiple voices

        private const string WelcomeBackA = "Welcome back #. ";

        private const string UpdateUserNameA = "Your user name is updated to #. ";
        private const string UpdateUserNameB = "Your user name is changed to #. ";

        private const string AskForUserNameA = "Your user name is empty. ";
        private const string AskForUserNameB = "Your user name is missing. ";
        private const string AskForUserNameC = "You haven't registered your user name yet. ";
        private const string AskForUserNameD = "You must have a user name to play the game. ";

        private const string AskForUserNameRepromptA = "Please add a user name of your choice by saying, update my user name to something. " +
                                                       "For example, you can say, update my user name to, Alexa the genius. " +
                                                       "It's your turn. remember, say update my user name to something. ";

        private const string FillUpProfileB = "You do not have any profiles filled up. ";
        private const string FillUpProfileA = "It seems like you don't have any profiles set up. ";

        private const string FillUpProfileRepromptA = "Do you want to fill one up now? ";
        private const string FillUpProfileRepromptB = "I can help you to make one right away, do you want one? ";

        private const string WhatWouldYouDoA = "What do you want to do next? ";
        private const string WhatWouldYouDoB = "What would you like to do next? ";

        private const string NotUnderstandA = "I didn't understand. ";

        private const string TryAgainA = "Please try again. ";
        private const string TryAgainB = "What about saying help? ";
        private const string TryAgainC = "I suggest you to say help. ";
        private const string TryAgainD = "Please say help for detailed instructions. ";

        private const string TryAgainE = "Perhaps, it's better for you to get some instructions by saying help. ";
        private const string ExceptionA = "Sorry, something went wrong. Please try again later. ";
        private const string ExceptionB = "Sorry, something is not right. Please try again later. ";
        private const string ExceptionC = "Sorry, something must have happened. I suggest you to try again. ";
        private const string ExceptionD = "Sorry, something went wrong. If problem persists, please contact support. ";


        public List<string> GetWelcomeSpeeches() { return new List<string> { WelcomeA }; }

        public List<string> GetWelcomeBackSpeeches() { return new List<string> { WelcomeBackA }; }

        public List<string> GetUpdateUserNameSpeeches() { return new List<string> { UpdateUserNameA, UpdateUserNameB }; }
        public List<string> GetAskForUserNameSpeeches() { return new List<string> { AskForUserNameA, AskForUserNameB, AskForUserNameC, AskForUserNameD }; }
        public List<string> GetAskForUserNameReprompts() { return new List<string> { AskForUserNameRepromptA }; }

        public List<string> GetFillUpProfileSpeeches() { return new List<string> { FillUpProfileA, FillUpProfileB }; }
        public List<string> GetFillUpProfileReprompts() { return new List<string> { FillUpProfileRepromptA, FillUpProfileRepromptB }; }

        public List<string> GetWhatWouldYouDoSpeeches() { return new List<string> { WhatWouldYouDoA, WhatWouldYouDoB }; }

        public List<string> GetNotUnderstandSpeeches() { return new List<string> { NotUnderstandA }; }
        public List<string> GetTryAgainSpeeches() { return new List<string> { TryAgainA, TryAgainB, TryAgainC, TryAgainD, TryAgainE }; }

        public List<string> GetExceptionSpeeches() { return new List<string> { ExceptionA, ExceptionB, ExceptionC, ExceptionD }; }







        private const string ShortHelpA = "This is a short help speech. ";

        public List<string> GetShortHelpSpeeches() { return new List<string> { ShortHelpA }; }







        private const string AskReviewA = "Sounds like you enjoy using #. Whenever you want, please search for # in your Alexa app, then select write a review. We always value your feedback. ";


        private const string DetailedHelpA = " This is a detailed help speech. ";



        private const string CancelA = "Action cancled. ";

        private const string GoodbyeA = "Hope to see you soon. Goodbye. ";
        private const string GoodbyeB = "Pleasure to meet you. Goodbye. ";









        public List<string> GetAskReviewSpeeches() { return new List<string> { AskReviewA }; }

        public List<string> GetDetailedHelpSpeeches() { return new List<string> { DetailedHelpA }; }


        public List<string> GetCancelSpeeches() { return new List<string> { CancelA }; }
        public List<string> GetGoodbyeSpeeches() { return new List<string> { GoodbyeA, GoodbyeB }; }

    }
}
