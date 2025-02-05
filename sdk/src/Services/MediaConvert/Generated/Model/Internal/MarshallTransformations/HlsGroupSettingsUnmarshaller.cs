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
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.MediaConvert.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
#pragma warning disable CS0612,CS0618
namespace Amazon.MediaConvert.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for HlsGroupSettings Object
    /// </summary>  
    public class HlsGroupSettingsUnmarshaller : IJsonUnmarshaller<HlsGroupSettings, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public HlsGroupSettings Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            HlsGroupSettings unmarshalledObject = new HlsGroupSettings();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("additionalManifests", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<HlsAdditionalManifest, HlsAdditionalManifestUnmarshaller>(HlsAdditionalManifestUnmarshaller.Instance);
                    unmarshalledObject.AdditionalManifests = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("adMarkers", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.AdMarkers = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("audioOnlyHeader", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AudioOnlyHeader = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("baseUrl", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.BaseUrl = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("captionLanguageMappings", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<HlsCaptionLanguageMapping, HlsCaptionLanguageMappingUnmarshaller>(HlsCaptionLanguageMappingUnmarshaller.Instance);
                    unmarshalledObject.CaptionLanguageMappings = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("captionLanguageSetting", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.CaptionLanguageSetting = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("captionSegmentLengthControl", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.CaptionSegmentLengthControl = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("clientCache", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ClientCache = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("codecSpecification", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.CodecSpecification = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("destination", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Destination = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("destinationSettings", targetDepth))
                {
                    var unmarshaller = DestinationSettingsUnmarshaller.Instance;
                    unmarshalledObject.DestinationSettings = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("directoryStructure", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DirectoryStructure = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("encryption", targetDepth))
                {
                    var unmarshaller = HlsEncryptionSettingsUnmarshaller.Instance;
                    unmarshalledObject.Encryption = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("imageBasedTrickPlay", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ImageBasedTrickPlay = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("imageBasedTrickPlaySettings", targetDepth))
                {
                    var unmarshaller = HlsImageBasedTrickPlaySettingsUnmarshaller.Instance;
                    unmarshalledObject.ImageBasedTrickPlaySettings = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("manifestCompression", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ManifestCompression = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("manifestDurationFormat", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ManifestDurationFormat = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("minFinalSegmentLength", targetDepth))
                {
                    var unmarshaller = NullableDoubleUnmarshaller.Instance;
                    unmarshalledObject.MinFinalSegmentLength = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("minSegmentLength", targetDepth))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.MinSegmentLength = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("outputSelection", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.OutputSelection = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("programDateTime", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ProgramDateTime = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("programDateTimePeriod", targetDepth))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.ProgramDateTimePeriod = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("progressiveWriteHlsManifest", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ProgressiveWriteHlsManifest = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("segmentControl", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SegmentControl = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("segmentLength", targetDepth))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.SegmentLength = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("segmentLengthControl", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SegmentLengthControl = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("segmentsPerSubdirectory", targetDepth))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.SegmentsPerSubdirectory = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("streamInfResolution", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.StreamInfResolution = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("targetDurationCompatibilityMode", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.TargetDurationCompatibilityMode = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("timedMetadataId3Frame", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.TimedMetadataId3Frame = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("timedMetadataId3Period", targetDepth))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.TimedMetadataId3Period = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("timestampDeltaMilliseconds", targetDepth))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.TimestampDeltaMilliseconds = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static HlsGroupSettingsUnmarshaller _instance = new HlsGroupSettingsUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static HlsGroupSettingsUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}