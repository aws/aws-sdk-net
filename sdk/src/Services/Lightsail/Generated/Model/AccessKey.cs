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
 * Do not modify this file. This file is generated from the lightsail-2016-11-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

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
    /// keys, see <a href="https://lightsail.aws.amazon.com/ls/docs/en_us/articles/amazon-lightsail-creating-bucket-access-keys">Creating
    /// access keys for a bucket in Amazon Lightsail</a> in the <i>Amazon Lightsail Developer
    /// Guide</i>.
    /// </para>
    ///  <important> 
    /// <para>
    /// The <code>secretAccessKey</code> value is returned only in response to the <code>CreateBucketAccessKey</code>
    /// action. You can get a secret access key only when you first create an access key;
    /// you cannot get the secret access key later. If you lose the secret access key, you
    /// must create a new access key.
    /// </para>
    ///  </important>
    /// </summary>
    public partial class AccessKey
    {
        private string _accessKeyId;
        private DateTime? _createdAt;
        private AccessKeyLastUsed _lastUsed;
        private string _secretAccessKey;
        private StatusType _status;

        /// <summary>
        /// Gets and sets the property AccessKeyId. 
        /// <para>
        /// The ID of the access key.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=20, Max=20)]
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
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The timestamp when the access key was created.
        /// </para>
        /// </summary>
        public DateTime CreatedAt
        {
            get { return this._createdAt.GetValueOrDefault(); }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LastUsed. 
        /// <para>
        /// An object that describes the last time the access key was used.
        /// </para>
        ///  <note> 
        /// <para>
        /// This object does not include data in the response of a <a href="https://docs.aws.amazon.com/lightsail/2016-11-28/api-reference/API_CreateBucketAccessKey.html">CreateBucketAccessKey</a>
        /// action. If the access key has not been used, the <code>region</code> and <code>serviceName</code>
        /// values are <code>N/A</code>, and the <code>lastUsedDate</code> value is null.
        /// </para>
        ///  </note>
        /// </summary>
        public AccessKeyLastUsed LastUsed
        {
            get { return this._lastUsed; }
            set { this._lastUsed = value; }
        }

        // Check to see if LastUsed property is set
        internal bool IsSetLastUsed()
        {
            return this._lastUsed != null;
        }

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
        public string SecretAccessKey
        {
            get { return this._secretAccessKey; }
            set { this._secretAccessKey = value; }
        }

        // Check to see if SecretAccessKey property is set
        internal bool IsSetSecretAccessKey()
        {
            return this._secretAccessKey != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the access key.
        /// </para>
        ///  
        /// <para>
        /// A status of <code>Active</code> means that the key is valid, while <code>Inactive</code>
        /// means it is not.
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

    }
}