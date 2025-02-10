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
    /// KPIOptions Marshaller
    /// </summary>
    public class KPIOptionsMarshaller : IRequestMarshaller<KPIOptions, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(KPIOptions requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetComparison())
            {
                context.Writer.WritePropertyName("Comparison");
                context.Writer.WriteStartObject();

                var marshaller = ComparisonConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.Comparison, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetPrimaryValueDisplayType())
            {
                context.Writer.WritePropertyName("PrimaryValueDisplayType");
                context.Writer.WriteStringValue(requestObject.PrimaryValueDisplayType);
            }

            if(requestObject.IsSetPrimaryValueFontConfiguration())
            {
                context.Writer.WritePropertyName("PrimaryValueFontConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = FontConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.PrimaryValueFontConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetProgressBar())
            {
                context.Writer.WritePropertyName("ProgressBar");
                context.Writer.WriteStartObject();

                var marshaller = ProgressBarOptionsMarshaller.Instance;
                marshaller.Marshall(requestObject.ProgressBar, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetSecondaryValue())
            {
                context.Writer.WritePropertyName("SecondaryValue");
                context.Writer.WriteStartObject();

                var marshaller = SecondaryValueOptionsMarshaller.Instance;
                marshaller.Marshall(requestObject.SecondaryValue, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetSecondaryValueFontConfiguration())
            {
                context.Writer.WritePropertyName("SecondaryValueFontConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = FontConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.SecondaryValueFontConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetSparkline())
            {
                context.Writer.WritePropertyName("Sparkline");
                context.Writer.WriteStartObject();

                var marshaller = KPISparklineOptionsMarshaller.Instance;
                marshaller.Marshall(requestObject.Sparkline, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetTrendArrows())
            {
                context.Writer.WritePropertyName("TrendArrows");
                context.Writer.WriteStartObject();

                var marshaller = TrendArrowOptionsMarshaller.Instance;
                marshaller.Marshall(requestObject.TrendArrows, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetVisualLayoutOptions())
            {
                context.Writer.WritePropertyName("VisualLayoutOptions");
                context.Writer.WriteStartObject();

                var marshaller = KPIVisualLayoutOptionsMarshaller.Instance;
                marshaller.Marshall(requestObject.VisualLayoutOptions, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static KPIOptionsMarshaller Instance = new KPIOptionsMarshaller();

    }
}