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
    /// The criteria for inspecting login requests, used by the ATP rule group to validate
    /// credentials usage. 
    /// 
    ///  
    /// <para>
    /// This is part of the <c>AWSManagedRulesATPRuleSet</c> configuration in <c>ManagedRuleGroupConfig</c>.
    /// </para>
    ///  
    /// <para>
    /// In these settings, you specify how your application accepts login attempts by providing
    /// the request payload type and the names of the fields within the request body where
    /// the username and password are provided. 
    /// </para>
    /// </summary>
    public partial class RequestInspection
    {
        private PasswordField _passwordField;
        private PayloadType _payloadType;
        private UsernameField _usernameField;

        /// <summary>
        /// Gets and sets the property PasswordField. 
        /// <para>
        /// The name of the field in the request payload that contains your customer's password.
        /// 
        /// </para>
        ///  
        /// <para>
        /// How you specify this depends on the request inspection payload type.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// For JSON payloads, specify the field name in JSON pointer syntax. For information
        /// about the JSON Pointer syntax, see the Internet Engineering Task Force (IETF) documentation
        /// <a href="https://tools.ietf.org/html/rfc6901">JavaScript Object Notation (JSON) Pointer</a>.
        /// 
        /// </para>
        ///  
        /// <para>
        /// For example, for the JSON payload <c>{ "form": { "password": "THE_PASSWORD" } }</c>,
        /// the password field specification is <c>/form/password</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For form encoded payload types, use the HTML form names.
        /// </para>
        ///  
        /// <para>
        /// For example, for an HTML form with the input element named <c>password1</c>, the password
        /// field specification is <c>password1</c>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
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
        [AWSProperty(Required=true)]
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
        /// The name of the field in the request payload that contains your customer's username.
        /// 
        /// </para>
        ///  
        /// <para>
        /// How you specify this depends on the request inspection payload type.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// For JSON payloads, specify the field name in JSON pointer syntax. For information
        /// about the JSON Pointer syntax, see the Internet Engineering Task Force (IETF) documentation
        /// <a href="https://tools.ietf.org/html/rfc6901">JavaScript Object Notation (JSON) Pointer</a>.
        /// 
        /// </para>
        ///  
        /// <para>
        /// For example, for the JSON payload <c>{ "form": { "username": "THE_USERNAME" } }</c>,
        /// the username field specification is <c>/form/username</c>. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For form encoded payload types, use the HTML form names.
        /// </para>
        ///  
        /// <para>
        /// For example, for an HTML form with the input element named <c>username1</c>, the username
        /// field specification is <c>username1</c> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
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