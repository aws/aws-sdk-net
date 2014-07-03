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
    /// Container for the parameters to the ChangePassword operation.
    /// Changes the password of the IAM user calling <code>ChangePassword</code>. The root
    /// account            password is not affected by this action. For information about modifying
    /// passwords, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/Using_ManagingLogins.html"
    /// target="_blank">Managing Passwords</a>.
    /// </summary>
    public partial class ChangePasswordRequest : AmazonIdentityManagementServiceRequest
    {
        private string _newPassword;
        private string _oldPassword;


        /// <summary>
        /// Gets and sets the property NewPassword.
        /// </summary>
        public string NewPassword
        {
            get { return this._newPassword; }
            set { this._newPassword = value; }
        }

        // Check to see if NewPassword property is set
        internal bool IsSetNewPassword()
        {
            return this._newPassword != null;
        }


        /// <summary>
        /// Gets and sets the property OldPassword.
        /// </summary>
        public string OldPassword
        {
            get { return this._oldPassword; }
            set { this._oldPassword = value; }
        }

        // Check to see if OldPassword property is set
        internal bool IsSetOldPassword()
        {
            return this._oldPassword != null;
        }

    }
}