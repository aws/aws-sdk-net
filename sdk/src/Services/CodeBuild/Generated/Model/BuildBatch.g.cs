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
    /// Contains information about a batch build.
    /// </summary>
    public partial class BuildBatch
    {
        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The ARN of the batch build.
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
        /// A <c>BuildArtifacts</c> object the defines the build artifacts for this batch build.
        /// </para>
        /// </summary>
        public BuildArtifacts Artifacts { get; set; }

        /// <summary>
        /// Checks to see if the Artifacts property is set.
        /// </summary>
        internal bool IsSetArtifacts() => this.Artifacts != null;

        /// <summary>
        /// Gets and sets the property BuildBatchConfig.
        /// </summary>
        public ProjectBuildBatchConfig BuildBatchConfig { get; set; }

        /// <summary>
        /// Checks to see if the BuildBatchConfig property is set.
        /// </summary>
        internal bool IsSetBuildBatchConfig() => this.BuildBatchConfig != null;

        /// <summary>
        /// Gets and sets the property BuildBatchNumber. 
        /// <para>
        /// The number of the batch build. For each project, the <c>buildBatchNumber</c> of its
        /// first batch build is <c>1</c>. The <c>buildBatchNumber</c> of each subsequent batch
        /// build is incremented by <c>1</c>. If a batch build is deleted, the <c>buildBatchNumber</c>
        /// of other batch builds does not change.
        /// </para>
        /// </summary>
        public long? BuildBatchNumber { get; set; }

        /// <summary>
        /// Checks to see if the BuildBatchNumber property is set.
        /// </summary>
        internal bool IsSetBuildBatchNumber() => this.BuildBatchNumber.HasValue;

        /// <summary>
        /// Gets and sets the property BuildBatchStatus. 
        /// <para>
        /// The status of the batch build.
        /// </para>
        /// </summary>
        public StatusType BuildBatchStatus { get; set; }

        /// <summary>
        /// Checks to see if the BuildBatchStatus property is set.
        /// </summary>
        internal bool IsSetBuildBatchStatus() => this.BuildBatchStatus != null;

        /// <summary>
        /// Gets and sets the property BuildGroups. 
        /// <para>
        /// An array of <c>BuildGroup</c> objects that define the build groups for the batch build.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<BuildGroup> BuildGroups { get; set; } = AWSConfigs.InitializeCollections ? new List<BuildGroup>() : null;

        /// <summary>
        /// Checks to see if the BuildGroups property is set.
        /// </summary>
        internal bool IsSetBuildGroups() => this.BuildGroups != null && (this.BuildGroups.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property BuildTimeoutInMinutes. 
        /// <para>
        /// Specifies the maximum amount of time, in minutes, that the build in a batch must be
        /// completed in.
        /// </para>
        /// </summary>
        public int? BuildTimeoutInMinutes { get; set; }

        /// <summary>
        /// Checks to see if the BuildTimeoutInMinutes property is set.
        /// </summary>
        internal bool IsSetBuildTimeoutInMinutes() => this.BuildTimeoutInMinutes.HasValue;

        /// <summary>
        /// Gets and sets the property Cache.
        /// </summary>
        public ProjectCache Cache { get; set; }

        /// <summary>
        /// Checks to see if the Cache property is set.
        /// </summary>
        internal bool IsSetCache() => this.Cache != null;

        /// <summary>
        /// Gets and sets the property Complete. 
        /// <para>
        /// Indicates if the batch build is complete.
        /// </para>
        /// </summary>
        public bool? Complete { get; set; }

        /// <summary>
        /// Checks to see if the Complete property is set.
        /// </summary>
        internal bool IsSetComplete() => this.Complete.HasValue;

        /// <summary>
        /// Gets and sets the property CurrentPhase. 
        /// <para>
        /// The current phase of the batch build.
        /// </para>
        /// </summary>
        public string CurrentPhase { get; set; }

        /// <summary>
        /// Checks to see if the CurrentPhase property is set.
        /// </summary>
        internal bool IsSetCurrentPhase() => this.CurrentPhase != null;

        /// <summary>
        /// Gets and sets the property DebugSessionEnabled. 
        /// <para>
        /// Specifies if session debugging is enabled for this batch build. For more information,
        /// see <a href="https://docs.aws.amazon.com/codebuild/latest/userguide/session-manager.html">Viewing
        /// a running build in Session Manager</a>. Batch session debugging is not supported for
        /// matrix batch builds.
        /// </para>
        /// </summary>
        public bool? DebugSessionEnabled { get; set; }

        /// <summary>
        /// Checks to see if the DebugSessionEnabled property is set.
        /// </summary>
        internal bool IsSetDebugSessionEnabled() => this.DebugSessionEnabled.HasValue;

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
        [AWSProperty(Min = 1)]
        public string EncryptionKey { get; set; }

        /// <summary>
        /// Checks to see if the EncryptionKey property is set.
        /// </summary>
        internal bool IsSetEncryptionKey() => this.EncryptionKey != null;

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// The date and time that the batch build ended.
        /// </para>
        /// </summary>
        public DateTime? EndTime { get; set; }

        /// <summary>
        /// Checks to see if the EndTime property is set.
        /// </summary>
        internal bool IsSetEndTime() => this.EndTime.HasValue;

        /// <summary>
        /// Gets and sets the property Environment.
        /// </summary>
        public ProjectEnvironment Environment { get; set; }

        /// <summary>
        /// Checks to see if the Environment property is set.
        /// </summary>
        internal bool IsSetEnvironment() => this.Environment != null;

        /// <summary>
        /// Gets and sets the property FileSystemLocations. 
        /// <para>
        /// An array of <c>ProjectFileSystemLocation</c> objects for the batch build project.
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
        /// The identifier of the batch build.
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
        public string Initiator { get; set; }

        /// <summary>
        /// Checks to see if the Initiator property is set.
        /// </summary>
        internal bool IsSetInitiator() => this.Initiator != null;

        /// <summary>
        /// Gets and sets the property LogConfig.
        /// </summary>
        public LogsConfig LogConfig { get; set; }

        /// <summary>
        /// Checks to see if the LogConfig property is set.
        /// </summary>
        internal bool IsSetLogConfig() => this.LogConfig != null;

        /// <summary>
        /// Gets and sets the property Phases. 
        /// <para>
        /// An array of <c>BuildBatchPhase</c> objects the specify the phases of the batch build.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<BuildBatchPhase> Phases { get; set; } = AWSConfigs.InitializeCollections ? new List<BuildBatchPhase>() : null;

        /// <summary>
        /// Checks to see if the Phases property is set.
        /// </summary>
        internal bool IsSetPhases() => this.Phases != null && (this.Phases.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ProjectName. 
        /// <para>
        /// The name of the batch build project.
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
        /// Specifies the amount of time, in minutes, that the batch build is allowed to be queued
        /// before it times out.
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
        /// An array that contains the ARNs of reports created by merging reports from builds
        /// associated with this batch build.
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
        [AWSProperty(Min = 1)]
        public string ResolvedSourceVersion { get; set; }

        /// <summary>
        /// Checks to see if the ResolvedSourceVersion property is set.
        /// </summary>
        internal bool IsSetResolvedSourceVersion() => this.ResolvedSourceVersion != null;

        /// <summary>
        /// Gets and sets the property SecondaryArtifacts. 
        /// <para>
        /// An array of <c>BuildArtifacts</c> objects the define the build artifacts for this
        /// batch build.
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
        /// An array of <c>ProjectSource</c> objects that define the sources for the batch build.
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
        /// The name of a service role used for builds in the batch.
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
        /// </summary>
        public ProjectSource Source { get; set; }

        /// <summary>
        /// Checks to see if the Source property is set.
        /// </summary>
        internal bool IsSetSource() => this.Source != null;

        /// <summary>
        /// Gets and sets the property SourceVersion. 
        /// <para>
        /// The identifier of the version of the source code to be built.
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
        /// The date and time that the batch build started.
        /// </para>
        /// </summary>
        public DateTime? StartTime { get; set; }

        /// <summary>
        /// Checks to see if the StartTime property is set.
        /// </summary>
        internal bool IsSetStartTime() => this.StartTime.HasValue;

        /// <summary>
        /// Gets and sets the property VpcConfig.
        /// </summary>
        public VpcConfig VpcConfig { get; set; }

        /// <summary>
        /// Checks to see if the VpcConfig property is set.
        /// </summary>
        internal bool IsSetVpcConfig() => this.VpcConfig != null;
    }
}
