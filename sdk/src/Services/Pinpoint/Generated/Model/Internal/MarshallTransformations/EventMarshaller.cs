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
    /// Event Marshaller
    /// </summary>
    public class EventMarshaller : IRequestMarshaller<Event, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(Event requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAppPackageName())
            {
                context.Writer.WritePropertyName("AppPackageName");
                context.Writer.WriteStringValue(requestObject.AppPackageName);
            }

            if(requestObject.IsSetAppTitle())
            {
                context.Writer.WritePropertyName("AppTitle");
                context.Writer.WriteStringValue(requestObject.AppTitle);
            }

            if(requestObject.IsSetAppVersionCode())
            {
                context.Writer.WritePropertyName("AppVersionCode");
                context.Writer.WriteStringValue(requestObject.AppVersionCode);
            }

            if(requestObject.IsSetAttributes())
            {
                context.Writer.WritePropertyName("Attributes");
                context.Writer.WriteStartObject();
                foreach (var requestObjectAttributesKvp in requestObject.Attributes)
                {
                    context.Writer.WritePropertyName(requestObjectAttributesKvp.Key);
                    var requestObjectAttributesValue = requestObjectAttributesKvp.Value;

                        context.Writer.WriteStringValue(requestObjectAttributesValue);
                }
                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetClientSdkVersion())
            {
                context.Writer.WritePropertyName("ClientSdkVersion");
                context.Writer.WriteStringValue(requestObject.ClientSdkVersion);
            }

            if(requestObject.IsSetEventType())
            {
                context.Writer.WritePropertyName("EventType");
                context.Writer.WriteStringValue(requestObject.EventType);
            }

            if(requestObject.IsSetMetrics())
            {
                context.Writer.WritePropertyName("Metrics");
                context.Writer.WriteStartObject();
                foreach (var requestObjectMetricsKvp in requestObject.Metrics)
                {
                    context.Writer.WritePropertyName(requestObjectMetricsKvp.Key);
                    var requestObjectMetricsValue = requestObjectMetricsKvp.Value;

                        context.Writer.WriteNumberValue(requestObjectMetricsValue);
                }
                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetSdkName())
            {
                context.Writer.WritePropertyName("SdkName");
                context.Writer.WriteStringValue(requestObject.SdkName);
            }

            if(requestObject.IsSetSession())
            {
                context.Writer.WritePropertyName("Session");
                context.Writer.WriteStartObject();

                var marshaller = SessionMarshaller.Instance;
                marshaller.Marshall(requestObject.Session, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetTimestamp())
            {
                context.Writer.WritePropertyName("Timestamp");
                context.Writer.WriteStringValue(requestObject.Timestamp);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static EventMarshaller Instance = new EventMarshaller();

    }
}