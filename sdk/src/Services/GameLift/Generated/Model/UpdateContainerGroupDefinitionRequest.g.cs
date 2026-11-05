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

namespace Amazon.GameLift.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateContainerGroupDefinition operation. <b>This
    /// API works with the following fleet types:</b> Container <para> Updates properties
    /// in an existing container group definition. This operation doesn't replace the definition.
    /// Instead, it creates a new version of the definition and saves it separately. You can
    /// access all versions that you choose to retain. </para> <para> The only property you
    /// can't update is the container group type. </para> <para> <b>Request options:</b> </para>
    /// <ul> <li> <para> Update based on the latest version of the container group definition.
    /// Specify the container group definition name only, or use an ARN value without a version
    /// number. Provide updated values for the properties that you want to change only. All
    /// other values remain the same as the latest version. </para> </li> <li> <para> Update
    /// based on a specific version of the container group definition. Specify the container
    /// group definition name and a source version number, or use an ARN value with a version
    /// number. Provide updated values for the properties that you want to change only. All
    /// other values remain the same as the source version. </para> </li> <li> <para> Change
    /// a game server container definition. Provide a complete set of container definitions,
    /// including the updated definition. </para> </li> <li> <para> Add or change a support
    /// container definition. Provide a complete set of container definitions, including the
    /// updated definition. </para> </li> <li> <para> Remove a support container definition.
    /// Provide a complete set of container definitions, excluding the definition to remove.
    /// If the container group has only one support container definition, provide an empty
    /// set. </para> </li> <li> <para> Remove the total vCPU limit from a game server container
    /// group so that its containers can use up to the instance's available vCPU. Set <c>RemoveAttributes</c>
    /// to <c>TOTAL_VCPU_LIMIT</c>. The game server container must have a <c>Vcpu</c> value,
    /// because a game server container group needs either a total vCPU limit or a game server
    /// <c>Vcpu</c> value. </para> </li> </ul> <para> <b>Results:</b> </para> <para> If successful,
    /// this operation returns the complete properties of the new container group definition
    /// version. </para> <para> If the container group definition version is used in an active
    /// fleet, the update automatically initiates a new fleet deployment of the new version.
    /// You can track a fleet's deployments using <a href="https://docs.aws.amazon.com/gamelift/latest/apireference/API_ListFleetDeployments.html">ListFleetDeployments</a>.
    /// </para>
    /// </summary>
    public partial class UpdateContainerGroupDefinitionRequest : AmazonGameLiftRequest
    {
        /// <summary>
        /// Gets and sets the property GameServerContainerDefinition. 
        /// <para>
        /// An updated definition for the game server container in this group. Define a game server
        /// container only when the container group type is <c>GAME_SERVER</c>. You can pass in
        /// your container definitions as a JSON file.
        /// </para>
        /// </summary>
        public GameServerContainerDefinitionInput GameServerContainerDefinition { get; set; }

        /// <summary>
        /// Checks to see if the GameServerContainerDefinition property is set.
        /// </summary>
        internal bool IsSetGameServerContainerDefinition() => this.GameServerContainerDefinition != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// A descriptive identifier for the container group definition. The name value must be
        /// unique in an Amazon Web Services Region.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 512)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property OperatingSystem. 
        /// <para>
        /// The platform that all containers in the group use. Containers in a group must run
        /// on the same operating system.
        /// </para>
        ///  <note> 
        /// <para>
        /// Amazon Linux 2 (AL2) will reach end of support on 6/30/2026. See more details in the
        /// <a href="http://aws.amazon.com/amazon-linux-2/faqs/">Amazon Linux 2 FAQs</a>. For
        /// game servers that are hosted on AL2 and use server SDK version 4.x for Amazon GameLift
        /// Servers, first update the game server build to server SDK 5.x, and then deploy to
        /// AL2023 instances. See <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/reference-serversdk5-migration.html">
        /// Migrate to server SDK version 5.</a> 
        /// </para>
        ///  </note>
        /// </summary>
        public ContainerOperatingSystem OperatingSystem { get; set; }

        /// <summary>
        /// Checks to see if the OperatingSystem property is set.
        /// </summary>
        internal bool IsSetOperatingSystem() => this.OperatingSystem != null;

        /// <summary>
        /// Gets and sets the property RemoveAttributes. 
        /// <para>
        /// If set, this update removes the container group's total vCPU limit, and the group's
        /// containers can use up to the instance's available vCPU. You can't remove the total
        /// vCPU limit from a per-instance container group. A game server container group needs
        /// either a total vCPU limit or a <c>Vcpu</c> value for the game server container. You
        /// can't set <c>TotalVcpuLimit</c> in the same request.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 1)]
        public List<string> RemoveAttributes { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the RemoveAttributes property is set.
        /// </summary>
        internal bool IsSetRemoveAttributes() => this.RemoveAttributes != null && (this.RemoveAttributes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SourceVersionNumber. 
        /// <para>
        /// The container group definition version to update. The new version starts with values
        /// from the source version, and then updates values included in this request. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public int? SourceVersionNumber { get; set; }

        /// <summary>
        /// Checks to see if the SourceVersionNumber property is set.
        /// </summary>
        internal bool IsSetSourceVersionNumber() => this.SourceVersionNumber.HasValue;

        /// <summary>
        /// Gets and sets the property SupportContainerDefinitions. 
        /// <para>
        /// One or more definitions for support containers in this group. You can define a support
        /// container in any type of container group. You can pass in your container definitions
        /// as a JSON file.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 10)]
        public List<SupportContainerDefinitionInput> SupportContainerDefinitions { get; set; } = AWSConfigs.InitializeCollections ? new List<SupportContainerDefinitionInput>() : null;

        /// <summary>
        /// Checks to see if the SupportContainerDefinitions property is set.
        /// </summary>
        internal bool IsSetSupportContainerDefinitions() => this.SupportContainerDefinitions != null && (this.SupportContainerDefinitions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TotalMemoryLimitMebibytes. 
        /// <para>
        /// The maximum amount of memory (in MiB) to allocate to the container group. All containers
        /// in the group share this memory. If you specify memory limits for an individual container,
        /// the total value must be greater than any individual container's memory limit.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 4, Max = 1024000)]
        public int? TotalMemoryLimitMebibytes { get; set; }

        /// <summary>
        /// Checks to see if the TotalMemoryLimitMebibytes property is set.
        /// </summary>
        internal bool IsSetTotalMemoryLimitMebibytes() => this.TotalMemoryLimitMebibytes.HasValue;

        /// <summary>
        /// Gets and sets the property TotalVcpuLimit. 
        /// <para>
        /// The maximum amount of vCPU units to allocate to the container group (1 vCPU is equal
        /// to 1024 CPU units). All containers in the group share these resources. If you set
        /// vCPU reservations for individual containers, the total value must be equal to or greater
        /// than the sum of the <c>Vcpu</c> values for all containers in the group.
        /// </para>
        ///  
        /// <para>
        /// For a game server container group, Amazon GameLift Servers requires either a total
        /// vCPU limit or a <c>Vcpu</c> value for the game server container. If the container
        /// group has a total vCPU limit, Amazon GameLift Servers uses this value to calculate
        /// how many game server container groups fit on an instance. If the container group doesn't
        /// have a total vCPU limit, its containers can use up to the instance's available vCPU,
        /// and Amazon GameLift Servers uses the sum of the containers' <c>Vcpu</c> values to
        /// calculate how many game server container groups fit on an instance. To remove the
        /// total vCPU limit, omit this parameter and set <c>RemoveAttributes</c> to <c>TOTAL_VCPU_LIMIT</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Max = 10)]
        public double? TotalVcpuLimit { get; set; }

        /// <summary>
        /// Checks to see if the TotalVcpuLimit property is set.
        /// </summary>
        internal bool IsSetTotalVcpuLimit() => this.TotalVcpuLimit.HasValue;

        /// <summary>
        /// Gets and sets the property VersionDescription. 
        /// <para>
        /// A description for this update to the container group definition. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string VersionDescription { get; set; }

        /// <summary>
        /// Checks to see if the VersionDescription property is set.
        /// </summary>
        internal bool IsSetVersionDescription() => this.VersionDescription != null;
    }
}
