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
    /// Container for the parameters to the DeleteRole operation.
    /// Deletes the specified role. The role must not have any policies attached. For more            information
    /// about roles, go to <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/WorkingWithRoles.html">Working
    /// with            Roles</a>.
    /// 
    ///         <important>Make sure you do not have any Amazon EC2 instances running with the role
    /// you are            about to delete. Deleting a role or instance profile that is associated
    /// with a running            instance will break any applications running on the instance.</important>
    /// </summary>
    public partial class DeleteRoleRequest : AmazonWebServiceRequest
    {
        private string _roleName;


        /// <summary>
        /// Gets and sets the property RoleName. 
        /// <para>
        /// Name of the role to delete.
        /// </para>
        /// </summary>
        public string RoleName
        {
            get { return this._roleName; }
            set { this._roleName = value; }
        }


        /// <summary>
        /// Sets the RoleName property
        /// </summary>
        /// <param name="roleName">The value to set for the RoleName property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DeleteRoleRequest WithRoleName(string roleName)
        {
            this._roleName = roleName;
            return this;
        }

        // Check to see if RoleName property is set
        internal bool IsSetRoleName()
        {
            return this._roleName != null;
        }

    }
}