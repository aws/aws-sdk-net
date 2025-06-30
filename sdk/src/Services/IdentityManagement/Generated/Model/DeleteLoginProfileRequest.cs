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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.IdentityManagement.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteLoginProfile operation.
    /// Deletes the password for the specified IAM user or root user, For more information,
    /// see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_credentials_passwords_admin-change-user.html">Managing
    /// passwords for IAM users</a>.
    /// 
    ///  
    /// <para>
    /// You can use the CLI, the Amazon Web Services API, or the <b>Users</b> page in the
    /// IAM console to delete a password for any IAM user. You can use <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_ChangePassword.html">ChangePassword</a>
    /// to update, but not delete, your own password in the <b>My Security Credentials</b>
    /// page in the Amazon Web Services Management Console.
    /// </para>
    ///  <important> 
    /// <para>
    /// Deleting a user's password does not prevent a user from accessing Amazon Web Services
    /// through the command line interface or the API. To prevent all user access, you must
    /// also either make any access keys inactive or delete them. For more information about
    /// making keys inactive or deleting them, see <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_UpdateAccessKey.html">UpdateAccessKey</a>
    /// and <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_DeleteAccessKey.html">DeleteAccessKey</a>.
    /// </para>
    ///  </important>
    /// </summary>
    public partial class DeleteLoginProfileRequest : AmazonIdentityManagementServiceRequest
    {
        private string _userName;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public DeleteLoginProfileRequest() { }

        /// <summary>
        /// Instantiates DeleteLoginProfileRequest with the parameterized properties
        /// </summary>
        /// <param name="userName">The name of the user whose password you want to delete. This parameter is optional. If no user name is included, it defaults to the principal making the request. When you make this request with root user credentials, you must use an <a href="https://docs.aws.amazon.com/STS/latest/APIReference/API_AssumeRoot.html">AssumeRoot</a> session to omit the user name. This parameter allows (through its <a href="http://wikipedia.org/wiki/regex">regex pattern</a>) a string of characters consisting of upper and lowercase alphanumeric characters with no spaces. You can also include any of the following characters: _+=,.@-</param>
        public DeleteLoginProfileRequest(string userName)
        {
            _userName = userName;
        }

        /// <summary>
        /// Gets and sets the property UserName. 
        /// <para>
        /// The name of the user whose password you want to delete.
        /// </para>
        ///  
        /// <para>
        /// This parameter is optional. If no user name is included, it defaults to the principal
        /// making the request. When you make this request with root user credentials, you must
        /// use an <a href="https://docs.aws.amazon.com/STS/latest/APIReference/API_AssumeRoot.html">AssumeRoot</a>
        /// session to omit the user name.
        /// </para>
        ///  
        /// <para>
        /// This parameter allows (through its <a href="http://wikipedia.org/wiki/regex">regex
        /// pattern</a>) a string of characters consisting of upper and lowercase alphanumeric
        /// characters with no spaces. You can also include any of the following characters: _+=,.@-
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
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