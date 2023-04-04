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

namespace Amazon.WAFV2.Model
{
    /// <summary>
    /// Container for the parameters to the CreateWebACL operation.
    /// Creates a <a>WebACL</a> per the specifications provided.
    /// 
    ///  
    /// <para>
    ///  A web ACL defines a collection of rules to use to inspect and control web requests.
    /// Each rule has an action defined (allow, block, or count) for requests that match the
    /// statement of the rule. In the web ACL, you assign a default action to take (allow,
    /// block) for any request that does not match any of the rules. The rules in a web ACL
    /// can be a combination of the types <a>Rule</a>, <a>RuleGroup</a>, and managed rule
    /// group. You can associate a web ACL with one or more Amazon Web Services resources
    /// to protect. The resources can be an Amazon CloudFront distribution, an Amazon API
    /// Gateway REST API, an Application Load Balancer, an AppSync GraphQL API, Amazon Cognito
    /// user pool, or an App Runner service. 
    /// </para>
    /// </summary>
    public partial class CreateWebACLRequest : AmazonWAFV2Request
    {
        private CaptchaConfig _captchaConfig;
        private ChallengeConfig _challengeConfig;
        private Dictionary<string, CustomResponseBody> _customResponseBodies = new Dictionary<string, CustomResponseBody>();
        private DefaultAction _defaultAction;
        private string _description;
        private string _name;
        private List<Rule> _rules = new List<Rule>();
        private Scope _scope;
        private List<Tag> _tags = new List<Tag>();
        private List<string> _tokenDomains = new List<string>();
        private VisibilityConfig _visibilityConfig;

        /// <summary>
        /// Gets and sets the property CaptchaConfig. 
        /// <para>
        /// Specifies how WAF should handle <code>CAPTCHA</code> evaluations for rules that don't
        /// have their own <code>CaptchaConfig</code> settings. If you don't specify this, WAF
        /// uses its default settings for <code>CaptchaConfig</code>. 
        /// </para>
        /// </summary>
        public CaptchaConfig CaptchaConfig
        {
            get { return this._captchaConfig; }
            set { this._captchaConfig = value; }
        }

        // Check to see if CaptchaConfig property is set
        internal bool IsSetCaptchaConfig()
        {
            return this._captchaConfig != null;
        }

        /// <summary>
        /// Gets and sets the property ChallengeConfig. 
        /// <para>
        /// Specifies how WAF should handle challenge evaluations for rules that don't have their
        /// own <code>ChallengeConfig</code> settings. If you don't specify this, WAF uses its
        /// default settings for <code>ChallengeConfig</code>. 
        /// </para>
        /// </summary>
        public ChallengeConfig ChallengeConfig
        {
            get { return this._challengeConfig; }
            set { this._challengeConfig = value; }
        }

        // Check to see if ChallengeConfig property is set
        internal bool IsSetChallengeConfig()
        {
            return this._challengeConfig != null;
        }

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
        /// web requests and responses in WAF</a> in the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">WAF
        /// Developer Guide</a>. 
        /// </para>
        ///  
        /// <para>
        /// For information about the limits on count and size for custom request and response
        /// settings, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/limits.html">WAF
        /// quotas</a> in the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">WAF
        /// Developer Guide</a>. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public Dictionary<string, CustomResponseBody> CustomResponseBodies
        {
            get { return this._customResponseBodies; }
            set { this._customResponseBodies = value; }
        }

        // Check to see if CustomResponseBodies property is set
        internal bool IsSetCustomResponseBodies()
        {
            return this._customResponseBodies != null && this._customResponseBodies.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property DefaultAction. 
        /// <para>
        /// The action to perform if none of the <code>Rules</code> contained in the <code>WebACL</code>
        /// match. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DefaultAction DefaultAction
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
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the web ACL that helps with identification. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the web ACL. You cannot change the name of a web ACL after you create
        /// it.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property Rules. 
        /// <para>
        /// The <a>Rule</a> statements used to identify the web requests that you want to allow,
        /// block, or count. Each rule includes one top-level statement that WAF uses to identify
        /// matching web requests, and parameters that govern how WAF handles them. 
        /// </para>
        /// </summary>
        public List<Rule> Rules
        {
            get { return this._rules; }
            set { this._rules = value; }
        }

        // Check to see if Rules property is set
        internal bool IsSetRules()
        {
            return this._rules != null && this._rules.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Scope. 
        /// <para>
        /// Specifies whether this is for an Amazon CloudFront distribution or for a regional
        /// application. A regional application can be an Application Load Balancer (ALB), an
        /// Amazon API Gateway REST API, an AppSync GraphQL API, a Amazon Cognito user pool, or
        /// an App Runner service. 
        /// </para>
        ///  
        /// <para>
        /// To work with CloudFront, you must also specify the Region US East (N. Virginia) as
        /// follows: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// CLI - Specify the Region when you use the CloudFront scope: <code>--scope=CLOUDFRONT
        /// --region=us-east-1</code>. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// API and SDKs - For all calls, use the Region endpoint us-east-1. 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public Scope Scope
        {
            get { return this._scope; }
            set { this._scope = value; }
        }

        // Check to see if Scope property is set
        internal bool IsSetScope()
        {
            return this._scope != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// An array of key:value pairs to associate with the resource.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

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
        /// Example JSON: <code>"TokenDomains": { "mywebsite.com", "myotherwebsite.com" }</code>
        /// 
        /// </para>
        ///  
        /// <para>
        /// Public suffixes aren't allowed. For example, you can't use <code>usa.gov</code> or
        /// <code>co.uk</code> as token domains.
        /// </para>
        /// </summary>
        public List<string> TokenDomains
        {
            get { return this._tokenDomains; }
            set { this._tokenDomains = value; }
        }

        // Check to see if TokenDomains property is set
        internal bool IsSetTokenDomains()
        {
            return this._tokenDomains != null && this._tokenDomains.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property VisibilityConfig. 
        /// <para>
        /// Defines and enables Amazon CloudWatch metrics and web request sample collection. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public VisibilityConfig VisibilityConfig
        {
            get { return this._visibilityConfig; }
            set { this._visibilityConfig = value; }
        }

        // Check to see if VisibilityConfig property is set
        internal bool IsSetVisibilityConfig()
        {
            return this._visibilityConfig != null;
        }

    }
}