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
    /// Contains the Amazon S3 location, encryption settings, and output types for a bulk
    /// operation. The <c>S3Bucket</c> and <c>OutputType</c> fields are required.
    /// </summary>
    public partial class OutputS3Configuration
    {
        /// <summary>
        /// Gets and sets the property OutputType. 
        /// <para>
        /// The following values describe the types of output that DynamoDB writes for individual
        /// input items. Include one or both values.
        /// </para>
        ///  <dl> <dt> ERROR </dt> <dd> 
        /// <para>
        /// Reports input records or input objects that DynamoDB couldn't process. This includes
        /// malformed input and item validation failures, such as a missing or incorrectly typed
        /// primary key attribute or an item that exceeds a DynamoDB limit.
        /// </para>
        ///  </dd> <dt> CONDITION_CHECK_FAILURE </dt> <dd> 
        /// <para>
        /// Reports the attempted item and, when present, the existing item for a write whose
        /// condition expression evaluates to false.
        /// </para>
        ///  </dd> </dl>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<string> OutputType { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the OutputType property is set.
        /// </summary>
        internal bool IsSetOutputType() => this.OutputType != null && (this.OutputType.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property S3Bucket. 
        /// <para>
        /// The name of the Amazon S3 bucket where DynamoDB writes output records.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 255)]
        public string S3Bucket { get; set; }

        /// <summary>
        /// Checks to see if the S3Bucket property is set.
        /// </summary>
        internal bool IsSetS3Bucket() => this.S3Bucket != null;

        /// <summary>
        /// Gets and sets the property S3BucketOwner. 
        /// <para>
        /// The Amazon Web Services account ID of the output bucket owner. If you omit this value,
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
        /// An optional key prefix under which DynamoDB writes the output records.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string S3KeyPrefix { get; set; }

        /// <summary>
        /// Checks to see if the S3KeyPrefix property is set.
        /// </summary>
        internal bool IsSetS3KeyPrefix() => this.S3KeyPrefix != null;

        /// <summary>
        /// Gets and sets the property S3SseAlgorithm. 
        /// <para>
        /// The server-side encryption algorithm for the output objects. Valid values are <c>AES256</c>
        /// and <c>KMS</c>. If you don't specify a value, Amazon S3 applies the destination bucket's
        /// default encryption settings.
        /// </para>
        /// </summary>
        public S3SseAlgorithm S3SseAlgorithm { get; set; }

        /// <summary>
        /// Checks to see if the S3SseAlgorithm property is set.
        /// </summary>
        internal bool IsSetS3SseAlgorithm() => this.S3SseAlgorithm != null;

        /// <summary>
        /// Gets and sets the property S3SseKmsKeyId. 
        /// <para>
        /// The identifier of the KMS key that encrypts the output objects. Specify this value
        /// when <c>S3SseAlgorithm</c> is <c>KMS</c>. Don't specify it when the algorithm is <c>AES256</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string S3SseKmsKeyId { get; set; }

        /// <summary>
        /// Checks to see if the S3SseKmsKeyId property is set.
        /// </summary>
        internal bool IsSetS3SseKmsKeyId() => this.S3SseKmsKeyId != null;
    }
}
