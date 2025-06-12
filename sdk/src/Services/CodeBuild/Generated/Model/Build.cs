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
    /// Information about a build.
    /// </summary>
    public partial class Build
    {
        private string _arn;
        private BuildArtifacts _artifacts;
        private AutoRetryConfig _autoRetryConfig;
        private string _buildBatchArn;
        private bool? _buildComplete;
        private long? _buildNumber;
        private StatusType _buildStatus;
        private ProjectCache _cache;
        private string _currentPhase;
        private DebugSession _debugSession;
        private string _encryptionKey;
        private DateTime? _endTime;
        private ProjectEnvironment _environment;
        private List<ExportedEnvironmentVariable> _exportedEnvironmentVariables = AWSConfigs.InitializeCollections ? new List<ExportedEnvironmentVariable>() : null;
        private List<ProjectFileSystemLocation> _fileSystemLocations = AWSConfigs.InitializeCollections ? new List<ProjectFileSystemLocation>() : null;
        private string _id;
        private string _initiator;
        private LogsLocation _logs;
        private NetworkInterface _networkInterface;
        private List<BuildPhase> _phases = AWSConfigs.InitializeCollections ? new List<BuildPhase>() : null;
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
        private int? _timeoutInMinutes;
        private VpcConfig _vpcConfig;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the build.
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
        /// Information about the output artifacts for the build.
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
        /// Gets and sets the property AutoRetryConfig. 
        /// <para>
        /// Information about the auto-retry configuration for the build.
        /// </para>
        /// </summary>
        public AutoRetryConfig AutoRetryConfig
        {
            get { return this._autoRetryConfig; }
            set { this._autoRetryConfig = value; }
        }

        // Check to see if AutoRetryConfig property is set
        internal bool IsSetAutoRetryConfig()
        {
            return this._autoRetryConfig != null;
        }

        /// <summary>
        /// Gets and sets the property BuildBatchArn. 
        /// <para>
        /// The ARN of the batch build that this build is a member of, if applicable.
        /// </para>
        /// </summary>
        public string BuildBatchArn
        {
            get { return this._buildBatchArn; }
            set { this._buildBatchArn = value; }
        }

        // Check to see if BuildBatchArn property is set
        internal bool IsSetBuildBatchArn()
        {
            return this._buildBatchArn != null;
        }

        /// <summary>
        /// Gets and sets the property BuildComplete. 
        /// <para>
        /// Whether the build is complete. True if complete; otherwise, false.
        /// </para>
        /// </summary>
        public bool? BuildComplete
        {
            get { return this._buildComplete; }
            set { this._buildComplete = value; }
        }

        // Check to see if BuildComplete property is set
        internal bool IsSetBuildComplete()
        {
            return this._buildComplete.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property BuildNumber. 
        /// <para>
        /// The number of the build. For each project, the <c>buildNumber</c> of its first build
        /// is <c>1</c>. The <c>buildNumber</c> of each subsequent build is incremented by <c>1</c>.
        /// If a build is deleted, the <c>buildNumber</c> of other builds does not change.
        /// </para>
        /// </summary>
        public long? BuildNumber
        {
            get { return this._buildNumber; }
            set { this._buildNumber = value; }
        }

        // Check to see if BuildNumber property is set
        internal bool IsSetBuildNumber()
        {
            return this._buildNumber.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property BuildStatus. 
        /// <para>
        /// The current status of the build. Valid values include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>FAILED</c>: The build failed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>FAULT</c>: The build faulted.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>IN_PROGRESS</c>: The build is still in progress.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>STOPPED</c>: The build stopped.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>SUCCEEDED</c>: The build succeeded.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>TIMED_OUT</c>: The build timed out.
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
        /// Gets and sets the property Cache. 
        /// <para>
        /// Information about the cache for the build.
        /// </para>
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
        /// Gets and sets the property CurrentPhase. 
        /// <para>
        /// The current build phase.
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
        /// Gets and sets the property DebugSession. 
        /// <para>
        /// Contains information about the debug session for this build.
        /// </para>
        /// </summary>
        public DebugSession DebugSession
        {
            get { return this._debugSession; }
            set { this._debugSession = value; }
        }

        // Check to see if DebugSession property is set
        internal bool IsSetDebugSession()
        {
            return this._debugSession != null;
        }

        /// <summary>
        /// Gets and sets the property EncryptionKey. 
        /// <para>
        /// The Key Management Service customer master key (CMK) to be used for encrypting the
        /// build output artifacts.
        /// </para>
        ///  <note> 
        /// <para>
        ///  You can use a cross-account KMS key to encrypt the build output artifacts if your
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
        /// When the build process ended, expressed in Unix time format.
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
        /// Gets and sets the property ExportedEnvironmentVariables. 
        /// <para>
        /// A list of exported environment variables for this build.
        /// </para>
        ///  
        /// <para>
        /// Exported environment variables are used in conjunction with CodePipeline to export
        /// environment variables from the current build stage to subsequent stages in the pipeline.
        /// For more information, see <a href="https://docs.aws.amazon.com/codepipeline/latest/userguide/actions-variables.html">Working
        /// with variables</a> in the <i>CodePipeline User Guide</i>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ExportedEnvironmentVariable> ExportedEnvironmentVariables
        {
            get { return this._exportedEnvironmentVariables; }
            set { this._exportedEnvironmentVariables = value; }
        }

        // Check to see if ExportedEnvironmentVariables property is set
        internal bool IsSetExportedEnvironmentVariables()
        {
            return this._exportedEnvironmentVariables != null && (this._exportedEnvironmentVariables.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property FileSystemLocations. 
        /// <para>
        ///  An array of <c>ProjectFileSystemLocation</c> objects for a CodeBuild build project.
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
        /// The unique ID for the build.
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
        /// The entity that started the build. Valid values include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If CodePipeline started the build, the pipeline's name (for example, <c>codepipeline/my-demo-pipeline</c>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If a user started the build, the user's name (for example, <c>MyUserName</c>).
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
        /// Gets and sets the property Logs. 
        /// <para>
        /// Information about the build's logs in CloudWatch Logs.
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
        /// Gets and sets the property NetworkInterface. 
        /// <para>
        /// Describes a network interface.
        /// </para>
        /// </summary>
        public NetworkInterface NetworkInterface
        {
            get { return this._networkInterface; }
            set { this._networkInterface = value; }
        }

        // Check to see if NetworkInterface property is set
        internal bool IsSetNetworkInterface()
        {
            return this._networkInterface != null;
        }

        /// <summary>
        /// Gets and sets the property Phases. 
        /// <para>
        /// Information about all previous build phases that are complete and information about
        /// any current build phase that is not yet complete.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<BuildPhase> Phases
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
        /// The name of the CodeBuild project.
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
        ///  The number of minutes a build is allowed to be queued before it times out. 
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
        ///  An array of the ARNs associated with this build's reports. 
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
        ///  An identifier for the version of this build's source code. 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  For CodeCommit, GitHub, GitHub Enterprise, and BitBucket, the commit ID. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  For CodePipeline, the source revision provided by CodePipeline. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  For Amazon S3, this does not apply. 
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
        ///  An array of <c>ProjectArtifacts</c> objects. 
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
        ///  An array of <c>ProjectSource</c> objects. 
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
        ///  An array of <c>ProjectSourceVersion</c> objects. Each <c>ProjectSourceVersion</c>
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
        /// The name of a service role used for this build.
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
        /// Any version identifier for the version of the source code to be built. If <c>sourceVersion</c>
        /// is specified at the project level, then this <c>sourceVersion</c> (at the build level)
        /// takes precedence. 
        /// </para>
        ///  
        /// <para>
        ///  For more information, see <a href="https://docs.aws.amazon.com/codebuild/latest/userguide/sample-source-version.html">Source
        /// Version Sample with CodeBuild</a> in the <i>CodeBuild User Guide</i>. 
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
        /// When the build process started, expressed in Unix time format.
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
        /// Gets and sets the property TimeoutInMinutes. 
        /// <para>
        /// How long, in minutes, from 5 to 2160 (36 hours), for CodeBuild to wait before timing
        /// out this build if it does not get marked as completed.
        /// </para>
        /// </summary>
        public int? TimeoutInMinutes
        {
            get { return this._timeoutInMinutes; }
            set { this._timeoutInMinutes = value; }
        }

        // Check to see if TimeoutInMinutes property is set
        internal bool IsSetTimeoutInMinutes()
        {
            return this._timeoutInMinutes.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property VpcConfig. 
        /// <para>
        /// If your CodeBuild project accesses resources in an Amazon VPC, you provide this parameter
        /// that identifies the VPC ID and the list of security group IDs and subnet IDs. The
        /// security groups and subnets must belong to the same VPC. You must provide at least
        /// one security group and one subnet ID.
        /// </para>
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