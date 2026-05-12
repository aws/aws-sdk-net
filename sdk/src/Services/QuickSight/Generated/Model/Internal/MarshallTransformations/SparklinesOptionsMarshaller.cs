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
    /// SparklinesOptions Marshaller
    /// </summary>
    public class SparklinesOptionsMarshaller : IRequestMarshaller<SparklinesOptions, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(SparklinesOptions requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAllPointsMarker())
            {
                context.Writer.WritePropertyName("AllPointsMarker");
                context.Writer.WriteStartObject();

                var marshaller = LineChartMarkerStyleSettingsMarshaller.Instance;
                marshaller.Marshall(requestObject.AllPointsMarker, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetFieldId())
            {
                context.Writer.WritePropertyName("FieldId");
                context.Writer.WriteStringValue(requestObject.FieldId);
            }

            if(requestObject.IsSetLineColor())
            {
                context.Writer.WritePropertyName("LineColor");
                context.Writer.WriteStringValue(requestObject.LineColor);
            }

            if(requestObject.IsSetLineInterpolation())
            {
                context.Writer.WritePropertyName("LineInterpolation");
                context.Writer.WriteStringValue(requestObject.LineInterpolation);
            }

            if(requestObject.IsSetMaxValueMarker())
            {
                context.Writer.WritePropertyName("MaxValueMarker");
                context.Writer.WriteStartObject();

                var marshaller = LineChartMarkerStyleSettingsMarshaller.Instance;
                marshaller.Marshall(requestObject.MaxValueMarker, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetMinValueMarker())
            {
                context.Writer.WritePropertyName("MinValueMarker");
                context.Writer.WriteStartObject();

                var marshaller = LineChartMarkerStyleSettingsMarshaller.Instance;
                marshaller.Marshall(requestObject.MinValueMarker, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetVisualType())
            {
                context.Writer.WritePropertyName("VisualType");
                context.Writer.WriteStringValue(requestObject.VisualType);
            }

            if(requestObject.IsSetXAxisField())
            {
                context.Writer.WritePropertyName("XAxisField");
                context.Writer.WriteStartObject();

                var marshaller = DimensionFieldMarshaller.Instance;
                marshaller.Marshall(requestObject.XAxisField, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetYAxisBehavior())
            {
                context.Writer.WritePropertyName("YAxisBehavior");
                context.Writer.WriteStringValue(requestObject.YAxisBehavior);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static SparklinesOptionsMarshaller Instance = new SparklinesOptionsMarshaller();

    }
}