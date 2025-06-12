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
    /// Contains information about a batch build.
    /// </summary>
    public partial class BuildBatch
    {
        private string _arn;
        private BuildArtifacts _artifacts;
        private ProjectBuildBatchConfig _buildBatchConfig;
        private long? _buildBatchNumber;
        private StatusType _buildBatchStatus;
        private List<BuildGroup> _buildGroups = AWSConfigs.InitializeCollections ? new List<BuildGroup>() : null;
        private int? _buildTimeoutInMinutes;
        private ProjectCache _cache;
        private bool? _complete;
        private string _currentPhase;
        private bool? _debugSessionEnabled;
        private string _encryptionKey;
        private DateTime? _endTime;
        private ProjectEnvironment _environment;
        private List<ProjectFileSystemLocation> _fileSystemLocations = AWSConfigs.InitializeCollections ? new List<ProjectFileSystemLocation>() : null;
        private string _id;
        private string _initiator;
        private LogsConfig _logConfig;
        private List<BuildBatchPhase> _phases = AWSConfigs.InitializeCollections ? new List<BuildBatchPhase>() : null;
        private string _projectName;
        private int? _queuedTimeoutInMinutes;
        private List<string> _reportArns = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _resolvedSourceVersion;
        private List<BuildArtifacts> _secondaryArtifacts = AWSConfigs.InitializeCollections ? new List<BuildArtifacts>() : null;
        private List<ProjectSource> _secondarySources = AWSConfigs.InitializeCollections ? new List<ProjectSource>() : null;
        private List<ProjectSourceVersion> _secondarySourceVersions = AWSConfigs.InitializeCollections ? new List<ProjectSourceVersion>() : null;
        private string _serviceRole;
        private ProjectSource _source;
        private string _sourceVersion;
        private DateTime? _startTime;
        private VpcConfig _vpcConfig;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The ARN of the batch build.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
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
        /// A <c>BuildArtifacts</c> object the defines the build artifacts for this batch build.
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
        /// Gets and sets the property BuildBatchConfig.
        /// </summary>
        public ProjectBuildBatchConfig BuildBatchConfig
        {
            get { return this._buildBatchConfig; }
            set { this._buildBatchConfig = value; }
        }

        // Check to see if BuildBatchConfig property is set
        internal bool IsSetBuildBatchConfig()
        {
            return this._buildBatchConfig != null;
        }

        /// <summary>
        /// Gets and sets the property BuildBatchNumber. 
        /// <para>
        /// The number of the batch build. For each project, the <c>buildBatchNumber</c> of its
        /// first batch build is <c>1</c>. The <c>buildBatchNumber</c> of each subsequent batch
        /// build is incremented by <c>1</c>. If a batch build is deleted, the <c>buildBatchNumber</c>
        /// of other batch builds does not change.
        /// </para>
        /// </summary>
        public long? BuildBatchNumber
        {
            get { return this._buildBatchNumber; }
            set { this._buildBatchNumber = value; }
        }

        // Check to see if BuildBatchNumber property is set
        internal bool IsSetBuildBatchNumber()
        {
            return this._buildBatchNumber.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property BuildBatchStatus. 
        /// <para>
        /// The status of the batch build.
        /// </para>
        /// </summary>
        public StatusType BuildBatchStatus
        {
            get { return this._buildBatchStatus; }
            set { this._buildBatchStatus = value; }
        }

        // Check to see if BuildBatchStatus property is set
        internal bool IsSetBuildBatchStatus()
        {
            return this._buildBatchStatus != null;
        }

        /// <summary>
        /// Gets and sets the property BuildGroups. 
        /// <para>
        /// An array of <c>BuildGroup</c> objects that define the build groups for the batch build.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<BuildGroup> BuildGroups
        {
            get { return this._buildGroups; }
            set { this._buildGroups = value; }
        }

        // Check to see if BuildGroups property is set
        internal bool IsSetBuildGroups()
        {
            return this._buildGroups != null && (this._buildGroups.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property BuildTimeoutInMinutes. 
        /// <para>
        /// Specifies the maximum amount of time, in minutes, that the build in a batch must be
        /// completed in.
        /// </para>
        /// </summary>
        public int? BuildTimeoutInMinutes
        {
            get { return this._buildTimeoutInMinutes; }
            set { this._buildTimeoutInMinutes = value; }
        }

        // Check to see if BuildTimeoutInMinutes property is set
        internal bool IsSetBuildTimeoutInMinutes()
        {
            return this._buildTimeoutInMinutes.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Cache.
        /// </summary>
        public ProjectCache Cache
        {
            get { return this._cache; }
            set { this._cache = value; }
        }

        // Check to see if Cache property is set
        internal bool IsSetCache()
        {
            return this._cache != null;
        }

        /// <summary>
        /// Gets and sets the property Complete. 
        /// <para>
        /// Indicates if the batch build is complete.
        /// </para>
        /// </summary>
        public bool? Complete
        {
            get { return this._complete; }
            set { this._complete = value; }
        }

        // Check to see if Complete property is set
        internal bool IsSetComplete()
        {
            return this._complete.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CurrentPhase. 
        /// <para>
        /// The current phase of the batch build.
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
        /// Gets and sets the property DebugSessionEnabled. 
        /// <para>
        /// Specifies if session debugging is enabled for this batch build. For more information,
        /// see <a href="https://docs.aws.amazon.com/codebuild/latest/userguide/session-manager.html">Viewing
        /// a running build in Session Manager</a>. Batch session debugging is not supported for
        /// matrix batch builds.
        /// </para>
        /// </summary>
        public bool? DebugSessionEnabled
        {
            get { return this._debugSessionEnabled; }
            set { this._debugSessionEnabled = value; }
        }

        // Check to see if DebugSessionEnabled property is set
        internal bool IsSetDebugSessionEnabled()
        {
            return this._debugSessionEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EncryptionKey. 
        /// <para>
        /// The Key Management Service customer master key (CMK) to be used for encrypting the
        /// batch build output artifacts.
        /// </para>
        ///  <note> 
        /// <para>
        /// You can use a cross-account KMS key to encrypt the build output artifacts if your
        /// service role has permission to that key. 
        /// </para>
        ///  </note> 
        /// <para>
        /// You can specify either the Amazon Resource Name (ARN) of the CMK or, if available,
        /// the CMK's alias (using the format <c>alias/&lt;alias-name&gt;</c>).
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public string EncryptionKey
        {
            get { return this._encryptionKey; }
            set { this._encryptionKey = value; }
        }

        // Check to see if EncryptionKey property is set
        internal bool IsSetEncryptionKey()
        {
            return this._encryptionKey != null;
        }

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// The date and time that the batch build ended.
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
        /// Gets and sets the property Environment.
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
        /// Gets and sets the property FileSystemLocations. 
        /// <para>
        /// An array of <c>ProjectFileSystemLocation</c> objects for the batch build project.
        /// A <c>ProjectFileSystemLocation</c> object specifies the <c>identifier</c>, <c>location</c>,
        /// <c>mountOptions</c>, <c>mountPoint</c>, and <c>type</c> of a file system created using
        /// Amazon Elastic File System. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ProjectFileSystemLocation> FileSystemLocations
        {
            get { return this._fileSystemLocations; }
            set { this._fileSystemLocations = value; }
        }

        // Check to see if FileSystemLocations property is set
        internal bool IsSetFileSystemLocations()
        {
            return this._fileSystemLocations != null && (this._fileSystemLocations.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The identifier of the batch build.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
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
        /// The entity that started the batch build. Valid values include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If CodePipeline started the build, the pipeline's name (for example, <c>codepipeline/my-demo-pipeline</c>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If a user started the build, the user's name.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If the Jenkins plugin for CodeBuild started the build, the string <c>CodeBuild-Jenkins-Plugin</c>.
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
        /// Gets and sets the property LogConfig.
        /// </summary>
        public LogsConfig LogConfig
        {
            get { return this._logConfig; }
            set { this._logConfig = value; }
        }

        // Check to see if LogConfig property is set
        internal bool IsSetLogConfig()
        {
            return this._logConfig != null;
        }

        /// <summary>
        /// Gets and sets the property Phases. 
        /// <para>
        /// An array of <c>BuildBatchPhase</c> objects the specify the phases of the batch build.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<BuildBatchPhase> Phases
        {
            get { return this._phases; }
            set { this._phases = value; }
        }

        // Check to see if Phases property is set
        internal bool IsSetPhases()
        {
            return this._phases != null && (this._phases.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ProjectName. 
        /// <para>
        /// The name of the batch build project.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
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
        /// Gets and sets the property QueuedTimeoutInMinutes. 
        /// <para>
        /// Specifies the amount of time, in minutes, that the batch build is allowed to be queued
        /// before it times out.
        /// </para>
        /// </summary>
        public int? QueuedTimeoutInMinutes
        {
            get { return this._queuedTimeoutInMinutes; }
            set { this._queuedTimeoutInMinutes = value; }
        }

        // Check to see if QueuedTimeoutInMinutes property is set
        internal bool IsSetQueuedTimeoutInMinutes()
        {
            return this._queuedTimeoutInMinutes.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ReportArns. 
        /// <para>
        /// An array that contains the ARNs of reports created by merging reports from builds
        /// associated with this batch build.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ReportArns
        {
            get { return this._reportArns; }
            set { this._reportArns = value; }
        }

        // Check to see if ReportArns property is set
        internal bool IsSetReportArns()
        {
            return this._reportArns != null && (this._reportArns.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ResolvedSourceVersion. 
        /// <para>
        /// The identifier of the resolved version of this batch build's source code.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// For CodeCommit, GitHub, GitHub Enterprise, and BitBucket, the commit ID.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For CodePipeline, the source revision provided by CodePipeline.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For Amazon S3, this does not apply.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Min=1)]
        public string ResolvedSourceVersion
        {
            get { return this._resolvedSourceVersion; }
            set { this._resolvedSourceVersion = value; }
        }

        // Check to see if ResolvedSourceVersion property is set
        internal bool IsSetResolvedSourceVersion()
        {
            return this._resolvedSourceVersion != null;
        }

        /// <summary>
        /// Gets and sets the property SecondaryArtifacts. 
        /// <para>
        /// An array of <c>BuildArtifacts</c> objects the define the build artifacts for this
        /// batch build.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=12)]
        public List<BuildArtifacts> SecondaryArtifacts
        {
            get { return this._secondaryArtifacts; }
            set { this._secondaryArtifacts = value; }
        }

        // Check to see if SecondaryArtifacts property is set
        internal bool IsSetSecondaryArtifacts()
        {
            return this._secondaryArtifacts != null && (this._secondaryArtifacts.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SecondarySources. 
        /// <para>
        /// An array of <c>ProjectSource</c> objects that define the sources for the batch build.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=12)]
        public List<ProjectSource> SecondarySources
        {
            get { return this._secondarySources; }
            set { this._secondarySources = value; }
        }

        // Check to see if SecondarySources property is set
        internal bool IsSetSecondarySources()
        {
            return this._secondarySources != null && (this._secondarySources.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SecondarySourceVersions. 
        /// <para>
        /// An array of <c>ProjectSourceVersion</c> objects. Each <c>ProjectSourceVersion</c>
        /// must be one of: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// For CodeCommit: the commit ID, branch, or Git tag to use.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For GitHub: the commit ID, pull request ID, branch name, or tag name that corresponds
        /// to the version of the source code you want to build. If a pull request ID is specified,
        /// it must use the format <c>pr/pull-request-ID</c> (for example, <c>pr/25</c>). If a
        /// branch name is specified, the branch's HEAD commit ID is used. If not specified, the
        /// default branch's HEAD commit ID is used.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For Bitbucket: the commit ID, branch name, or tag name that corresponds to the version
        /// of the source code you want to build. If a branch name is specified, the branch's
        /// HEAD commit ID is used. If not specified, the default branch's HEAD commit ID is used.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For Amazon S3: the version ID of the object that represents the build input ZIP file
        /// to use.
        /// </para>
        ///  </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=12)]
        public List<ProjectSourceVersion> SecondarySourceVersions
        {
            get { return this._secondarySourceVersions; }
            set { this._secondarySourceVersions = value; }
        }

        // Check to see if SecondarySourceVersions property is set
        internal bool IsSetSecondarySourceVersions()
        {
            return this._secondarySourceVersions != null && (this._secondarySourceVersions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ServiceRole. 
        /// <para>
        /// The name of a service role used for builds in the batch.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public string ServiceRole
        {
            get { return this._serviceRole; }
            set { this._serviceRole = value; }
        }

        // Check to see if ServiceRole property is set
        internal bool IsSetServiceRole()
        {
            return this._serviceRole != null;
        }

        /// <summary>
        /// Gets and sets the property Source.
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
        /// The identifier of the version of the source code to be built.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
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
        /// The date and time that the batch build started.
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

        /// <summary>
        /// Gets and sets the property VpcConfig.
        /// </summary>
        public VpcConfig VpcConfig
        {
            get { return this._vpcConfig; }
            set { this._vpcConfig = value; }
        }

        // Check to see if VpcConfig property is set
        internal bool IsSetVpcConfig()
        {
            return this._vpcConfig != null;
        }

    }
}