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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IdentityManagement.Model
{
    /// <summary>
    /// Container for the parameters to the ChangePassword operation.
    /// <para>Changes the password of the IAM user calling <c>ChangePassword</c> . The root account password is not affected by this action. For
    /// information about modifying passwords, see Managing Passwords.</para>
    /// </summary>
    /// <seealso cref="Amazon.IdentityManagement.AmazonIdentityManagementService.ChangePassword"/>
    public class ChangePasswordRequest : AmazonWebServiceRequest
    {
        private string oldPassword;
        private string newPassword;
        public string OldPassword
        {
            get { return this.oldPassword; }
            set { this.oldPassword = value; }
        }

        /// <summary>
        /// Sets the OldPassword property
        /// </summary>
        /// <param name="oldPassword">The value to set for the OldPassword property </param>
        /// <returns>this instance</returns>
        public ChangePasswordRequest WithOldPassword(string oldPassword)
        {
            this.oldPassword = oldPassword;
            return this;
        }
            

        // Check to see if OldPassword property is set
        internal bool IsSetOldPassword()
        {
            return this.oldPassword != null;       
        }
        public string NewPassword
        {
            get { return this.newPassword; }
            set { this.newPassword = value; }
        }

        /// <summary>
        /// Sets the NewPassword property
        /// </summary>
        /// <param name="newPassword">The value to set for the NewPassword property </param>
        /// <returns>this instance</returns>
        public ChangePasswordRequest WithNewPassword(string newPassword)
        {
            this.newPassword = newPassword;
            return this;
        }
            

        // Check to see if NewPassword property is set
        internal bool IsSetNewPassword()
        {
            return this.newPassword != null;       
        }
    }
}
    
