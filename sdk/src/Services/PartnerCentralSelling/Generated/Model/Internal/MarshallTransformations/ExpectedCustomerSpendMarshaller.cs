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
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.PartnerCentralSelling.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ExpectedCustomerSpend Marshaller
    /// </summary>
    public class ExpectedCustomerSpendMarshaller : IRequestMarshaller<ExpectedCustomerSpend, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(ExpectedCustomerSpend requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAmount())
            {
                context.Writer.WritePropertyName("Amount");
                context.Writer.Write(requestObject.Amount);
            }

            if(requestObject.IsSetCurrencyCode())
            {
                context.Writer.WritePropertyName("CurrencyCode");
                context.Writer.Write(requestObject.CurrencyCode);
            }

            if(requestObject.IsSetEstimationUrl())
            {
                context.Writer.WritePropertyName("EstimationUrl");
                context.Writer.Write(requestObject.EstimationUrl);
            }

            if(requestObject.IsSetFrequency())
            {
                context.Writer.WritePropertyName("Frequency");
                context.Writer.Write(requestObject.Frequency);
            }

            if(requestObject.IsSetTargetCompany())
            {
                context.Writer.WritePropertyName("TargetCompany");
                context.Writer.Write(requestObject.TargetCompany);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static ExpectedCustomerSpendMarshaller Instance = new ExpectedCustomerSpendMarshaller();

    }
}