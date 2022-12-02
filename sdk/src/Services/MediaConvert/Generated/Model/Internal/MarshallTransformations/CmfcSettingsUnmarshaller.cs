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
    /// Response Unmarshaller for CmfcSettings Object
    /// </summary>  
    public class CmfcSettingsUnmarshaller : IUnmarshaller<CmfcSettings, XmlUnmarshallerContext>, IUnmarshaller<CmfcSettings, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        CmfcSettings IUnmarshaller<CmfcSettings, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public CmfcSettings Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            CmfcSettings unmarshalledObject = new CmfcSettings();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("audioDuration", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AudioDuration = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("audioGroupId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AudioGroupId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("audioRenditionSets", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AudioRenditionSets = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("audioTrackType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AudioTrackType = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("descriptiveVideoServiceFlag", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DescriptiveVideoServiceFlag = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("iFrameOnlyManifest", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.IFrameOnlyManifest = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("klvMetadata", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.KlvMetadata = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("manifestMetadataSignaling", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ManifestMetadataSignaling = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("scte35Esam", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Scte35Esam = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("scte35Source", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Scte35Source = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("timedMetadata", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.TimedMetadata = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("timedMetadataBoxVersion", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.TimedMetadataBoxVersion = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("timedMetadataSchemeIdUri", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.TimedMetadataSchemeIdUri = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("timedMetadataValue", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.TimedMetadataValue = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static CmfcSettingsUnmarshaller _instance = new CmfcSettingsUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CmfcSettingsUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}