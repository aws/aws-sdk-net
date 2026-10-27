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
    /// Container for the parameters to the CreateRuleGroup operation. Creates a <a>RuleGroup</a>
    /// per the specifications provided. <para> A rule group defines a collection of rules
    /// to inspect and control web requests that you can use in a <a>WebACL</a>. When you
    /// create a rule group, you define an immutable capacity limit. If you update a rule
    /// group, you must stay within the capacity. This allows others to reuse the rule group
    /// with confidence in its capacity requirements. </para>
    /// </summary>
    public partial class CreateRuleGroupRequest : AmazonWAFV2Request
    {
        /// <summary>
        /// Gets and sets the property Capacity. 
        /// <para>
        /// The web ACL capacity units (WCUs) required for this rule group.
        /// </para>
        ///  
        /// <para>
        /// When you create your own rule group, you define this, and you cannot change it after
        /// creation. When you add or modify the rules in a rule group, WAF enforces this limit.
        /// You can check the capacity for a set of rules using <a>CheckCapacity</a>.
        /// </para>
        ///  
        /// <para>
        /// WAF uses WCUs to calculate and control the operating resources that are used to run
        /// your rules, rule groups, and web ACLs. WAF calculates capacity differently for each
        /// rule type, to reflect the relative cost of each rule. Simple rules that cost little
        /// to run use fewer WCUs than more complex rules that use more processing power. Rule
        /// group capacity is fixed at creation, which helps users plan their web ACL WCU usage
        /// when they use a rule group. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/aws-waf-capacity-units.html">WAF
        /// web ACL capacity units (WCU)</a> in the <i>WAF Developer Guide</i>. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1)]
        public long? Capacity { get; set; }

        /// <summary>
        /// Checks to see if the Capacity property is set.
        /// </summary>
        internal bool IsSetCapacity() => this.Capacity.HasValue;

        /// <summary>
        /// Gets and sets the property CustomResponseBodies. 
        /// <para>
        /// A map of custom response keys and content bodies. When you create a rule with a block
        /// action, you can send a custom response to the web request. You define these for the
        /// rule group, and then use them in the rules that you define in the rule group. 
        /// </para>
        ///  
        /// <para>
        /// For information about customizing web requests and responses, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-custom-request-response.html">Customizing
        /// web requests and responses in WAF</a> in the <i>WAF Developer Guide</i>. 
        /// </para>
        ///  
        /// <para>
        /// For information about the limits on count and size for custom request and response
        /// settings, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/limits.html">WAF
        /// quotas</a> in the <i>WAF Developer Guide</i>. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1)]
        public Dictionary<string, CustomResponseBody> CustomResponseBodies { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, CustomResponseBody>() : null;

        /// <summary>
        /// Checks to see if the CustomResponseBodies property is set.
        /// </summary>
        internal bool IsSetCustomResponseBodies() => this.CustomResponseBodies != null && (this.CustomResponseBodies.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the rule group that helps with identification. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property MonetizationConfig. 
        /// <para>
        /// The monetization configuration for the rule group. Provide this when any rule in the
        /// rule group uses the <c>Monetize</c> action.
        /// </para>
        /// </summary>
        public MonetizationConfig MonetizationConfig { get; set; }

        /// <summary>
        /// Checks to see if the MonetizationConfig property is set.
        /// </summary>
        internal bool IsSetMonetizationConfig() => this.MonetizationConfig != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the rule group. You cannot change the name of a rule group after you create
        /// it.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 128)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Rules. 
        /// <para>
        /// The <a>Rule</a> statements used to identify the web requests that you want to manage.
        /// Each rule includes one top-level statement that WAF uses to identify matching web
        /// requests, and parameters that govern how WAF handles them. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Rule> Rules { get; set; } = AWSConfigs.InitializeCollections ? new List<Rule>() : null;

        /// <summary>
        /// Checks to see if the Rules property is set.
        /// </summary>
        internal bool IsSetRules() => this.Rules != null && (this.Rules.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Scope. 
        /// <para>
        /// Specifies whether this is for a global resource type, such as a Amazon CloudFront
        /// distribution. For an Amplify application, use <c>CLOUDFRONT</c>.
        /// </para>
        ///  
        /// <para>
        /// To work with CloudFront, you must also specify the Region US East (N. Virginia) as
        /// follows: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// CLI - Specify the Region when you use the CloudFront scope: <c>--scope=CLOUDFRONT
        /// --region=us-east-1</c>. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// API and SDKs - For all calls, use the Region endpoint us-east-1. 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required = true)]
        public Scope Scope { get; set; }

        /// <summary>
        /// Checks to see if the Scope property is set.
        /// </summary>
        internal bool IsSetScope() => this.Scope != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// An array of key:value pairs to associate with the resource.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1)]
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property VisibilityConfig. 
        /// <para>
        /// Defines and enables Amazon CloudWatch metrics and web request sample collection. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public VisibilityConfig VisibilityConfig { get; set; }

        /// <summary>
        /// Checks to see if the VisibilityConfig property is set.
        /// </summary>
        internal bool IsSetVisibilityConfig() => this.VisibilityConfig != null;
    }
}
