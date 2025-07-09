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
    /// Container for the parameters to the DeleteUser operation.
    /// Deletes the specified IAM user. Unlike the Amazon Web Services Management Console,
    /// when you delete a user programmatically, you must delete the items attached to the
    /// user manually, or the deletion fails. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_users_manage.html#id_users_deleting_cli">Deleting
    /// an IAM user</a>. Before attempting to delete a user, remove the following items:
    /// 
    ///  <ul> <li> 
    /// <para>
    /// Password (<a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_DeleteLoginProfile.html">DeleteLoginProfile</a>)
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Access keys (<a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_DeleteAccessKey.html">DeleteAccessKey</a>)
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Signing certificate (<a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_DeleteSigningCertificate.html">DeleteSigningCertificate</a>)
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// SSH public key (<a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_DeleteSSHPublicKey.html">DeleteSSHPublicKey</a>)
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Git credentials (<a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_DeleteServiceSpecificCredential.html">DeleteServiceSpecificCredential</a>)
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Multi-factor authentication (MFA) device (<a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_DeactivateMFADevice.html">DeactivateMFADevice</a>,
    /// <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_DeleteVirtualMFADevice.html">DeleteVirtualMFADevice</a>)
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Inline policies (<a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_DeleteUserPolicy.html">DeleteUserPolicy</a>)
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Attached managed policies (<a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_DetachUserPolicy.html">DetachUserPolicy</a>)
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Group memberships (<a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_RemoveUserFromGroup.html">RemoveUserFromGroup</a>)
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class DeleteUserRequest : AmazonIdentityManagementServiceRequest
    {
        private string _userName;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public DeleteUserRequest() { }

        /// <summary>
        /// Instantiates DeleteUserRequest with the parameterized properties
        /// </summary>
        /// <param name="userName">The name of the user to delete. This parameter allows (through its <a href="http://wikipedia.org/wiki/regex">regex pattern</a>) a string of characters consisting of upper and lowercase alphanumeric characters with no spaces. You can also include any of the following characters: _+=,.@-</param>
        public DeleteUserRequest(string userName)
        {
            _userName = userName;
        }

        /// <summary>
        /// Gets and sets the property UserName. 
        /// <para>
        /// The name of the user to delete.
        /// </para>
        ///  
        /// <para>
        /// This parameter allows (through its <a href="http://wikipedia.org/wiki/regex">regex
        /// pattern</a>) a string of characters consisting of upper and lowercase alphanumeric
        /// characters with no spaces. You can also include any of the following characters: _+=,.@-
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
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