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
 * Do not modify this file. This file is generated from the appstream-2016-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.AppStream.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using Amazon.Extensions.CborProtocol;
using Amazon.Extensions.CborProtocol.Internal;
using Amazon.Extensions.CborProtocol.Internal.Transform;

#pragma warning disable CS0612,CS0618
namespace Amazon.AppStream.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateAppBlockBuilder Request Marshaller
    /// </summary>       
    public class UpdateAppBlockBuilderRequestMarshaller : IMarshaller<IRequest, UpdateAppBlockBuilderRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateAppBlockBuilderRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateAppBlockBuilderRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.AppStream");
            request.Headers["smithy-protocol"] = "rpc-v2-cbor";
            request.ResourcePath = "service/PhotonAdminProxyService/operation/UpdateAppBlockBuilder";
            request.Headers["Content-Type"] = "application/cbor";
            request.Headers["Accept"] = "application/cbor";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2016-12-01";
            request.HttpMethod = "POST";

            var writer = CborWriterPool.Rent();
            try
            {
                writer.WriteStartMap(null);
                var context = new CborMarshallerContext(request, writer);
                if (publicRequest.IsSetAccessEndpoints())
                {
                    context.Writer.WriteTextString("AccessEndpoints");
                    context.Writer.WriteStartArray(publicRequest.AccessEndpoints.Count);
                    foreach(var publicRequestAccessEndpointsListValue in publicRequest.AccessEndpoints)
                    {
                        context.Writer.WriteStartMap(null);

                        var marshaller = AccessEndpointMarshaller.Instance;
                        marshaller.Marshall(publicRequestAccessEndpointsListValue, context);

                        context.Writer.WriteEndMap();
                    }
                    context.Writer.WriteEndArray();
                }
                if (publicRequest.IsSetAttributesToDelete())
                {
                    context.Writer.WriteTextString("AttributesToDelete");
                    context.Writer.WriteStartArray(publicRequest.AttributesToDelete.Count);
                    foreach(var publicRequestAttributesToDeleteListValue in publicRequest.AttributesToDelete)
                    {
                            context.Writer.WriteTextString(publicRequestAttributesToDeleteListValue);
                    }
                    context.Writer.WriteEndArray();
                }
                if (publicRequest.IsSetDescription())
                {
                    context.Writer.WriteTextString("Description");
                    context.Writer.WriteTextString(publicRequest.Description);
                }
                if (publicRequest.IsSetDisableIMDSV1())
                {
                    context.Writer.WriteTextString("DisableIMDSV1");
                    context.Writer.WriteBoolean(publicRequest.DisableIMDSV1.Value);
                }
                if (publicRequest.IsSetDisplayName())
                {
                    context.Writer.WriteTextString("DisplayName");
                    context.Writer.WriteTextString(publicRequest.DisplayName);
                }
                if (publicRequest.IsSetEnableDefaultInternetAccess())
                {
                    context.Writer.WriteTextString("EnableDefaultInternetAccess");
                    context.Writer.WriteBoolean(publicRequest.EnableDefaultInternetAccess.Value);
                }
                if (publicRequest.IsSetIamRoleArn())
                {
                    context.Writer.WriteTextString("IamRoleArn");
                    context.Writer.WriteTextString(publicRequest.IamRoleArn);
                }
                if (publicRequest.IsSetInstanceType())
                {
                    context.Writer.WriteTextString("InstanceType");
                    context.Writer.WriteTextString(publicRequest.InstanceType);
                }
                if (publicRequest.IsSetName())
                {
                    context.Writer.WriteTextString("Name");
                    context.Writer.WriteTextString(publicRequest.Name);
                }
                if (publicRequest.IsSetPlatform())
                {
                    context.Writer.WriteTextString("Platform");
                    context.Writer.WriteTextString(publicRequest.Platform);
                }
                if (publicRequest.IsSetVpcConfig())
                {
                    context.Writer.WriteTextString("VpcConfig");
                    context.Writer.WriteStartMap(null);

                    var marshaller = VpcConfigMarshaller.Instance;
                    marshaller.Marshall(publicRequest.VpcConfig, context);

                    context.Writer.WriteEndMap();
                }
                writer.WriteEndMap();
#if !NETFRAMEWORK
                // Encode directly into a pooled buffer instead of allocating a new byte[] per request.
                // The buffer is pre-sized to writer.BytesWritten so it's rented at the right size up front,
                // avoiding the default-size rent followed by a resize+return.
                var encodedLength = writer.BytesWritten;
                request.ContentStream = new PooledContentStream(encodedLength);
                var bufferWriter = ((PooledContentStream)request.ContentStream).BufferWriter;
                var span = bufferWriter.GetSpan(encodedLength);
                var bytesWritten = writer.Encode(span);
                bufferWriter.Advance(bytesWritten);
#else
                request.Content = writer.Encode();
#endif
            }
            finally
            {
                CborWriterPool.Return(writer);
            }
            
            return request;
        }
        private static UpdateAppBlockBuilderRequestMarshaller _instance = new UpdateAppBlockBuilderRequestMarshaller();        

        internal static UpdateAppBlockBuilderRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateAppBlockBuilderRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}