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
    /// Describes a single annotation attached to an object, including its name, last modified
    /// time, size, ETag, checksum algorithm, and replication status. Returned in the response
    /// from <c>ListObjectAnnotations</c>.
    /// </summary>
    public partial class AnnotationEntry
    {
        private string _annotationName;
        private List<string> _checksumAlgorithm = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _eTag;
        private DateTime? _lastModified;
        private ReplicationStatus _replicationStatus;
        private long? _size;

        /// <summary>
        /// Gets and sets the property AnnotationName. 
        /// <para>
        /// The name of the annotation.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string AnnotationName
        {
            get { return this._annotationName; }
            set { this._annotationName = value; }
        }

        // Check to see if AnnotationName property is set
        internal bool IsSetAnnotationName()
        {
            return this._annotationName != null;
        }

        /// <summary>
        /// Gets and sets the property ChecksumAlgorithm. 
        /// <para>
        /// The checksum algorithm used for the annotation.
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
        /// Gets and sets the property ETag. 
        /// <para>
        /// The entity tag of the annotation.
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
        /// The date and time the annotation was last modified.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property ReplicationStatus. 
        /// <para>
        /// The replication status of the annotation.
        /// </para>
        /// </summary>
        public ReplicationStatus ReplicationStatus
        {
            get { return this._replicationStatus; }
            set { this._replicationStatus = value; }
        }

        // Check to see if ReplicationStatus property is set
        internal bool IsSetReplicationStatus()
        {
            return this._replicationStatus != null;
        }

        /// <summary>
        /// Gets and sets the property Size. 
        /// <para>
        /// The size of the annotation payload, in bytes.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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

    }
}