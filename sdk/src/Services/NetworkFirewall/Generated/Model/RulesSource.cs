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
    /// The stateless or stateful rules definitions for use in a single rule group. Each rule
    /// group requires a single <code>RulesSource</code>. You can use an instance of this
    /// for either stateless rules or stateful rules.
    /// </summary>
    public partial class RulesSource
    {
        private RulesSourceList _rulesSourceList;
        private string _rulesString;
        private List<StatefulRule> _statefulRules = new List<StatefulRule>();
        private StatelessRulesAndCustomActions _statelessRulesAndCustomActions;

        /// <summary>
        /// Gets and sets the property RulesSourceList. 
        /// <para>
        /// Stateful inspection criteria for a domain list rule group. 
        /// </para>
        /// </summary>
        public RulesSourceList RulesSourceList
        {
            get { return this._rulesSourceList; }
            set { this._rulesSourceList = value; }
        }

        // Check to see if RulesSourceList property is set
        internal bool IsSetRulesSourceList()
        {
            return this._rulesSourceList != null;
        }

        /// <summary>
        /// Gets and sets the property RulesString. 
        /// <para>
        /// Stateful inspection criteria, provided in Suricata compatible intrusion prevention
        /// system (IPS) rules. Suricata is an open-source network IPS that includes a standard
        /// rule-based language for network traffic inspection.
        /// </para>
        ///  
        /// <para>
        /// These rules contain the inspection criteria and the action to take for traffic that
        /// matches the criteria, so this type of rule group doesn't have a separate action setting.
        /// </para>
        ///  
        /// <para>
        /// You can provide the rules from a file that you've stored in an Amazon S3 bucket, or
        /// by providing the rules in a Suricata rules string. To import from Amazon S3, provide
        /// the fully qualified name of the file that contains the rules definitions. To provide
        /// a Suricata rule string, provide the complete, Suricata compatible rule.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1000000)]
        public string RulesString
        {
            get { return this._rulesString; }
            set { this._rulesString = value; }
        }

        // Check to see if RulesString property is set
        internal bool IsSetRulesString()
        {
            return this._rulesString != null;
        }

        /// <summary>
        /// Gets and sets the property StatefulRules. 
        /// <para>
        /// The 5-tuple stateful inspection criteria. This contains an array of individual 5-tuple
        /// stateful rules to be used together in a stateful rule group. 
        /// </para>
        /// </summary>
        public List<StatefulRule> StatefulRules
        {
            get { return this._statefulRules; }
            set { this._statefulRules = value; }
        }

        // Check to see if StatefulRules property is set
        internal bool IsSetStatefulRules()
        {
            return this._statefulRules != null && this._statefulRules.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property StatelessRulesAndCustomActions. 
        /// <para>
        /// Stateless inspection criteria to be used in a stateless rule group. 
        /// </para>
        /// </summary>
        public StatelessRulesAndCustomActions StatelessRulesAndCustomActions
        {
            get { return this._statelessRulesAndCustomActions; }
            set { this._statelessRulesAndCustomActions = value; }
        }

        // Check to see if StatelessRulesAndCustomActions property is set
        internal bool IsSetStatelessRulesAndCustomActions()
        {
            return this._statelessRulesAndCustomActions != null;
        }

    }
}