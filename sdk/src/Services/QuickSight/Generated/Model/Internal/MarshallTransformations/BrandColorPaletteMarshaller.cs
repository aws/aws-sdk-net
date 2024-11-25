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
                context.Writer.WriteObjectStart();

                var marshaller = PaletteMarshaller.Instance;
                marshaller.Marshall(requestObject.Accent, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetDanger())
            {
                context.Writer.WritePropertyName("Danger");
                context.Writer.WriteObjectStart();

                var marshaller = PaletteMarshaller.Instance;
                marshaller.Marshall(requestObject.Danger, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetDimension())
            {
                context.Writer.WritePropertyName("Dimension");
                context.Writer.WriteObjectStart();

                var marshaller = PaletteMarshaller.Instance;
                marshaller.Marshall(requestObject.Dimension, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetInfo())
            {
                context.Writer.WritePropertyName("Info");
                context.Writer.WriteObjectStart();

                var marshaller = PaletteMarshaller.Instance;
                marshaller.Marshall(requestObject.Info, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetMeasure())
            {
                context.Writer.WritePropertyName("Measure");
                context.Writer.WriteObjectStart();

                var marshaller = PaletteMarshaller.Instance;
                marshaller.Marshall(requestObject.Measure, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetPrimary())
            {
                context.Writer.WritePropertyName("Primary");
                context.Writer.WriteObjectStart();

                var marshaller = PaletteMarshaller.Instance;
                marshaller.Marshall(requestObject.Primary, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetSecondary())
            {
                context.Writer.WritePropertyName("Secondary");
                context.Writer.WriteObjectStart();

                var marshaller = PaletteMarshaller.Instance;
                marshaller.Marshall(requestObject.Secondary, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetSuccess())
            {
                context.Writer.WritePropertyName("Success");
                context.Writer.WriteObjectStart();

                var marshaller = PaletteMarshaller.Instance;
                marshaller.Marshall(requestObject.Success, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetWarning())
            {
                context.Writer.WritePropertyName("Warning");
                context.Writer.WriteObjectStart();

                var marshaller = PaletteMarshaller.Instance;
                marshaller.Marshall(requestObject.Warning, context);

                context.Writer.WriteObjectEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static BrandColorPaletteMarshaller Instance = new BrandColorPaletteMarshaller();

    }
}