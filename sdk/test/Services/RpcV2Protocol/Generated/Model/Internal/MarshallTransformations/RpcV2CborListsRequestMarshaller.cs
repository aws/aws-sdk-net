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
using System.Text;
using System.Xml.Serialization;

using Amazon.RpcV2Protocol.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using Amazon.Extensions.CborProtocol;
using Amazon.Extensions.CborProtocol.Internal;
using Amazon.Extensions.CborProtocol.Internal.Transform;

#pragma warning disable CS0612,CS0618
namespace Amazon.RpcV2Protocol.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// RpcV2CborLists Request Marshaller
    /// </summary>       
    public class RpcV2CborListsRequestMarshaller : IMarshaller<IRequest, RpcV2CborListsRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((RpcV2CborListsRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(RpcV2CborListsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.RpcV2Protocol");
            request.Headers["smithy-protocol"] = "rpc-v2-cbor";
            request.ResourcePath = "service/RpcV2Protocol/operation/RpcV2CborLists";
            request.Headers["Content-Type"] = "application/cbor";
            request.Headers["Accept"] = "application/cbor";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2020-07-14";
            request.HttpMethod = "POST";

            var writer = CborWriterPool.Rent();
            try
            {
                writer.WriteStartMap(null);
                var context = new CborMarshallerContext(request, writer);
                if (publicRequest.IsSetBlobList())
                {
                    context.Writer.WriteTextString("blobList");
                    context.Writer.WriteStartArray(publicRequest.BlobList.Count);
                    foreach(var publicRequestBlobListListValue in publicRequest.BlobList)
                    {
                        context.Writer.WriteByteString(publicRequestBlobListListValue.ToArray());
                    }
                    context.Writer.WriteEndArray();
                }
                if (publicRequest.IsSetBooleanList())
                {
                    context.Writer.WriteTextString("booleanList");
                    context.Writer.WriteStartArray(publicRequest.BooleanList.Count);
                    foreach(var publicRequestBooleanListListValue in publicRequest.BooleanList)
                    {
                            context.Writer.WriteBoolean(publicRequestBooleanListListValue);
                    }
                    context.Writer.WriteEndArray();
                }
                if (publicRequest.IsSetEnumList())
                {
                    context.Writer.WriteTextString("enumList");
                    context.Writer.WriteStartArray(publicRequest.EnumList.Count);
                    foreach(var publicRequestEnumListListValue in publicRequest.EnumList)
                    {
                            context.Writer.WriteTextString(publicRequestEnumListListValue);
                    }
                    context.Writer.WriteEndArray();
                }
                if (publicRequest.IsSetIntegerList())
                {
                    context.Writer.WriteTextString("integerList");
                    context.Writer.WriteStartArray(publicRequest.IntegerList.Count);
                    foreach(var publicRequestIntegerListListValue in publicRequest.IntegerList)
                    {
                            context.Writer.WriteInt32(publicRequestIntegerListListValue);
                    }
                    context.Writer.WriteEndArray();
                }
                if (publicRequest.IsSetIntEnumList())
                {
                    context.Writer.WriteTextString("intEnumList");
                    context.Writer.WriteStartArray(publicRequest.IntEnumList.Count);
                    foreach(var publicRequestIntEnumListListValue in publicRequest.IntEnumList)
                    {
                            context.Writer.WriteInt32(publicRequestIntEnumListListValue);
                    }
                    context.Writer.WriteEndArray();
                }
                if (publicRequest.IsSetNestedStringList())
                {
                    context.Writer.WriteTextString("nestedStringList");
                    context.Writer.WriteStartArray(publicRequest.NestedStringList.Count);
                    foreach(var publicRequestNestedStringListListValue in publicRequest.NestedStringList)
                    {
                        context.Writer.WriteStartArray(publicRequestNestedStringListListValue.Count);
                        foreach(var publicRequestNestedStringListListValueListValue in publicRequestNestedStringListListValue)
                        {
                                context.Writer.WriteTextString(publicRequestNestedStringListListValueListValue);
                        }
                        context.Writer.WriteEndArray();
                    }
                    context.Writer.WriteEndArray();
                }
                if (publicRequest.IsSetStringList())
                {
                    context.Writer.WriteTextString("stringList");
                    context.Writer.WriteStartArray(publicRequest.StringList.Count);
                    foreach(var publicRequestStringListListValue in publicRequest.StringList)
                    {
                            context.Writer.WriteTextString(publicRequestStringListListValue);
                    }
                    context.Writer.WriteEndArray();
                }
                if (publicRequest.IsSetStringSet())
                {
                    context.Writer.WriteTextString("stringSet");
                    context.Writer.WriteStartArray(publicRequest.StringSet.Count);
                    foreach(var publicRequestStringSetListValue in publicRequest.StringSet)
                    {
                            context.Writer.WriteTextString(publicRequestStringSetListValue);
                    }
                    context.Writer.WriteEndArray();
                }
                if (publicRequest.IsSetStructureList())
                {
                    context.Writer.WriteTextString("structureList");
                    context.Writer.WriteStartArray(publicRequest.StructureList.Count);
                    foreach(var publicRequestStructureListListValue in publicRequest.StructureList)
                    {
                        context.Writer.WriteStartMap(null);

                        var marshaller = StructureListMemberMarshaller.Instance;
                        marshaller.Marshall(publicRequestStructureListListValue, context);

                        context.Writer.WriteEndMap();
                    }
                    context.Writer.WriteEndArray();
                }
                if (publicRequest.IsSetTimestampList())
                {
                    context.Writer.WriteTextString("timestampList");
                    context.Writer.WriteStartArray(publicRequest.TimestampList.Count);
                    foreach(var publicRequestTimestampListListValue in publicRequest.TimestampList)
                    {
                            context.Writer.WriteDateTime(publicRequestTimestampListListValue);
                    }
                    context.Writer.WriteEndArray();
                }
                writer.WriteEndMap();
                request.Content = writer.Encode();
            }
            finally
            {
                CborWriterPool.Return(writer);
            }
            
            return request;
        }
        private static RpcV2CborListsRequestMarshaller _instance = new RpcV2CborListsRequestMarshaller();        

        internal static RpcV2CborListsRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static RpcV2CborListsRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}