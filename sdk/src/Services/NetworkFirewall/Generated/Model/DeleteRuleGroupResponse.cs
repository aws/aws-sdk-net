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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.NetworkFirewall.Model
{
    /// <summary>
    /// This is the response object from the DeleteRuleGroup operation.
    /// </summary>
    public partial class DeleteRuleGroupResponse : AmazonWebServiceResponse
    {
        private RuleGroupResponse _ruleGroupResponse;

        /// <summary>
        /// Gets and sets the property RuleGroupResponse. 
        /// <para>
        /// The high-level properties of a rule group. This, along with the <a>RuleGroup</a>,
        /// define the rule group. You can retrieve all objects for a rule group by calling <a>DescribeRuleGroup</a>.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public RuleGroupResponse RuleGroupResponse
        {
            get { return this._ruleGroupResponse; }
            set { this._ruleGroupResponse = value; }
        }

        // Check to see if RuleGroupResponse property is set
        internal bool IsSetRuleGroupResponse()
        {
            return this._ruleGroupResponse != null;
        }

    }
}