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
 * Do not modify this file. This file is generated from the amplifybackend-2020-08-11.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.AmplifyBackend.Model
{
    /// <summary>
    /// The settings for using the social identity providers for access to your Amplify app.
    /// </summary>
    public partial class SocialProviderSettings
    {
        private BackendAuthSocialProviderConfig _facebook;
        private BackendAuthSocialProviderConfig _google;
        private BackendAuthSocialProviderConfig _loginWithAmazon;

        /// <summary>
        /// Gets and sets the property Facebook.
        /// </summary>
        public BackendAuthSocialProviderConfig Facebook
        {
            get { return this._facebook; }
            set { this._facebook = value; }
        }

        // Check to see if Facebook property is set
        internal bool IsSetFacebook()
        {
            return this._facebook != null;
        }

        /// <summary>
        /// Gets and sets the property Google.
        /// </summary>
        public BackendAuthSocialProviderConfig Google
        {
            get { return this._google; }
            set { this._google = value; }
        }

        // Check to see if Google property is set
        internal bool IsSetGoogle()
        {
            return this._google != null;
        }

        /// <summary>
        /// Gets and sets the property LoginWithAmazon.
        /// </summary>
        public BackendAuthSocialProviderConfig LoginWithAmazon
        {
            get { return this._loginWithAmazon; }
            set { this._loginWithAmazon = value; }
        }

        // Check to see if LoginWithAmazon property is set
        internal bool IsSetLoginWithAmazon()
        {
            return this._loginWithAmazon != null;
        }

    }
}