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
    /// Container for the parameters to the UpdateRuleGroup operation.
    /// Inserts or deletes <a>ActivatedRule</a> objects in a <code>RuleGroup</code>.
    /// 
    ///  
    /// <para>
    /// You can only insert <code>REGULAR</code> rules into a rule group.
    /// </para>
    ///  
    /// <para>
    /// You can have a maximum of ten rules per rule group.
    /// </para>
    ///  
    /// <para>
    /// To create and configure a <code>RuleGroup</code>, perform the following steps:
    /// </para>
    ///  <ol> <li> 
    /// <para>
    /// Create and update the <code>Rules</code> that you want to include in the <code>RuleGroup</code>.
    /// See <a>CreateRule</a>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Use <code>GetChangeToken</code> to get the change token that you provide in the <code>ChangeToken</code>
    /// parameter of an <a>UpdateRuleGroup</a> request.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Submit an <code>UpdateRuleGroup</code> request to add <code>Rules</code> to the <code>RuleGroup</code>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Create and update a <code>WebACL</code> that contains the <code>RuleGroup</code>.
    /// See <a>CreateWebACL</a>.
    /// </para>
    ///  </li> </ol> 
    /// <para>
    /// If you want to replace one <code>Rule</code> with another, you delete the existing
    /// one and add the new one.
    /// </para>
    ///  
    /// <para>
    /// For more information about how to use the AWS WAF API to allow or block HTTP requests,
    /// see the <a href="http://docs.aws.amazon.com/waf/latest/developerguide/">AWS WAF Developer
    /// Guide</a>.
    /// </para>
    /// </summary>
    public partial class UpdateRuleGroupRequest : AmazonWAFRegionalRequest
    {
        private string _changeToken;
        private string _ruleGroupId;
        private List<RuleGroupUpdate> _updates = new List<RuleGroupUpdate>();

        /// <summary>
        /// Gets and sets the property ChangeToken. 
        /// <para>
        /// The value returned by the most recent call to <a>GetChangeToken</a>.
        /// </para>
        /// </summary>
        public string ChangeToken
        {
            get { return this._changeToken; }
            set { this._changeToken = value; }
        }

        // Check to see if ChangeToken property is set
        internal bool IsSetChangeToken()
        {
            return this._changeToken != null;
        }

        /// <summary>
        /// Gets and sets the property RuleGroupId. 
        /// <para>
        /// The <code>RuleGroupId</code> of the <a>RuleGroup</a> that you want to update. <code>RuleGroupId</code>
        /// is returned by <a>CreateRuleGroup</a> and by <a>ListRuleGroups</a>.
        /// </para>
        /// </summary>
        public string RuleGroupId
        {
            get { return this._ruleGroupId; }
            set { this._ruleGroupId = value; }
        }

        // Check to see if RuleGroupId property is set
        internal bool IsSetRuleGroupId()
        {
            return this._ruleGroupId != null;
        }

        /// <summary>
        /// Gets and sets the property Updates. 
        /// <para>
        /// An array of <code>RuleGroupUpdate</code> objects that you want to insert into or delete
        /// from a <a>RuleGroup</a>.
        /// </para>
        ///  
        /// <para>
        /// You can only insert <code>REGULAR</code> rules into a rule group.
        /// </para>
        ///  
        /// <para>
        ///  <code>ActivatedRule|OverrideAction</code> applies only when updating or adding a
        /// <code>RuleGroup</code> to a <code>WebACL</code>. In this case you do not use <code>ActivatedRule|Action</code>.
        /// For all other update requests, <code>ActivatedRule|Action</code> is used instead of
        /// <code>ActivatedRule|OverrideAction</code>.
        /// </para>
        /// </summary>
        public List<RuleGroupUpdate> Updates
        {
            get { return this._updates; }
            set { this._updates = value; }
        }

        // Check to see if Updates property is set
        internal bool IsSetUpdates()
        {
            return this._updates != null && this._updates.Count > 0; 
        }

    }
}