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
#pragma warning disable CS0612,CS0618
namespace Amazon.SageMaker.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// HyperParameterTrainingJobDefinition Marshaller
    /// </summary>
    public class HyperParameterTrainingJobDefinitionMarshaller : IRequestMarshaller<HyperParameterTrainingJobDefinition, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(HyperParameterTrainingJobDefinition requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAlgorithmSpecification())
            {
                context.Writer.WritePropertyName("AlgorithmSpecification");
                context.Writer.WriteStartObject();

                var marshaller = HyperParameterAlgorithmSpecificationMarshaller.Instance;
                marshaller.Marshall(requestObject.AlgorithmSpecification, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetCheckpointConfig())
            {
                context.Writer.WritePropertyName("CheckpointConfig");
                context.Writer.WriteStartObject();

                var marshaller = CheckpointConfigMarshaller.Instance;
                marshaller.Marshall(requestObject.CheckpointConfig, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetDefinitionName())
            {
                context.Writer.WritePropertyName("DefinitionName");
                context.Writer.WriteStringValue(requestObject.DefinitionName);
            }

            if(requestObject.IsSetEnableInterContainerTrafficEncryption())
            {
                context.Writer.WritePropertyName("EnableInterContainerTrafficEncryption");
                context.Writer.WriteBooleanValue(requestObject.EnableInterContainerTrafficEncryption.Value);
            }

            if(requestObject.IsSetEnableManagedSpotTraining())
            {
                context.Writer.WritePropertyName("EnableManagedSpotTraining");
                context.Writer.WriteBooleanValue(requestObject.EnableManagedSpotTraining.Value);
            }

            if(requestObject.IsSetEnableNetworkIsolation())
            {
                context.Writer.WritePropertyName("EnableNetworkIsolation");
                context.Writer.WriteBooleanValue(requestObject.EnableNetworkIsolation.Value);
            }

            if(requestObject.IsSetEnvironment())
            {
                context.Writer.WritePropertyName("Environment");
                context.Writer.WriteStartObject();
                foreach (var requestObjectEnvironmentKvp in requestObject.Environment)
                {
                    context.Writer.WritePropertyName(requestObjectEnvironmentKvp.Key);
                    var requestObjectEnvironmentValue = requestObjectEnvironmentKvp.Value;

                        context.Writer.WriteStringValue(requestObjectEnvironmentValue);
                }
                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetHyperParameterRanges())
            {
                context.Writer.WritePropertyName("HyperParameterRanges");
                context.Writer.WriteStartObject();

                var marshaller = ParameterRangesMarshaller.Instance;
                marshaller.Marshall(requestObject.HyperParameterRanges, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetHyperParameterTuningResourceConfig())
            {
                context.Writer.WritePropertyName("HyperParameterTuningResourceConfig");
                context.Writer.WriteStartObject();

                var marshaller = HyperParameterTuningResourceConfigMarshaller.Instance;
                marshaller.Marshall(requestObject.HyperParameterTuningResourceConfig, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetInputDataConfig())
            {
                context.Writer.WritePropertyName("InputDataConfig");
                context.Writer.WriteStartArray();
                foreach(var requestObjectInputDataConfigListValue in requestObject.InputDataConfig)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = ChannelMarshaller.Instance;
                    marshaller.Marshall(requestObjectInputDataConfigListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetOutputDataConfig())
            {
                context.Writer.WritePropertyName("OutputDataConfig");
                context.Writer.WriteStartObject();

                var marshaller = OutputDataConfigMarshaller.Instance;
                marshaller.Marshall(requestObject.OutputDataConfig, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetResourceConfig())
            {
                context.Writer.WritePropertyName("ResourceConfig");
                context.Writer.WriteStartObject();

                var marshaller = ResourceConfigMarshaller.Instance;
                marshaller.Marshall(requestObject.ResourceConfig, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetRetryStrategy())
            {
                context.Writer.WritePropertyName("RetryStrategy");
                context.Writer.WriteStartObject();

                var marshaller = RetryStrategyMarshaller.Instance;
                marshaller.Marshall(requestObject.RetryStrategy, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetRoleArn())
            {
                context.Writer.WritePropertyName("RoleArn");
                context.Writer.WriteStringValue(requestObject.RoleArn);
            }

            if(requestObject.IsSetStaticHyperParameters())
            {
                context.Writer.WritePropertyName("StaticHyperParameters");
                context.Writer.WriteStartObject();
                foreach (var requestObjectStaticHyperParametersKvp in requestObject.StaticHyperParameters)
                {
                    context.Writer.WritePropertyName(requestObjectStaticHyperParametersKvp.Key);
                    var requestObjectStaticHyperParametersValue = requestObjectStaticHyperParametersKvp.Value;

                        context.Writer.WriteStringValue(requestObjectStaticHyperParametersValue);
                }
                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetStoppingCondition())
            {
                context.Writer.WritePropertyName("StoppingCondition");
                context.Writer.WriteStartObject();

                var marshaller = StoppingConditionMarshaller.Instance;
                marshaller.Marshall(requestObject.StoppingCondition, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetTuningObjective())
            {
                context.Writer.WritePropertyName("TuningObjective");
                context.Writer.WriteStartObject();

                var marshaller = HyperParameterTuningJobObjectiveMarshaller.Instance;
                marshaller.Marshall(requestObject.TuningObjective, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetVpcConfig())
            {
                context.Writer.WritePropertyName("VpcConfig");
                context.Writer.WriteStartObject();

                var marshaller = VpcConfigMarshaller.Instance;
                marshaller.Marshall(requestObject.VpcConfig, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static HyperParameterTrainingJobDefinitionMarshaller Instance = new HyperParameterTrainingJobDefinitionMarshaller();

    }
}