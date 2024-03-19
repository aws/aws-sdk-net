using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWSSDK.ProtocolTests.Utils
{
    internal static class QueryTestUtils
    {
        // Once support for nested structures are added this will most likely have to be updated.
        /// <summary>
        /// Takes the body of a smithy protocol test and converts it to a dictionary of query parameter to query values
        /// </summary>
        /// <param name="body"></param>
        /// <returns></returns>
        internal static Dictionary<string,string> ConvertBodyToParameters(string body)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            var splitBody = body.Split('&');
            foreach(var queryParam in splitBody)
            {
                string key = queryParam.Split('=')[0];
                string value = queryParam.Split('=')[1];
                parameters.Add(key, value);
            }
            return parameters;
        }
    }
}
