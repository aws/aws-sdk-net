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
    /// CreateTrainingJob Request Marshaller
    /// </summary>       
    public class CreateTrainingJobRequestMarshaller : IMarshaller<IRequest, CreateTrainingJobRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateTrainingJobRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateTrainingJobRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.SageMaker");
            string target = "SageMaker.CreateTrainingJob";
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
            if(publicRequest.IsSetAlgorithmSpecification())
            {
                context.Writer.WritePropertyName("AlgorithmSpecification");
                context.Writer.WriteStartObject();

                var marshaller = AlgorithmSpecificationMarshaller.Instance;
                marshaller.Marshall(publicRequest.AlgorithmSpecification, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetCheckpointConfig())
            {
                context.Writer.WritePropertyName("CheckpointConfig");
                context.Writer.WriteStartObject();

                var marshaller = CheckpointConfigMarshaller.Instance;
                marshaller.Marshall(publicRequest.CheckpointConfig, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetDebugHookConfig())
            {
                context.Writer.WritePropertyName("DebugHookConfig");
                context.Writer.WriteStartObject();

                var marshaller = DebugHookConfigMarshaller.Instance;
                marshaller.Marshall(publicRequest.DebugHookConfig, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetDebugRuleConfigurations())
            {
                context.Writer.WritePropertyName("DebugRuleConfigurations");
                context.Writer.WriteStartArray();
                foreach(var publicRequestDebugRuleConfigurationsListValue in publicRequest.DebugRuleConfigurations)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = DebugRuleConfigurationMarshaller.Instance;
                    marshaller.Marshall(publicRequestDebugRuleConfigurationsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetEnableInterContainerTrafficEncryption())
            {
                context.Writer.WritePropertyName("EnableInterContainerTrafficEncryption");
                context.Writer.WriteBooleanValue(publicRequest.EnableInterContainerTrafficEncryption.Value);
            }

            if(publicRequest.IsSetEnableManagedSpotTraining())
            {
                context.Writer.WritePropertyName("EnableManagedSpotTraining");
                context.Writer.WriteBooleanValue(publicRequest.EnableManagedSpotTraining.Value);
            }

            if(publicRequest.IsSetEnableNetworkIsolation())
            {
                context.Writer.WritePropertyName("EnableNetworkIsolation");
                context.Writer.WriteBooleanValue(publicRequest.EnableNetworkIsolation.Value);
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

            if(publicRequest.IsSetHyperParameters())
            {
                context.Writer.WritePropertyName("HyperParameters");
                context.Writer.WriteStartObject();
                foreach (var publicRequestHyperParametersKvp in publicRequest.HyperParameters)
                {
                    context.Writer.WritePropertyName(publicRequestHyperParametersKvp.Key);
                    var publicRequestHyperParametersValue = publicRequestHyperParametersKvp.Value;

                        context.Writer.WriteStringValue(publicRequestHyperParametersValue);
                }
                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetInfraCheckConfig())
            {
                context.Writer.WritePropertyName("InfraCheckConfig");
                context.Writer.WriteStartObject();

                var marshaller = InfraCheckConfigMarshaller.Instance;
                marshaller.Marshall(publicRequest.InfraCheckConfig, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetInputDataConfig())
            {
                context.Writer.WritePropertyName("InputDataConfig");
                context.Writer.WriteStartArray();
                foreach(var publicRequestInputDataConfigListValue in publicRequest.InputDataConfig)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = ChannelMarshaller.Instance;
                    marshaller.Marshall(publicRequestInputDataConfigListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetOutputDataConfig())
            {
                context.Writer.WritePropertyName("OutputDataConfig");
                context.Writer.WriteStartObject();

                var marshaller = OutputDataConfigMarshaller.Instance;
                marshaller.Marshall(publicRequest.OutputDataConfig, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetProfilerConfig())
            {
                context.Writer.WritePropertyName("ProfilerConfig");
                context.Writer.WriteStartObject();

                var marshaller = ProfilerConfigMarshaller.Instance;
                marshaller.Marshall(publicRequest.ProfilerConfig, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetProfilerRuleConfigurations())
            {
                context.Writer.WritePropertyName("ProfilerRuleConfigurations");
                context.Writer.WriteStartArray();
                foreach(var publicRequestProfilerRuleConfigurationsListValue in publicRequest.ProfilerRuleConfigurations)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = ProfilerRuleConfigurationMarshaller.Instance;
                    marshaller.Marshall(publicRequestProfilerRuleConfigurationsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetRemoteDebugConfig())
            {
                context.Writer.WritePropertyName("RemoteDebugConfig");
                context.Writer.WriteStartObject();

                var marshaller = RemoteDebugConfigMarshaller.Instance;
                marshaller.Marshall(publicRequest.RemoteDebugConfig, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetResourceConfig())
            {
                context.Writer.WritePropertyName("ResourceConfig");
                context.Writer.WriteStartObject();

                var marshaller = ResourceConfigMarshaller.Instance;
                marshaller.Marshall(publicRequest.ResourceConfig, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetRetryStrategy())
            {
                context.Writer.WritePropertyName("RetryStrategy");
                context.Writer.WriteStartObject();

                var marshaller = RetryStrategyMarshaller.Instance;
                marshaller.Marshall(publicRequest.RetryStrategy, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetRoleArn())
            {
                context.Writer.WritePropertyName("RoleArn");
                context.Writer.WriteStringValue(publicRequest.RoleArn);
            }

            if(publicRequest.IsSetSessionChainingConfig())
            {
                context.Writer.WritePropertyName("SessionChainingConfig");
                context.Writer.WriteStartObject();

                var marshaller = SessionChainingConfigMarshaller.Instance;
                marshaller.Marshall(publicRequest.SessionChainingConfig, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetStoppingCondition())
            {
                context.Writer.WritePropertyName("StoppingCondition");
                context.Writer.WriteStartObject();

                var marshaller = StoppingConditionMarshaller.Instance;
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

            if(publicRequest.IsSetTensorBoardOutputConfig())
            {
                context.Writer.WritePropertyName("TensorBoardOutputConfig");
                context.Writer.WriteStartObject();

                var marshaller = TensorBoardOutputConfigMarshaller.Instance;
                marshaller.Marshall(publicRequest.TensorBoardOutputConfig, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetTrainingJobName())
            {
                context.Writer.WritePropertyName("TrainingJobName");
                context.Writer.WriteStringValue(publicRequest.TrainingJobName);
            }

            if(publicRequest.IsSetVpcConfig())
            {
                context.Writer.WritePropertyName("VpcConfig");
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
        private static CreateTrainingJobRequestMarshaller _instance = new CreateTrainingJobRequestMarshaller();        

        internal static CreateTrainingJobRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateTrainingJobRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}