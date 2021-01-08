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
    /// CreateNFSFileShare Request Marshaller
    /// </summary>       
    public class CreateNFSFileShareRequestMarshaller : IMarshaller<IRequest, CreateNFSFileShareRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateNFSFileShareRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateNFSFileShareRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.StorageGateway");
            string target = "StorageGateway_20130630.CreateNFSFileShare";
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
                if(publicRequest.IsSetCacheAttributes())
                {
                    context.Writer.WritePropertyName("CacheAttributes");
                    context.Writer.WriteObjectStart();

                    var marshaller = CacheAttributesMarshaller.Instance;
                    marshaller.Marshall(publicRequest.CacheAttributes, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetClientList())
                {
                    context.Writer.WritePropertyName("ClientList");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestClientListListValue in publicRequest.ClientList)
                    {
                            context.Writer.Write(publicRequestClientListListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetClientToken())
                {
                    context.Writer.WritePropertyName("ClientToken");
                    context.Writer.Write(publicRequest.ClientToken);
                }

                if(publicRequest.IsSetDefaultStorageClass())
                {
                    context.Writer.WritePropertyName("DefaultStorageClass");
                    context.Writer.Write(publicRequest.DefaultStorageClass);
                }

                if(publicRequest.IsSetFileShareName())
                {
                    context.Writer.WritePropertyName("FileShareName");
                    context.Writer.Write(publicRequest.FileShareName);
                }

                if(publicRequest.IsSetGatewayARN())
                {
                    context.Writer.WritePropertyName("GatewayARN");
                    context.Writer.Write(publicRequest.GatewayARN);
                }

                if(publicRequest.IsSetGuessMIMETypeEnabled())
                {
                    context.Writer.WritePropertyName("GuessMIMETypeEnabled");
                    context.Writer.Write(publicRequest.GuessMIMETypeEnabled);
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

                if(publicRequest.IsSetLocationARN())
                {
                    context.Writer.WritePropertyName("LocationARN");
                    context.Writer.Write(publicRequest.LocationARN);
                }

                if(publicRequest.IsSetNFSFileShareDefaults())
                {
                    context.Writer.WritePropertyName("NFSFileShareDefaults");
                    context.Writer.WriteObjectStart();

                    var marshaller = NFSFileShareDefaultsMarshaller.Instance;
                    marshaller.Marshall(publicRequest.NFSFileShareDefaults, context);

                    context.Writer.WriteObjectEnd();
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

                if(publicRequest.IsSetRole())
                {
                    context.Writer.WritePropertyName("Role");
                    context.Writer.Write(publicRequest.Role);
                }

                if(publicRequest.IsSetSquash())
                {
                    context.Writer.WritePropertyName("Squash");
                    context.Writer.Write(publicRequest.Squash);
                }

                if(publicRequest.IsSetTags())
                {
                    context.Writer.WritePropertyName("Tags");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestTagsListValue in publicRequest.Tags)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = TagMarshaller.Instance;
                        marshaller.Marshall(publicRequestTagsListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static CreateNFSFileShareRequestMarshaller _instance = new CreateNFSFileShareRequestMarshaller();        

        internal static CreateNFSFileShareRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateNFSFileShareRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}