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

namespace Amazon.SimpleSystemsManagement.Model
{
    /// <summary>
    /// Details about a specific managed node.
    /// </summary>
    public partial class InstanceInfo
    {
        /// <summary>
        /// Gets and sets the property AgentType. 
        /// <para>
        /// The type of agent installed on the node.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string AgentType { get; set; }

        /// <summary>
        /// Checks to see if the AgentType property is set.
        /// </summary>
        internal bool IsSetAgentType() => this.AgentType != null;

        /// <summary>
        /// Gets and sets the property AgentVersion. 
        /// <para>
        /// The version number of the agent installed on the node.
        /// </para>
        /// </summary>
        public string AgentVersion { get; set; }

        /// <summary>
        /// Checks to see if the AgentVersion property is set.
        /// </summary>
        internal bool IsSetAgentVersion() => this.AgentVersion != null;

        /// <summary>
        /// Gets and sets the property AvailabilityZone. 
        /// <para>
        /// The Availability Zone where the managed node is located.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 120)]
        public string AvailabilityZone { get; set; }

        /// <summary>
        /// Checks to see if the AvailabilityZone property is set.
        /// </summary>
        internal bool IsSetAvailabilityZone() => this.AvailabilityZone != null;

        /// <summary>
        /// Gets and sets the property AvailabilityZoneId. 
        /// <para>
        /// The Availability Zone ID where the managed node is located.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 50)]
        public string AvailabilityZoneId { get; set; }

        /// <summary>
        /// Checks to see if the AvailabilityZoneId property is set.
        /// </summary>
        internal bool IsSetAvailabilityZoneId() => this.AvailabilityZoneId != null;

        /// <summary>
        /// Gets and sets the property ComputerName. 
        /// <para>
        /// The fully qualified host name of the managed node.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string ComputerName { get; set; }

        /// <summary>
        /// Checks to see if the ComputerName property is set.
        /// </summary>
        internal bool IsSetComputerName() => this.ComputerName != null;

        /// <summary>
        /// Gets and sets the property InstanceStatus. 
        /// <para>
        /// The current status of the managed node.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string InstanceStatus { get; set; }

        /// <summary>
        /// Checks to see if the InstanceStatus property is set.
        /// </summary>
        internal bool IsSetInstanceStatus() => this.InstanceStatus != null;

        /// <summary>
        /// Gets and sets the property IpAddress. 
        /// <para>
        /// The IP address of the managed node.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 46)]
        public string IpAddress { get; set; }

        /// <summary>
        /// Checks to see if the IpAddress property is set.
        /// </summary>
        internal bool IsSetIpAddress() => this.IpAddress != null;

        /// <summary>
        /// Gets and sets the property ManagedStatus. 
        /// <para>
        /// Indicates whether the node is managed by Systems Manager.
        /// </para>
        /// </summary>
        public ManagedStatus ManagedStatus { get; set; }

        /// <summary>
        /// Checks to see if the ManagedStatus property is set.
        /// </summary>
        internal bool IsSetManagedStatus() => this.ManagedStatus != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name assigned to the managed node.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property PlatformName. 
        /// <para>
        /// The name of the operating system platform running on your managed node.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 120)]
        public string PlatformName { get; set; }

        /// <summary>
        /// Checks to see if the PlatformName property is set.
        /// </summary>
        internal bool IsSetPlatformName() => this.PlatformName != null;

        /// <summary>
        /// Gets and sets the property PlatformType. 
        /// <para>
        /// The operating system platform type of the managed node.
        /// </para>
        /// </summary>
        public PlatformType PlatformType { get; set; }

        /// <summary>
        /// Checks to see if the PlatformType property is set.
        /// </summary>
        internal bool IsSetPlatformType() => this.PlatformType != null;

        /// <summary>
        /// Gets and sets the property PlatformVersion. 
        /// <para>
        /// The version of the OS platform running on your managed node. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 120)]
        public string PlatformVersion { get; set; }

        /// <summary>
        /// Checks to see if the PlatformVersion property is set.
        /// </summary>
        internal bool IsSetPlatformVersion() => this.PlatformVersion != null;

        /// <summary>
        /// Gets and sets the property ResourceType. 
        /// <para>
        /// The type of instance, either an EC2 instance or another supported machine type in
        /// a hybrid fleet.
        /// </para>
        /// </summary>
        public ResourceType ResourceType { get; set; }

        /// <summary>
        /// Checks to see if the ResourceType property is set.
        /// </summary>
        internal bool IsSetResourceType() => this.ResourceType != null;

        /// <summary>
        /// Gets and sets the property SourceId. 
        /// <para>
        /// The ID of the source resource. For IoT Greengrass devices, <c>SourceId</c> is the
        /// Thing name.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 128)]
        public string SourceId { get; set; }

        /// <summary>
        /// Checks to see if the SourceId property is set.
        /// </summary>
        internal bool IsSetSourceId() => this.SourceId != null;

        /// <summary>
        /// Gets and sets the property SourceLocation. 
        /// <para>
        /// The location of the source resource in the third-party cloud environment.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string SourceLocation { get; set; }

        /// <summary>
        /// Checks to see if the SourceLocation property is set.
        /// </summary>
        internal bool IsSetSourceLocation() => this.SourceLocation != null;

        /// <summary>
        /// Gets and sets the property SourceType. 
        /// <para>
        /// The type of the source resource. For IoT Greengrass devices, <c>SourceType</c> is
        /// <c>AWS::IoT::Thing</c>.
        /// </para>
        /// </summary>
        public SourceType SourceType { get; set; }

        /// <summary>
        /// Checks to see if the SourceType property is set.
        /// </summary>
        internal bool IsSetSourceType() => this.SourceType != null;
    }
}
