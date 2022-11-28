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
 * Do not modify this file. This file is generated from the iot-2015-05-28.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.IoT
{

    /// <summary>
    /// Constants used for properties of type AbortAction.
    /// </summary>
    public class AbortAction : ConstantClass
    {

        /// <summary>
        /// Constant CANCEL for AbortAction
        /// </summary>
        public static readonly AbortAction CANCEL = new AbortAction("CANCEL");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AbortAction(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AbortAction FindValue(string value)
        {
            return FindValue<AbortAction>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AbortAction(string value)
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
        /// Constant CONNECT for ActionType
        /// </summary>
        public static readonly ActionType CONNECT = new ActionType("CONNECT");
        /// <summary>
        /// Constant PUBLISH for ActionType
        /// </summary>
        public static readonly ActionType PUBLISH = new ActionType("PUBLISH");
        /// <summary>
        /// Constant RECEIVE for ActionType
        /// </summary>
        public static readonly ActionType RECEIVE = new ActionType("RECEIVE");
        /// <summary>
        /// Constant SUBSCRIBE for ActionType
        /// </summary>
        public static readonly ActionType SUBSCRIBE = new ActionType("SUBSCRIBE");

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
    /// Constants used for properties of type AggregationTypeName.
    /// </summary>
    public class AggregationTypeName : ConstantClass
    {

        /// <summary>
        /// Constant Cardinality for AggregationTypeName
        /// </summary>
        public static readonly AggregationTypeName Cardinality = new AggregationTypeName("Cardinality");
        /// <summary>
        /// Constant Percentiles for AggregationTypeName
        /// </summary>
        public static readonly AggregationTypeName Percentiles = new AggregationTypeName("Percentiles");
        /// <summary>
        /// Constant Statistics for AggregationTypeName
        /// </summary>
        public static readonly AggregationTypeName Statistics = new AggregationTypeName("Statistics");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AggregationTypeName(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AggregationTypeName FindValue(string value)
        {
            return FindValue<AggregationTypeName>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AggregationTypeName(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AlertTargetType.
    /// </summary>
    public class AlertTargetType : ConstantClass
    {

        /// <summary>
        /// Constant SNS for AlertTargetType
        /// </summary>
        public static readonly AlertTargetType SNS = new AlertTargetType("SNS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AlertTargetType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AlertTargetType FindValue(string value)
        {
            return FindValue<AlertTargetType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AlertTargetType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AuditCheckRunStatus.
    /// </summary>
    public class AuditCheckRunStatus : ConstantClass
    {

        /// <summary>
        /// Constant CANCELED for AuditCheckRunStatus
        /// </summary>
        public static readonly AuditCheckRunStatus CANCELED = new AuditCheckRunStatus("CANCELED");
        /// <summary>
        /// Constant COMPLETED_COMPLIANT for AuditCheckRunStatus
        /// </summary>
        public static readonly AuditCheckRunStatus COMPLETED_COMPLIANT = new AuditCheckRunStatus("COMPLETED_COMPLIANT");
        /// <summary>
        /// Constant COMPLETED_NON_COMPLIANT for AuditCheckRunStatus
        /// </summary>
        public static readonly AuditCheckRunStatus COMPLETED_NON_COMPLIANT = new AuditCheckRunStatus("COMPLETED_NON_COMPLIANT");
        /// <summary>
        /// Constant FAILED for AuditCheckRunStatus
        /// </summary>
        public static readonly AuditCheckRunStatus FAILED = new AuditCheckRunStatus("FAILED");
        /// <summary>
        /// Constant IN_PROGRESS for AuditCheckRunStatus
        /// </summary>
        public static readonly AuditCheckRunStatus IN_PROGRESS = new AuditCheckRunStatus("IN_PROGRESS");
        /// <summary>
        /// Constant WAITING_FOR_DATA_COLLECTION for AuditCheckRunStatus
        /// </summary>
        public static readonly AuditCheckRunStatus WAITING_FOR_DATA_COLLECTION = new AuditCheckRunStatus("WAITING_FOR_DATA_COLLECTION");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AuditCheckRunStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AuditCheckRunStatus FindValue(string value)
        {
            return FindValue<AuditCheckRunStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AuditCheckRunStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AuditFindingSeverity.
    /// </summary>
    public class AuditFindingSeverity : ConstantClass
    {

        /// <summary>
        /// Constant CRITICAL for AuditFindingSeverity
        /// </summary>
        public static readonly AuditFindingSeverity CRITICAL = new AuditFindingSeverity("CRITICAL");
        /// <summary>
        /// Constant HIGH for AuditFindingSeverity
        /// </summary>
        public static readonly AuditFindingSeverity HIGH = new AuditFindingSeverity("HIGH");
        /// <summary>
        /// Constant LOW for AuditFindingSeverity
        /// </summary>
        public static readonly AuditFindingSeverity LOW = new AuditFindingSeverity("LOW");
        /// <summary>
        /// Constant MEDIUM for AuditFindingSeverity
        /// </summary>
        public static readonly AuditFindingSeverity MEDIUM = new AuditFindingSeverity("MEDIUM");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AuditFindingSeverity(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AuditFindingSeverity FindValue(string value)
        {
            return FindValue<AuditFindingSeverity>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AuditFindingSeverity(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AuditFrequency.
    /// </summary>
    public class AuditFrequency : ConstantClass
    {

        /// <summary>
        /// Constant BIWEEKLY for AuditFrequency
        /// </summary>
        public static readonly AuditFrequency BIWEEKLY = new AuditFrequency("BIWEEKLY");
        /// <summary>
        /// Constant DAILY for AuditFrequency
        /// </summary>
        public static readonly AuditFrequency DAILY = new AuditFrequency("DAILY");
        /// <summary>
        /// Constant MONTHLY for AuditFrequency
        /// </summary>
        public static readonly AuditFrequency MONTHLY = new AuditFrequency("MONTHLY");
        /// <summary>
        /// Constant WEEKLY for AuditFrequency
        /// </summary>
        public static readonly AuditFrequency WEEKLY = new AuditFrequency("WEEKLY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AuditFrequency(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AuditFrequency FindValue(string value)
        {
            return FindValue<AuditFrequency>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AuditFrequency(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AuditMitigationActionsExecutionStatus.
    /// </summary>
    public class AuditMitigationActionsExecutionStatus : ConstantClass
    {

        /// <summary>
        /// Constant CANCELED for AuditMitigationActionsExecutionStatus
        /// </summary>
        public static readonly AuditMitigationActionsExecutionStatus CANCELED = new AuditMitigationActionsExecutionStatus("CANCELED");
        /// <summary>
        /// Constant COMPLETED for AuditMitigationActionsExecutionStatus
        /// </summary>
        public static readonly AuditMitigationActionsExecutionStatus COMPLETED = new AuditMitigationActionsExecutionStatus("COMPLETED");
        /// <summary>
        /// Constant FAILED for AuditMitigationActionsExecutionStatus
        /// </summary>
        public static readonly AuditMitigationActionsExecutionStatus FAILED = new AuditMitigationActionsExecutionStatus("FAILED");
        /// <summary>
        /// Constant IN_PROGRESS for AuditMitigationActionsExecutionStatus
        /// </summary>
        public static readonly AuditMitigationActionsExecutionStatus IN_PROGRESS = new AuditMitigationActionsExecutionStatus("IN_PROGRESS");
        /// <summary>
        /// Constant PENDING for AuditMitigationActionsExecutionStatus
        /// </summary>
        public static readonly AuditMitigationActionsExecutionStatus PENDING = new AuditMitigationActionsExecutionStatus("PENDING");
        /// <summary>
        /// Constant SKIPPED for AuditMitigationActionsExecutionStatus
        /// </summary>
        public static readonly AuditMitigationActionsExecutionStatus SKIPPED = new AuditMitigationActionsExecutionStatus("SKIPPED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AuditMitigationActionsExecutionStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AuditMitigationActionsExecutionStatus FindValue(string value)
        {
            return FindValue<AuditMitigationActionsExecutionStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AuditMitigationActionsExecutionStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AuditMitigationActionsTaskStatus.
    /// </summary>
    public class AuditMitigationActionsTaskStatus : ConstantClass
    {

        /// <summary>
        /// Constant CANCELED for AuditMitigationActionsTaskStatus
        /// </summary>
        public static readonly AuditMitigationActionsTaskStatus CANCELED = new AuditMitigationActionsTaskStatus("CANCELED");
        /// <summary>
        /// Constant COMPLETED for AuditMitigationActionsTaskStatus
        /// </summary>
        public static readonly AuditMitigationActionsTaskStatus COMPLETED = new AuditMitigationActionsTaskStatus("COMPLETED");
        /// <summary>
        /// Constant FAILED for AuditMitigationActionsTaskStatus
        /// </summary>
        public static readonly AuditMitigationActionsTaskStatus FAILED = new AuditMitigationActionsTaskStatus("FAILED");
        /// <summary>
        /// Constant IN_PROGRESS for AuditMitigationActionsTaskStatus
        /// </summary>
        public static readonly AuditMitigationActionsTaskStatus IN_PROGRESS = new AuditMitigationActionsTaskStatus("IN_PROGRESS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AuditMitigationActionsTaskStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AuditMitigationActionsTaskStatus FindValue(string value)
        {
            return FindValue<AuditMitigationActionsTaskStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AuditMitigationActionsTaskStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AuditNotificationType.
    /// </summary>
    public class AuditNotificationType : ConstantClass
    {

        /// <summary>
        /// Constant SNS for AuditNotificationType
        /// </summary>
        public static readonly AuditNotificationType SNS = new AuditNotificationType("SNS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AuditNotificationType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AuditNotificationType FindValue(string value)
        {
            return FindValue<AuditNotificationType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AuditNotificationType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AuditTaskStatus.
    /// </summary>
    public class AuditTaskStatus : ConstantClass
    {

        /// <summary>
        /// Constant CANCELED for AuditTaskStatus
        /// </summary>
        public static readonly AuditTaskStatus CANCELED = new AuditTaskStatus("CANCELED");
        /// <summary>
        /// Constant COMPLETED for AuditTaskStatus
        /// </summary>
        public static readonly AuditTaskStatus COMPLETED = new AuditTaskStatus("COMPLETED");
        /// <summary>
        /// Constant FAILED for AuditTaskStatus
        /// </summary>
        public static readonly AuditTaskStatus FAILED = new AuditTaskStatus("FAILED");
        /// <summary>
        /// Constant IN_PROGRESS for AuditTaskStatus
        /// </summary>
        public static readonly AuditTaskStatus IN_PROGRESS = new AuditTaskStatus("IN_PROGRESS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AuditTaskStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AuditTaskStatus FindValue(string value)
        {
            return FindValue<AuditTaskStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AuditTaskStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AuditTaskType.
    /// </summary>
    public class AuditTaskType : ConstantClass
    {

        /// <summary>
        /// Constant ON_DEMAND_AUDIT_TASK for AuditTaskType
        /// </summary>
        public static readonly AuditTaskType ON_DEMAND_AUDIT_TASK = new AuditTaskType("ON_DEMAND_AUDIT_TASK");
        /// <summary>
        /// Constant SCHEDULED_AUDIT_TASK for AuditTaskType
        /// </summary>
        public static readonly AuditTaskType SCHEDULED_AUDIT_TASK = new AuditTaskType("SCHEDULED_AUDIT_TASK");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AuditTaskType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AuditTaskType FindValue(string value)
        {
            return FindValue<AuditTaskType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AuditTaskType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AuthDecision.
    /// </summary>
    public class AuthDecision : ConstantClass
    {

        /// <summary>
        /// Constant ALLOWED for AuthDecision
        /// </summary>
        public static readonly AuthDecision ALLOWED = new AuthDecision("ALLOWED");
        /// <summary>
        /// Constant EXPLICIT_DENY for AuthDecision
        /// </summary>
        public static readonly AuthDecision EXPLICIT_DENY = new AuthDecision("EXPLICIT_DENY");
        /// <summary>
        /// Constant IMPLICIT_DENY for AuthDecision
        /// </summary>
        public static readonly AuthDecision IMPLICIT_DENY = new AuthDecision("IMPLICIT_DENY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AuthDecision(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AuthDecision FindValue(string value)
        {
            return FindValue<AuthDecision>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AuthDecision(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AuthorizerStatus.
    /// </summary>
    public class AuthorizerStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for AuthorizerStatus
        /// </summary>
        public static readonly AuthorizerStatus ACTIVE = new AuthorizerStatus("ACTIVE");
        /// <summary>
        /// Constant INACTIVE for AuthorizerStatus
        /// </summary>
        public static readonly AuthorizerStatus INACTIVE = new AuthorizerStatus("INACTIVE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AuthorizerStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AuthorizerStatus FindValue(string value)
        {
            return FindValue<AuthorizerStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AuthorizerStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AutoRegistrationStatus.
    /// </summary>
    public class AutoRegistrationStatus : ConstantClass
    {

        /// <summary>
        /// Constant DISABLE for AutoRegistrationStatus
        /// </summary>
        public static readonly AutoRegistrationStatus DISABLE = new AutoRegistrationStatus("DISABLE");
        /// <summary>
        /// Constant ENABLE for AutoRegistrationStatus
        /// </summary>
        public static readonly AutoRegistrationStatus ENABLE = new AutoRegistrationStatus("ENABLE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AutoRegistrationStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AutoRegistrationStatus FindValue(string value)
        {
            return FindValue<AutoRegistrationStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AutoRegistrationStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AwsJobAbortCriteriaAbortAction.
    /// </summary>
    public class AwsJobAbortCriteriaAbortAction : ConstantClass
    {

        /// <summary>
        /// Constant CANCEL for AwsJobAbortCriteriaAbortAction
        /// </summary>
        public static readonly AwsJobAbortCriteriaAbortAction CANCEL = new AwsJobAbortCriteriaAbortAction("CANCEL");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AwsJobAbortCriteriaAbortAction(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AwsJobAbortCriteriaAbortAction FindValue(string value)
        {
            return FindValue<AwsJobAbortCriteriaAbortAction>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AwsJobAbortCriteriaAbortAction(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AwsJobAbortCriteriaFailureType.
    /// </summary>
    public class AwsJobAbortCriteriaFailureType : ConstantClass
    {

        /// <summary>
        /// Constant ALL for AwsJobAbortCriteriaFailureType
        /// </summary>
        public static readonly AwsJobAbortCriteriaFailureType ALL = new AwsJobAbortCriteriaFailureType("ALL");
        /// <summary>
        /// Constant FAILED for AwsJobAbortCriteriaFailureType
        /// </summary>
        public static readonly AwsJobAbortCriteriaFailureType FAILED = new AwsJobAbortCriteriaFailureType("FAILED");
        /// <summary>
        /// Constant REJECTED for AwsJobAbortCriteriaFailureType
        /// </summary>
        public static readonly AwsJobAbortCriteriaFailureType REJECTED = new AwsJobAbortCriteriaFailureType("REJECTED");
        /// <summary>
        /// Constant TIMED_OUT for AwsJobAbortCriteriaFailureType
        /// </summary>
        public static readonly AwsJobAbortCriteriaFailureType TIMED_OUT = new AwsJobAbortCriteriaFailureType("TIMED_OUT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AwsJobAbortCriteriaFailureType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AwsJobAbortCriteriaFailureType FindValue(string value)
        {
            return FindValue<AwsJobAbortCriteriaFailureType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AwsJobAbortCriteriaFailureType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type BehaviorCriteriaType.
    /// </summary>
    public class BehaviorCriteriaType : ConstantClass
    {

        /// <summary>
        /// Constant MACHINE_LEARNING for BehaviorCriteriaType
        /// </summary>
        public static readonly BehaviorCriteriaType MACHINE_LEARNING = new BehaviorCriteriaType("MACHINE_LEARNING");
        /// <summary>
        /// Constant STATIC for BehaviorCriteriaType
        /// </summary>
        public static readonly BehaviorCriteriaType STATIC = new BehaviorCriteriaType("STATIC");
        /// <summary>
        /// Constant STATISTICAL for BehaviorCriteriaType
        /// </summary>
        public static readonly BehaviorCriteriaType STATISTICAL = new BehaviorCriteriaType("STATISTICAL");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public BehaviorCriteriaType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static BehaviorCriteriaType FindValue(string value)
        {
            return FindValue<BehaviorCriteriaType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator BehaviorCriteriaType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CACertificateStatus.
    /// </summary>
    public class CACertificateStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for CACertificateStatus
        /// </summary>
        public static readonly CACertificateStatus ACTIVE = new CACertificateStatus("ACTIVE");
        /// <summary>
        /// Constant INACTIVE for CACertificateStatus
        /// </summary>
        public static readonly CACertificateStatus INACTIVE = new CACertificateStatus("INACTIVE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CACertificateStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CACertificateStatus FindValue(string value)
        {
            return FindValue<CACertificateStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CACertificateStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CACertificateUpdateAction.
    /// </summary>
    public class CACertificateUpdateAction : ConstantClass
    {

        /// <summary>
        /// Constant DEACTIVATE for CACertificateUpdateAction
        /// </summary>
        public static readonly CACertificateUpdateAction DEACTIVATE = new CACertificateUpdateAction("DEACTIVATE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CACertificateUpdateAction(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CACertificateUpdateAction FindValue(string value)
        {
            return FindValue<CACertificateUpdateAction>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CACertificateUpdateAction(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CannedAccessControlList.
    /// </summary>
    public class CannedAccessControlList : ConstantClass
    {

        /// <summary>
        /// Constant AuthenticatedRead for CannedAccessControlList
        /// </summary>
        public static readonly CannedAccessControlList AuthenticatedRead = new CannedAccessControlList("authenticated-read");
        /// <summary>
        /// Constant AwsExecRead for CannedAccessControlList
        /// </summary>
        public static readonly CannedAccessControlList AwsExecRead = new CannedAccessControlList("aws-exec-read");
        /// <summary>
        /// Constant BucketOwnerFullControl for CannedAccessControlList
        /// </summary>
        public static readonly CannedAccessControlList BucketOwnerFullControl = new CannedAccessControlList("bucket-owner-full-control");
        /// <summary>
        /// Constant BucketOwnerRead for CannedAccessControlList
        /// </summary>
        public static readonly CannedAccessControlList BucketOwnerRead = new CannedAccessControlList("bucket-owner-read");
        /// <summary>
        /// Constant LogDeliveryWrite for CannedAccessControlList
        /// </summary>
        public static readonly CannedAccessControlList LogDeliveryWrite = new CannedAccessControlList("log-delivery-write");
        /// <summary>
        /// Constant Private for CannedAccessControlList
        /// </summary>
        public static readonly CannedAccessControlList Private = new CannedAccessControlList("private");
        /// <summary>
        /// Constant PublicRead for CannedAccessControlList
        /// </summary>
        public static readonly CannedAccessControlList PublicRead = new CannedAccessControlList("public-read");
        /// <summary>
        /// Constant PublicReadWrite for CannedAccessControlList
        /// </summary>
        public static readonly CannedAccessControlList PublicReadWrite = new CannedAccessControlList("public-read-write");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CannedAccessControlList(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CannedAccessControlList FindValue(string value)
        {
            return FindValue<CannedAccessControlList>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CannedAccessControlList(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CertificateMode.
    /// </summary>
    public class CertificateMode : ConstantClass
    {

        /// <summary>
        /// Constant DEFAULT for CertificateMode
        /// </summary>
        public static readonly CertificateMode DEFAULT = new CertificateMode("DEFAULT");
        /// <summary>
        /// Constant SNI_ONLY for CertificateMode
        /// </summary>
        public static readonly CertificateMode SNI_ONLY = new CertificateMode("SNI_ONLY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CertificateMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CertificateMode FindValue(string value)
        {
            return FindValue<CertificateMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CertificateMode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CertificateStatus.
    /// </summary>
    public class CertificateStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for CertificateStatus
        /// </summary>
        public static readonly CertificateStatus ACTIVE = new CertificateStatus("ACTIVE");
        /// <summary>
        /// Constant INACTIVE for CertificateStatus
        /// </summary>
        public static readonly CertificateStatus INACTIVE = new CertificateStatus("INACTIVE");
        /// <summary>
        /// Constant PENDING_ACTIVATION for CertificateStatus
        /// </summary>
        public static readonly CertificateStatus PENDING_ACTIVATION = new CertificateStatus("PENDING_ACTIVATION");
        /// <summary>
        /// Constant PENDING_TRANSFER for CertificateStatus
        /// </summary>
        public static readonly CertificateStatus PENDING_TRANSFER = new CertificateStatus("PENDING_TRANSFER");
        /// <summary>
        /// Constant REGISTER_INACTIVE for CertificateStatus
        /// </summary>
        public static readonly CertificateStatus REGISTER_INACTIVE = new CertificateStatus("REGISTER_INACTIVE");
        /// <summary>
        /// Constant REVOKED for CertificateStatus
        /// </summary>
        public static readonly CertificateStatus REVOKED = new CertificateStatus("REVOKED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CertificateStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CertificateStatus FindValue(string value)
        {
            return FindValue<CertificateStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CertificateStatus(string value)
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
        /// Constant GreaterThan for ComparisonOperator
        /// </summary>
        public static readonly ComparisonOperator GreaterThan = new ComparisonOperator("greater-than");
        /// <summary>
        /// Constant GreaterThanEquals for ComparisonOperator
        /// </summary>
        public static readonly ComparisonOperator GreaterThanEquals = new ComparisonOperator("greater-than-equals");
        /// <summary>
        /// Constant InCidrSet for ComparisonOperator
        /// </summary>
        public static readonly ComparisonOperator InCidrSet = new ComparisonOperator("in-cidr-set");
        /// <summary>
        /// Constant InPortSet for ComparisonOperator
        /// </summary>
        public static readonly ComparisonOperator InPortSet = new ComparisonOperator("in-port-set");
        /// <summary>
        /// Constant InSet for ComparisonOperator
        /// </summary>
        public static readonly ComparisonOperator InSet = new ComparisonOperator("in-set");
        /// <summary>
        /// Constant LessThan for ComparisonOperator
        /// </summary>
        public static readonly ComparisonOperator LessThan = new ComparisonOperator("less-than");
        /// <summary>
        /// Constant LessThanEquals for ComparisonOperator
        /// </summary>
        public static readonly ComparisonOperator LessThanEquals = new ComparisonOperator("less-than-equals");
        /// <summary>
        /// Constant NotInCidrSet for ComparisonOperator
        /// </summary>
        public static readonly ComparisonOperator NotInCidrSet = new ComparisonOperator("not-in-cidr-set");
        /// <summary>
        /// Constant NotInPortSet for ComparisonOperator
        /// </summary>
        public static readonly ComparisonOperator NotInPortSet = new ComparisonOperator("not-in-port-set");
        /// <summary>
        /// Constant NotInSet for ComparisonOperator
        /// </summary>
        public static readonly ComparisonOperator NotInSet = new ComparisonOperator("not-in-set");

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
    /// Constants used for properties of type ConfidenceLevel.
    /// </summary>
    public class ConfidenceLevel : ConstantClass
    {

        /// <summary>
        /// Constant HIGH for ConfidenceLevel
        /// </summary>
        public static readonly ConfidenceLevel HIGH = new ConfidenceLevel("HIGH");
        /// <summary>
        /// Constant LOW for ConfidenceLevel
        /// </summary>
        public static readonly ConfidenceLevel LOW = new ConfidenceLevel("LOW");
        /// <summary>
        /// Constant MEDIUM for ConfidenceLevel
        /// </summary>
        public static readonly ConfidenceLevel MEDIUM = new ConfidenceLevel("MEDIUM");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ConfidenceLevel(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ConfidenceLevel FindValue(string value)
        {
            return FindValue<ConfidenceLevel>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ConfidenceLevel(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CustomMetricType.
    /// </summary>
    public class CustomMetricType : ConstantClass
    {

        /// <summary>
        /// Constant IpAddressList for CustomMetricType
        /// </summary>
        public static readonly CustomMetricType IpAddressList = new CustomMetricType("ip-address-list");
        /// <summary>
        /// Constant Number for CustomMetricType
        /// </summary>
        public static readonly CustomMetricType Number = new CustomMetricType("number");
        /// <summary>
        /// Constant NumberList for CustomMetricType
        /// </summary>
        public static readonly CustomMetricType NumberList = new CustomMetricType("number-list");
        /// <summary>
        /// Constant StringList for CustomMetricType
        /// </summary>
        public static readonly CustomMetricType StringList = new CustomMetricType("string-list");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CustomMetricType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CustomMetricType FindValue(string value)
        {
            return FindValue<CustomMetricType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CustomMetricType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DayOfWeek.
    /// </summary>
    public class DayOfWeek : ConstantClass
    {

        /// <summary>
        /// Constant FRI for DayOfWeek
        /// </summary>
        public static readonly DayOfWeek FRI = new DayOfWeek("FRI");
        /// <summary>
        /// Constant MON for DayOfWeek
        /// </summary>
        public static readonly DayOfWeek MON = new DayOfWeek("MON");
        /// <summary>
        /// Constant SAT for DayOfWeek
        /// </summary>
        public static readonly DayOfWeek SAT = new DayOfWeek("SAT");
        /// <summary>
        /// Constant SUN for DayOfWeek
        /// </summary>
        public static readonly DayOfWeek SUN = new DayOfWeek("SUN");
        /// <summary>
        /// Constant THU for DayOfWeek
        /// </summary>
        public static readonly DayOfWeek THU = new DayOfWeek("THU");
        /// <summary>
        /// Constant TUE for DayOfWeek
        /// </summary>
        public static readonly DayOfWeek TUE = new DayOfWeek("TUE");
        /// <summary>
        /// Constant WED for DayOfWeek
        /// </summary>
        public static readonly DayOfWeek WED = new DayOfWeek("WED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DayOfWeek(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DayOfWeek FindValue(string value)
        {
            return FindValue<DayOfWeek>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DayOfWeek(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DetectMitigationActionExecutionStatus.
    /// </summary>
    public class DetectMitigationActionExecutionStatus : ConstantClass
    {

        /// <summary>
        /// Constant FAILED for DetectMitigationActionExecutionStatus
        /// </summary>
        public static readonly DetectMitigationActionExecutionStatus FAILED = new DetectMitigationActionExecutionStatus("FAILED");
        /// <summary>
        /// Constant IN_PROGRESS for DetectMitigationActionExecutionStatus
        /// </summary>
        public static readonly DetectMitigationActionExecutionStatus IN_PROGRESS = new DetectMitigationActionExecutionStatus("IN_PROGRESS");
        /// <summary>
        /// Constant SKIPPED for DetectMitigationActionExecutionStatus
        /// </summary>
        public static readonly DetectMitigationActionExecutionStatus SKIPPED = new DetectMitigationActionExecutionStatus("SKIPPED");
        /// <summary>
        /// Constant SUCCESSFUL for DetectMitigationActionExecutionStatus
        /// </summary>
        public static readonly DetectMitigationActionExecutionStatus SUCCESSFUL = new DetectMitigationActionExecutionStatus("SUCCESSFUL");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DetectMitigationActionExecutionStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DetectMitigationActionExecutionStatus FindValue(string value)
        {
            return FindValue<DetectMitigationActionExecutionStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DetectMitigationActionExecutionStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DetectMitigationActionsTaskStatus.
    /// </summary>
    public class DetectMitigationActionsTaskStatus : ConstantClass
    {

        /// <summary>
        /// Constant CANCELED for DetectMitigationActionsTaskStatus
        /// </summary>
        public static readonly DetectMitigationActionsTaskStatus CANCELED = new DetectMitigationActionsTaskStatus("CANCELED");
        /// <summary>
        /// Constant FAILED for DetectMitigationActionsTaskStatus
        /// </summary>
        public static readonly DetectMitigationActionsTaskStatus FAILED = new DetectMitigationActionsTaskStatus("FAILED");
        /// <summary>
        /// Constant IN_PROGRESS for DetectMitigationActionsTaskStatus
        /// </summary>
        public static readonly DetectMitigationActionsTaskStatus IN_PROGRESS = new DetectMitigationActionsTaskStatus("IN_PROGRESS");
        /// <summary>
        /// Constant SUCCESSFUL for DetectMitigationActionsTaskStatus
        /// </summary>
        public static readonly DetectMitigationActionsTaskStatus SUCCESSFUL = new DetectMitigationActionsTaskStatus("SUCCESSFUL");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DetectMitigationActionsTaskStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DetectMitigationActionsTaskStatus FindValue(string value)
        {
            return FindValue<DetectMitigationActionsTaskStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DetectMitigationActionsTaskStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DeviceCertificateUpdateAction.
    /// </summary>
    public class DeviceCertificateUpdateAction : ConstantClass
    {

        /// <summary>
        /// Constant DEACTIVATE for DeviceCertificateUpdateAction
        /// </summary>
        public static readonly DeviceCertificateUpdateAction DEACTIVATE = new DeviceCertificateUpdateAction("DEACTIVATE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DeviceCertificateUpdateAction(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DeviceCertificateUpdateAction FindValue(string value)
        {
            return FindValue<DeviceCertificateUpdateAction>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DeviceCertificateUpdateAction(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DeviceDefenderIndexingMode.
    /// </summary>
    public class DeviceDefenderIndexingMode : ConstantClass
    {

        /// <summary>
        /// Constant OFF for DeviceDefenderIndexingMode
        /// </summary>
        public static readonly DeviceDefenderIndexingMode OFF = new DeviceDefenderIndexingMode("OFF");
        /// <summary>
        /// Constant VIOLATIONS for DeviceDefenderIndexingMode
        /// </summary>
        public static readonly DeviceDefenderIndexingMode VIOLATIONS = new DeviceDefenderIndexingMode("VIOLATIONS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DeviceDefenderIndexingMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DeviceDefenderIndexingMode FindValue(string value)
        {
            return FindValue<DeviceDefenderIndexingMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DeviceDefenderIndexingMode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DimensionType.
    /// </summary>
    public class DimensionType : ConstantClass
    {

        /// <summary>
        /// Constant TOPIC_FILTER for DimensionType
        /// </summary>
        public static readonly DimensionType TOPIC_FILTER = new DimensionType("TOPIC_FILTER");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DimensionType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DimensionType FindValue(string value)
        {
            return FindValue<DimensionType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DimensionType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DimensionValueOperator.
    /// </summary>
    public class DimensionValueOperator : ConstantClass
    {

        /// <summary>
        /// Constant IN for DimensionValueOperator
        /// </summary>
        public static readonly DimensionValueOperator IN = new DimensionValueOperator("IN");
        /// <summary>
        /// Constant NOT_IN for DimensionValueOperator
        /// </summary>
        public static readonly DimensionValueOperator NOT_IN = new DimensionValueOperator("NOT_IN");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DimensionValueOperator(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DimensionValueOperator FindValue(string value)
        {
            return FindValue<DimensionValueOperator>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DimensionValueOperator(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DomainConfigurationStatus.
    /// </summary>
    public class DomainConfigurationStatus : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for DomainConfigurationStatus
        /// </summary>
        public static readonly DomainConfigurationStatus DISABLED = new DomainConfigurationStatus("DISABLED");
        /// <summary>
        /// Constant ENABLED for DomainConfigurationStatus
        /// </summary>
        public static readonly DomainConfigurationStatus ENABLED = new DomainConfigurationStatus("ENABLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DomainConfigurationStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DomainConfigurationStatus FindValue(string value)
        {
            return FindValue<DomainConfigurationStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DomainConfigurationStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DomainType.
    /// </summary>
    public class DomainType : ConstantClass
    {

        /// <summary>
        /// Constant AWS_MANAGED for DomainType
        /// </summary>
        public static readonly DomainType AWS_MANAGED = new DomainType("AWS_MANAGED");
        /// <summary>
        /// Constant CUSTOMER_MANAGED for DomainType
        /// </summary>
        public static readonly DomainType CUSTOMER_MANAGED = new DomainType("CUSTOMER_MANAGED");
        /// <summary>
        /// Constant ENDPOINT for DomainType
        /// </summary>
        public static readonly DomainType ENDPOINT = new DomainType("ENDPOINT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
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

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DomainType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DynamicGroupStatus.
    /// </summary>
    public class DynamicGroupStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for DynamicGroupStatus
        /// </summary>
        public static readonly DynamicGroupStatus ACTIVE = new DynamicGroupStatus("ACTIVE");
        /// <summary>
        /// Constant BUILDING for DynamicGroupStatus
        /// </summary>
        public static readonly DynamicGroupStatus BUILDING = new DynamicGroupStatus("BUILDING");
        /// <summary>
        /// Constant REBUILDING for DynamicGroupStatus
        /// </summary>
        public static readonly DynamicGroupStatus REBUILDING = new DynamicGroupStatus("REBUILDING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DynamicGroupStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DynamicGroupStatus FindValue(string value)
        {
            return FindValue<DynamicGroupStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DynamicGroupStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DynamoKeyType.
    /// </summary>
    public class DynamoKeyType : ConstantClass
    {

        /// <summary>
        /// Constant NUMBER for DynamoKeyType
        /// </summary>
        public static readonly DynamoKeyType NUMBER = new DynamoKeyType("NUMBER");
        /// <summary>
        /// Constant STRING for DynamoKeyType
        /// </summary>
        public static readonly DynamoKeyType STRING = new DynamoKeyType("STRING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DynamoKeyType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DynamoKeyType FindValue(string value)
        {
            return FindValue<DynamoKeyType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DynamoKeyType(string value)
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
        /// Constant CA_CERTIFICATE for EventType
        /// </summary>
        public static readonly EventType CA_CERTIFICATE = new EventType("CA_CERTIFICATE");
        /// <summary>
        /// Constant CERTIFICATE for EventType
        /// </summary>
        public static readonly EventType CERTIFICATE = new EventType("CERTIFICATE");
        /// <summary>
        /// Constant JOB for EventType
        /// </summary>
        public static readonly EventType JOB = new EventType("JOB");
        /// <summary>
        /// Constant JOB_EXECUTION for EventType
        /// </summary>
        public static readonly EventType JOB_EXECUTION = new EventType("JOB_EXECUTION");
        /// <summary>
        /// Constant POLICY for EventType
        /// </summary>
        public static readonly EventType POLICY = new EventType("POLICY");
        /// <summary>
        /// Constant THING for EventType
        /// </summary>
        public static readonly EventType THING = new EventType("THING");
        /// <summary>
        /// Constant THING_GROUP for EventType
        /// </summary>
        public static readonly EventType THING_GROUP = new EventType("THING_GROUP");
        /// <summary>
        /// Constant THING_GROUP_HIERARCHY for EventType
        /// </summary>
        public static readonly EventType THING_GROUP_HIERARCHY = new EventType("THING_GROUP_HIERARCHY");
        /// <summary>
        /// Constant THING_GROUP_MEMBERSHIP for EventType
        /// </summary>
        public static readonly EventType THING_GROUP_MEMBERSHIP = new EventType("THING_GROUP_MEMBERSHIP");
        /// <summary>
        /// Constant THING_TYPE for EventType
        /// </summary>
        public static readonly EventType THING_TYPE = new EventType("THING_TYPE");
        /// <summary>
        /// Constant THING_TYPE_ASSOCIATION for EventType
        /// </summary>
        public static readonly EventType THING_TYPE_ASSOCIATION = new EventType("THING_TYPE_ASSOCIATION");

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
    /// Constants used for properties of type FieldType.
    /// </summary>
    public class FieldType : ConstantClass
    {

        /// <summary>
        /// Constant Boolean for FieldType
        /// </summary>
        public static readonly FieldType Boolean = new FieldType("Boolean");
        /// <summary>
        /// Constant Number for FieldType
        /// </summary>
        public static readonly FieldType Number = new FieldType("Number");
        /// <summary>
        /// Constant String for FieldType
        /// </summary>
        public static readonly FieldType String = new FieldType("String");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FieldType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FieldType FindValue(string value)
        {
            return FindValue<FieldType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FieldType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type FleetMetricUnit.
    /// </summary>
    public class FleetMetricUnit : ConstantClass
    {

        /// <summary>
        /// Constant Bits for FleetMetricUnit
        /// </summary>
        public static readonly FleetMetricUnit Bits = new FleetMetricUnit("Bits");
        /// <summary>
        /// Constant BitsSecond for FleetMetricUnit
        /// </summary>
        public static readonly FleetMetricUnit BitsSecond = new FleetMetricUnit("Bits/Second");
        /// <summary>
        /// Constant Bytes for FleetMetricUnit
        /// </summary>
        public static readonly FleetMetricUnit Bytes = new FleetMetricUnit("Bytes");
        /// <summary>
        /// Constant BytesSecond for FleetMetricUnit
        /// </summary>
        public static readonly FleetMetricUnit BytesSecond = new FleetMetricUnit("Bytes/Second");
        /// <summary>
        /// Constant Count for FleetMetricUnit
        /// </summary>
        public static readonly FleetMetricUnit Count = new FleetMetricUnit("Count");
        /// <summary>
        /// Constant CountSecond for FleetMetricUnit
        /// </summary>
        public static readonly FleetMetricUnit CountSecond = new FleetMetricUnit("Count/Second");
        /// <summary>
        /// Constant Gigabits for FleetMetricUnit
        /// </summary>
        public static readonly FleetMetricUnit Gigabits = new FleetMetricUnit("Gigabits");
        /// <summary>
        /// Constant GigabitsSecond for FleetMetricUnit
        /// </summary>
        public static readonly FleetMetricUnit GigabitsSecond = new FleetMetricUnit("Gigabits/Second");
        /// <summary>
        /// Constant Gigabytes for FleetMetricUnit
        /// </summary>
        public static readonly FleetMetricUnit Gigabytes = new FleetMetricUnit("Gigabytes");
        /// <summary>
        /// Constant GigabytesSecond for FleetMetricUnit
        /// </summary>
        public static readonly FleetMetricUnit GigabytesSecond = new FleetMetricUnit("Gigabytes/Second");
        /// <summary>
        /// Constant Kilobits for FleetMetricUnit
        /// </summary>
        public static readonly FleetMetricUnit Kilobits = new FleetMetricUnit("Kilobits");
        /// <summary>
        /// Constant KilobitsSecond for FleetMetricUnit
        /// </summary>
        public static readonly FleetMetricUnit KilobitsSecond = new FleetMetricUnit("Kilobits/Second");
        /// <summary>
        /// Constant Kilobytes for FleetMetricUnit
        /// </summary>
        public static readonly FleetMetricUnit Kilobytes = new FleetMetricUnit("Kilobytes");
        /// <summary>
        /// Constant KilobytesSecond for FleetMetricUnit
        /// </summary>
        public static readonly FleetMetricUnit KilobytesSecond = new FleetMetricUnit("Kilobytes/Second");
        /// <summary>
        /// Constant Megabits for FleetMetricUnit
        /// </summary>
        public static readonly FleetMetricUnit Megabits = new FleetMetricUnit("Megabits");
        /// <summary>
        /// Constant MegabitsSecond for FleetMetricUnit
        /// </summary>
        public static readonly FleetMetricUnit MegabitsSecond = new FleetMetricUnit("Megabits/Second");
        /// <summary>
        /// Constant Megabytes for FleetMetricUnit
        /// </summary>
        public static readonly FleetMetricUnit Megabytes = new FleetMetricUnit("Megabytes");
        /// <summary>
        /// Constant MegabytesSecond for FleetMetricUnit
        /// </summary>
        public static readonly FleetMetricUnit MegabytesSecond = new FleetMetricUnit("Megabytes/Second");
        /// <summary>
        /// Constant Microseconds for FleetMetricUnit
        /// </summary>
        public static readonly FleetMetricUnit Microseconds = new FleetMetricUnit("Microseconds");
        /// <summary>
        /// Constant Milliseconds for FleetMetricUnit
        /// </summary>
        public static readonly FleetMetricUnit Milliseconds = new FleetMetricUnit("Milliseconds");
        /// <summary>
        /// Constant None for FleetMetricUnit
        /// </summary>
        public static readonly FleetMetricUnit None = new FleetMetricUnit("None");
        /// <summary>
        /// Constant Percent for FleetMetricUnit
        /// </summary>
        public static readonly FleetMetricUnit Percent = new FleetMetricUnit("Percent");
        /// <summary>
        /// Constant Seconds for FleetMetricUnit
        /// </summary>
        public static readonly FleetMetricUnit Seconds = new FleetMetricUnit("Seconds");
        /// <summary>
        /// Constant Terabits for FleetMetricUnit
        /// </summary>
        public static readonly FleetMetricUnit Terabits = new FleetMetricUnit("Terabits");
        /// <summary>
        /// Constant TerabitsSecond for FleetMetricUnit
        /// </summary>
        public static readonly FleetMetricUnit TerabitsSecond = new FleetMetricUnit("Terabits/Second");
        /// <summary>
        /// Constant Terabytes for FleetMetricUnit
        /// </summary>
        public static readonly FleetMetricUnit Terabytes = new FleetMetricUnit("Terabytes");
        /// <summary>
        /// Constant TerabytesSecond for FleetMetricUnit
        /// </summary>
        public static readonly FleetMetricUnit TerabytesSecond = new FleetMetricUnit("Terabytes/Second");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FleetMetricUnit(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FleetMetricUnit FindValue(string value)
        {
            return FindValue<FleetMetricUnit>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FleetMetricUnit(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type IndexStatus.
    /// </summary>
    public class IndexStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for IndexStatus
        /// </summary>
        public static readonly IndexStatus ACTIVE = new IndexStatus("ACTIVE");
        /// <summary>
        /// Constant BUILDING for IndexStatus
        /// </summary>
        public static readonly IndexStatus BUILDING = new IndexStatus("BUILDING");
        /// <summary>
        /// Constant REBUILDING for IndexStatus
        /// </summary>
        public static readonly IndexStatus REBUILDING = new IndexStatus("REBUILDING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public IndexStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static IndexStatus FindValue(string value)
        {
            return FindValue<IndexStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator IndexStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type JobEndBehavior.
    /// </summary>
    public class JobEndBehavior : ConstantClass
    {

        /// <summary>
        /// Constant CANCEL for JobEndBehavior
        /// </summary>
        public static readonly JobEndBehavior CANCEL = new JobEndBehavior("CANCEL");
        /// <summary>
        /// Constant FORCE_CANCEL for JobEndBehavior
        /// </summary>
        public static readonly JobEndBehavior FORCE_CANCEL = new JobEndBehavior("FORCE_CANCEL");
        /// <summary>
        /// Constant STOP_ROLLOUT for JobEndBehavior
        /// </summary>
        public static readonly JobEndBehavior STOP_ROLLOUT = new JobEndBehavior("STOP_ROLLOUT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public JobEndBehavior(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static JobEndBehavior FindValue(string value)
        {
            return FindValue<JobEndBehavior>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator JobEndBehavior(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type JobExecutionFailureType.
    /// </summary>
    public class JobExecutionFailureType : ConstantClass
    {

        /// <summary>
        /// Constant ALL for JobExecutionFailureType
        /// </summary>
        public static readonly JobExecutionFailureType ALL = new JobExecutionFailureType("ALL");
        /// <summary>
        /// Constant FAILED for JobExecutionFailureType
        /// </summary>
        public static readonly JobExecutionFailureType FAILED = new JobExecutionFailureType("FAILED");
        /// <summary>
        /// Constant REJECTED for JobExecutionFailureType
        /// </summary>
        public static readonly JobExecutionFailureType REJECTED = new JobExecutionFailureType("REJECTED");
        /// <summary>
        /// Constant TIMED_OUT for JobExecutionFailureType
        /// </summary>
        public static readonly JobExecutionFailureType TIMED_OUT = new JobExecutionFailureType("TIMED_OUT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public JobExecutionFailureType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static JobExecutionFailureType FindValue(string value)
        {
            return FindValue<JobExecutionFailureType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator JobExecutionFailureType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type JobExecutionStatus.
    /// </summary>
    public class JobExecutionStatus : ConstantClass
    {

        /// <summary>
        /// Constant CANCELED for JobExecutionStatus
        /// </summary>
        public static readonly JobExecutionStatus CANCELED = new JobExecutionStatus("CANCELED");
        /// <summary>
        /// Constant FAILED for JobExecutionStatus
        /// </summary>
        public static readonly JobExecutionStatus FAILED = new JobExecutionStatus("FAILED");
        /// <summary>
        /// Constant IN_PROGRESS for JobExecutionStatus
        /// </summary>
        public static readonly JobExecutionStatus IN_PROGRESS = new JobExecutionStatus("IN_PROGRESS");
        /// <summary>
        /// Constant QUEUED for JobExecutionStatus
        /// </summary>
        public static readonly JobExecutionStatus QUEUED = new JobExecutionStatus("QUEUED");
        /// <summary>
        /// Constant REJECTED for JobExecutionStatus
        /// </summary>
        public static readonly JobExecutionStatus REJECTED = new JobExecutionStatus("REJECTED");
        /// <summary>
        /// Constant REMOVED for JobExecutionStatus
        /// </summary>
        public static readonly JobExecutionStatus REMOVED = new JobExecutionStatus("REMOVED");
        /// <summary>
        /// Constant SUCCEEDED for JobExecutionStatus
        /// </summary>
        public static readonly JobExecutionStatus SUCCEEDED = new JobExecutionStatus("SUCCEEDED");
        /// <summary>
        /// Constant TIMED_OUT for JobExecutionStatus
        /// </summary>
        public static readonly JobExecutionStatus TIMED_OUT = new JobExecutionStatus("TIMED_OUT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public JobExecutionStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static JobExecutionStatus FindValue(string value)
        {
            return FindValue<JobExecutionStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator JobExecutionStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type JobStatus.
    /// </summary>
    public class JobStatus : ConstantClass
    {

        /// <summary>
        /// Constant CANCELED for JobStatus
        /// </summary>
        public static readonly JobStatus CANCELED = new JobStatus("CANCELED");
        /// <summary>
        /// Constant COMPLETED for JobStatus
        /// </summary>
        public static readonly JobStatus COMPLETED = new JobStatus("COMPLETED");
        /// <summary>
        /// Constant DELETION_IN_PROGRESS for JobStatus
        /// </summary>
        public static readonly JobStatus DELETION_IN_PROGRESS = new JobStatus("DELETION_IN_PROGRESS");
        /// <summary>
        /// Constant IN_PROGRESS for JobStatus
        /// </summary>
        public static readonly JobStatus IN_PROGRESS = new JobStatus("IN_PROGRESS");
        /// <summary>
        /// Constant SCHEDULED for JobStatus
        /// </summary>
        public static readonly JobStatus SCHEDULED = new JobStatus("SCHEDULED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public JobStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static JobStatus FindValue(string value)
        {
            return FindValue<JobStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator JobStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type LogLevel.
    /// </summary>
    public class LogLevel : ConstantClass
    {

        /// <summary>
        /// Constant DEBUG for LogLevel
        /// </summary>
        public static readonly LogLevel DEBUG = new LogLevel("DEBUG");
        /// <summary>
        /// Constant DISABLED for LogLevel
        /// </summary>
        public static readonly LogLevel DISABLED = new LogLevel("DISABLED");
        /// <summary>
        /// Constant ERROR for LogLevel
        /// </summary>
        public static readonly LogLevel ERROR = new LogLevel("ERROR");
        /// <summary>
        /// Constant INFO for LogLevel
        /// </summary>
        public static readonly LogLevel INFO = new LogLevel("INFO");
        /// <summary>
        /// Constant WARN for LogLevel
        /// </summary>
        public static readonly LogLevel WARN = new LogLevel("WARN");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public LogLevel(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LogLevel FindValue(string value)
        {
            return FindValue<LogLevel>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator LogLevel(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type LogTargetType.
    /// </summary>
    public class LogTargetType : ConstantClass
    {

        /// <summary>
        /// Constant CLIENT_ID for LogTargetType
        /// </summary>
        public static readonly LogTargetType CLIENT_ID = new LogTargetType("CLIENT_ID");
        /// <summary>
        /// Constant DEFAULT for LogTargetType
        /// </summary>
        public static readonly LogTargetType DEFAULT = new LogTargetType("DEFAULT");
        /// <summary>
        /// Constant PRINCIPAL_ID for LogTargetType
        /// </summary>
        public static readonly LogTargetType PRINCIPAL_ID = new LogTargetType("PRINCIPAL_ID");
        /// <summary>
        /// Constant SOURCE_IP for LogTargetType
        /// </summary>
        public static readonly LogTargetType SOURCE_IP = new LogTargetType("SOURCE_IP");
        /// <summary>
        /// Constant THING_GROUP for LogTargetType
        /// </summary>
        public static readonly LogTargetType THING_GROUP = new LogTargetType("THING_GROUP");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public LogTargetType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LogTargetType FindValue(string value)
        {
            return FindValue<LogTargetType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator LogTargetType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type MessageFormat.
    /// </summary>
    public class MessageFormat : ConstantClass
    {

        /// <summary>
        /// Constant JSON for MessageFormat
        /// </summary>
        public static readonly MessageFormat JSON = new MessageFormat("JSON");
        /// <summary>
        /// Constant RAW for MessageFormat
        /// </summary>
        public static readonly MessageFormat RAW = new MessageFormat("RAW");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MessageFormat(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MessageFormat FindValue(string value)
        {
            return FindValue<MessageFormat>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MessageFormat(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type MitigationActionType.
    /// </summary>
    public class MitigationActionType : ConstantClass
    {

        /// <summary>
        /// Constant ADD_THINGS_TO_THING_GROUP for MitigationActionType
        /// </summary>
        public static readonly MitigationActionType ADD_THINGS_TO_THING_GROUP = new MitigationActionType("ADD_THINGS_TO_THING_GROUP");
        /// <summary>
        /// Constant ENABLE_IOT_LOGGING for MitigationActionType
        /// </summary>
        public static readonly MitigationActionType ENABLE_IOT_LOGGING = new MitigationActionType("ENABLE_IOT_LOGGING");
        /// <summary>
        /// Constant PUBLISH_FINDING_TO_SNS for MitigationActionType
        /// </summary>
        public static readonly MitigationActionType PUBLISH_FINDING_TO_SNS = new MitigationActionType("PUBLISH_FINDING_TO_SNS");
        /// <summary>
        /// Constant REPLACE_DEFAULT_POLICY_VERSION for MitigationActionType
        /// </summary>
        public static readonly MitigationActionType REPLACE_DEFAULT_POLICY_VERSION = new MitigationActionType("REPLACE_DEFAULT_POLICY_VERSION");
        /// <summary>
        /// Constant UPDATE_CA_CERTIFICATE for MitigationActionType
        /// </summary>
        public static readonly MitigationActionType UPDATE_CA_CERTIFICATE = new MitigationActionType("UPDATE_CA_CERTIFICATE");
        /// <summary>
        /// Constant UPDATE_DEVICE_CERTIFICATE for MitigationActionType
        /// </summary>
        public static readonly MitigationActionType UPDATE_DEVICE_CERTIFICATE = new MitigationActionType("UPDATE_DEVICE_CERTIFICATE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MitigationActionType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MitigationActionType FindValue(string value)
        {
            return FindValue<MitigationActionType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MitigationActionType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ModelStatus.
    /// </summary>
    public class ModelStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for ModelStatus
        /// </summary>
        public static readonly ModelStatus ACTIVE = new ModelStatus("ACTIVE");
        /// <summary>
        /// Constant EXPIRED for ModelStatus
        /// </summary>
        public static readonly ModelStatus EXPIRED = new ModelStatus("EXPIRED");
        /// <summary>
        /// Constant PENDING_BUILD for ModelStatus
        /// </summary>
        public static readonly ModelStatus PENDING_BUILD = new ModelStatus("PENDING_BUILD");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ModelStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ModelStatus FindValue(string value)
        {
            return FindValue<ModelStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ModelStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type NamedShadowIndexingMode.
    /// </summary>
    public class NamedShadowIndexingMode : ConstantClass
    {

        /// <summary>
        /// Constant OFF for NamedShadowIndexingMode
        /// </summary>
        public static readonly NamedShadowIndexingMode OFF = new NamedShadowIndexingMode("OFF");
        /// <summary>
        /// Constant ON for NamedShadowIndexingMode
        /// </summary>
        public static readonly NamedShadowIndexingMode ON = new NamedShadowIndexingMode("ON");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public NamedShadowIndexingMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static NamedShadowIndexingMode FindValue(string value)
        {
            return FindValue<NamedShadowIndexingMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator NamedShadowIndexingMode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type OTAUpdateStatus.
    /// </summary>
    public class OTAUpdateStatus : ConstantClass
    {

        /// <summary>
        /// Constant CREATE_COMPLETE for OTAUpdateStatus
        /// </summary>
        public static readonly OTAUpdateStatus CREATE_COMPLETE = new OTAUpdateStatus("CREATE_COMPLETE");
        /// <summary>
        /// Constant CREATE_FAILED for OTAUpdateStatus
        /// </summary>
        public static readonly OTAUpdateStatus CREATE_FAILED = new OTAUpdateStatus("CREATE_FAILED");
        /// <summary>
        /// Constant CREATE_IN_PROGRESS for OTAUpdateStatus
        /// </summary>
        public static readonly OTAUpdateStatus CREATE_IN_PROGRESS = new OTAUpdateStatus("CREATE_IN_PROGRESS");
        /// <summary>
        /// Constant CREATE_PENDING for OTAUpdateStatus
        /// </summary>
        public static readonly OTAUpdateStatus CREATE_PENDING = new OTAUpdateStatus("CREATE_PENDING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public OTAUpdateStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static OTAUpdateStatus FindValue(string value)
        {
            return FindValue<OTAUpdateStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator OTAUpdateStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PolicyTemplateName.
    /// </summary>
    public class PolicyTemplateName : ConstantClass
    {

        /// <summary>
        /// Constant BLANK_POLICY for PolicyTemplateName
        /// </summary>
        public static readonly PolicyTemplateName BLANK_POLICY = new PolicyTemplateName("BLANK_POLICY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PolicyTemplateName(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PolicyTemplateName FindValue(string value)
        {
            return FindValue<PolicyTemplateName>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PolicyTemplateName(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Protocol.
    /// </summary>
    public class Protocol : ConstantClass
    {

        /// <summary>
        /// Constant HTTP for Protocol
        /// </summary>
        public static readonly Protocol HTTP = new Protocol("HTTP");
        /// <summary>
        /// Constant MQTT for Protocol
        /// </summary>
        public static readonly Protocol MQTT = new Protocol("MQTT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Protocol(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Protocol FindValue(string value)
        {
            return FindValue<Protocol>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Protocol(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ReportType.
    /// </summary>
    public class ReportType : ConstantClass
    {

        /// <summary>
        /// Constant ERRORS for ReportType
        /// </summary>
        public static readonly ReportType ERRORS = new ReportType("ERRORS");
        /// <summary>
        /// Constant RESULTS for ReportType
        /// </summary>
        public static readonly ReportType RESULTS = new ReportType("RESULTS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ReportType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ReportType FindValue(string value)
        {
            return FindValue<ReportType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ReportType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ResourceType.
    /// </summary>
    public class ResourceType : ConstantClass
    {

        /// <summary>
        /// Constant ACCOUNT_SETTINGS for ResourceType
        /// </summary>
        public static readonly ResourceType ACCOUNT_SETTINGS = new ResourceType("ACCOUNT_SETTINGS");
        /// <summary>
        /// Constant CA_CERTIFICATE for ResourceType
        /// </summary>
        public static readonly ResourceType CA_CERTIFICATE = new ResourceType("CA_CERTIFICATE");
        /// <summary>
        /// Constant CLIENT_ID for ResourceType
        /// </summary>
        public static readonly ResourceType CLIENT_ID = new ResourceType("CLIENT_ID");
        /// <summary>
        /// Constant COGNITO_IDENTITY_POOL for ResourceType
        /// </summary>
        public static readonly ResourceType COGNITO_IDENTITY_POOL = new ResourceType("COGNITO_IDENTITY_POOL");
        /// <summary>
        /// Constant DEVICE_CERTIFICATE for ResourceType
        /// </summary>
        public static readonly ResourceType DEVICE_CERTIFICATE = new ResourceType("DEVICE_CERTIFICATE");
        /// <summary>
        /// Constant IAM_ROLE for ResourceType
        /// </summary>
        public static readonly ResourceType IAM_ROLE = new ResourceType("IAM_ROLE");
        /// <summary>
        /// Constant IOT_POLICY for ResourceType
        /// </summary>
        public static readonly ResourceType IOT_POLICY = new ResourceType("IOT_POLICY");
        /// <summary>
        /// Constant ISSUER_CERTIFICATE for ResourceType
        /// </summary>
        public static readonly ResourceType ISSUER_CERTIFICATE = new ResourceType("ISSUER_CERTIFICATE");
        /// <summary>
        /// Constant ROLE_ALIAS for ResourceType
        /// </summary>
        public static readonly ResourceType ROLE_ALIAS = new ResourceType("ROLE_ALIAS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
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

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ResourceType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RetryableFailureType.
    /// </summary>
    public class RetryableFailureType : ConstantClass
    {

        /// <summary>
        /// Constant ALL for RetryableFailureType
        /// </summary>
        public static readonly RetryableFailureType ALL = new RetryableFailureType("ALL");
        /// <summary>
        /// Constant FAILED for RetryableFailureType
        /// </summary>
        public static readonly RetryableFailureType FAILED = new RetryableFailureType("FAILED");
        /// <summary>
        /// Constant TIMED_OUT for RetryableFailureType
        /// </summary>
        public static readonly RetryableFailureType TIMED_OUT = new RetryableFailureType("TIMED_OUT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RetryableFailureType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RetryableFailureType FindValue(string value)
        {
            return FindValue<RetryableFailureType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RetryableFailureType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ServerCertificateStatus.
    /// </summary>
    public class ServerCertificateStatus : ConstantClass
    {

        /// <summary>
        /// Constant INVALID for ServerCertificateStatus
        /// </summary>
        public static readonly ServerCertificateStatus INVALID = new ServerCertificateStatus("INVALID");
        /// <summary>
        /// Constant VALID for ServerCertificateStatus
        /// </summary>
        public static readonly ServerCertificateStatus VALID = new ServerCertificateStatus("VALID");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ServerCertificateStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ServerCertificateStatus FindValue(string value)
        {
            return FindValue<ServerCertificateStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ServerCertificateStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ServiceType.
    /// </summary>
    public class ServiceType : ConstantClass
    {

        /// <summary>
        /// Constant CREDENTIAL_PROVIDER for ServiceType
        /// </summary>
        public static readonly ServiceType CREDENTIAL_PROVIDER = new ServiceType("CREDENTIAL_PROVIDER");
        /// <summary>
        /// Constant DATA for ServiceType
        /// </summary>
        public static readonly ServiceType DATA = new ServiceType("DATA");
        /// <summary>
        /// Constant JOBS for ServiceType
        /// </summary>
        public static readonly ServiceType JOBS = new ServiceType("JOBS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ServiceType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ServiceType FindValue(string value)
        {
            return FindValue<ServiceType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ServiceType(string value)
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
        /// Constant Cancelled for Status
        /// </summary>
        public static readonly Status Cancelled = new Status("Cancelled");
        /// <summary>
        /// Constant Cancelling for Status
        /// </summary>
        public static readonly Status Cancelling = new Status("Cancelling");
        /// <summary>
        /// Constant Completed for Status
        /// </summary>
        public static readonly Status Completed = new Status("Completed");
        /// <summary>
        /// Constant Failed for Status
        /// </summary>
        public static readonly Status Failed = new Status("Failed");
        /// <summary>
        /// Constant InProgress for Status
        /// </summary>
        public static readonly Status InProgress = new Status("InProgress");

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
    /// Constants used for properties of type TargetSelection.
    /// </summary>
    public class TargetSelection : ConstantClass
    {

        /// <summary>
        /// Constant CONTINUOUS for TargetSelection
        /// </summary>
        public static readonly TargetSelection CONTINUOUS = new TargetSelection("CONTINUOUS");
        /// <summary>
        /// Constant SNAPSHOT for TargetSelection
        /// </summary>
        public static readonly TargetSelection SNAPSHOT = new TargetSelection("SNAPSHOT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TargetSelection(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TargetSelection FindValue(string value)
        {
            return FindValue<TargetSelection>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TargetSelection(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TemplateType.
    /// </summary>
    public class TemplateType : ConstantClass
    {

        /// <summary>
        /// Constant FLEET_PROVISIONING for TemplateType
        /// </summary>
        public static readonly TemplateType FLEET_PROVISIONING = new TemplateType("FLEET_PROVISIONING");
        /// <summary>
        /// Constant JITP for TemplateType
        /// </summary>
        public static readonly TemplateType JITP = new TemplateType("JITP");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TemplateType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TemplateType FindValue(string value)
        {
            return FindValue<TemplateType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TemplateType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ThingConnectivityIndexingMode.
    /// </summary>
    public class ThingConnectivityIndexingMode : ConstantClass
    {

        /// <summary>
        /// Constant OFF for ThingConnectivityIndexingMode
        /// </summary>
        public static readonly ThingConnectivityIndexingMode OFF = new ThingConnectivityIndexingMode("OFF");
        /// <summary>
        /// Constant STATUS for ThingConnectivityIndexingMode
        /// </summary>
        public static readonly ThingConnectivityIndexingMode STATUS = new ThingConnectivityIndexingMode("STATUS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ThingConnectivityIndexingMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ThingConnectivityIndexingMode FindValue(string value)
        {
            return FindValue<ThingConnectivityIndexingMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ThingConnectivityIndexingMode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ThingGroupIndexingMode.
    /// </summary>
    public class ThingGroupIndexingMode : ConstantClass
    {

        /// <summary>
        /// Constant OFF for ThingGroupIndexingMode
        /// </summary>
        public static readonly ThingGroupIndexingMode OFF = new ThingGroupIndexingMode("OFF");
        /// <summary>
        /// Constant ON for ThingGroupIndexingMode
        /// </summary>
        public static readonly ThingGroupIndexingMode ON = new ThingGroupIndexingMode("ON");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ThingGroupIndexingMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ThingGroupIndexingMode FindValue(string value)
        {
            return FindValue<ThingGroupIndexingMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ThingGroupIndexingMode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ThingIndexingMode.
    /// </summary>
    public class ThingIndexingMode : ConstantClass
    {

        /// <summary>
        /// Constant OFF for ThingIndexingMode
        /// </summary>
        public static readonly ThingIndexingMode OFF = new ThingIndexingMode("OFF");
        /// <summary>
        /// Constant REGISTRY for ThingIndexingMode
        /// </summary>
        public static readonly ThingIndexingMode REGISTRY = new ThingIndexingMode("REGISTRY");
        /// <summary>
        /// Constant REGISTRY_AND_SHADOW for ThingIndexingMode
        /// </summary>
        public static readonly ThingIndexingMode REGISTRY_AND_SHADOW = new ThingIndexingMode("REGISTRY_AND_SHADOW");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ThingIndexingMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ThingIndexingMode FindValue(string value)
        {
            return FindValue<ThingIndexingMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ThingIndexingMode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TopicRuleDestinationStatus.
    /// </summary>
    public class TopicRuleDestinationStatus : ConstantClass
    {

        /// <summary>
        /// Constant DELETING for TopicRuleDestinationStatus
        /// </summary>
        public static readonly TopicRuleDestinationStatus DELETING = new TopicRuleDestinationStatus("DELETING");
        /// <summary>
        /// Constant DISABLED for TopicRuleDestinationStatus
        /// </summary>
        public static readonly TopicRuleDestinationStatus DISABLED = new TopicRuleDestinationStatus("DISABLED");
        /// <summary>
        /// Constant ENABLED for TopicRuleDestinationStatus
        /// </summary>
        public static readonly TopicRuleDestinationStatus ENABLED = new TopicRuleDestinationStatus("ENABLED");
        /// <summary>
        /// Constant ERROR for TopicRuleDestinationStatus
        /// </summary>
        public static readonly TopicRuleDestinationStatus ERROR = new TopicRuleDestinationStatus("ERROR");
        /// <summary>
        /// Constant IN_PROGRESS for TopicRuleDestinationStatus
        /// </summary>
        public static readonly TopicRuleDestinationStatus IN_PROGRESS = new TopicRuleDestinationStatus("IN_PROGRESS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TopicRuleDestinationStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TopicRuleDestinationStatus FindValue(string value)
        {
            return FindValue<TopicRuleDestinationStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TopicRuleDestinationStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type VerificationState.
    /// </summary>
    public class VerificationState : ConstantClass
    {

        /// <summary>
        /// Constant BENIGN_POSITIVE for VerificationState
        /// </summary>
        public static readonly VerificationState BENIGN_POSITIVE = new VerificationState("BENIGN_POSITIVE");
        /// <summary>
        /// Constant FALSE_POSITIVE for VerificationState
        /// </summary>
        public static readonly VerificationState FALSE_POSITIVE = new VerificationState("FALSE_POSITIVE");
        /// <summary>
        /// Constant TRUE_POSITIVE for VerificationState
        /// </summary>
        public static readonly VerificationState TRUE_POSITIVE = new VerificationState("TRUE_POSITIVE");
        /// <summary>
        /// Constant UNKNOWN for VerificationState
        /// </summary>
        public static readonly VerificationState UNKNOWN = new VerificationState("UNKNOWN");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public VerificationState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static VerificationState FindValue(string value)
        {
            return FindValue<VerificationState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator VerificationState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ViolationEventType.
    /// </summary>
    public class ViolationEventType : ConstantClass
    {

        /// <summary>
        /// Constant AlarmCleared for ViolationEventType
        /// </summary>
        public static readonly ViolationEventType AlarmCleared = new ViolationEventType("alarm-cleared");
        /// <summary>
        /// Constant AlarmInvalidated for ViolationEventType
        /// </summary>
        public static readonly ViolationEventType AlarmInvalidated = new ViolationEventType("alarm-invalidated");
        /// <summary>
        /// Constant InAlarm for ViolationEventType
        /// </summary>
        public static readonly ViolationEventType InAlarm = new ViolationEventType("in-alarm");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ViolationEventType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ViolationEventType FindValue(string value)
        {
            return FindValue<ViolationEventType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ViolationEventType(string value)
        {
            return FindValue(value);
        }
    }

}