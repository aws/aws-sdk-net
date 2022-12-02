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
    /// MpdSettings Marshaller
    /// </summary>
    public class MpdSettingsMarshaller : IRequestMarshaller<MpdSettings, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(MpdSettings requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetAccessibilityCaptionHints())
            {
                context.Writer.WritePropertyName("accessibilityCaptionHints");
                context.Writer.Write(requestObject.AccessibilityCaptionHints);
            }

            if(requestObject.IsSetAudioDuration())
            {
                context.Writer.WritePropertyName("audioDuration");
                context.Writer.Write(requestObject.AudioDuration);
            }

            if(requestObject.IsSetCaptionContainerType())
            {
                context.Writer.WritePropertyName("captionContainerType");
                context.Writer.Write(requestObject.CaptionContainerType);
            }

            if(requestObject.IsSetKlvMetadata())
            {
                context.Writer.WritePropertyName("klvMetadata");
                context.Writer.Write(requestObject.KlvMetadata);
            }

            if(requestObject.IsSetManifestMetadataSignaling())
            {
                context.Writer.WritePropertyName("manifestMetadataSignaling");
                context.Writer.Write(requestObject.ManifestMetadataSignaling);
            }

            if(requestObject.IsSetScte35Esam())
            {
                context.Writer.WritePropertyName("scte35Esam");
                context.Writer.Write(requestObject.Scte35Esam);
            }

            if(requestObject.IsSetScte35Source())
            {
                context.Writer.WritePropertyName("scte35Source");
                context.Writer.Write(requestObject.Scte35Source);
            }

            if(requestObject.IsSetTimedMetadata())
            {
                context.Writer.WritePropertyName("timedMetadata");
                context.Writer.Write(requestObject.TimedMetadata);
            }

            if(requestObject.IsSetTimedMetadataBoxVersion())
            {
                context.Writer.WritePropertyName("timedMetadataBoxVersion");
                context.Writer.Write(requestObject.TimedMetadataBoxVersion);
            }

            if(requestObject.IsSetTimedMetadataSchemeIdUri())
            {
                context.Writer.WritePropertyName("timedMetadataSchemeIdUri");
                context.Writer.Write(requestObject.TimedMetadataSchemeIdUri);
            }

            if(requestObject.IsSetTimedMetadataValue())
            {
                context.Writer.WritePropertyName("timedMetadataValue");
                context.Writer.Write(requestObject.TimedMetadataValue);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static MpdSettingsMarshaller Instance = new MpdSettingsMarshaller();

    }
}