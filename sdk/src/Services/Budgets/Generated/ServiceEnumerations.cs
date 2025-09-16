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
    /// Constants used for properties of type AutoAdjustType.
    /// </summary>
    public class AutoAdjustType : ConstantClass
    {

        /// <summary>
        /// Constant FORECAST for AutoAdjustType
        /// </summary>
        public static readonly AutoAdjustType FORECAST = new AutoAdjustType("FORECAST");
        /// <summary>
        /// Constant HISTORICAL for AutoAdjustType
        /// </summary>
        public static readonly AutoAdjustType HISTORICAL = new AutoAdjustType("HISTORICAL");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AutoAdjustType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AutoAdjustType FindValue(string value)
        {
            return FindValue<AutoAdjustType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AutoAdjustType(string value)
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
    /// Constants used for properties of type Dimension.
    /// </summary>
    public class Dimension : ConstantClass
    {

        /// <summary>
        /// Constant AZ for Dimension
        /// </summary>
        public static readonly Dimension AZ = new Dimension("AZ");
        /// <summary>
        /// Constant BILLING_ENTITY for Dimension
        /// </summary>
        public static readonly Dimension BILLING_ENTITY = new Dimension("BILLING_ENTITY");
        /// <summary>
        /// Constant CACHE_ENGINE for Dimension
        /// </summary>
        public static readonly Dimension CACHE_ENGINE = new Dimension("CACHE_ENGINE");
        /// <summary>
        /// Constant COST_CATEGORY_NAME for Dimension
        /// </summary>
        public static readonly Dimension COST_CATEGORY_NAME = new Dimension("COST_CATEGORY_NAME");
        /// <summary>
        /// Constant DATABASE_ENGINE for Dimension
        /// </summary>
        public static readonly Dimension DATABASE_ENGINE = new Dimension("DATABASE_ENGINE");
        /// <summary>
        /// Constant DEPLOYMENT_OPTION for Dimension
        /// </summary>
        public static readonly Dimension DEPLOYMENT_OPTION = new Dimension("DEPLOYMENT_OPTION");
        /// <summary>
        /// Constant INSTANCE_TYPE for Dimension
        /// </summary>
        public static readonly Dimension INSTANCE_TYPE = new Dimension("INSTANCE_TYPE");
        /// <summary>
        /// Constant INSTANCE_TYPE_FAMILY for Dimension
        /// </summary>
        public static readonly Dimension INSTANCE_TYPE_FAMILY = new Dimension("INSTANCE_TYPE_FAMILY");
        /// <summary>
        /// Constant INVOICING_ENTITY for Dimension
        /// </summary>
        public static readonly Dimension INVOICING_ENTITY = new Dimension("INVOICING_ENTITY");
        /// <summary>
        /// Constant LEGAL_ENTITY_NAME for Dimension
        /// </summary>
        public static readonly Dimension LEGAL_ENTITY_NAME = new Dimension("LEGAL_ENTITY_NAME");
        /// <summary>
        /// Constant LINKED_ACCOUNT for Dimension
        /// </summary>
        public static readonly Dimension LINKED_ACCOUNT = new Dimension("LINKED_ACCOUNT");
        /// <summary>
        /// Constant LINKED_ACCOUNT_NAME for Dimension
        /// </summary>
        public static readonly Dimension LINKED_ACCOUNT_NAME = new Dimension("LINKED_ACCOUNT_NAME");
        /// <summary>
        /// Constant OPERATING_SYSTEM for Dimension
        /// </summary>
        public static readonly Dimension OPERATING_SYSTEM = new Dimension("OPERATING_SYSTEM");
        /// <summary>
        /// Constant OPERATION for Dimension
        /// </summary>
        public static readonly Dimension OPERATION = new Dimension("OPERATION");
        /// <summary>
        /// Constant PAYMENT_OPTION for Dimension
        /// </summary>
        public static readonly Dimension PAYMENT_OPTION = new Dimension("PAYMENT_OPTION");
        /// <summary>
        /// Constant PLATFORM for Dimension
        /// </summary>
        public static readonly Dimension PLATFORM = new Dimension("PLATFORM");
        /// <summary>
        /// Constant PURCHASE_TYPE for Dimension
        /// </summary>
        public static readonly Dimension PURCHASE_TYPE = new Dimension("PURCHASE_TYPE");
        /// <summary>
        /// Constant RECORD_TYPE for Dimension
        /// </summary>
        public static readonly Dimension RECORD_TYPE = new Dimension("RECORD_TYPE");
        /// <summary>
        /// Constant REGION for Dimension
        /// </summary>
        public static readonly Dimension REGION = new Dimension("REGION");
        /// <summary>
        /// Constant RESERVATION_ID for Dimension
        /// </summary>
        public static readonly Dimension RESERVATION_ID = new Dimension("RESERVATION_ID");
        /// <summary>
        /// Constant RESERVATION_MODIFIED for Dimension
        /// </summary>
        public static readonly Dimension RESERVATION_MODIFIED = new Dimension("RESERVATION_MODIFIED");
        /// <summary>
        /// Constant RESOURCE_ID for Dimension
        /// </summary>
        public static readonly Dimension RESOURCE_ID = new Dimension("RESOURCE_ID");
        /// <summary>
        /// Constant RIGHTSIZING_TYPE for Dimension
        /// </summary>
        public static readonly Dimension RIGHTSIZING_TYPE = new Dimension("RIGHTSIZING_TYPE");
        /// <summary>
        /// Constant SAVINGS_PLAN_ARN for Dimension
        /// </summary>
        public static readonly Dimension SAVINGS_PLAN_ARN = new Dimension("SAVINGS_PLAN_ARN");
        /// <summary>
        /// Constant SAVINGS_PLANS_TYPE for Dimension
        /// </summary>
        public static readonly Dimension SAVINGS_PLANS_TYPE = new Dimension("SAVINGS_PLANS_TYPE");
        /// <summary>
        /// Constant SCOPE for Dimension
        /// </summary>
        public static readonly Dimension SCOPE = new Dimension("SCOPE");
        /// <summary>
        /// Constant SERVICE for Dimension
        /// </summary>
        public static readonly Dimension SERVICE = new Dimension("SERVICE");
        /// <summary>
        /// Constant SERVICE_CODE for Dimension
        /// </summary>
        public static readonly Dimension SERVICE_CODE = new Dimension("SERVICE_CODE");
        /// <summary>
        /// Constant SUBSCRIPTION_ID for Dimension
        /// </summary>
        public static readonly Dimension SUBSCRIPTION_ID = new Dimension("SUBSCRIPTION_ID");
        /// <summary>
        /// Constant TAG_KEY for Dimension
        /// </summary>
        public static readonly Dimension TAG_KEY = new Dimension("TAG_KEY");
        /// <summary>
        /// Constant TENANCY for Dimension
        /// </summary>
        public static readonly Dimension TENANCY = new Dimension("TENANCY");
        /// <summary>
        /// Constant USAGE_TYPE for Dimension
        /// </summary>
        public static readonly Dimension USAGE_TYPE = new Dimension("USAGE_TYPE");
        /// <summary>
        /// Constant USAGE_TYPE_GROUP for Dimension
        /// </summary>
        public static readonly Dimension USAGE_TYPE_GROUP = new Dimension("USAGE_TYPE_GROUP");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Dimension(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Dimension FindValue(string value)
        {
            return FindValue<Dimension>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Dimension(string value)
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
    /// Constants used for properties of type HealthStatusReason.
    /// </summary>
    public class HealthStatusReason : ConstantClass
    {

        /// <summary>
        /// Constant BILLING_VIEW_NO_ACCESS for HealthStatusReason
        /// </summary>
        public static readonly HealthStatusReason BILLING_VIEW_NO_ACCESS = new HealthStatusReason("BILLING_VIEW_NO_ACCESS");
        /// <summary>
        /// Constant BILLING_VIEW_UNHEALTHY for HealthStatusReason
        /// </summary>
        public static readonly HealthStatusReason BILLING_VIEW_UNHEALTHY = new HealthStatusReason("BILLING_VIEW_UNHEALTHY");
        /// <summary>
        /// Constant FILTER_INVALID for HealthStatusReason
        /// </summary>
        public static readonly HealthStatusReason FILTER_INVALID = new HealthStatusReason("FILTER_INVALID");
        /// <summary>
        /// Constant MULTI_YEAR_HISTORICAL_DATA_DISABLED for HealthStatusReason
        /// </summary>
        public static readonly HealthStatusReason MULTI_YEAR_HISTORICAL_DATA_DISABLED = new HealthStatusReason("MULTI_YEAR_HISTORICAL_DATA_DISABLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public HealthStatusReason(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static HealthStatusReason FindValue(string value)
        {
            return FindValue<HealthStatusReason>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator HealthStatusReason(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type HealthStatusValue.
    /// </summary>
    public class HealthStatusValue : ConstantClass
    {

        /// <summary>
        /// Constant HEALTHY for HealthStatusValue
        /// </summary>
        public static readonly HealthStatusValue HEALTHY = new HealthStatusValue("HEALTHY");
        /// <summary>
        /// Constant UNHEALTHY for HealthStatusValue
        /// </summary>
        public static readonly HealthStatusValue UNHEALTHY = new HealthStatusValue("UNHEALTHY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public HealthStatusValue(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static HealthStatusValue FindValue(string value)
        {
            return FindValue<HealthStatusValue>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator HealthStatusValue(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type MatchOption.
    /// </summary>
    public class MatchOption : ConstantClass
    {

        /// <summary>
        /// Constant ABSENT for MatchOption
        /// </summary>
        public static readonly MatchOption ABSENT = new MatchOption("ABSENT");
        /// <summary>
        /// Constant CASE_INSENSITIVE for MatchOption
        /// </summary>
        public static readonly MatchOption CASE_INSENSITIVE = new MatchOption("CASE_INSENSITIVE");
        /// <summary>
        /// Constant CASE_SENSITIVE for MatchOption
        /// </summary>
        public static readonly MatchOption CASE_SENSITIVE = new MatchOption("CASE_SENSITIVE");
        /// <summary>
        /// Constant CONTAINS for MatchOption
        /// </summary>
        public static readonly MatchOption CONTAINS = new MatchOption("CONTAINS");
        /// <summary>
        /// Constant ENDS_WITH for MatchOption
        /// </summary>
        public static readonly MatchOption ENDS_WITH = new MatchOption("ENDS_WITH");
        /// <summary>
        /// Constant EQUALS for MatchOption
        /// </summary>
        public static readonly MatchOption EQUALS = new MatchOption("EQUALS");
        /// <summary>
        /// Constant GREATER_THAN_OR_EQUAL for MatchOption
        /// </summary>
        public static readonly MatchOption GREATER_THAN_OR_EQUAL = new MatchOption("GREATER_THAN_OR_EQUAL");
        /// <summary>
        /// Constant STARTS_WITH for MatchOption
        /// </summary>
        public static readonly MatchOption STARTS_WITH = new MatchOption("STARTS_WITH");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MatchOption(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MatchOption FindValue(string value)
        {
            return FindValue<MatchOption>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MatchOption(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Metric.
    /// </summary>
    public class Metric : ConstantClass
    {

        /// <summary>
        /// Constant AmortizedCost for Metric
        /// </summary>
        public static readonly Metric AmortizedCost = new Metric("AmortizedCost");
        /// <summary>
        /// Constant BlendedCost for Metric
        /// </summary>
        public static readonly Metric BlendedCost = new Metric("BlendedCost");
        /// <summary>
        /// Constant Hours for Metric
        /// </summary>
        public static readonly Metric Hours = new Metric("Hours");
        /// <summary>
        /// Constant NetAmortizedCost for Metric
        /// </summary>
        public static readonly Metric NetAmortizedCost = new Metric("NetAmortizedCost");
        /// <summary>
        /// Constant NetUnblendedCost for Metric
        /// </summary>
        public static readonly Metric NetUnblendedCost = new Metric("NetUnblendedCost");
        /// <summary>
        /// Constant NormalizedUsageAmount for Metric
        /// </summary>
        public static readonly Metric NormalizedUsageAmount = new Metric("NormalizedUsageAmount");
        /// <summary>
        /// Constant UnblendedCost for Metric
        /// </summary>
        public static readonly Metric UnblendedCost = new Metric("UnblendedCost");
        /// <summary>
        /// Constant UsageQuantity for Metric
        /// </summary>
        public static readonly Metric UsageQuantity = new Metric("UsageQuantity");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Metric(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Metric FindValue(string value)
        {
            return FindValue<Metric>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Metric(string value)
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
        /// Constant CUSTOM for TimeUnit
        /// </summary>
        public static readonly TimeUnit CUSTOM = new TimeUnit("CUSTOM");
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