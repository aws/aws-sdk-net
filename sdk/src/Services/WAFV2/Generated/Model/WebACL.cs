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
    /// A web ACL defines a collection of rules to use to inspect and control web requests.
    /// Each rule has a statement that defines what to look for in web requests and an action
    /// that WAF applies to requests that match the statement. In the web ACL, you assign
    /// a default action to take (allow, block) for any request that does not match any of
    /// the rules. The rules in a web ACL can be a combination of the types <a>Rule</a>, <a>RuleGroup</a>,
    /// and managed rule group. You can associate a web ACL with one or more Amazon Web Services
    /// resources to protect. The resource types include Amazon CloudFront distribution, Amazon
    /// API Gateway REST API, Application Load Balancer, AppSync GraphQL API, Amazon Cognito
    /// user pool, App Runner service, Amplify application, and Amazon Web Services Verified
    /// Access instance.
    /// </summary>
    public partial class WebACL
    {
        private ApplicationConfig _applicationConfig;
        private string _arn;
        private AssociationConfig _associationConfig;
        private long? _capacity;
        private CaptchaConfig _captchaConfig;
        private ChallengeConfig _challengeConfig;
        private Dictionary<string, CustomResponseBody> _customResponseBodies = AWSConfigs.InitializeCollections ? new Dictionary<string, CustomResponseBody>() : null;
        private DataProtectionConfig _dataProtectionConfig;
        private DefaultAction _defaultAction;
        private string _description;
        private string _id;
        private string _labelNamespace;
        private bool? _managedByFirewallManager;
        private string _name;
        private OnSourceDDoSProtectionConfig _onSourceDDoSProtectionConfig;
        private List<FirewallManagerRuleGroup> _postProcessFirewallManagerRuleGroups = AWSConfigs.InitializeCollections ? new List<FirewallManagerRuleGroup>() : null;
        private List<FirewallManagerRuleGroup> _preProcessFirewallManagerRuleGroups = AWSConfigs.InitializeCollections ? new List<FirewallManagerRuleGroup>() : null;
        private bool? _retrofittedByFirewallManager;
        private List<Rule> _rules = AWSConfigs.InitializeCollections ? new List<Rule>() : null;
        private List<string> _tokenDomains = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private VisibilityConfig _visibilityConfig;

        /// <summary>
        /// Gets and sets the property ApplicationConfig. 
        /// <para>
        /// Returns a list of <c>ApplicationAttribute</c>s.
        /// </para>
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
        /// Gets and sets the property ARN. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the web ACL that you want to associate with the
        /// resource.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=2048)]
        public string ARN
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if ARN property is set
        internal bool IsSetARN()
        {
            return this._arn != null;
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
        /// Gets and sets the property Capacity. 
        /// <para>
        /// The web ACL capacity units (WCUs) currently being used by this web ACL. 
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
        [AWSProperty(Min=0)]
        public long? Capacity
        {
            get { return this._capacity; }
            set { this._capacity = value; }
        }

        // Check to see if Capacity property is set
        internal bool IsSetCapacity()
        {
            return this._capacity.HasValue; 
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
        /// A unique identifier for the <c>WebACL</c>. This ID is returned in the responses to
        /// create and list commands. You use this ID to do things like get, update, and delete
        /// a <c>WebACL</c>.
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
        /// Gets and sets the property LabelNamespace. 
        /// <para>
        /// The label namespace prefix for this web ACL. All labels added by rules in this web
        /// ACL have this prefix. 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The syntax for the label namespace prefix for a web ACL is the following: 
        /// </para>
        ///  
        /// <para>
        ///  <c>awswaf:&lt;account ID&gt;:webacl:&lt;web ACL name&gt;:</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// When a rule with a label matches a web request, WAF adds the fully qualified label
        /// to the request. A fully qualified label is made up of the label namespace from the
        /// rule group or web ACL where the rule is defined and the label from the rule, separated
        /// by a colon: 
        /// </para>
        ///  
        /// <para>
        ///  <c>&lt;label namespace&gt;:&lt;label from rule&gt;</c> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string LabelNamespace
        {
            get { return this._labelNamespace; }
            set { this._labelNamespace = value; }
        }

        // Check to see if LabelNamespace property is set
        internal bool IsSetLabelNamespace()
        {
            return this._labelNamespace != null;
        }

        /// <summary>
        /// Gets and sets the property ManagedByFirewallManager. 
        /// <para>
        /// Indicates whether this web ACL was created by Firewall Manager and is being managed
        /// by Firewall Manager. If true, then only Firewall Manager can delete the web ACL or
        /// any Firewall Manager rule groups in the web ACL. See also the properties <c>RetrofittedByFirewallManager</c>,
        /// <c>PreProcessFirewallManagerRuleGroups</c>, and <c>PostProcessFirewallManagerRuleGroups</c>.
        /// 
        /// </para>
        /// </summary>
        public bool? ManagedByFirewallManager
        {
            get { return this._managedByFirewallManager; }
            set { this._managedByFirewallManager = value; }
        }

        // Check to see if ManagedByFirewallManager property is set
        internal bool IsSetManagedByFirewallManager()
        {
            return this._managedByFirewallManager.HasValue; 
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
        /// Configures the level of DDoS protection that applies to web ACLs associated with Application
        /// Load Balancers.
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
        /// Gets and sets the property PostProcessFirewallManagerRuleGroups. 
        /// <para>
        /// The last set of rules for WAF to process in the web ACL. This is defined in an Firewall
        /// Manager WAF policy and contains only rule group references. You can't alter these.
        /// Any rules and rule groups that you define for the web ACL are prioritized before these.
        /// 
        /// </para>
        ///  
        /// <para>
        /// In the Firewall Manager WAF policy, the Firewall Manager administrator can define
        /// a set of rule groups to run first in the web ACL and a set of rule groups to run last.
        /// Within each set, the administrator prioritizes the rule groups, to determine their
        /// relative processing order.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<FirewallManagerRuleGroup> PostProcessFirewallManagerRuleGroups
        {
            get { return this._postProcessFirewallManagerRuleGroups; }
            set { this._postProcessFirewallManagerRuleGroups = value; }
        }

        // Check to see if PostProcessFirewallManagerRuleGroups property is set
        internal bool IsSetPostProcessFirewallManagerRuleGroups()
        {
            return this._postProcessFirewallManagerRuleGroups != null && (this._postProcessFirewallManagerRuleGroups.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property PreProcessFirewallManagerRuleGroups. 
        /// <para>
        /// The first set of rules for WAF to process in the web ACL. This is defined in an Firewall
        /// Manager WAF policy and contains only rule group references. You can't alter these.
        /// Any rules and rule groups that you define for the web ACL are prioritized after these.
        /// 
        /// </para>
        ///  
        /// <para>
        /// In the Firewall Manager WAF policy, the Firewall Manager administrator can define
        /// a set of rule groups to run first in the web ACL and a set of rule groups to run last.
        /// Within each set, the administrator prioritizes the rule groups, to determine their
        /// relative processing order.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<FirewallManagerRuleGroup> PreProcessFirewallManagerRuleGroups
        {
            get { return this._preProcessFirewallManagerRuleGroups; }
            set { this._preProcessFirewallManagerRuleGroups = value; }
        }

        // Check to see if PreProcessFirewallManagerRuleGroups property is set
        internal bool IsSetPreProcessFirewallManagerRuleGroups()
        {
            return this._preProcessFirewallManagerRuleGroups != null && (this._preProcessFirewallManagerRuleGroups.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property RetrofittedByFirewallManager. 
        /// <para>
        /// Indicates whether this web ACL was created by a customer account and then retrofitted
        /// by Firewall Manager. If true, then the web ACL is currently being managed by a Firewall
        /// Manager WAF policy, and only Firewall Manager can manage any Firewall Manager rule
        /// groups in the web ACL. See also the properties <c>ManagedByFirewallManager</c>, <c>PreProcessFirewallManagerRuleGroups</c>,
        /// and <c>PostProcessFirewallManagerRuleGroups</c>. 
        /// </para>
        /// </summary>
        public bool? RetrofittedByFirewallManager
        {
            get { return this._retrofittedByFirewallManager; }
            set { this._retrofittedByFirewallManager = value; }
        }

        // Check to see if RetrofittedByFirewallManager property is set
        internal bool IsSetRetrofittedByFirewallManager()
        {
            return this._retrofittedByFirewallManager.HasValue; 
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
        /// Gets and sets the property TokenDomains. 
        /// <para>
        /// Specifies the domains that WAF should accept in a web request token. This enables
        /// the use of tokens across multiple protected websites. When WAF provides a token, it
        /// uses the domain of the Amazon Web Services resource that the web ACL is protecting.
        /// If you don't specify a list of token domains, WAF accepts tokens only for the domain
        /// of the protected resource. With a token domain list, WAF accepts the resource's host
        /// domain plus all domains in the token domain list, including their prefixed subdomains.
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