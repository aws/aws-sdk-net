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

namespace Amazon.SSOOIDC.Model
{
    /// <summary>
    /// This is the response object from the CreateTokenWithIAM operation.
    /// </summary>
    public partial class CreateTokenWithIAMResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property AccessToken. 
        /// <para>
        /// A bearer token to access Amazon Web Services accounts and applications assigned to
        /// a user.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public string AccessToken { get; set; }

        /// <summary>
        /// Checks to see if the AccessToken property is set.
        /// </summary>
        internal bool IsSetAccessToken() => this.AccessToken != null;

        /// <summary>
        /// Gets and sets the property AwsAdditionalDetails. 
        /// <para>
        /// A structure containing information from IAM Identity Center managed user and group
        /// information.
        /// </para>
        /// </summary>
        public AwsAdditionalDetails AwsAdditionalDetails { get; set; }

        /// <summary>
        /// Checks to see if the AwsAdditionalDetails property is set.
        /// </summary>
        internal bool IsSetAwsAdditionalDetails() => this.AwsAdditionalDetails != null;

        /// <summary>
        /// Gets and sets the property ExpiresIn. 
        /// <para>
        /// Indicates the time in seconds when an access token will expire.
        /// </para>
        /// </summary>
        public int? ExpiresIn { get; set; }

        /// <summary>
        /// Checks to see if the ExpiresIn property is set.
        /// </summary>
        internal bool IsSetExpiresIn() => this.ExpiresIn.HasValue;

        /// <summary>
        /// Gets and sets the property IdToken. 
        /// <para>
        /// A JSON Web Token (JWT) that identifies the user associated with the issued access
        /// token. 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public string IdToken { get; set; }

        /// <summary>
        /// Checks to see if the IdToken property is set.
        /// </summary>
        internal bool IsSetIdToken() => this.IdToken != null;

        /// <summary>
        /// Gets and sets the property IssuedTokenType. 
        /// <para>
        /// Indicates the type of tokens that are issued by IAM Identity Center. The following
        /// values are supported: 
        /// </para>
        ///  
        /// <para>
        /// * Access Token - <c>urn:ietf:params:oauth:token-type:access_token</c> 
        /// </para>
        ///  
        /// <para>
        /// * Refresh Token - <c>urn:ietf:params:oauth:token-type:refresh_token</c> 
        /// </para>
        /// </summary>
        public string IssuedTokenType { get; set; }

        /// <summary>
        /// Checks to see if the IssuedTokenType property is set.
        /// </summary>
        internal bool IsSetIssuedTokenType() => this.IssuedTokenType != null;

        /// <summary>
        /// Gets and sets the property RefreshToken. 
        /// <para>
        /// A token that, if present, can be used to refresh a previously issued access token
        /// that might have expired.
        /// </para>
        ///  
        /// <para>
        /// For more information about the features and limitations of the current IAM Identity
        /// Center OIDC implementation, see <i>Considerations for Using this Guide</i> in the
        /// <a href="https://docs.aws.amazon.com/singlesignon/latest/OIDCAPIReference/Welcome.html">IAM
        /// Identity Center OIDC API Reference</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public string RefreshToken { get; set; }

        /// <summary>
        /// Checks to see if the RefreshToken property is set.
        /// </summary>
        internal bool IsSetRefreshToken() => this.RefreshToken != null;

        /// <summary>
        /// Gets and sets the property Scope. 
        /// <para>
        /// The list of scopes for which authorization is granted. The access token that is issued
        /// is limited to the scopes that are granted.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Scope { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Scope property is set.
        /// </summary>
        internal bool IsSetScope() => this.Scope != null && (this.Scope.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TokenType. 
        /// <para>
        /// Used to notify the requester that the returned token is an access token. The supported
        /// token type is <c>Bearer</c>.
        /// </para>
        /// </summary>
        public string TokenType { get; set; }

        /// <summary>
        /// Checks to see if the TokenType property is set.
        /// </summary>
        internal bool IsSetTokenType() => this.TokenType != null;
    }
}
