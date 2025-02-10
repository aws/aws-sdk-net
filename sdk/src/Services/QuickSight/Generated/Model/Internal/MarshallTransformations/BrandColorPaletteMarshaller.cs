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
    /// BrandColorPalette Marshaller
    /// </summary>
    public class BrandColorPaletteMarshaller : IRequestMarshaller<BrandColorPalette, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(BrandColorPalette requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAccent())
            {
                context.Writer.WritePropertyName("Accent");
                context.Writer.WriteStartObject();

                var marshaller = PaletteMarshaller.Instance;
                marshaller.Marshall(requestObject.Accent, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetDanger())
            {
                context.Writer.WritePropertyName("Danger");
                context.Writer.WriteStartObject();

                var marshaller = PaletteMarshaller.Instance;
                marshaller.Marshall(requestObject.Danger, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetDimension())
            {
                context.Writer.WritePropertyName("Dimension");
                context.Writer.WriteStartObject();

                var marshaller = PaletteMarshaller.Instance;
                marshaller.Marshall(requestObject.Dimension, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetInfo())
            {
                context.Writer.WritePropertyName("Info");
                context.Writer.WriteStartObject();

                var marshaller = PaletteMarshaller.Instance;
                marshaller.Marshall(requestObject.Info, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetMeasure())
            {
                context.Writer.WritePropertyName("Measure");
                context.Writer.WriteStartObject();

                var marshaller = PaletteMarshaller.Instance;
                marshaller.Marshall(requestObject.Measure, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetPrimary())
            {
                context.Writer.WritePropertyName("Primary");
                context.Writer.WriteStartObject();

                var marshaller = PaletteMarshaller.Instance;
                marshaller.Marshall(requestObject.Primary, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetSecondary())
            {
                context.Writer.WritePropertyName("Secondary");
                context.Writer.WriteStartObject();

                var marshaller = PaletteMarshaller.Instance;
                marshaller.Marshall(requestObject.Secondary, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetSuccess())
            {
                context.Writer.WritePropertyName("Success");
                context.Writer.WriteStartObject();

                var marshaller = PaletteMarshaller.Instance;
                marshaller.Marshall(requestObject.Success, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetWarning())
            {
                context.Writer.WritePropertyName("Warning");
                context.Writer.WriteStartObject();

                var marshaller = PaletteMarshaller.Instance;
                marshaller.Marshall(requestObject.Warning, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static BrandColorPaletteMarshaller Instance = new BrandColorPaletteMarshaller();

    }
}