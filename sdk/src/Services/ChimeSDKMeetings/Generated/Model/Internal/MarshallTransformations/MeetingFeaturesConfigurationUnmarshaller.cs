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
 * Do not modify this file. This file is generated from the chime-sdk-meetings-2021-07-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.ChimeSDKMeetings.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
#pragma warning disable CS0612,CS0618
namespace Amazon.ChimeSDKMeetings.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for MeetingFeaturesConfiguration Object
    /// </summary>  
    public class MeetingFeaturesConfigurationUnmarshaller : IJsonUnmarshaller<MeetingFeaturesConfiguration, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public MeetingFeaturesConfiguration Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            MeetingFeaturesConfiguration unmarshalledObject = new MeetingFeaturesConfiguration();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("Attendee", targetDepth))
                {
                    var unmarshaller = AttendeeFeaturesUnmarshaller.Instance;
                    unmarshalledObject.Attendee = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Audio", targetDepth))
                {
                    var unmarshaller = AudioFeaturesUnmarshaller.Instance;
                    unmarshalledObject.Audio = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Content", targetDepth))
                {
                    var unmarshaller = ContentFeaturesUnmarshaller.Instance;
                    unmarshalledObject.Content = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Video", targetDepth))
                {
                    var unmarshaller = VideoFeaturesUnmarshaller.Instance;
                    unmarshalledObject.Video = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static MeetingFeaturesConfigurationUnmarshaller _instance = new MeetingFeaturesConfigurationUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static MeetingFeaturesConfigurationUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}