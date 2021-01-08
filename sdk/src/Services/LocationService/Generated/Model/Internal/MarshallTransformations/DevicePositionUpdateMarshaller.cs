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
 * Do not modify this file. This file is generated from the location-2020-11-19.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.LocationService.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.LocationService.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DevicePositionUpdate Marshaller
    /// </summary>       
    public class DevicePositionUpdateMarshaller : IRequestMarshaller<DevicePositionUpdate, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(DevicePositionUpdate requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetDeviceId())
            {
                context.Writer.WritePropertyName("DeviceId");
                context.Writer.Write(requestObject.DeviceId);
            }

            if(requestObject.IsSetPosition())
            {
                context.Writer.WritePropertyName("Position");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectPositionListValue in requestObject.Position)
                {
                        context.Writer.Write(requestObjectPositionListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetSampleTime())
            {
                context.Writer.WritePropertyName("SampleTime");
                context.Writer.Write(StringUtils.FromDateTimeToISO8601(requestObject.SampleTime));
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static DevicePositionUpdateMarshaller Instance = new DevicePositionUpdateMarshaller();

    }
}