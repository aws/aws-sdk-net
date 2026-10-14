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
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

using Amazon.Glue.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

#pragma warning disable CS0612,CS0618

namespace Amazon.Glue.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DataQualityAnalyzerResult Marshaller
    /// </summary>
    public partial class DataQualityAnalyzerResultMarshaller : IRequestMarshaller<DataQualityAnalyzerResult, JsonMarshallerContext>
    {
        /// <summary>
        /// Marshall the structure from the request object to the service
        /// </summary>
        public void Marshall(DataQualityAnalyzerResult requestObject, JsonMarshallerContext context)
        {
            if (requestObject == null) return;

            if (requestObject.IsSetDescription())
            {
                context.Writer.WritePropertyName("Description");
                context.Writer.WriteStringValue(requestObject.Description);
            }

            if (requestObject.IsSetEvaluatedDistributions())
            {
                context.Writer.WritePropertyName("EvaluatedDistributions");
                context.Writer.WriteStartObject();
                foreach (var requestObjectEvaluatedDistributionsKvp in requestObject.EvaluatedDistributions)
                {
                    context.Writer.WritePropertyName(requestObjectEvaluatedDistributionsKvp.Key);
                    var requestObjectEvaluatedDistributionsValue = requestObjectEvaluatedDistributionsKvp.Value;
                    context.Writer.WriteStartObject();

                    var marshaller = DistributionDataMarshaller.Instance;
                    marshaller.Marshall(requestObjectEvaluatedDistributionsValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndObject();
            }

            if (requestObject.IsSetEvaluatedMetrics())
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

            if (requestObject.IsSetEvaluationMessage())
            {
                context.Writer.WritePropertyName("EvaluationMessage");
                context.Writer.WriteStringValue(requestObject.EvaluationMessage);
            }

            if (requestObject.IsSetName())
            {
                context.Writer.WritePropertyName("Name");
                context.Writer.WriteStringValue(requestObject.Name);
            }
        }

        /// <summary>
        /// Singleton Marshaller
        /// </summary>
        public readonly static DataQualityAnalyzerResultMarshaller Instance = new DataQualityAnalyzerResultMarshaller();
    }
}
