/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;

using Amazon.Runtime;


namespace Amazon.EC2
{


    /// <summary>Container Format
    /// </summary>
    public class ContainerFormat : ConstantClass
    {


       /// <summary>Constant Ova for ContainerFormat
       /// </summary>
        public static readonly ContainerFormat Ova = new ContainerFormat("ova");
    

        /// <summary>
        /// Default Constructor
        /// </summary>
        public ContainerFormat(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ContainerFormat FindValue(string value)
        {
            return FindValue<ContainerFormat>(value);
        }

        public static implicit operator ContainerFormat(string value)
        {
            return FindValue(value);
        }
    }
    

    /// <summary>Disk Image Format
    /// </summary>
    public class DiskImageFormat : ConstantClass
    {


       /// <summary>Constant Vhd for DiskImageFormat
       /// </summary>
        public static readonly DiskImageFormat Vhd = new DiskImageFormat("vhd");
    

       /// <summary>Constant Vmdk for DiskImageFormat
       /// </summary>
        public static readonly DiskImageFormat Vmdk = new DiskImageFormat("vmdk");
    

        /// <summary>
        /// Default Constructor
        /// </summary>
        public DiskImageFormat(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DiskImageFormat FindValue(string value)
        {
            return FindValue<DiskImageFormat>(value);
        }

        public static implicit operator DiskImageFormat(string value)
        {
            return FindValue(value);
        }
    }
    

    /// <summary>Domain Type
    /// </summary>
    public class DomainType : ConstantClass
    {


       /// <summary>Constant Standard for DomainType
       /// </summary>
        public static readonly DomainType Standard = new DomainType("standard");
    

       /// <summary>Constant Vpc for DomainType
       /// </summary>
        public static readonly DomainType Vpc = new DomainType("vpc");
    

        /// <summary>
        /// Default Constructor
        /// </summary>
        public DomainType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DomainType FindValue(string value)
        {
            return FindValue<DomainType>(value);
        }

        public static implicit operator DomainType(string value)
        {
            return FindValue(value);
        }
    }
    

    /// <summary>Export Environment
    /// </summary>
    public class ExportEnvironment : ConstantClass
    {


       /// <summary>Constant Citrix for ExportEnvironment
       /// </summary>
        public static readonly ExportEnvironment Citrix = new ExportEnvironment("citrix");
    

       /// <summary>Constant Vmware for ExportEnvironment
       /// </summary>
        public static readonly ExportEnvironment Vmware = new ExportEnvironment("vmware");
    

        /// <summary>
        /// Default Constructor
        /// </summary>
        public ExportEnvironment(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ExportEnvironment FindValue(string value)
        {
            return FindValue<ExportEnvironment>(value);
        }

        public static implicit operator ExportEnvironment(string value)
        {
            return FindValue(value);
        }
    }
    

    /// <summary>Hypervisor Type
    /// </summary>
    public class HypervisorType : ConstantClass
    {


       /// <summary>Constant Ovm for HypervisorType
       /// </summary>
        public static readonly HypervisorType Ovm = new HypervisorType("ovm");
    

       /// <summary>Constant Xen for HypervisorType
       /// </summary>
        public static readonly HypervisorType Xen = new HypervisorType("xen");
    

        /// <summary>
        /// Default Constructor
        /// </summary>
        public HypervisorType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static HypervisorType FindValue(string value)
        {
            return FindValue<HypervisorType>(value);
        }

        public static implicit operator HypervisorType(string value)
        {
            return FindValue(value);
        }
    }
    

    /// <summary>Image State
    /// </summary>
    public class ImageState : ConstantClass
    {


       /// <summary>Constant Available for ImageState
       /// </summary>
        public static readonly ImageState Available = new ImageState("available");
    

       /// <summary>Constant Deregistered for ImageState
       /// </summary>
        public static readonly ImageState Deregistered = new ImageState("deregistered");
    

        /// <summary>
        /// Default Constructor
        /// </summary>
        public ImageState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ImageState FindValue(string value)
        {
            return FindValue<ImageState>(value);
        }

        public static implicit operator ImageState(string value)
        {
            return FindValue(value);
        }
    }
    

    /// <summary>Instance Attribute Name
    /// </summary>
    public class InstanceAttributeName : ConstantClass
    {


       /// <summary>Constant BlockDeviceMapping for InstanceAttributeName
       /// </summary>
        public static readonly InstanceAttributeName BlockDeviceMapping = new InstanceAttributeName("blockDeviceMapping");
    

       /// <summary>Constant DisableApiTermination for InstanceAttributeName
       /// </summary>
        public static readonly InstanceAttributeName DisableApiTermination = new InstanceAttributeName("disableApiTermination");
    

       /// <summary>Constant EbsOptimized for InstanceAttributeName
       /// </summary>
        public static readonly InstanceAttributeName EbsOptimized = new InstanceAttributeName("ebsOptimized");
    

       /// <summary>Constant GroupSet for InstanceAttributeName
       /// </summary>
        public static readonly InstanceAttributeName GroupSet = new InstanceAttributeName("groupSet");
    

       /// <summary>Constant InstanceInitiatedShutdownBehavior for InstanceAttributeName
       /// </summary>
        public static readonly InstanceAttributeName InstanceInitiatedShutdownBehavior = new InstanceAttributeName("instanceInitiatedShutdownBehavior");
    

       /// <summary>Constant InstanceType for InstanceAttributeName
       /// </summary>
        public static readonly InstanceAttributeName InstanceType = new InstanceAttributeName("instanceType");
    

       /// <summary>Constant Kernel for InstanceAttributeName
       /// </summary>
        public static readonly InstanceAttributeName Kernel = new InstanceAttributeName("kernel");
    

       /// <summary>Constant ProductCodes for InstanceAttributeName
       /// </summary>
        public static readonly InstanceAttributeName ProductCodes = new InstanceAttributeName("productCodes");
    

       /// <summary>Constant Ramdisk for InstanceAttributeName
       /// </summary>
        public static readonly InstanceAttributeName Ramdisk = new InstanceAttributeName("ramdisk");
    

       /// <summary>Constant RootDeviceName for InstanceAttributeName
       /// </summary>
        public static readonly InstanceAttributeName RootDeviceName = new InstanceAttributeName("rootDeviceName");
    

       /// <summary>Constant SourceDestCheck for InstanceAttributeName
       /// </summary>
        public static readonly InstanceAttributeName SourceDestCheck = new InstanceAttributeName("sourceDestCheck");
    

       /// <summary>Constant UserData for InstanceAttributeName
       /// </summary>
        public static readonly InstanceAttributeName UserData = new InstanceAttributeName("userData");
    

        /// <summary>
        /// Default Constructor
        /// </summary>
        public InstanceAttributeName(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static InstanceAttributeName FindValue(string value)
        {
            return FindValue<InstanceAttributeName>(value);
        }

        public static implicit operator InstanceAttributeName(string value)
        {
            return FindValue(value);
        }
    }
    

    /// <summary>Instance State Name
    /// </summary>
    public class InstanceStateName : ConstantClass
    {


       /// <summary>Constant Pending for InstanceStateName
       /// </summary>
        public static readonly InstanceStateName Pending = new InstanceStateName("pending");
    

       /// <summary>Constant Running for InstanceStateName
       /// </summary>
        public static readonly InstanceStateName Running = new InstanceStateName("running");
    

       /// <summary>Constant ShuttingDown for InstanceStateName
       /// </summary>
        public static readonly InstanceStateName ShuttingDown = new InstanceStateName("shutting-down");
    

       /// <summary>Constant Stopped for InstanceStateName
       /// </summary>
        public static readonly InstanceStateName Stopped = new InstanceStateName("stopped");
    

       /// <summary>Constant Stopping for InstanceStateName
       /// </summary>
        public static readonly InstanceStateName Stopping = new InstanceStateName("stopping");
    

       /// <summary>Constant Terminated for InstanceStateName
       /// </summary>
        public static readonly InstanceStateName Terminated = new InstanceStateName("terminated");
    

        /// <summary>
        /// Default Constructor
        /// </summary>
        public InstanceStateName(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static InstanceStateName FindValue(string value)
        {
            return FindValue<InstanceStateName>(value);
        }

        public static implicit operator InstanceStateName(string value)
        {
            return FindValue(value);
        }
    }
    

    /// <summary>Instance Type
    /// </summary>
    public class InstanceType : ConstantClass
    {


       /// <summary>Constant C1Medium for InstanceType
       /// </summary>
        public static readonly InstanceType C1Medium = new InstanceType("c1.medium");
    

       /// <summary>Constant C1Xlarge for InstanceType
       /// </summary>
        public static readonly InstanceType C1Xlarge = new InstanceType("c1.xlarge");
    

       /// <summary>Constant Cc14xlarge for InstanceType
       /// </summary>
        public static readonly InstanceType Cc14xlarge = new InstanceType("cc1.4xlarge");
    

       /// <summary>Constant Cc28xlarge for InstanceType
       /// </summary>
        public static readonly InstanceType Cc28xlarge = new InstanceType("cc2.8xlarge");
    

       /// <summary>Constant Cg14xlarge for InstanceType
       /// </summary>
        public static readonly InstanceType Cg14xlarge = new InstanceType("cg1.4xlarge");
    

       /// <summary>Constant Cr18xlarge for InstanceType
       /// </summary>
        public static readonly InstanceType Cr18xlarge = new InstanceType("cr1.8xlarge");
    

       /// <summary>Constant Hi14xlarge for InstanceType
       /// </summary>
        public static readonly InstanceType Hi14xlarge = new InstanceType("hi1.4xlarge");
    

       /// <summary>Constant Hs18xlarge for InstanceType
       /// </summary>
        public static readonly InstanceType Hs18xlarge = new InstanceType("hs1.8xlarge");
    

       /// <summary>Constant M1Large for InstanceType
       /// </summary>
        public static readonly InstanceType M1Large = new InstanceType("m1.large");
    

       /// <summary>Constant M1Medium for InstanceType
       /// </summary>
        public static readonly InstanceType M1Medium = new InstanceType("m1.medium");
    

       /// <summary>Constant M1Small for InstanceType
       /// </summary>
        public static readonly InstanceType M1Small = new InstanceType("m1.small");
    

       /// <summary>Constant M1Xlarge for InstanceType
       /// </summary>
        public static readonly InstanceType M1Xlarge = new InstanceType("m1.xlarge");
    

       /// <summary>Constant M22xlarge for InstanceType
       /// </summary>
        public static readonly InstanceType M22xlarge = new InstanceType("m2.2xlarge");
    

       /// <summary>Constant M24xlarge for InstanceType
       /// </summary>
        public static readonly InstanceType M24xlarge = new InstanceType("m2.4xlarge");
    

       /// <summary>Constant M2Xlarge for InstanceType
       /// </summary>
        public static readonly InstanceType M2Xlarge = new InstanceType("m2.xlarge");
    

       /// <summary>Constant M32xlarge for InstanceType
       /// </summary>
        public static readonly InstanceType M32xlarge = new InstanceType("m3.2xlarge");
    

       /// <summary>Constant M3Xlarge for InstanceType
       /// </summary>
        public static readonly InstanceType M3Xlarge = new InstanceType("m3.xlarge");
    

       /// <summary>Constant T1Micro for InstanceType
       /// </summary>
        public static readonly InstanceType T1Micro = new InstanceType("t1.micro");
    

        /// <summary>
        /// Default Constructor
        /// </summary>
        public InstanceType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static InstanceType FindValue(string value)
        {
            return FindValue<InstanceType>(value);
        }

        public static implicit operator InstanceType(string value)
        {
            return FindValue(value);
        }
    }
    

    /// <summary>Placement Group State
    /// </summary>
    public class PlacementGroupState : ConstantClass
    {


       /// <summary>Constant Available for PlacementGroupState
       /// </summary>
        public static readonly PlacementGroupState Available = new PlacementGroupState("available");
    

       /// <summary>Constant Deleted for PlacementGroupState
       /// </summary>
        public static readonly PlacementGroupState Deleted = new PlacementGroupState("deleted");
    

       /// <summary>Constant Deleting for PlacementGroupState
       /// </summary>
        public static readonly PlacementGroupState Deleting = new PlacementGroupState("deleting");
    

       /// <summary>Constant Pending for PlacementGroupState
       /// </summary>
        public static readonly PlacementGroupState Pending = new PlacementGroupState("pending");
    

        /// <summary>
        /// Default Constructor
        /// </summary>
        public PlacementGroupState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PlacementGroupState FindValue(string value)
        {
            return FindValue<PlacementGroupState>(value);
        }

        public static implicit operator PlacementGroupState(string value)
        {
            return FindValue(value);
        }
    }
    

    /// <summary>Placement Strategy
    /// </summary>
    public class PlacementStrategy : ConstantClass
    {


       /// <summary>Constant Cluster for PlacementStrategy
       /// </summary>
        public static readonly PlacementStrategy Cluster = new PlacementStrategy("cluster");
    

        /// <summary>
        /// Default Constructor
        /// </summary>
        public PlacementStrategy(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PlacementStrategy FindValue(string value)
        {
            return FindValue<PlacementStrategy>(value);
        }

        public static implicit operator PlacementStrategy(string value)
        {
            return FindValue(value);
        }
    }
    

    /// <summary>Resource Type
    /// </summary>
    public class ResourceType : ConstantClass
    {


       /// <summary>Constant CustomerGateway for ResourceType
       /// </summary>
        public static readonly ResourceType CustomerGateway = new ResourceType("customer-gateway");
    

       /// <summary>Constant DhcpOptions for ResourceType
       /// </summary>
        public static readonly ResourceType DhcpOptions = new ResourceType("dhcp-options");
    

       /// <summary>Constant Image for ResourceType
       /// </summary>
        public static readonly ResourceType Image = new ResourceType("image");
    

       /// <summary>Constant Instance for ResourceType
       /// </summary>
        public static readonly ResourceType Instance = new ResourceType("instance");
    

       /// <summary>Constant Snapshot for ResourceType
       /// </summary>
        public static readonly ResourceType Snapshot = new ResourceType("snapshot");
    

       /// <summary>Constant SpotInstancesRequest for ResourceType
       /// </summary>
        public static readonly ResourceType SpotInstancesRequest = new ResourceType("spot-instances-request");
    

       /// <summary>Constant Subnet for ResourceType
       /// </summary>
        public static readonly ResourceType Subnet = new ResourceType("subnet");
    

       /// <summary>Constant Volume for ResourceType
       /// </summary>
        public static readonly ResourceType Volume = new ResourceType("volume");
    

       /// <summary>Constant Vpc for ResourceType
       /// </summary>
        public static readonly ResourceType Vpc = new ResourceType("vpc");
    

       /// <summary>Constant VpnConnection for ResourceType
       /// </summary>
        public static readonly ResourceType VpnConnection = new ResourceType("vpn-connection");
    

       /// <summary>Constant VpnGateway for ResourceType
       /// </summary>
        public static readonly ResourceType VpnGateway = new ResourceType("vpn-gateway");
    

        /// <summary>
        /// Default Constructor
        /// </summary>
        public ResourceType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ResourceType FindValue(string value)
        {
            return FindValue<ResourceType>(value);
        }

        public static implicit operator ResourceType(string value)
        {
            return FindValue(value);
        }
    }
    

    /// <summary>Rule Action
    /// </summary>
    public class RuleAction : ConstantClass
    {


       /// <summary>Constant Allow for RuleAction
       /// </summary>
        public static readonly RuleAction Allow = new RuleAction("allow");
    

       /// <summary>Constant Deny for RuleAction
       /// </summary>
        public static readonly RuleAction Deny = new RuleAction("deny");
    

        /// <summary>
        /// Default Constructor
        /// </summary>
        public RuleAction(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RuleAction FindValue(string value)
        {
            return FindValue<RuleAction>(value);
        }

        public static implicit operator RuleAction(string value)
        {
            return FindValue(value);
        }
    }
    

    /// <summary>Snapshot Attribute Name
    /// </summary>
    public class SnapshotAttributeName : ConstantClass
    {


       /// <summary>Constant CreateVolumePermission for SnapshotAttributeName
       /// </summary>
        public static readonly SnapshotAttributeName CreateVolumePermission = new SnapshotAttributeName("createVolumePermission");
    

       /// <summary>Constant ProductCodes for SnapshotAttributeName
       /// </summary>
        public static readonly SnapshotAttributeName ProductCodes = new SnapshotAttributeName("productCodes");
    

        /// <summary>
        /// Default Constructor
        /// </summary>
        public SnapshotAttributeName(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SnapshotAttributeName FindValue(string value)
        {
            return FindValue<SnapshotAttributeName>(value);
        }

        public static implicit operator SnapshotAttributeName(string value)
        {
            return FindValue(value);
        }
    }
    

    /// <summary>Snapshot State
    /// </summary>
    public class SnapshotState : ConstantClass
    {


       /// <summary>Constant Completed for SnapshotState
       /// </summary>
        public static readonly SnapshotState Completed = new SnapshotState("completed");
    

       /// <summary>Constant Error for SnapshotState
       /// </summary>
        public static readonly SnapshotState Error = new SnapshotState("error");
    

       /// <summary>Constant Pending for SnapshotState
       /// </summary>
        public static readonly SnapshotState Pending = new SnapshotState("pending");
    

        /// <summary>
        /// Default Constructor
        /// </summary>
        public SnapshotState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SnapshotState FindValue(string value)
        {
            return FindValue<SnapshotState>(value);
        }

        public static implicit operator SnapshotState(string value)
        {
            return FindValue(value);
        }
    }
    

    /// <summary>Spot Instance Type
    /// </summary>
    public class SpotInstanceType : ConstantClass
    {


       /// <summary>Constant OneTime for SpotInstanceType
       /// </summary>
        public static readonly SpotInstanceType OneTime = new SpotInstanceType("one-time");
    

       /// <summary>Constant Persistent for SpotInstanceType
       /// </summary>
        public static readonly SpotInstanceType Persistent = new SpotInstanceType("persistent");
    

        /// <summary>
        /// Default Constructor
        /// </summary>
        public SpotInstanceType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SpotInstanceType FindValue(string value)
        {
            return FindValue<SpotInstanceType>(value);
        }

        public static implicit operator SpotInstanceType(string value)
        {
            return FindValue(value);
        }
    }
    

    /// <summary>Virtualization Type
    /// </summary>
    public class VirtualizationType : ConstantClass
    {


       /// <summary>Constant Hvm for VirtualizationType
       /// </summary>
        public static readonly VirtualizationType Hvm = new VirtualizationType("hvm");
    

       /// <summary>Constant Paravirtual for VirtualizationType
       /// </summary>
        public static readonly VirtualizationType Paravirtual = new VirtualizationType("paravirtual");
    

        /// <summary>
        /// Default Constructor
        /// </summary>
        public VirtualizationType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static VirtualizationType FindValue(string value)
        {
            return FindValue<VirtualizationType>(value);
        }

        public static implicit operator VirtualizationType(string value)
        {
            return FindValue(value);
        }
    }
    

    /// <summary>Volume Attachment State
    /// </summary>
    public class VolumeAttachmentState : ConstantClass
    {


       /// <summary>Constant Attached for VolumeAttachmentState
       /// </summary>
        public static readonly VolumeAttachmentState Attached = new VolumeAttachmentState("attached");
    

       /// <summary>Constant Attaching for VolumeAttachmentState
       /// </summary>
        public static readonly VolumeAttachmentState Attaching = new VolumeAttachmentState("attaching");
    

       /// <summary>Constant Detached for VolumeAttachmentState
       /// </summary>
        public static readonly VolumeAttachmentState Detached = new VolumeAttachmentState("detached");
    

       /// <summary>Constant Detaching for VolumeAttachmentState
       /// </summary>
        public static readonly VolumeAttachmentState Detaching = new VolumeAttachmentState("detaching");
    

        /// <summary>
        /// Default Constructor
        /// </summary>
        public VolumeAttachmentState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static VolumeAttachmentState FindValue(string value)
        {
            return FindValue<VolumeAttachmentState>(value);
        }

        public static implicit operator VolumeAttachmentState(string value)
        {
            return FindValue(value);
        }
    }
    

    /// <summary>Volume Attribute Name
    /// </summary>
    public class VolumeAttributeName : ConstantClass
    {


       /// <summary>Constant AutoEnableIO for VolumeAttributeName
       /// </summary>
        public static readonly VolumeAttributeName AutoEnableIO = new VolumeAttributeName("autoEnableIO");
    

       /// <summary>Constant ProductCodes for VolumeAttributeName
       /// </summary>
        public static readonly VolumeAttributeName ProductCodes = new VolumeAttributeName("productCodes");
    

        /// <summary>
        /// Default Constructor
        /// </summary>
        public VolumeAttributeName(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static VolumeAttributeName FindValue(string value)
        {
            return FindValue<VolumeAttributeName>(value);
        }

        public static implicit operator VolumeAttributeName(string value)
        {
            return FindValue(value);
        }
    }
    

    /// <summary>Volume State
    /// </summary>
    public class VolumeState : ConstantClass
    {


       /// <summary>Constant Available for VolumeState
       /// </summary>
        public static readonly VolumeState Available = new VolumeState("available");
    

       /// <summary>Constant Creating for VolumeState
       /// </summary>
        public static readonly VolumeState Creating = new VolumeState("creating");
    

       /// <summary>Constant Deleting for VolumeState
       /// </summary>
        public static readonly VolumeState Deleting = new VolumeState("deleting");
    

       /// <summary>Constant Error for VolumeState
       /// </summary>
        public static readonly VolumeState Error = new VolumeState("error");
    

       /// <summary>Constant InUse for VolumeState
       /// </summary>
        public static readonly VolumeState InUse = new VolumeState("in-use");
    

        /// <summary>
        /// Default Constructor
        /// </summary>
        public VolumeState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static VolumeState FindValue(string value)
        {
            return FindValue<VolumeState>(value);
        }

        public static implicit operator VolumeState(string value)
        {
            return FindValue(value);
        }
    }
    

    /// <summary>Volume Type
    /// </summary>
    public class VolumeType : ConstantClass
    {


       /// <summary>Constant Io1 for VolumeType
       /// </summary>
        public static readonly VolumeType Io1 = new VolumeType("io1");
    

       /// <summary>Constant Standard for VolumeType
       /// </summary>
        public static readonly VolumeType Standard = new VolumeType("standard");
    

        /// <summary>
        /// Default Constructor
        /// </summary>
        public VolumeType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static VolumeType FindValue(string value)
        {
            return FindValue<VolumeType>(value);
        }

        public static implicit operator VolumeType(string value)
        {
            return FindValue(value);
        }
    }
    

    /// <summary>Vpc Attribute Name
    /// </summary>
    public class VpcAttributeName : ConstantClass
    {


       /// <summary>Constant EnableDnsHostnames for VpcAttributeName
       /// </summary>
        public static readonly VpcAttributeName EnableDnsHostnames = new VpcAttributeName("enableDnsHostnames");
    

       /// <summary>Constant EnableDnsSupport for VpcAttributeName
       /// </summary>
        public static readonly VpcAttributeName EnableDnsSupport = new VpcAttributeName("enableDnsSupport");
    

        /// <summary>
        /// Default Constructor
        /// </summary>
        public VpcAttributeName(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static VpcAttributeName FindValue(string value)
        {
            return FindValue<VpcAttributeName>(value);
        }

        public static implicit operator VpcAttributeName(string value)
        {
            return FindValue(value);
        }
    }
    

}
        
