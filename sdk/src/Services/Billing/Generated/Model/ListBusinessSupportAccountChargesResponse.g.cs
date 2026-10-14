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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.Billing.Model
{
    /// <summary>
    /// This is the response object from the ListBusinessSupportAccountCharges operation.
    /// </summary>
    public partial class ListBusinessSupportAccountChargesResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property AccountCharges. 
        /// <para>
        /// The list of Business Support charges per linked account.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Max = 100)]
        public List<BusinessSupportAccountCharge> AccountCharges { get; set; } = AWSConfigs.InitializeCollections ? new List<BusinessSupportAccountCharge>() : null;

        /// <summary>
        /// Checks to see if the AccountCharges property is set.
        /// </summary>
        internal bool IsSetAccountCharges() => this.AccountCharges != null && (this.AccountCharges.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property AccountCount. 
        /// <para>
        /// The total number of linked accounts with Business Support charges in the billing month.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public int? AccountCount { get; set; }

        /// <summary>
        /// Checks to see if the AccountCount property is set.
        /// </summary>
        internal bool IsSetAccountCount() => this.AccountCount.HasValue;

        /// <summary>
        /// Gets and sets the property BillingMonth. 
        /// <para>
        /// The billing month for the returned charges, in YYYY-MM format.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string BillingMonth { get; set; }

        /// <summary>
        /// Checks to see if the BillingMonth property is set.
        /// </summary>
        internal bool IsSetBillingMonth() => this.BillingMonth != null;

        /// <summary>
        /// Gets and sets the property IsEstimated. 
        /// <para>
        /// Specifies whether the Support charge amount is estimated. When false, the charge amount
        /// is finalized.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public bool? IsEstimated { get; set; }

        /// <summary>
        /// Checks to see if the IsEstimated property is set.
        /// </summary>
        internal bool IsSetIsEstimated() => this.IsEstimated.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The pagination token for the next page of results.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 4095)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property TotalSupportCharge. 
        /// <para>
        /// The total Business Support charge amount for all accounts in the billing month.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string TotalSupportCharge { get; set; }

        /// <summary>
        /// Checks to see if the TotalSupportCharge property is set.
        /// </summary>
        internal bool IsSetTotalSupportCharge() => this.TotalSupportCharge != null;

        /// <summary>
        /// Gets and sets the property TotalSupportEligibleSpend. 
        /// <para>
        /// The total Support-eligible spend from all accounts in the billing month. This includes
        /// eligible spend from usage of Amazon Web Services.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string TotalSupportEligibleSpend { get; set; }

        /// <summary>
        /// Checks to see if the TotalSupportEligibleSpend property is set.
        /// </summary>
        internal bool IsSetTotalSupportEligibleSpend() => this.TotalSupportEligibleSpend != null;
    }
}
