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
using Amazon.Runtime;

namespace Amazon.ConnectScheduling
{
    /// <summary>
    /// Constants used for properties of type ApprovalType.
    /// </summary>
    public class ApprovalType : ConstantClass
    {
        /// <summary>
        /// Constant AUTOMATIC for ApprovalType
        /// </summary>
        public static readonly ApprovalType AUTOMATIC = new ApprovalType("AUTOMATIC");

        /// <summary>
        /// Constant AWAIT_APPROVAL for ApprovalType
        /// </summary>
        public static readonly ApprovalType AWAIT_APPROVAL = new ApprovalType("AWAIT_APPROVAL");

        /// <summary>
        /// Constructs a custom ApprovalType for a value not among the defined constants.
        /// </summary>
        public ApprovalType(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ApprovalType FindValue(string value)
        {
            return FindValue<ApprovalType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ApprovalType(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type DurationUnit.
    /// </summary>
    public class DurationUnit : ConstantClass
    {
        /// <summary>
        /// Constant DAYS for DurationUnit
        /// </summary>
        public static readonly DurationUnit DAYS = new DurationUnit("DAYS");

        /// <summary>
        /// Constant HOURS for DurationUnit
        /// </summary>
        public static readonly DurationUnit HOURS = new DurationUnit("HOURS");

        /// <summary>
        /// Constant MINUTES for DurationUnit
        /// </summary>
        public static readonly DurationUnit MINUTES = new DurationUnit("MINUTES");

        /// <summary>
        /// Constructs a custom DurationUnit for a value not among the defined constants.
        /// </summary>
        public DurationUnit(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DurationUnit FindValue(string value)
        {
            return FindValue<DurationUnit>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DurationUnit(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type RuleFailureAction.
    /// </summary>
    public class RuleFailureAction : ConstantClass
    {
        /// <summary>
        /// Constant OVERRIDE for RuleFailureAction
        /// </summary>
        public static readonly RuleFailureAction OVERRIDE = new RuleFailureAction("OVERRIDE");

        /// <summary>
        /// Constant REJECT for RuleFailureAction
        /// </summary>
        public static readonly RuleFailureAction REJECT = new RuleFailureAction("REJECT");

        /// <summary>
        /// Constructs a custom RuleFailureAction for a value not among the defined constants.
        /// </summary>
        public RuleFailureAction(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RuleFailureAction FindValue(string value)
        {
            return FindValue<RuleFailureAction>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RuleFailureAction(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type TimeOffStatus.
    /// </summary>
    public class TimeOffStatus : ConstantClass
    {
        /// <summary>
        /// Constant APPROVED for TimeOffStatus
        /// </summary>
        public static readonly TimeOffStatus APPROVED = new TimeOffStatus("APPROVED");

        /// <summary>
        /// Constant AWAITING_APPROVAL for TimeOffStatus
        /// </summary>
        public static readonly TimeOffStatus AWAITING_APPROVAL = new TimeOffStatus("AWAITING_APPROVAL");

        /// <summary>
        /// Constant CANCELLED for TimeOffStatus
        /// </summary>
        public static readonly TimeOffStatus CANCELLED = new TimeOffStatus("CANCELLED");

        /// <summary>
        /// Constant PENDING for TimeOffStatus
        /// </summary>
        public static readonly TimeOffStatus PENDING = new TimeOffStatus("PENDING");

        /// <summary>
        /// Constant REJECTED for TimeOffStatus
        /// </summary>
        public static readonly TimeOffStatus REJECTED = new TimeOffStatus("REJECTED");

        /// <summary>
        /// Constructs a custom TimeOffStatus for a value not among the defined constants.
        /// </summary>
        public TimeOffStatus(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TimeOffStatus FindValue(string value)
        {
            return FindValue<TimeOffStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TimeOffStatus(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type TimeOffValidationCode.
    /// </summary>
    public class TimeOffValidationCode : ConstantClass
    {
        /// <summary>
        /// Constant CONFLICTING_TIME_OFF_REQUEST for TimeOffValidationCode
        /// </summary>
        public static readonly TimeOffValidationCode CONFLICTING_TIME_OFF_REQUEST = new TimeOffValidationCode("CONFLICTING_TIME_OFF_REQUEST");

        /// <summary>
        /// Constant INSUFFICIENT_GROUP_TIME_OFF_ALLOWANCE for TimeOffValidationCode
        /// </summary>
        public static readonly TimeOffValidationCode INSUFFICIENT_GROUP_TIME_OFF_ALLOWANCE = new TimeOffValidationCode("INSUFFICIENT_GROUP_TIME_OFF_ALLOWANCE");

        /// <summary>
        /// Constant INSUFFICIENT_STAFFING_GROUP_TIME_OFF_ALLOWANCE for TimeOffValidationCode
        /// </summary>
        public static readonly TimeOffValidationCode INSUFFICIENT_STAFFING_GROUP_TIME_OFF_ALLOWANCE = new TimeOffValidationCode("INSUFFICIENT_STAFFING_GROUP_TIME_OFF_ALLOWANCE");

        /// <summary>
        /// Constant INSUFFICIENT_USER_TIME_OFF_BALANCE for TimeOffValidationCode
        /// </summary>
        public static readonly TimeOffValidationCode INSUFFICIENT_USER_TIME_OFF_BALANCE = new TimeOffValidationCode("INSUFFICIENT_USER_TIME_OFF_BALANCE");

        /// <summary>
        /// Constructs a custom TimeOffValidationCode for a value not among the defined constants.
        /// </summary>
        public TimeOffValidationCode(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TimeOffValidationCode FindValue(string value)
        {
            return FindValue<TimeOffValidationCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TimeOffValidationCode(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type TimeOffValidationSeverity.
    /// </summary>
    public class TimeOffValidationSeverity : ConstantClass
    {
        /// <summary>
        /// Constant ERROR for TimeOffValidationSeverity
        /// </summary>
        public static readonly TimeOffValidationSeverity ERROR = new TimeOffValidationSeverity("ERROR");

        /// <summary>
        /// Constant WARNING for TimeOffValidationSeverity
        /// </summary>
        public static readonly TimeOffValidationSeverity WARNING = new TimeOffValidationSeverity("WARNING");

        /// <summary>
        /// Constructs a custom TimeOffValidationSeverity for a value not among the defined constants.
        /// </summary>
        public TimeOffValidationSeverity(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TimeOffValidationSeverity FindValue(string value)
        {
            return FindValue<TimeOffValidationSeverity>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TimeOffValidationSeverity(string value)
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
        /// Constructs a custom ValidationExceptionReason for a value not among the defined constants.
        /// </summary>
        public ValidationExceptionReason(string value) : base(value) { }

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
