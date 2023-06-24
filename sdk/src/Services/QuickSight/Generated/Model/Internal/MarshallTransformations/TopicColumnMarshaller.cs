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
using ThirdParty.Json.LitJson;

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
            if(requestObject.IsSetAggregation())
            {
                context.Writer.WritePropertyName("Aggregation");
                context.Writer.Write(requestObject.Aggregation);
            }

            if(requestObject.IsSetAllowedAggregations())
            {
                context.Writer.WritePropertyName("AllowedAggregations");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectAllowedAggregationsListValue in requestObject.AllowedAggregations)
                {
                        context.Writer.Write(requestObjectAllowedAggregationsListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetCellValueSynonyms())
            {
                context.Writer.WritePropertyName("CellValueSynonyms");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectCellValueSynonymsListValue in requestObject.CellValueSynonyms)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = CellValueSynonymMarshaller.Instance;
                    marshaller.Marshall(requestObjectCellValueSynonymsListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetColumnDataRole())
            {
                context.Writer.WritePropertyName("ColumnDataRole");
                context.Writer.Write(requestObject.ColumnDataRole);
            }

            if(requestObject.IsSetColumnDescription())
            {
                context.Writer.WritePropertyName("ColumnDescription");
                context.Writer.Write(requestObject.ColumnDescription);
            }

            if(requestObject.IsSetColumnFriendlyName())
            {
                context.Writer.WritePropertyName("ColumnFriendlyName");
                context.Writer.Write(requestObject.ColumnFriendlyName);
            }

            if(requestObject.IsSetColumnName())
            {
                context.Writer.WritePropertyName("ColumnName");
                context.Writer.Write(requestObject.ColumnName);
            }

            if(requestObject.IsSetColumnSynonyms())
            {
                context.Writer.WritePropertyName("ColumnSynonyms");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectColumnSynonymsListValue in requestObject.ColumnSynonyms)
                {
                        context.Writer.Write(requestObjectColumnSynonymsListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetComparativeOrder())
            {
                context.Writer.WritePropertyName("ComparativeOrder");
                context.Writer.WriteObjectStart();

                var marshaller = ComparativeOrderMarshaller.Instance;
                marshaller.Marshall(requestObject.ComparativeOrder, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetDefaultFormatting())
            {
                context.Writer.WritePropertyName("DefaultFormatting");
                context.Writer.WriteObjectStart();

                var marshaller = DefaultFormattingMarshaller.Instance;
                marshaller.Marshall(requestObject.DefaultFormatting, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetDisableIndexing())
            {
                context.Writer.WritePropertyName("DisableIndexing");
                context.Writer.Write(requestObject.DisableIndexing);
            }

            if(requestObject.IsSetIsIncludedInTopic())
            {
                context.Writer.WritePropertyName("IsIncludedInTopic");
                context.Writer.Write(requestObject.IsIncludedInTopic);
            }

            if(requestObject.IsSetNeverAggregateInFilter())
            {
                context.Writer.WritePropertyName("NeverAggregateInFilter");
                context.Writer.Write(requestObject.NeverAggregateInFilter);
            }

            if(requestObject.IsSetNotAllowedAggregations())
            {
                context.Writer.WritePropertyName("NotAllowedAggregations");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectNotAllowedAggregationsListValue in requestObject.NotAllowedAggregations)
                {
                        context.Writer.Write(requestObjectNotAllowedAggregationsListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetSemanticType())
            {
                context.Writer.WritePropertyName("SemanticType");
                context.Writer.WriteObjectStart();

                var marshaller = SemanticTypeMarshaller.Instance;
                marshaller.Marshall(requestObject.SemanticType, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetTimeGranularity())
            {
                context.Writer.WritePropertyName("TimeGranularity");
                context.Writer.Write(requestObject.TimeGranularity);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static TopicColumnMarshaller Instance = new TopicColumnMarshaller();

    }
}