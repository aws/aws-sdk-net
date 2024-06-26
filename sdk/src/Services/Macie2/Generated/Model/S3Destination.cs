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
 * Do not modify this file. This file is generated from the macie2-2020-01-01.normal.json service model.
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
namespace Amazon.Macie2.Model
{
    /// <summary>
    /// Specifies an S3 bucket to store data classification results in, and the encryption
    /// settings to use when storing results in that bucket.
    /// </summary>
    public partial class S3Destination
    {
        private string _bucketName;
        private string _keyPrefix;
        private string _kmsKeyArn;

        /// <summary>
        /// Gets and sets the property BucketName. 
        /// <para>
        /// The name of the bucket. This must be the name of an existing general purpose bucket.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property KeyPrefix. 
        /// <para>
        /// The path prefix to use in the path to the location in the bucket. This prefix specifies
        /// where to store classification results in the bucket.
        /// </para>
        /// </summary>
        public string KeyPrefix
        {
            get { return this._keyPrefix; }
            set { this._keyPrefix = value; }
        }

        // Check to see if KeyPrefix property is set
        internal bool IsSetKeyPrefix()
        {
            return this._keyPrefix != null;
        }

        /// <summary>
        /// Gets and sets the property KmsKeyArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the customer managed KMS key to use for encryption
        /// of the results. This must be the ARN of an existing, symmetric encryption KMS key
        /// that's enabled in the same Amazon Web Services Region as the bucket.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string KmsKeyArn
        {
            get { return this._kmsKeyArn; }
            set { this._kmsKeyArn = value; }
        }

        // Check to see if KmsKeyArn property is set
        internal bool IsSetKmsKeyArn()
        {
            return this._kmsKeyArn != null;
        }

    }
}