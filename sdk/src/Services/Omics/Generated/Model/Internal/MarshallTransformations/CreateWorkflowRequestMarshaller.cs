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
 * Do not modify this file. This file is generated from the omics-2022-11-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Omics.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Omics.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateWorkflow Request Marshaller
    /// </summary>       
    public class CreateWorkflowRequestMarshaller : IMarshaller<IRequest, CreateWorkflowRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateWorkflowRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateWorkflowRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Omics");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2022-11-28";
            request.HttpMethod = "POST";

            request.ResourcePath = "/workflow";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetDefinitionUri())
                {
                    context.Writer.WritePropertyName("definitionUri");
                    context.Writer.Write(publicRequest.DefinitionUri);
                }

                if(publicRequest.IsSetDefinitionZip())
                {
                    context.Writer.WritePropertyName("definitionZip");
                    context.Writer.Write(StringUtils.FromMemoryStream(publicRequest.DefinitionZip));
                }

                if(publicRequest.IsSetDescription())
                {
                    context.Writer.WritePropertyName("description");
                    context.Writer.Write(publicRequest.Description);
                }

                if(publicRequest.IsSetEngine())
                {
                    context.Writer.WritePropertyName("engine");
                    context.Writer.Write(publicRequest.Engine);
                }

                if(publicRequest.IsSetMain())
                {
                    context.Writer.WritePropertyName("main");
                    context.Writer.Write(publicRequest.Main);
                }

                if(publicRequest.IsSetName())
                {
                    context.Writer.WritePropertyName("name");
                    context.Writer.Write(publicRequest.Name);
                }

                if(publicRequest.IsSetParameterTemplate())
                {
                    context.Writer.WritePropertyName("parameterTemplate");
                    context.Writer.WriteObjectStart();
                    foreach (var publicRequestParameterTemplateKvp in publicRequest.ParameterTemplate)
                    {
                        context.Writer.WritePropertyName(publicRequestParameterTemplateKvp.Key);
                        var publicRequestParameterTemplateValue = publicRequestParameterTemplateKvp.Value;

                        context.Writer.WriteObjectStart();

                        var marshaller = WorkflowParameterMarshaller.Instance;
                        marshaller.Marshall(publicRequestParameterTemplateValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetRequestId())
                {
                    context.Writer.WritePropertyName("requestId");
                    context.Writer.Write(publicRequest.RequestId);
                }

                else if(!(publicRequest.IsSetRequestId()))
                {
                    context.Writer.WritePropertyName("requestId");
                    context.Writer.Write(Guid.NewGuid().ToString());
                }
                if(publicRequest.IsSetStorageCapacity())
                {
                    context.Writer.WritePropertyName("storageCapacity");
                    context.Writer.Write(publicRequest.StorageCapacity);
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

            
            request.HostPrefix = $"workflows-";

            return request;
        }
        private static CreateWorkflowRequestMarshaller _instance = new CreateWorkflowRequestMarshaller();        

        internal static CreateWorkflowRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateWorkflowRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}