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
using Amazon.Extensions.CborProtocol;
using Amazon.Extensions.CborProtocol.Internal.Transform;

#pragma warning disable CS0612,CS0618
namespace Amazon.MarketplaceAgreement.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// BatchCreateBillingAdjustmentRequestEntry Marshaller
    /// </summary>
    public class BatchCreateBillingAdjustmentRequestEntryMarshaller : IRequestMarshaller<BatchCreateBillingAdjustmentRequestEntry, CborMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(BatchCreateBillingAdjustmentRequestEntry requestObject, CborMarshallerContext context)
        {
            if (requestObject == null)
                return;

            if (requestObject.IsSetAdjustmentAmount())
            {
                context.Writer.WriteTextString("adjustmentAmount");
                context.Writer.WriteTextString(requestObject.AdjustmentAmount);
            }
            if (requestObject.IsSetAdjustmentReasonCode())
            {
                context.Writer.WriteTextString("adjustmentReasonCode");
                context.Writer.WriteTextString(requestObject.AdjustmentReasonCode);
            }
            if (requestObject.IsSetAgreementId())
            {
                context.Writer.WriteTextString("agreementId");
                context.Writer.WriteTextString(requestObject.AgreementId);
            }
            if (requestObject.IsSetClientToken())
            {
                context.Writer.WriteTextString("clientToken");
                context.Writer.WriteTextString(requestObject.ClientToken);
            }
            if (requestObject.IsSetCurrencyCode())
            {
                context.Writer.WriteTextString("currencyCode");
                context.Writer.WriteTextString(requestObject.CurrencyCode);
            }
            if (requestObject.IsSetDescription())
            {
                context.Writer.WriteTextString("description");
                context.Writer.WriteTextString(requestObject.Description);
            }
            if (requestObject.IsSetOriginalInvoiceId())
            {
                context.Writer.WriteTextString("originalInvoiceId");
                context.Writer.WriteTextString(requestObject.OriginalInvoiceId);
            }
        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static BatchCreateBillingAdjustmentRequestEntryMarshaller Instance = new BatchCreateBillingAdjustmentRequestEntryMarshaller();

    }
}