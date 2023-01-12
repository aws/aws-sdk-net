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
using ThirdParty.Json.LitJson;

namespace Amazon.MediaConvert.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for DashIsoGroupSettings Object
    /// </summary>  
    public class DashIsoGroupSettingsUnmarshaller : IUnmarshaller<DashIsoGroupSettings, XmlUnmarshallerContext>, IUnmarshaller<DashIsoGroupSettings, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        DashIsoGroupSettings IUnmarshaller<DashIsoGroupSettings, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public DashIsoGroupSettings Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            DashIsoGroupSettings unmarshalledObject = new DashIsoGroupSettings();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("additionalManifests", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<DashAdditionalManifest, DashAdditionalManifestUnmarshaller>(DashAdditionalManifestUnmarshaller.Instance);
                    unmarshalledObject.AdditionalManifests = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("audioChannelConfigSchemeIdUri", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AudioChannelConfigSchemeIdUri = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("baseUrl", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.BaseUrl = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("dashManifestStyle", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DashManifestStyle = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("destination", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Destination = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("destinationSettings", targetDepth))
                {
                    var unmarshaller = DestinationSettingsUnmarshaller.Instance;
                    unmarshalledObject.DestinationSettings = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("encryption", targetDepth))
                {
                    var unmarshaller = DashIsoEncryptionSettingsUnmarshaller.Instance;
                    unmarshalledObject.Encryption = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("fragmentLength", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.FragmentLength = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("hbbtvCompliance", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.HbbtvCompliance = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("imageBasedTrickPlay", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ImageBasedTrickPlay = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("imageBasedTrickPlaySettings", targetDepth))
                {
                    var unmarshaller = DashIsoImageBasedTrickPlaySettingsUnmarshaller.Instance;
                    unmarshalledObject.ImageBasedTrickPlaySettings = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("minBufferTime", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.MinBufferTime = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("minFinalSegmentLength", targetDepth))
                {
                    var unmarshaller = DoubleUnmarshaller.Instance;
                    unmarshalledObject.MinFinalSegmentLength = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("mpdManifestBandwidthType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.MpdManifestBandwidthType = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("mpdProfile", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.MpdProfile = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ptsOffsetHandlingForBFrames", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.PtsOffsetHandlingForBFrames = unmarshaller.Unmarshall(context);
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
                if (context.TestExpression("segmentLengthControl", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SegmentLengthControl = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("videoCompositionOffsets", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.VideoCompositionOffsets = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("writeSegmentTimelineInRepresentation", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.WriteSegmentTimelineInRepresentation = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static DashIsoGroupSettingsUnmarshaller _instance = new DashIsoGroupSettingsUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DashIsoGroupSettingsUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}