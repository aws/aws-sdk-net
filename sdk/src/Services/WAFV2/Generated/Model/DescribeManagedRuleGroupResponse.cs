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
 * Do not modify this file. This file is generated from the wafv2-2019-07-29.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.WAFV2.Model
{
    /// <summary>
    /// This is the response object from the DescribeManagedRuleGroup operation.
    /// </summary>
    public partial class DescribeManagedRuleGroupResponse : AmazonWebServiceResponse
    {
        private long? _capacity;
        private List<RuleSummary> _rules = new List<RuleSummary>();

        /// <summary>
        /// Gets and sets the property Capacity. 
        /// <para>
        /// The web ACL capacity units (WCUs) required for this rule group. AWS WAF uses web ACL
        /// capacity units (WCU) to calculate and control the operating resources that are used
        /// to run your rules, rule groups, and web ACLs. AWS WAF calculates capacity differently
        /// for each rule type, to reflect each rule's relative cost. Rule group capacity is fixed
        /// at creation, so users can plan their web ACL WCU usage when they use a rule group.
        /// The WCU limit for web ACLs is 1,500. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public long Capacity
        {
            get { return this._capacity.GetValueOrDefault(); }
            set { this._capacity = value; }
        }

        // Check to see if Capacity property is set
        internal bool IsSetCapacity()
        {
            return this._capacity.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Rules.
        /// </summary>
        public List<RuleSummary> Rules
        {
            get { return this._rules; }
            set { this._rules = value; }
        }

        // Check to see if Rules property is set
        internal bool IsSetRules()
        {
            return this._rules != null && this._rules.Count > 0; 
        }

    }
}