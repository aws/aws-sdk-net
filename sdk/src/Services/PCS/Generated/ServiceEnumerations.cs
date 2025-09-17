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
 * Do not modify this file. This file is generated from the pcs-2023-02-10.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.PCS
{

    /// <summary>
    /// Constants used for properties of type AccountingMode.
    /// </summary>
    public class AccountingMode : ConstantClass
    {

        /// <summary>
        /// Constant NONE for AccountingMode
        /// </summary>
        public static readonly AccountingMode NONE = new AccountingMode("NONE");
        /// <summary>
        /// Constant STANDARD for AccountingMode
        /// </summary>
        public static readonly AccountingMode STANDARD = new AccountingMode("STANDARD");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AccountingMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AccountingMode FindValue(string value)
        {
            return FindValue<AccountingMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AccountingMode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ClusterStatus.
    /// </summary>
    public class ClusterStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for ClusterStatus
        /// </summary>
        public static readonly ClusterStatus ACTIVE = new ClusterStatus("ACTIVE");
        /// <summary>
        /// Constant CREATE_FAILED for ClusterStatus
        /// </summary>
        public static readonly ClusterStatus CREATE_FAILED = new ClusterStatus("CREATE_FAILED");
        /// <summary>
        /// Constant CREATING for ClusterStatus
        /// </summary>
        public static readonly ClusterStatus CREATING = new ClusterStatus("CREATING");
        /// <summary>
        /// Constant DELETE_FAILED for ClusterStatus
        /// </summary>
        public static readonly ClusterStatus DELETE_FAILED = new ClusterStatus("DELETE_FAILED");
        /// <summary>
        /// Constant DELETING for ClusterStatus
        /// </summary>
        public static readonly ClusterStatus DELETING = new ClusterStatus("DELETING");
        /// <summary>
        /// Constant SUSPENDED for ClusterStatus
        /// </summary>
        public static readonly ClusterStatus SUSPENDED = new ClusterStatus("SUSPENDED");
        /// <summary>
        /// Constant SUSPENDING for ClusterStatus
        /// </summary>
        public static readonly ClusterStatus SUSPENDING = new ClusterStatus("SUSPENDING");
        /// <summary>
        /// Constant UPDATE_FAILED for ClusterStatus
        /// </summary>
        public static readonly ClusterStatus UPDATE_FAILED = new ClusterStatus("UPDATE_FAILED");
        /// <summary>
        /// Constant UPDATING for ClusterStatus
        /// </summary>
        public static readonly ClusterStatus UPDATING = new ClusterStatus("UPDATING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ClusterStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ClusterStatus FindValue(string value)
        {
            return FindValue<ClusterStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ClusterStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ComputeNodeGroupStatus.
    /// </summary>
    public class ComputeNodeGroupStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for ComputeNodeGroupStatus
        /// </summary>
        public static readonly ComputeNodeGroupStatus ACTIVE = new ComputeNodeGroupStatus("ACTIVE");
        /// <summary>
        /// Constant CREATE_FAILED for ComputeNodeGroupStatus
        /// </summary>
        public static readonly ComputeNodeGroupStatus CREATE_FAILED = new ComputeNodeGroupStatus("CREATE_FAILED");
        /// <summary>
        /// Constant CREATING for ComputeNodeGroupStatus
        /// </summary>
        public static readonly ComputeNodeGroupStatus CREATING = new ComputeNodeGroupStatus("CREATING");
        /// <summary>
        /// Constant DELETE_FAILED for ComputeNodeGroupStatus
        /// </summary>
        public static readonly ComputeNodeGroupStatus DELETE_FAILED = new ComputeNodeGroupStatus("DELETE_FAILED");
        /// <summary>
        /// Constant DELETED for ComputeNodeGroupStatus
        /// </summary>
        public static readonly ComputeNodeGroupStatus DELETED = new ComputeNodeGroupStatus("DELETED");
        /// <summary>
        /// Constant DELETING for ComputeNodeGroupStatus
        /// </summary>
        public static readonly ComputeNodeGroupStatus DELETING = new ComputeNodeGroupStatus("DELETING");
        /// <summary>
        /// Constant SUSPENDED for ComputeNodeGroupStatus
        /// </summary>
        public static readonly ComputeNodeGroupStatus SUSPENDED = new ComputeNodeGroupStatus("SUSPENDED");
        /// <summary>
        /// Constant SUSPENDING for ComputeNodeGroupStatus
        /// </summary>
        public static readonly ComputeNodeGroupStatus SUSPENDING = new ComputeNodeGroupStatus("SUSPENDING");
        /// <summary>
        /// Constant UPDATE_FAILED for ComputeNodeGroupStatus
        /// </summary>
        public static readonly ComputeNodeGroupStatus UPDATE_FAILED = new ComputeNodeGroupStatus("UPDATE_FAILED");
        /// <summary>
        /// Constant UPDATING for ComputeNodeGroupStatus
        /// </summary>
        public static readonly ComputeNodeGroupStatus UPDATING = new ComputeNodeGroupStatus("UPDATING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ComputeNodeGroupStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ComputeNodeGroupStatus FindValue(string value)
        {
            return FindValue<ComputeNodeGroupStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ComputeNodeGroupStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type EndpointType.
    /// </summary>
    public class EndpointType : ConstantClass
    {

        /// <summary>
        /// Constant SLURMCTLD for EndpointType
        /// </summary>
        public static readonly EndpointType SLURMCTLD = new EndpointType("SLURMCTLD");
        /// <summary>
        /// Constant SLURMDBD for EndpointType
        /// </summary>
        public static readonly EndpointType SLURMDBD = new EndpointType("SLURMDBD");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EndpointType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EndpointType FindValue(string value)
        {
            return FindValue<EndpointType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EndpointType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type NetworkType.
    /// </summary>
    public class NetworkType : ConstantClass
    {

        /// <summary>
        /// Constant IPV4 for NetworkType
        /// </summary>
        public static readonly NetworkType IPV4 = new NetworkType("IPV4");
        /// <summary>
        /// Constant IPV6 for NetworkType
        /// </summary>
        public static readonly NetworkType IPV6 = new NetworkType("IPV6");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public NetworkType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static NetworkType FindValue(string value)
        {
            return FindValue<NetworkType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator NetworkType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PurchaseOption.
    /// </summary>
    public class PurchaseOption : ConstantClass
    {

        /// <summary>
        /// Constant CAPACITY_BLOCK for PurchaseOption
        /// </summary>
        public static readonly PurchaseOption CAPACITY_BLOCK = new PurchaseOption("CAPACITY_BLOCK");
        /// <summary>
        /// Constant ONDEMAND for PurchaseOption
        /// </summary>
        public static readonly PurchaseOption ONDEMAND = new PurchaseOption("ONDEMAND");
        /// <summary>
        /// Constant SPOT for PurchaseOption
        /// </summary>
        public static readonly PurchaseOption SPOT = new PurchaseOption("SPOT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PurchaseOption(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PurchaseOption FindValue(string value)
        {
            return FindValue<PurchaseOption>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PurchaseOption(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type QueueStatus.
    /// </summary>
    public class QueueStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for QueueStatus
        /// </summary>
        public static readonly QueueStatus ACTIVE = new QueueStatus("ACTIVE");
        /// <summary>
        /// Constant CREATE_FAILED for QueueStatus
        /// </summary>
        public static readonly QueueStatus CREATE_FAILED = new QueueStatus("CREATE_FAILED");
        /// <summary>
        /// Constant CREATING for QueueStatus
        /// </summary>
        public static readonly QueueStatus CREATING = new QueueStatus("CREATING");
        /// <summary>
        /// Constant DELETE_FAILED for QueueStatus
        /// </summary>
        public static readonly QueueStatus DELETE_FAILED = new QueueStatus("DELETE_FAILED");
        /// <summary>
        /// Constant DELETING for QueueStatus
        /// </summary>
        public static readonly QueueStatus DELETING = new QueueStatus("DELETING");
        /// <summary>
        /// Constant SUSPENDED for QueueStatus
        /// </summary>
        public static readonly QueueStatus SUSPENDED = new QueueStatus("SUSPENDED");
        /// <summary>
        /// Constant SUSPENDING for QueueStatus
        /// </summary>
        public static readonly QueueStatus SUSPENDING = new QueueStatus("SUSPENDING");
        /// <summary>
        /// Constant UPDATE_FAILED for QueueStatus
        /// </summary>
        public static readonly QueueStatus UPDATE_FAILED = new QueueStatus("UPDATE_FAILED");
        /// <summary>
        /// Constant UPDATING for QueueStatus
        /// </summary>
        public static readonly QueueStatus UPDATING = new QueueStatus("UPDATING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public QueueStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static QueueStatus FindValue(string value)
        {
            return FindValue<QueueStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator QueueStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SchedulerType.
    /// </summary>
    public class SchedulerType : ConstantClass
    {

        /// <summary>
        /// Constant SLURM for SchedulerType
        /// </summary>
        public static readonly SchedulerType SLURM = new SchedulerType("SLURM");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SchedulerType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SchedulerType FindValue(string value)
        {
            return FindValue<SchedulerType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SchedulerType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Size.
    /// </summary>
    public class Size : ConstantClass
    {

        /// <summary>
        /// Constant LARGE for Size
        /// </summary>
        public static readonly Size LARGE = new Size("LARGE");
        /// <summary>
        /// Constant MEDIUM for Size
        /// </summary>
        public static readonly Size MEDIUM = new Size("MEDIUM");
        /// <summary>
        /// Constant SMALL for Size
        /// </summary>
        public static readonly Size SMALL = new Size("SMALL");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Size(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Size FindValue(string value)
        {
            return FindValue<Size>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Size(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SpotAllocationStrategy.
    /// </summary>
    public class SpotAllocationStrategy : ConstantClass
    {

        /// <summary>
        /// Constant CapacityOptimized for SpotAllocationStrategy
        /// </summary>
        public static readonly SpotAllocationStrategy CapacityOptimized = new SpotAllocationStrategy("capacity-optimized");
        /// <summary>
        /// Constant LowestPrice for SpotAllocationStrategy
        /// </summary>
        public static readonly SpotAllocationStrategy LowestPrice = new SpotAllocationStrategy("lowest-price");
        /// <summary>
        /// Constant PriceCapacityOptimized for SpotAllocationStrategy
        /// </summary>
        public static readonly SpotAllocationStrategy PriceCapacityOptimized = new SpotAllocationStrategy("price-capacity-optimized");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SpotAllocationStrategy(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SpotAllocationStrategy FindValue(string value)
        {
            return FindValue<SpotAllocationStrategy>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SpotAllocationStrategy(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ValidationExceptionReason.
    /// </summary>
    public class ValidationExceptionReason : ConstantClass
    {

        /// <summary>
        /// Constant CannotParse for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason CannotParse = new ValidationExceptionReason("cannotParse");
        /// <summary>
        /// Constant FieldValidationFailed for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason FieldValidationFailed = new ValidationExceptionReason("fieldValidationFailed");
        /// <summary>
        /// Constant Other for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason Other = new ValidationExceptionReason("other");
        /// <summary>
        /// Constant UnknownOperation for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason UnknownOperation = new ValidationExceptionReason("unknownOperation");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ValidationExceptionReason(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ValidationExceptionReason FindValue(string value)
        {
            return FindValue<ValidationExceptionReason>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ValidationExceptionReason(string value)
        {
            return FindValue(value);
        }
    }

}