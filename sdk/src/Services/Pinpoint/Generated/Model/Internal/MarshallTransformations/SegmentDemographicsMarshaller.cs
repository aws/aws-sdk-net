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
 * Do not modify this file. This file is generated from the pinpoint-2016-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Pinpoint.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.Pinpoint.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// SegmentDemographics Marshaller
    /// </summary>
    public class SegmentDemographicsMarshaller : IRequestMarshaller<SegmentDemographics, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(SegmentDemographics requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAppVersion())
            {
                context.Writer.WritePropertyName("AppVersion");
                context.Writer.WriteStartObject();

                var marshaller = SetDimensionMarshaller.Instance;
                marshaller.Marshall(requestObject.AppVersion, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetChannel())
            {
                context.Writer.WritePropertyName("Channel");
                context.Writer.WriteStartObject();

                var marshaller = SetDimensionMarshaller.Instance;
                marshaller.Marshall(requestObject.Channel, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetDeviceType())
            {
                context.Writer.WritePropertyName("DeviceType");
                context.Writer.WriteStartObject();

                var marshaller = SetDimensionMarshaller.Instance;
                marshaller.Marshall(requestObject.DeviceType, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetMake())
            {
                context.Writer.WritePropertyName("Make");
                context.Writer.WriteStartObject();

                var marshaller = SetDimensionMarshaller.Instance;
                marshaller.Marshall(requestObject.Make, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetModel())
            {
                context.Writer.WritePropertyName("Model");
                context.Writer.WriteStartObject();

                var marshaller = SetDimensionMarshaller.Instance;
                marshaller.Marshall(requestObject.Model, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetPlatform())
            {
                context.Writer.WritePropertyName("Platform");
                context.Writer.WriteStartObject();

                var marshaller = SetDimensionMarshaller.Instance;
                marshaller.Marshall(requestObject.Platform, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static SegmentDemographicsMarshaller Instance = new SegmentDemographicsMarshaller();

    }
}