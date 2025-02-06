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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.SageMaker.Model;
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
namespace Amazon.SageMaker.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateProcessingJob Request Marshaller
    /// </summary>       
    public class CreateProcessingJobRequestMarshaller : IMarshaller<IRequest, CreateProcessingJobRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateProcessingJobRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateProcessingJobRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.SageMaker");
            string target = "SageMaker.CreateProcessingJob";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2017-07-24";
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetAppSpecification())
            {
                context.Writer.WritePropertyName("AppSpecification");
                context.Writer.WriteStartObject();

                var marshaller = AppSpecificationMarshaller.Instance;
                marshaller.Marshall(publicRequest.AppSpecification, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetEnvironment())
            {
                context.Writer.WritePropertyName("Environment");
                context.Writer.WriteStartObject();
                foreach (var publicRequestEnvironmentKvp in publicRequest.Environment)
                {
                    context.Writer.WritePropertyName(publicRequestEnvironmentKvp.Key);
                    var publicRequestEnvironmentValue = publicRequestEnvironmentKvp.Value;

                        context.Writer.WriteStringValue(publicRequestEnvironmentValue);
                }
                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetExperimentConfig())
            {
                context.Writer.WritePropertyName("ExperimentConfig");
                context.Writer.WriteStartObject();

                var marshaller = ExperimentConfigMarshaller.Instance;
                marshaller.Marshall(publicRequest.ExperimentConfig, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetNetworkConfig())
            {
                context.Writer.WritePropertyName("NetworkConfig");
                context.Writer.WriteStartObject();

                var marshaller = NetworkConfigMarshaller.Instance;
                marshaller.Marshall(publicRequest.NetworkConfig, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetProcessingInputs())
            {
                context.Writer.WritePropertyName("ProcessingInputs");
                context.Writer.WriteStartArray();
                foreach(var publicRequestProcessingInputsListValue in publicRequest.ProcessingInputs)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = ProcessingInputMarshaller.Instance;
                    marshaller.Marshall(publicRequestProcessingInputsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetProcessingJobName())
            {
                context.Writer.WritePropertyName("ProcessingJobName");
                context.Writer.WriteStringValue(publicRequest.ProcessingJobName);
            }

            if(publicRequest.IsSetProcessingOutputConfig())
            {
                context.Writer.WritePropertyName("ProcessingOutputConfig");
                context.Writer.WriteStartObject();

                var marshaller = ProcessingOutputConfigMarshaller.Instance;
                marshaller.Marshall(publicRequest.ProcessingOutputConfig, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetProcessingResources())
            {
                context.Writer.WritePropertyName("ProcessingResources");
                context.Writer.WriteStartObject();

                var marshaller = ProcessingResourcesMarshaller.Instance;
                marshaller.Marshall(publicRequest.ProcessingResources, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetRoleArn())
            {
                context.Writer.WritePropertyName("RoleArn");
                context.Writer.WriteStringValue(publicRequest.RoleArn);
            }

            if(publicRequest.IsSetStoppingCondition())
            {
                context.Writer.WritePropertyName("StoppingCondition");
                context.Writer.WriteStartObject();

                var marshaller = ProcessingStoppingConditionMarshaller.Instance;
                marshaller.Marshall(publicRequest.StoppingCondition, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetTags())
            {
                context.Writer.WritePropertyName("Tags");
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
            // ToArray() must be called here because aspects of sigv4 signing require a byte array
#if !NETFRAMEWORK
            request.Content = arrayPoolBufferWriter.WrittenMemory.ToArray();
#else
            request.Content = memoryStream.ToArray();
#endif
            


            return request;
        }
        private static CreateProcessingJobRequestMarshaller _instance = new CreateProcessingJobRequestMarshaller();        

        internal static CreateProcessingJobRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateProcessingJobRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}