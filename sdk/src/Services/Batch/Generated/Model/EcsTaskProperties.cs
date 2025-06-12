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
 * Do not modify this file. This file is generated from the batch-2016-08-10.normal.json service model.
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
namespace Amazon.Batch.Model
{
    /// <summary>
    /// The properties for a task definition that describes the container and volume definitions
    /// of an Amazon ECS task. You can specify which Docker images to use, the required resources,
    /// and other configurations related to launching the task definition through an Amazon
    /// ECS service or task.
    /// </summary>
    public partial class EcsTaskProperties
    {
        private List<TaskContainerProperties> _containers = AWSConfigs.InitializeCollections ? new List<TaskContainerProperties>() : null;
        private bool? _enableExecuteCommand;
        private EphemeralStorage _ephemeralStorage;
        private string _executionRoleArn;
        private string _ipcMode;
        private NetworkConfiguration _networkConfiguration;
        private string _pidMode;
        private string _platformVersion;
        private RuntimePlatform _runtimePlatform;
        private string _taskRoleArn;
        private List<Volume> _volumes = AWSConfigs.InitializeCollections ? new List<Volume>() : null;

        /// <summary>
        /// Gets and sets the property Containers. 
        /// <para>
        /// This object is a list of containers.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<TaskContainerProperties> Containers
        {
            get { return this._containers; }
            set { this._containers = value; }
        }

        // Check to see if Containers property is set
        internal bool IsSetContainers()
        {
            return this._containers != null && (this._containers.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property EnableExecuteCommand. 
        /// <para>
        /// Determines whether execute command functionality is turned on for this task. If <c>true</c>,
        /// execute command functionality is turned on all the containers in the task.
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
        /// Gets and sets the property EphemeralStorage. 
        /// <para>
        /// The amount of ephemeral storage to allocate for the task. This parameter is used to
        /// expand the total amount of ephemeral storage available, beyond the default amount,
        /// for tasks hosted on Fargate.
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
        /// Gets and sets the property ExecutionRoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the execution role that Batch can assume. For jobs
        /// that run on Fargate resources, you must provide an execution role. For more information,
        /// see <a href="https://docs.aws.amazon.com/batch/latest/userguide/execution-IAM-role.html">Batch
        /// execution IAM role</a> in the <i>Batch User Guide</i>.
        /// </para>
        /// </summary>
        public string ExecutionRoleArn
        {
            get { return this._executionRoleArn; }
            set { this._executionRoleArn = value; }
        }

        // Check to see if ExecutionRoleArn property is set
        internal bool IsSetExecutionRoleArn()
        {
            return this._executionRoleArn != null;
        }

        /// <summary>
        /// Gets and sets the property IpcMode. 
        /// <para>
        /// The IPC resource namespace to use for the containers in the task. The valid values
        /// are <c>host</c>, <c>task</c>, or <c>none</c>.
        /// </para>
        ///  
        /// <para>
        /// If <c>host</c> is specified, all containers within the tasks that specified the <c>host</c>
        /// IPC mode on the same container instance share the same IPC resources with the host
        /// Amazon EC2 instance.
        /// </para>
        ///  
        /// <para>
        /// If <c>task</c> is specified, all containers within the specified <c>task</c> share
        /// the same IPC resources.
        /// </para>
        ///  
        /// <para>
        /// If <c>none</c> is specified, the IPC resources within the containers of a task are
        /// private, and are not shared with other containers in a task or on the container instance.
        /// 
        /// </para>
        ///  
        /// <para>
        /// If no value is specified, then the IPC resource namespace sharing depends on the Docker
        /// daemon setting on the container instance. For more information, see <a href="https://docs.docker.com/engine/reference/run/#ipc-settings---ipc">IPC
        /// settings</a> in the Docker run reference.
        /// </para>
        /// </summary>
        public string IpcMode
        {
            get { return this._ipcMode; }
            set { this._ipcMode = value; }
        }

        // Check to see if IpcMode property is set
        internal bool IsSetIpcMode()
        {
            return this._ipcMode != null;
        }

        /// <summary>
        /// Gets and sets the property NetworkConfiguration. 
        /// <para>
        /// The network configuration for jobs that are running on Fargate resources. Jobs that
        /// are running on Amazon EC2 resources must not specify this parameter.
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
        /// Gets and sets the property PidMode. 
        /// <para>
        /// The process namespace to use for the containers in the task. The valid values are
        /// <c>host</c> or <c>task</c>. For example, monitoring sidecars might need <c>pidMode</c>
        /// to access information about other containers running in the same task.
        /// </para>
        ///  
        /// <para>
        /// If <c>host</c> is specified, all containers within the tasks that specified the <c>host</c>
        /// PID mode on the same container instance share the process namespace with the host
        /// Amazon EC2 instance.
        /// </para>
        ///  
        /// <para>
        /// If <c>task</c> is specified, all containers within the specified task share the same
        /// process namespace.
        /// </para>
        ///  
        /// <para>
        /// If no value is specified, the default is a private namespace for each container. For
        /// more information, see <a href="https://docs.docker.com/engine/reference/run/#pid-settings---pid">PID
        /// settings</a> in the Docker run reference.
        /// </para>
        /// </summary>
        public string PidMode
        {
            get { return this._pidMode; }
            set { this._pidMode = value; }
        }

        // Check to see if PidMode property is set
        internal bool IsSetPidMode()
        {
            return this._pidMode != null;
        }

        /// <summary>
        /// Gets and sets the property PlatformVersion. 
        /// <para>
        /// The Fargate platform version where the jobs are running. A platform version is specified
        /// only for jobs that are running on Fargate resources. If one isn't specified, the <c>LATEST</c>
        /// platform version is used by default. This uses a recent, approved version of the Fargate
        /// platform for compute resources. For more information, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/platform_versions.html">Fargate
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
        /// Gets and sets the property RuntimePlatform. 
        /// <para>
        /// An object that represents the compute environment architecture for Batch jobs on Fargate.
        /// </para>
        /// </summary>
        public RuntimePlatform RuntimePlatform
        {
            get { return this._runtimePlatform; }
            set { this._runtimePlatform = value; }
        }

        // Check to see if RuntimePlatform property is set
        internal bool IsSetRuntimePlatform()
        {
            return this._runtimePlatform != null;
        }

        /// <summary>
        /// Gets and sets the property TaskRoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) that's associated with the Amazon ECS task.
        /// </para>
        ///  <note> 
        /// <para>
        /// This is object is comparable to <a href="https://docs.aws.amazon.com/batch/latest/APIReference/API_ContainerProperties.html">ContainerProperties:jobRoleArn</a>.
        /// </para>
        ///  </note>
        /// </summary>
        public string TaskRoleArn
        {
            get { return this._taskRoleArn; }
            set { this._taskRoleArn = value; }
        }

        // Check to see if TaskRoleArn property is set
        internal bool IsSetTaskRoleArn()
        {
            return this._taskRoleArn != null;
        }

        /// <summary>
        /// Gets and sets the property Volumes. 
        /// <para>
        /// A list of volumes that are associated with the job.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Volume> Volumes
        {
            get { return this._volumes; }
            set { this._volumes = value; }
        }

        // Check to see if Volumes property is set
        internal bool IsSetVolumes()
        {
            return this._volumes != null && (this._volumes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}