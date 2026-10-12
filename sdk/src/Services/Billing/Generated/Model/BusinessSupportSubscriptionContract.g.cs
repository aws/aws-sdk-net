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
    /// A Business Support subscription contract for an account.
    /// </summary>
    public partial class BusinessSupportSubscriptionContract
    {
        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// The account ID associated with this subscription contract.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string AccountId { get; set; }

        /// <summary>
        /// Checks to see if the AccountId property is set.
        /// </summary>
        internal bool IsSetAccountId() => this.AccountId != null;

        /// <summary>
        /// Gets and sets the property ContractEndDate. 
        /// <para>
        /// The end date of the subscription contract.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? ContractEndDate { get; set; }

        /// <summary>
        /// Checks to see if the ContractEndDate property is set.
        /// </summary>
        internal bool IsSetContractEndDate() => this.ContractEndDate.HasValue;

        /// <summary>
        /// Gets and sets the property ContractStartDate. 
        /// <para>
        /// The start date of the subscription contract.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? ContractStartDate { get; set; }

        /// <summary>
        /// Checks to see if the ContractStartDate property is set.
        /// </summary>
        internal bool IsSetContractStartDate() => this.ContractStartDate.HasValue;

        /// <summary>
        /// Gets and sets the property PlanName. 
        /// <para>
        /// The name of the Support plan for this subscription contract. Valid values: <c>AWSSupportBusiness</c>
        /// (Business Support plan), <c>AWSSupportDeveloper</c> (Developer Support plan), <c>AWSSupportEssential</c>
        /// (Basic Support plan).
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string PlanName { get; set; }

        /// <summary>
        /// Checks to see if the PlanName property is set.
        /// </summary>
        internal bool IsSetPlanName() => this.PlanName != null;
    }
}
