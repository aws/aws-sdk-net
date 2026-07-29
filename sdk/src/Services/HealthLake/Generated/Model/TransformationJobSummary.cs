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
 * Do not modify this file. This file is generated from the healthlake-2017-07-01.normal.json service model.
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
namespace Amazon.HealthLake.Model
{
    /// <summary>
    /// Contains summary information about a data transformation job. To retrieve full job
    /// details, call <c>DescribeDataTransformationJob</c>.
    /// </summary>
    public partial class TransformationJobSummary
    {
        private DateTime? _endTime;
        private string _jobId;
        private string _jobName;
        private TransformationJobStatus _jobStatus;
        private SourceFormat _sourceFormat;
        private DateTime? _submitTime;

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// The timestamp when the job completed.
        /// </para>
        /// </summary>
        public DateTime? EndTime
        {
            get { return this._endTime; }
            set { this._endTime = value; }
        }

        // Check to see if EndTime property is set
        internal bool IsSetEndTime()
        {
            return this._endTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property JobId. 
        /// <para>
        /// The unique identifier of the job.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=32)]
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
        /// Gets and sets the property JobName. 
        /// <para>
        /// The name of the job.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string JobName
        {
            get { return this._jobName; }
            set { this._jobName = value; }
        }

        // Check to see if JobName property is set
        internal bool IsSetJobName()
        {
            return this._jobName != null;
        }

        /// <summary>
        /// Gets and sets the property JobStatus. 
        /// <para>
        /// The current status of the job.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public TransformationJobStatus JobStatus
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
        /// Gets and sets the property SourceFormat. 
        /// <para>
        /// The source data format for this job.
        /// </para>
        /// </summary>
        public SourceFormat SourceFormat
        {
            get { return this._sourceFormat; }
            set { this._sourceFormat = value; }
        }

        // Check to see if SourceFormat property is set
        internal bool IsSetSourceFormat()
        {
            return this._sourceFormat != null;
        }

        /// <summary>
        /// Gets and sets the property SubmitTime. 
        /// <para>
        /// The timestamp when the job was submitted.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? SubmitTime
        {
            get { return this._submitTime; }
            set { this._submitTime = value; }
        }

        // Check to see if SubmitTime property is set
        internal bool IsSetSubmitTime()
        {
            return this._submitTime.HasValue; 
        }

    }
}