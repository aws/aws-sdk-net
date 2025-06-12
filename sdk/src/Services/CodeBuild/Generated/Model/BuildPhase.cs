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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.CodeBuild.Model
{
    /// <summary>
    /// Information about a stage for a build.
    /// </summary>
    public partial class BuildPhase
    {
        private List<PhaseContext> _contexts = AWSConfigs.InitializeCollections ? new List<PhaseContext>() : null;
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
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<PhaseContext> Contexts
        {
            get { return this._contexts; }
            set { this._contexts = value; }
        }

        // Check to see if Contexts property is set
        internal bool IsSetContexts()
        {
            return this._contexts != null && (this._contexts.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property DurationInSeconds. 
        /// <para>
        /// How long, in seconds, between the starting and ending times of the build's phase.
        /// </para>
        /// </summary>
        public long? DurationInSeconds
        {
            get { return this._durationInSeconds; }
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
        /// Gets and sets the property PhaseStatus. 
        /// <para>
        /// The current status of the build phase. Valid values include:
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
        /// The name of the build phase. Valid values include:
        /// </para>
        ///  <dl> <dt>BUILD</dt> <dd> 
        /// <para>
        /// Core build activities typically occur in this build phase.
        /// </para>
        ///  </dd> <dt>COMPLETED</dt> <dd> 
        /// <para>
        /// The build has been completed.
        /// </para>
        ///  </dd> <dt>DOWNLOAD_SOURCE</dt> <dd> 
        /// <para>
        /// Source code is being downloaded in this build phase.
        /// </para>
        ///  </dd> <dt>FINALIZING</dt> <dd> 
        /// <para>
        /// The build process is completing in this build phase.
        /// </para>
        ///  </dd> <dt>INSTALL</dt> <dd> 
        /// <para>
        /// Installation activities typically occur in this build phase.
        /// </para>
        ///  </dd> <dt>POST_BUILD</dt> <dd> 
        /// <para>
        /// Post-build activities typically occur in this build phase.
        /// </para>
        ///  </dd> <dt>PRE_BUILD</dt> <dd> 
        /// <para>
        /// Pre-build activities typically occur in this build phase.
        /// </para>
        ///  </dd> <dt>PROVISIONING</dt> <dd> 
        /// <para>
        /// The build environment is being set up.
        /// </para>
        ///  </dd> <dt>QUEUED</dt> <dd> 
        /// <para>
        /// The build has been submitted and is queued behind other submitted builds.
        /// </para>
        ///  </dd> <dt>SUBMITTED</dt> <dd> 
        /// <para>
        /// The build has been submitted.
        /// </para>
        ///  </dd> <dt>UPLOAD_ARTIFACTS</dt> <dd> 
        /// <para>
        /// Build output artifacts are being uploaded to the output location.
        /// </para>
        ///  </dd> </dl>
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
        public DateTime? StartTime
        {
            get { return this._startTime; }
            set { this._startTime = value; }
        }

        // Check to see if StartTime property is set
        internal bool IsSetStartTime()
        {
            return this._startTime.HasValue; 
        }

    }
}