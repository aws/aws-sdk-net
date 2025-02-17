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
    /// This is the response object from the GetUserAuthFactors operation.
    /// </summary>
    public partial class GetUserAuthFactorsResponse : AmazonWebServiceResponse
    {
        private List<string> _configuredUserAuthFactors = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _preferredMfaSetting;
        private List<string> _userMFASettingList = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _username;

        /// <summary>
        /// Gets and sets the property ConfiguredUserAuthFactors. 
        /// <para>
        /// The authentication types that are available to the user with <c>USER_AUTH</c> sign-in.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=8)]
        public List<string> ConfiguredUserAuthFactors
        {
            get { return this._configuredUserAuthFactors; }
            set { this._configuredUserAuthFactors = value; }
        }

        // Check to see if ConfiguredUserAuthFactors property is set
        internal bool IsSetConfiguredUserAuthFactors()
        {
            return this._configuredUserAuthFactors != null && (this._configuredUserAuthFactors.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property PreferredMfaSetting. 
        /// <para>
        /// The user's preferred MFA setting.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=131072)]
        public string PreferredMfaSetting
        {
            get { return this._preferredMfaSetting; }
            set { this._preferredMfaSetting = value; }
        }

        // Check to see if PreferredMfaSetting property is set
        internal bool IsSetPreferredMfaSetting()
        {
            return this._preferredMfaSetting != null;
        }

        /// <summary>
        /// Gets and sets the property UserMFASettingList. 
        /// <para>
        /// The MFA options that are activated for the user. The possible values in this list
        /// are <c>SMS_MFA</c>, <c>EMAIL_OTP</c>, and <c>SOFTWARE_TOKEN_MFA</c>.
        /// </para>
        /// </summary>
        public List<string> UserMFASettingList
        {
            get { return this._userMFASettingList; }
            set { this._userMFASettingList = value; }
        }

        // Check to see if UserMFASettingList property is set
        internal bool IsSetUserMFASettingList()
        {
            return this._userMFASettingList != null && (this._userMFASettingList.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Username. 
        /// <para>
        /// The username of the currently sign-in user.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=1, Max=128)]
        public string Username
        {
            get { return this._username; }
            set { this._username = value; }
        }

        // Check to see if Username property is set
        internal bool IsSetUsername()
        {
            return this._username != null;
        }

    }
}