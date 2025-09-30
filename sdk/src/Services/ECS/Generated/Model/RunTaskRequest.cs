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
 * Do not modify this file. This file is generated from the ecs-2014-11-13.normal.json service model.
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
namespace Amazon.ECS.Model
{
    /// <summary>
    /// Container for the parameters to the RunTask operation.
    /// Starts a new task using the specified task definition.
    /// 
    ///  <note> 
    /// <para>
    /// On March 21, 2024, a change was made to resolve the task definition revision before
    /// authorization. When a task definition revision is not specified, authorization will
    /// occur using the latest revision of a task definition.
    /// </para>
    ///  </note> <note> 
    /// <para>
    /// Amazon Elastic Inference (EI) is no longer available to customers.
    /// </para>
    ///  </note> 
    /// <para>
    /// You can allow Amazon ECS to place tasks for you, or you can customize how Amazon ECS
    /// places tasks using placement constraints and placement strategies. For more information,
    /// see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/scheduling_tasks.html">Scheduling
    /// Tasks</a> in the <i>Amazon Elastic Container Service Developer Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// Alternatively, you can use <c>StartTask</c> to use your own scheduler or place tasks
    /// manually on specific container instances.
    /// </para>
    ///  
    /// <para>
    /// You can attach Amazon EBS volumes to Amazon ECS tasks by configuring the volume when
    /// creating or updating a service. For more information, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/ebs-volumes.html#ebs-volume-types">Amazon
    /// EBS volumes</a> in the <i>Amazon Elastic Container Service Developer Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// The Amazon ECS API follows an eventual consistency model. This is because of the distributed
    /// nature of the system supporting the API. This means that the result of an API command
    /// you run that affects your Amazon ECS resources might not be immediately visible to
    /// all subsequent commands you run. Keep this in mind when you carry out an API command
    /// that immediately follows a previous API command.
    /// </para>
    ///  
    /// <para>
    /// To manage eventual consistency, you can do the following:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Confirm the state of the resource before you run a command to modify it. Run the DescribeTasks
    /// command using an exponential backoff algorithm to ensure that you allow enough time
    /// for the previous command to propagate through the system. To do this, run the DescribeTasks
    /// command repeatedly, starting with a couple of seconds of wait time and increasing
    /// gradually up to five minutes of wait time.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Add wait time between subsequent commands, even if the DescribeTasks command returns
    /// an accurate response. Apply an exponential backoff algorithm starting with a couple
    /// of seconds of wait time, and increase gradually up to about five minutes of wait time.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// If you get a <c>ConflictException</c> error, the <c>RunTask</c> request could not
    /// be processed due to conflicts. The provided <c>clientToken</c> is already in use with
    /// a different <c>RunTask</c> request. The <c>resourceIds</c> are the existing task ARNs
    /// which are already associated with the <c>clientToken</c>. 
    /// </para>
    ///  
    /// <para>
    /// To fix this issue:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Run <c>RunTask</c> with a unique <c>clientToken</c>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Run <c>RunTask</c> with the <c>clientToken</c> and the original set of parameters
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// If you get a <c>ClientException</c>error, the <c>RunTask</c> could not be processed
    /// because you use managed scaling and there is a capacity error because the quota of
    /// tasks in the <c>PROVISIONING</c> per cluster has been reached. For information about
    /// the service quotas, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/service-quotas.html">Amazon
    /// ECS service quotas</a>.
    /// </para>
    /// </summary>
    public partial class RunTaskRequest : AmazonECSRequest
    {
        private List<CapacityProviderStrategyItem> _capacityProviderStrategy = AWSConfigs.InitializeCollections ? new List<CapacityProviderStrategyItem>() : null;
        private string _clientToken;
        private string _cluster;
        private int? _count;
        private bool? _enableecsManagedTags;
        private bool? _enableExecuteCommand;
        private string _group;
        private LaunchType _launchType;
        private NetworkConfiguration _networkConfiguration;
        private TaskOverride _overrides;
        private List<PlacementConstraint> _placementConstraints = AWSConfigs.InitializeCollections ? new List<PlacementConstraint>() : null;
        private List<PlacementStrategy> _placementStrategy = AWSConfigs.InitializeCollections ? new List<PlacementStrategy>() : null;
        private string _platformVersion;
        private PropagateTags _propagateTags;
        private string _referenceId;
        private string _startedBy;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;
        private string _taskDefinition;
        private List<TaskVolumeConfiguration> _volumeConfigurations = AWSConfigs.InitializeCollections ? new List<TaskVolumeConfiguration>() : null;

        /// <summary>
        /// Gets and sets the property CapacityProviderStrategy. 
        /// <para>
        /// The capacity provider strategy to use for the task.
        /// </para>
        ///  
        /// <para>
        /// If a <c>capacityProviderStrategy</c> is specified, the <c>launchType</c> parameter
        /// must be omitted. If no <c>capacityProviderStrategy</c> or <c>launchType</c> is specified,
        /// the <c>defaultCapacityProviderStrategy</c> for the cluster is used.
        /// </para>
        ///  
        /// <para>
        /// When you use cluster auto scaling, you must specify <c>capacityProviderStrategy</c>
        /// and not <c>launchType</c>. 
        /// </para>
        ///  
        /// <para>
        /// A capacity provider strategy can contain a maximum of 20 capacity providers.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<CapacityProviderStrategyItem> CapacityProviderStrategy
        {
            get { return this._capacityProviderStrategy; }
            set { this._capacityProviderStrategy = value; }
        }

        // Check to see if CapacityProviderStrategy property is set
        internal bool IsSetCapacityProviderStrategy()
        {
            return this._capacityProviderStrategy != null && (this._capacityProviderStrategy.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// An identifier that you provide to ensure the idempotency of the request. It must be
        /// unique and is case sensitive. Up to 64 characters are allowed. The valid characters
        /// are characters in the range of 33-126, inclusive. For more information, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/APIReference/ECS_Idempotency.html">Ensuring
        /// idempotency</a>.
        /// </para>
        /// </summary>
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property Cluster. 
        /// <para>
        /// The short name or full Amazon Resource Name (ARN) of the cluster to run your task
        /// on. If you do not specify a cluster, the default cluster is assumed.
        /// </para>
        ///  
        /// <para>
        /// Each account receives a default cluster the first time you use the service, but you
        /// may also create other clusters.
        /// </para>
        /// </summary>
        public string Cluster
        {
            get { return this._cluster; }
            set { this._cluster = value; }
        }

        // Check to see if Cluster property is set
        internal bool IsSetCluster()
        {
            return this._cluster != null;
        }

        /// <summary>
        /// Gets and sets the property Count. 
        /// <para>
        /// The number of instantiations of the specified task to place on your cluster. You can
        /// specify up to 10 tasks for each call.
        /// </para>
        /// </summary>
        public int? Count
        {
            get { return this._count; }
            set { this._count = value; }
        }

        // Check to see if Count property is set
        internal bool IsSetCount()
        {
            return this._count.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EnableECSManagedTags. 
        /// <para>
        /// Specifies whether to use Amazon ECS managed tags for the task. For more information,
        /// see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/ecs-using-tags.html">Tagging
        /// Your Amazon ECS Resources</a> in the <i>Amazon Elastic Container Service Developer
        /// Guide</i>.
        /// </para>
        /// </summary>
        public bool? EnableECSManagedTags
        {
            get { return this._enableecsManagedTags; }
            set { this._enableecsManagedTags = value; }
        }

        // Check to see if EnableECSManagedTags property is set
        internal bool IsSetEnableECSManagedTags()
        {
            return this._enableecsManagedTags.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EnableExecuteCommand. 
        /// <para>
        /// Determines whether to use the execute command functionality for the containers in
        /// this task. If <c>true</c>, this enables execute command functionality on all containers
        /// in the task.
        /// </para>
        ///  
        /// <para>
        /// If <c>true</c>, then the task definition must have a task role, or you must provide
        /// one as an override.
        /// </para>
        /// </summary>
        public bool? EnableExecuteCommand
        {
            get { return this._enableExecuteCommand; }
            set { this._enableExecuteCommand = value; }
        }

        // Check to see if EnableExecuteCommand property is set
        internal bool IsSetEnableExecuteCommand()
        {
            return this._enableExecuteCommand.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Group. 
        /// <para>
        /// The name of the task group to associate with the task. The default value is the family
        /// name of the task definition (for example, <c>family:my-family-name</c>).
        /// </para>
        /// </summary>
        public string Group
        {
            get { return this._group; }
            set { this._group = value; }
        }

        // Check to see if Group property is set
        internal bool IsSetGroup()
        {
            return this._group != null;
        }

        /// <summary>
        /// Gets and sets the property LaunchType. 
        /// <para>
        /// The infrastructure to run your standalone task on. For more information, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/launch_types.html">Amazon
        /// ECS launch types</a> in the <i>Amazon Elastic Container Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// The <c>FARGATE</c> launch type runs your tasks on Fargate On-Demand infrastructure.
        /// </para>
        ///  <note> 
        /// <para>
        /// Fargate Spot infrastructure is available for use but a capacity provider strategy
        /// must be used. For more information, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/fargate-capacity-providers.html">Fargate
        /// capacity providers</a> in the <i>Amazon ECS Developer Guide</i>.
        /// </para>
        ///  </note> 
        /// <para>
        /// The <c>EC2</c> launch type runs your tasks on Amazon EC2 instances registered to your
        /// cluster.
        /// </para>
        ///  
        /// <para>
        /// The <c>EXTERNAL</c> launch type runs your tasks on your on-premises server or virtual
        /// machine (VM) capacity registered to your cluster.
        /// </para>
        ///  
        /// <para>
        /// A task can use either a launch type or a capacity provider strategy. If a <c>launchType</c>
        /// is specified, the <c>capacityProviderStrategy</c> parameter must be omitted.
        /// </para>
        ///  
        /// <para>
        /// When you use cluster auto scaling, you must specify <c>capacityProviderStrategy</c>
        /// and not <c>launchType</c>. 
        /// </para>
        /// </summary>
        public LaunchType LaunchType
        {
            get { return this._launchType; }
            set { this._launchType = value; }
        }

        // Check to see if LaunchType property is set
        internal bool IsSetLaunchType()
        {
            return this._launchType != null;
        }

        /// <summary>
        /// Gets and sets the property NetworkConfiguration. 
        /// <para>
        /// The network configuration for the task. This parameter is required for task definitions
        /// that use the <c>awsvpc</c> network mode to receive their own elastic network interface,
        /// and it isn't supported for other network modes. For more information, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/task-networking.html">Task
        /// networking</a> in the <i>Amazon Elastic Container Service Developer Guide</i>.
        /// </para>
        /// </summary>
        public NetworkConfiguration NetworkConfiguration
        {
            get { return this._networkConfiguration; }
            set { this._networkConfiguration = value; }
        }

        // Check to see if NetworkConfiguration property is set
        internal bool IsSetNetworkConfiguration()
        {
            return this._networkConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property Overrides. 
        /// <para>
        /// A list of container overrides in JSON format that specify the name of a container
        /// in the specified task definition and the overrides it should receive. You can override
        /// the default command for a container (that's specified in the task definition or Docker
        /// image) with a <c>command</c> override. You can also override existing environment
        /// variables (that are specified in the task definition or Docker image) on a container
        /// or add new environment variables to it with an <c>environment</c> override.
        /// </para>
        ///  
        /// <para>
        /// A total of 8192 characters are allowed for overrides. This limit includes the JSON
        /// formatting characters of the override structure.
        /// </para>
        /// </summary>
        public TaskOverride Overrides
        {
            get { return this._overrides; }
            set { this._overrides = value; }
        }

        // Check to see if Overrides property is set
        internal bool IsSetOverrides()
        {
            return this._overrides != null;
        }

        /// <summary>
        /// Gets and sets the property PlacementConstraints. 
        /// <para>
        /// An array of placement constraint objects to use for the task. You can specify up to
        /// 10 constraints for each task (including constraints in the task definition and those
        /// specified at runtime).
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<PlacementConstraint> PlacementConstraints
        {
            get { return this._placementConstraints; }
            set { this._placementConstraints = value; }
        }

        // Check to see if PlacementConstraints property is set
        internal bool IsSetPlacementConstraints()
        {
            return this._placementConstraints != null && (this._placementConstraints.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property PlacementStrategy. 
        /// <para>
        /// The placement strategy objects to use for the task. You can specify a maximum of 5
        /// strategy rules for each task.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<PlacementStrategy> PlacementStrategy
        {
            get { return this._placementStrategy; }
            set { this._placementStrategy = value; }
        }

        // Check to see if PlacementStrategy property is set
        internal bool IsSetPlacementStrategy()
        {
            return this._placementStrategy != null && (this._placementStrategy.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property PlatformVersion. 
        /// <para>
        /// The platform version the task uses. A platform version is only specified for tasks
        /// hosted on Fargate. If one isn't specified, the <c>LATEST</c> platform version is used.
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/platform_versions.html">Fargate
        /// platform versions</a> in the <i>Amazon Elastic Container Service Developer Guide</i>.
        /// </para>
        /// </summary>
        public string PlatformVersion
        {
            get { return this._platformVersion; }
            set { this._platformVersion = value; }
        }

        // Check to see if PlatformVersion property is set
        internal bool IsSetPlatformVersion()
        {
            return this._platformVersion != null;
        }

        /// <summary>
        /// Gets and sets the property PropagateTags. 
        /// <para>
        /// Specifies whether to propagate the tags from the task definition to the task. If no
        /// value is specified, the tags aren't propagated. Tags can only be propagated to the
        /// task during task creation. To add tags to a task after task creation, use the<a href="https://docs.aws.amazon.com/AmazonECS/latest/APIReference/API_TagResource.html">TagResource</a>
        /// API action.
        /// </para>
        ///  <note> 
        /// <para>
        /// An error will be received if you specify the <c>SERVICE</c> option when running a
        /// task.
        /// </para>
        ///  </note>
        /// </summary>
        public PropagateTags PropagateTags
        {
            get { return this._propagateTags; }
            set { this._propagateTags = value; }
        }

        // Check to see if PropagateTags property is set
        internal bool IsSetPropagateTags()
        {
            return this._propagateTags != null;
        }

        /// <summary>
        /// Gets and sets the property ReferenceId. 
        /// <para>
        /// This parameter is only used by Amazon ECS. It is not intended for use by customers.
        /// </para>
        /// </summary>
        public string ReferenceId
        {
            get { return this._referenceId; }
            set { this._referenceId = value; }
        }

        // Check to see if ReferenceId property is set
        internal bool IsSetReferenceId()
        {
            return this._referenceId != null;
        }

        /// <summary>
        /// Gets and sets the property StartedBy. 
        /// <para>
        /// An optional tag specified when a task is started. For example, if you automatically
        /// trigger a task to run a batch process job, you could apply a unique identifier for
        /// that job to your task with the <c>startedBy</c> parameter. You can then identify which
        /// tasks belong to that job by filtering the results of a <a href="https://docs.aws.amazon.com/AmazonECS/latest/APIReference/API_ListTasks.html">ListTasks</a>
        /// call with the <c>startedBy</c> value. Up to 128 letters (uppercase and lowercase),
        /// numbers, hyphens (-), forward slash (/), and underscores (_) are allowed.
        /// </para>
        ///  
        /// <para>
        /// If a task is started by an Amazon ECS service, then the <c>startedBy</c> parameter
        /// contains the deployment ID of the service that starts it.
        /// </para>
        /// </summary>
        public string StartedBy
        {
            get { return this._startedBy; }
            set { this._startedBy = value; }
        }

        // Check to see if StartedBy property is set
        internal bool IsSetStartedBy()
        {
            return this._startedBy != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The metadata that you apply to the task to help you categorize and organize them.
        /// Each tag consists of a key and an optional value, both of which you define.
        /// </para>
        ///  
        /// <para>
        /// The following basic restrictions apply to tags:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Maximum number of tags per resource - 50
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For each resource, each tag key must be unique, and each tag key can have only one
        /// value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Maximum key length - 128 Unicode characters in UTF-8
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Maximum value length - 256 Unicode characters in UTF-8
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If your tagging schema is used across multiple services and resources, remember that
        /// other services may have restrictions on allowed characters. Generally allowed characters
        /// are: letters, numbers, and spaces representable in UTF-8, and the following characters:
        /// + - = . _ : / @.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Tag keys and values are case-sensitive.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Do not use <c>aws:</c>, <c>AWS:</c>, or any upper or lowercase combination of such
        /// as a prefix for either keys or values as it is reserved for Amazon Web Services use.
        /// You cannot edit or delete tag keys or values with this prefix. Tags with this prefix
        /// do not count against your tags per resource limit.
        /// </para>
        ///  </li> </ul>
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
        /// Gets and sets the property TaskDefinition. 
        /// <para>
        /// The <c>family</c> and <c>revision</c> (<c>family:revision</c>) or full ARN of the
        /// task definition to run. If a <c>revision</c> isn't specified, the latest <c>ACTIVE</c>
        /// revision is used.
        /// </para>
        ///  
        /// <para>
        /// The full ARN value must match the value that you specified as the <c>Resource</c>
        /// of the principal's permissions policy.
        /// </para>
        ///  
        /// <para>
        /// When you specify a task definition, you must either specify a specific revision, or
        /// all revisions in the ARN.
        /// </para>
        ///  
        /// <para>
        /// To specify a specific revision, include the revision number in the ARN. For example,
        /// to specify revision 2, use <c>arn:aws:ecs:us-east-1:111122223333:task-definition/TaskFamilyName:2</c>.
        /// </para>
        ///  
        /// <para>
        /// To specify all revisions, use the wildcard (*) in the ARN. For example, to specify
        /// all revisions, use <c>arn:aws:ecs:us-east-1:111122223333:task-definition/TaskFamilyName:*</c>.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/security_iam_service-with-iam.html#security_iam_service-with-iam-id-based-policies-resources">Policy
        /// Resources for Amazon ECS</a> in the Amazon Elastic Container Service Developer Guide.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string TaskDefinition
        {
            get { return this._taskDefinition; }
            set { this._taskDefinition = value; }
        }

        // Check to see if TaskDefinition property is set
        internal bool IsSetTaskDefinition()
        {
            return this._taskDefinition != null;
        }

        /// <summary>
        /// Gets and sets the property VolumeConfigurations. 
        /// <para>
        /// The details of the volume that was <c>configuredAtLaunch</c>. You can configure the
        /// size, volumeType, IOPS, throughput, snapshot and encryption in in <a href="https://docs.aws.amazon.com/AmazonECS/latest/APIReference/API_TaskManagedEBSVolumeConfiguration.html">TaskManagedEBSVolumeConfiguration</a>.
        /// The <c>name</c> of the volume must match the <c>name</c> from the task definition.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<TaskVolumeConfiguration> VolumeConfigurations
        {
            get { return this._volumeConfigurations; }
            set { this._volumeConfigurations = value; }
        }

        // Check to see if VolumeConfigurations property is set
        internal bool IsSetVolumeConfigurations()
        {
            return this._volumeConfigurations != null && (this._volumeConfigurations.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}