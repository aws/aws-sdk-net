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
 * Do not modify this file. This file is generated from the bedrock-agent-2023-06-05.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.BedrockAgent.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.BedrockAgent.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateDataSource Request Marshaller
    /// </summary>       
    public class UpdateDataSourceRequestMarshaller : IMarshaller<IRequest, UpdateDataSourceRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateDataSourceRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateDataSourceRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.BedrockAgent");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2023-06-05";
            request.HttpMethod = "PUT";

            if (!publicRequest.IsSetDataSourceId())
                throw new AmazonBedrockAgentException("Request object does not have required field DataSourceId set");
            request.AddPathResource("{dataSourceId}", StringUtils.FromString(publicRequest.DataSourceId));
            if (!publicRequest.IsSetKnowledgeBaseId())
                throw new AmazonBedrockAgentException("Request object does not have required field KnowledgeBaseId set");
            request.AddPathResource("{knowledgeBaseId}", StringUtils.FromString(publicRequest.KnowledgeBaseId));
            request.ResourcePath = "/knowledgebases/{knowledgeBaseId}/datasources/{dataSourceId}";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.Validate = false;
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetDataDeletionPolicy())
                {
                    context.Writer.WritePropertyName("dataDeletionPolicy");
                    context.Writer.Write(publicRequest.DataDeletionPolicy);
                }

                if(publicRequest.IsSetDataSourceConfiguration())
                {
                    context.Writer.WritePropertyName("dataSourceConfiguration");
                    context.Writer.WriteObjectStart();

                    var marshaller = DataSourceConfigurationMarshaller.Instance;
                    marshaller.Marshall(publicRequest.DataSourceConfiguration, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetDescription())
                {
                    context.Writer.WritePropertyName("description");
                    context.Writer.Write(publicRequest.Description);
                }

                if(publicRequest.IsSetName())
                {
                    context.Writer.WritePropertyName("name");
                    context.Writer.Write(publicRequest.Name);
                }

                if(publicRequest.IsSetServerSideEncryptionConfiguration())
                {
                    context.Writer.WritePropertyName("serverSideEncryptionConfiguration");
                    context.Writer.WriteObjectStart();

                    var marshaller = ServerSideEncryptionConfigurationMarshaller.Instance;
                    marshaller.Marshall(publicRequest.ServerSideEncryptionConfiguration, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetVectorIngestionConfiguration())
                {
                    context.Writer.WritePropertyName("vectorIngestionConfiguration");
                    context.Writer.WriteObjectStart();

                    var marshaller = VectorIngestionConfigurationMarshaller.Instance;
                    marshaller.Marshall(publicRequest.VectorIngestionConfiguration, context);

                    context.Writer.WriteObjectEnd();
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static UpdateDataSourceRequestMarshaller _instance = new UpdateDataSourceRequestMarshaller();        

        internal static UpdateDataSourceRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateDataSourceRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}