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
 * Do not modify this file. This file is generated from the alexaforbusiness-2017-11-09.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.AlexaForBusiness.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.AlexaForBusiness.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for MeetingRoomConfiguration Object
    /// </summary>  
    public class MeetingRoomConfigurationUnmarshaller : IUnmarshaller<MeetingRoomConfiguration, XmlUnmarshallerContext>, IUnmarshaller<MeetingRoomConfiguration, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        MeetingRoomConfiguration IUnmarshaller<MeetingRoomConfiguration, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public MeetingRoomConfiguration Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            MeetingRoomConfiguration unmarshalledObject = new MeetingRoomConfiguration();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("EndOfMeetingReminder", targetDepth))
                {
                    var unmarshaller = EndOfMeetingReminderUnmarshaller.Instance;
                    unmarshalledObject.EndOfMeetingReminder = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("InstantBooking", targetDepth))
                {
                    var unmarshaller = InstantBookingUnmarshaller.Instance;
                    unmarshalledObject.InstantBooking = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ProactiveJoin", targetDepth))
                {
                    var unmarshaller = ProactiveJoinUnmarshaller.Instance;
                    unmarshalledObject.ProactiveJoin = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("RequireCheckIn", targetDepth))
                {
                    var unmarshaller = RequireCheckInUnmarshaller.Instance;
                    unmarshalledObject.RequireCheckIn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("RoomUtilizationMetricsEnabled", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.RoomUtilizationMetricsEnabled = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static MeetingRoomConfigurationUnmarshaller _instance = new MeetingRoomConfigurationUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static MeetingRoomConfigurationUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}