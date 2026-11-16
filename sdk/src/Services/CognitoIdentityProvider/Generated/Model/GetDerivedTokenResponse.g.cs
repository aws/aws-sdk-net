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
    /// This is the response object from the GetDerivedToken operation.
    /// </summary>
    public partial class GetDerivedTokenResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property ExpiresIn. 
        /// <para>
        /// The number of seconds until the issued token expires.
        /// </para>
        /// </summary>
        public int? ExpiresIn { get; set; }

        /// <summary>
        /// Checks to see if the ExpiresIn property is set.
        /// </summary>
        internal bool IsSetExpiresIn() => this.ExpiresIn.HasValue;

        /// <summary>
        /// Gets and sets the property IssuedToken. 
        /// <para>
        /// The token that Amazon Cognito issued in response to the token exchange request.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true)]
        public string IssuedToken { get; set; }

        /// <summary>
        /// Checks to see if the IssuedToken property is set.
        /// </summary>
        internal bool IsSetIssuedToken() => this.IssuedToken != null;

        /// <summary>
        /// Gets and sets the property IssuedTokenType. 
        /// <para>
        /// The type of the token in the <c>IssuedToken</c> parameter. Valid values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>ACCESS_TOKEN</c> – The issued token is an access token.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ID_TOKEN</c> – The issued token is an ID token.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required = true)]
        public IssuedTokenTypeIdentifierType IssuedTokenType { get; set; }

        /// <summary>
        /// Checks to see if the IssuedTokenType property is set.
        /// </summary>
        internal bool IsSetIssuedTokenType() => this.IssuedTokenType != null;

        /// <summary>
        /// Gets and sets the property Scopes. 
        /// <para>
        /// The scopes that Amazon Cognito granted in the issued token.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 50)]
        public List<string> Scopes { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Scopes property is set.
        /// </summary>
        internal bool IsSetScopes() => this.Scopes != null && (this.Scopes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TokenType. 
        /// <para>
        /// The type of the issued token. For example, <c>Bearer</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public OAuthTokenTypeType TokenType { get; set; }

        /// <summary>
        /// Checks to see if the TokenType property is set.
        /// </summary>
        internal bool IsSetTokenType() => this.TokenType != null;
    }
}
