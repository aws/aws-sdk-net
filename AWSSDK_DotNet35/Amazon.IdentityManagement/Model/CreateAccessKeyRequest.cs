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
    /// Container for the parameters to the CreateAccessKey operation.
    /// Creates a new AWS secret access key and corresponding AWS access key ID for the specified            user.
    /// The default status for new keys is <code>Active</code>.
    /// 
    ///         
    /// <para>
    /// If you do not specify a user name, IAM determines the user name implicitly based on
    /// the AWS            access key ID signing the request. Because this action works for access
    /// keys under the AWS            account, you can use this API to manage root credentials even
    /// if the AWS account has no            associated users.
    /// </para>
    ///         
    /// <para>
    /// For information about limits on the number of keys you can create, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/LimitationsOnEntities.html"
    /// target="_blank">Limitations on IAM Entities</a> in <i>Using AWS Identity and Access                Management</i>.
    /// </para>
    ///         <important>To ensure the security of your AWS account, the secret access key is
    /// accessible only            during key and user creation. You must save the key (for example,
    /// in a text file) if you want            to be able to access it again. If a secret key is lost,
    /// you can delete the access keys for the            associated user and then create new keys.</important>
    /// </summary>
    public partial class CreateAccessKeyRequest : AmazonIdentityManagementServiceRequest
    {
        private string _userName;


        /// <summary>
        /// Gets and sets the property UserName. 
        /// <para>
        /// The user name that the new key will belong to.
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