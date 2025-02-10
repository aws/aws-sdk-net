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
 * Do not modify this file. This file is generated from the medialive-2017-10-14.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.MediaLive.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.MediaLive.Model.Internal.MarshallTransformations
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

            if(requestObject.IsSetBaseUrlContent())
            {
                context.Writer.WritePropertyName("baseUrlContent");
                context.Writer.WriteStringValue(requestObject.BaseUrlContent);
            }

            if(requestObject.IsSetBaseUrlContent1())
            {
                context.Writer.WritePropertyName("baseUrlContent1");
                context.Writer.WriteStringValue(requestObject.BaseUrlContent1);
            }

            if(requestObject.IsSetBaseUrlManifest())
            {
                context.Writer.WritePropertyName("baseUrlManifest");
                context.Writer.WriteStringValue(requestObject.BaseUrlManifest);
            }

            if(requestObject.IsSetBaseUrlManifest1())
            {
                context.Writer.WritePropertyName("baseUrlManifest1");
                context.Writer.WriteStringValue(requestObject.BaseUrlManifest1);
            }

            if(requestObject.IsSetCaptionLanguageMappings())
            {
                context.Writer.WritePropertyName("captionLanguageMappings");
                context.Writer.WriteStartArray();
                foreach(var requestObjectCaptionLanguageMappingsListValue in requestObject.CaptionLanguageMappings)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = CaptionLanguageMappingMarshaller.Instance;
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

            if(requestObject.IsSetConstantIv())
            {
                context.Writer.WritePropertyName("constantIv");
                context.Writer.WriteStringValue(requestObject.ConstantIv);
            }

            if(requestObject.IsSetDestination())
            {
                context.Writer.WritePropertyName("destination");
                context.Writer.WriteStartObject();

                var marshaller = OutputLocationRefMarshaller.Instance;
                marshaller.Marshall(requestObject.Destination, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetDirectoryStructure())
            {
                context.Writer.WritePropertyName("directoryStructure");
                context.Writer.WriteStringValue(requestObject.DirectoryStructure);
            }

            if(requestObject.IsSetDiscontinuityTags())
            {
                context.Writer.WritePropertyName("discontinuityTags");
                context.Writer.WriteStringValue(requestObject.DiscontinuityTags);
            }

            if(requestObject.IsSetEncryptionType())
            {
                context.Writer.WritePropertyName("encryptionType");
                context.Writer.WriteStringValue(requestObject.EncryptionType);
            }

            if(requestObject.IsSetHlsCdnSettings())
            {
                context.Writer.WritePropertyName("hlsCdnSettings");
                context.Writer.WriteStartObject();

                var marshaller = HlsCdnSettingsMarshaller.Instance;
                marshaller.Marshall(requestObject.HlsCdnSettings, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetHlsId3SegmentTagging())
            {
                context.Writer.WritePropertyName("hlsId3SegmentTagging");
                context.Writer.WriteStringValue(requestObject.HlsId3SegmentTagging);
            }

            if(requestObject.IsSetIFrameOnlyPlaylists())
            {
                context.Writer.WritePropertyName("iFrameOnlyPlaylists");
                context.Writer.WriteStringValue(requestObject.IFrameOnlyPlaylists);
            }

            if(requestObject.IsSetIncompleteSegmentBehavior())
            {
                context.Writer.WritePropertyName("incompleteSegmentBehavior");
                context.Writer.WriteStringValue(requestObject.IncompleteSegmentBehavior);
            }

            if(requestObject.IsSetIndexNSegments())
            {
                context.Writer.WritePropertyName("indexNSegments");
                context.Writer.WriteNumberValue(requestObject.IndexNSegments.Value);
            }

            if(requestObject.IsSetInputLossAction())
            {
                context.Writer.WritePropertyName("inputLossAction");
                context.Writer.WriteStringValue(requestObject.InputLossAction);
            }

            if(requestObject.IsSetIvInManifest())
            {
                context.Writer.WritePropertyName("ivInManifest");
                context.Writer.WriteStringValue(requestObject.IvInManifest);
            }

            if(requestObject.IsSetIvSource())
            {
                context.Writer.WritePropertyName("ivSource");
                context.Writer.WriteStringValue(requestObject.IvSource);
            }

            if(requestObject.IsSetKeepSegments())
            {
                context.Writer.WritePropertyName("keepSegments");
                context.Writer.WriteNumberValue(requestObject.KeepSegments.Value);
            }

            if(requestObject.IsSetKeyFormat())
            {
                context.Writer.WritePropertyName("keyFormat");
                context.Writer.WriteStringValue(requestObject.KeyFormat);
            }

            if(requestObject.IsSetKeyFormatVersions())
            {
                context.Writer.WritePropertyName("keyFormatVersions");
                context.Writer.WriteStringValue(requestObject.KeyFormatVersions);
            }

            if(requestObject.IsSetKeyProviderSettings())
            {
                context.Writer.WritePropertyName("keyProviderSettings");
                context.Writer.WriteStartObject();

                var marshaller = KeyProviderSettingsMarshaller.Instance;
                marshaller.Marshall(requestObject.KeyProviderSettings, context);

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

            if(requestObject.IsSetMinSegmentLength())
            {
                context.Writer.WritePropertyName("minSegmentLength");
                context.Writer.WriteNumberValue(requestObject.MinSegmentLength.Value);
            }

            if(requestObject.IsSetMode())
            {
                context.Writer.WritePropertyName("mode");
                context.Writer.WriteStringValue(requestObject.Mode);
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

            if(requestObject.IsSetProgramDateTimeClock())
            {
                context.Writer.WritePropertyName("programDateTimeClock");
                context.Writer.WriteStringValue(requestObject.ProgramDateTimeClock);
            }

            if(requestObject.IsSetProgramDateTimePeriod())
            {
                context.Writer.WritePropertyName("programDateTimePeriod");
                context.Writer.WriteNumberValue(requestObject.ProgramDateTimePeriod.Value);
            }

            if(requestObject.IsSetRedundantManifest())
            {
                context.Writer.WritePropertyName("redundantManifest");
                context.Writer.WriteStringValue(requestObject.RedundantManifest);
            }

            if(requestObject.IsSetSegmentationMode())
            {
                context.Writer.WritePropertyName("segmentationMode");
                context.Writer.WriteStringValue(requestObject.SegmentationMode);
            }

            if(requestObject.IsSetSegmentLength())
            {
                context.Writer.WritePropertyName("segmentLength");
                context.Writer.WriteNumberValue(requestObject.SegmentLength.Value);
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

            if(requestObject.IsSetTsFileMode())
            {
                context.Writer.WritePropertyName("tsFileMode");
                context.Writer.WriteStringValue(requestObject.TsFileMode);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static HlsGroupSettingsMarshaller Instance = new HlsGroupSettingsMarshaller();

    }
}