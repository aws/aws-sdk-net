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
    /// Container for the parameters to the AssociateContract operation. Private Pricing contracts
    /// let eligible payer accounts manage private pricing agreements with Amazon Web Services.
    /// This operation associates a private pricing contract with the caller's Amazon Web
    /// Services account. The caller must be a payer (management) account listed on the contract.
    /// This operation is idempotent, so retrying a request that already succeeded is safe.
    /// </summary>
    public partial class AssociateContractRequest : AmazonBillingRequest
    {
        /// <summary>
        /// Gets and sets the property ContractArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the contract to associate with your account.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 500)]
        public string ContractArn { get; set; }

        /// <summary>
        /// Checks to see if the ContractArn property is set.
        /// </summary>
        internal bool IsSetContractArn() => this.ContractArn != null;

        /// <summary>
        /// Gets and sets the property ContractDocumentId. 
        /// <para>
        /// The contract ID from the contract document. It can be found in the top right corner
        /// of your contract's pages. This value confirms that you have access to the contract
        /// you are associating.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 1, Max = 36)]
        public string ContractDocumentId { get; set; }

        /// <summary>
        /// Checks to see if the ContractDocumentId property is set.
        /// </summary>
        internal bool IsSetContractDocumentId() => this.ContractDocumentId != null;
    }
}
