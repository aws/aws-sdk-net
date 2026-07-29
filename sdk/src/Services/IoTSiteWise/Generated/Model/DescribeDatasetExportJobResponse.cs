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
 * Do not modify this file. This file is generated from the iotsitewise-2019-12-02.normal.json service model.
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
namespace Amazon.IoTSiteWise.Model
{
    /// <summary>
    /// Response for describe dataset export job request.
    /// </summary>
    public partial class DescribeDatasetExportJobResponse : AmazonWebServiceResponse
    {
        private DateTime? _completedAt;
        private string _destinations3Uri;
        private ExportErrorReportLocation _errorReportLocation;
        private ProcessingInput _input;
        private string _jobId;
        private DateTime? _startedAt;
        private DatasetExportJobStatus _status;
        private string _workspaceName;

        /// <summary>
        /// Gets and sets the property CompletedAt. 
        /// <para>
        /// The timestamp when the job completed, or null if the job is still running.
        /// </para>
        /// </summary>
        public DateTime? CompletedAt
        {
            get { return this._completedAt; }
            set { this._completedAt = value; }
        }

        // Check to see if CompletedAt property is set
        internal bool IsSetCompletedAt()
        {
            return this._completedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DestinationS3Uri. 
        /// <para>
        /// The S3 URI where output clips are written.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1024)]
        public string DestinationS3Uri
        {
            get { return this._destinations3Uri; }
            set { this._destinations3Uri = value; }
        }

        // Check to see if DestinationS3Uri property is set
        internal bool IsSetDestinationS3Uri()
        {
            return this._destinations3Uri != null;
        }

        /// <summary>
        /// Gets and sets the property ErrorReportLocation. 
        /// <para>
        /// The location where the error report will be written on failure.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ExportErrorReportLocation ErrorReportLocation
        {
            get { return this._errorReportLocation; }
            set { this._errorReportLocation = value; }
        }

        // Check to see if ErrorReportLocation property is set
        internal bool IsSetErrorReportLocation()
        {
            return this._errorReportLocation != null;
        }

        /// <summary>
        /// Gets and sets the property Input. 
        /// <para>
        /// The processing input that was provided in the CreateDatasetExportJob request.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ProcessingInput Input
        {
            get { return this._input; }
            set { this._input = value; }
        }

        // Check to see if Input property is set
        internal bool IsSetInput()
        {
            return this._input != null;
        }

        /// <summary>
        /// Gets and sets the property JobId. 
        /// <para>
        /// The unique identifier for the dataset export job.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=36, Max=36)]
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
        /// Gets and sets the property StartedAt. 
        /// <para>
        /// The timestamp when the job started processing.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? StartedAt
        {
            get { return this._startedAt; }
            set { this._startedAt = value; }
        }

        // Check to see if StartedAt property is set
        internal bool IsSetStartedAt()
        {
            return this._startedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the dataset export job.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DatasetExportJobStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property WorkspaceName. 
        /// <para>
        /// The name of the workspace that contains the dataset export job.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string WorkspaceName
        {
            get { return this._workspaceName; }
            set { this._workspaceName = value; }
        }

        // Check to see if WorkspaceName property is set
        internal bool IsSetWorkspaceName()
        {
            return this._workspaceName != null;
        }

    }
}