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

namespace Amazon.ConfigService.Model
{
    /// <summary>
    /// Compliance information of one or more Config rules within a conformance pack. You
    /// can filter using Config rule names and compliance types.
    /// </summary>
    public partial class ConformancePackRuleCompliance
    {
        /// <summary>
        /// Gets and sets the property ComplianceType. 
        /// <para>
        /// Compliance of the Config rule.
        /// </para>
        /// </summary>
        public ConformancePackComplianceType ComplianceType { get; set; }

        /// <summary>
        /// Checks to see if the ComplianceType property is set.
        /// </summary>
        internal bool IsSetComplianceType() => this.ComplianceType != null;

        /// <summary>
        /// Gets and sets the property ConfigRuleName. 
        /// <para>
        /// Name of the Config rule.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string ConfigRuleName { get; set; }

        /// <summary>
        /// Checks to see if the ConfigRuleName property is set.
        /// </summary>
        internal bool IsSetConfigRuleName() => this.ConfigRuleName != null;

        /// <summary>
        /// Gets and sets the property Controls. 
        /// <para>
        /// Controls for the conformance pack. A control is a process to prevent or detect problems
        /// while meeting objectives. A control can align with a specific compliance regime or
        /// map to internal controls defined by an organization.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 20)]
        public List<string> Controls { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Controls property is set.
        /// </summary>
        internal bool IsSetControls() => this.Controls != null && (this.Controls.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
