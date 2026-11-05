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
    /// Contains information about the indicators that include a set of signals observed in
    /// an attack sequence.
    /// </summary>
    public partial class Indicator
    {
        /// <summary>
        /// Gets and sets the property Key. 
        /// <para>
        /// Specific indicator keys observed in the attack sequence. For description of the valid
        /// values for key, see <a href="https://docs.aws.amazon.com/guardduty/latest/ug/guardduty_findings-summary.html#guardduty-extended-threat-detection-attack-sequence-finding-details">Attack
        /// sequence finding details</a> in the <i>Amazon GuardDuty User Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public IndicatorType Key { get; set; }

        /// <summary>
        /// Checks to see if the Key property is set.
        /// </summary>
        internal bool IsSetKey() => this.Key != null;

        /// <summary>
        /// Gets and sets the property Title. 
        /// <para>
        /// Title describing the indicator.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string Title { get; set; }

        /// <summary>
        /// Checks to see if the Title property is set.
        /// </summary>
        internal bool IsSetTitle() => this.Title != null;

        /// <summary>
        /// Gets and sets the property Values. 
        /// <para>
        /// Values associated with each indicator key. For example, if the indicator key is <c>SUSPICIOUS_NETWORK</c>,
        /// then the value will be the name of the network. If the indicator key is <c>ATTACK_TACTIC</c>,
        /// then the value will be one of the MITRE tactics. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 400)]
        public List<string> Values { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Values property is set.
        /// </summary>
        internal bool IsSetValues() => this.Values != null && (this.Values.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
