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
 * Do not modify this file. This file is generated from the frauddetector-2019-11-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.FraudDetector.Model
{
    /// <summary>
    /// The rule results.
    /// </summary>
    public partial class RuleResult
    {
        private List<string> _outcomes = new List<string>();
        private string _ruleId;

        /// <summary>
        /// Gets and sets the property Outcomes. 
        /// <para>
        /// The outcomes of the matched rule, based on the rule execution mode.
        /// </para>
        /// </summary>
        public List<string> Outcomes
        {
            get { return this._outcomes; }
            set { this._outcomes = value; }
        }

        // Check to see if Outcomes property is set
        internal bool IsSetOutcomes()
        {
            return this._outcomes != null && this._outcomes.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property RuleId. 
        /// <para>
        /// The rule ID that was matched, based on the rule execution mode.
        /// </para>
        /// </summary>
        public string RuleId
        {
            get { return this._ruleId; }
            set { this._ruleId = value; }
        }

        // Check to see if RuleId property is set
        internal bool IsSetRuleId()
        {
            return this._ruleId != null;
        }

    }
}