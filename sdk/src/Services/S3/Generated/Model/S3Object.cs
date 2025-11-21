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
 * Do not modify this file. This file is generated from the s3-2006-03-01.normal.json service model.
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
namespace Amazon.S3.Model
{
    /// <summary>
    /// An object consists of data and its descriptive metadata.
    /// </summary>
    public partial class S3Object
    {
        private List<string> _checksumAlgorithm = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private ChecksumType _checksumType;
        private string _eTag;
        private string _key;
        private DateTime? _lastModified;
        private Owner _owner;
        private RestoreStatus _restoreStatus;
        private long? _size;
        private S3StorageClass _storageClass;

        /// <summary>
        /// Gets and sets the property ChecksumAlgorithm. 
        /// <para>
        /// The algorithm that was used to create a checksum of the object.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
        /// Gets and sets the property ChecksumType. 
        /// <para>
        /// The checksum type that is used to calculate the object’s checksum value. For more
        /// information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/checking-object-integrity.html">Checking
        /// object integrity</a> in the <i>Amazon S3 User Guide</i>.
        /// </para>
        /// </summary>
        public ChecksumType ChecksumType
        {
            get { return this._checksumType; }
            set { this._checksumType = value; }
        }

        // Check to see if ChecksumType property is set
        internal bool IsSetChecksumType()
        {
            return this._checksumType != null;
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
        ///  </li> </ul> <note> 
        /// <para>
        ///  <b>Directory buckets</b> - MD5 is not supported by directory buckets.
        /// </para>
        ///  </note>
        /// </summary>
        public string ETag
        {
            get { return this._eTag; }
            set { this._eTag = value; }
        }

        // Check to see if ETag property is set
        internal bool IsSetETag()
        {
            return this._eTag != null;
        }

        /// <summary>
        /// Gets and sets the property Key. 
        /// <para>
        /// The name that you assign to an object. You use the object key to retrieve the object.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public string Key
        {
            get { return this._key; }
            set { this._key = value; }
        }

        // Check to see if Key property is set
        internal bool IsSetKey()
        {
            return this._key != null;
        }

        /// <summary>
        /// Gets and sets the property LastModified. 
        /// <para>
        /// Creation date of the object.
        /// </para>
        /// </summary>
        public DateTime? LastModified
        {
            get { return this._lastModified; }
            set { this._lastModified = value; }
        }

        // Check to see if LastModified property is set
        internal bool IsSetLastModified()
        {
            return this._lastModified.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Owner. 
        /// <para>
        /// The owner of the object
        /// </para>
        ///  <note> 
        /// <para>
        ///  <b>Directory buckets</b> - The bucket owner is returned as the object owner.
        /// </para>
        ///  </note>
        /// </summary>
        public Owner Owner
        {
            get { return this._owner; }
            set { this._owner = value; }
        }

        // Check to see if Owner property is set
        internal bool IsSetOwner()
        {
            return this._owner != null;
        }

        /// <summary>
        /// Gets and sets the property RestoreStatus. 
        /// <para>
        /// Specifies the restoration status of an object. Objects in certain storage classes
        /// must be restored before they can be retrieved. For more information about these storage
        /// classes and how to work with archived objects, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/archived-objects.html">
        /// Working with archived objects</a> in the <i>Amazon S3 User Guide</i>.
        /// </para>
        ///  <note> 
        /// <para>
        /// This functionality is not supported for directory buckets. Directory buckets only
        /// support <c>EXPRESS_ONEZONE</c> (the S3 Express One Zone storage class) in Availability
        /// Zones and <c>ONEZONE_IA</c> (the S3 One Zone-Infrequent Access storage class) in Dedicated
        /// Local Zones.
        /// </para>
        ///  </note>
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
        /// Gets and sets the property Size. 
        /// <para>
        /// Size in bytes of the object
        /// </para>
        /// </summary>
        public long? Size
        {
            get { return this._size; }
            set { this._size = value; }
        }

        // Check to see if Size property is set
        internal bool IsSetSize()
        {
            return this._size.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StorageClass. 
        /// <para>
        /// The class of storage used to store the object.
        /// </para>
        ///  <note> 
        /// <para>
        ///  <b>Directory buckets</b> - Directory buckets only support <c>EXPRESS_ONEZONE</c>
        /// (the S3 Express One Zone storage class) in Availability Zones and <c>ONEZONE_IA</c>
        /// (the S3 One Zone-Infrequent Access storage class) in Dedicated Local Zones.
        /// </para>
        ///  </note>
        /// </summary>
        public S3StorageClass StorageClass
        {
            get { return this._storageClass; }
            set { this._storageClass = value; }
        }

        // Check to see if StorageClass property is set
        internal bool IsSetStorageClass()
        {
            return this._storageClass != null;
        }

    }
}