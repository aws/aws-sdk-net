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
 * Do not modify this file. This file is generated from the timestream-write-2018-11-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.TimestreamWrite.Model
{
    /// <summary>
    /// The configuration that specifies an S3 location.
    /// </summary>
    public partial class S3Configuration
    {
        private string _bucketName;
        private S3EncryptionOption _encryptionOption;
        private string _kmsKeyId;
        private string _objectKeyPrefix;

        /// <summary>
        /// Gets and sets the property BucketName. 
        /// <para>
        /// The bucket name of the customer S3 bucket.
        /// </para>
        /// </summary>
        [AWSProperty(Min=3, Max=63)]
        public string BucketName
        {
            get { return this._bucketName; }
            set { this._bucketName = value; }
        }

        // Check to see if BucketName property is set
        internal bool IsSetBucketName()
        {
            return this._bucketName != null;
        }

        /// <summary>
        /// Gets and sets the property EncryptionOption. 
        /// <para>
        /// The encryption option for the customer S3 location. Options are S3 server-side encryption
        /// with an S3 managed key or Amazon Web Services managed key.
        /// </para>
        /// </summary>
        public S3EncryptionOption EncryptionOption
        {
            get { return this._encryptionOption; }
            set { this._encryptionOption = value; }
        }

        // Check to see if EncryptionOption property is set
        internal bool IsSetEncryptionOption()
        {
            return this._encryptionOption != null;
        }

        /// <summary>
        /// Gets and sets the property KmsKeyId. 
        /// <para>
        /// The KMS key ID for the customer S3 location when encrypting with an Amazon Web Services
        /// managed key.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string KmsKeyId
        {
            get { return this._kmsKeyId; }
            set { this._kmsKeyId = value; }
        }

        // Check to see if KmsKeyId property is set
        internal bool IsSetKmsKeyId()
        {
            return this._kmsKeyId != null;
        }

        /// <summary>
        /// Gets and sets the property ObjectKeyPrefix. 
        /// <para>
        /// The object key preview for the customer S3 location.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=928)]
        public string ObjectKeyPrefix
        {
            get { return this._objectKeyPrefix; }
            set { this._objectKeyPrefix = value; }
        }

        // Check to see if ObjectKeyPrefix property is set
        internal bool IsSetObjectKeyPrefix()
        {
            return this._objectKeyPrefix != null;
        }

    }
}