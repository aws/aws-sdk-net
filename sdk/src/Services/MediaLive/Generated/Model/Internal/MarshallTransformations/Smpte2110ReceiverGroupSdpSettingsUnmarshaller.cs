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
    /// Response Unmarshaller for Smpte2110ReceiverGroupSdpSettings Object
    /// </summary>  
    public class Smpte2110ReceiverGroupSdpSettingsUnmarshaller : IJsonUnmarshaller<Smpte2110ReceiverGroupSdpSettings, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public Smpte2110ReceiverGroupSdpSettings Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            Smpte2110ReceiverGroupSdpSettings unmarshalledObject = new Smpte2110ReceiverGroupSdpSettings();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("ancillarySdps", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<InputSdpLocation, InputSdpLocationUnmarshaller>(InputSdpLocationUnmarshaller.Instance);
                    unmarshalledObject.AncillarySdps = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("audioSdps", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<InputSdpLocation, InputSdpLocationUnmarshaller>(InputSdpLocationUnmarshaller.Instance);
                    unmarshalledObject.AudioSdps = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("videoSdp", targetDepth))
                {
                    var unmarshaller = InputSdpLocationUnmarshaller.Instance;
                    unmarshalledObject.VideoSdp = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static Smpte2110ReceiverGroupSdpSettingsUnmarshaller _instance = new Smpte2110ReceiverGroupSdpSettingsUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static Smpte2110ReceiverGroupSdpSettingsUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}