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
    /// Container for the parameters to the UpdateBillScenario operation. Updates an existing
    /// bill scenario.
    /// </summary>
    public partial class UpdateBillScenarioRequest : AmazonBCMPricingCalculatorRequest
    {
        /// <summary>
        /// Gets and sets the property CostCategoryGroupSharingPreferenceArn. 
        /// <para>
        /// The arn of the cost category used in the reserved and prioritized group sharing.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string CostCategoryGroupSharingPreferenceArn { get; set; }

        /// <summary>
        /// Checks to see if the CostCategoryGroupSharingPreferenceArn property is set.
        /// </summary>
        internal bool IsSetCostCategoryGroupSharingPreferenceArn() => this.CostCategoryGroupSharingPreferenceArn != null;

        /// <summary>
        /// Gets and sets the property ExpiresAt. 
        /// <para>
        ///  The new expiration date for the bill scenario. 
        /// </para>
        /// </summary>
        public DateTime? ExpiresAt { get; set; }

        /// <summary>
        /// Checks to see if the ExpiresAt property is set.
        /// </summary>
        internal bool IsSetExpiresAt() => this.ExpiresAt.HasValue;

        /// <summary>
        /// Gets and sets the property GroupSharingPreference. 
        /// <para>
        /// The setting for the reserved instance and savings plan group sharing used in this
        /// estimate.
        /// </para>
        /// </summary>
        public GroupSharingPreferenceEnum GroupSharingPreference { get; set; }

        /// <summary>
        /// Checks to see if the GroupSharingPreference property is set.
        /// </summary>
        internal bool IsSetGroupSharingPreference() => this.GroupSharingPreference != null;

        /// <summary>
        /// Gets and sets the property Identifier. 
        /// <para>
        ///  The unique identifier of the bill scenario to update. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 36, Max = 36)]
        public string Identifier { get; set; }

        /// <summary>
        /// Checks to see if the Identifier property is set.
        /// </summary>
        internal bool IsSetIdentifier() => this.Identifier != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        ///  The new name for the bill scenario. 
        /// </para>
        /// </summary>
        [AWSProperty(Max = 64)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;
    }
}
