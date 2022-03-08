﻿/*
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
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.S3.Model
{
    /// <summary>
    /// This is the response object from the GetObjectAttributes operation.
    /// </summary>
    public partial class GetObjectAttributesResponse : AmazonWebServiceResponse
    {
        private Checksum _checksum;
        private bool? _deleteMarker;
        private string _eTag;
        private DateTime? _lastModified;
        private GetObjectAttributesParts _objectParts;
        private long? _objectSize;
        private RequestCharged _requestCharged;
        private S3StorageClass _storageClass;
        private string _versionId;

        /// <summary>
        /// Gets and sets the property Checksum. 
        /// <para>
        /// The checksum or digest of the object.
        /// </para>
        /// </summary>
        public Checksum Checksum
        {
            get { return this._checksum; }
            set { this._checksum = value; }
        }

        // Check to see if Checksum property is set
        internal bool IsSetChecksum()
        {
            return this._checksum != null;
        }

        /// <summary>
        /// Gets and sets the property DeleteMarker. 
        /// <para>
        /// Specifies whether the object retrieved was (true) or was not (false) a Delete Marker.
        /// If false, this response header does not appear in the response.
        /// </para>
        /// </summary>
        public bool DeleteMarker
        {
            get { return this._deleteMarker.GetValueOrDefault(); }
            set { this._deleteMarker = value; }
        }

        // Check to see if DeleteMarker property is set
        internal bool IsSetDeleteMarker()
        {
            return this._deleteMarker.HasValue;
        }

        /// <summary>
        /// Gets and sets the property ETag. 
        /// <para>
        /// An ETag is an opaque identifier assigned by a web server to a specific version of
        /// a resource found at a URL.
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
        /// Gets and sets the property LastModified. 
        /// <para>
        /// Creation date of the object.
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
        /// Gets and sets the property ObjectParts. 
        /// <para>
        /// A collection of parts associated with a multipart upload.
        /// </para>
        /// </summary>
        public GetObjectAttributesParts ObjectParts
        {
            get { return this._objectParts; }
            set { this._objectParts = value; }
        }

        // Check to see if ObjectParts property is set
        internal bool IsSetObjectParts()
        {
            return this._objectParts != null;
        }

        /// <summary>
        /// Gets and sets the property ObjectSize. 
        /// <para>
        /// The size of the object in bytes.
        /// </para>
        /// </summary>
        public long ObjectSize
        {
            get { return this._objectSize.GetValueOrDefault(); }
            set { this._objectSize = value; }
        }

        // Check to see if ObjectSize property is set
        internal bool IsSetObjectSize()
        {
            return this._objectSize.HasValue;
        }

        /// <summary>
        /// Gets and sets the property RequestCharged.
        /// </summary>
        public RequestCharged RequestCharged
        {
            get { return this._requestCharged; }
            set { this._requestCharged = value; }
        }

        // Check to see if RequestCharged property is set
        internal bool IsSetRequestCharged()
        {
            return this._requestCharged != null;
        }

        /// <summary>
        /// Gets and sets the property StorageClass. 
        /// <para>
        /// Provides storage class information of the object. Amazon S3 returns this header for
        /// all objects except for S3 Standard storage class objects.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/storage-class-intro.html">Storage
        /// Classes</a>.
        /// </para>
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

        /// <summary>
        /// Gets and sets the property VersionId. 
        /// <para>
        /// Version of the object.
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