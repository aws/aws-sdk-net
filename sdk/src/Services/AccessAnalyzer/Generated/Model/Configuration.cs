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
 * Do not modify this file. This file is generated from the accessanalyzer-2019-11-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.AccessAnalyzer.Model
{
    /// <summary>
    /// Access control configuration structures for your resource. You specify the configuration
    /// as a type-value pair. You can specify only one type of access control configuration.
    /// </summary>
    public partial class Configuration
    {
        private IamRoleConfiguration _iamRole;
        private KmsKeyConfiguration _kmsKey;
        private S3BucketConfiguration _s3Bucket;
        private SecretsManagerSecretConfiguration _secretsManagerSecret;
        private SqsQueueConfiguration _sqsQueue;

        /// <summary>
        /// Gets and sets the property IamRole. 
        /// <para>
        /// The access control configuration is for an IAM role. 
        /// </para>
        /// </summary>
        public IamRoleConfiguration IamRole
        {
            get { return this._iamRole; }
            set { this._iamRole = value; }
        }

        // Check to see if IamRole property is set
        internal bool IsSetIamRole()
        {
            return this._iamRole != null;
        }

        /// <summary>
        /// Gets and sets the property KmsKey. 
        /// <para>
        /// The access control configuration is for a KMS key. 
        /// </para>
        /// </summary>
        public KmsKeyConfiguration KmsKey
        {
            get { return this._kmsKey; }
            set { this._kmsKey = value; }
        }

        // Check to see if KmsKey property is set
        internal bool IsSetKmsKey()
        {
            return this._kmsKey != null;
        }

        /// <summary>
        /// Gets and sets the property S3Bucket. 
        /// <para>
        /// The access control configuration is for an Amazon S3 Bucket. 
        /// </para>
        /// </summary>
        public S3BucketConfiguration S3Bucket
        {
            get { return this._s3Bucket; }
            set { this._s3Bucket = value; }
        }

        // Check to see if S3Bucket property is set
        internal bool IsSetS3Bucket()
        {
            return this._s3Bucket != null;
        }

        /// <summary>
        /// Gets and sets the property SecretsManagerSecret. 
        /// <para>
        /// The access control configuration is for a Secrets Manager secret.
        /// </para>
        /// </summary>
        public SecretsManagerSecretConfiguration SecretsManagerSecret
        {
            get { return this._secretsManagerSecret; }
            set { this._secretsManagerSecret = value; }
        }

        // Check to see if SecretsManagerSecret property is set
        internal bool IsSetSecretsManagerSecret()
        {
            return this._secretsManagerSecret != null;
        }

        /// <summary>
        /// Gets and sets the property SqsQueue. 
        /// <para>
        /// The access control configuration is for an Amazon SQS queue. 
        /// </para>
        /// </summary>
        public SqsQueueConfiguration SqsQueue
        {
            get { return this._sqsQueue; }
            set { this._sqsQueue = value; }
        }

        // Check to see if SqsQueue property is set
        internal bool IsSetSqsQueue()
        {
            return this._sqsQueue != null;
        }

    }
}