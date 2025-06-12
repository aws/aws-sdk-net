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
    /// A Docker container that's part of a task.
    /// </summary>
    public partial class Container
    {
        private string _containerArn;
        private string _cpu;
        private int? _exitCode;
        private List<string> _gpuIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private HealthStatus _healthStatus;
        private string _image;
        private string _imageDigest;
        private string _lastStatus;
        private List<ManagedAgent> _managedAgents = AWSConfigs.InitializeCollections ? new List<ManagedAgent>() : null;
        private string _memory;
        private string _memoryReservation;
        private string _name;
        private List<NetworkBinding> _networkBindings = AWSConfigs.InitializeCollections ? new List<NetworkBinding>() : null;
        private List<NetworkInterface> _networkInterfaces = AWSConfigs.InitializeCollections ? new List<NetworkInterface>() : null;
        private string _reason;
        private string _runtimeId;
        private string _taskArn;

        /// <summary>
        /// Gets and sets the property ContainerArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the container.
        /// </para>
        /// </summary>
        public string ContainerArn
        {
            get { return this._containerArn; }
            set { this._containerArn = value; }
        }

        // Check to see if ContainerArn property is set
        internal bool IsSetContainerArn()
        {
            return this._containerArn != null;
        }

        /// <summary>
        /// Gets and sets the property Cpu. 
        /// <para>
        /// The number of CPU units set for the container. The value is <c>0</c> if no value was
        /// specified in the container definition when the task definition was registered.
        /// </para>
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
        /// Gets and sets the property ExitCode. 
        /// <para>
        /// The exit code returned from the container.
        /// </para>
        /// </summary>
        public int? ExitCode
        {
            get { return this._exitCode; }
            set { this._exitCode = value; }
        }

        // Check to see if ExitCode property is set
        internal bool IsSetExitCode()
        {
            return this._exitCode.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property GpuIds. 
        /// <para>
        /// The IDs of each GPU assigned to the container.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> GpuIds
        {
            get { return this._gpuIds; }
            set { this._gpuIds = value; }
        }

        // Check to see if GpuIds property is set
        internal bool IsSetGpuIds()
        {
            return this._gpuIds != null && (this._gpuIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property HealthStatus. 
        /// <para>
        /// The health status of the container. If health checks aren't configured for this container
        /// in its task definition, then it reports the health status as <c>UNKNOWN</c>.
        /// </para>
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
        /// Gets and sets the property Image. 
        /// <para>
        /// The image used for the container.
        /// </para>
        /// </summary>
        public string Image
        {
            get { return this._image; }
            set { this._image = value; }
        }

        // Check to see if Image property is set
        internal bool IsSetImage()
        {
            return this._image != null;
        }

        /// <summary>
        /// Gets and sets the property ImageDigest. 
        /// <para>
        /// The container image manifest digest.
        /// </para>
        /// </summary>
        public string ImageDigest
        {
            get { return this._imageDigest; }
            set { this._imageDigest = value; }
        }

        // Check to see if ImageDigest property is set
        internal bool IsSetImageDigest()
        {
            return this._imageDigest != null;
        }

        /// <summary>
        /// Gets and sets the property LastStatus. 
        /// <para>
        /// The last known status of the container.
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
        /// Gets and sets the property ManagedAgents. 
        /// <para>
        /// The details of any Amazon ECS managed agents associated with the container.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ManagedAgent> ManagedAgents
        {
            get { return this._managedAgents; }
            set { this._managedAgents = value; }
        }

        // Check to see if ManagedAgents property is set
        internal bool IsSetManagedAgents()
        {
            return this._managedAgents != null && (this._managedAgents.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Memory. 
        /// <para>
        /// The hard limit (in MiB) of memory set for the container.
        /// </para>
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
        /// Gets and sets the property MemoryReservation. 
        /// <para>
        /// The soft limit (in MiB) of memory set for the container.
        /// </para>
        /// </summary>
        public string MemoryReservation
        {
            get { return this._memoryReservation; }
            set { this._memoryReservation = value; }
        }

        // Check to see if MemoryReservation property is set
        internal bool IsSetMemoryReservation()
        {
            return this._memoryReservation != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the container.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property NetworkBindings. 
        /// <para>
        /// The network bindings associated with the container.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<NetworkBinding> NetworkBindings
        {
            get { return this._networkBindings; }
            set { this._networkBindings = value; }
        }

        // Check to see if NetworkBindings property is set
        internal bool IsSetNetworkBindings()
        {
            return this._networkBindings != null && (this._networkBindings.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NetworkInterfaces. 
        /// <para>
        /// The network interfaces associated with the container.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<NetworkInterface> NetworkInterfaces
        {
            get { return this._networkInterfaces; }
            set { this._networkInterfaces = value; }
        }

        // Check to see if NetworkInterfaces property is set
        internal bool IsSetNetworkInterfaces()
        {
            return this._networkInterfaces != null && (this._networkInterfaces.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Reason. 
        /// <para>
        /// A short (1024 max characters) human-readable string to provide additional details
        /// about a running or stopped container.
        /// </para>
        /// </summary>
        public string Reason
        {
            get { return this._reason; }
            set { this._reason = value; }
        }

        // Check to see if Reason property is set
        internal bool IsSetReason()
        {
            return this._reason != null;
        }

        /// <summary>
        /// Gets and sets the property RuntimeId. 
        /// <para>
        /// The ID of the Docker container.
        /// </para>
        /// </summary>
        public string RuntimeId
        {
            get { return this._runtimeId; }
            set { this._runtimeId = value; }
        }

        // Check to see if RuntimeId property is set
        internal bool IsSetRuntimeId()
        {
            return this._runtimeId != null;
        }

        /// <summary>
        /// Gets and sets the property TaskArn. 
        /// <para>
        /// The ARN of the task.
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

    }
}