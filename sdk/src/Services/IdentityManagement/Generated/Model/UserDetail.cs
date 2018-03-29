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
    /// Contains information about an IAM user, including all the user's policies and all
    /// the IAM groups the user is in.
    /// 
    ///  
    /// <para>
    /// This data type is used as a response element in the <a>GetAccountAuthorizationDetails</a>
    /// operation.
    /// </para>
    /// </summary>
    public partial class UserDetail
    {
        private string _arn;
        private List<AttachedPolicyType> _attachedManagedPolicies = new List<AttachedPolicyType>();
        private DateTime? _createDate;
        private List<string> _groupList = new List<string>();
        private string _path;
        private string _userId;
        private string _userName;
        private List<PolicyDetail> _userPolicyList = new List<PolicyDetail>();

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
        /// Gets and sets the property AttachedManagedPolicies. 
        /// <para>
        /// A list of the managed policies attached to the user.
        /// </para>
        /// </summary>
        public List<AttachedPolicyType> AttachedManagedPolicies
        {
            get { return this._attachedManagedPolicies; }
            set { this._attachedManagedPolicies = value; }
        }

        // Check to see if AttachedManagedPolicies property is set
        internal bool IsSetAttachedManagedPolicies()
        {
            return this._attachedManagedPolicies != null && this._attachedManagedPolicies.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property CreateDate. 
        /// <para>
        /// The date and time, in <a href="http://www.iso.org/iso/iso8601">ISO 8601 date-time
        /// format</a>, when the user was created.
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
        /// Gets and sets the property GroupList. 
        /// <para>
        /// A list of IAM groups that the user is in.
        /// </para>
        /// </summary>
        public List<string> GroupList
        {
            get { return this._groupList; }
            set { this._groupList = value; }
        }

        // Check to see if GroupList property is set
        internal bool IsSetGroupList()
        {
            return this._groupList != null && this._groupList.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Path. 
        /// <para>
        /// The path to the user. For more information about paths, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/Using_Identifiers.html">IAM
        /// Identifiers</a> in the <i>Using IAM</i> guide.
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
        /// Gets and sets the property UserId. 
        /// <para>
        /// The stable and unique string identifying the user. For more information about IDs,
        /// see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/Using_Identifiers.html">IAM
        /// Identifiers</a> in the <i>Using IAM</i> guide.
        /// </para>
        /// </summary>
        public string UserId
        {
            get { return this._userId; }
            set { this._userId = value; }
        }

        // Check to see if UserId property is set
        internal bool IsSetUserId()
        {
            return this._userId != null;
        }

        /// <summary>
        /// Gets and sets the property UserName. 
        /// <para>
        /// The friendly name identifying the user.
        /// </para>
        /// </summary>
        public string UserName
        {
            get { return this._userName; }
            set { this._userName = value; }
        }

        // Check to see if UserName property is set
        internal bool IsSetUserName()
        {
            return this._userName != null;
        }

        /// <summary>
        /// Gets and sets the property UserPolicyList. 
        /// <para>
        /// A list of the inline policies embedded in the user.
        /// </para>
        /// </summary>
        public List<PolicyDetail> UserPolicyList
        {
            get { return this._userPolicyList; }
            set { this._userPolicyList = value; }
        }

        // Check to see if UserPolicyList property is set
        internal bool IsSetUserPolicyList()
        {
            return this._userPolicyList != null && this._userPolicyList.Count > 0; 
        }

    }
}