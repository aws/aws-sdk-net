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
    /// HlsGroupSettings Marshaller
    /// </summary>
    public class HlsGroupSettingsMarshaller : IRequestMarshaller<HlsGroupSettings, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(HlsGroupSettings requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAdditionalManifests())
            {
                context.Writer.WritePropertyName("additionalManifests");
                context.Writer.WriteStartArray();
                foreach(var requestObjectAdditionalManifestsListValue in requestObject.AdditionalManifests)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = HlsAdditionalManifestMarshaller.Instance;
                    marshaller.Marshall(requestObjectAdditionalManifestsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetAdMarkers())
            {
                context.Writer.WritePropertyName("adMarkers");
                context.Writer.WriteStartArray();
                foreach(var requestObjectAdMarkersListValue in requestObject.AdMarkers)
                {
                        context.Writer.WriteStringValue(requestObjectAdMarkersListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetAudioOnlyHeader())
            {
                context.Writer.WritePropertyName("audioOnlyHeader");
                context.Writer.WriteStringValue(requestObject.AudioOnlyHeader);
            }

            if(requestObject.IsSetBaseUrl())
            {
                context.Writer.WritePropertyName("baseUrl");
                context.Writer.WriteStringValue(requestObject.BaseUrl);
            }

            if(requestObject.IsSetCaptionLanguageMappings())
            {
                context.Writer.WritePropertyName("captionLanguageMappings");
                context.Writer.WriteStartArray();
                foreach(var requestObjectCaptionLanguageMappingsListValue in requestObject.CaptionLanguageMappings)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = HlsCaptionLanguageMappingMarshaller.Instance;
                    marshaller.Marshall(requestObjectCaptionLanguageMappingsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetCaptionLanguageSetting())
            {
                context.Writer.WritePropertyName("captionLanguageSetting");
                context.Writer.WriteStringValue(requestObject.CaptionLanguageSetting);
            }

            if(requestObject.IsSetCaptionSegmentLengthControl())
            {
                context.Writer.WritePropertyName("captionSegmentLengthControl");
                context.Writer.WriteStringValue(requestObject.CaptionSegmentLengthControl);
            }

            if(requestObject.IsSetClientCache())
            {
                context.Writer.WritePropertyName("clientCache");
                context.Writer.WriteStringValue(requestObject.ClientCache);
            }

            if(requestObject.IsSetCodecSpecification())
            {
                context.Writer.WritePropertyName("codecSpecification");
                context.Writer.WriteStringValue(requestObject.CodecSpecification);
            }

            if(requestObject.IsSetDestination())
            {
                context.Writer.WritePropertyName("destination");
                context.Writer.WriteStringValue(requestObject.Destination);
            }

            if(requestObject.IsSetDestinationSettings())
            {
                context.Writer.WritePropertyName("destinationSettings");
                context.Writer.WriteStartObject();

                var marshaller = DestinationSettingsMarshaller.Instance;
                marshaller.Marshall(requestObject.DestinationSettings, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetDirectoryStructure())
            {
                context.Writer.WritePropertyName("directoryStructure");
                context.Writer.WriteStringValue(requestObject.DirectoryStructure);
            }

            if(requestObject.IsSetEncryption())
            {
                context.Writer.WritePropertyName("encryption");
                context.Writer.WriteStartObject();

                var marshaller = HlsEncryptionSettingsMarshaller.Instance;
                marshaller.Marshall(requestObject.Encryption, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetImageBasedTrickPlay())
            {
                context.Writer.WritePropertyName("imageBasedTrickPlay");
                context.Writer.WriteStringValue(requestObject.ImageBasedTrickPlay);
            }

            if(requestObject.IsSetImageBasedTrickPlaySettings())
            {
                context.Writer.WritePropertyName("imageBasedTrickPlaySettings");
                context.Writer.WriteStartObject();

                var marshaller = HlsImageBasedTrickPlaySettingsMarshaller.Instance;
                marshaller.Marshall(requestObject.ImageBasedTrickPlaySettings, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetManifestCompression())
            {
                context.Writer.WritePropertyName("manifestCompression");
                context.Writer.WriteStringValue(requestObject.ManifestCompression);
            }

            if(requestObject.IsSetManifestDurationFormat())
            {
                context.Writer.WritePropertyName("manifestDurationFormat");
                context.Writer.WriteStringValue(requestObject.ManifestDurationFormat);
            }

            if(requestObject.IsSetMinFinalSegmentLength())
            {
                context.Writer.WritePropertyName("minFinalSegmentLength");
                if(StringUtils.IsSpecialDoubleValue(requestObject.MinFinalSegmentLength.Value))
                {
                    context.Writer.WriteStringValue(StringUtils.FromSpecialDoubleValue(requestObject.MinFinalSegmentLength.Value));
                }
                else
                {
                    context.Writer.WriteNumberValue(requestObject.MinFinalSegmentLength.Value);
                }
            }

            if(requestObject.IsSetMinSegmentLength())
            {
                context.Writer.WritePropertyName("minSegmentLength");
                context.Writer.WriteNumberValue(requestObject.MinSegmentLength.Value);
            }

            if(requestObject.IsSetOutputSelection())
            {
                context.Writer.WritePropertyName("outputSelection");
                context.Writer.WriteStringValue(requestObject.OutputSelection);
            }

            if(requestObject.IsSetProgramDateTime())
            {
                context.Writer.WritePropertyName("programDateTime");
                context.Writer.WriteStringValue(requestObject.ProgramDateTime);
            }

            if(requestObject.IsSetProgramDateTimePeriod())
            {
                context.Writer.WritePropertyName("programDateTimePeriod");
                context.Writer.WriteNumberValue(requestObject.ProgramDateTimePeriod.Value);
            }

            if(requestObject.IsSetProgressiveWriteHlsManifest())
            {
                context.Writer.WritePropertyName("progressiveWriteHlsManifest");
                context.Writer.WriteStringValue(requestObject.ProgressiveWriteHlsManifest);
            }

            if(requestObject.IsSetSegmentControl())
            {
                context.Writer.WritePropertyName("segmentControl");
                context.Writer.WriteStringValue(requestObject.SegmentControl);
            }

            if(requestObject.IsSetSegmentLength())
            {
                context.Writer.WritePropertyName("segmentLength");
                context.Writer.WriteNumberValue(requestObject.SegmentLength.Value);
            }

            if(requestObject.IsSetSegmentLengthControl())
            {
                context.Writer.WritePropertyName("segmentLengthControl");
                context.Writer.WriteStringValue(requestObject.SegmentLengthControl);
            }

            if(requestObject.IsSetSegmentsPerSubdirectory())
            {
                context.Writer.WritePropertyName("segmentsPerSubdirectory");
                context.Writer.WriteNumberValue(requestObject.SegmentsPerSubdirectory.Value);
            }

            if(requestObject.IsSetStreamInfResolution())
            {
                context.Writer.WritePropertyName("streamInfResolution");
                context.Writer.WriteStringValue(requestObject.StreamInfResolution);
            }

            if(requestObject.IsSetTargetDurationCompatibilityMode())
            {
                context.Writer.WritePropertyName("targetDurationCompatibilityMode");
                context.Writer.WriteStringValue(requestObject.TargetDurationCompatibilityMode);
            }

            if(requestObject.IsSetTimedMetadataId3Frame())
            {
                context.Writer.WritePropertyName("timedMetadataId3Frame");
                context.Writer.WriteStringValue(requestObject.TimedMetadataId3Frame);
            }

            if(requestObject.IsSetTimedMetadataId3Period())
            {
                context.Writer.WritePropertyName("timedMetadataId3Period");
                context.Writer.WriteNumberValue(requestObject.TimedMetadataId3Period.Value);
            }

            if(requestObject.IsSetTimestampDeltaMilliseconds())
            {
                context.Writer.WritePropertyName("timestampDeltaMilliseconds");
                context.Writer.WriteNumberValue(requestObject.TimestampDeltaMilliseconds.Value);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static HlsGroupSettingsMarshaller Instance = new HlsGroupSettingsMarshaller();

    }
}