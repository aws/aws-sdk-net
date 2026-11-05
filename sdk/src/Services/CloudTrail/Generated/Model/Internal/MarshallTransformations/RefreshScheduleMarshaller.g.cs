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
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

using Amazon.CloudTrail.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

#pragma warning disable CS0612,CS0618

namespace Amazon.CloudTrail.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// RefreshSchedule Marshaller
    /// </summary>
    public partial class RefreshScheduleMarshaller : IRequestMarshaller<RefreshSchedule, JsonMarshallerContext>
    {
        /// <summary>
        /// Marshall the structure from the request object to the service
        /// </summary>
        public void Marshall(RefreshSchedule requestObject, JsonMarshallerContext context)
        {
            if (requestObject == null) return;

            if (requestObject.IsSetFrequency())
            {
                context.Writer.WritePropertyName("Frequency");
                context.Writer.WriteStartObject();

                var marshaller = RefreshScheduleFrequencyMarshaller.Instance;
                marshaller.Marshall(requestObject.Frequency, context);

                context.Writer.WriteEndObject();
            }

            if (requestObject.IsSetStatus())
            {
                context.Writer.WritePropertyName("Status");
                context.Writer.WriteStringValue(requestObject.Status);
            }

            if (requestObject.IsSetTimeOfDay())
            {
                context.Writer.WritePropertyName("TimeOfDay");
                context.Writer.WriteStringValue(requestObject.TimeOfDay);
            }
        }

        /// <summary>
        /// Singleton Marshaller
        /// </summary>
        public readonly static RefreshScheduleMarshaller Instance = new RefreshScheduleMarshaller();
    }
}
