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
            if(requestObject.IsSetMessageConfiguration())
            {
                context.Writer.WritePropertyName("MessageConfiguration");
                context.Writer.WriteObjectStart();

                var marshaller = MessageConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.MessageConfiguration, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetSchedule())
            {
                context.Writer.WritePropertyName("Schedule");
                context.Writer.WriteObjectStart();

                var marshaller = ScheduleMarshaller.Instance;
                marshaller.Marshall(requestObject.Schedule, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetSizePercent())
            {
                context.Writer.WritePropertyName("SizePercent");
                context.Writer.Write(requestObject.SizePercent);
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
        public readonly static WriteTreatmentResourceMarshaller Instance = new WriteTreatmentResourceMarshaller();

    }
}