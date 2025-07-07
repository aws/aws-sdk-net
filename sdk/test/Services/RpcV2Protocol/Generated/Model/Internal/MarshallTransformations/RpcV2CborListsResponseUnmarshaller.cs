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
    /// Response Unmarshaller for RpcV2CborLists operation
    /// </summary>  
    public class RpcV2CborListsResponseUnmarshaller : JsonResponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
        {
            RpcV2CborListsResponse response = new RpcV2CborListsResponse();
            StreamingUtf8JsonReader reader = new StreamingUtf8JsonReader(context.Stream);
            context.Read(ref reader);
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("blobList", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<MemoryStream, MemoryStreamUnmarshaller>(MemoryStreamUnmarshaller.Instance);
                    response.BlobList = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("booleanList", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<bool, BoolUnmarshaller>(BoolUnmarshaller.Instance);
                    response.BooleanList = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("enumList", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    response.EnumList = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("integerList", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<int, IntUnmarshaller>(IntUnmarshaller.Instance);
                    response.IntegerList = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("intEnumList", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<int, IntUnmarshaller>(IntUnmarshaller.Instance);
                    response.IntEnumList = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("nestedStringList", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<List<string>, JsonListUnmarshaller<string,StringUnmarshaller>>(new JsonListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance));
                    response.NestedStringList = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("stringList", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    response.StringList = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("stringSet", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    response.StringSet = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("structureList", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<StructureListMember, StructureListMemberUnmarshaller>(StructureListMemberUnmarshaller.Instance);
                    response.StructureList = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("timestampList", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<DateTime, DateTimeUnmarshaller>(DateTimeUnmarshaller.Instance);
                    response.TimestampList = unmarshaller.Unmarshall(context, ref reader);
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

        private static RpcV2CborListsResponseUnmarshaller _instance = new RpcV2CborListsResponseUnmarshaller();        

        internal static RpcV2CborListsResponseUnmarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static RpcV2CborListsResponseUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}