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
    /// A rule statement used to run the rules that are defined in a managed rule group. To
    /// use this, provide the vendor name and the name of the rule group in this statement.
    /// You can retrieve the required names by calling <a>ListAvailableManagedRuleGroups</a>.
    /// 
    ///  
    /// <para>
    /// You cannot nest a <c>ManagedRuleGroupStatement</c>, for example for use inside a <c>NotStatement</c>
    /// or <c>OrStatement</c>. You cannot use a managed rule group inside another rule group.
    /// You can only reference a managed rule group as a top-level statement within a rule
    /// that you define in a web ACL.
    /// </para>
    ///  <note> 
    /// <para>
    /// You are charged additional fees when you use the WAF Bot Control managed rule group
    /// <c>AWSManagedRulesBotControlRuleSet</c>, the WAF Fraud Control account takeover prevention
    /// (ATP) managed rule group <c>AWSManagedRulesATPRuleSet</c>, or the WAF Fraud Control
    /// account creation fraud prevention (ACFP) managed rule group <c>AWSManagedRulesACFPRuleSet</c>.
    /// For more information, see <a href="http://aws.amazon.com/waf/pricing/">WAF Pricing</a>.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class ManagedRuleGroupStatement
    {
        private List<ExcludedRule> _excludedRules = AWSConfigs.InitializeCollections ? new List<ExcludedRule>() : null;
        private List<ManagedRuleGroupConfig> _managedRuleGroupConfigs = AWSConfigs.InitializeCollections ? new List<ManagedRuleGroupConfig>() : null;
        private string _name;
        private List<RuleActionOverride> _ruleActionOverrides = AWSConfigs.InitializeCollections ? new List<RuleActionOverride>() : null;
        private Statement _scopeDownStatement;
        private string _vendorName;
        private string _version;

        /// <summary>
        /// Gets and sets the property ExcludedRules. 
        /// <para>
        /// Rules in the referenced rule group whose actions are set to <c>Count</c>. 
        /// </para>
        ///  <note> 
        /// <para>
        /// Instead of this option, use <c>RuleActionOverrides</c>. It accepts any valid action
        /// setting, including <c>Count</c>.
        /// </para>
        ///  </note>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max=100)]
        public List<ExcludedRule> ExcludedRules
        {
            get { return this._excludedRules; }
            set { this._excludedRules = value; }
        }

        // Check to see if ExcludedRules property is set
        internal bool IsSetExcludedRules()
        {
            return this._excludedRules != null && (this._excludedRules.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ManagedRuleGroupConfigs. 
        /// <para>
        /// Additional information that's used by a managed rule group. Many managed rule groups
        /// don't require this.
        /// </para>
        ///  
        /// <para>
        /// The rule groups used for intelligent threat mitigation require additional configuration:
        /// 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Use the <c>AWSManagedRulesACFPRuleSet</c> configuration object to configure the account
        /// creation fraud prevention managed rule group. The configuration includes the registration
        /// and sign-up pages of your application and the locations in the account creation request
        /// payload of data, such as the user email and phone number fields. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use the <c>AWSManagedRulesAntiDDoSRuleSet</c> configuration object to configure the
        /// anti-DDoS managed rule group. The configuration includes the sensitivity levels to
        /// use in the rules that typically block and challenge requests that might be participating
        /// in DDoS attacks and the specification to use to indicate whether a request can handle
        /// a silent browser challenge. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use the <c>AWSManagedRulesATPRuleSet</c> configuration object to configure the account
        /// takeover prevention managed rule group. The configuration includes the sign-in page
        /// of your application and the locations in the login request payload of data such as
        /// the username and password. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use the <c>AWSManagedRulesBotControlRuleSet</c> configuration object to configure
        /// the protection level that you want the Bot Control rule group to use. 
        /// </para>
        ///  </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ManagedRuleGroupConfig> ManagedRuleGroupConfigs
        {
            get { return this._managedRuleGroupConfigs; }
            set { this._managedRuleGroupConfigs = value; }
        }

        // Check to see if ManagedRuleGroupConfigs property is set
        internal bool IsSetManagedRuleGroupConfigs()
        {
            return this._managedRuleGroupConfigs != null && (this._managedRuleGroupConfigs.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the managed rule group. You use this, along with the vendor name, to identify
        /// the rule group.
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
        /// Gets and sets the property RuleActionOverrides. 
        /// <para>
        /// Action settings to use in the place of the rule actions that are configured inside
        /// the rule group. You specify one override for each rule whose action you want to change.
        /// 
        /// </para>
        ///  <note> 
        /// <para>
        /// Verify the rule names in your overrides carefully. With managed rule groups, WAF silently
        /// ignores any override that uses an invalid rule name. With customer-owned rule groups,
        /// invalid rule names in your overrides will cause web ACL updates to fail. An invalid
        /// rule name is any name that doesn't exactly match the case-sensitive name of an existing
        /// rule in the rule group.
        /// </para>
        ///  </note> 
        /// <para>
        /// You can use overrides for testing, for example you can override all of rule actions
        /// to <c>Count</c> and then monitor the resulting count metrics to understand how the
        /// rule group would handle your web traffic. You can also permanently override some or
        /// all actions, to modify how the rule group manages your web traffic.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max=100)]
        public List<RuleActionOverride> RuleActionOverrides
        {
            get { return this._ruleActionOverrides; }
            set { this._ruleActionOverrides = value; }
        }

        // Check to see if RuleActionOverrides property is set
        internal bool IsSetRuleActionOverrides()
        {
            return this._ruleActionOverrides != null && (this._ruleActionOverrides.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ScopeDownStatement. 
        /// <para>
        /// An optional nested statement that narrows the scope of the web requests that are evaluated
        /// by the managed rule group. Requests are only evaluated by the rule group if they match
        /// the scope-down statement. You can use any nestable <a>Statement</a> in the scope-down
        /// statement, and you can nest statements at any level, the same as you can for a rule
        /// statement. 
        /// </para>
        /// </summary>
        public Statement ScopeDownStatement
        {
            get { return this._scopeDownStatement; }
            set { this._scopeDownStatement = value; }
        }

        // Check to see if ScopeDownStatement property is set
        internal bool IsSetScopeDownStatement()
        {
            return this._scopeDownStatement != null;
        }

        /// <summary>
        /// Gets and sets the property VendorName. 
        /// <para>
        /// The name of the managed rule group vendor. You use this, along with the rule group
        /// name, to identify a rule group.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string VendorName
        {
            get { return this._vendorName; }
            set { this._vendorName = value; }
        }

        // Check to see if VendorName property is set
        internal bool IsSetVendorName()
        {
            return this._vendorName != null;
        }

        /// <summary>
        /// Gets and sets the property Version. 
        /// <para>
        /// The version of the managed rule group to use. If you specify this, the version setting
        /// is fixed until you change it. If you don't specify this, WAF uses the vendor's default
        /// version, and then keeps the version at the vendor's default when the vendor updates
        /// the managed rule group settings. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string Version
        {
            get { return this._version; }
            set { this._version = value; }
        }

        // Check to see if Version property is set
        internal bool IsSetVersion()
        {
            return this._version != null;
        }

    }
}