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
 * Do not modify this file. This file is generated from the customer-profiles-2020-08-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.CustomerProfiles.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.CustomerProfiles.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// MatchingRequest Marshaller
    /// </summary>
    public class MatchingRequestMarshaller : IRequestMarshaller<MatchingRequest, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(MatchingRequest requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetAutoMerging())
            {
                context.Writer.WritePropertyName("AutoMerging");
                context.Writer.WriteObjectStart();

                var marshaller = AutoMergingMarshaller.Instance;
                marshaller.Marshall(requestObject.AutoMerging, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetEnabled())
            {
                context.Writer.WritePropertyName("Enabled");
                context.Writer.Write(requestObject.Enabled);
            }

            if(requestObject.IsSetExportingConfig())
            {
                context.Writer.WritePropertyName("ExportingConfig");
                context.Writer.WriteObjectStart();

                var marshaller = ExportingConfigMarshaller.Instance;
                marshaller.Marshall(requestObject.ExportingConfig, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetJobSchedule())
            {
                context.Writer.WritePropertyName("JobSchedule");
                context.Writer.WriteObjectStart();

                var marshaller = JobScheduleMarshaller.Instance;
                marshaller.Marshall(requestObject.JobSchedule, context);

                context.Writer.WriteObjectEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static MatchingRequestMarshaller Instance = new MatchingRequestMarshaller();

    }
}