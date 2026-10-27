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

namespace Amazon.Lightsail.Model
{
    /// <summary>
    /// Describes the configuration of the account takeover prevention Web Application Firewall
    /// (WAF) rule group. The rule group inspects login requests to the login path of your
    /// application.
    /// </summary>
    public partial class WafAtpConfig
    {
        /// <summary>
        /// Gets and sets the property LoginPath. 
        /// <para>
        /// The path of the login endpoint of your application (for example, <c>/login</c>). Login
        /// paths that start with the path that you specify are a match.
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Must start with a forward slash (<c>/</c>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Must contain from 1 to 256 characters.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string LoginPath { get; set; }

        /// <summary>
        /// Checks to see if the LoginPath property is set.
        /// </summary>
        internal bool IsSetLoginPath() => this.LoginPath != null;

        /// <summary>
        /// Gets and sets the property PasswordField. 
        /// <para>
        /// The name of the field in the request body that contains the password (for example,
        /// <c>/password</c> for <c>JSON</c> or <c>password</c> for <c>FORM_ENCODED</c>).
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// For a <c>JSON</c> payload, must be a JSON pointer that starts with a forward slash
        /// (<c>/</c>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Must contain from 1 to 512 characters.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string PasswordField { get; set; }

        /// <summary>
        /// Checks to see if the PasswordField property is set.
        /// </summary>
        internal bool IsSetPasswordField() => this.PasswordField != null;

        /// <summary>
        /// Gets and sets the property PayloadType. 
        /// <para>
        /// The content type of the request body of login requests.
        /// </para>
        ///  
        /// <para>
        /// The following content types are possible:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>JSON</c> – The request body is in JSON format.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>FORM_ENCODED</c> – The request body is form encoded.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public WafPayloadTypeEnum PayloadType { get; set; }

        /// <summary>
        /// Checks to see if the PayloadType property is set.
        /// </summary>
        internal bool IsSetPayloadType() => this.PayloadType != null;

        /// <summary>
        /// Gets and sets the property ResponseInspection. 
        /// <para>
        /// An object that describes the HTTP status codes that your application returns for successful
        /// and failed login attempts.
        /// </para>
        /// </summary>
        public WafResponseInspection ResponseInspection { get; set; }

        /// <summary>
        /// Checks to see if the ResponseInspection property is set.
        /// </summary>
        internal bool IsSetResponseInspection() => this.ResponseInspection != null;

        /// <summary>
        /// Gets and sets the property UsernameField. 
        /// <para>
        /// The name of the field in the request body that contains the username (for example,
        /// <c>/username</c> for <c>JSON</c> or <c>username</c> for <c>FORM_ENCODED</c>).
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// For a <c>JSON</c> payload, must be a JSON pointer that starts with a forward slash
        /// (<c>/</c>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Must contain from 1 to 512 characters.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string UsernameField { get; set; }

        /// <summary>
        /// Checks to see if the UsernameField property is set.
        /// </summary>
        internal bool IsSetUsernameField() => this.UsernameField != null;
    }
}
