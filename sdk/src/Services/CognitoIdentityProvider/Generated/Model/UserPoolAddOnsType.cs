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

namespace Amazon.CognitoIdentityProvider.Model
{
    /// <summary>
    /// User pool add-ons. Contains settings for activation of advanced security features.
    /// To log user security information but take no action, set to <code>AUDIT</code>. To
    /// configure automatic security responses to risky traffic to your user pool, set to
    /// <code>ENFORCED</code>.
    /// 
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/cognito-user-pool-settings-advanced-security.html">Adding
    /// advanced security to a user pool</a>.
    /// </para>
    /// </summary>
    public partial class UserPoolAddOnsType
    {
        private AdvancedSecurityModeType _advancedSecurityMode;

        /// <summary>
        /// Gets and sets the property AdvancedSecurityMode. 
        /// <para>
        /// The operating mode of advanced security features in your user pool.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AdvancedSecurityModeType AdvancedSecurityMode
        {
            get { return this._advancedSecurityMode; }
            set { this._advancedSecurityMode = value; }
        }

        // Check to see if AdvancedSecurityMode property is set
        internal bool IsSetAdvancedSecurityMode()
        {
            return this._advancedSecurityMode != null;
        }

    }
}