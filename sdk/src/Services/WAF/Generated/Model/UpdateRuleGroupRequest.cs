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
 * Do not modify this file. This file is generated from the waf-2015-08-24.normal.json service model.
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
namespace Amazon.WAF.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateRuleGroup operation.
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
    /// Inserts or deletes <a>ActivatedRule</a> objects in a <c>RuleGroup</c>.
    /// </para>
    ///  
    /// <para>
    /// You can only insert <c>REGULAR</c> rules into a rule group.
    /// </para>
    ///  
    /// <para>
    /// You can have a maximum of ten rules per rule group.
    /// </para>
    ///  
    /// <para>
    /// To create and configure a <c>RuleGroup</c>, perform the following steps:
    /// </para>
    ///  <ol> <li> 
    /// <para>
    /// Create and update the <c>Rules</c> that you want to include in the <c>RuleGroup</c>.
    /// See <a>CreateRule</a>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Use <c>GetChangeToken</c> to get the change token that you provide in the <c>ChangeToken</c>
    /// parameter of an <a>UpdateRuleGroup</a> request.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Submit an <c>UpdateRuleGroup</c> request to add <c>Rules</c> to the <c>RuleGroup</c>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Create and update a <c>WebACL</c> that contains the <c>RuleGroup</c>. See <a>CreateWebACL</a>.
    /// </para>
    ///  </li> </ol> 
    /// <para>
    /// If you want to replace one <c>Rule</c> with another, you delete the existing one and
    /// add the new one.
    /// </para>
    ///  
    /// <para>
    /// For more information about how to use the AWS WAF API to allow or block HTTP requests,
    /// see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/">AWS WAF Developer
    /// Guide</a>.
    /// </para>
    /// </summary>
    public partial class UpdateRuleGroupRequest : AmazonWAFRequest
    {
        private string _changeToken;
        private string _ruleGroupId;
        private List<RuleGroupUpdate> _updates = AWSConfigs.InitializeCollections ? new List<RuleGroupUpdate>() : null;

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
        /// Gets and sets the property RuleGroupId. 
        /// <para>
        /// The <c>RuleGroupId</c> of the <a>RuleGroup</a> that you want to update. <c>RuleGroupId</c>
        /// is returned by <a>CreateRuleGroup</a> and by <a>ListRuleGroups</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
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
        /// An array of <c>RuleGroupUpdate</c> objects that you want to insert into or delete
        /// from a <a>RuleGroup</a>.
        /// </para>
        ///  
        /// <para>
        /// You can only insert <c>REGULAR</c> rules into a rule group.
        /// </para>
        ///  
        /// <para>
        ///  <c>ActivatedRule|OverrideAction</c> applies only when updating or adding a <c>RuleGroup</c>
        /// to a <c>WebACL</c>. In this case you do not use <c>ActivatedRule|Action</c>. For all
        /// other update requests, <c>ActivatedRule|Action</c> is used instead of <c>ActivatedRule|OverrideAction</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
        public List<RuleGroupUpdate> Updates
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