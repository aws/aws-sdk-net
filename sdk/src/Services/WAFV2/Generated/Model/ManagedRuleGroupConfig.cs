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
    /// Additional information that's used by a managed rule group. Many managed rule groups
    /// don't require this.
    /// 
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
    /// <para>
    /// For example specifications, see the examples section of <a>CreateWebACL</a>.
    /// </para>
    /// </summary>
    public partial class ManagedRuleGroupConfig
    {
        private AWSManagedRulesACFPRuleSet _awsManagedRulesACFPRuleSet;
        private AWSManagedRulesAntiDDoSRuleSet _awsManagedRulesAntiDDoSRuleSet;
        private AWSManagedRulesATPRuleSet _awsManagedRulesATPRuleSet;
        private AWSManagedRulesBotControlRuleSet _awsManagedRulesBotControlRuleSet;
        private string _loginPath;
        private PasswordField _passwordField;
        private PayloadType _payloadType;
        private UsernameField _usernameField;

        /// <summary>
        /// Gets and sets the property AWSManagedRulesACFPRuleSet. 
        /// <para>
        /// Additional configuration for using the account creation fraud prevention (ACFP) managed
        /// rule group, <c>AWSManagedRulesACFPRuleSet</c>. Use this to provide account creation
        /// request information to the rule group. For web ACLs that protect CloudFront distributions,
        /// use this to also provide the information about how your distribution responds to account
        /// creation requests. 
        /// </para>
        ///  
        /// <para>
        /// For information about using the ACFP managed rule group, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/aws-managed-rule-groups-acfp.html">WAF
        /// Fraud Control account creation fraud prevention (ACFP) rule group</a> and <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-acfp.html">WAF
        /// Fraud Control account creation fraud prevention (ACFP)</a> in the <i>WAF Developer
        /// Guide</i>.
        /// </para>
        /// </summary>
        public AWSManagedRulesACFPRuleSet AWSManagedRulesACFPRuleSet
        {
            get { return this._awsManagedRulesACFPRuleSet; }
            set { this._awsManagedRulesACFPRuleSet = value; }
        }

        // Check to see if AWSManagedRulesACFPRuleSet property is set
        internal bool IsSetAWSManagedRulesACFPRuleSet()
        {
            return this._awsManagedRulesACFPRuleSet != null;
        }

        /// <summary>
        /// Gets and sets the property AWSManagedRulesAntiDDoSRuleSet. 
        /// <para>
        /// Additional configuration for using the anti-DDoS managed rule group, <c>AWSManagedRulesAntiDDoSRuleSet</c>.
        /// Use this to configure anti-DDoS behavior for the rule group. 
        /// </para>
        ///  
        /// <para>
        /// For information about using the anti-DDoS managed rule group, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/aws-managed-rule-groups-anti-ddos.html">WAF
        /// Anti-DDoS rule group</a> and <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-anti-ddos.html">Distributed
        /// Denial of Service (DDoS) prevention</a> in the <i>WAF Developer Guide</i>.
        /// </para>
        /// </summary>
        public AWSManagedRulesAntiDDoSRuleSet AWSManagedRulesAntiDDoSRuleSet
        {
            get { return this._awsManagedRulesAntiDDoSRuleSet; }
            set { this._awsManagedRulesAntiDDoSRuleSet = value; }
        }

        // Check to see if AWSManagedRulesAntiDDoSRuleSet property is set
        internal bool IsSetAWSManagedRulesAntiDDoSRuleSet()
        {
            return this._awsManagedRulesAntiDDoSRuleSet != null;
        }

        /// <summary>
        /// Gets and sets the property AWSManagedRulesATPRuleSet. 
        /// <para>
        /// Additional configuration for using the account takeover prevention (ATP) managed rule
        /// group, <c>AWSManagedRulesATPRuleSet</c>. Use this to provide login request information
        /// to the rule group. For web ACLs that protect CloudFront distributions, use this to
        /// also provide the information about how your distribution responds to login requests.
        /// 
        /// </para>
        ///  
        /// <para>
        /// This configuration replaces the individual configuration fields in <c>ManagedRuleGroupConfig</c>
        /// and provides additional feature configuration. 
        /// </para>
        ///  
        /// <para>
        /// For information about using the ATP managed rule group, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/aws-managed-rule-groups-atp.html">WAF
        /// Fraud Control account takeover prevention (ATP) rule group</a> and <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-atp.html">WAF
        /// Fraud Control account takeover prevention (ATP)</a> in the <i>WAF Developer Guide</i>.
        /// </para>
        /// </summary>
        public AWSManagedRulesATPRuleSet AWSManagedRulesATPRuleSet
        {
            get { return this._awsManagedRulesATPRuleSet; }
            set { this._awsManagedRulesATPRuleSet = value; }
        }

        // Check to see if AWSManagedRulesATPRuleSet property is set
        internal bool IsSetAWSManagedRulesATPRuleSet()
        {
            return this._awsManagedRulesATPRuleSet != null;
        }

        /// <summary>
        /// Gets and sets the property AWSManagedRulesBotControlRuleSet. 
        /// <para>
        /// Additional configuration for using the Bot Control managed rule group. Use this to
        /// specify the inspection level that you want to use. For information about using the
        /// Bot Control managed rule group, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/aws-managed-rule-groups-bot.html">WAF
        /// Bot Control rule group</a> and <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-bot-control.html">WAF
        /// Bot Control</a> in the <i>WAF Developer Guide</i>.
        /// </para>
        /// </summary>
        public AWSManagedRulesBotControlRuleSet AWSManagedRulesBotControlRuleSet
        {
            get { return this._awsManagedRulesBotControlRuleSet; }
            set { this._awsManagedRulesBotControlRuleSet = value; }
        }

        // Check to see if AWSManagedRulesBotControlRuleSet property is set
        internal bool IsSetAWSManagedRulesBotControlRuleSet()
        {
            return this._awsManagedRulesBotControlRuleSet != null;
        }

        /// <summary>
        /// Gets and sets the property LoginPath. <note> 
        /// <para>
        /// Instead of this setting, provide your configuration under <c>AWSManagedRulesATPRuleSet</c>.
        /// 
        /// </para>
        ///  </note>
        /// </summary>
        [Obsolete("Deprecated. Use AWSManagedRulesATPRuleSet LoginPath")]
        [AWSProperty(Min=1, Max=256)]
        public string LoginPath
        {
            get { return this._loginPath; }
            set { this._loginPath = value; }
        }

        // Check to see if LoginPath property is set
        internal bool IsSetLoginPath()
        {
            return this._loginPath != null;
        }

        /// <summary>
        /// Gets and sets the property PasswordField. <note> 
        /// <para>
        /// Instead of this setting, provide your configuration under the request inspection configuration
        /// for <c>AWSManagedRulesATPRuleSet</c> or <c>AWSManagedRulesACFPRuleSet</c>. 
        /// </para>
        ///  </note>
        /// </summary>
        [Obsolete("Deprecated. Use AWSManagedRulesATPRuleSet RequestInspection PasswordField")]
        public PasswordField PasswordField
        {
            get { return this._passwordField; }
            set { this._passwordField = value; }
        }

        // Check to see if PasswordField property is set
        internal bool IsSetPasswordField()
        {
            return this._passwordField != null;
        }

        /// <summary>
        /// Gets and sets the property PayloadType. <note> 
        /// <para>
        /// Instead of this setting, provide your configuration under the request inspection configuration
        /// for <c>AWSManagedRulesATPRuleSet</c> or <c>AWSManagedRulesACFPRuleSet</c>. 
        /// </para>
        ///  </note>
        /// </summary>
        [Obsolete("Deprecated. Use AWSManagedRulesATPRuleSet RequestInspection PayloadType")]
        public PayloadType PayloadType
        {
            get { return this._payloadType; }
            set { this._payloadType = value; }
        }

        // Check to see if PayloadType property is set
        internal bool IsSetPayloadType()
        {
            return this._payloadType != null;
        }

        /// <summary>
        /// Gets and sets the property UsernameField. <note> 
        /// <para>
        /// Instead of this setting, provide your configuration under the request inspection configuration
        /// for <c>AWSManagedRulesATPRuleSet</c> or <c>AWSManagedRulesACFPRuleSet</c>. 
        /// </para>
        ///  </note>
        /// </summary>
        [Obsolete("Deprecated. Use AWSManagedRulesATPRuleSet RequestInspection UsernameField")]
        public UsernameField UsernameField
        {
            get { return this._usernameField; }
            set { this._usernameField = value; }
        }

        // Check to see if UsernameField property is set
        internal bool IsSetUsernameField()
        {
            return this._usernameField != null;
        }

    }
}