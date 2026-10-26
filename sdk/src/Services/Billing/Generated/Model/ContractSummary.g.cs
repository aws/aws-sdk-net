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
    /// A summary of a private pricing contract visible to your account. <c>ListContracts</c>
    /// returns these summaries.
    /// </summary>
    public partial class ContractSummary
    {
        /// <summary>
        /// Gets and sets the property AssociationStatus. 
        /// <para>
        /// Indicates whether the contract is currently associated with your account. Valid values
        /// are <c>ASSOCIATED</c> and <c>NOT_ASSOCIATED</c>. <c>ASSOCIATED</c> means the contract
        /// is associated with your account. <c>NOT_ASSOCIATED</c> means the contract is not associated
        /// with your account.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public AssociationStatus AssociationStatus { get; set; }

        /// <summary>
        /// Checks to see if the AssociationStatus property is set.
        /// </summary>
        internal bool IsSetAssociationStatus() => this.AssociationStatus != null;

        /// <summary>
        /// Gets and sets the property ContractArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the contract. Pass this value to operations such
        /// as <c>GetContractInformation</c>, <c>ListContractualInvestmentSummaries</c>, and <c>AssociateContract</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 500)]
        public string ContractArn { get; set; }

        /// <summary>
        /// Checks to see if the ContractArn property is set.
        /// </summary>
        internal bool IsSetContractArn() => this.ContractArn != null;

        /// <summary>
        /// Gets and sets the property ContractTerm. 
        /// <para>
        /// The contract term period of the contract, expressed as an interval with an inclusive
        /// start date and an inclusive end date.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public Interval ContractTerm { get; set; }

        /// <summary>
        /// Checks to see if the ContractTerm property is set.
        /// </summary>
        internal bool IsSetContractTerm() => this.ContractTerm != null;

        /// <summary>
        /// Gets and sets the property ContractType. 
        /// <para>
        /// The classification of the contract. Valid values are <c>Cross-Service</c>, <c>Service-Specific</c>,
        /// and <c>Other</c>. <c>Cross-Service</c> applies across multiple Amazon Web Services
        /// services. <c>Service-Specific</c> applies to a specific Amazon Web Services service.
        /// <c>Other</c> applies to other arrangements.
        /// </para>
        /// </summary>
        public ContractType ContractType { get; set; }

        /// <summary>
        /// Checks to see if the ContractType property is set.
        /// </summary>
        internal bool IsSetContractType() => this.ContractType != null;

        /// <summary>
        /// Gets and sets the property LastUpdatedAt. 
        /// <para>
        /// The time when the contract was last associated with your account.
        /// </para>
        /// </summary>
        public DateTime? LastUpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the LastUpdatedAt property is set.
        /// </summary>
        internal bool IsSetLastUpdatedAt() => this.LastUpdatedAt.HasValue;
    }
}
