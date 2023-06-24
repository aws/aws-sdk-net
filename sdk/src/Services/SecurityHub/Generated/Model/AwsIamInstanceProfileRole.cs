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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Information about a role associated with an instance profile.
    /// </summary>
    public partial class AwsIamInstanceProfileRole
    {
        private string _arn;
        private string _assumeRolePolicyDocument;
        private string _createDate;
        private string _path;
        private string _roleId;
        private string _roleName;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The ARN of the role.
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
        /// </summary>
        [AWSProperty(Min=1, Max=131072)]
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
        /// Indicates when the role was created.
        /// </para>
        ///  
        /// <para>
        /// Uses the <code>date-time</code> format specified in <a href="https://tools.ietf.org/html/rfc3339#section-5.6">RFC
        /// 3339 section 5.6, Internet Date/Time Format</a>. The value cannot contain spaces,
        /// and date and time should be separated by <code>T</code>. For example, <code>2020-03-22T13:22:13.933Z</code>.
        /// </para>
        /// </summary>
        public string CreateDate
        {
            get { return this._createDate; }
            set { this._createDate = value; }
        }

        // Check to see if CreateDate property is set
        internal bool IsSetCreateDate()
        {
            return this._createDate != null;
        }

        /// <summary>
        /// Gets and sets the property Path. 
        /// <para>
        /// The path to the role.
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
        /// The identifier of the role.
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
        /// The name of the role.
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