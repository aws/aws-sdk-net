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
    /// Container for the parameters to the CreateWebACL operation. Creates a <a>WebACL</a>
    /// per the specifications provided. <para> A web ACL defines a collection of rules to
    /// use to inspect and control web requests. Each rule has a statement that defines what
    /// to look for in web requests and an action that WAF applies to requests that match
    /// the statement. In the web ACL, you assign a default action to take (allow, block)
    /// for any request that does not match any of the rules. The rules in a web ACL can be
    /// a combination of the types <a>Rule</a>, <a>RuleGroup</a>, and managed rule group.
    /// You can associate a web ACL with one or more Amazon Web Services resources to protect.
    /// The resource types include Amazon CloudFront distribution, Amazon API Gateway REST
    /// API, Application Load Balancer, AppSync GraphQL API, Amazon Cognito user pool, App
    /// Runner service, Amplify application, Amazon Web Services Verified Access instance,
    /// and Amazon Bedrock AgentCore Gateway. </para>
    /// </summary>
    public partial class CreateWebACLRequest : AmazonWAFV2Request
    {
        /// <summary>
        /// Gets and sets the property ApplicationConfig. 
        /// <para>
        /// Configures the ability for the WAF console to store and retrieve application attributes
        /// during the web ACL creation process. Application attributes help WAF give recommendations
        /// for protection packs.
        /// </para>
        /// </summary>
        public ApplicationConfig ApplicationConfig { get; set; }

        /// <summary>
        /// Checks to see if the ApplicationConfig property is set.
        /// </summary>
        internal bool IsSetApplicationConfig() => this.ApplicationConfig != null;

        /// <summary>
        /// Gets and sets the property AssociationConfig. 
        /// <para>
        /// Specifies custom configurations for the associations between the web ACL and protected
        /// resources. 
        /// </para>
        ///  
        /// <para>
        /// Use this to customize the maximum size of the request body that your protected resources
        /// forward to WAF for inspection. You can customize this setting for CloudFront, API
        /// Gateway, Amazon Cognito, App Runner, or Verified Access resources. The default setting
        /// is 16 KB (16,384 bytes). 
        /// </para>
        ///  <note> 
        /// <para>
        /// You are charged additional fees when your protected resources forward body sizes that
        /// are larger than the default. For more information, see <a href="http://aws.amazon.com/waf/pricing/">WAF
        /// Pricing</a>.
        /// </para>
        ///  </note> 
        /// <para>
        /// For Application Load Balancer and AppSync, the limit is fixed at 8 KB (8,192 bytes).
        /// </para>
        ///  
        /// <para>
        /// You can also use this to have your CloudFront distributions insert the WAF challenge
        /// JavaScript SDK into the HTML responses that they return. For more information, see
        /// the <c>ChallengeJavascriptSdkInjection</c> setting. 
        /// </para>
        /// </summary>
        public AssociationConfig AssociationConfig { get; set; }

        /// <summary>
        /// Checks to see if the AssociationConfig property is set.
        /// </summary>
        internal bool IsSetAssociationConfig() => this.AssociationConfig != null;

        /// <summary>
        /// Gets and sets the property CaptchaConfig. 
        /// <para>
        /// Specifies how WAF should handle <c>CAPTCHA</c> evaluations for rules that don't have
        /// their own <c>CaptchaConfig</c> settings. If you don't specify this, WAF uses its default
        /// settings for <c>CaptchaConfig</c>. 
        /// </para>
        /// </summary>
        public CaptchaConfig CaptchaConfig { get; set; }

        /// <summary>
        /// Checks to see if the CaptchaConfig property is set.
        /// </summary>
        internal bool IsSetCaptchaConfig() => this.CaptchaConfig != null;

        /// <summary>
        /// Gets and sets the property ChallengeConfig. 
        /// <para>
        /// Specifies how WAF should handle challenge evaluations for rules that don't have their
        /// own <c>ChallengeConfig</c> settings. If you don't specify this, WAF uses its default
        /// settings for <c>ChallengeConfig</c>. 
        /// </para>
        /// </summary>
        public ChallengeConfig ChallengeConfig { get; set; }

        /// <summary>
        /// Checks to see if the ChallengeConfig property is set.
        /// </summary>
        internal bool IsSetChallengeConfig() => this.ChallengeConfig != null;

        /// <summary>
        /// Gets and sets the property CustomResponseBodies. 
        /// <para>
        /// A map of custom response keys and content bodies. When you create a rule with a block
        /// action, you can send a custom response to the web request. You define these for the
        /// web ACL, and then use them in the rules and default actions that you define in the
        /// web ACL. 
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
        /// Gets and sets the property DataProtectionConfig. 
        /// <para>
        /// Specifies data protection to apply to the web request data for the web ACL. This is
        /// a web ACL level data protection option. 
        /// </para>
        ///  
        /// <para>
        /// The data protection that you configure for the web ACL alters the data that's available
        /// for any other data collection activity, including your WAF logging destinations, web
        /// ACL request sampling, and Amazon Security Lake data collection and management. Your
        /// other option for data protection is in the logging configuration, which only affects
        /// logging. 
        /// </para>
        /// </summary>
        public DataProtectionConfig DataProtectionConfig { get; set; }

        /// <summary>
        /// Checks to see if the DataProtectionConfig property is set.
        /// </summary>
        internal bool IsSetDataProtectionConfig() => this.DataProtectionConfig != null;

        /// <summary>
        /// Gets and sets the property DefaultAction. 
        /// <para>
        /// The action to perform if none of the <c>Rules</c> contained in the <c>WebACL</c> match.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DefaultAction DefaultAction { get; set; }

        /// <summary>
        /// Checks to see if the DefaultAction property is set.
        /// </summary>
        internal bool IsSetDefaultAction() => this.DefaultAction != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the web ACL that helps with identification. 
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
        /// The monetization configuration for the web ACL. Provide this when any rule in the
        /// web ACL uses the <c>Monetize</c> action.
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
        /// The name of the web ACL. You cannot change the name of a web ACL after you create
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
        /// Gets and sets the property OnSourceDDoSProtectionConfig. 
        /// <para>
        /// Specifies the type of DDoS protection to apply to web request data for a web ACL.
        /// For most scenarios, it is recommended to use the default protection level, <c>ACTIVE_UNDER_DDOS</c>.
        /// If a web ACL is associated with multiple Application Load Balancers, the changes you
        /// make to DDoS protection in that web ACL will apply to all associated Application Load
        /// Balancers.
        /// </para>
        /// </summary>
        public OnSourceDDoSProtectionConfig OnSourceDDoSProtectionConfig { get; set; }

        /// <summary>
        /// Checks to see if the OnSourceDDoSProtectionConfig property is set.
        /// </summary>
        internal bool IsSetOnSourceDDoSProtectionConfig() => this.OnSourceDDoSProtectionConfig != null;

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
        /// Gets and sets the property TokenDomains. 
        /// <para>
        /// Specifies the domains that WAF should accept in a web request token. This enables
        /// the use of tokens across multiple protected websites. When WAF provides a token, it
        /// uses the domain of the Amazon Web Services resource that the web ACL is protecting.
        /// If you don't specify a list of token domains, WAF accepts tokens only for the domain
        /// of the protected resource. With a token domain list, WAF accepts the resource's host
        /// domain plus all domains in the token domain list, including their prefixed subdomains.
        /// </para>
        ///  
        /// <para>
        /// Example JSON: <c>"TokenDomains": { "mywebsite.com", "myotherwebsite.com" }</c> 
        /// </para>
        ///  
        /// <para>
        /// Public suffixes aren't allowed. For example, you can't use <c>gov.au</c> or <c>co.uk</c>
        /// as token domains.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> TokenDomains { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the TokenDomains property is set.
        /// </summary>
        internal bool IsSetTokenDomains() => this.TokenDomains != null && (this.TokenDomains.Count > 0 || !AWSConfigs.InitializeCollections);

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
