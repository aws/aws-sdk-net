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
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

using Amazon.NumericTypesCbor.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Formats.Cbor;
using Amazon.Extensions.CborProtocol.Internal.Transform;

#pragma warning disable CS0612,CS0618

namespace Amazon.NumericTypesCbor.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for BodyNumbers operation.
    /// </summary>
    public partial class BodyNumbersResponseUnmarshaller : CborResponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>
        public override AmazonWebServiceResponse Unmarshall(CborUnmarshallerContext context)
        {
            var unmarshalledObject = new BodyNumbersResponse();
            var reader = context.Reader;

            context.AddPathSegment("BodyNumbers");
            reader.ReadStartMap();
            while (reader.PeekState() != CborReaderState.EndMap)
            {
                var propertyName = reader.ReadTextString();
                switch (propertyName)
                {
                    case "BigDecimalList":
                        context.AddPathSegment("BigDecimalList");
                        unmarshalledObject.BigDecimalList = new CborListUnmarshaller<Amazon.Extensions.Numerics.BigDecimal, CborBigDecimalUnmarshaller>(CborBigDecimalUnmarshaller.Instance).Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "BigDecimalMap":
                        context.AddPathSegment("BigDecimalMap");
                        unmarshalledObject.BigDecimalMap = new CborDictionaryUnmarshaller<string, Amazon.Extensions.Numerics.BigDecimal, CborStringUnmarshaller, CborBigDecimalUnmarshaller>(CborStringUnmarshaller.Instance, CborBigDecimalUnmarshaller.Instance).Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "BigDecimalValue":
                        context.AddPathSegment("BigDecimalValue");
                        unmarshalledObject.BigDecimalValue = CborNullableBigDecimalUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "BigIntegerList":
                        context.AddPathSegment("BigIntegerList");
                        unmarshalledObject.BigIntegerList = new CborListUnmarshaller<System.Numerics.BigInteger, CborBigIntegerUnmarshaller>(CborBigIntegerUnmarshaller.Instance).Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "BigIntegerMap":
                        context.AddPathSegment("BigIntegerMap");
                        unmarshalledObject.BigIntegerMap = new CborDictionaryUnmarshaller<string, System.Numerics.BigInteger, CborStringUnmarshaller, CborBigIntegerUnmarshaller>(CborStringUnmarshaller.Instance, CborBigIntegerUnmarshaller.Instance).Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "BigIntegerValue":
                        context.AddPathSegment("BigIntegerValue");
                        unmarshalledObject.BigIntegerValue = CborNullableBigIntegerUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "ByteList":
                        context.AddPathSegment("ByteList");
                        unmarshalledObject.ByteList = new CborListUnmarshaller<sbyte, CborSByteUnmarshaller>(CborSByteUnmarshaller.Instance).Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "ByteMap":
                        context.AddPathSegment("ByteMap");
                        unmarshalledObject.ByteMap = new CborDictionaryUnmarshaller<string, sbyte, CborStringUnmarshaller, CborSByteUnmarshaller>(CborStringUnmarshaller.Instance, CborSByteUnmarshaller.Instance).Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "ByteValue":
                        context.AddPathSegment("ByteValue");
                        unmarshalledObject.ByteValue = CborNullableSByteUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "Nested":
                        context.AddPathSegment("Nested");
                        unmarshalledObject.Nested = NestedNumbersUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "NestedList":
                        context.AddPathSegment("NestedList");
                        unmarshalledObject.NestedList = new CborListUnmarshaller<NestedNumbers, NestedNumbersUnmarshaller>(NestedNumbersUnmarshaller.Instance).Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "ShortList":
                        context.AddPathSegment("ShortList");
                        unmarshalledObject.ShortList = new CborListUnmarshaller<short, CborShortUnmarshaller>(CborShortUnmarshaller.Instance).Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "ShortMap":
                        context.AddPathSegment("ShortMap");
                        unmarshalledObject.ShortMap = new CborDictionaryUnmarshaller<string, short, CborStringUnmarshaller, CborShortUnmarshaller>(CborStringUnmarshaller.Instance, CborShortUnmarshaller.Instance).Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "ShortValue":
                        context.AddPathSegment("ShortValue");
                        unmarshalledObject.ShortValue = CborNullableShortUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    default:
                        reader.SkipValue();
                        break;
                }
            }
            reader.ReadEndMap();
            context.PopPathSegment();

            return unmarshalledObject;
        }

        /// <summary>
        /// Unmarshall error response to exception.
        /// </summary>
        public override AmazonServiceException UnmarshallException(CborUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
        {
            var errorResponse = CborErrorResponseUnmarshaller.GetInstance().Unmarshall(context);
            errorResponse.InnerException = innerException;
            errorResponse.StatusCode = statusCode;

            var responseBodyBytes = context.GetResponseBodyBytes();

            using (var streamCopy = new MemoryStream(responseBodyBytes))
            {
                using (var contextCopy = new CborUnmarshallerContext(streamCopy, false, context.ResponseData))
                {
                }
            }
            return new AmazonNumericTypesCborException(errorResponse.Message, errorResponse.InnerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, errorResponse.StatusCode);
        }

        private static BodyNumbersResponseUnmarshaller _instance = new BodyNumbersResponseUnmarshaller();

        internal static BodyNumbersResponseUnmarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static BodyNumbersResponseUnmarshaller Instance => _instance;
    }
}
