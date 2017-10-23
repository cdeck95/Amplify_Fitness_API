using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Amazon.Lambda.Core;

// Assembly attribute to enable the Lambda function's JSON input to be converted into a .NET class.
[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.Json.JsonSerializer))]

namespace Amplify_Fitness_API
{
    public class Function
    {
        
        /// <summary>
        /// A simple function that takes a string and does a ToUpper
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        public int FunctionHandler(ILambdaContext context)
        {
            Random rnd = new Random();
            int month = rnd.Next(1, 13);  // month: >= 1 and < 13
            return month;
        }
    }
}
