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
    /// TrainingSpecification Marshaller
    /// </summary>       
    public class TrainingSpecificationMarshaller : IRequestMarshaller<TrainingSpecification, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(TrainingSpecification requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetMetricDefinitions())
            {
                context.Writer.WritePropertyName("MetricDefinitions");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectMetricDefinitionsListValue in requestObject.MetricDefinitions)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = MetricDefinitionMarshaller.Instance;
                    marshaller.Marshall(requestObjectMetricDefinitionsListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetSupportedHyperParameters())
            {
                context.Writer.WritePropertyName("SupportedHyperParameters");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectSupportedHyperParametersListValue in requestObject.SupportedHyperParameters)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = HyperParameterSpecificationMarshaller.Instance;
                    marshaller.Marshall(requestObjectSupportedHyperParametersListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetSupportedTrainingInstanceTypes())
            {
                context.Writer.WritePropertyName("SupportedTrainingInstanceTypes");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectSupportedTrainingInstanceTypesListValue in requestObject.SupportedTrainingInstanceTypes)
                {
                        context.Writer.Write(requestObjectSupportedTrainingInstanceTypesListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetSupportedTuningJobObjectiveMetrics())
            {
                context.Writer.WritePropertyName("SupportedTuningJobObjectiveMetrics");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectSupportedTuningJobObjectiveMetricsListValue in requestObject.SupportedTuningJobObjectiveMetrics)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = HyperParameterTuningJobObjectiveMarshaller.Instance;
                    marshaller.Marshall(requestObjectSupportedTuningJobObjectiveMetricsListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetSupportsDistributedTraining())
            {
                context.Writer.WritePropertyName("SupportsDistributedTraining");
                context.Writer.Write(requestObject.SupportsDistributedTraining);
            }

            if(requestObject.IsSetTrainingChannels())
            {
                context.Writer.WritePropertyName("TrainingChannels");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectTrainingChannelsListValue in requestObject.TrainingChannels)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = ChannelSpecificationMarshaller.Instance;
                    marshaller.Marshall(requestObjectTrainingChannelsListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetTrainingImage())
            {
                context.Writer.WritePropertyName("TrainingImage");
                context.Writer.Write(requestObject.TrainingImage);
            }

            if(requestObject.IsSetTrainingImageDigest())
            {
                context.Writer.WritePropertyName("TrainingImageDigest");
                context.Writer.Write(requestObject.TrainingImageDigest);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static TrainingSpecificationMarshaller Instance = new TrainingSpecificationMarshaller();

    }
}