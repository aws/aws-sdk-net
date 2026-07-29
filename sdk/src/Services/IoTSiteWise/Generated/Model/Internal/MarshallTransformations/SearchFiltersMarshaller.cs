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
 * Do not modify this file. This file is generated from the iotsitewise-2019-12-02.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.IoTSiteWise.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.IoTSiteWise.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// SearchFilters Marshaller
    /// </summary>
    public class SearchFiltersMarshaller : IRequestMarshaller<SearchFilters, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(SearchFilters requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetDatasetIds())
            {
                context.Writer.WritePropertyName("datasetIds");
                context.Writer.WriteStartArray();
                foreach(var requestObjectDatasetIdsListValue in requestObject.DatasetIds)
                {
                        context.Writer.WriteStringValue(requestObjectDatasetIdsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetTimeIntervals())
            {
                context.Writer.WritePropertyName("timeIntervals");
                context.Writer.WriteStartArray();
                foreach(var requestObjectTimeIntervalsListValue in requestObject.TimeIntervals)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = TimeIntervalMarshaller.Instance;
                    marshaller.Marshall(requestObjectTimeIntervalsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetTimeSeriesIds())
            {
                context.Writer.WritePropertyName("timeSeriesIds");
                context.Writer.WriteStartArray();
                foreach(var requestObjectTimeSeriesIdsListValue in requestObject.TimeSeriesIds)
                {
                        context.Writer.WriteStringValue(requestObjectTimeSeriesIdsListValue);
                }
                context.Writer.WriteEndArray();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static SearchFiltersMarshaller Instance = new SearchFiltersMarshaller();

    }
}