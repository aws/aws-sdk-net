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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
        /// <summary>
        /// Gets and sets the property FileCount. 
        /// <para>
        /// The number of sub-object data files selected for that refresh.
        /// </para>
        /// </summary>
        public long? FileCount { get; set; }

        /// <summary>
        /// Checks to see if the FileCount property is set.
        /// </summary>
        internal bool IsSetFileCount() => this.FileCount.HasValue;

        /// <summary>
        /// Gets and sets the property GlueVersionId. 
        /// <para>
        /// The Glue version ID of the sub-object that the statistics were captured for.
        /// </para>
        /// </summary>
        public string GlueVersionId { get; set; }

        /// <summary>
        /// Checks to see if the GlueVersionId property is set.
        /// </summary>
        internal bool IsSetGlueVersionId() => this.GlueVersionId != null;

        /// <summary>
        /// Gets and sets the property PartitionCount. 
        /// <para>
        /// The number of sub-object partitions selected for that refresh. Not present for unpartitioned
        /// sub-objects.
        /// </para>
        /// </summary>
        public long? PartitionCount { get; set; }

        /// <summary>
        /// Checks to see if the PartitionCount property is set.
        /// </summary>
        internal bool IsSetPartitionCount() => this.PartitionCount.HasValue;

        /// <summary>
        /// Gets and sets the property SourceType. 
        /// <para>
        /// The source type of the sub-object (for example, its table format), which identifies
        /// the sub-object.
        /// </para>
        /// </summary>
        public SubObjectSourceType SourceType { get; set; }

        /// <summary>
        /// Checks to see if the SourceType property is set.
        /// </summary>
        internal bool IsSetSourceType() => this.SourceType != null;

        /// <summary>
        /// Gets and sets the property TotalFileBytes. 
        /// <para>
        /// The total size, in bytes, of the data files counted by <c>FileCount</c>.
        /// </para>
        /// </summary>
        public long? TotalFileBytes { get; set; }

        /// <summary>
        /// Checks to see if the TotalFileBytes property is set.
        /// </summary>
        internal bool IsSetTotalFileBytes() => this.TotalFileBytes.HasValue;
    }
}
