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
 * Do not modify this file. This file is generated from the ce-2017-10-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.CostExplorer.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.CostExplorer.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// SavingsPlans Marshaller
    /// </summary>
    public class SavingsPlansMarshaller : IRequestMarshaller<SavingsPlans, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(SavingsPlans requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetInstanceFamily())
            {
                context.Writer.WritePropertyName("InstanceFamily");
                context.Writer.Write(requestObject.InstanceFamily);
            }

            if(requestObject.IsSetOfferingId())
            {
                context.Writer.WritePropertyName("OfferingId");
                context.Writer.Write(requestObject.OfferingId);
            }

            if(requestObject.IsSetPaymentOption())
            {
                context.Writer.WritePropertyName("PaymentOption");
                context.Writer.Write(requestObject.PaymentOption);
            }

            if(requestObject.IsSetRegion())
            {
                context.Writer.WritePropertyName("Region");
                context.Writer.Write(requestObject.Region);
            }

            if(requestObject.IsSetSavingsPlansCommitment())
            {
                context.Writer.WritePropertyName("SavingsPlansCommitment");
                if(StringUtils.IsSpecialDoubleValue(requestObject.SavingsPlansCommitment))
                {
                    context.Writer.Write(StringUtils.FromSpecialDoubleValue(requestObject.SavingsPlansCommitment));
                }
                else
                {
                    context.Writer.Write(requestObject.SavingsPlansCommitment);
                }
            }

            if(requestObject.IsSetSavingsPlansType())
            {
                context.Writer.WritePropertyName("SavingsPlansType");
                context.Writer.Write(requestObject.SavingsPlansType);
            }

            if(requestObject.IsSetTermInYears())
            {
                context.Writer.WritePropertyName("TermInYears");
                context.Writer.Write(requestObject.TermInYears);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static SavingsPlansMarshaller Instance = new SavingsPlansMarshaller();

    }
}