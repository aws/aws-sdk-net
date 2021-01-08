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
    /// Response Unmarshaller for NielsenNonLinearWatermarkSettings Object
    /// </summary>  
    public class NielsenNonLinearWatermarkSettingsUnmarshaller : IUnmarshaller<NielsenNonLinearWatermarkSettings, XmlUnmarshallerContext>, IUnmarshaller<NielsenNonLinearWatermarkSettings, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        NielsenNonLinearWatermarkSettings IUnmarshaller<NielsenNonLinearWatermarkSettings, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public NielsenNonLinearWatermarkSettings Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            NielsenNonLinearWatermarkSettings unmarshalledObject = new NielsenNonLinearWatermarkSettings();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("activeWatermarkProcess", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ActiveWatermarkProcess = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("adiFilename", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AdiFilename = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("assetId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AssetId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("assetName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AssetName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("cbetSourceId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.CbetSourceId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("episodeId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.EpisodeId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("metadataDestination", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.MetadataDestination = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("sourceId", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.SourceId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("sourceWatermarkStatus", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SourceWatermarkStatus = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ticServerUrl", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.TicServerUrl = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("uniqueTicPerAudioTrack", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.UniqueTicPerAudioTrack = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static NielsenNonLinearWatermarkSettingsUnmarshaller _instance = new NielsenNonLinearWatermarkSettingsUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static NielsenNonLinearWatermarkSettingsUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}