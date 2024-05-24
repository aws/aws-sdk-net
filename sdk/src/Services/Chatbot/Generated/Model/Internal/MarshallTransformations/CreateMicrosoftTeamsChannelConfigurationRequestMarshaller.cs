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
    /// CreateMicrosoftTeamsChannelConfiguration Request Marshaller
    /// </summary>       
    public class CreateMicrosoftTeamsChannelConfigurationRequestMarshaller : IMarshaller<IRequest, CreateMicrosoftTeamsChannelConfigurationRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateMicrosoftTeamsChannelConfigurationRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateMicrosoftTeamsChannelConfigurationRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Chatbot");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2017-10-11";
            request.HttpMethod = "POST";

            request.ResourcePath = "/create-ms-teams-channel-configuration";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.Validate = false;
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetChannelId())
                {
                    context.Writer.WritePropertyName("ChannelId");
                    context.Writer.Write(publicRequest.ChannelId);
                }

                if(publicRequest.IsSetChannelName())
                {
                    context.Writer.WritePropertyName("ChannelName");
                    context.Writer.Write(publicRequest.ChannelName);
                }

                if(publicRequest.IsSetConfigurationName())
                {
                    context.Writer.WritePropertyName("ConfigurationName");
                    context.Writer.Write(publicRequest.ConfigurationName);
                }

                if(publicRequest.IsSetGuardrailPolicyArns())
                {
                    context.Writer.WritePropertyName("GuardrailPolicyArns");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestGuardrailPolicyArnsListValue in publicRequest.GuardrailPolicyArns)
                    {
                            context.Writer.Write(publicRequestGuardrailPolicyArnsListValue);
                    }
                    context.Writer.WriteArrayEnd();
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

                if(publicRequest.IsSetTeamId())
                {
                    context.Writer.WritePropertyName("TeamId");
                    context.Writer.Write(publicRequest.TeamId);
                }

                if(publicRequest.IsSetTeamName())
                {
                    context.Writer.WritePropertyName("TeamName");
                    context.Writer.Write(publicRequest.TeamName);
                }

                if(publicRequest.IsSetTenantId())
                {
                    context.Writer.WritePropertyName("TenantId");
                    context.Writer.Write(publicRequest.TenantId);
                }

                if(publicRequest.IsSetUserAuthorizationRequired())
                {
                    context.Writer.WritePropertyName("UserAuthorizationRequired");
                    context.Writer.Write(publicRequest.UserAuthorizationRequired);
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static CreateMicrosoftTeamsChannelConfigurationRequestMarshaller _instance = new CreateMicrosoftTeamsChannelConfigurationRequestMarshaller();        

        internal static CreateMicrosoftTeamsChannelConfigurationRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateMicrosoftTeamsChannelConfigurationRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}