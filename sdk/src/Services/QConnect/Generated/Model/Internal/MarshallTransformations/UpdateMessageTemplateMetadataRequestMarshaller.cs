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
 * Do not modify this file. This file is generated from the qconnect-2020-10-19.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.QConnect.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.QConnect.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateMessageTemplateMetadata Request Marshaller
    /// </summary>       
    public class UpdateMessageTemplateMetadataRequestMarshaller : IMarshaller<IRequest, UpdateMessageTemplateMetadataRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateMessageTemplateMetadataRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateMessageTemplateMetadataRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.QConnect");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2020-10-19";
            request.HttpMethod = "POST";

            if (!publicRequest.IsSetKnowledgeBaseId())
                throw new AmazonQConnectException("Request object does not have required field KnowledgeBaseId set");
            request.AddPathResource("{knowledgeBaseId}", StringUtils.FromString(publicRequest.KnowledgeBaseId));
            if (!publicRequest.IsSetMessageTemplateId())
                throw new AmazonQConnectException("Request object does not have required field MessageTemplateId set");
            request.AddPathResource("{messageTemplateId}", StringUtils.FromString(publicRequest.MessageTemplateId));
            request.ResourcePath = "/knowledgeBases/{knowledgeBaseId}/messageTemplates/{messageTemplateId}/metadata";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.Validate = false;
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
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

                if(publicRequest.IsSetName())
                {
                    context.Writer.WritePropertyName("name");
                    context.Writer.Write(publicRequest.Name);
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static UpdateMessageTemplateMetadataRequestMarshaller _instance = new UpdateMessageTemplateMetadataRequestMarshaller();        

        internal static UpdateMessageTemplateMetadataRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateMessageTemplateMetadataRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}