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
    /// Information about a build project.
    /// </summary>
    public partial class Project
    {
        private string _arn;
        private ProjectArtifacts _artifacts;
        private int? _autoRetryLimit;
        private ProjectBadge _badge;
        private ProjectBuildBatchConfig _buildBatchConfig;
        private ProjectCache _cache;
        private int? _concurrentBuildLimit;
        private DateTime? _created;
        private string _description;
        private string _encryptionKey;
        private ProjectEnvironment _environment;
        private List<ProjectFileSystemLocation> _fileSystemLocations = AWSConfigs.InitializeCollections ? new List<ProjectFileSystemLocation>() : null;
        private DateTime? _lastModified;
        private LogsConfig _logsConfig;
        private string _name;
        private ProjectVisibilityType _projectVisibility;
        private string _publicProjectAlias;
        private int? _queuedTimeoutInMinutes;
        private string _resourceAccessRole;
        private List<ProjectArtifacts> _secondaryArtifacts = AWSConfigs.InitializeCollections ? new List<ProjectArtifacts>() : null;
        private List<ProjectSource> _secondarySources = AWSConfigs.InitializeCollections ? new List<ProjectSource>() : null;
        private List<ProjectSourceVersion> _secondarySourceVersions = AWSConfigs.InitializeCollections ? new List<ProjectSourceVersion>() : null;
        private string _serviceRole;
        private ProjectSource _source;
        private string _sourceVersion;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;
        private int? _timeoutInMinutes;
        private VpcConfig _vpcConfig;
        private Webhook _webhook;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the build project.
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
        /// Information about the build output artifacts for the build project.
        /// </para>
        /// </summary>
        public ProjectArtifacts Artifacts
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
        /// Gets and sets the property AutoRetryLimit. 
        /// <para>
        /// The maximum number of additional automatic retries after a failed build. For example,
        /// if the auto-retry limit is set to 2, CodeBuild will call the <c>RetryBuild</c> API
        /// to automatically retry your build for up to 2 additional times.
        /// </para>
        /// </summary>
        public int? AutoRetryLimit
        {
            get { return this._autoRetryLimit; }
            set { this._autoRetryLimit = value; }
        }

        // Check to see if AutoRetryLimit property is set
        internal bool IsSetAutoRetryLimit()
        {
            return this._autoRetryLimit.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Badge. 
        /// <para>
        /// Information about the build badge for the build project.
        /// </para>
        /// </summary>
        public ProjectBadge Badge
        {
            get { return this._badge; }
            set { this._badge = value; }
        }

        // Check to see if Badge property is set
        internal bool IsSetBadge()
        {
            return this._badge != null;
        }

        /// <summary>
        /// Gets and sets the property BuildBatchConfig. 
        /// <para>
        /// A <a>ProjectBuildBatchConfig</a> object that defines the batch build options for the
        /// project.
        /// </para>
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
        /// Gets and sets the property Cache. 
        /// <para>
        /// Information about the cache for the build project.
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
        /// Gets and sets the property ConcurrentBuildLimit. 
        /// <para>
        /// The maximum number of concurrent builds that are allowed for this project.
        /// </para>
        ///  
        /// <para>
        /// New builds are only started if the current number of builds is less than or equal
        /// to this limit. If the current build count meets this limit, new builds are throttled
        /// and are not run.
        /// </para>
        /// </summary>
        public int? ConcurrentBuildLimit
        {
            get { return this._concurrentBuildLimit; }
            set { this._concurrentBuildLimit = value; }
        }

        // Check to see if ConcurrentBuildLimit property is set
        internal bool IsSetConcurrentBuildLimit()
        {
            return this._concurrentBuildLimit.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Created. 
        /// <para>
        /// When the build project was created, expressed in Unix time format.
        /// </para>
        /// </summary>
        public DateTime? Created
        {
            get { return this._created; }
            set { this._created = value; }
        }

        // Check to see if Created property is set
        internal bool IsSetCreated()
        {
            return this._created.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description that makes the build project easy to identify.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=255)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property EncryptionKey. 
        /// <para>
        /// The Key Management Service customer master key (CMK) to be used for encrypting the
        /// build output artifacts.
        /// </para>
        ///  <note> 
        /// <para>
        /// You can use a cross-account KMS key to encrypt the build output artifacts if your
        /// service role has permission to that key. 
        /// </para>
        ///  </note> 
        /// <para>
        /// You can specify either the Amazon Resource Name (ARN) of the CMK or, if available,
        /// the CMK's alias (using the format <c>alias/&lt;alias-name&gt;</c>). If you don't specify
        /// a value, CodeBuild uses the managed CMK for Amazon Simple Storage Service (Amazon
        /// S3). 
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
        /// Gets and sets the property Environment. 
        /// <para>
        /// Information about the build environment for this build project.
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
        /// Gets and sets the property LastModified. 
        /// <para>
        /// When the build project's settings were last modified, expressed in Unix time format.
        /// </para>
        /// </summary>
        public DateTime? LastModified
        {
            get { return this._lastModified; }
            set { this._lastModified = value; }
        }

        // Check to see if LastModified property is set
        internal bool IsSetLastModified()
        {
            return this._lastModified.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LogsConfig. 
        /// <para>
        /// Information about logs for the build project. A project can create logs in CloudWatch
        /// Logs, an S3 bucket, or both. 
        /// </para>
        /// </summary>
        public LogsConfig LogsConfig
        {
            get { return this._logsConfig; }
            set { this._logsConfig = value; }
        }

        // Check to see if LogsConfig property is set
        internal bool IsSetLogsConfig()
        {
            return this._logsConfig != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the build project.
        /// </para>
        /// </summary>
        [AWSProperty(Min=2, Max=150)]
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
        /// Gets and sets the property ProjectVisibility.
        /// </summary>
        public ProjectVisibilityType ProjectVisibility
        {
            get { return this._projectVisibility; }
            set { this._projectVisibility = value; }
        }

        // Check to see if ProjectVisibility property is set
        internal bool IsSetProjectVisibility()
        {
            return this._projectVisibility != null;
        }

        /// <summary>
        /// Gets and sets the property PublicProjectAlias. 
        /// <para>
        /// Contains the project identifier used with the public build APIs. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public string PublicProjectAlias
        {
            get { return this._publicProjectAlias; }
            set { this._publicProjectAlias = value; }
        }

        // Check to see if PublicProjectAlias property is set
        internal bool IsSetPublicProjectAlias()
        {
            return this._publicProjectAlias != null;
        }

        /// <summary>
        /// Gets and sets the property QueuedTimeoutInMinutes. 
        /// <para>
        /// The number of minutes a build is allowed to be queued before it times out. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=5, Max=480)]
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
        /// Gets and sets the property ResourceAccessRole. 
        /// <para>
        /// The ARN of the IAM role that enables CodeBuild to access the CloudWatch Logs and Amazon
        /// S3 artifacts for the project's builds.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public string ResourceAccessRole
        {
            get { return this._resourceAccessRole; }
            set { this._resourceAccessRole = value; }
        }

        // Check to see if ResourceAccessRole property is set
        internal bool IsSetResourceAccessRole()
        {
            return this._resourceAccessRole != null;
        }

        /// <summary>
        /// Gets and sets the property SecondaryArtifacts. 
        /// <para>
        /// An array of <c>ProjectArtifacts</c> objects. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=12)]
        public List<ProjectArtifacts> SecondaryArtifacts
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
        /// An array of <c>ProjectSource</c> objects. 
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
        /// An array of <c>ProjectSourceVersion</c> objects. If <c>secondarySourceVersions</c>
        /// is specified at the build level, then they take over these <c>secondarySourceVersions</c>
        /// (at the project level). 
        /// </para>
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
        /// The ARN of the IAM role that enables CodeBuild to interact with dependent Amazon Web
        /// Services services on behalf of the Amazon Web Services account.
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
        /// Information about the build input source code for this build project.
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
        /// A version of the build input to be built for this project. If not specified, the latest
        /// version is used. If specified, it must be one of:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// For CodeCommit: the commit ID, branch, or Git tag to use.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For GitHub: the commit ID, pull request ID, branch name, or tag name that corresponds
        /// to the version of the source code you want to build. If a pull request ID is specified,
        /// it must use the format <c>pr/pull-request-ID</c> (for example <c>pr/25</c>). If a
        /// branch name is specified, the branch's HEAD commit ID is used. If not specified, the
        /// default branch's HEAD commit ID is used.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For GitLab: the commit ID, branch, or Git tag to use.
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
        /// <para>
        /// If <c>sourceVersion</c> is specified at the build level, then that version takes precedence
        /// over this <c>sourceVersion</c> (at the project level). 
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/codebuild/latest/userguide/sample-source-version.html">Source
        /// Version Sample with CodeBuild</a> in the <i>CodeBuild User Guide</i>. 
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
        /// Gets and sets the property Tags. 
        /// <para>
        /// A list of tag key and value pairs associated with this build project.
        /// </para>
        ///  
        /// <para>
        /// These tags are available for use by Amazon Web Services services that support CodeBuild
        /// build project tags.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TimeoutInMinutes. 
        /// <para>
        /// How long, in minutes, from 5 to 2160 (36 hours), for CodeBuild to wait before timing
        /// out any related build that did not get marked as completed. The default is 60 minutes.
        /// </para>
        /// </summary>
        [AWSProperty(Min=5, Max=2160)]
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
        /// Information about the VPC configuration that CodeBuild accesses.
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

        /// <summary>
        /// Gets and sets the property Webhook. 
        /// <para>
        /// Information about a webhook that connects repository events to a build project in
        /// CodeBuild.
        /// </para>
        /// </summary>
        public Webhook Webhook
        {
            get { return this._webhook; }
            set { this._webhook = value; }
        }

        // Check to see if Webhook property is set
        internal bool IsSetWebhook()
        {
            return this._webhook != null;
        }

    }
}