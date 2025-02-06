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
 * Do not modify this file. This file is generated from the storagegateway-2013-06-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.StorageGateway.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.StorageGateway.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// BandwidthRateLimitInterval Marshaller
    /// </summary>
    public class BandwidthRateLimitIntervalMarshaller : IRequestMarshaller<BandwidthRateLimitInterval, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(BandwidthRateLimitInterval requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAverageDownloadRateLimitInBitsPerSec())
            {
                context.Writer.WritePropertyName("AverageDownloadRateLimitInBitsPerSec");
                context.Writer.WriteNumberValue(requestObject.AverageDownloadRateLimitInBitsPerSec.Value);
            }

            if(requestObject.IsSetAverageUploadRateLimitInBitsPerSec())
            {
                context.Writer.WritePropertyName("AverageUploadRateLimitInBitsPerSec");
                context.Writer.WriteNumberValue(requestObject.AverageUploadRateLimitInBitsPerSec.Value);
            }

            if(requestObject.IsSetDaysOfWeek())
            {
                context.Writer.WritePropertyName("DaysOfWeek");
                context.Writer.WriteStartArray();
                foreach(var requestObjectDaysOfWeekListValue in requestObject.DaysOfWeek)
                {
                        context.Writer.WriteNumberValue(requestObjectDaysOfWeekListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetEndHourOfDay())
            {
                context.Writer.WritePropertyName("EndHourOfDay");
                context.Writer.WriteNumberValue(requestObject.EndHourOfDay.Value);
            }

            if(requestObject.IsSetEndMinuteOfHour())
            {
                context.Writer.WritePropertyName("EndMinuteOfHour");
                context.Writer.WriteNumberValue(requestObject.EndMinuteOfHour.Value);
            }

            if(requestObject.IsSetStartHourOfDay())
            {
                context.Writer.WritePropertyName("StartHourOfDay");
                context.Writer.WriteNumberValue(requestObject.StartHourOfDay.Value);
            }

            if(requestObject.IsSetStartMinuteOfHour())
            {
                context.Writer.WritePropertyName("StartMinuteOfHour");
                context.Writer.WriteNumberValue(requestObject.StartMinuteOfHour.Value);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static BandwidthRateLimitIntervalMarshaller Instance = new BandwidthRateLimitIntervalMarshaller();

    }
}