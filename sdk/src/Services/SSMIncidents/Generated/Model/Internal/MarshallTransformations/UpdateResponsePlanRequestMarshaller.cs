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
 * Do not modify this file. This file is generated from the ssm-incidents-2018-05-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.SSMIncidents.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.SSMIncidents.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateResponsePlan Request Marshaller
    /// </summary>       
    public class UpdateResponsePlanRequestMarshaller : IMarshaller<IRequest, UpdateResponsePlanRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateResponsePlanRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateResponsePlanRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.SSMIncidents");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-05-10";
            request.HttpMethod = "POST";

            request.ResourcePath = "/updateResponsePlan";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetActions())
                {
                    context.Writer.WritePropertyName("actions");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestActionsListValue in publicRequest.Actions)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = ActionMarshaller.Instance;
                        marshaller.Marshall(publicRequestActionsListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetArn())
                {
                    context.Writer.WritePropertyName("arn");
                    context.Writer.Write(publicRequest.Arn);
                }

                if(publicRequest.IsSetChatChannel())
                {
                    context.Writer.WritePropertyName("chatChannel");
                    context.Writer.WriteObjectStart();

                    var marshaller = ChatChannelMarshaller.Instance;
                    marshaller.Marshall(publicRequest.ChatChannel, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetClientToken())
                {
                    context.Writer.WritePropertyName("clientToken");
                    context.Writer.Write(publicRequest.ClientToken);
                }

                else if(!(publicRequest.IsSetClientToken()))
                {
                    context.Writer.WritePropertyName("clientToken");
                    context.Writer.Write(Guid.NewGuid().ToString());
                }
                if(publicRequest.IsSetDisplayName())
                {
                    context.Writer.WritePropertyName("displayName");
                    context.Writer.Write(publicRequest.DisplayName);
                }

                if(publicRequest.IsSetEngagements())
                {
                    context.Writer.WritePropertyName("engagements");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestEngagementsListValue in publicRequest.Engagements)
                    {
                            context.Writer.Write(publicRequestEngagementsListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetIncidentTemplateDedupeString())
                {
                    context.Writer.WritePropertyName("incidentTemplateDedupeString");
                    context.Writer.Write(publicRequest.IncidentTemplateDedupeString);
                }

                if(publicRequest.IsSetIncidentTemplateImpact())
                {
                    context.Writer.WritePropertyName("incidentTemplateImpact");
                    context.Writer.Write(publicRequest.IncidentTemplateImpact);
                }

                if(publicRequest.IsSetIncidentTemplateNotificationTargets())
                {
                    context.Writer.WritePropertyName("incidentTemplateNotificationTargets");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestIncidentTemplateNotificationTargetsListValue in publicRequest.IncidentTemplateNotificationTargets)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = NotificationTargetItemMarshaller.Instance;
                        marshaller.Marshall(publicRequestIncidentTemplateNotificationTargetsListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetIncidentTemplateSummary())
                {
                    context.Writer.WritePropertyName("incidentTemplateSummary");
                    context.Writer.Write(publicRequest.IncidentTemplateSummary);
                }

                if(publicRequest.IsSetIncidentTemplateTags())
                {
                    context.Writer.WritePropertyName("incidentTemplateTags");
                    context.Writer.WriteObjectStart();
                    foreach (var publicRequestIncidentTemplateTagsKvp in publicRequest.IncidentTemplateTags)
                    {
                        context.Writer.WritePropertyName(publicRequestIncidentTemplateTagsKvp.Key);
                        var publicRequestIncidentTemplateTagsValue = publicRequestIncidentTemplateTagsKvp.Value;

                            context.Writer.Write(publicRequestIncidentTemplateTagsValue);
                    }
                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetIncidentTemplateTitle())
                {
                    context.Writer.WritePropertyName("incidentTemplateTitle");
                    context.Writer.Write(publicRequest.IncidentTemplateTitle);
                }

                if(publicRequest.IsSetIntegrations())
                {
                    context.Writer.WritePropertyName("integrations");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestIntegrationsListValue in publicRequest.Integrations)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = IntegrationMarshaller.Instance;
                        marshaller.Marshall(publicRequestIntegrationsListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static UpdateResponsePlanRequestMarshaller _instance = new UpdateResponsePlanRequestMarshaller();        

        internal static UpdateResponsePlanRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateResponsePlanRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}