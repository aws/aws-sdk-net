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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
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
        private string _accessControlList;
        private AwsS3BucketBucketLifecycleConfigurationDetails _bucketLifecycleConfiguration;
        private AwsS3BucketLoggingConfiguration _bucketLoggingConfiguration;
        private AwsS3BucketNotificationConfiguration _bucketNotificationConfiguration;
        private AwsS3BucketBucketVersioningConfiguration _bucketVersioningConfiguration;
        private AwsS3BucketWebsiteConfiguration _bucketWebsiteConfiguration;
        private string _createdAt;
        private string _name;
        private AwsS3BucketObjectLockConfiguration _objectLockConfiguration;
        private string _ownerAccountId;
        private string _ownerId;
        private string _ownerName;
        private AwsS3AccountPublicAccessBlockDetails _publicAccessBlockConfiguration;
        private AwsS3BucketServerSideEncryptionConfiguration _serverSideEncryptionConfiguration;

        /// <summary>
        /// Gets and sets the property AccessControlList. 
        /// <para>
        /// The access control list for the S3 bucket.
        /// </para>
        /// </summary>
        public string AccessControlList
        {
            get { return this._accessControlList; }
            set { this._accessControlList = value; }
        }

        // Check to see if AccessControlList property is set
        internal bool IsSetAccessControlList()
        {
            return this._accessControlList != null;
        }

        /// <summary>
        /// Gets and sets the property BucketLifecycleConfiguration. 
        /// <para>
        /// The lifecycle configuration for objects in the specified bucket.
        /// </para>
        /// </summary>
        public AwsS3BucketBucketLifecycleConfigurationDetails BucketLifecycleConfiguration
        {
            get { return this._bucketLifecycleConfiguration; }
            set { this._bucketLifecycleConfiguration = value; }
        }

        // Check to see if BucketLifecycleConfiguration property is set
        internal bool IsSetBucketLifecycleConfiguration()
        {
            return this._bucketLifecycleConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property BucketLoggingConfiguration. 
        /// <para>
        /// The logging configuration for the S3 bucket.
        /// </para>
        /// </summary>
        public AwsS3BucketLoggingConfiguration BucketLoggingConfiguration
        {
            get { return this._bucketLoggingConfiguration; }
            set { this._bucketLoggingConfiguration = value; }
        }

        // Check to see if BucketLoggingConfiguration property is set
        internal bool IsSetBucketLoggingConfiguration()
        {
            return this._bucketLoggingConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property BucketNotificationConfiguration. 
        /// <para>
        /// The notification configuration for the S3 bucket.
        /// </para>
        /// </summary>
        public AwsS3BucketNotificationConfiguration BucketNotificationConfiguration
        {
            get { return this._bucketNotificationConfiguration; }
            set { this._bucketNotificationConfiguration = value; }
        }

        // Check to see if BucketNotificationConfiguration property is set
        internal bool IsSetBucketNotificationConfiguration()
        {
            return this._bucketNotificationConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property BucketVersioningConfiguration. 
        /// <para>
        /// The versioning state of an S3 bucket.
        /// </para>
        /// </summary>
        public AwsS3BucketBucketVersioningConfiguration BucketVersioningConfiguration
        {
            get { return this._bucketVersioningConfiguration; }
            set { this._bucketVersioningConfiguration = value; }
        }

        // Check to see if BucketVersioningConfiguration property is set
        internal bool IsSetBucketVersioningConfiguration()
        {
            return this._bucketVersioningConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property BucketWebsiteConfiguration. 
        /// <para>
        /// The website configuration parameters for the S3 bucket.
        /// </para>
        /// </summary>
        public AwsS3BucketWebsiteConfiguration BucketWebsiteConfiguration
        {
            get { return this._bucketWebsiteConfiguration; }
            set { this._bucketWebsiteConfiguration = value; }
        }

        // Check to see if BucketWebsiteConfiguration property is set
        internal bool IsSetBucketWebsiteConfiguration()
        {
            return this._bucketWebsiteConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// Indicates when the S3 bucket was created.
        /// </para>
        ///  
        /// <para>
        /// This field accepts only the specified formats. Timestamps can end with <c>Z</c> or
        /// <c>("+" / "-") time-hour [":" time-minute]</c>. The time-secfrac after seconds is
        /// limited to a maximum of 9 digits. The offset is bounded by +/-18:00. Here are valid
        /// timestamp formats with examples:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>YYYY-MM-DDTHH:MM:SSZ</c> (for example, <c>2019-01-31T23:00:00Z</c>)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>YYYY-MM-DDTHH:MM:SS.mmmmmmmmmZ</c> (for example, <c>2019-01-31T23:00:00.123456789Z</c>)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>YYYY-MM-DDTHH:MM:SS+HH:MM</c> (for example, <c>2024-01-04T15:25:10+17:59</c>)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>YYYY-MM-DDTHH:MM:SS-HHMM</c> (for example, <c>2024-01-04T15:25:10-1759</c>)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>YYYY-MM-DDTHH:MM:SS.mmmmmmmmm+HH:MM</c> (for example, <c>2024-01-04T15:25:10.123456789+17:59</c>)
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string CreatedAt
        {
            get { return this._createdAt; }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        ///  The name of the bucket. 
        /// </para>
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property ObjectLockConfiguration. 
        /// <para>
        ///  Specifies which rule Amazon S3 applies by default to every new object placed in the
        /// bucket. 
        /// </para>
        /// </summary>
        public AwsS3BucketObjectLockConfiguration ObjectLockConfiguration
        {
            get { return this._objectLockConfiguration; }
            set { this._objectLockConfiguration = value; }
        }

        // Check to see if ObjectLockConfiguration property is set
        internal bool IsSetObjectLockConfiguration()
        {
            return this._objectLockConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property OwnerAccountId. 
        /// <para>
        /// The Amazon Web Services account identifier of the account that owns the S3 bucket.
        /// </para>
        /// </summary>
        public string OwnerAccountId
        {
            get { return this._ownerAccountId; }
            set { this._ownerAccountId = value; }
        }

        // Check to see if OwnerAccountId property is set
        internal bool IsSetOwnerAccountId()
        {
            return this._ownerAccountId != null;
        }

        /// <summary>
        /// Gets and sets the property OwnerId. 
        /// <para>
        /// The canonical user ID of the owner of the S3 bucket.
        /// </para>
        /// </summary>
        public string OwnerId
        {
            get { return this._ownerId; }
            set { this._ownerId = value; }
        }

        // Check to see if OwnerId property is set
        internal bool IsSetOwnerId()
        {
            return this._ownerId != null;
        }

        /// <summary>
        /// Gets and sets the property OwnerName. 
        /// <para>
        /// The display name of the owner of the S3 bucket.
        /// </para>
        /// </summary>
        public string OwnerName
        {
            get { return this._ownerName; }
            set { this._ownerName = value; }
        }

        // Check to see if OwnerName property is set
        internal bool IsSetOwnerName()
        {
            return this._ownerName != null;
        }

        /// <summary>
        /// Gets and sets the property PublicAccessBlockConfiguration. 
        /// <para>
        /// Provides information about the Amazon S3 Public Access Block configuration for the
        /// S3 bucket.
        /// </para>
        /// </summary>
        public AwsS3AccountPublicAccessBlockDetails PublicAccessBlockConfiguration
        {
            get { return this._publicAccessBlockConfiguration; }
            set { this._publicAccessBlockConfiguration = value; }
        }

        // Check to see if PublicAccessBlockConfiguration property is set
        internal bool IsSetPublicAccessBlockConfiguration()
        {
            return this._publicAccessBlockConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property ServerSideEncryptionConfiguration. 
        /// <para>
        /// The encryption rules that are applied to the S3 bucket.
        /// </para>
        /// </summary>
        public AwsS3BucketServerSideEncryptionConfiguration ServerSideEncryptionConfiguration
        {
            get { return this._serverSideEncryptionConfiguration; }
            set { this._serverSideEncryptionConfiguration = value; }
        }

        // Check to see if ServerSideEncryptionConfiguration property is set
        internal bool IsSetServerSideEncryptionConfiguration()
        {
            return this._serverSideEncryptionConfiguration != null;
        }

    }
}