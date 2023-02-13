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
 * Do not modify this file. This file is generated from the snowball-2016-06-30.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.Snowball
{

    /// <summary>
    /// Constants used for properties of type ClusterState.
    /// </summary>
    public class ClusterState : ConstantClass
    {

        /// <summary>
        /// Constant AwaitingQuorum for ClusterState
        /// </summary>
        public static readonly ClusterState AwaitingQuorum = new ClusterState("AwaitingQuorum");
        /// <summary>
        /// Constant Cancelled for ClusterState
        /// </summary>
        public static readonly ClusterState Cancelled = new ClusterState("Cancelled");
        /// <summary>
        /// Constant Complete for ClusterState
        /// </summary>
        public static readonly ClusterState Complete = new ClusterState("Complete");
        /// <summary>
        /// Constant InUse for ClusterState
        /// </summary>
        public static readonly ClusterState InUse = new ClusterState("InUse");
        /// <summary>
        /// Constant Pending for ClusterState
        /// </summary>
        public static readonly ClusterState Pending = new ClusterState("Pending");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ClusterState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ClusterState FindValue(string value)
        {
            return FindValue<ClusterState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ClusterState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DeviceServiceName.
    /// </summary>
    public class DeviceServiceName : ConstantClass
    {

        /// <summary>
        /// Constant NFS_ON_DEVICE_SERVICE for DeviceServiceName
        /// </summary>
        public static readonly DeviceServiceName NFS_ON_DEVICE_SERVICE = new DeviceServiceName("NFS_ON_DEVICE_SERVICE");
        /// <summary>
        /// Constant S3_ON_DEVICE_SERVICE for DeviceServiceName
        /// </summary>
        public static readonly DeviceServiceName S3_ON_DEVICE_SERVICE = new DeviceServiceName("S3_ON_DEVICE_SERVICE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DeviceServiceName(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DeviceServiceName FindValue(string value)
        {
            return FindValue<DeviceServiceName>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DeviceServiceName(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type JobState.
    /// </summary>
    public class JobState : ConstantClass
    {

        /// <summary>
        /// Constant Cancelled for JobState
        /// </summary>
        public static readonly JobState Cancelled = new JobState("Cancelled");
        /// <summary>
        /// Constant Complete for JobState
        /// </summary>
        public static readonly JobState Complete = new JobState("Complete");
        /// <summary>
        /// Constant InProgress for JobState
        /// </summary>
        public static readonly JobState InProgress = new JobState("InProgress");
        /// <summary>
        /// Constant InTransitToAWS for JobState
        /// </summary>
        public static readonly JobState InTransitToAWS = new JobState("InTransitToAWS");
        /// <summary>
        /// Constant InTransitToCustomer for JobState
        /// </summary>
        public static readonly JobState InTransitToCustomer = new JobState("InTransitToCustomer");
        /// <summary>
        /// Constant Listing for JobState
        /// </summary>
        public static readonly JobState Listing = new JobState("Listing");
        /// <summary>
        /// Constant New for JobState
        /// </summary>
        public static readonly JobState New = new JobState("New");
        /// <summary>
        /// Constant Pending for JobState
        /// </summary>
        public static readonly JobState Pending = new JobState("Pending");
        /// <summary>
        /// Constant PreparingAppliance for JobState
        /// </summary>
        public static readonly JobState PreparingAppliance = new JobState("PreparingAppliance");
        /// <summary>
        /// Constant PreparingShipment for JobState
        /// </summary>
        public static readonly JobState PreparingShipment = new JobState("PreparingShipment");
        /// <summary>
        /// Constant WithAWS for JobState
        /// </summary>
        public static readonly JobState WithAWS = new JobState("WithAWS");
        /// <summary>
        /// Constant WithAWSSortingFacility for JobState
        /// </summary>
        public static readonly JobState WithAWSSortingFacility = new JobState("WithAWSSortingFacility");
        /// <summary>
        /// Constant WithCustomer for JobState
        /// </summary>
        public static readonly JobState WithCustomer = new JobState("WithCustomer");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public JobState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static JobState FindValue(string value)
        {
            return FindValue<JobState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator JobState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type JobType.
    /// </summary>
    public class JobType : ConstantClass
    {

        /// <summary>
        /// Constant EXPORT for JobType
        /// </summary>
        public static readonly JobType EXPORT = new JobType("EXPORT");
        /// <summary>
        /// Constant IMPORT for JobType
        /// </summary>
        public static readonly JobType IMPORT = new JobType("IMPORT");
        /// <summary>
        /// Constant LOCAL_USE for JobType
        /// </summary>
        public static readonly JobType LOCAL_USE = new JobType("LOCAL_USE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public JobType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static JobType FindValue(string value)
        {
            return FindValue<JobType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator JobType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type LongTermPricingType.
    /// </summary>
    public class LongTermPricingType : ConstantClass
    {

        /// <summary>
        /// Constant OneYear for LongTermPricingType
        /// </summary>
        public static readonly LongTermPricingType OneYear = new LongTermPricingType("OneYear");
        /// <summary>
        /// Constant ThreeYear for LongTermPricingType
        /// </summary>
        public static readonly LongTermPricingType ThreeYear = new LongTermPricingType("ThreeYear");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public LongTermPricingType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LongTermPricingType FindValue(string value)
        {
            return FindValue<LongTermPricingType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator LongTermPricingType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RemoteManagement.
    /// </summary>
    public class RemoteManagement : ConstantClass
    {

        /// <summary>
        /// Constant INSTALLED_AUTOSTART for RemoteManagement
        /// </summary>
        public static readonly RemoteManagement INSTALLED_AUTOSTART = new RemoteManagement("INSTALLED_AUTOSTART");
        /// <summary>
        /// Constant INSTALLED_ONLY for RemoteManagement
        /// </summary>
        public static readonly RemoteManagement INSTALLED_ONLY = new RemoteManagement("INSTALLED_ONLY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RemoteManagement(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RemoteManagement FindValue(string value)
        {
            return FindValue<RemoteManagement>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RemoteManagement(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ServiceName.
    /// </summary>
    public class ServiceName : ConstantClass
    {

        /// <summary>
        /// Constant EKS_ANYWHERE for ServiceName
        /// </summary>
        public static readonly ServiceName EKS_ANYWHERE = new ServiceName("EKS_ANYWHERE");
        /// <summary>
        /// Constant KUBERNETES for ServiceName
        /// </summary>
        public static readonly ServiceName KUBERNETES = new ServiceName("KUBERNETES");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ServiceName(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ServiceName FindValue(string value)
        {
            return FindValue<ServiceName>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ServiceName(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ShipmentState.
    /// </summary>
    public class ShipmentState : ConstantClass
    {

        /// <summary>
        /// Constant RECEIVED for ShipmentState
        /// </summary>
        public static readonly ShipmentState RECEIVED = new ShipmentState("RECEIVED");
        /// <summary>
        /// Constant RETURNED for ShipmentState
        /// </summary>
        public static readonly ShipmentState RETURNED = new ShipmentState("RETURNED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ShipmentState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ShipmentState FindValue(string value)
        {
            return FindValue<ShipmentState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ShipmentState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ShippingLabelStatus.
    /// </summary>
    public class ShippingLabelStatus : ConstantClass
    {

        /// <summary>
        /// Constant Failed for ShippingLabelStatus
        /// </summary>
        public static readonly ShippingLabelStatus Failed = new ShippingLabelStatus("Failed");
        /// <summary>
        /// Constant InProgress for ShippingLabelStatus
        /// </summary>
        public static readonly ShippingLabelStatus InProgress = new ShippingLabelStatus("InProgress");
        /// <summary>
        /// Constant Succeeded for ShippingLabelStatus
        /// </summary>
        public static readonly ShippingLabelStatus Succeeded = new ShippingLabelStatus("Succeeded");
        /// <summary>
        /// Constant TimedOut for ShippingLabelStatus
        /// </summary>
        public static readonly ShippingLabelStatus TimedOut = new ShippingLabelStatus("TimedOut");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ShippingLabelStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ShippingLabelStatus FindValue(string value)
        {
            return FindValue<ShippingLabelStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ShippingLabelStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ShippingOption.
    /// </summary>
    public class ShippingOption : ConstantClass
    {

        /// <summary>
        /// Constant EXPRESS for ShippingOption
        /// </summary>
        public static readonly ShippingOption EXPRESS = new ShippingOption("EXPRESS");
        /// <summary>
        /// Constant NEXT_DAY for ShippingOption
        /// </summary>
        public static readonly ShippingOption NEXT_DAY = new ShippingOption("NEXT_DAY");
        /// <summary>
        /// Constant SECOND_DAY for ShippingOption
        /// </summary>
        public static readonly ShippingOption SECOND_DAY = new ShippingOption("SECOND_DAY");
        /// <summary>
        /// Constant STANDARD for ShippingOption
        /// </summary>
        public static readonly ShippingOption STANDARD = new ShippingOption("STANDARD");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ShippingOption(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ShippingOption FindValue(string value)
        {
            return FindValue<ShippingOption>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ShippingOption(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SnowballCapacity.
    /// </summary>
    public class SnowballCapacity : ConstantClass
    {

        /// <summary>
        /// Constant NoPreference for SnowballCapacity
        /// </summary>
        public static readonly SnowballCapacity NoPreference = new SnowballCapacity("NoPreference");
        /// <summary>
        /// Constant T100 for SnowballCapacity
        /// </summary>
        public static readonly SnowballCapacity T100 = new SnowballCapacity("T100");
        /// <summary>
        /// Constant T14 for SnowballCapacity
        /// </summary>
        public static readonly SnowballCapacity T14 = new SnowballCapacity("T14");
        /// <summary>
        /// Constant T32 for SnowballCapacity
        /// </summary>
        public static readonly SnowballCapacity T32 = new SnowballCapacity("T32");
        /// <summary>
        /// Constant T42 for SnowballCapacity
        /// </summary>
        public static readonly SnowballCapacity T42 = new SnowballCapacity("T42");
        /// <summary>
        /// Constant T50 for SnowballCapacity
        /// </summary>
        public static readonly SnowballCapacity T50 = new SnowballCapacity("T50");
        /// <summary>
        /// Constant T8 for SnowballCapacity
        /// </summary>
        public static readonly SnowballCapacity T8 = new SnowballCapacity("T8");
        /// <summary>
        /// Constant T80 for SnowballCapacity
        /// </summary>
        public static readonly SnowballCapacity T80 = new SnowballCapacity("T80");
        /// <summary>
        /// Constant T98 for SnowballCapacity
        /// </summary>
        public static readonly SnowballCapacity T98 = new SnowballCapacity("T98");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SnowballCapacity(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SnowballCapacity FindValue(string value)
        {
            return FindValue<SnowballCapacity>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SnowballCapacity(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SnowballType.
    /// </summary>
    public class SnowballType : ConstantClass
    {

        /// <summary>
        /// Constant EDGE for SnowballType
        /// </summary>
        public static readonly SnowballType EDGE = new SnowballType("EDGE");
        /// <summary>
        /// Constant EDGE_C for SnowballType
        /// </summary>
        public static readonly SnowballType EDGE_C = new SnowballType("EDGE_C");
        /// <summary>
        /// Constant EDGE_CG for SnowballType
        /// </summary>
        public static readonly SnowballType EDGE_CG = new SnowballType("EDGE_CG");
        /// <summary>
        /// Constant EDGE_S for SnowballType
        /// </summary>
        public static readonly SnowballType EDGE_S = new SnowballType("EDGE_S");
        /// <summary>
        /// Constant SNC1_HDD for SnowballType
        /// </summary>
        public static readonly SnowballType SNC1_HDD = new SnowballType("SNC1_HDD");
        /// <summary>
        /// Constant SNC1_SSD for SnowballType
        /// </summary>
        public static readonly SnowballType SNC1_SSD = new SnowballType("SNC1_SSD");
        /// <summary>
        /// Constant STANDARD for SnowballType
        /// </summary>
        public static readonly SnowballType STANDARD = new SnowballType("STANDARD");
        /// <summary>
        /// Constant V3_5C for SnowballType
        /// </summary>
        public static readonly SnowballType V3_5C = new SnowballType("V3_5C");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SnowballType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SnowballType FindValue(string value)
        {
            return FindValue<SnowballType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SnowballType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type StorageUnit.
    /// </summary>
    public class StorageUnit : ConstantClass
    {

        /// <summary>
        /// Constant TB for StorageUnit
        /// </summary>
        public static readonly StorageUnit TB = new StorageUnit("TB");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public StorageUnit(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static StorageUnit FindValue(string value)
        {
            return FindValue<StorageUnit>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator StorageUnit(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TransferOption.
    /// </summary>
    public class TransferOption : ConstantClass
    {

        /// <summary>
        /// Constant EXPORT for TransferOption
        /// </summary>
        public static readonly TransferOption EXPORT = new TransferOption("EXPORT");
        /// <summary>
        /// Constant IMPORT for TransferOption
        /// </summary>
        public static readonly TransferOption IMPORT = new TransferOption("IMPORT");
        /// <summary>
        /// Constant LOCAL_USE for TransferOption
        /// </summary>
        public static readonly TransferOption LOCAL_USE = new TransferOption("LOCAL_USE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TransferOption(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TransferOption FindValue(string value)
        {
            return FindValue<TransferOption>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TransferOption(string value)
        {
            return FindValue(value);
        }
    }

}