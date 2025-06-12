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
 * Do not modify this file. This file is generated from the waf-regional-2016-11-28.normal.json service model.
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
namespace Amazon.WAFRegional.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateRule operation.
    /// <note> 
    /// <para>
    /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
    /// WAF Classic</a> in the developer guide.
    /// </para>
    ///  
    /// <para>
    ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
    /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
    /// for regional and global use. 
    /// </para>
    ///  </note> 
    /// <para>
    /// Inserts or deletes <a>Predicate</a> objects in a <c>Rule</c>. Each <c>Predicate</c>
    /// object identifies a predicate, such as a <a>ByteMatchSet</a> or an <a>IPSet</a>, that
    /// specifies the web requests that you want to allow, block, or count. If you add more
    /// than one predicate to a <c>Rule</c>, a request must match all of the specifications
    /// to be allowed, blocked, or counted. For example, suppose that you add the following
    /// to a <c>Rule</c>: 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// A <c>ByteMatchSet</c> that matches the value <c>BadBot</c> in the <c>User-Agent</c>
    /// header
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// An <c>IPSet</c> that matches the IP address <c>192.0.2.44</c> 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// You then add the <c>Rule</c> to a <c>WebACL</c> and specify that you want to block
    /// requests that satisfy the <c>Rule</c>. For a request to be blocked, the <c>User-Agent</c>
    /// header in the request must contain the value <c>BadBot</c> <i>and</i> the request
    /// must originate from the IP address 192.0.2.44.
    /// </para>
    ///  
    /// <para>
    /// To create and configure a <c>Rule</c>, perform the following steps:
    /// </para>
    ///  <ol> <li> 
    /// <para>
    /// Create and update the predicates that you want to include in the <c>Rule</c>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Create the <c>Rule</c>. See <a>CreateRule</a>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Use <c>GetChangeToken</c> to get the change token that you provide in the <c>ChangeToken</c>
    /// parameter of an <a>UpdateRule</a> request.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Submit an <c>UpdateRule</c> request to add predicates to the <c>Rule</c>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Create and update a <c>WebACL</c> that contains the <c>Rule</c>. See <a>CreateWebACL</a>.
    /// </para>
    ///  </li> </ol> 
    /// <para>
    /// If you want to replace one <c>ByteMatchSet</c> or <c>IPSet</c> with another, you delete
    /// the existing one and add the new one.
    /// </para>
    ///  
    /// <para>
    /// For more information about how to use the AWS WAF API to allow or block HTTP requests,
    /// see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/">AWS WAF Developer
    /// Guide</a>.
    /// </para>
    /// </summary>
    public partial class UpdateRuleRequest : AmazonWAFRegionalRequest
    {
        private string _changeToken;
        private string _ruleId;
        private List<RuleUpdate> _updates = AWSConfigs.InitializeCollections ? new List<RuleUpdate>() : null;

        /// <summary>
        /// Gets and sets the property ChangeToken. 
        /// <para>
        /// The value returned by the most recent call to <a>GetChangeToken</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
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
        /// The <c>RuleId</c> of the <c>Rule</c> that you want to update. <c>RuleId</c> is returned
        /// by <c>CreateRule</c> and by <a>ListRules</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
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
        /// An array of <c>RuleUpdate</c> objects that you want to insert into or delete from
        /// a <a>Rule</a>. For more information, see the applicable data types:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>RuleUpdate</a>: Contains <c>Action</c> and <c>Predicate</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>Predicate</a>: Contains <c>DataId</c>, <c>Negated</c>, and <c>Type</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>FieldToMatch</a>: Contains <c>Data</c> and <c>Type</c> 
        /// </para>
        ///  </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<RuleUpdate> Updates
        {
            get { return this._updates; }
            set { this._updates = value; }
        }

        // Check to see if Updates property is set
        internal bool IsSetUpdates()
        {
            return this._updates != null && (this._updates.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}