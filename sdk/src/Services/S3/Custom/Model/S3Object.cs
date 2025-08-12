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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

namespace Amazon.S3.Model
{
    /// <summary>
    /// Represents an S3 Object. Contains all attributes that an S3 Object has.
    /// For more information about S3 Objects refer:
    /// <see href="http://docs.amazonwebservices.com/AmazonS3/latest/UsingObjects.html"/>
    /// </summary>
    public class S3Object
    {
        private List<string> _checksumAlgorithm = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string eTag;
        private string key;
        private DateTime? lastModified;
        private Owner owner;
        private RestoreStatus _restoreStatus;
        private long? size;
        private S3StorageClass storageClass;
        private string bucketName;
        private ChecksumType checksumType;

        /// <summary>
        /// Gets and sets the property ChecksumAlgorithm. 
        /// <para>
        /// The algorithm that was used to create a checksum of the object.
        /// </para>
        /// </summary>
        public List<string> ChecksumAlgorithm
        {
            get { return this._checksumAlgorithm; }
            set { this._checksumAlgorithm = value; }
        }

        // Check to see if ChecksumAlgorithm property is set
        internal bool IsSetChecksumAlgorithm()
        {
            return this._checksumAlgorithm != null && (this._checksumAlgorithm.Count > 0 || !AWSConfigs.InitializeCollections);
        }

        /// <summary>
        /// Gets and sets the property ETag. 
        /// <para>
        /// The entity tag is a hash of the object. The ETag reflects changes only to the contents
        /// of an object, not its metadata. The ETag may or may not be an MD5 digest of the object
        /// data. Whether or not it is depends on how the object was created and how it is encrypted
        /// as described below:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Objects created by the PUT Object, POST Object, or Copy operation, or through the
        /// Amazon Web Services Management Console, and are encrypted by SSE-S3 or plaintext,
        /// have ETags that are an MD5 digest of their object data.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Objects created by the PUT Object, POST Object, or Copy operation, or through the
        /// Amazon Web Services Management Console, and are encrypted by SSE-C or SSE-KMS, have
        /// ETags that are not an MD5 digest of their object data.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If an object is created by either the Multipart Upload or Part Copy operation, the
        /// ETag is not an MD5 digest, regardless of the method of encryption. If an object is
        /// larger than 16 MB, the Amazon Web Services Management Console will upload or copy
        /// that object as a Multipart Upload, and therefore the ETag will not be an MD5 digest.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string ETag
        {
            get { return this.eTag; }
            set { this.eTag = value; }
        }

        // Check to see if ETag property is set
        internal bool IsSetETag()
        {
            return this.eTag != null;
        }

        /// <summary>
        /// The name of the bucket containing this object.
        /// </summary>
        public string BucketName
        {
            get { return this.bucketName; }
            set { this.bucketName = value; }
        }

        // check to see if the BucketName property is set
        internal bool IsSetBucketName()
        {
            return this.bucketName != null;
        }

        /// <summary>
        /// The key of the object.
        /// </summary>
        public string Key
        {
            get { return this.key; }
            set { this.key = value; }
        }

        // Check to see if Key property is set
        internal bool IsSetKey()
        {
            return this.key != null;
        }

        /// <summary>
        /// Gets and sets the property LastModified. 
        /// <para>
        /// Date and time when the object was last modified.
        /// </para>
        /// <remarks>
        /// The date retrieved from S3 is in ISO8601 format. A GMT formatted date is passed back to the user.
        /// </remarks>
        /// </summary>
        public DateTime? LastModified
        {
            get { return this.lastModified; }
            set { this.lastModified = value; }
        }

        // Check to see if LastModified property is set
        internal bool IsSetLastModified()
        {
            return this.lastModified.HasValue;
        }

        /// <summary>
        /// The owner of the object.
        /// </summary>
        public Owner Owner
        {
            get { return this.owner; }
            set { this.owner = value; }
        }

        // Check to see if Owner property is set
        internal bool IsSetOwner()
        {
            return this.owner != null;
        }

        /// <summary>
        /// Gets and sets the property RestoreStatus. 
        /// <para>
        /// Specifies the restoration status of an object. Objects in certain storage classes
        /// must be restored before they can be retrieved. For more information about these storage
        /// classes and how to work with archived objects, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/archived-objects.html">
        /// Working with archived objects</a> in the <i>Amazon S3 User Guide</i>.
        /// </para>
        /// </summary>
        public RestoreStatus RestoreStatus
        {
            get { return this._restoreStatus; }
            set { this._restoreStatus = value; }
        }

        // Check to see if RestoreStatus property is set
        internal bool IsSetRestoreStatus()
        {
            return this._restoreStatus != null;
        }
        /// <summary>
        /// The size of the object.
        /// </summary>
        public long? Size
        {
            get { return this.size; }
            set { this.size = value; }
        }

        // Check to see if Size property is set
        internal bool IsSetSize()
        {
            return this.size.HasValue;
        }

        /// <summary>
        /// The class of storage used to store the object.
        ///  
        /// </summary>
        public S3StorageClass StorageClass
        {
            get { return this.storageClass; }
            set { this.storageClass = value; }
        }

        // Check to see if StorageClass property is set
        internal bool IsSetStorageClass()
        {
            return this.storageClass != null;
        }

        /// <summary>
        /// Gets and sets the property ChecksumType.
        /// <para>
        /// The checksum type that is used to calculate the object's checksum value.
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/checking-object-integrity.html">
        /// Checking object integrity in the Amazon S3 User Guide</a>.
        /// </para>
        /// </summary>
        public ChecksumType ChecksumType
        {
            get { return this.checksumType; }
            set { this.checksumType = value; }
        }

        /// <summary>
        /// Checks to see if ChecksumType is set.
        /// </summary>
        /// <returns>true, if ChecksumType property is set.</returns>
        internal bool IsSetChecksumType()
        {
            return checksumType != null;
        }
    }
}
