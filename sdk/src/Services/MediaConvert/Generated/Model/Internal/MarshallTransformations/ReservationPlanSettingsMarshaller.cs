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
 * Do not modify this file. This file is generated from the mediaconvert-2017-08-29.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.MediaConvert.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.MediaConvert.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ReservationPlanSettings Marshaller
    /// </summary>
    public class ReservationPlanSettingsMarshaller : IRequestMarshaller<ReservationPlanSettings, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(ReservationPlanSettings requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetCommitment())
            {
                context.Writer.WritePropertyName("commitment");
                context.Writer.WriteStringValue(requestObject.Commitment);
            }

            if(requestObject.IsSetRenewalType())
            {
                context.Writer.WritePropertyName("renewalType");
                context.Writer.WriteStringValue(requestObject.RenewalType);
            }

            if(requestObject.IsSetReservedSlots())
            {
                context.Writer.WritePropertyName("reservedSlots");
                context.Writer.WriteNumberValue(requestObject.ReservedSlots.Value);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static ReservationPlanSettingsMarshaller Instance = new ReservationPlanSettingsMarshaller();

    }
}