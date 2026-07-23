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
 * Do not modify this file. This file is generated from the workspaces-instances-2022-07-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.WorkspacesInstances.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using Amazon.Extensions.CborProtocol;
using Amazon.Extensions.CborProtocol.Internal;
using Amazon.Extensions.CborProtocol.Internal.Transform;

#pragma warning disable CS0612,CS0618
namespace Amazon.WorkspacesInstances.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateVolume Request Marshaller
    /// </summary>       
    public class CreateVolumeRequestMarshaller : IMarshaller<IRequest, CreateVolumeRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateVolumeRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateVolumeRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.WorkspacesInstances");
            request.Headers["smithy-protocol"] = "rpc-v2-cbor";
            request.ResourcePath = "service/EUCMIFrontendAPIService/operation/CreateVolume";
            request.Headers["Content-Type"] = "application/cbor";
            request.Headers["Accept"] = "application/cbor";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2022-07-26";
            request.HttpMethod = "POST";

            var writer = CborWriterPool.Rent();
            try
            {
                writer.WriteStartMap(null);
                var context = new CborMarshallerContext(request, writer);
                if (publicRequest.IsSetAvailabilityZone())
                {
                    context.Writer.WriteTextString("AvailabilityZone");
                    context.Writer.WriteTextString(publicRequest.AvailabilityZone);
                }
                if (publicRequest.IsSetClientToken())
                {
                    context.Writer.WriteTextString("ClientToken");
                    context.Writer.WriteTextString(publicRequest.ClientToken);
                }
                else if (!(publicRequest.IsSetClientToken()))
                {
                    context.Writer.WriteTextString("ClientToken");
                    context.Writer.WriteTextString(Guid.NewGuid().ToString());
                }
                if (publicRequest.IsSetEncrypted())
                {
                    context.Writer.WriteTextString("Encrypted");
                    context.Writer.WriteBoolean(publicRequest.Encrypted.Value);
                }
                if (publicRequest.IsSetIops())
                {
                    context.Writer.WriteTextString("Iops");
                    context.Writer.WriteInt32(publicRequest.Iops.Value);
                }
                if (publicRequest.IsSetKmsKeyId())
                {
                    context.Writer.WriteTextString("KmsKeyId");
                    context.Writer.WriteTextString(publicRequest.KmsKeyId);
                }
                if (publicRequest.IsSetSizeInGB())
                {
                    context.Writer.WriteTextString("SizeInGB");
                    context.Writer.WriteInt32(publicRequest.SizeInGB.Value);
                }
                if (publicRequest.IsSetSnapshotId())
                {
                    context.Writer.WriteTextString("SnapshotId");
                    context.Writer.WriteTextString(publicRequest.SnapshotId);
                }
                if (publicRequest.IsSetTagSpecifications())
                {
                    context.Writer.WriteTextString("TagSpecifications");
                    context.Writer.WriteStartArray(publicRequest.TagSpecifications.Count);
                    foreach(var publicRequestTagSpecificationsListValue in publicRequest.TagSpecifications)
                    {
                        context.Writer.WriteStartMap(null);

                        var marshaller = TagSpecificationMarshaller.Instance;
                        marshaller.Marshall(publicRequestTagSpecificationsListValue, context);

                        context.Writer.WriteEndMap();
                    }
                    context.Writer.WriteEndArray();
                }
                if (publicRequest.IsSetThroughput())
                {
                    context.Writer.WriteTextString("Throughput");
                    context.Writer.WriteInt32(publicRequest.Throughput.Value);
                }
                if (publicRequest.IsSetVolumeType())
                {
                    context.Writer.WriteTextString("VolumeType");
                    context.Writer.WriteTextString(publicRequest.VolumeType);
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
        private static CreateVolumeRequestMarshaller _instance = new CreateVolumeRequestMarshaller();        

        internal static CreateVolumeRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateVolumeRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}