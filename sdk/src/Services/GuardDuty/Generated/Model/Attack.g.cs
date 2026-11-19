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
    /// Contains a MITRE ATT&amp;CK tactic and technique observed during an attack, with the
    /// findings that are associated with them.
    /// </summary>
    public partial class Attack
    {
        /// <summary>
        /// Gets and sets the property Findings. 
        /// <para>
        /// The findings associated with the tactic and technique.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 100)]
        public List<FindingReference> Findings { get; set; } = AWSConfigs.InitializeCollections ? new List<FindingReference>() : null;

        /// <summary>
        /// Checks to see if the Findings property is set.
        /// </summary>
        internal bool IsSetFindings() => this.Findings != null && (this.Findings.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Tactic. 
        /// <para>
        /// The MITRE ATT&amp;CK tactic.
        /// </para>
        /// </summary>
        public ThreatReference Tactic { get; set; }

        /// <summary>
        /// Checks to see if the Tactic property is set.
        /// </summary>
        internal bool IsSetTactic() => this.Tactic != null;

        /// <summary>
        /// Gets and sets the property Technique. 
        /// <para>
        /// The MITRE ATT&amp;CK technique.
        /// </para>
        /// </summary>
        public ThreatReference Technique { get; set; }

        /// <summary>
        /// Checks to see if the Technique property is set.
        /// </summary>
        internal bool IsSetTechnique() => this.Technique != null;

        /// <summary>
        /// Gets and sets the property Version. 
        /// <para>
        /// The version of the attack framework that the tactic and technique classification uses.
        /// </para>
        /// </summary>
        public string Version { get; set; }

        /// <summary>
        /// Checks to see if the Version property is set.
        /// </summary>
        internal bool IsSetVersion() => this.Version != null;
    }
}
