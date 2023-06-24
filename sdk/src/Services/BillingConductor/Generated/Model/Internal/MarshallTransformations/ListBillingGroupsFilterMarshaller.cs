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
 * Do not modify this file. This file is generated from the billingconductor-2021-07-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.BillingConductor.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.BillingConductor.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ListBillingGroupsFilter Marshaller
    /// </summary>
    public class ListBillingGroupsFilterMarshaller : IRequestMarshaller<ListBillingGroupsFilter, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(ListBillingGroupsFilter requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetArns())
            {
                context.Writer.WritePropertyName("Arns");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectArnsListValue in requestObject.Arns)
                {
                        context.Writer.Write(requestObjectArnsListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetPricingPlan())
            {
                context.Writer.WritePropertyName("PricingPlan");
                context.Writer.Write(requestObject.PricingPlan);
            }

            if(requestObject.IsSetStatuses())
            {
                context.Writer.WritePropertyName("Statuses");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectStatusesListValue in requestObject.Statuses)
                {
                        context.Writer.Write(requestObjectStatusesListValue);
                }
                context.Writer.WriteArrayEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static ListBillingGroupsFilterMarshaller Instance = new ListBillingGroupsFilterMarshaller();

    }
}