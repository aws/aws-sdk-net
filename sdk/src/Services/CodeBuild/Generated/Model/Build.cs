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
    /// Information about a build.
    /// </summary>
    public partial class Build
    {
        private string _arn;
        private BuildArtifacts _artifacts;
        private bool? _buildComplete;
        private StatusType _buildStatus;
        private string _currentPhase;
        private DateTime? _endTime;
        private ProjectEnvironment _environment;
        private string _id;
        private string _initiator;
        private LogsLocation _logs;
        private List<BuildPhase> _phases = new List<BuildPhase>();
        private string _projectName;
        private ProjectSource _source;
        private string _sourceVersion;
        private DateTime? _startTime;
        private int? _timeoutInMinutes;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The build's Amazon Resource Name (ARN).
        /// </para>
        /// </summary>
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property Artifacts. 
        /// <para>
        /// Information about the build's output artifacts.
        /// </para>
        /// </summary>
        public BuildArtifacts Artifacts
        {
            get { return this._artifacts; }
            set { this._artifacts = value; }
        }

        // Check to see if Artifacts property is set
        internal bool IsSetArtifacts()
        {
            return this._artifacts != null;
        }

        /// <summary>
        /// Gets and sets the property BuildComplete. 
        /// <para>
        /// Whether the build has finished. Valid values include true if completed; otherwise,
        /// false.
        /// </para>
        /// </summary>
        public bool BuildComplete
        {
            get { return this._buildComplete.GetValueOrDefault(); }
            set { this._buildComplete = value; }
        }

        // Check to see if BuildComplete property is set
        internal bool IsSetBuildComplete()
        {
            return this._buildComplete.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property BuildStatus. 
        /// <para>
        /// The build's current status. Valid values include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>FAILED</code>: The build failed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>FAULT</code>: The build faulted.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>IN_PROGRESS</code>: The build is still in progress.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>STOPPED</code>: The build stopped.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>SUCCEEDED</code>: The build succeeded.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>TIMED_OUT</code>: The build timed out.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public StatusType BuildStatus
        {
            get { return this._buildStatus; }
            set { this._buildStatus = value; }
        }

        // Check to see if BuildStatus property is set
        internal bool IsSetBuildStatus()
        {
            return this._buildStatus != null;
        }

        /// <summary>
        /// Gets and sets the property CurrentPhase. 
        /// <para>
        /// The build's current build phase.
        /// </para>
        /// </summary>
        public string CurrentPhase
        {
            get { return this._currentPhase; }
            set { this._currentPhase = value; }
        }

        // Check to see if CurrentPhase property is set
        internal bool IsSetCurrentPhase()
        {
            return this._currentPhase != null;
        }

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// When the build process ended, expressed in Unix time format.
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
        /// Gets and sets the property Environment. 
        /// <para>
        /// Information about the build environment for this build.
        /// </para>
        /// </summary>
        public ProjectEnvironment Environment
        {
            get { return this._environment; }
            set { this._environment = value; }
        }

        // Check to see if Environment property is set
        internal bool IsSetEnvironment()
        {
            return this._environment != null;
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The build's unique ID.
        /// </para>
        /// </summary>
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property Initiator. 
        /// <para>
        /// The entity that started the build. Valid values include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If AWS CodePipeline started the build, the pipeline's name, for example <code>codepipeline/my-demo-pipeline</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If an AWS Identity and Access Management (IAM) user started the build, the user's
        /// name, for example <code>MyUserName</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If the Jenkins plugin for AWS CodeBuild started the build, the string <code>CodeBuild-Jenkins-Plugin</code>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string Initiator
        {
            get { return this._initiator; }
            set { this._initiator = value; }
        }

        // Check to see if Initiator property is set
        internal bool IsSetInitiator()
        {
            return this._initiator != null;
        }

        /// <summary>
        /// Gets and sets the property Logs. 
        /// <para>
        /// Information about the build's logs in Amazon CloudWatch Logs.
        /// </para>
        /// </summary>
        public LogsLocation Logs
        {
            get { return this._logs; }
            set { this._logs = value; }
        }

        // Check to see if Logs property is set
        internal bool IsSetLogs()
        {
            return this._logs != null;
        }

        /// <summary>
        /// Gets and sets the property Phases. 
        /// <para>
        /// Information about all previous build phases that have completed, and information about
        /// any current build phase that has not yet completed.
        /// </para>
        /// </summary>
        public List<BuildPhase> Phases
        {
            get { return this._phases; }
            set { this._phases = value; }
        }

        // Check to see if Phases property is set
        internal bool IsSetPhases()
        {
            return this._phases != null && this._phases.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ProjectName. 
        /// <para>
        /// The build project's name.
        /// </para>
        /// </summary>
        public string ProjectName
        {
            get { return this._projectName; }
            set { this._projectName = value; }
        }

        // Check to see if ProjectName property is set
        internal bool IsSetProjectName()
        {
            return this._projectName != null;
        }

        /// <summary>
        /// Gets and sets the property Source. 
        /// <para>
        /// Information about the source code to be built.
        /// </para>
        /// </summary>
        public ProjectSource Source
        {
            get { return this._source; }
            set { this._source = value; }
        }

        // Check to see if Source property is set
        internal bool IsSetSource()
        {
            return this._source != null;
        }

        /// <summary>
        /// Gets and sets the property SourceVersion. 
        /// <para>
        /// Any version identifier for the version of the source code to be built.
        /// </para>
        /// </summary>
        public string SourceVersion
        {
            get { return this._sourceVersion; }
            set { this._sourceVersion = value; }
        }

        // Check to see if SourceVersion property is set
        internal bool IsSetSourceVersion()
        {
            return this._sourceVersion != null;
        }

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// When the build process started, expressed in Unix time format.
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

        /// <summary>
        /// Gets and sets the property TimeoutInMinutes. 
        /// <para>
        /// How long in minutes for AWS CodeBuild to wait to timeout this build if it does not
        /// get marked as completed.
        /// </para>
        /// </summary>
        public int TimeoutInMinutes
        {
            get { return this._timeoutInMinutes.GetValueOrDefault(); }
            set { this._timeoutInMinutes = value; }
        }

        // Check to see if TimeoutInMinutes property is set
        internal bool IsSetTimeoutInMinutes()
        {
            return this._timeoutInMinutes.HasValue; 
        }

    }
}