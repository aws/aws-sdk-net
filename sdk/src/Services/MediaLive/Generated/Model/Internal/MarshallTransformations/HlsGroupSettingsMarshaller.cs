/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using ThirdParty.Json.LitJson;

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
            if(requestObject.IsSetAdMarkers())
            {
                context.Writer.WritePropertyName("adMarkers");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectAdMarkersListValue in requestObject.AdMarkers)
                {
                        context.Writer.Write(requestObjectAdMarkersListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetBaseUrlContent())
            {
                context.Writer.WritePropertyName("baseUrlContent");
                context.Writer.Write(requestObject.BaseUrlContent);
            }

            if(requestObject.IsSetBaseUrlManifest())
            {
                context.Writer.WritePropertyName("baseUrlManifest");
                context.Writer.Write(requestObject.BaseUrlManifest);
            }

            if(requestObject.IsSetCaptionLanguageMappings())
            {
                context.Writer.WritePropertyName("captionLanguageMappings");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectCaptionLanguageMappingsListValue in requestObject.CaptionLanguageMappings)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = CaptionLanguageMappingMarshaller.Instance;
                    marshaller.Marshall(requestObjectCaptionLanguageMappingsListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetCaptionLanguageSetting())
            {
                context.Writer.WritePropertyName("captionLanguageSetting");
                context.Writer.Write(requestObject.CaptionLanguageSetting);
            }

            if(requestObject.IsSetClientCache())
            {
                context.Writer.WritePropertyName("clientCache");
                context.Writer.Write(requestObject.ClientCache);
            }

            if(requestObject.IsSetCodecSpecification())
            {
                context.Writer.WritePropertyName("codecSpecification");
                context.Writer.Write(requestObject.CodecSpecification);
            }

            if(requestObject.IsSetConstantIv())
            {
                context.Writer.WritePropertyName("constantIv");
                context.Writer.Write(requestObject.ConstantIv);
            }

            if(requestObject.IsSetDestination())
            {
                context.Writer.WritePropertyName("destination");
                context.Writer.WriteObjectStart();

                var marshaller = OutputLocationRefMarshaller.Instance;
                marshaller.Marshall(requestObject.Destination, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetDirectoryStructure())
            {
                context.Writer.WritePropertyName("directoryStructure");
                context.Writer.Write(requestObject.DirectoryStructure);
            }

            if(requestObject.IsSetEncryptionType())
            {
                context.Writer.WritePropertyName("encryptionType");
                context.Writer.Write(requestObject.EncryptionType);
            }

            if(requestObject.IsSetHlsCdnSettings())
            {
                context.Writer.WritePropertyName("hlsCdnSettings");
                context.Writer.WriteObjectStart();

                var marshaller = HlsCdnSettingsMarshaller.Instance;
                marshaller.Marshall(requestObject.HlsCdnSettings, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetIndexNSegments())
            {
                context.Writer.WritePropertyName("indexNSegments");
                context.Writer.Write(requestObject.IndexNSegments);
            }

            if(requestObject.IsSetInputLossAction())
            {
                context.Writer.WritePropertyName("inputLossAction");
                context.Writer.Write(requestObject.InputLossAction);
            }

            if(requestObject.IsSetIvInManifest())
            {
                context.Writer.WritePropertyName("ivInManifest");
                context.Writer.Write(requestObject.IvInManifest);
            }

            if(requestObject.IsSetIvSource())
            {
                context.Writer.WritePropertyName("ivSource");
                context.Writer.Write(requestObject.IvSource);
            }

            if(requestObject.IsSetKeepSegments())
            {
                context.Writer.WritePropertyName("keepSegments");
                context.Writer.Write(requestObject.KeepSegments);
            }

            if(requestObject.IsSetKeyFormat())
            {
                context.Writer.WritePropertyName("keyFormat");
                context.Writer.Write(requestObject.KeyFormat);
            }

            if(requestObject.IsSetKeyFormatVersions())
            {
                context.Writer.WritePropertyName("keyFormatVersions");
                context.Writer.Write(requestObject.KeyFormatVersions);
            }

            if(requestObject.IsSetKeyProviderSettings())
            {
                context.Writer.WritePropertyName("keyProviderSettings");
                context.Writer.WriteObjectStart();

                var marshaller = KeyProviderSettingsMarshaller.Instance;
                marshaller.Marshall(requestObject.KeyProviderSettings, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetManifestCompression())
            {
                context.Writer.WritePropertyName("manifestCompression");
                context.Writer.Write(requestObject.ManifestCompression);
            }

            if(requestObject.IsSetManifestDurationFormat())
            {
                context.Writer.WritePropertyName("manifestDurationFormat");
                context.Writer.Write(requestObject.ManifestDurationFormat);
            }

            if(requestObject.IsSetMinSegmentLength())
            {
                context.Writer.WritePropertyName("minSegmentLength");
                context.Writer.Write(requestObject.MinSegmentLength);
            }

            if(requestObject.IsSetMode())
            {
                context.Writer.WritePropertyName("mode");
                context.Writer.Write(requestObject.Mode);
            }

            if(requestObject.IsSetOutputSelection())
            {
                context.Writer.WritePropertyName("outputSelection");
                context.Writer.Write(requestObject.OutputSelection);
            }

            if(requestObject.IsSetProgramDateTime())
            {
                context.Writer.WritePropertyName("programDateTime");
                context.Writer.Write(requestObject.ProgramDateTime);
            }

            if(requestObject.IsSetProgramDateTimePeriod())
            {
                context.Writer.WritePropertyName("programDateTimePeriod");
                context.Writer.Write(requestObject.ProgramDateTimePeriod);
            }

            if(requestObject.IsSetSegmentationMode())
            {
                context.Writer.WritePropertyName("segmentationMode");
                context.Writer.Write(requestObject.SegmentationMode);
            }

            if(requestObject.IsSetSegmentLength())
            {
                context.Writer.WritePropertyName("segmentLength");
                context.Writer.Write(requestObject.SegmentLength);
            }

            if(requestObject.IsSetSegmentsPerSubdirectory())
            {
                context.Writer.WritePropertyName("segmentsPerSubdirectory");
                context.Writer.Write(requestObject.SegmentsPerSubdirectory);
            }

            if(requestObject.IsSetStreamInfResolution())
            {
                context.Writer.WritePropertyName("streamInfResolution");
                context.Writer.Write(requestObject.StreamInfResolution);
            }

            if(requestObject.IsSetTimedMetadataId3Frame())
            {
                context.Writer.WritePropertyName("timedMetadataId3Frame");
                context.Writer.Write(requestObject.TimedMetadataId3Frame);
            }

            if(requestObject.IsSetTimedMetadataId3Period())
            {
                context.Writer.WritePropertyName("timedMetadataId3Period");
                context.Writer.Write(requestObject.TimedMetadataId3Period);
            }

            if(requestObject.IsSetTimestampDeltaMilliseconds())
            {
                context.Writer.WritePropertyName("timestampDeltaMilliseconds");
                context.Writer.Write(requestObject.TimestampDeltaMilliseconds);
            }

            if(requestObject.IsSetTsFileMode())
            {
                context.Writer.WritePropertyName("tsFileMode");
                context.Writer.Write(requestObject.TsFileMode);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static HlsGroupSettingsMarshaller Instance = new HlsGroupSettingsMarshaller();

    }
}