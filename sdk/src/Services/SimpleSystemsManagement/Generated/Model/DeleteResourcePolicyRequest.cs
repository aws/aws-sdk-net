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
    /// Container for the parameters to the DeleteResourcePolicy operation.
    /// Deletes a Systems Manager resource policy. A resource policy helps you to define the
    /// IAM entity (for example, an Amazon Web Services account) that can manage your Systems
    /// Manager resources. The following resources support Systems Manager resource policies.
    /// 
    ///  <ul> <li> 
    /// <para>
    ///  <c>OpsItemGroup</c> - The resource policy for <c>OpsItemGroup</c> enables Amazon
    /// Web Services accounts to view and interact with OpsCenter operational work items (OpsItems).
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>Parameter</c> - The resource policy is used to share a parameter with other accounts
    /// using Resource Access Manager (RAM). For more information about cross-account sharing
    /// of parameters, see <a href="https://docs.aws.amazon.com/systems-manager/latest/userguide/parameter-store-shared-parameters.html">Working
    /// with shared parameters</a> in the <i>Amazon Web Services Systems Manager User Guide</i>.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class DeleteResourcePolicyRequest : AmazonSimpleSystemsManagementRequest
    {
        private string _policyHash;
        private string _policyId;
        private string _resourceArn;

        /// <summary>
        /// Gets and sets the property PolicyHash. 
        /// <para>
        /// ID of the current policy version. The hash helps to prevent multiple calls from attempting
        /// to overwrite a policy.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        [AWSProperty(Required=true)]
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
        /// Amazon Resource Name (ARN) of the resource to which the policies are attached.
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