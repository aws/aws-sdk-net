/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the iam-2010-05-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IdentityManagement.Model
{
    /// <summary>
    /// Container for the parameters to the DeletePolicy operation.
    /// Deletes the specified managed policy.
    /// 
    ///  
    /// <para>
    /// Before you can delete a managed policy, you must detach the policy from all users,
    /// groups, and roles that it is attached to, and you must delete all of the policy's
    /// versions. The following steps describe the process for deleting a managed policy:
    /// <ol> <li>Detach the policy from all users, groups, and roles that the policy is attached
    /// to, using the <a>DetachUserPolicy</a>, <a>DetachGroupPolicy</a>, or <a>DetachRolePolicy</a>
    /// APIs. To list all the users, groups, and roles that a policy is attached to, use <a>ListEntitiesForPolicy</a>.
    /// </li> <li>Delete all versions of the policy using <a>DeletePolicyVersion</a>. To list
    /// the policy's versions, use <a>ListPolicyVersions</a>. You cannot use <a>DeletePolicyVersion</a>
    /// to delete the version that is marked as the default version. You delete the policy's
    /// default version in the next step of the process. </li> <li>Delete the policy (this
    /// automatically deletes the policy's default version) using this API. </li> </ol> 
    /// </para>
    ///  
    /// <para>
    /// For information about managed policies, refer to <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/policies-managed-vs-inline.html">Managed
    /// Policies and Inline Policies</a> in the <i>IAM User Guide</i>. 
    /// </para>
    /// </summary>
    public partial class DeletePolicyRequest : AmazonIdentityManagementServiceRequest
    {
        private string _policyArn;

        /// <summary>
        /// Gets and sets the property PolicyArn.
        /// </summary>
        public string PolicyArn
        {
            get { return this._policyArn; }
            set { this._policyArn = value; }
        }

        // Check to see if PolicyArn property is set
        internal bool IsSetPolicyArn()
        {
            return this._policyArn != null;
        }

    }
}