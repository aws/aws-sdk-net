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
 * Do not modify this file. This file is generated from the partnercentral-channel-2024-03-18.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.PartnerCentralChannel.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.PartnerCentralChannel.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// StartServicePeriodPayload Marshaller
    /// </summary>
    public class StartServicePeriodPayloadMarshaller : IRequestMarshaller<StartServicePeriodPayload, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(StartServicePeriodPayload requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetEndDate())
            {
                context.Writer.WritePropertyName("endDate");
                context.Writer.WriteStringValue(StringUtils.FromDateTimeToISO8601WithOptionalMs(requestObject.EndDate));
            }

            if(requestObject.IsSetMinimumNoticeDays())
            {
                context.Writer.WritePropertyName("minimumNoticeDays");
                context.Writer.WriteStringValue(requestObject.MinimumNoticeDays);
            }

            if(requestObject.IsSetNote())
            {
                context.Writer.WritePropertyName("note");
                context.Writer.WriteStringValue(requestObject.Note);
            }

            if(requestObject.IsSetProgramManagementAccountIdentifier())
            {
                context.Writer.WritePropertyName("programManagementAccountIdentifier");
                context.Writer.WriteStringValue(requestObject.ProgramManagementAccountIdentifier);
            }

            if(requestObject.IsSetServicePeriodType())
            {
                context.Writer.WritePropertyName("servicePeriodType");
                context.Writer.WriteStringValue(requestObject.ServicePeriodType);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static StartServicePeriodPayloadMarshaller Instance = new StartServicePeriodPayloadMarshaller();

    }
}