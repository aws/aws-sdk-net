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
    /// This is the response object from the CreateRuleGroup operation.
    /// </summary>
    public partial class CreateRuleGroupResponse : AmazonWebServiceResponse
    {
        private RuleGroupResponse _ruleGroupResponse;
        private string _updateToken;

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

        /// <summary>
        /// Gets and sets the property UpdateToken. 
        /// <para>
        /// A token used for optimistic locking. Network Firewall returns a token to your requests
        /// that access the rule group. The token marks the state of the rule group resource at
        /// the time of the request. 
        /// </para>
        ///  
        /// <para>
        /// To make changes to the rule group, you provide the token in your request. Network
        /// Firewall uses the token to ensure that the rule group hasn't changed since you last
        /// retrieved it. If it has changed, the operation fails with an <c>InvalidTokenException</c>.
        /// If this happens, retrieve the rule group again to get a current copy of it with a
        /// current token. Reapply your changes as needed, then try the operation again using
        /// the new token. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1024)]
        public string UpdateToken
        {
            get { return this._updateToken; }
            set { this._updateToken = value; }
        }

        // Check to see if UpdateToken property is set
        internal bool IsSetUpdateToken()
        {
            return this._updateToken != null;
        }

    }
}