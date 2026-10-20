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
    /// A container definition for a daemon task. Daemon container definitions describe the
    /// containers that run as part of a daemon task on container instances managed by capacity
    /// providers.
    /// </summary>
    public partial class DaemonContainerDefinition
    {
        /// <summary>
        /// Gets and sets the property Command. 
        /// <para>
        /// The command that's passed to the container.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Command { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Command property is set.
        /// </summary>
        internal bool IsSetCommand() => this.Command != null && (this.Command.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Cpu. 
        /// <para>
        /// The number of <c>cpu</c> units reserved for the container.
        /// </para>
        /// </summary>
        public int? Cpu { get; set; }

        /// <summary>
        /// Checks to see if the Cpu property is set.
        /// </summary>
        internal bool IsSetCpu() => this.Cpu.HasValue;

        /// <summary>
        /// Gets and sets the property DependsOn. 
        /// <para>
        /// The dependencies defined for container startup and shutdown. A container can contain
        /// multiple dependencies on other containers in a task definition.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ContainerDependency> DependsOn { get; set; } = AWSConfigs.InitializeCollections ? new List<ContainerDependency>() : null;

        /// <summary>
        /// Checks to see if the DependsOn property is set.
        /// </summary>
        internal bool IsSetDependsOn() => this.DependsOn != null && (this.DependsOn.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property EntryPoint. 
        /// <para>
        /// The entry point that's passed to the container.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> EntryPoint { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the EntryPoint property is set.
        /// </summary>
        internal bool IsSetEntryPoint() => this.EntryPoint != null && (this.EntryPoint.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Environment. 
        /// <para>
        /// The environment variables to pass to a container.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public List<KeyValuePair> Environment { get; set; } = AWSConfigs.InitializeCollections ? new List<KeyValuePair>() : null;

        /// <summary>
        /// Checks to see if the Environment property is set.
        /// </summary>
        internal bool IsSetEnvironment() => this.Environment != null && (this.Environment.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property EnvironmentFiles. 
        /// <para>
        /// A list of files containing the environment variables to pass to a container.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<EnvironmentFile> EnvironmentFiles { get; set; } = AWSConfigs.InitializeCollections ? new List<EnvironmentFile>() : null;

        /// <summary>
        /// Checks to see if the EnvironmentFiles property is set.
        /// </summary>
        internal bool IsSetEnvironmentFiles() => this.EnvironmentFiles != null && (this.EnvironmentFiles.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Essential. 
        /// <para>
        /// If the <c>essential</c> parameter of a container is marked as <c>true</c>, and that
        /// container fails or stops for any reason, all other containers that are part of the
        /// task are stopped.
        /// </para>
        /// </summary>
        public bool? Essential { get; set; }

        /// <summary>
        /// Checks to see if the Essential property is set.
        /// </summary>
        internal bool IsSetEssential() => this.Essential.HasValue;

        /// <summary>
        /// Gets and sets the property FirelensConfiguration. 
        /// <para>
        /// The FireLens configuration for the container. This is used to specify and configure
        /// a log router for container logs.
        /// </para>
        /// </summary>
        public FirelensConfiguration FirelensConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the FirelensConfiguration property is set.
        /// </summary>
        internal bool IsSetFirelensConfiguration() => this.FirelensConfiguration != null;

        /// <summary>
        /// Gets and sets the property HealthCheck. 
        /// <para>
        /// The container health check command and associated configuration parameters for the
        /// container.
        /// </para>
        /// </summary>
        public HealthCheck HealthCheck { get; set; }

        /// <summary>
        /// Checks to see if the HealthCheck property is set.
        /// </summary>
        internal bool IsSetHealthCheck() => this.HealthCheck != null;

        /// <summary>
        /// Gets and sets the property Image. 
        /// <para>
        /// The image used to start the container. This string is passed directly to the Docker
        /// daemon. Images in the Docker Hub registry are available by default. Other repositories
        /// are specified with either <c> <i>repository-url</i>/<i>image</i>:<i>tag</i> </c> or
        /// <c> <i>repository-url</i>/<i>image</i>@<i>digest</i> </c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Image { get; set; }

        /// <summary>
        /// Checks to see if the Image property is set.
        /// </summary>
        internal bool IsSetImage() => this.Image != null;

        /// <summary>
        /// Gets and sets the property Interactive. 
        /// <para>
        /// When this parameter is <c>true</c>, you can deploy containerized applications that
        /// require <c>stdin</c> or a <c>tty</c> to be allocated.
        /// </para>
        /// </summary>
        public bool? Interactive { get; set; }

        /// <summary>
        /// Checks to see if the Interactive property is set.
        /// </summary>
        internal bool IsSetInteractive() => this.Interactive.HasValue;

        /// <summary>
        /// Gets and sets the property LinuxParameters. 
        /// <para>
        /// Linux-specific modifications that are applied to the container configuration, such
        /// as Linux kernel capabilities.
        /// </para>
        /// </summary>
        public DaemonLinuxParameters LinuxParameters { get; set; }

        /// <summary>
        /// Checks to see if the LinuxParameters property is set.
        /// </summary>
        internal bool IsSetLinuxParameters() => this.LinuxParameters != null;

        /// <summary>
        /// Gets and sets the property LogConfiguration. 
        /// <para>
        /// The log configuration specification for the container.
        /// </para>
        /// </summary>
        public LogConfiguration LogConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the LogConfiguration property is set.
        /// </summary>
        internal bool IsSetLogConfiguration() => this.LogConfiguration != null;

        /// <summary>
        /// Gets and sets the property Memory. 
        /// <para>
        /// The amount (in MiB) of memory to present to the container. If the container attempts
        /// to exceed the memory specified here, the container is killed.
        /// </para>
        /// </summary>
        public int? Memory { get; set; }

        /// <summary>
        /// Checks to see if the Memory property is set.
        /// </summary>
        internal bool IsSetMemory() => this.Memory.HasValue;

        /// <summary>
        /// Gets and sets the property MemoryReservation. 
        /// <para>
        /// The soft limit (in MiB) of memory to reserve for the container.
        /// </para>
        /// </summary>
        public int? MemoryReservation { get; set; }

        /// <summary>
        /// Checks to see if the MemoryReservation property is set.
        /// </summary>
        internal bool IsSetMemoryReservation() => this.MemoryReservation.HasValue;

        /// <summary>
        /// Gets and sets the property MountPoints. 
        /// <para>
        /// The mount points for data volumes in your container.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<MountPoint> MountPoints { get; set; } = AWSConfigs.InitializeCollections ? new List<MountPoint>() : null;

        /// <summary>
        /// Checks to see if the MountPoints property is set.
        /// </summary>
        internal bool IsSetMountPoints() => this.MountPoints != null && (this.MountPoints.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the container. Up to 255 letters (uppercase and lowercase), numbers, underscores,
        /// and hyphens are allowed.
        /// </para>
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Privileged. 
        /// <para>
        /// When this parameter is true, the container is given elevated privileges on the host
        /// container instance (similar to the <c>root</c> user).
        /// </para>
        /// </summary>
        public bool? Privileged { get; set; }

        /// <summary>
        /// Checks to see if the Privileged property is set.
        /// </summary>
        internal bool IsSetPrivileged() => this.Privileged.HasValue;

        /// <summary>
        /// Gets and sets the property PseudoTerminal. 
        /// <para>
        /// When this parameter is <c>true</c>, a TTY is allocated.
        /// </para>
        /// </summary>
        public bool? PseudoTerminal { get; set; }

        /// <summary>
        /// Checks to see if the PseudoTerminal property is set.
        /// </summary>
        internal bool IsSetPseudoTerminal() => this.PseudoTerminal.HasValue;

        /// <summary>
        /// Gets and sets the property ReadonlyRootFilesystem. 
        /// <para>
        /// When this parameter is true, the container is given read-only access to its root file
        /// system.
        /// </para>
        /// </summary>
        public bool? ReadonlyRootFilesystem { get; set; }

        /// <summary>
        /// Checks to see if the ReadonlyRootFilesystem property is set.
        /// </summary>
        internal bool IsSetReadonlyRootFilesystem() => this.ReadonlyRootFilesystem.HasValue;

        /// <summary>
        /// Gets and sets the property RepositoryCredentials. 
        /// <para>
        /// The private repository authentication credentials to use.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public RepositoryCredentials RepositoryCredentials { get; set; }

        /// <summary>
        /// Checks to see if the RepositoryCredentials property is set.
        /// </summary>
        internal bool IsSetRepositoryCredentials() => this.RepositoryCredentials != null;

        /// <summary>
        /// Gets and sets the property RestartPolicy. 
        /// <para>
        /// The restart policy for the container. When you set up a restart policy, Amazon ECS
        /// can restart the container without needing to replace the task.
        /// </para>
        /// </summary>
        public ContainerRestartPolicy RestartPolicy { get; set; }

        /// <summary>
        /// Checks to see if the RestartPolicy property is set.
        /// </summary>
        internal bool IsSetRestartPolicy() => this.RestartPolicy != null;

        /// <summary>
        /// Gets and sets the property Secrets. 
        /// <para>
        /// The secrets to pass to the container.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Secret> Secrets { get; set; } = AWSConfigs.InitializeCollections ? new List<Secret>() : null;

        /// <summary>
        /// Checks to see if the Secrets property is set.
        /// </summary>
        internal bool IsSetSecrets() => this.Secrets != null && (this.Secrets.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property StartTimeout. 
        /// <para>
        /// Time duration (in seconds) to wait before giving up on resolving dependencies for
        /// a container.
        /// </para>
        /// </summary>
        public int? StartTimeout { get; set; }

        /// <summary>
        /// Checks to see if the StartTimeout property is set.
        /// </summary>
        internal bool IsSetStartTimeout() => this.StartTimeout.HasValue;

        /// <summary>
        /// Gets and sets the property StopTimeout. 
        /// <para>
        /// Time duration (in seconds) to wait before the container is forcefully killed if it
        /// doesn't exit normally on its own.
        /// </para>
        /// </summary>
        public int? StopTimeout { get; set; }

        /// <summary>
        /// Checks to see if the StopTimeout property is set.
        /// </summary>
        internal bool IsSetStopTimeout() => this.StopTimeout.HasValue;

        /// <summary>
        /// Gets and sets the property SystemControls. 
        /// <para>
        /// A list of namespaced kernel parameters to set in the container.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<SystemControl> SystemControls { get; set; } = AWSConfigs.InitializeCollections ? new List<SystemControl>() : null;

        /// <summary>
        /// Checks to see if the SystemControls property is set.
        /// </summary>
        internal bool IsSetSystemControls() => this.SystemControls != null && (this.SystemControls.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Ulimits. 
        /// <para>
        /// A list of <c>ulimits</c> to set in the container.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Ulimit> Ulimits { get; set; } = AWSConfigs.InitializeCollections ? new List<Ulimit>() : null;

        /// <summary>
        /// Checks to see if the Ulimits property is set.
        /// </summary>
        internal bool IsSetUlimits() => this.Ulimits != null && (this.Ulimits.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property User. 
        /// <para>
        /// The user to use inside the container.
        /// </para>
        /// </summary>
        public string User { get; set; }

        /// <summary>
        /// Checks to see if the User property is set.
        /// </summary>
        internal bool IsSetUser() => this.User != null;

        /// <summary>
        /// Gets and sets the property WorkingDirectory. 
        /// <para>
        /// The working directory to run commands inside the container in.
        /// </para>
        /// </summary>
        public string WorkingDirectory { get; set; }

        /// <summary>
        /// Checks to see if the WorkingDirectory property is set.
        /// </summary>
        internal bool IsSetWorkingDirectory() => this.WorkingDirectory != null;
    }
}
