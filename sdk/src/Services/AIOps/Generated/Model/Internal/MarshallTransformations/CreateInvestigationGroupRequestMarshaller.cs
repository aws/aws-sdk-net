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
 * Do not modify this file. This file is generated from the aiops-2018-05-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.AIOps.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.AIOps.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateInvestigationGroup Request Marshaller
    /// </summary>       
    public class CreateInvestigationGroupRequestMarshaller : IMarshaller<IRequest, CreateInvestigationGroupRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateInvestigationGroupRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateInvestigationGroupRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.AIOps");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-05-10";
            request.HttpMethod = "POST";

            request.ResourcePath = "/investigationGroups";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.Validate = false;
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetChatbotNotificationChannel())
                {
                    context.Writer.WritePropertyName("chatbotNotificationChannel");
                    context.Writer.WriteObjectStart();
                    foreach (var publicRequestChatbotNotificationChannelKvp in publicRequest.ChatbotNotificationChannel)
                    {
                        context.Writer.WritePropertyName(publicRequestChatbotNotificationChannelKvp.Key);
                        var publicRequestChatbotNotificationChannelValue = publicRequestChatbotNotificationChannelKvp.Value;

                        context.Writer.WriteArrayStart();
                        foreach(var publicRequestChatbotNotificationChannelValueListValue in publicRequestChatbotNotificationChannelValue)
                        {
                                context.Writer.Write(publicRequestChatbotNotificationChannelValueListValue);
                        }
                        context.Writer.WriteArrayEnd();
                    }
                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetCrossAccountConfigurations())
                {
                    context.Writer.WritePropertyName("crossAccountConfigurations");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestCrossAccountConfigurationsListValue in publicRequest.CrossAccountConfigurations)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = CrossAccountConfigurationMarshaller.Instance;
                        marshaller.Marshall(publicRequestCrossAccountConfigurationsListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetEncryptionConfiguration())
                {
                    context.Writer.WritePropertyName("encryptionConfiguration");
                    context.Writer.WriteObjectStart();

                    var marshaller = EncryptionConfigurationMarshaller.Instance;
                    marshaller.Marshall(publicRequest.EncryptionConfiguration, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetIsCloudTrailEventHistoryEnabled())
                {
                    context.Writer.WritePropertyName("isCloudTrailEventHistoryEnabled");
                    context.Writer.Write(publicRequest.IsCloudTrailEventHistoryEnabled);
                }

                if(publicRequest.IsSetName())
                {
                    context.Writer.WritePropertyName("name");
                    context.Writer.Write(publicRequest.Name);
                }

                if(publicRequest.IsSetRetentionInDays())
                {
                    context.Writer.WritePropertyName("retentionInDays");
                    context.Writer.Write(publicRequest.RetentionInDays);
                }

                if(publicRequest.IsSetRoleArn())
                {
                    context.Writer.WritePropertyName("roleArn");
                    context.Writer.Write(publicRequest.RoleArn);
                }

                if(publicRequest.IsSetTagKeyBoundaries())
                {
                    context.Writer.WritePropertyName("tagKeyBoundaries");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestTagKeyBoundariesListValue in publicRequest.TagKeyBoundaries)
                    {
                            context.Writer.Write(publicRequestTagKeyBoundariesListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetTags())
                {
                    context.Writer.WritePropertyName("tags");
                    context.Writer.WriteObjectStart();
                    foreach (var publicRequestTagsKvp in publicRequest.Tags)
                    {
                        context.Writer.WritePropertyName(publicRequestTagsKvp.Key);
                        var publicRequestTagsValue = publicRequestTagsKvp.Value;

                            context.Writer.Write(publicRequestTagsValue);
                    }
                    context.Writer.WriteObjectEnd();
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static CreateInvestigationGroupRequestMarshaller _instance = new CreateInvestigationGroupRequestMarshaller();        

        internal static CreateInvestigationGroupRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateInvestigationGroupRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}