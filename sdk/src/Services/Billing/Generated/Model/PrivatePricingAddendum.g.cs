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
    /// The details of a private pricing addendum contract.
    /// </summary>
    public partial class PrivatePricingAddendum
    {
        /// <summary>
        /// Gets and sets the property ContractArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the private pricing addendum.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 500)]
        public string ContractArn { get; set; }

        /// <summary>
        /// Checks to see if the ContractArn property is set.
        /// </summary>
        internal bool IsSetContractArn() => this.ContractArn != null;

        /// <summary>
        /// Gets and sets the property ContractRestrictions. 
        /// <para>
        /// The restrictions that limit the self-service actions you can take on the private pricing
        /// addendum. An empty or absent value indicates that no restrictions apply. The list
        /// contains at most 10 restrictions.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 10)]
        public List<string> ContractRestrictions { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ContractRestrictions property is set.
        /// </summary>
        internal bool IsSetContractRestrictions() => this.ContractRestrictions != null && (this.ContractRestrictions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ContractTerm. 
        /// <para>
        /// The contract term period of the private pricing addendum, expressed as an interval
        /// with an inclusive start date and an inclusive end date.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public Interval ContractTerm { get; set; }

        /// <summary>
        /// Checks to see if the ContractTerm property is set.
        /// </summary>
        internal bool IsSetContractTerm() => this.ContractTerm != null;

        /// <summary>
        /// Gets and sets the property EligiblePayerAccounts. 
        /// <para>
        /// The payer accounts that are eligible under the private pricing addendum. The list
        /// contains at most 100 account IDs.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Max = 100)]
        public List<string> EligiblePayerAccounts { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the EligiblePayerAccounts property is set.
        /// </summary>
        internal bool IsSetEligiblePayerAccounts() => this.EligiblePayerAccounts != null && (this.EligiblePayerAccounts.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property InvestmentAccounts. 
        /// <para>
        /// The accounts that are eligible to receive investments under the private pricing addendum.
        /// An <c>InvestmentDistribution</c> must target one of these accounts. The list contains
        /// at most 100 account IDs.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Max = 100)]
        public List<string> InvestmentAccounts { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the InvestmentAccounts property is set.
        /// </summary>
        internal bool IsSetInvestmentAccounts() => this.InvestmentAccounts != null && (this.InvestmentAccounts.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property LegalEntities. 
        /// <para>
        /// The legal entities on the private pricing addendum. The list contains at most 10 legal
        /// entities.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Max = 10)]
        public List<LegalEntity> LegalEntities { get; set; } = AWSConfigs.InitializeCollections ? new List<LegalEntity>() : null;

        /// <summary>
        /// Checks to see if the LegalEntities property is set.
        /// </summary>
        internal bool IsSetLegalEntities() => this.LegalEntities != null && (this.LegalEntities.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
