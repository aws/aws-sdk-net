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
 * Do not modify this file. This file is generated from the support-app-2021-08-20.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.SupportApp.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.SupportApp.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateSlackChannelConfiguration Request Marshaller
    /// </summary>       
    public class UpdateSlackChannelConfigurationRequestMarshaller : IMarshaller<IRequest, UpdateSlackChannelConfigurationRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateSlackChannelConfigurationRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateSlackChannelConfigurationRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.SupportApp");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2021-08-20";
            request.HttpMethod = "POST";

            request.ResourcePath = "/control/update-slack-channel-configuration";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetChannelId())
                {
                    context.Writer.WritePropertyName("channelId");
                    context.Writer.Write(publicRequest.ChannelId);
                }

                if(publicRequest.IsSetChannelName())
                {
                    context.Writer.WritePropertyName("channelName");
                    context.Writer.Write(publicRequest.ChannelName);
                }

                if(publicRequest.IsSetChannelRoleArn())
                {
                    context.Writer.WritePropertyName("channelRoleArn");
                    context.Writer.Write(publicRequest.ChannelRoleArn);
                }

                if(publicRequest.IsSetNotifyOnAddCorrespondenceToCase())
                {
                    context.Writer.WritePropertyName("notifyOnAddCorrespondenceToCase");
                    context.Writer.Write(publicRequest.NotifyOnAddCorrespondenceToCase);
                }

                if(publicRequest.IsSetNotifyOnCaseSeverity())
                {
                    context.Writer.WritePropertyName("notifyOnCaseSeverity");
                    context.Writer.Write(publicRequest.NotifyOnCaseSeverity);
                }

                if(publicRequest.IsSetNotifyOnCreateOrReopenCase())
                {
                    context.Writer.WritePropertyName("notifyOnCreateOrReopenCase");
                    context.Writer.Write(publicRequest.NotifyOnCreateOrReopenCase);
                }

                if(publicRequest.IsSetNotifyOnResolveCase())
                {
                    context.Writer.WritePropertyName("notifyOnResolveCase");
                    context.Writer.Write(publicRequest.NotifyOnResolveCase);
                }

                if(publicRequest.IsSetTeamId())
                {
                    context.Writer.WritePropertyName("teamId");
                    context.Writer.Write(publicRequest.TeamId);
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static UpdateSlackChannelConfigurationRequestMarshaller _instance = new UpdateSlackChannelConfigurationRequestMarshaller();        

        internal static UpdateSlackChannelConfigurationRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateSlackChannelConfigurationRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}