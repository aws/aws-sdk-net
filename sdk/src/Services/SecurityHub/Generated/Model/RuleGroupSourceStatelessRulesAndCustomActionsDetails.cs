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
    /// Stateless rules and custom actions for a stateless rule group.
    /// </summary>
    public partial class RuleGroupSourceStatelessRulesAndCustomActionsDetails
    {
        private List<RuleGroupSourceCustomActionsDetails> _customActions = new List<RuleGroupSourceCustomActionsDetails>();
        private List<RuleGroupSourceStatelessRulesDetails> _statelessRules = new List<RuleGroupSourceStatelessRulesDetails>();

        /// <summary>
        /// Gets and sets the property CustomActions. 
        /// <para>
        /// Custom actions for the rule group.
        /// </para>
        /// </summary>
        public List<RuleGroupSourceCustomActionsDetails> CustomActions
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
        /// Stateless rules for the rule group.
        /// </para>
        /// </summary>
        public List<RuleGroupSourceStatelessRulesDetails> StatelessRules
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