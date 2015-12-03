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
    /// Container for the parameters to the UpdateWebACL operation.
    /// Inserts or deletes <a>ActivatedRule</a> objects in a <code>WebACL</code>. Each <code>Rule</code>
    /// identifies web requests that you want to allow, block, or count. When you update a
    /// <code>WebACL</code>, you specify the following values:
    /// 
    ///  <ul> <li>A default action for the <code>WebACL</code>, either <code>ALLOW</code>
    /// or <code>BLOCK</code>. AWS WAF performs the default action if a request doesn't match
    /// the criteria in any of the <code>Rules</code> in a <code>WebACL</code>.</li> <li>The
    /// <code>Rules</code> that you want to add and/or delete. If you want to replace one
    /// <code>Rule</code> with another, you delete the existing <code>Rule</code> and add
    /// the new one.</li> <li>For each <code>Rule</code>, whether you want AWS WAF to allow
    /// requests, block requests, or count requests that match the conditions in the <code>Rule</code>.</li>
    /// <li>The order in which you want AWS WAF to evaluate the <code>Rules</code> in a <code>WebACL</code>.
    /// If you add more than one <code>Rule</code> to a <code>WebACL</code>, AWS WAF evaluates
    /// each request against the <code>Rules</code> in order based on the value of <code>Priority</code>.
    /// (The <code>Rule</code> that has the lowest value for <code>Priority</code> is evaluated
    /// first.) When a web request matches all of the predicates (such as <code>ByteMatchSets</code>
    /// and <code>IPSets</code>) in a <code>Rule</code>, AWS WAF immediately takes the corresponding
    /// action, allow or block, and doesn't evaluate the request against the remaining <code>Rules</code>
    /// in the <code>WebACL</code>, if any. </li> <li>The CloudFront distribution that you
    /// want to associate with the <code>WebACL</code>.</li> </ul> 
    /// <para>
    /// To create and configure a <code>WebACL</code>, perform the following steps:
    /// </para>
    ///  <ol> <li>Create and update the predicates that you want to include in <code>Rules</code>.
    /// For more information, see <a>CreateByteMatchSet</a>, <a>UpdateByteMatchSet</a>, <a>CreateIPSet</a>,
    /// <a>UpdateIPSet</a>, <a>CreateSqlInjectionMatchSet</a>, and <a>UpdateSqlInjectionMatchSet</a>.</li>
    /// <li>Create and update the <code>Rules</code> that you want to include in the <code>WebACL</code>.
    /// For more information, see <a>CreateRule</a> and <a>UpdateRule</a>.</li> <li>Create
    /// a <code>WebACL</code>. See <a>CreateWebACL</a>.</li> <li>Use <code>GetChangeToken</code>
    /// to get the change token that you provide in the <code>ChangeToken</code> parameter
    /// of an <a>UpdateWebACL</a> request.</li> <li>Submit an <code>UpdateWebACL</code> request
    /// to specify the <code>Rules</code> that you want to include in the <code>WebACL</code>,
    /// to specify the default action, and to associate the <code>WebACL</code> with a CloudFront
    /// distribution. </li> </ol> 
    /// <para>
    /// For more information about how to use the AWS WAF API to allow or block HTTP requests,
    /// see the <a href="http://docs.aws.amazon.com/waf/latest/developerguide/">AWS WAF Developer
    /// Guide</a>.
    /// </para>
    /// </summary>
    public partial class UpdateWebACLRequest : AmazonWAFRequest
    {
        private string _changeToken;
        private WafAction _defaultAction;
        private List<WebACLUpdate> _updates = new List<WebACLUpdate>();
        private string _webACLId;

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
        /// Gets and sets the property DefaultAction.
        /// </summary>
        public WafAction DefaultAction
        {
            get { return this._defaultAction; }
            set { this._defaultAction = value; }
        }

        // Check to see if DefaultAction property is set
        internal bool IsSetDefaultAction()
        {
            return this._defaultAction != null;
        }

        /// <summary>
        /// Gets and sets the property Updates. 
        /// <para>
        /// An array of updates to make to the <a>WebACL</a>.
        /// </para>
        ///  
        /// <para>
        /// An array of <code>WebACLUpdate</code> objects that you want to insert into or delete
        /// from a <a>WebACL</a>. For more information, see the applicable data types:
        /// </para>
        ///  <ul> <li> <a>WebACLUpdate</a>: Contains <code>Action</code> and <code>ActivatedRule</code>
        /// </li> <li> <a>ActivatedRule</a>: Contains <code>Action</code>, <code>Priority</code>,
        /// and <code>RuleId</code> </li> <li> <a>WafAction</a>: Contains <code>Type</code> </li>
        /// </ul>
        /// </summary>
        public List<WebACLUpdate> Updates
        {
            get { return this._updates; }
            set { this._updates = value; }
        }

        // Check to see if Updates property is set
        internal bool IsSetUpdates()
        {
            return this._updates != null && this._updates.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property WebACLId. 
        /// <para>
        /// The <code>WebACLId</code> of the <a>WebACL</a> that you want to update. <code>WebACLId</code>
        /// is returned by <a>CreateWebACL</a> and by <a>ListWebACLs</a>.
        /// </para>
        /// </summary>
        public string WebACLId
        {
            get { return this._webACLId; }
            set { this._webACLId = value; }
        }

        // Check to see if WebACLId property is set
        internal bool IsSetWebACLId()
        {
            return this._webACLId != null;
        }

    }
}