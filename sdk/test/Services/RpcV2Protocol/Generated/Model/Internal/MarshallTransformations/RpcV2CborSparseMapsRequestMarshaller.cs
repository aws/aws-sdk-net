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
    /// RpcV2CborSparseMaps Request Marshaller
    /// </summary>       
    public class RpcV2CborSparseMapsRequestMarshaller : IMarshaller<IRequest, RpcV2CborSparseMapsRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((RpcV2CborSparseMapsRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(RpcV2CborSparseMapsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.RpcV2Protocol");
            request.Headers["smithy-protocol"] = "rpc-v2-cbor";
            request.ResourcePath = "service/RpcV2Protocol/operation/RpcV2CborSparseMaps";
            request.Headers["Content-Type"] = "application/cbor";
            request.Headers["Accept"] = "application/cbor";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2020-07-14";
            request.HttpMethod = "POST";

            var writer = CborWriterPool.Rent();
            try
            {
                writer.WriteStartMap(null);
                var context = new CborMarshallerContext(request, writer);
                if (publicRequest.IsSetSparseBooleanMap())
                {
                    context.Writer.WriteTextString("sparseBooleanMap");
                    context.Writer.WriteStartMap(null);
                    foreach (var publicRequestSparseBooleanMapKvp in publicRequest.SparseBooleanMap)
                    {
                        context.Writer.WriteTextString(publicRequestSparseBooleanMapKvp.Key);
                        var publicRequestSparseBooleanMapValue = publicRequestSparseBooleanMapKvp.Value;

                                if (publicRequestSparseBooleanMapValue == null)
                                    context.Writer.WriteNull();
                                else
                                    context.Writer.WriteBoolean(publicRequestSparseBooleanMapValue.Value);
                    }
                    context.Writer.WriteEndMap();
                }
                if (publicRequest.IsSetSparseNumberMap())
                {
                    context.Writer.WriteTextString("sparseNumberMap");
                    context.Writer.WriteStartMap(null);
                    foreach (var publicRequestSparseNumberMapKvp in publicRequest.SparseNumberMap)
                    {
                        context.Writer.WriteTextString(publicRequestSparseNumberMapKvp.Key);
                        var publicRequestSparseNumberMapValue = publicRequestSparseNumberMapKvp.Value;

                                if (publicRequestSparseNumberMapValue == null)
                                    context.Writer.WriteNull();
                                else
                                    context.Writer.WriteInt32(publicRequestSparseNumberMapValue.Value);
                    }
                    context.Writer.WriteEndMap();
                }
                if (publicRequest.IsSetSparseSetMap())
                {
                    context.Writer.WriteTextString("sparseSetMap");
                    context.Writer.WriteStartMap(null);
                    foreach (var publicRequestSparseSetMapKvp in publicRequest.SparseSetMap)
                    {
                        context.Writer.WriteTextString(publicRequestSparseSetMapKvp.Key);
                        var publicRequestSparseSetMapValue = publicRequestSparseSetMapKvp.Value;

                        if (publicRequestSparseSetMapValue == null)
                            context.Writer.WriteNull();
                        else
                        {
                            context.Writer.WriteStartArray(publicRequestSparseSetMapValue.Count);
                            foreach(var publicRequestSparseSetMapValueListValue in publicRequestSparseSetMapValue)
                            {
                                        if (publicRequestSparseSetMapValueListValue == null)
                                            context.Writer.WriteNull();
                                        else
                                            context.Writer.WriteTextString(publicRequestSparseSetMapValueListValue);
                            }
                            context.Writer.WriteEndArray();
                        }
                    }
                    context.Writer.WriteEndMap();
                }
                if (publicRequest.IsSetSparseStringMap())
                {
                    context.Writer.WriteTextString("sparseStringMap");
                    context.Writer.WriteStartMap(null);
                    foreach (var publicRequestSparseStringMapKvp in publicRequest.SparseStringMap)
                    {
                        context.Writer.WriteTextString(publicRequestSparseStringMapKvp.Key);
                        var publicRequestSparseStringMapValue = publicRequestSparseStringMapKvp.Value;

                                if (publicRequestSparseStringMapValue == null)
                                    context.Writer.WriteNull();
                                else
                                    context.Writer.WriteTextString(publicRequestSparseStringMapValue);
                    }
                    context.Writer.WriteEndMap();
                }
                if (publicRequest.IsSetSparseStructMap())
                {
                    context.Writer.WriteTextString("sparseStructMap");
                    context.Writer.WriteStartMap(null);
                    foreach (var publicRequestSparseStructMapKvp in publicRequest.SparseStructMap)
                    {
                        context.Writer.WriteTextString(publicRequestSparseStructMapKvp.Key);
                        var publicRequestSparseStructMapValue = publicRequestSparseStructMapKvp.Value;

                        if (publicRequestSparseStructMapValue == null)
                            context.Writer.WriteNull();
                        else
                        {
                            context.Writer.WriteStartMap(null);

                            var marshaller = GreetingStructMarshaller.Instance;
                            marshaller.Marshall(publicRequestSparseStructMapValue, context);

                            context.Writer.WriteEndMap();
                        }
                    }
                    context.Writer.WriteEndMap();
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
        private static RpcV2CborSparseMapsRequestMarshaller _instance = new RpcV2CborSparseMapsRequestMarshaller();        

        internal static RpcV2CborSparseMapsRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static RpcV2CborSparseMapsRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}