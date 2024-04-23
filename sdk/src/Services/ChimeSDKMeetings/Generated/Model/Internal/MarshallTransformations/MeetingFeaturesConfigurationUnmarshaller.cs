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
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.ChimeSDKMeetings.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for MeetingFeaturesConfiguration Object
    /// </summary>  
    public class MeetingFeaturesConfigurationUnmarshaller : IUnmarshaller<MeetingFeaturesConfiguration, XmlUnmarshallerContext>, IUnmarshaller<MeetingFeaturesConfiguration, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        MeetingFeaturesConfiguration IUnmarshaller<MeetingFeaturesConfiguration, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public MeetingFeaturesConfiguration Unmarshall(JsonUnmarshallerContext context)
        {
            MeetingFeaturesConfiguration unmarshalledObject = new MeetingFeaturesConfiguration();
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("Attendee", targetDepth))
                {
                    var unmarshaller = AttendeeFeaturesUnmarshaller.Instance;
                    unmarshalledObject.Attendee = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Audio", targetDepth))
                {
                    var unmarshaller = AudioFeaturesUnmarshaller.Instance;
                    unmarshalledObject.Audio = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Content", targetDepth))
                {
                    var unmarshaller = ContentFeaturesUnmarshaller.Instance;
                    unmarshalledObject.Content = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Video", targetDepth))
                {
                    var unmarshaller = VideoFeaturesUnmarshaller.Instance;
                    unmarshalledObject.Video = unmarshaller.Unmarshall(context);
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
#pragma warning restore CS0612,CS0618