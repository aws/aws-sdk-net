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
    /// TopBottomFilter Marshaller
    /// </summary>
    public class TopBottomFilterMarshaller : IRequestMarshaller<TopBottomFilter, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(TopBottomFilter requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetAggregationSortConfigurations())
            {
                context.Writer.WritePropertyName("AggregationSortConfigurations");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectAggregationSortConfigurationsListValue in requestObject.AggregationSortConfigurations)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = AggregationSortConfigurationMarshaller.Instance;
                    marshaller.Marshall(requestObjectAggregationSortConfigurationsListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetColumn())
            {
                context.Writer.WritePropertyName("Column");
                context.Writer.WriteObjectStart();

                var marshaller = ColumnIdentifierMarshaller.Instance;
                marshaller.Marshall(requestObject.Column, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetFilterId())
            {
                context.Writer.WritePropertyName("FilterId");
                context.Writer.Write(requestObject.FilterId);
            }

            if(requestObject.IsSetLimit())
            {
                context.Writer.WritePropertyName("Limit");
                context.Writer.Write(requestObject.Limit);
            }

            if(requestObject.IsSetParameterName())
            {
                context.Writer.WritePropertyName("ParameterName");
                context.Writer.Write(requestObject.ParameterName);
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
        public readonly static TopBottomFilterMarshaller Instance = new TopBottomFilterMarshaller();

    }
}