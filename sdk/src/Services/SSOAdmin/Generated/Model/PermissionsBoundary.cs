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
 * Do not modify this file. This file is generated from the sso-admin-2020-07-20.normal.json service model.
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
namespace Amazon.SSOAdmin.Model
{
    /// <summary>
    /// Specifies the configuration of the Amazon Web Services managed or customer managed
    /// policy that you want to set as a permissions boundary. Specify either <c>CustomerManagedPolicyReference</c>
    /// to use the name and path of a customer managed policy, or <c>ManagedPolicyArn</c>
    /// to use the ARN of an Amazon Web Services managed policy. A permissions boundary represents
    /// the maximum permissions that any policy can grant your role. For more information,
    /// see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access_policies_boundaries.html">Permissions
    /// boundaries for IAM entities</a> in the <i>IAM User Guide</i>.
    /// 
    ///  <important> 
    /// <para>
    /// Policies used as permissions boundaries don't provide permissions. You must also attach
    /// an IAM policy to the role. To learn how the effective permissions for a role are evaluated,
    /// see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference_policies_evaluation-logic.html">IAM
    /// JSON policy evaluation logic</a> in the <i>IAM User Guide</i>.
    /// </para>
    ///  </important>
    /// </summary>
    public partial class PermissionsBoundary
    {
        private CustomerManagedPolicyReference _customerManagedPolicyReference;
        private string _managedPolicyArn;

        /// <summary>
        /// Gets and sets the property CustomerManagedPolicyReference. 
        /// <para>
        /// Specifies the name and path of a customer managed policy. You must have an IAM policy
        /// that matches the name and path in each Amazon Web Services account where you want
        /// to deploy your permission set.
        /// </para>
        /// </summary>
        public CustomerManagedPolicyReference CustomerManagedPolicyReference
        {
            get { return this._customerManagedPolicyReference; }
            set { this._customerManagedPolicyReference = value; }
        }

        // Check to see if CustomerManagedPolicyReference property is set
        internal bool IsSetCustomerManagedPolicyReference()
        {
            return this._customerManagedPolicyReference != null;
        }

        /// <summary>
        /// Gets and sets the property ManagedPolicyArn. 
        /// <para>
        /// The Amazon Web Services managed policy ARN that you want to attach to a permission
        /// set as a permissions boundary.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string ManagedPolicyArn
        {
            get { return this._managedPolicyArn; }
            set { this._managedPolicyArn = value; }
        }

        // Check to see if ManagedPolicyArn property is set
        internal bool IsSetManagedPolicyArn()
        {
            return this._managedPolicyArn != null;
        }

    }
}