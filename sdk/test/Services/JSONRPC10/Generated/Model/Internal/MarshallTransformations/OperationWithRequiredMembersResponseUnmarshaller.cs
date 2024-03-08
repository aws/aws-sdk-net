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
 * Do not modify this file. This file is generated from the json-rpc-10-2020-07-14.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.JSONRPC10.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.JSONRPC10.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for OperationWithRequiredMembers operation
    /// </summary>  
    public class OperationWithRequiredMembersResponseUnmarshaller : JsonResponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
        {
            OperationWithRequiredMembersResponse response = new OperationWithRequiredMembersResponse();

            context.Read();
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("requiredBlob", targetDepth))
                {
                    var unmarshaller = MemoryStreamUnmarshaller.Instance;
                    response.RequiredBlob = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("requiredBoolean", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    response.RequiredBoolean = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("requiredByte", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    response.RequiredByte = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("requiredDouble", targetDepth))
                {
                    var unmarshaller = DoubleUnmarshaller.Instance;
                    response.RequiredDouble = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("requiredFloat", targetDepth))
                {
                    var unmarshaller = FloatUnmarshaller.Instance;
                    response.RequiredFloat = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("requiredInteger", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    response.RequiredInteger = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("requiredList", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    response.RequiredList = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("requiredLong", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    response.RequiredLong = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("requiredMap", targetDepth))
                {
                    var unmarshaller = new DictionaryUnmarshaller<string, string, StringUnmarshaller, StringUnmarshaller>(StringUnmarshaller.Instance, StringUnmarshaller.Instance);
                    response.RequiredMap = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("requiredShort", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    response.RequiredShort = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("requiredString", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.RequiredString = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("requiredTimestamp", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    response.RequiredTimestamp = unmarshaller.Unmarshall(context);
                    continue;
                }
            }

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
            var errorResponse = JsonErrorResponseUnmarshaller.GetInstance().Unmarshall(context);
            errorResponse.InnerException = innerException;
            errorResponse.StatusCode = statusCode;

            var responseBodyBytes = context.GetResponseBodyBytes();

            using (var streamCopy = new MemoryStream(responseBodyBytes))
            using (var contextCopy = new JsonUnmarshallerContext(streamCopy, false, null))
            {
            }
            return new AmazonJSONRPC10Exception(errorResponse.Message, errorResponse.InnerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, errorResponse.StatusCode);
        }

        private static OperationWithRequiredMembersResponseUnmarshaller _instance = new OperationWithRequiredMembersResponseUnmarshaller();        

        internal static OperationWithRequiredMembersResponseUnmarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static OperationWithRequiredMembersResponseUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}