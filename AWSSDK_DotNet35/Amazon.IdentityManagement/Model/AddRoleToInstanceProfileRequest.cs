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
    /// Container for the parameters to the AddRoleToInstanceProfile operation.
    /// Adds the specified role to the specified instance profile. For more information about
    /// roles, go to <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/WorkingWithRoles.html">Working
    /// with Roles</a>. For more information about instance profiles, go to <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/AboutInstanceProfiles.html">About
    /// Instance Profiles</a>.
    /// </summary>
    public partial class AddRoleToInstanceProfileRequest : AmazonIdentityManagementServiceRequest
    {
        private string _instanceProfileName;
        private string _roleName;


        /// <summary>
        /// Gets and sets the property InstanceProfileName. 
        /// <para>
        /// Name of the instance profile to update.
        /// </para>
        /// </summary>
        public string InstanceProfileName
        {
            get { return this._instanceProfileName; }
            set { this._instanceProfileName = value; }
        }

        // Check to see if InstanceProfileName property is set
        internal bool IsSetInstanceProfileName()
        {
            return this._instanceProfileName != null;
        }


        /// <summary>
        /// Gets and sets the property RoleName. 
        /// <para>
        /// Name of the role to add.
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