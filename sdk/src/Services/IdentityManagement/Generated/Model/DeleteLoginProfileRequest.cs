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
    /// Container for the parameters to the DeleteLoginProfile operation.
    /// Deletes the password for the specified IAM user, which terminates the user's ability
    /// to access AWS services through the AWS Management Console.
    /// 
    ///  <important> 
    /// <para>
    ///  Deleting a user's password does not prevent a user from accessing AWS through the
    /// command line interface or the API. To prevent all user access you must also either
    /// make any access keys inactive or delete them. For more information about making keys
    /// inactive or deleting them, see <a>UpdateAccessKey</a> and <a>DeleteAccessKey</a>.
    /// 
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
        /// <param name="userName">The name of the user whose password you want to delete. This parameter allows (per its <a href="http://wikipedia.org/wiki/regex">regex pattern</a>) a string of characters consisting of upper and lowercase alphanumeric characters with no spaces. You can also include any of the following characters: _+=,.@-</param>
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