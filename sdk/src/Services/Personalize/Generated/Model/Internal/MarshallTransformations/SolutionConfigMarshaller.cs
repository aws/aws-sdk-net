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
 * Do not modify this file. This file is generated from the personalize-2018-05-22.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Personalize.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.Personalize.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// SolutionConfig Marshaller
    /// </summary>
    public class SolutionConfigMarshaller : IRequestMarshaller<SolutionConfig, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(SolutionConfig requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAlgorithmHyperParameters())
            {
                context.Writer.WritePropertyName("algorithmHyperParameters");
                context.Writer.WriteStartObject();
                foreach (var requestObjectAlgorithmHyperParametersKvp in requestObject.AlgorithmHyperParameters)
                {
                    context.Writer.WritePropertyName(requestObjectAlgorithmHyperParametersKvp.Key);
                    var requestObjectAlgorithmHyperParametersValue = requestObjectAlgorithmHyperParametersKvp.Value;

                        context.Writer.WriteStringValue(requestObjectAlgorithmHyperParametersValue);
                }
                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetAutoMLConfig())
            {
                context.Writer.WritePropertyName("autoMLConfig");
                context.Writer.WriteStartObject();

                var marshaller = AutoMLConfigMarshaller.Instance;
                marshaller.Marshall(requestObject.AutoMLConfig, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetAutoTrainingConfig())
            {
                context.Writer.WritePropertyName("autoTrainingConfig");
                context.Writer.WriteStartObject();

                var marshaller = AutoTrainingConfigMarshaller.Instance;
                marshaller.Marshall(requestObject.AutoTrainingConfig, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetEventsConfig())
            {
                context.Writer.WritePropertyName("eventsConfig");
                context.Writer.WriteStartObject();

                var marshaller = EventsConfigMarshaller.Instance;
                marshaller.Marshall(requestObject.EventsConfig, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetEventValueThreshold())
            {
                context.Writer.WritePropertyName("eventValueThreshold");
                context.Writer.WriteStringValue(requestObject.EventValueThreshold);
            }

            if(requestObject.IsSetFeatureTransformationParameters())
            {
                context.Writer.WritePropertyName("featureTransformationParameters");
                context.Writer.WriteStartObject();
                foreach (var requestObjectFeatureTransformationParametersKvp in requestObject.FeatureTransformationParameters)
                {
                    context.Writer.WritePropertyName(requestObjectFeatureTransformationParametersKvp.Key);
                    var requestObjectFeatureTransformationParametersValue = requestObjectFeatureTransformationParametersKvp.Value;

                        context.Writer.WriteStringValue(requestObjectFeatureTransformationParametersValue);
                }
                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetHpoConfig())
            {
                context.Writer.WritePropertyName("hpoConfig");
                context.Writer.WriteStartObject();

                var marshaller = HPOConfigMarshaller.Instance;
                marshaller.Marshall(requestObject.HpoConfig, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetOptimizationObjective())
            {
                context.Writer.WritePropertyName("optimizationObjective");
                context.Writer.WriteStartObject();

                var marshaller = OptimizationObjectiveMarshaller.Instance;
                marshaller.Marshall(requestObject.OptimizationObjective, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetTrainingDataConfig())
            {
                context.Writer.WritePropertyName("trainingDataConfig");
                context.Writer.WriteStartObject();

                var marshaller = TrainingDataConfigMarshaller.Instance;
                marshaller.Marshall(requestObject.TrainingDataConfig, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static SolutionConfigMarshaller Instance = new SolutionConfigMarshaller();

    }
}