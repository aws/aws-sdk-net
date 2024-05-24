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
 * Do not modify this file. This file is generated from the qbusiness-2023-11-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.QBusiness.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.QBusiness.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateChatControlsConfiguration Request Marshaller
    /// </summary>       
    public class UpdateChatControlsConfigurationRequestMarshaller : IMarshaller<IRequest, UpdateChatControlsConfigurationRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateChatControlsConfigurationRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateChatControlsConfigurationRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.QBusiness");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2023-11-27";
            request.HttpMethod = "PATCH";

            if (!publicRequest.IsSetApplicationId())
                throw new AmazonQBusinessException("Request object does not have required field ApplicationId set");
            request.AddPathResource("{applicationId}", StringUtils.FromString(publicRequest.ApplicationId));
            request.ResourcePath = "/applications/{applicationId}/chatcontrols";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.Validate = false;
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetBlockedPhrasesConfigurationUpdate())
                {
                    context.Writer.WritePropertyName("blockedPhrasesConfigurationUpdate");
                    context.Writer.WriteObjectStart();

                    var marshaller = BlockedPhrasesConfigurationUpdateMarshaller.Instance;
                    marshaller.Marshall(publicRequest.BlockedPhrasesConfigurationUpdate, context);

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
                if(publicRequest.IsSetCreatorModeConfiguration())
                {
                    context.Writer.WritePropertyName("creatorModeConfiguration");
                    context.Writer.WriteObjectStart();

                    var marshaller = CreatorModeConfigurationMarshaller.Instance;
                    marshaller.Marshall(publicRequest.CreatorModeConfiguration, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetResponseScope())
                {
                    context.Writer.WritePropertyName("responseScope");
                    context.Writer.Write(publicRequest.ResponseScope);
                }

                if(publicRequest.IsSetTopicConfigurationsToCreateOrUpdate())
                {
                    context.Writer.WritePropertyName("topicConfigurationsToCreateOrUpdate");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestTopicConfigurationsToCreateOrUpdateListValue in publicRequest.TopicConfigurationsToCreateOrUpdate)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = TopicConfigurationMarshaller.Instance;
                        marshaller.Marshall(publicRequestTopicConfigurationsToCreateOrUpdateListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetTopicConfigurationsToDelete())
                {
                    context.Writer.WritePropertyName("topicConfigurationsToDelete");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestTopicConfigurationsToDeleteListValue in publicRequest.TopicConfigurationsToDelete)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = TopicConfigurationMarshaller.Instance;
                        marshaller.Marshall(publicRequestTopicConfigurationsToDeleteListValue, context);

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
        private static UpdateChatControlsConfigurationRequestMarshaller _instance = new UpdateChatControlsConfigurationRequestMarshaller();        

        internal static UpdateChatControlsConfigurationRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateChatControlsConfigurationRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}