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
    /// Response Unmarshaller for RpcV2CborDenseMaps operation
    /// </summary>  
    public class RpcV2CborDenseMapsResponseUnmarshaller : CborResponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public override AmazonWebServiceResponse Unmarshall(CborUnmarshallerContext context)
        {
            RpcV2CborDenseMapsResponse response = new RpcV2CborDenseMapsResponse();
            var reader = context.Reader;
            context.AddPathSegment("RpcV2CborDenseMaps");
            reader.ReadStartMap();
            while (reader.PeekState() != CborReaderState.EndMap)
            {
                string propertyName = reader.ReadTextString();
                switch (propertyName)
                {
                    case "denseBooleanMap":
                        {
                            context.AddPathSegment("DenseBooleanMap");
                            var unmarshaller = new CborDictionaryUnmarshaller<string, bool, CborStringUnmarshaller, CborBoolUnmarshaller>(CborStringUnmarshaller.Instance, CborBoolUnmarshaller.Instance);
                            response.DenseBooleanMap = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "denseNumberMap":
                        {
                            context.AddPathSegment("DenseNumberMap");
                            var unmarshaller = new CborDictionaryUnmarshaller<string, int, CborStringUnmarshaller, CborIntUnmarshaller>(CborStringUnmarshaller.Instance, CborIntUnmarshaller.Instance);
                            response.DenseNumberMap = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "denseSetMap":
                        {
                            context.AddPathSegment("DenseSetMap");
                            var unmarshaller = new CborDictionaryUnmarshaller<string, List<string>, CborStringUnmarshaller, CborListUnmarshaller<string, CborStringUnmarshaller>>(CborStringUnmarshaller.Instance, new CborListUnmarshaller<string, CborStringUnmarshaller>(CborStringUnmarshaller.Instance));
                            response.DenseSetMap = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "denseStringMap":
                        {
                            context.AddPathSegment("DenseStringMap");
                            var unmarshaller = new CborDictionaryUnmarshaller<string, string, CborStringUnmarshaller, CborStringUnmarshaller>(CborStringUnmarshaller.Instance, CborStringUnmarshaller.Instance);
                            response.DenseStringMap = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "denseStructMap":
                        {
                            context.AddPathSegment("DenseStructMap");
                            var unmarshaller = new CborDictionaryUnmarshaller<string, GreetingStruct, CborStringUnmarshaller, GreetingStructUnmarshaller>(CborStringUnmarshaller.Instance, GreetingStructUnmarshaller.Instance);
                            response.DenseStructMap = unmarshaller.Unmarshall(context);
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
                if (errorResponse.Code != null && errorResponse.Code.Equals("ValidationException"))
                {
                    return ValidationExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
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