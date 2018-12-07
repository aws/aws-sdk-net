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
    /// Contains information about an attached permissions boundary.
    /// 
    ///  
    /// <para>
    /// An attached permissions boundary is a managed policy that has been attached to a user
    /// or role to set the permissions boundary.
    /// </para>
    ///  
    /// <para>
    /// For more information about permissions boundaries, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/access_policies_boundaries.html">Permissions
    /// Boundaries for IAM Identities </a> in the <i>IAM User Guide</i>.
    /// </para>
    /// </summary>
    public partial class AttachedPermissionsBoundary
    {
        private string _permissionsBoundaryArn;
        private PermissionsBoundaryAttachmentType _permissionsBoundaryType;

        /// <summary>
        /// Gets and sets the property PermissionsBoundaryArn. 
        /// <para>
        ///  The ARN of the policy used to set the permissions boundary for the user or role.
        /// </para>
        /// </summary>
        public string PermissionsBoundaryArn
        {
            get { return this._permissionsBoundaryArn; }
            set { this._permissionsBoundaryArn = value; }
        }

        // Check to see if PermissionsBoundaryArn property is set
        internal bool IsSetPermissionsBoundaryArn()
        {
            return this._permissionsBoundaryArn != null;
        }

        /// <summary>
        /// Gets and sets the property PermissionsBoundaryType. 
        /// <para>
        ///  The permissions boundary usage type that indicates what type of IAM resource is used
        /// as the permissions boundary for an entity. This data type can only have a value of
        /// <code>Policy</code>.
        /// </para>
        /// </summary>
        public PermissionsBoundaryAttachmentType PermissionsBoundaryType
        {
            get { return this._permissionsBoundaryType; }
            set { this._permissionsBoundaryType = value; }
        }

        // Check to see if PermissionsBoundaryType property is set
        internal bool IsSetPermissionsBoundaryType()
        {
            return this._permissionsBoundaryType != null;
        }

    }
}