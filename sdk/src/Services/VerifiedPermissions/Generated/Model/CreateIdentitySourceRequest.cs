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
 * Do not modify this file. This file is generated from the verifiedpermissions-2021-12-01.normal.json service model.
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
namespace Amazon.VerifiedPermissions.Model
{
    /// <summary>
    /// Container for the parameters to the CreateIdentitySource operation.
    /// Adds an identity source to a policy store–an Amazon Cognito user pool or OpenID Connect
    /// (OIDC) identity provider (IdP). 
    /// 
    ///  
    /// <para>
    /// After you create an identity source, you can use the identities provided by the IdP
    /// as proxies for the principal in authorization queries that use the <a href="https://docs.aws.amazon.com/verifiedpermissions/latest/apireference/API_IsAuthorizedWithToken.html">IsAuthorizedWithToken</a>
    /// or <a href="https://docs.aws.amazon.com/verifiedpermissions/latest/apireference/API_BatchIsAuthorizedWithToken.html">BatchIsAuthorizedWithToken</a>
    /// API operations. These identities take the form of tokens that contain claims about
    /// the user, such as IDs, attributes and group memberships. Identity sources provide
    /// identity (ID) tokens and access tokens. Verified Permissions derives information about
    /// your user and session from token claims. Access tokens provide action <c>context</c>
    /// to your policies, and ID tokens provide principal <c>Attributes</c>.
    /// </para>
    ///  <important> 
    /// <para>
    /// Tokens from an identity source user continue to be usable until they expire. Token
    /// revocation and resource deletion have no effect on the validity of a token in your
    /// policy store
    /// </para>
    ///  </important> <note> 
    /// <para>
    /// To reference a user from this identity source in your Cedar policies, refer to the
    /// following syntax examples.
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Amazon Cognito user pool: <c>Namespace::[Entity type]::[User pool ID]|[user principal
    /// attribute]</c>, for example <c>MyCorp::User::us-east-1_EXAMPLE|a1b2c3d4-5678-90ab-cdef-EXAMPLE11111</c>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// OpenID Connect (OIDC) provider: <c>Namespace::[Entity type]::[entityIdPrefix]|[user
    /// principal attribute]</c>, for example <c>MyCorp::User::MyOIDCProvider|a1b2c3d4-5678-90ab-cdef-EXAMPLE22222</c>.
    /// </para>
    ///  </li> </ul> </note> <note> 
    /// <para>
    /// Verified Permissions is <i> <a href="https://wikipedia.org/wiki/Eventual_consistency">eventually
    /// consistent</a> </i>. It can take a few seconds for a new or changed element to propagate
    /// through the service and be visible in the results of other Verified Permissions operations.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class CreateIdentitySourceRequest : AmazonVerifiedPermissionsRequest
    {
        private string _clientToken;
        private Configuration _configuration;
        private string _policyStoreId;
        private string _principalEntityType;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// Specifies a unique, case-sensitive ID that you provide to ensure the idempotency of
        /// the request. This lets you safely retry the request without accidentally performing
        /// the same operation a second time. Passing the same value to a later call to an operation
        /// requires that you also pass the same value for all other parameters. We recommend
        /// that you use a <a href="https://wikipedia.org/wiki/Universally_unique_identifier">UUID
        /// type of value.</a>.
        /// </para>
        ///  
        /// <para>
        /// If you don't provide this value, then Amazon Web Services generates a random one for
        /// you.
        /// </para>
        ///  
        /// <para>
        /// If you retry the operation with the same <c>ClientToken</c>, but with different parameters,
        /// the retry fails with an <c>ConflictException</c> error.
        /// </para>
        ///  
        /// <para>
        /// Verified Permissions recognizes a <c>ClientToken</c> for eight hours. After eight
        /// hours, the next request with the same parameters performs the operation again regardless
        /// of the value of <c>ClientToken</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property Configuration. 
        /// <para>
        /// Specifies the details required to communicate with the identity provider (IdP) associated
        /// with this identity source.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public Configuration Configuration
        {
            get { return this._configuration; }
            set { this._configuration = value; }
        }

        // Check to see if Configuration property is set
        internal bool IsSetConfiguration()
        {
            return this._configuration != null;
        }

        /// <summary>
        /// Gets and sets the property PolicyStoreId. 
        /// <para>
        /// Specifies the ID of the policy store in which you want to store this identity source.
        /// Only policies and requests made using this policy store can reference identities from
        /// the identity provider configured in the new identity source.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=200)]
        public string PolicyStoreId
        {
            get { return this._policyStoreId; }
            set { this._policyStoreId = value; }
        }

        // Check to see if PolicyStoreId property is set
        internal bool IsSetPolicyStoreId()
        {
            return this._policyStoreId != null;
        }

        /// <summary>
        /// Gets and sets the property PrincipalEntityType. 
        /// <para>
        /// Specifies the namespace and data type of the principals generated for identities authenticated
        /// by the new identity source.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=200)]
        public string PrincipalEntityType
        {
            get { return this._principalEntityType; }
            set { this._principalEntityType = value; }
        }

        // Check to see if PrincipalEntityType property is set
        internal bool IsSetPrincipalEntityType()
        {
            return this._principalEntityType != null;
        }

    }
}