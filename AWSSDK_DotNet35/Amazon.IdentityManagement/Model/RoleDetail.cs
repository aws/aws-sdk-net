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
    /// 
    /// </summary>
    public partial class RoleDetail
    {
        private string _arn;
        private string _assumeRolePolicyDocument;
        private DateTime? _createDate;
        private List<InstanceProfile> _instanceProfileList = new List<InstanceProfile>();
        private string _path;
        private string _roleId;
        private string _roleName;
        private List<PolicyDetail> _rolePolicyList = new List<PolicyDetail>();

        /// <summary>
        /// Gets and sets the property Arn.
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
        /// Gets and sets the property InstanceProfileList.
        /// </summary>
        public List<InstanceProfile> InstanceProfileList
        {
            get { return this._instanceProfileList; }
            set { this._instanceProfileList = value; }
        }

        // Check to see if InstanceProfileList property is set
        internal bool IsSetInstanceProfileList()
        {
            return this._instanceProfileList != null && this._instanceProfileList.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Path.
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

        /// <summary>
        /// Gets and sets the property RolePolicyList.
        /// </summary>
        public List<PolicyDetail> RolePolicyList
        {
            get { return this._rolePolicyList; }
            set { this._rolePolicyList = value; }
        }

        // Check to see if RolePolicyList property is set
        internal bool IsSetRolePolicyList()
        {
            return this._rolePolicyList != null && this._rolePolicyList.Count > 0; 
        }

    }
}