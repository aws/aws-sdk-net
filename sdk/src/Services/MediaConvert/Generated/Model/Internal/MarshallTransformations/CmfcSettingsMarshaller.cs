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
    /// CmfcSettings Marshaller
    /// </summary>
    public class CmfcSettingsMarshaller : IRequestMarshaller<CmfcSettings, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(CmfcSettings requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAudioDuration())
            {
                context.Writer.WritePropertyName("audioDuration");
                context.Writer.WriteStringValue(requestObject.AudioDuration);
            }

            if(requestObject.IsSetAudioGroupId())
            {
                context.Writer.WritePropertyName("audioGroupId");
                context.Writer.WriteStringValue(requestObject.AudioGroupId);
            }

            if(requestObject.IsSetAudioRenditionSets())
            {
                context.Writer.WritePropertyName("audioRenditionSets");
                context.Writer.WriteStringValue(requestObject.AudioRenditionSets);
            }

            if(requestObject.IsSetAudioTrackType())
            {
                context.Writer.WritePropertyName("audioTrackType");
                context.Writer.WriteStringValue(requestObject.AudioTrackType);
            }

            if(requestObject.IsSetDescriptiveVideoServiceFlag())
            {
                context.Writer.WritePropertyName("descriptiveVideoServiceFlag");
                context.Writer.WriteStringValue(requestObject.DescriptiveVideoServiceFlag);
            }

            if(requestObject.IsSetIFrameOnlyManifest())
            {
                context.Writer.WritePropertyName("iFrameOnlyManifest");
                context.Writer.WriteStringValue(requestObject.IFrameOnlyManifest);
            }

            if(requestObject.IsSetKlvMetadata())
            {
                context.Writer.WritePropertyName("klvMetadata");
                context.Writer.WriteStringValue(requestObject.KlvMetadata);
            }

            if(requestObject.IsSetManifestMetadataSignaling())
            {
                context.Writer.WritePropertyName("manifestMetadataSignaling");
                context.Writer.WriteStringValue(requestObject.ManifestMetadataSignaling);
            }

            if(requestObject.IsSetScte35Esam())
            {
                context.Writer.WritePropertyName("scte35Esam");
                context.Writer.WriteStringValue(requestObject.Scte35Esam);
            }

            if(requestObject.IsSetScte35Source())
            {
                context.Writer.WritePropertyName("scte35Source");
                context.Writer.WriteStringValue(requestObject.Scte35Source);
            }

            if(requestObject.IsSetTimedMetadata())
            {
                context.Writer.WritePropertyName("timedMetadata");
                context.Writer.WriteStringValue(requestObject.TimedMetadata);
            }

            if(requestObject.IsSetTimedMetadataBoxVersion())
            {
                context.Writer.WritePropertyName("timedMetadataBoxVersion");
                context.Writer.WriteStringValue(requestObject.TimedMetadataBoxVersion);
            }

            if(requestObject.IsSetTimedMetadataSchemeIdUri())
            {
                context.Writer.WritePropertyName("timedMetadataSchemeIdUri");
                context.Writer.WriteStringValue(requestObject.TimedMetadataSchemeIdUri);
            }

            if(requestObject.IsSetTimedMetadataValue())
            {
                context.Writer.WritePropertyName("timedMetadataValue");
                context.Writer.WriteStringValue(requestObject.TimedMetadataValue);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static CmfcSettingsMarshaller Instance = new CmfcSettingsMarshaller();

    }
}