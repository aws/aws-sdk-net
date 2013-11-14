/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
    /// <para>Deletes the specified role. The role must not have any policies attached. For more information about roles, go to <a
    /// href="http://docs.aws.amazon.com/IAM/latest/UserGuide/WorkingWithRoles.html" >Working with Roles</a> .</para> <para><b>IMPORTANT:</b>Make
    /// sure you do not have any Amazon EC2 instances running with the role you are about to delete. Deleting a role or instance profile that is
    /// associated with a running instance will break any applications running on the instance.</para>
    /// </summary>
    public partial class DeleteRoleRequest : AmazonIdentityManagementServiceRequest
    {
        private string roleName;


        /// <summary>
        /// Name of the role to delete.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>1 - 64</description>
        ///     </item>
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>[\w+=,.@-]*</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string RoleName
        {
            get { return this.roleName; }
            set { this.roleName = value; }
        }

        // Check to see if RoleName property is set
        internal bool IsSetRoleName()
        {
            return this.roleName != null;
        }

    }
}
    
