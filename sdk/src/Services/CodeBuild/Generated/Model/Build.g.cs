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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the build.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property Artifacts. 
        /// <para>
        /// Information about the output artifacts for the build.
        /// </para>
        /// </summary>
        public BuildArtifacts Artifacts { get; set; }

        /// <summary>
        /// Checks to see if the Artifacts property is set.
        /// </summary>
        internal bool IsSetArtifacts() => this.Artifacts != null;

        /// <summary>
        /// Gets and sets the property AutoRetryConfig. 
        /// <para>
        /// Information about the auto-retry configuration for the build.
        /// </para>
        /// </summary>
        public AutoRetryConfig AutoRetryConfig { get; set; }

        /// <summary>
        /// Checks to see if the AutoRetryConfig property is set.
        /// </summary>
        internal bool IsSetAutoRetryConfig() => this.AutoRetryConfig != null;

        /// <summary>
        /// Gets and sets the property BuildBatchArn. 
        /// <para>
        /// The ARN of the batch build that this build is a member of, if applicable.
        /// </para>
        /// </summary>
        public string BuildBatchArn { get; set; }

        /// <summary>
        /// Checks to see if the BuildBatchArn property is set.
        /// </summary>
        internal bool IsSetBuildBatchArn() => this.BuildBatchArn != null;

        /// <summary>
        /// Gets and sets the property BuildComplete. 
        /// <para>
        /// Whether the build is complete. True if complete; otherwise, false.
        /// </para>
        /// </summary>
        public bool? BuildComplete { get; set; }

        /// <summary>
        /// Checks to see if the BuildComplete property is set.
        /// </summary>
        internal bool IsSetBuildComplete() => this.BuildComplete.HasValue;

        /// <summary>
        /// Gets and sets the property BuildNumber. 
        /// <para>
        /// The number of the build. For each project, the <c>buildNumber</c> of its first build
        /// is <c>1</c>. The <c>buildNumber</c> of each subsequent build is incremented by <c>1</c>.
        /// If a build is deleted, the <c>buildNumber</c> of other builds does not change.
        /// </para>
        /// </summary>
        public long? BuildNumber { get; set; }

        /// <summary>
        /// Checks to see if the BuildNumber property is set.
        /// </summary>
        internal bool IsSetBuildNumber() => this.BuildNumber.HasValue;

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
        public StatusType BuildStatus { get; set; }

        /// <summary>
        /// Checks to see if the BuildStatus property is set.
        /// </summary>
        internal bool IsSetBuildStatus() => this.BuildStatus != null;

        /// <summary>
        /// Gets and sets the property Cache. 
        /// <para>
        /// Information about the cache for the build.
        /// </para>
        /// </summary>
        public ProjectCache Cache { get; set; }

        /// <summary>
        /// Checks to see if the Cache property is set.
        /// </summary>
        internal bool IsSetCache() => this.Cache != null;

        /// <summary>
        /// Gets and sets the property CurrentPhase. 
        /// <para>
        /// The current build phase.
        /// </para>
        /// </summary>
        public string CurrentPhase { get; set; }

        /// <summary>
        /// Checks to see if the CurrentPhase property is set.
        /// </summary>
        internal bool IsSetCurrentPhase() => this.CurrentPhase != null;

        /// <summary>
        /// Gets and sets the property DebugSession. 
        /// <para>
        /// Contains information about the debug session for this build.
        /// </para>
        /// </summary>
        public DebugSession DebugSession { get; set; }

        /// <summary>
        /// Checks to see if the DebugSession property is set.
        /// </summary>
        internal bool IsSetDebugSession() => this.DebugSession != null;

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
        [AWSProperty(Min = 1)]
        public string EncryptionKey { get; set; }

        /// <summary>
        /// Checks to see if the EncryptionKey property is set.
        /// </summary>
        internal bool IsSetEncryptionKey() => this.EncryptionKey != null;

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// When the build process ended, expressed in Unix time format.
        /// </para>
        /// </summary>
        public DateTime? EndTime { get; set; }

        /// <summary>
        /// Checks to see if the EndTime property is set.
        /// </summary>
        internal bool IsSetEndTime() => this.EndTime.HasValue;

        /// <summary>
        /// Gets and sets the property Environment. 
        /// <para>
        /// Information about the build environment for this build.
        /// </para>
        /// </summary>
        public ProjectEnvironment Environment { get; set; }

        /// <summary>
        /// Checks to see if the Environment property is set.
        /// </summary>
        internal bool IsSetEnvironment() => this.Environment != null;

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
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ExportedEnvironmentVariable> ExportedEnvironmentVariables { get; set; } = AWSConfigs.InitializeCollections ? new List<ExportedEnvironmentVariable>() : null;

        /// <summary>
        /// Checks to see if the ExportedEnvironmentVariables property is set.
        /// </summary>
        internal bool IsSetExportedEnvironmentVariables() => this.ExportedEnvironmentVariables != null && (this.ExportedEnvironmentVariables.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property FileSystemLocations. 
        /// <para>
        ///  An array of <c>ProjectFileSystemLocation</c> objects for a CodeBuild build project.
        /// A <c>ProjectFileSystemLocation</c> object specifies the <c>identifier</c>, <c>location</c>,
        /// <c>mountOptions</c>, <c>mountPoint</c>, and <c>type</c> of a file system created using
        /// Amazon Elastic File System. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ProjectFileSystemLocation> FileSystemLocations { get; set; } = AWSConfigs.InitializeCollections ? new List<ProjectFileSystemLocation>() : null;

        /// <summary>
        /// Checks to see if the FileSystemLocations property is set.
        /// </summary>
        internal bool IsSetFileSystemLocations() => this.FileSystemLocations != null && (this.FileSystemLocations.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The unique ID for the build.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

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
        public string Initiator { get; set; }

        /// <summary>
        /// Checks to see if the Initiator property is set.
        /// </summary>
        internal bool IsSetInitiator() => this.Initiator != null;

        /// <summary>
        /// Gets and sets the property Logs. 
        /// <para>
        /// Information about the build's logs in CloudWatch Logs.
        /// </para>
        /// </summary>
        public LogsLocation Logs { get; set; }

        /// <summary>
        /// Checks to see if the Logs property is set.
        /// </summary>
        internal bool IsSetLogs() => this.Logs != null;

        /// <summary>
        /// Gets and sets the property NetworkInterface. 
        /// <para>
        /// Describes a network interface.
        /// </para>
        /// </summary>
        public NetworkInterface NetworkInterface { get; set; }

        /// <summary>
        /// Checks to see if the NetworkInterface property is set.
        /// </summary>
        internal bool IsSetNetworkInterface() => this.NetworkInterface != null;

        /// <summary>
        /// Gets and sets the property Phases. 
        /// <para>
        /// Information about all previous build phases that are complete and information about
        /// any current build phase that is not yet complete.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<BuildPhase> Phases { get; set; } = AWSConfigs.InitializeCollections ? new List<BuildPhase>() : null;

        /// <summary>
        /// Checks to see if the Phases property is set.
        /// </summary>
        internal bool IsSetPhases() => this.Phases != null && (this.Phases.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ProjectName. 
        /// <para>
        /// The name of the CodeBuild project.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public string ProjectName { get; set; }

        /// <summary>
        /// Checks to see if the ProjectName property is set.
        /// </summary>
        internal bool IsSetProjectName() => this.ProjectName != null;

        /// <summary>
        /// Gets and sets the property QueuedTimeoutInMinutes. 
        /// <para>
        ///  The number of minutes a build is allowed to be queued before it times out. 
        /// </para>
        /// </summary>
        public int? QueuedTimeoutInMinutes { get; set; }

        /// <summary>
        /// Checks to see if the QueuedTimeoutInMinutes property is set.
        /// </summary>
        internal bool IsSetQueuedTimeoutInMinutes() => this.QueuedTimeoutInMinutes.HasValue;

        /// <summary>
        /// Gets and sets the property ReportArns. 
        /// <para>
        ///  An array of the ARNs associated with this build's reports. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ReportArns { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ReportArns property is set.
        /// </summary>
        internal bool IsSetReportArns() => this.ReportArns != null && (this.ReportArns.Count > 0 || !AWSConfigs.InitializeCollections);

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
        [AWSProperty(Min = 1)]
        public string ResolvedSourceVersion { get; set; }

        /// <summary>
        /// Checks to see if the ResolvedSourceVersion property is set.
        /// </summary>
        internal bool IsSetResolvedSourceVersion() => this.ResolvedSourceVersion != null;

        /// <summary>
        /// Gets and sets the property SecondaryArtifacts. 
        /// <para>
        ///  An array of <c>ProjectArtifacts</c> objects. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 12)]
        public List<BuildArtifacts> SecondaryArtifacts { get; set; } = AWSConfigs.InitializeCollections ? new List<BuildArtifacts>() : null;

        /// <summary>
        /// Checks to see if the SecondaryArtifacts property is set.
        /// </summary>
        internal bool IsSetSecondaryArtifacts() => this.SecondaryArtifacts != null && (this.SecondaryArtifacts.Count > 0 || !AWSConfigs.InitializeCollections);

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
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 12)]
        public List<ProjectSourceVersion> SecondarySourceVersions { get; set; } = AWSConfigs.InitializeCollections ? new List<ProjectSourceVersion>() : null;

        /// <summary>
        /// Checks to see if the SecondarySourceVersions property is set.
        /// </summary>
        internal bool IsSetSecondarySourceVersions() => this.SecondarySourceVersions != null && (this.SecondarySourceVersions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SecondarySources. 
        /// <para>
        ///  An array of <c>ProjectSource</c> objects. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 12)]
        public List<ProjectSource> SecondarySources { get; set; } = AWSConfigs.InitializeCollections ? new List<ProjectSource>() : null;

        /// <summary>
        /// Checks to see if the SecondarySources property is set.
        /// </summary>
        internal bool IsSetSecondarySources() => this.SecondarySources != null && (this.SecondarySources.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ServiceRole. 
        /// <para>
        /// The name of a service role used for this build.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public string ServiceRole { get; set; }

        /// <summary>
        /// Checks to see if the ServiceRole property is set.
        /// </summary>
        internal bool IsSetServiceRole() => this.ServiceRole != null;

        /// <summary>
        /// Gets and sets the property Source. 
        /// <para>
        /// Information about the source code to be built.
        /// </para>
        /// </summary>
        public ProjectSource Source { get; set; }

        /// <summary>
        /// Checks to see if the Source property is set.
        /// </summary>
        internal bool IsSetSource() => this.Source != null;

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
        [AWSProperty(Min = 1)]
        public string SourceVersion { get; set; }

        /// <summary>
        /// Checks to see if the SourceVersion property is set.
        /// </summary>
        internal bool IsSetSourceVersion() => this.SourceVersion != null;

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// When the build process started, expressed in Unix time format.
        /// </para>
        /// </summary>
        public DateTime? StartTime { get; set; }

        /// <summary>
        /// Checks to see if the StartTime property is set.
        /// </summary>
        internal bool IsSetStartTime() => this.StartTime.HasValue;

        /// <summary>
        /// Gets and sets the property TimeoutInMinutes. 
        /// <para>
        /// How long, in minutes, from 5 to 2160 (36 hours), for CodeBuild to wait before timing
        /// out this build if it does not get marked as completed.
        /// </para>
        /// </summary>
        public int? TimeoutInMinutes { get; set; }

        /// <summary>
        /// Checks to see if the TimeoutInMinutes property is set.
        /// </summary>
        internal bool IsSetTimeoutInMinutes() => this.TimeoutInMinutes.HasValue;

        /// <summary>
        /// Gets and sets the property VpcConfig. 
        /// <para>
        /// If your CodeBuild project accesses resources in an Amazon VPC, you provide this parameter
        /// that identifies the VPC ID and the list of security group IDs and subnet IDs. The
        /// security groups and subnets must belong to the same VPC. You must provide at least
        /// one security group and one subnet ID.
        /// </para>
        /// </summary>
        public VpcConfig VpcConfig { get; set; }

        /// <summary>
        /// Checks to see if the VpcConfig property is set.
        /// </summary>
        internal bool IsSetVpcConfig() => this.VpcConfig != null;
    }
}
