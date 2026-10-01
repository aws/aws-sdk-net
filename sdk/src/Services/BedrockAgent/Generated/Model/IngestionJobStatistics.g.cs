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

namespace Amazon.BedrockAgent.Model
{
    /// <summary>
    /// Contains the statistics for the data ingestion job.
    /// </summary>
    public partial class IngestionJobStatistics
    {
        /// <summary>
        /// Gets and sets the property NumberOfDocumentsDeleted. 
        /// <para>
        /// The number of source documents that were deleted.
        /// </para>
        /// </summary>
        public long? NumberOfDocumentsDeleted { get; set; }

        /// <summary>
        /// Checks to see if the NumberOfDocumentsDeleted property is set.
        /// </summary>
        internal bool IsSetNumberOfDocumentsDeleted() => this.NumberOfDocumentsDeleted.HasValue;

        /// <summary>
        /// Gets and sets the property NumberOfDocumentsFailed. 
        /// <para>
        /// The number of source documents that failed to be ingested.
        /// </para>
        /// </summary>
        public long? NumberOfDocumentsFailed { get; set; }

        /// <summary>
        /// Checks to see if the NumberOfDocumentsFailed property is set.
        /// </summary>
        internal bool IsSetNumberOfDocumentsFailed() => this.NumberOfDocumentsFailed.HasValue;

        /// <summary>
        /// Gets and sets the property NumberOfDocumentsScanned. 
        /// <para>
        /// The total number of source documents that were scanned. Includes new, updated, and
        /// unchanged documents.
        /// </para>
        /// </summary>
        public long? NumberOfDocumentsScanned { get; set; }

        /// <summary>
        /// Checks to see if the NumberOfDocumentsScanned property is set.
        /// </summary>
        internal bool IsSetNumberOfDocumentsScanned() => this.NumberOfDocumentsScanned.HasValue;

        /// <summary>
        /// Gets and sets the property NumberOfDocumentsSkipped. 
        /// <para>
        /// The number of source documents that were skipped during ingestion.
        /// </para>
        /// </summary>
        public long? NumberOfDocumentsSkipped { get; set; }

        /// <summary>
        /// Checks to see if the NumberOfDocumentsSkipped property is set.
        /// </summary>
        internal bool IsSetNumberOfDocumentsSkipped() => this.NumberOfDocumentsSkipped.HasValue;

        /// <summary>
        /// Gets and sets the property NumberOfMetadataDocumentsModified. 
        /// <para>
        /// The number of metadata files that were updated or deleted.
        /// </para>
        /// </summary>
        public long? NumberOfMetadataDocumentsModified { get; set; }

        /// <summary>
        /// Checks to see if the NumberOfMetadataDocumentsModified property is set.
        /// </summary>
        internal bool IsSetNumberOfMetadataDocumentsModified() => this.NumberOfMetadataDocumentsModified.HasValue;

        /// <summary>
        /// Gets and sets the property NumberOfMetadataDocumentsScanned. 
        /// <para>
        /// The total number of metadata files that were scanned. Includes new, updated, and unchanged
        /// files.
        /// </para>
        /// </summary>
        public long? NumberOfMetadataDocumentsScanned { get; set; }

        /// <summary>
        /// Checks to see if the NumberOfMetadataDocumentsScanned property is set.
        /// </summary>
        internal bool IsSetNumberOfMetadataDocumentsScanned() => this.NumberOfMetadataDocumentsScanned.HasValue;

        /// <summary>
        /// Gets and sets the property NumberOfModifiedDocumentsIndexed. 
        /// <para>
        /// The number of modified source documents in the data source that were successfully
        /// indexed.
        /// </para>
        /// </summary>
        public long? NumberOfModifiedDocumentsIndexed { get; set; }

        /// <summary>
        /// Checks to see if the NumberOfModifiedDocumentsIndexed property is set.
        /// </summary>
        internal bool IsSetNumberOfModifiedDocumentsIndexed() => this.NumberOfModifiedDocumentsIndexed.HasValue;

        /// <summary>
        /// Gets and sets the property NumberOfNewDocumentsIndexed. 
        /// <para>
        /// The number of new source documents in the data source that were successfully indexed.
        /// </para>
        /// </summary>
        public long? NumberOfNewDocumentsIndexed { get; set; }

        /// <summary>
        /// Checks to see if the NumberOfNewDocumentsIndexed property is set.
        /// </summary>
        internal bool IsSetNumberOfNewDocumentsIndexed() => this.NumberOfNewDocumentsIndexed.HasValue;
    }
}
