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
    /// Object Identifier is unique value to identify objects.
    /// </summary>
    public partial class KeyVersion
    {
        private string _eTag;
        private string _key;
        private DateTime? _lastModifiedTime;
        private long? _size;
        private string _versionId;

        /// <summary>
        /// Gets and sets the property ETag. 
        /// <para>
        /// An entity tag (ETag) is an identifier assigned by a web server to a specific version
        /// of a resource found at a URL. This header field makes the request method conditional
        /// on <c>ETags</c>. 
        /// </para>
        ///  <note> 
        /// <para>
        /// Entity tags (ETags) for S3 Express One Zone are random alphanumeric strings unique
        /// to the object. 
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
            return !String.IsNullOrEmpty(this._eTag);
        }

        /// <summary>
        /// Gets and sets the property Key. 
        /// <para>
        /// Key name of the object.
        /// </para>
        ///  <important> 
        /// <para>
        /// Replacement must be made for object keys containing special characters (such as carriage
        /// returns) when using XML requests. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/object-keys.html#object-key-xml-related-constraints">
        /// XML related object key constraints</a>.
        /// </para>
        ///  </important>
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
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
        /// Gets and sets the property LastModifiedTime. 
        /// <para>
        /// If present, the objects are deleted only if its modification times matches the provided
        /// <c>Timestamp</c>. 
        /// </para>
        ///  <note> 
        /// <para>
        /// This functionality is only supported for directory buckets.
        /// </para>
        ///  </note>
        /// </summary>
        public DateTime? LastModifiedTime
        {
            get { return this._lastModifiedTime; }
            set { this._lastModifiedTime = value; }
        }

        // Check to see if LastModifiedTime property is set
        internal bool IsSetLastModifiedTime()
        {
            return this._lastModifiedTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Size. 
        /// <para>
        /// If present, the objects are deleted only if its size matches the provided size in
        /// bytes. 
        /// </para>
        ///  <note> 
        /// <para>
        /// This functionality is only supported for directory buckets.
        /// </para>
        ///  </note>
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
        /// Gets and sets the property VersionId. 
        /// <para>
        /// Version ID for the specific version of the object to delete.
        /// </para>
        ///  <note> 
        /// <para>
        /// This functionality is not supported for directory buckets.
        /// </para>
        ///  </note>
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