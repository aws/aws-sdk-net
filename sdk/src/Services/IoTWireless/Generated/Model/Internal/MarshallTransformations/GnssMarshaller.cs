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
 * Do not modify this file. This file is generated from the iotwireless-2020-11-22.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.IoTWireless.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.IoTWireless.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Gnss Marshaller
    /// </summary>
    public class GnssMarshaller : IRequestMarshaller<Gnss, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(Gnss requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAssistAltitude())
            {
                context.Writer.WritePropertyName("AssistAltitude");
                if(StringUtils.IsSpecialFloatValue(requestObject.AssistAltitude.Value))
                {
                    context.Writer.WriteStringValue(StringUtils.FromSpecialFloatValue(requestObject.AssistAltitude.Value));
                }
                else
                {
                    context.Writer.WriteNumberValue(requestObject.AssistAltitude.Value);
                }
            }

            if(requestObject.IsSetAssistPosition())
            {
                context.Writer.WritePropertyName("AssistPosition");
                context.Writer.WriteStartArray();
                foreach(var requestObjectAssistPositionListValue in requestObject.AssistPosition)
                {
                        context.Writer.WriteNumberValue(requestObjectAssistPositionListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetCaptureTime())
            {
                context.Writer.WritePropertyName("CaptureTime");
                if(StringUtils.IsSpecialFloatValue(requestObject.CaptureTime.Value))
                {
                    context.Writer.WriteStringValue(StringUtils.FromSpecialFloatValue(requestObject.CaptureTime.Value));
                }
                else
                {
                    context.Writer.WriteNumberValue(requestObject.CaptureTime.Value);
                }
            }

            if(requestObject.IsSetCaptureTimeAccuracy())
            {
                context.Writer.WritePropertyName("CaptureTimeAccuracy");
                if(StringUtils.IsSpecialFloatValue(requestObject.CaptureTimeAccuracy.Value))
                {
                    context.Writer.WriteStringValue(StringUtils.FromSpecialFloatValue(requestObject.CaptureTimeAccuracy.Value));
                }
                else
                {
                    context.Writer.WriteNumberValue(requestObject.CaptureTimeAccuracy.Value);
                }
            }

            if(requestObject.IsSetPayload())
            {
                context.Writer.WritePropertyName("Payload");
                context.Writer.WriteStringValue(requestObject.Payload);
            }

            if(requestObject.IsSetUse2DSolver())
            {
                context.Writer.WritePropertyName("Use2DSolver");
                context.Writer.WriteBooleanValue(requestObject.Use2DSolver.Value);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static GnssMarshaller Instance = new GnssMarshaller();

    }
}