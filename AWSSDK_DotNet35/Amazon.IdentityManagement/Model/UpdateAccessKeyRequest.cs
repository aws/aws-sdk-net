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
    /// Container for the parameters to the UpdateAccessKey operation.
    /// Changes the status of the specified access key from Active to Inactive, or vice versa.
    /// This            action can be used to disable a user's key as part of a key rotation work flow.
    /// 
    ///         
    /// <para>
    /// If the <code>UserName</code> field is not specified, the UserName is determined implicitly            based
    /// on the AWS access key ID used to sign the request. Because this action works for access            keys
    /// under the AWS account, this API can be used to manage root credentials even if the
    /// AWS            account has no associated users.
    /// </para>
    ///         
    /// <para>
    /// For information about rotating keys, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/ManagingCredentials.html"
    /// target="_blank">Managing Keys and Certificates</a> in <i>Using AWS Identity and Access                Management</i>.
    /// </para>
    /// </summary>
    public partial class UpdateAccessKeyRequest : AmazonIdentityManagementServiceRequest
    {
        private string _accessKeyId;
        private StatusType _status;
        private string _userName;


        /// <summary>
        /// Gets and sets the property AccessKeyId. 
        /// <para>
        /// The access key ID of the secret access key you want to update.
        /// </para>
        /// </summary>
        public string AccessKeyId
        {
            get { return this._accessKeyId; }
            set { this._accessKeyId = value; }
        }

        // Check to see if AccessKeyId property is set
        internal bool IsSetAccessKeyId()
        {
            return this._accessKeyId != null;
        }


        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status you want to assign to the secret access key. <code>Active</code> means
        /// the key can            be used for API calls to AWS, while <code>Inactive</code> means the
        /// key cannot be used.
        /// </para>
        /// </summary>
        public StatusType Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }


        /// <summary>
        /// Gets and sets the property UserName. 
        /// <para>
        /// Name of the user whose key you want to update.
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