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

namespace Amazon.Kafka.Model
{
    /// <summary>
    /// Storage configuration for an Amazon S3 destination bucket.
    /// </summary>
    public partial class S3Storage
    {
        /// <summary>
        /// Gets and sets the property BucketArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the destination Amazon S3 bucket.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string BucketArn { get; set; }

        /// <summary>
        /// Checks to see if the BucketArn property is set.
        /// </summary>
        internal bool IsSetBucketArn() => this.BucketArn != null;

        /// <summary>
        /// Gets and sets the property CompressionType. 
        /// <para>
        /// The compression codec applied to delivered Amazon S3 objects.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public S3CompressionType CompressionType { get; set; }

        /// <summary>
        /// Checks to see if the CompressionType property is set.
        /// </summary>
        internal bool IsSetCompressionType() => this.CompressionType != null;

        /// <summary>
        /// Gets and sets the property ExpectedBucketOwner. 
        /// <para>
        /// Optional 12-digit AWS account ID expected to own the Amazon S3 bucket.
        /// </para>
        /// </summary>
        public string ExpectedBucketOwner { get; set; }

        /// <summary>
        /// Checks to see if the ExpectedBucketOwner property is set.
        /// </summary>
        internal bool IsSetExpectedBucketOwner() => this.ExpectedBucketOwner != null;

        /// <summary>
        /// Gets and sets the property OutputKeyTemplate. 
        /// <para>
        /// An optional template that controls the Amazon S3 object key for each delivered record.
        /// Supports the placeholders !{partition-id}, !{sequence-number}, and !{kafka-offset}.
        /// </para>
        /// </summary>
        public string OutputKeyTemplate { get; set; }

        /// <summary>
        /// Checks to see if the OutputKeyTemplate property is set.
        /// </summary>
        internal bool IsSetOutputKeyTemplate() => this.OutputKeyTemplate != null;

        /// <summary>
        /// Gets and sets the property OutputPrefix. 
        /// <para>
        /// An optional prefix prepended to every Amazon S3 object key written by the channel.
        /// </para>
        /// </summary>
        public string OutputPrefix { get; set; }

        /// <summary>
        /// Checks to see if the OutputPrefix property is set.
        /// </summary>
        internal bool IsSetOutputPrefix() => this.OutputPrefix != null;

        /// <summary>
        /// Gets and sets the property StorageClass. 
        /// <para>
        /// The Amazon S3 storage class for delivered objects.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public S3StorageClass StorageClass { get; set; }

        /// <summary>
        /// Checks to see if the StorageClass property is set.
        /// </summary>
        internal bool IsSetStorageClass() => this.StorageClass != null;
    }
}
