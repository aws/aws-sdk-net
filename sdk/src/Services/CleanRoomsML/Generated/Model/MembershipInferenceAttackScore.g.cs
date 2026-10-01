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

namespace Amazon.CleanRoomsML.Model
{
    /// <summary>
    /// A score that measures the vulnerability of synthetic data to membership inference
    /// attacks and provides both the numerical score and the version of the attack methodology
    /// used for evaluation.
    /// </summary>
    public partial class MembershipInferenceAttackScore
    {
        /// <summary>
        /// Gets and sets the property AttackVersion. 
        /// <para>
        /// The version of the membership inference attack, which consists of the attack type
        /// and its version number, used to generate this privacy score.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public MembershipInferenceAttackVersion AttackVersion { get; set; }

        /// <summary>
        /// Checks to see if the AttackVersion property is set.
        /// </summary>
        internal bool IsSetAttackVersion() => this.AttackVersion != null;

        /// <summary>
        /// Gets and sets the property Score. 
        /// <para>
        /// The numerical score representing the vulnerability to membership inference attacks.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 1)]
        public double? Score { get; set; }

        /// <summary>
        /// Checks to see if the Score property is set.
        /// </summary>
        internal bool IsSetScore() => this.Score.HasValue;
    }
}
