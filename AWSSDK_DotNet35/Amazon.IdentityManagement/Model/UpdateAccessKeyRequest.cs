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
    /// Container for the parameters to the UpdateAccessKey operation.
    /// <para>Changes the status of the specified access key from Active to Inactive, or vice versa. This action can be used to disable a user's key
    /// as part of a key rotation work flow.</para> <para>If the <c>UserName</c> field is not specified, the UserName is determined implicitly based
    /// on the AWS access key ID used to sign the request. Because this action works for access keys under the AWS account, this API can be used to
    /// manage root credentials even if the AWS account has no associated users.</para> <para>For information about rotating keys, see <a
    /// href="http://docs.aws.amazon.com/IAM/latest/UserGuide/index.html?ManagingCredentials.html" >Managing Keys and Certificates</a> in <i>Using
    /// AWS Identity and Access Management</i> .</para>
    /// </summary>
    public partial class UpdateAccessKeyRequest : AmazonIdentityManagementServiceRequest
    {
        private string userName;
        private string accessKeyId;
        private StatusType status;


        /// <summary>
        /// Name of the user whose key you want to update.
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
        /// The access key ID of the secret access key you want to update.
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

        /// <summary>
        /// The status you want to assign to the secret access key. <c>Active</c> means the key can be used for API calls to AWS, while <c>Inactive</c>
        /// means the key cannot be used.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Allowed Values</term>
        ///         <description>Active, Inactive</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public StatusType Status
        {
            get { return this.status; }
            set { this.status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this.status != null;
        }

    }
}
    
