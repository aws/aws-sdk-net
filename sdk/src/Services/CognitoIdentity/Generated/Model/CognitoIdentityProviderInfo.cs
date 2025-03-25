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
 * Do not modify this file. This file is generated from the cognito-identity-2014-06-30.normal.json service model.
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
namespace Amazon.CognitoIdentity.Model
{
    /// <summary>
    /// A provider representing an Amazon Cognito user pool and its client ID.
    /// </summary>
    public partial class CognitoIdentityProviderInfo
    {
        private string _clientId;
        private string _providerName;
        private bool? _serverSideTokenCheck;

        /// <summary>
        /// Gets and sets the property ClientId. 
        /// <para>
        /// The client ID for the Amazon Cognito user pool.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
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
        /// Gets and sets the property ProviderName. 
        /// <para>
        /// The provider name for an Amazon Cognito user pool. For example, <c>cognito-idp.us-east-1.amazonaws.com/us-east-1_123456789</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string ProviderName
        {
            get { return this._providerName; }
            set { this._providerName = value; }
        }

        // Check to see if ProviderName property is set
        internal bool IsSetProviderName()
        {
            return this._providerName != null;
        }

        /// <summary>
        /// Gets and sets the property ServerSideTokenCheck. 
        /// <para>
        /// TRUE if server-side token validation is enabled for the identity provider’s token.
        /// </para>
        ///  
        /// <para>
        /// Once you set <c>ServerSideTokenCheck</c> to TRUE for an identity pool, that identity
        /// pool will check with the integrated user pools to make sure that the user has not
        /// been globally signed out or deleted before the identity pool provides an OIDC token
        /// or Amazon Web Services credentials for the user.
        /// </para>
        ///  
        /// <para>
        /// If the user is signed out or deleted, the identity pool will return a 400 Not Authorized
        /// error.
        /// </para>
        /// </summary>
        public bool? ServerSideTokenCheck
        {
            get { return this._serverSideTokenCheck; }
            set { this._serverSideTokenCheck = value; }
        }

        // Check to see if ServerSideTokenCheck property is set
        internal bool IsSetServerSideTokenCheck()
        {
            return this._serverSideTokenCheck.HasValue; 
        }

    }
}