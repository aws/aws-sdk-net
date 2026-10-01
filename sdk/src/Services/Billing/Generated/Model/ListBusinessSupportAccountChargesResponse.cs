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
 * Do not modify this file. This file is generated from the billing-2023-09-07.normal.json service model.
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
    /// Contains the Business Support charges broken down by linked account for the specified
    /// billing month, along with account and spend totals.
    /// </summary>
    public partial class ListBusinessSupportAccountChargesResponse : AmazonWebServiceResponse
    {
        private List<BusinessSupportAccountCharge> _accountCharges = AWSConfigs.InitializeCollections ? new List<BusinessSupportAccountCharge>() : null;
        private int? _accountCount;
        private string _billingMonth;
        private bool? _isEstimated;
        private string _nextToken;
        private string _totalSupportCharge;
        private string _totalSupportEligibleSpend;

        /// <summary>
        /// Gets and sets the property AccountCharges. 
        /// <para>
        /// The list of Business Support charges per linked account.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=100)]
        public List<BusinessSupportAccountCharge> AccountCharges
        {
            get { return this._accountCharges; }
            set { this._accountCharges = value; }
        }

        // Check to see if AccountCharges property is set
        internal bool IsSetAccountCharges()
        {
            return this._accountCharges != null && (this._accountCharges.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property AccountCount. 
        /// <para>
        /// The total number of linked accounts with Business Support charges in the billing month.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int? AccountCount
        {
            get { return this._accountCount; }
            set { this._accountCount = value; }
        }

        // Check to see if AccountCount property is set
        internal bool IsSetAccountCount()
        {
            return this._accountCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property BillingMonth. 
        /// <para>
        /// The billing month for the returned charges, in YYYY-MM format.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string BillingMonth
        {
            get { return this._billingMonth; }
            set { this._billingMonth = value; }
        }

        // Check to see if BillingMonth property is set
        internal bool IsSetBillingMonth()
        {
            return this._billingMonth != null;
        }

        /// <summary>
        /// Gets and sets the property IsEstimated. 
        /// <para>
        /// Specifies whether the Support charge amount is estimated. When false, the charge amount
        /// is finalized.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool? IsEstimated
        {
            get { return this._isEstimated; }
            set { this._isEstimated = value; }
        }

        // Check to see if IsEstimated property is set
        internal bool IsSetIsEstimated()
        {
            return this._isEstimated.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The pagination token for the next page of results.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=4095)]
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

        /// <summary>
        /// Gets and sets the property TotalSupportCharge. 
        /// <para>
        /// The total Business Support charge amount for all accounts in the billing month.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string TotalSupportCharge
        {
            get { return this._totalSupportCharge; }
            set { this._totalSupportCharge = value; }
        }

        // Check to see if TotalSupportCharge property is set
        internal bool IsSetTotalSupportCharge()
        {
            return this._totalSupportCharge != null;
        }

        /// <summary>
        /// Gets and sets the property TotalSupportEligibleSpend. 
        /// <para>
        /// The total Support-eligible spend from all accounts in the billing month. This includes
        /// eligible spend from usage of Amazon Web Services.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string TotalSupportEligibleSpend
        {
            get { return this._totalSupportEligibleSpend; }
            set { this._totalSupportEligibleSpend = value; }
        }

        // Check to see if TotalSupportEligibleSpend property is set
        internal bool IsSetTotalSupportEligibleSpend()
        {
            return this._totalSupportEligibleSpend != null;
        }

    }
}