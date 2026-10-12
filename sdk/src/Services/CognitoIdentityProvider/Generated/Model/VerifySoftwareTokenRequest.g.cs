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
    /// Container for the parameters to the VerifySoftwareToken operation. Registers the current
    /// user's time-based one-time password (TOTP) authenticator with a code generated in
    /// their authenticator app from a private key that's supplied by your user pool. Marks
    /// the user's software token MFA status as "verified" if successful. The request takes
    /// an access token or a session string, but not both. <note> <para> Amazon Cognito doesn't
    /// evaluate Identity and Access Management (IAM) policies in requests for this API operation.
    /// For this operation, you can't use IAM credentials to authorize requests, and you can't
    /// grant IAM permissions in policies. For more information about authorization models
    /// in Amazon Cognito, see <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/user-pools-API-operations.html">Using
    /// the Amazon Cognito user pools API and user pool endpoints</a>. </para> </note>
    /// </summary>
    public partial class VerifySoftwareTokenRequest : AmazonCognitoIdentityProviderRequest
    {
        /// <summary>
        /// Gets and sets the property AccessToken. 
        /// <para>
        /// A valid access token that Amazon Cognito issued to the currently signed-in user. Must
        /// include a scope claim for <c>aws.cognito.signin.user.admin</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public string AccessToken { get; set; }

        /// <summary>
        /// Checks to see if the AccessToken property is set.
        /// </summary>
        internal bool IsSetAccessToken() => this.AccessToken != null;

        /// <summary>
        /// Gets and sets the property FriendlyDeviceName. 
        /// <para>
        /// A friendly name for the device that's running the TOTP authenticator.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 131072)]
        public string FriendlyDeviceName { get; set; }

        /// <summary>
        /// Checks to see if the FriendlyDeviceName property is set.
        /// </summary>
        internal bool IsSetFriendlyDeviceName() => this.FriendlyDeviceName != null;

        /// <summary>
        /// Gets and sets the property Session. 
        /// <para>
        /// The session ID from an <c>AssociateSoftwareToken</c> request.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 20, Max = 4096)]
        public string Session { get; set; }

        /// <summary>
        /// Checks to see if the Session property is set.
        /// </summary>
        internal bool IsSetSession() => this.Session != null;

        /// <summary>
        /// Gets and sets the property UserCode. 
        /// <para>
        /// A TOTP that the user generated in their configured authenticator app.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 6, Max = 6)]
        public string UserCode { get; set; }

        /// <summary>
        /// Checks to see if the UserCode property is set.
        /// </summary>
        internal bool IsSetUserCode() => this.UserCode != null;
    }
}
