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
    /// Additional information that's used by a managed rule group. Many managed rule groups
    /// don't require this.
    /// 
    ///  
    /// <para>
    /// Use the <code>AWSManagedRulesBotControlRuleSet</code> configuration object to configure
    /// the protection level that you want the Bot Control rule group to use. 
    /// </para>
    ///  
    /// <para>
    /// For example specifications, see the examples section of <a>CreateWebACL</a>.
    /// </para>
    /// </summary>
    public partial class ManagedRuleGroupConfig
    {
        private AWSManagedRulesBotControlRuleSet _awsManagedRulesBotControlRuleSet;
        private string _loginPath;
        private PasswordField _passwordField;
        private PayloadType _payloadType;
        private UsernameField _usernameField;

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
        /// Gets and sets the property LoginPath. 
        /// <para>
        /// The path of the login endpoint for your application. For example, for the URL <code>https://example.com/web/login</code>,
        /// you would provide the path <code>/web/login</code>.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property PasswordField. 
        /// <para>
        /// Details about your login page password field. 
        /// </para>
        /// </summary>
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
        /// Gets and sets the property PayloadType. 
        /// <para>
        /// The payload type for your login endpoint, either JSON or form encoded.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property UsernameField. 
        /// <para>
        /// Details about your login page username field. 
        /// </para>
        /// </summary>
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