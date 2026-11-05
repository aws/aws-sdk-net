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
    /// Describes a filter for a specific list of managed nodes.
    /// </summary>
    public partial class InstanceInformation
    {
        /// <summary>
        /// Gets and sets the property ActivationId. 
        /// <para>
        /// The activation ID created by Amazon Web Services Systems Manager when the server or
        /// virtual machine (VM) was registered.
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
        /// The version of SSM Agent running on your Linux managed node. 
        /// </para>
        /// </summary>
        public string AgentVersion { get; set; }

        /// <summary>
        /// Checks to see if the AgentVersion property is set.
        /// </summary>
        internal bool IsSetAgentVersion() => this.AgentVersion != null;

        /// <summary>
        /// Gets and sets the property AssociationOverview. 
        /// <para>
        /// Information about the association.
        /// </para>
        /// </summary>
        public InstanceAggregatedAssociationOverview AssociationOverview { get; set; }

        /// <summary>
        /// Checks to see if the AssociationOverview property is set.
        /// </summary>
        internal bool IsSetAssociationOverview() => this.AssociationOverview != null;

        /// <summary>
        /// Gets and sets the property AssociationStatus. 
        /// <para>
        /// The status of the association.
        /// </para>
        /// </summary>
        public string AssociationStatus { get; set; }

        /// <summary>
        /// Checks to see if the AssociationStatus property is set.
        /// </summary>
        internal bool IsSetAssociationStatus() => this.AssociationStatus != null;

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
        /// The IP address of the managed node.
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
        /// The role assigned to an Amazon EC2 instance configured with a Systems Manager Quick
        /// Setup host management configuration or the role assigned to an on-premises managed
        /// node.
        /// </para>
        ///  
        /// <para>
        ///  This call doesn't return the IAM role for <i>unmanaged</i> Amazon EC2 instances (instances
        /// not configured for Systems Manager). To retrieve the role for an unmanaged instance,
        /// use the Amazon EC2 <c>DescribeInstances</c> operation. For information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/API_DescribeInstances.html">DescribeInstances</a>
        /// in the <i>Amazon EC2 API Reference</i> or <a href="https://docs.aws.amazon.com/cli/latest/reference/ec2/describe-instances.html">describe-instances</a>
        /// in the <i>Amazon Web Services CLI Command Reference</i>.
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
        /// The managed node ID. 
        /// </para>
        /// </summary>
        public string InstanceId { get; set; }

        /// <summary>
        /// Checks to see if the InstanceId property is set.
        /// </summary>
        internal bool IsSetInstanceId() => this.InstanceId != null;

        /// <summary>
        /// Gets and sets the property IsLatestVersion. 
        /// <para>
        /// Indicates whether the latest version of SSM Agent is running on your Linux managed
        /// node. This field doesn't indicate whether or not the latest version is installed on
        /// Windows managed nodes, because some older versions of Windows Server use the EC2Config
        /// service to process Systems Manager requests.
        /// </para>
        /// </summary>
        public bool? IsLatestVersion { get; set; }

        /// <summary>
        /// Checks to see if the IsLatestVersion property is set.
        /// </summary>
        internal bool IsSetIsLatestVersion() => this.IsLatestVersion.HasValue;

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
        /// The date and time when the agent last pinged the Systems Manager service. 
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
        /// Gets and sets the property Name. 
        /// <para>
        /// The name assigned to an on-premises server, edge device, or virtual machine (VM) when
        /// it is activated as a Systems Manager managed node. The name is specified as the <c>DefaultInstanceName</c>
        /// property using the <a>CreateActivation</a> command. It is applied to the managed node
        /// by specifying the Activation Code and Activation ID when you install SSM Agent on
        /// the node, as explained in <a href="https://docs.aws.amazon.com/systems-manager/latest/userguide/hybrid-multicloud-ssm-agent-install-linux.html">How
        /// to install SSM Agent on hybrid Linux nodes</a> and <a href="https://docs.aws.amazon.com/systems-manager/latest/userguide/hybrid-multicloud-ssm-agent-install-windows.html">How
        /// to install SSM Agent on hybrid Windows Server nodes</a>. To retrieve the <c>Name</c>
        /// tag of an EC2 instance, use the Amazon EC2 <c>DescribeInstances</c> operation. For
        /// information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/API_DescribeInstances.html">DescribeInstances</a>
        /// in the <i>Amazon EC2 API Reference</i> or <a href="https://docs.aws.amazon.com/cli/latest/reference/ec2/describe-instances.html">describe-instances</a>
        /// in the <i>Amazon Web Services CLI Command Reference</i>.
        /// </para>
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property PingStatus. 
        /// <para>
        /// Connection status of SSM Agent. 
        /// </para>
        ///  <note> 
        /// <para>
        /// The status <c>Inactive</c> has been deprecated and is no longer in use.
        /// </para>
        ///  </note>
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
        public string PlatformName { get; set; }

        /// <summary>
        /// Checks to see if the PlatformName property is set.
        /// </summary>
        internal bool IsSetPlatformName() => this.PlatformName != null;

        /// <summary>
        /// Gets and sets the property PlatformType. 
        /// <para>
        /// The operating system platform type.
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
        public string PlatformVersion { get; set; }

        /// <summary>
        /// Checks to see if the PlatformVersion property is set.
        /// </summary>
        internal bool IsSetPlatformVersion() => this.PlatformVersion != null;

        /// <summary>
        /// Gets and sets the property RegistrationDate. 
        /// <para>
        /// The date the server or VM was registered with Amazon Web Services as a managed node.
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
        /// The type of instance. Instances are either EC2 instances or managed instances. 
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
        /// <c>AWS::IoT::Thing</c>. For Azure Virtual Machines, <c>SourceType</c> is <c>Microsoft.Compute/virtualMachines</c>.
        /// </para>
        /// </summary>
        public SourceType SourceType { get; set; }

        /// <summary>
        /// Checks to see if the SourceType property is set.
        /// </summary>
        internal bool IsSetSourceType() => this.SourceType != null;
    }
}
