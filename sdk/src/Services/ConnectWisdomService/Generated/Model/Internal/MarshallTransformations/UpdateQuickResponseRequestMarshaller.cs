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
 * Do not modify this file. This file is generated from the wisdom-2020-10-19.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.ConnectWisdomService.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.ConnectWisdomService.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateQuickResponse Request Marshaller
    /// </summary>       
    public class UpdateQuickResponseRequestMarshaller : IMarshaller<IRequest, UpdateQuickResponseRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateQuickResponseRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateQuickResponseRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ConnectWisdomService");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2020-10-19";
            request.HttpMethod = "POST";

            if (!publicRequest.IsSetKnowledgeBaseId())
                throw new AmazonConnectWisdomServiceException("Request object does not have required field KnowledgeBaseId set");
            request.AddPathResource("{knowledgeBaseId}", StringUtils.FromString(publicRequest.KnowledgeBaseId));
            if (!publicRequest.IsSetQuickResponseId())
                throw new AmazonConnectWisdomServiceException("Request object does not have required field QuickResponseId set");
            request.AddPathResource("{quickResponseId}", StringUtils.FromString(publicRequest.QuickResponseId));
            request.ResourcePath = "/knowledgeBases/{knowledgeBaseId}/quickResponses/{quickResponseId}";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.Validate = false;
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetChannels())
                {
                    context.Writer.WritePropertyName("channels");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestChannelsListValue in publicRequest.Channels)
                    {
                            context.Writer.Write(publicRequestChannelsListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetContent())
                {
                    context.Writer.WritePropertyName("content");
                    context.Writer.WriteObjectStart();

                    var marshaller = QuickResponseDataProviderMarshaller.Instance;
                    marshaller.Marshall(publicRequest.Content, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetContentType())
                {
                    context.Writer.WritePropertyName("contentType");
                    context.Writer.Write(publicRequest.ContentType);
                }

                if(publicRequest.IsSetDescription())
                {
                    context.Writer.WritePropertyName("description");
                    context.Writer.Write(publicRequest.Description);
                }

                if(publicRequest.IsSetGroupingConfiguration())
                {
                    context.Writer.WritePropertyName("groupingConfiguration");
                    context.Writer.WriteObjectStart();

                    var marshaller = GroupingConfigurationMarshaller.Instance;
                    marshaller.Marshall(publicRequest.GroupingConfiguration, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetIsActive())
                {
                    context.Writer.WritePropertyName("isActive");
                    context.Writer.Write(publicRequest.IsActive);
                }

                if(publicRequest.IsSetLanguage())
                {
                    context.Writer.WritePropertyName("language");
                    context.Writer.Write(publicRequest.Language);
                }

                if(publicRequest.IsSetName())
                {
                    context.Writer.WritePropertyName("name");
                    context.Writer.Write(publicRequest.Name);
                }

                if(publicRequest.IsSetRemoveDescription())
                {
                    context.Writer.WritePropertyName("removeDescription");
                    context.Writer.Write(publicRequest.RemoveDescription);
                }

                if(publicRequest.IsSetRemoveGroupingConfiguration())
                {
                    context.Writer.WritePropertyName("removeGroupingConfiguration");
                    context.Writer.Write(publicRequest.RemoveGroupingConfiguration);
                }

                if(publicRequest.IsSetRemoveShortcutKey())
                {
                    context.Writer.WritePropertyName("removeShortcutKey");
                    context.Writer.Write(publicRequest.RemoveShortcutKey);
                }

                if(publicRequest.IsSetShortcutKey())
                {
                    context.Writer.WritePropertyName("shortcutKey");
                    context.Writer.Write(publicRequest.ShortcutKey);
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static UpdateQuickResponseRequestMarshaller _instance = new UpdateQuickResponseRequestMarshaller();        

        internal static UpdateQuickResponseRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateQuickResponseRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}
#pragma warning restore CS0612,CS0618