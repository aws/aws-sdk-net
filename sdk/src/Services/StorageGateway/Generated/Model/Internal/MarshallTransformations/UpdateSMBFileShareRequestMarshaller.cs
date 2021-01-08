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
using ThirdParty.Json.LitJson;

namespace Amazon.StorageGateway.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateSMBFileShare Request Marshaller
    /// </summary>       
    public class UpdateSMBFileShareRequestMarshaller : IMarshaller<IRequest, UpdateSMBFileShareRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateSMBFileShareRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateSMBFileShareRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.StorageGateway");
            string target = "StorageGateway_20130630.UpdateSMBFileShare";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2013-06-30";            
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
            request.MarshallerVersion = 2;
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetAccessBasedEnumeration())
                {
                    context.Writer.WritePropertyName("AccessBasedEnumeration");
                    context.Writer.Write(publicRequest.AccessBasedEnumeration);
                }

                if(publicRequest.IsSetAdminUserList())
                {
                    context.Writer.WritePropertyName("AdminUserList");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestAdminUserListListValue in publicRequest.AdminUserList)
                    {
                            context.Writer.Write(publicRequestAdminUserListListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetAuditDestinationARN())
                {
                    context.Writer.WritePropertyName("AuditDestinationARN");
                    context.Writer.Write(publicRequest.AuditDestinationARN);
                }

                if(publicRequest.IsSetCacheAttributes())
                {
                    context.Writer.WritePropertyName("CacheAttributes");
                    context.Writer.WriteObjectStart();

                    var marshaller = CacheAttributesMarshaller.Instance;
                    marshaller.Marshall(publicRequest.CacheAttributes, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetCaseSensitivity())
                {
                    context.Writer.WritePropertyName("CaseSensitivity");
                    context.Writer.Write(publicRequest.CaseSensitivity);
                }

                if(publicRequest.IsSetDefaultStorageClass())
                {
                    context.Writer.WritePropertyName("DefaultStorageClass");
                    context.Writer.Write(publicRequest.DefaultStorageClass);
                }

                if(publicRequest.IsSetFileShareARN())
                {
                    context.Writer.WritePropertyName("FileShareARN");
                    context.Writer.Write(publicRequest.FileShareARN);
                }

                if(publicRequest.IsSetFileShareName())
                {
                    context.Writer.WritePropertyName("FileShareName");
                    context.Writer.Write(publicRequest.FileShareName);
                }

                if(publicRequest.IsSetGuessMIMETypeEnabled())
                {
                    context.Writer.WritePropertyName("GuessMIMETypeEnabled");
                    context.Writer.Write(publicRequest.GuessMIMETypeEnabled);
                }

                if(publicRequest.IsSetInvalidUserList())
                {
                    context.Writer.WritePropertyName("InvalidUserList");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestInvalidUserListListValue in publicRequest.InvalidUserList)
                    {
                            context.Writer.Write(publicRequestInvalidUserListListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetKMSEncrypted())
                {
                    context.Writer.WritePropertyName("KMSEncrypted");
                    context.Writer.Write(publicRequest.KMSEncrypted);
                }

                if(publicRequest.IsSetKMSKey())
                {
                    context.Writer.WritePropertyName("KMSKey");
                    context.Writer.Write(publicRequest.KMSKey);
                }

                if(publicRequest.IsSetNotificationPolicy())
                {
                    context.Writer.WritePropertyName("NotificationPolicy");
                    context.Writer.Write(publicRequest.NotificationPolicy);
                }

                if(publicRequest.IsSetObjectACL())
                {
                    context.Writer.WritePropertyName("ObjectACL");
                    context.Writer.Write(publicRequest.ObjectACL);
                }

                if(publicRequest.IsSetReadOnly())
                {
                    context.Writer.WritePropertyName("ReadOnly");
                    context.Writer.Write(publicRequest.ReadOnly);
                }

                if(publicRequest.IsSetRequesterPays())
                {
                    context.Writer.WritePropertyName("RequesterPays");
                    context.Writer.Write(publicRequest.RequesterPays);
                }

                if(publicRequest.IsSetSMBACLEnabled())
                {
                    context.Writer.WritePropertyName("SMBACLEnabled");
                    context.Writer.Write(publicRequest.SMBACLEnabled);
                }

                if(publicRequest.IsSetValidUserList())
                {
                    context.Writer.WritePropertyName("ValidUserList");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestValidUserListListValue in publicRequest.ValidUserList)
                    {
                            context.Writer.Write(publicRequestValidUserListListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static UpdateSMBFileShareRequestMarshaller _instance = new UpdateSMBFileShareRequestMarshaller();        

        internal static UpdateSMBFileShareRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateSMBFileShareRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}