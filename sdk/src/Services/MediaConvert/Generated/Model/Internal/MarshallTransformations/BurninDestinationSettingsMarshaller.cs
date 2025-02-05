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
#pragma warning disable CS0612,CS0618
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
            if(requestObject == null)
                return;
            if(requestObject.IsSetAlignment())
            {
                context.Writer.WritePropertyName("alignment");
                context.Writer.WriteStringValue(requestObject.Alignment);
            }

            if(requestObject.IsSetApplyFontColor())
            {
                context.Writer.WritePropertyName("applyFontColor");
                context.Writer.WriteStringValue(requestObject.ApplyFontColor);
            }

            if(requestObject.IsSetBackgroundColor())
            {
                context.Writer.WritePropertyName("backgroundColor");
                context.Writer.WriteStringValue(requestObject.BackgroundColor);
            }

            if(requestObject.IsSetBackgroundOpacity())
            {
                context.Writer.WritePropertyName("backgroundOpacity");
                context.Writer.WriteNumberValue(requestObject.BackgroundOpacity.Value);
            }

            if(requestObject.IsSetFallbackFont())
            {
                context.Writer.WritePropertyName("fallbackFont");
                context.Writer.WriteStringValue(requestObject.FallbackFont);
            }

            if(requestObject.IsSetFontColor())
            {
                context.Writer.WritePropertyName("fontColor");
                context.Writer.WriteStringValue(requestObject.FontColor);
            }

            if(requestObject.IsSetFontFileBold())
            {
                context.Writer.WritePropertyName("fontFileBold");
                context.Writer.WriteStringValue(requestObject.FontFileBold);
            }

            if(requestObject.IsSetFontFileBoldItalic())
            {
                context.Writer.WritePropertyName("fontFileBoldItalic");
                context.Writer.WriteStringValue(requestObject.FontFileBoldItalic);
            }

            if(requestObject.IsSetFontFileItalic())
            {
                context.Writer.WritePropertyName("fontFileItalic");
                context.Writer.WriteStringValue(requestObject.FontFileItalic);
            }

            if(requestObject.IsSetFontFileRegular())
            {
                context.Writer.WritePropertyName("fontFileRegular");
                context.Writer.WriteStringValue(requestObject.FontFileRegular);
            }

            if(requestObject.IsSetFontOpacity())
            {
                context.Writer.WritePropertyName("fontOpacity");
                context.Writer.WriteNumberValue(requestObject.FontOpacity.Value);
            }

            if(requestObject.IsSetFontResolution())
            {
                context.Writer.WritePropertyName("fontResolution");
                context.Writer.WriteNumberValue(requestObject.FontResolution.Value);
            }

            if(requestObject.IsSetFontScript())
            {
                context.Writer.WritePropertyName("fontScript");
                context.Writer.WriteStringValue(requestObject.FontScript);
            }

            if(requestObject.IsSetFontSize())
            {
                context.Writer.WritePropertyName("fontSize");
                context.Writer.WriteNumberValue(requestObject.FontSize.Value);
            }

            if(requestObject.IsSetHexFontColor())
            {
                context.Writer.WritePropertyName("hexFontColor");
                context.Writer.WriteStringValue(requestObject.HexFontColor);
            }

            if(requestObject.IsSetOutlineColor())
            {
                context.Writer.WritePropertyName("outlineColor");
                context.Writer.WriteStringValue(requestObject.OutlineColor);
            }

            if(requestObject.IsSetOutlineSize())
            {
                context.Writer.WritePropertyName("outlineSize");
                context.Writer.WriteNumberValue(requestObject.OutlineSize.Value);
            }

            if(requestObject.IsSetRemoveRubyReserveAttributes())
            {
                context.Writer.WritePropertyName("removeRubyReserveAttributes");
                context.Writer.WriteStringValue(requestObject.RemoveRubyReserveAttributes);
            }

            if(requestObject.IsSetShadowColor())
            {
                context.Writer.WritePropertyName("shadowColor");
                context.Writer.WriteStringValue(requestObject.ShadowColor);
            }

            if(requestObject.IsSetShadowOpacity())
            {
                context.Writer.WritePropertyName("shadowOpacity");
                context.Writer.WriteNumberValue(requestObject.ShadowOpacity.Value);
            }

            if(requestObject.IsSetShadowXOffset())
            {
                context.Writer.WritePropertyName("shadowXOffset");
                context.Writer.WriteNumberValue(requestObject.ShadowXOffset.Value);
            }

            if(requestObject.IsSetShadowYOffset())
            {
                context.Writer.WritePropertyName("shadowYOffset");
                context.Writer.WriteNumberValue(requestObject.ShadowYOffset.Value);
            }

            if(requestObject.IsSetStylePassthrough())
            {
                context.Writer.WritePropertyName("stylePassthrough");
                context.Writer.WriteStringValue(requestObject.StylePassthrough);
            }

            if(requestObject.IsSetTeletextSpacing())
            {
                context.Writer.WritePropertyName("teletextSpacing");
                context.Writer.WriteStringValue(requestObject.TeletextSpacing);
            }

            if(requestObject.IsSetXPosition())
            {
                context.Writer.WritePropertyName("xPosition");
                context.Writer.WriteNumberValue(requestObject.XPosition.Value);
            }

            if(requestObject.IsSetYPosition())
            {
                context.Writer.WritePropertyName("yPosition");
                context.Writer.WriteNumberValue(requestObject.YPosition.Value);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static BurninDestinationSettingsMarshaller Instance = new BurninDestinationSettingsMarshaller();

    }
}