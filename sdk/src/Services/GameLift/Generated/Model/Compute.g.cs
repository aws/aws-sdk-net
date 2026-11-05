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
    /// An Amazon GameLift Servers compute resource for hosting your game servers. Computes
    /// in an Amazon GameLift Servers fleet differ depending on the fleet's compute type property
    /// as follows: 
    /// 
    ///  <ul> <li> 
    /// <para>
    /// For managed EC2 fleets, a compute is an EC2 instance.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// For Anywhere fleets, a compute is a computing resource that you provide and is registered
    /// to the fleet.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class Compute
    {
        /// <summary>
        /// Gets and sets the property ComputeArn. 
        /// <para>
        /// The ARN that is assigned to a compute resource and uniquely identifies it. ARNs are
        /// unique across locations. Instances in managed EC2 fleets are not assigned a Compute
        /// ARN.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string ComputeArn { get; set; }

        /// <summary>
        /// Checks to see if the ComputeArn property is set.
        /// </summary>
        internal bool IsSetComputeArn() => this.ComputeArn != null;

        /// <summary>
        /// Gets and sets the property ComputeName. 
        /// <para>
        /// A descriptive label for the compute resource. For instances in a managed EC2 fleet,
        /// the compute name is the same value as the <c>InstanceId</c> ID.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string ComputeName { get; set; }

        /// <summary>
        /// Checks to see if the ComputeName property is set.
        /// </summary>
        internal bool IsSetComputeName() => this.ComputeName != null;

        /// <summary>
        /// Gets and sets the property ComputeStatus. 
        /// <para>
        /// Current status of the compute. A compute must have an <c>ACTIVE</c> status to host
        /// game sessions. Valid values include <c>PENDING</c>, <c>ACTIVE</c>, <c>TERMINATING</c>,
        /// and <c>IMPAIRED</c>.
        /// </para>
        ///  <note> 
        /// <para>
        /// While the ComputeStatus enum type is valid for Container based servers, the result
        /// may also include other non-enumerated string values such as "Active" for fleets which
        /// are not Container-based.
        /// </para>
        ///  </note>
        /// </summary>
        public ComputeStatus ComputeStatus { get; set; }

        /// <summary>
        /// Checks to see if the ComputeStatus property is set.
        /// </summary>
        internal bool IsSetComputeStatus() => this.ComputeStatus != null;

        /// <summary>
        /// Gets and sets the property ContainerAttributes. 
        /// <para>
        /// A set of attributes for each container in the compute. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 10)]
        public List<ContainerAttribute> ContainerAttributes { get; set; } = AWSConfigs.InitializeCollections ? new List<ContainerAttribute>() : null;

        /// <summary>
        /// Checks to see if the ContainerAttributes property is set.
        /// </summary>
        internal bool IsSetContainerAttributes() => this.ContainerAttributes != null && (this.ContainerAttributes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// A time stamp indicating when this data object was created. Format is a number expressed
        /// in Unix time as milliseconds (for example <c>"1469498468.057"</c>).
        /// </para>
        /// </summary>
        public DateTime? CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime.HasValue;

        /// <summary>
        /// Gets and sets the property DnsName. 
        /// <para>
        /// The DNS name of a compute resource. Amazon GameLift Servers requires a DNS name or
        /// IP address for a compute.
        /// </para>
        /// </summary>
        public string DnsName { get; set; }

        /// <summary>
        /// Checks to see if the DnsName property is set.
        /// </summary>
        internal bool IsSetDnsName() => this.DnsName != null;

        /// <summary>
        /// Gets and sets the property FleetArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the fleet that the compute belongs to.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 512)]
        public string FleetArn { get; set; }

        /// <summary>
        /// Checks to see if the FleetArn property is set.
        /// </summary>
        internal bool IsSetFleetArn() => this.FleetArn != null;

        /// <summary>
        /// Gets and sets the property FleetId. 
        /// <para>
        /// A unique identifier for the fleet that the compute belongs to.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string FleetId { get; set; }

        /// <summary>
        /// Checks to see if the FleetId property is set.
        /// </summary>
        internal bool IsSetFleetId() => this.FleetId != null;

        /// <summary>
        /// Gets and sets the property GameLiftAgentEndpoint. 
        /// <para>
        ///  The endpoint of the Amazon GameLift Servers Agent. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string GameLiftAgentEndpoint { get; set; }

        /// <summary>
        /// Checks to see if the GameLiftAgentEndpoint property is set.
        /// </summary>
        internal bool IsSetGameLiftAgentEndpoint() => this.GameLiftAgentEndpoint != null;

        /// <summary>
        /// Gets and sets the property GameLiftServiceSdkEndpoint. 
        /// <para>
        /// The Amazon GameLift Servers SDK endpoint connection for a registered compute resource
        /// in an Anywhere fleet. The game servers on the compute use this endpoint to connect
        /// to the Amazon GameLift Servers service.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string GameLiftServiceSdkEndpoint { get; set; }

        /// <summary>
        /// Checks to see if the GameLiftServiceSdkEndpoint property is set.
        /// </summary>
        internal bool IsSetGameLiftServiceSdkEndpoint() => this.GameLiftServiceSdkEndpoint != null;

        /// <summary>
        /// Gets and sets the property GameServerContainerGroupDefinitionArn. 
        /// <para>
        /// The game server container group definition for the compute.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 512)]
        public string GameServerContainerGroupDefinitionArn { get; set; }

        /// <summary>
        /// Checks to see if the GameServerContainerGroupDefinitionArn property is set.
        /// </summary>
        internal bool IsSetGameServerContainerGroupDefinitionArn() => this.GameServerContainerGroupDefinitionArn != null;

        /// <summary>
        /// Gets and sets the property InstanceId. 
        /// <para>
        ///  The <c>InstanceID</c> of the EC2 instance that is hosting the compute. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string InstanceId { get; set; }

        /// <summary>
        /// Checks to see if the InstanceId property is set.
        /// </summary>
        internal bool IsSetInstanceId() => this.InstanceId != null;

        /// <summary>
        /// Gets and sets the property IpAddress. 
        /// <para>
        /// The IP address of a compute resource. Amazon GameLift Servers requires a DNS name
        /// or IP address for a compute.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 128)]
        public string IpAddress { get; set; }

        /// <summary>
        /// Checks to see if the IpAddress property is set.
        /// </summary>
        internal bool IsSetIpAddress() => this.IpAddress != null;

        /// <summary>
        /// Gets and sets the property Location. 
        /// <para>
        /// The name of the custom location you added to the fleet that this compute resource
        /// resides in.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string Location { get; set; }

        /// <summary>
        /// Checks to see if the Location property is set.
        /// </summary>
        internal bool IsSetLocation() => this.Location != null;

        /// <summary>
        /// Gets and sets the property OperatingSystem. 
        /// <para>
        /// The type of operating system on the compute resource.
        /// </para>
        ///  <note> 
        /// <para>
        /// Amazon Linux 2 (AL2) will reach end of support on 6/30/2026. See more details in the
        /// <a href="http://aws.amazon.com/aws.amazon.com/amazon-linux-2/faqs/">Amazon Linux 2
        /// FAQs</a>. For game servers that are hosted on AL2 and use server SDK version 4.x for
        /// Amazon GameLift Servers, first update the game server build to server SDK 5.x, and
        /// then deploy to AL2023 instances. See <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/reference-serversdk5-migration.html">
        /// Migrate to server SDK version 5.</a> 
        /// </para>
        ///  </note>
        /// </summary>
        public OperatingSystem OperatingSystem { get; set; }

        /// <summary>
        /// Checks to see if the OperatingSystem property is set.
        /// </summary>
        internal bool IsSetOperatingSystem() => this.OperatingSystem != null;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The Amazon EC2 instance type that the fleet uses. For registered computes in an Amazon
        /// GameLift Servers Anywhere fleet, this property is empty. 
        /// </para>
        /// </summary>
        public EC2InstanceType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}
