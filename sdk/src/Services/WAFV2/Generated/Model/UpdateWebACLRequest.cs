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
    /// Container for the parameters to the UpdateWebACL operation.
    /// Updates the specified <a>WebACL</a>. While updating a web ACL, WAF provides continuous
    /// coverage to the resources that you have associated with the web ACL. 
    /// 
    ///  <note> 
    /// <para>
    /// This operation completely replaces the mutable specifications that you already have
    /// for the web ACL with the ones that you provide to this call. 
    /// </para>
    ///  
    /// <para>
    /// To modify a web ACL, do the following: 
    /// </para>
    ///  <ol> <li> 
    /// <para>
    /// Retrieve it by calling <a>GetWebACL</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Update its settings as needed
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Provide the complete web ACL specification to this call
    /// </para>
    ///  </li> </ol> </note> 
    /// <para>
    ///  A web ACL defines a collection of rules to use to inspect and control web requests.
    /// Each rule has a statement that defines what to look for in web requests and an action
    /// that WAF applies to requests that match the statement. In the web ACL, you assign
    /// a default action to take (allow, block) for any request that does not match any of
    /// the rules. The rules in a web ACL can be a combination of the types <a>Rule</a>, <a>RuleGroup</a>,
    /// and managed rule group. You can associate a web ACL with one or more Amazon Web Services
    /// resources to protect. The resource types include Amazon CloudFront distribution, Amazon
    /// API Gateway REST API, Application Load Balancer, AppSync GraphQL API, Amazon Cognito
    /// user pool, App Runner service, Amplify application, and Amazon Web Services Verified
    /// Access instance. 
    /// </para>
    ///  
    /// <para>
    ///  <b>Temporary inconsistencies during updates</b> 
    /// </para>
    ///  
    /// <para>
    /// When you create or change a web ACL or other WAF resources, the changes take a small
    /// amount of time to propagate to all areas where the resources are stored. The propagation
    /// time can be from a few seconds to a number of minutes. 
    /// </para>
    ///  
    /// <para>
    /// The following are examples of the temporary inconsistencies that you might notice
    /// during change propagation: 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// After you create a web ACL, if you try to associate it with a resource, you might
    /// get an exception indicating that the web ACL is unavailable. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// After you add a rule group to a web ACL, the new rule group rules might be in effect
    /// in one area where the web ACL is used and not in another.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// After you change a rule action setting, you might see the old action in some places
    /// and the new action in others. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// After you add an IP address to an IP set that is in use in a blocking rule, the new
    /// address might be blocked in one area while still allowed in another.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class UpdateWebACLRequest : AmazonWAFV2Request
    {
        private ApplicationConfig _applicationConfig;
        private AssociationConfig _associationConfig;
        private CaptchaConfig _captchaConfig;
        private ChallengeConfig _challengeConfig;
        private Dictionary<string, CustomResponseBody> _customResponseBodies = AWSConfigs.InitializeCollections ? new Dictionary<string, CustomResponseBody>() : null;
        private DataProtectionConfig _dataProtectionConfig;
        private DefaultAction _defaultAction;
        private string _description;
        private string _id;
        private string _lockToken;
        private string _name;
        private OnSourceDDoSProtectionConfig _onSourceDDoSProtectionConfig;
        private List<Rule> _rules = AWSConfigs.InitializeCollections ? new List<Rule>() : null;
        private Scope _scope;
        private List<string> _tokenDomains = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private VisibilityConfig _visibilityConfig;

        /// <summary>
        /// Gets and sets the property ApplicationConfig. 
        /// <para>
        /// Configures the ability for the WAF console to store and retrieve application attributes.
        /// Application attributes help WAF give recommendations for protection packs.
        /// </para>
        ///  
        /// <para>
        /// When using <c>UpdateWebACL</c>, <c>ApplicationConfig</c> follows these rules:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If you omit <c>ApplicationConfig</c> from the request, all existing entries in the
        /// web ACL are retained.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you include <c>ApplicationConfig</c>, entries must match the existing values exactly.
        /// Any attempt to modify existing entries will result in an error.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public ApplicationConfig ApplicationConfig
        {
            get { return this._applicationConfig; }
            set { this._applicationConfig = value; }
        }

        // Check to see if ApplicationConfig property is set
        internal bool IsSetApplicationConfig()
        {
            return this._applicationConfig != null;
        }

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
        /// </summary>
        public AssociationConfig AssociationConfig
        {
            get { return this._associationConfig; }
            set { this._associationConfig = value; }
        }

        // Check to see if AssociationConfig property is set
        internal bool IsSetAssociationConfig()
        {
            return this._associationConfig != null;
        }

        /// <summary>
        /// Gets and sets the property CaptchaConfig. 
        /// <para>
        /// Specifies how WAF should handle <c>CAPTCHA</c> evaluations for rules that don't have
        /// their own <c>CaptchaConfig</c> settings. If you don't specify this, WAF uses its default
        /// settings for <c>CaptchaConfig</c>. 
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
        /// own <c>ChallengeConfig</c> settings. If you don't specify this, WAF uses its default
        /// settings for <c>ChallengeConfig</c>. 
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
        /// web requests and responses in WAF</a> in the <i>WAF Developer Guide</i>. 
        /// </para>
        ///  
        /// <para>
        /// For information about the limits on count and size for custom request and response
        /// settings, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/limits.html">WAF
        /// quotas</a> in the <i>WAF Developer Guide</i>. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
            return this._customResponseBodies != null && (this._customResponseBodies.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

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
        public DataProtectionConfig DataProtectionConfig
        {
            get { return this._dataProtectionConfig; }
            set { this._dataProtectionConfig = value; }
        }

        // Check to see if DataProtectionConfig property is set
        internal bool IsSetDataProtectionConfig()
        {
            return this._dataProtectionConfig != null;
        }

        /// <summary>
        /// Gets and sets the property DefaultAction. 
        /// <para>
        /// The action to perform if none of the <c>Rules</c> contained in the <c>WebACL</c> match.
        /// 
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
        /// Gets and sets the property Id. 
        /// <para>
        /// The unique identifier for the web ACL. This ID is returned in the responses to create
        /// and list commands. You provide it to operations like update and delete.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=36)]
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property LockToken. 
        /// <para>
        /// A token used for optimistic locking. WAF returns a token to your <c>get</c> and <c>list</c>
        /// requests, to mark the state of the entity at the time of the request. To make changes
        /// to the entity associated with the token, you provide the token to operations like
        /// <c>update</c> and <c>delete</c>. WAF uses the token to ensure that no changes have
        /// been made to the entity since you last retrieved it. If a change has been made, the
        /// update fails with a <c>WAFOptimisticLockException</c>. If this happens, perform another
        /// <c>get</c>, and use the new token returned by that operation. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=36)]
        public string LockToken
        {
            get { return this._lockToken; }
            set { this._lockToken = value; }
        }

        // Check to see if LockToken property is set
        internal bool IsSetLockToken()
        {
            return this._lockToken != null;
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
        /// Gets and sets the property OnSourceDDoSProtectionConfig. 
        /// <para>
        /// Specifies the type of DDoS protection to apply to web request data for a web ACL.
        /// For most scenarios, it is recommended to use the default protection level, <c>ACTIVE_UNDER_DDOS</c>.
        /// If a web ACL is associated with multiple Application Load Balancers, the changes you
        /// make to DDoS protection in that web ACL will apply to all associated Application Load
        /// Balancers.
        /// </para>
        /// </summary>
        public OnSourceDDoSProtectionConfig OnSourceDDoSProtectionConfig
        {
            get { return this._onSourceDDoSProtectionConfig; }
            set { this._onSourceDDoSProtectionConfig = value; }
        }

        // Check to see if OnSourceDDoSProtectionConfig property is set
        internal bool IsSetOnSourceDDoSProtectionConfig()
        {
            return this._onSourceDDoSProtectionConfig != null;
        }

        /// <summary>
        /// Gets and sets the property Rules. 
        /// <para>
        /// The <a>Rule</a> statements used to identify the web requests that you want to manage.
        /// Each rule includes one top-level statement that WAF uses to identify matching web
        /// requests, and parameters that govern how WAF handles them. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Rule> Rules
        {
            get { return this._rules; }
            set { this._rules = value; }
        }

        // Check to see if Rules property is set
        internal bool IsSetRules()
        {
            return this._rules != null && (this._rules.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

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
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> TokenDomains
        {
            get { return this._tokenDomains; }
            set { this._tokenDomains = value; }
        }

        // Check to see if TokenDomains property is set
        internal bool IsSetTokenDomains()
        {
            return this._tokenDomains != null && (this._tokenDomains.Count > 0 || !AWSConfigs.InitializeCollections); 
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