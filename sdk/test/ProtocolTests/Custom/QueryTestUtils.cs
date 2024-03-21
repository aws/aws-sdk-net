/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

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
        public static Dictionary<string,string> ConvertBodyToParameters(string body)
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
