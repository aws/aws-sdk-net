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
    /// Specifies an object key and optional object version.
    /// </summary>
    public class KeyVersion
    {
        
        private string key;
        private string versionId;
        private string eTag;
        private DateTime? lastModifiedTime;
        private long? size;

        /// <summary>
        /// Key name of the object to delete.
        ///  
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
        /// VersionId for the specific version of the object to delete.
        ///  
        /// </summary>
        public string VersionId
        {
            get { return this.versionId; }
            set { this.versionId = value; }
        }

        // Check to see if VersionId property is set
        internal bool IsSetVersionId()
        {
            return this.versionId != null;
        }

        /// <summary>
        /// Gets and sets the property ETag. 
        /// <para>An entity tag (ETag) is an identifier assigned by a web server to a specific version of a resource found at a URL.
        /// This header field makes the request method conditional on <c>ETags</c>. </para>
        /// <note>
        /// <para>Entity tags (ETags) for S3 Express One Zone are random alphanumeric strings unique to the object. </para>
        /// </note>
        /// </summary>
        public string ETag
        {
            get { return this.eTag; }
            set { this.eTag = value; }
        }

        // Check to see if ETag property is set
        internal bool IsSetETag()
        {
            return !String.IsNullOrEmpty(this.eTag);
        }

        /// <summary>
        /// Gets and sets the property Size. 
        /// <para>If present, the objects are deleted only if its size matches the provided size in bytes. </para>
        /// <note>
        /// <para>This functionality is only supported for directory buckets.</para>
        /// </note>
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
        /// Gets and sets the property LastModifiedTime. 
        /// <para>If present, the objects are deleted only if its modification times matches the provided <c>Timestamp</c>.
        /// </para>
        /// <note>
        /// <para>This functionality is only supported for directory buckets.</para>
        /// </note>
        /// </summary>
        public DateTime? LastModifiedTime
        {
            get { return this.lastModifiedTime; }
            set { this.lastModifiedTime = value; }
        }

        // Check to see if LastModifiedTime property is set
        internal bool IsSetLastModifiedTime()
        {
            return this.lastModifiedTime.HasValue;
        }
    }
}
