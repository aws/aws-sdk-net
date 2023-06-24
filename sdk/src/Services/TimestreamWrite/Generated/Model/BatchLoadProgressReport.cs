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
 * Do not modify this file. This file is generated from the timestream-write-2018-11-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.TimestreamWrite.Model
{
    /// <summary>
    /// Details about the progress of a batch load task.
    /// </summary>
    public partial class BatchLoadProgressReport
    {
        private long? _bytesMetered;
        private long? _fileFailures;
        private long? _parseFailures;
        private long? _recordIngestionFailures;
        private long? _recordsIngested;
        private long? _recordsProcessed;

        /// <summary>
        /// Gets and sets the property BytesMetered.
        /// </summary>
        public long BytesMetered
        {
            get { return this._bytesMetered.GetValueOrDefault(); }
            set { this._bytesMetered = value; }
        }

        // Check to see if BytesMetered property is set
        internal bool IsSetBytesMetered()
        {
            return this._bytesMetered.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property FileFailures.
        /// </summary>
        public long FileFailures
        {
            get { return this._fileFailures.GetValueOrDefault(); }
            set { this._fileFailures = value; }
        }

        // Check to see if FileFailures property is set
        internal bool IsSetFileFailures()
        {
            return this._fileFailures.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ParseFailures.
        /// </summary>
        public long ParseFailures
        {
            get { return this._parseFailures.GetValueOrDefault(); }
            set { this._parseFailures = value; }
        }

        // Check to see if ParseFailures property is set
        internal bool IsSetParseFailures()
        {
            return this._parseFailures.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RecordIngestionFailures.
        /// </summary>
        public long RecordIngestionFailures
        {
            get { return this._recordIngestionFailures.GetValueOrDefault(); }
            set { this._recordIngestionFailures = value; }
        }

        // Check to see if RecordIngestionFailures property is set
        internal bool IsSetRecordIngestionFailures()
        {
            return this._recordIngestionFailures.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RecordsIngested.
        /// </summary>
        public long RecordsIngested
        {
            get { return this._recordsIngested.GetValueOrDefault(); }
            set { this._recordsIngested = value; }
        }

        // Check to see if RecordsIngested property is set
        internal bool IsSetRecordsIngested()
        {
            return this._recordsIngested.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RecordsProcessed.
        /// </summary>
        public long RecordsProcessed
        {
            get { return this._recordsProcessed.GetValueOrDefault(); }
            set { this._recordsProcessed = value; }
        }

        // Check to see if RecordsProcessed property is set
        internal bool IsSetRecordsProcessed()
        {
            return this._recordsProcessed.HasValue; 
        }

    }
}