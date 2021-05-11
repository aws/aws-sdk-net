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
 * Do not modify this file. This file is generated from the ssm-contacts-2021-05-03.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.SSMContacts.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.SSMContacts.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// StartEngagement Request Marshaller
    /// </summary>       
    public class StartEngagementRequestMarshaller : IMarshaller<IRequest, StartEngagementRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((StartEngagementRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(StartEngagementRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.SSMContacts");
            string target = "SSMContacts.StartEngagement";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2021-05-03";            
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetContactId())
                {
                    context.Writer.WritePropertyName("ContactId");
                    context.Writer.Write(publicRequest.ContactId);
                }

                if(publicRequest.IsSetContent())
                {
                    context.Writer.WritePropertyName("Content");
                    context.Writer.Write(publicRequest.Content);
                }

                if(publicRequest.IsSetIdempotencyToken())
                {
                    context.Writer.WritePropertyName("IdempotencyToken");
                    context.Writer.Write(publicRequest.IdempotencyToken);
                }

                else if(!(publicRequest.IsSetIdempotencyToken()))
                {
                    context.Writer.WritePropertyName("IdempotencyToken");
                    context.Writer.Write(Guid.NewGuid().ToString());                                                
                }
                if(publicRequest.IsSetIncidentId())
                {
                    context.Writer.WritePropertyName("IncidentId");
                    context.Writer.Write(publicRequest.IncidentId);
                }

                if(publicRequest.IsSetPublicContent())
                {
                    context.Writer.WritePropertyName("PublicContent");
                    context.Writer.Write(publicRequest.PublicContent);
                }

                if(publicRequest.IsSetPublicSubject())
                {
                    context.Writer.WritePropertyName("PublicSubject");
                    context.Writer.Write(publicRequest.PublicSubject);
                }

                if(publicRequest.IsSetSender())
                {
                    context.Writer.WritePropertyName("Sender");
                    context.Writer.Write(publicRequest.Sender);
                }

                if(publicRequest.IsSetSubject())
                {
                    context.Writer.WritePropertyName("Subject");
                    context.Writer.Write(publicRequest.Subject);
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static StartEngagementRequestMarshaller _instance = new StartEngagementRequestMarshaller();        

        internal static StartEngagementRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static StartEngagementRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}