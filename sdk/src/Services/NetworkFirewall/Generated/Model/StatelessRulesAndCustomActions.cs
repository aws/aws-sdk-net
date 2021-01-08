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
 * Do not modify this file. This file is generated from the network-firewall-2020-11-12.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.NetworkFirewall.Model
{
    /// <summary>
    /// Stateless inspection criteria. Each stateless rule group uses exactly one of these
    /// data types to define its stateless rules.
    /// </summary>
    public partial class StatelessRulesAndCustomActions
    {
        private List<CustomAction> _customActions = new List<CustomAction>();
        private List<StatelessRule> _statelessRules = new List<StatelessRule>();

        /// <summary>
        /// Gets and sets the property CustomActions. 
        /// <para>
        /// Defines an array of individual custom action definitions that are available for use
        /// by the stateless rules in this <code>StatelessRulesAndCustomActions</code> specification.
        /// You name each custom action that you define, and then you can use it by name in your
        /// <a>StatelessRule</a> <a>RuleDefinition</a> <code>Actions</code> specification.
        /// </para>
        /// </summary>
        public List<CustomAction> CustomActions
        {
            get { return this._customActions; }
            set { this._customActions = value; }
        }

        // Check to see if CustomActions property is set
        internal bool IsSetCustomActions()
        {
            return this._customActions != null && this._customActions.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property StatelessRules. 
        /// <para>
        /// Defines the set of stateless rules for use in a stateless rule group. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<StatelessRule> StatelessRules
        {
            get { return this._statelessRules; }
            set { this._statelessRules = value; }
        }

        // Check to see if StatelessRules property is set
        internal bool IsSetStatelessRules()
        {
            return this._statelessRules != null && this._statelessRules.Count > 0; 
        }

    }
}