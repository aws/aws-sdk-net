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
 * Do not modify this file. This file is generated from the savingsplans-2019-06-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SavingsPlans.Model
{
    /// <summary>
    /// Container for the parameters to the CreateSavingsPlan operation.
    /// Creates a Savings Plan.
    /// </summary>
    public partial class CreateSavingsPlanRequest : AmazonSavingsPlansRequest
    {
        private string _clientToken;
        private string _commitment;
        private DateTime? _purchaseTime;
        private string _savingsPlanOfferingId;
        private Dictionary<string, string> _tags = new Dictionary<string, string>();
        private string _upfrontPaymentAmount;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// Unique, case-sensitive identifier that you provide to ensure the idempotency of the
        /// request.
        /// </para>
        /// </summary>
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property Commitment. 
        /// <para>
        /// The hourly commitment, in USD. This is a value between 0.001 and 1 million. You cannot
        /// specify more than three digits after the decimal point.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Commitment
        {
            get { return this._commitment; }
            set { this._commitment = value; }
        }

        // Check to see if Commitment property is set
        internal bool IsSetCommitment()
        {
            return this._commitment != null;
        }

        /// <summary>
        /// Gets and sets the property PurchaseTime. 
        /// <para>
        /// The time at which to purchase the Savings Plan, in UTC format (YYYY-MM-DDTHH:MM:SSZ).
        /// </para>
        /// </summary>
        public DateTime PurchaseTime
        {
            get { return this._purchaseTime.GetValueOrDefault(); }
            set { this._purchaseTime = value; }
        }

        // Check to see if PurchaseTime property is set
        internal bool IsSetPurchaseTime()
        {
            return this._purchaseTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SavingsPlanOfferingId. 
        /// <para>
        /// The ID of the offering.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string SavingsPlanOfferingId
        {
            get { return this._savingsPlanOfferingId; }
            set { this._savingsPlanOfferingId = value; }
        }

        // Check to see if SavingsPlanOfferingId property is set
        internal bool IsSetSavingsPlanOfferingId()
        {
            return this._savingsPlanOfferingId != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// One or more tags.
        /// </para>
        /// </summary>
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property UpfrontPaymentAmount. 
        /// <para>
        /// The up-front payment amount. This is a whole number between 50 and 99 percent of the
        /// total value of the Savings Plan. This parameter is supported only if the payment option
        /// is <code>Partial Upfront</code>.
        /// </para>
        /// </summary>
        public string UpfrontPaymentAmount
        {
            get { return this._upfrontPaymentAmount; }
            set { this._upfrontPaymentAmount = value; }
        }

        // Check to see if UpfrontPaymentAmount property is set
        internal bool IsSetUpfrontPaymentAmount()
        {
            return this._upfrontPaymentAmount != null;
        }

    }
}