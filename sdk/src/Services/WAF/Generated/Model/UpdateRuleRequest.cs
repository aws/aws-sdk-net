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
    /// Container for the parameters to the UpdateRule operation.
    /// Inserts or deletes <a>Predicate</a> objects in a <code>Rule</code>. Each <code>Predicate</code>
    /// object identifies a predicate, such as a <a>ByteMatchSet</a> or an <a>IPSet</a>, that
    /// specifies the web requests that you want to allow, block, or count. If you add more
    /// than one predicate to a <code>Rule</code>, a request must match all of the specifications
    /// to be allowed, blocked, or counted. For example, suppose that you add the following
    /// to a <code>Rule</code>: 
    /// 
    ///  <ul> <li> 
    /// <para>
    /// A <code>ByteMatchSet</code> that matches the value <code>BadBot</code> in the <code>User-Agent</code>
    /// header
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// An <code>IPSet</code> that matches the IP address <code>192.0.2.44</code> 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// You then add the <code>Rule</code> to a <code>WebACL</code> and specify that you want
    /// to block requests that satisfy the <code>Rule</code>. For a request to be blocked,
    /// the <code>User-Agent</code> header in the request must contain the value <code>BadBot</code>
    /// <i>and</i> the request must originate from the IP address 192.0.2.44.
    /// </para>
    ///  
    /// <para>
    /// To create and configure a <code>Rule</code>, perform the following steps:
    /// </para>
    ///  <ol> <li> 
    /// <para>
    /// Create and update the predicates that you want to include in the <code>Rule</code>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Create the <code>Rule</code>. See <a>CreateRule</a>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Use <code>GetChangeToken</code> to get the change token that you provide in the <code>ChangeToken</code>
    /// parameter of an <a>UpdateRule</a> request.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Submit an <code>UpdateRule</code> request to add predicates to the <code>Rule</code>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Create and update a <code>WebACL</code> that contains the <code>Rule</code>. See <a>CreateWebACL</a>.
    /// </para>
    ///  </li> </ol> 
    /// <para>
    /// If you want to replace one <code>ByteMatchSet</code> or <code>IPSet</code> with another,
    /// you delete the existing one and add the new one.
    /// </para>
    ///  
    /// <para>
    /// For more information about how to use the AWS WAF API to allow or block HTTP requests,
    /// see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/">AWS WAF Developer
    /// Guide</a>.
    /// </para>
    /// </summary>
    public partial class UpdateRuleRequest : AmazonWAFRequest
    {
        private string _changeToken;
        private string _ruleId;
        private List<RuleUpdate> _updates = new List<RuleUpdate>();

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
        /// Gets and sets the property RuleId. 
        /// <para>
        /// The <code>RuleId</code> of the <code>Rule</code> that you want to update. <code>RuleId</code>
        /// is returned by <code>CreateRule</code> and by <a>ListRules</a>.
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

        /// <summary>
        /// Gets and sets the property Updates. 
        /// <para>
        /// An array of <code>RuleUpdate</code> objects that you want to insert into or delete
        /// from a <a>Rule</a>. For more information, see the applicable data types:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>RuleUpdate</a>: Contains <code>Action</code> and <code>Predicate</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>Predicate</a>: Contains <code>DataId</code>, <code>Negated</code>, and <code>Type</code>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>FieldToMatch</a>: Contains <code>Data</code> and <code>Type</code> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public List<RuleUpdate> Updates
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