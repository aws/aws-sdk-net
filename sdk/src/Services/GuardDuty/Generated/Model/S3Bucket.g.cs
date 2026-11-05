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

namespace Amazon.GuardDuty.Model
{
    /// <summary>
    /// Contains information about the Amazon S3 bucket policies and encryption.
    /// </summary>
    public partial class S3Bucket
    {
        /// <summary>
        /// Gets and sets the property AccountPublicAccess. 
        /// <para>
        /// Contains information about the public access policies that apply to the Amazon S3
        /// bucket at the account level.
        /// </para>
        /// </summary>
        public PublicAccessConfiguration AccountPublicAccess { get; set; }

        /// <summary>
        /// Checks to see if the AccountPublicAccess property is set.
        /// </summary>
        internal bool IsSetAccountPublicAccess() => this.AccountPublicAccess != null;

        /// <summary>
        /// Gets and sets the property BucketPublicAccess. 
        /// <para>
        /// Contains information about public access policies that apply to the Amazon S3 bucket.
        /// </para>
        /// </summary>
        public PublicAccessConfiguration BucketPublicAccess { get; set; }

        /// <summary>
        /// Checks to see if the BucketPublicAccess property is set.
        /// </summary>
        internal bool IsSetBucketPublicAccess() => this.BucketPublicAccess != null;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The timestamp at which the Amazon S3 bucket was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property EffectivePermission. 
        /// <para>
        /// Describes the effective permissions on this S3 bucket, after factoring all the attached
        /// policies.
        /// </para>
        /// </summary>
        public string EffectivePermission { get; set; }

        /// <summary>
        /// Checks to see if the EffectivePermission property is set.
        /// </summary>
        internal bool IsSetEffectivePermission() => this.EffectivePermission != null;

        /// <summary>
        /// Gets and sets the property EncryptionKeyArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the encryption key that is used to encrypt the Amazon
        /// S3 bucket and its objects.
        /// </para>
        /// </summary>
        public string EncryptionKeyArn { get; set; }

        /// <summary>
        /// Checks to see if the EncryptionKeyArn property is set.
        /// </summary>
        internal bool IsSetEncryptionKeyArn() => this.EncryptionKeyArn != null;

        /// <summary>
        /// Gets and sets the property EncryptionType. 
        /// <para>
        /// The type of encryption used for the Amazon S3 buckets and its objects. For more information,
        /// see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/serv-side-encryption.html">Protecting
        /// data with server-side encryption</a> in the <i>Amazon S3 User Guide</i>.
        /// </para>
        /// </summary>
        public string EncryptionType { get; set; }

        /// <summary>
        /// Checks to see if the EncryptionType property is set.
        /// </summary>
        internal bool IsSetEncryptionType() => this.EncryptionType != null;

        /// <summary>
        /// Gets and sets the property OwnerId. 
        /// <para>
        /// The owner ID of the associated S3Amazon S3bucket.
        /// </para>
        /// </summary>
        public string OwnerId { get; set; }

        /// <summary>
        /// Checks to see if the OwnerId property is set.
        /// </summary>
        internal bool IsSetOwnerId() => this.OwnerId != null;

        /// <summary>
        /// Gets and sets the property PublicReadAccess. 
        /// <para>
        /// Indicates whether or not the public read access is allowed for an Amazon S3 bucket.
        /// </para>
        /// </summary>
        public PublicAccessStatus PublicReadAccess { get; set; }

        /// <summary>
        /// Checks to see if the PublicReadAccess property is set.
        /// </summary>
        internal bool IsSetPublicReadAccess() => this.PublicReadAccess != null;

        /// <summary>
        /// Gets and sets the property PublicWriteAccess. 
        /// <para>
        /// Indicates whether or not the public write access is allowed for an Amazon S3 bucket.
        /// </para>
        /// </summary>
        public PublicAccessStatus PublicWriteAccess { get; set; }

        /// <summary>
        /// Checks to see if the PublicWriteAccess property is set.
        /// </summary>
        internal bool IsSetPublicWriteAccess() => this.PublicWriteAccess != null;

        /// <summary>
        /// Gets and sets the property S3ObjectUids. 
        /// <para>
        /// Represents a list of Amazon S3 object identifiers.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> S3ObjectUids { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the S3ObjectUids property is set.
        /// </summary>
        internal bool IsSetS3ObjectUids() => this.S3ObjectUids != null && (this.S3ObjectUids.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
