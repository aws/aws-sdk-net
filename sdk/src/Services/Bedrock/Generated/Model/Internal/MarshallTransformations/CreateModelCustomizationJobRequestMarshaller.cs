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
    /// CreateModelCustomizationJob Request Marshaller
    /// </summary>       
    public class CreateModelCustomizationJobRequestMarshaller : IMarshaller<IRequest, CreateModelCustomizationJobRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateModelCustomizationJobRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateModelCustomizationJobRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Bedrock");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2023-04-20";
            request.HttpMethod = "POST";

            request.ResourcePath = "/model-customization-jobs";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetBaseModelIdentifier())
            {
                context.Writer.WritePropertyName("baseModelIdentifier");
                context.Writer.WriteStringValue(publicRequest.BaseModelIdentifier);
            }

            if(publicRequest.IsSetClientRequestToken())
            {
                context.Writer.WritePropertyName("clientRequestToken");
                context.Writer.WriteStringValue(publicRequest.ClientRequestToken);
            }

            else if(!(publicRequest.IsSetClientRequestToken()))
            {
                context.Writer.WritePropertyName("clientRequestToken");
                context.Writer.WriteStringValue(Guid.NewGuid().ToString());
            }
            if(publicRequest.IsSetCustomizationConfig())
            {
                context.Writer.WritePropertyName("customizationConfig");
                context.Writer.WriteStartObject();

                var marshaller = CustomizationConfigMarshaller.Instance;
                marshaller.Marshall(publicRequest.CustomizationConfig, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetCustomizationType())
            {
                context.Writer.WritePropertyName("customizationType");
                context.Writer.WriteStringValue(publicRequest.CustomizationType);
            }

            if(publicRequest.IsSetCustomModelKmsKeyId())
            {
                context.Writer.WritePropertyName("customModelKmsKeyId");
                context.Writer.WriteStringValue(publicRequest.CustomModelKmsKeyId);
            }

            if(publicRequest.IsSetCustomModelName())
            {
                context.Writer.WritePropertyName("customModelName");
                context.Writer.WriteStringValue(publicRequest.CustomModelName);
            }

            if(publicRequest.IsSetCustomModelTags())
            {
                context.Writer.WritePropertyName("customModelTags");
                context.Writer.WriteStartArray();
                foreach(var publicRequestCustomModelTagsListValue in publicRequest.CustomModelTags)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = TagMarshaller.Instance;
                    marshaller.Marshall(publicRequestCustomModelTagsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetHyperParameters())
            {
                context.Writer.WritePropertyName("hyperParameters");
                context.Writer.WriteStartObject();
                foreach (var publicRequestHyperParametersKvp in publicRequest.HyperParameters)
                {
                    context.Writer.WritePropertyName(publicRequestHyperParametersKvp.Key);
                    var publicRequestHyperParametersValue = publicRequestHyperParametersKvp.Value;

                        context.Writer.WriteStringValue(publicRequestHyperParametersValue);
                }
                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetJobName())
            {
                context.Writer.WritePropertyName("jobName");
                context.Writer.WriteStringValue(publicRequest.JobName);
            }

            if(publicRequest.IsSetJobTags())
            {
                context.Writer.WritePropertyName("jobTags");
                context.Writer.WriteStartArray();
                foreach(var publicRequestJobTagsListValue in publicRequest.JobTags)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = TagMarshaller.Instance;
                    marshaller.Marshall(publicRequestJobTagsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetOutputDataConfig())
            {
                context.Writer.WritePropertyName("outputDataConfig");
                context.Writer.WriteStartObject();

                var marshaller = OutputDataConfigMarshaller.Instance;
                marshaller.Marshall(publicRequest.OutputDataConfig, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetRoleArn())
            {
                context.Writer.WritePropertyName("roleArn");
                context.Writer.WriteStringValue(publicRequest.RoleArn);
            }

            if(publicRequest.IsSetTrainingDataConfig())
            {
                context.Writer.WritePropertyName("trainingDataConfig");
                context.Writer.WriteStartObject();

                var marshaller = TrainingDataConfigMarshaller.Instance;
                marshaller.Marshall(publicRequest.TrainingDataConfig, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetValidationDataConfig())
            {
                context.Writer.WritePropertyName("validationDataConfig");
                context.Writer.WriteStartObject();

                var marshaller = ValidationDataConfigMarshaller.Instance;
                marshaller.Marshall(publicRequest.ValidationDataConfig, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetVpcConfig())
            {
                context.Writer.WritePropertyName("vpcConfig");
                context.Writer.WriteStartObject();

                var marshaller = VpcConfigMarshaller.Instance;
                marshaller.Marshall(publicRequest.VpcConfig, context);

                context.Writer.WriteEndObject();
            }

            writer.WriteEndObject();
            writer.Flush();
            // ToArray() must be called here because aspects of sigv4 signing require a byte array
#if !NETFRAMEWORK
            request.Content = arrayPoolBufferWriter.WrittenMemory.ToArray();
#else
            request.Content = memoryStream.ToArray();
#endif
            


            return request;
        }
        private static CreateModelCustomizationJobRequestMarshaller _instance = new CreateModelCustomizationJobRequestMarshaller();        

        internal static CreateModelCustomizationJobRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateModelCustomizationJobRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}