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
    /// RpcV2CborDenseMaps Request Marshaller
    /// </summary>       
    public class RpcV2CborDenseMapsRequestMarshaller : IMarshaller<IRequest, RpcV2CborDenseMapsRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((RpcV2CborDenseMapsRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(RpcV2CborDenseMapsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.RpcV2Protocol");
            request.Headers["smithy-protocol"] = "rpc-v2-cbor";
            request.ResourcePath = "service/RpcV2Protocol/operation/RpcV2CborDenseMaps";
            request.Headers["Content-Type"] = "application/cbor";
            request.Headers["Accept"] = "application/cbor";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2020-07-14";
            request.HttpMethod = "POST";

            var writer = CborWriterPool.Rent();
            try
            {
                writer.WriteStartMap(null);
                var context = new CborMarshallerContext(request, writer);
                if (publicRequest.IsSetDenseBooleanMap())
                {
                    context.Writer.WriteTextString("denseBooleanMap");
                    context.Writer.WriteStartMap(null);
                    foreach (var publicRequestDenseBooleanMapKvp in publicRequest.DenseBooleanMap)
                    {
                        context.Writer.WriteTextString(publicRequestDenseBooleanMapKvp.Key);
                        var publicRequestDenseBooleanMapValue = publicRequestDenseBooleanMapKvp.Value;

                            context.Writer.WriteBoolean(publicRequestDenseBooleanMapValue);
                    }
                    context.Writer.WriteEndMap();
                }
                if (publicRequest.IsSetDenseNumberMap())
                {
                    context.Writer.WriteTextString("denseNumberMap");
                    context.Writer.WriteStartMap(null);
                    foreach (var publicRequestDenseNumberMapKvp in publicRequest.DenseNumberMap)
                    {
                        context.Writer.WriteTextString(publicRequestDenseNumberMapKvp.Key);
                        var publicRequestDenseNumberMapValue = publicRequestDenseNumberMapKvp.Value;

                            context.Writer.WriteInt32(publicRequestDenseNumberMapValue);
                    }
                    context.Writer.WriteEndMap();
                }
                if (publicRequest.IsSetDenseSetMap())
                {
                    context.Writer.WriteTextString("denseSetMap");
                    context.Writer.WriteStartMap(null);
                    foreach (var publicRequestDenseSetMapKvp in publicRequest.DenseSetMap)
                    {
                        context.Writer.WriteTextString(publicRequestDenseSetMapKvp.Key);
                        var publicRequestDenseSetMapValue = publicRequestDenseSetMapKvp.Value;

                        context.Writer.WriteStartArray(publicRequestDenseSetMapValue.Count);
                        foreach(var publicRequestDenseSetMapValueListValue in publicRequestDenseSetMapValue)
                        {
                                context.Writer.WriteTextString(publicRequestDenseSetMapValueListValue);
                        }
                        context.Writer.WriteEndArray();
                    }
                    context.Writer.WriteEndMap();
                }
                if (publicRequest.IsSetDenseStringMap())
                {
                    context.Writer.WriteTextString("denseStringMap");
                    context.Writer.WriteStartMap(null);
                    foreach (var publicRequestDenseStringMapKvp in publicRequest.DenseStringMap)
                    {
                        context.Writer.WriteTextString(publicRequestDenseStringMapKvp.Key);
                        var publicRequestDenseStringMapValue = publicRequestDenseStringMapKvp.Value;

                            context.Writer.WriteTextString(publicRequestDenseStringMapValue);
                    }
                    context.Writer.WriteEndMap();
                }
                if (publicRequest.IsSetDenseStructMap())
                {
                    context.Writer.WriteTextString("denseStructMap");
                    context.Writer.WriteStartMap(null);
                    foreach (var publicRequestDenseStructMapKvp in publicRequest.DenseStructMap)
                    {
                        context.Writer.WriteTextString(publicRequestDenseStructMapKvp.Key);
                        var publicRequestDenseStructMapValue = publicRequestDenseStructMapKvp.Value;

                        context.Writer.WriteStartMap(null);

                        var marshaller = GreetingStructMarshaller.Instance;
                        marshaller.Marshall(publicRequestDenseStructMapValue, context);

                        context.Writer.WriteEndMap();
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
        private static RpcV2CborDenseMapsRequestMarshaller _instance = new RpcV2CborDenseMapsRequestMarshaller();        

        internal static RpcV2CborDenseMapsRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static RpcV2CborDenseMapsRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}