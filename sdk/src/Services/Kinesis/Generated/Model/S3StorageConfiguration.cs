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
 * Do not modify this file. This file is generated from the kinesis-2013-12-02.normal.json service model.
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
namespace Amazon.Kinesis.Model
{
    /// <summary>
    /// The Amazon S3 storage settings for a general purpose Amazon S3 destination.
    /// </summary>
    public partial class S3StorageConfiguration
    {
        private string _bucketARN;
        private S3CompressionType _compressionType;
        private string _expectedBucketOwner;
        private string _outputKeyTemplate;
        private S3StorageClass _storageClass;

        /// <summary>
        /// Gets and sets the property BucketARN. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the destination Amazon S3 bucket.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
        public string BucketARN
        {
            get { return this._bucketARN; }
            set { this._bucketARN = value; }
        }

        // Check to see if BucketARN property is set
        internal bool IsSetBucketARN()
        {
            return this._bucketARN != null;
        }

        /// <summary>
        /// Gets and sets the property CompressionType. 
        /// <para>
        /// The compression applied to delivered objects. Valid values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>NONE</c> - No compression.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>GZIP</c> - gzip compression.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ZSTD</c> - Zstandard compression.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public S3CompressionType CompressionType
        {
            get { return this._compressionType; }
            set { this._compressionType = value; }
        }

        // Check to see if CompressionType property is set
        internal bool IsSetCompressionType()
        {
            return this._compressionType != null;
        }

        /// <summary>
        /// Gets and sets the property ExpectedBucketOwner. 
        /// <para>
        /// The Amazon Web Services account ID of the expected owner of the destination bucket.
        /// This value helps prevent delivery to an unintended bucket if ownership changes.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=12, Max=12)]
        public string ExpectedBucketOwner
        {
            get { return this._expectedBucketOwner; }
            set { this._expectedBucketOwner = value; }
        }

        // Check to see if ExpectedBucketOwner property is set
        internal bool IsSetExpectedBucketOwner()
        {
            return this._expectedBucketOwner != null;
        }

        /// <summary>
        /// Gets and sets the property OutputKeyTemplate. 
        /// <para>
        /// The template used to construct the Amazon S3 object key for delivered objects. If
        /// not specified, a default template is used.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string OutputKeyTemplate
        {
            get { return this._outputKeyTemplate; }
            set { this._outputKeyTemplate = value; }
        }

        // Check to see if OutputKeyTemplate property is set
        internal bool IsSetOutputKeyTemplate()
        {
            return this._outputKeyTemplate != null;
        }

        /// <summary>
        /// Gets and sets the property StorageClass. 
        /// <para>
        /// The Amazon S3 storage class for delivered objects. Valid values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>STANDARD</c> (default)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>INTELLIGENT_TIERING</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>GLACIER_IR</c> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public S3StorageClass StorageClass
        {
            get { return this._storageClass; }
            set { this._storageClass = value; }
        }

        // Check to see if StorageClass property is set
        internal bool IsSetStorageClass()
        {
            return this._storageClass != null;
        }

    }
}