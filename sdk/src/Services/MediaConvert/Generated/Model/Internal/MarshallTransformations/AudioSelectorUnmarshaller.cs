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

#pragma warning disable CS0612,CS0618
namespace Amazon.MediaConvert.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for AudioSelector Object
    /// </summary>  
    public class AudioSelectorUnmarshaller : IUnmarshaller<AudioSelector, XmlUnmarshallerContext>, IUnmarshaller<AudioSelector, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        AudioSelector IUnmarshaller<AudioSelector, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public AudioSelector Unmarshall(JsonUnmarshallerContext context)
        {
            AudioSelector unmarshalledObject = new AudioSelector();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("audioDurationCorrection", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AudioDurationCorrection = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("customLanguageCode", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.CustomLanguageCode = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("defaultSelection", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DefaultSelection = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("externalAudioFileInput", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ExternalAudioFileInput = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("hlsRenditionGroupSettings", targetDepth))
                {
                    var unmarshaller = HlsRenditionGroupSettingsUnmarshaller.Instance;
                    unmarshalledObject.HlsRenditionGroupSettings = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("languageCode", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.LanguageCode = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("offset", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.Offset = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("pids", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<int, IntUnmarshaller>(IntUnmarshaller.Instance);
                    unmarshalledObject.Pids = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("programSelection", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.ProgramSelection = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("remixSettings", targetDepth))
                {
                    var unmarshaller = RemixSettingsUnmarshaller.Instance;
                    unmarshalledObject.RemixSettings = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("selectorType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SelectorType = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("streams", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<int, IntUnmarshaller>(IntUnmarshaller.Instance);
                    unmarshalledObject.Streams = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("tracks", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<int, IntUnmarshaller>(IntUnmarshaller.Instance);
                    unmarshalledObject.Tracks = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static AudioSelectorUnmarshaller _instance = new AudioSelectorUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static AudioSelectorUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}