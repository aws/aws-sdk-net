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
    /// Additional information that's used by a managed rule group. Most managed rule groups
    /// don't require this.
    /// 
    ///  
    /// <para>
    /// Use this for the account takeover prevention managed rule group <code>AWSManagedRulesATPRuleSet</code>,
    /// to provide information about the sign-in page of your application. 
    /// </para>
    ///  
    /// <para>
    /// You can provide multiple individual <code>ManagedRuleGroupConfig</code> objects for
    /// any rule group configuration, for example <code>UsernameField</code> and <code>PasswordField</code>.
    /// The configuration that you provide depends on the needs of the managed rule group.
    /// For the ATP managed rule group, you provide the following individual configuration
    /// objects: <code>LoginPath</code>, <code>PasswordField</code>, <code>PayloadType</code>
    /// and <code>UsernameField</code>.
    /// </para>
    /// </summary>
    public partial class ManagedRuleGroupConfig
    {
        private string _loginPath;
        private PasswordField _passwordField;
        private PayloadType _payloadType;
        private UsernameField _usernameField;

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