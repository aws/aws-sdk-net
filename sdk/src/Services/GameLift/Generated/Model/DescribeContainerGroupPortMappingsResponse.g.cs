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
    /// This is the response object from the DescribeContainerGroupPortMappings operation.
    /// </summary>
    public partial class DescribeContainerGroupPortMappingsResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property ComputeName. 
        /// <para>
        /// A unique identifier for the compute resource running the game server container group.
        /// Returned when <c>ContainerGroupType</c> is <c>GAME_SERVER</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string ComputeName { get; set; }

        /// <summary>
        /// Checks to see if the ComputeName property is set.
        /// </summary>
        internal bool IsSetComputeName() => this.ComputeName != null;

        /// <summary>
        /// Gets and sets the property ContainerGroupDefinitionArn. 
        /// <para>
        /// The Amazon Resource Name (<a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/s3-arn-format.html">ARN</a>)
        /// that is assigned to the container group definition. The ARN value also identifies
        /// the specific container group definition version in use.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 512)]
        public string ContainerGroupDefinitionArn { get; set; }

        /// <summary>
        /// Checks to see if the ContainerGroupDefinitionArn property is set.
        /// </summary>
        internal bool IsSetContainerGroupDefinitionArn() => this.ContainerGroupDefinitionArn != null;

        /// <summary>
        /// Gets and sets the property ContainerGroupPortMappings. 
        /// <para>
        /// A list of <c>ContainerGroupPortMapping</c> objects that describe the port mappings
        /// for each container in the container group.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ContainerGroupPortMapping> ContainerGroupPortMappings { get; set; } = AWSConfigs.InitializeCollections ? new List<ContainerGroupPortMapping>() : null;

        /// <summary>
        /// Checks to see if the ContainerGroupPortMappings property is set.
        /// </summary>
        internal bool IsSetContainerGroupPortMappings() => this.ContainerGroupPortMappings != null && (this.ContainerGroupPortMappings.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ContainerGroupType. 
        /// <para>
        /// The type of container group that was specified in the request. Valid values are <c>GAME_SERVER</c>
        /// or <c>PER_INSTANCE</c>.
        /// </para>
        /// </summary>
        public ContainerGroupType ContainerGroupType { get; set; }

        /// <summary>
        /// Checks to see if the ContainerGroupType property is set.
        /// </summary>
        internal bool IsSetContainerGroupType() => this.ContainerGroupType != null;

        /// <summary>
        /// Gets and sets the property FleetArn. 
        /// <para>
        /// The Amazon Resource Name (<a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/s3-arn-format.html">ARN</a>)
        /// that is assigned to a Amazon GameLift Servers fleet resource and uniquely identifies
        /// it. ARNs are unique across all Regions. Format is <c>arn:aws:gamelift:&lt;region&gt;::fleet/fleet-a1234567-b8c9-0d1e-2fa3-b45c6d7e8912</c>.
        /// In a GameLift fleet ARN, the resource ID matches the <c>FleetId</c> value.
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
        /// A unique identifier for the container fleet.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string FleetId { get; set; }

        /// <summary>
        /// Checks to see if the FleetId property is set.
        /// </summary>
        internal bool IsSetFleetId() => this.FleetId != null;

        /// <summary>
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// A unique identifier for the fleet instance. For <c>GAME_SERVER</c> requests, this
        /// is the instance running the specified compute. For <c>PER_INSTANCE</c> requests, this
        /// is the instance specified in the request.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string InstanceId { get; set; }

        /// <summary>
        /// Checks to see if the InstanceId property is set.
        /// </summary>
        internal bool IsSetInstanceId() => this.InstanceId != null;

        /// <summary>
        /// Gets and sets the property Location. 
        /// <para>
        /// The location of the fleet instance, expressed as an Amazon Web Services Region code,
        /// such as <c>us-west-2</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string Location { get; set; }

        /// <summary>
        /// Checks to see if the Location property is set.
        /// </summary>
        internal bool IsSetLocation() => this.Location != null;
    }
}
