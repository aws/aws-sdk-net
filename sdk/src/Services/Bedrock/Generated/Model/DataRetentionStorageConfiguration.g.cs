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

namespace Amazon.Bedrock.Model
{
    /// <summary>
    /// You provide the Amazon S3 destination and AWS Key Management Service (AWS KMS) key
    /// for retained data.
    /// 
    ///  
    /// <para>
    /// Before saving a customer-managed destination, Amazon Bedrock validates that you can
    /// use the bucket and key and that their resource policies permit the required Amazon
    /// Bedrock access. If validation fails, Amazon Bedrock rejects the configuration without
    /// saving it.
    /// </para>
    ///  
    /// <para>
    /// You need <c>s3:PutObject</c>, <c>s3:GetObject</c>, <c>kms:GenerateDataKey</c>, and
    /// <c>kms:Decrypt</c> permissions. The Amazon S3 bucket policy must allow the Amazon
    /// Bedrock service principal, <c>bedrock.amazonaws.com</c>, to put, get, and delete objects
    /// with conditions appropriate to the configuration scope.
    /// </para>
    ///  
    /// <para>
    /// Use <c>aws:SourceAccount</c> for account scope, <c>aws:SourceOrgID</c> for organization
    /// scope, and both <c>aws:SourceAccount</c> and the project's <c>aws:SourceArn</c> for
    /// project scope. Validation rejects resource policies that allow the service principal
    /// to access the destination without the required scope conditions.
    /// </para>
    ///  
    /// <para>
    /// The key policy must permit <c>kms:GenerateDataKey</c> and <c>kms:Decrypt</c> for both
    /// uses of the key: direct use by Amazon Bedrock with the scope conditions, and use through
    /// Amazon S3 with a <c>kms:ViaService</c> condition for the bucket's Region and <c>kms:EncryptionContext:aws:s3:arn</c>
    /// scoped to the bucket.
    /// </para>
    /// </summary>
    public partial class DataRetentionStorageConfiguration
    {
        /// <summary>
        /// Gets and sets the property KmsKeyArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the customer managed AWS Key Management Service
        /// (AWS KMS) key you use to encrypt retained data. Specify an enabled symmetric encryption
        /// key in the AWS Region where you register the configuration. You cannot specify a key
        /// alias.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2048)]
        public string KmsKeyArn { get; set; }

        /// <summary>
        /// Checks to see if the KmsKeyArn property is set.
        /// </summary>
        internal bool IsSetKmsKeyArn() => this.KmsKeyArn != null;

        /// <summary>
        /// Gets and sets the property S3BucketArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Amazon S3 bucket that receives retained data.
        /// The bucket must be in the AWS Region where you register the configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2048)]
        public string S3BucketArn { get; set; }

        /// <summary>
        /// Checks to see if the S3BucketArn property is set.
        /// </summary>
        internal bool IsSetS3BucketArn() => this.S3BucketArn != null;

        /// <summary>
        /// Gets and sets the property S3BucketOwner. 
        /// <para>
        /// The AWS account ID of the destination bucket's owner. You must specify the owner,
        /// even when the bucket belongs to another account. Amazon Bedrock uses this ID to verify
        /// bucket ownership for each delivery request.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string S3BucketOwner { get; set; }

        /// <summary>
        /// Checks to see if the S3BucketOwner property is set.
        /// </summary>
        internal bool IsSetS3BucketOwner() => this.S3BucketOwner != null;
    }
}
