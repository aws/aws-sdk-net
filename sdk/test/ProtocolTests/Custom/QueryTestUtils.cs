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
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK.ProtocolTests.Utils
{
    internal static class QueryTestUtils
    {
        /// <summary>
        /// Asserts that the form-urlencoded body the SDK sent contains every query parameter in the
        /// expected body with a matching (url-decoded) value. Used by the mocked-client request tests,
        /// where the captured request only exposes the raw body bytes.
        /// </summary>
        public static void AssertBody(byte[] actualBodyBytes, string expectedBody)
        {
            if (actualBodyBytes == null)
            {
                Assert.Fail("Expected a request body but none was sent (actualBodyBytes was null).");
            }
            var actualBody = Encoding.UTF8.GetString(actualBodyBytes);
            var expectedParams = ConvertBodyToParameters(expectedBody);
            var actualParams = ConvertBodyToParameters(actualBody);
            foreach (var queryParam in expectedParams.Keys)
            {
                Assert.IsTrue(actualParams.Keys.Contains(queryParam), $"Expected query parameter '{queryParam}' was not found in the request body.");
                Assert.AreEqual(WebUtility.UrlDecode(expectedParams[queryParam]), WebUtility.UrlDecode(actualParams[queryParam]));
            }
            // Ensure the SDK didn't send any query parameters beyond the expected set.
            var extraParams = actualParams.Keys.Except(expectedParams.Keys).ToList();
            Assert.IsFalse(extraParams.Any(), $"Request body contained unexpected query parameter(s): {string.Join(", ", extraParams)}.");
        }

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
