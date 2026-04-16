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
 * Do not modify this file. This file is generated from the cognito-idp-2016-04-18.normal.json service model.
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
namespace Amazon.CognitoIdentityProvider.Model
{
    /// <summary>
    /// A user's preference for using passkey, or WebAuthn, multi-factor authentication (MFA).
    /// Turns passkey MFA on and off for the user. Unlike other MFA settings types, this type
    /// doesn't include a <c>PreferredMfa</c> option because passkey MFA applies only when
    /// passkey is the first authentication factor.
    /// </summary>
    public partial class WebAuthnMfaSettingsType
    {
        private bool? _enabled;

        /// <summary>
        /// Gets and sets the property Enabled. 
        /// <para>
        /// Specifies whether passkey MFA is activated for a user. When activated, the user's
        /// passkey authentication requires user verification, and passkey sign-in is available
        /// when MFA is required. The user must also have at least one other MFA method such as
        /// SMS, TOTP, or email activated to prevent account lockout.
        /// </para>
        /// </summary>
        public bool? Enabled
        {
            get { return this._enabled; }
            set { this._enabled = value; }
        }

        // Check to see if Enabled property is set
        internal bool IsSetEnabled()
        {
            return this._enabled.HasValue; 
        }

    }
}