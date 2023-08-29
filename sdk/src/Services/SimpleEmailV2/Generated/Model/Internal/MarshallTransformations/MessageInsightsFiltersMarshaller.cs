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
using ThirdParty.Json.LitJson;

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
            if(requestObject.IsSetDestination())
            {
                context.Writer.WritePropertyName("Destination");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectDestinationListValue in requestObject.Destination)
                {
                        context.Writer.Write(requestObjectDestinationListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetFromEmailAddress())
            {
                context.Writer.WritePropertyName("FromEmailAddress");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectFromEmailAddressListValue in requestObject.FromEmailAddress)
                {
                        context.Writer.Write(requestObjectFromEmailAddressListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetIsp())
            {
                context.Writer.WritePropertyName("Isp");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectIspListValue in requestObject.Isp)
                {
                        context.Writer.Write(requestObjectIspListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetLastDeliveryEvent())
            {
                context.Writer.WritePropertyName("LastDeliveryEvent");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectLastDeliveryEventListValue in requestObject.LastDeliveryEvent)
                {
                        context.Writer.Write(requestObjectLastDeliveryEventListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetLastEngagementEvent())
            {
                context.Writer.WritePropertyName("LastEngagementEvent");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectLastEngagementEventListValue in requestObject.LastEngagementEvent)
                {
                        context.Writer.Write(requestObjectLastEngagementEventListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetSubject())
            {
                context.Writer.WritePropertyName("Subject");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectSubjectListValue in requestObject.Subject)
                {
                        context.Writer.Write(requestObjectSubjectListValue);
                }
                context.Writer.WriteArrayEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static MessageInsightsFiltersMarshaller Instance = new MessageInsightsFiltersMarshaller();

    }
}