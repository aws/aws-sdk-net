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
    /// Container for the parameters to the IsAuthorizedWithToken operation.
    /// Makes an authorization decision about a service request described in the parameters.
    /// The principal in this request comes from an external identity source. The information
    /// in the parameters can also define additional context that Verified Permissions can
    /// include in the evaluation. The request is evaluated against all matching policies
    /// in the specified policy store. The result of the decision is either <code>Allow</code>
    /// or <code>Deny</code>, along with a list of the policies that resulted in the decision.
    /// 
    ///  <important> 
    /// <para>
    /// If you delete a Amazon Cognito user pool or user, tokens from that deleted pool or
    /// that deleted user continue to be usable until they expire.
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
        /// You must specify either an <code>AccessToken</code> or an <code>IdentityToken</code>,
        /// but not both.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=131072)]
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
        /// Specifies the list of resources and principals and their associated attributes that
        /// Verified Permissions can examine when evaluating the policies. 
        /// </para>
        ///  <note> 
        /// <para>
        /// You can include only principal and resource entities in this parameter; you can't
        /// include actions. You must specify actions in the schema.
        /// </para>
        ///  </note>
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
        /// You must specify either an <code>AccessToken</code> or an <code>IdentityToken</code>,
        /// but not both.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=131072)]
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