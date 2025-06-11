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
 * Do not modify this file. This file is generated from the elasticfilesystem-2015-02-01.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.ElasticFileSystem
{

    /// <summary>
    /// Constants used for properties of type DeletionMode.
    /// </summary>
    public class DeletionMode : ConstantClass
    {

        /// <summary>
        /// Constant ALL_CONFIGURATIONS for DeletionMode
        /// </summary>
        public static readonly DeletionMode ALL_CONFIGURATIONS = new DeletionMode("ALL_CONFIGURATIONS");
        /// <summary>
        /// Constant LOCAL_CONFIGURATION_ONLY for DeletionMode
        /// </summary>
        public static readonly DeletionMode LOCAL_CONFIGURATION_ONLY = new DeletionMode("LOCAL_CONFIGURATION_ONLY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DeletionMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DeletionMode FindValue(string value)
        {
            return FindValue<DeletionMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DeletionMode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type IpAddressType.
    /// </summary>
    public class IpAddressType : ConstantClass
    {

        /// <summary>
        /// Constant DUAL_STACK for IpAddressType
        /// </summary>
        public static readonly IpAddressType DUAL_STACK = new IpAddressType("DUAL_STACK");
        /// <summary>
        /// Constant IPV4_ONLY for IpAddressType
        /// </summary>
        public static readonly IpAddressType IPV4_ONLY = new IpAddressType("IPV4_ONLY");
        /// <summary>
        /// Constant IPV6_ONLY for IpAddressType
        /// </summary>
        public static readonly IpAddressType IPV6_ONLY = new IpAddressType("IPV6_ONLY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public IpAddressType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static IpAddressType FindValue(string value)
        {
            return FindValue<IpAddressType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator IpAddressType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type LifeCycleState.
    /// </summary>
    public class LifeCycleState : ConstantClass
    {

        /// <summary>
        /// Constant Available for LifeCycleState
        /// </summary>
        public static readonly LifeCycleState Available = new LifeCycleState("available");
        /// <summary>
        /// Constant Creating for LifeCycleState
        /// </summary>
        public static readonly LifeCycleState Creating = new LifeCycleState("creating");
        /// <summary>
        /// Constant Deleted for LifeCycleState
        /// </summary>
        public static readonly LifeCycleState Deleted = new LifeCycleState("deleted");
        /// <summary>
        /// Constant Deleting for LifeCycleState
        /// </summary>
        public static readonly LifeCycleState Deleting = new LifeCycleState("deleting");
        /// <summary>
        /// Constant Error for LifeCycleState
        /// </summary>
        public static readonly LifeCycleState Error = new LifeCycleState("error");
        /// <summary>
        /// Constant Updating for LifeCycleState
        /// </summary>
        public static readonly LifeCycleState Updating = new LifeCycleState("updating");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public LifeCycleState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LifeCycleState FindValue(string value)
        {
            return FindValue<LifeCycleState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator LifeCycleState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PerformanceMode.
    /// </summary>
    public class PerformanceMode : ConstantClass
    {

        /// <summary>
        /// Constant GeneralPurpose for PerformanceMode
        /// </summary>
        public static readonly PerformanceMode GeneralPurpose = new PerformanceMode("generalPurpose");
        /// <summary>
        /// Constant MaxIO for PerformanceMode
        /// </summary>
        public static readonly PerformanceMode MaxIO = new PerformanceMode("maxIO");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PerformanceMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PerformanceMode FindValue(string value)
        {
            return FindValue<PerformanceMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PerformanceMode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ReplicationOverwriteProtection.
    /// </summary>
    public class ReplicationOverwriteProtection : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for ReplicationOverwriteProtection
        /// </summary>
        public static readonly ReplicationOverwriteProtection DISABLED = new ReplicationOverwriteProtection("DISABLED");
        /// <summary>
        /// Constant ENABLED for ReplicationOverwriteProtection
        /// </summary>
        public static readonly ReplicationOverwriteProtection ENABLED = new ReplicationOverwriteProtection("ENABLED");
        /// <summary>
        /// Constant REPLICATING for ReplicationOverwriteProtection
        /// </summary>
        public static readonly ReplicationOverwriteProtection REPLICATING = new ReplicationOverwriteProtection("REPLICATING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ReplicationOverwriteProtection(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ReplicationOverwriteProtection FindValue(string value)
        {
            return FindValue<ReplicationOverwriteProtection>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ReplicationOverwriteProtection(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ReplicationStatus.
    /// </summary>
    public class ReplicationStatus : ConstantClass
    {

        /// <summary>
        /// Constant DELETING for ReplicationStatus
        /// </summary>
        public static readonly ReplicationStatus DELETING = new ReplicationStatus("DELETING");
        /// <summary>
        /// Constant ENABLED for ReplicationStatus
        /// </summary>
        public static readonly ReplicationStatus ENABLED = new ReplicationStatus("ENABLED");
        /// <summary>
        /// Constant ENABLING for ReplicationStatus
        /// </summary>
        public static readonly ReplicationStatus ENABLING = new ReplicationStatus("ENABLING");
        /// <summary>
        /// Constant ERROR for ReplicationStatus
        /// </summary>
        public static readonly ReplicationStatus ERROR = new ReplicationStatus("ERROR");
        /// <summary>
        /// Constant PAUSED for ReplicationStatus
        /// </summary>
        public static readonly ReplicationStatus PAUSED = new ReplicationStatus("PAUSED");
        /// <summary>
        /// Constant PAUSING for ReplicationStatus
        /// </summary>
        public static readonly ReplicationStatus PAUSING = new ReplicationStatus("PAUSING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ReplicationStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ReplicationStatus FindValue(string value)
        {
            return FindValue<ReplicationStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ReplicationStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Resource.
    /// </summary>
    public class Resource : ConstantClass
    {

        /// <summary>
        /// Constant FILE_SYSTEM for Resource
        /// </summary>
        public static readonly Resource FILE_SYSTEM = new Resource("FILE_SYSTEM");
        /// <summary>
        /// Constant MOUNT_TARGET for Resource
        /// </summary>
        public static readonly Resource MOUNT_TARGET = new Resource("MOUNT_TARGET");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Resource(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Resource FindValue(string value)
        {
            return FindValue<Resource>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Resource(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ResourceIdType.
    /// </summary>
    public class ResourceIdType : ConstantClass
    {

        /// <summary>
        /// Constant LONG_ID for ResourceIdType
        /// </summary>
        public static readonly ResourceIdType LONG_ID = new ResourceIdType("LONG_ID");
        /// <summary>
        /// Constant SHORT_ID for ResourceIdType
        /// </summary>
        public static readonly ResourceIdType SHORT_ID = new ResourceIdType("SHORT_ID");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ResourceIdType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ResourceIdType FindValue(string value)
        {
            return FindValue<ResourceIdType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ResourceIdType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Status.
    /// </summary>
    public class Status : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for Status
        /// </summary>
        public static readonly Status DISABLED = new Status("DISABLED");
        /// <summary>
        /// Constant DISABLING for Status
        /// </summary>
        public static readonly Status DISABLING = new Status("DISABLING");
        /// <summary>
        /// Constant ENABLED for Status
        /// </summary>
        public static readonly Status ENABLED = new Status("ENABLED");
        /// <summary>
        /// Constant ENABLING for Status
        /// </summary>
        public static readonly Status ENABLING = new Status("ENABLING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Status(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Status FindValue(string value)
        {
            return FindValue<Status>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Status(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ThroughputMode.
    /// </summary>
    public class ThroughputMode : ConstantClass
    {

        /// <summary>
        /// Constant Bursting for ThroughputMode
        /// </summary>
        public static readonly ThroughputMode Bursting = new ThroughputMode("bursting");
        /// <summary>
        /// Constant Elastic for ThroughputMode
        /// </summary>
        public static readonly ThroughputMode Elastic = new ThroughputMode("elastic");
        /// <summary>
        /// Constant Provisioned for ThroughputMode
        /// </summary>
        public static readonly ThroughputMode Provisioned = new ThroughputMode("provisioned");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ThroughputMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ThroughputMode FindValue(string value)
        {
            return FindValue<ThroughputMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ThroughputMode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TransitionToArchiveRules.
    /// </summary>
    public class TransitionToArchiveRules : ConstantClass
    {

        /// <summary>
        /// Constant AFTER_1_DAY for TransitionToArchiveRules
        /// </summary>
        public static readonly TransitionToArchiveRules AFTER_1_DAY = new TransitionToArchiveRules("AFTER_1_DAY");
        /// <summary>
        /// Constant AFTER_14_DAYS for TransitionToArchiveRules
        /// </summary>
        public static readonly TransitionToArchiveRules AFTER_14_DAYS = new TransitionToArchiveRules("AFTER_14_DAYS");
        /// <summary>
        /// Constant AFTER_180_DAYS for TransitionToArchiveRules
        /// </summary>
        public static readonly TransitionToArchiveRules AFTER_180_DAYS = new TransitionToArchiveRules("AFTER_180_DAYS");
        /// <summary>
        /// Constant AFTER_270_DAYS for TransitionToArchiveRules
        /// </summary>
        public static readonly TransitionToArchiveRules AFTER_270_DAYS = new TransitionToArchiveRules("AFTER_270_DAYS");
        /// <summary>
        /// Constant AFTER_30_DAYS for TransitionToArchiveRules
        /// </summary>
        public static readonly TransitionToArchiveRules AFTER_30_DAYS = new TransitionToArchiveRules("AFTER_30_DAYS");
        /// <summary>
        /// Constant AFTER_365_DAYS for TransitionToArchiveRules
        /// </summary>
        public static readonly TransitionToArchiveRules AFTER_365_DAYS = new TransitionToArchiveRules("AFTER_365_DAYS");
        /// <summary>
        /// Constant AFTER_60_DAYS for TransitionToArchiveRules
        /// </summary>
        public static readonly TransitionToArchiveRules AFTER_60_DAYS = new TransitionToArchiveRules("AFTER_60_DAYS");
        /// <summary>
        /// Constant AFTER_7_DAYS for TransitionToArchiveRules
        /// </summary>
        public static readonly TransitionToArchiveRules AFTER_7_DAYS = new TransitionToArchiveRules("AFTER_7_DAYS");
        /// <summary>
        /// Constant AFTER_90_DAYS for TransitionToArchiveRules
        /// </summary>
        public static readonly TransitionToArchiveRules AFTER_90_DAYS = new TransitionToArchiveRules("AFTER_90_DAYS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TransitionToArchiveRules(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TransitionToArchiveRules FindValue(string value)
        {
            return FindValue<TransitionToArchiveRules>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TransitionToArchiveRules(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TransitionToIARules.
    /// </summary>
    public class TransitionToIARules : ConstantClass
    {

        /// <summary>
        /// Constant AFTER_1_DAY for TransitionToIARules
        /// </summary>
        public static readonly TransitionToIARules AFTER_1_DAY = new TransitionToIARules("AFTER_1_DAY");
        /// <summary>
        /// Constant AFTER_14_DAYS for TransitionToIARules
        /// </summary>
        public static readonly TransitionToIARules AFTER_14_DAYS = new TransitionToIARules("AFTER_14_DAYS");
        /// <summary>
        /// Constant AFTER_180_DAYS for TransitionToIARules
        /// </summary>
        public static readonly TransitionToIARules AFTER_180_DAYS = new TransitionToIARules("AFTER_180_DAYS");
        /// <summary>
        /// Constant AFTER_270_DAYS for TransitionToIARules
        /// </summary>
        public static readonly TransitionToIARules AFTER_270_DAYS = new TransitionToIARules("AFTER_270_DAYS");
        /// <summary>
        /// Constant AFTER_30_DAYS for TransitionToIARules
        /// </summary>
        public static readonly TransitionToIARules AFTER_30_DAYS = new TransitionToIARules("AFTER_30_DAYS");
        /// <summary>
        /// Constant AFTER_365_DAYS for TransitionToIARules
        /// </summary>
        public static readonly TransitionToIARules AFTER_365_DAYS = new TransitionToIARules("AFTER_365_DAYS");
        /// <summary>
        /// Constant AFTER_60_DAYS for TransitionToIARules
        /// </summary>
        public static readonly TransitionToIARules AFTER_60_DAYS = new TransitionToIARules("AFTER_60_DAYS");
        /// <summary>
        /// Constant AFTER_7_DAYS for TransitionToIARules
        /// </summary>
        public static readonly TransitionToIARules AFTER_7_DAYS = new TransitionToIARules("AFTER_7_DAYS");
        /// <summary>
        /// Constant AFTER_90_DAYS for TransitionToIARules
        /// </summary>
        public static readonly TransitionToIARules AFTER_90_DAYS = new TransitionToIARules("AFTER_90_DAYS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TransitionToIARules(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TransitionToIARules FindValue(string value)
        {
            return FindValue<TransitionToIARules>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TransitionToIARules(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TransitionToPrimaryStorageClassRules.
    /// </summary>
    public class TransitionToPrimaryStorageClassRules : ConstantClass
    {

        /// <summary>
        /// Constant AFTER_1_ACCESS for TransitionToPrimaryStorageClassRules
        /// </summary>
        public static readonly TransitionToPrimaryStorageClassRules AFTER_1_ACCESS = new TransitionToPrimaryStorageClassRules("AFTER_1_ACCESS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TransitionToPrimaryStorageClassRules(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TransitionToPrimaryStorageClassRules FindValue(string value)
        {
            return FindValue<TransitionToPrimaryStorageClassRules>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TransitionToPrimaryStorageClassRules(string value)
        {
            return FindValue(value);
        }
    }

}