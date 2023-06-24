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
 * Do not modify this file. This file is generated from the iam-2010-05-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IdentityManagement.Model
{
    /// <summary>
    /// Container for the parameters to the PutUserPermissionsBoundary operation.
    /// Adds or updates the policy that is specified as the IAM user's permissions boundary.
    /// You can use an Amazon Web Services managed policy or a customer managed policy to
    /// set the boundary for a user. Use the boundary to control the maximum permissions that
    /// the user can have. Setting a permissions boundary is an advanced feature that can
    /// affect the permissions for the user.
    /// 
    ///  <important> 
    /// <para>
    /// Policies that are used as permissions boundaries do not provide permissions. You must
    /// also attach a permissions policy to the user. To learn how the effective permissions
    /// for a user are evaluated, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference_policies_evaluation-logic.html">IAM
    /// JSON policy evaluation logic</a> in the IAM User Guide. 
    /// </para>
    ///  </important>
    /// </summary>
    public partial class PutUserPermissionsBoundaryRequest : AmazonIdentityManagementServiceRequest
    {
        private string _permissionsBoundary;
        private string _userName;

        /// <summary>
        /// Gets and sets the property PermissionsBoundary. 
        /// <para>
        /// The ARN of the managed policy that is used to set the permissions boundary for the
        /// user.
        /// </para>
        ///  
        /// <para>
        /// A permissions boundary policy defines the maximum permissions that identity-based
        /// policies can grant to an entity, but does not grant permissions. Permissions boundaries
        /// do not define the maximum permissions that a resource-based policy can grant to an
        /// entity. To learn more, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access_policies_boundaries.html">Permissions
        /// boundaries for IAM entities</a> in the <i>IAM User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// For more information about policy types, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access_policies.html#access_policy-types">Policy
        /// types </a> in the <i>IAM User Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=2048)]
        public string PermissionsBoundary
        {
            get { return this._permissionsBoundary; }
            set { this._permissionsBoundary = value; }
        }

        // Check to see if PermissionsBoundary property is set
        internal bool IsSetPermissionsBoundary()
        {
            return this._permissionsBoundary != null;
        }

        /// <summary>
        /// Gets and sets the property UserName. 
        /// <para>
        /// The name (friendly name, not ARN) of the IAM user for which you want to set the permissions
        /// boundary.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string UserName
        {
            get { return this._userName; }
            set { this._userName = value; }
        }

        // Check to see if UserName property is set
        internal bool IsSetUserName()
        {
            return this._userName != null;
        }

    }
}