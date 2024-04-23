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
 * Do not modify this file. This file is generated from the sesv2-2019-09-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.SimpleEmailV2.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.SimpleEmailV2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// MetricsDataSource Marshaller
    /// </summary>
    public class MetricsDataSourceMarshaller : IRequestMarshaller<MetricsDataSource, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(MetricsDataSource requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetDimensions())
            {
                context.Writer.WritePropertyName("Dimensions");
                context.Writer.WriteObjectStart();
                foreach (var requestObjectDimensionsKvp in requestObject.Dimensions)
                {
                    context.Writer.WritePropertyName(requestObjectDimensionsKvp.Key);
                    var requestObjectDimensionsValue = requestObjectDimensionsKvp.Value;

                    context.Writer.WriteArrayStart();
                    foreach(var requestObjectDimensionsValueListValue in requestObjectDimensionsValue)
                    {
                            context.Writer.Write(requestObjectDimensionsValueListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }
                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetEndDate())
            {
                context.Writer.WritePropertyName("EndDate");
                context.Writer.Write(requestObject.EndDate);
            }

            if(requestObject.IsSetMetrics())
            {
                context.Writer.WritePropertyName("Metrics");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectMetricsListValue in requestObject.Metrics)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = ExportMetricMarshaller.Instance;
                    marshaller.Marshall(requestObjectMetricsListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetNamespace())
            {
                context.Writer.WritePropertyName("Namespace");
                context.Writer.Write(requestObject.Namespace);
            }

            if(requestObject.IsSetStartDate())
            {
                context.Writer.WritePropertyName("StartDate");
                context.Writer.Write(requestObject.StartDate);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static MetricsDataSourceMarshaller Instance = new MetricsDataSourceMarshaller();

    }
}
#pragma warning restore CS0612,CS0618