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
    /// A web ACL defines a collection of rules to use to inspect and control web requests.
    /// Each rule has an action defined (allow, block, or count) for requests that match the
    /// statement of the rule. In the web ACL, you assign a default action to take (allow,
    /// block) for any request that does not match any of the rules. The rules in a web ACL
    /// can be a combination of the types <a>Rule</a>, <a>RuleGroup</a>, and managed rule
    /// group. You can associate a web ACL with one or more Amazon Web Services resources
    /// to protect. The resources can be an Amazon CloudFront distribution, an Amazon API
    /// Gateway REST API, an Application Load Balancer, an AppSync GraphQL API, Amazon Cognito
    /// user pool, or an App Runner service.
    /// </summary>
    public partial class WebACL
    {
        private string _arn;
        private long? _capacity;
        private CaptchaConfig _captchaConfig;
        private ChallengeConfig _challengeConfig;
        private Dictionary<string, CustomResponseBody> _customResponseBodies = new Dictionary<string, CustomResponseBody>();
        private DefaultAction _defaultAction;
        private string _description;
        private string _id;
        private string _labelNamespace;
        private bool? _managedByFirewallManager;
        private string _name;
        private List<FirewallManagerRuleGroup> _postProcessFirewallManagerRuleGroups = new List<FirewallManagerRuleGroup>();
        private List<FirewallManagerRuleGroup> _preProcessFirewallManagerRuleGroups = new List<FirewallManagerRuleGroup>();
        private List<Rule> _rules = new List<Rule>();
        private List<string> _tokenDomains = new List<string>();
        private VisibilityConfig _visibilityConfig;

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
        /// when they use a rule group. The WCU limit for web ACLs is 1,500. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public long Capacity
        {
            get { return this._capacity.GetValueOrDefault(); }
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
        /// Gets and sets the property Id. 
        /// <para>
        /// A unique identifier for the <code>WebACL</code>. This ID is returned in the responses
        /// to create and list commands. You use this ID to do things like get, update, and delete
        /// a <code>WebACL</code>.
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
        ///  <code>awswaf:&lt;account ID&gt;:webacl:&lt;web ACL name&gt;:</code> 
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
        ///  <code>&lt;label namespace&gt;:&lt;label from rule&gt;</code> 
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
        /// Indicates whether this web ACL is managed by Firewall Manager. If true, then only
        /// Firewall Manager can delete the web ACL or any Firewall Manager rule groups in the
        /// web ACL. 
        /// </para>
        /// </summary>
        public bool ManagedByFirewallManager
        {
            get { return this._managedByFirewallManager.GetValueOrDefault(); }
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
        /// </summary>
        public List<FirewallManagerRuleGroup> PostProcessFirewallManagerRuleGroups
        {
            get { return this._postProcessFirewallManagerRuleGroups; }
            set { this._postProcessFirewallManagerRuleGroups = value; }
        }

        // Check to see if PostProcessFirewallManagerRuleGroups property is set
        internal bool IsSetPostProcessFirewallManagerRuleGroups()
        {
            return this._postProcessFirewallManagerRuleGroups != null && this._postProcessFirewallManagerRuleGroups.Count > 0; 
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
        /// </summary>
        public List<FirewallManagerRuleGroup> PreProcessFirewallManagerRuleGroups
        {
            get { return this._preProcessFirewallManagerRuleGroups; }
            set { this._preProcessFirewallManagerRuleGroups = value; }
        }

        // Check to see if PreProcessFirewallManagerRuleGroups property is set
        internal bool IsSetPreProcessFirewallManagerRuleGroups()
        {
            return this._preProcessFirewallManagerRuleGroups != null && this._preProcessFirewallManagerRuleGroups.Count > 0; 
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
        /// Gets and sets the property TokenDomains. 
        /// <para>
        /// Specifies the domains that WAF should accept in a web request token. This enables
        /// the use of tokens across multiple protected websites. When WAF provides a token, it
        /// uses the domain of the Amazon Web Services resource that the web ACL is protecting.
        /// If you don't specify a list of token domains, WAF accepts tokens only for the domain
        /// of the protected resource. With a token domain list, WAF accepts the resource's host
        /// domain plus all domains in the token domain list, including their prefixed subdomains.
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