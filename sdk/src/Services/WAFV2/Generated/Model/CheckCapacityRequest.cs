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
 * Do not modify this file. This file is generated from the wafv2-2019-07-29.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.WAFV2.Model
{
    /// <summary>
    /// Container for the parameters to the CheckCapacity operation.
    /// Returns the web ACL capacity unit (WCU) requirements for a specified scope and set
    /// of rules. You can use this to check the capacity requirements for the rules you want
    /// to use in a <a>RuleGroup</a> or <a>WebACL</a>. 
    /// 
    ///  
    /// <para>
    /// WAF uses WCUs to calculate and control the operating resources that are used to run
    /// your rules, rule groups, and web ACLs. WAF calculates capacity differently for each
    /// rule type, to reflect the relative cost of each rule. Simple rules that cost little
    /// to run use fewer WCUs than more complex rules that use more processing power. Rule
    /// group capacity is fixed at creation, which helps users plan their web ACL WCU usage
    /// when they use a rule group. The WCU limit for web ACLs is 1,500. 
    /// </para>
    /// </summary>
    public partial class CheckCapacityRequest : AmazonWAFV2Request
    {
        private List<Rule> _rules = new List<Rule>();
        private Scope _scope;

        /// <summary>
        /// Gets and sets the property Rules. 
        /// <para>
        /// An array of <a>Rule</a> that you're configuring to use in a rule group or web ACL.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<Rule> Rules
        {
            get { return this._rules; }
            set { this._rules = value; }
        }

        // Check to see if Rules property is set
        internal bool IsSetRules()
        {
            return this._rules != null && this._rules.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Scope. 
        /// <para>
        /// Specifies whether this is for an Amazon CloudFront distribution or for a regional
        /// application. A regional application can be an Application Load Balancer (ALB), an
        /// Amazon API Gateway REST API, an AppSync GraphQL API, a Amazon Cognito user pool, or
        /// an App Runner service. 
        /// </para>
        ///  
        /// <para>
        /// To work with CloudFront, you must also specify the Region US East (N. Virginia) as
        /// follows: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// CLI - Specify the Region when you use the CloudFront scope: <code>--scope=CLOUDFRONT
        /// --region=us-east-1</code>. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// API and SDKs - For all calls, use the Region endpoint us-east-1. 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public Scope Scope
        {
            get { return this._scope; }
            set { this._scope = value; }
        }

        // Check to see if Scope property is set
        internal bool IsSetScope()
        {
            return this._scope != null;
        }

    }
}