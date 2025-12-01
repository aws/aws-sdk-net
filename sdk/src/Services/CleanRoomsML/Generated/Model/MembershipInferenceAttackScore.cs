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
    /// A score that measures the vulnerability of synthetic data to membership inference
    /// attacks and provides both the numerical score and the version of the attack methodology
    /// used for evaluation.
    /// </summary>
    public partial class MembershipInferenceAttackScore
    {
        private MembershipInferenceAttackVersion _attackVersion;
        private double? _score;

        /// <summary>
        /// Gets and sets the property AttackVersion. 
        /// <para>
        /// The version of the membership inference attack, which consists of the attack type
        /// and its version number, used to generate this privacy score.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public MembershipInferenceAttackVersion AttackVersion
        {
            get { return this._attackVersion; }
            set { this._attackVersion = value; }
        }

        // Check to see if AttackVersion property is set
        internal bool IsSetAttackVersion()
        {
            return this._attackVersion != null;
        }

        /// <summary>
        /// Gets and sets the property Score. 
        /// <para>
        /// The numerical score representing the vulnerability to membership inference attacks.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=1)]
        public double Score
        {
            get { return this._score.GetValueOrDefault(); }
            set { this._score = value; }
        }

        // Check to see if Score property is set
        internal bool IsSetScore()
        {
            return this._score.HasValue; 
        }

    }
}