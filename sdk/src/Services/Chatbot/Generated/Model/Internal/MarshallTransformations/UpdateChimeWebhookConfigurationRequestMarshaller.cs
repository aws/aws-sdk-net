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
 * Do not modify this file. This file is generated from the chatbot-2017-10-11.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Chatbot.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.Chatbot.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateChimeWebhookConfiguration Request Marshaller
    /// </summary>       
    public class UpdateChimeWebhookConfigurationRequestMarshaller : IMarshaller<IRequest, UpdateChimeWebhookConfigurationRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateChimeWebhookConfigurationRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateChimeWebhookConfigurationRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Chatbot");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2017-10-11";
            request.HttpMethod = "POST";

            request.ResourcePath = "/update-chime-webhook-configuration";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.Validate = false;
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetChatConfigurationArn())
                {
                    context.Writer.WritePropertyName("ChatConfigurationArn");
                    context.Writer.Write(publicRequest.ChatConfigurationArn);
                }

                if(publicRequest.IsSetIamRoleArn())
                {
                    context.Writer.WritePropertyName("IamRoleArn");
                    context.Writer.Write(publicRequest.IamRoleArn);
                }

                if(publicRequest.IsSetLoggingLevel())
                {
                    context.Writer.WritePropertyName("LoggingLevel");
                    context.Writer.Write(publicRequest.LoggingLevel);
                }

                if(publicRequest.IsSetSnsTopicArns())
                {
                    context.Writer.WritePropertyName("SnsTopicArns");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestSnsTopicArnsListValue in publicRequest.SnsTopicArns)
                    {
                            context.Writer.Write(publicRequestSnsTopicArnsListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetWebhookDescription())
                {
                    context.Writer.WritePropertyName("WebhookDescription");
                    context.Writer.Write(publicRequest.WebhookDescription);
                }

                if(publicRequest.IsSetWebhookUrl())
                {
                    context.Writer.WritePropertyName("WebhookUrl");
                    context.Writer.Write(publicRequest.WebhookUrl);
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static UpdateChimeWebhookConfigurationRequestMarshaller _instance = new UpdateChimeWebhookConfigurationRequestMarshaller();        

        internal static UpdateChimeWebhookConfigurationRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateChimeWebhookConfigurationRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}