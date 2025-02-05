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
    /// CmafGroupSettings Marshaller
    /// </summary>
    public class CmafGroupSettingsMarshaller : IRequestMarshaller<CmafGroupSettings, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(CmafGroupSettings requestObject, JsonMarshallerContext context)
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

                    var marshaller = CmafAdditionalManifestMarshaller.Instance;
                    marshaller.Marshall(requestObjectAdditionalManifestsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetBaseUrl())
            {
                context.Writer.WritePropertyName("baseUrl");
                context.Writer.WriteStringValue(requestObject.BaseUrl);
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

            if(requestObject.IsSetDashIFrameTrickPlayNameModifier())
            {
                context.Writer.WritePropertyName("dashIFrameTrickPlayNameModifier");
                context.Writer.WriteStringValue(requestObject.DashIFrameTrickPlayNameModifier);
            }

            if(requestObject.IsSetDashManifestStyle())
            {
                context.Writer.WritePropertyName("dashManifestStyle");
                context.Writer.WriteStringValue(requestObject.DashManifestStyle);
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

            if(requestObject.IsSetEncryption())
            {
                context.Writer.WritePropertyName("encryption");
                context.Writer.WriteStartObject();

                var marshaller = CmafEncryptionSettingsMarshaller.Instance;
                marshaller.Marshall(requestObject.Encryption, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetFragmentLength())
            {
                context.Writer.WritePropertyName("fragmentLength");
                context.Writer.WriteNumberValue(requestObject.FragmentLength.Value);
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

                var marshaller = CmafImageBasedTrickPlaySettingsMarshaller.Instance;
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

            if(requestObject.IsSetMinBufferTime())
            {
                context.Writer.WritePropertyName("minBufferTime");
                context.Writer.WriteNumberValue(requestObject.MinBufferTime.Value);
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

            if(requestObject.IsSetMpdManifestBandwidthType())
            {
                context.Writer.WritePropertyName("mpdManifestBandwidthType");
                context.Writer.WriteStringValue(requestObject.MpdManifestBandwidthType);
            }

            if(requestObject.IsSetMpdProfile())
            {
                context.Writer.WritePropertyName("mpdProfile");
                context.Writer.WriteStringValue(requestObject.MpdProfile);
            }

            if(requestObject.IsSetPtsOffsetHandlingForBFrames())
            {
                context.Writer.WritePropertyName("ptsOffsetHandlingForBFrames");
                context.Writer.WriteStringValue(requestObject.PtsOffsetHandlingForBFrames);
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

            if(requestObject.IsSetVideoCompositionOffsets())
            {
                context.Writer.WritePropertyName("videoCompositionOffsets");
                context.Writer.WriteStringValue(requestObject.VideoCompositionOffsets);
            }

            if(requestObject.IsSetWriteDashManifest())
            {
                context.Writer.WritePropertyName("writeDashManifest");
                context.Writer.WriteStringValue(requestObject.WriteDashManifest);
            }

            if(requestObject.IsSetWriteHlsManifest())
            {
                context.Writer.WritePropertyName("writeHlsManifest");
                context.Writer.WriteStringValue(requestObject.WriteHlsManifest);
            }

            if(requestObject.IsSetWriteSegmentTimelineInRepresentation())
            {
                context.Writer.WritePropertyName("writeSegmentTimelineInRepresentation");
                context.Writer.WriteStringValue(requestObject.WriteSegmentTimelineInRepresentation);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static CmafGroupSettingsMarshaller Instance = new CmafGroupSettingsMarshaller();

    }
}