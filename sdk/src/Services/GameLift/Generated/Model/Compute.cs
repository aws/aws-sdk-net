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
 * Do not modify this file. This file is generated from the gamelift-2015-10-01.normal.json service model.
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
    /// in an Amazon GameLift Servers fleet differs depending on the fleet's compute type
    /// property as follows: 
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
        private string _computeArn;
        private string _computeName;
        private ComputeStatus _computeStatus;
        private List<ContainerAttribute> _containerAttributes = AWSConfigs.InitializeCollections ? new List<ContainerAttribute>() : null;
        private DateTime? _creationTime;
        private string _dnsName;
        private string _fleetArn;
        private string _fleetId;
        private string _gameLiftAgentEndpoint;
        private string _gameLiftServiceSdkEndpoint;
        private string _gameServerContainerGroupDefinitionArn;
        private string _instanceId;
        private string _ipAddress;
        private string _location;
        private OperatingSystem _operatingSystem;
        private EC2InstanceType _type;

        /// <summary>
        /// Gets and sets the property ComputeArn. 
        /// <para>
        /// The ARN that is assigned to a compute resource and uniquely identifies it. ARNs are
        /// unique across locations. Instances in managed EC2 fleets are not assigned a Compute
        /// ARN.
        /// </para>
        /// </summary>
        [AWSProperty(Max=1024)]
        public string ComputeArn
        {
            get { return this._computeArn; }
            set { this._computeArn = value; }
        }

        // Check to see if ComputeArn property is set
        internal bool IsSetComputeArn()
        {
            return this._computeArn != null;
        }

        /// <summary>
        /// Gets and sets the property ComputeName. 
        /// <para>
        /// A descriptive label for the compute resource. For instances in a managed EC2 fleet,
        /// the compute name is the same value as the <c>InstanceId</c> ID.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string ComputeName
        {
            get { return this._computeName; }
            set { this._computeName = value; }
        }

        // Check to see if ComputeName property is set
        internal bool IsSetComputeName()
        {
            return this._computeName != null;
        }

        /// <summary>
        /// Gets and sets the property ComputeStatus. 
        /// <para>
        /// Current status of the compute. A compute must have an <c>ACTIVE</c> status to host
        /// game sessions.
        /// </para>
        /// </summary>
        public ComputeStatus ComputeStatus
        {
            get { return this._computeStatus; }
            set { this._computeStatus = value; }
        }

        // Check to see if ComputeStatus property is set
        internal bool IsSetComputeStatus()
        {
            return this._computeStatus != null;
        }

        /// <summary>
        /// Gets and sets the property ContainerAttributes. 
        /// <para>
        /// A set of attributes for each container in the compute. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public List<ContainerAttribute> ContainerAttributes
        {
            get { return this._containerAttributes; }
            set { this._containerAttributes = value; }
        }

        // Check to see if ContainerAttributes property is set
        internal bool IsSetContainerAttributes()
        {
            return this._containerAttributes != null && (this._containerAttributes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// A time stamp indicating when this data object was created. Format is a number expressed
        /// in Unix time as milliseconds (for example <c>"1469498468.057"</c>).
        /// </para>
        /// </summary>
        public DateTime? CreationTime
        {
            get { return this._creationTime; }
            set { this._creationTime = value; }
        }

        // Check to see if CreationTime property is set
        internal bool IsSetCreationTime()
        {
            return this._creationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DnsName. 
        /// <para>
        /// The DNS name of a compute resource. Amazon GameLift Servers requires a DNS name or
        /// IP address for a compute.
        /// </para>
        /// </summary>
        public string DnsName
        {
            get { return this._dnsName; }
            set { this._dnsName = value; }
        }

        // Check to see if DnsName property is set
        internal bool IsSetDnsName()
        {
            return this._dnsName != null;
        }

        /// <summary>
        /// Gets and sets the property FleetArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the fleet that the compute belongs to.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=512)]
        public string FleetArn
        {
            get { return this._fleetArn; }
            set { this._fleetArn = value; }
        }

        // Check to see if FleetArn property is set
        internal bool IsSetFleetArn()
        {
            return this._fleetArn != null;
        }

        /// <summary>
        /// Gets and sets the property FleetId. 
        /// <para>
        /// A unique identifier for the fleet that the compute belongs to.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string FleetId
        {
            get { return this._fleetId; }
            set { this._fleetId = value; }
        }

        // Check to see if FleetId property is set
        internal bool IsSetFleetId()
        {
            return this._fleetId != null;
        }

        /// <summary>
        /// Gets and sets the property GameLiftAgentEndpoint. 
        /// <para>
        ///  The endpoint of the Amazon GameLift Servers Agent. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string GameLiftAgentEndpoint
        {
            get { return this._gameLiftAgentEndpoint; }
            set { this._gameLiftAgentEndpoint = value; }
        }

        // Check to see if GameLiftAgentEndpoint property is set
        internal bool IsSetGameLiftAgentEndpoint()
        {
            return this._gameLiftAgentEndpoint != null;
        }

        /// <summary>
        /// Gets and sets the property GameLiftServiceSdkEndpoint. 
        /// <para>
        /// The Amazon GameLift Servers SDK endpoint connection for a registered compute resource
        /// in an Anywhere fleet. The game servers on the compute use this endpoint to connect
        /// to the Amazon GameLift Servers service.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string GameLiftServiceSdkEndpoint
        {
            get { return this._gameLiftServiceSdkEndpoint; }
            set { this._gameLiftServiceSdkEndpoint = value; }
        }

        // Check to see if GameLiftServiceSdkEndpoint property is set
        internal bool IsSetGameLiftServiceSdkEndpoint()
        {
            return this._gameLiftServiceSdkEndpoint != null;
        }

        /// <summary>
        /// Gets and sets the property GameServerContainerGroupDefinitionArn. 
        /// <para>
        /// The game server container group definition for the compute.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=512)]
        public string GameServerContainerGroupDefinitionArn
        {
            get { return this._gameServerContainerGroupDefinitionArn; }
            set { this._gameServerContainerGroupDefinitionArn = value; }
        }

        // Check to see if GameServerContainerGroupDefinitionArn property is set
        internal bool IsSetGameServerContainerGroupDefinitionArn()
        {
            return this._gameServerContainerGroupDefinitionArn != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceId. 
        /// <para>
        ///  The <c>InstanceID</c> of the EC2 instance that is hosting the compute. 
        /// </para>
        /// </summary>
        public string InstanceId
        {
            get { return this._instanceId; }
            set { this._instanceId = value; }
        }

        // Check to see if InstanceId property is set
        internal bool IsSetInstanceId()
        {
            return this._instanceId != null;
        }

        /// <summary>
        /// Gets and sets the property IpAddress. 
        /// <para>
        /// The IP address of a compute resource. Amazon GameLift Servers requires a DNS name
        /// or IP address for a compute.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=128)]
        public string IpAddress
        {
            get { return this._ipAddress; }
            set { this._ipAddress = value; }
        }

        // Check to see if IpAddress property is set
        internal bool IsSetIpAddress()
        {
            return this._ipAddress != null;
        }

        /// <summary>
        /// Gets and sets the property Location. 
        /// <para>
        /// The name of the custom location you added to the fleet that this compute resource
        /// resides in.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string Location
        {
            get { return this._location; }
            set { this._location = value; }
        }

        // Check to see if Location property is set
        internal bool IsSetLocation()
        {
            return this._location != null;
        }

        /// <summary>
        /// Gets and sets the property OperatingSystem. 
        /// <para>
        /// The type of operating system on the compute resource.
        /// </para>
        ///  <note> 
        /// <para>
        /// Amazon Linux 2 (AL2) will reach end of support on 6/30/2025. See more details in the
        /// <a href="http://aws.amazon.com/aws.amazon.com/amazon-linux-2/faqs/">Amazon Linux 2
        /// FAQs</a>. For game servers that are hosted on AL2 and use server SDK version 4.x for
        /// Amazon GameLift Servers, first update the game server build to server SDK 5.x, and
        /// then deploy to AL2023 instances. See <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/reference-serversdk5-migration.html">
        /// Migrate to server SDK version 5.</a> 
        /// </para>
        ///  </note>
        /// </summary>
        public OperatingSystem OperatingSystem
        {
            get { return this._operatingSystem; }
            set { this._operatingSystem = value; }
        }

        // Check to see if OperatingSystem property is set
        internal bool IsSetOperatingSystem()
        {
            return this._operatingSystem != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The Amazon EC2 instance type that the fleet uses. For registered computes in an Amazon
        /// GameLift Servers Anywhere fleet, this property is empty. 
        /// </para>
        /// </summary>
        public EC2InstanceType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}