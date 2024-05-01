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
    /// Container for the parameters to the ListActivatedRulesInRuleGroup operation.
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
    /// Returns an array of <a>ActivatedRule</a> objects.
    /// </para>
    /// </summary>
    public partial class ListActivatedRulesInRuleGroupRequest : AmazonWAFRegionalRequest
    {
        private int? _limit;
        private string _nextMarker;
        private string _ruleGroupId;

        /// <summary>
        /// Gets and sets the property Limit. 
        /// <para>
        /// Specifies the number of <c>ActivatedRules</c> that you want AWS WAF to return for
        /// this request. If you have more <c>ActivatedRules</c> than the number that you specify
        /// for <c>Limit</c>, the response includes a <c>NextMarker</c> value that you can use
        /// to get another batch of <c>ActivatedRules</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public int? Limit
        {
            get { return this._limit; }
            set { this._limit = value; }
        }

        // Check to see if Limit property is set
        internal bool IsSetLimit()
        {
            return this._limit.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextMarker. 
        /// <para>
        /// If you specify a value for <c>Limit</c> and you have more <c>ActivatedRules</c> than
        /// the value of <c>Limit</c>, AWS WAF returns a <c>NextMarker</c> value in the response
        /// that allows you to list another group of <c>ActivatedRules</c>. For the second and
        /// subsequent <c>ListActivatedRulesInRuleGroup</c> requests, specify the value of <c>NextMarker</c>
        /// from the previous response to get information about another batch of <c>ActivatedRules</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1224)]
        public string NextMarker
        {
            get { return this._nextMarker; }
            set { this._nextMarker = value; }
        }

        // Check to see if NextMarker property is set
        internal bool IsSetNextMarker()
        {
            return this._nextMarker != null;
        }

        /// <summary>
        /// Gets and sets the property RuleGroupId. 
        /// <para>
        /// The <c>RuleGroupId</c> of the <a>RuleGroup</a> for which you want to get a list of
        /// <a>ActivatedRule</a> objects.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
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

    }
}