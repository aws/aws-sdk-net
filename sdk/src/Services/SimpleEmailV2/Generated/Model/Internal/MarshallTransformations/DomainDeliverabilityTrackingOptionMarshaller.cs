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
 * Do not modify this file. This file is generated from the sesv2-2019-09-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.SimpleEmailV2.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.SimpleEmailV2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DomainDeliverabilityTrackingOption Marshaller
    /// </summary>
    public class DomainDeliverabilityTrackingOptionMarshaller : IRequestMarshaller<DomainDeliverabilityTrackingOption, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(DomainDeliverabilityTrackingOption requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetDomain())
            {
                context.Writer.WritePropertyName("Domain");
                context.Writer.WriteStringValue(requestObject.Domain);
            }

            if(requestObject.IsSetInboxPlacementTrackingOption())
            {
                context.Writer.WritePropertyName("InboxPlacementTrackingOption");
                context.Writer.WriteStartObject();

                var marshaller = InboxPlacementTrackingOptionMarshaller.Instance;
                marshaller.Marshall(requestObject.InboxPlacementTrackingOption, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetSubscriptionStartDate())
            {
                context.Writer.WritePropertyName("SubscriptionStartDate");
                context.Writer.WriteNumberValue(Convert.ToInt64(StringUtils.FromDateTimeToUnixTimestamp(requestObject.SubscriptionStartDate.Value)));
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static DomainDeliverabilityTrackingOptionMarshaller Instance = new DomainDeliverabilityTrackingOptionMarshaller();

    }
}