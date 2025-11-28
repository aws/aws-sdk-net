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
 * Do not modify this file. This file is generated from the mwaa-serverless-2024-07-26.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.MWAAServerless
{

    /// <summary>
    /// Constants used for properties of type EncryptionType.
    /// </summary>
    public class EncryptionType : ConstantClass
    {

        /// <summary>
        /// Constant AWS_MANAGED_KEY for EncryptionType
        /// </summary>
        public static readonly EncryptionType AWS_MANAGED_KEY = new EncryptionType("AWS_MANAGED_KEY");
        /// <summary>
        /// Constant CUSTOMER_MANAGED_KEY for EncryptionType
        /// </summary>
        public static readonly EncryptionType CUSTOMER_MANAGED_KEY = new EncryptionType("CUSTOMER_MANAGED_KEY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EncryptionType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EncryptionType FindValue(string value)
        {
            return FindValue<EncryptionType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EncryptionType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RunType.
    /// </summary>
    public class RunType : ConstantClass
    {

        /// <summary>
        /// Constant ON_DEMAND for RunType
        /// </summary>
        public static readonly RunType ON_DEMAND = new RunType("ON_DEMAND");
        /// <summary>
        /// Constant SCHEDULED for RunType
        /// </summary>
        public static readonly RunType SCHEDULED = new RunType("SCHEDULED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RunType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RunType FindValue(string value)
        {
            return FindValue<RunType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RunType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TaskInstanceStatus.
    /// </summary>
    public class TaskInstanceStatus : ConstantClass
    {

        /// <summary>
        /// Constant CANCELLED for TaskInstanceStatus
        /// </summary>
        public static readonly TaskInstanceStatus CANCELLED = new TaskInstanceStatus("CANCELLED");
        /// <summary>
        /// Constant DEFERRED for TaskInstanceStatus
        /// </summary>
        public static readonly TaskInstanceStatus DEFERRED = new TaskInstanceStatus("DEFERRED");
        /// <summary>
        /// Constant FAILED for TaskInstanceStatus
        /// </summary>
        public static readonly TaskInstanceStatus FAILED = new TaskInstanceStatus("FAILED");
        /// <summary>
        /// Constant NONE for TaskInstanceStatus
        /// </summary>
        public static readonly TaskInstanceStatus NONE = new TaskInstanceStatus("NONE");
        /// <summary>
        /// Constant QUEUED for TaskInstanceStatus
        /// </summary>
        public static readonly TaskInstanceStatus QUEUED = new TaskInstanceStatus("QUEUED");
        /// <summary>
        /// Constant REMOVED for TaskInstanceStatus
        /// </summary>
        public static readonly TaskInstanceStatus REMOVED = new TaskInstanceStatus("REMOVED");
        /// <summary>
        /// Constant RESTARTING for TaskInstanceStatus
        /// </summary>
        public static readonly TaskInstanceStatus RESTARTING = new TaskInstanceStatus("RESTARTING");
        /// <summary>
        /// Constant RUNNING for TaskInstanceStatus
        /// </summary>
        public static readonly TaskInstanceStatus RUNNING = new TaskInstanceStatus("RUNNING");
        /// <summary>
        /// Constant SCHEDULED for TaskInstanceStatus
        /// </summary>
        public static readonly TaskInstanceStatus SCHEDULED = new TaskInstanceStatus("SCHEDULED");
        /// <summary>
        /// Constant SUCCESS for TaskInstanceStatus
        /// </summary>
        public static readonly TaskInstanceStatus SUCCESS = new TaskInstanceStatus("SUCCESS");
        /// <summary>
        /// Constant TIMEOUT for TaskInstanceStatus
        /// </summary>
        public static readonly TaskInstanceStatus TIMEOUT = new TaskInstanceStatus("TIMEOUT");
        /// <summary>
        /// Constant UP_FOR_RESCHEDULE for TaskInstanceStatus
        /// </summary>
        public static readonly TaskInstanceStatus UP_FOR_RESCHEDULE = new TaskInstanceStatus("UP_FOR_RESCHEDULE");
        /// <summary>
        /// Constant UP_FOR_RETRY for TaskInstanceStatus
        /// </summary>
        public static readonly TaskInstanceStatus UP_FOR_RETRY = new TaskInstanceStatus("UP_FOR_RETRY");
        /// <summary>
        /// Constant UPSTREAM_FAILED for TaskInstanceStatus
        /// </summary>
        public static readonly TaskInstanceStatus UPSTREAM_FAILED = new TaskInstanceStatus("UPSTREAM_FAILED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TaskInstanceStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TaskInstanceStatus FindValue(string value)
        {
            return FindValue<TaskInstanceStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TaskInstanceStatus(string value)
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


    /// <summary>
    /// Constants used for properties of type WorkflowRunStatus.
    /// </summary>
    public class WorkflowRunStatus : ConstantClass
    {

        /// <summary>
        /// Constant FAILED for WorkflowRunStatus
        /// </summary>
        public static readonly WorkflowRunStatus FAILED = new WorkflowRunStatus("FAILED");
        /// <summary>
        /// Constant QUEUED for WorkflowRunStatus
        /// </summary>
        public static readonly WorkflowRunStatus QUEUED = new WorkflowRunStatus("QUEUED");
        /// <summary>
        /// Constant RUNNING for WorkflowRunStatus
        /// </summary>
        public static readonly WorkflowRunStatus RUNNING = new WorkflowRunStatus("RUNNING");
        /// <summary>
        /// Constant STARTING for WorkflowRunStatus
        /// </summary>
        public static readonly WorkflowRunStatus STARTING = new WorkflowRunStatus("STARTING");
        /// <summary>
        /// Constant STOPPED for WorkflowRunStatus
        /// </summary>
        public static readonly WorkflowRunStatus STOPPED = new WorkflowRunStatus("STOPPED");
        /// <summary>
        /// Constant STOPPING for WorkflowRunStatus
        /// </summary>
        public static readonly WorkflowRunStatus STOPPING = new WorkflowRunStatus("STOPPING");
        /// <summary>
        /// Constant SUCCESS for WorkflowRunStatus
        /// </summary>
        public static readonly WorkflowRunStatus SUCCESS = new WorkflowRunStatus("SUCCESS");
        /// <summary>
        /// Constant TIMEOUT for WorkflowRunStatus
        /// </summary>
        public static readonly WorkflowRunStatus TIMEOUT = new WorkflowRunStatus("TIMEOUT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public WorkflowRunStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static WorkflowRunStatus FindValue(string value)
        {
            return FindValue<WorkflowRunStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator WorkflowRunStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type WorkflowStatus.
    /// </summary>
    public class WorkflowStatus : ConstantClass
    {

        /// <summary>
        /// Constant DELETING for WorkflowStatus
        /// </summary>
        public static readonly WorkflowStatus DELETING = new WorkflowStatus("DELETING");
        /// <summary>
        /// Constant READY for WorkflowStatus
        /// </summary>
        public static readonly WorkflowStatus READY = new WorkflowStatus("READY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public WorkflowStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static WorkflowStatus FindValue(string value)
        {
            return FindValue<WorkflowStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator WorkflowStatus(string value)
        {
            return FindValue(value);
        }
    }

}