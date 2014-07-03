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
    /// Container for the parameters to the DeleteAccessKey operation.
    /// Deletes the access key associated with the specified user.
    /// 
    ///         
    /// <para>
    /// If you do not specify a user name, IAM determines the user name implicitly based on
    /// the AWS            access key ID signing the request. Because this action works for access
    /// keys under the AWS            account, you can use this API to manage root credentials even
    /// if the AWS account has no            associated users.
    /// </para>
    /// </summary>
    public partial class DeleteAccessKeyRequest : AmazonWebServiceRequest
    {
        private string _accessKeyId;
        private string _userName;


        /// <summary>
        /// Gets and sets the property AccessKeyId. 
        /// <para>
        /// The access key ID for the access key ID and secret access key you want to delete.
        /// </para>
        /// </summary>
        public string AccessKeyId
        {
            get { return this._accessKeyId; }
            set { this._accessKeyId = value; }
        }


        /// <summary>
        /// Sets the AccessKeyId property
        /// </summary>
        /// <param name="accessKeyId">The value to set for the AccessKeyId property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DeleteAccessKeyRequest WithAccessKeyId(string accessKeyId)
        {
            this._accessKeyId = accessKeyId;
            return this;
        }

        // Check to see if AccessKeyId property is set
        internal bool IsSetAccessKeyId()
        {
            return this._accessKeyId != null;
        }


        /// <summary>
        /// Gets and sets the property UserName. 
        /// <para>
        /// Name of the user whose key you want to delete.
        /// </para>
        /// </summary>
        public string UserName
        {
            get { return this._userName; }
            set { this._userName = value; }
        }


        /// <summary>
        /// Sets the UserName property
        /// </summary>
        /// <param name="userName">The value to set for the UserName property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DeleteAccessKeyRequest WithUserName(string userName)
        {
            this._userName = userName;
            return this;
        }

        // Check to see if UserName property is set
        internal bool IsSetUserName()
        {
            return this._userName != null;
        }

    }
}