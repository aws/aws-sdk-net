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
    /// MessageInsightsFilters Marshaller
    /// </summary>
    public class MessageInsightsFiltersMarshaller : IRequestMarshaller<MessageInsightsFilters, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(MessageInsightsFilters requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetDestination())
            {
                context.Writer.WritePropertyName("Destination");
                context.Writer.WriteStartArray();
                foreach(var requestObjectDestinationListValue in requestObject.Destination)
                {
                        context.Writer.WriteStringValue(requestObjectDestinationListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetFromEmailAddress())
            {
                context.Writer.WritePropertyName("FromEmailAddress");
                context.Writer.WriteStartArray();
                foreach(var requestObjectFromEmailAddressListValue in requestObject.FromEmailAddress)
                {
                        context.Writer.WriteStringValue(requestObjectFromEmailAddressListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetIsp())
            {
                context.Writer.WritePropertyName("Isp");
                context.Writer.WriteStartArray();
                foreach(var requestObjectIspListValue in requestObject.Isp)
                {
                        context.Writer.WriteStringValue(requestObjectIspListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetLastDeliveryEvent())
            {
                context.Writer.WritePropertyName("LastDeliveryEvent");
                context.Writer.WriteStartArray();
                foreach(var requestObjectLastDeliveryEventListValue in requestObject.LastDeliveryEvent)
                {
                        context.Writer.WriteStringValue(requestObjectLastDeliveryEventListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetLastEngagementEvent())
            {
                context.Writer.WritePropertyName("LastEngagementEvent");
                context.Writer.WriteStartArray();
                foreach(var requestObjectLastEngagementEventListValue in requestObject.LastEngagementEvent)
                {
                        context.Writer.WriteStringValue(requestObjectLastEngagementEventListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetSubject())
            {
                context.Writer.WritePropertyName("Subject");
                context.Writer.WriteStartArray();
                foreach(var requestObjectSubjectListValue in requestObject.Subject)
                {
                        context.Writer.WriteStringValue(requestObjectSubjectListValue);
                }
                context.Writer.WriteEndArray();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static MessageInsightsFiltersMarshaller Instance = new MessageInsightsFiltersMarshaller();

    }
}