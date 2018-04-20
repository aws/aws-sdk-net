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
using ThirdParty.Json.LitJson;

namespace Amazon.MediaLive.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for M3u8Settings Object
    /// </summary>  
    public class M3u8SettingsUnmarshaller : IUnmarshaller<M3u8Settings, XmlUnmarshallerContext>, IUnmarshaller<M3u8Settings, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        M3u8Settings IUnmarshaller<M3u8Settings, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public M3u8Settings Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            M3u8Settings unmarshalledObject = new M3u8Settings();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("audioFramesPerPes", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.AudioFramesPerPes = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("audioPids", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AudioPids = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ecmPid", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.EcmPid = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("patInterval", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.PatInterval = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("pcrControl", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.PcrControl = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("pcrPeriod", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.PcrPeriod = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("pcrPid", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.PcrPid = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("pmtInterval", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.PmtInterval = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("pmtPid", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.PmtPid = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("programNum", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.ProgramNum = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("scte35Behavior", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Scte35Behavior = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("scte35Pid", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Scte35Pid = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("timedMetadataBehavior", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.TimedMetadataBehavior = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("timedMetadataPid", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.TimedMetadataPid = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("transportStreamId", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.TransportStreamId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("videoPid", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.VideoPid = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static M3u8SettingsUnmarshaller _instance = new M3u8SettingsUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static M3u8SettingsUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}