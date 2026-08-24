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
    /// Container for the parameters to the GetEnterpriseSupportChargeSummary operation.
    /// Returns a summary of Enterprise Support data aggregated across all accounts in the
    /// Enterprise Support profile.
    /// </summary>
    public partial class GetEnterpriseSupportChargeSummaryRequest : AmazonBillingRequest
    {
        private string _billingMonth;

        /// <summary>
        /// Gets and sets the property BillingMonth. 
        /// <para>
        /// The billing month in YYYY-MM format. This must be a month in the past.
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

    }
}