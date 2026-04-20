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
 * Do not modify this file. This file is generated from the location-2020-11-19.normal.json service model.
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
namespace Amazon.LocationService.Model
{
    /// <summary>
    /// Job summary information returned in list operations.
    /// </summary>
    public partial class ListJobsResponseEntry
    {
        private JobAction _action;
        private JobActionOptions _actionOptions;
        private DateTime? _createdAt;
        private DateTime? _endedAt;
        private JobError _error;
        private string _executionRoleArn;
        private JobInputOptions _inputOptions;
        private string _jobArn;
        private string _jobId;
        private string _name;
        private JobOutputOptions _outputOptions;
        private JobStatus _status;
        private DateTime? _updatedAt;

        /// <summary>
        /// Gets and sets the property Action. 
        /// <para>
        /// Action performed by the job.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public JobAction Action
        {
            get { return this._action; }
            set { this._action = value; }
        }

        // Check to see if Action property is set
        internal bool IsSetAction()
        {
            return this._action != null;
        }

        /// <summary>
        /// Gets and sets the property ActionOptions. 
        /// <para>
        /// Additional options for configuring job action parameters.
        /// </para>
        /// </summary>
        public JobActionOptions ActionOptions
        {
            get { return this._actionOptions; }
            set { this._actionOptions = value; }
        }

        // Check to see if ActionOptions property is set
        internal bool IsSetActionOptions()
        {
            return this._actionOptions != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// Job creation time in <a href="https://www.iso.org/iso-8601-date-and-time-format.html">ISO
        /// 8601</a> format: <c>YYYY-MM-DDThh:mm:ss.sss</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true)]
        public DateTime? CreatedAt
        {
            get { return this._createdAt; }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EndedAt. 
        /// <para>
        /// Job completion time in <a href="https://www.iso.org/iso-8601-date-and-time-format.html">ISO
        /// 8601</a> format: <c>YYYY-MM-DDThh:mm:ss.sss</c>. Only returned for jobs in a terminal
        /// status: <c>Completed</c> | <c>Failed</c> | <c>Cancelled</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public DateTime? EndedAt
        {
            get { return this._endedAt; }
            set { this._endedAt = value; }
        }

        // Check to see if EndedAt property is set
        internal bool IsSetEndedAt()
        {
            return this._endedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Error. 
        /// <para>
        /// Error information if the job failed.
        /// </para>
        /// </summary>
        public JobError Error
        {
            get { return this._error; }
            set { this._error = value; }
        }

        // Check to see if Error property is set
        internal bool IsSetError()
        {
            return this._error != null;
        }

        /// <summary>
        /// Gets and sets the property ExecutionRoleArn. 
        /// <para>
        /// IAM role used for job execution.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ExecutionRoleArn
        {
            get { return this._executionRoleArn; }
            set { this._executionRoleArn = value; }
        }

        // Check to see if ExecutionRoleArn property is set
        internal bool IsSetExecutionRoleArn()
        {
            return this._executionRoleArn != null;
        }

        /// <summary>
        /// Gets and sets the property InputOptions. 
        /// <para>
        /// Input configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public JobInputOptions InputOptions
        {
            get { return this._inputOptions; }
            set { this._inputOptions = value; }
        }

        // Check to see if InputOptions property is set
        internal bool IsSetInputOptions()
        {
            return this._inputOptions != null;
        }

        /// <summary>
        /// Gets and sets the property JobArn. 
        /// <para>
        /// Amazon Resource Name (ARN) of the job.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=1600)]
        public string JobArn
        {
            get { return this._jobArn; }
            set { this._jobArn = value; }
        }

        // Check to see if JobArn property is set
        internal bool IsSetJobArn()
        {
            return this._jobArn != null;
        }

        /// <summary>
        /// Gets and sets the property JobId. 
        /// <para>
        /// Unique job identifier.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=200)]
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
        /// Gets and sets the property Name. 
        /// <para>
        /// Job name (if provided during creation).
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property OutputOptions. 
        /// <para>
        /// Output configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public JobOutputOptions OutputOptions
        {
            get { return this._outputOptions; }
            set { this._outputOptions = value; }
        }

        // Check to see if OutputOptions property is set
        internal bool IsSetOutputOptions()
        {
            return this._outputOptions != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Current job status.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public JobStatus Status
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
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// Last update time in <a href="https://www.iso.org/iso-8601-date-and-time-format.html">ISO
        /// 8601</a> format: <c>YYYY-MM-DDThh:mm:ss.sss</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true)]
        public DateTime? UpdatedAt
        {
            get { return this._updatedAt; }
            set { this._updatedAt = value; }
        }

        // Check to see if UpdatedAt property is set
        internal bool IsSetUpdatedAt()
        {
            return this._updatedAt.HasValue; 
        }

    }
}