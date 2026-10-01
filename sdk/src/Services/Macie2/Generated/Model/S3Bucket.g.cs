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

namespace Amazon.Macie2.Model
{
    /// <summary>
    /// Provides information about the S3 bucket that a finding applies to. If a quota prevented
    /// Amazon Macie from retrieving and processing all the bucket's information prior to
    /// generating the finding, the following values are UNKNOWN or null: allowsUnencryptedObjectUploads,
    /// defaultServerSideEncryption, publicAccess, and tags.
    /// </summary>
    public partial class S3Bucket
    {
        /// <summary>
        /// Gets and sets the property AllowsUnencryptedObjectUploads. 
        /// <para>
        /// Specifies whether the bucket policy for the bucket requires server-side encryption
        /// of objects when objects are added to the bucket. Possible values are:
        /// </para>
        ///  <ul><li>
        /// <para>
        /// FALSE - The bucket policy requires server-side encryption of new objects. PutObject
        /// requests must include a valid server-side encryption header.
        /// </para>
        /// </li> <li>
        /// <para>
        /// TRUE - The bucket doesn't have a bucket policy or it has a bucket policy that doesn't
        /// require server-side encryption of new objects. If a bucket policy exists, it doesn't
        /// require PutObject requests to include a valid server-side encryption header.
        /// </para>
        /// </li> <li>
        /// <para>
        /// UNKNOWN - Amazon Macie can't determine whether the bucket policy requires server-side
        /// encryption of new objects.
        /// </para>
        /// </li></ul> 
        /// <para>
        /// Valid server-side encryption headers are: x-amz-server-side-encryption with a value
        /// of AES256 or aws:kms, and x-amz-server-side-encryption-customer-algorithm with a value
        /// of AES256.
        /// </para>
        /// </summary>
        public AllowsUnencryptedObjectUploads AllowsUnencryptedObjectUploads { get; set; }

        /// <summary>
        /// Checks to see if the AllowsUnencryptedObjectUploads property is set.
        /// </summary>
        internal bool IsSetAllowsUnencryptedObjectUploads() => this.AllowsUnencryptedObjectUploads != null;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the bucket.
        /// </para>
        /// </summary>
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The date and time, in UTC and extended ISO 8601 format, when the bucket was created.
        /// This value can also indicate when changes such as edits to the bucket's policy were
        /// most recently made to the bucket, relative to when the finding was created or last
        /// updated.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property DefaultServerSideEncryption. 
        /// <para>
        /// The default server-side encryption settings for the bucket.
        /// </para>
        /// </summary>
        public ServerSideEncryption DefaultServerSideEncryption { get; set; }

        /// <summary>
        /// Checks to see if the DefaultServerSideEncryption property is set.
        /// </summary>
        internal bool IsSetDefaultServerSideEncryption() => this.DefaultServerSideEncryption != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the bucket.
        /// </para>
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Owner. 
        /// <para>
        /// The display name and canonical user ID for the Amazon Web Services account that owns
        /// the bucket.
        /// </para>
        /// </summary>
        public S3BucketOwner Owner { get; set; }

        /// <summary>
        /// Checks to see if the Owner property is set.
        /// </summary>
        internal bool IsSetOwner() => this.Owner != null;

        /// <summary>
        /// Gets and sets the property PublicAccess. 
        /// <para>
        /// The permissions settings that determine whether the bucket is publicly accessible.
        /// </para>
        /// </summary>
        public BucketPublicAccess PublicAccess { get; set; }

        /// <summary>
        /// Checks to see if the PublicAccess property is set.
        /// </summary>
        internal bool IsSetPublicAccess() => this.PublicAccess != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags that are associated with the bucket.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<KeyValuePair> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<KeyValuePair>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
