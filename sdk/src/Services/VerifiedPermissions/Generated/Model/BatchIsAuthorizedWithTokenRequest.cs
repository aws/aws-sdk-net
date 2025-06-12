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
    /// Container for the parameters to the BatchIsAuthorizedWithToken operation.
    /// Makes a series of decisions about multiple authorization requests for one token. The
    /// principal in this request comes from an external identity source in the form of an
    /// identity or access token, formatted as a <a href="https://wikipedia.org/wiki/JSON_Web_Token">JSON
    /// web token (JWT)</a>. The information in the parameters can also define additional
    /// context that Verified Permissions can include in the evaluations.
    /// 
    ///  
    /// <para>
    /// The request is evaluated against all policies in the specified policy store that match
    /// the entities that you provide in the entities declaration and in the token. The result
    /// of the decisions is a series of <c>Allow</c> or <c>Deny</c> responses, along with
    /// the IDs of the policies that produced each decision.
    /// </para>
    ///  
    /// <para>
    /// The <c>entities</c> of a <c>BatchIsAuthorizedWithToken</c> API request can contain
    /// up to 100 resources and up to 99 user groups. The <c>requests</c> of a <c>BatchIsAuthorizedWithToken</c>
    /// API request can contain up to 30 requests.
    /// </para>
    ///  <note> 
    /// <para>
    /// The <c>BatchIsAuthorizedWithToken</c> operation doesn't have its own IAM permission.
    /// To authorize this operation for Amazon Web Services principals, include the permission
    /// <c>verifiedpermissions:IsAuthorizedWithToken</c> in their IAM policies.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class BatchIsAuthorizedWithTokenRequest : AmazonVerifiedPermissionsRequest
    {
        private string _accessToken;
        private EntitiesDefinition _entities;
        private string _identityToken;
        private string _policyStoreId;
        private List<BatchIsAuthorizedWithTokenInputItem> _requests = AWSConfigs.InitializeCollections ? new List<BatchIsAuthorizedWithTokenInputItem>() : null;

        /// <summary>
        /// Gets and sets the property AccessToken. 
        /// <para>
        /// Specifies an access token for the principal that you want to authorize in each request.
        /// This token is provided to you by the identity provider (IdP) associated with the specified
        /// identity source. You must specify either an <c>accessToken</c>, an <c>identityToken</c>,
        /// or both.
        /// </para>
        ///  
        /// <para>
        /// Must be an access token. Verified Permissions returns an error if the <c>token_use</c>
        /// claim in the submitted token isn't <c>access</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=131072)]
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
        /// Gets and sets the property Entities. 
        /// <para>
        /// (Optional) Specifies the list of resources and their associated attributes that Verified
        /// Permissions can examine when evaluating the policies. These additional entities and
        /// their attributes can be referenced and checked by conditional elements in the policies
        /// in the specified policy store.
        /// </para>
        ///  <important> 
        /// <para>
        /// You can't include principals in this parameter, only resource and action entities.
        /// This parameter can't include any entities of a type that matches the user or group
        /// entity types that you defined in your identity source.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The <c>BatchIsAuthorizedWithToken</c> operation takes principal attributes from <b>
        /// <i>only</i> </b> the <c>identityToken</c> or <c>accessToken</c> passed to the operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For action entities, you can include only their <c>Identifier</c> and <c>EntityType</c>.
        /// 
        /// </para>
        ///  </li> </ul> </important>
        /// </summary>
        public EntitiesDefinition Entities
        {
            get { return this._entities; }
            set { this._entities = value; }
        }

        // Check to see if Entities property is set
        internal bool IsSetEntities()
        {
            return this._entities != null;
        }

        /// <summary>
        /// Gets and sets the property IdentityToken. 
        /// <para>
        /// Specifies an identity (ID) token for the principal that you want to authorize in each
        /// request. This token is provided to you by the identity provider (IdP) associated with
        /// the specified identity source. You must specify either an <c>accessToken</c>, an <c>identityToken</c>,
        /// or both.
        /// </para>
        ///  
        /// <para>
        /// Must be an ID token. Verified Permissions returns an error if the <c>token_use</c>
        /// claim in the submitted token isn't <c>id</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=131072)]
        public string IdentityToken
        {
            get { return this._identityToken; }
            set { this._identityToken = value; }
        }

        // Check to see if IdentityToken property is set
        internal bool IsSetIdentityToken()
        {
            return this._identityToken != null;
        }

        /// <summary>
        /// Gets and sets the property PolicyStoreId. 
        /// <para>
        /// Specifies the ID of the policy store. Policies in this policy store will be used to
        /// make an authorization decision for the input.
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
        /// Gets and sets the property Requests. 
        /// <para>
        /// An array of up to 30 requests that you want Verified Permissions to evaluate.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
        public List<BatchIsAuthorizedWithTokenInputItem> Requests
        {
            get { return this._requests; }
            set { this._requests = value; }
        }

        // Check to see if Requests property is set
        internal bool IsSetRequests()
        {
            return this._requests != null && (this._requests.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}