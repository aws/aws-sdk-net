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

namespace Amazon.Evs.Model
{
    /// <summary>
    /// An ESX host that runs on an Amazon EC2 bare metal instance.
    /// </summary>
    public partial class Host
    {
        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        ///  The date and time that the host was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property DedicatedHostId. 
        /// <para>
        /// The unique ID of the Amazon EC2 Dedicated Host.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 25)]
        public string DedicatedHostId { get; set; }

        /// <summary>
        /// Checks to see if the DedicatedHostId property is set.
        /// </summary>
        internal bool IsSetDedicatedHostId() => this.DedicatedHostId != null;

        /// <summary>
        /// Gets and sets the property Ec2InstanceId. 
        /// <para>
        /// The unique ID of the EC2 instance that represents the host.
        /// </para>
        /// </summary>
        public string Ec2InstanceId { get; set; }

        /// <summary>
        /// Checks to see if the Ec2InstanceId property is set.
        /// </summary>
        internal bool IsSetEc2InstanceId() => this.Ec2InstanceId != null;

        /// <summary>
        /// Gets and sets the property HostName. 
        /// <para>
        /// The DNS hostname of the host. DNS hostnames for hosts must be unique across Amazon
        /// EVS environments and within VCF.
        /// </para>
        /// </summary>
        public string HostName { get; set; }

        /// <summary>
        /// Checks to see if the HostName property is set.
        /// </summary>
        internal bool IsSetHostName() => this.HostName != null;

        /// <summary>
        /// Gets and sets the property HostState. 
        /// <para>
        ///  The state of the host.
        /// </para>
        /// </summary>
        public HostState HostState { get; set; }

        /// <summary>
        /// Checks to see if the HostState property is set.
        /// </summary>
        internal bool IsSetHostState() => this.HostState != null;

        /// <summary>
        /// Gets and sets the property InstanceType. 
        /// <para>
        /// The EC2 instance type of the host.
        /// </para>
        ///  <note> 
        /// <para>
        /// EC2 instances created through Amazon EVS do not support associating an IAM instance
        /// profile.
        /// </para>
        ///  </note>
        /// </summary>
        public InstanceType InstanceType { get; set; }

        /// <summary>
        /// Checks to see if the InstanceType property is set.
        /// </summary>
        internal bool IsSetInstanceType() => this.InstanceType != null;

        /// <summary>
        /// Gets and sets the property IpAddress. 
        /// <para>
        /// The IP address of the host.
        /// </para>
        /// </summary>
        public string IpAddress { get; set; }

        /// <summary>
        /// Checks to see if the IpAddress property is set.
        /// </summary>
        internal bool IsSetIpAddress() => this.IpAddress != null;

        /// <summary>
        /// Gets and sets the property KeyName. 
        /// <para>
        /// The name of the SSH key that is used to access the host.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string KeyName { get; set; }

        /// <summary>
        /// Checks to see if the KeyName property is set.
        /// </summary>
        internal bool IsSetKeyName() => this.KeyName != null;

        /// <summary>
        /// Gets and sets the property ModifiedAt. 
        /// <para>
        ///  The date and time that the host was modified.
        /// </para>
        /// </summary>
        public DateTime? ModifiedAt { get; set; }

        /// <summary>
        /// Checks to see if the ModifiedAt property is set.
        /// </summary>
        internal bool IsSetModifiedAt() => this.ModifiedAt.HasValue;

        /// <summary>
        /// Gets and sets the property NetworkInterfaces. 
        /// <para>
        /// The elastic network interfaces that are attached to the host.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 2)]
        public List<NetworkInterface> NetworkInterfaces { get; set; } = AWSConfigs.InitializeCollections ? new List<NetworkInterface>() : null;

        /// <summary>
        /// Checks to see if the NetworkInterfaces property is set.
        /// </summary>
        internal bool IsSetNetworkInterfaces() => this.NetworkInterfaces != null && (this.NetworkInterfaces.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property PlacementGroupId. 
        /// <para>
        /// The unique ID of the placement group where the host is placed.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 25)]
        public string PlacementGroupId { get; set; }

        /// <summary>
        /// Checks to see if the PlacementGroupId property is set.
        /// </summary>
        internal bool IsSetPlacementGroupId() => this.PlacementGroupId != null;

        /// <summary>
        /// Gets and sets the property StateDetails. 
        /// <para>
        ///  A detailed description of the <c>hostState</c> of a host.
        /// </para>
        /// </summary>
        public string StateDetails { get; set; }

        /// <summary>
        /// Checks to see if the StateDetails property is set.
        /// </summary>
        internal bool IsSetStateDetails() => this.StateDetails != null;
    }
}
