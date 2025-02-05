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
 * Do not modify this file. This file is generated from the elasticfilesystem-2015-02-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.ElasticFileSystem.Model;
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
namespace Amazon.ElasticFileSystem.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateFileSystem Request Marshaller
    /// </summary>       
    public class CreateFileSystemRequestMarshaller : IMarshaller<IRequest, CreateFileSystemRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateFileSystemRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateFileSystemRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ElasticFileSystem");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2015-02-01";
            request.HttpMethod = "POST";

            request.ResourcePath = "/2015-02-01/file-systems";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetAvailabilityZoneName())
            {
                context.Writer.WritePropertyName("AvailabilityZoneName");
                context.Writer.WriteStringValue(publicRequest.AvailabilityZoneName);
            }

            if(publicRequest.IsSetBackup())
            {
                context.Writer.WritePropertyName("Backup");
                context.Writer.WriteBooleanValue(publicRequest.Backup.Value);
            }

            if(publicRequest.IsSetCreationToken())
            {
                context.Writer.WritePropertyName("CreationToken");
                context.Writer.WriteStringValue(publicRequest.CreationToken);
            }

            else if(!(publicRequest.IsSetCreationToken()))
            {
                context.Writer.WritePropertyName("CreationToken");
                context.Writer.WriteStringValue(Guid.NewGuid().ToString());
            }
            if(publicRequest.IsSetEncrypted())
            {
                context.Writer.WritePropertyName("Encrypted");
                context.Writer.WriteBooleanValue(publicRequest.Encrypted.Value);
            }

            if(publicRequest.IsSetKmsKeyId())
            {
                context.Writer.WritePropertyName("KmsKeyId");
                context.Writer.WriteStringValue(publicRequest.KmsKeyId);
            }

            if(publicRequest.IsSetPerformanceMode())
            {
                context.Writer.WritePropertyName("PerformanceMode");
                context.Writer.WriteStringValue(publicRequest.PerformanceMode);
            }

            if(publicRequest.IsSetProvisionedThroughputInMibps())
            {
                context.Writer.WritePropertyName("ProvisionedThroughputInMibps");
                if(StringUtils.IsSpecialDoubleValue(publicRequest.ProvisionedThroughputInMibps.Value))
                {
                    context.Writer.WriteStringValue(StringUtils.FromSpecialDoubleValue(publicRequest.ProvisionedThroughputInMibps.Value));
                }
                else
                {
                    context.Writer.WriteNumberValue(publicRequest.ProvisionedThroughputInMibps.Value);
                }
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

            if(publicRequest.IsSetThroughputMode())
            {
                context.Writer.WritePropertyName("ThroughputMode");
                context.Writer.WriteStringValue(publicRequest.ThroughputMode);
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
        private static CreateFileSystemRequestMarshaller _instance = new CreateFileSystemRequestMarshaller();        

        internal static CreateFileSystemRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateFileSystemRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}