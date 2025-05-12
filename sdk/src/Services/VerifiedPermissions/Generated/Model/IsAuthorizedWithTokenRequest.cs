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
    /// Container for the parameters to the IsAuthorizedWithToken operation.
    /// Makes an authorization decision about a service request described in the parameters.
    /// The principal in this request comes from an external identity source in the form of
    /// an identity token formatted as a <a href="https://wikipedia.org/wiki/JSON_Web_Token">JSON
    /// web token (JWT)</a>. The information in the parameters can also define additional
    /// context that Verified Permissions can include in the evaluation. The request is evaluated
    /// against all matching policies in the specified policy store. The result of the decision
    /// is either <c>Allow</c> or <c>Deny</c>, along with a list of the policies that resulted
    /// in the decision.
    /// 
    ///  
    /// <para>
    /// Verified Permissions validates each token that is specified in a request by checking
    /// its expiration date and its signature.
    /// </para>
    ///  <important> 
    /// <para>
    /// Tokens from an identity source user continue to be usable until they expire. Token
    /// revocation and resource deletion have no effect on the validity of a token in your
    /// policy store
    /// </para>
    ///  </important>
    /// </summary>
    public partial class IsAuthorizedWithTokenRequest : AmazonVerifiedPermissionsRequest
    {
        private string _accessToken;
        private ActionIdentifier _action;
        private ContextDefinition _context;
        private EntitiesDefinition _entities;
        private string _identityToken;
        private string _policyStoreId;
        private EntityIdentifier _resource;

        /// <summary>
        /// Gets and sets the property AccessToken. 
        /// <para>
        /// Specifies an access token for the principal to be authorized. This token is provided
        /// to you by the identity provider (IdP) associated with the specified identity source.
        /// You must specify either an <c>accessToken</c>, an <c>identityToken</c>, or both.
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
        /// Gets and sets the property Action. 
        /// <para>
        /// Specifies the requested action to be authorized. Is the specified principal authorized
        /// to perform this action on the specified resource.
        /// </para>
        /// </summary>
        public ActionIdentifier Action
        {
            get { return this._action; }
            set { this._action = value; }
        }

        // Check to see if Action property is set
        internal bool IsSetAction()
        {
            return this._action != null;
        }

        /// <summary>
        /// Gets and sets the property Context. 
        /// <para>
        /// Specifies additional context that can be used to make more granular authorization
        /// decisions.
        /// </para>
        /// </summary>
        public ContextDefinition Context
        {
            get { return this._context; }
            set { this._context = value; }
        }

        // Check to see if Context property is set
        internal bool IsSetContext()
        {
            return this._context != null;
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
        /// The <c>IsAuthorizedWithToken</c> operation takes principal attributes from <b> <i>only</i>
        /// </b> the <c>identityToken</c> or <c>accessToken</c> passed to the operation.
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
        /// Specifies an identity token for the principal to be authorized. This token is provided
        /// to you by the identity provider (IdP) associated with the specified identity source.
        /// You must specify either an <c>accessToken</c>, an <c>identityToken</c>, or both.
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
        /// Gets and sets the property Resource. 
        /// <para>
        /// Specifies the resource for which the authorization decision is made. For example,
        /// is the principal allowed to perform the action on the resource?
        /// </para>
        /// </summary>
        public EntityIdentifier Resource
        {
            get { return this._resource; }
            set { this._resource = value; }
        }

        // Check to see if Resource property is set
        internal bool IsSetResource()
        {
            return this._resource != null;
        }

    }
}