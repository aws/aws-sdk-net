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
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.MarketplaceAgreement.Model
{
    /// <summary>
    /// Container for the parameters to the BatchCreateBillingAdjustmentRequest operation.
    /// Allows sellers (proposers) to submit billing adjustment requests for one or more invoices
    /// within an agreement. Each entry in the batch specifies an invoice and the adjustment
    /// amount. The operation returns successfully created adjustment request IDs and any
    /// errors for entries that failed validation.
    /// 
    ///  <note> 
    /// <para>
    /// Each entry requires a unique <c>clientToken</c> for idempotency. A <c>ValidationException</c>
    /// is returned if the adjustment amount exceeds the maximum refundable amount for the
    /// invoice.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class BatchCreateBillingAdjustmentRequestRequest : AmazonMarketplaceAgreementRequest
    {
        private List<BatchCreateBillingAdjustmentRequestEntry> _billingAdjustmentRequestEntries = AWSConfigs.InitializeCollections ? new List<BatchCreateBillingAdjustmentRequestEntry>() : null;

        /// <summary>
        /// Gets and sets the property BillingAdjustmentRequestEntries. 
        /// <para>
        /// A list of billing adjustment request entries. Each entry specifies the invoice and
        /// adjustment details.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<BatchCreateBillingAdjustmentRequestEntry> BillingAdjustmentRequestEntries
        {
            get { return this._billingAdjustmentRequestEntries; }
            set { this._billingAdjustmentRequestEntries = value; }
        }

        // Check to see if BillingAdjustmentRequestEntries property is set
        internal bool IsSetBillingAdjustmentRequestEntries()
        {
            return this._billingAdjustmentRequestEntries != null && (this._billingAdjustmentRequestEntries.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}