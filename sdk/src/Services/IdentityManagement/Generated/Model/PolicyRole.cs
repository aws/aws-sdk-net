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
    /// Contains information about a role that a managed policy is attached to.
    /// 
    ///  
    /// <para>
    /// This data type is used as a response element in the <a>ListEntitiesForPolicy</a> action.
    /// 
    /// </para>
    ///  
    /// <para>
    /// For more information about managed policies, refer to <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/policies-managed-vs-inline.html">Managed
    /// Policies and Inline Policies</a> in the <i>Using IAM</i> guide. 
    /// </para>
    /// </summary>
    public partial class PolicyRole
    {
        private string _roleId;
        private string _roleName;

        /// <summary>
        /// Gets and sets the property RoleId. 
        /// <para>
        /// The stable and unique string identifying the role. For more information about IDs,
        /// see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/reference_identifiers.html">IAM
        /// Identifiers</a> in the <i>IAM User Guide</i>.
        /// </para>
        /// </summary>
        public string RoleId
        {
            get { return this._roleId; }
            set { this._roleId = value; }
        }

        // Check to see if RoleId property is set
        internal bool IsSetRoleId()
        {
            return this._roleId != null;
        }

        /// <summary>
        /// Gets and sets the property RoleName. 
        /// <para>
        /// The name (friendly name, not ARN) identifying the role.
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