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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Stateful inspection criteria for a domain list rule group.
    /// </summary>
    public partial class RuleGroupSourceListDetails
    {
        private string _generatedRulesType;
        private List<string> _targets = new List<string>();
        private List<string> _targetTypes = new List<string>();

        /// <summary>
        /// Gets and sets the property GeneratedRulesType. 
        /// <para>
        /// Indicates whether to allow or deny access to the domains listed in <code>Targets</code>.
        /// </para>
        /// </summary>
        public string GeneratedRulesType
        {
            get { return this._generatedRulesType; }
            set { this._generatedRulesType = value; }
        }

        // Check to see if GeneratedRulesType property is set
        internal bool IsSetGeneratedRulesType()
        {
            return this._generatedRulesType != null;
        }

        /// <summary>
        /// Gets and sets the property Targets. 
        /// <para>
        /// The domains that you want to inspect for in your traffic flows. You can provide full
        /// domain names, or use the '.' prefix as a wildcard. For example, <code>.example.com</code>
        /// matches all domains that end with <code>example.com</code>.
        /// </para>
        /// </summary>
        public List<string> Targets
        {
            get { return this._targets; }
            set { this._targets = value; }
        }

        // Check to see if Targets property is set
        internal bool IsSetTargets()
        {
            return this._targets != null && this._targets.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property TargetTypes. 
        /// <para>
        /// The protocols that you want to inspect. Specify <code>LS_SNI</code> for HTTPS. Specify
        /// <code>HTTP_HOST</code> for HTTP. You can specify either or both.
        /// </para>
        /// </summary>
        public List<string> TargetTypes
        {
            get { return this._targetTypes; }
            set { this._targetTypes = value; }
        }

        // Check to see if TargetTypes property is set
        internal bool IsSetTargetTypes()
        {
            return this._targetTypes != null && this._targetTypes.Count > 0; 
        }

    }
}