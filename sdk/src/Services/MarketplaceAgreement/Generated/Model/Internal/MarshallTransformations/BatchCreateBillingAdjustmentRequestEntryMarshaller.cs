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
 * Do not modify this file. This file is generated from the marketplace-agreement-2020-03-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.MarketplaceAgreement.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.MarketplaceAgreement.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// BatchCreateBillingAdjustmentRequestEntry Marshaller
    /// </summary>
    public class BatchCreateBillingAdjustmentRequestEntryMarshaller : IRequestMarshaller<BatchCreateBillingAdjustmentRequestEntry, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(BatchCreateBillingAdjustmentRequestEntry requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAdjustmentAmount())
            {
                context.Writer.WritePropertyName("adjustmentAmount");
                context.Writer.WriteStringValue(requestObject.AdjustmentAmount);
            }

            if(requestObject.IsSetAdjustmentReasonCode())
            {
                context.Writer.WritePropertyName("adjustmentReasonCode");
                context.Writer.WriteStringValue(requestObject.AdjustmentReasonCode);
            }

            if(requestObject.IsSetAgreementId())
            {
                context.Writer.WritePropertyName("agreementId");
                context.Writer.WriteStringValue(requestObject.AgreementId);
            }

            if(requestObject.IsSetClientToken())
            {
                context.Writer.WritePropertyName("clientToken");
                context.Writer.WriteStringValue(requestObject.ClientToken);
            }

            if(requestObject.IsSetCurrencyCode())
            {
                context.Writer.WritePropertyName("currencyCode");
                context.Writer.WriteStringValue(requestObject.CurrencyCode);
            }

            if(requestObject.IsSetDescription())
            {
                context.Writer.WritePropertyName("description");
                context.Writer.WriteStringValue(requestObject.Description);
            }

            if(requestObject.IsSetOriginalInvoiceId())
            {
                context.Writer.WritePropertyName("originalInvoiceId");
                context.Writer.WriteStringValue(requestObject.OriginalInvoiceId);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static BatchCreateBillingAdjustmentRequestEntryMarshaller Instance = new BatchCreateBillingAdjustmentRequestEntryMarshaller();

    }
}