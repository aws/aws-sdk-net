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
    /// CreateSMBFileShare Request Marshaller
    /// </summary>       
    public class CreateSMBFileShareRequestMarshaller : IMarshaller<IRequest, CreateSMBFileShareRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateSMBFileShareRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateSMBFileShareRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.StorageGateway");
            string target = "StorageGateway_20130630.CreateSMBFileShare";
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
            if(publicRequest.IsSetAccessBasedEnumeration())
            {
                context.Writer.WritePropertyName("AccessBasedEnumeration");
                context.Writer.WriteBooleanValue(publicRequest.AccessBasedEnumeration.Value);
            }

            if(publicRequest.IsSetAdminUserList())
            {
                context.Writer.WritePropertyName("AdminUserList");
                context.Writer.WriteStartArray();
                foreach(var publicRequestAdminUserListListValue in publicRequest.AdminUserList)
                {
                        context.Writer.WriteStringValue(publicRequestAdminUserListListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetAuditDestinationARN())
            {
                context.Writer.WritePropertyName("AuditDestinationARN");
                context.Writer.WriteStringValue(publicRequest.AuditDestinationARN);
            }

            if(publicRequest.IsSetAuthentication())
            {
                context.Writer.WritePropertyName("Authentication");
                context.Writer.WriteStringValue(publicRequest.Authentication);
            }

            if(publicRequest.IsSetBucketRegion())
            {
                context.Writer.WritePropertyName("BucketRegion");
                context.Writer.WriteStringValue(publicRequest.BucketRegion);
            }

            if(publicRequest.IsSetCacheAttributes())
            {
                context.Writer.WritePropertyName("CacheAttributes");
                context.Writer.WriteStartObject();

                var marshaller = CacheAttributesMarshaller.Instance;
                marshaller.Marshall(publicRequest.CacheAttributes, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetCaseSensitivity())
            {
                context.Writer.WritePropertyName("CaseSensitivity");
                context.Writer.WriteStringValue(publicRequest.CaseSensitivity);
            }

            if(publicRequest.IsSetClientToken())
            {
                context.Writer.WritePropertyName("ClientToken");
                context.Writer.WriteStringValue(publicRequest.ClientToken);
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

            if(publicRequest.IsSetFileShareName())
            {
                context.Writer.WritePropertyName("FileShareName");
                context.Writer.WriteStringValue(publicRequest.FileShareName);
            }

            if(publicRequest.IsSetGatewayARN())
            {
                context.Writer.WritePropertyName("GatewayARN");
                context.Writer.WriteStringValue(publicRequest.GatewayARN);
            }

            if(publicRequest.IsSetGuessMIMETypeEnabled())
            {
                context.Writer.WritePropertyName("GuessMIMETypeEnabled");
                context.Writer.WriteBooleanValue(publicRequest.GuessMIMETypeEnabled.Value);
            }

            if(publicRequest.IsSetInvalidUserList())
            {
                context.Writer.WritePropertyName("InvalidUserList");
                context.Writer.WriteStartArray();
                foreach(var publicRequestInvalidUserListListValue in publicRequest.InvalidUserList)
                {
                        context.Writer.WriteStringValue(publicRequestInvalidUserListListValue);
                }
                context.Writer.WriteEndArray();
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

            if(publicRequest.IsSetLocationARN())
            {
                context.Writer.WritePropertyName("LocationARN");
                context.Writer.WriteStringValue(publicRequest.LocationARN);
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

            if(publicRequest.IsSetOplocksEnabled())
            {
                context.Writer.WritePropertyName("OplocksEnabled");
                context.Writer.WriteBooleanValue(publicRequest.OplocksEnabled.Value);
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

            if(publicRequest.IsSetRole())
            {
                context.Writer.WritePropertyName("Role");
                context.Writer.WriteStringValue(publicRequest.Role);
            }

            if(publicRequest.IsSetSMBACLEnabled())
            {
                context.Writer.WritePropertyName("SMBACLEnabled");
                context.Writer.WriteBooleanValue(publicRequest.SMBACLEnabled.Value);
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

            if(publicRequest.IsSetValidUserList())
            {
                context.Writer.WritePropertyName("ValidUserList");
                context.Writer.WriteStartArray();
                foreach(var publicRequestValidUserListListValue in publicRequest.ValidUserList)
                {
                        context.Writer.WriteStringValue(publicRequestValidUserListListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetVPCEndpointDNSName())
            {
                context.Writer.WritePropertyName("VPCEndpointDNSName");
                context.Writer.WriteStringValue(publicRequest.VPCEndpointDNSName);
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
        private static CreateSMBFileShareRequestMarshaller _instance = new CreateSMBFileShareRequestMarshaller();        

        internal static CreateSMBFileShareRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateSMBFileShareRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}