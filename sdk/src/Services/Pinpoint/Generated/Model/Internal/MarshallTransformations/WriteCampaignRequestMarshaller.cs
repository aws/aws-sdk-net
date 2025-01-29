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
            if(requestObject == null)
                return;
            if(requestObject.IsSetAdditionalTreatments())
            {
                context.Writer.WritePropertyName("AdditionalTreatments");
                context.Writer.WriteStartArray();
                foreach(var requestObjectAdditionalTreatmentsListValue in requestObject.AdditionalTreatments)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = WriteTreatmentResourceMarshaller.Instance;
                    marshaller.Marshall(requestObjectAdditionalTreatmentsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetCustomDeliveryConfiguration())
            {
                context.Writer.WritePropertyName("CustomDeliveryConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = CustomDeliveryConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.CustomDeliveryConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetDescription())
            {
                context.Writer.WritePropertyName("Description");
                context.Writer.WriteStringValue(requestObject.Description);
            }

            if(requestObject.IsSetHoldoutPercent())
            {
                context.Writer.WritePropertyName("HoldoutPercent");
                context.Writer.WriteNumberValue(requestObject.HoldoutPercent.Value);
            }

            if(requestObject.IsSetHook())
            {
                context.Writer.WritePropertyName("Hook");
                context.Writer.WriteStartObject();

                var marshaller = CampaignHookMarshaller.Instance;
                marshaller.Marshall(requestObject.Hook, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetIsPaused())
            {
                context.Writer.WritePropertyName("IsPaused");
                context.Writer.WriteBooleanValue(requestObject.IsPaused.Value);
            }

            if(requestObject.IsSetLimits())
            {
                context.Writer.WritePropertyName("Limits");
                context.Writer.WriteStartObject();

                var marshaller = CampaignLimitsMarshaller.Instance;
                marshaller.Marshall(requestObject.Limits, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetMessageConfiguration())
            {
                context.Writer.WritePropertyName("MessageConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = MessageConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.MessageConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetName())
            {
                context.Writer.WritePropertyName("Name");
                context.Writer.WriteStringValue(requestObject.Name);
            }

            if(requestObject.IsSetPriority())
            {
                context.Writer.WritePropertyName("Priority");
                context.Writer.WriteNumberValue(requestObject.Priority.Value);
            }

            if(requestObject.IsSetSchedule())
            {
                context.Writer.WritePropertyName("Schedule");
                context.Writer.WriteStartObject();

                var marshaller = ScheduleMarshaller.Instance;
                marshaller.Marshall(requestObject.Schedule, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetSegmentId())
            {
                context.Writer.WritePropertyName("SegmentId");
                context.Writer.WriteStringValue(requestObject.SegmentId);
            }

            if(requestObject.IsSetSegmentVersion())
            {
                context.Writer.WritePropertyName("SegmentVersion");
                context.Writer.WriteNumberValue(requestObject.SegmentVersion.Value);
            }

            if(requestObject.IsSetTags())
            {
                context.Writer.WritePropertyName("tags");
                context.Writer.WriteStartObject();
                foreach (var requestObjectTagsKvp in requestObject.Tags)
                {
                    context.Writer.WritePropertyName(requestObjectTagsKvp.Key);
                    var requestObjectTagsValue = requestObjectTagsKvp.Value;

                        context.Writer.WriteStringValue(requestObjectTagsValue);
                }
                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetTemplateConfiguration())
            {
                context.Writer.WritePropertyName("TemplateConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = TemplateConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.TemplateConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetTreatmentDescription())
            {
                context.Writer.WritePropertyName("TreatmentDescription");
                context.Writer.WriteStringValue(requestObject.TreatmentDescription);
            }

            if(requestObject.IsSetTreatmentName())
            {
                context.Writer.WritePropertyName("TreatmentName");
                context.Writer.WriteStringValue(requestObject.TreatmentName);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static WriteCampaignRequestMarshaller Instance = new WriteCampaignRequestMarshaller();

    }
}