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
    /// WriteTreatmentResource Marshaller
    /// </summary>
    public class WriteTreatmentResourceMarshaller : IRequestMarshaller<WriteTreatmentResource, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(WriteTreatmentResource requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetCustomDeliveryConfiguration())
            {
                context.Writer.WritePropertyName("CustomDeliveryConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = CustomDeliveryConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.CustomDeliveryConfiguration, context);

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

            if(requestObject.IsSetSchedule())
            {
                context.Writer.WritePropertyName("Schedule");
                context.Writer.WriteStartObject();

                var marshaller = ScheduleMarshaller.Instance;
                marshaller.Marshall(requestObject.Schedule, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetSizePercent())
            {
                context.Writer.WritePropertyName("SizePercent");
                context.Writer.WriteNumberValue(requestObject.SizePercent.Value);
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
        public readonly static WriteTreatmentResourceMarshaller Instance = new WriteTreatmentResourceMarshaller();

    }
}