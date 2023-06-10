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
    /// Container for the parameters to the DeleteRolePermissionsBoundary operation.
    /// Deletes the permissions boundary for the specified IAM role. 
    /// 
    ///  
    /// <para>
    /// You cannot set the boundary for a service-linked role.
    /// </para>
    ///  <important> 
    /// <para>
    /// Deleting the permissions boundary for a role might increase its permissions. For example,
    /// it might allow anyone who assumes the role to perform all the actions granted in its
    /// permissions policies.
    /// </para>
    ///  </important>
    /// </summary>
    public partial class DeleteRolePermissionsBoundaryRequest : AmazonIdentityManagementServiceRequest
    {
        private string _roleName;

        /// <summary>
        /// Gets and sets the property RoleName. 
        /// <para>
        /// The name (friendly name, not ARN) of the IAM role from which you want to remove the
        /// permissions boundary.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
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