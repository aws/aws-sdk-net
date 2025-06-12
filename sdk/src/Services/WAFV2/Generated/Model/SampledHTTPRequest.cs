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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.WAFV2.Model
{
    /// <summary>
    /// Represents a single sampled web request. The response from <a>GetSampledRequests</a>
    /// includes a <c>SampledHTTPRequests</c> complex type that appears as <c>SampledRequests</c>
    /// in the response syntax. <c>SampledHTTPRequests</c> contains an array of <c>SampledHTTPRequest</c>
    /// objects.
    /// </summary>
    public partial class SampledHTTPRequest
    {
        private string _action;
        private CaptchaResponse _captchaResponse;
        private ChallengeResponse _challengeResponse;
        private List<Label> _labels = AWSConfigs.InitializeCollections ? new List<Label>() : null;
        private string _overriddenAction;
        private HTTPRequest _request;
        private List<HTTPHeader> _requestHeadersInserted = AWSConfigs.InitializeCollections ? new List<HTTPHeader>() : null;
        private int? _responseCodeSent;
        private string _ruleNameWithinRuleGroup;
        private DateTime? _timestamp;
        private long? _weight;

        /// <summary>
        /// Gets and sets the property Action. 
        /// <para>
        /// The action that WAF applied to the request.
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
        /// Gets and sets the property CaptchaResponse. 
        /// <para>
        /// The <c>CAPTCHA</c> response for the request.
        /// </para>
        /// </summary>
        public CaptchaResponse CaptchaResponse
        {
            get { return this._captchaResponse; }
            set { this._captchaResponse = value; }
        }

        // Check to see if CaptchaResponse property is set
        internal bool IsSetCaptchaResponse()
        {
            return this._captchaResponse != null;
        }

        /// <summary>
        /// Gets and sets the property ChallengeResponse. 
        /// <para>
        /// The <c>Challenge</c> response for the request.
        /// </para>
        /// </summary>
        public ChallengeResponse ChallengeResponse
        {
            get { return this._challengeResponse; }
            set { this._challengeResponse = value; }
        }

        // Check to see if ChallengeResponse property is set
        internal bool IsSetChallengeResponse()
        {
            return this._challengeResponse != null;
        }

        /// <summary>
        /// Gets and sets the property Labels. 
        /// <para>
        /// Labels applied to the web request by matching rules. WAF applies fully qualified labels
        /// to matching web requests. A fully qualified label is the concatenation of a label
        /// namespace and a rule label. The rule's rule group or web ACL defines the label namespace.
        /// 
        /// </para>
        ///  
        /// <para>
        /// For example, <c>awswaf:111122223333:myRuleGroup:testRules:testNS1:testNS2:labelNameA</c>
        /// or <c>awswaf:managed:aws:managed-rule-set:header:encoding:utf8</c>. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Label> Labels
        {
            get { return this._labels; }
            set { this._labels = value; }
        }

        // Check to see if Labels property is set
        internal bool IsSetLabels()
        {
            return this._labels != null && (this._labels.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property OverriddenAction. 
        /// <para>
        /// Used only for rule group rules that have a rule action override in place in the web
        /// ACL. This is the action that the rule group rule is configured for, and not the action
        /// that was applied to the request. The action that WAF applied is the <c>Action</c>
        /// value. 
        /// </para>
        /// </summary>
        public string OverriddenAction
        {
            get { return this._overriddenAction; }
            set { this._overriddenAction = value; }
        }

        // Check to see if OverriddenAction property is set
        internal bool IsSetOverriddenAction()
        {
            return this._overriddenAction != null;
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
        /// Gets and sets the property RequestHeadersInserted. 
        /// <para>
        /// Custom request headers inserted by WAF into the request, according to the custom request
        /// configuration for the matching rule action.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<HTTPHeader> RequestHeadersInserted
        {
            get { return this._requestHeadersInserted; }
            set { this._requestHeadersInserted = value; }
        }

        // Check to see if RequestHeadersInserted property is set
        internal bool IsSetRequestHeadersInserted()
        {
            return this._requestHeadersInserted != null && (this._requestHeadersInserted.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ResponseCodeSent. 
        /// <para>
        /// The response code that was sent for the request.
        /// </para>
        /// </summary>
        [AWSProperty(Min=200, Max=599)]
        public int? ResponseCodeSent
        {
            get { return this._responseCodeSent; }
            set { this._responseCodeSent = value; }
        }

        // Check to see if ResponseCodeSent property is set
        internal bool IsSetResponseCodeSent()
        {
            return this._responseCodeSent.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RuleNameWithinRuleGroup. 
        /// <para>
        /// The name of the <c>Rule</c> that the request matched. For managed rule groups, the
        /// format for this name is <c>&lt;vendor name&gt;#&lt;managed rule group name&gt;#&lt;rule
        /// name&gt;</c>. For your own rule groups, the format for this name is <c>&lt;rule group
        /// name&gt;#&lt;rule name&gt;</c>. If the rule is not in a rule group, this field is
        /// absent. 
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
        /// The time at which WAF received the request from your Amazon Web Services resource,
        /// in Unix time format (in seconds).
        /// </para>
        /// </summary>
        public DateTime? Timestamp
        {
            get { return this._timestamp; }
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
        /// results in the response. For example, a result that has a weight of <c>2</c> represents
        /// roughly twice as many web requests as a result that has a weight of <c>1</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0)]
        public long? Weight
        {
            get { return this._weight; }
            set { this._weight = value; }
        }

        // Check to see if Weight property is set
        internal bool IsSetWeight()
        {
            return this._weight.HasValue; 
        }

    }
}