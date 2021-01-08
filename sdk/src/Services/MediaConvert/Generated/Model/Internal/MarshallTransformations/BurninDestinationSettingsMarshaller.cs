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
 * Do not modify this file. This file is generated from the mediaconvert-2017-08-29.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.MediaConvert.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.MediaConvert.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// BurninDestinationSettings Marshaller
    /// </summary>       
    public class BurninDestinationSettingsMarshaller : IRequestMarshaller<BurninDestinationSettings, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(BurninDestinationSettings requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetAlignment())
            {
                context.Writer.WritePropertyName("alignment");
                context.Writer.Write(requestObject.Alignment);
            }

            if(requestObject.IsSetBackgroundColor())
            {
                context.Writer.WritePropertyName("backgroundColor");
                context.Writer.Write(requestObject.BackgroundColor);
            }

            if(requestObject.IsSetBackgroundOpacity())
            {
                context.Writer.WritePropertyName("backgroundOpacity");
                context.Writer.Write(requestObject.BackgroundOpacity);
            }

            if(requestObject.IsSetFontColor())
            {
                context.Writer.WritePropertyName("fontColor");
                context.Writer.Write(requestObject.FontColor);
            }

            if(requestObject.IsSetFontOpacity())
            {
                context.Writer.WritePropertyName("fontOpacity");
                context.Writer.Write(requestObject.FontOpacity);
            }

            if(requestObject.IsSetFontResolution())
            {
                context.Writer.WritePropertyName("fontResolution");
                context.Writer.Write(requestObject.FontResolution);
            }

            if(requestObject.IsSetFontScript())
            {
                context.Writer.WritePropertyName("fontScript");
                context.Writer.Write(requestObject.FontScript);
            }

            if(requestObject.IsSetFontSize())
            {
                context.Writer.WritePropertyName("fontSize");
                context.Writer.Write(requestObject.FontSize);
            }

            if(requestObject.IsSetOutlineColor())
            {
                context.Writer.WritePropertyName("outlineColor");
                context.Writer.Write(requestObject.OutlineColor);
            }

            if(requestObject.IsSetOutlineSize())
            {
                context.Writer.WritePropertyName("outlineSize");
                context.Writer.Write(requestObject.OutlineSize);
            }

            if(requestObject.IsSetShadowColor())
            {
                context.Writer.WritePropertyName("shadowColor");
                context.Writer.Write(requestObject.ShadowColor);
            }

            if(requestObject.IsSetShadowOpacity())
            {
                context.Writer.WritePropertyName("shadowOpacity");
                context.Writer.Write(requestObject.ShadowOpacity);
            }

            if(requestObject.IsSetShadowXOffset())
            {
                context.Writer.WritePropertyName("shadowXOffset");
                context.Writer.Write(requestObject.ShadowXOffset);
            }

            if(requestObject.IsSetShadowYOffset())
            {
                context.Writer.WritePropertyName("shadowYOffset");
                context.Writer.Write(requestObject.ShadowYOffset);
            }

            if(requestObject.IsSetTeletextSpacing())
            {
                context.Writer.WritePropertyName("teletextSpacing");
                context.Writer.Write(requestObject.TeletextSpacing);
            }

            if(requestObject.IsSetXPosition())
            {
                context.Writer.WritePropertyName("xPosition");
                context.Writer.Write(requestObject.XPosition);
            }

            if(requestObject.IsSetYPosition())
            {
                context.Writer.WritePropertyName("yPosition");
                context.Writer.Write(requestObject.YPosition);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static BurninDestinationSettingsMarshaller Instance = new BurninDestinationSettingsMarshaller();

    }
}