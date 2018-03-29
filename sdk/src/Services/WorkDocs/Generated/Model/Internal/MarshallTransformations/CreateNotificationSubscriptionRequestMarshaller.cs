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
 * Do not modify this file. This file is generated from the workdocs-2016-05-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.WorkDocs.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.WorkDocs.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateNotificationSubscription Request Marshaller
    /// </summary>       
    public class CreateNotificationSubscriptionRequestMarshaller : IMarshaller<IRequest, CreateNotificationSubscriptionRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateNotificationSubscriptionRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateNotificationSubscriptionRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.WorkDocs");
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.HttpMethod = "POST";

            string uriResourcePath = "/api/v1/organizations/{OrganizationId}/subscriptions";
            if (!publicRequest.IsSetOrganizationId())
                throw new AmazonWorkDocsException("Request object does not have required field OrganizationId set");
            uriResourcePath = uriResourcePath.Replace("{OrganizationId}", StringUtils.FromString(publicRequest.OrganizationId));
            request.ResourcePath = uriResourcePath;
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetEndpoint())
                {
                    context.Writer.WritePropertyName("Endpoint");
                    context.Writer.Write(publicRequest.Endpoint);
                }

                if(publicRequest.IsSetProtocol())
                {
                    context.Writer.WritePropertyName("Protocol");
                    context.Writer.Write(publicRequest.Protocol);
                }

                if(publicRequest.IsSetSubscriptionType())
                {
                    context.Writer.WritePropertyName("SubscriptionType");
                    context.Writer.Write(publicRequest.SubscriptionType);
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static CreateNotificationSubscriptionRequestMarshaller _instance = new CreateNotificationSubscriptionRequestMarshaller();        

        internal static CreateNotificationSubscriptionRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateNotificationSubscriptionRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}