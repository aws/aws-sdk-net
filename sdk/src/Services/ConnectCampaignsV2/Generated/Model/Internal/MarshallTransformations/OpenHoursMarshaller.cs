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
 * Do not modify this file. This file is generated from the connectcampaignsv2-2024-04-23.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.ConnectCampaignsV2.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.ConnectCampaignsV2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// OpenHours Marshaller
    /// </summary>
    public class OpenHoursMarshaller : IRequestMarshaller<OpenHours, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(OpenHours requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetDailyHours())
            {
                context.Writer.WritePropertyName("dailyHours");
                context.Writer.WriteStartObject();
                foreach (var requestObjectDailyHoursKvp in requestObject.DailyHours)
                {
                    context.Writer.WritePropertyName(requestObjectDailyHoursKvp.Key);
                    var requestObjectDailyHoursValue = requestObjectDailyHoursKvp.Value;

                    context.Writer.WriteStartArray();
                    foreach(var requestObjectDailyHoursValueListValue in requestObjectDailyHoursValue)
                    {
                        context.Writer.WriteStartObject();

                        var marshaller = TimeRangeMarshaller.Instance;
                        marshaller.Marshall(requestObjectDailyHoursValueListValue, context);

                        context.Writer.WriteEndObject();
                    }
                    context.Writer.WriteEndArray();
                }
                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static OpenHoursMarshaller Instance = new OpenHoursMarshaller();

    }
}