/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using ThirdParty.Json.LitJson;

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
            if(requestObject.IsSetAlgorithmSpecification())
            {
                context.Writer.WritePropertyName("AlgorithmSpecification");
                context.Writer.WriteObjectStart();

                var marshaller = HyperParameterAlgorithmSpecificationMarshaller.Instance;
                marshaller.Marshall(requestObject.AlgorithmSpecification, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetInputDataConfig())
            {
                context.Writer.WritePropertyName("InputDataConfig");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectInputDataConfigListValue in requestObject.InputDataConfig)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = ChannelMarshaller.Instance;
                    marshaller.Marshall(requestObjectInputDataConfigListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetOutputDataConfig())
            {
                context.Writer.WritePropertyName("OutputDataConfig");
                context.Writer.WriteObjectStart();

                var marshaller = OutputDataConfigMarshaller.Instance;
                marshaller.Marshall(requestObject.OutputDataConfig, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetResourceConfig())
            {
                context.Writer.WritePropertyName("ResourceConfig");
                context.Writer.WriteObjectStart();

                var marshaller = ResourceConfigMarshaller.Instance;
                marshaller.Marshall(requestObject.ResourceConfig, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetRoleArn())
            {
                context.Writer.WritePropertyName("RoleArn");
                context.Writer.Write(requestObject.RoleArn);
            }

            if(requestObject.IsSetStaticHyperParameters())
            {
                context.Writer.WritePropertyName("StaticHyperParameters");
                context.Writer.WriteObjectStart();
                foreach (var requestObjectStaticHyperParametersKvp in requestObject.StaticHyperParameters)
                {
                    context.Writer.WritePropertyName(requestObjectStaticHyperParametersKvp.Key);
                    var requestObjectStaticHyperParametersValue = requestObjectStaticHyperParametersKvp.Value;

                        context.Writer.Write(requestObjectStaticHyperParametersValue);
                }
                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetStoppingCondition())
            {
                context.Writer.WritePropertyName("StoppingCondition");
                context.Writer.WriteObjectStart();

                var marshaller = StoppingConditionMarshaller.Instance;
                marshaller.Marshall(requestObject.StoppingCondition, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetVpcConfig())
            {
                context.Writer.WritePropertyName("VpcConfig");
                context.Writer.WriteObjectStart();

                var marshaller = VpcConfigMarshaller.Instance;
                marshaller.Marshall(requestObject.VpcConfig, context);

                context.Writer.WriteObjectEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static HyperParameterTrainingJobDefinitionMarshaller Instance = new HyperParameterTrainingJobDefinitionMarshaller();

    }
}