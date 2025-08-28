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
using System.Text.Json;
using System.Buffers;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618
namespace Amazon.Omics.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateWorkflowVersion Request Marshaller
    /// </summary>       
    public class CreateWorkflowVersionRequestMarshaller : IMarshaller<IRequest, CreateWorkflowVersionRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateWorkflowVersionRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateWorkflowVersionRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Omics");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2022-11-28";
            request.HttpMethod = "POST";

            if (!publicRequest.IsSetWorkflowId())
                throw new AmazonOmicsException("Request object does not have required field WorkflowId set");
            request.AddPathResource("{workflowId}", StringUtils.FromString(publicRequest.WorkflowId));
            request.ResourcePath = "/workflow/{workflowId}/version";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetAccelerators())
            {
                context.Writer.WritePropertyName("accelerators");
                context.Writer.WriteStringValue(publicRequest.Accelerators);
            }

            if(publicRequest.IsSetContainerRegistryMap())
            {
                context.Writer.WritePropertyName("containerRegistryMap");
                context.Writer.WriteStartObject();

                var marshaller = ContainerRegistryMapMarshaller.Instance;
                marshaller.Marshall(publicRequest.ContainerRegistryMap, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetContainerRegistryMapUri())
            {
                context.Writer.WritePropertyName("containerRegistryMapUri");
                context.Writer.WriteStringValue(publicRequest.ContainerRegistryMapUri);
            }

            if(publicRequest.IsSetDefinitionRepository())
            {
                context.Writer.WritePropertyName("definitionRepository");
                context.Writer.WriteStartObject();

                var marshaller = DefinitionRepositoryMarshaller.Instance;
                marshaller.Marshall(publicRequest.DefinitionRepository, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetDefinitionUri())
            {
                context.Writer.WritePropertyName("definitionUri");
                context.Writer.WriteStringValue(publicRequest.DefinitionUri);
            }

            if(publicRequest.IsSetDefinitionZip())
            {
                context.Writer.WritePropertyName("definitionZip");
                context.Writer.WriteStringValue(StringUtils.FromMemoryStream(publicRequest.DefinitionZip));
            }

            if(publicRequest.IsSetDescription())
            {
                context.Writer.WritePropertyName("description");
                context.Writer.WriteStringValue(publicRequest.Description);
            }

            if(publicRequest.IsSetEngine())
            {
                context.Writer.WritePropertyName("engine");
                context.Writer.WriteStringValue(publicRequest.Engine);
            }

            if(publicRequest.IsSetMain())
            {
                context.Writer.WritePropertyName("main");
                context.Writer.WriteStringValue(publicRequest.Main);
            }

            if(publicRequest.IsSetParameterTemplate())
            {
                context.Writer.WritePropertyName("parameterTemplate");
                context.Writer.WriteStartObject();
                foreach (var publicRequestParameterTemplateKvp in publicRequest.ParameterTemplate)
                {
                    context.Writer.WritePropertyName(publicRequestParameterTemplateKvp.Key);
                    var publicRequestParameterTemplateValue = publicRequestParameterTemplateKvp.Value;

                    context.Writer.WriteStartObject();

                    var marshaller = WorkflowParameterMarshaller.Instance;
                    marshaller.Marshall(publicRequestParameterTemplateValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetParameterTemplatePath())
            {
                context.Writer.WritePropertyName("parameterTemplatePath");
                context.Writer.WriteStringValue(publicRequest.ParameterTemplatePath);
            }

            if(publicRequest.IsSetReadmeMarkdown())
            {
                context.Writer.WritePropertyName("readmeMarkdown");
                context.Writer.WriteStringValue(publicRequest.ReadmeMarkdown);
            }

            if(publicRequest.IsSetReadmePath())
            {
                context.Writer.WritePropertyName("readmePath");
                context.Writer.WriteStringValue(publicRequest.ReadmePath);
            }

            if(publicRequest.IsSetReadmeUri())
            {
                context.Writer.WritePropertyName("readmeUri");
                context.Writer.WriteStringValue(publicRequest.ReadmeUri);
            }

            if(publicRequest.IsSetRequestId())
            {
                context.Writer.WritePropertyName("requestId");
                context.Writer.WriteStringValue(publicRequest.RequestId);
            }

            else if(!(publicRequest.IsSetRequestId()))
            {
                context.Writer.WritePropertyName("requestId");
                context.Writer.WriteStringValue(Guid.NewGuid().ToString());
            }
            if(publicRequest.IsSetStorageCapacity())
            {
                context.Writer.WritePropertyName("storageCapacity");
                context.Writer.WriteNumberValue(publicRequest.StorageCapacity.Value);
            }

            if(publicRequest.IsSetStorageType())
            {
                context.Writer.WritePropertyName("storageType");
                context.Writer.WriteStringValue(publicRequest.StorageType);
            }

            if(publicRequest.IsSetTags())
            {
                context.Writer.WritePropertyName("tags");
                context.Writer.WriteStartObject();
                foreach (var publicRequestTagsKvp in publicRequest.Tags)
                {
                    context.Writer.WritePropertyName(publicRequestTagsKvp.Key);
                    var publicRequestTagsValue = publicRequestTagsKvp.Value;

                        context.Writer.WriteStringValue(publicRequestTagsValue);
                }
                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetVersionName())
            {
                context.Writer.WritePropertyName("versionName");
                context.Writer.WriteStringValue(publicRequest.VersionName);
            }

            if(publicRequest.IsSetWorkflowBucketOwnerId())
            {
                context.Writer.WritePropertyName("workflowBucketOwnerId");
                context.Writer.WriteStringValue(publicRequest.WorkflowBucketOwnerId);
            }

            writer.WriteEndObject();
            writer.Flush();
            // ToArray() must be called here because aspects of sigv4 signing require a byte array
#if !NETFRAMEWORK
            request.Content = arrayPoolBufferWriter.WrittenMemory.ToArray();
#else
            request.Content = memoryStream.ToArray();
#endif
            

            
            request.HostPrefix = $"workflows-";

            return request;
        }
        private static CreateWorkflowVersionRequestMarshaller _instance = new CreateWorkflowVersionRequestMarshaller();        

        internal static CreateWorkflowVersionRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateWorkflowVersionRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}