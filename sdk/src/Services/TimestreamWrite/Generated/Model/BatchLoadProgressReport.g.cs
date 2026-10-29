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

namespace Amazon.TimestreamWrite.Model
{
    /// <summary>
    /// Details about the progress of a batch load task.
    /// </summary>
    public partial class BatchLoadProgressReport
    {
        /// <summary>
        /// Gets and sets the property BytesMetered. 
        /// <para>
        /// 
        /// </para>
        /// </summary>
        public long? BytesMetered { get; set; }

        /// <summary>
        /// Checks to see if the BytesMetered property is set.
        /// </summary>
        internal bool IsSetBytesMetered() => this.BytesMetered.HasValue;

        /// <summary>
        /// Gets and sets the property FileFailures. 
        /// <para>
        /// 
        /// </para>
        /// </summary>
        public long? FileFailures { get; set; }

        /// <summary>
        /// Checks to see if the FileFailures property is set.
        /// </summary>
        internal bool IsSetFileFailures() => this.FileFailures.HasValue;

        /// <summary>
        /// Gets and sets the property ParseFailures. 
        /// <para>
        /// 
        /// </para>
        /// </summary>
        public long? ParseFailures { get; set; }

        /// <summary>
        /// Checks to see if the ParseFailures property is set.
        /// </summary>
        internal bool IsSetParseFailures() => this.ParseFailures.HasValue;

        /// <summary>
        /// Gets and sets the property RecordIngestionFailures. 
        /// <para>
        /// 
        /// </para>
        /// </summary>
        public long? RecordIngestionFailures { get; set; }

        /// <summary>
        /// Checks to see if the RecordIngestionFailures property is set.
        /// </summary>
        internal bool IsSetRecordIngestionFailures() => this.RecordIngestionFailures.HasValue;

        /// <summary>
        /// Gets and sets the property RecordsIngested. 
        /// <para>
        /// 
        /// </para>
        /// </summary>
        public long? RecordsIngested { get; set; }

        /// <summary>
        /// Checks to see if the RecordsIngested property is set.
        /// </summary>
        internal bool IsSetRecordsIngested() => this.RecordsIngested.HasValue;

        /// <summary>
        /// Gets and sets the property RecordsProcessed. 
        /// <para>
        /// 
        /// </para>
        /// </summary>
        public long? RecordsProcessed { get; set; }

        /// <summary>
        /// Checks to see if the RecordsProcessed property is set.
        /// </summary>
        internal bool IsSetRecordsProcessed() => this.RecordsProcessed.HasValue;
    }
}
