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
#pragma warning disable CS0612,CS0618
namespace Amazon.Bedrock.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// HumanEvaluationConfig Marshaller
    /// </summary>
    public class HumanEvaluationConfigMarshaller : IRequestMarshaller<HumanEvaluationConfig, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(HumanEvaluationConfig requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetCustomMetrics())
            {
                context.Writer.WritePropertyName("customMetrics");
                context.Writer.WriteStartArray();
                foreach(var requestObjectCustomMetricsListValue in requestObject.CustomMetrics)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = HumanEvaluationCustomMetricMarshaller.Instance;
                    marshaller.Marshall(requestObjectCustomMetricsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetDatasetMetricConfigs())
            {
                context.Writer.WritePropertyName("datasetMetricConfigs");
                context.Writer.WriteStartArray();
                foreach(var requestObjectDatasetMetricConfigsListValue in requestObject.DatasetMetricConfigs)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = EvaluationDatasetMetricConfigMarshaller.Instance;
                    marshaller.Marshall(requestObjectDatasetMetricConfigsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetHumanWorkflowConfig())
            {
                context.Writer.WritePropertyName("humanWorkflowConfig");
                context.Writer.WriteStartObject();

                var marshaller = HumanWorkflowConfigMarshaller.Instance;
                marshaller.Marshall(requestObject.HumanWorkflowConfig, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static HumanEvaluationConfigMarshaller Instance = new HumanEvaluationConfigMarshaller();

    }
}