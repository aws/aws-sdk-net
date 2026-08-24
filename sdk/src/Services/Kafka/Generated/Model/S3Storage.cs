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
 * Do not modify this file. This file is generated from the kafka-2018-11-14.normal.json service model.
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
namespace Amazon.Kafka.Model
{
    /// <summary>
    /// Storage configuration for an Amazon S3 destination bucket.
    /// </summary>
    public partial class S3Storage
    {
        private string _bucketArn;
        private S3CompressionType _compressionType;
        private string _expectedBucketOwner;
        private string _outputKeyTemplate;
        private string _outputPrefix;
        private S3StorageClass _storageClass;

        /// <summary>
        /// Gets and sets the property BucketArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the destination Amazon S3 bucket.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string BucketArn
        {
            get { return this._bucketArn; }
            set { this._bucketArn = value; }
        }

        // Check to see if BucketArn property is set
        internal bool IsSetBucketArn()
        {
            return this._bucketArn != null;
        }

        /// <summary>
        /// Gets and sets the property CompressionType. 
        /// <para>
        /// The compression codec applied to delivered Amazon S3 objects.
        /// </para>
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
        /// Optional 12-digit AWS account ID expected to own the Amazon S3 bucket.
        /// </para>
        /// </summary>
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
        /// An optional template that controls the Amazon S3 object key for each delivered record.
        /// Supports the placeholders !{partition-id}, !{sequence-number}, and !{kafka-offset}.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property OutputPrefix. 
        /// <para>
        /// An optional prefix prepended to every Amazon S3 object key written by the channel.
        /// </para>
        /// </summary>
        public string OutputPrefix
        {
            get { return this._outputPrefix; }
            set { this._outputPrefix = value; }
        }

        // Check to see if OutputPrefix property is set
        internal bool IsSetOutputPrefix()
        {
            return this._outputPrefix != null;
        }

        /// <summary>
        /// Gets and sets the property StorageClass. 
        /// <para>
        /// The Amazon S3 storage class for delivered objects.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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