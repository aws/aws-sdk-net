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
 * Do not modify this file. This file is generated from the wafv2-2019-07-29.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.WAFV2.Model
{
    /// <summary>
    /// <note> 
    /// <para>
    /// This is the latest version of <b>AWS WAF</b>, named AWS WAFV2, released in November,
    /// 2019. For information, including how to migrate your AWS WAF resources from the prior
    /// release, see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
    /// WAF Developer Guide</a>. 
    /// </para>
    ///  </note> 
    /// <para>
    /// Represents a single sampled web request. The response from <a>GetSampledRequests</a>
    /// includes a <code>SampledHTTPRequests</code> complex type that appears as <code>SampledRequests</code>
    /// in the response syntax. <code>SampledHTTPRequests</code> contains an array of <code>SampledHTTPRequest</code>
    /// objects.
    /// </para>
    /// </summary>
    public partial class SampledHTTPRequest
    {
        private string _action;
        private HTTPRequest _request;
        private string _ruleNameWithinRuleGroup;
        private DateTime? _timestamp;
        private long? _weight;

        /// <summary>
        /// Gets and sets the property Action. 
        /// <para>
        /// The action for the <code>Rule</code> that the request matched: <code>ALLOW</code>,
        /// <code>BLOCK</code>, or <code>COUNT</code>.
        /// </para>
        /// </summary>
        public string Action
        {
            get { return this._action; }
            set { this._action = value; }
        }

        // Check to see if Action property is set
        internal bool IsSetAction()
        {
            return this._action != null;
        }

        /// <summary>
        /// Gets and sets the property Request. 
        /// <para>
        /// A complex type that contains detailed information about the request.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public HTTPRequest Request
        {
            get { return this._request; }
            set { this._request = value; }
        }

        // Check to see if Request property is set
        internal bool IsSetRequest()
        {
            return this._request != null;
        }

        /// <summary>
        /// Gets and sets the property RuleNameWithinRuleGroup. 
        /// <para>
        /// The name of the <code>Rule</code> that the request matched. For managed rule groups,
        /// the format for this name is <code>&lt;vendor name&gt;#&lt;managed rule group name&gt;#&lt;rule
        /// name&gt;</code>. For your own rule groups, the format for this name is <code>&lt;rule
        /// group name&gt;#&lt;rule name&gt;</code>. If the rule is not in a rule group, the format
        /// is <code>&lt;rule name&gt;</code>. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string RuleNameWithinRuleGroup
        {
            get { return this._ruleNameWithinRuleGroup; }
            set { this._ruleNameWithinRuleGroup = value; }
        }

        // Check to see if RuleNameWithinRuleGroup property is set
        internal bool IsSetRuleNameWithinRuleGroup()
        {
            return this._ruleNameWithinRuleGroup != null;
        }

        /// <summary>
        /// Gets and sets the property Timestamp. 
        /// <para>
        /// The time at which AWS WAF received the request from your AWS resource, in Unix time
        /// format (in seconds).
        /// </para>
        /// </summary>
        public DateTime Timestamp
        {
            get { return this._timestamp.GetValueOrDefault(); }
            set { this._timestamp = value; }
        }

        // Check to see if Timestamp property is set
        internal bool IsSetTimestamp()
        {
            return this._timestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Weight. 
        /// <para>
        /// A value that indicates how one result in the response relates proportionally to other
        /// results in the response. For example, a result that has a weight of <code>2</code>
        /// represents roughly twice as many web requests as a result that has a weight of <code>1</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0)]
        public long Weight
        {
            get { return this._weight.GetValueOrDefault(); }
            set { this._weight = value; }
        }

        // Check to see if Weight property is set
        internal bool IsSetWeight()
        {
            return this._weight.HasValue; 
        }

    }
}