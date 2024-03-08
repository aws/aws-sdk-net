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
    /// Response Unmarshaller for OperationWithDefaults operation
    /// </summary>  
    public class OperationWithDefaultsResponseUnmarshaller : JsonResponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
        {
            OperationWithDefaultsResponse response = new OperationWithDefaultsResponse();

            context.Read();
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("defaultBlob", targetDepth))
                {
                    var unmarshaller = MemoryStreamUnmarshaller.Instance;
                    response.DefaultBlob = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("defaultBoolean", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    response.DefaultBoolean = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("defaultByte", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    response.DefaultByte = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("defaultDocumentBoolean", targetDepth))
                {
                    var unmarshaller = Amazon.Runtime.Documents.Internal.Transform.DocumentUnmarshaller.Instance;
                    response.DefaultDocumentBoolean = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("defaultDocumentList", targetDepth))
                {
                    var unmarshaller = Amazon.Runtime.Documents.Internal.Transform.DocumentUnmarshaller.Instance;
                    response.DefaultDocumentList = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("defaultDocumentMap", targetDepth))
                {
                    var unmarshaller = Amazon.Runtime.Documents.Internal.Transform.DocumentUnmarshaller.Instance;
                    response.DefaultDocumentMap = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("defaultDocumentString", targetDepth))
                {
                    var unmarshaller = Amazon.Runtime.Documents.Internal.Transform.DocumentUnmarshaller.Instance;
                    response.DefaultDocumentString = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("defaultDouble", targetDepth))
                {
                    var unmarshaller = DoubleUnmarshaller.Instance;
                    response.DefaultDouble = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("defaultEnum", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.DefaultEnum = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("defaultFloat", targetDepth))
                {
                    var unmarshaller = FloatUnmarshaller.Instance;
                    response.DefaultFloat = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("defaultInteger", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    response.DefaultInteger = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("defaultIntEnum", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    response.DefaultIntEnum = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("defaultList", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    response.DefaultList = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("defaultLong", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    response.DefaultLong = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("defaultMap", targetDepth))
                {
                    var unmarshaller = new DictionaryUnmarshaller<string, string, StringUnmarshaller, StringUnmarshaller>(StringUnmarshaller.Instance, StringUnmarshaller.Instance);
                    response.DefaultMap = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("defaultNullDocument", targetDepth))
                {
                    var unmarshaller = Amazon.Runtime.Documents.Internal.Transform.DocumentUnmarshaller.Instance;
                    response.DefaultNullDocument = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("defaultShort", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    response.DefaultShort = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("defaultString", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.DefaultString = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("defaultTimestamp", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    response.DefaultTimestamp = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("emptyBlob", targetDepth))
                {
                    var unmarshaller = MemoryStreamUnmarshaller.Instance;
                    response.EmptyBlob = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("emptyString", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.EmptyString = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("falseBoolean", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    response.FalseBoolean = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("zeroByte", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    response.ZeroByte = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("zeroDouble", targetDepth))
                {
                    var unmarshaller = DoubleUnmarshaller.Instance;
                    response.ZeroDouble = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("zeroFloat", targetDepth))
                {
                    var unmarshaller = FloatUnmarshaller.Instance;
                    response.ZeroFloat = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("zeroInteger", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    response.ZeroInteger = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("zeroLong", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    response.ZeroLong = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("zeroShort", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    response.ZeroShort = unmarshaller.Unmarshall(context);
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

        private static OperationWithDefaultsResponseUnmarshaller _instance = new OperationWithDefaultsResponseUnmarshaller();        

        internal static OperationWithDefaultsResponseUnmarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static OperationWithDefaultsResponseUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}