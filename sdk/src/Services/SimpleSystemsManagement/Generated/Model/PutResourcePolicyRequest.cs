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
 * Do not modify this file. This file is generated from the ssm-2014-11-06.normal.json service model.
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
namespace Amazon.SimpleSystemsManagement.Model
{
    /// <summary>
    /// Container for the parameters to the PutResourcePolicy operation.
    /// Creates or updates a Systems Manager resource policy. A resource policy helps you
    /// to define the IAM entity (for example, an Amazon Web Services account) that can manage
    /// your Systems Manager resources. The following resources support Systems Manager resource
    /// policies.
    /// 
    ///  <ul> <li> 
    /// <para>
    ///  <c>OpsItemGroup</c> - The resource policy for <c>OpsItemGroup</c> enables Amazon
    /// Web Services accounts to view and interact with OpsCenter operational work items (OpsItems).
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>Parameter</c> - The resource policy is used to share a parameter with other accounts
    /// using Resource Access Manager (RAM). 
    /// </para>
    ///  
    /// <para>
    /// To share a parameter, it must be in the advanced parameter tier. For information about
    /// parameter tiers, see <a href="https://docs.aws.amazon.com/systems-manager/latest/userguide/parameter-store-advanced-parameters.html">Managing
    /// parameter tiers</a>. For information about changing an existing standard parameter
    /// to an advanced parameter, see <a href="https://docs.aws.amazon.com/systems-manager/latest/userguide/parameter-store-advanced-parameters.html#parameter-store-advanced-parameters-enabling">Changing
    /// a standard parameter to an advanced parameter</a>.
    /// </para>
    ///  
    /// <para>
    /// To share a <c>SecureString</c> parameter, it must be encrypted with a customer managed
    /// key, and you must share the key separately through Key Management Service. Amazon
    /// Web Services managed keys cannot be shared. Parameters encrypted with the default
    /// Amazon Web Services managed key can be updated to use a customer managed key instead.
    /// For KMS key definitions, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html">KMS
    /// concepts</a> in the <i>Key Management Service Developer Guide</i>.
    /// </para>
    ///  <important> 
    /// <para>
    /// While you can share a parameter using the Systems Manager <c>PutResourcePolicy</c>
    /// operation, we recommend using Resource Access Manager (RAM) instead. This is because
    /// using <c>PutResourcePolicy</c> requires the extra step of promoting the parameter
    /// to a standard RAM Resource Share using the RAM <a href="https://docs.aws.amazon.com/ram/latest/APIReference/API_PromoteResourceShareCreatedFromPolicy.html">PromoteResourceShareCreatedFromPolicy</a>
    /// API operation. Otherwise, the parameter won't be returned by the Systems Manager <a
    /// href="https://docs.aws.amazon.com/systems-manager/latest/APIReference/API_DescribeParameters.html">DescribeParameters</a>
    /// API operation using the <c>--shared</c> option.
    /// </para>
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/systems-manager/latest/userguide/parameter-store-shared-parameters.html#share">Sharing
    /// a parameter</a> in the <i>Amazon Web Services Systems Manager User Guide</i> 
    /// </para>
    ///  </important> </li> </ul>
    /// </summary>
    public partial class PutResourcePolicyRequest : AmazonSimpleSystemsManagementRequest
    {
        private string _policy;
        private string _policyHash;
        private string _policyId;
        private string _resourceArn;

        /// <summary>
        /// Gets and sets the property Policy. 
        /// <para>
        /// A policy you want to associate with a resource.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Policy
        {
            get { return this._policy; }
            set { this._policy = value; }
        }

        // Check to see if Policy property is set
        internal bool IsSetPolicy()
        {
            return this._policy != null;
        }

        /// <summary>
        /// Gets and sets the property PolicyHash. 
        /// <para>
        /// ID of the current policy version. The hash helps to prevent a situation where multiple
        /// users attempt to overwrite a policy. You must provide this hash when updating or deleting
        /// a policy.
        /// </para>
        /// </summary>
        public string PolicyHash
        {
            get { return this._policyHash; }
            set { this._policyHash = value; }
        }

        // Check to see if PolicyHash property is set
        internal bool IsSetPolicyHash()
        {
            return this._policyHash != null;
        }

        /// <summary>
        /// Gets and sets the property PolicyId. 
        /// <para>
        /// The policy ID.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property ResourceArn. 
        /// <para>
        /// Amazon Resource Name (ARN) of the resource to which you want to attach a policy.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=2048)]
        public string ResourceArn
        {
            get { return this._resourceArn; }
            set { this._resourceArn = value; }
        }

        // Check to see if ResourceArn property is set
        internal bool IsSetResourceArn()
        {
            return this._resourceArn != null;
        }

    }
}