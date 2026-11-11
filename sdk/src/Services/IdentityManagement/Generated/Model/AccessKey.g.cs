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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// Contains information about an Amazon Web Services access key.
    /// 
    ///  
    /// <para>
    ///  This data type is used as a response element in the <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_CreateAccessKey.html">CreateAccessKey</a>
    /// and <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_ListAccessKeys.html">ListAccessKeys</a>
    /// operations. 
    /// </para>
    ///  <note> 
    /// <para>
    /// The <c>SecretAccessKey</c> value is returned only in response to <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_CreateAccessKey.html">CreateAccessKey</a>.
    /// You can get a secret access key only when you first create an access key; you cannot
    /// recover the secret access key later. If you lose a secret access key, you must create
    /// a new access key.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class AccessKey
    {
        /// <summary>
        /// Empty constructor used to set properties independently even when a simple constructor is available
        /// </summary>
        public AccessKey() { }

        /// <summary>
        /// Instantiates AccessKey with the parameterized properties
        /// </summary>
        /// <param name="userName">The name of the IAM user that the access key is associated with.</param>
        /// <param name="accessKeyId">The ID for this access key.</param>
        /// <param name="status">The status of the access key. <c>Active</c> means that the key is valid for API   calls, while <c>Inactive</c> means it is not. </param>
        /// <param name="secretAccessKey">The secret key used to sign requests.</param>
        public AccessKey(string userName, string accessKeyId, StatusType status, string secretAccessKey)
        {
            this.UserName = userName;
            this.AccessKeyId = accessKeyId;
            this.Status = status;
            this.SecretAccessKey = secretAccessKey;
        }

        /// <summary>
        /// Gets and sets the property AccessKeyId. 
        /// <para>
        /// The ID for this access key.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 16, Max = 128)]
        public string AccessKeyId { get; set; }

        /// <summary>
        /// Checks to see if the AccessKeyId property is set.
        /// </summary>
        internal bool IsSetAccessKeyId() => this.AccessKeyId != null;

        /// <summary>
        /// Gets and sets the property CreateDate. 
        /// <para>
        /// The date when the access key was created.
        /// </para>
        /// </summary>
        public DateTime? CreateDate { get; set; }

        /// <summary>
        /// Checks to see if the CreateDate property is set.
        /// </summary>
        internal bool IsSetCreateDate() => this.CreateDate.HasValue;

        /// <summary>
        /// Gets and sets the property SecretAccessKey. 
        /// <para>
        /// The secret key used to sign requests.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true)]
        public string SecretAccessKey { get; set; }

        /// <summary>
        /// Checks to see if the SecretAccessKey property is set.
        /// </summary>
        internal bool IsSetSecretAccessKey() => this.SecretAccessKey != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the access key. <c>Active</c> means that the key is valid for API calls,
        /// while <c>Inactive</c> means it is not. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public StatusType Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property UserName. 
        /// <para>
        /// The name of the IAM user that the access key is associated with.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string UserName { get; set; }

        /// <summary>
        /// Checks to see if the UserName property is set.
        /// </summary>
        internal bool IsSetUserName() => this.UserName != null;
    }
}
