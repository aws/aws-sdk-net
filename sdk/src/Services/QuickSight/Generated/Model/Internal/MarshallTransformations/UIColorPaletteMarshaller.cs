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
    /// UIColorPalette Marshaller
    /// </summary>
    public class UIColorPaletteMarshaller : IRequestMarshaller<UIColorPalette, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(UIColorPalette requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAccent())
            {
                context.Writer.WritePropertyName("Accent");
                context.Writer.WriteStringValue(requestObject.Accent);
            }

            if(requestObject.IsSetAccentForeground())
            {
                context.Writer.WritePropertyName("AccentForeground");
                context.Writer.WriteStringValue(requestObject.AccentForeground);
            }

            if(requestObject.IsSetDanger())
            {
                context.Writer.WritePropertyName("Danger");
                context.Writer.WriteStringValue(requestObject.Danger);
            }

            if(requestObject.IsSetDangerForeground())
            {
                context.Writer.WritePropertyName("DangerForeground");
                context.Writer.WriteStringValue(requestObject.DangerForeground);
            }

            if(requestObject.IsSetDimension())
            {
                context.Writer.WritePropertyName("Dimension");
                context.Writer.WriteStringValue(requestObject.Dimension);
            }

            if(requestObject.IsSetDimensionForeground())
            {
                context.Writer.WritePropertyName("DimensionForeground");
                context.Writer.WriteStringValue(requestObject.DimensionForeground);
            }

            if(requestObject.IsSetMeasure())
            {
                context.Writer.WritePropertyName("Measure");
                context.Writer.WriteStringValue(requestObject.Measure);
            }

            if(requestObject.IsSetMeasureForeground())
            {
                context.Writer.WritePropertyName("MeasureForeground");
                context.Writer.WriteStringValue(requestObject.MeasureForeground);
            }

            if(requestObject.IsSetPrimaryBackground())
            {
                context.Writer.WritePropertyName("PrimaryBackground");
                context.Writer.WriteStringValue(requestObject.PrimaryBackground);
            }

            if(requestObject.IsSetPrimaryForeground())
            {
                context.Writer.WritePropertyName("PrimaryForeground");
                context.Writer.WriteStringValue(requestObject.PrimaryForeground);
            }

            if(requestObject.IsSetSecondaryBackground())
            {
                context.Writer.WritePropertyName("SecondaryBackground");
                context.Writer.WriteStringValue(requestObject.SecondaryBackground);
            }

            if(requestObject.IsSetSecondaryForeground())
            {
                context.Writer.WritePropertyName("SecondaryForeground");
                context.Writer.WriteStringValue(requestObject.SecondaryForeground);
            }

            if(requestObject.IsSetSuccess())
            {
                context.Writer.WritePropertyName("Success");
                context.Writer.WriteStringValue(requestObject.Success);
            }

            if(requestObject.IsSetSuccessForeground())
            {
                context.Writer.WritePropertyName("SuccessForeground");
                context.Writer.WriteStringValue(requestObject.SuccessForeground);
            }

            if(requestObject.IsSetWarning())
            {
                context.Writer.WritePropertyName("Warning");
                context.Writer.WriteStringValue(requestObject.Warning);
            }

            if(requestObject.IsSetWarningForeground())
            {
                context.Writer.WritePropertyName("WarningForeground");
                context.Writer.WriteStringValue(requestObject.WarningForeground);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static UIColorPaletteMarshaller Instance = new UIColorPaletteMarshaller();

    }
}