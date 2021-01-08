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
 * Do not modify this file. This file is generated from the codebuild-2016-10-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CodeBuild.Model
{
    /// <summary>
    /// Contains information about a stage for a batch build.
    /// </summary>
    public partial class BuildBatchPhase
    {
        private List<PhaseContext> _contexts = new List<PhaseContext>();
        private long? _durationInSeconds;
        private DateTime? _endTime;
        private StatusType _phaseStatus;
        private BuildBatchPhaseType _phaseType;
        private DateTime? _startTime;

        /// <summary>
        /// Gets and sets the property Contexts. 
        /// <para>
        /// Additional information about the batch build phase. Especially to help troubleshoot
        /// a failed btach build.
        /// </para>
        /// </summary>
        public List<PhaseContext> Contexts
        {
            get { return this._contexts; }
            set { this._contexts = value; }
        }

        // Check to see if Contexts property is set
        internal bool IsSetContexts()
        {
            return this._contexts != null && this._contexts.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property DurationInSeconds. 
        /// <para>
        /// How long, in seconds, between the starting and ending times of the batch build's phase.
        /// </para>
        /// </summary>
        public long DurationInSeconds
        {
            get { return this._durationInSeconds.GetValueOrDefault(); }
            set { this._durationInSeconds = value; }
        }

        // Check to see if DurationInSeconds property is set
        internal bool IsSetDurationInSeconds()
        {
            return this._durationInSeconds.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// When the batch build phase ended, expressed in Unix time format.
        /// </para>
        /// </summary>
        public DateTime EndTime
        {
            get { return this._endTime.GetValueOrDefault(); }
            set { this._endTime = value; }
        }

        // Check to see if EndTime property is set
        internal bool IsSetEndTime()
        {
            return this._endTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PhaseStatus. 
        /// <para>
        /// The current status of the batch build phase. Valid values include:
        /// </para>
        ///  <dl> <dt>FAILED</dt> <dd> 
        /// <para>
        /// The build phase failed.
        /// </para>
        ///  </dd> <dt>FAULT</dt> <dd> 
        /// <para>
        /// The build phase faulted.
        /// </para>
        ///  </dd> <dt>IN_PROGRESS</dt> <dd> 
        /// <para>
        /// The build phase is still in progress.
        /// </para>
        ///  </dd> <dt>QUEUED</dt> <dd> 
        /// <para>
        /// The build has been submitted and is queued behind other submitted builds.
        /// </para>
        ///  </dd> <dt>STOPPED</dt> <dd> 
        /// <para>
        /// The build phase stopped.
        /// </para>
        ///  </dd> <dt>SUCCEEDED</dt> <dd> 
        /// <para>
        /// The build phase succeeded.
        /// </para>
        ///  </dd> <dt>TIMED_OUT</dt> <dd> 
        /// <para>
        /// The build phase timed out.
        /// </para>
        ///  </dd> </dl>
        /// </summary>
        public StatusType PhaseStatus
        {
            get { return this._phaseStatus; }
            set { this._phaseStatus = value; }
        }

        // Check to see if PhaseStatus property is set
        internal bool IsSetPhaseStatus()
        {
            return this._phaseStatus != null;
        }

        /// <summary>
        /// Gets and sets the property PhaseType. 
        /// <para>
        /// The name of the batch build phase. Valid values include:
        /// </para>
        ///  <dl> <dt>COMBINE_ARTIFACTS</dt> <dd> 
        /// <para>
        /// Build output artifacts are being combined and uploaded to the output location.
        /// </para>
        ///  </dd> <dt>DOWNLOAD_BATCHSPEC</dt> <dd> 
        /// <para>
        /// The batch build specification is being downloaded.
        /// </para>
        ///  </dd> <dt>FAILED</dt> <dd> 
        /// <para>
        /// One or more of the builds failed.
        /// </para>
        ///  </dd> <dt>IN_PROGRESS</dt> <dd> 
        /// <para>
        /// The batch build is in progress.
        /// </para>
        ///  </dd> <dt>STOPPED</dt> <dd> 
        /// <para>
        /// The batch build was stopped.
        /// </para>
        ///  </dd> <dt>SUBMITTED</dt> <dd> 
        /// <para>
        /// The btach build has been submitted.
        /// </para>
        ///  </dd> <dt>SUCCEEDED</dt> <dd> 
        /// <para>
        /// The batch build succeeded.
        /// </para>
        ///  </dd> </dl>
        /// </summary>
        public BuildBatchPhaseType PhaseType
        {
            get { return this._phaseType; }
            set { this._phaseType = value; }
        }

        // Check to see if PhaseType property is set
        internal bool IsSetPhaseType()
        {
            return this._phaseType != null;
        }

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// When the batch build phase started, expressed in Unix time format.
        /// </para>
        /// </summary>
        public DateTime StartTime
        {
            get { return this._startTime.GetValueOrDefault(); }
            set { this._startTime = value; }
        }

        // Check to see if StartTime property is set
        internal bool IsSetStartTime()
        {
            return this._startTime.HasValue; 
        }

    }
}