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
    /// Container for the parameters to the CreatePolicy operation.
    /// Creates a Cedar policy and saves it in the specified policy store. You can create
    /// either a static policy or a policy linked to a policy template.
    /// 
    ///  <ul> <li> 
    /// <para>
    /// To create a static policy, provide the Cedar policy text in the <c>StaticPolicy</c>
    /// section of the <c>PolicyDefinition</c>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// To create a policy that is dynamically linked to a policy template, specify the policy
    /// template ID and the principal and resource to associate with this policy in the <c>templateLinked</c>
    /// section of the <c>PolicyDefinition</c>. If the policy template is ever updated, any
    /// policies linked to the policy template automatically use the updated template.
    /// </para>
    ///  </li> </ul> <note> 
    /// <para>
    /// Creating a policy causes it to be validated against the schema in the policy store.
    /// If the policy doesn't pass validation, the operation fails and the policy isn't stored.
    /// </para>
    ///  </note> <note> 
    /// <para>
    /// Verified Permissions is <i> <a href="https://wikipedia.org/wiki/Eventual_consistency">eventually
    /// consistent</a> </i>. It can take a few seconds for a new or changed element to propagate
    /// through the service and be visible in the results of other Verified Permissions operations.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class CreatePolicyRequest : AmazonVerifiedPermissionsRequest
    {
        private string _clientToken;
        private PolicyDefinition _definition;
        private string _policyStoreId;

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
        /// Gets and sets the property Definition. 
        /// <para>
        /// A structure that specifies the policy type and content to use for the new policy.
        /// You must include either a static or a templateLinked element. The policy content must
        /// be written in the Cedar policy language.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public PolicyDefinition Definition
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
        /// Gets and sets the property PolicyStoreId. 
        /// <para>
        /// Specifies the <c>PolicyStoreId</c> of the policy store you want to store the policy
        /// in.
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