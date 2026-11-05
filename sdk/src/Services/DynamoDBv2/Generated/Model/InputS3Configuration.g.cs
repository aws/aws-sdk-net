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

namespace Amazon.DynamoDBv2.Model
{
    /// <summary>
    /// Contains the Amazon S3 location and format settings for bulk operation input. The
    /// <c>S3Bucket</c> and <c>InputFormat</c> fields are required.
    /// </summary>
    public partial class InputS3Configuration
    {
        /// <summary>
        /// Gets and sets the property InputCompressionType. 
        /// <para>
        /// The compression type of the input objects. Valid values are <c>GZIP</c>, <c>ZSTD</c>,
        /// and <c>NONE</c>. If you don't specify a value, DynamoDB uses <c>NONE</c>.
        /// </para>
        /// </summary>
        public InputCompressionType InputCompressionType { get; set; }

        /// <summary>
        /// Checks to see if the InputCompressionType property is set.
        /// </summary>
        internal bool IsSetInputCompressionType() => this.InputCompressionType != null;

        /// <summary>
        /// Gets and sets the property InputFormat. 
        /// <para>
        /// The format of the input objects. <c>DYNAMODB_JSON</c> uses JSON Lines, with one JSON
        /// record per line. <c>ION</c> uses a sequence of Ion structs.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public BulkOperationInputFormat InputFormat { get; set; }

        /// <summary>
        /// Checks to see if the InputFormat property is set.
        /// </summary>
        internal bool IsSetInputFormat() => this.InputFormat != null;

        /// <summary>
        /// Gets and sets the property S3Bucket. 
        /// <para>
        /// The name of the Amazon S3 bucket that contains the input objects.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 255)]
        public string S3Bucket { get; set; }

        /// <summary>
        /// Checks to see if the S3Bucket property is set.
        /// </summary>
        internal bool IsSetS3Bucket() => this.S3Bucket != null;

        /// <summary>
        /// Gets and sets the property S3BucketOwner. 
        /// <para>
        /// The Amazon Web Services account ID of the input bucket owner. If you omit this value,
        /// DynamoDB uses the Amazon Web Services account ID of the requester.
        /// </para>
        ///  <note> 
        /// <para>
        ///  <c>S3BucketOwner</c> is required when the bucket is owned by another Amazon Web Services
        /// account.
        /// </para>
        ///  </note>
        /// </summary>
        public string S3BucketOwner { get; set; }

        /// <summary>
        /// Checks to see if the S3BucketOwner property is set.
        /// </summary>
        internal bool IsSetS3BucketOwner() => this.S3BucketOwner != null;

        /// <summary>
        /// Gets and sets the property S3KeyPrefix. 
        /// <para>
        /// An optional key prefix that limits the input to matching objects in the Amazon S3
        /// bucket.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string S3KeyPrefix { get; set; }

        /// <summary>
        /// Checks to see if the S3KeyPrefix property is set.
        /// </summary>
        internal bool IsSetS3KeyPrefix() => this.S3KeyPrefix != null;
    }
}
