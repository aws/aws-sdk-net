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
    /// The type used for enabling SMS multi-factor authentication (MFA) at the user level.
    /// Phone numbers don't need to be verified to be used for SMS MFA. If an MFA type is
    /// activated for a user, the user will be prompted for MFA during all sign-in attempts,
    /// unless device tracking is turned on and the device has been trusted. If you would
    /// like MFA to be applied selectively based on the assessed risk level of sign-in attempts,
    /// deactivate MFA for users and turn on Adaptive Authentication for the user pool.
    /// </summary>
    public partial class SMSMfaSettingsType
    {
        private bool? _enabled;
        private bool? _preferredMfa;

        /// <summary>
        /// Gets and sets the property Enabled. 
        /// <para>
        /// Specifies whether SMS message MFA is activated. If an MFA type is activated for a
        /// user, the user will be prompted for MFA during all sign-in attempts, unless device
        /// tracking is turned on and the device has been trusted.
        /// </para>
        /// </summary>
        public bool Enabled
        {
            get { return this._enabled.GetValueOrDefault(); }
            set { this._enabled = value; }
        }

        // Check to see if Enabled property is set
        internal bool IsSetEnabled()
        {
            return this._enabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PreferredMfa. 
        /// <para>
        /// Specifies whether SMS is the preferred MFA method.
        /// </para>
        /// </summary>
        public bool PreferredMfa
        {
            get { return this._preferredMfa.GetValueOrDefault(); }
            set { this._preferredMfa = value; }
        }

        // Check to see if PreferredMfa property is set
        internal bool IsSetPreferredMfa()
        {
            return this._preferredMfa.HasValue; 
        }

    }
}