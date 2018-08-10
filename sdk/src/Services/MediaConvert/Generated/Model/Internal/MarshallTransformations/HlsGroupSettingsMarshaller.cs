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

            if(requestObject.IsSetBaseUrl())
            {
                context.Writer.WritePropertyName("baseUrl");
                context.Writer.Write(requestObject.BaseUrl);
            }

            if(requestObject.IsSetCaptionLanguageMappings())
            {
                context.Writer.WritePropertyName("captionLanguageMappings");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectCaptionLanguageMappingsListValue in requestObject.CaptionLanguageMappings)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = HlsCaptionLanguageMappingMarshaller.Instance;
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

            if(requestObject.IsSetDestination())
            {
                context.Writer.WritePropertyName("destination");
                context.Writer.Write(requestObject.Destination);
            }

            if(requestObject.IsSetDirectoryStructure())
            {
                context.Writer.WritePropertyName("directoryStructure");
                context.Writer.Write(requestObject.DirectoryStructure);
            }

            if(requestObject.IsSetEncryption())
            {
                context.Writer.WritePropertyName("encryption");
                context.Writer.WriteObjectStart();

                var marshaller = HlsEncryptionSettingsMarshaller.Instance;
                marshaller.Marshall(requestObject.Encryption, context);

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

            if(requestObject.IsSetMinFinalSegmentLength())
            {
                context.Writer.WritePropertyName("minFinalSegmentLength");
                context.Writer.Write(requestObject.MinFinalSegmentLength);
            }

            if(requestObject.IsSetMinSegmentLength())
            {
                context.Writer.WritePropertyName("minSegmentLength");
                context.Writer.Write(requestObject.MinSegmentLength);
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

            if(requestObject.IsSetSegmentControl())
            {
                context.Writer.WritePropertyName("segmentControl");
                context.Writer.Write(requestObject.SegmentControl);
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

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static HlsGroupSettingsMarshaller Instance = new HlsGroupSettingsMarshaller();

    }
}