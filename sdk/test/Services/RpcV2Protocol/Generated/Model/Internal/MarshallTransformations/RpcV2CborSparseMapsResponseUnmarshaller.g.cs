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
    /// Response Unmarshaller for RpcV2CborSparseMaps operation.
    /// </summary>
    public partial class RpcV2CborSparseMapsResponseUnmarshaller : CborResponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>
        public override AmazonWebServiceResponse Unmarshall(CborUnmarshallerContext context)
        {
            var unmarshalledObject = new RpcV2CborSparseMapsResponse();
            var reader = context.Reader;

            context.AddPathSegment("RpcV2CborSparseMaps");
            reader.ReadStartMap();
            while (reader.PeekState() != CborReaderState.EndMap)
            {
                var propertyName = reader.ReadTextString();
                switch (propertyName)
                {
                    case "sparseBooleanMap":
                        context.AddPathSegment("SparseBooleanMap");
                        unmarshalledObject.SparseBooleanMap = new CborDictionaryUnmarshaller<string, bool?, CborStringUnmarshaller, CborNullableBoolUnmarshaller>(CborStringUnmarshaller.Instance, CborNullableBoolUnmarshaller.Instance).Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "sparseNumberMap":
                        context.AddPathSegment("SparseNumberMap");
                        unmarshalledObject.SparseNumberMap = new CborDictionaryUnmarshaller<string, int?, CborStringUnmarshaller, CborNullableIntUnmarshaller>(CborStringUnmarshaller.Instance, CborNullableIntUnmarshaller.Instance).Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "sparseSetMap":
                        context.AddPathSegment("SparseSetMap");
                        unmarshalledObject.SparseSetMap = new CborDictionaryUnmarshaller<string, List<string>, CborStringUnmarshaller, CborListUnmarshaller<string, CborStringUnmarshaller>>(CborStringUnmarshaller.Instance, new CborListUnmarshaller<string, CborStringUnmarshaller>(CborStringUnmarshaller.Instance)).Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "sparseStringMap":
                        context.AddPathSegment("SparseStringMap");
                        unmarshalledObject.SparseStringMap = new CborDictionaryUnmarshaller<string, string, CborStringUnmarshaller, CborStringUnmarshaller>(CborStringUnmarshaller.Instance, CborStringUnmarshaller.Instance).Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "sparseStructMap":
                        context.AddPathSegment("SparseStructMap");
                        unmarshalledObject.SparseStructMap = new CborDictionaryUnmarshaller<string, GreetingStruct, CborStringUnmarshaller, GreetingStructUnmarshaller>(CborStringUnmarshaller.Instance, GreetingStructUnmarshaller.Instance).Unmarshall(context);
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
                    if (errorResponse.Code != null && errorResponse.Code.Equals("ValidationException"))
                    {
                        return ValidationExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                    }
                }
            }
            return new AmazonRpcV2ProtocolException(errorResponse.Message, errorResponse.InnerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, errorResponse.StatusCode);
        }

        private static RpcV2CborSparseMapsResponseUnmarshaller _instance = new RpcV2CborSparseMapsResponseUnmarshaller();

        internal static RpcV2CborSparseMapsResponseUnmarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static RpcV2CborSparseMapsResponseUnmarshaller Instance => _instance;
    }
}
