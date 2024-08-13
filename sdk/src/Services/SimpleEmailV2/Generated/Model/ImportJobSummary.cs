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
 * Do not modify this file. This file is generated from the sesv2-2019-09-27.normal.json service model.
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
namespace Amazon.SimpleEmailV2.Model
{
    /// <summary>
    /// A summary of the import job.
    /// </summary>
    public partial class ImportJobSummary
    {
        private DateTime? _createdTimestamp;
        private int? _failedRecordsCount;
        private ImportDestination _importDestination;
        private string _jobId;
        private JobStatus _jobStatus;
        private int? _processedRecordsCount;

        /// <summary>
        /// Gets and sets the property CreatedTimestamp. 
        /// <para>
        /// The date and time when the import job was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedTimestamp
        {
            get { return this._createdTimestamp; }
            set { this._createdTimestamp = value; }
        }

        // Check to see if CreatedTimestamp property is set
        internal bool IsSetCreatedTimestamp()
        {
            return this._createdTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property FailedRecordsCount. 
        /// <para>
        /// The number of records that failed processing because of invalid input or other reasons.
        /// </para>
        /// </summary>
        public int? FailedRecordsCount
        {
            get { return this._failedRecordsCount; }
            set { this._failedRecordsCount = value; }
        }

        // Check to see if FailedRecordsCount property is set
        internal bool IsSetFailedRecordsCount()
        {
            return this._failedRecordsCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ImportDestination.
        /// </summary>
        public ImportDestination ImportDestination
        {
            get { return this._importDestination; }
            set { this._importDestination = value; }
        }

        // Check to see if ImportDestination property is set
        internal bool IsSetImportDestination()
        {
            return this._importDestination != null;
        }

        /// <summary>
        /// Gets and sets the property JobId.
        /// </summary>
        [AWSProperty(Min=1)]
        public string JobId
        {
            get { return this._jobId; }
            set { this._jobId = value; }
        }

        // Check to see if JobId property is set
        internal bool IsSetJobId()
        {
            return this._jobId != null;
        }

        /// <summary>
        /// Gets and sets the property JobStatus.
        /// </summary>
        public JobStatus JobStatus
        {
            get { return this._jobStatus; }
            set { this._jobStatus = value; }
        }

        // Check to see if JobStatus property is set
        internal bool IsSetJobStatus()
        {
            return this._jobStatus != null;
        }

        /// <summary>
        /// Gets and sets the property ProcessedRecordsCount. 
        /// <para>
        /// The current number of records processed.
        /// </para>
        /// </summary>
        public int? ProcessedRecordsCount
        {
            get { return this._processedRecordsCount; }
            set { this._processedRecordsCount = value; }
        }

        // Check to see if ProcessedRecordsCount property is set
        internal bool IsSetProcessedRecordsCount()
        {
            return this._processedRecordsCount.HasValue; 
        }

    }
}