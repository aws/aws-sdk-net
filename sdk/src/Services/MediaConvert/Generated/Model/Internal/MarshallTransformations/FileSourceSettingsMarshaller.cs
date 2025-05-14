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
    /// FileSourceSettings Marshaller
    /// </summary>
    public class FileSourceSettingsMarshaller : IRequestMarshaller<FileSourceSettings, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(FileSourceSettings requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetByteRateLimit())
            {
                context.Writer.WritePropertyName("byteRateLimit");
                context.Writer.WriteStringValue(requestObject.ByteRateLimit);
            }

            if(requestObject.IsSetConvert608To708())
            {
                context.Writer.WritePropertyName("convert608To708");
                context.Writer.WriteStringValue(requestObject.Convert608To708);
            }

            if(requestObject.IsSetConvertPaintToPop())
            {
                context.Writer.WritePropertyName("convertPaintToPop");
                context.Writer.WriteStringValue(requestObject.ConvertPaintToPop);
            }

            if(requestObject.IsSetFramerate())
            {
                context.Writer.WritePropertyName("framerate");
                context.Writer.WriteStartObject();

                var marshaller = CaptionSourceFramerateMarshaller.Instance;
                marshaller.Marshall(requestObject.Framerate, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetSourceFile())
            {
                context.Writer.WritePropertyName("sourceFile");
                context.Writer.WriteStringValue(requestObject.SourceFile);
            }

            if(requestObject.IsSetTimeDelta())
            {
                context.Writer.WritePropertyName("timeDelta");
                context.Writer.WriteNumberValue(requestObject.TimeDelta.Value);
            }

            if(requestObject.IsSetTimeDeltaUnits())
            {
                context.Writer.WritePropertyName("timeDeltaUnits");
                context.Writer.WriteStringValue(requestObject.TimeDeltaUnits);
            }

            if(requestObject.IsSetUpconvertSTLToTeletext())
            {
                context.Writer.WritePropertyName("upconvertSTLToTeletext");
                context.Writer.WriteStringValue(requestObject.UpconvertSTLToTeletext);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static FileSourceSettingsMarshaller Instance = new FileSourceSettingsMarshaller();

    }
}