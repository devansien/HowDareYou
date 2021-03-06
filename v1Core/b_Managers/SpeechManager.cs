﻿using System;
using System.Collections.Generic;

namespace HowDareYou
{
    class SpeechManager
    {
        protected const string replaceTarget = "#";
        protected static Random random = new Random();
        protected static EnPlainSpeech enSpeech = new EnPlainSpeech();


        public static string GetWelcomeSpeech()
        {
            List<string> speeches = enSpeech.GetWelcomeSpeeches();
            string speech = speeches[random.Next(speeches.Count)];

            int targetIndex = speech.IndexOf(replaceTarget);
            speech = speech.Remove(targetIndex, replaceTarget.Length).Insert(targetIndex, SkillMetadata.Name);

            return speech;
        }

        public static string GetWelcomeBackSpeech(string username)
        {
            List<string> speeches = enSpeech.GetWelcomeBackSpeeches();
            string speech = speeches[random.Next(speeches.Count)];

            int targetIndex = speech.IndexOf(replaceTarget);
            speech = speech.Remove(targetIndex, replaceTarget.Length).Insert(targetIndex, username);

            return speech;
        }

        public static string GetUpdateUserNameSpeech(string username)
        {
            List<string> speeches = enSpeech.GetUpdateUserNameSpeeches();
            string speech = speeches[random.Next(speeches.Count)];

            int targetIndex = speech.IndexOf(replaceTarget);
            speech = speech.Remove(targetIndex, replaceTarget.Length).Insert(targetIndex, username);

            return speech;
        }

        public static string GetAskForUserNameSpeech()
        {
            List<string> speeches = enSpeech.GetAskForUserNameSpeeches();
            string speech = speeches[random.Next(speeches.Count)];

            return speech;
        }

        public static string GetAskForUserNameReprompt()
        {
            List<string> speeches = enSpeech.GetAskForUserNameReprompts();
            string speech = speeches[random.Next(speeches.Count)];

            return speech;
        }

        public static string GetFillUpProfileSpeech()
        {
            List<string> speeches = enSpeech.GetFillUpProfileSpeeches();
            string speech = speeches[random.Next(speeches.Count)];

            return speech;
        }

        public static string GetFillUpProfileReprompt()
        {
            List<string> speeches = enSpeech.GetFillUpProfileReprompts();
            string speech = speeches[random.Next(speeches.Count)];

            return speech;
        }

        public static string GetWhatWouldYouDoSpeech()
        {
            List<string> speeches = enSpeech.GetWhatWouldYouDoSpeeches();
            return speeches[random.Next(speeches.Count)];
        }

        public static string GetNotUnderstandSpeech()
        {
            List<string> notUnderstandSpeeches = enSpeech.GetNotUnderstandSpeeches();
            return notUnderstandSpeeches[random.Next(notUnderstandSpeeches.Count)];
        }

        public static string GetTryAgainSpeech()
        {
            List<string> tryAgainSpeeches = enSpeech.GetTryAgainSpeeches();
            return tryAgainSpeeches[random.Next(tryAgainSpeeches.Count)];
        }

        public static string GetExceptionSpeech()
        {
            List<string> speeches = enSpeech.GetExceptionSpeeches();
            return speeches[random.Next(speeches.Count)];
        }

        protected static int CountTargetString(string text)
        {
            int i = 0;
            int count = 0;

            while ((i = text.IndexOf(replaceTarget, i)) != -1)
            {
                i += replaceTarget.Length;
                count++;
            }

            return count;
        }





















        public static string GetWelcomeBackSpeech()
        {
            List<string> welcomeBackSpeeches = enSpeech.GetWelcomeBackSpeeches();
            return welcomeBackSpeeches[random.Next(welcomeBackSpeeches.Count)];
        }

        public static string GetAskReviewSpeech()
        {
            List<string> reviewSpeeches = enSpeech.GetAskReviewSpeeches();
            string reviewSpeech = reviewSpeeches[random.Next(reviewSpeeches.Count)];
            int count = CountTargetString(reviewSpeech);

            for (int i = 0; i < count; i++)
            {
                int targetIndex = reviewSpeech.IndexOf(replaceTarget);
                reviewSpeech = reviewSpeech.Remove(targetIndex, replaceTarget.Length).Insert(targetIndex, SkillMetadata.Name);
            }

            return reviewSpeech;
        }

        public static string GetShortHelpSpeech()
        {
            List<string> shortHelpSpeeches = enSpeech.GetShortHelpSpeeches();
            return shortHelpSpeeches[random.Next(shortHelpSpeeches.Count)];
        }








    }
}
