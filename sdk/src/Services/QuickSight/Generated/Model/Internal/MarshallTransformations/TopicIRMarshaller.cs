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

#pragma warning disable CS0612,CS0618
namespace Amazon.QuickSight.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// TopicIR Marshaller
    /// </summary>
    public class TopicIRMarshaller : IRequestMarshaller<TopicIR, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(TopicIR requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetContributionAnalysis())
            {
                context.Writer.WritePropertyName("ContributionAnalysis");
                context.Writer.WriteObjectStart();

                var marshaller = TopicIRContributionAnalysisMarshaller.Instance;
                marshaller.Marshall(requestObject.ContributionAnalysis, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetFilters())
            {
                context.Writer.WritePropertyName("Filters");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectFiltersListValue in requestObject.Filters)
                {
                    context.Writer.WriteArrayStart();
                    foreach(var requestObjectFiltersListValueListValue in requestObjectFiltersListValue)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = TopicIRFilterOptionMarshaller.Instance;
                        marshaller.Marshall(requestObjectFiltersListValueListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetGroupByList())
            {
                context.Writer.WritePropertyName("GroupByList");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectGroupByListListValue in requestObject.GroupByList)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = TopicIRGroupByMarshaller.Instance;
                    marshaller.Marshall(requestObjectGroupByListListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetMetrics())
            {
                context.Writer.WritePropertyName("Metrics");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectMetricsListValue in requestObject.Metrics)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = TopicIRMetricMarshaller.Instance;
                    marshaller.Marshall(requestObjectMetricsListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetSort())
            {
                context.Writer.WritePropertyName("Sort");
                context.Writer.WriteObjectStart();

                var marshaller = TopicSortClauseMarshaller.Instance;
                marshaller.Marshall(requestObject.Sort, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetVisual())
            {
                context.Writer.WritePropertyName("Visual");
                context.Writer.WriteObjectStart();

                var marshaller = VisualOptionsMarshaller.Instance;
                marshaller.Marshall(requestObject.Visual, context);

                context.Writer.WriteObjectEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static TopicIRMarshaller Instance = new TopicIRMarshaller();

    }
}