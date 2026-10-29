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
    /// An object containing various properties of a managed node.
    /// </summary>
    public partial class InstanceProperty
    {
        /// <summary>
        /// Gets and sets the property ActivationId. 
        /// <para>
        /// The activation ID created by Systems Manager when the server or virtual machine (VM)
        /// was registered
        /// </para>
        /// </summary>
        public string ActivationId { get; set; }

        /// <summary>
        /// Checks to see if the ActivationId property is set.
        /// </summary>
        internal bool IsSetActivationId() => this.ActivationId != null;

        /// <summary>
        /// Gets and sets the property AgentVersion. 
        /// <para>
        /// The version of SSM Agent running on your managed node.
        /// </para>
        /// </summary>
        public string AgentVersion { get; set; }

        /// <summary>
        /// Checks to see if the AgentVersion property is set.
        /// </summary>
        internal bool IsSetAgentVersion() => this.AgentVersion != null;

        /// <summary>
        /// Gets and sets the property Architecture. 
        /// <para>
        /// The CPU architecture of the node. For example, <c>x86_64</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 120)]
        public string Architecture { get; set; }

        /// <summary>
        /// Checks to see if the Architecture property is set.
        /// </summary>
        internal bool IsSetArchitecture() => this.Architecture != null;

        /// <summary>
        /// Gets and sets the property AssociationOverview.
        /// </summary>
        public InstanceAggregatedAssociationOverview AssociationOverview { get; set; }

        /// <summary>
        /// Checks to see if the AssociationOverview property is set.
        /// </summary>
        internal bool IsSetAssociationOverview() => this.AssociationOverview != null;

        /// <summary>
        /// Gets and sets the property AssociationStatus. 
        /// <para>
        /// The status of the State Manager association applied to the managed node.
        /// </para>
        /// </summary>
        public string AssociationStatus { get; set; }

        /// <summary>
        /// Checks to see if the AssociationStatus property is set.
        /// </summary>
        internal bool IsSetAssociationStatus() => this.AssociationStatus != null;

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
        /// Gets and sets the property IPAddress. 
        /// <para>
        /// The public IPv4 address assigned to the node. If a public IPv4 address isn't assigned
        /// to the node, this value is blank.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 46)]
        public string IPAddress { get; set; }

        /// <summary>
        /// Checks to see if the IPAddress property is set.
        /// </summary>
        internal bool IsSetIPAddress() => this.IPAddress != null;

        /// <summary>
        /// Gets and sets the property IamRole. 
        /// <para>
        /// The IAM role used in the hybrid activation to register the node with Systems Manager.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 64)]
        public string IamRole { get; set; }

        /// <summary>
        /// Checks to see if the IamRole property is set.
        /// </summary>
        internal bool IsSetIamRole() => this.IamRole != null;

        /// <summary>
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// The ID of the managed node.
        /// </para>
        /// </summary>
        public string InstanceId { get; set; }

        /// <summary>
        /// Checks to see if the InstanceId property is set.
        /// </summary>
        internal bool IsSetInstanceId() => this.InstanceId != null;

        /// <summary>
        /// Gets and sets the property InstanceRole. 
        /// <para>
        /// The instance profile attached to the node. If an instance profile isn't attached to
        /// the node, this value is blank.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 120)]
        public string InstanceRole { get; set; }

        /// <summary>
        /// Checks to see if the InstanceRole property is set.
        /// </summary>
        internal bool IsSetInstanceRole() => this.InstanceRole != null;

        /// <summary>
        /// Gets and sets the property InstanceState. 
        /// <para>
        /// The current state of the node.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 120)]
        public string InstanceState { get; set; }

        /// <summary>
        /// Checks to see if the InstanceState property is set.
        /// </summary>
        internal bool IsSetInstanceState() => this.InstanceState != null;

        /// <summary>
        /// Gets and sets the property InstanceType. 
        /// <para>
        /// The instance type of the managed node. For example, t3.large.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 120)]
        public string InstanceType { get; set; }

        /// <summary>
        /// Checks to see if the InstanceType property is set.
        /// </summary>
        internal bool IsSetInstanceType() => this.InstanceType != null;

        /// <summary>
        /// Gets and sets the property KeyName. 
        /// <para>
        /// The name of the key pair associated with the node. If a key pair isnt't associated
        /// with the node, this value is blank.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 255)]
        public string KeyName { get; set; }

        /// <summary>
        /// Checks to see if the KeyName property is set.
        /// </summary>
        internal bool IsSetKeyName() => this.KeyName != null;

        /// <summary>
        /// Gets and sets the property LastAssociationExecutionDate. 
        /// <para>
        /// The date the association was last run.
        /// </para>
        /// </summary>
        public DateTime? LastAssociationExecutionDate { get; set; }

        /// <summary>
        /// Checks to see if the LastAssociationExecutionDate property is set.
        /// </summary>
        internal bool IsSetLastAssociationExecutionDate() => this.LastAssociationExecutionDate.HasValue;

        /// <summary>
        /// Gets and sets the property LastPingDateTime. 
        /// <para>
        /// The date and time when the SSM Agent last pinged the Systems Manager service.
        /// </para>
        /// </summary>
        public DateTime? LastPingDateTime { get; set; }

        /// <summary>
        /// Checks to see if the LastPingDateTime property is set.
        /// </summary>
        internal bool IsSetLastPingDateTime() => this.LastPingDateTime.HasValue;

        /// <summary>
        /// Gets and sets the property LastSuccessfulAssociationExecutionDate. 
        /// <para>
        /// The last date the association was successfully run.
        /// </para>
        /// </summary>
        public DateTime? LastSuccessfulAssociationExecutionDate { get; set; }

        /// <summary>
        /// Checks to see if the LastSuccessfulAssociationExecutionDate property is set.
        /// </summary>
        internal bool IsSetLastSuccessfulAssociationExecutionDate() => this.LastSuccessfulAssociationExecutionDate.HasValue;

        /// <summary>
        /// Gets and sets the property LaunchTime. 
        /// <para>
        /// The timestamp for when the node was launched.
        /// </para>
        /// </summary>
        public DateTime? LaunchTime { get; set; }

        /// <summary>
        /// Checks to see if the LaunchTime property is set.
        /// </summary>
        internal bool IsSetLaunchTime() => this.LaunchTime.HasValue;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The value of the EC2 <c>Name</c> tag associated with the node. If a <c>Name</c> tag
        /// hasn't been applied to the node, this value is blank.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 255)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property PingStatus. 
        /// <para>
        /// Connection status of the SSM Agent on the managed node.
        /// </para>
        /// </summary>
        public PingStatus PingStatus { get; set; }

        /// <summary>
        /// Checks to see if the PingStatus property is set.
        /// </summary>
        internal bool IsSetPingStatus() => this.PingStatus != null;

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
        /// The operating system platform type of the managed node. For example, Windows Server
        /// or Amazon Linux 2.
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
        /// Gets and sets the property RegistrationDate. 
        /// <para>
        /// The date the node was registered with Systems Manager.
        /// </para>
        /// </summary>
        public DateTime? RegistrationDate { get; set; }

        /// <summary>
        /// Checks to see if the RegistrationDate property is set.
        /// </summary>
        internal bool IsSetRegistrationDate() => this.RegistrationDate.HasValue;

        /// <summary>
        /// Gets and sets the property ResourceType. 
        /// <para>
        /// The type of managed node.
        /// </para>
        /// </summary>
        public string ResourceType { get; set; }

        /// <summary>
        /// Checks to see if the ResourceType property is set.
        /// </summary>
        internal bool IsSetResourceType() => this.ResourceType != null;

        /// <summary>
        /// Gets and sets the property SourceId. 
        /// <para>
        /// The ID of the source resource.
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
        /// The type of the source resource. Valid values: <c>AWS::EC2::Instance</c> | <c>AWS::SSM::ManagedInstance</c>
        /// | <c>AWS::IoT::Thing</c> | <c>Microsoft.Compute/virtualMachines</c>.
        /// </para>
        /// </summary>
        public SourceType SourceType { get; set; }

        /// <summary>
        /// Checks to see if the SourceType property is set.
        /// </summary>
        internal bool IsSetSourceType() => this.SourceType != null;
    }
}
