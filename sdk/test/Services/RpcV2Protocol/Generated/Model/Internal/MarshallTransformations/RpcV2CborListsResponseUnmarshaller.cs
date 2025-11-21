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
    /// Response Unmarshaller for RpcV2CborLists operation
    /// </summary>  
    public class RpcV2CborListsResponseUnmarshaller : CborResponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public override AmazonWebServiceResponse Unmarshall(CborUnmarshallerContext context)
        {
            RpcV2CborListsResponse response = new RpcV2CborListsResponse();
            var reader = context.Reader;
            context.AddPathSegment("RpcV2CborLists");
            reader.ReadStartMap();
            while (reader.PeekState() != CborReaderState.EndMap)
            {
                string propertyName = reader.ReadTextString();
                switch (propertyName)
                {
                    case "blobList":
                        {
                            context.AddPathSegment("BlobList");
                            var unmarshaller = new CborListUnmarshaller<MemoryStream, CborMemoryStreamUnmarshaller>(CborMemoryStreamUnmarshaller.Instance);
                            response.BlobList = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "booleanList":
                        {
                            context.AddPathSegment("BooleanList");
                            var unmarshaller = new CborListUnmarshaller<bool, CborBoolUnmarshaller>(CborBoolUnmarshaller.Instance);
                            response.BooleanList = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "enumList":
                        {
                            context.AddPathSegment("EnumList");
                            var unmarshaller = new CborListUnmarshaller<string, CborStringUnmarshaller>(CborStringUnmarshaller.Instance);
                            response.EnumList = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "integerList":
                        {
                            context.AddPathSegment("IntegerList");
                            var unmarshaller = new CborListUnmarshaller<int, CborIntUnmarshaller>(CborIntUnmarshaller.Instance);
                            response.IntegerList = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "intEnumList":
                        {
                            context.AddPathSegment("IntEnumList");
                            var unmarshaller = new CborListUnmarshaller<int, CborIntUnmarshaller>(CborIntUnmarshaller.Instance);
                            response.IntEnumList = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "nestedStringList":
                        {
                            context.AddPathSegment("NestedStringList");
                            var unmarshaller = new CborListUnmarshaller<List<string>, CborListUnmarshaller<string, CborStringUnmarshaller>>(new CborListUnmarshaller<string, CborStringUnmarshaller>(CborStringUnmarshaller.Instance));
                            response.NestedStringList = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "stringList":
                        {
                            context.AddPathSegment("StringList");
                            var unmarshaller = new CborListUnmarshaller<string, CborStringUnmarshaller>(CborStringUnmarshaller.Instance);
                            response.StringList = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "stringSet":
                        {
                            context.AddPathSegment("StringSet");
                            var unmarshaller = new CborListUnmarshaller<string, CborStringUnmarshaller>(CborStringUnmarshaller.Instance);
                            response.StringSet = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "structureList":
                        {
                            context.AddPathSegment("StructureList");
                            var unmarshaller = new CborListUnmarshaller<StructureListMember, StructureListMemberUnmarshaller>(StructureListMemberUnmarshaller.Instance);
                            response.StructureList = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "timestampList":
                        {
                            context.AddPathSegment("TimestampList");
                            var unmarshaller = new CborListUnmarshaller<DateTime, CborDateTimeUnmarshaller>(CborDateTimeUnmarshaller.Instance);
                            response.TimestampList = unmarshaller.Unmarshall(context);
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