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

namespace Amazon.GuardDuty.Model
{
    /// <summary>
    /// Contains an assessment of the threat that a <c>FINDING</c> investigation identified.
    /// </summary>
    public partial class ThreatAssessment
    {
        /// <summary>
        /// Gets and sets the property AttackProgression. 
        /// <para>
        /// The phases of the attack, in terms of MITRE ATT&amp;CK tactics.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 20)]
        public List<AttackPhase> AttackProgression { get; set; } = AWSConfigs.InitializeCollections ? new List<AttackPhase>() : null;

        /// <summary>
        /// Checks to see if the AttackProgression property is set.
        /// </summary>
        internal bool IsSetAttackProgression() => this.AttackProgression != null && (this.AttackProgression.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ThreatActorProfile. 
        /// <para>
        /// A description of the likely threat actor.
        /// </para>
        /// </summary>
        public string ThreatActorProfile { get; set; }

        /// <summary>
        /// Checks to see if the ThreatActorProfile property is set.
        /// </summary>
        internal bool IsSetThreatActorProfile() => this.ThreatActorProfile != null;
    }
}
