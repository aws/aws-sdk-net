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
 * Do not modify this file. This file is generated from the budgets-2016-10-20.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.Budgets
{

    /// <summary>
    /// Constants used for properties of type ActionStatus.
    /// </summary>
    public class ActionStatus : ConstantClass
    {

        /// <summary>
        /// Constant EXECUTION_FAILURE for ActionStatus
        /// </summary>
        public static readonly ActionStatus EXECUTION_FAILURE = new ActionStatus("EXECUTION_FAILURE");
        /// <summary>
        /// Constant EXECUTION_IN_PROGRESS for ActionStatus
        /// </summary>
        public static readonly ActionStatus EXECUTION_IN_PROGRESS = new ActionStatus("EXECUTION_IN_PROGRESS");
        /// <summary>
        /// Constant EXECUTION_SUCCESS for ActionStatus
        /// </summary>
        public static readonly ActionStatus EXECUTION_SUCCESS = new ActionStatus("EXECUTION_SUCCESS");
        /// <summary>
        /// Constant PENDING for ActionStatus
        /// </summary>
        public static readonly ActionStatus PENDING = new ActionStatus("PENDING");
        /// <summary>
        /// Constant RESET_FAILURE for ActionStatus
        /// </summary>
        public static readonly ActionStatus RESET_FAILURE = new ActionStatus("RESET_FAILURE");
        /// <summary>
        /// Constant RESET_IN_PROGRESS for ActionStatus
        /// </summary>
        public static readonly ActionStatus RESET_IN_PROGRESS = new ActionStatus("RESET_IN_PROGRESS");
        /// <summary>
        /// Constant REVERSE_FAILURE for ActionStatus
        /// </summary>
        public static readonly ActionStatus REVERSE_FAILURE = new ActionStatus("REVERSE_FAILURE");
        /// <summary>
        /// Constant REVERSE_IN_PROGRESS for ActionStatus
        /// </summary>
        public static readonly ActionStatus REVERSE_IN_PROGRESS = new ActionStatus("REVERSE_IN_PROGRESS");
        /// <summary>
        /// Constant REVERSE_SUCCESS for ActionStatus
        /// </summary>
        public static readonly ActionStatus REVERSE_SUCCESS = new ActionStatus("REVERSE_SUCCESS");
        /// <summary>
        /// Constant STANDBY for ActionStatus
        /// </summary>
        public static readonly ActionStatus STANDBY = new ActionStatus("STANDBY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ActionStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ActionStatus FindValue(string value)
        {
            return FindValue<ActionStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ActionStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ActionSubType.
    /// </summary>
    public class ActionSubType : ConstantClass
    {

        /// <summary>
        /// Constant STOP_EC2_INSTANCES for ActionSubType
        /// </summary>
        public static readonly ActionSubType STOP_EC2_INSTANCES = new ActionSubType("STOP_EC2_INSTANCES");
        /// <summary>
        /// Constant STOP_RDS_INSTANCES for ActionSubType
        /// </summary>
        public static readonly ActionSubType STOP_RDS_INSTANCES = new ActionSubType("STOP_RDS_INSTANCES");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ActionSubType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ActionSubType FindValue(string value)
        {
            return FindValue<ActionSubType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ActionSubType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ActionType.
    /// </summary>
    public class ActionType : ConstantClass
    {

        /// <summary>
        /// Constant APPLY_IAM_POLICY for ActionType
        /// </summary>
        public static readonly ActionType APPLY_IAM_POLICY = new ActionType("APPLY_IAM_POLICY");
        /// <summary>
        /// Constant APPLY_SCP_POLICY for ActionType
        /// </summary>
        public static readonly ActionType APPLY_SCP_POLICY = new ActionType("APPLY_SCP_POLICY");
        /// <summary>
        /// Constant RUN_SSM_DOCUMENTS for ActionType
        /// </summary>
        public static readonly ActionType RUN_SSM_DOCUMENTS = new ActionType("RUN_SSM_DOCUMENTS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ActionType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ActionType FindValue(string value)
        {
            return FindValue<ActionType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ActionType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ApprovalModel.
    /// </summary>
    public class ApprovalModel : ConstantClass
    {

        /// <summary>
        /// Constant AUTOMATIC for ApprovalModel
        /// </summary>
        public static readonly ApprovalModel AUTOMATIC = new ApprovalModel("AUTOMATIC");
        /// <summary>
        /// Constant MANUAL for ApprovalModel
        /// </summary>
        public static readonly ApprovalModel MANUAL = new ApprovalModel("MANUAL");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ApprovalModel(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ApprovalModel FindValue(string value)
        {
            return FindValue<ApprovalModel>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ApprovalModel(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type BudgetType.
    /// </summary>
    public class BudgetType : ConstantClass
    {

        /// <summary>
        /// Constant COST for BudgetType
        /// </summary>
        public static readonly BudgetType COST = new BudgetType("COST");
        /// <summary>
        /// Constant RI_COVERAGE for BudgetType
        /// </summary>
        public static readonly BudgetType RI_COVERAGE = new BudgetType("RI_COVERAGE");
        /// <summary>
        /// Constant RI_UTILIZATION for BudgetType
        /// </summary>
        public static readonly BudgetType RI_UTILIZATION = new BudgetType("RI_UTILIZATION");
        /// <summary>
        /// Constant SAVINGS_PLANS_COVERAGE for BudgetType
        /// </summary>
        public static readonly BudgetType SAVINGS_PLANS_COVERAGE = new BudgetType("SAVINGS_PLANS_COVERAGE");
        /// <summary>
        /// Constant SAVINGS_PLANS_UTILIZATION for BudgetType
        /// </summary>
        public static readonly BudgetType SAVINGS_PLANS_UTILIZATION = new BudgetType("SAVINGS_PLANS_UTILIZATION");
        /// <summary>
        /// Constant USAGE for BudgetType
        /// </summary>
        public static readonly BudgetType USAGE = new BudgetType("USAGE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public BudgetType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static BudgetType FindValue(string value)
        {
            return FindValue<BudgetType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator BudgetType(string value)
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
        /// Constant EQUAL_TO for ComparisonOperator
        /// </summary>
        public static readonly ComparisonOperator EQUAL_TO = new ComparisonOperator("EQUAL_TO");
        /// <summary>
        /// Constant GREATER_THAN for ComparisonOperator
        /// </summary>
        public static readonly ComparisonOperator GREATER_THAN = new ComparisonOperator("GREATER_THAN");
        /// <summary>
        /// Constant LESS_THAN for ComparisonOperator
        /// </summary>
        public static readonly ComparisonOperator LESS_THAN = new ComparisonOperator("LESS_THAN");

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
    /// Constants used for properties of type EventType.
    /// </summary>
    public class EventType : ConstantClass
    {

        /// <summary>
        /// Constant CREATE_ACTION for EventType
        /// </summary>
        public static readonly EventType CREATE_ACTION = new EventType("CREATE_ACTION");
        /// <summary>
        /// Constant DELETE_ACTION for EventType
        /// </summary>
        public static readonly EventType DELETE_ACTION = new EventType("DELETE_ACTION");
        /// <summary>
        /// Constant EXECUTE_ACTION for EventType
        /// </summary>
        public static readonly EventType EXECUTE_ACTION = new EventType("EXECUTE_ACTION");
        /// <summary>
        /// Constant SYSTEM for EventType
        /// </summary>
        public static readonly EventType SYSTEM = new EventType("SYSTEM");
        /// <summary>
        /// Constant UPDATE_ACTION for EventType
        /// </summary>
        public static readonly EventType UPDATE_ACTION = new EventType("UPDATE_ACTION");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EventType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EventType FindValue(string value)
        {
            return FindValue<EventType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EventType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ExecutionType.
    /// </summary>
    public class ExecutionType : ConstantClass
    {

        /// <summary>
        /// Constant APPROVE_BUDGET_ACTION for ExecutionType
        /// </summary>
        public static readonly ExecutionType APPROVE_BUDGET_ACTION = new ExecutionType("APPROVE_BUDGET_ACTION");
        /// <summary>
        /// Constant RESET_BUDGET_ACTION for ExecutionType
        /// </summary>
        public static readonly ExecutionType RESET_BUDGET_ACTION = new ExecutionType("RESET_BUDGET_ACTION");
        /// <summary>
        /// Constant RETRY_BUDGET_ACTION for ExecutionType
        /// </summary>
        public static readonly ExecutionType RETRY_BUDGET_ACTION = new ExecutionType("RETRY_BUDGET_ACTION");
        /// <summary>
        /// Constant REVERSE_BUDGET_ACTION for ExecutionType
        /// </summary>
        public static readonly ExecutionType REVERSE_BUDGET_ACTION = new ExecutionType("REVERSE_BUDGET_ACTION");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ExecutionType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ExecutionType FindValue(string value)
        {
            return FindValue<ExecutionType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ExecutionType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type NotificationState.
    /// </summary>
    public class NotificationState : ConstantClass
    {

        /// <summary>
        /// Constant ALARM for NotificationState
        /// </summary>
        public static readonly NotificationState ALARM = new NotificationState("ALARM");
        /// <summary>
        /// Constant OK for NotificationState
        /// </summary>
        public static readonly NotificationState OK = new NotificationState("OK");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public NotificationState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static NotificationState FindValue(string value)
        {
            return FindValue<NotificationState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator NotificationState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type NotificationType.
    /// </summary>
    public class NotificationType : ConstantClass
    {

        /// <summary>
        /// Constant ACTUAL for NotificationType
        /// </summary>
        public static readonly NotificationType ACTUAL = new NotificationType("ACTUAL");
        /// <summary>
        /// Constant FORECASTED for NotificationType
        /// </summary>
        public static readonly NotificationType FORECASTED = new NotificationType("FORECASTED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public NotificationType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static NotificationType FindValue(string value)
        {
            return FindValue<NotificationType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator NotificationType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SubscriptionType.
    /// </summary>
    public class SubscriptionType : ConstantClass
    {

        /// <summary>
        /// Constant EMAIL for SubscriptionType
        /// </summary>
        public static readonly SubscriptionType EMAIL = new SubscriptionType("EMAIL");
        /// <summary>
        /// Constant SNS for SubscriptionType
        /// </summary>
        public static readonly SubscriptionType SNS = new SubscriptionType("SNS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SubscriptionType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SubscriptionType FindValue(string value)
        {
            return FindValue<SubscriptionType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SubscriptionType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ThresholdType.
    /// </summary>
    public class ThresholdType : ConstantClass
    {

        /// <summary>
        /// Constant ABSOLUTE_VALUE for ThresholdType
        /// </summary>
        public static readonly ThresholdType ABSOLUTE_VALUE = new ThresholdType("ABSOLUTE_VALUE");
        /// <summary>
        /// Constant PERCENTAGE for ThresholdType
        /// </summary>
        public static readonly ThresholdType PERCENTAGE = new ThresholdType("PERCENTAGE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ThresholdType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ThresholdType FindValue(string value)
        {
            return FindValue<ThresholdType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ThresholdType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TimeUnit.
    /// </summary>
    public class TimeUnit : ConstantClass
    {

        /// <summary>
        /// Constant ANNUALLY for TimeUnit
        /// </summary>
        public static readonly TimeUnit ANNUALLY = new TimeUnit("ANNUALLY");
        /// <summary>
        /// Constant DAILY for TimeUnit
        /// </summary>
        public static readonly TimeUnit DAILY = new TimeUnit("DAILY");
        /// <summary>
        /// Constant MONTHLY for TimeUnit
        /// </summary>
        public static readonly TimeUnit MONTHLY = new TimeUnit("MONTHLY");
        /// <summary>
        /// Constant QUARTERLY for TimeUnit
        /// </summary>
        public static readonly TimeUnit QUARTERLY = new TimeUnit("QUARTERLY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TimeUnit(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TimeUnit FindValue(string value)
        {
            return FindValue<TimeUnit>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TimeUnit(string value)
        {
            return FindValue(value);
        }
    }

}