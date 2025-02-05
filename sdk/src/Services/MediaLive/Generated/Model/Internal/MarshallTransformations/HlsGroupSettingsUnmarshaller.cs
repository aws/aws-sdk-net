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
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.MediaLive.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
#pragma warning disable CS0612,CS0618
namespace Amazon.MediaLive.Model.Internal.MarshallTransformations
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
                if (context.TestExpression("adMarkers", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.AdMarkers = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("baseUrlContent", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.BaseUrlContent = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("baseUrlContent1", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.BaseUrlContent1 = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("baseUrlManifest", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.BaseUrlManifest = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("baseUrlManifest1", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.BaseUrlManifest1 = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("captionLanguageMappings", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<CaptionLanguageMapping, CaptionLanguageMappingUnmarshaller>(CaptionLanguageMappingUnmarshaller.Instance);
                    unmarshalledObject.CaptionLanguageMappings = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("captionLanguageSetting", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.CaptionLanguageSetting = unmarshaller.Unmarshall(context, ref reader);
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
                if (context.TestExpression("constantIv", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ConstantIv = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("destination", targetDepth))
                {
                    var unmarshaller = OutputLocationRefUnmarshaller.Instance;
                    unmarshalledObject.Destination = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("directoryStructure", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DirectoryStructure = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("discontinuityTags", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DiscontinuityTags = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("encryptionType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.EncryptionType = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("hlsCdnSettings", targetDepth))
                {
                    var unmarshaller = HlsCdnSettingsUnmarshaller.Instance;
                    unmarshalledObject.HlsCdnSettings = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("hlsId3SegmentTagging", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.HlsId3SegmentTagging = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("iFrameOnlyPlaylists", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.IFrameOnlyPlaylists = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("incompleteSegmentBehavior", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.IncompleteSegmentBehavior = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("indexNSegments", targetDepth))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.IndexNSegments = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("inputLossAction", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.InputLossAction = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ivInManifest", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.IvInManifest = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ivSource", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.IvSource = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("keepSegments", targetDepth))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.KeepSegments = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("keyFormat", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.KeyFormat = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("keyFormatVersions", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.KeyFormatVersions = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("keyProviderSettings", targetDepth))
                {
                    var unmarshaller = KeyProviderSettingsUnmarshaller.Instance;
                    unmarshalledObject.KeyProviderSettings = unmarshaller.Unmarshall(context, ref reader);
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
                if (context.TestExpression("minSegmentLength", targetDepth))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.MinSegmentLength = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("mode", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Mode = unmarshaller.Unmarshall(context, ref reader);
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
                if (context.TestExpression("programDateTimeClock", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ProgramDateTimeClock = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("programDateTimePeriod", targetDepth))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.ProgramDateTimePeriod = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("redundantManifest", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.RedundantManifest = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("segmentationMode", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SegmentationMode = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("segmentLength", targetDepth))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.SegmentLength = unmarshaller.Unmarshall(context, ref reader);
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
                if (context.TestExpression("tsFileMode", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.TsFileMode = unmarshaller.Unmarshall(context, ref reader);
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