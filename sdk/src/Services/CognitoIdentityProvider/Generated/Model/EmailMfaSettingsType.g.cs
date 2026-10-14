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

namespace Amazon.CognitoIdentityProvider.Model
{
    /// <summary>
    /// User preferences for multi-factor authentication with email messages. Activates or
    /// deactivates email MFA and sets it as the preferred MFA method when multiple methods
    /// are available. To activate this setting, your user pool must be in the <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/feature-plans-features-essentials.html">
    /// Essentials tier</a> or higher.
    /// </summary>
    public partial class EmailMfaSettingsType
    {
        /// <summary>
        /// Gets and sets the property Enabled. 
        /// <para>
        /// Specifies whether email message MFA is active for a user. When the value of this parameter
        /// is <c>Enabled</c>, the user will be prompted for MFA during all sign-in attempts,
        /// unless device tracking is turned on and the device has been trusted.
        /// </para>
        /// </summary>
        public bool? Enabled { get; set; }

        /// <summary>
        /// Checks to see if the Enabled property is set.
        /// </summary>
        internal bool IsSetEnabled() => this.Enabled.HasValue;

        /// <summary>
        /// Gets and sets the property PreferredMfa. 
        /// <para>
        /// Specifies whether email message MFA is the user's preferred method.
        /// </para>
        /// </summary>
        public bool? PreferredMfa { get; set; }

        /// <summary>
        /// Checks to see if the PreferredMfa property is set.
        /// </summary>
        internal bool IsSetPreferredMfa() => this.PreferredMfa.HasValue;
    }
}
