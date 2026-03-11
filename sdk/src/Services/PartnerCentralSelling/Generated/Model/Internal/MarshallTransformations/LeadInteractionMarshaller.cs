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
 * Do not modify this file. This file is generated from the partnercentral-selling-2022-07-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.PartnerCentralSelling.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.PartnerCentralSelling.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// LeadInteraction Marshaller
    /// </summary>
    public class LeadInteractionMarshaller : IRequestMarshaller<LeadInteraction, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(LeadInteraction requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetBusinessProblem())
            {
                context.Writer.WritePropertyName("BusinessProblem");
                context.Writer.WriteStringValue(requestObject.BusinessProblem);
            }

            if(requestObject.IsSetContact())
            {
                context.Writer.WritePropertyName("Contact");
                context.Writer.WriteStartObject();

                var marshaller = LeadContactMarshaller.Instance;
                marshaller.Marshall(requestObject.Contact, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetCustomerAction())
            {
                context.Writer.WritePropertyName("CustomerAction");
                context.Writer.WriteStringValue(requestObject.CustomerAction);
            }

            if(requestObject.IsSetInteractionDate())
            {
                context.Writer.WritePropertyName("InteractionDate");
                context.Writer.WriteStringValue(StringUtils.FromDateTimeToISO8601WithOptionalMs(requestObject.InteractionDate));
            }

            if(requestObject.IsSetSourceId())
            {
                context.Writer.WritePropertyName("SourceId");
                context.Writer.WriteStringValue(requestObject.SourceId);
            }

            if(requestObject.IsSetSourceName())
            {
                context.Writer.WritePropertyName("SourceName");
                context.Writer.WriteStringValue(requestObject.SourceName);
            }

            if(requestObject.IsSetSourceType())
            {
                context.Writer.WritePropertyName("SourceType");
                context.Writer.WriteStringValue(requestObject.SourceType);
            }

            if(requestObject.IsSetUsecase())
            {
                context.Writer.WritePropertyName("Usecase");
                context.Writer.WriteStringValue(requestObject.Usecase);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static LeadInteractionMarshaller Instance = new LeadInteractionMarshaller();

    }
}