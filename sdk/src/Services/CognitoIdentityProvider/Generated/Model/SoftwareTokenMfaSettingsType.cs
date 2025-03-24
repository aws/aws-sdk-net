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
    /// A user's preference for using time-based one-time password (TOTP) multi-factor authentication
    /// (MFA). Turns TOTP MFA on and off, and can set TOTP as preferred when other MFA options
    /// are available. You can't turn off TOTP MFA for any of your users when MFA is required
    /// in your user pool; you can only set the type that your user prefers.
    /// </summary>
    public partial class SoftwareTokenMfaSettingsType
    {
        private bool? _enabled;
        private bool? _preferredMfa;

        /// <summary>
        /// Gets and sets the property Enabled. 
        /// <para>
        /// Specifies whether software token MFA is activated. If an MFA type is activated for
        /// a user, the user will be prompted for MFA during all sign-in attempts, unless device
        /// tracking is turned on and the device has been trusted.
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

        /// <summary>
        /// Gets and sets the property PreferredMfa. 
        /// <para>
        /// Specifies whether software token MFA is the preferred MFA method.
        /// </para>
        /// </summary>
        public bool? PreferredMfa
        {
            get { return this._preferredMfa; }
            set { this._preferredMfa = value; }
        }

        // Check to see if PreferredMfa property is set
        internal bool IsSetPreferredMfa()
        {
            return this._preferredMfa.HasValue; 
        }

    }
}