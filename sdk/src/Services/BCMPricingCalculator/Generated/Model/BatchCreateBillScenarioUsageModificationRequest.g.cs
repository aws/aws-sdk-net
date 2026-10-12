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

namespace Amazon.BCMPricingCalculator.Model
{
    /// <summary>
    /// Container for the parameters to the BatchCreateBillScenarioUsageModification operation.
    /// Create Amazon Web Services service usage that you want to model in a Bill Scenario.
    /// <note> <para> The <c>BatchCreateBillScenarioUsageModification</c> operation doesn't
    /// have its own IAM permission. To authorize this operation for Amazon Web Services principals,
    /// include the permission <c>bcm-pricing-calculator:CreateBillScenarioUsageModification</c>
    /// in your policies. </para> </note>
    /// </summary>
    public partial class BatchCreateBillScenarioUsageModificationRequest : AmazonBCMPricingCalculatorRequest
    {
        /// <summary>
        /// Gets and sets the property BillScenarioId. 
        /// <para>
        ///  The ID of the Bill Scenario for which you want to create the modeled usage. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 36, Max = 36)]
        public string BillScenarioId { get; set; }

        /// <summary>
        /// Checks to see if the BillScenarioId property is set.
        /// </summary>
        internal bool IsSetBillScenarioId() => this.BillScenarioId != null;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        ///  A unique, case-sensitive identifier that you provide to ensure the idempotency of
        /// the request. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property UsageModifications. 
        /// <para>
        ///  List of usage that you want to model in the Bill Scenario. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 25)]
        public List<BatchCreateBillScenarioUsageModificationEntry> UsageModifications { get; set; } = AWSConfigs.InitializeCollections ? new List<BatchCreateBillScenarioUsageModificationEntry>() : null;

        /// <summary>
        /// Checks to see if the UsageModifications property is set.
        /// </summary>
        internal bool IsSetUsageModifications() => this.UsageModifications != null && (this.UsageModifications.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
