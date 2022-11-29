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
 * Do not modify this file. This file is generated from the securitylake-2018-05-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.SecurityLake.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.SecurityLake.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateSubscriptionNotificationConfiguration Request Marshaller
    /// </summary>       
    public class UpdateSubscriptionNotificationConfigurationRequestMarshaller : IMarshaller<IRequest, UpdateSubscriptionNotificationConfigurationRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateSubscriptionNotificationConfigurationRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateSubscriptionNotificationConfigurationRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.SecurityLake");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-05-10";
            request.HttpMethod = "PUT";

            if (!publicRequest.IsSetSubscriptionId())
                throw new AmazonSecurityLakeException("Request object does not have required field SubscriptionId set");
            request.AddPathResource("{subscriptionId}", StringUtils.FromString(publicRequest.SubscriptionId));
            request.ResourcePath = "/subscription-notifications/{subscriptionId}";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetCreateSqs())
                {
                    context.Writer.WritePropertyName("createSqs");
                    context.Writer.Write(publicRequest.CreateSqs);
                }

                if(publicRequest.IsSetHttpsApiKeyName())
                {
                    context.Writer.WritePropertyName("httpsApiKeyName");
                    context.Writer.Write(publicRequest.HttpsApiKeyName);
                }

                if(publicRequest.IsSetHttpsApiKeyValue())
                {
                    context.Writer.WritePropertyName("httpsApiKeyValue");
                    context.Writer.Write(publicRequest.HttpsApiKeyValue);
                }

                if(publicRequest.IsSetHttpsMethod())
                {
                    context.Writer.WritePropertyName("httpsMethod");
                    context.Writer.Write(publicRequest.HttpsMethod);
                }

                if(publicRequest.IsSetRoleArn())
                {
                    context.Writer.WritePropertyName("roleArn");
                    context.Writer.Write(publicRequest.RoleArn);
                }

                if(publicRequest.IsSetSubscriptionEndpoint())
                {
                    context.Writer.WritePropertyName("subscriptionEndpoint");
                    context.Writer.Write(publicRequest.SubscriptionEndpoint);
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static UpdateSubscriptionNotificationConfigurationRequestMarshaller _instance = new UpdateSubscriptionNotificationConfigurationRequestMarshaller();        

        internal static UpdateSubscriptionNotificationConfigurationRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateSubscriptionNotificationConfigurationRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}