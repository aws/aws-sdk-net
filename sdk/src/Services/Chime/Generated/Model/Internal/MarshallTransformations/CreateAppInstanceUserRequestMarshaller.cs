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
 * Do not modify this file. This file is generated from the chime-2018-05-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Chime.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Chime.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateAppInstanceUser Request Marshaller
    /// </summary>       
    public class CreateAppInstanceUserRequestMarshaller : IMarshaller<IRequest, CreateAppInstanceUserRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateAppInstanceUserRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateAppInstanceUserRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Chime");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-05-01";            
            request.HttpMethod = "POST";

            request.ResourcePath = "/app-instance-users";
            request.MarshallerVersion = 2;
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetAppInstanceArn())
                {
                    context.Writer.WritePropertyName("AppInstanceArn");
                    context.Writer.Write(publicRequest.AppInstanceArn);
                }

                if(publicRequest.IsSetAppInstanceUserId())
                {
                    context.Writer.WritePropertyName("AppInstanceUserId");
                    context.Writer.Write(publicRequest.AppInstanceUserId);
                }

                if(publicRequest.IsSetClientRequestToken())
                {
                    context.Writer.WritePropertyName("ClientRequestToken");
                    context.Writer.Write(publicRequest.ClientRequestToken);
                }

                else if(!(publicRequest.IsSetClientRequestToken()))
                {
                    context.Writer.WritePropertyName("ClientRequestToken");
                    context.Writer.Write(Guid.NewGuid().ToString());                                                
                }
                if(publicRequest.IsSetMetadata())
                {
                    context.Writer.WritePropertyName("Metadata");
                    context.Writer.Write(publicRequest.Metadata);
                }

                if(publicRequest.IsSetName())
                {
                    context.Writer.WritePropertyName("Name");
                    context.Writer.Write(publicRequest.Name);
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }

            
            request.HostPrefix = $"identity-";

            return request;
        }
        private static CreateAppInstanceUserRequestMarshaller _instance = new CreateAppInstanceUserRequestMarshaller();        

        internal static CreateAppInstanceUserRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateAppInstanceUserRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}