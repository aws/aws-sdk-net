using System;
using System.Collections.Generic;
using System.Text;
using Amazon.Util;

namespace Amazon.Runtime.Internal.Util
{
    public static class TransformServiceId
    {

        public static string TransformServiceIdToConfigVariable(string serviceId)
        {
            var lowercasedString = serviceId.ToLower();
            var lowercasedAndUnderscoredString = lowercasedString.Replace(' ', '_');
            return lowercasedAndUnderscoredString;
           
        }
        public static string TransformServiceIdToEnvVariable(string serviceId)
        {
            var uppercasedString = serviceId.ToUpper();
            var uppercasedAndUnderscoredString = uppercasedString.Replace(' ', '_');
            return String.Concat(EnvironmentVariables.SERVICE_SPECIFIC_ENDPOINT_ENVIRONMENT_VARIABLE_PREFIX, uppercasedAndUnderscoredString);
        }
    }
}
