using System.Collections.Generic;

namespace HowDareYou
{
    public class RequestManager
    {
        private List<RequestType> requestTypeList;


        public RequestManager()
        {
            SetRequestTypes();
        }

        public List<RequestType> GetRequestTypes()
        {
            return requestTypeList;
        }

        private void SetRequestTypes()
        {
            requestTypeList = new List<RequestType>
            {
                new RequestType
                {
                    Name = BuiltInRequest.LaunchRequest,
                    Type = typeof(LaunchRequestHandler)
                },
                new RequestType
                {
                    Name = CustomRequest.NewUserNameIntent,
                    Type = typeof(NewUserNameIntentHandler)
                },
                new RequestType
                {
                    Name = BuiltInRequest.YesIntent,
                    Type = typeof(YesIntentHandler)
                },
                new RequestType
                {
                    Name = CustomRequest.AnswerIntent,
                    Type = typeof(AnswerIntentHandler)
                },
                new RequestType
                {
                    Name = CustomRequest.SetProfileModeIntent,
                    Type = typeof(SetProfileModeIntentHandler)
                },
                new RequestType
                {

                    Name = CustomRequest.SendProfileIntent,
                    Type = typeof(SendProfileIntentHandler)
                },
                new RequestType
                {
                    Name = BuiltInRequest.SessionEndedRequest,
                    Type = typeof(SessionEndedRequestHandler)
                }
            };
        }
    }
}
