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

namespace Amazon.AmplifyBackend.Model
{
    /// <summary>
    /// The settings for using the social identity providers for access to your Amplify app.
    /// </summary>
    public partial class SocialProviderSettings
    {
        /// <summary>
        /// Gets and sets the property Facebook.
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public BackendAuthSocialProviderConfig Facebook { get; set; }

        /// <summary>
        /// Checks to see if the Facebook property is set.
        /// </summary>
        internal bool IsSetFacebook() => this.Facebook != null;

        /// <summary>
        /// Gets and sets the property Google.
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public BackendAuthSocialProviderConfig Google { get; set; }

        /// <summary>
        /// Checks to see if the Google property is set.
        /// </summary>
        internal bool IsSetGoogle() => this.Google != null;

        /// <summary>
        /// Gets and sets the property LoginWithAmazon.
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public BackendAuthSocialProviderConfig LoginWithAmazon { get; set; }

        /// <summary>
        /// Checks to see if the LoginWithAmazon property is set.
        /// </summary>
        internal bool IsSetLoginWithAmazon() => this.LoginWithAmazon != null;

        /// <summary>
        /// Gets and sets the property SignInWithApple.
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public BackendAuthAppleProviderConfig SignInWithApple { get; set; }

        /// <summary>
        /// Checks to see if the SignInWithApple property is set.
        /// </summary>
        internal bool IsSetSignInWithApple() => this.SignInWithApple != null;
    }
}
