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
    /// &lt;p&gt;Contains summary information about a dataset export job.&lt;/p&gt;
    /// </summary>
    public partial class ExportJobSummary
    {
        private DateTime? _completedAt;
        private string _destinations3Uri;
        private string _jobId;
        private DateTime? _startedAt;
        private DatasetExportJobStatus _status;

        /// <summary>
        /// Gets and sets the property CompletedAt. &lt;p&gt;The timestamp when the job completed,
        /// or null if the job is still running.&lt;/p&gt;
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
        /// Gets and sets the property DestinationS3Uri. &lt;p&gt;The S3 URI where output clips
        /// are written.&lt;/p&gt;
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
        /// Gets and sets the property JobId. &lt;p&gt;The unique identifier for the dataset export
        /// job.&lt;/p&gt;
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
        /// Gets and sets the property StartedAt. &lt;p&gt;The timestamp when the job started
        /// processing.&lt;/p&gt;
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
        /// Gets and sets the property Status. &lt;p&gt;The current status of the dataset export
        /// job.&lt;/p&gt;
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

    }
}