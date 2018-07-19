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
 * Do not modify this file. This file is generated from the opsworks-2013-02-18.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.OpsWorks.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateUserProfile operation.
    /// Updates a specified user profile.
    /// 
    ///  
    /// <para>
    ///  <b>Required Permissions</b>: To use this action, an IAM user must have an attached
    /// policy that explicitly grants permissions. For more information about user permissions,
    /// see <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html">Managing
    /// User Permissions</a>.
    /// </para>
    /// </summary>
    public partial class UpdateUserProfileRequest : AmazonOpsWorksRequest
    {
        private bool? _allowSelfManagement;
        private string _iamUserArn;
        private string _sshPublicKey;
        private string _sshUsername;

        /// <summary>
        /// Gets and sets the property AllowSelfManagement. 
        /// <para>
        /// Whether users can specify their own SSH public key through the My Settings page. For
        /// more information, see <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/security-settingsshkey.html">Managing
        /// User Permissions</a>.
        /// </para>
        /// </summary>
        public bool AllowSelfManagement
        {
            get { return this._allowSelfManagement.GetValueOrDefault(); }
            set { this._allowSelfManagement = value; }
        }

        // Check to see if AllowSelfManagement property is set
        internal bool IsSetAllowSelfManagement()
        {
            return this._allowSelfManagement.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IamUserArn. 
        /// <para>
        /// The user IAM ARN. This can also be a federated user's ARN.
        /// </para>
        /// </summary>
        public string IamUserArn
        {
            get { return this._iamUserArn; }
            set { this._iamUserArn = value; }
        }

        // Check to see if IamUserArn property is set
        internal bool IsSetIamUserArn()
        {
            return this._iamUserArn != null;
        }

        /// <summary>
        /// Gets and sets the property SshPublicKey. 
        /// <para>
        /// The user's new SSH public key.
        /// </para>
        /// </summary>
        public string SshPublicKey
        {
            get { return this._sshPublicKey; }
            set { this._sshPublicKey = value; }
        }

        // Check to see if SshPublicKey property is set
        internal bool IsSetSshPublicKey()
        {
            return this._sshPublicKey != null;
        }

        /// <summary>
        /// Gets and sets the property SshUsername. 
        /// <para>
        /// The user's SSH user name. The allowable characters are [a-z], [A-Z], [0-9], '-', and
        /// '_'. If the specified name includes other punctuation marks, AWS OpsWorks Stacks removes
        /// them. For example, <code>my.name</code> will be changed to <code>myname</code>. If
        /// you do not specify an SSH user name, AWS OpsWorks Stacks generates one from the IAM
        /// user name. 
        /// </para>
        /// </summary>
        public string SshUsername
        {
            get { return this._sshUsername; }
            set { this._sshUsername = value; }
        }

        // Check to see if SshUsername property is set
        internal bool IsSetSshUsername()
        {
            return this._sshUsername != null;
        }

    }
}