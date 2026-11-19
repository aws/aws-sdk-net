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
    /// Contains information about the findings associated with a MITRE ATT&amp;CK tactic.
    /// </summary>
    public partial class TacticCoverage
    {
        /// <summary>
        /// Gets and sets the property FindingCount. 
        /// <para>
        /// The number of findings associated with the tactic.
        /// </para>
        /// </summary>
        public int? FindingCount { get; set; }

        /// <summary>
        /// Checks to see if the FindingCount property is set.
        /// </summary>
        internal bool IsSetFindingCount() => this.FindingCount.HasValue;

        /// <summary>
        /// Gets and sets the property FindingTypes. 
        /// <para>
        /// The finding types associated with the tactic.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 50)]
        public List<string> FindingTypes { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the FindingTypes property is set.
        /// </summary>
        internal bool IsSetFindingTypes() => this.FindingTypes != null && (this.FindingTypes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Phase. 
        /// <para>
        /// The name of the tactic. Possible values are <c>Reconnaissance</c>, <c>Resource Development</c>,
        /// <c>Initial Access</c>, <c>Execution</c>, <c>Persistence</c>, <c>Privilege Escalation</c>,
        /// <c>Defense Evasion</c>, <c>Credential Access</c>, <c>Discovery</c>, <c>Lateral Movement</c>,
        /// <c>Collection</c>, <c>Command and Control</c>, <c>Exfiltration</c>, and <c>Impact</c>.
        /// </para>
        /// </summary>
        public AttackPhaseName Phase { get; set; }

        /// <summary>
        /// Checks to see if the Phase property is set.
        /// </summary>
        internal bool IsSetPhase() => this.Phase != null;

        /// <summary>
        /// Gets and sets the property Techniques. 
        /// <para>
        /// The MITRE ATT&amp;CK techniques within the tactic that are associated with findings.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 50)]
        public List<TechniqueCoverage> Techniques { get; set; } = AWSConfigs.InitializeCollections ? new List<TechniqueCoverage>() : null;

        /// <summary>
        /// Checks to see if the Techniques property is set.
        /// </summary>
        internal bool IsSetTechniques() => this.Techniques != null && (this.Techniques.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
