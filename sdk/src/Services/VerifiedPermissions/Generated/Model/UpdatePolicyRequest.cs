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
    /// Container for the parameters to the UpdatePolicy operation.
    /// Modifies a Cedar static policy in the specified policy store. You can change only
    /// certain elements of the <a href="https://docs.aws.amazon.com/verifiedpermissions/latest/apireference/API_UpdatePolicyInput.html#amazonverifiedpermissions-UpdatePolicy-request-UpdatePolicyDefinition">UpdatePolicyDefinition</a>
    /// parameter. You can directly update only static policies. To change a template-linked
    /// policy, you must update the template instead, using <a href="https://docs.aws.amazon.com/verifiedpermissions/latest/apireference/API_UpdatePolicyTemplate.html">UpdatePolicyTemplate</a>.
    /// 
    ///  <note> <ul> <li> 
    /// <para>
    /// If policy validation is enabled in the policy store, then updating a static policy
    /// causes Verified Permissions to validate the policy against the schema in the policy
    /// store. If the updated static policy doesn't pass validation, the operation fails and
    /// the update isn't stored.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// When you edit a static policy, you can change only certain elements of a static policy:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// The action referenced by the policy. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// A condition clause, such as when and unless. 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// You can't change these elements of a static policy: 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Changing a policy from a static policy to a template-linked policy. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Changing the effect of a static policy from permit or forbid. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The principal referenced by a static policy. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The resource referenced by a static policy. 
    /// </para>
    ///  </li> </ul> </li> <li> 
    /// <para>
    /// To update a template-linked policy, you must update the template instead. 
    /// </para>
    ///  </li> </ul> </note> <note> 
    /// <para>
    /// Verified Permissions is <i> <a href="https://wikipedia.org/wiki/Eventual_consistency">eventually
    /// consistent</a> </i>. It can take a few seconds for a new or changed element to propagate
    /// through the service and be visible in the results of other Verified Permissions operations.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class UpdatePolicyRequest : AmazonVerifiedPermissionsRequest
    {
        private UpdatePolicyDefinition _definition;
        private string _policyId;
        private string _policyStoreId;

        /// <summary>
        /// Gets and sets the property Definition. 
        /// <para>
        /// Specifies the updated policy content that you want to replace on the specified policy.
        /// The content must be valid Cedar policy language text.
        /// </para>
        ///  
        /// <para>
        /// You can change only the following elements from the policy definition:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The <c>action</c> referenced by the policy.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Any conditional clauses, such as <c>when</c> or <c>unless</c> clauses.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// You <b>can't</b> change the following elements:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Changing from <c>static</c> to <c>templateLinked</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Changing the effect of the policy from <c>permit</c> or <c>forbid</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The <c>principal</c> referenced by the policy.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The <c>resource</c> referenced by the policy.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public UpdatePolicyDefinition Definition
        {
            get { return this._definition; }
            set { this._definition = value; }
        }

        // Check to see if Definition property is set
        internal bool IsSetDefinition()
        {
            return this._definition != null;
        }

        /// <summary>
        /// Gets and sets the property PolicyId. 
        /// <para>
        /// Specifies the ID of the policy that you want to update. To find this value, you can
        /// use <a href="https://docs.aws.amazon.com/verifiedpermissions/latest/apireference/API_ListPolicies.html">ListPolicies</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=200)]
        public string PolicyId
        {
            get { return this._policyId; }
            set { this._policyId = value; }
        }

        // Check to see if PolicyId property is set
        internal bool IsSetPolicyId()
        {
            return this._policyId != null;
        }

        /// <summary>
        /// Gets and sets the property PolicyStoreId. 
        /// <para>
        /// Specifies the ID of the policy store that contains the policy that you want to update.
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

    }
}