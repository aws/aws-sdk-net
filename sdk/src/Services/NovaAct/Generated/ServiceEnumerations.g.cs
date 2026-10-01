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

namespace Amazon.NovaAct
{
    /// <summary>
    /// Constants used for properties of type ActStatus.
    /// </summary>
    public class ActStatus : ConstantClass
    {
        /// <summary>
        /// Constant FAILED for ActStatus
        /// </summary>
        public static readonly ActStatus FAILED = new ActStatus("FAILED");

        /// <summary>
        /// Constant PENDING_CLIENT_ACTION for ActStatus
        /// </summary>
        public static readonly ActStatus PENDING_CLIENT_ACTION = new ActStatus("PENDING_CLIENT_ACTION");

        /// <summary>
        /// Constant PENDING_HUMAN_ACTION for ActStatus
        /// </summary>
        public static readonly ActStatus PENDING_HUMAN_ACTION = new ActStatus("PENDING_HUMAN_ACTION");

        /// <summary>
        /// Constant RUNNING for ActStatus
        /// </summary>
        public static readonly ActStatus RUNNING = new ActStatus("RUNNING");

        /// <summary>
        /// Constant SUCCEEDED for ActStatus
        /// </summary>
        public static readonly ActStatus SUCCEEDED = new ActStatus("SUCCEEDED");

        /// <summary>
        /// Constant TIMED_OUT for ActStatus
        /// </summary>
        public static readonly ActStatus TIMED_OUT = new ActStatus("TIMED_OUT");

        /// <summary>
        /// Constructs a custom ActStatus for a value not among the defined constants.
        /// </summary>
        public ActStatus(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ActStatus FindValue(string value)
        {
            return FindValue<ActStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ActStatus(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type InternalServerExceptionReason.
    /// </summary>
    public class InternalServerExceptionReason : ConstantClass
    {
        /// <summary>
        /// Constant InvalidModelGeneration for InternalServerExceptionReason
        /// </summary>
        public static readonly InternalServerExceptionReason InvalidModelGeneration = new InternalServerExceptionReason("InvalidModelGeneration");

        /// <summary>
        /// Constant RequestTokenLimitExceeded for InternalServerExceptionReason
        /// </summary>
        public static readonly InternalServerExceptionReason RequestTokenLimitExceeded = new InternalServerExceptionReason("RequestTokenLimitExceeded");

        /// <summary>
        /// Constructs a custom InternalServerExceptionReason for a value not among the defined constants.
        /// </summary>
        public InternalServerExceptionReason(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static InternalServerExceptionReason FindValue(string value)
        {
            return FindValue<InternalServerExceptionReason>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator InternalServerExceptionReason(string value)
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
        /// Constant DEPRECATED for ModelStatus
        /// </summary>
        public static readonly ModelStatus DEPRECATED = new ModelStatus("DEPRECATED");

        /// <summary>
        /// Constant LEGACY for ModelStatus
        /// </summary>
        public static readonly ModelStatus LEGACY = new ModelStatus("LEGACY");

        /// <summary>
        /// Constant PREVIEW for ModelStatus
        /// </summary>
        public static readonly ModelStatus PREVIEW = new ModelStatus("PREVIEW");

        /// <summary>
        /// Constructs a custom ModelStatus for a value not among the defined constants.
        /// </summary>
        public ModelStatus(string value) : base(value) { }

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
    /// Constants used for properties of type SortOrder.
    /// </summary>
    public class SortOrder : ConstantClass
    {
        /// <summary>
        /// Constant Ascending for SortOrder
        /// </summary>
        public static readonly SortOrder Ascending = new SortOrder("Ascending");

        /// <summary>
        /// Constant Descending for SortOrder
        /// </summary>
        public static readonly SortOrder Descending = new SortOrder("Descending");

        /// <summary>
        /// Constructs a custom SortOrder for a value not among the defined constants.
        /// </summary>
        public SortOrder(string value) : base(value) { }

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
    /// Constants used for properties of type TraceLocationType.
    /// </summary>
    public class TraceLocationType : ConstantClass
    {
        /// <summary>
        /// Constant S3 for TraceLocationType
        /// </summary>
        public static readonly TraceLocationType S3 = new TraceLocationType("S3");

        /// <summary>
        /// Constructs a custom TraceLocationType for a value not among the defined constants.
        /// </summary>
        public TraceLocationType(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TraceLocationType FindValue(string value)
        {
            return FindValue<TraceLocationType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TraceLocationType(string value)
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
        /// Constant FieldValidationFailed for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason FieldValidationFailed = new ValidationExceptionReason("FieldValidationFailed");

        /// <summary>
        /// Constant GuardrailIntervened for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason GuardrailIntervened = new ValidationExceptionReason("GuardrailIntervened");

        /// <summary>
        /// Constant InvalidStatus for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason InvalidStatus = new ValidationExceptionReason("InvalidStatus");

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

    /// <summary>
    /// Constants used for properties of type WorkflowDefinitionStatus.
    /// </summary>
    public class WorkflowDefinitionStatus : ConstantClass
    {
        /// <summary>
        /// Constant ACTIVE for WorkflowDefinitionStatus
        /// </summary>
        public static readonly WorkflowDefinitionStatus ACTIVE = new WorkflowDefinitionStatus("ACTIVE");

        /// <summary>
        /// Constant DELETING for WorkflowDefinitionStatus
        /// </summary>
        public static readonly WorkflowDefinitionStatus DELETING = new WorkflowDefinitionStatus("DELETING");

        /// <summary>
        /// Constructs a custom WorkflowDefinitionStatus for a value not among the defined constants.
        /// </summary>
        public WorkflowDefinitionStatus(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static WorkflowDefinitionStatus FindValue(string value)
        {
            return FindValue<WorkflowDefinitionStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator WorkflowDefinitionStatus(string value)
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
        /// Constant DELETING for WorkflowRunStatus
        /// </summary>
        public static readonly WorkflowRunStatus DELETING = new WorkflowRunStatus("DELETING");

        /// <summary>
        /// Constant FAILED for WorkflowRunStatus
        /// </summary>
        public static readonly WorkflowRunStatus FAILED = new WorkflowRunStatus("FAILED");

        /// <summary>
        /// Constant RUNNING for WorkflowRunStatus
        /// </summary>
        public static readonly WorkflowRunStatus RUNNING = new WorkflowRunStatus("RUNNING");

        /// <summary>
        /// Constant SUCCEEDED for WorkflowRunStatus
        /// </summary>
        public static readonly WorkflowRunStatus SUCCEEDED = new WorkflowRunStatus("SUCCEEDED");

        /// <summary>
        /// Constant TIMED_OUT for WorkflowRunStatus
        /// </summary>
        public static readonly WorkflowRunStatus TIMED_OUT = new WorkflowRunStatus("TIMED_OUT");

        /// <summary>
        /// Constructs a custom WorkflowRunStatus for a value not among the defined constants.
        /// </summary>
        public WorkflowRunStatus(string value) : base(value) { }

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
}
