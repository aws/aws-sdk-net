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

using Amazon.RpcV2Protocol.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Formats.Cbor;
using Amazon.Extensions.CborProtocol.Internal.Transform;

#pragma warning disable CS0612,CS0618

namespace Amazon.RpcV2Protocol.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for SimpleScalarProperties operation.
    /// </summary>
    public partial class SimpleScalarPropertiesResponseUnmarshaller : CborResponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>
        public override AmazonWebServiceResponse Unmarshall(CborUnmarshallerContext context)
        {
            var unmarshalledObject = new SimpleScalarPropertiesResponse();
            var reader = context.Reader;

            context.AddPathSegment("SimpleScalarProperties");
            reader.ReadStartMap();
            while (reader.PeekState() != CborReaderState.EndMap)
            {
                var propertyName = reader.ReadTextString();
                switch (propertyName)
                {
                    case "blobValue":
                        context.AddPathSegment("BlobValue");
                        unmarshalledObject.BlobValue = CborMemoryStreamUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "byteValue":
                        context.AddPathSegment("ByteValue");
                        unmarshalledObject.ByteValue = CborNullableIntUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "doubleValue":
                        context.AddPathSegment("DoubleValue");
                        unmarshalledObject.DoubleValue = CborNullableDoubleUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "falseBooleanValue":
                        context.AddPathSegment("FalseBooleanValue");
                        unmarshalledObject.FalseBooleanValue = CborNullableBoolUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "floatValue":
                        context.AddPathSegment("FloatValue");
                        unmarshalledObject.FloatValue = CborNullableFloatUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "integerValue":
                        context.AddPathSegment("IntegerValue");
                        unmarshalledObject.IntegerValue = CborNullableIntUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "longValue":
                        context.AddPathSegment("LongValue");
                        unmarshalledObject.LongValue = CborNullableLongUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "shortValue":
                        context.AddPathSegment("ShortValue");
                        unmarshalledObject.ShortValue = CborNullableIntUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "stringValue":
                        context.AddPathSegment("StringValue");
                        unmarshalledObject.StringValue = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "trueBooleanValue":
                        context.AddPathSegment("TrueBooleanValue");
                        unmarshalledObject.TrueBooleanValue = CborNullableBoolUnmarshaller.Instance.Unmarshall(context);
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
            return new AmazonRpcV2ProtocolException(errorResponse.Message, errorResponse.InnerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, errorResponse.StatusCode);
        }

        private static SimpleScalarPropertiesResponseUnmarshaller _instance = new SimpleScalarPropertiesResponseUnmarshaller();

        internal static SimpleScalarPropertiesResponseUnmarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static SimpleScalarPropertiesResponseUnmarshaller Instance => _instance;
    }
}
