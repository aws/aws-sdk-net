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
 * Do not modify this file. This file is generated from the iot-2015-05-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.IoT.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.IoT.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// LocationAction Marshaller
    /// </summary>
    public class LocationActionMarshaller : IRequestMarshaller<LocationAction, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(LocationAction requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetDeviceId())
            {
                context.Writer.WritePropertyName("deviceId");
                context.Writer.WriteStringValue(requestObject.DeviceId);
            }

            if(requestObject.IsSetLatitude())
            {
                context.Writer.WritePropertyName("latitude");
                context.Writer.WriteStringValue(requestObject.Latitude);
            }

            if(requestObject.IsSetLongitude())
            {
                context.Writer.WritePropertyName("longitude");
                context.Writer.WriteStringValue(requestObject.Longitude);
            }

            if(requestObject.IsSetRoleArn())
            {
                context.Writer.WritePropertyName("roleArn");
                context.Writer.WriteStringValue(requestObject.RoleArn);
            }

            if(requestObject.IsSetTimestamp())
            {
                context.Writer.WritePropertyName("timestamp");
                context.Writer.WriteStartObject();

                var marshaller = LocationTimestampMarshaller.Instance;
                marshaller.Marshall(requestObject.Timestamp, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetTrackerName())
            {
                context.Writer.WritePropertyName("trackerName");
                context.Writer.WriteStringValue(requestObject.TrackerName);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static LocationActionMarshaller Instance = new LocationActionMarshaller();

    }
}