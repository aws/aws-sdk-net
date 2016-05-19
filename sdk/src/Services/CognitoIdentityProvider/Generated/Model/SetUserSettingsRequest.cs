/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CognitoIdentityProvider.Model
{
    /// <summary>
    /// Container for the parameters to the SetUserSettings operation.
    /// Sets the user settings like multi-factor authentication (MFA). If MFA is to be removed
    /// for a particular attribute pass the attribute with code delivery as null. If null
    /// list is passed, all MFA options are removed.
    /// </summary>
    public partial class SetUserSettingsRequest : AmazonCognitoIdentityProviderRequest
    {
        private string _accessToken;
        private List<MFAOptionType> _mfaOptions = new List<MFAOptionType>();

        /// <summary>
        /// Gets and sets the property AccessToken. 
        /// <para>
        /// The access token for the set user settings request.
        /// </para>
        /// </summary>
        public string AccessToken
        {
            get { return this._accessToken; }
            set { this._accessToken = value; }
        }

        // Check to see if AccessToken property is set
        internal bool IsSetAccessToken()
        {
            return this._accessToken != null;
        }

        /// <summary>
        /// Gets and sets the property MFAOptions. 
        /// <para>
        /// Specifies the options for MFA (e.g., email or phone number).
        /// </para>
        /// </summary>
        public List<MFAOptionType> MFAOptions
        {
            get { return this._mfaOptions; }
            set { this._mfaOptions = value; }
        }

        // Check to see if MFAOptions property is set
        internal bool IsSetMFAOptions()
        {
            return this._mfaOptions != null && this._mfaOptions.Count > 0; 
        }

    }
}