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
    /// Response Unmarshaller for MsSmoothGroupSettings Object
    /// </summary>  
    public class MsSmoothGroupSettingsUnmarshaller : IUnmarshaller<MsSmoothGroupSettings, XmlUnmarshallerContext>, IUnmarshaller<MsSmoothGroupSettings, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        MsSmoothGroupSettings IUnmarshaller<MsSmoothGroupSettings, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public MsSmoothGroupSettings Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            MsSmoothGroupSettings unmarshalledObject = new MsSmoothGroupSettings();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("acquisitionPointId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AcquisitionPointId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("audioOnlyTimecodeControl", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AudioOnlyTimecodeControl = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("certificateMode", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.CertificateMode = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("connectionRetryInterval", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.ConnectionRetryInterval = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("destination", targetDepth))
                {
                    var unmarshaller = OutputLocationRefUnmarshaller.Instance;
                    unmarshalledObject.Destination = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("eventId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.EventId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("eventIdMode", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.EventIdMode = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("eventStopBehavior", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.EventStopBehavior = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("filecacheDuration", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.FilecacheDuration = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("fragmentLength", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.FragmentLength = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("inputLossAction", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.InputLossAction = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("numRetries", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.NumRetries = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("restartDelay", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.RestartDelay = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("segmentationMode", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SegmentationMode = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("sendDelayMs", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.SendDelayMs = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("sparseTrackType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SparseTrackType = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("streamManifestBehavior", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.StreamManifestBehavior = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("timestampOffset", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.TimestampOffset = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("timestampOffsetMode", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.TimestampOffsetMode = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static MsSmoothGroupSettingsUnmarshaller _instance = new MsSmoothGroupSettingsUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static MsSmoothGroupSettingsUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}