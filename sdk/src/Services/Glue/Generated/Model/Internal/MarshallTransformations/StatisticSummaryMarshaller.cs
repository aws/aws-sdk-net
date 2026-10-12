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
    /// StatisticSummary Marshaller
    /// </summary>
    public class StatisticSummaryMarshaller : IRequestMarshaller<StatisticSummary, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(StatisticSummary requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetColumnsReferenced())
            {
                context.Writer.WritePropertyName("ColumnsReferenced");
                context.Writer.WriteStartArray();
                foreach(var requestObjectColumnsReferencedListValue in requestObject.ColumnsReferenced)
                {
                        context.Writer.WriteStringValue(requestObjectColumnsReferencedListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetDistributionValue())
            {
                context.Writer.WritePropertyName("DistributionValue");
                context.Writer.WriteStartObject();

                var marshaller = DistributionDataMarshaller.Instance;
                marshaller.Marshall(requestObject.DistributionValue, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetDoubleValue())
            {
                context.Writer.WritePropertyName("DoubleValue");
                if(StringUtils.IsSpecialDoubleValue(requestObject.DoubleValue.Value))
                {
                    context.Writer.WriteStringValue(StringUtils.FromSpecialDoubleValue(requestObject.DoubleValue.Value));
                }
                else
                {
                    context.Writer.WriteNumberValue(requestObject.DoubleValue.Value);
                }
            }

            if(requestObject.IsSetEvaluationLevel())
            {
                context.Writer.WritePropertyName("EvaluationLevel");
                context.Writer.WriteStringValue(requestObject.EvaluationLevel);
            }

            if(requestObject.IsSetInclusionAnnotation())
            {
                context.Writer.WritePropertyName("InclusionAnnotation");
                context.Writer.WriteStartObject();

                var marshaller = TimestampedInclusionAnnotationMarshaller.Instance;
                marshaller.Marshall(requestObject.InclusionAnnotation, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetProfileId())
            {
                context.Writer.WritePropertyName("ProfileId");
                context.Writer.WriteStringValue(requestObject.ProfileId);
            }

            if(requestObject.IsSetRecordedOn())
            {
                context.Writer.WritePropertyName("RecordedOn");
                context.Writer.WriteNumberValue(Amazon.Util.AWSSDKUtils.ConvertToUnixEpochSecondsDecimal(requestObject.RecordedOn.Value));
            }

            if(requestObject.IsSetReferencedDatasets())
            {
                context.Writer.WritePropertyName("ReferencedDatasets");
                context.Writer.WriteStartArray();
                foreach(var requestObjectReferencedDatasetsListValue in requestObject.ReferencedDatasets)
                {
                        context.Writer.WriteStringValue(requestObjectReferencedDatasetsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetRunIdentifier())
            {
                context.Writer.WritePropertyName("RunIdentifier");
                context.Writer.WriteStartObject();

                var marshaller = RunIdentifierMarshaller.Instance;
                marshaller.Marshall(requestObject.RunIdentifier, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetStatisticId())
            {
                context.Writer.WritePropertyName("StatisticId");
                context.Writer.WriteStringValue(requestObject.StatisticId);
            }

            if(requestObject.IsSetStatisticName())
            {
                context.Writer.WritePropertyName("StatisticName");
                context.Writer.WriteStringValue(requestObject.StatisticName);
            }

            if(requestObject.IsSetStatisticProperties())
            {
                context.Writer.WritePropertyName("StatisticProperties");
                context.Writer.WriteStartObject();
                foreach (var requestObjectStatisticPropertiesKvp in requestObject.StatisticProperties)
                {
                    context.Writer.WritePropertyName(requestObjectStatisticPropertiesKvp.Key);
                    var requestObjectStatisticPropertiesValue = requestObjectStatisticPropertiesKvp.Value;

                        context.Writer.WriteStringValue(requestObjectStatisticPropertiesValue);
                }
                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static StatisticSummaryMarshaller Instance = new StatisticSummaryMarshaller();

    }
}