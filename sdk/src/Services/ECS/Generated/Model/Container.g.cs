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

namespace Amazon.ECS.Model
{
    /// <summary>
    /// A Docker container that's part of a task.
    /// </summary>
    public partial class Container
    {
        /// <summary>
        /// Gets and sets the property ContainerArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the container.
        /// </para>
        /// </summary>
        public string ContainerArn { get; set; }

        /// <summary>
        /// Checks to see if the ContainerArn property is set.
        /// </summary>
        internal bool IsSetContainerArn() => this.ContainerArn != null;

        /// <summary>
        /// Gets and sets the property Cpu. 
        /// <para>
        /// The number of CPU units set for the container. The value is <c>0</c> if no value was
        /// specified in the container definition when the task definition was registered.
        /// </para>
        /// </summary>
        public string Cpu { get; set; }

        /// <summary>
        /// Checks to see if the Cpu property is set.
        /// </summary>
        internal bool IsSetCpu() => this.Cpu != null;

        /// <summary>
        /// Gets and sets the property ExitCode. 
        /// <para>
        /// The exit code returned from the container.
        /// </para>
        /// </summary>
        public int? ExitCode { get; set; }

        /// <summary>
        /// Checks to see if the ExitCode property is set.
        /// </summary>
        internal bool IsSetExitCode() => this.ExitCode.HasValue;

        /// <summary>
        /// Gets and sets the property GpuIds. 
        /// <para>
        /// The IDs of each GPU assigned to the container.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> GpuIds { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the GpuIds property is set.
        /// </summary>
        internal bool IsSetGpuIds() => this.GpuIds != null && (this.GpuIds.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property GpuSharingStrategy. 
        /// <para>
        /// The GPU sharing strategy that the task definition specifies for the container. This
        /// field is present only for containers whose resource requirements include <c>sharingStrategy</c>.
        /// </para>
        /// </summary>
        public SharingStrategy GpuSharingStrategy { get; set; }

        /// <summary>
        /// Checks to see if the GpuSharingStrategy property is set.
        /// </summary>
        internal bool IsSetGpuSharingStrategy() => this.GpuSharingStrategy != null;

        /// <summary>
        /// Gets and sets the property HealthStatus. 
        /// <para>
        /// The health status of the container. If health checks aren't configured for this container
        /// in its task definition, then it reports the health status as <c>UNKNOWN</c>.
        /// </para>
        /// </summary>
        public HealthStatus HealthStatus { get; set; }

        /// <summary>
        /// Checks to see if the HealthStatus property is set.
        /// </summary>
        internal bool IsSetHealthStatus() => this.HealthStatus != null;

        /// <summary>
        /// Gets and sets the property Image. 
        /// <para>
        /// The image used for the container.
        /// </para>
        /// </summary>
        public string Image { get; set; }

        /// <summary>
        /// Checks to see if the Image property is set.
        /// </summary>
        internal bool IsSetImage() => this.Image != null;

        /// <summary>
        /// Gets and sets the property ImageDigest. 
        /// <para>
        /// The container image manifest digest.
        /// </para>
        /// </summary>
        public string ImageDigest { get; set; }

        /// <summary>
        /// Checks to see if the ImageDigest property is set.
        /// </summary>
        internal bool IsSetImageDigest() => this.ImageDigest != null;

        /// <summary>
        /// Gets and sets the property LastStatus. 
        /// <para>
        /// The last known status of the container.
        /// </para>
        /// </summary>
        public string LastStatus { get; set; }

        /// <summary>
        /// Checks to see if the LastStatus property is set.
        /// </summary>
        internal bool IsSetLastStatus() => this.LastStatus != null;

        /// <summary>
        /// Gets and sets the property ManagedAgents. 
        /// <para>
        /// The details of any Amazon ECS managed agents associated with the container.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ManagedAgent> ManagedAgents { get; set; } = AWSConfigs.InitializeCollections ? new List<ManagedAgent>() : null;

        /// <summary>
        /// Checks to see if the ManagedAgents property is set.
        /// </summary>
        internal bool IsSetManagedAgents() => this.ManagedAgents != null && (this.ManagedAgents.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Memory. 
        /// <para>
        /// The hard limit (in MiB) of memory set for the container.
        /// </para>
        /// </summary>
        public string Memory { get; set; }

        /// <summary>
        /// Checks to see if the Memory property is set.
        /// </summary>
        internal bool IsSetMemory() => this.Memory != null;

        /// <summary>
        /// Gets and sets the property MemoryReservation. 
        /// <para>
        /// The soft limit (in MiB) of memory set for the container.
        /// </para>
        /// </summary>
        public string MemoryReservation { get; set; }

        /// <summary>
        /// Checks to see if the MemoryReservation property is set.
        /// </summary>
        internal bool IsSetMemoryReservation() => this.MemoryReservation != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the container.
        /// </para>
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property NetworkBindings. 
        /// <para>
        /// The network bindings associated with the container.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<NetworkBinding> NetworkBindings { get; set; } = AWSConfigs.InitializeCollections ? new List<NetworkBinding>() : null;

        /// <summary>
        /// Checks to see if the NetworkBindings property is set.
        /// </summary>
        internal bool IsSetNetworkBindings() => this.NetworkBindings != null && (this.NetworkBindings.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property NetworkInterfaces. 
        /// <para>
        /// The network interfaces associated with the container.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<NetworkInterface> NetworkInterfaces { get; set; } = AWSConfigs.InitializeCollections ? new List<NetworkInterface>() : null;

        /// <summary>
        /// Checks to see if the NetworkInterfaces property is set.
        /// </summary>
        internal bool IsSetNetworkInterfaces() => this.NetworkInterfaces != null && (this.NetworkInterfaces.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property NeuronDeviceIds. 
        /// <para>
        /// The IDs of each Neuron device assigned to the container.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> NeuronDeviceIds { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the NeuronDeviceIds property is set.
        /// </summary>
        internal bool IsSetNeuronDeviceIds() => this.NeuronDeviceIds != null && (this.NeuronDeviceIds.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Reason. 
        /// <para>
        /// A short (1024 max characters) human-readable string to provide additional details
        /// about a running or stopped container.
        /// </para>
        /// </summary>
        public string Reason { get; set; }

        /// <summary>
        /// Checks to see if the Reason property is set.
        /// </summary>
        internal bool IsSetReason() => this.Reason != null;

        /// <summary>
        /// Gets and sets the property RuntimeId. 
        /// <para>
        /// The ID of the Docker container.
        /// </para>
        /// </summary>
        public string RuntimeId { get; set; }

        /// <summary>
        /// Checks to see if the RuntimeId property is set.
        /// </summary>
        internal bool IsSetRuntimeId() => this.RuntimeId != null;

        /// <summary>
        /// Gets and sets the property TaskArn. 
        /// <para>
        /// The ARN of the task.
        /// </para>
        /// </summary>
        public string TaskArn { get; set; }

        /// <summary>
        /// Checks to see if the TaskArn property is set.
        /// </summary>
        internal bool IsSetTaskArn() => this.TaskArn != null;
    }
}
