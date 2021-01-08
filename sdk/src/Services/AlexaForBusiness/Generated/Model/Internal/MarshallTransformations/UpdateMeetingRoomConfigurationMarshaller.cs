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
    /// UpdateMeetingRoomConfiguration Marshaller
    /// </summary>       
    public class UpdateMeetingRoomConfigurationMarshaller : IRequestMarshaller<UpdateMeetingRoomConfiguration, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(UpdateMeetingRoomConfiguration requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetEndOfMeetingReminder())
            {
                context.Writer.WritePropertyName("EndOfMeetingReminder");
                context.Writer.WriteObjectStart();

                var marshaller = UpdateEndOfMeetingReminderMarshaller.Instance;
                marshaller.Marshall(requestObject.EndOfMeetingReminder, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetInstantBooking())
            {
                context.Writer.WritePropertyName("InstantBooking");
                context.Writer.WriteObjectStart();

                var marshaller = UpdateInstantBookingMarshaller.Instance;
                marshaller.Marshall(requestObject.InstantBooking, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetRequireCheckIn())
            {
                context.Writer.WritePropertyName("RequireCheckIn");
                context.Writer.WriteObjectStart();

                var marshaller = UpdateRequireCheckInMarshaller.Instance;
                marshaller.Marshall(requestObject.RequireCheckIn, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetRoomUtilizationMetricsEnabled())
            {
                context.Writer.WritePropertyName("RoomUtilizationMetricsEnabled");
                context.Writer.Write(requestObject.RoomUtilizationMetricsEnabled);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static UpdateMeetingRoomConfigurationMarshaller Instance = new UpdateMeetingRoomConfigurationMarshaller();

    }
}