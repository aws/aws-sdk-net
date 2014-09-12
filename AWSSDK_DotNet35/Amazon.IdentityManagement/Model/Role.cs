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
    /// The Role data type contains information about a role.
    /// 
    ///  
    /// <para>
    ///  This data type is used as a response element in the following actions:
    /// </para>
    ///  <ul> <li>
    /// <para>
    /// <a>CreateRole</a>
    /// </para>
    /// </li> <li>
    /// <para>
    /// <a>GetRole</a>
    /// </para>
    /// </li> <li>
    /// <para>
    /// <a>ListRoles</a>
    /// </para>
    /// </li> </ul>
    /// </summary>
    public partial class Role
    {
        private string _arn;
        private string _assumeRolePolicyDocument;
        private DateTime? _createDate;
        private string _path;
        private string _roleId;
        private string _roleName;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) specifying the role. For more information about ARNs
        /// and how to use them in policies, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/Using_Identifiers.html">Identifiers
        /// for IAM Entities</a> in the <i>Using IAM</i> guide.
        /// </para>
        /// </summary>
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property AssumeRolePolicyDocument. 
        /// <para>
        /// The policy that grants an entity permission to assume the role.
        /// </para>
        ///  
        /// <para>
        /// The returned policy is URL-encoded according to RFC 3986. For more information about
        /// RFC 3986, go to <a href="http://www.faqs.org/rfcs/rfc3986.html">http://www.faqs.org/rfcs/rfc3986.html</a>.
        /// </para>
        /// </summary>
        public string AssumeRolePolicyDocument
        {
            get { return this._assumeRolePolicyDocument; }
            set { this._assumeRolePolicyDocument = value; }
        }

        // Check to see if AssumeRolePolicyDocument property is set
        internal bool IsSetAssumeRolePolicyDocument()
        {
            return this._assumeRolePolicyDocument != null;
        }

        /// <summary>
        /// Gets and sets the property CreateDate. 
        /// <para>
        /// The date when the role was created.
        /// </para>
        /// </summary>
        public DateTime CreateDate
        {
            get { return this._createDate.GetValueOrDefault(); }
            set { this._createDate = value; }
        }

        // Check to see if CreateDate property is set
        internal bool IsSetCreateDate()
        {
            return this._createDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Path. 
        /// <para>
        /// Path to the role. For more information about paths, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/Using_Identifiers.html">Identifiers
        /// for IAM Entities</a> in the <i>Using IAM</i> guide.
        /// </para>
        /// </summary>
        public string Path
        {
            get { return this._path; }
            set { this._path = value; }
        }

        // Check to see if Path property is set
        internal bool IsSetPath()
        {
            return this._path != null;
        }

        /// <summary>
        /// Gets and sets the property RoleId. 
        /// <para>
        /// The stable and unique string identifying the role. For more information about IDs,
        /// see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/Using_Identifiers.html">Identifiers
        /// for IAM Entities</a> in the <i>Using IAM</i> guide.
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
        /// The name identifying the role.
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