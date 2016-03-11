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
    /// Container for the parameters to the UpdateUser operation.
    /// Updates the name and/or the path of the specified user.
    /// 
    ///  <important> You should understand the implications of changing a user's path or name.
    /// For more information, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/id_users_manage.html#id_users_renaming">Renaming
    /// an IAM User</a> and <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/id_groups_manage_rename.html">Renaming
    /// an IAM Group</a> in the <i>IAM User Guide</i>. </important> <note> To change a user
    /// name the requester must have appropriate permissions on both the source object and
    /// the target object. For example, to change Bob to Robert, the entity making the request
    /// must have permission on Bob and Robert, or must have permission on all (*). For more
    /// information about permissions, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/PermissionsAndPolicies.html"
    /// target="blank">Permissions and Policies</a>. </note>
    /// </summary>
    public partial class UpdateUserRequest : AmazonIdentityManagementServiceRequest
    {
        private string _newPath;
        private string _newUserName;
        private string _userName;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public UpdateUserRequest() { }

        /// <summary>
        /// Instantiates UpdateUserRequest with the parameterized properties
        /// </summary>
        /// <param name="userName">Name of the user to update. If you're changing the name of the user, this is the original user name. </param>
        public UpdateUserRequest(string userName)
        {
            _userName = userName;
        }

        /// <summary>
        /// Gets and sets the property NewPath. 
        /// <para>
        /// New path for the user. Include this parameter only if you're changing the user's path.
        /// </para>
        /// </summary>
        public string NewPath
        {
            get { return this._newPath; }
            set { this._newPath = value; }
        }

        // Check to see if NewPath property is set
        internal bool IsSetNewPath()
        {
            return this._newPath != null;
        }

        /// <summary>
        /// Gets and sets the property NewUserName. 
        /// <para>
        /// New name for the user. Include this parameter only if you're changing the user's name.
        /// </para>
        /// </summary>
        public string NewUserName
        {
            get { return this._newUserName; }
            set { this._newUserName = value; }
        }

        // Check to see if NewUserName property is set
        internal bool IsSetNewUserName()
        {
            return this._newUserName != null;
        }

        /// <summary>
        /// Gets and sets the property UserName. 
        /// <para>
        /// Name of the user to update. If you're changing the name of the user, this is the original
        /// user name. 
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

    }
}