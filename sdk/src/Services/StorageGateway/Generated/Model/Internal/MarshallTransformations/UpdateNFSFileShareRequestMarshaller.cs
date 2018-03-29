/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
            request.HttpMethod = "POST";

            string uriResourcePath = "/";
            request.ResourcePath = uriResourcePath;
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
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

                if(publicRequest.IsSetNFSFileShareDefaults())
                {
                    context.Writer.WritePropertyName("NFSFileShareDefaults");
                    context.Writer.WriteObjectStart();

                    var marshaller = NFSFileShareDefaultsMarshaller.Instance;
                    marshaller.Marshall(publicRequest.NFSFileShareDefaults, context);

                    context.Writer.WriteObjectEnd();
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

                if(publicRequest.IsSetSquash())
                {
                    context.Writer.WritePropertyName("Squash");
                    context.Writer.Write(publicRequest.Squash);
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


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