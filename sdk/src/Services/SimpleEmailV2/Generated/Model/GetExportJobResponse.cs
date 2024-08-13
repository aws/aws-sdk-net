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
    /// An HTTP 200 response if the request succeeds, or an error message if the request fails.
    /// </summary>
    public partial class GetExportJobResponse : AmazonWebServiceResponse
    {
        private DateTime? _completedTimestamp;
        private DateTime? _createdTimestamp;
        private ExportDataSource _exportDataSource;
        private ExportDestination _exportDestination;
        private ExportSourceType _exportSourceType;
        private FailureInfo _failureInfo;
        private string _jobId;
        private JobStatus _jobStatus;
        private ExportStatistics _statistics;

        /// <summary>
        /// Gets and sets the property CompletedTimestamp. 
        /// <para>
        /// The timestamp of when the export job was completed.
        /// </para>
        /// </summary>
        public DateTime? CompletedTimestamp
        {
            get { return this._completedTimestamp; }
            set { this._completedTimestamp = value; }
        }

        // Check to see if CompletedTimestamp property is set
        internal bool IsSetCompletedTimestamp()
        {
            return this._completedTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CreatedTimestamp. 
        /// <para>
        /// The timestamp of when the export job was created.
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
        /// Gets and sets the property ExportDataSource. 
        /// <para>
        /// The data source of the export job.
        /// </para>
        /// </summary>
        public ExportDataSource ExportDataSource
        {
            get { return this._exportDataSource; }
            set { this._exportDataSource = value; }
        }

        // Check to see if ExportDataSource property is set
        internal bool IsSetExportDataSource()
        {
            return this._exportDataSource != null;
        }

        /// <summary>
        /// Gets and sets the property ExportDestination. 
        /// <para>
        /// The destination of the export job.
        /// </para>
        /// </summary>
        public ExportDestination ExportDestination
        {
            get { return this._exportDestination; }
            set { this._exportDestination = value; }
        }

        // Check to see if ExportDestination property is set
        internal bool IsSetExportDestination()
        {
            return this._exportDestination != null;
        }

        /// <summary>
        /// Gets and sets the property ExportSourceType. 
        /// <para>
        /// The type of source of the export job.
        /// </para>
        /// </summary>
        public ExportSourceType ExportSourceType
        {
            get { return this._exportSourceType; }
            set { this._exportSourceType = value; }
        }

        // Check to see if ExportSourceType property is set
        internal bool IsSetExportSourceType()
        {
            return this._exportSourceType != null;
        }

        /// <summary>
        /// Gets and sets the property FailureInfo. 
        /// <para>
        /// The failure details about an export job.
        /// </para>
        /// </summary>
        public FailureInfo FailureInfo
        {
            get { return this._failureInfo; }
            set { this._failureInfo = value; }
        }

        // Check to see if FailureInfo property is set
        internal bool IsSetFailureInfo()
        {
            return this._failureInfo != null;
        }

        /// <summary>
        /// Gets and sets the property JobId. 
        /// <para>
        /// The export job ID.
        /// </para>
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
        /// <para>
        /// The status of the export job.
        /// </para>
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
        /// Gets and sets the property Statistics. 
        /// <para>
        /// The statistics about the export job.
        /// </para>
        /// </summary>
        public ExportStatistics Statistics
        {
            get { return this._statistics; }
            set { this._statistics = value; }
        }

        // Check to see if Statistics property is set
        internal bool IsSetStatistics()
        {
            return this._statistics != null;
        }

    }
}