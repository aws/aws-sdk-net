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

namespace Amazon.CostOptimizationHub.Model
{
    /// <summary>
    /// Container for the parameters to the UpdatePreferences operation. Updates a set of
    /// preferences for an account in order to add account-specific preferences into the service.
    /// These preferences impact how the savings associated with recommendations are presented.
    /// </summary>
    public partial class UpdatePreferencesRequest : AmazonCostOptimizationHubRequest
    {
        /// <summary>
        /// Gets and sets the property MemberAccountDiscountVisibility. 
        /// <para>
        /// Sets the "member account discount visibility" preference.
        /// </para>
        /// </summary>
        public MemberAccountDiscountVisibility MemberAccountDiscountVisibility { get; set; }

        /// <summary>
        /// Checks to see if the MemberAccountDiscountVisibility property is set.
        /// </summary>
        internal bool IsSetMemberAccountDiscountVisibility() => this.MemberAccountDiscountVisibility != null;

        /// <summary>
        /// Gets and sets the property PreferredCommitment. 
        /// <para>
        /// Sets the preferences for how Reserved Instances and Savings Plans cost-saving opportunities
        /// are prioritized in terms of payment option and term length.
        /// </para>
        /// </summary>
        public PreferredCommitment PreferredCommitment { get; set; }

        /// <summary>
        /// Checks to see if the PreferredCommitment property is set.
        /// </summary>
        internal bool IsSetPreferredCommitment() => this.PreferredCommitment != null;

        /// <summary>
        /// Gets and sets the property SavingsEstimationMode. 
        /// <para>
        /// Sets the "savings estimation mode" preference.
        /// </para>
        /// </summary>
        public SavingsEstimationMode SavingsEstimationMode { get; set; }

        /// <summary>
        /// Checks to see if the SavingsEstimationMode property is set.
        /// </summary>
        internal bool IsSetSavingsEstimationMode() => this.SavingsEstimationMode != null;
    }
}
