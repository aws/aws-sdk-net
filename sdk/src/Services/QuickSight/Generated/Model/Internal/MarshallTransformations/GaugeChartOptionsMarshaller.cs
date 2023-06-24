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
    /// GaugeChartOptions Marshaller
    /// </summary>
    public class GaugeChartOptionsMarshaller : IRequestMarshaller<GaugeChartOptions, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(GaugeChartOptions requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetArc())
            {
                context.Writer.WritePropertyName("Arc");
                context.Writer.WriteObjectStart();

                var marshaller = ArcConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.Arc, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetArcAxis())
            {
                context.Writer.WritePropertyName("ArcAxis");
                context.Writer.WriteObjectStart();

                var marshaller = ArcAxisConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.ArcAxis, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetComparison())
            {
                context.Writer.WritePropertyName("Comparison");
                context.Writer.WriteObjectStart();

                var marshaller = ComparisonConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.Comparison, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetPrimaryValueDisplayType())
            {
                context.Writer.WritePropertyName("PrimaryValueDisplayType");
                context.Writer.Write(requestObject.PrimaryValueDisplayType);
            }

            if(requestObject.IsSetPrimaryValueFontConfiguration())
            {
                context.Writer.WritePropertyName("PrimaryValueFontConfiguration");
                context.Writer.WriteObjectStart();

                var marshaller = FontConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.PrimaryValueFontConfiguration, context);

                context.Writer.WriteObjectEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static GaugeChartOptionsMarshaller Instance = new GaugeChartOptionsMarshaller();

    }
}