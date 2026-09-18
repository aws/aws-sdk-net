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
    /// This is the response object from the GetExportJob operation.
    /// </summary>
    public partial class GetExportJobResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property CompletedTimestamp. 
        /// <para>
        /// The timestamp of when the export job was completed.
        /// </para>
        /// </summary>
        public DateTime? CompletedTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the CompletedTimestamp property is set.
        /// </summary>
        internal bool IsSetCompletedTimestamp() => this.CompletedTimestamp.HasValue;

        /// <summary>
        /// Gets and sets the property CreatedTimestamp. 
        /// <para>
        /// The timestamp of when the export job was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the CreatedTimestamp property is set.
        /// </summary>
        internal bool IsSetCreatedTimestamp() => this.CreatedTimestamp.HasValue;

        /// <summary>
        /// Gets and sets the property ExportDataSource. 
        /// <para>
        /// The data source of the export job.
        /// </para>
        /// </summary>
        public ExportDataSource ExportDataSource { get; set; }

        /// <summary>
        /// Checks to see if the ExportDataSource property is set.
        /// </summary>
        internal bool IsSetExportDataSource() => this.ExportDataSource != null;

        /// <summary>
        /// Gets and sets the property ExportDestination. 
        /// <para>
        /// The destination of the export job.
        /// </para>
        /// </summary>
        public ExportDestination ExportDestination { get; set; }

        /// <summary>
        /// Checks to see if the ExportDestination property is set.
        /// </summary>
        internal bool IsSetExportDestination() => this.ExportDestination != null;

        /// <summary>
        /// Gets and sets the property ExportSourceType. 
        /// <para>
        /// The type of source of the export job.
        /// </para>
        /// </summary>
        public ExportSourceType ExportSourceType { get; set; }

        /// <summary>
        /// Checks to see if the ExportSourceType property is set.
        /// </summary>
        internal bool IsSetExportSourceType() => this.ExportSourceType != null;

        /// <summary>
        /// Gets and sets the property FailureInfo. 
        /// <para>
        /// The failure details about an export job.
        /// </para>
        /// </summary>
        public FailureInfo FailureInfo { get; set; }

        /// <summary>
        /// Checks to see if the FailureInfo property is set.
        /// </summary>
        internal bool IsSetFailureInfo() => this.FailureInfo != null;

        /// <summary>
        /// Gets and sets the property JobId. 
        /// <para>
        /// The export job ID.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public string JobId { get; set; }

        /// <summary>
        /// Checks to see if the JobId property is set.
        /// </summary>
        internal bool IsSetJobId() => this.JobId != null;

        /// <summary>
        /// Gets and sets the property JobStatus. 
        /// <para>
        /// The status of the export job.
        /// </para>
        /// </summary>
        public JobStatus JobStatus { get; set; }

        /// <summary>
        /// Checks to see if the JobStatus property is set.
        /// </summary>
        internal bool IsSetJobStatus() => this.JobStatus != null;

        /// <summary>
        /// Gets and sets the property Statistics. 
        /// <para>
        /// The statistics about the export job.
        /// </para>
        /// </summary>
        public ExportStatistics Statistics { get; set; }

        /// <summary>
        /// Checks to see if the Statistics property is set.
        /// </summary>
        internal bool IsSetStatistics() => this.Statistics != null;
    }
}
