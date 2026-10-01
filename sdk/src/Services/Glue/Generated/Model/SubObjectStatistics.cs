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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
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
namespace Amazon.Glue.Model
{
    /// <summary>
    /// Statistics for one sub-object referenced by a materialized view, recorded when the
    /// materialized view was created or last fully refreshed. These values describe what
    /// that refresh selected from the sub-object, which can be a subset of the table when
    /// the materialized view's definition limits the data it reads. The fields present depend
    /// on the sub-object's format.
    /// </summary>
    public partial class SubObjectStatistics
    {
        private long? _fileCount;
        private string _glueVersionId;
        private long? _partitionCount;
        private SubObjectSourceType _sourceType;
        private long? _totalFileBytes;

        /// <summary>
        /// Gets and sets the property FileCount. 
        /// <para>
        /// The number of sub-object data files selected for that refresh.
        /// </para>
        /// </summary>
        public long? FileCount
        {
            get { return this._fileCount; }
            set { this._fileCount = value; }
        }

        // Check to see if FileCount property is set
        internal bool IsSetFileCount()
        {
            return this._fileCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property GlueVersionId. 
        /// <para>
        /// The Glue version ID of the sub-object that the statistics were captured for.
        /// </para>
        /// </summary>
        public string GlueVersionId
        {
            get { return this._glueVersionId; }
            set { this._glueVersionId = value; }
        }

        // Check to see if GlueVersionId property is set
        internal bool IsSetGlueVersionId()
        {
            return this._glueVersionId != null;
        }

        /// <summary>
        /// Gets and sets the property PartitionCount. 
        /// <para>
        /// The number of sub-object partitions selected for that refresh. Not present for unpartitioned
        /// sub-objects.
        /// </para>
        /// </summary>
        public long? PartitionCount
        {
            get { return this._partitionCount; }
            set { this._partitionCount = value; }
        }

        // Check to see if PartitionCount property is set
        internal bool IsSetPartitionCount()
        {
            return this._partitionCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SourceType. 
        /// <para>
        /// The source type of the sub-object (for example, its table format), which identifies
        /// the sub-object.
        /// </para>
        /// </summary>
        public SubObjectSourceType SourceType
        {
            get { return this._sourceType; }
            set { this._sourceType = value; }
        }

        // Check to see if SourceType property is set
        internal bool IsSetSourceType()
        {
            return this._sourceType != null;
        }

        /// <summary>
        /// Gets and sets the property TotalFileBytes. 
        /// <para>
        /// The total size, in bytes, of the data files counted by <c>FileCount</c>.
        /// </para>
        /// </summary>
        public long? TotalFileBytes
        {
            get { return this._totalFileBytes; }
            set { this._totalFileBytes = value; }
        }

        // Check to see if TotalFileBytes property is set
        internal bool IsSetTotalFileBytes()
        {
            return this._totalFileBytes.HasValue; 
        }

    }
}