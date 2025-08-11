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
 * Do not modify this file. This file is generated from the deadline-2023-10-12.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.Deadline
{

    /// <summary>
    /// Constants used for properties of type AcceleratorName.
    /// </summary>
    public class AcceleratorName : ConstantClass
    {

        /// <summary>
        /// Constant A10g for AcceleratorName
        /// </summary>
        public static readonly AcceleratorName A10g = new AcceleratorName("a10g");
        /// <summary>
        /// Constant L4 for AcceleratorName
        /// </summary>
        public static readonly AcceleratorName L4 = new AcceleratorName("l4");
        /// <summary>
        /// Constant L40s for AcceleratorName
        /// </summary>
        public static readonly AcceleratorName L40s = new AcceleratorName("l40s");
        /// <summary>
        /// Constant T4 for AcceleratorName
        /// </summary>
        public static readonly AcceleratorName T4 = new AcceleratorName("t4");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AcceleratorName(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AcceleratorName FindValue(string value)
        {
            return FindValue<AcceleratorName>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AcceleratorName(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AcceleratorType.
    /// </summary>
    public class AcceleratorType : ConstantClass
    {

        /// <summary>
        /// Constant Gpu for AcceleratorType
        /// </summary>
        public static readonly AcceleratorType Gpu = new AcceleratorType("gpu");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AcceleratorType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AcceleratorType FindValue(string value)
        {
            return FindValue<AcceleratorType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AcceleratorType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AutoScalingMode.
    /// </summary>
    public class AutoScalingMode : ConstantClass
    {

        /// <summary>
        /// Constant EVENT_BASED_AUTO_SCALING for AutoScalingMode
        /// </summary>
        public static readonly AutoScalingMode EVENT_BASED_AUTO_SCALING = new AutoScalingMode("EVENT_BASED_AUTO_SCALING");
        /// <summary>
        /// Constant NO_SCALING for AutoScalingMode
        /// </summary>
        public static readonly AutoScalingMode NO_SCALING = new AutoScalingMode("NO_SCALING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AutoScalingMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AutoScalingMode FindValue(string value)
        {
            return FindValue<AutoScalingMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AutoScalingMode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AutoScalingStatus.
    /// </summary>
    public class AutoScalingStatus : ConstantClass
    {

        /// <summary>
        /// Constant GROWING for AutoScalingStatus
        /// </summary>
        public static readonly AutoScalingStatus GROWING = new AutoScalingStatus("GROWING");
        /// <summary>
        /// Constant SHRINKING for AutoScalingStatus
        /// </summary>
        public static readonly AutoScalingStatus SHRINKING = new AutoScalingStatus("SHRINKING");
        /// <summary>
        /// Constant STEADY for AutoScalingStatus
        /// </summary>
        public static readonly AutoScalingStatus STEADY = new AutoScalingStatus("STEADY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AutoScalingStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AutoScalingStatus FindValue(string value)
        {
            return FindValue<AutoScalingStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AutoScalingStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type BudgetActionType.
    /// </summary>
    public class BudgetActionType : ConstantClass
    {

        /// <summary>
        /// Constant STOP_SCHEDULING_AND_CANCEL_TASKS for BudgetActionType
        /// </summary>
        public static readonly BudgetActionType STOP_SCHEDULING_AND_CANCEL_TASKS = new BudgetActionType("STOP_SCHEDULING_AND_CANCEL_TASKS");
        /// <summary>
        /// Constant STOP_SCHEDULING_AND_COMPLETE_TASKS for BudgetActionType
        /// </summary>
        public static readonly BudgetActionType STOP_SCHEDULING_AND_COMPLETE_TASKS = new BudgetActionType("STOP_SCHEDULING_AND_COMPLETE_TASKS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public BudgetActionType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static BudgetActionType FindValue(string value)
        {
            return FindValue<BudgetActionType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator BudgetActionType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type BudgetStatus.
    /// </summary>
    public class BudgetStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for BudgetStatus
        /// </summary>
        public static readonly BudgetStatus ACTIVE = new BudgetStatus("ACTIVE");
        /// <summary>
        /// Constant INACTIVE for BudgetStatus
        /// </summary>
        public static readonly BudgetStatus INACTIVE = new BudgetStatus("INACTIVE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public BudgetStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static BudgetStatus FindValue(string value)
        {
            return FindValue<BudgetStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator BudgetStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ComparisonOperator.
    /// </summary>
    public class ComparisonOperator : ConstantClass
    {

        /// <summary>
        /// Constant EQUAL for ComparisonOperator
        /// </summary>
        public static readonly ComparisonOperator EQUAL = new ComparisonOperator("EQUAL");
        /// <summary>
        /// Constant GREATER_THAN for ComparisonOperator
        /// </summary>
        public static readonly ComparisonOperator GREATER_THAN = new ComparisonOperator("GREATER_THAN");
        /// <summary>
        /// Constant GREATER_THAN_EQUAL_TO for ComparisonOperator
        /// </summary>
        public static readonly ComparisonOperator GREATER_THAN_EQUAL_TO = new ComparisonOperator("GREATER_THAN_EQUAL_TO");
        /// <summary>
        /// Constant LESS_THAN for ComparisonOperator
        /// </summary>
        public static readonly ComparisonOperator LESS_THAN = new ComparisonOperator("LESS_THAN");
        /// <summary>
        /// Constant LESS_THAN_EQUAL_TO for ComparisonOperator
        /// </summary>
        public static readonly ComparisonOperator LESS_THAN_EQUAL_TO = new ComparisonOperator("LESS_THAN_EQUAL_TO");
        /// <summary>
        /// Constant NOT_EQUAL for ComparisonOperator
        /// </summary>
        public static readonly ComparisonOperator NOT_EQUAL = new ComparisonOperator("NOT_EQUAL");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ComparisonOperator(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ComparisonOperator FindValue(string value)
        {
            return FindValue<ComparisonOperator>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ComparisonOperator(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CompletedStatus.
    /// </summary>
    public class CompletedStatus : ConstantClass
    {

        /// <summary>
        /// Constant CANCELED for CompletedStatus
        /// </summary>
        public static readonly CompletedStatus CANCELED = new CompletedStatus("CANCELED");
        /// <summary>
        /// Constant FAILED for CompletedStatus
        /// </summary>
        public static readonly CompletedStatus FAILED = new CompletedStatus("FAILED");
        /// <summary>
        /// Constant INTERRUPTED for CompletedStatus
        /// </summary>
        public static readonly CompletedStatus INTERRUPTED = new CompletedStatus("INTERRUPTED");
        /// <summary>
        /// Constant NEVER_ATTEMPTED for CompletedStatus
        /// </summary>
        public static readonly CompletedStatus NEVER_ATTEMPTED = new CompletedStatus("NEVER_ATTEMPTED");
        /// <summary>
        /// Constant SUCCEEDED for CompletedStatus
        /// </summary>
        public static readonly CompletedStatus SUCCEEDED = new CompletedStatus("SUCCEEDED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CompletedStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CompletedStatus FindValue(string value)
        {
            return FindValue<CompletedStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CompletedStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ConflictExceptionReason.
    /// </summary>
    public class ConflictExceptionReason : ConstantClass
    {

        /// <summary>
        /// Constant CONCURRENT_MODIFICATION for ConflictExceptionReason
        /// </summary>
        public static readonly ConflictExceptionReason CONCURRENT_MODIFICATION = new ConflictExceptionReason("CONCURRENT_MODIFICATION");
        /// <summary>
        /// Constant CONFLICT_EXCEPTION for ConflictExceptionReason
        /// </summary>
        public static readonly ConflictExceptionReason CONFLICT_EXCEPTION = new ConflictExceptionReason("CONFLICT_EXCEPTION");
        /// <summary>
        /// Constant RESOURCE_ALREADY_EXISTS for ConflictExceptionReason
        /// </summary>
        public static readonly ConflictExceptionReason RESOURCE_ALREADY_EXISTS = new ConflictExceptionReason("RESOURCE_ALREADY_EXISTS");
        /// <summary>
        /// Constant RESOURCE_IN_USE for ConflictExceptionReason
        /// </summary>
        public static readonly ConflictExceptionReason RESOURCE_IN_USE = new ConflictExceptionReason("RESOURCE_IN_USE");
        /// <summary>
        /// Constant STATUS_CONFLICT for ConflictExceptionReason
        /// </summary>
        public static readonly ConflictExceptionReason STATUS_CONFLICT = new ConflictExceptionReason("STATUS_CONFLICT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ConflictExceptionReason(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ConflictExceptionReason FindValue(string value)
        {
            return FindValue<ConflictExceptionReason>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ConflictExceptionReason(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CpuArchitectureType.
    /// </summary>
    public class CpuArchitectureType : ConstantClass
    {

        /// <summary>
        /// Constant Arm64 for CpuArchitectureType
        /// </summary>
        public static readonly CpuArchitectureType Arm64 = new CpuArchitectureType("arm64");
        /// <summary>
        /// Constant X86_64 for CpuArchitectureType
        /// </summary>
        public static readonly CpuArchitectureType X86_64 = new CpuArchitectureType("x86_64");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CpuArchitectureType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CpuArchitectureType FindValue(string value)
        {
            return FindValue<CpuArchitectureType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CpuArchitectureType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CreateJobTargetTaskRunStatus.
    /// </summary>
    public class CreateJobTargetTaskRunStatus : ConstantClass
    {

        /// <summary>
        /// Constant READY for CreateJobTargetTaskRunStatus
        /// </summary>
        public static readonly CreateJobTargetTaskRunStatus READY = new CreateJobTargetTaskRunStatus("READY");
        /// <summary>
        /// Constant SUSPENDED for CreateJobTargetTaskRunStatus
        /// </summary>
        public static readonly CreateJobTargetTaskRunStatus SUSPENDED = new CreateJobTargetTaskRunStatus("SUSPENDED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CreateJobTargetTaskRunStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CreateJobTargetTaskRunStatus FindValue(string value)
        {
            return FindValue<CreateJobTargetTaskRunStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CreateJobTargetTaskRunStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CustomerManagedFleetOperatingSystemFamily.
    /// </summary>
    public class CustomerManagedFleetOperatingSystemFamily : ConstantClass
    {

        /// <summary>
        /// Constant LINUX for CustomerManagedFleetOperatingSystemFamily
        /// </summary>
        public static readonly CustomerManagedFleetOperatingSystemFamily LINUX = new CustomerManagedFleetOperatingSystemFamily("LINUX");
        /// <summary>
        /// Constant MACOS for CustomerManagedFleetOperatingSystemFamily
        /// </summary>
        public static readonly CustomerManagedFleetOperatingSystemFamily MACOS = new CustomerManagedFleetOperatingSystemFamily("MACOS");
        /// <summary>
        /// Constant WINDOWS for CustomerManagedFleetOperatingSystemFamily
        /// </summary>
        public static readonly CustomerManagedFleetOperatingSystemFamily WINDOWS = new CustomerManagedFleetOperatingSystemFamily("WINDOWS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CustomerManagedFleetOperatingSystemFamily(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CustomerManagedFleetOperatingSystemFamily FindValue(string value)
        {
            return FindValue<CustomerManagedFleetOperatingSystemFamily>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CustomerManagedFleetOperatingSystemFamily(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DefaultQueueBudgetAction.
    /// </summary>
    public class DefaultQueueBudgetAction : ConstantClass
    {

        /// <summary>
        /// Constant NONE for DefaultQueueBudgetAction
        /// </summary>
        public static readonly DefaultQueueBudgetAction NONE = new DefaultQueueBudgetAction("NONE");
        /// <summary>
        /// Constant STOP_SCHEDULING_AND_CANCEL_TASKS for DefaultQueueBudgetAction
        /// </summary>
        public static readonly DefaultQueueBudgetAction STOP_SCHEDULING_AND_CANCEL_TASKS = new DefaultQueueBudgetAction("STOP_SCHEDULING_AND_CANCEL_TASKS");
        /// <summary>
        /// Constant STOP_SCHEDULING_AND_COMPLETE_TASKS for DefaultQueueBudgetAction
        /// </summary>
        public static readonly DefaultQueueBudgetAction STOP_SCHEDULING_AND_COMPLETE_TASKS = new DefaultQueueBudgetAction("STOP_SCHEDULING_AND_COMPLETE_TASKS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DefaultQueueBudgetAction(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DefaultQueueBudgetAction FindValue(string value)
        {
            return FindValue<DefaultQueueBudgetAction>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DefaultQueueBudgetAction(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DependencyConsumerResolutionStatus.
    /// </summary>
    public class DependencyConsumerResolutionStatus : ConstantClass
    {

        /// <summary>
        /// Constant RESOLVED for DependencyConsumerResolutionStatus
        /// </summary>
        public static readonly DependencyConsumerResolutionStatus RESOLVED = new DependencyConsumerResolutionStatus("RESOLVED");
        /// <summary>
        /// Constant UNRESOLVED for DependencyConsumerResolutionStatus
        /// </summary>
        public static readonly DependencyConsumerResolutionStatus UNRESOLVED = new DependencyConsumerResolutionStatus("UNRESOLVED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DependencyConsumerResolutionStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DependencyConsumerResolutionStatus FindValue(string value)
        {
            return FindValue<DependencyConsumerResolutionStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DependencyConsumerResolutionStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DesiredWorkerStatus.
    /// </summary>
    public class DesiredWorkerStatus : ConstantClass
    {

        /// <summary>
        /// Constant STOPPED for DesiredWorkerStatus
        /// </summary>
        public static readonly DesiredWorkerStatus STOPPED = new DesiredWorkerStatus("STOPPED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DesiredWorkerStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DesiredWorkerStatus FindValue(string value)
        {
            return FindValue<DesiredWorkerStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DesiredWorkerStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Ec2MarketType.
    /// </summary>
    public class Ec2MarketType : ConstantClass
    {

        /// <summary>
        /// Constant OnDemand for Ec2MarketType
        /// </summary>
        public static readonly Ec2MarketType OnDemand = new Ec2MarketType("on-demand");
        /// <summary>
        /// Constant Spot for Ec2MarketType
        /// </summary>
        public static readonly Ec2MarketType Spot = new Ec2MarketType("spot");
        /// <summary>
        /// Constant WaitAndSave for Ec2MarketType
        /// </summary>
        public static readonly Ec2MarketType WaitAndSave = new Ec2MarketType("wait-and-save");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Ec2MarketType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Ec2MarketType FindValue(string value)
        {
            return FindValue<Ec2MarketType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Ec2MarketType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type EnvironmentTemplateType.
    /// </summary>
    public class EnvironmentTemplateType : ConstantClass
    {

        /// <summary>
        /// Constant JSON for EnvironmentTemplateType
        /// </summary>
        public static readonly EnvironmentTemplateType JSON = new EnvironmentTemplateType("JSON");
        /// <summary>
        /// Constant YAML for EnvironmentTemplateType
        /// </summary>
        public static readonly EnvironmentTemplateType YAML = new EnvironmentTemplateType("YAML");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EnvironmentTemplateType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EnvironmentTemplateType FindValue(string value)
        {
            return FindValue<EnvironmentTemplateType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EnvironmentTemplateType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type FileSystemLocationType.
    /// </summary>
    public class FileSystemLocationType : ConstantClass
    {

        /// <summary>
        /// Constant LOCAL for FileSystemLocationType
        /// </summary>
        public static readonly FileSystemLocationType LOCAL = new FileSystemLocationType("LOCAL");
        /// <summary>
        /// Constant SHARED for FileSystemLocationType
        /// </summary>
        public static readonly FileSystemLocationType SHARED = new FileSystemLocationType("SHARED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FileSystemLocationType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FileSystemLocationType FindValue(string value)
        {
            return FindValue<FileSystemLocationType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FileSystemLocationType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type FleetStatus.
    /// </summary>
    public class FleetStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for FleetStatus
        /// </summary>
        public static readonly FleetStatus ACTIVE = new FleetStatus("ACTIVE");
        /// <summary>
        /// Constant CREATE_FAILED for FleetStatus
        /// </summary>
        public static readonly FleetStatus CREATE_FAILED = new FleetStatus("CREATE_FAILED");
        /// <summary>
        /// Constant CREATE_IN_PROGRESS for FleetStatus
        /// </summary>
        public static readonly FleetStatus CREATE_IN_PROGRESS = new FleetStatus("CREATE_IN_PROGRESS");
        /// <summary>
        /// Constant SUSPENDED for FleetStatus
        /// </summary>
        public static readonly FleetStatus SUSPENDED = new FleetStatus("SUSPENDED");
        /// <summary>
        /// Constant UPDATE_FAILED for FleetStatus
        /// </summary>
        public static readonly FleetStatus UPDATE_FAILED = new FleetStatus("UPDATE_FAILED");
        /// <summary>
        /// Constant UPDATE_IN_PROGRESS for FleetStatus
        /// </summary>
        public static readonly FleetStatus UPDATE_IN_PROGRESS = new FleetStatus("UPDATE_IN_PROGRESS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FleetStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FleetStatus FindValue(string value)
        {
            return FindValue<FleetStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FleetStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type JobAttachmentsFileSystem.
    /// </summary>
    public class JobAttachmentsFileSystem : ConstantClass
    {

        /// <summary>
        /// Constant COPIED for JobAttachmentsFileSystem
        /// </summary>
        public static readonly JobAttachmentsFileSystem COPIED = new JobAttachmentsFileSystem("COPIED");
        /// <summary>
        /// Constant VIRTUAL for JobAttachmentsFileSystem
        /// </summary>
        public static readonly JobAttachmentsFileSystem VIRTUAL = new JobAttachmentsFileSystem("VIRTUAL");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public JobAttachmentsFileSystem(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static JobAttachmentsFileSystem FindValue(string value)
        {
            return FindValue<JobAttachmentsFileSystem>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator JobAttachmentsFileSystem(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type JobEntityErrorCode.
    /// </summary>
    public class JobEntityErrorCode : ConstantClass
    {

        /// <summary>
        /// Constant AccessDeniedException for JobEntityErrorCode
        /// </summary>
        public static readonly JobEntityErrorCode AccessDeniedException = new JobEntityErrorCode("AccessDeniedException");
        /// <summary>
        /// Constant ConflictException for JobEntityErrorCode
        /// </summary>
        public static readonly JobEntityErrorCode ConflictException = new JobEntityErrorCode("ConflictException");
        /// <summary>
        /// Constant InternalServerException for JobEntityErrorCode
        /// </summary>
        public static readonly JobEntityErrorCode InternalServerException = new JobEntityErrorCode("InternalServerException");
        /// <summary>
        /// Constant MaxPayloadSizeExceeded for JobEntityErrorCode
        /// </summary>
        public static readonly JobEntityErrorCode MaxPayloadSizeExceeded = new JobEntityErrorCode("MaxPayloadSizeExceeded");
        /// <summary>
        /// Constant ResourceNotFoundException for JobEntityErrorCode
        /// </summary>
        public static readonly JobEntityErrorCode ResourceNotFoundException = new JobEntityErrorCode("ResourceNotFoundException");
        /// <summary>
        /// Constant ValidationException for JobEntityErrorCode
        /// </summary>
        public static readonly JobEntityErrorCode ValidationException = new JobEntityErrorCode("ValidationException");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public JobEntityErrorCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static JobEntityErrorCode FindValue(string value)
        {
            return FindValue<JobEntityErrorCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator JobEntityErrorCode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type JobLifecycleStatus.
    /// </summary>
    public class JobLifecycleStatus : ConstantClass
    {

        /// <summary>
        /// Constant ARCHIVED for JobLifecycleStatus
        /// </summary>
        public static readonly JobLifecycleStatus ARCHIVED = new JobLifecycleStatus("ARCHIVED");
        /// <summary>
        /// Constant CREATE_COMPLETE for JobLifecycleStatus
        /// </summary>
        public static readonly JobLifecycleStatus CREATE_COMPLETE = new JobLifecycleStatus("CREATE_COMPLETE");
        /// <summary>
        /// Constant CREATE_FAILED for JobLifecycleStatus
        /// </summary>
        public static readonly JobLifecycleStatus CREATE_FAILED = new JobLifecycleStatus("CREATE_FAILED");
        /// <summary>
        /// Constant CREATE_IN_PROGRESS for JobLifecycleStatus
        /// </summary>
        public static readonly JobLifecycleStatus CREATE_IN_PROGRESS = new JobLifecycleStatus("CREATE_IN_PROGRESS");
        /// <summary>
        /// Constant UPDATE_FAILED for JobLifecycleStatus
        /// </summary>
        public static readonly JobLifecycleStatus UPDATE_FAILED = new JobLifecycleStatus("UPDATE_FAILED");
        /// <summary>
        /// Constant UPDATE_IN_PROGRESS for JobLifecycleStatus
        /// </summary>
        public static readonly JobLifecycleStatus UPDATE_IN_PROGRESS = new JobLifecycleStatus("UPDATE_IN_PROGRESS");
        /// <summary>
        /// Constant UPDATE_SUCCEEDED for JobLifecycleStatus
        /// </summary>
        public static readonly JobLifecycleStatus UPDATE_SUCCEEDED = new JobLifecycleStatus("UPDATE_SUCCEEDED");
        /// <summary>
        /// Constant UPLOAD_FAILED for JobLifecycleStatus
        /// </summary>
        public static readonly JobLifecycleStatus UPLOAD_FAILED = new JobLifecycleStatus("UPLOAD_FAILED");
        /// <summary>
        /// Constant UPLOAD_IN_PROGRESS for JobLifecycleStatus
        /// </summary>
        public static readonly JobLifecycleStatus UPLOAD_IN_PROGRESS = new JobLifecycleStatus("UPLOAD_IN_PROGRESS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public JobLifecycleStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static JobLifecycleStatus FindValue(string value)
        {
            return FindValue<JobLifecycleStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator JobLifecycleStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type JobTargetTaskRunStatus.
    /// </summary>
    public class JobTargetTaskRunStatus : ConstantClass
    {

        /// <summary>
        /// Constant CANCELED for JobTargetTaskRunStatus
        /// </summary>
        public static readonly JobTargetTaskRunStatus CANCELED = new JobTargetTaskRunStatus("CANCELED");
        /// <summary>
        /// Constant FAILED for JobTargetTaskRunStatus
        /// </summary>
        public static readonly JobTargetTaskRunStatus FAILED = new JobTargetTaskRunStatus("FAILED");
        /// <summary>
        /// Constant PENDING for JobTargetTaskRunStatus
        /// </summary>
        public static readonly JobTargetTaskRunStatus PENDING = new JobTargetTaskRunStatus("PENDING");
        /// <summary>
        /// Constant READY for JobTargetTaskRunStatus
        /// </summary>
        public static readonly JobTargetTaskRunStatus READY = new JobTargetTaskRunStatus("READY");
        /// <summary>
        /// Constant SUCCEEDED for JobTargetTaskRunStatus
        /// </summary>
        public static readonly JobTargetTaskRunStatus SUCCEEDED = new JobTargetTaskRunStatus("SUCCEEDED");
        /// <summary>
        /// Constant SUSPENDED for JobTargetTaskRunStatus
        /// </summary>
        public static readonly JobTargetTaskRunStatus SUSPENDED = new JobTargetTaskRunStatus("SUSPENDED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public JobTargetTaskRunStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static JobTargetTaskRunStatus FindValue(string value)
        {
            return FindValue<JobTargetTaskRunStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator JobTargetTaskRunStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type JobTemplateType.
    /// </summary>
    public class JobTemplateType : ConstantClass
    {

        /// <summary>
        /// Constant JSON for JobTemplateType
        /// </summary>
        public static readonly JobTemplateType JSON = new JobTemplateType("JSON");
        /// <summary>
        /// Constant YAML for JobTemplateType
        /// </summary>
        public static readonly JobTemplateType YAML = new JobTemplateType("YAML");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public JobTemplateType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static JobTemplateType FindValue(string value)
        {
            return FindValue<JobTemplateType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator JobTemplateType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type LicenseEndpointStatus.
    /// </summary>
    public class LicenseEndpointStatus : ConstantClass
    {

        /// <summary>
        /// Constant CREATE_IN_PROGRESS for LicenseEndpointStatus
        /// </summary>
        public static readonly LicenseEndpointStatus CREATE_IN_PROGRESS = new LicenseEndpointStatus("CREATE_IN_PROGRESS");
        /// <summary>
        /// Constant DELETE_IN_PROGRESS for LicenseEndpointStatus
        /// </summary>
        public static readonly LicenseEndpointStatus DELETE_IN_PROGRESS = new LicenseEndpointStatus("DELETE_IN_PROGRESS");
        /// <summary>
        /// Constant NOT_READY for LicenseEndpointStatus
        /// </summary>
        public static readonly LicenseEndpointStatus NOT_READY = new LicenseEndpointStatus("NOT_READY");
        /// <summary>
        /// Constant READY for LicenseEndpointStatus
        /// </summary>
        public static readonly LicenseEndpointStatus READY = new LicenseEndpointStatus("READY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public LicenseEndpointStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LicenseEndpointStatus FindValue(string value)
        {
            return FindValue<LicenseEndpointStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator LicenseEndpointStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type LogicalOperator.
    /// </summary>
    public class LogicalOperator : ConstantClass
    {

        /// <summary>
        /// Constant AND for LogicalOperator
        /// </summary>
        public static readonly LogicalOperator AND = new LogicalOperator("AND");
        /// <summary>
        /// Constant OR for LogicalOperator
        /// </summary>
        public static readonly LogicalOperator OR = new LogicalOperator("OR");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public LogicalOperator(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LogicalOperator FindValue(string value)
        {
            return FindValue<LogicalOperator>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator LogicalOperator(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type MembershipLevel.
    /// </summary>
    public class MembershipLevel : ConstantClass
    {

        /// <summary>
        /// Constant CONTRIBUTOR for MembershipLevel
        /// </summary>
        public static readonly MembershipLevel CONTRIBUTOR = new MembershipLevel("CONTRIBUTOR");
        /// <summary>
        /// Constant MANAGER for MembershipLevel
        /// </summary>
        public static readonly MembershipLevel MANAGER = new MembershipLevel("MANAGER");
        /// <summary>
        /// Constant OWNER for MembershipLevel
        /// </summary>
        public static readonly MembershipLevel OWNER = new MembershipLevel("OWNER");
        /// <summary>
        /// Constant VIEWER for MembershipLevel
        /// </summary>
        public static readonly MembershipLevel VIEWER = new MembershipLevel("VIEWER");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MembershipLevel(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MembershipLevel FindValue(string value)
        {
            return FindValue<MembershipLevel>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MembershipLevel(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PathFormat.
    /// </summary>
    public class PathFormat : ConstantClass
    {

        /// <summary>
        /// Constant Posix for PathFormat
        /// </summary>
        public static readonly PathFormat Posix = new PathFormat("posix");
        /// <summary>
        /// Constant Windows for PathFormat
        /// </summary>
        public static readonly PathFormat Windows = new PathFormat("windows");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PathFormat(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PathFormat FindValue(string value)
        {
            return FindValue<PathFormat>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PathFormat(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Period.
    /// </summary>
    public class Period : ConstantClass
    {

        /// <summary>
        /// Constant DAILY for Period
        /// </summary>
        public static readonly Period DAILY = new Period("DAILY");
        /// <summary>
        /// Constant HOURLY for Period
        /// </summary>
        public static readonly Period HOURLY = new Period("HOURLY");
        /// <summary>
        /// Constant MONTHLY for Period
        /// </summary>
        public static readonly Period MONTHLY = new Period("MONTHLY");
        /// <summary>
        /// Constant WEEKLY for Period
        /// </summary>
        public static readonly Period WEEKLY = new Period("WEEKLY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Period(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Period FindValue(string value)
        {
            return FindValue<Period>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Period(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PrincipalType.
    /// </summary>
    public class PrincipalType : ConstantClass
    {

        /// <summary>
        /// Constant GROUP for PrincipalType
        /// </summary>
        public static readonly PrincipalType GROUP = new PrincipalType("GROUP");
        /// <summary>
        /// Constant USER for PrincipalType
        /// </summary>
        public static readonly PrincipalType USER = new PrincipalType("USER");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PrincipalType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PrincipalType FindValue(string value)
        {
            return FindValue<PrincipalType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PrincipalType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type QueueBlockedReason.
    /// </summary>
    public class QueueBlockedReason : ConstantClass
    {

        /// <summary>
        /// Constant BUDGET_THRESHOLD_REACHED for QueueBlockedReason
        /// </summary>
        public static readonly QueueBlockedReason BUDGET_THRESHOLD_REACHED = new QueueBlockedReason("BUDGET_THRESHOLD_REACHED");
        /// <summary>
        /// Constant NO_BUDGET_CONFIGURED for QueueBlockedReason
        /// </summary>
        public static readonly QueueBlockedReason NO_BUDGET_CONFIGURED = new QueueBlockedReason("NO_BUDGET_CONFIGURED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public QueueBlockedReason(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static QueueBlockedReason FindValue(string value)
        {
            return FindValue<QueueBlockedReason>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator QueueBlockedReason(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type QueueFleetAssociationStatus.
    /// </summary>
    public class QueueFleetAssociationStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for QueueFleetAssociationStatus
        /// </summary>
        public static readonly QueueFleetAssociationStatus ACTIVE = new QueueFleetAssociationStatus("ACTIVE");
        /// <summary>
        /// Constant STOP_SCHEDULING_AND_CANCEL_TASKS for QueueFleetAssociationStatus
        /// </summary>
        public static readonly QueueFleetAssociationStatus STOP_SCHEDULING_AND_CANCEL_TASKS = new QueueFleetAssociationStatus("STOP_SCHEDULING_AND_CANCEL_TASKS");
        /// <summary>
        /// Constant STOP_SCHEDULING_AND_COMPLETE_TASKS for QueueFleetAssociationStatus
        /// </summary>
        public static readonly QueueFleetAssociationStatus STOP_SCHEDULING_AND_COMPLETE_TASKS = new QueueFleetAssociationStatus("STOP_SCHEDULING_AND_COMPLETE_TASKS");
        /// <summary>
        /// Constant STOPPED for QueueFleetAssociationStatus
        /// </summary>
        public static readonly QueueFleetAssociationStatus STOPPED = new QueueFleetAssociationStatus("STOPPED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public QueueFleetAssociationStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static QueueFleetAssociationStatus FindValue(string value)
        {
            return FindValue<QueueFleetAssociationStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator QueueFleetAssociationStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type QueueLimitAssociationStatus.
    /// </summary>
    public class QueueLimitAssociationStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for QueueLimitAssociationStatus
        /// </summary>
        public static readonly QueueLimitAssociationStatus ACTIVE = new QueueLimitAssociationStatus("ACTIVE");
        /// <summary>
        /// Constant STOP_LIMIT_USAGE_AND_CANCEL_TASKS for QueueLimitAssociationStatus
        /// </summary>
        public static readonly QueueLimitAssociationStatus STOP_LIMIT_USAGE_AND_CANCEL_TASKS = new QueueLimitAssociationStatus("STOP_LIMIT_USAGE_AND_CANCEL_TASKS");
        /// <summary>
        /// Constant STOP_LIMIT_USAGE_AND_COMPLETE_TASKS for QueueLimitAssociationStatus
        /// </summary>
        public static readonly QueueLimitAssociationStatus STOP_LIMIT_USAGE_AND_COMPLETE_TASKS = new QueueLimitAssociationStatus("STOP_LIMIT_USAGE_AND_COMPLETE_TASKS");
        /// <summary>
        /// Constant STOPPED for QueueLimitAssociationStatus
        /// </summary>
        public static readonly QueueLimitAssociationStatus STOPPED = new QueueLimitAssociationStatus("STOPPED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public QueueLimitAssociationStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static QueueLimitAssociationStatus FindValue(string value)
        {
            return FindValue<QueueLimitAssociationStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator QueueLimitAssociationStatus(string value)
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
        /// Constant IDLE for QueueStatus
        /// </summary>
        public static readonly QueueStatus IDLE = new QueueStatus("IDLE");
        /// <summary>
        /// Constant SCHEDULING for QueueStatus
        /// </summary>
        public static readonly QueueStatus SCHEDULING = new QueueStatus("SCHEDULING");
        /// <summary>
        /// Constant SCHEDULING_BLOCKED for QueueStatus
        /// </summary>
        public static readonly QueueStatus SCHEDULING_BLOCKED = new QueueStatus("SCHEDULING_BLOCKED");

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
    /// Constants used for properties of type RunAs.
    /// </summary>
    public class RunAs : ConstantClass
    {

        /// <summary>
        /// Constant QUEUE_CONFIGURED_USER for RunAs
        /// </summary>
        public static readonly RunAs QUEUE_CONFIGURED_USER = new RunAs("QUEUE_CONFIGURED_USER");
        /// <summary>
        /// Constant WORKER_AGENT_USER for RunAs
        /// </summary>
        public static readonly RunAs WORKER_AGENT_USER = new RunAs("WORKER_AGENT_USER");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RunAs(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RunAs FindValue(string value)
        {
            return FindValue<RunAs>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RunAs(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SearchTermMatchingType.
    /// </summary>
    public class SearchTermMatchingType : ConstantClass
    {

        /// <summary>
        /// Constant CONTAINS for SearchTermMatchingType
        /// </summary>
        public static readonly SearchTermMatchingType CONTAINS = new SearchTermMatchingType("CONTAINS");
        /// <summary>
        /// Constant FUZZY_MATCH for SearchTermMatchingType
        /// </summary>
        public static readonly SearchTermMatchingType FUZZY_MATCH = new SearchTermMatchingType("FUZZY_MATCH");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SearchTermMatchingType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SearchTermMatchingType FindValue(string value)
        {
            return FindValue<SearchTermMatchingType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SearchTermMatchingType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ServiceManagedFleetOperatingSystemFamily.
    /// </summary>
    public class ServiceManagedFleetOperatingSystemFamily : ConstantClass
    {

        /// <summary>
        /// Constant LINUX for ServiceManagedFleetOperatingSystemFamily
        /// </summary>
        public static readonly ServiceManagedFleetOperatingSystemFamily LINUX = new ServiceManagedFleetOperatingSystemFamily("LINUX");
        /// <summary>
        /// Constant WINDOWS for ServiceManagedFleetOperatingSystemFamily
        /// </summary>
        public static readonly ServiceManagedFleetOperatingSystemFamily WINDOWS = new ServiceManagedFleetOperatingSystemFamily("WINDOWS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ServiceManagedFleetOperatingSystemFamily(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ServiceManagedFleetOperatingSystemFamily FindValue(string value)
        {
            return FindValue<ServiceManagedFleetOperatingSystemFamily>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ServiceManagedFleetOperatingSystemFamily(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ServiceQuotaExceededExceptionReason.
    /// </summary>
    public class ServiceQuotaExceededExceptionReason : ConstantClass
    {

        /// <summary>
        /// Constant DEPENDENCY_LIMIT_EXCEEDED for ServiceQuotaExceededExceptionReason
        /// </summary>
        public static readonly ServiceQuotaExceededExceptionReason DEPENDENCY_LIMIT_EXCEEDED = new ServiceQuotaExceededExceptionReason("DEPENDENCY_LIMIT_EXCEEDED");
        /// <summary>
        /// Constant KMS_KEY_LIMIT_EXCEEDED for ServiceQuotaExceededExceptionReason
        /// </summary>
        public static readonly ServiceQuotaExceededExceptionReason KMS_KEY_LIMIT_EXCEEDED = new ServiceQuotaExceededExceptionReason("KMS_KEY_LIMIT_EXCEEDED");
        /// <summary>
        /// Constant SERVICE_QUOTA_EXCEEDED_EXCEPTION for ServiceQuotaExceededExceptionReason
        /// </summary>
        public static readonly ServiceQuotaExceededExceptionReason SERVICE_QUOTA_EXCEEDED_EXCEPTION = new ServiceQuotaExceededExceptionReason("SERVICE_QUOTA_EXCEEDED_EXCEPTION");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ServiceQuotaExceededExceptionReason(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ServiceQuotaExceededExceptionReason FindValue(string value)
        {
            return FindValue<ServiceQuotaExceededExceptionReason>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ServiceQuotaExceededExceptionReason(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SessionActionStatus.
    /// </summary>
    public class SessionActionStatus : ConstantClass
    {

        /// <summary>
        /// Constant ASSIGNED for SessionActionStatus
        /// </summary>
        public static readonly SessionActionStatus ASSIGNED = new SessionActionStatus("ASSIGNED");
        /// <summary>
        /// Constant CANCELED for SessionActionStatus
        /// </summary>
        public static readonly SessionActionStatus CANCELED = new SessionActionStatus("CANCELED");
        /// <summary>
        /// Constant CANCELING for SessionActionStatus
        /// </summary>
        public static readonly SessionActionStatus CANCELING = new SessionActionStatus("CANCELING");
        /// <summary>
        /// Constant FAILED for SessionActionStatus
        /// </summary>
        public static readonly SessionActionStatus FAILED = new SessionActionStatus("FAILED");
        /// <summary>
        /// Constant INTERRUPTED for SessionActionStatus
        /// </summary>
        public static readonly SessionActionStatus INTERRUPTED = new SessionActionStatus("INTERRUPTED");
        /// <summary>
        /// Constant NEVER_ATTEMPTED for SessionActionStatus
        /// </summary>
        public static readonly SessionActionStatus NEVER_ATTEMPTED = new SessionActionStatus("NEVER_ATTEMPTED");
        /// <summary>
        /// Constant RECLAIMED for SessionActionStatus
        /// </summary>
        public static readonly SessionActionStatus RECLAIMED = new SessionActionStatus("RECLAIMED");
        /// <summary>
        /// Constant RECLAIMING for SessionActionStatus
        /// </summary>
        public static readonly SessionActionStatus RECLAIMING = new SessionActionStatus("RECLAIMING");
        /// <summary>
        /// Constant RUNNING for SessionActionStatus
        /// </summary>
        public static readonly SessionActionStatus RUNNING = new SessionActionStatus("RUNNING");
        /// <summary>
        /// Constant SCHEDULED for SessionActionStatus
        /// </summary>
        public static readonly SessionActionStatus SCHEDULED = new SessionActionStatus("SCHEDULED");
        /// <summary>
        /// Constant SUCCEEDED for SessionActionStatus
        /// </summary>
        public static readonly SessionActionStatus SUCCEEDED = new SessionActionStatus("SUCCEEDED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SessionActionStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SessionActionStatus FindValue(string value)
        {
            return FindValue<SessionActionStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SessionActionStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SessionLifecycleStatus.
    /// </summary>
    public class SessionLifecycleStatus : ConstantClass
    {

        /// <summary>
        /// Constant ENDED for SessionLifecycleStatus
        /// </summary>
        public static readonly SessionLifecycleStatus ENDED = new SessionLifecycleStatus("ENDED");
        /// <summary>
        /// Constant STARTED for SessionLifecycleStatus
        /// </summary>
        public static readonly SessionLifecycleStatus STARTED = new SessionLifecycleStatus("STARTED");
        /// <summary>
        /// Constant UPDATE_FAILED for SessionLifecycleStatus
        /// </summary>
        public static readonly SessionLifecycleStatus UPDATE_FAILED = new SessionLifecycleStatus("UPDATE_FAILED");
        /// <summary>
        /// Constant UPDATE_IN_PROGRESS for SessionLifecycleStatus
        /// </summary>
        public static readonly SessionLifecycleStatus UPDATE_IN_PROGRESS = new SessionLifecycleStatus("UPDATE_IN_PROGRESS");
        /// <summary>
        /// Constant UPDATE_SUCCEEDED for SessionLifecycleStatus
        /// </summary>
        public static readonly SessionLifecycleStatus UPDATE_SUCCEEDED = new SessionLifecycleStatus("UPDATE_SUCCEEDED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SessionLifecycleStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SessionLifecycleStatus FindValue(string value)
        {
            return FindValue<SessionLifecycleStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SessionLifecycleStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SessionLifecycleTargetStatus.
    /// </summary>
    public class SessionLifecycleTargetStatus : ConstantClass
    {

        /// <summary>
        /// Constant ENDED for SessionLifecycleTargetStatus
        /// </summary>
        public static readonly SessionLifecycleTargetStatus ENDED = new SessionLifecycleTargetStatus("ENDED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SessionLifecycleTargetStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SessionLifecycleTargetStatus FindValue(string value)
        {
            return FindValue<SessionLifecycleTargetStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SessionLifecycleTargetStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SessionsStatisticsAggregationStatus.
    /// </summary>
    public class SessionsStatisticsAggregationStatus : ConstantClass
    {

        /// <summary>
        /// Constant COMPLETED for SessionsStatisticsAggregationStatus
        /// </summary>
        public static readonly SessionsStatisticsAggregationStatus COMPLETED = new SessionsStatisticsAggregationStatus("COMPLETED");
        /// <summary>
        /// Constant FAILED for SessionsStatisticsAggregationStatus
        /// </summary>
        public static readonly SessionsStatisticsAggregationStatus FAILED = new SessionsStatisticsAggregationStatus("FAILED");
        /// <summary>
        /// Constant IN_PROGRESS for SessionsStatisticsAggregationStatus
        /// </summary>
        public static readonly SessionsStatisticsAggregationStatus IN_PROGRESS = new SessionsStatisticsAggregationStatus("IN_PROGRESS");
        /// <summary>
        /// Constant TIMEOUT for SessionsStatisticsAggregationStatus
        /// </summary>
        public static readonly SessionsStatisticsAggregationStatus TIMEOUT = new SessionsStatisticsAggregationStatus("TIMEOUT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SessionsStatisticsAggregationStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SessionsStatisticsAggregationStatus FindValue(string value)
        {
            return FindValue<SessionsStatisticsAggregationStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SessionsStatisticsAggregationStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SortOrder.
    /// </summary>
    public class SortOrder : ConstantClass
    {

        /// <summary>
        /// Constant ASCENDING for SortOrder
        /// </summary>
        public static readonly SortOrder ASCENDING = new SortOrder("ASCENDING");
        /// <summary>
        /// Constant DESCENDING for SortOrder
        /// </summary>
        public static readonly SortOrder DESCENDING = new SortOrder("DESCENDING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SortOrder(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SortOrder FindValue(string value)
        {
            return FindValue<SortOrder>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SortOrder(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type StepLifecycleStatus.
    /// </summary>
    public class StepLifecycleStatus : ConstantClass
    {

        /// <summary>
        /// Constant CREATE_COMPLETE for StepLifecycleStatus
        /// </summary>
        public static readonly StepLifecycleStatus CREATE_COMPLETE = new StepLifecycleStatus("CREATE_COMPLETE");
        /// <summary>
        /// Constant UPDATE_FAILED for StepLifecycleStatus
        /// </summary>
        public static readonly StepLifecycleStatus UPDATE_FAILED = new StepLifecycleStatus("UPDATE_FAILED");
        /// <summary>
        /// Constant UPDATE_IN_PROGRESS for StepLifecycleStatus
        /// </summary>
        public static readonly StepLifecycleStatus UPDATE_IN_PROGRESS = new StepLifecycleStatus("UPDATE_IN_PROGRESS");
        /// <summary>
        /// Constant UPDATE_SUCCEEDED for StepLifecycleStatus
        /// </summary>
        public static readonly StepLifecycleStatus UPDATE_SUCCEEDED = new StepLifecycleStatus("UPDATE_SUCCEEDED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public StepLifecycleStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static StepLifecycleStatus FindValue(string value)
        {
            return FindValue<StepLifecycleStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator StepLifecycleStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type StepParameterType.
    /// </summary>
    public class StepParameterType : ConstantClass
    {

        /// <summary>
        /// Constant CHUNK_INT for StepParameterType
        /// </summary>
        public static readonly StepParameterType CHUNK_INT = new StepParameterType("CHUNK_INT");
        /// <summary>
        /// Constant FLOAT for StepParameterType
        /// </summary>
        public static readonly StepParameterType FLOAT = new StepParameterType("FLOAT");
        /// <summary>
        /// Constant INT for StepParameterType
        /// </summary>
        public static readonly StepParameterType INT = new StepParameterType("INT");
        /// <summary>
        /// Constant PATH for StepParameterType
        /// </summary>
        public static readonly StepParameterType PATH = new StepParameterType("PATH");
        /// <summary>
        /// Constant STRING for StepParameterType
        /// </summary>
        public static readonly StepParameterType STRING = new StepParameterType("STRING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public StepParameterType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static StepParameterType FindValue(string value)
        {
            return FindValue<StepParameterType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator StepParameterType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type StepTargetTaskRunStatus.
    /// </summary>
    public class StepTargetTaskRunStatus : ConstantClass
    {

        /// <summary>
        /// Constant CANCELED for StepTargetTaskRunStatus
        /// </summary>
        public static readonly StepTargetTaskRunStatus CANCELED = new StepTargetTaskRunStatus("CANCELED");
        /// <summary>
        /// Constant FAILED for StepTargetTaskRunStatus
        /// </summary>
        public static readonly StepTargetTaskRunStatus FAILED = new StepTargetTaskRunStatus("FAILED");
        /// <summary>
        /// Constant PENDING for StepTargetTaskRunStatus
        /// </summary>
        public static readonly StepTargetTaskRunStatus PENDING = new StepTargetTaskRunStatus("PENDING");
        /// <summary>
        /// Constant READY for StepTargetTaskRunStatus
        /// </summary>
        public static readonly StepTargetTaskRunStatus READY = new StepTargetTaskRunStatus("READY");
        /// <summary>
        /// Constant SUCCEEDED for StepTargetTaskRunStatus
        /// </summary>
        public static readonly StepTargetTaskRunStatus SUCCEEDED = new StepTargetTaskRunStatus("SUCCEEDED");
        /// <summary>
        /// Constant SUSPENDED for StepTargetTaskRunStatus
        /// </summary>
        public static readonly StepTargetTaskRunStatus SUSPENDED = new StepTargetTaskRunStatus("SUSPENDED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public StepTargetTaskRunStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static StepTargetTaskRunStatus FindValue(string value)
        {
            return FindValue<StepTargetTaskRunStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator StepTargetTaskRunStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type StorageProfileOperatingSystemFamily.
    /// </summary>
    public class StorageProfileOperatingSystemFamily : ConstantClass
    {

        /// <summary>
        /// Constant LINUX for StorageProfileOperatingSystemFamily
        /// </summary>
        public static readonly StorageProfileOperatingSystemFamily LINUX = new StorageProfileOperatingSystemFamily("LINUX");
        /// <summary>
        /// Constant MACOS for StorageProfileOperatingSystemFamily
        /// </summary>
        public static readonly StorageProfileOperatingSystemFamily MACOS = new StorageProfileOperatingSystemFamily("MACOS");
        /// <summary>
        /// Constant WINDOWS for StorageProfileOperatingSystemFamily
        /// </summary>
        public static readonly StorageProfileOperatingSystemFamily WINDOWS = new StorageProfileOperatingSystemFamily("WINDOWS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public StorageProfileOperatingSystemFamily(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static StorageProfileOperatingSystemFamily FindValue(string value)
        {
            return FindValue<StorageProfileOperatingSystemFamily>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator StorageProfileOperatingSystemFamily(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TagPropagationMode.
    /// </summary>
    public class TagPropagationMode : ConstantClass
    {

        /// <summary>
        /// Constant NO_PROPAGATION for TagPropagationMode
        /// </summary>
        public static readonly TagPropagationMode NO_PROPAGATION = new TagPropagationMode("NO_PROPAGATION");
        /// <summary>
        /// Constant PROPAGATE_TAGS_TO_WORKERS_AT_LAUNCH for TagPropagationMode
        /// </summary>
        public static readonly TagPropagationMode PROPAGATE_TAGS_TO_WORKERS_AT_LAUNCH = new TagPropagationMode("PROPAGATE_TAGS_TO_WORKERS_AT_LAUNCH");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TagPropagationMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TagPropagationMode FindValue(string value)
        {
            return FindValue<TagPropagationMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TagPropagationMode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TaskRunStatus.
    /// </summary>
    public class TaskRunStatus : ConstantClass
    {

        /// <summary>
        /// Constant ASSIGNED for TaskRunStatus
        /// </summary>
        public static readonly TaskRunStatus ASSIGNED = new TaskRunStatus("ASSIGNED");
        /// <summary>
        /// Constant CANCELED for TaskRunStatus
        /// </summary>
        public static readonly TaskRunStatus CANCELED = new TaskRunStatus("CANCELED");
        /// <summary>
        /// Constant FAILED for TaskRunStatus
        /// </summary>
        public static readonly TaskRunStatus FAILED = new TaskRunStatus("FAILED");
        /// <summary>
        /// Constant INTERRUPTING for TaskRunStatus
        /// </summary>
        public static readonly TaskRunStatus INTERRUPTING = new TaskRunStatus("INTERRUPTING");
        /// <summary>
        /// Constant NOT_COMPATIBLE for TaskRunStatus
        /// </summary>
        public static readonly TaskRunStatus NOT_COMPATIBLE = new TaskRunStatus("NOT_COMPATIBLE");
        /// <summary>
        /// Constant PENDING for TaskRunStatus
        /// </summary>
        public static readonly TaskRunStatus PENDING = new TaskRunStatus("PENDING");
        /// <summary>
        /// Constant READY for TaskRunStatus
        /// </summary>
        public static readonly TaskRunStatus READY = new TaskRunStatus("READY");
        /// <summary>
        /// Constant RUNNING for TaskRunStatus
        /// </summary>
        public static readonly TaskRunStatus RUNNING = new TaskRunStatus("RUNNING");
        /// <summary>
        /// Constant SCHEDULED for TaskRunStatus
        /// </summary>
        public static readonly TaskRunStatus SCHEDULED = new TaskRunStatus("SCHEDULED");
        /// <summary>
        /// Constant STARTING for TaskRunStatus
        /// </summary>
        public static readonly TaskRunStatus STARTING = new TaskRunStatus("STARTING");
        /// <summary>
        /// Constant SUCCEEDED for TaskRunStatus
        /// </summary>
        public static readonly TaskRunStatus SUCCEEDED = new TaskRunStatus("SUCCEEDED");
        /// <summary>
        /// Constant SUSPENDED for TaskRunStatus
        /// </summary>
        public static readonly TaskRunStatus SUSPENDED = new TaskRunStatus("SUSPENDED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TaskRunStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TaskRunStatus FindValue(string value)
        {
            return FindValue<TaskRunStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TaskRunStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TaskTargetRunStatus.
    /// </summary>
    public class TaskTargetRunStatus : ConstantClass
    {

        /// <summary>
        /// Constant CANCELED for TaskTargetRunStatus
        /// </summary>
        public static readonly TaskTargetRunStatus CANCELED = new TaskTargetRunStatus("CANCELED");
        /// <summary>
        /// Constant FAILED for TaskTargetRunStatus
        /// </summary>
        public static readonly TaskTargetRunStatus FAILED = new TaskTargetRunStatus("FAILED");
        /// <summary>
        /// Constant PENDING for TaskTargetRunStatus
        /// </summary>
        public static readonly TaskTargetRunStatus PENDING = new TaskTargetRunStatus("PENDING");
        /// <summary>
        /// Constant READY for TaskTargetRunStatus
        /// </summary>
        public static readonly TaskTargetRunStatus READY = new TaskTargetRunStatus("READY");
        /// <summary>
        /// Constant SUCCEEDED for TaskTargetRunStatus
        /// </summary>
        public static readonly TaskTargetRunStatus SUCCEEDED = new TaskTargetRunStatus("SUCCEEDED");
        /// <summary>
        /// Constant SUSPENDED for TaskTargetRunStatus
        /// </summary>
        public static readonly TaskTargetRunStatus SUSPENDED = new TaskTargetRunStatus("SUSPENDED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TaskTargetRunStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TaskTargetRunStatus FindValue(string value)
        {
            return FindValue<TaskTargetRunStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TaskTargetRunStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type UpdatedWorkerStatus.
    /// </summary>
    public class UpdatedWorkerStatus : ConstantClass
    {

        /// <summary>
        /// Constant STARTED for UpdatedWorkerStatus
        /// </summary>
        public static readonly UpdatedWorkerStatus STARTED = new UpdatedWorkerStatus("STARTED");
        /// <summary>
        /// Constant STOPPED for UpdatedWorkerStatus
        /// </summary>
        public static readonly UpdatedWorkerStatus STOPPED = new UpdatedWorkerStatus("STOPPED");
        /// <summary>
        /// Constant STOPPING for UpdatedWorkerStatus
        /// </summary>
        public static readonly UpdatedWorkerStatus STOPPING = new UpdatedWorkerStatus("STOPPING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public UpdatedWorkerStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static UpdatedWorkerStatus FindValue(string value)
        {
            return FindValue<UpdatedWorkerStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator UpdatedWorkerStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type UpdateJobLifecycleStatus.
    /// </summary>
    public class UpdateJobLifecycleStatus : ConstantClass
    {

        /// <summary>
        /// Constant ARCHIVED for UpdateJobLifecycleStatus
        /// </summary>
        public static readonly UpdateJobLifecycleStatus ARCHIVED = new UpdateJobLifecycleStatus("ARCHIVED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public UpdateJobLifecycleStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static UpdateJobLifecycleStatus FindValue(string value)
        {
            return FindValue<UpdateJobLifecycleStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator UpdateJobLifecycleStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type UpdateQueueFleetAssociationStatus.
    /// </summary>
    public class UpdateQueueFleetAssociationStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for UpdateQueueFleetAssociationStatus
        /// </summary>
        public static readonly UpdateQueueFleetAssociationStatus ACTIVE = new UpdateQueueFleetAssociationStatus("ACTIVE");
        /// <summary>
        /// Constant STOP_SCHEDULING_AND_CANCEL_TASKS for UpdateQueueFleetAssociationStatus
        /// </summary>
        public static readonly UpdateQueueFleetAssociationStatus STOP_SCHEDULING_AND_CANCEL_TASKS = new UpdateQueueFleetAssociationStatus("STOP_SCHEDULING_AND_CANCEL_TASKS");
        /// <summary>
        /// Constant STOP_SCHEDULING_AND_COMPLETE_TASKS for UpdateQueueFleetAssociationStatus
        /// </summary>
        public static readonly UpdateQueueFleetAssociationStatus STOP_SCHEDULING_AND_COMPLETE_TASKS = new UpdateQueueFleetAssociationStatus("STOP_SCHEDULING_AND_COMPLETE_TASKS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public UpdateQueueFleetAssociationStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static UpdateQueueFleetAssociationStatus FindValue(string value)
        {
            return FindValue<UpdateQueueFleetAssociationStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator UpdateQueueFleetAssociationStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type UpdateQueueLimitAssociationStatus.
    /// </summary>
    public class UpdateQueueLimitAssociationStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for UpdateQueueLimitAssociationStatus
        /// </summary>
        public static readonly UpdateQueueLimitAssociationStatus ACTIVE = new UpdateQueueLimitAssociationStatus("ACTIVE");
        /// <summary>
        /// Constant STOP_LIMIT_USAGE_AND_CANCEL_TASKS for UpdateQueueLimitAssociationStatus
        /// </summary>
        public static readonly UpdateQueueLimitAssociationStatus STOP_LIMIT_USAGE_AND_CANCEL_TASKS = new UpdateQueueLimitAssociationStatus("STOP_LIMIT_USAGE_AND_CANCEL_TASKS");
        /// <summary>
        /// Constant STOP_LIMIT_USAGE_AND_COMPLETE_TASKS for UpdateQueueLimitAssociationStatus
        /// </summary>
        public static readonly UpdateQueueLimitAssociationStatus STOP_LIMIT_USAGE_AND_COMPLETE_TASKS = new UpdateQueueLimitAssociationStatus("STOP_LIMIT_USAGE_AND_COMPLETE_TASKS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public UpdateQueueLimitAssociationStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static UpdateQueueLimitAssociationStatus FindValue(string value)
        {
            return FindValue<UpdateQueueLimitAssociationStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator UpdateQueueLimitAssociationStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type UsageGroupByField.
    /// </summary>
    public class UsageGroupByField : ConstantClass
    {

        /// <summary>
        /// Constant FLEET_ID for UsageGroupByField
        /// </summary>
        public static readonly UsageGroupByField FLEET_ID = new UsageGroupByField("FLEET_ID");
        /// <summary>
        /// Constant INSTANCE_TYPE for UsageGroupByField
        /// </summary>
        public static readonly UsageGroupByField INSTANCE_TYPE = new UsageGroupByField("INSTANCE_TYPE");
        /// <summary>
        /// Constant JOB_ID for UsageGroupByField
        /// </summary>
        public static readonly UsageGroupByField JOB_ID = new UsageGroupByField("JOB_ID");
        /// <summary>
        /// Constant LICENSE_PRODUCT for UsageGroupByField
        /// </summary>
        public static readonly UsageGroupByField LICENSE_PRODUCT = new UsageGroupByField("LICENSE_PRODUCT");
        /// <summary>
        /// Constant QUEUE_ID for UsageGroupByField
        /// </summary>
        public static readonly UsageGroupByField QUEUE_ID = new UsageGroupByField("QUEUE_ID");
        /// <summary>
        /// Constant USAGE_TYPE for UsageGroupByField
        /// </summary>
        public static readonly UsageGroupByField USAGE_TYPE = new UsageGroupByField("USAGE_TYPE");
        /// <summary>
        /// Constant USER_ID for UsageGroupByField
        /// </summary>
        public static readonly UsageGroupByField USER_ID = new UsageGroupByField("USER_ID");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public UsageGroupByField(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static UsageGroupByField FindValue(string value)
        {
            return FindValue<UsageGroupByField>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator UsageGroupByField(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type UsageStatistic.
    /// </summary>
    public class UsageStatistic : ConstantClass
    {

        /// <summary>
        /// Constant AVG for UsageStatistic
        /// </summary>
        public static readonly UsageStatistic AVG = new UsageStatistic("AVG");
        /// <summary>
        /// Constant MAX for UsageStatistic
        /// </summary>
        public static readonly UsageStatistic MAX = new UsageStatistic("MAX");
        /// <summary>
        /// Constant MIN for UsageStatistic
        /// </summary>
        public static readonly UsageStatistic MIN = new UsageStatistic("MIN");
        /// <summary>
        /// Constant SUM for UsageStatistic
        /// </summary>
        public static readonly UsageStatistic SUM = new UsageStatistic("SUM");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public UsageStatistic(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static UsageStatistic FindValue(string value)
        {
            return FindValue<UsageStatistic>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator UsageStatistic(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type UsageType.
    /// </summary>
    public class UsageType : ConstantClass
    {

        /// <summary>
        /// Constant COMPUTE for UsageType
        /// </summary>
        public static readonly UsageType COMPUTE = new UsageType("COMPUTE");
        /// <summary>
        /// Constant LICENSE for UsageType
        /// </summary>
        public static readonly UsageType LICENSE = new UsageType("LICENSE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public UsageType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static UsageType FindValue(string value)
        {
            return FindValue<UsageType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator UsageType(string value)
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
        /// Constant CANNOT_PARSE for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason CANNOT_PARSE = new ValidationExceptionReason("CANNOT_PARSE");
        /// <summary>
        /// Constant FIELD_VALIDATION_FAILED for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason FIELD_VALIDATION_FAILED = new ValidationExceptionReason("FIELD_VALIDATION_FAILED");
        /// <summary>
        /// Constant OTHER for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason OTHER = new ValidationExceptionReason("OTHER");
        /// <summary>
        /// Constant UNKNOWN_OPERATION for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason UNKNOWN_OPERATION = new ValidationExceptionReason("UNKNOWN_OPERATION");

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


    /// <summary>
    /// Constants used for properties of type WorkerStatus.
    /// </summary>
    public class WorkerStatus : ConstantClass
    {

        /// <summary>
        /// Constant CREATED for WorkerStatus
        /// </summary>
        public static readonly WorkerStatus CREATED = new WorkerStatus("CREATED");
        /// <summary>
        /// Constant IDLE for WorkerStatus
        /// </summary>
        public static readonly WorkerStatus IDLE = new WorkerStatus("IDLE");
        /// <summary>
        /// Constant NOT_COMPATIBLE for WorkerStatus
        /// </summary>
        public static readonly WorkerStatus NOT_COMPATIBLE = new WorkerStatus("NOT_COMPATIBLE");
        /// <summary>
        /// Constant NOT_RESPONDING for WorkerStatus
        /// </summary>
        public static readonly WorkerStatus NOT_RESPONDING = new WorkerStatus("NOT_RESPONDING");
        /// <summary>
        /// Constant RUNNING for WorkerStatus
        /// </summary>
        public static readonly WorkerStatus RUNNING = new WorkerStatus("RUNNING");
        /// <summary>
        /// Constant STARTED for WorkerStatus
        /// </summary>
        public static readonly WorkerStatus STARTED = new WorkerStatus("STARTED");
        /// <summary>
        /// Constant STOPPED for WorkerStatus
        /// </summary>
        public static readonly WorkerStatus STOPPED = new WorkerStatus("STOPPED");
        /// <summary>
        /// Constant STOPPING for WorkerStatus
        /// </summary>
        public static readonly WorkerStatus STOPPING = new WorkerStatus("STOPPING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public WorkerStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static WorkerStatus FindValue(string value)
        {
            return FindValue<WorkerStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator WorkerStatus(string value)
        {
            return FindValue(value);
        }
    }

}