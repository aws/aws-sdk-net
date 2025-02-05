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
 * Do not modify this file. This file is generated from the xray-2016-04-12.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.XRay.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.XRay.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// TelemetryRecord Marshaller
    /// </summary>
    public class TelemetryRecordMarshaller : IRequestMarshaller<TelemetryRecord, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(TelemetryRecord requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetBackendConnectionErrors())
            {
                context.Writer.WritePropertyName("BackendConnectionErrors");
                context.Writer.WriteStartObject();

                var marshaller = BackendConnectionErrorsMarshaller.Instance;
                marshaller.Marshall(requestObject.BackendConnectionErrors, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetSegmentsReceivedCount())
            {
                context.Writer.WritePropertyName("SegmentsReceivedCount");
                context.Writer.WriteNumberValue(requestObject.SegmentsReceivedCount.Value);
            }

            if(requestObject.IsSetSegmentsRejectedCount())
            {
                context.Writer.WritePropertyName("SegmentsRejectedCount");
                context.Writer.WriteNumberValue(requestObject.SegmentsRejectedCount.Value);
            }

            if(requestObject.IsSetSegmentsSentCount())
            {
                context.Writer.WritePropertyName("SegmentsSentCount");
                context.Writer.WriteNumberValue(requestObject.SegmentsSentCount.Value);
            }

            if(requestObject.IsSetSegmentsSpilloverCount())
            {
                context.Writer.WritePropertyName("SegmentsSpilloverCount");
                context.Writer.WriteNumberValue(requestObject.SegmentsSpilloverCount.Value);
            }

            if(requestObject.IsSetTimestamp())
            {
                context.Writer.WritePropertyName("Timestamp");
                context.Writer.WriteNumberValue(Convert.ToInt64(StringUtils.FromDateTimeToUnixTimestamp(requestObject.Timestamp.Value)));
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static TelemetryRecordMarshaller Instance = new TelemetryRecordMarshaller();

    }
}