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
using Amazon.Util;
using System.Formats.Cbor;
using Amazon.Extensions.CborProtocol.Internal.Transform;

#pragma warning disable CS0612,CS0618
namespace Amazon.RpcV2Protocol.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for SimpleScalarProperties operation
    /// </summary>  
    public class SimpleScalarPropertiesResponseUnmarshaller : CborResponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public override AmazonWebServiceResponse Unmarshall(CborUnmarshallerContext context)
        {
            SimpleScalarPropertiesResponse response = new SimpleScalarPropertiesResponse();
            var reader = context.Reader;
            context.AddPathSegment("SimpleScalarProperties");
            reader.ReadStartMap();
            while (reader.PeekState() != CborReaderState.EndMap)
            {
                string propertyName = reader.ReadTextString();
                switch (propertyName)
                {
                    case "blobValue":
                        {
                            context.AddPathSegment("BlobValue");
                            var unmarshaller = CborMemoryStreamUnmarshaller.Instance;
                            response.BlobValue = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "byteValue":
                        {
                            context.AddPathSegment("ByteValue");
                            var unmarshaller = CborNullableIntUnmarshaller.Instance;
                            response.ByteValue = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "doubleValue":
                        {
                            context.AddPathSegment("DoubleValue");
                            var unmarshaller = CborNullableDoubleUnmarshaller.Instance;
                            response.DoubleValue = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "falseBooleanValue":
                        {
                            context.AddPathSegment("FalseBooleanValue");
                            var unmarshaller = CborNullableBoolUnmarshaller.Instance;
                            response.FalseBooleanValue = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "floatValue":
                        {
                            context.AddPathSegment("FloatValue");
                            var unmarshaller = CborNullableFloatUnmarshaller.Instance;
                            response.FloatValue = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "integerValue":
                        {
                            context.AddPathSegment("IntegerValue");
                            var unmarshaller = CborNullableIntUnmarshaller.Instance;
                            response.IntegerValue = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "longValue":
                        {
                            context.AddPathSegment("LongValue");
                            var unmarshaller = CborNullableLongUnmarshaller.Instance;
                            response.LongValue = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "shortValue":
                        {
                            context.AddPathSegment("ShortValue");
                            var unmarshaller = CborNullableIntUnmarshaller.Instance;
                            response.ShortValue = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "stringValue":
                        {
                            context.AddPathSegment("StringValue");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            response.StringValue = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "trueBooleanValue":
                        {
                            context.AddPathSegment("TrueBooleanValue");
                            var unmarshaller = CborNullableBoolUnmarshaller.Instance;
                            response.TrueBooleanValue = unmarshaller.Unmarshall(context);
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
            return new AmazonRpcV2ProtocolException(errorResponse.Message, errorResponse.InnerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, errorResponse.StatusCode);
        }

        private static SimpleScalarPropertiesResponseUnmarshaller _instance = new SimpleScalarPropertiesResponseUnmarshaller();        

        internal static SimpleScalarPropertiesResponseUnmarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static SimpleScalarPropertiesResponseUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}