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
    /// Container for the parameters to the AddRoleToInstanceProfile operation.
    /// <para>Adds the specified role to the specified instance profile.</para>
    /// </summary>
    /// <seealso cref="Amazon.IdentityManagement.AmazonIdentityManagementService.AddRoleToInstanceProfile"/>
    public class AddRoleToInstanceProfileRequest : AmazonWebServiceRequest
    {
        private string instanceProfileName;
        private string roleName;

        /// <summary>
        /// Name of the instance profile to update.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>1 - 128</description>
        ///     </item>
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>[\w+=,.@-]*</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string InstanceProfileName
        {
            get { return this.instanceProfileName; }
            set { this.instanceProfileName = value; }
        }

        /// <summary>
        /// Sets the InstanceProfileName property
        /// </summary>
        /// <param name="instanceProfileName">The value to set for the InstanceProfileName property </param>
        /// <returns>this instance</returns>
        public AddRoleToInstanceProfileRequest WithInstanceProfileName(string instanceProfileName)
        {
            this.instanceProfileName = instanceProfileName;
            return this;
        }
            

        // Check to see if InstanceProfileName property is set
        internal bool IsSetInstanceProfileName()
        {
            return this.instanceProfileName != null;       
        }

        /// <summary>
        /// Name of the role to add.
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

        /// <summary>
        /// Sets the RoleName property
        /// </summary>
        /// <param name="roleName">The value to set for the RoleName property </param>
        /// <returns>this instance</returns>
        public AddRoleToInstanceProfileRequest WithRoleName(string roleName)
        {
            this.roleName = roleName;
            return this;
        }
            

        // Check to see if RoleName property is set
        internal bool IsSetRoleName()
        {
            return this.roleName != null;       
        }
    }
}
    
