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
 * Do not modify this file. This file is generated from the numerictypescbor-2026-10-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.NumericTypesCbor.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using Amazon.Util;
using System.Formats.Cbor;
using Amazon.Extensions.CborProtocol.Internal.Transform;

#pragma warning disable CS0612,CS0618
namespace Amazon.NumericTypesCbor.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for BodyNumbers operation
    /// </summary>  
    public class BodyNumbersResponseUnmarshaller : CborResponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public override AmazonWebServiceResponse Unmarshall(CborUnmarshallerContext context)
        {
            BodyNumbersResponse response = new BodyNumbersResponse();
            var reader = context.Reader;
            context.AddPathSegment("BodyNumbers");
            reader.ReadStartMap();
            while (reader.PeekState() != CborReaderState.EndMap)
            {
                string propertyName = reader.ReadTextString();
                switch (propertyName)
                {
                    case "BigDecimalList":
                        {
                            context.AddPathSegment("BigDecimalList");
                            var unmarshaller = new CborListUnmarshaller<Amazon.Extensions.Numerics.BigDecimal, CborBigDecimalUnmarshaller>(CborBigDecimalUnmarshaller.Instance);
                            response.BigDecimalList = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "BigDecimalMap":
                        {
                            context.AddPathSegment("BigDecimalMap");
                            var unmarshaller = new CborDictionaryUnmarshaller<string, Amazon.Extensions.Numerics.BigDecimal, CborStringUnmarshaller, CborBigDecimalUnmarshaller>(CborStringUnmarshaller.Instance, CborBigDecimalUnmarshaller.Instance);
                            response.BigDecimalMap = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "BigDecimalValue":
                        {
                            context.AddPathSegment("BigDecimalValue");
                            var unmarshaller = CborNullableBigDecimalUnmarshaller.Instance;
                            response.BigDecimalValue = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "BigIntegerList":
                        {
                            context.AddPathSegment("BigIntegerList");
                            var unmarshaller = new CborListUnmarshaller<System.Numerics.BigInteger, CborBigIntegerUnmarshaller>(CborBigIntegerUnmarshaller.Instance);
                            response.BigIntegerList = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "BigIntegerMap":
                        {
                            context.AddPathSegment("BigIntegerMap");
                            var unmarshaller = new CborDictionaryUnmarshaller<string, System.Numerics.BigInteger, CborStringUnmarshaller, CborBigIntegerUnmarshaller>(CborStringUnmarshaller.Instance, CborBigIntegerUnmarshaller.Instance);
                            response.BigIntegerMap = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "BigIntegerValue":
                        {
                            context.AddPathSegment("BigIntegerValue");
                            var unmarshaller = CborNullableBigIntegerUnmarshaller.Instance;
                            response.BigIntegerValue = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "ByteList":
                        {
                            context.AddPathSegment("ByteList");
                            var unmarshaller = new CborListUnmarshaller<sbyte, CborSByteUnmarshaller>(CborSByteUnmarshaller.Instance);
                            response.ByteList = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "ByteMap":
                        {
                            context.AddPathSegment("ByteMap");
                            var unmarshaller = new CborDictionaryUnmarshaller<string, sbyte, CborStringUnmarshaller, CborSByteUnmarshaller>(CborStringUnmarshaller.Instance, CborSByteUnmarshaller.Instance);
                            response.ByteMap = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "ByteValue":
                        {
                            context.AddPathSegment("ByteValue");
                            var unmarshaller = CborNullableSByteUnmarshaller.Instance;
                            response.ByteValue = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "Nested":
                        {
                            context.AddPathSegment("Nested");
                            var unmarshaller = NestedNumbersUnmarshaller.Instance;
                            response.Nested = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "NestedList":
                        {
                            context.AddPathSegment("NestedList");
                            var unmarshaller = new CborListUnmarshaller<NestedNumbers, NestedNumbersUnmarshaller>(NestedNumbersUnmarshaller.Instance);
                            response.NestedList = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "ShortList":
                        {
                            context.AddPathSegment("ShortList");
                            var unmarshaller = new CborListUnmarshaller<short, CborShortUnmarshaller>(CborShortUnmarshaller.Instance);
                            response.ShortList = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "ShortMap":
                        {
                            context.AddPathSegment("ShortMap");
                            var unmarshaller = new CborDictionaryUnmarshaller<string, short, CborStringUnmarshaller, CborShortUnmarshaller>(CborStringUnmarshaller.Instance, CborShortUnmarshaller.Instance);
                            response.ShortMap = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "ShortValue":
                        {
                            context.AddPathSegment("ShortValue");
                            var unmarshaller = CborNullableShortUnmarshaller.Instance;
                            response.ShortValue = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    default:
                        reader.SkipValue();
                        break;
                }
            }
            reader.ReadEndMap();
            context.PopPathSegment();

            return response;
        }

        /// <summary>
        /// Unmarshaller error response to exception.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="innerException"></param>
        /// <param name="statusCode"></param>
        /// <returns></returns>
        public override AmazonServiceException UnmarshallException(CborUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
        {
            var errorResponse = CborErrorResponseUnmarshaller.GetInstance().Unmarshall(context);
            errorResponse.InnerException = innerException;
            errorResponse.StatusCode = statusCode;

            var responseBodyBytes = context.GetResponseBodyBytes();

            using (var streamCopy = new MemoryStream(responseBodyBytes))
            using (var contextCopy = new CborUnmarshallerContext(streamCopy, false, context.ResponseData))
            {
            }
            return new AmazonNumericTypesCborException(errorResponse.Message, errorResponse.InnerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, errorResponse.StatusCode);
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