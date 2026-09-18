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

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// The details of an Amazon Simple Storage Service (Amazon S3) bucket.
    /// </summary>
    public partial class AwsS3BucketDetails
    {
        /// <summary>
        /// Gets and sets the property AccessControlList. 
        /// <para>
        /// The access control list for the S3 bucket.
        /// </para>
        /// </summary>
        public string AccessControlList { get; set; }

        /// <summary>
        /// Checks to see if the AccessControlList property is set.
        /// </summary>
        internal bool IsSetAccessControlList() => this.AccessControlList != null;

        /// <summary>
        /// Gets and sets the property BucketLifecycleConfiguration. 
        /// <para>
        /// The lifecycle configuration for objects in the specified bucket.
        /// </para>
        /// </summary>
        public AwsS3BucketBucketLifecycleConfigurationDetails BucketLifecycleConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the BucketLifecycleConfiguration property is set.
        /// </summary>
        internal bool IsSetBucketLifecycleConfiguration() => this.BucketLifecycleConfiguration != null;

        /// <summary>
        /// Gets and sets the property BucketLoggingConfiguration. 
        /// <para>
        /// The logging configuration for the S3 bucket.
        /// </para>
        /// </summary>
        public AwsS3BucketLoggingConfiguration BucketLoggingConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the BucketLoggingConfiguration property is set.
        /// </summary>
        internal bool IsSetBucketLoggingConfiguration() => this.BucketLoggingConfiguration != null;

        /// <summary>
        /// Gets and sets the property BucketNotificationConfiguration. 
        /// <para>
        /// The notification configuration for the S3 bucket.
        /// </para>
        /// </summary>
        public AwsS3BucketNotificationConfiguration BucketNotificationConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the BucketNotificationConfiguration property is set.
        /// </summary>
        internal bool IsSetBucketNotificationConfiguration() => this.BucketNotificationConfiguration != null;

        /// <summary>
        /// Gets and sets the property BucketVersioningConfiguration. 
        /// <para>
        /// The versioning state of an S3 bucket.
        /// </para>
        /// </summary>
        public AwsS3BucketBucketVersioningConfiguration BucketVersioningConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the BucketVersioningConfiguration property is set.
        /// </summary>
        internal bool IsSetBucketVersioningConfiguration() => this.BucketVersioningConfiguration != null;

        /// <summary>
        /// Gets and sets the property BucketWebsiteConfiguration. 
        /// <para>
        /// The website configuration parameters for the S3 bucket.
        /// </para>
        /// </summary>
        public AwsS3BucketWebsiteConfiguration BucketWebsiteConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the BucketWebsiteConfiguration property is set.
        /// </summary>
        internal bool IsSetBucketWebsiteConfiguration() => this.BucketWebsiteConfiguration != null;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// Indicates when the S3 bucket was created.
        /// </para>
        ///  
        /// <para>
        /// For more information about the validation and formatting of timestamp fields in Security
        /// Hub CSPM, see <a href="https://docs.aws.amazon.com/securityhub/1.0/APIReference/Welcome.html#timestamps">Timestamps</a>.
        /// </para>
        /// </summary>
        public string CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        ///  The name of the bucket. 
        /// </para>
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property ObjectLockConfiguration. 
        /// <para>
        ///  Specifies which rule Amazon S3 applies by default to every new object placed in the
        /// bucket. 
        /// </para>
        /// </summary>
        public AwsS3BucketObjectLockConfiguration ObjectLockConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the ObjectLockConfiguration property is set.
        /// </summary>
        internal bool IsSetObjectLockConfiguration() => this.ObjectLockConfiguration != null;

        /// <summary>
        /// Gets and sets the property OwnerAccountId. 
        /// <para>
        /// The Amazon Web Services account identifier of the account that owns the S3 bucket.
        /// </para>
        /// </summary>
        public string OwnerAccountId { get; set; }

        /// <summary>
        /// Checks to see if the OwnerAccountId property is set.
        /// </summary>
        internal bool IsSetOwnerAccountId() => this.OwnerAccountId != null;

        /// <summary>
        /// Gets and sets the property OwnerId. 
        /// <para>
        /// The canonical user ID of the owner of the S3 bucket.
        /// </para>
        /// </summary>
        public string OwnerId { get; set; }

        /// <summary>
        /// Checks to see if the OwnerId property is set.
        /// </summary>
        internal bool IsSetOwnerId() => this.OwnerId != null;

        /// <summary>
        /// Gets and sets the property OwnerName. 
        /// <para>
        /// The display name of the owner of the S3 bucket.
        /// </para>
        /// </summary>
        public string OwnerName { get; set; }

        /// <summary>
        /// Checks to see if the OwnerName property is set.
        /// </summary>
        internal bool IsSetOwnerName() => this.OwnerName != null;

        /// <summary>
        /// Gets and sets the property PublicAccessBlockConfiguration. 
        /// <para>
        /// Provides information about the Amazon S3 Public Access Block configuration for the
        /// S3 bucket.
        /// </para>
        /// </summary>
        public AwsS3AccountPublicAccessBlockDetails PublicAccessBlockConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the PublicAccessBlockConfiguration property is set.
        /// </summary>
        internal bool IsSetPublicAccessBlockConfiguration() => this.PublicAccessBlockConfiguration != null;

        /// <summary>
        /// Gets and sets the property ServerSideEncryptionConfiguration. 
        /// <para>
        /// The encryption rules that are applied to the S3 bucket.
        /// </para>
        /// </summary>
        public AwsS3BucketServerSideEncryptionConfiguration ServerSideEncryptionConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the ServerSideEncryptionConfiguration property is set.
        /// </summary>
        internal bool IsSetServerSideEncryptionConfiguration() => this.ServerSideEncryptionConfiguration != null;
    }
}
