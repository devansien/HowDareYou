using Amazon.Lambda.Core;

namespace HowDareYou
{
    public class Logger
    {
        private readonly ILambdaLogger logger;


        public Logger(ILambdaLogger logger)
        {
            this.logger = logger;
        }

        public void Write(string log)
        {
            logger.LogLine($"{log}");
        }
    }
}
