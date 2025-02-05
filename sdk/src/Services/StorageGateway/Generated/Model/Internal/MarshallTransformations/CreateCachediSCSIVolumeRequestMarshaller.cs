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
 * Do not modify this file. This file is generated from the storagegateway-2013-06-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.StorageGateway.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
using System.Buffers;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618
namespace Amazon.StorageGateway.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateCachediSCSIVolume Request Marshaller
    /// </summary>       
    public class CreateCachediSCSIVolumeRequestMarshaller : IMarshaller<IRequest, CreateCachediSCSIVolumeRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateCachediSCSIVolumeRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateCachediSCSIVolumeRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.StorageGateway");
            string target = "StorageGateway_20130630.CreateCachediSCSIVolume";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2013-06-30";
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetClientToken())
            {
                context.Writer.WritePropertyName("ClientToken");
                context.Writer.WriteStringValue(publicRequest.ClientToken);
            }

            if(publicRequest.IsSetGatewayARN())
            {
                context.Writer.WritePropertyName("GatewayARN");
                context.Writer.WriteStringValue(publicRequest.GatewayARN);
            }

            if(publicRequest.IsSetKMSEncrypted())
            {
                context.Writer.WritePropertyName("KMSEncrypted");
                context.Writer.WriteBooleanValue(publicRequest.KMSEncrypted.Value);
            }

            if(publicRequest.IsSetKMSKey())
            {
                context.Writer.WritePropertyName("KMSKey");
                context.Writer.WriteStringValue(publicRequest.KMSKey);
            }

            if(publicRequest.IsSetNetworkInterfaceId())
            {
                context.Writer.WritePropertyName("NetworkInterfaceId");
                context.Writer.WriteStringValue(publicRequest.NetworkInterfaceId);
            }

            if(publicRequest.IsSetSnapshotId())
            {
                context.Writer.WritePropertyName("SnapshotId");
                context.Writer.WriteStringValue(publicRequest.SnapshotId);
            }

            if(publicRequest.IsSetSourceVolumeARN())
            {
                context.Writer.WritePropertyName("SourceVolumeARN");
                context.Writer.WriteStringValue(publicRequest.SourceVolumeARN);
            }

            if(publicRequest.IsSetTags())
            {
                context.Writer.WritePropertyName("Tags");
                context.Writer.WriteStartArray();
                foreach(var publicRequestTagsListValue in publicRequest.Tags)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = TagMarshaller.Instance;
                    marshaller.Marshall(publicRequestTagsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetTargetName())
            {
                context.Writer.WritePropertyName("TargetName");
                context.Writer.WriteStringValue(publicRequest.TargetName);
            }

            if(publicRequest.IsSetVolumeSizeInBytes())
            {
                context.Writer.WritePropertyName("VolumeSizeInBytes");
                context.Writer.WriteNumberValue(publicRequest.VolumeSizeInBytes.Value);
            }

            writer.WriteEndObject();
            writer.Flush();
            // ToArray() must be called here because aspects of sigv4 signing require a byte array
#if !NETFRAMEWORK
            request.Content = arrayPoolBufferWriter.WrittenMemory.ToArray();
#else
            request.Content = memoryStream.ToArray();
#endif
            


            return request;
        }
        private static CreateCachediSCSIVolumeRequestMarshaller _instance = new CreateCachediSCSIVolumeRequestMarshaller();        

        internal static CreateCachediSCSIVolumeRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateCachediSCSIVolumeRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}