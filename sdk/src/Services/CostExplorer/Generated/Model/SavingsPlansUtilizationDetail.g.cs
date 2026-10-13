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

namespace Amazon.CostExplorer.Model
{
    /// <summary>
    /// A single daily or monthly Savings Plans utilization rate and details for your account.
    /// A management account in an organization have access to member accounts. You can use
    /// <c>GetDimensionValues</c> to determine the possible dimension values.
    /// </summary>
    public partial class SavingsPlansUtilizationDetail
    {
        /// <summary>
        /// Gets and sets the property AmortizedCommitment. 
        /// <para>
        /// The total amortized commitment for a Savings Plans. Includes the sum of the upfront
        /// and recurring Savings Plans fees.
        /// </para>
        /// </summary>
        public SavingsPlansAmortizedCommitment AmortizedCommitment { get; set; }

        /// <summary>
        /// Checks to see if the AmortizedCommitment property is set.
        /// </summary>
        internal bool IsSetAmortizedCommitment() => this.AmortizedCommitment != null;

        /// <summary>
        /// Gets and sets the property Attributes. 
        /// <para>
        /// The attribute that applies to a specific <c>Dimension</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Attributes { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Attributes property is set.
        /// </summary>
        internal bool IsSetAttributes() => this.Attributes != null && (this.Attributes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Savings. 
        /// <para>
        /// The amount saved by using existing Savings Plans. Savings returns both net savings
        /// from savings plans and also the <c>onDemandCostEquivalent</c> of the Savings Plans
        /// when considering the utilization rate.
        /// </para>
        /// </summary>
        public SavingsPlansSavings Savings { get; set; }

        /// <summary>
        /// Checks to see if the Savings property is set.
        /// </summary>
        internal bool IsSetSavings() => this.Savings != null;

        /// <summary>
        /// Gets and sets the property SavingsPlanArn. 
        /// <para>
        /// The unique Amazon Resource Name (ARN) for a particular Savings Plan.
        /// </para>
        /// </summary>
        public string SavingsPlanArn { get; set; }

        /// <summary>
        /// Checks to see if the SavingsPlanArn property is set.
        /// </summary>
        internal bool IsSetSavingsPlanArn() => this.SavingsPlanArn != null;

        /// <summary>
        /// Gets and sets the property Utilization. 
        /// <para>
        /// A ratio of your effectiveness of using existing Savings Plans to apply to workloads
        /// that are Savings Plans eligible.
        /// </para>
        /// </summary>
        public SavingsPlansUtilization Utilization { get; set; }

        /// <summary>
        /// Checks to see if the Utilization property is set.
        /// </summary>
        internal bool IsSetUtilization() => this.Utilization != null;
    }
}
