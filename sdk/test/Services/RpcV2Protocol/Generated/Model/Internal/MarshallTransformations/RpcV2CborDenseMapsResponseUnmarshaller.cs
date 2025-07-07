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
 * Do not modify this file. This file is generated from the rpcv2protocol-2020-07-14.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.RpcV2Protocol.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
using Amazon.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.RpcV2Protocol.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for RpcV2CborDenseMaps operation
    /// </summary>  
    public class RpcV2CborDenseMapsResponseUnmarshaller : JsonResponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
        {
            RpcV2CborDenseMapsResponse response = new RpcV2CborDenseMapsResponse();
            StreamingUtf8JsonReader reader = new StreamingUtf8JsonReader(context.Stream);
            context.Read(ref reader);
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("denseBooleanMap", targetDepth))
                {
                    var unmarshaller = new JsonDictionaryUnmarshaller<string, bool, StringUnmarshaller, BoolUnmarshaller>(StringUnmarshaller.Instance, BoolUnmarshaller.Instance);
                    response.DenseBooleanMap = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("denseNumberMap", targetDepth))
                {
                    var unmarshaller = new JsonDictionaryUnmarshaller<string, int, StringUnmarshaller, IntUnmarshaller>(StringUnmarshaller.Instance, IntUnmarshaller.Instance);
                    response.DenseNumberMap = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("denseSetMap", targetDepth))
                {
                    var unmarshaller = new JsonDictionaryUnmarshaller<string, List<string>, StringUnmarshaller, JsonListUnmarshaller<string,StringUnmarshaller>>(StringUnmarshaller.Instance, new JsonListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance));
                    response.DenseSetMap = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("denseStringMap", targetDepth))
                {
                    var unmarshaller = new JsonDictionaryUnmarshaller<string, string, StringUnmarshaller, StringUnmarshaller>(StringUnmarshaller.Instance, StringUnmarshaller.Instance);
                    response.DenseStringMap = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("denseStructMap", targetDepth))
                {
                    var unmarshaller = new JsonDictionaryUnmarshaller<string, GreetingStruct, StringUnmarshaller, GreetingStructUnmarshaller>(StringUnmarshaller.Instance, GreetingStructUnmarshaller.Instance);
                    response.DenseStructMap = unmarshaller.Unmarshall(context, ref reader);
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
            StreamingUtf8JsonReader reader = new StreamingUtf8JsonReader(context.Stream);
            var errorResponse = JsonErrorResponseUnmarshaller.GetInstance().Unmarshall(context, ref reader);
            errorResponse.InnerException = innerException;
            errorResponse.StatusCode = statusCode;

            var responseBodyBytes = context.GetResponseBodyBytes();

            using (var streamCopy = new MemoryStream(responseBodyBytes))
            using (var contextCopy = new JsonUnmarshallerContext(streamCopy, false, context.ResponseData))
            {
                StreamingUtf8JsonReader readerCopy = new StreamingUtf8JsonReader(streamCopy);
                if (errorResponse.Code != null && errorResponse.Code.Equals("ValidationException"))
                {
                    return ValidationExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse, ref readerCopy);
                }
            }
            return new AmazonRpcV2ProtocolException(errorResponse.Message, errorResponse.InnerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, errorResponse.StatusCode);
        }

        private static RpcV2CborDenseMapsResponseUnmarshaller _instance = new RpcV2CborDenseMapsResponseUnmarshaller();        

        internal static RpcV2CborDenseMapsResponseUnmarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static RpcV2CborDenseMapsResponseUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}