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

namespace Amazon.S3Vectors.Model
{
    /// <summary>
    /// Container for the parameters to the CreateVectorBucket operation. Creates a vector
    /// bucket in the Amazon Web Services Region that you want your bucket to be in. <dl>
    /// <dt>Permissions</dt> <dd> <para> You must have the <c>s3vectors:CreateVectorBucket</c>
    /// permission to use this operation. </para> <para> You must have the <c>s3vectors:TagResource</c>
    /// permission in addition to <c>s3vectors:CreateVectorBucket</c> permission to create
    /// a vector bucket with tags. </para> </dd> </dl>
    /// </summary>
    public partial class CreateVectorBucketRequest : AmazonS3VectorsRequest
    {
        /// <summary>
        /// Gets and sets the property EncryptionConfiguration. 
        /// <para>
        /// The encryption configuration for the vector bucket. By default, if you don't specify,
        /// all new vectors in Amazon S3 vector buckets use server-side encryption with Amazon
        /// S3 managed keys (SSE-S3), specifically <c>AES256</c>. 
        /// </para>
        /// </summary>
        public EncryptionConfiguration EncryptionConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the EncryptionConfiguration property is set.
        /// </summary>
        internal bool IsSetEncryptionConfiguration() => this.EncryptionConfiguration != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// An array of user-defined tags that you would like to apply to the vector bucket that
        /// you are creating. A tag is a key-value pair that you apply to your resources. Tags
        /// can help you organize and control access to resources. For more information, see <a
        /// href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/tagging.html">Tagging
        /// for cost allocation or attribute-based access control (ABAC)</a>.
        /// </para>
        ///  <note> 
        /// <para>
        /// You must have the <c>s3vectors:TagResource</c> permission in addition to <c>s3vectors:CreateVectorBucket</c>
        /// permission to create a vector bucket with tags.
        /// </para>
        ///  </note>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property VectorBucketName. 
        /// <para>
        /// The name of the vector bucket to create. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 3, Max = 63)]
        public string VectorBucketName { get; set; }

        /// <summary>
        /// Checks to see if the VectorBucketName property is set.
        /// </summary>
        internal bool IsSetVectorBucketName() => this.VectorBucketName != null;
    }
}
