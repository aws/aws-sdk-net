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
    /// A Business Support subscription contract for an account.
    /// </summary>
    public partial class BusinessSupportSubscriptionContract
    {
        private string _accountId;
        private DateTime? _contractEndDate;
        private DateTime? _contractStartDate;
        private string _planName;

        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// The account ID associated with this subscription contract.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string AccountId
        {
            get { return this._accountId; }
            set { this._accountId = value; }
        }

        // Check to see if AccountId property is set
        internal bool IsSetAccountId()
        {
            return this._accountId != null;
        }

        /// <summary>
        /// Gets and sets the property ContractEndDate. 
        /// <para>
        /// The end date of the subscription contract.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? ContractEndDate
        {
            get { return this._contractEndDate; }
            set { this._contractEndDate = value; }
        }

        // Check to see if ContractEndDate property is set
        internal bool IsSetContractEndDate()
        {
            return this._contractEndDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ContractStartDate. 
        /// <para>
        /// The start date of the subscription contract.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? ContractStartDate
        {
            get { return this._contractStartDate; }
            set { this._contractStartDate = value; }
        }

        // Check to see if ContractStartDate property is set
        internal bool IsSetContractStartDate()
        {
            return this._contractStartDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PlanName. 
        /// <para>
        /// The name of the Support plan for this subscription contract. Valid values: <c>AWSSupportBusiness</c>
        /// (Business Support plan), <c>AWSSupportDeveloper</c> (Developer Support plan), <c>AWSSupportEssential</c>
        /// (Basic Support plan).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string PlanName
        {
            get { return this._planName; }
            set { this._planName = value; }
        }

        // Check to see if PlanName property is set
        internal bool IsSetPlanName()
        {
            return this._planName != null;
        }

    }
}