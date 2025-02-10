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
 * Do not modify this file. This file is generated from the bedrock-agent-2023-06-05.normal.json service model.
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
        private long? _numberOfDocumentsDeleted;
        private long? _numberOfDocumentsFailed;
        private long? _numberOfDocumentsScanned;
        private long? _numberOfMetadataDocumentsModified;
        private long? _numberOfMetadataDocumentsScanned;
        private long? _numberOfModifiedDocumentsIndexed;
        private long? _numberOfNewDocumentsIndexed;

        /// <summary>
        /// Gets and sets the property NumberOfDocumentsDeleted. 
        /// <para>
        /// The number of source documents that were deleted.
        /// </para>
        /// </summary>
        public long? NumberOfDocumentsDeleted
        {
            get { return this._numberOfDocumentsDeleted; }
            set { this._numberOfDocumentsDeleted = value; }
        }

        // Check to see if NumberOfDocumentsDeleted property is set
        internal bool IsSetNumberOfDocumentsDeleted()
        {
            return this._numberOfDocumentsDeleted.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NumberOfDocumentsFailed. 
        /// <para>
        /// The number of source documents that failed to be ingested.
        /// </para>
        /// </summary>
        public long? NumberOfDocumentsFailed
        {
            get { return this._numberOfDocumentsFailed; }
            set { this._numberOfDocumentsFailed = value; }
        }

        // Check to see if NumberOfDocumentsFailed property is set
        internal bool IsSetNumberOfDocumentsFailed()
        {
            return this._numberOfDocumentsFailed.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NumberOfDocumentsScanned. 
        /// <para>
        /// The total number of source documents that were scanned. Includes new, updated, and
        /// unchanged documents.
        /// </para>
        /// </summary>
        public long? NumberOfDocumentsScanned
        {
            get { return this._numberOfDocumentsScanned; }
            set { this._numberOfDocumentsScanned = value; }
        }

        // Check to see if NumberOfDocumentsScanned property is set
        internal bool IsSetNumberOfDocumentsScanned()
        {
            return this._numberOfDocumentsScanned.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NumberOfMetadataDocumentsModified. 
        /// <para>
        /// The number of metadata files that were updated or deleted.
        /// </para>
        /// </summary>
        public long? NumberOfMetadataDocumentsModified
        {
            get { return this._numberOfMetadataDocumentsModified; }
            set { this._numberOfMetadataDocumentsModified = value; }
        }

        // Check to see if NumberOfMetadataDocumentsModified property is set
        internal bool IsSetNumberOfMetadataDocumentsModified()
        {
            return this._numberOfMetadataDocumentsModified.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NumberOfMetadataDocumentsScanned. 
        /// <para>
        /// The total number of metadata files that were scanned. Includes new, updated, and unchanged
        /// files.
        /// </para>
        /// </summary>
        public long? NumberOfMetadataDocumentsScanned
        {
            get { return this._numberOfMetadataDocumentsScanned; }
            set { this._numberOfMetadataDocumentsScanned = value; }
        }

        // Check to see if NumberOfMetadataDocumentsScanned property is set
        internal bool IsSetNumberOfMetadataDocumentsScanned()
        {
            return this._numberOfMetadataDocumentsScanned.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NumberOfModifiedDocumentsIndexed. 
        /// <para>
        /// The number of modified source documents in the data source that were successfully
        /// indexed.
        /// </para>
        /// </summary>
        public long? NumberOfModifiedDocumentsIndexed
        {
            get { return this._numberOfModifiedDocumentsIndexed; }
            set { this._numberOfModifiedDocumentsIndexed = value; }
        }

        // Check to see if NumberOfModifiedDocumentsIndexed property is set
        internal bool IsSetNumberOfModifiedDocumentsIndexed()
        {
            return this._numberOfModifiedDocumentsIndexed.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NumberOfNewDocumentsIndexed. 
        /// <para>
        /// The number of new source documents in the data source that were successfully indexed.
        /// </para>
        /// </summary>
        public long? NumberOfNewDocumentsIndexed
        {
            get { return this._numberOfNewDocumentsIndexed; }
            set { this._numberOfNewDocumentsIndexed = value; }
        }

        // Check to see if NumberOfNewDocumentsIndexed property is set
        internal bool IsSetNumberOfNewDocumentsIndexed()
        {
            return this._numberOfNewDocumentsIndexed.HasValue; 
        }

    }
}