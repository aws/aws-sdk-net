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

namespace Amazon.ECS.Model
{
    /// <summary>
    /// Details on a task in a cluster.
    /// </summary>
    public partial class Task
    {
        private List<Attachment> _attachments = new List<Attachment>();
        private List<Attribute> _attributes = new List<Attribute>();
        private string _availabilityZone;
        private string _capacityProviderName;
        private string _clusterArn;
        private Connectivity _connectivity;
        private DateTime? _connectivityAt;
        private string _containerInstanceArn;
        private List<Container> _containers = new List<Container>();
        private string _cpu;
        private DateTime? _createdAt;
        private string _desiredStatus;
        private bool? _enableExecuteCommand;
        private EphemeralStorage _ephemeralStorage;
        private DateTime? _executionStoppedAt;
        private string _group;
        private HealthStatus _healthStatus;
        private List<InferenceAccelerator> _inferenceAccelerators = new List<InferenceAccelerator>();
        private string _lastStatus;
        private LaunchType _launchType;
        private string _memory;
        private TaskOverride _overrides;
        private string _platformFamily;
        private string _platformVersion;
        private DateTime? _pullStartedAt;
        private DateTime? _pullStoppedAt;
        private DateTime? _startedAt;
        private string _startedBy;
        private TaskStopCode _stopCode;
        private DateTime? _stoppedAt;
        private string _stoppedReason;
        private DateTime? _stoppingAt;
        private List<Tag> _tags = new List<Tag>();
        private string _taskArn;
        private string _taskDefinitionArn;
        private long? _version;

        /// <summary>
        /// Gets and sets the property Attachments. 
        /// <para>
        /// The Elastic Network Adapter that's associated with the task if the task uses the <code>awsvpc</code>
        /// network mode.
        /// </para>
        /// </summary>
        public List<Attachment> Attachments
        {
            get { return this._attachments; }
            set { this._attachments = value; }
        }

        // Check to see if Attachments property is set
        internal bool IsSetAttachments()
        {
            return this._attachments != null && this._attachments.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Attributes. 
        /// <para>
        /// The attributes of the task
        /// </para>
        /// </summary>
        public List<Attribute> Attributes
        {
            get { return this._attributes; }
            set { this._attributes = value; }
        }

        // Check to see if Attributes property is set
        internal bool IsSetAttributes()
        {
            return this._attributes != null && this._attributes.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property AvailabilityZone. 
        /// <para>
        /// The Availability Zone for the task.
        /// </para>
        /// </summary>
        public string AvailabilityZone
        {
            get { return this._availabilityZone; }
            set { this._availabilityZone = value; }
        }

        // Check to see if AvailabilityZone property is set
        internal bool IsSetAvailabilityZone()
        {
            return this._availabilityZone != null;
        }

        /// <summary>
        /// Gets and sets the property CapacityProviderName. 
        /// <para>
        /// The capacity provider that's associated with the task.
        /// </para>
        /// </summary>
        public string CapacityProviderName
        {
            get { return this._capacityProviderName; }
            set { this._capacityProviderName = value; }
        }

        // Check to see if CapacityProviderName property is set
        internal bool IsSetCapacityProviderName()
        {
            return this._capacityProviderName != null;
        }

        /// <summary>
        /// Gets and sets the property ClusterArn. 
        /// <para>
        /// The ARN of the cluster that hosts the task.
        /// </para>
        /// </summary>
        public string ClusterArn
        {
            get { return this._clusterArn; }
            set { this._clusterArn = value; }
        }

        // Check to see if ClusterArn property is set
        internal bool IsSetClusterArn()
        {
            return this._clusterArn != null;
        }

        /// <summary>
        /// Gets and sets the property Connectivity. 
        /// <para>
        /// The connectivity status of a task.
        /// </para>
        /// </summary>
        public Connectivity Connectivity
        {
            get { return this._connectivity; }
            set { this._connectivity = value; }
        }

        // Check to see if Connectivity property is set
        internal bool IsSetConnectivity()
        {
            return this._connectivity != null;
        }

        /// <summary>
        /// Gets and sets the property ConnectivityAt. 
        /// <para>
        /// The Unix timestamp for the time when the task last went into <code>CONNECTED</code>
        /// status.
        /// </para>
        /// </summary>
        public DateTime ConnectivityAt
        {
            get { return this._connectivityAt.GetValueOrDefault(); }
            set { this._connectivityAt = value; }
        }

        // Check to see if ConnectivityAt property is set
        internal bool IsSetConnectivityAt()
        {
            return this._connectivityAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ContainerInstanceArn. 
        /// <para>
        /// The ARN of the container instances that host the task.
        /// </para>
        /// </summary>
        public string ContainerInstanceArn
        {
            get { return this._containerInstanceArn; }
            set { this._containerInstanceArn = value; }
        }

        // Check to see if ContainerInstanceArn property is set
        internal bool IsSetContainerInstanceArn()
        {
            return this._containerInstanceArn != null;
        }

        /// <summary>
        /// Gets and sets the property Containers. 
        /// <para>
        /// The containers that's associated with the task.
        /// </para>
        /// </summary>
        public List<Container> Containers
        {
            get { return this._containers; }
            set { this._containers = value; }
        }

        // Check to see if Containers property is set
        internal bool IsSetContainers()
        {
            return this._containers != null && this._containers.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Cpu. 
        /// <para>
        /// The number of CPU units used by the task as expressed in a task definition. It can
        /// be expressed as an integer using CPU units (for example, <code>1024</code>). It can
        /// also be expressed as a string using vCPUs (for example, <code>1 vCPU</code> or <code>1
        /// vcpu</code>). String values are converted to an integer that indicates the CPU units
        /// when the task definition is registered.
        /// </para>
        ///  
        /// <para>
        /// If you use the EC2 launch type, this field is optional. Supported values are between
        /// <code>128</code> CPU units (<code>0.125</code> vCPUs) and <code>10240</code> CPU units
        /// (<code>10</code> vCPUs).
        /// </para>
        ///  
        /// <para>
        /// If you use the Fargate launch type, this field is required. You must use one of the
        /// following values. These values determine the range of supported values for the <code>memory</code>
        /// parameter:
        /// </para>
        ///  
        /// <para>
        /// The CPU units cannot be less than 1 vCPU when you use Windows containers on Fargate.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// 256 (.25 vCPU) - Available <code>memory</code> values: 512 (0.5 GB), 1024 (1 GB),
        /// 2048 (2 GB)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// 512 (.5 vCPU) - Available <code>memory</code> values: 1024 (1 GB), 2048 (2 GB), 3072
        /// (3 GB), 4096 (4 GB)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// 1024 (1 vCPU) - Available <code>memory</code> values: 2048 (2 GB), 3072 (3 GB), 4096
        /// (4 GB), 5120 (5 GB), 6144 (6 GB), 7168 (7 GB), 8192 (8 GB)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// 2048 (2 vCPU) - Available <code>memory</code> values: 4096 (4 GB) and 16384 (16 GB)
        /// in increments of 1024 (1 GB)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// 4096 (4 vCPU) - Available <code>memory</code> values: 8192 (8 GB) and 30720 (30 GB)
        /// in increments of 1024 (1 GB)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// 8192 (8 vCPU) - Available <code>memory</code> values: 16 GB and 60 GB in 4 GB increments
        /// </para>
        ///  
        /// <para>
        /// This option requires Linux platform <code>1.4.0</code> or later.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// 16384 (16vCPU) - Available <code>memory</code> values: 32GB and 120 GB in 8 GB increments
        /// </para>
        ///  
        /// <para>
        /// This option requires Linux platform <code>1.4.0</code> or later.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string Cpu
        {
            get { return this._cpu; }
            set { this._cpu = value; }
        }

        // Check to see if Cpu property is set
        internal bool IsSetCpu()
        {
            return this._cpu != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The Unix timestamp for the time when the task was created. More specifically, it's
        /// for the time when the task entered the <code>PENDING</code> state.
        /// </para>
        /// </summary>
        public DateTime CreatedAt
        {
            get { return this._createdAt.GetValueOrDefault(); }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DesiredStatus. 
        /// <para>
        /// The desired status of the task. For more information, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/task-lifecycle.html">Task
        /// Lifecycle</a>.
        /// </para>
        /// </summary>
        public string DesiredStatus
        {
            get { return this._desiredStatus; }
            set { this._desiredStatus = value; }
        }

        // Check to see if DesiredStatus property is set
        internal bool IsSetDesiredStatus()
        {
            return this._desiredStatus != null;
        }

        /// <summary>
        /// Gets and sets the property EnableExecuteCommand. 
        /// <para>
        /// Determines whether execute command functionality is enabled for this task. If <code>true</code>,
        /// execute command functionality is enabled on all the containers in the task.
        /// </para>
        /// </summary>
        public bool EnableExecuteCommand
        {
            get { return this._enableExecuteCommand.GetValueOrDefault(); }
            set { this._enableExecuteCommand = value; }
        }

        // Check to see if EnableExecuteCommand property is set
        internal bool IsSetEnableExecuteCommand()
        {
            return this._enableExecuteCommand.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EphemeralStorage. 
        /// <para>
        /// The ephemeral storage settings for the task.
        /// </para>
        /// </summary>
        public EphemeralStorage EphemeralStorage
        {
            get { return this._ephemeralStorage; }
            set { this._ephemeralStorage = value; }
        }

        // Check to see if EphemeralStorage property is set
        internal bool IsSetEphemeralStorage()
        {
            return this._ephemeralStorage != null;
        }

        /// <summary>
        /// Gets and sets the property ExecutionStoppedAt. 
        /// <para>
        /// The Unix timestamp for the time when the task execution stopped.
        /// </para>
        /// </summary>
        public DateTime ExecutionStoppedAt
        {
            get { return this._executionStoppedAt.GetValueOrDefault(); }
            set { this._executionStoppedAt = value; }
        }

        // Check to see if ExecutionStoppedAt property is set
        internal bool IsSetExecutionStoppedAt()
        {
            return this._executionStoppedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Group. 
        /// <para>
        /// The name of the task group that's associated with the task.
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
        /// Gets and sets the property HealthStatus. 
        /// <para>
        /// The health status for the task. It's determined by the health of the essential containers
        /// in the task. If all essential containers in the task are reporting as <code>HEALTHY</code>,
        /// the task status also reports as <code>HEALTHY</code>. If any essential containers
        /// in the task are reporting as <code>UNHEALTHY</code> or <code>UNKNOWN</code>, the task
        /// status also reports as <code>UNHEALTHY</code> or <code>UNKNOWN</code>.
        /// </para>
        ///  <note> 
        /// <para>
        /// The Amazon ECS container agent doesn't monitor or report on Docker health checks that
        /// are embedded in a container image and not specified in the container definition. For
        /// example, this includes those specified in a parent image or from the image's Dockerfile.
        /// Health check parameters that are specified in a container definition override any
        /// Docker health checks that are found in the container image.
        /// </para>
        ///  </note>
        /// </summary>
        public HealthStatus HealthStatus
        {
            get { return this._healthStatus; }
            set { this._healthStatus = value; }
        }

        // Check to see if HealthStatus property is set
        internal bool IsSetHealthStatus()
        {
            return this._healthStatus != null;
        }

        /// <summary>
        /// Gets and sets the property InferenceAccelerators. 
        /// <para>
        /// The Elastic Inference accelerator that's associated with the task.
        /// </para>
        /// </summary>
        public List<InferenceAccelerator> InferenceAccelerators
        {
            get { return this._inferenceAccelerators; }
            set { this._inferenceAccelerators = value; }
        }

        // Check to see if InferenceAccelerators property is set
        internal bool IsSetInferenceAccelerators()
        {
            return this._inferenceAccelerators != null && this._inferenceAccelerators.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property LastStatus. 
        /// <para>
        /// The last known status for the task. For more information, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/task-lifecycle.html">Task
        /// Lifecycle</a>.
        /// </para>
        /// </summary>
        public string LastStatus
        {
            get { return this._lastStatus; }
            set { this._lastStatus = value; }
        }

        // Check to see if LastStatus property is set
        internal bool IsSetLastStatus()
        {
            return this._lastStatus != null;
        }

        /// <summary>
        /// Gets and sets the property LaunchType. 
        /// <para>
        /// The infrastructure where your task runs on. For more information, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/launch_types.html">Amazon
        /// ECS launch types</a> in the <i>Amazon Elastic Container Service Developer Guide</i>.
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
        /// Gets and sets the property Memory. 
        /// <para>
        /// The amount of memory (in MiB) that the task uses as expressed in a task definition.
        /// It can be expressed as an integer using MiB (for example, <code>1024</code>). If it's
        /// expressed as a string using GB (for example, <code>1GB</code> or <code>1 GB</code>),
        /// it's converted to an integer indicating the MiB when the task definition is registered.
        /// </para>
        ///  
        /// <para>
        /// If you use the EC2 launch type, this field is optional.
        /// </para>
        ///  
        /// <para>
        /// If you use the Fargate launch type, this field is required. You must use one of the
        /// following values. The value that you choose determines the range of supported values
        /// for the <code>cpu</code> parameter.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// 512 (0.5 GB), 1024 (1 GB), 2048 (2 GB) - Available <code>cpu</code> values: 256 (.25
        /// vCPU)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// 1024 (1 GB), 2048 (2 GB), 3072 (3 GB), 4096 (4 GB) - Available <code>cpu</code> values:
        /// 512 (.5 vCPU)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// 2048 (2 GB), 3072 (3 GB), 4096 (4 GB), 5120 (5 GB), 6144 (6 GB), 7168 (7 GB), 8192
        /// (8 GB) - Available <code>cpu</code> values: 1024 (1 vCPU)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Between 4096 (4 GB) and 16384 (16 GB) in increments of 1024 (1 GB) - Available <code>cpu</code>
        /// values: 2048 (2 vCPU)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Between 8192 (8 GB) and 30720 (30 GB) in increments of 1024 (1 GB) - Available <code>cpu</code>
        /// values: 4096 (4 vCPU)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Between 16 GB and 60 GB in 4 GB increments - Available <code>cpu</code> values: 8192
        /// (8 vCPU)
        /// </para>
        ///  
        /// <para>
        /// This option requires Linux platform <code>1.4.0</code> or later.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Between 32GB and 120 GB in 8 GB increments - Available <code>cpu</code> values: 16384
        /// (16 vCPU)
        /// </para>
        ///  
        /// <para>
        /// This option requires Linux platform <code>1.4.0</code> or later.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string Memory
        {
            get { return this._memory; }
            set { this._memory = value; }
        }

        // Check to see if Memory property is set
        internal bool IsSetMemory()
        {
            return this._memory != null;
        }

        /// <summary>
        /// Gets and sets the property Overrides. 
        /// <para>
        /// One or more container overrides.
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
        /// Gets and sets the property PlatformFamily. 
        /// <para>
        /// The operating system that your tasks are running on. A platform family is specified
        /// only for tasks that use the Fargate launch type. 
        /// </para>
        ///  
        /// <para>
        ///  All tasks that run as part of this service must use the same <code>platformFamily</code>
        /// value as the service (for example, <code>LINUX.</code>).
        /// </para>
        /// </summary>
        public string PlatformFamily
        {
            get { return this._platformFamily; }
            set { this._platformFamily = value; }
        }

        // Check to see if PlatformFamily property is set
        internal bool IsSetPlatformFamily()
        {
            return this._platformFamily != null;
        }

        /// <summary>
        /// Gets and sets the property PlatformVersion. 
        /// <para>
        /// The platform version where your task runs on. A platform version is only specified
        /// for tasks that use the Fargate launch type. If you didn't specify one, the <code>LATEST</code>
        /// platform version is used. For more information, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/platform_versions.html">Fargate
        /// Platform Versions</a> in the <i>Amazon Elastic Container Service Developer Guide</i>.
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
        /// Gets and sets the property PullStartedAt. 
        /// <para>
        /// The Unix timestamp for the time when the container image pull began.
        /// </para>
        /// </summary>
        public DateTime PullStartedAt
        {
            get { return this._pullStartedAt.GetValueOrDefault(); }
            set { this._pullStartedAt = value; }
        }

        // Check to see if PullStartedAt property is set
        internal bool IsSetPullStartedAt()
        {
            return this._pullStartedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PullStoppedAt. 
        /// <para>
        /// The Unix timestamp for the time when the container image pull completed.
        /// </para>
        /// </summary>
        public DateTime PullStoppedAt
        {
            get { return this._pullStoppedAt.GetValueOrDefault(); }
            set { this._pullStoppedAt = value; }
        }

        // Check to see if PullStoppedAt property is set
        internal bool IsSetPullStoppedAt()
        {
            return this._pullStoppedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StartedAt. 
        /// <para>
        /// The Unix timestamp for the time when the task started. More specifically, it's for
        /// the time when the task transitioned from the <code>PENDING</code> state to the <code>RUNNING</code>
        /// state.
        /// </para>
        /// </summary>
        public DateTime StartedAt
        {
            get { return this._startedAt.GetValueOrDefault(); }
            set { this._startedAt = value; }
        }

        // Check to see if StartedAt property is set
        internal bool IsSetStartedAt()
        {
            return this._startedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StartedBy. 
        /// <para>
        /// The tag specified when a task is started. If an Amazon ECS service started the task,
        /// the <code>startedBy</code> parameter contains the deployment ID of that service.
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
        /// Gets and sets the property StopCode. 
        /// <para>
        /// The stop code indicating why a task was stopped. The <code>stoppedReason</code> might
        /// contain additional details.
        /// </para>
        ///  
        /// <para>
        /// The following are valid values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>TaskFailedToStart</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>EssentialContainerExited</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>UserInitiated</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>TerminationNotice</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ServiceSchedulerInitiated</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>SpotInterruption</code> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public TaskStopCode StopCode
        {
            get { return this._stopCode; }
            set { this._stopCode = value; }
        }

        // Check to see if StopCode property is set
        internal bool IsSetStopCode()
        {
            return this._stopCode != null;
        }

        /// <summary>
        /// Gets and sets the property StoppedAt. 
        /// <para>
        /// The Unix timestamp for the time when the task was stopped. More specifically, it's
        /// for the time when the task transitioned from the <code>RUNNING</code> state to the
        /// <code>STOPPED</code> state.
        /// </para>
        /// </summary>
        public DateTime StoppedAt
        {
            get { return this._stoppedAt.GetValueOrDefault(); }
            set { this._stoppedAt = value; }
        }

        // Check to see if StoppedAt property is set
        internal bool IsSetStoppedAt()
        {
            return this._stoppedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StoppedReason. 
        /// <para>
        /// The reason that the task was stopped.
        /// </para>
        /// </summary>
        public string StoppedReason
        {
            get { return this._stoppedReason; }
            set { this._stoppedReason = value; }
        }

        // Check to see if StoppedReason property is set
        internal bool IsSetStoppedReason()
        {
            return this._stoppedReason != null;
        }

        /// <summary>
        /// Gets and sets the property StoppingAt. 
        /// <para>
        /// The Unix timestamp for the time when the task stops. More specifically, it's for the
        /// time when the task transitions from the <code>RUNNING</code> state to <code>STOPPED</code>.
        /// </para>
        /// </summary>
        public DateTime StoppingAt
        {
            get { return this._stoppingAt.GetValueOrDefault(); }
            set { this._stoppingAt = value; }
        }

        // Check to see if StoppingAt property is set
        internal bool IsSetStoppingAt()
        {
            return this._stoppingAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The metadata that you apply to the task to help you categorize and organize the task.
        /// Each tag consists of a key and an optional value. You define both the key and value.
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
        /// Do not use <code>aws:</code>, <code>AWS:</code>, or any upper or lowercase combination
        /// of such as a prefix for either keys or values as it is reserved for Amazon Web Services
        /// use. You cannot edit or delete tag keys or values with this prefix. Tags with this
        /// prefix do not count against your tags per resource limit.
        /// </para>
        ///  </li> </ul>
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
            return this._tags != null && this._tags.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property TaskArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the task.
        /// </para>
        /// </summary>
        public string TaskArn
        {
            get { return this._taskArn; }
            set { this._taskArn = value; }
        }

        // Check to see if TaskArn property is set
        internal bool IsSetTaskArn()
        {
            return this._taskArn != null;
        }

        /// <summary>
        /// Gets and sets the property TaskDefinitionArn. 
        /// <para>
        /// The ARN of the task definition that creates the task.
        /// </para>
        /// </summary>
        public string TaskDefinitionArn
        {
            get { return this._taskDefinitionArn; }
            set { this._taskDefinitionArn = value; }
        }

        // Check to see if TaskDefinitionArn property is set
        internal bool IsSetTaskDefinitionArn()
        {
            return this._taskDefinitionArn != null;
        }

        /// <summary>
        /// Gets and sets the property Version. 
        /// <para>
        /// The version counter for the task. Every time a task experiences a change that starts
        /// a CloudWatch event, the version counter is incremented. If you replicate your Amazon
        /// ECS task state with CloudWatch Events, you can compare the version of a task reported
        /// by the Amazon ECS API actions with the version reported in CloudWatch Events for the
        /// task (inside the <code>detail</code> object) to verify that the version in your event
        /// stream is current.
        /// </para>
        /// </summary>
        public long Version
        {
            get { return this._version.GetValueOrDefault(); }
            set { this._version = value; }
        }

        // Check to see if Version property is set
        internal bool IsSetVersion()
        {
            return this._version.HasValue; 
        }

    }
}