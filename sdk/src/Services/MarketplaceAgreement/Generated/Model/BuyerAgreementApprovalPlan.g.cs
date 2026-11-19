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

namespace Amazon.MarketplaceAgreement.Model
{
    /// <summary>
    /// An approval plan that the buyer's organization requires, with its approval levels
    /// and the approvers at each level.
    /// </summary>
    public partial class BuyerAgreementApprovalPlan
    {
        /// <summary>
        /// Gets and sets the property Levels. 
        /// <para>
        /// The approval levels of the plan, in the order they are evaluated. Approvers at a level
        /// can act only after the previous level is approved.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 6)]
        public List<BuyerAgreementApprovalPlanLevel> Levels { get; set; } = AWSConfigs.InitializeCollections ? new List<BuyerAgreementApprovalPlanLevel>() : null;

        /// <summary>
        /// Checks to see if the Levels property is set.
        /// </summary>
        internal bool IsSetLevels() => this.Levels != null && (this.Levels.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the approval plan.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property PlanReference. 
        /// <para>
        /// The identifier of the approval plan. Pass it in <c>StartAgreementApprovals</c> to
        /// start an agreement approval for this plan.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string PlanReference { get; set; }

        /// <summary>
        /// Checks to see if the PlanReference property is set.
        /// </summary>
        internal bool IsSetPlanReference() => this.PlanReference != null;
    }
}
