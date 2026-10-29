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

namespace Amazon.WAF.Model
{
    /// <summary>
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
    /// The response from a <a>GetSampledRequests</a> request includes a <c>SampledHTTPRequests</c>
    /// complex type that appears as <c>SampledRequests</c> in the response syntax. <c>SampledHTTPRequests</c>
    /// contains one <c>SampledHTTPRequest</c> object for each web request that is returned
    /// by <c>GetSampledRequests</c>.
    /// </para>
    /// </summary>
    public partial class SampledHTTPRequest
    {
        /// <summary>
        /// Gets and sets the property Action. 
        /// <para>
        /// The action for the <c>Rule</c> that the request matched: <c>ALLOW</c>, <c>BLOCK</c>,
        /// or <c>COUNT</c>.
        /// </para>
        /// </summary>
        public string Action { get; set; }

        /// <summary>
        /// Checks to see if the Action property is set.
        /// </summary>
        internal bool IsSetAction() => this.Action != null;

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
        /// Gets and sets the property RuleWithinRuleGroup. 
        /// <para>
        /// This value is returned if the <c>GetSampledRequests</c> request specifies the ID of
        /// a <c>RuleGroup</c> rather than the ID of an individual rule. <c>RuleWithinRuleGroup</c>
        /// is the rule within the specified <c>RuleGroup</c> that matched the request listed
        /// in the response.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string RuleWithinRuleGroup { get; set; }

        /// <summary>
        /// Checks to see if the RuleWithinRuleGroup property is set.
        /// </summary>
        internal bool IsSetRuleWithinRuleGroup() => this.RuleWithinRuleGroup != null;

        /// <summary>
        /// Gets and sets the property Timestamp. 
        /// <para>
        /// The time at which AWS WAF received the request from your AWS resource, in Unix time
        /// format (in seconds).
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
        /// results in the response. A result that has a weight of <c>2</c> represents roughly
        /// twice as many CloudFront web requests as a result that has a weight of <c>1</c>.
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
