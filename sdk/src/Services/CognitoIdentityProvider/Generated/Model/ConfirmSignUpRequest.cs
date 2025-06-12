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
    /// Container for the parameters to the ConfirmSignUp operation.
    /// Confirms the account of a new user. This public API operation submits a code that
    /// Amazon Cognito sent to your user when they signed up in your user pool. After your
    /// user enters their code, they confirm ownership of the email address or phone number
    /// that they provided, and their user account becomes active. Depending on your user
    /// pool configuration, your users will receive their confirmation code in an email or
    /// SMS message.
    /// 
    ///  
    /// <para>
    /// Local users who signed up in your user pool are the only type of user who can confirm
    /// sign-up with a code. Users who federate through an external identity provider (IdP)
    /// have already been confirmed by their IdP.
    /// </para>
    ///  <note> 
    /// <para>
    /// Amazon Cognito doesn't evaluate Identity and Access Management (IAM) policies in requests
    /// for this API operation. For this operation, you can't use IAM credentials to authorize
    /// requests, and you can't grant IAM permissions in policies. For more information about
    /// authorization models in Amazon Cognito, see <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/user-pools-API-operations.html">Using
    /// the Amazon Cognito user pools API and user pool endpoints</a>.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class ConfirmSignUpRequest : AmazonCognitoIdentityProviderRequest
    {
        private AnalyticsMetadataType _analyticsMetadata;
        private string _clientId;
        private Dictionary<string, string> _clientMetadata = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private string _confirmationCode;
        private bool? _forceAliasCreation;
        private string _secretHash;
        private string _session;
        private UserContextDataType _userContextData;
        private string _username;

        /// <summary>
        /// Gets and sets the property AnalyticsMetadata. 
        /// <para>
        /// Information that supports analytics outcomes with Amazon Pinpoint, including the user's
        /// endpoint ID. The endpoint ID is a destination for Amazon Pinpoint push notifications,
        /// for example a device identifier, email address, or phone number.
        /// </para>
        /// </summary>
        public AnalyticsMetadataType AnalyticsMetadata
        {
            get { return this._analyticsMetadata; }
            set { this._analyticsMetadata = value; }
        }

        // Check to see if AnalyticsMetadata property is set
        internal bool IsSetAnalyticsMetadata()
        {
            return this._analyticsMetadata != null;
        }

        /// <summary>
        /// Gets and sets the property ClientId. 
        /// <para>
        /// The ID of the app client associated with the user pool.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=1, Max=128)]
        public string ClientId
        {
            get { return this._clientId; }
            set { this._clientId = value; }
        }

        // Check to see if ClientId property is set
        internal bool IsSetClientId()
        {
            return this._clientId != null;
        }

        /// <summary>
        /// Gets and sets the property ClientMetadata. 
        /// <para>
        /// A map of custom key-value pairs that you can provide as input for any custom workflows
        /// that this action triggers.
        /// </para>
        ///  
        /// <para>
        /// You create custom workflows by assigning Lambda functions to user pool triggers. When
        /// you use the ConfirmSignUp API action, Amazon Cognito invokes the function that is
        /// assigned to the <i>post confirmation</i> trigger. When Amazon Cognito invokes this
        /// function, it passes a JSON payload, which the function receives as input. This payload
        /// contains a <c>clientMetadata</c> attribute, which provides the data that you assigned
        /// to the ClientMetadata parameter in your ConfirmSignUp request. In your function code
        /// in Lambda, you can process the <c>clientMetadata</c> value to enhance your workflow
        /// for your specific needs.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/cognito-user-identity-pools-working-with-aws-lambda-triggers.html">
        /// Using Lambda triggers</a> in the <i>Amazon Cognito Developer Guide</i>.
        /// </para>
        ///  <note> 
        /// <para>
        /// When you use the <c>ClientMetadata</c> parameter, note that Amazon Cognito won't do
        /// the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Store the <c>ClientMetadata</c> value. This data is available only to Lambda triggers
        /// that are assigned to a user pool to support custom workflows. If your user pool configuration
        /// doesn't include triggers, the <c>ClientMetadata</c> parameter serves no purpose.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Validate the <c>ClientMetadata</c> value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Encrypt the <c>ClientMetadata</c> value. Don't send sensitive information in this
        /// parameter.
        /// </para>
        ///  </li> </ul> </note>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> ClientMetadata
        {
            get { return this._clientMetadata; }
            set { this._clientMetadata = value; }
        }

        // Check to see if ClientMetadata property is set
        internal bool IsSetClientMetadata()
        {
            return this._clientMetadata != null && (this._clientMetadata.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ConfirmationCode. 
        /// <para>
        /// The confirmation code that your user pool sent in response to the <c>SignUp</c> request.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
        public string ConfirmationCode
        {
            get { return this._confirmationCode; }
            set { this._confirmationCode = value; }
        }

        // Check to see if ConfirmationCode property is set
        internal bool IsSetConfirmationCode()
        {
            return this._confirmationCode != null;
        }

        /// <summary>
        /// Gets and sets the property ForceAliasCreation. 
        /// <para>
        /// When <c>true</c>, forces user confirmation despite any existing aliases. Defaults
        /// to <c>false</c>. A value of <c>true</c> migrates the alias from an existing user to
        /// the new user if an existing user already has the phone number or email address as
        /// an alias.
        /// </para>
        ///  
        /// <para>
        /// Say, for example, that an existing user has an <c>email</c> attribute of <c>bob@example.com</c>
        /// and email is an alias in your user pool. If the new user also has an email of <c>bob@example.com</c>
        /// and your <c>ConfirmSignUp</c> response sets <c>ForceAliasCreation</c> to <c>true</c>,
        /// the new user can sign in with a username of <c>bob@example.com</c> and the existing
        /// user can no longer do so.
        /// </para>
        ///  
        /// <para>
        /// If <c>false</c> and an attribute belongs to an existing alias, this request returns
        /// an <b>AliasExistsException</b> error.
        /// </para>
        ///  
        /// <para>
        /// For more information about sign-in aliases, see <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/user-pool-settings-attributes.html#user-pool-settings-aliases">Customizing
        /// sign-in attributes</a>.
        /// </para>
        /// </summary>
        public bool? ForceAliasCreation
        {
            get { return this._forceAliasCreation; }
            set { this._forceAliasCreation = value; }
        }

        // Check to see if ForceAliasCreation property is set
        internal bool IsSetForceAliasCreation()
        {
            return this._forceAliasCreation.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SecretHash. 
        /// <para>
        /// A keyed-hash message authentication code (HMAC) calculated using the secret key of
        /// a user pool client and username plus the client ID in the message. For more information
        /// about <c>SecretHash</c>, see <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/signing-up-users-in-your-app.html#cognito-user-pools-computing-secret-hash">Computing
        /// secret hash values</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=128)]
        public string SecretHash
        {
            get { return this._secretHash; }
            set { this._secretHash = value; }
        }

        // Check to see if SecretHash property is set
        internal bool IsSetSecretHash()
        {
            return this._secretHash != null;
        }

        /// <summary>
        /// Gets and sets the property Session. 
        /// <para>
        /// The optional session ID from a <c>SignUp</c> API request. You can sign in a user directly
        /// from the sign-up process with the <c>USER_AUTH</c> authentication flow.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=20, Max=2048)]
        public string Session
        {
            get { return this._session; }
            set { this._session = value; }
        }

        // Check to see if Session property is set
        internal bool IsSetSession()
        {
            return this._session != null;
        }

        /// <summary>
        /// Gets and sets the property UserContextData. 
        /// <para>
        /// Contextual data about your user session like the device fingerprint, IP address, or
        /// location. Amazon Cognito threat protection evaluates the risk of an authentication
        /// event based on the context that your app generates and passes to Amazon Cognito when
        /// it makes API requests.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/user-pool-settings-viewing-threat-protection-app.html">Collecting
        /// data for threat protection in applications</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public UserContextDataType UserContextData
        {
            get { return this._userContextData; }
            set { this._userContextData = value; }
        }

        // Check to see if UserContextData property is set
        internal bool IsSetUserContextData()
        {
            return this._userContextData != null;
        }

        /// <summary>
        /// Gets and sets the property Username. 
        /// <para>
        /// The name of the user that you want to query or modify. The value of this parameter
        /// is typically your user's username, but it can be any of their alias attributes. If
        /// <c>username</c> isn't an alias attribute in your user pool, this value must be the
        /// <c>sub</c> of a local user or the username of a user from a third-party IdP.
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