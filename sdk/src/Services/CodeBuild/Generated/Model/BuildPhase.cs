/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CodeBuild.Model
{
    /// <summary>
    /// Information about a stage for a build.
    /// </summary>
    public partial class BuildPhase
    {
        private List<PhaseContext> _contexts = new List<PhaseContext>();
        private long? _durationInSeconds;
        private DateTime? _endTime;
        private StatusType _phaseStatus;
        private BuildPhaseType _phaseType;
        private DateTime? _startTime;

        /// <summary>
        /// Gets and sets the property Contexts. 
        /// <para>
        /// Additional information about a build phase, especially to help troubleshoot a failed
        /// build.
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
        /// How long, in seconds, between the starting and ending times of the build's phase.
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
        /// When the build phase ended, expressed in Unix time format.
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
        /// The current status of the build phase. Valid values include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>FAILED</code>: The build phase failed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>FAULT</code>: The build phase faulted.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>IN_PROGRESS</code>: The build phase is still in progress.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>QUEUED</code>: The build has been submitted and is queued behind other submitted
        /// builds.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>STOPPED</code>: The build phase stopped.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>SUCCEEDED</code>: The build phase succeeded.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>TIMED_OUT</code>: The build phase timed out.
        /// </para>
        ///  </li> </ul>
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
        /// The name of the build phase. Valid values include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>BUILD</code>: Core build activities typically occur in this build phase.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>COMPLETED</code>: The build has been completed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>DOWNLOAD_SOURCE</code>: Source code is being downloaded in this build phase.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>FINALIZING</code>: The build process is completing in this build phase.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>INSTALL</code>: Installation activities typically occur in this build phase.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>POST_BUILD</code>: Post-build activities typically occur in this build phase.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>PRE_BUILD</code>: Pre-build activities typically occur in this build phase.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>PROVISIONING</code>: The build environment is being set up.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>QUEUED</code>: The build has been submitted and is queued behind other submitted
        /// builds.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>SUBMITTED</code>: The build has been submitted.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>UPLOAD_ARTIFACTS</code>: Build output artifacts are being uploaded to the output
        /// location.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public BuildPhaseType PhaseType
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
        /// When the build phase started, expressed in Unix time format.
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