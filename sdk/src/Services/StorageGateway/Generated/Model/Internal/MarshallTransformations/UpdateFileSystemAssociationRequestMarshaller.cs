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
    /// UpdateFileSystemAssociation Request Marshaller
    /// </summary>       
    public class UpdateFileSystemAssociationRequestMarshaller : IMarshaller<IRequest, UpdateFileSystemAssociationRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateFileSystemAssociationRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateFileSystemAssociationRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.StorageGateway");
            string target = "StorageGateway_20130630.UpdateFileSystemAssociation";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2013-06-30";            
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
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

                if(publicRequest.IsSetFileSystemAssociationARN())
                {
                    context.Writer.WritePropertyName("FileSystemAssociationARN");
                    context.Writer.Write(publicRequest.FileSystemAssociationARN);
                }

                if(publicRequest.IsSetPassword())
                {
                    context.Writer.WritePropertyName("Password");
                    context.Writer.Write(publicRequest.Password);
                }

                if(publicRequest.IsSetUserName())
                {
                    context.Writer.WritePropertyName("UserName");
                    context.Writer.Write(publicRequest.UserName);
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static UpdateFileSystemAssociationRequestMarshaller _instance = new UpdateFileSystemAssociationRequestMarshaller();        

        internal static UpdateFileSystemAssociationRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateFileSystemAssociationRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}