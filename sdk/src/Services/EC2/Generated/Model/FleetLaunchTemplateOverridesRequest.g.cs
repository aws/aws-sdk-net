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

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Describes overrides for a launch template.
    /// </summary>
    public partial class FleetLaunchTemplateOverridesRequest
    {
        /// <summary>
        /// Gets and sets the property AvailabilityZone. 
        /// <para>
        /// The Availability Zone in which to launch the instances. For example, <c>us-east-2a</c>.
        /// </para>
        ///  
        /// <para>
        /// Either <c>AvailabilityZone</c> or <c>AvailabilityZoneId</c> must be specified in the
        /// request, but not both.
        /// </para>
        /// </summary>
        public string AvailabilityZone { get; set; }

        /// <summary>
        /// Checks to see if the AvailabilityZone property is set.
        /// </summary>
        internal bool IsSetAvailabilityZone() => this.AvailabilityZone != null;

        /// <summary>
        /// Gets and sets the property AvailabilityZoneId. 
        /// <para>
        /// The ID of the Availability Zone in which to launch the instances. For example, <c>use2-az1</c>.
        /// </para>
        ///  
        /// <para>
        /// Either <c>AvailabilityZone</c> or <c>AvailabilityZoneId</c> must be specified in the
        /// request, but not both.
        /// </para>
        /// </summary>
        public string AvailabilityZoneId { get; set; }

        /// <summary>
        /// Checks to see if the AvailabilityZoneId property is set.
        /// </summary>
        internal bool IsSetAvailabilityZoneId() => this.AvailabilityZoneId != null;

        /// <summary>
        /// Gets and sets the property BlockDeviceMappings. 
        /// <para>
        /// The block device mappings, which define the EBS volumes and instance store volumes
        /// to attach to the instance at launch.
        /// </para>
        ///  
        /// <para>
        /// Supported only for fleets of type <c>instant</c>.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/block-device-mapping-concepts.html">Block
        /// device mappings for volumes on Amazon EC2 instances</a> in the <i>Amazon EC2 User
        /// Guide</i>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<FleetBlockDeviceMappingRequest> BlockDeviceMappings { get; set; } = AWSConfigs.InitializeCollections ? new List<FleetBlockDeviceMappingRequest>() : null;

        /// <summary>
        /// Checks to see if the BlockDeviceMappings property is set.
        /// </summary>
        internal bool IsSetBlockDeviceMappings() => this.BlockDeviceMappings != null && (this.BlockDeviceMappings.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property IamInstanceProfile. 
        /// <para>
        /// The IAM instance profile to associate with the instances.
        /// </para>
        ///  
        /// <para>
        /// Supported only for fleets of type <c>instant</c>.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/iam-roles-for-amazon-ec2.html">IAM
        /// roles for Amazon EC2</a> in the <i>Amazon EC2 User Guide</i>.
        /// </para>
        /// </summary>
        public FleetIamInstanceProfileSpecificationRequest IamInstanceProfile { get; set; }

        /// <summary>
        /// Checks to see if the IamInstanceProfile property is set.
        /// </summary>
        internal bool IsSetIamInstanceProfile() => this.IamInstanceProfile != null;

        /// <summary>
        /// Gets and sets the property ImageId. 
        /// <para>
        /// The ID of the AMI in the format <c>ami-17characters00000</c>.
        /// </para>
        ///  
        /// <para>
        /// Alternatively, you can specify a Systems Manager parameter, using one of the following
        /// formats. The Systems Manager parameter will resolve to an AMI ID on launch.
        /// </para>
        ///  
        /// <para>
        /// To reference a public parameter:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>resolve:ssm:<i>public-parameter</i> </c> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// To reference a parameter stored in the same account:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>resolve:ssm:<i>parameter-name</i> </c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>resolve:ssm:<i>parameter-name:version-number</i> </c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>resolve:ssm:<i>parameter-name:label</i> </c> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// To reference a parameter shared from another Amazon Web Services account:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>resolve:ssm:<i>parameter-ARN</i> </c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>resolve:ssm:<i>parameter-ARN:version-number</i> </c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>resolve:ssm:<i>parameter-ARN:label</i> </c> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/create-launch-template.html#use-an-ssm-parameter-instead-of-an-ami-id">Use
        /// a Systems Manager parameter instead of an AMI ID</a> in the <i>Amazon EC2 User Guide</i>.
        /// </para>
        ///  <note> 
        /// <para>
        /// This parameter is only available for fleets of type <c>instant</c>. For fleets of
        /// type <c>maintain</c> and <c>request</c>, you must specify the AMI ID in the launch
        /// template.
        /// </para>
        ///  </note>
        /// </summary>
        public string ImageId { get; set; }

        /// <summary>
        /// Checks to see if the ImageId property is set.
        /// </summary>
        internal bool IsSetImageId() => this.ImageId != null;

        /// <summary>
        /// Gets and sets the property InstanceRequirements. 
        /// <para>
        /// The attributes for the instance types. When you specify instance attributes, Amazon
        /// EC2 will identify instance types with those attributes.
        /// </para>
        ///  <note> 
        /// <para>
        /// If you specify <c>InstanceRequirements</c>, you can't specify <c>InstanceType</c>.
        /// </para>
        ///  </note>
        /// </summary>
        public InstanceRequirementsRequest InstanceRequirements { get; set; }

        /// <summary>
        /// Checks to see if the InstanceRequirements property is set.
        /// </summary>
        internal bool IsSetInstanceRequirements() => this.InstanceRequirements != null;

        /// <summary>
        /// Gets and sets the property InstanceType. 
        /// <para>
        /// The instance type.
        /// </para>
        ///  
        /// <para>
        ///  <c>mac1.metal</c> is not supported as a launch template override.
        /// </para>
        ///  <note> 
        /// <para>
        /// If you specify <c>InstanceType</c>, you can't specify <c>InstanceRequirements</c>.
        /// </para>
        ///  </note>
        /// </summary>
        public InstanceType InstanceType { get; set; }

        /// <summary>
        /// Checks to see if the InstanceType property is set.
        /// </summary>
        internal bool IsSetInstanceType() => this.InstanceType != null;

        /// <summary>
        /// Gets and sets the property KeyName. 
        /// <para>
        /// The name of the key pair to use for the instances.
        /// </para>
        ///  
        /// <para>
        /// Supported only for fleets of type <c>instant</c>.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-key-pairs.html">Amazon
        /// EC2 key pairs</a> in the <i>Amazon EC2 User Guide</i>.
        /// </para>
        /// </summary>
        public string KeyName { get; set; }

        /// <summary>
        /// Checks to see if the KeyName property is set.
        /// </summary>
        internal bool IsSetKeyName() => this.KeyName != null;

        /// <summary>
        /// Gets and sets the property MaxPrice. 
        /// <para>
        /// The maximum price per unit hour that you are willing to pay for a Spot Instance. We
        /// do not recommend using this parameter because it can lead to increased interruptions.
        /// If you do not specify this parameter, you will pay the current Spot price. 
        /// </para>
        ///  <important> 
        /// <para>
        /// If you specify a maximum price, your instances will be interrupted more frequently
        /// than if you do not specify this parameter.
        /// </para>
        ///  
        /// <para>
        /// If you specify a maximum price, it must be more than USD $0.001. Specifying a value
        /// below USD $0.001 will result in an <c>InvalidParameterValue</c> error message.
        /// </para>
        ///  </important>
        /// </summary>
        public string MaxPrice { get; set; }

        /// <summary>
        /// Checks to see if the MaxPrice property is set.
        /// </summary>
        internal bool IsSetMaxPrice() => this.MaxPrice != null;

        /// <summary>
        /// Gets and sets the property MetadataOptions. 
        /// <para>
        /// The metadata options for the instances.
        /// </para>
        ///  
        /// <para>
        /// Supported only for fleets of type <c>instant</c>.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/configuring-instance-metadata-service.html">Configure
        /// the instance metadata service</a> in the <i>Amazon EC2 User Guide</i>.
        /// </para>
        /// </summary>
        public FleetInstanceMetadataOptionsRequest MetadataOptions { get; set; }

        /// <summary>
        /// Checks to see if the MetadataOptions property is set.
        /// </summary>
        internal bool IsSetMetadataOptions() => this.MetadataOptions != null;

        /// <summary>
        /// Gets and sets the property Placement. 
        /// <para>
        /// The location where the instance launched, if applicable.
        /// </para>
        /// </summary>
        public Placement Placement { get; set; }

        /// <summary>
        /// Checks to see if the Placement property is set.
        /// </summary>
        internal bool IsSetPlacement() => this.Placement != null;

        /// <summary>
        /// Gets and sets the property Priority. 
        /// <para>
        /// The priority for the launch template override. The highest priority is launched first.
        /// </para>
        ///  
        /// <para>
        /// If the On-Demand <c>AllocationStrategy</c> is set to <c>prioritized</c>, EC2 Fleet
        /// uses priority to determine which launch template override to use first in fulfilling
        /// On-Demand capacity.
        /// </para>
        ///  
        /// <para>
        /// If the Spot <c>AllocationStrategy</c> is set to <c>capacity-optimized-prioritized</c>,
        /// EC2 Fleet uses priority on a best-effort basis to determine which launch template
        /// override to use in fulfilling Spot capacity, but optimizes for capacity first.
        /// </para>
        ///  
        /// <para>
        /// Valid values are whole numbers starting at <c>0</c>. The lower the number, the higher
        /// the priority. If no number is set, the launch template override has the lowest priority.
        /// You can set the same priority for different launch template overrides.
        /// </para>
        /// </summary>
        public double? Priority { get; set; }

        /// <summary>
        /// Checks to see if the Priority property is set.
        /// </summary>
        internal bool IsSetPriority() => this.Priority.HasValue;

        /// <summary>
        /// Gets and sets the property SubnetId. 
        /// <para>
        /// The IDs of the subnets in which to launch the instances. Separate multiple subnet
        /// IDs using commas (for example, <c>subnet-1234abcdeexample1, subnet-0987cdef6example2</c>).
        /// A request of type <c>instant</c> can have only one subnet ID.
        /// </para>
        /// </summary>
        public string SubnetId { get; set; }

        /// <summary>
        /// Checks to see if the SubnetId property is set.
        /// </summary>
        internal bool IsSetSubnetId() => this.SubnetId != null;

        /// <summary>
        /// Gets and sets the property WeightedCapacity. 
        /// <para>
        /// The number of units provided by the specified instance type. These are the same units
        /// that you chose to set the target capacity in terms of instances, or a performance
        /// characteristic such as vCPUs, memory, or I/O.
        /// </para>
        ///  
        /// <para>
        /// If the target capacity divided by this value is not a whole number, Amazon EC2 rounds
        /// the number of instances to the next whole number. If this value is not specified,
        /// the default is 1.
        /// </para>
        ///  <note> 
        /// <para>
        /// When specifying weights, the price used in the <c>lowest-price</c> and <c>price-capacity-optimized</c>
        /// allocation strategies is per <i>unit</i> hour (where the instance price is divided
        /// by the specified weight). However, if all the specified weights are above the requested
        /// <c>TargetCapacity</c>, resulting in only 1 instance being launched, the price used
        /// is per <i>instance</i> hour.
        /// </para>
        ///  </note>
        /// </summary>
        public double? WeightedCapacity { get; set; }

        /// <summary>
        /// Checks to see if the WeightedCapacity property is set.
        /// </summary>
        internal bool IsSetWeightedCapacity() => this.WeightedCapacity.HasValue;
    }
}
