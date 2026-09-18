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

namespace Amazon.SimpleEmailV2.Model
{
    /// <summary>
    /// A summary of the import job.
    /// </summary>
    public partial class ImportJobSummary
    {
        /// <summary>
        /// Gets and sets the property CreatedTimestamp. 
        /// <para>
        /// The date and time when the import job was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the CreatedTimestamp property is set.
        /// </summary>
        internal bool IsSetCreatedTimestamp() => this.CreatedTimestamp.HasValue;

        /// <summary>
        /// Gets and sets the property FailedRecordsCount. 
        /// <para>
        /// The number of records that failed processing because of invalid input or other reasons.
        /// </para>
        /// </summary>
        public int? FailedRecordsCount { get; set; }

        /// <summary>
        /// Checks to see if the FailedRecordsCount property is set.
        /// </summary>
        internal bool IsSetFailedRecordsCount() => this.FailedRecordsCount.HasValue;

        /// <summary>
        /// Gets and sets the property ImportDestination.
        /// </summary>
        public ImportDestination ImportDestination { get; set; }

        /// <summary>
        /// Checks to see if the ImportDestination property is set.
        /// </summary>
        internal bool IsSetImportDestination() => this.ImportDestination != null;

        /// <summary>
        /// Gets and sets the property JobId.
        /// </summary>
        [AWSProperty(Min = 1)]
        public string JobId { get; set; }

        /// <summary>
        /// Checks to see if the JobId property is set.
        /// </summary>
        internal bool IsSetJobId() => this.JobId != null;

        /// <summary>
        /// Gets and sets the property JobStatus.
        /// </summary>
        public JobStatus JobStatus { get; set; }

        /// <summary>
        /// Checks to see if the JobStatus property is set.
        /// </summary>
        internal bool IsSetJobStatus() => this.JobStatus != null;

        /// <summary>
        /// Gets and sets the property ProcessedRecordsCount. 
        /// <para>
        /// The current number of records processed.
        /// </para>
        /// </summary>
        public int? ProcessedRecordsCount { get; set; }

        /// <summary>
        /// Checks to see if the ProcessedRecordsCount property is set.
        /// </summary>
        internal bool IsSetProcessedRecordsCount() => this.ProcessedRecordsCount.HasValue;
    }
}
