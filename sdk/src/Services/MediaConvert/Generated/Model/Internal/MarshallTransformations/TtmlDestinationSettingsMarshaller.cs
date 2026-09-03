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
    /// TtmlDestinationSettings Marshaller
    /// </summary>
    public class TtmlDestinationSettingsMarshaller : IRequestMarshaller<TtmlDestinationSettings, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(TtmlDestinationSettings requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
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

            if(requestObject.IsSetFontColor())
            {
                context.Writer.WritePropertyName("fontColor");
                context.Writer.WriteStringValue(requestObject.FontColor);
            }

            if(requestObject.IsSetFontOpacity())
            {
                context.Writer.WritePropertyName("fontOpacity");
                context.Writer.WriteNumberValue(requestObject.FontOpacity.Value);
            }

            if(requestObject.IsSetFontSize())
            {
                context.Writer.WritePropertyName("fontSize");
                context.Writer.WriteNumberValue(requestObject.FontSize.Value);
            }

            if(requestObject.IsSetFontStyle())
            {
                context.Writer.WritePropertyName("fontStyle");
                context.Writer.WriteStringValue(requestObject.FontStyle);
            }

            if(requestObject.IsSetFontWeight())
            {
                context.Writer.WritePropertyName("fontWeight");
                context.Writer.WriteStringValue(requestObject.FontWeight);
            }

            if(requestObject.IsSetStylePassthrough())
            {
                context.Writer.WritePropertyName("stylePassthrough");
                context.Writer.WriteStringValue(requestObject.StylePassthrough);
            }

            if(requestObject.IsSetTextDecoration())
            {
                context.Writer.WritePropertyName("textDecoration");
                context.Writer.WriteStringValue(requestObject.TextDecoration);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static TtmlDestinationSettingsMarshaller Instance = new TtmlDestinationSettingsMarshaller();

    }
}