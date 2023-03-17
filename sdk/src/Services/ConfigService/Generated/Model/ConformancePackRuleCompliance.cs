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
 * Do not modify this file. This file is generated from the config-2014-11-12.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ConfigService.Model
{
    /// <summary>
    /// Compliance information of one or more Config rules within a conformance pack. You
    /// can filter using Config rule names and compliance types.
    /// </summary>
    public partial class ConformancePackRuleCompliance
    {
        private ConformancePackComplianceType _complianceType;
        private string _configRuleName;
        private List<string> _controls = new List<string>();

        /// <summary>
        /// Gets and sets the property ComplianceType. 
        /// <para>
        /// Compliance of the Config rule.
        /// </para>
        /// </summary>
        public ConformancePackComplianceType ComplianceType
        {
            get { return this._complianceType; }
            set { this._complianceType = value; }
        }

        // Check to see if ComplianceType property is set
        internal bool IsSetComplianceType()
        {
            return this._complianceType != null;
        }

        /// <summary>
        /// Gets and sets the property ConfigRuleName. 
        /// <para>
        /// Name of the Config rule.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string ConfigRuleName
        {
            get { return this._configRuleName; }
            set { this._configRuleName = value; }
        }

        // Check to see if ConfigRuleName property is set
        internal bool IsSetConfigRuleName()
        {
            return this._configRuleName != null;
        }

        /// <summary>
        /// Gets and sets the property Controls. 
        /// <para>
        /// Controls for the conformance pack. A control is a process to prevent or detect problems
        /// while meeting objectives. A control can align with a specific compliance regime or
        /// map to internal controls defined by an organization.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=20)]
        public List<string> Controls
        {
            get { return this._controls; }
            set { this._controls = value; }
        }

        // Check to see if Controls property is set
        internal bool IsSetControls()
        {
            return this._controls != null && this._controls.Count > 0; 
        }

    }
}