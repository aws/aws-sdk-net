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
 * Do not modify this file. This file is generated from the ssm-incidents-2018-05-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.SSMIncidents.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.SSMIncidents.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// IncidentTemplate Marshaller
    /// </summary>
    public class IncidentTemplateMarshaller : IRequestMarshaller<IncidentTemplate, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(IncidentTemplate requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetDedupeString())
            {
                context.Writer.WritePropertyName("dedupeString");
                context.Writer.Write(requestObject.DedupeString);
            }

            if(requestObject.IsSetImpact())
            {
                context.Writer.WritePropertyName("impact");
                context.Writer.Write(requestObject.Impact);
            }

            if(requestObject.IsSetNotificationTargets())
            {
                context.Writer.WritePropertyName("notificationTargets");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectNotificationTargetsListValue in requestObject.NotificationTargets)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = NotificationTargetItemMarshaller.Instance;
                    marshaller.Marshall(requestObjectNotificationTargetsListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetSummary())
            {
                context.Writer.WritePropertyName("summary");
                context.Writer.Write(requestObject.Summary);
            }

            if(requestObject.IsSetTitle())
            {
                context.Writer.WritePropertyName("title");
                context.Writer.Write(requestObject.Title);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static IncidentTemplateMarshaller Instance = new IncidentTemplateMarshaller();

    }
}