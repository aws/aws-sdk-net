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
 * Do not modify this file. This file is generated from the partnercentral-revenue-measurement-2022-07-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.PartnerCentralRevenueMeasurement.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using Amazon.Extensions.CborProtocol;
using Amazon.Extensions.CborProtocol.Internal.Transform;

#pragma warning disable CS0612,CS0618
namespace Amazon.PartnerCentralRevenueMeasurement.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// RevenueShareAllocation Marshaller
    /// </summary>
    public class RevenueShareAllocationMarshaller : IRequestMarshaller<RevenueShareAllocation, CborMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(RevenueShareAllocation requestObject, CborMarshallerContext context)
        {
            if (requestObject == null)
                return;

            if (requestObject.IsSetAction())
            {
                context.Writer.WriteTextString("Action");
                context.Writer.WriteTextString(requestObject.Action);
            }
            if (requestObject.IsSetCustomerAwsAccountId())
            {
                context.Writer.WriteTextString("CustomerAwsAccountId");
                context.Writer.WriteTextString(requestObject.CustomerAwsAccountId);
            }
            if (requestObject.IsSetEffectiveFrom())
            {
                context.Writer.WriteTextString("EffectiveFrom");
                context.Writer.WriteTextString(requestObject.EffectiveFrom);
            }
            if (requestObject.IsSetEffectiveUntil())
            {
                context.Writer.WriteTextString("EffectiveUntil");
                context.Writer.WriteTextString(requestObject.EffectiveUntil);
            }
            if (requestObject.IsSetEntityIdentifier())
            {
                context.Writer.WriteTextString("EntityIdentifier");
                context.Writer.WriteTextString(requestObject.EntityIdentifier);
            }
            if (requestObject.IsSetEntityType())
            {
                context.Writer.WriteTextString("EntityType");
                context.Writer.WriteTextString(requestObject.EntityType);
            }
            if (requestObject.IsSetRevenueAttributionAllocationId())
            {
                context.Writer.WriteTextString("RevenueAttributionAllocationId");
                context.Writer.WriteTextString(requestObject.RevenueAttributionAllocationId);
            }
            if (requestObject.IsSetRevenueSharePercent())
            {
                context.Writer.WriteTextString("RevenueSharePercent");
                context.Writer.WriteTextString(requestObject.RevenueSharePercent);
            }
            if (requestObject.IsSetStatus())
            {
                context.Writer.WriteTextString("Status");
                context.Writer.WriteTextString(requestObject.Status);
            }
        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static RevenueShareAllocationMarshaller Instance = new RevenueShareAllocationMarshaller();

    }
}