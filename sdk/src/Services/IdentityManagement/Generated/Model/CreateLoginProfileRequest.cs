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
    /// Container for the parameters to the CreateLoginProfile operation.
    /// Creates a password for the specified user, giving the user the ability to access
    /// AWS services through the AWS Management Console. For more information about managing
    /// passwords, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/Using_ManagingLogins.html">Managing
    /// Passwords</a> in the <i>IAM User Guide</i>.
    /// </summary>
    public partial class CreateLoginProfileRequest : AmazonIdentityManagementServiceRequest
    {
        private string _password;
        private bool? _passwordResetRequired;
        private string _userName;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public CreateLoginProfileRequest() { }

        /// <summary>
        /// Instantiates CreateLoginProfileRequest with the parameterized properties
        /// </summary>
        /// <param name="userName">The name of the IAM user to create a password for. The user must already exist. This parameter allows (per its <a href="http://wikipedia.org/wiki/regex">regex pattern</a>) a string of characters consisting of upper and lowercase alphanumeric characters with no spaces. You can also include any of the following characters: _+=,.@-</param>
        /// <param name="password">The new password for the user. The <a href="http://wikipedia.org/wiki/regex">regex pattern</a> that is used to validate this parameter is a string of characters. That string can include almost any printable ASCII character from the space (\u0020) through the end of the ASCII character range (\u00FF). You can also include the tab (\u0009), line feed (\u000A), and carriage return (\u000D) characters. Any of these characters are valid in a password. However, many tools, such as the AWS Management Console, might restrict the ability to type certain characters because they have special meaning within that tool.</param>
        public CreateLoginProfileRequest(string userName, string password)
        {
            _userName = userName;
            _password = password;
        }

        /// <summary>
        /// Gets and sets the property Password. 
        /// <para>
        /// The new password for the user.
        /// </para>
        ///  
        /// <para>
        /// The <a href="http://wikipedia.org/wiki/regex">regex pattern</a> that is used to validate
        /// this parameter is a string of characters. That string can include almost any printable
        /// ASCII character from the space (\u0020) through the end of the ASCII character range
        /// (\u00FF). You can also include the tab (\u0009), line feed (\u000A), and carriage
        /// return (\u000D) characters. Any of these characters are valid in a password. However,
        /// many tools, such as the AWS Management Console, might restrict the ability to type
        /// certain characters because they have special meaning within that tool.
        /// </para>
        /// </summary>
        public string Password
        {
            get { return this._password; }
            set { this._password = value; }
        }

        // Check to see if Password property is set
        internal bool IsSetPassword()
        {
            return this._password != null;
        }

        /// <summary>
        /// Gets and sets the property PasswordResetRequired. 
        /// <para>
        /// Specifies whether the user is required to set a new password on next sign-in.
        /// </para>
        /// </summary>
        public bool PasswordResetRequired
        {
            get { return this._passwordResetRequired.GetValueOrDefault(); }
            set { this._passwordResetRequired = value; }
        }

        // Check to see if PasswordResetRequired property is set
        internal bool IsSetPasswordResetRequired()
        {
            return this._passwordResetRequired.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property UserName. 
        /// <para>
        /// The name of the IAM user to create a password for. The user must already exist.
        /// </para>
        ///  
        /// <para>
        /// This parameter allows (per its <a href="http://wikipedia.org/wiki/regex">regex pattern</a>)
        /// a string of characters consisting of upper and lowercase alphanumeric characters with
        /// no spaces. You can also include any of the following characters: _+=,.@-
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