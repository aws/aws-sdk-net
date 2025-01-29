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
#pragma warning disable CS0612,CS0618
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
            if(requestObject == null)
                return;
            if(requestObject.IsSetAccuracy())
            {
                context.Writer.WritePropertyName("Accuracy");
                context.Writer.WriteStartObject();

                var marshaller = PositionalAccuracyMarshaller.Instance;
                marshaller.Marshall(requestObject.Accuracy, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetDeviceId())
            {
                context.Writer.WritePropertyName("DeviceId");
                context.Writer.WriteStringValue(requestObject.DeviceId);
            }

            if(requestObject.IsSetPosition())
            {
                context.Writer.WritePropertyName("Position");
                context.Writer.WriteStartArray();
                foreach(var requestObjectPositionListValue in requestObject.Position)
                {
                        context.Writer.WriteNumberValue(requestObjectPositionListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetPositionProperties())
            {
                context.Writer.WritePropertyName("PositionProperties");
                context.Writer.WriteStartObject();
                foreach (var requestObjectPositionPropertiesKvp in requestObject.PositionProperties)
                {
                    context.Writer.WritePropertyName(requestObjectPositionPropertiesKvp.Key);
                    var requestObjectPositionPropertiesValue = requestObjectPositionPropertiesKvp.Value;

                        context.Writer.WriteStringValue(requestObjectPositionPropertiesValue);
                }
                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetSampleTime())
            {
                context.Writer.WritePropertyName("SampleTime");
                context.Writer.WriteStringValue(StringUtils.FromDateTimeToISO8601WithOptionalMs(requestObject.SampleTime));
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static DevicePositionUpdateMarshaller Instance = new DevicePositionUpdateMarshaller();

    }
}