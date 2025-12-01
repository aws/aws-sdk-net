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
 * Do not modify this file. This file is generated from the cleanroomsml-2023-09-06.normal.json service model.
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
namespace Amazon.CleanRoomsML.Model
{
    /// <summary>
    /// Privacy evaluation scores that measure the privacy characteristics of the generated
    /// synthetic data, including assessments of potential privacy risks such as membership
    /// inference attacks.
    /// </summary>
    public partial class DataPrivacyScores
    {
        private List<MembershipInferenceAttackScore> _membershipInferenceAttackScores = AWSConfigs.InitializeCollections ? new List<MembershipInferenceAttackScore>() : null;

        /// <summary>
        /// Gets and sets the property MembershipInferenceAttackScores. 
        /// <para>
        /// Scores that evaluate the vulnerability of the synthetic data to membership inference
        /// attacks, which attempt to determine whether a specific individual was a member of
        /// the original dataset.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1)]
        public List<MembershipInferenceAttackScore> MembershipInferenceAttackScores
        {
            get { return this._membershipInferenceAttackScores; }
            set { this._membershipInferenceAttackScores = value; }
        }

        // Check to see if MembershipInferenceAttackScores property is set
        internal bool IsSetMembershipInferenceAttackScores()
        {
            return this._membershipInferenceAttackScores != null && (this._membershipInferenceAttackScores.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}