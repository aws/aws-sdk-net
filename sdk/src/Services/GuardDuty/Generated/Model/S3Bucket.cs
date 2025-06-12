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
 * Do not modify this file. This file is generated from the guardduty-2017-11-28.normal.json service model.
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
        private PublicAccessConfiguration _accountPublicAccess;
        private PublicAccessConfiguration _bucketPublicAccess;
        private DateTime? _createdAt;
        private string _effectivePermission;
        private string _encryptionKeyArn;
        private string _encryptionType;
        private string _ownerId;
        private PublicAccessStatus _publicReadAccess;
        private PublicAccessStatus _publicWriteAccess;
        private List<string> _s3ObjectUids = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property AccountPublicAccess. 
        /// <para>
        /// Contains information about the public access policies that apply to the Amazon S3
        /// bucket at the account level.
        /// </para>
        /// </summary>
        public PublicAccessConfiguration AccountPublicAccess
        {
            get { return this._accountPublicAccess; }
            set { this._accountPublicAccess = value; }
        }

        // Check to see if AccountPublicAccess property is set
        internal bool IsSetAccountPublicAccess()
        {
            return this._accountPublicAccess != null;
        }

        /// <summary>
        /// Gets and sets the property BucketPublicAccess. 
        /// <para>
        /// Contains information about public access policies that apply to the Amazon S3 bucket.
        /// </para>
        /// </summary>
        public PublicAccessConfiguration BucketPublicAccess
        {
            get { return this._bucketPublicAccess; }
            set { this._bucketPublicAccess = value; }
        }

        // Check to see if BucketPublicAccess property is set
        internal bool IsSetBucketPublicAccess()
        {
            return this._bucketPublicAccess != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The timestamp at which the Amazon S3 bucket was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt
        {
            get { return this._createdAt; }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EffectivePermission. 
        /// <para>
        /// Describes the effective permissions on this S3 bucket, after factoring all the attached
        /// policies.
        /// </para>
        /// </summary>
        public string EffectivePermission
        {
            get { return this._effectivePermission; }
            set { this._effectivePermission = value; }
        }

        // Check to see if EffectivePermission property is set
        internal bool IsSetEffectivePermission()
        {
            return this._effectivePermission != null;
        }

        /// <summary>
        /// Gets and sets the property EncryptionKeyArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the encryption key that is used to encrypt the Amazon
        /// S3 bucket and its objects.
        /// </para>
        /// </summary>
        public string EncryptionKeyArn
        {
            get { return this._encryptionKeyArn; }
            set { this._encryptionKeyArn = value; }
        }

        // Check to see if EncryptionKeyArn property is set
        internal bool IsSetEncryptionKeyArn()
        {
            return this._encryptionKeyArn != null;
        }

        /// <summary>
        /// Gets and sets the property EncryptionType. 
        /// <para>
        /// The type of encryption used for the Amazon S3 buckets and its objects. For more information,
        /// see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/serv-side-encryption.html">Protecting
        /// data with server-side encryption</a> in the <i>Amazon S3 User Guide</i>.
        /// </para>
        /// </summary>
        public string EncryptionType
        {
            get { return this._encryptionType; }
            set { this._encryptionType = value; }
        }

        // Check to see if EncryptionType property is set
        internal bool IsSetEncryptionType()
        {
            return this._encryptionType != null;
        }

        /// <summary>
        /// Gets and sets the property OwnerId. 
        /// <para>
        /// The owner ID of the associated S3Amazon S3bucket.
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
        /// Gets and sets the property PublicReadAccess. 
        /// <para>
        /// Indicates whether or not the public read access is allowed for an Amazon S3 bucket.
        /// </para>
        /// </summary>
        public PublicAccessStatus PublicReadAccess
        {
            get { return this._publicReadAccess; }
            set { this._publicReadAccess = value; }
        }

        // Check to see if PublicReadAccess property is set
        internal bool IsSetPublicReadAccess()
        {
            return this._publicReadAccess != null;
        }

        /// <summary>
        /// Gets and sets the property PublicWriteAccess. 
        /// <para>
        /// Indicates whether or not the public write access is allowed for an Amazon S3 bucket.
        /// </para>
        /// </summary>
        public PublicAccessStatus PublicWriteAccess
        {
            get { return this._publicWriteAccess; }
            set { this._publicWriteAccess = value; }
        }

        // Check to see if PublicWriteAccess property is set
        internal bool IsSetPublicWriteAccess()
        {
            return this._publicWriteAccess != null;
        }

        /// <summary>
        /// Gets and sets the property S3ObjectUids. 
        /// <para>
        /// Represents a list of Amazon S3 object identifiers.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> S3ObjectUids
        {
            get { return this._s3ObjectUids; }
            set { this._s3ObjectUids = value; }
        }

        // Check to see if S3ObjectUids property is set
        internal bool IsSetS3ObjectUids()
        {
            return this._s3ObjectUids != null && (this._s3ObjectUids.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}