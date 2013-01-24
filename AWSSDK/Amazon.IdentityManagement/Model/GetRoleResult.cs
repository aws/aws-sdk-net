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

namespace Amazon.IdentityManagement.Model
{
    /// <summary>
    /// <para>Contains the result of a successful invocation of the GetRoleResponse action.</para>
    /// </summary>
    public class GetRoleResult  
    {
        
        private Role role;

        /// <summary>
        /// Information about the role.
        ///  
        /// </summary>
        public Role Role
        {
            get { return this.role; }
            set { this.role = value; }
        }

        /// <summary>
        /// Sets the Role property
        /// </summary>
        /// <param name="role">The value to set for the Role property </param>
        /// <returns>this instance</returns>
        public GetRoleResult WithRole(Role role)
        {
            this.role = role;
            return this;
        }
            

        // Check to see if Role property is set
        internal bool IsSetRole()
        {
            return this.role != null;       
        }
    }
}
