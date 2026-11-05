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

namespace Amazon.Lightsail.Model
{
    /// <summary>
    /// Describes an access key for an Amazon Lightsail bucket.
    /// 
    ///  
    /// <para>
    /// Access keys grant full programmatic access to the specified bucket and its objects.
    /// You can have a maximum of two access keys per bucket. Use the <a href="https://docs.aws.amazon.com/lightsail/2016-11-28/api-reference/API_CreateBucketAccessKey.html">CreateBucketAccessKey</a>
    /// action to create an access key for a specific bucket. For more information about access
    /// keys, see <a href="https://docs.aws.amazon.com/lightsail/latest/userguide/amazon-lightsail-creating-bucket-access-keys">Creating
    /// access keys for a bucket in Amazon Lightsail</a> in the <i>Amazon Lightsail Developer
    /// Guide</i>.
    /// </para>
    ///  <important> 
    /// <para>
    /// The <c>secretAccessKey</c> value is returned only in response to the <c>CreateBucketAccessKey</c>
    /// action. You can get a secret access key only when you first create an access key;
    /// you cannot get the secret access key later. If you lose the secret access key, you
    /// must create a new access key.
    /// </para>
    ///  </important>
    /// </summary>
    public partial class AccessKey
    {
        /// <summary>
        /// Gets and sets the property AccessKeyId. 
        /// <para>
        /// The ID of the access key.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 20, Max = 20)]
        public string AccessKeyId { get; set; }

        /// <summary>
        /// Checks to see if the AccessKeyId property is set.
        /// </summary>
        internal bool IsSetAccessKeyId() => this.AccessKeyId != null;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The timestamp when the access key was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property LastUsed. 
        /// <para>
        /// An object that describes the last time the access key was used.
        /// </para>
        ///  <note> 
        /// <para>
        /// This object does not include data in the response of a <a href="https://docs.aws.amazon.com/lightsail/2016-11-28/api-reference/API_CreateBucketAccessKey.html">CreateBucketAccessKey</a>
        /// action. If the access key has not been used, the <c>region</c> and <c>serviceName</c>
        /// values are <c>N/A</c>, and the <c>lastUsedDate</c> value is null.
        /// </para>
        ///  </note>
        /// </summary>
        public AccessKeyLastUsed LastUsed { get; set; }

        /// <summary>
        /// Checks to see if the LastUsed property is set.
        /// </summary>
        internal bool IsSetLastUsed() => this.LastUsed != null;

        /// <summary>
        /// Gets and sets the property SecretAccessKey. 
        /// <para>
        /// The secret access key used to sign requests.
        /// </para>
        ///  
        /// <para>
        /// You should store the secret access key in a safe location. We recommend that you delete
        /// the access key if the secret access key is compromised.
        /// </para>
        /// </summary>
        public string SecretAccessKey { get; set; }

        /// <summary>
        /// Checks to see if the SecretAccessKey property is set.
        /// </summary>
        internal bool IsSetSecretAccessKey() => this.SecretAccessKey != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the access key.
        /// </para>
        ///  
        /// <para>
        /// A status of <c>Active</c> means that the key is valid, while <c>Inactive</c> means
        /// it is not.
        /// </para>
        /// </summary>
        public StatusType Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
