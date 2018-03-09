/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using ThirdParty.Json.LitJson;

namespace Amazon.Pinpoint.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// WriteCampaignRequest Marshaller
    /// </summary>       
    public class WriteCampaignRequestMarshaller : IRequestMarshaller<WriteCampaignRequest, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(WriteCampaignRequest requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetAdditionalTreatments())
            {
                context.Writer.WritePropertyName("AdditionalTreatments");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectAdditionalTreatmentsListValue in requestObject.AdditionalTreatments)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = WriteTreatmentResourceMarshaller.Instance;
                    marshaller.Marshall(requestObjectAdditionalTreatmentsListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetDescription())
            {
                context.Writer.WritePropertyName("Description");
                context.Writer.Write(requestObject.Description);
            }

            if(requestObject.IsSetHoldoutPercent())
            {
                context.Writer.WritePropertyName("HoldoutPercent");
                context.Writer.Write(requestObject.HoldoutPercent);
            }

            if(requestObject.IsSetHook())
            {
                context.Writer.WritePropertyName("Hook");
                context.Writer.WriteObjectStart();

                var marshaller = CampaignHookMarshaller.Instance;
                marshaller.Marshall(requestObject.Hook, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetIsPaused())
            {
                context.Writer.WritePropertyName("IsPaused");
                context.Writer.Write(requestObject.IsPaused);
            }

            if(requestObject.IsSetLimits())
            {
                context.Writer.WritePropertyName("Limits");
                context.Writer.WriteObjectStart();

                var marshaller = CampaignLimitsMarshaller.Instance;
                marshaller.Marshall(requestObject.Limits, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetMessageConfiguration())
            {
                context.Writer.WritePropertyName("MessageConfiguration");
                context.Writer.WriteObjectStart();

                var marshaller = MessageConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.MessageConfiguration, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetName())
            {
                context.Writer.WritePropertyName("Name");
                context.Writer.Write(requestObject.Name);
            }

            if(requestObject.IsSetSchedule())
            {
                context.Writer.WritePropertyName("Schedule");
                context.Writer.WriteObjectStart();

                var marshaller = ScheduleMarshaller.Instance;
                marshaller.Marshall(requestObject.Schedule, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetSegmentId())
            {
                context.Writer.WritePropertyName("SegmentId");
                context.Writer.Write(requestObject.SegmentId);
            }

            if(requestObject.IsSetSegmentVersion())
            {
                context.Writer.WritePropertyName("SegmentVersion");
                context.Writer.Write(requestObject.SegmentVersion);
            }

            if(requestObject.IsSetTreatmentDescription())
            {
                context.Writer.WritePropertyName("TreatmentDescription");
                context.Writer.Write(requestObject.TreatmentDescription);
            }

            if(requestObject.IsSetTreatmentName())
            {
                context.Writer.WritePropertyName("TreatmentName");
                context.Writer.Write(requestObject.TreatmentName);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static WriteCampaignRequestMarshaller Instance = new WriteCampaignRequestMarshaller();

    }
}