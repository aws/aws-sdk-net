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
 * Do not modify this file. This file is generated from the numerictypesrestjson-2026-10-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.NumericTypesRestJson.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
using Amazon.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.NumericTypesRestJson.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for BodyNumbers operation
    /// </summary>  
    public class BodyNumbersResponseUnmarshaller : JsonResponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
        {
            BodyNumbersResponse response = new BodyNumbersResponse();
            StreamingUtf8JsonReader reader = new StreamingUtf8JsonReader(context.Stream, AWSConfigs.StreamingUtf8JsonReaderBufferSize ?? 4096, context.JsonMaxDepth);
            context.Read(ref reader);
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("BigDecimalList", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<Amazon.Extensions.Numerics.BigDecimal, BigDecimalUnmarshaller>(BigDecimalUnmarshaller.Instance);
                    response.BigDecimalList = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("BigDecimalMap", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonDictionaryUnmarshaller<string, Amazon.Extensions.Numerics.BigDecimal, StringUnmarshaller, BigDecimalUnmarshaller>(StringUnmarshaller.Instance, BigDecimalUnmarshaller.Instance);
                    response.BigDecimalMap = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("BigDecimalValue", targetDepth, ref reader))
                {
                    var unmarshaller = NullableBigDecimalUnmarshaller.Instance;
                    response.BigDecimalValue = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("BigIntegerList", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<System.Numerics.BigInteger, BigIntegerUnmarshaller>(BigIntegerUnmarshaller.Instance);
                    response.BigIntegerList = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("BigIntegerMap", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonDictionaryUnmarshaller<string, System.Numerics.BigInteger, StringUnmarshaller, BigIntegerUnmarshaller>(StringUnmarshaller.Instance, BigIntegerUnmarshaller.Instance);
                    response.BigIntegerMap = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("BigIntegerValue", targetDepth, ref reader))
                {
                    var unmarshaller = NullableBigIntegerUnmarshaller.Instance;
                    response.BigIntegerValue = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ByteList", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<sbyte, SByteUnmarshaller>(SByteUnmarshaller.Instance);
                    response.ByteList = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ByteMap", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonDictionaryUnmarshaller<string, sbyte, StringUnmarshaller, SByteUnmarshaller>(StringUnmarshaller.Instance, SByteUnmarshaller.Instance);
                    response.ByteMap = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ByteValue", targetDepth, ref reader))
                {
                    var unmarshaller = NullableSByteUnmarshaller.Instance;
                    response.ByteValue = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Nested", targetDepth, ref reader))
                {
                    var unmarshaller = NestedNumbersUnmarshaller.Instance;
                    response.Nested = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("NestedList", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<NestedNumbers, NestedNumbersUnmarshaller>(NestedNumbersUnmarshaller.Instance);
                    response.NestedList = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ShortList", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<short, ShortUnmarshaller>(ShortUnmarshaller.Instance);
                    response.ShortList = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ShortMap", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonDictionaryUnmarshaller<string, short, StringUnmarshaller, ShortUnmarshaller>(StringUnmarshaller.Instance, ShortUnmarshaller.Instance);
                    response.ShortMap = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ShortValue", targetDepth, ref reader))
                {
                    var unmarshaller = NullableShortUnmarshaller.Instance;
                    response.ShortValue = unmarshaller.Unmarshall(context, ref reader);
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
            StreamingUtf8JsonReader reader = new StreamingUtf8JsonReader(context.Stream, AWSConfigs.StreamingUtf8JsonReaderBufferSize ?? 4096, context.JsonMaxDepth);
            var errorResponse = JsonErrorResponseUnmarshaller.GetInstance().Unmarshall(context, ref reader);
            errorResponse.InnerException = innerException;
            errorResponse.StatusCode = statusCode;

            var responseBodyBytes = context.GetResponseBodyBytes();

            using (var streamCopy = new MemoryStream(responseBodyBytes))
            using (var contextCopy = new JsonUnmarshallerContext(streamCopy, false, context.ResponseData))
            {
                StreamingUtf8JsonReader readerCopy = new StreamingUtf8JsonReader(streamCopy, AWSConfigs.StreamingUtf8JsonReaderBufferSize ?? 4096, context.JsonMaxDepth);
            }
            return new AmazonNumericTypesRestJsonException(errorResponse.Message, errorResponse.InnerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, errorResponse.StatusCode);
        }

        private static BodyNumbersResponseUnmarshaller _instance = new BodyNumbersResponseUnmarshaller();        

        internal static BodyNumbersResponseUnmarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static BodyNumbersResponseUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}