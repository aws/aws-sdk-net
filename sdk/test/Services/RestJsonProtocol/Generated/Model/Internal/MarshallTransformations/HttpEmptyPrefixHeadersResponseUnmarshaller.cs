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

/*
 * Do not modify this file. This file is generated from the rest-json-protocol-2019-12-16.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.RestJsonProtocol.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
using Amazon.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.RestJsonProtocol.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for HttpEmptyPrefixHeaders operation
    /// </summary>  
    public class HttpEmptyPrefixHeadersResponseUnmarshaller : JsonResponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
        {
            HttpEmptyPrefixHeadersResponse response = new HttpEmptyPrefixHeadersResponse();
            //Map of headers with prefix "".
            var headersForPrefixHeaders = new Dictionary<string, string>();
            foreach (var namePrefixHeaders in context.ResponseData.GetHeaderNames())
            {
                var keyToUse = namePrefixHeaders;
                if("".Length > 0 && keyToUse.StartsWith("")) {
                    keyToUse = keyToUse.Substring("".Length);
                }

                if (context.ResponseData.IsHeaderPresent($"{keyToUse}"))
                {
                    headersForPrefixHeaders.Add(
                        keyToUse,
                        context.ResponseData.GetHeaderValue($"{keyToUse}")
                    );
                }
            }
            if(headersForPrefixHeaders.Count > 0)
                response.PrefixHeaders = headersForPrefixHeaders;
            if (context.ResponseData.IsHeaderPresent("hello"))
                response.SpecificHeader = context.ResponseData.GetHeaderValue("hello");

            return response;
        }

        /// <summary>
        /// Unmarshaller error response to exception.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="innerException"></param>
        /// <param name="statusCode"></param>
        /// <returns></returns>
        public override AmazonServiceException UnmarshallException(JsonUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
        {
            StreamingUtf8JsonReader reader = new StreamingUtf8JsonReader(context.Stream);
            var errorResponse = JsonErrorResponseUnmarshaller.GetInstance().Unmarshall(context, ref reader);
            errorResponse.InnerException = innerException;
            errorResponse.StatusCode = statusCode;

            var responseBodyBytes = context.GetResponseBodyBytes();

            using (var streamCopy = new MemoryStream(responseBodyBytes))
            using (var contextCopy = new JsonUnmarshallerContext(streamCopy, false, context.ResponseData))
            {
                StreamingUtf8JsonReader readerCopy = new StreamingUtf8JsonReader(streamCopy);
            }
            return new AmazonRestJsonProtocolException(errorResponse.Message, errorResponse.InnerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, errorResponse.StatusCode);
        }

        private static HttpEmptyPrefixHeadersResponseUnmarshaller _instance = new HttpEmptyPrefixHeadersResponseUnmarshaller();        

        internal static HttpEmptyPrefixHeadersResponseUnmarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static HttpEmptyPrefixHeadersResponseUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}