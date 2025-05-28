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
 * Do not modify this file. This file is generated from the cost-optimization-hub-2022-07-26.normal.json service model.
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
    /// This is the response object from the GetPreferences operation.
    /// </summary>
    public partial class GetPreferencesResponse : AmazonWebServiceResponse
    {
        private MemberAccountDiscountVisibility _memberAccountDiscountVisibility;
        private PreferredCommitment _preferredCommitment;
        private SavingsEstimationMode _savingsEstimationMode;

        /// <summary>
        /// Gets and sets the property MemberAccountDiscountVisibility. 
        /// <para>
        /// Retrieves the status of the "member account discount visibility" preference.
        /// </para>
        /// </summary>
        public MemberAccountDiscountVisibility MemberAccountDiscountVisibility
        {
            get { return this._memberAccountDiscountVisibility; }
            set { this._memberAccountDiscountVisibility = value; }
        }

        // Check to see if MemberAccountDiscountVisibility property is set
        internal bool IsSetMemberAccountDiscountVisibility()
        {
            return this._memberAccountDiscountVisibility != null;
        }

        /// <summary>
        /// Gets and sets the property PreferredCommitment. 
        /// <para>
        /// Retrieves the current preferences for how Reserved Instances and Savings Plans cost-saving
        /// opportunities are prioritized in terms of payment option and term length.
        /// </para>
        /// </summary>
        public PreferredCommitment PreferredCommitment
        {
            get { return this._preferredCommitment; }
            set { this._preferredCommitment = value; }
        }

        // Check to see if PreferredCommitment property is set
        internal bool IsSetPreferredCommitment()
        {
            return this._preferredCommitment != null;
        }

        /// <summary>
        /// Gets and sets the property SavingsEstimationMode. 
        /// <para>
        /// Retrieves the status of the "savings estimation mode" preference.
        /// </para>
        /// </summary>
        public SavingsEstimationMode SavingsEstimationMode
        {
            get { return this._savingsEstimationMode; }
            set { this._savingsEstimationMode = value; }
        }

        // Check to see if SavingsEstimationMode property is set
        internal bool IsSetSavingsEstimationMode()
        {
            return this._savingsEstimationMode != null;
        }

    }
}