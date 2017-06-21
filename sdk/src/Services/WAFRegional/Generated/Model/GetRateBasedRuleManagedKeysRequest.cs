/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the waf-regional-2016-11-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.WAFRegional.Model
{
    /// <summary>
    /// Container for the parameters to the GetRateBasedRuleManagedKeys operation.
    /// Returns an array of IP addresses currently being blocked by the <a>RateBasedRule</a>
    /// that is specified by the <code>RuleId</code>. The maximum number of managed keys that
    /// will be blocked is 10,000. If more than 10,000 addresses exceed the rate limit, the
    /// 10,000 addresses with the highest rates will be blocked.
    /// </summary>
    public partial class GetRateBasedRuleManagedKeysRequest : AmazonWAFRegionalRequest
    {
        private string _nextMarker;
        private string _ruleId;

        /// <summary>
        /// Gets and sets the property NextMarker. 
        /// <para>
        /// A null value and not currently used. Do not include this in your request.
        /// </para>
        /// </summary>
        public string NextMarker
        {
            get { return this._nextMarker; }
            set { this._nextMarker = value; }
        }

        // Check to see if NextMarker property is set
        internal bool IsSetNextMarker()
        {
            return this._nextMarker != null;
        }

        /// <summary>
        /// Gets and sets the property RuleId. 
        /// <para>
        /// The <code>RuleId</code> of the <a>RateBasedRule</a> for which you want to get a list
        /// of <code>ManagedKeys</code>. <code>RuleId</code> is returned by <a>CreateRateBasedRule</a>
        /// and by <a>ListRateBasedRules</a>.
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