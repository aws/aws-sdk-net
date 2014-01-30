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


    /// <summary>Account Attribute Name
    /// </summary>
    public class AccountAttributeName : ConstantClass
    {


       /// <summary>Constant DefaultVpc for AccountAttributeName
       /// </summary>
        public static readonly AccountAttributeName DefaultVpc = new AccountAttributeName("default-vpc");
    

       /// <summary>Constant SupportedPlatforms for AccountAttributeName
       /// </summary>
        public static readonly AccountAttributeName SupportedPlatforms = new AccountAttributeName("supported-platforms");
    

        /// <summary>
        /// Default Constructor
        /// </summary>
        public AccountAttributeName(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AccountAttributeName FindValue(string value)
        {
            return FindValue<AccountAttributeName>(value);
        }

        public static implicit operator AccountAttributeName(string value)
        {
            return FindValue(value);
        }
    }
    

    /// <summary>Architecture Values
    /// </summary>
    public class ArchitectureValues : ConstantClass
    {


       /// <summary>Constant I386 for ArchitectureValues
       /// </summary>
        public static readonly ArchitectureValues I386 = new ArchitectureValues("i386");
    

       /// <summary>Constant X86_64 for ArchitectureValues
       /// </summary>
        public static readonly ArchitectureValues X86_64 = new ArchitectureValues("x86_64");
    

        /// <summary>
        /// Default Constructor
        /// </summary>
        public ArchitectureValues(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ArchitectureValues FindValue(string value)
        {
            return FindValue<ArchitectureValues>(value);
        }

        public static implicit operator ArchitectureValues(string value)
        {
            return FindValue(value);
        }
    }
    

    /// <summary>Attachment Status
    /// </summary>
    public class AttachmentStatus : ConstantClass
    {


       /// <summary>Constant Attached for AttachmentStatus
       /// </summary>
        public static readonly AttachmentStatus Attached = new AttachmentStatus("attached");
    

       /// <summary>Constant Attaching for AttachmentStatus
       /// </summary>
        public static readonly AttachmentStatus Attaching = new AttachmentStatus("attaching");
    

       /// <summary>Constant Detached for AttachmentStatus
       /// </summary>
        public static readonly AttachmentStatus Detached = new AttachmentStatus("detached");
    

       /// <summary>Constant Detaching for AttachmentStatus
       /// </summary>
        public static readonly AttachmentStatus Detaching = new AttachmentStatus("detaching");
    

        /// <summary>
        /// Default Constructor
        /// </summary>
        public AttachmentStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AttachmentStatus FindValue(string value)
        {
            return FindValue<AttachmentStatus>(value);
        }

        public static implicit operator AttachmentStatus(string value)
        {
            return FindValue(value);
        }
    }
    

    /// <summary>Availability Zone State
    /// </summary>
    public class AvailabilityZoneState : ConstantClass
    {


       /// <summary>Constant Available for AvailabilityZoneState
       /// </summary>
        public static readonly AvailabilityZoneState Available = new AvailabilityZoneState("available");
    

        /// <summary>
        /// Default Constructor
        /// </summary>
        public AvailabilityZoneState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AvailabilityZoneState FindValue(string value)
        {
            return FindValue<AvailabilityZoneState>(value);
        }

        public static implicit operator AvailabilityZoneState(string value)
        {
            return FindValue(value);
        }
    }
    

    /// <summary>Bundle Task State
    /// </summary>
    public class BundleTaskState : ConstantClass
    {


       /// <summary>Constant Bundling for BundleTaskState
       /// </summary>
        public static readonly BundleTaskState Bundling = new BundleTaskState("bundling");
    

       /// <summary>Constant Cancelling for BundleTaskState
       /// </summary>
        public static readonly BundleTaskState Cancelling = new BundleTaskState("cancelling");
    

       /// <summary>Constant Complete for BundleTaskState
       /// </summary>
        public static readonly BundleTaskState Complete = new BundleTaskState("complete");
    

       /// <summary>Constant Failed for BundleTaskState
       /// </summary>
        public static readonly BundleTaskState Failed = new BundleTaskState("failed");
    

       /// <summary>Constant Pending for BundleTaskState
       /// </summary>
        public static readonly BundleTaskState Pending = new BundleTaskState("pending");
    

       /// <summary>Constant Storing for BundleTaskState
       /// </summary>
        public static readonly BundleTaskState Storing = new BundleTaskState("storing");
    

       /// <summary>Constant WaitingForShutdown for BundleTaskState
       /// </summary>
        public static readonly BundleTaskState WaitingForShutdown = new BundleTaskState("waiting-for-shutdown");
    

        /// <summary>
        /// Default Constructor
        /// </summary>
        public BundleTaskState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static BundleTaskState FindValue(string value)
        {
            return FindValue<BundleTaskState>(value);
        }

        public static implicit operator BundleTaskState(string value)
        {
            return FindValue(value);
        }
    }
    

    /// <summary>Cancel Spot Instance Request State
    /// </summary>
    public class CancelSpotInstanceRequestState : ConstantClass
    {


       /// <summary>Constant Active for CancelSpotInstanceRequestState
       /// </summary>
        public static readonly CancelSpotInstanceRequestState Active = new CancelSpotInstanceRequestState("active");
    

       /// <summary>Constant Cancelled for CancelSpotInstanceRequestState
       /// </summary>
        public static readonly CancelSpotInstanceRequestState Cancelled = new CancelSpotInstanceRequestState("cancelled");
    

       /// <summary>Constant Closed for CancelSpotInstanceRequestState
       /// </summary>
        public static readonly CancelSpotInstanceRequestState Closed = new CancelSpotInstanceRequestState("closed");
    

       /// <summary>Constant Completed for CancelSpotInstanceRequestState
       /// </summary>
        public static readonly CancelSpotInstanceRequestState Completed = new CancelSpotInstanceRequestState("completed");
    

       /// <summary>Constant Open for CancelSpotInstanceRequestState
       /// </summary>
        public static readonly CancelSpotInstanceRequestState Open = new CancelSpotInstanceRequestState("open");
    

        /// <summary>
        /// Default Constructor
        /// </summary>
        public CancelSpotInstanceRequestState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CancelSpotInstanceRequestState FindValue(string value)
        {
            return FindValue<CancelSpotInstanceRequestState>(value);
        }

        public static implicit operator CancelSpotInstanceRequestState(string value)
        {
            return FindValue(value);
        }
    }
    

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
    

    /// <summary>Conversion Task State
    /// </summary>
    public class ConversionTaskState : ConstantClass
    {


       /// <summary>Constant Active for ConversionTaskState
       /// </summary>
        public static readonly ConversionTaskState Active = new ConversionTaskState("active");
    

       /// <summary>Constant Cancelled for ConversionTaskState
       /// </summary>
        public static readonly ConversionTaskState Cancelled = new ConversionTaskState("cancelled");
    

       /// <summary>Constant Cancelling for ConversionTaskState
       /// </summary>
        public static readonly ConversionTaskState Cancelling = new ConversionTaskState("cancelling");
    

       /// <summary>Constant Completed for ConversionTaskState
       /// </summary>
        public static readonly ConversionTaskState Completed = new ConversionTaskState("completed");
    

        /// <summary>
        /// Default Constructor
        /// </summary>
        public ConversionTaskState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ConversionTaskState FindValue(string value)
        {
            return FindValue<ConversionTaskState>(value);
        }

        public static implicit operator ConversionTaskState(string value)
        {
            return FindValue(value);
        }
    }
    

    /// <summary>Currency Code Values
    /// </summary>
    public class CurrencyCodeValues : ConstantClass
    {


       /// <summary>Constant USD for CurrencyCodeValues
       /// </summary>
        public static readonly CurrencyCodeValues USD = new CurrencyCodeValues("USD");
    

        /// <summary>
        /// Default Constructor
        /// </summary>
        public CurrencyCodeValues(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CurrencyCodeValues FindValue(string value)
        {
            return FindValue<CurrencyCodeValues>(value);
        }

        public static implicit operator CurrencyCodeValues(string value)
        {
            return FindValue(value);
        }
    }
    

    /// <summary>Datafeed Subscription State
    /// </summary>
    public class DatafeedSubscriptionState : ConstantClass
    {


       /// <summary>Constant Active for DatafeedSubscriptionState
       /// </summary>
        public static readonly DatafeedSubscriptionState Active = new DatafeedSubscriptionState("Active");
    

       /// <summary>Constant Inactive for DatafeedSubscriptionState
       /// </summary>
        public static readonly DatafeedSubscriptionState Inactive = new DatafeedSubscriptionState("Inactive");
    

        /// <summary>
        /// Default Constructor
        /// </summary>
        public DatafeedSubscriptionState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DatafeedSubscriptionState FindValue(string value)
        {
            return FindValue<DatafeedSubscriptionState>(value);
        }

        public static implicit operator DatafeedSubscriptionState(string value)
        {
            return FindValue(value);
        }
    }
    

    /// <summary>Device Type
    /// </summary>
    public class DeviceType : ConstantClass
    {


       /// <summary>Constant Ebs for DeviceType
       /// </summary>
        public static readonly DeviceType Ebs = new DeviceType("ebs");
    

       /// <summary>Constant InstanceStore for DeviceType
       /// </summary>
        public static readonly DeviceType InstanceStore = new DeviceType("instance-store");
    

        /// <summary>
        /// Default Constructor
        /// </summary>
        public DeviceType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DeviceType FindValue(string value)
        {
            return FindValue<DeviceType>(value);
        }

        public static implicit operator DeviceType(string value)
        {
            return FindValue(value);
        }
    }
    

    /// <summary>Disk Image Format
    /// </summary>
    public class DiskImageFormat : ConstantClass
    {


       /// <summary>Constant RAW for DiskImageFormat
       /// </summary>
        public static readonly DiskImageFormat RAW = new DiskImageFormat("RAW");
    

       /// <summary>Constant VHD for DiskImageFormat
       /// </summary>
        public static readonly DiskImageFormat VHD = new DiskImageFormat("VHD");
    

       /// <summary>Constant VMDK for DiskImageFormat
       /// </summary>
        public static readonly DiskImageFormat VMDK = new DiskImageFormat("VMDK");
    

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
    

    /// <summary>Event Code
    /// </summary>
    public class EventCode : ConstantClass
    {


       /// <summary>Constant InstanceReboot for EventCode
       /// </summary>
        public static readonly EventCode InstanceReboot = new EventCode("instance-reboot");
    

       /// <summary>Constant InstanceRetirement for EventCode
       /// </summary>
        public static readonly EventCode InstanceRetirement = new EventCode("instance-retirement");
    

       /// <summary>Constant InstanceStop for EventCode
       /// </summary>
        public static readonly EventCode InstanceStop = new EventCode("instance-stop");
    

       /// <summary>Constant SystemMaintenance for EventCode
       /// </summary>
        public static readonly EventCode SystemMaintenance = new EventCode("system-maintenance");
    

       /// <summary>Constant SystemReboot for EventCode
       /// </summary>
        public static readonly EventCode SystemReboot = new EventCode("system-reboot");
    

        /// <summary>
        /// Default Constructor
        /// </summary>
        public EventCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EventCode FindValue(string value)
        {
            return FindValue<EventCode>(value);
        }

        public static implicit operator EventCode(string value)
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
    

       /// <summary>Constant Microsoft for ExportEnvironment
       /// </summary>
        public static readonly ExportEnvironment Microsoft = new ExportEnvironment("microsoft");
    

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
    

    /// <summary>Export Task State
    /// </summary>
    public class ExportTaskState : ConstantClass
    {


       /// <summary>Constant Active for ExportTaskState
       /// </summary>
        public static readonly ExportTaskState Active = new ExportTaskState("active");
    

       /// <summary>Constant Cancelled for ExportTaskState
       /// </summary>
        public static readonly ExportTaskState Cancelled = new ExportTaskState("cancelled");
    

       /// <summary>Constant Cancelling for ExportTaskState
       /// </summary>
        public static readonly ExportTaskState Cancelling = new ExportTaskState("cancelling");
    

       /// <summary>Constant Completed for ExportTaskState
       /// </summary>
        public static readonly ExportTaskState Completed = new ExportTaskState("completed");
    

        /// <summary>
        /// Default Constructor
        /// </summary>
        public ExportTaskState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ExportTaskState FindValue(string value)
        {
            return FindValue<ExportTaskState>(value);
        }

        public static implicit operator ExportTaskState(string value)
        {
            return FindValue(value);
        }
    }
    

    /// <summary>Gateway Type
    /// </summary>
    public class GatewayType : ConstantClass
    {


       /// <summary>Constant Ipsec1 for GatewayType
       /// </summary>
        public static readonly GatewayType Ipsec1 = new GatewayType("ipsec.1");
    

        /// <summary>
        /// Default Constructor
        /// </summary>
        public GatewayType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static GatewayType FindValue(string value)
        {
            return FindValue<GatewayType>(value);
        }

        public static implicit operator GatewayType(string value)
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
    

    /// <summary>Image Attribute Name
    /// </summary>
    public class ImageAttributeName : ConstantClass
    {


       /// <summary>Constant BlockDeviceMapping for ImageAttributeName
       /// </summary>
        public static readonly ImageAttributeName BlockDeviceMapping = new ImageAttributeName("blockDeviceMapping");
    

       /// <summary>Constant Description for ImageAttributeName
       /// </summary>
        public static readonly ImageAttributeName Description = new ImageAttributeName("description");
    

       /// <summary>Constant Kernel for ImageAttributeName
       /// </summary>
        public static readonly ImageAttributeName Kernel = new ImageAttributeName("kernel");
    

       /// <summary>Constant LaunchPermission for ImageAttributeName
       /// </summary>
        public static readonly ImageAttributeName LaunchPermission = new ImageAttributeName("launchPermission");
    

       /// <summary>Constant ProductCodes for ImageAttributeName
       /// </summary>
        public static readonly ImageAttributeName ProductCodes = new ImageAttributeName("productCodes");
    

       /// <summary>Constant Ramdisk for ImageAttributeName
       /// </summary>
        public static readonly ImageAttributeName Ramdisk = new ImageAttributeName("ramdisk");
    

        /// <summary>
        /// Default Constructor
        /// </summary>
        public ImageAttributeName(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ImageAttributeName FindValue(string value)
        {
            return FindValue<ImageAttributeName>(value);
        }

        public static implicit operator ImageAttributeName(string value)
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
    

    /// <summary>Image Type Values
    /// </summary>
    public class ImageTypeValues : ConstantClass
    {


       /// <summary>Constant Kernel for ImageTypeValues
       /// </summary>
        public static readonly ImageTypeValues Kernel = new ImageTypeValues("kernel");
    

       /// <summary>Constant Machine for ImageTypeValues
       /// </summary>
        public static readonly ImageTypeValues Machine = new ImageTypeValues("machine");
    

       /// <summary>Constant Ramdisk for ImageTypeValues
       /// </summary>
        public static readonly ImageTypeValues Ramdisk = new ImageTypeValues("ramdisk");
    

        /// <summary>
        /// Default Constructor
        /// </summary>
        public ImageTypeValues(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ImageTypeValues FindValue(string value)
        {
            return FindValue<ImageTypeValues>(value);
        }

        public static implicit operator ImageTypeValues(string value)
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
    

    /// <summary>Instance Lifecycle Type
    /// </summary>
    public class InstanceLifecycleType : ConstantClass
    {


       /// <summary>Constant Spot for InstanceLifecycleType
       /// </summary>
        public static readonly InstanceLifecycleType Spot = new InstanceLifecycleType("spot");
    

        /// <summary>
        /// Default Constructor
        /// </summary>
        public InstanceLifecycleType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static InstanceLifecycleType FindValue(string value)
        {
            return FindValue<InstanceLifecycleType>(value);
        }

        public static implicit operator InstanceLifecycleType(string value)
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
    

       /// <summary>Constant C32xlarge for InstanceType
       /// </summary>
        public static readonly InstanceType C32xlarge = new InstanceType("c3.2xlarge");
    

       /// <summary>Constant C34xlarge for InstanceType
       /// </summary>
        public static readonly InstanceType C34xlarge = new InstanceType("c3.4xlarge");
    

       /// <summary>Constant C38xlarge for InstanceType
       /// </summary>
        public static readonly InstanceType C38xlarge = new InstanceType("c3.8xlarge");
    

       /// <summary>Constant C3Large for InstanceType
       /// </summary>
        public static readonly InstanceType C3Large = new InstanceType("c3.large");
    

       /// <summary>Constant C3Xlarge for InstanceType
       /// </summary>
        public static readonly InstanceType C3Xlarge = new InstanceType("c3.xlarge");
    

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
    

       /// <summary>Constant G22xlarge for InstanceType
       /// </summary>
        public static readonly InstanceType G22xlarge = new InstanceType("g2.2xlarge");
    

       /// <summary>Constant Hi14xlarge for InstanceType
       /// </summary>
        public static readonly InstanceType Hi14xlarge = new InstanceType("hi1.4xlarge");
    

       /// <summary>Constant Hs18xlarge for InstanceType
       /// </summary>
        public static readonly InstanceType Hs18xlarge = new InstanceType("hs1.8xlarge");
    

       /// <summary>Constant I22xlarge for InstanceType
       /// </summary>
        public static readonly InstanceType I22xlarge = new InstanceType("i2.2xlarge");
    

       /// <summary>Constant I24xlarge for InstanceType
       /// </summary>
        public static readonly InstanceType I24xlarge = new InstanceType("i2.4xlarge");
    

       /// <summary>Constant I28xlarge for InstanceType
       /// </summary>
        public static readonly InstanceType I28xlarge = new InstanceType("i2.8xlarge");
    

       /// <summary>Constant I2Xlarge for InstanceType
       /// </summary>
        public static readonly InstanceType I2Xlarge = new InstanceType("i2.xlarge");
    

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

        /// <summary>Constant M3Large for InstanceType
        /// </summary>
        public static readonly InstanceType M3Large = new InstanceType("m3.large");

        /// <summary>Constant M3Medium for InstanceType
        /// </summary>
        public static readonly InstanceType M3Medium = new InstanceType("m3.medium");

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
    

    /// <summary>Listing State
    /// </summary>
    public class ListingState : ConstantClass
    {


       /// <summary>Constant Available for ListingState
       /// </summary>
        public static readonly ListingState Available = new ListingState("available");
    

       /// <summary>Constant Cancelled for ListingState
       /// </summary>
        public static readonly ListingState Cancelled = new ListingState("cancelled");
    

       /// <summary>Constant Pending for ListingState
       /// </summary>
        public static readonly ListingState Pending = new ListingState("pending");
    

       /// <summary>Constant Sold for ListingState
       /// </summary>
        public static readonly ListingState Sold = new ListingState("sold");
    

        /// <summary>
        /// Default Constructor
        /// </summary>
        public ListingState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ListingState FindValue(string value)
        {
            return FindValue<ListingState>(value);
        }

        public static implicit operator ListingState(string value)
        {
            return FindValue(value);
        }
    }
    

    /// <summary>Listing Status
    /// </summary>
    public class ListingStatus : ConstantClass
    {


       /// <summary>Constant Active for ListingStatus
       /// </summary>
        public static readonly ListingStatus Active = new ListingStatus("active");
    

       /// <summary>Constant Cancelled for ListingStatus
       /// </summary>
        public static readonly ListingStatus Cancelled = new ListingStatus("cancelled");
    

       /// <summary>Constant Closed for ListingStatus
       /// </summary>
        public static readonly ListingStatus Closed = new ListingStatus("closed");
    

       /// <summary>Constant Pending for ListingStatus
       /// </summary>
        public static readonly ListingStatus Pending = new ListingStatus("pending");
    

        /// <summary>
        /// Default Constructor
        /// </summary>
        public ListingStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ListingStatus FindValue(string value)
        {
            return FindValue<ListingStatus>(value);
        }

        public static implicit operator ListingStatus(string value)
        {
            return FindValue(value);
        }
    }
    

    /// <summary>Monitoring State
    /// </summary>
    public class MonitoringState : ConstantClass
    {


       /// <summary>Constant Disabled for MonitoringState
       /// </summary>
        public static readonly MonitoringState Disabled = new MonitoringState("disabled");
    

       /// <summary>Constant Enabled for MonitoringState
       /// </summary>
        public static readonly MonitoringState Enabled = new MonitoringState("enabled");
    

       /// <summary>Constant Pending for MonitoringState
       /// </summary>
        public static readonly MonitoringState Pending = new MonitoringState("pending");
    

        /// <summary>
        /// Default Constructor
        /// </summary>
        public MonitoringState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MonitoringState FindValue(string value)
        {
            return FindValue<MonitoringState>(value);
        }

        public static implicit operator MonitoringState(string value)
        {
            return FindValue(value);
        }
    }
    

    /// <summary>Network Interface Status
    /// </summary>
    public class NetworkInterfaceStatus : ConstantClass
    {


       /// <summary>Constant Attaching for NetworkInterfaceStatus
       /// </summary>
        public static readonly NetworkInterfaceStatus Attaching = new NetworkInterfaceStatus("attaching");
    

       /// <summary>Constant Available for NetworkInterfaceStatus
       /// </summary>
        public static readonly NetworkInterfaceStatus Available = new NetworkInterfaceStatus("available");
    

       /// <summary>Constant Detaching for NetworkInterfaceStatus
       /// </summary>
        public static readonly NetworkInterfaceStatus Detaching = new NetworkInterfaceStatus("detaching");
    

       /// <summary>Constant InUse for NetworkInterfaceStatus
       /// </summary>
        public static readonly NetworkInterfaceStatus InUse = new NetworkInterfaceStatus("in-use");
    

        /// <summary>
        /// Default Constructor
        /// </summary>
        public NetworkInterfaceStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static NetworkInterfaceStatus FindValue(string value)
        {
            return FindValue<NetworkInterfaceStatus>(value);
        }

        public static implicit operator NetworkInterfaceStatus(string value)
        {
            return FindValue(value);
        }
    }
    

    /// <summary>Offering Type Values
    /// </summary>
    public class OfferingTypeValues : ConstantClass
    {


       /// <summary>Constant HeavyUtilization for OfferingTypeValues
       /// </summary>
        public static readonly OfferingTypeValues HeavyUtilization = new OfferingTypeValues("Heavy Utilization");
    

       /// <summary>Constant LightUtilization for OfferingTypeValues
       /// </summary>
        public static readonly OfferingTypeValues LightUtilization = new OfferingTypeValues("Light Utilization");
    

       /// <summary>Constant MediumUtilization for OfferingTypeValues
       /// </summary>
        public static readonly OfferingTypeValues MediumUtilization = new OfferingTypeValues("Medium Utilization");
    

        /// <summary>
        /// Default Constructor
        /// </summary>
        public OfferingTypeValues(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static OfferingTypeValues FindValue(string value)
        {
            return FindValue<OfferingTypeValues>(value);
        }

        public static implicit operator OfferingTypeValues(string value)
        {
            return FindValue(value);
        }
    }
    

    /// <summary>Permission Group
    /// </summary>
    public class PermissionGroup : ConstantClass
    {


       /// <summary>Constant All for PermissionGroup
       /// </summary>
        public static readonly PermissionGroup All = new PermissionGroup("all");
    

        /// <summary>
        /// Default Constructor
        /// </summary>
        public PermissionGroup(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PermissionGroup FindValue(string value)
        {
            return FindValue<PermissionGroup>(value);
        }

        public static implicit operator PermissionGroup(string value)
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
    

    /// <summary>Platform Values
    /// </summary>
    public class PlatformValues : ConstantClass
    {


       /// <summary>Constant Windows for PlatformValues
       /// </summary>
        public static readonly PlatformValues Windows = new PlatformValues("Windows");
    

        /// <summary>
        /// Default Constructor
        /// </summary>
        public PlatformValues(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PlatformValues FindValue(string value)
        {
            return FindValue<PlatformValues>(value);
        }

        public static implicit operator PlatformValues(string value)
        {
            return FindValue(value);
        }
    }
    

    /// <summary>Product Code Values
    /// </summary>
    public class ProductCodeValues : ConstantClass
    {


       /// <summary>Constant Devpay for ProductCodeValues
       /// </summary>
        public static readonly ProductCodeValues Devpay = new ProductCodeValues("devpay");
    

       /// <summary>Constant Marketplace for ProductCodeValues
       /// </summary>
        public static readonly ProductCodeValues Marketplace = new ProductCodeValues("marketplace");
    

        /// <summary>
        /// Default Constructor
        /// </summary>
        public ProductCodeValues(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ProductCodeValues FindValue(string value)
        {
            return FindValue<ProductCodeValues>(value);
        }

        public static implicit operator ProductCodeValues(string value)
        {
            return FindValue(value);
        }
    }
    

    /// <summary>R I Product Description
    /// </summary>
    public class RIProductDescription : ConstantClass
    {


       /// <summary>Constant LinuxUNIX for RIProductDescription
       /// </summary>
        public static readonly RIProductDescription LinuxUNIX = new RIProductDescription("Linux/UNIX");
    

       /// <summary>Constant LinuxUNIXAmazonVPC for RIProductDescription
       /// </summary>
        public static readonly RIProductDescription LinuxUNIXAmazonVPC = new RIProductDescription("Linux/UNIX (Amazon VPC)");
    

       /// <summary>Constant Windows for RIProductDescription
       /// </summary>
        public static readonly RIProductDescription Windows = new RIProductDescription("Windows");
    

       /// <summary>Constant WindowsAmazonVPC for RIProductDescription
       /// </summary>
        public static readonly RIProductDescription WindowsAmazonVPC = new RIProductDescription("Windows (Amazon VPC)");
    

        /// <summary>
        /// Default Constructor
        /// </summary>
        public RIProductDescription(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RIProductDescription FindValue(string value)
        {
            return FindValue<RIProductDescription>(value);
        }

        public static implicit operator RIProductDescription(string value)
        {
            return FindValue(value);
        }
    }
    

    /// <summary>Recurring Charge Frequency
    /// </summary>
    public class RecurringChargeFrequency : ConstantClass
    {


       /// <summary>Constant Hourly for RecurringChargeFrequency
       /// </summary>
        public static readonly RecurringChargeFrequency Hourly = new RecurringChargeFrequency("Hourly");
    

        /// <summary>
        /// Default Constructor
        /// </summary>
        public RecurringChargeFrequency(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RecurringChargeFrequency FindValue(string value)
        {
            return FindValue<RecurringChargeFrequency>(value);
        }

        public static implicit operator RecurringChargeFrequency(string value)
        {
            return FindValue(value);
        }
    }
    

    /// <summary>Report Instance Reason Codes
    /// </summary>
    public class ReportInstanceReasonCodes : ConstantClass
    {


       /// <summary>Constant InstanceStuckInState for ReportInstanceReasonCodes
       /// </summary>
        public static readonly ReportInstanceReasonCodes InstanceStuckInState = new ReportInstanceReasonCodes("instance-stuck-in-state");
    

       /// <summary>Constant NotAcceptingCredentials for ReportInstanceReasonCodes
       /// </summary>
        public static readonly ReportInstanceReasonCodes NotAcceptingCredentials = new ReportInstanceReasonCodes("not-accepting-credentials");
    

       /// <summary>Constant Other for ReportInstanceReasonCodes
       /// </summary>
        public static readonly ReportInstanceReasonCodes Other = new ReportInstanceReasonCodes("other");
    

       /// <summary>Constant PasswordNotAvailable for ReportInstanceReasonCodes
       /// </summary>
        public static readonly ReportInstanceReasonCodes PasswordNotAvailable = new ReportInstanceReasonCodes("password-not-available");
    

       /// <summary>Constant PerformanceEbsVolume for ReportInstanceReasonCodes
       /// </summary>
        public static readonly ReportInstanceReasonCodes PerformanceEbsVolume = new ReportInstanceReasonCodes("performance-ebs-volume");
    

       /// <summary>Constant PerformanceInstanceStore for ReportInstanceReasonCodes
       /// </summary>
        public static readonly ReportInstanceReasonCodes PerformanceInstanceStore = new ReportInstanceReasonCodes("performance-instance-store");
    

       /// <summary>Constant PerformanceNetwork for ReportInstanceReasonCodes
       /// </summary>
        public static readonly ReportInstanceReasonCodes PerformanceNetwork = new ReportInstanceReasonCodes("performance-network");
    

       /// <summary>Constant PerformanceOther for ReportInstanceReasonCodes
       /// </summary>
        public static readonly ReportInstanceReasonCodes PerformanceOther = new ReportInstanceReasonCodes("performance-other");
    

       /// <summary>Constant Unresponsive for ReportInstanceReasonCodes
       /// </summary>
        public static readonly ReportInstanceReasonCodes Unresponsive = new ReportInstanceReasonCodes("unresponsive");
    

        /// <summary>
        /// Default Constructor
        /// </summary>
        public ReportInstanceReasonCodes(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ReportInstanceReasonCodes FindValue(string value)
        {
            return FindValue<ReportInstanceReasonCodes>(value);
        }

        public static implicit operator ReportInstanceReasonCodes(string value)
        {
            return FindValue(value);
        }
    }
    

    /// <summary>Report Status Type
    /// </summary>
    public class ReportStatusType : ConstantClass
    {


       /// <summary>Constant Impaired for ReportStatusType
       /// </summary>
        public static readonly ReportStatusType Impaired = new ReportStatusType("impaired");
    

       /// <summary>Constant Ok for ReportStatusType
       /// </summary>
        public static readonly ReportStatusType Ok = new ReportStatusType("ok");
    

        /// <summary>
        /// Default Constructor
        /// </summary>
        public ReportStatusType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ReportStatusType FindValue(string value)
        {
            return FindValue<ReportStatusType>(value);
        }

        public static implicit operator ReportStatusType(string value)
        {
            return FindValue(value);
        }
    }
    

    /// <summary>Reserved Instance State
    /// </summary>
    public class ReservedInstanceState : ConstantClass
    {


       /// <summary>Constant Active for ReservedInstanceState
       /// </summary>
        public static readonly ReservedInstanceState Active = new ReservedInstanceState("active");
    

       /// <summary>Constant PaymentFailed for ReservedInstanceState
       /// </summary>
        public static readonly ReservedInstanceState PaymentFailed = new ReservedInstanceState("payment-failed");
    

       /// <summary>Constant PaymentPending for ReservedInstanceState
       /// </summary>
        public static readonly ReservedInstanceState PaymentPending = new ReservedInstanceState("payment-pending");
    

       /// <summary>Constant Retired for ReservedInstanceState
       /// </summary>
        public static readonly ReservedInstanceState Retired = new ReservedInstanceState("retired");
    

        /// <summary>
        /// Default Constructor
        /// </summary>
        public ReservedInstanceState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ReservedInstanceState FindValue(string value)
        {
            return FindValue<ReservedInstanceState>(value);
        }

        public static implicit operator ReservedInstanceState(string value)
        {
            return FindValue(value);
        }
    }
    

    /// <summary>Reset Image Attribute Name
    /// </summary>
    public class ResetImageAttributeName : ConstantClass
    {


       /// <summary>Constant LaunchPermission for ResetImageAttributeName
       /// </summary>
        public static readonly ResetImageAttributeName LaunchPermission = new ResetImageAttributeName("launchPermission");
    

        /// <summary>
        /// Default Constructor
        /// </summary>
        public ResetImageAttributeName(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ResetImageAttributeName FindValue(string value)
        {
            return FindValue<ResetImageAttributeName>(value);
        }

        public static implicit operator ResetImageAttributeName(string value)
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
    

       /// <summary>Constant InternetGateway for ResourceType
       /// </summary>
        public static readonly ResourceType InternetGateway = new ResourceType("internet-gateway");
    

       /// <summary>Constant NetworkAcl for ResourceType
       /// </summary>
        public static readonly ResourceType NetworkAcl = new ResourceType("network-acl");
    

       /// <summary>Constant NetworkInterface for ResourceType
       /// </summary>
        public static readonly ResourceType NetworkInterface = new ResourceType("network-interface");
    

       /// <summary>Constant ReservedInstances for ResourceType
       /// </summary>
        public static readonly ResourceType ReservedInstances = new ResourceType("reserved-instances");
    

       /// <summary>Constant RouteTable for ResourceType
       /// </summary>
        public static readonly ResourceType RouteTable = new ResourceType("route-table");
    

       /// <summary>Constant SecurityGroup for ResourceType
       /// </summary>
        public static readonly ResourceType SecurityGroup = new ResourceType("security-group");
    

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
    

    /// <summary>Route State
    /// </summary>
    public class RouteState : ConstantClass
    {


       /// <summary>Constant Active for RouteState
       /// </summary>
        public static readonly RouteState Active = new RouteState("active");
    

       /// <summary>Constant Blackhole for RouteState
       /// </summary>
        public static readonly RouteState Blackhole = new RouteState("blackhole");
    

        /// <summary>
        /// Default Constructor
        /// </summary>
        public RouteState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RouteState FindValue(string value)
        {
            return FindValue<RouteState>(value);
        }

        public static implicit operator RouteState(string value)
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
    

    /// <summary>Shutdown Behavior
    /// </summary>
    public class ShutdownBehavior : ConstantClass
    {


       /// <summary>Constant Stop for ShutdownBehavior
       /// </summary>
        public static readonly ShutdownBehavior Stop = new ShutdownBehavior("stop");
    

       /// <summary>Constant Terminate for ShutdownBehavior
       /// </summary>
        public static readonly ShutdownBehavior Terminate = new ShutdownBehavior("terminate");
    

        /// <summary>
        /// Default Constructor
        /// </summary>
        public ShutdownBehavior(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ShutdownBehavior FindValue(string value)
        {
            return FindValue<ShutdownBehavior>(value);
        }

        public static implicit operator ShutdownBehavior(string value)
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
    

    /// <summary>Spot Instance State
    /// </summary>
    public class SpotInstanceState : ConstantClass
    {


       /// <summary>Constant Active for SpotInstanceState
       /// </summary>
        public static readonly SpotInstanceState Active = new SpotInstanceState("active");
    

       /// <summary>Constant Cancelled for SpotInstanceState
       /// </summary>
        public static readonly SpotInstanceState Cancelled = new SpotInstanceState("cancelled");
    

       /// <summary>Constant Closed for SpotInstanceState
       /// </summary>
        public static readonly SpotInstanceState Closed = new SpotInstanceState("closed");
    

       /// <summary>Constant Failed for SpotInstanceState
       /// </summary>
        public static readonly SpotInstanceState Failed = new SpotInstanceState("failed");
    

       /// <summary>Constant Open for SpotInstanceState
       /// </summary>
        public static readonly SpotInstanceState Open = new SpotInstanceState("open");
    

        /// <summary>
        /// Default Constructor
        /// </summary>
        public SpotInstanceState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SpotInstanceState FindValue(string value)
        {
            return FindValue<SpotInstanceState>(value);
        }

        public static implicit operator SpotInstanceState(string value)
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
    

    /// <summary>Status Name
    /// </summary>
    public class StatusName : ConstantClass
    {


       /// <summary>Constant Reachability for StatusName
       /// </summary>
        public static readonly StatusName Reachability = new StatusName("reachability");
    

        /// <summary>
        /// Default Constructor
        /// </summary>
        public StatusName(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static StatusName FindValue(string value)
        {
            return FindValue<StatusName>(value);
        }

        public static implicit operator StatusName(string value)
        {
            return FindValue(value);
        }
    }
    

    /// <summary>Status Type
    /// </summary>
    public class StatusType : ConstantClass
    {


       /// <summary>Constant Failed for StatusType
       /// </summary>
        public static readonly StatusType Failed = new StatusType("failed");
    

       /// <summary>Constant InsufficientData for StatusType
       /// </summary>
        public static readonly StatusType InsufficientData = new StatusType("insufficient-data");
    

       /// <summary>Constant Passed for StatusType
       /// </summary>
        public static readonly StatusType Passed = new StatusType("passed");
    

        /// <summary>
        /// Default Constructor
        /// </summary>
        public StatusType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static StatusType FindValue(string value)
        {
            return FindValue<StatusType>(value);
        }

        public static implicit operator StatusType(string value)
        {
            return FindValue(value);
        }
    }
    

    /// <summary>Subnet State
    /// </summary>
    public class SubnetState : ConstantClass
    {


       /// <summary>Constant Available for SubnetState
       /// </summary>
        public static readonly SubnetState Available = new SubnetState("available");
    

       /// <summary>Constant Pending for SubnetState
       /// </summary>
        public static readonly SubnetState Pending = new SubnetState("pending");
    

        /// <summary>
        /// Default Constructor
        /// </summary>
        public SubnetState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SubnetState FindValue(string value)
        {
            return FindValue<SubnetState>(value);
        }

        public static implicit operator SubnetState(string value)
        {
            return FindValue(value);
        }
    }
    

    /// <summary>Summary Status
    /// </summary>
    public class SummaryStatus : ConstantClass
    {


       /// <summary>Constant Impaired for SummaryStatus
       /// </summary>
        public static readonly SummaryStatus Impaired = new SummaryStatus("impaired");
    

       /// <summary>Constant InsufficientData for SummaryStatus
       /// </summary>
        public static readonly SummaryStatus InsufficientData = new SummaryStatus("insufficient-data");
    

       /// <summary>Constant NotApplicable for SummaryStatus
       /// </summary>
        public static readonly SummaryStatus NotApplicable = new SummaryStatus("not-applicable");
    

       /// <summary>Constant Ok for SummaryStatus
       /// </summary>
        public static readonly SummaryStatus Ok = new SummaryStatus("ok");
    

        /// <summary>
        /// Default Constructor
        /// </summary>
        public SummaryStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SummaryStatus FindValue(string value)
        {
            return FindValue<SummaryStatus>(value);
        }

        public static implicit operator SummaryStatus(string value)
        {
            return FindValue(value);
        }
    }
    

    /// <summary>Telemetry Status
    /// </summary>
    public class TelemetryStatus : ConstantClass
    {


       /// <summary>Constant DOWN for TelemetryStatus
       /// </summary>
        public static readonly TelemetryStatus DOWN = new TelemetryStatus("DOWN");
    

       /// <summary>Constant UP for TelemetryStatus
       /// </summary>
        public static readonly TelemetryStatus UP = new TelemetryStatus("UP");
    

        /// <summary>
        /// Default Constructor
        /// </summary>
        public TelemetryStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TelemetryStatus FindValue(string value)
        {
            return FindValue<TelemetryStatus>(value);
        }

        public static implicit operator TelemetryStatus(string value)
        {
            return FindValue(value);
        }
    }
    

    /// <summary>Tenancy
    /// </summary>
    public class Tenancy : ConstantClass
    {


       /// <summary>Constant Dedicated for Tenancy
       /// </summary>
        public static readonly Tenancy Dedicated = new Tenancy("dedicated");
    

       /// <summary>Constant Default for Tenancy
       /// </summary>
        public static readonly Tenancy Default = new Tenancy("default");
    

        /// <summary>
        /// Default Constructor
        /// </summary>
        public Tenancy(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Tenancy FindValue(string value)
        {
            return FindValue<Tenancy>(value);
        }

        public static implicit operator Tenancy(string value)
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
    

       /// <summary>Constant Deleted for VolumeState
       /// </summary>
        public static readonly VolumeState Deleted = new VolumeState("deleted");
    

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
    

    /// <summary>Volume Status Info Status
    /// </summary>
    public class VolumeStatusInfoStatus : ConstantClass
    {


       /// <summary>Constant Impaired for VolumeStatusInfoStatus
       /// </summary>
        public static readonly VolumeStatusInfoStatus Impaired = new VolumeStatusInfoStatus("impaired");
    

       /// <summary>Constant InsufficientData for VolumeStatusInfoStatus
       /// </summary>
        public static readonly VolumeStatusInfoStatus InsufficientData = new VolumeStatusInfoStatus("insufficient-data");
    

       /// <summary>Constant Ok for VolumeStatusInfoStatus
       /// </summary>
        public static readonly VolumeStatusInfoStatus Ok = new VolumeStatusInfoStatus("ok");
    

        /// <summary>
        /// Default Constructor
        /// </summary>
        public VolumeStatusInfoStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static VolumeStatusInfoStatus FindValue(string value)
        {
            return FindValue<VolumeStatusInfoStatus>(value);
        }

        public static implicit operator VolumeStatusInfoStatus(string value)
        {
            return FindValue(value);
        }
    }
    

    /// <summary>Volume Status Name
    /// </summary>
    public class VolumeStatusName : ConstantClass
    {


       /// <summary>Constant IoEnabled for VolumeStatusName
       /// </summary>
        public static readonly VolumeStatusName IoEnabled = new VolumeStatusName("io-enabled");
    

       /// <summary>Constant IoPerformance for VolumeStatusName
       /// </summary>
        public static readonly VolumeStatusName IoPerformance = new VolumeStatusName("io-performance");
    

        /// <summary>
        /// Default Constructor
        /// </summary>
        public VolumeStatusName(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static VolumeStatusName FindValue(string value)
        {
            return FindValue<VolumeStatusName>(value);
        }

        public static implicit operator VolumeStatusName(string value)
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
    

    /// <summary>Vpc State
    /// </summary>
    public class VpcState : ConstantClass
    {


       /// <summary>Constant Available for VpcState
       /// </summary>
        public static readonly VpcState Available = new VpcState("available");
    

       /// <summary>Constant Pending for VpcState
       /// </summary>
        public static readonly VpcState Pending = new VpcState("pending");
    

        /// <summary>
        /// Default Constructor
        /// </summary>
        public VpcState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static VpcState FindValue(string value)
        {
            return FindValue<VpcState>(value);
        }

        public static implicit operator VpcState(string value)
        {
            return FindValue(value);
        }
    }
    

    /// <summary>Vpn State
    /// </summary>
    public class VpnState : ConstantClass
    {


       /// <summary>Constant Available for VpnState
       /// </summary>
        public static readonly VpnState Available = new VpnState("available");
    

       /// <summary>Constant Deleted for VpnState
       /// </summary>
        public static readonly VpnState Deleted = new VpnState("deleted");
    

       /// <summary>Constant Deleting for VpnState
       /// </summary>
        public static readonly VpnState Deleting = new VpnState("deleting");
    

       /// <summary>Constant Pending for VpnState
       /// </summary>
        public static readonly VpnState Pending = new VpnState("pending");
    

        /// <summary>
        /// Default Constructor
        /// </summary>
        public VpnState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static VpnState FindValue(string value)
        {
            return FindValue<VpnState>(value);
        }

        public static implicit operator VpnState(string value)
        {
            return FindValue(value);
        }
    }
    

    /// <summary>Vpn Static Route Source
    /// </summary>
    public class VpnStaticRouteSource : ConstantClass
    {


       /// <summary>Constant Static for VpnStaticRouteSource
       /// </summary>
        public static readonly VpnStaticRouteSource Static = new VpnStaticRouteSource("Static");
    

        /// <summary>
        /// Default Constructor
        /// </summary>
        public VpnStaticRouteSource(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static VpnStaticRouteSource FindValue(string value)
        {
            return FindValue<VpnStaticRouteSource>(value);
        }

        public static implicit operator VpnStaticRouteSource(string value)
        {
            return FindValue(value);
        }
    }
    

}
        
