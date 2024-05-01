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
 * Do not modify this file. This file is generated from the json-protocol-2018-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.JsonProtocol.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.JsonProtocol.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for KitchenSinkOperation operation
    /// </summary>  
    public class KitchenSinkOperationResponseUnmarshaller : JsonResponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
        {
            KitchenSinkOperationResponse response = new KitchenSinkOperationResponse();

            context.Read();
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("Blob", targetDepth))
                {
                    var unmarshaller = MemoryStreamUnmarshaller.Instance;
                    response.Blob = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Boolean", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    response.Boolean = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Double", targetDepth))
                {
                    var unmarshaller = DoubleUnmarshaller.Instance;
                    response.Double = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("EmptyStruct", targetDepth))
                {
                    var unmarshaller = EmptyStructUnmarshaller.Instance;
                    response.EmptyStruct = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Float", targetDepth))
                {
                    var unmarshaller = FloatUnmarshaller.Instance;
                    response.Float = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("HttpdateTimestamp", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    response.HttpdateTimestamp = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Integer", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    response.Integer = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Iso8601Timestamp", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    response.Iso8601Timestamp = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("JsonValue", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.JsonValue = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ListOfLists", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<List<string>, ListUnmarshaller<string, StringUnmarshaller>>(new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance));
                    response.ListOfLists = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ListOfMapsOfStrings", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<Dictionary<string, string>, DictionaryUnmarshaller<string, string, StringUnmarshaller, StringUnmarshaller>>(new DictionaryUnmarshaller<string, string, StringUnmarshaller, StringUnmarshaller>(StringUnmarshaller.Instance, StringUnmarshaller.Instance));
                    response.ListOfMapsOfStrings = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ListOfStrings", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    response.ListOfStrings = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ListOfStructs", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<SimpleStruct, SimpleStructUnmarshaller>(SimpleStructUnmarshaller.Instance);
                    response.ListOfStructs = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Long", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    response.Long = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("MapOfListsOfStrings", targetDepth))
                {
                    var unmarshaller = new DictionaryUnmarshaller<string, List<string>, StringUnmarshaller, ListUnmarshaller<string, StringUnmarshaller>>(StringUnmarshaller.Instance, new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance));
                    response.MapOfListsOfStrings = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("MapOfMaps", targetDepth))
                {
                    var unmarshaller = new DictionaryUnmarshaller<string, Dictionary<string, string>, StringUnmarshaller, DictionaryUnmarshaller<string, string, StringUnmarshaller, StringUnmarshaller>>(StringUnmarshaller.Instance, new DictionaryUnmarshaller<string, string, StringUnmarshaller, StringUnmarshaller>(StringUnmarshaller.Instance, StringUnmarshaller.Instance));
                    response.MapOfMaps = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("MapOfStrings", targetDepth))
                {
                    var unmarshaller = new DictionaryUnmarshaller<string, string, StringUnmarshaller, StringUnmarshaller>(StringUnmarshaller.Instance, StringUnmarshaller.Instance);
                    response.MapOfStrings = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("MapOfStructs", targetDepth))
                {
                    var unmarshaller = new DictionaryUnmarshaller<string, SimpleStruct, StringUnmarshaller, SimpleStructUnmarshaller>(StringUnmarshaller.Instance, SimpleStructUnmarshaller.Instance);
                    response.MapOfStructs = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("RecursiveList", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<KitchenSink, KitchenSinkUnmarshaller>(KitchenSinkUnmarshaller.Instance);
                    response.RecursiveList = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("RecursiveMap", targetDepth))
                {
                    var unmarshaller = new DictionaryUnmarshaller<string, KitchenSink, StringUnmarshaller, KitchenSinkUnmarshaller>(StringUnmarshaller.Instance, KitchenSinkUnmarshaller.Instance);
                    response.RecursiveMap = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("RecursiveStruct", targetDepth))
                {
                    var unmarshaller = KitchenSinkUnmarshaller.Instance;
                    response.RecursiveStruct = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SimpleStruct", targetDepth))
                {
                    var unmarshaller = SimpleStructUnmarshaller.Instance;
                    response.SimpleStruct = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("String", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.String = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("StructWithJsonName", targetDepth))
                {
                    var unmarshaller = StructWithJsonNameUnmarshaller.Instance;
                    response.StructWithJsonName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Timestamp", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    response.Timestamp = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("UnixTimestamp", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    response.UnixTimestamp = unmarshaller.Unmarshall(context);
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
                if (errorResponse.Code != null && errorResponse.Code.Equals("ErrorWithMembers"))
                {
                    return ErrorWithMembersExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("ErrorWithoutMembers"))
                {
                    return ErrorWithoutMembersExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
            }
            return new AmazonJsonProtocolException(errorResponse.Message, errorResponse.InnerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, errorResponse.StatusCode);
        }

        private static KitchenSinkOperationResponseUnmarshaller _instance = new KitchenSinkOperationResponseUnmarshaller();        

        internal static KitchenSinkOperationResponseUnmarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static KitchenSinkOperationResponseUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}