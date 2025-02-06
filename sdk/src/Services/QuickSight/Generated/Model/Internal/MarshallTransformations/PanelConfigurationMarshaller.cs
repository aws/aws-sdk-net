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
    /// PanelConfiguration Marshaller
    /// </summary>
    public class PanelConfigurationMarshaller : IRequestMarshaller<PanelConfiguration, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(PanelConfiguration requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetBackgroundColor())
            {
                context.Writer.WritePropertyName("BackgroundColor");
                context.Writer.WriteStringValue(requestObject.BackgroundColor);
            }

            if(requestObject.IsSetBackgroundVisibility())
            {
                context.Writer.WritePropertyName("BackgroundVisibility");
                context.Writer.WriteStringValue(requestObject.BackgroundVisibility);
            }

            if(requestObject.IsSetBorderColor())
            {
                context.Writer.WritePropertyName("BorderColor");
                context.Writer.WriteStringValue(requestObject.BorderColor);
            }

            if(requestObject.IsSetBorderStyle())
            {
                context.Writer.WritePropertyName("BorderStyle");
                context.Writer.WriteStringValue(requestObject.BorderStyle);
            }

            if(requestObject.IsSetBorderThickness())
            {
                context.Writer.WritePropertyName("BorderThickness");
                context.Writer.WriteStringValue(requestObject.BorderThickness);
            }

            if(requestObject.IsSetBorderVisibility())
            {
                context.Writer.WritePropertyName("BorderVisibility");
                context.Writer.WriteStringValue(requestObject.BorderVisibility);
            }

            if(requestObject.IsSetGutterSpacing())
            {
                context.Writer.WritePropertyName("GutterSpacing");
                context.Writer.WriteStringValue(requestObject.GutterSpacing);
            }

            if(requestObject.IsSetGutterVisibility())
            {
                context.Writer.WritePropertyName("GutterVisibility");
                context.Writer.WriteStringValue(requestObject.GutterVisibility);
            }

            if(requestObject.IsSetTitle())
            {
                context.Writer.WritePropertyName("Title");
                context.Writer.WriteStartObject();

                var marshaller = PanelTitleOptionsMarshaller.Instance;
                marshaller.Marshall(requestObject.Title, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static PanelConfigurationMarshaller Instance = new PanelConfigurationMarshaller();

    }
}