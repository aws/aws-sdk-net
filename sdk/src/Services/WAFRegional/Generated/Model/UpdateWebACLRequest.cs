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
    /// Container for the parameters to the UpdateWebACL operation.
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
    /// Inserts or deletes <a>ActivatedRule</a> objects in a <c>WebACL</c>. Each <c>Rule</c>
    /// identifies web requests that you want to allow, block, or count. When you update a
    /// <c>WebACL</c>, you specify the following values:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// A default action for the <c>WebACL</c>, either <c>ALLOW</c> or <c>BLOCK</c>. AWS WAF
    /// performs the default action if a request doesn't match the criteria in any of the
    /// <c>Rules</c> in a <c>WebACL</c>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The <c>Rules</c> that you want to add or delete. If you want to replace one <c>Rule</c>
    /// with another, you delete the existing <c>Rule</c> and add the new one.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// For each <c>Rule</c>, whether you want AWS WAF to allow requests, block requests,
    /// or count requests that match the conditions in the <c>Rule</c>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The order in which you want AWS WAF to evaluate the <c>Rules</c> in a <c>WebACL</c>.
    /// If you add more than one <c>Rule</c> to a <c>WebACL</c>, AWS WAF evaluates each request
    /// against the <c>Rules</c> in order based on the value of <c>Priority</c>. (The <c>Rule</c>
    /// that has the lowest value for <c>Priority</c> is evaluated first.) When a web request
    /// matches all the predicates (such as <c>ByteMatchSets</c> and <c>IPSets</c>) in a <c>Rule</c>,
    /// AWS WAF immediately takes the corresponding action, allow or block, and doesn't evaluate
    /// the request against the remaining <c>Rules</c> in the <c>WebACL</c>, if any. 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// To create and configure a <c>WebACL</c>, perform the following steps:
    /// </para>
    ///  <ol> <li> 
    /// <para>
    /// Create and update the predicates that you want to include in <c>Rules</c>. For more
    /// information, see <a>CreateByteMatchSet</a>, <a>UpdateByteMatchSet</a>, <a>CreateIPSet</a>,
    /// <a>UpdateIPSet</a>, <a>CreateSqlInjectionMatchSet</a>, and <a>UpdateSqlInjectionMatchSet</a>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Create and update the <c>Rules</c> that you want to include in the <c>WebACL</c>.
    /// For more information, see <a>CreateRule</a> and <a>UpdateRule</a>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Create a <c>WebACL</c>. See <a>CreateWebACL</a>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Use <c>GetChangeToken</c> to get the change token that you provide in the <c>ChangeToken</c>
    /// parameter of an <a>UpdateWebACL</a> request.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Submit an <c>UpdateWebACL</c> request to specify the <c>Rules</c> that you want to
    /// include in the <c>WebACL</c>, to specify the default action, and to associate the
    /// <c>WebACL</c> with a CloudFront distribution. 
    /// </para>
    ///  
    /// <para>
    /// The <c>ActivatedRule</c> can be a rule group. If you specify a rule group as your
    /// <c>ActivatedRule</c> , you can exclude specific rules from that rule group.
    /// </para>
    ///  
    /// <para>
    /// If you already have a rule group associated with a web ACL and want to submit an <c>UpdateWebACL</c>
    /// request to exclude certain rules from that rule group, you must first remove the rule
    /// group from the web ACL, the re-insert it again, specifying the excluded rules. For
    /// details, see <a>ActivatedRule$ExcludedRules</a> . 
    /// </para>
    ///  </li> </ol> 
    /// <para>
    /// Be aware that if you try to add a RATE_BASED rule to a web ACL without setting the
    /// rule type when first creating the rule, the <a>UpdateWebACL</a> request will fail
    /// because the request tries to add a REGULAR rule (the default rule type) with the specified
    /// ID, which does not exist. 
    /// </para>
    ///  
    /// <para>
    /// For more information about how to use the AWS WAF API to allow or block HTTP requests,
    /// see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/">AWS WAF Developer
    /// Guide</a>.
    /// </para>
    /// </summary>
    public partial class UpdateWebACLRequest : AmazonWAFRegionalRequest
    {
        private string _changeToken;
        private WafAction _defaultAction;
        private List<WebACLUpdate> _updates = AWSConfigs.InitializeCollections ? new List<WebACLUpdate>() : null;
        private string _webACLId;

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
        /// Gets and sets the property DefaultAction. 
        /// <para>
        /// A default action for the web ACL, either ALLOW or BLOCK. AWS WAF performs the default
        /// action if a request doesn't match the criteria in any of the rules in a web ACL.
        /// </para>
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
        /// An array of <c>WebACLUpdate</c> objects that you want to insert into or delete from
        /// a <a>WebACL</a>. For more information, see the applicable data types:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>WebACLUpdate</a>: Contains <c>Action</c> and <c>ActivatedRule</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ActivatedRule</a>: Contains <c>Action</c>, <c>OverrideAction</c>, <c>Priority</c>,
        /// <c>RuleId</c>, and <c>Type</c>. <c>ActivatedRule|OverrideAction</c> applies only when
        /// updating or adding a <c>RuleGroup</c> to a <c>WebACL</c>. In this case, you do not
        /// use <c>ActivatedRule|Action</c>. For all other update requests, <c>ActivatedRule|Action</c>
        /// is used instead of <c>ActivatedRule|OverrideAction</c>. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>WafAction</a>: Contains <c>Type</c> 
        /// </para>
        ///  </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<WebACLUpdate> Updates
        {
            get { return this._updates; }
            set { this._updates = value; }
        }

        // Check to see if Updates property is set
        internal bool IsSetUpdates()
        {
            return this._updates != null && (this._updates.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property WebACLId. 
        /// <para>
        /// The <c>WebACLId</c> of the <a>WebACL</a> that you want to update. <c>WebACLId</c>
        /// is returned by <a>CreateWebACL</a> and by <a>ListWebACLs</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
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