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
    /// TrainingJobDefinition Marshaller
    /// </summary>       
    public class TrainingJobDefinitionMarshaller : IRequestMarshaller<TrainingJobDefinition, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(TrainingJobDefinition requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetHyperParameters())
            {
                context.Writer.WritePropertyName("HyperParameters");
                context.Writer.WriteObjectStart();
                foreach (var requestObjectHyperParametersKvp in requestObject.HyperParameters)
                {
                    context.Writer.WritePropertyName(requestObjectHyperParametersKvp.Key);
                    var requestObjectHyperParametersValue = requestObjectHyperParametersKvp.Value;

                        context.Writer.Write(requestObjectHyperParametersValue);
                }
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

            if(requestObject.IsSetStoppingCondition())
            {
                context.Writer.WritePropertyName("StoppingCondition");
                context.Writer.WriteObjectStart();

                var marshaller = StoppingConditionMarshaller.Instance;
                marshaller.Marshall(requestObject.StoppingCondition, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetTrainingInputMode())
            {
                context.Writer.WritePropertyName("TrainingInputMode");
                context.Writer.Write(requestObject.TrainingInputMode);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static TrainingJobDefinitionMarshaller Instance = new TrainingJobDefinitionMarshaller();

    }
}