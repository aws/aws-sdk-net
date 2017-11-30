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
 * Do not modify this file. This file is generated from the waf-2015-08-24.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.WAF.Model
{
    /// <summary>
    /// This is the response object from the ListRuleGroups operation.
    /// </summary>
    public partial class ListRuleGroupsResponse : AmazonWebServiceResponse
    {
        private string _nextMarker;
        private List<RuleGroupSummary> _ruleGroups = new List<RuleGroupSummary>();

        /// <summary>
        /// Gets and sets the property NextMarker. 
        /// <para>
        /// If you have more <code>RuleGroups</code> than the number that you specified for <code>Limit</code>
        /// in the request, the response includes a <code>NextMarker</code> value. To list more
        /// <code>RuleGroups</code>, submit another <code>ListRuleGroups</code> request, and specify
        /// the <code>NextMarker</code> value from the response in the <code>NextMarker</code>
        /// value in the next request.
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
        /// Gets and sets the property RuleGroups. 
        /// <para>
        /// An array of <a>RuleGroup</a> objects.
        /// </para>
        /// </summary>
        public List<RuleGroupSummary> RuleGroups
        {
            get { return this._ruleGroups; }
            set { this._ruleGroups = value; }
        }

        // Check to see if RuleGroups property is set
        internal bool IsSetRuleGroups()
        {
            return this._ruleGroups != null && this._ruleGroups.Count > 0; 
        }

    }
}