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
    /// Settings for authentication (MFA) with passkey, or webauthN, biometric and security-key
    /// devices in a user pool. Configures the following:
    /// 
    ///  <ul> <li> 
    /// <para>
    /// Configuration for requiring user-verification support in passkeys.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The user pool relying-party ID. This is the domain, typically your user pool domain,
    /// that user's passkey providers should trust as a receiver of passkey authentication.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The providers that you want to allow as origins for passkey authentication.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class WebAuthnConfigurationType
    {
        private string _relyingPartyId;
        private UserVerificationType _userVerification;

        /// <summary>
        /// Gets and sets the property RelyingPartyId. 
        /// <para>
        /// Sets or displays the authentication domain, typically your user pool domain, that
        /// passkey providers must use as a relying party (RP) in their configuration.
        /// </para>
        ///  
        /// <para>
        /// Under the following conditions, the passkey relying party ID must be the fully-qualified
        /// domain name of your custom domain:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The user pool is configured for passkey authentication.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The user pool has a custom domain, whether or not it also has a prefix domain.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your application performs authentication with managed login or the classic hosted
        /// UI.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Min=1, Max=127)]
        public string RelyingPartyId
        {
            get { return this._relyingPartyId; }
            set { this._relyingPartyId = value; }
        }

        // Check to see if RelyingPartyId property is set
        internal bool IsSetRelyingPartyId()
        {
            return this._relyingPartyId != null;
        }

        /// <summary>
        /// Gets and sets the property UserVerification. 
        /// <para>
        /// When <c>required</c>, users can only register and sign in users with passkeys that
        /// are capable of <a href="https://www.w3.org/TR/webauthn-2/#enum-userVerificationRequirement">user
        /// verification</a>. When <c>preferred</c>, your user pool doesn't require the use of
        /// authenticators with user verification but encourages it.
        /// </para>
        /// </summary>
        public UserVerificationType UserVerification
        {
            get { return this._userVerification; }
            set { this._userVerification = value; }
        }

        // Check to see if UserVerification property is set
        internal bool IsSetUserVerification()
        {
            return this._userVerification != null;
        }

    }
}