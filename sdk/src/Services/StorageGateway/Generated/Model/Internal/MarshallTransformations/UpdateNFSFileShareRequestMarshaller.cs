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
    /// UpdateNFSFileShare Request Marshaller
    /// </summary>       
    public class UpdateNFSFileShareRequestMarshaller : IMarshaller<IRequest, UpdateNFSFileShareRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateNFSFileShareRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateNFSFileShareRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.StorageGateway");
            string target = "StorageGateway_20130630.UpdateNFSFileShare";
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
            if(publicRequest.IsSetAuditDestinationARN())
            {
                context.Writer.WritePropertyName("AuditDestinationARN");
                context.Writer.WriteStringValue(publicRequest.AuditDestinationARN);
            }

            if(publicRequest.IsSetCacheAttributes())
            {
                context.Writer.WritePropertyName("CacheAttributes");
                context.Writer.WriteStartObject();

                var marshaller = CacheAttributesMarshaller.Instance;
                marshaller.Marshall(publicRequest.CacheAttributes, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetClientList())
            {
                context.Writer.WritePropertyName("ClientList");
                context.Writer.WriteStartArray();
                foreach(var publicRequestClientListListValue in publicRequest.ClientList)
                {
                        context.Writer.WriteStringValue(publicRequestClientListListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetDefaultStorageClass())
            {
                context.Writer.WritePropertyName("DefaultStorageClass");
                context.Writer.WriteStringValue(publicRequest.DefaultStorageClass);
            }

            if(publicRequest.IsSetEncryptionType())
            {
                context.Writer.WritePropertyName("EncryptionType");
                context.Writer.WriteStringValue(publicRequest.EncryptionType);
            }

            if(publicRequest.IsSetFileShareARN())
            {
                context.Writer.WritePropertyName("FileShareARN");
                context.Writer.WriteStringValue(publicRequest.FileShareARN);
            }

            if(publicRequest.IsSetFileShareName())
            {
                context.Writer.WritePropertyName("FileShareName");
                context.Writer.WriteStringValue(publicRequest.FileShareName);
            }

            if(publicRequest.IsSetGuessMIMETypeEnabled())
            {
                context.Writer.WritePropertyName("GuessMIMETypeEnabled");
                context.Writer.WriteBooleanValue(publicRequest.GuessMIMETypeEnabled.Value);
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

            if(publicRequest.IsSetNFSFileShareDefaults())
            {
                context.Writer.WritePropertyName("NFSFileShareDefaults");
                context.Writer.WriteStartObject();

                var marshaller = NFSFileShareDefaultsMarshaller.Instance;
                marshaller.Marshall(publicRequest.NFSFileShareDefaults, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetNotificationPolicy())
            {
                context.Writer.WritePropertyName("NotificationPolicy");
                context.Writer.WriteStringValue(publicRequest.NotificationPolicy);
            }

            if(publicRequest.IsSetObjectACL())
            {
                context.Writer.WritePropertyName("ObjectACL");
                context.Writer.WriteStringValue(publicRequest.ObjectACL);
            }

            if(publicRequest.IsSetReadOnly())
            {
                context.Writer.WritePropertyName("ReadOnly");
                context.Writer.WriteBooleanValue(publicRequest.ReadOnly.Value);
            }

            if(publicRequest.IsSetRequesterPays())
            {
                context.Writer.WritePropertyName("RequesterPays");
                context.Writer.WriteBooleanValue(publicRequest.RequesterPays.Value);
            }

            if(publicRequest.IsSetSquash())
            {
                context.Writer.WritePropertyName("Squash");
                context.Writer.WriteStringValue(publicRequest.Squash);
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
        private static UpdateNFSFileShareRequestMarshaller _instance = new UpdateNFSFileShareRequestMarshaller();        

        internal static UpdateNFSFileShareRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateNFSFileShareRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}