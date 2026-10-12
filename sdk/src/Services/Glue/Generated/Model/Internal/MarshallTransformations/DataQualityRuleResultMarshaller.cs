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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Glue.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.Glue.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DataQualityRuleResult Marshaller
    /// </summary>
    public class DataQualityRuleResultMarshaller : IRequestMarshaller<DataQualityRuleResult, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(DataQualityRuleResult requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetDescription())
            {
                context.Writer.WritePropertyName("Description");
                context.Writer.WriteStringValue(requestObject.Description);
            }

            if(requestObject.IsSetEvaluatedMetrics())
            {
                context.Writer.WritePropertyName("EvaluatedMetrics");
                context.Writer.WriteStartObject();
                foreach (var requestObjectEvaluatedMetricsKvp in requestObject.EvaluatedMetrics)
                {
                    context.Writer.WritePropertyName(requestObjectEvaluatedMetricsKvp.Key);
                    var requestObjectEvaluatedMetricsValue = requestObjectEvaluatedMetricsKvp.Value;

                        context.Writer.WriteNumberValue(requestObjectEvaluatedMetricsValue);
                }
                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetEvaluatedRule())
            {
                context.Writer.WritePropertyName("EvaluatedRule");
                context.Writer.WriteStringValue(requestObject.EvaluatedRule);
            }

            if(requestObject.IsSetEvaluationMessage())
            {
                context.Writer.WritePropertyName("EvaluationMessage");
                context.Writer.WriteStringValue(requestObject.EvaluationMessage);
            }

            if(requestObject.IsSetLabels())
            {
                context.Writer.WritePropertyName("Labels");
                context.Writer.WriteStartObject();
                foreach (var requestObjectLabelsKvp in requestObject.Labels)
                {
                    context.Writer.WritePropertyName(requestObjectLabelsKvp.Key);
                    var requestObjectLabelsValue = requestObjectLabelsKvp.Value;

                        context.Writer.WriteStringValue(requestObjectLabelsValue);
                }
                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetName())
            {
                context.Writer.WritePropertyName("Name");
                context.Writer.WriteStringValue(requestObject.Name);
            }

            if(requestObject.IsSetResult())
            {
                context.Writer.WritePropertyName("Result");
                context.Writer.WriteStringValue(requestObject.Result);
            }

            if(requestObject.IsSetRuleMetrics())
            {
                context.Writer.WritePropertyName("RuleMetrics");
                context.Writer.WriteStartObject();
                foreach (var requestObjectRuleMetricsKvp in requestObject.RuleMetrics)
                {
                    context.Writer.WritePropertyName(requestObjectRuleMetricsKvp.Key);
                    var requestObjectRuleMetricsValue = requestObjectRuleMetricsKvp.Value;

                        context.Writer.WriteNumberValue(requestObjectRuleMetricsValue);
                }
                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static DataQualityRuleResultMarshaller Instance = new DataQualityRuleResultMarshaller();

    }
}