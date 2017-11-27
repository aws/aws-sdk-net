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
using System.Net;
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
    /// Response Unmarshaller for HlsGroupSettings Object
    /// </summary>  
    public class HlsGroupSettingsUnmarshaller : IUnmarshaller<HlsGroupSettings, XmlUnmarshallerContext>, IUnmarshaller<HlsGroupSettings, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        HlsGroupSettings IUnmarshaller<HlsGroupSettings, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public HlsGroupSettings Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            HlsGroupSettings unmarshalledObject = new HlsGroupSettings();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("adMarkers", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.AdMarkers = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("baseUrl", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.BaseUrl = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("captionLanguageMappings", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<HlsCaptionLanguageMapping, HlsCaptionLanguageMappingUnmarshaller>(HlsCaptionLanguageMappingUnmarshaller.Instance);
                    unmarshalledObject.CaptionLanguageMappings = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("captionLanguageSetting", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.CaptionLanguageSetting = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("clientCache", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ClientCache = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("codecSpecification", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.CodecSpecification = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("destination", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Destination = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("directoryStructure", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DirectoryStructure = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("encryption", targetDepth))
                {
                    var unmarshaller = HlsEncryptionSettingsUnmarshaller.Instance;
                    unmarshalledObject.Encryption = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("manifestCompression", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ManifestCompression = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("manifestDurationFormat", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ManifestDurationFormat = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("minSegmentLength", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.MinSegmentLength = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("outputSelection", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.OutputSelection = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("programDateTime", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ProgramDateTime = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("programDateTimePeriod", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.ProgramDateTimePeriod = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("segmentControl", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SegmentControl = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("segmentLength", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.SegmentLength = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("segmentsPerSubdirectory", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.SegmentsPerSubdirectory = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("streamInfResolution", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.StreamInfResolution = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("timedMetadataId3Frame", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.TimedMetadataId3Frame = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("timedMetadataId3Period", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.TimedMetadataId3Period = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("timestampDeltaMilliseconds", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.TimestampDeltaMilliseconds = unmarshaller.Unmarshall(context);
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