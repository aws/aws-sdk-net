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
 * Do not modify this file. This file is generated from the backup-gateway-2021-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.BackupGateway.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using Amazon.Extensions.CborProtocol;
using Amazon.Extensions.CborProtocol.Internal.Transform;

#pragma warning disable CS0612,CS0618
namespace Amazon.BackupGateway.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// BandwidthRateLimitInterval Marshaller
    /// </summary>
    public class BandwidthRateLimitIntervalMarshaller : IRequestMarshaller<BandwidthRateLimitInterval, CborMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(BandwidthRateLimitInterval requestObject, CborMarshallerContext context)
        {
            if (requestObject == null)
                return;

            if (requestObject.IsSetAverageUploadRateLimitInBitsPerSec())
            {
                context.Writer.WriteTextString("AverageUploadRateLimitInBitsPerSec");
                context.Writer.WriteInt64(requestObject.AverageUploadRateLimitInBitsPerSec.Value);
            }
            if (requestObject.IsSetDaysOfWeek())
            {
                context.Writer.WriteTextString("DaysOfWeek");
                context.Writer.WriteStartArray(requestObject.DaysOfWeek.Count);
                foreach(var requestObjectDaysOfWeekListValue in requestObject.DaysOfWeek)
                {
                        context.Writer.WriteInt32(requestObjectDaysOfWeekListValue);
                }
                context.Writer.WriteEndArray();
            }
            if (requestObject.IsSetEndHourOfDay())
            {
                context.Writer.WriteTextString("EndHourOfDay");
                context.Writer.WriteInt32(requestObject.EndHourOfDay.Value);
            }
            if (requestObject.IsSetEndMinuteOfHour())
            {
                context.Writer.WriteTextString("EndMinuteOfHour");
                context.Writer.WriteInt32(requestObject.EndMinuteOfHour.Value);
            }
            if (requestObject.IsSetStartHourOfDay())
            {
                context.Writer.WriteTextString("StartHourOfDay");
                context.Writer.WriteInt32(requestObject.StartHourOfDay.Value);
            }
            if (requestObject.IsSetStartMinuteOfHour())
            {
                context.Writer.WriteTextString("StartMinuteOfHour");
                context.Writer.WriteInt32(requestObject.StartMinuteOfHour.Value);
            }
        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static BandwidthRateLimitIntervalMarshaller Instance = new BandwidthRateLimitIntervalMarshaller();

    }
}