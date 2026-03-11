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
 * Do not modify this file. This file is generated from the s3tables-2018-05-10.normal.json service model.
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
namespace Amazon.S3Tables.Model
{
    /// <summary>
    /// Provides metrics for the record expiration job that most recently ran for a table.
    /// The metrics provide insight into the amount of data that was removed when the job
    /// ran.
    /// </summary>
    public partial class TableRecordExpirationJobMetrics
    {
        private long? _deletedDataFiles;
        private long? _deletedRecords;
        private long? _removedFilesSize;

        /// <summary>
        /// Gets and sets the property DeletedDataFiles. 
        /// <para>
        /// The total number of data files that were removed when the job ran.
        /// </para>
        /// </summary>
        public long? DeletedDataFiles
        {
            get { return this._deletedDataFiles; }
            set { this._deletedDataFiles = value; }
        }

        // Check to see if DeletedDataFiles property is set
        internal bool IsSetDeletedDataFiles()
        {
            return this._deletedDataFiles.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DeletedRecords. 
        /// <para>
        /// The total number of records that were removed when the job ran.
        /// </para>
        /// </summary>
        public long? DeletedRecords
        {
            get { return this._deletedRecords; }
            set { this._deletedRecords = value; }
        }

        // Check to see if DeletedRecords property is set
        internal bool IsSetDeletedRecords()
        {
            return this._deletedRecords.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RemovedFilesSize. 
        /// <para>
        /// The total size (in bytes) of the data files that were removed when the job ran.
        /// </para>
        /// </summary>
        public long? RemovedFilesSize
        {
            get { return this._removedFilesSize; }
            set { this._removedFilesSize = value; }
        }

        // Check to see if RemovedFilesSize property is set
        internal bool IsSetRemovedFilesSize()
        {
            return this._removedFilesSize.HasValue; 
        }

    }
}