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
using ThirdParty.Json.LitJson;

namespace Amazon.AppStream.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateUser Request Marshaller
    /// </summary>       
    public class CreateUserRequestMarshaller : IMarshaller<IRequest, CreateUserRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateUserRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateUserRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.AppStream");
            string target = "PhotonAdminProxyService.CreateUser";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2016-12-01";            
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
            request.MarshallerVersion = 2;
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetAuthenticationType())
                {
                    context.Writer.WritePropertyName("AuthenticationType");
                    context.Writer.Write(publicRequest.AuthenticationType);
                }

                if(publicRequest.IsSetFirstName())
                {
                    context.Writer.WritePropertyName("FirstName");
                    context.Writer.Write(publicRequest.FirstName);
                }

                if(publicRequest.IsSetLastName())
                {
                    context.Writer.WritePropertyName("LastName");
                    context.Writer.Write(publicRequest.LastName);
                }

                if(publicRequest.IsSetMessageAction())
                {
                    context.Writer.WritePropertyName("MessageAction");
                    context.Writer.Write(publicRequest.MessageAction);
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
        private static CreateUserRequestMarshaller _instance = new CreateUserRequestMarshaller();        

        internal static CreateUserRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateUserRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}