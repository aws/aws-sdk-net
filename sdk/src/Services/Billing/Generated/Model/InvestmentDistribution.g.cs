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
    /// An allocation of an investment disbursement to a specific recipient account. The account
    /// is the target account that receives the investment, not your account.
    /// </summary>
    public partial class InvestmentDistribution
    {
        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// The recipient Amazon Web Services account ID that receives this portion of the investment.
        /// This must be one of the eligible investment accounts on the contract.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string AccountId { get; set; }

        /// <summary>
        /// Checks to see if the AccountId property is set.
        /// </summary>
        internal bool IsSetAccountId() => this.AccountId != null;

        /// <summary>
        /// Gets and sets the property InvestmentAmount. 
        /// <para>
        /// The monetary value allocated to the recipient account.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public Amount InvestmentAmount { get; set; }

        /// <summary>
        /// Checks to see if the InvestmentAmount property is set.
        /// </summary>
        internal bool IsSetInvestmentAmount() => this.InvestmentAmount != null;
    }
}
