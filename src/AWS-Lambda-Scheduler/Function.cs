using Amazon.Lambda.Core;

// Assembly attribute to enable the Lambda function's JSON input to be converted into a .NET class.
[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.SystemTextJson.DefaultLambdaJsonSerializer))]

namespace AWS_Lambda_Scheduler
{
    public class Function
    {

        /// <summary>
        /// A sample function which will log time of whenever the event is invoked
        /// </summary>
        /// <param name="context">The ILambdaContext that provides methods for logging and describing the Lambda environment.</param>
        public void FunctionHandler(ILambdaContext context)
        {
            context.Logger.LogInformation($"Lambda called at: {DateTime.UtcNow}");
        }
    }
}
