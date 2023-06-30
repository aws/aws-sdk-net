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

namespace Amazon.VerifiedPermissions.Model
{
    /// <summary>
    /// Container for the parameters to the CreateIdentitySource operation.
    /// Creates a reference to an Amazon Cognito user pool as an external identity provider
    /// (IdP). 
    /// 
    ///  
    /// <para>
    /// After you create an identity source, you can use the identities provided by the IdP
    /// as proxies for the principal in authorization queries that use the <a href="https://docs.aws.amazon.com/verifiedpermissions/latest/apireference/API_IsAuthorizedWithToken.html">IsAuthorizedWithToken</a>
    /// operation. These identities take the form of tokens that contain claims about the
    /// user, such as IDs, attributes and group memberships. Amazon Cognito provides both
    /// identity tokens and access tokens, and Verified Permissions can use either or both.
    /// Any combination of identity and access tokens results in the same Cedar principal.
    /// Verified Permissions automatically translates the information about the identities
    /// into the standard Cedar attributes that can be evaluated by your policies. Because
    /// the Amazon Cognito identity and access tokens can contain different information, the
    /// tokens you choose to use determine which principal attributes are available to access
    /// when evaluating Cedar policies.
    /// </para>
    ///  <important> 
    /// <para>
    /// If you delete a Amazon Cognito user pool or user, tokens from that deleted pool or
    /// that deleted user continue to be usable until they expire.
    /// </para>
    ///  </important> <note> 
    /// <para>
    /// To reference a user from this identity source in your Cedar policies, use the following
    /// syntax.
    /// </para>
    ///  
    /// <para>
    ///  <i>IdentityType::"&lt;CognitoUserPoolIdentifier&gt;|&lt;CognitoClientId&gt;</i> 
    /// </para>
    ///  
    /// <para>
    /// Where <code>IdentityType</code> is the string that you provide to the <code>PrincipalEntityType</code>
    /// parameter for this operation. The <code>CognitoUserPoolId</code> and <code>CognitoClientId</code>
    /// are defined by the Amazon Cognito user pool.
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
        /// If you retry the operation with the same <code>ClientToken</code>, but with different
        /// parameters, the retry fails with an <code>IdempotentParameterMismatch</code> error.
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
        ///  <note> 
        /// <para>
        /// At this time, the only valid member of this structure is a Amazon Cognito user pool
        /// configuration.
        /// </para>
        ///  
        /// <para>
        /// You must specify a <code>UserPoolArn</code>, and optionally, a <code>ClientId</code>.
        /// </para>
        ///  </note>
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
        [AWSProperty(Min=1, Max=200)]
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