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
    /// Container for the parameters to the BatchIsAuthorized operation.
    /// Makes a series of decisions about multiple authorization requests for one principal
    /// or resource. Each request contains the equivalent content of an <code>IsAuthorized</code>
    /// request: principal, action, resource, and context. Either the <code>principal</code>
    /// or the <code>resource</code> parameter must be identical across all requests. For
    /// example, Verified Permissions won't evaluate a pair of requests where <code>bob</code>
    /// views <code>photo1</code> and <code>alice</code> views <code>photo2</code>. Authorization
    /// of <code>bob</code> to view <code>photo1</code> and <code>photo2</code>, or <code>bob</code>
    /// and <code>alice</code> to view <code>photo1</code>, are valid batches. 
    /// 
    ///  
    /// <para>
    /// The request is evaluated against all policies in the specified policy store that match
    /// the entities that you declare. The result of the decisions is a series of <code>Allow</code>
    /// or <code>Deny</code> responses, along with the IDs of the policies that produced each
    /// decision.
    /// </para>
    ///  
    /// <para>
    /// The <code>entities</code> of a <code>BatchIsAuthorized</code> API request can contain
    /// up to 100 principals and up to 100 resources. The <code>requests</code> of a <code>BatchIsAuthorized</code>
    /// API request can contain up to 30 requests.
    /// </para>
    /// </summary>
    public partial class BatchIsAuthorizedRequest : AmazonVerifiedPermissionsRequest
    {
        private EntitiesDefinition _entities;
        private string _policyStoreId;
        private List<BatchIsAuthorizedInputItem> _requests = new List<BatchIsAuthorizedInputItem>();

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
        /// Gets and sets the property PolicyStoreId. 
        /// <para>
        /// Specifies the ID of the policy store. Policies in this policy store will be used to
        /// make the authorization decisions for the input.
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
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
        public List<BatchIsAuthorizedInputItem> Requests
        {
            get { return this._requests; }
            set { this._requests = value; }
        }

        // Check to see if Requests property is set
        internal bool IsSetRequests()
        {
            return this._requests != null && this._requests.Count > 0; 
        }

    }
}