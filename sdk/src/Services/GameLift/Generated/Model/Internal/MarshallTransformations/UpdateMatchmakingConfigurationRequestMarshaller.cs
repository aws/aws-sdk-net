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
 * Do not modify this file. This file is generated from the gamelift-2015-10-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.GameLift.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.GameLift.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateMatchmakingConfiguration Request Marshaller
    /// </summary>       
    public class UpdateMatchmakingConfigurationRequestMarshaller : IMarshaller<IRequest, UpdateMatchmakingConfigurationRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateMatchmakingConfigurationRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateMatchmakingConfigurationRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.GameLift");
            string target = "GameLift.UpdateMatchmakingConfiguration";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2015-10-01";            
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
            request.MarshallerVersion = 2;
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetAcceptanceRequired())
                {
                    context.Writer.WritePropertyName("AcceptanceRequired");
                    context.Writer.Write(publicRequest.AcceptanceRequired);
                }

                if(publicRequest.IsSetAcceptanceTimeoutSeconds())
                {
                    context.Writer.WritePropertyName("AcceptanceTimeoutSeconds");
                    context.Writer.Write(publicRequest.AcceptanceTimeoutSeconds);
                }

                if(publicRequest.IsSetAdditionalPlayerCount())
                {
                    context.Writer.WritePropertyName("AdditionalPlayerCount");
                    context.Writer.Write(publicRequest.AdditionalPlayerCount);
                }

                if(publicRequest.IsSetBackfillMode())
                {
                    context.Writer.WritePropertyName("BackfillMode");
                    context.Writer.Write(publicRequest.BackfillMode);
                }

                if(publicRequest.IsSetCustomEventData())
                {
                    context.Writer.WritePropertyName("CustomEventData");
                    context.Writer.Write(publicRequest.CustomEventData);
                }

                if(publicRequest.IsSetDescription())
                {
                    context.Writer.WritePropertyName("Description");
                    context.Writer.Write(publicRequest.Description);
                }

                if(publicRequest.IsSetFlexMatchMode())
                {
                    context.Writer.WritePropertyName("FlexMatchMode");
                    context.Writer.Write(publicRequest.FlexMatchMode);
                }

                if(publicRequest.IsSetGameProperties())
                {
                    context.Writer.WritePropertyName("GameProperties");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestGamePropertiesListValue in publicRequest.GameProperties)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = GamePropertyMarshaller.Instance;
                        marshaller.Marshall(publicRequestGamePropertiesListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetGameSessionData())
                {
                    context.Writer.WritePropertyName("GameSessionData");
                    context.Writer.Write(publicRequest.GameSessionData);
                }

                if(publicRequest.IsSetGameSessionQueueArns())
                {
                    context.Writer.WritePropertyName("GameSessionQueueArns");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestGameSessionQueueArnsListValue in publicRequest.GameSessionQueueArns)
                    {
                            context.Writer.Write(publicRequestGameSessionQueueArnsListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetName())
                {
                    context.Writer.WritePropertyName("Name");
                    context.Writer.Write(publicRequest.Name);
                }

                if(publicRequest.IsSetNotificationTarget())
                {
                    context.Writer.WritePropertyName("NotificationTarget");
                    context.Writer.Write(publicRequest.NotificationTarget);
                }

                if(publicRequest.IsSetRequestTimeoutSeconds())
                {
                    context.Writer.WritePropertyName("RequestTimeoutSeconds");
                    context.Writer.Write(publicRequest.RequestTimeoutSeconds);
                }

                if(publicRequest.IsSetRuleSetName())
                {
                    context.Writer.WritePropertyName("RuleSetName");
                    context.Writer.Write(publicRequest.RuleSetName);
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static UpdateMatchmakingConfigurationRequestMarshaller _instance = new UpdateMatchmakingConfigurationRequestMarshaller();        

        internal static UpdateMatchmakingConfigurationRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateMatchmakingConfigurationRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}