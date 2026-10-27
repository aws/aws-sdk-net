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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
        /// <summary>
        /// Gets and sets the property Action. 
        /// <para>
        /// The action that WAF applied to the request.
        /// </para>
        /// </summary>
        public string Action { get; set; }

        /// <summary>
        /// Checks to see if the Action property is set.
        /// </summary>
        internal bool IsSetAction() => this.Action != null;

        /// <summary>
        /// Gets and sets the property CaptchaResponse. 
        /// <para>
        /// The <c>CAPTCHA</c> response for the request.
        /// </para>
        /// </summary>
        public CaptchaResponse CaptchaResponse { get; set; }

        /// <summary>
        /// Checks to see if the CaptchaResponse property is set.
        /// </summary>
        internal bool IsSetCaptchaResponse() => this.CaptchaResponse != null;

        /// <summary>
        /// Gets and sets the property ChallengeResponse. 
        /// <para>
        /// The <c>Challenge</c> response for the request.
        /// </para>
        /// </summary>
        public ChallengeResponse ChallengeResponse { get; set; }

        /// <summary>
        /// Checks to see if the ChallengeResponse property is set.
        /// </summary>
        internal bool IsSetChallengeResponse() => this.ChallengeResponse != null;

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
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Label> Labels { get; set; } = AWSConfigs.InitializeCollections ? new List<Label>() : null;

        /// <summary>
        /// Checks to see if the Labels property is set.
        /// </summary>
        internal bool IsSetLabels() => this.Labels != null && (this.Labels.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property OverriddenAction. 
        /// <para>
        /// Used only for rule group rules that have a rule action override in place in the web
        /// ACL. This is the action that the rule group rule is configured for, and not the action
        /// that was applied to the request. The action that WAF applied is the <c>Action</c>
        /// value. 
        /// </para>
        /// </summary>
        public string OverriddenAction { get; set; }

        /// <summary>
        /// Checks to see if the OverriddenAction property is set.
        /// </summary>
        internal bool IsSetOverriddenAction() => this.OverriddenAction != null;

        /// <summary>
        /// Gets and sets the property Request. 
        /// <para>
        /// A complex type that contains detailed information about the request.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public HTTPRequest Request { get; set; }

        /// <summary>
        /// Checks to see if the Request property is set.
        /// </summary>
        internal bool IsSetRequest() => this.Request != null;

        /// <summary>
        /// Gets and sets the property RequestHeadersInserted. 
        /// <para>
        /// Custom request headers inserted by WAF into the request, according to the custom request
        /// configuration for the matching rule action.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<HTTPHeader> RequestHeadersInserted { get; set; } = AWSConfigs.InitializeCollections ? new List<HTTPHeader>() : null;

        /// <summary>
        /// Checks to see if the RequestHeadersInserted property is set.
        /// </summary>
        internal bool IsSetRequestHeadersInserted() => this.RequestHeadersInserted != null && (this.RequestHeadersInserted.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ResponseCodeSent. 
        /// <para>
        /// The response code that was sent for the request.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 200, Max = 599)]
        public int? ResponseCodeSent { get; set; }

        /// <summary>
        /// Checks to see if the ResponseCodeSent property is set.
        /// </summary>
        internal bool IsSetResponseCodeSent() => this.ResponseCodeSent.HasValue;

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
        [AWSProperty(Min = 1, Max = 128)]
        public string RuleNameWithinRuleGroup { get; set; }

        /// <summary>
        /// Checks to see if the RuleNameWithinRuleGroup property is set.
        /// </summary>
        internal bool IsSetRuleNameWithinRuleGroup() => this.RuleNameWithinRuleGroup != null;

        /// <summary>
        /// Gets and sets the property Timestamp. 
        /// <para>
        /// The time at which WAF received the request from your Amazon Web Services resource,
        /// in Unix time format (in seconds).
        /// </para>
        /// </summary>
        public DateTime? Timestamp { get; set; }

        /// <summary>
        /// Checks to see if the Timestamp property is set.
        /// </summary>
        internal bool IsSetTimestamp() => this.Timestamp.HasValue;

        /// <summary>
        /// Gets and sets the property Weight. 
        /// <para>
        /// A value that indicates how one result in the response relates proportionally to other
        /// results in the response. For example, a result that has a weight of <c>2</c> represents
        /// roughly twice as many web requests as a result that has a weight of <c>1</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0)]
        public long? Weight { get; set; }

        /// <summary>
        /// Checks to see if the Weight property is set.
        /// </summary>
        internal bool IsSetWeight() => this.Weight.HasValue;
    }
}
