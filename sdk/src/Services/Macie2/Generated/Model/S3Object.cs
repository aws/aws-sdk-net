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
 * Do not modify this file. This file is generated from the macie2-2020-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Macie2.Model
{
    /// <summary>
    /// Provides information about the S3 object that a finding applies to.
    /// </summary>
    public partial class S3Object
    {
        private string _bucketArn;
        private string _eTag;
        private string _extension;
        private string _key;
        private DateTime? _lastModified;
        private string _path;
        private bool? _publicAccess;
        private ServerSideEncryption _serverSideEncryption;
        private long? _size;
        private StorageClass _storageClass;
        private List<KeyValuePair> _tags = new List<KeyValuePair>();
        private string _versionId;

        /// <summary>
        /// Gets and sets the property BucketArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the bucket that contains the object.
        /// </para>
        /// </summary>
        public string BucketArn
        {
            get { return this._bucketArn; }
            set { this._bucketArn = value; }
        }

        // Check to see if BucketArn property is set
        internal bool IsSetBucketArn()
        {
            return this._bucketArn != null;
        }

        /// <summary>
        /// Gets and sets the property ETag. 
        /// <para>
        /// The entity tag (ETag) that identifies the affected version of the object. If the object
        /// was overwritten or changed after Amazon Macie produced the finding, this value might
        /// be different from the current ETag for the object.
        /// </para>
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
        /// Gets and sets the property Extension. 
        /// <para>
        /// The file name extension of the object. If the object doesn't have a file name extension,
        /// this value is "".
        /// </para>
        /// </summary>
        public string Extension
        {
            get { return this._extension; }
            set { this._extension = value; }
        }

        // Check to see if Extension property is set
        internal bool IsSetExtension()
        {
            return this._extension != null;
        }

        /// <summary>
        /// Gets and sets the property Key. 
        /// <para>
        /// The full key (name) that's assigned to the object.
        /// </para>
        /// </summary>
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
        /// The date and time, in UTC and extended ISO 8601 format, when the object was last modified.
        /// </para>
        /// </summary>
        public DateTime LastModified
        {
            get { return this._lastModified.GetValueOrDefault(); }
            set { this._lastModified = value; }
        }

        // Check to see if LastModified property is set
        internal bool IsSetLastModified()
        {
            return this._lastModified.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Path. 
        /// <para>
        /// The path to the object, including the full key (name).
        /// </para>
        /// </summary>
        public string Path
        {
            get { return this._path; }
            set { this._path = value; }
        }

        // Check to see if Path property is set
        internal bool IsSetPath()
        {
            return this._path != null;
        }

        /// <summary>
        /// Gets and sets the property PublicAccess. 
        /// <para>
        /// Specifies whether the object is publicly accessible due to the combination of permissions
        /// settings that apply to the object.
        /// </para>
        /// </summary>
        public bool PublicAccess
        {
            get { return this._publicAccess.GetValueOrDefault(); }
            set { this._publicAccess = value; }
        }

        // Check to see if PublicAccess property is set
        internal bool IsSetPublicAccess()
        {
            return this._publicAccess.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ServerSideEncryption. 
        /// <para>
        /// The type of server-side encryption that was used to encrypt the object.
        /// </para>
        /// </summary>
        public ServerSideEncryption ServerSideEncryption
        {
            get { return this._serverSideEncryption; }
            set { this._serverSideEncryption = value; }
        }

        // Check to see if ServerSideEncryption property is set
        internal bool IsSetServerSideEncryption()
        {
            return this._serverSideEncryption != null;
        }

        /// <summary>
        /// Gets and sets the property Size. 
        /// <para>
        /// The total storage size, in bytes, of the object.
        /// </para>
        /// </summary>
        public long Size
        {
            get { return this._size.GetValueOrDefault(); }
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
        /// The storage class of the object.
        /// </para>
        /// </summary>
        public StorageClass StorageClass
        {
            get { return this._storageClass; }
            set { this._storageClass = value; }
        }

        // Check to see if StorageClass property is set
        internal bool IsSetStorageClass()
        {
            return this._storageClass != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags that are associated with the object.
        /// </para>
        /// </summary>
        public List<KeyValuePair> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property VersionId. 
        /// <para>
        /// The identifier for the affected version of the object.
        /// </para>
        /// </summary>
        public string VersionId
        {
            get { return this._versionId; }
            set { this._versionId = value; }
        }

        // Check to see if VersionId property is set
        internal bool IsSetVersionId()
        {
            return this._versionId != null;
        }

    }
}