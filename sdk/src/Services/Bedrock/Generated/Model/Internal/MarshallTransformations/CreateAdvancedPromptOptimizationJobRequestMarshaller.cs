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
 * Do not modify this file. This file is generated from the bedrock-2023-04-20.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Bedrock.Model;
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
namespace Amazon.Bedrock.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateAdvancedPromptOptimizationJob Request Marshaller
    /// </summary>       
    public class CreateAdvancedPromptOptimizationJobRequestMarshaller : IMarshaller<IRequest, CreateAdvancedPromptOptimizationJobRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateAdvancedPromptOptimizationJobRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateAdvancedPromptOptimizationJobRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Bedrock");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2023-04-20";
            request.HttpMethod = "POST";

            request.ResourcePath = "/advanced-prompt-optimization-jobs";
#if !NETFRAMEWORK
            request.ContentStream = new PooledContentStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(((PooledContentStream)request.ContentStream).BufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetClientToken())
            {
                context.Writer.WritePropertyName("clientToken");
                context.Writer.WriteStringValue(publicRequest.ClientToken);
            }

            else if(!(publicRequest.IsSetClientToken()))
            {
                context.Writer.WritePropertyName("clientToken");
                context.Writer.WriteStringValue(Guid.NewGuid().ToString());
            }
            if(publicRequest.IsSetEncryptionKeyArn())
            {
                context.Writer.WritePropertyName("encryptionKeyArn");
                context.Writer.WriteStringValue(publicRequest.EncryptionKeyArn);
            }

            if(publicRequest.IsSetInputConfig())
            {
                context.Writer.WritePropertyName("inputConfig");
                context.Writer.WriteStartObject();

                var marshaller = AdvancedPromptOptimizationInputConfigMarshaller.Instance;
                marshaller.Marshall(publicRequest.InputConfig, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetJobDescription())
            {
                context.Writer.WritePropertyName("jobDescription");
                context.Writer.WriteStringValue(publicRequest.JobDescription);
            }

            if(publicRequest.IsSetJobName())
            {
                context.Writer.WritePropertyName("jobName");
                context.Writer.WriteStringValue(publicRequest.JobName);
            }

            if(publicRequest.IsSetModelConfigurations())
            {
                context.Writer.WritePropertyName("modelConfigurations");
                context.Writer.WriteStartArray();
                foreach(var publicRequestModelConfigurationsListValue in publicRequest.ModelConfigurations)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = ModelConfigurationMarshaller.Instance;
                    marshaller.Marshall(publicRequestModelConfigurationsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetOutputConfig())
            {
                context.Writer.WritePropertyName("outputConfig");
                context.Writer.WriteStartObject();

                var marshaller = AdvancedPromptOptimizationOutputConfigMarshaller.Instance;
                marshaller.Marshall(publicRequest.OutputConfig, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetTags())
            {
                context.Writer.WritePropertyName("tags");
                context.Writer.WriteStartArray();
                foreach(var publicRequestTagsListValue in publicRequest.Tags)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = TagMarshaller.Instance;
                    marshaller.Marshall(publicRequestTagsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            writer.WriteEndObject();
            writer.Flush();
#if NETFRAMEWORK
            request.Content = memoryStream.ToArray();
#endif
            


            return request;
        }
        private static CreateAdvancedPromptOptimizationJobRequestMarshaller _instance = new CreateAdvancedPromptOptimizationJobRequestMarshaller();        

        internal static CreateAdvancedPromptOptimizationJobRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateAdvancedPromptOptimizationJobRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}