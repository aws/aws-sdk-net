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

namespace Amazon.Pipes.Model
{
    /// <summary>
    /// The overrides that are sent to a container. An empty container override can be passed
    /// in. An example of an empty container override is <c>{"containerOverrides": [ ] }</c>.
    /// If a non-empty container override is specified, the <c>name</c> parameter must be
    /// included.
    /// </summary>
    public partial class EcsContainerOverride
    {
        /// <summary>
        /// Gets and sets the property Command. 
        /// <para>
        /// The command to send to the container that overrides the default command from the Docker
        /// image or the task definition. You must also specify a container name.
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
        /// The number of <c>cpu</c> units reserved for the container, instead of the default
        /// value from the task definition. You must also specify a container name.
        /// </para>
        /// </summary>
        public int? Cpu { get; set; }

        /// <summary>
        /// Checks to see if the Cpu property is set.
        /// </summary>
        internal bool IsSetCpu() => this.Cpu.HasValue;

        /// <summary>
        /// Gets and sets the property Environment. 
        /// <para>
        /// The environment variables to send to the container. You can add new environment variables,
        /// which are added to the container at launch, or you can override the existing environment
        /// variables from the Docker image or the task definition. You must also specify a container
        /// name.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<EcsEnvironmentVariable> Environment { get; set; } = AWSConfigs.InitializeCollections ? new List<EcsEnvironmentVariable>() : null;

        /// <summary>
        /// Checks to see if the Environment property is set.
        /// </summary>
        internal bool IsSetEnvironment() => this.Environment != null && (this.Environment.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property EnvironmentFiles. 
        /// <para>
        /// A list of files containing the environment variables to pass to a container, instead
        /// of the value from the container definition.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<EcsEnvironmentFile> EnvironmentFiles { get; set; } = AWSConfigs.InitializeCollections ? new List<EcsEnvironmentFile>() : null;

        /// <summary>
        /// Checks to see if the EnvironmentFiles property is set.
        /// </summary>
        internal bool IsSetEnvironmentFiles() => this.EnvironmentFiles != null && (this.EnvironmentFiles.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Memory. 
        /// <para>
        /// The hard limit (in MiB) of memory to present to the container, instead of the default
        /// value from the task definition. If your container attempts to exceed the memory specified
        /// here, the container is killed. You must also specify a container name.
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
        /// The soft limit (in MiB) of memory to reserve for the container, instead of the default
        /// value from the task definition. You must also specify a container name.
        /// </para>
        /// </summary>
        public int? MemoryReservation { get; set; }

        /// <summary>
        /// Checks to see if the MemoryReservation property is set.
        /// </summary>
        internal bool IsSetMemoryReservation() => this.MemoryReservation.HasValue;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the container that receives the override. This parameter is required if
        /// any override is specified.
        /// </para>
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property ResourceRequirements. 
        /// <para>
        /// The type and amount of a resource to assign to a container, instead of the default
        /// value from the task definition. The only supported resource is a GPU.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<EcsResourceRequirement> ResourceRequirements { get; set; } = AWSConfigs.InitializeCollections ? new List<EcsResourceRequirement>() : null;

        /// <summary>
        /// Checks to see if the ResourceRequirements property is set.
        /// </summary>
        internal bool IsSetResourceRequirements() => this.ResourceRequirements != null && (this.ResourceRequirements.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
