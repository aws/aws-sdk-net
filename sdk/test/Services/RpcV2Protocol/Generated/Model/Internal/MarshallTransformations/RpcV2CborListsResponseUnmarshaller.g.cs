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
    /// Response Unmarshaller for RpcV2CborLists operation.
    /// </summary>
    public partial class RpcV2CborListsResponseUnmarshaller : CborResponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>
        public override AmazonWebServiceResponse Unmarshall(CborUnmarshallerContext context)
        {
            var unmarshalledObject = new RpcV2CborListsResponse();
            var reader = context.Reader;

            context.AddPathSegment("RpcV2CborLists");
            reader.ReadStartMap();
            while (reader.PeekState() != CborReaderState.EndMap)
            {
                var propertyName = reader.ReadTextString();
                switch (propertyName)
                {
                    case "blobList":
                        context.AddPathSegment("BlobList");
                        unmarshalledObject.BlobList = new CborListUnmarshaller<MemoryStream, CborMemoryStreamUnmarshaller>(CborMemoryStreamUnmarshaller.Instance).Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "booleanList":
                        context.AddPathSegment("BooleanList");
                        unmarshalledObject.BooleanList = new CborListUnmarshaller<bool, CborBoolUnmarshaller>(CborBoolUnmarshaller.Instance).Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "enumList":
                        context.AddPathSegment("EnumList");
                        unmarshalledObject.EnumList = new CborListUnmarshaller<string, CborStringUnmarshaller>(CborStringUnmarshaller.Instance).Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "intEnumList":
                        context.AddPathSegment("IntEnumList");
                        unmarshalledObject.IntEnumList = new CborListUnmarshaller<int, CborIntUnmarshaller>(CborIntUnmarshaller.Instance).Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "integerList":
                        context.AddPathSegment("IntegerList");
                        unmarshalledObject.IntegerList = new CborListUnmarshaller<int, CborIntUnmarshaller>(CborIntUnmarshaller.Instance).Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "nestedStringList":
                        context.AddPathSegment("NestedStringList");
                        unmarshalledObject.NestedStringList = new CborListUnmarshaller<List<string>, CborListUnmarshaller<string, CborStringUnmarshaller>>(new CborListUnmarshaller<string, CborStringUnmarshaller>(CborStringUnmarshaller.Instance)).Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "stringList":
                        context.AddPathSegment("StringList");
                        unmarshalledObject.StringList = new CborListUnmarshaller<string, CborStringUnmarshaller>(CborStringUnmarshaller.Instance).Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "stringSet":
                        context.AddPathSegment("StringSet");
                        unmarshalledObject.StringSet = new CborListUnmarshaller<string, CborStringUnmarshaller>(CborStringUnmarshaller.Instance).Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "structureList":
                        context.AddPathSegment("StructureList");
                        unmarshalledObject.StructureList = new CborListUnmarshaller<StructureListMember, StructureListMemberUnmarshaller>(StructureListMemberUnmarshaller.Instance).Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "timestampList":
                        context.AddPathSegment("TimestampList");
                        unmarshalledObject.TimestampList = new CborListUnmarshaller<DateTime, CborDateTimeUnmarshaller>(CborDateTimeUnmarshaller.Instance).Unmarshall(context);
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

        private static RpcV2CborListsResponseUnmarshaller _instance = new RpcV2CborListsResponseUnmarshaller();

        internal static RpcV2CborListsResponseUnmarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static RpcV2CborListsResponseUnmarshaller Instance => _instance;
    }
}
