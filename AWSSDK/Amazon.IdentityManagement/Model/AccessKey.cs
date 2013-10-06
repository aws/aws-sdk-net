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

namespace Amazon.IdentityManagement.Model
{
    /// <summary>
    /// <para>The AccessKey data type contains information about an AWS access key.</para> <para> This data type is used as a response element in
    /// the actions CreateAccessKey and ListAccessKeys. </para>
    /// </summary>
    public class AccessKey  
    {
        
        private string userName;
        private string accessKeyId;
        private string status;
        private string secretAccessKey;
        private DateTime? createDate;

        /// <summary>
        /// Name of the user the key is associated with.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>1 - 64</description>
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

        /// <summary>
        /// Sets the UserName property
        /// </summary>
        /// <param name="userName">The value to set for the UserName property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public AccessKey WithUserName(string userName)
        {
            this.userName = userName;
            return this;
        }
            

        // Check to see if UserName property is set
        internal bool IsSetUserName()
        {
            return this.userName != null;       
        }

        /// <summary>
        /// The ID for this access key.
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

        /// <summary>
        /// Sets the AccessKeyId property
        /// </summary>
        /// <param name="accessKeyId">The value to set for the AccessKeyId property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public AccessKey WithAccessKeyId(string accessKeyId)
        {
            this.accessKeyId = accessKeyId;
            return this;
        }
            

        // Check to see if AccessKeyId property is set
        internal bool IsSetAccessKeyId()
        {
            return this.accessKeyId != null;       
        }

        /// <summary>
        /// The status of the access key. <c>Active</c> means the key is valid for API calls, while <c>Inactive</c> means it is not.
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
        public string Status
        {
            get { return this.status; }
            set { this.status = value; }
        }

        /// <summary>
        /// Sets the Status property
        /// </summary>
        /// <param name="status">The value to set for the Status property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public AccessKey WithStatus(string status)
        {
            this.status = status;
            return this;
        }
            

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this.status != null;       
        }

        /// <summary>
        /// The secret key used to sign requests.
        ///  
        /// </summary>
        public string SecretAccessKey
        {
            get { return this.secretAccessKey; }
            set { this.secretAccessKey = value; }
        }

        /// <summary>
        /// Sets the SecretAccessKey property
        /// </summary>
        /// <param name="secretAccessKey">The value to set for the SecretAccessKey property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public AccessKey WithSecretAccessKey(string secretAccessKey)
        {
            this.secretAccessKey = secretAccessKey;
            return this;
        }
            

        // Check to see if SecretAccessKey property is set
        internal bool IsSetSecretAccessKey()
        {
            return this.secretAccessKey != null;       
        }

        /// <summary>
        /// The date when the access key was created.
        ///  
        /// </summary>
        public DateTime CreateDate
        {
            get { return this.createDate ?? default(DateTime); }
            set { this.createDate = value; }
        }

        /// <summary>
        /// Sets the CreateDate property
        /// </summary>
        /// <param name="createDate">The value to set for the CreateDate property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public AccessKey WithCreateDate(DateTime createDate)
        {
            this.createDate = createDate;
            return this;
        }
            

        // Check to see if CreateDate property is set
        internal bool IsSetCreateDate()
        {
            return this.createDate.HasValue;       
        }
    }
}
