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
    /// Container for the parameters to the DeleteAccessKey operation.
    /// <para>Deletes the access key associated with the specified user.</para> <para>If you do not specify a user name, IAM determines the user
    /// name implicitly based on the AWS access key ID signing the request. Because this action works for access keys under the AWS account, you can
    /// use this API to manage root credentials even if the AWS account has no associated users.</para>
    /// </summary>
    public partial class DeleteAccessKeyRequest : AmazonIdentityManagementServiceRequest
    {
        private string userName;
        private string accessKeyId;


        /// <summary>
        /// Name of the user whose key you want to delete.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>1 - 128</description>
        ///     </item>
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>[\w+=,.@-]*</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string UserName
        {
            get { return this.userName; }
            set { this.userName = value; }
        }

        // Check to see if UserName property is set
        internal bool IsSetUserName()
        {
            return this.userName != null;
        }

        /// <summary>
        /// The access key ID for the access key ID and secret access key you want to delete.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>16 - 32</description>
        ///     </item>
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>[\w]*</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string AccessKeyId
        {
            get { return this.accessKeyId; }
            set { this.accessKeyId = value; }
        }

        // Check to see if AccessKeyId property is set
        internal bool IsSetAccessKeyId()
        {
            return this.accessKeyId != null;
        }

    }
}
    
