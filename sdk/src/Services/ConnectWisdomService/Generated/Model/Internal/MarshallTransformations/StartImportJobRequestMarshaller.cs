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
    /// StartImportJob Request Marshaller
    /// </summary>       
    public class StartImportJobRequestMarshaller : IMarshaller<IRequest, StartImportJobRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((StartImportJobRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(StartImportJobRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ConnectWisdomService");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2020-10-19";
            request.HttpMethod = "POST";

            if (!publicRequest.IsSetKnowledgeBaseId())
                throw new AmazonConnectWisdomServiceException("Request object does not have required field KnowledgeBaseId set");
            request.AddPathResource("{knowledgeBaseId}", StringUtils.FromString(publicRequest.KnowledgeBaseId));
            request.ResourcePath = "/knowledgeBases/{knowledgeBaseId}/importJobs";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.Validate = false;
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
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
                if(publicRequest.IsSetExternalSourceConfiguration())
                {
                    context.Writer.WritePropertyName("externalSourceConfiguration");
                    context.Writer.WriteObjectStart();

                    var marshaller = ExternalSourceConfigurationMarshaller.Instance;
                    marshaller.Marshall(publicRequest.ExternalSourceConfiguration, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetImportJobType())
                {
                    context.Writer.WritePropertyName("importJobType");
                    context.Writer.Write(publicRequest.ImportJobType);
                }

                if(publicRequest.IsSetMetadata())
                {
                    context.Writer.WritePropertyName("metadata");
                    context.Writer.WriteObjectStart();
                    foreach (var publicRequestMetadataKvp in publicRequest.Metadata)
                    {
                        context.Writer.WritePropertyName(publicRequestMetadataKvp.Key);
                        var publicRequestMetadataValue = publicRequestMetadataKvp.Value;

                            context.Writer.Write(publicRequestMetadataValue);
                    }
                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetUploadId())
                {
                    context.Writer.WritePropertyName("uploadId");
                    context.Writer.Write(publicRequest.UploadId);
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static StartImportJobRequestMarshaller _instance = new StartImportJobRequestMarshaller();        

        internal static StartImportJobRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static StartImportJobRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}