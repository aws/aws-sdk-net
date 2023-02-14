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
 * Do not modify this file. This file is generated from the iam-2010-05-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IdentityManagement.Model
{
    /// <summary>
    /// Container for the parameters to the ChangePassword operation.
    /// Changes the password of the IAM user who is calling this operation. This operation
    /// can be performed using the CLI, the Amazon Web Services API, or the <b>My Security
    /// Credentials</b> page in the Amazon Web Services Management Console. The Amazon Web
    /// Services account root user password is not affected by this operation.
    /// 
    ///  
    /// <para>
    /// Use <a>UpdateLoginProfile</a> to use the CLI, the Amazon Web Services API, or the
    /// <b>Users</b> page in the IAM console to change the password for any IAM user. For
    /// more information about modifying passwords, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/Using_ManagingLogins.html">Managing
    /// passwords</a> in the <i>IAM User Guide</i>.
    /// </para>
    /// </summary>
    public partial class ChangePasswordRequest : AmazonIdentityManagementServiceRequest
    {
        private string _newPassword;
        private string _oldPassword;

        /// <summary>
        /// Gets and sets the property NewPassword. 
        /// <para>
        /// The new password. The new password must conform to the Amazon Web Services account's
        /// password policy, if one exists.
        /// </para>
        ///  
        /// <para>
        /// The <a href="http://wikipedia.org/wiki/regex">regex pattern</a> that is used to validate
        /// this parameter is a string of characters. That string can include almost any printable
        /// ASCII character from the space (<code>\u0020</code>) through the end of the ASCII
        /// character range (<code>\u00FF</code>). You can also include the tab (<code>\u0009</code>),
        /// line feed (<code>\u000A</code>), and carriage return (<code>\u000D</code>) characters.
        /// Any of these characters are valid in a password. However, many tools, such as the
        /// Amazon Web Services Management Console, might restrict the ability to type certain
        /// characters because they have special meaning within that tool.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=1, Max=128)]
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
        /// <para>
        /// The IAM user's current password.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=1, Max=128)]
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