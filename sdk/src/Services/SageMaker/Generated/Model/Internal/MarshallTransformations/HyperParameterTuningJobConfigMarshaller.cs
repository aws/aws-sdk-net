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
    /// HyperParameterTuningJobConfig Marshaller
    /// </summary>
    public class HyperParameterTuningJobConfigMarshaller : IRequestMarshaller<HyperParameterTuningJobConfig, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(HyperParameterTuningJobConfig requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetHyperParameterTuningJobObjective())
            {
                context.Writer.WritePropertyName("HyperParameterTuningJobObjective");
                context.Writer.WriteStartObject();

                var marshaller = HyperParameterTuningJobObjectiveMarshaller.Instance;
                marshaller.Marshall(requestObject.HyperParameterTuningJobObjective, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetParameterRanges())
            {
                context.Writer.WritePropertyName("ParameterRanges");
                context.Writer.WriteStartObject();

                var marshaller = ParameterRangesMarshaller.Instance;
                marshaller.Marshall(requestObject.ParameterRanges, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetRandomSeed())
            {
                context.Writer.WritePropertyName("RandomSeed");
                context.Writer.WriteNumberValue(requestObject.RandomSeed.Value);
            }

            if(requestObject.IsSetResourceLimits())
            {
                context.Writer.WritePropertyName("ResourceLimits");
                context.Writer.WriteStartObject();

                var marshaller = ResourceLimitsMarshaller.Instance;
                marshaller.Marshall(requestObject.ResourceLimits, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetStrategy())
            {
                context.Writer.WritePropertyName("Strategy");
                context.Writer.WriteStringValue(requestObject.Strategy);
            }

            if(requestObject.IsSetStrategyConfig())
            {
                context.Writer.WritePropertyName("StrategyConfig");
                context.Writer.WriteStartObject();

                var marshaller = HyperParameterTuningJobStrategyConfigMarshaller.Instance;
                marshaller.Marshall(requestObject.StrategyConfig, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetTrainingJobEarlyStoppingType())
            {
                context.Writer.WritePropertyName("TrainingJobEarlyStoppingType");
                context.Writer.WriteStringValue(requestObject.TrainingJobEarlyStoppingType);
            }

            if(requestObject.IsSetTuningJobCompletionCriteria())
            {
                context.Writer.WritePropertyName("TuningJobCompletionCriteria");
                context.Writer.WriteStartObject();

                var marshaller = TuningJobCompletionCriteriaMarshaller.Instance;
                marshaller.Marshall(requestObject.TuningJobCompletionCriteria, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static HyperParameterTuningJobConfigMarshaller Instance = new HyperParameterTuningJobConfigMarshaller();

    }
}