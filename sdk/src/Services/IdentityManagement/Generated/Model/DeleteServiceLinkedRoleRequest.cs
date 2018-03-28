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
    /// Container for the parameters to the DeleteServiceLinkedRole operation.
    /// Submits a service-linked role deletion request and returns a <code>DeletionTaskId</code>,
    /// which you can use to check the status of the deletion. Before you call this operation,
    /// confirm that the role has no active sessions and that any resources used by the role
    /// in the linked service are deleted. If you call this operation more than once for the
    /// same service-linked role and an earlier deletion task is not complete, then the <code>DeletionTaskId</code>
    /// of the earlier request is returned.
    /// 
    ///  
    /// <para>
    /// If you submit a deletion request for a service-linked role whose linked service is
    /// still accessing a resource, then the deletion task fails. If it fails, the <a>GetServiceLinkedRoleDeletionStatus</a>
    /// API operation returns the reason for the failure, usually including the resources
    /// that must be deleted. To delete the service-linked role, you must first remove those
    /// resources from the linked service and then submit the deletion request again. Resources
    /// are specific to the service that is linked to the role. For more information about
    /// removing resources from a service, see the <a href="http://docs.aws.amazon.com/">AWS
    /// documentation</a> for your service.
    /// </para>
    ///  
    /// <para>
    /// For more information about service-linked roles, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/id_roles_terms-and-concepts.html#iam-term-service-linked-role">Roles
    /// Terms and Concepts: AWS Service-Linked Role</a> in the <i>IAM User Guide</i>.
    /// </para>
    /// </summary>
    public partial class DeleteServiceLinkedRoleRequest : AmazonIdentityManagementServiceRequest
    {
        private string _roleName;

        /// <summary>
        /// Gets and sets the property RoleName. 
        /// <para>
        /// The name of the service-linked role to be deleted.
        /// </para>
        /// </summary>
        public string RoleName
        {
            get { return this._roleName; }
            set { this._roleName = value; }
        }

        // Check to see if RoleName property is set
        internal bool IsSetRoleName()
        {
            return this._roleName != null;
        }

    }
}