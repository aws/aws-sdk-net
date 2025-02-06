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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.QuickSight.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.QuickSight.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// TopicColumn Marshaller
    /// </summary>
    public class TopicColumnMarshaller : IRequestMarshaller<TopicColumn, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(TopicColumn requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAggregation())
            {
                context.Writer.WritePropertyName("Aggregation");
                context.Writer.WriteStringValue(requestObject.Aggregation);
            }

            if(requestObject.IsSetAllowedAggregations())
            {
                context.Writer.WritePropertyName("AllowedAggregations");
                context.Writer.WriteStartArray();
                foreach(var requestObjectAllowedAggregationsListValue in requestObject.AllowedAggregations)
                {
                        context.Writer.WriteStringValue(requestObjectAllowedAggregationsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetCellValueSynonyms())
            {
                context.Writer.WritePropertyName("CellValueSynonyms");
                context.Writer.WriteStartArray();
                foreach(var requestObjectCellValueSynonymsListValue in requestObject.CellValueSynonyms)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = CellValueSynonymMarshaller.Instance;
                    marshaller.Marshall(requestObjectCellValueSynonymsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetColumnDataRole())
            {
                context.Writer.WritePropertyName("ColumnDataRole");
                context.Writer.WriteStringValue(requestObject.ColumnDataRole);
            }

            if(requestObject.IsSetColumnDescription())
            {
                context.Writer.WritePropertyName("ColumnDescription");
                context.Writer.WriteStringValue(requestObject.ColumnDescription);
            }

            if(requestObject.IsSetColumnFriendlyName())
            {
                context.Writer.WritePropertyName("ColumnFriendlyName");
                context.Writer.WriteStringValue(requestObject.ColumnFriendlyName);
            }

            if(requestObject.IsSetColumnName())
            {
                context.Writer.WritePropertyName("ColumnName");
                context.Writer.WriteStringValue(requestObject.ColumnName);
            }

            if(requestObject.IsSetColumnSynonyms())
            {
                context.Writer.WritePropertyName("ColumnSynonyms");
                context.Writer.WriteStartArray();
                foreach(var requestObjectColumnSynonymsListValue in requestObject.ColumnSynonyms)
                {
                        context.Writer.WriteStringValue(requestObjectColumnSynonymsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetComparativeOrder())
            {
                context.Writer.WritePropertyName("ComparativeOrder");
                context.Writer.WriteStartObject();

                var marshaller = ComparativeOrderMarshaller.Instance;
                marshaller.Marshall(requestObject.ComparativeOrder, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetDefaultFormatting())
            {
                context.Writer.WritePropertyName("DefaultFormatting");
                context.Writer.WriteStartObject();

                var marshaller = DefaultFormattingMarshaller.Instance;
                marshaller.Marshall(requestObject.DefaultFormatting, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetDisableIndexing())
            {
                context.Writer.WritePropertyName("DisableIndexing");
                context.Writer.WriteBooleanValue(requestObject.DisableIndexing.Value);
            }

            if(requestObject.IsSetIsIncludedInTopic())
            {
                context.Writer.WritePropertyName("IsIncludedInTopic");
                context.Writer.WriteBooleanValue(requestObject.IsIncludedInTopic.Value);
            }

            if(requestObject.IsSetNeverAggregateInFilter())
            {
                context.Writer.WritePropertyName("NeverAggregateInFilter");
                context.Writer.WriteBooleanValue(requestObject.NeverAggregateInFilter.Value);
            }

            if(requestObject.IsSetNonAdditive())
            {
                context.Writer.WritePropertyName("NonAdditive");
                context.Writer.WriteBooleanValue(requestObject.NonAdditive.Value);
            }

            if(requestObject.IsSetNotAllowedAggregations())
            {
                context.Writer.WritePropertyName("NotAllowedAggregations");
                context.Writer.WriteStartArray();
                foreach(var requestObjectNotAllowedAggregationsListValue in requestObject.NotAllowedAggregations)
                {
                        context.Writer.WriteStringValue(requestObjectNotAllowedAggregationsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetSemanticType())
            {
                context.Writer.WritePropertyName("SemanticType");
                context.Writer.WriteStartObject();

                var marshaller = SemanticTypeMarshaller.Instance;
                marshaller.Marshall(requestObject.SemanticType, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetTimeGranularity())
            {
                context.Writer.WritePropertyName("TimeGranularity");
                context.Writer.WriteStringValue(requestObject.TimeGranularity);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static TopicColumnMarshaller Instance = new TopicColumnMarshaller();

    }
}