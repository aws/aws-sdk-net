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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Connect.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Connect.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// MetricV2 Marshaller
    /// </summary>
    public class MetricV2Marshaller : IRequestMarshaller<MetricV2, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(MetricV2 requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetMetricFilters())
            {
                context.Writer.WritePropertyName("MetricFilters");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectMetricFiltersListValue in requestObject.MetricFilters)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = MetricFilterV2Marshaller.Instance;
                    marshaller.Marshall(requestObjectMetricFiltersListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetName())
            {
                context.Writer.WritePropertyName("Name");
                context.Writer.Write(requestObject.Name);
            }

            if(requestObject.IsSetThreshold())
            {
                context.Writer.WritePropertyName("Threshold");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectThresholdListValue in requestObject.Threshold)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = ThresholdV2Marshaller.Instance;
                    marshaller.Marshall(requestObjectThresholdListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static MetricV2Marshaller Instance = new MetricV2Marshaller();

    }
}