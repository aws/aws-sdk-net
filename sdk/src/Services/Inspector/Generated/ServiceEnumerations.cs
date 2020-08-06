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
 * Do not modify this file. This file is generated from the inspector-2016-02-16.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.Inspector
{

    /// <summary>
    /// Constants used for properties of type AccessDeniedErrorCode.
    /// </summary>
    public class AccessDeniedErrorCode : ConstantClass
    {

        /// <summary>
        /// Constant ACCESS_DENIED_TO_ASSESSMENT_RUN for AccessDeniedErrorCode
        /// </summary>
        public static readonly AccessDeniedErrorCode ACCESS_DENIED_TO_ASSESSMENT_RUN = new AccessDeniedErrorCode("ACCESS_DENIED_TO_ASSESSMENT_RUN");
        /// <summary>
        /// Constant ACCESS_DENIED_TO_ASSESSMENT_TARGET for AccessDeniedErrorCode
        /// </summary>
        public static readonly AccessDeniedErrorCode ACCESS_DENIED_TO_ASSESSMENT_TARGET = new AccessDeniedErrorCode("ACCESS_DENIED_TO_ASSESSMENT_TARGET");
        /// <summary>
        /// Constant ACCESS_DENIED_TO_ASSESSMENT_TEMPLATE for AccessDeniedErrorCode
        /// </summary>
        public static readonly AccessDeniedErrorCode ACCESS_DENIED_TO_ASSESSMENT_TEMPLATE = new AccessDeniedErrorCode("ACCESS_DENIED_TO_ASSESSMENT_TEMPLATE");
        /// <summary>
        /// Constant ACCESS_DENIED_TO_FINDING for AccessDeniedErrorCode
        /// </summary>
        public static readonly AccessDeniedErrorCode ACCESS_DENIED_TO_FINDING = new AccessDeniedErrorCode("ACCESS_DENIED_TO_FINDING");
        /// <summary>
        /// Constant ACCESS_DENIED_TO_IAM_ROLE for AccessDeniedErrorCode
        /// </summary>
        public static readonly AccessDeniedErrorCode ACCESS_DENIED_TO_IAM_ROLE = new AccessDeniedErrorCode("ACCESS_DENIED_TO_IAM_ROLE");
        /// <summary>
        /// Constant ACCESS_DENIED_TO_RESOURCE_GROUP for AccessDeniedErrorCode
        /// </summary>
        public static readonly AccessDeniedErrorCode ACCESS_DENIED_TO_RESOURCE_GROUP = new AccessDeniedErrorCode("ACCESS_DENIED_TO_RESOURCE_GROUP");
        /// <summary>
        /// Constant ACCESS_DENIED_TO_RULES_PACKAGE for AccessDeniedErrorCode
        /// </summary>
        public static readonly AccessDeniedErrorCode ACCESS_DENIED_TO_RULES_PACKAGE = new AccessDeniedErrorCode("ACCESS_DENIED_TO_RULES_PACKAGE");
        /// <summary>
        /// Constant ACCESS_DENIED_TO_SNS_TOPIC for AccessDeniedErrorCode
        /// </summary>
        public static readonly AccessDeniedErrorCode ACCESS_DENIED_TO_SNS_TOPIC = new AccessDeniedErrorCode("ACCESS_DENIED_TO_SNS_TOPIC");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AccessDeniedErrorCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AccessDeniedErrorCode FindValue(string value)
        {
            return FindValue<AccessDeniedErrorCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AccessDeniedErrorCode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AgentHealth.
    /// </summary>
    public class AgentHealth : ConstantClass
    {

        /// <summary>
        /// Constant HEALTHY for AgentHealth
        /// </summary>
        public static readonly AgentHealth HEALTHY = new AgentHealth("HEALTHY");
        /// <summary>
        /// Constant UNHEALTHY for AgentHealth
        /// </summary>
        public static readonly AgentHealth UNHEALTHY = new AgentHealth("UNHEALTHY");
        /// <summary>
        /// Constant UNKNOWN for AgentHealth
        /// </summary>
        public static readonly AgentHealth UNKNOWN = new AgentHealth("UNKNOWN");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AgentHealth(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AgentHealth FindValue(string value)
        {
            return FindValue<AgentHealth>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AgentHealth(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AgentHealthCode.
    /// </summary>
    public class AgentHealthCode : ConstantClass
    {

        /// <summary>
        /// Constant IDLE for AgentHealthCode
        /// </summary>
        public static readonly AgentHealthCode IDLE = new AgentHealthCode("IDLE");
        /// <summary>
        /// Constant RUNNING for AgentHealthCode
        /// </summary>
        public static readonly AgentHealthCode RUNNING = new AgentHealthCode("RUNNING");
        /// <summary>
        /// Constant SHUTDOWN for AgentHealthCode
        /// </summary>
        public static readonly AgentHealthCode SHUTDOWN = new AgentHealthCode("SHUTDOWN");
        /// <summary>
        /// Constant THROTTLED for AgentHealthCode
        /// </summary>
        public static readonly AgentHealthCode THROTTLED = new AgentHealthCode("THROTTLED");
        /// <summary>
        /// Constant UNHEALTHY for AgentHealthCode
        /// </summary>
        public static readonly AgentHealthCode UNHEALTHY = new AgentHealthCode("UNHEALTHY");
        /// <summary>
        /// Constant UNKNOWN for AgentHealthCode
        /// </summary>
        public static readonly AgentHealthCode UNKNOWN = new AgentHealthCode("UNKNOWN");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AgentHealthCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AgentHealthCode FindValue(string value)
        {
            return FindValue<AgentHealthCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AgentHealthCode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AssessmentRunNotificationSnsStatusCode.
    /// </summary>
    public class AssessmentRunNotificationSnsStatusCode : ConstantClass
    {

        /// <summary>
        /// Constant ACCESS_DENIED for AssessmentRunNotificationSnsStatusCode
        /// </summary>
        public static readonly AssessmentRunNotificationSnsStatusCode ACCESS_DENIED = new AssessmentRunNotificationSnsStatusCode("ACCESS_DENIED");
        /// <summary>
        /// Constant INTERNAL_ERROR for AssessmentRunNotificationSnsStatusCode
        /// </summary>
        public static readonly AssessmentRunNotificationSnsStatusCode INTERNAL_ERROR = new AssessmentRunNotificationSnsStatusCode("INTERNAL_ERROR");
        /// <summary>
        /// Constant SUCCESS for AssessmentRunNotificationSnsStatusCode
        /// </summary>
        public static readonly AssessmentRunNotificationSnsStatusCode SUCCESS = new AssessmentRunNotificationSnsStatusCode("SUCCESS");
        /// <summary>
        /// Constant TOPIC_DOES_NOT_EXIST for AssessmentRunNotificationSnsStatusCode
        /// </summary>
        public static readonly AssessmentRunNotificationSnsStatusCode TOPIC_DOES_NOT_EXIST = new AssessmentRunNotificationSnsStatusCode("TOPIC_DOES_NOT_EXIST");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AssessmentRunNotificationSnsStatusCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AssessmentRunNotificationSnsStatusCode FindValue(string value)
        {
            return FindValue<AssessmentRunNotificationSnsStatusCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AssessmentRunNotificationSnsStatusCode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AssessmentRunState.
    /// </summary>
    public class AssessmentRunState : ConstantClass
    {

        /// <summary>
        /// Constant CANCELED for AssessmentRunState
        /// </summary>
        public static readonly AssessmentRunState CANCELED = new AssessmentRunState("CANCELED");
        /// <summary>
        /// Constant COLLECTING_DATA for AssessmentRunState
        /// </summary>
        public static readonly AssessmentRunState COLLECTING_DATA = new AssessmentRunState("COLLECTING_DATA");
        /// <summary>
        /// Constant COMPLETED for AssessmentRunState
        /// </summary>
        public static readonly AssessmentRunState COMPLETED = new AssessmentRunState("COMPLETED");
        /// <summary>
        /// Constant COMPLETED_WITH_ERRORS for AssessmentRunState
        /// </summary>
        public static readonly AssessmentRunState COMPLETED_WITH_ERRORS = new AssessmentRunState("COMPLETED_WITH_ERRORS");
        /// <summary>
        /// Constant CREATED for AssessmentRunState
        /// </summary>
        public static readonly AssessmentRunState CREATED = new AssessmentRunState("CREATED");
        /// <summary>
        /// Constant DATA_COLLECTED for AssessmentRunState
        /// </summary>
        public static readonly AssessmentRunState DATA_COLLECTED = new AssessmentRunState("DATA_COLLECTED");
        /// <summary>
        /// Constant ERROR for AssessmentRunState
        /// </summary>
        public static readonly AssessmentRunState ERROR = new AssessmentRunState("ERROR");
        /// <summary>
        /// Constant EVALUATING_RULES for AssessmentRunState
        /// </summary>
        public static readonly AssessmentRunState EVALUATING_RULES = new AssessmentRunState("EVALUATING_RULES");
        /// <summary>
        /// Constant FAILED for AssessmentRunState
        /// </summary>
        public static readonly AssessmentRunState FAILED = new AssessmentRunState("FAILED");
        /// <summary>
        /// Constant START_DATA_COLLECTION_IN_PROGRESS for AssessmentRunState
        /// </summary>
        public static readonly AssessmentRunState START_DATA_COLLECTION_IN_PROGRESS = new AssessmentRunState("START_DATA_COLLECTION_IN_PROGRESS");
        /// <summary>
        /// Constant START_DATA_COLLECTION_PENDING for AssessmentRunState
        /// </summary>
        public static readonly AssessmentRunState START_DATA_COLLECTION_PENDING = new AssessmentRunState("START_DATA_COLLECTION_PENDING");
        /// <summary>
        /// Constant START_EVALUATING_RULES_PENDING for AssessmentRunState
        /// </summary>
        public static readonly AssessmentRunState START_EVALUATING_RULES_PENDING = new AssessmentRunState("START_EVALUATING_RULES_PENDING");
        /// <summary>
        /// Constant STOP_DATA_COLLECTION_PENDING for AssessmentRunState
        /// </summary>
        public static readonly AssessmentRunState STOP_DATA_COLLECTION_PENDING = new AssessmentRunState("STOP_DATA_COLLECTION_PENDING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AssessmentRunState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AssessmentRunState FindValue(string value)
        {
            return FindValue<AssessmentRunState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AssessmentRunState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AssetType.
    /// </summary>
    public class AssetType : ConstantClass
    {

        /// <summary>
        /// Constant Ec2Instance for AssetType
        /// </summary>
        public static readonly AssetType Ec2Instance = new AssetType("ec2-instance");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AssetType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AssetType FindValue(string value)
        {
            return FindValue<AssetType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AssetType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type FailedItemErrorCode.
    /// </summary>
    public class FailedItemErrorCode : ConstantClass
    {

        /// <summary>
        /// Constant ACCESS_DENIED for FailedItemErrorCode
        /// </summary>
        public static readonly FailedItemErrorCode ACCESS_DENIED = new FailedItemErrorCode("ACCESS_DENIED");
        /// <summary>
        /// Constant DUPLICATE_ARN for FailedItemErrorCode
        /// </summary>
        public static readonly FailedItemErrorCode DUPLICATE_ARN = new FailedItemErrorCode("DUPLICATE_ARN");
        /// <summary>
        /// Constant INTERNAL_ERROR for FailedItemErrorCode
        /// </summary>
        public static readonly FailedItemErrorCode INTERNAL_ERROR = new FailedItemErrorCode("INTERNAL_ERROR");
        /// <summary>
        /// Constant INVALID_ARN for FailedItemErrorCode
        /// </summary>
        public static readonly FailedItemErrorCode INVALID_ARN = new FailedItemErrorCode("INVALID_ARN");
        /// <summary>
        /// Constant ITEM_DOES_NOT_EXIST for FailedItemErrorCode
        /// </summary>
        public static readonly FailedItemErrorCode ITEM_DOES_NOT_EXIST = new FailedItemErrorCode("ITEM_DOES_NOT_EXIST");
        /// <summary>
        /// Constant LIMIT_EXCEEDED for FailedItemErrorCode
        /// </summary>
        public static readonly FailedItemErrorCode LIMIT_EXCEEDED = new FailedItemErrorCode("LIMIT_EXCEEDED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FailedItemErrorCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FailedItemErrorCode FindValue(string value)
        {
            return FindValue<FailedItemErrorCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FailedItemErrorCode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type InspectorEvent.
    /// </summary>
    public class InspectorEvent : ConstantClass
    {

        /// <summary>
        /// Constant ASSESSMENT_RUN_COMPLETED for InspectorEvent
        /// </summary>
        public static readonly InspectorEvent ASSESSMENT_RUN_COMPLETED = new InspectorEvent("ASSESSMENT_RUN_COMPLETED");
        /// <summary>
        /// Constant ASSESSMENT_RUN_STARTED for InspectorEvent
        /// </summary>
        public static readonly InspectorEvent ASSESSMENT_RUN_STARTED = new InspectorEvent("ASSESSMENT_RUN_STARTED");
        /// <summary>
        /// Constant ASSESSMENT_RUN_STATE_CHANGED for InspectorEvent
        /// </summary>
        public static readonly InspectorEvent ASSESSMENT_RUN_STATE_CHANGED = new InspectorEvent("ASSESSMENT_RUN_STATE_CHANGED");
        /// <summary>
        /// Constant FINDING_REPORTED for InspectorEvent
        /// </summary>
        public static readonly InspectorEvent FINDING_REPORTED = new InspectorEvent("FINDING_REPORTED");
        /// <summary>
        /// Constant OTHER for InspectorEvent
        /// </summary>
        public static readonly InspectorEvent OTHER = new InspectorEvent("OTHER");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public InspectorEvent(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static InspectorEvent FindValue(string value)
        {
            return FindValue<InspectorEvent>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator InspectorEvent(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type InvalidCrossAccountRoleErrorCode.
    /// </summary>
    public class InvalidCrossAccountRoleErrorCode : ConstantClass
    {

        /// <summary>
        /// Constant ROLE_DOES_NOT_EXIST_OR_INVALID_TRUST_RELATIONSHIP for InvalidCrossAccountRoleErrorCode
        /// </summary>
        public static readonly InvalidCrossAccountRoleErrorCode ROLE_DOES_NOT_EXIST_OR_INVALID_TRUST_RELATIONSHIP = new InvalidCrossAccountRoleErrorCode("ROLE_DOES_NOT_EXIST_OR_INVALID_TRUST_RELATIONSHIP");
        /// <summary>
        /// Constant ROLE_DOES_NOT_HAVE_CORRECT_POLICY for InvalidCrossAccountRoleErrorCode
        /// </summary>
        public static readonly InvalidCrossAccountRoleErrorCode ROLE_DOES_NOT_HAVE_CORRECT_POLICY = new InvalidCrossAccountRoleErrorCode("ROLE_DOES_NOT_HAVE_CORRECT_POLICY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public InvalidCrossAccountRoleErrorCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static InvalidCrossAccountRoleErrorCode FindValue(string value)
        {
            return FindValue<InvalidCrossAccountRoleErrorCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator InvalidCrossAccountRoleErrorCode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type InvalidInputErrorCode.
    /// </summary>
    public class InvalidInputErrorCode : ConstantClass
    {

        /// <summary>
        /// Constant ASSESSMENT_TARGET_NAME_ALREADY_TAKEN for InvalidInputErrorCode
        /// </summary>
        public static readonly InvalidInputErrorCode ASSESSMENT_TARGET_NAME_ALREADY_TAKEN = new InvalidInputErrorCode("ASSESSMENT_TARGET_NAME_ALREADY_TAKEN");
        /// <summary>
        /// Constant ASSESSMENT_TEMPLATE_NAME_ALREADY_TAKEN for InvalidInputErrorCode
        /// </summary>
        public static readonly InvalidInputErrorCode ASSESSMENT_TEMPLATE_NAME_ALREADY_TAKEN = new InvalidInputErrorCode("ASSESSMENT_TEMPLATE_NAME_ALREADY_TAKEN");
        /// <summary>
        /// Constant INVALID_AGENT_ID for InvalidInputErrorCode
        /// </summary>
        public static readonly InvalidInputErrorCode INVALID_AGENT_ID = new InvalidInputErrorCode("INVALID_AGENT_ID");
        /// <summary>
        /// Constant INVALID_ASSESSMENT_RUN_ARN for InvalidInputErrorCode
        /// </summary>
        public static readonly InvalidInputErrorCode INVALID_ASSESSMENT_RUN_ARN = new InvalidInputErrorCode("INVALID_ASSESSMENT_RUN_ARN");
        /// <summary>
        /// Constant INVALID_ASSESSMENT_RUN_COMPLETION_TIME_RANGE for InvalidInputErrorCode
        /// </summary>
        public static readonly InvalidInputErrorCode INVALID_ASSESSMENT_RUN_COMPLETION_TIME_RANGE = new InvalidInputErrorCode("INVALID_ASSESSMENT_RUN_COMPLETION_TIME_RANGE");
        /// <summary>
        /// Constant INVALID_ASSESSMENT_RUN_DURATION_RANGE for InvalidInputErrorCode
        /// </summary>
        public static readonly InvalidInputErrorCode INVALID_ASSESSMENT_RUN_DURATION_RANGE = new InvalidInputErrorCode("INVALID_ASSESSMENT_RUN_DURATION_RANGE");
        /// <summary>
        /// Constant INVALID_ASSESSMENT_RUN_START_TIME_RANGE for InvalidInputErrorCode
        /// </summary>
        public static readonly InvalidInputErrorCode INVALID_ASSESSMENT_RUN_START_TIME_RANGE = new InvalidInputErrorCode("INVALID_ASSESSMENT_RUN_START_TIME_RANGE");
        /// <summary>
        /// Constant INVALID_ASSESSMENT_RUN_STATE for InvalidInputErrorCode
        /// </summary>
        public static readonly InvalidInputErrorCode INVALID_ASSESSMENT_RUN_STATE = new InvalidInputErrorCode("INVALID_ASSESSMENT_RUN_STATE");
        /// <summary>
        /// Constant INVALID_ASSESSMENT_RUN_STATE_CHANGE_TIME_RANGE for InvalidInputErrorCode
        /// </summary>
        public static readonly InvalidInputErrorCode INVALID_ASSESSMENT_RUN_STATE_CHANGE_TIME_RANGE = new InvalidInputErrorCode("INVALID_ASSESSMENT_RUN_STATE_CHANGE_TIME_RANGE");
        /// <summary>
        /// Constant INVALID_ASSESSMENT_TARGET_ARN for InvalidInputErrorCode
        /// </summary>
        public static readonly InvalidInputErrorCode INVALID_ASSESSMENT_TARGET_ARN = new InvalidInputErrorCode("INVALID_ASSESSMENT_TARGET_ARN");
        /// <summary>
        /// Constant INVALID_ASSESSMENT_TARGET_NAME for InvalidInputErrorCode
        /// </summary>
        public static readonly InvalidInputErrorCode INVALID_ASSESSMENT_TARGET_NAME = new InvalidInputErrorCode("INVALID_ASSESSMENT_TARGET_NAME");
        /// <summary>
        /// Constant INVALID_ASSESSMENT_TARGET_NAME_PATTERN for InvalidInputErrorCode
        /// </summary>
        public static readonly InvalidInputErrorCode INVALID_ASSESSMENT_TARGET_NAME_PATTERN = new InvalidInputErrorCode("INVALID_ASSESSMENT_TARGET_NAME_PATTERN");
        /// <summary>
        /// Constant INVALID_ASSESSMENT_TEMPLATE_ARN for InvalidInputErrorCode
        /// </summary>
        public static readonly InvalidInputErrorCode INVALID_ASSESSMENT_TEMPLATE_ARN = new InvalidInputErrorCode("INVALID_ASSESSMENT_TEMPLATE_ARN");
        /// <summary>
        /// Constant INVALID_ASSESSMENT_TEMPLATE_DURATION for InvalidInputErrorCode
        /// </summary>
        public static readonly InvalidInputErrorCode INVALID_ASSESSMENT_TEMPLATE_DURATION = new InvalidInputErrorCode("INVALID_ASSESSMENT_TEMPLATE_DURATION");
        /// <summary>
        /// Constant INVALID_ASSESSMENT_TEMPLATE_DURATION_RANGE for InvalidInputErrorCode
        /// </summary>
        public static readonly InvalidInputErrorCode INVALID_ASSESSMENT_TEMPLATE_DURATION_RANGE = new InvalidInputErrorCode("INVALID_ASSESSMENT_TEMPLATE_DURATION_RANGE");
        /// <summary>
        /// Constant INVALID_ASSESSMENT_TEMPLATE_NAME for InvalidInputErrorCode
        /// </summary>
        public static readonly InvalidInputErrorCode INVALID_ASSESSMENT_TEMPLATE_NAME = new InvalidInputErrorCode("INVALID_ASSESSMENT_TEMPLATE_NAME");
        /// <summary>
        /// Constant INVALID_ASSESSMENT_TEMPLATE_NAME_PATTERN for InvalidInputErrorCode
        /// </summary>
        public static readonly InvalidInputErrorCode INVALID_ASSESSMENT_TEMPLATE_NAME_PATTERN = new InvalidInputErrorCode("INVALID_ASSESSMENT_TEMPLATE_NAME_PATTERN");
        /// <summary>
        /// Constant INVALID_ATTRIBUTE for InvalidInputErrorCode
        /// </summary>
        public static readonly InvalidInputErrorCode INVALID_ATTRIBUTE = new InvalidInputErrorCode("INVALID_ATTRIBUTE");
        /// <summary>
        /// Constant INVALID_AUTO_SCALING_GROUP for InvalidInputErrorCode
        /// </summary>
        public static readonly InvalidInputErrorCode INVALID_AUTO_SCALING_GROUP = new InvalidInputErrorCode("INVALID_AUTO_SCALING_GROUP");
        /// <summary>
        /// Constant INVALID_EVENT for InvalidInputErrorCode
        /// </summary>
        public static readonly InvalidInputErrorCode INVALID_EVENT = new InvalidInputErrorCode("INVALID_EVENT");
        /// <summary>
        /// Constant INVALID_FINDING_ARN for InvalidInputErrorCode
        /// </summary>
        public static readonly InvalidInputErrorCode INVALID_FINDING_ARN = new InvalidInputErrorCode("INVALID_FINDING_ARN");
        /// <summary>
        /// Constant INVALID_IAM_ROLE_ARN for InvalidInputErrorCode
        /// </summary>
        public static readonly InvalidInputErrorCode INVALID_IAM_ROLE_ARN = new InvalidInputErrorCode("INVALID_IAM_ROLE_ARN");
        /// <summary>
        /// Constant INVALID_LOCALE for InvalidInputErrorCode
        /// </summary>
        public static readonly InvalidInputErrorCode INVALID_LOCALE = new InvalidInputErrorCode("INVALID_LOCALE");
        /// <summary>
        /// Constant INVALID_MAX_RESULTS for InvalidInputErrorCode
        /// </summary>
        public static readonly InvalidInputErrorCode INVALID_MAX_RESULTS = new InvalidInputErrorCode("INVALID_MAX_RESULTS");
        /// <summary>
        /// Constant INVALID_NUMBER_OF_AGENT_IDS for InvalidInputErrorCode
        /// </summary>
        public static readonly InvalidInputErrorCode INVALID_NUMBER_OF_AGENT_IDS = new InvalidInputErrorCode("INVALID_NUMBER_OF_AGENT_IDS");
        /// <summary>
        /// Constant INVALID_NUMBER_OF_ASSESSMENT_RUN_ARNS for InvalidInputErrorCode
        /// </summary>
        public static readonly InvalidInputErrorCode INVALID_NUMBER_OF_ASSESSMENT_RUN_ARNS = new InvalidInputErrorCode("INVALID_NUMBER_OF_ASSESSMENT_RUN_ARNS");
        /// <summary>
        /// Constant INVALID_NUMBER_OF_ASSESSMENT_RUN_STATES for InvalidInputErrorCode
        /// </summary>
        public static readonly InvalidInputErrorCode INVALID_NUMBER_OF_ASSESSMENT_RUN_STATES = new InvalidInputErrorCode("INVALID_NUMBER_OF_ASSESSMENT_RUN_STATES");
        /// <summary>
        /// Constant INVALID_NUMBER_OF_ASSESSMENT_TARGET_ARNS for InvalidInputErrorCode
        /// </summary>
        public static readonly InvalidInputErrorCode INVALID_NUMBER_OF_ASSESSMENT_TARGET_ARNS = new InvalidInputErrorCode("INVALID_NUMBER_OF_ASSESSMENT_TARGET_ARNS");
        /// <summary>
        /// Constant INVALID_NUMBER_OF_ASSESSMENT_TEMPLATE_ARNS for InvalidInputErrorCode
        /// </summary>
        public static readonly InvalidInputErrorCode INVALID_NUMBER_OF_ASSESSMENT_TEMPLATE_ARNS = new InvalidInputErrorCode("INVALID_NUMBER_OF_ASSESSMENT_TEMPLATE_ARNS");
        /// <summary>
        /// Constant INVALID_NUMBER_OF_ATTRIBUTES for InvalidInputErrorCode
        /// </summary>
        public static readonly InvalidInputErrorCode INVALID_NUMBER_OF_ATTRIBUTES = new InvalidInputErrorCode("INVALID_NUMBER_OF_ATTRIBUTES");
        /// <summary>
        /// Constant INVALID_NUMBER_OF_AUTO_SCALING_GROUPS for InvalidInputErrorCode
        /// </summary>
        public static readonly InvalidInputErrorCode INVALID_NUMBER_OF_AUTO_SCALING_GROUPS = new InvalidInputErrorCode("INVALID_NUMBER_OF_AUTO_SCALING_GROUPS");
        /// <summary>
        /// Constant INVALID_NUMBER_OF_FINDING_ARNS for InvalidInputErrorCode
        /// </summary>
        public static readonly InvalidInputErrorCode INVALID_NUMBER_OF_FINDING_ARNS = new InvalidInputErrorCode("INVALID_NUMBER_OF_FINDING_ARNS");
        /// <summary>
        /// Constant INVALID_NUMBER_OF_RESOURCE_GROUP_ARNS for InvalidInputErrorCode
        /// </summary>
        public static readonly InvalidInputErrorCode INVALID_NUMBER_OF_RESOURCE_GROUP_ARNS = new InvalidInputErrorCode("INVALID_NUMBER_OF_RESOURCE_GROUP_ARNS");
        /// <summary>
        /// Constant INVALID_NUMBER_OF_RESOURCE_GROUP_TAGS for InvalidInputErrorCode
        /// </summary>
        public static readonly InvalidInputErrorCode INVALID_NUMBER_OF_RESOURCE_GROUP_TAGS = new InvalidInputErrorCode("INVALID_NUMBER_OF_RESOURCE_GROUP_TAGS");
        /// <summary>
        /// Constant INVALID_NUMBER_OF_RULE_NAMES for InvalidInputErrorCode
        /// </summary>
        public static readonly InvalidInputErrorCode INVALID_NUMBER_OF_RULE_NAMES = new InvalidInputErrorCode("INVALID_NUMBER_OF_RULE_NAMES");
        /// <summary>
        /// Constant INVALID_NUMBER_OF_RULES_PACKAGE_ARNS for InvalidInputErrorCode
        /// </summary>
        public static readonly InvalidInputErrorCode INVALID_NUMBER_OF_RULES_PACKAGE_ARNS = new InvalidInputErrorCode("INVALID_NUMBER_OF_RULES_PACKAGE_ARNS");
        /// <summary>
        /// Constant INVALID_NUMBER_OF_SEVERITIES for InvalidInputErrorCode
        /// </summary>
        public static readonly InvalidInputErrorCode INVALID_NUMBER_OF_SEVERITIES = new InvalidInputErrorCode("INVALID_NUMBER_OF_SEVERITIES");
        /// <summary>
        /// Constant INVALID_NUMBER_OF_TAGS for InvalidInputErrorCode
        /// </summary>
        public static readonly InvalidInputErrorCode INVALID_NUMBER_OF_TAGS = new InvalidInputErrorCode("INVALID_NUMBER_OF_TAGS");
        /// <summary>
        /// Constant INVALID_NUMBER_OF_USER_ATTRIBUTES for InvalidInputErrorCode
        /// </summary>
        public static readonly InvalidInputErrorCode INVALID_NUMBER_OF_USER_ATTRIBUTES = new InvalidInputErrorCode("INVALID_NUMBER_OF_USER_ATTRIBUTES");
        /// <summary>
        /// Constant INVALID_PAGINATION_TOKEN for InvalidInputErrorCode
        /// </summary>
        public static readonly InvalidInputErrorCode INVALID_PAGINATION_TOKEN = new InvalidInputErrorCode("INVALID_PAGINATION_TOKEN");
        /// <summary>
        /// Constant INVALID_RESOURCE_ARN for InvalidInputErrorCode
        /// </summary>
        public static readonly InvalidInputErrorCode INVALID_RESOURCE_ARN = new InvalidInputErrorCode("INVALID_RESOURCE_ARN");
        /// <summary>
        /// Constant INVALID_RESOURCE_GROUP_ARN for InvalidInputErrorCode
        /// </summary>
        public static readonly InvalidInputErrorCode INVALID_RESOURCE_GROUP_ARN = new InvalidInputErrorCode("INVALID_RESOURCE_GROUP_ARN");
        /// <summary>
        /// Constant INVALID_RESOURCE_GROUP_TAG_KEY for InvalidInputErrorCode
        /// </summary>
        public static readonly InvalidInputErrorCode INVALID_RESOURCE_GROUP_TAG_KEY = new InvalidInputErrorCode("INVALID_RESOURCE_GROUP_TAG_KEY");
        /// <summary>
        /// Constant INVALID_RESOURCE_GROUP_TAG_VALUE for InvalidInputErrorCode
        /// </summary>
        public static readonly InvalidInputErrorCode INVALID_RESOURCE_GROUP_TAG_VALUE = new InvalidInputErrorCode("INVALID_RESOURCE_GROUP_TAG_VALUE");
        /// <summary>
        /// Constant INVALID_RULE_NAME for InvalidInputErrorCode
        /// </summary>
        public static readonly InvalidInputErrorCode INVALID_RULE_NAME = new InvalidInputErrorCode("INVALID_RULE_NAME");
        /// <summary>
        /// Constant INVALID_RULES_PACKAGE_ARN for InvalidInputErrorCode
        /// </summary>
        public static readonly InvalidInputErrorCode INVALID_RULES_PACKAGE_ARN = new InvalidInputErrorCode("INVALID_RULES_PACKAGE_ARN");
        /// <summary>
        /// Constant INVALID_SEVERITY for InvalidInputErrorCode
        /// </summary>
        public static readonly InvalidInputErrorCode INVALID_SEVERITY = new InvalidInputErrorCode("INVALID_SEVERITY");
        /// <summary>
        /// Constant INVALID_SNS_TOPIC_ARN for InvalidInputErrorCode
        /// </summary>
        public static readonly InvalidInputErrorCode INVALID_SNS_TOPIC_ARN = new InvalidInputErrorCode("INVALID_SNS_TOPIC_ARN");
        /// <summary>
        /// Constant INVALID_TAG for InvalidInputErrorCode
        /// </summary>
        public static readonly InvalidInputErrorCode INVALID_TAG = new InvalidInputErrorCode("INVALID_TAG");
        /// <summary>
        /// Constant INVALID_TAG_KEY for InvalidInputErrorCode
        /// </summary>
        public static readonly InvalidInputErrorCode INVALID_TAG_KEY = new InvalidInputErrorCode("INVALID_TAG_KEY");
        /// <summary>
        /// Constant INVALID_TAG_VALUE for InvalidInputErrorCode
        /// </summary>
        public static readonly InvalidInputErrorCode INVALID_TAG_VALUE = new InvalidInputErrorCode("INVALID_TAG_VALUE");
        /// <summary>
        /// Constant INVALID_USER_ATTRIBUTE for InvalidInputErrorCode
        /// </summary>
        public static readonly InvalidInputErrorCode INVALID_USER_ATTRIBUTE = new InvalidInputErrorCode("INVALID_USER_ATTRIBUTE");
        /// <summary>
        /// Constant INVALID_USER_ATTRIBUTE_KEY for InvalidInputErrorCode
        /// </summary>
        public static readonly InvalidInputErrorCode INVALID_USER_ATTRIBUTE_KEY = new InvalidInputErrorCode("INVALID_USER_ATTRIBUTE_KEY");
        /// <summary>
        /// Constant INVALID_USER_ATTRIBUTE_VALUE for InvalidInputErrorCode
        /// </summary>
        public static readonly InvalidInputErrorCode INVALID_USER_ATTRIBUTE_VALUE = new InvalidInputErrorCode("INVALID_USER_ATTRIBUTE_VALUE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public InvalidInputErrorCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static InvalidInputErrorCode FindValue(string value)
        {
            return FindValue<InvalidInputErrorCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator InvalidInputErrorCode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type LimitExceededErrorCode.
    /// </summary>
    public class LimitExceededErrorCode : ConstantClass
    {

        /// <summary>
        /// Constant ASSESSMENT_RUN_LIMIT_EXCEEDED for LimitExceededErrorCode
        /// </summary>
        public static readonly LimitExceededErrorCode ASSESSMENT_RUN_LIMIT_EXCEEDED = new LimitExceededErrorCode("ASSESSMENT_RUN_LIMIT_EXCEEDED");
        /// <summary>
        /// Constant ASSESSMENT_TARGET_LIMIT_EXCEEDED for LimitExceededErrorCode
        /// </summary>
        public static readonly LimitExceededErrorCode ASSESSMENT_TARGET_LIMIT_EXCEEDED = new LimitExceededErrorCode("ASSESSMENT_TARGET_LIMIT_EXCEEDED");
        /// <summary>
        /// Constant ASSESSMENT_TEMPLATE_LIMIT_EXCEEDED for LimitExceededErrorCode
        /// </summary>
        public static readonly LimitExceededErrorCode ASSESSMENT_TEMPLATE_LIMIT_EXCEEDED = new LimitExceededErrorCode("ASSESSMENT_TEMPLATE_LIMIT_EXCEEDED");
        /// <summary>
        /// Constant EVENT_SUBSCRIPTION_LIMIT_EXCEEDED for LimitExceededErrorCode
        /// </summary>
        public static readonly LimitExceededErrorCode EVENT_SUBSCRIPTION_LIMIT_EXCEEDED = new LimitExceededErrorCode("EVENT_SUBSCRIPTION_LIMIT_EXCEEDED");
        /// <summary>
        /// Constant RESOURCE_GROUP_LIMIT_EXCEEDED for LimitExceededErrorCode
        /// </summary>
        public static readonly LimitExceededErrorCode RESOURCE_GROUP_LIMIT_EXCEEDED = new LimitExceededErrorCode("RESOURCE_GROUP_LIMIT_EXCEEDED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public LimitExceededErrorCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LimitExceededErrorCode FindValue(string value)
        {
            return FindValue<LimitExceededErrorCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator LimitExceededErrorCode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Locale.
    /// </summary>
    public class Locale : ConstantClass
    {

        /// <summary>
        /// Constant EN_US for Locale
        /// </summary>
        public static readonly Locale EN_US = new Locale("EN_US");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Locale(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Locale FindValue(string value)
        {
            return FindValue<Locale>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Locale(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type NoSuchEntityErrorCode.
    /// </summary>
    public class NoSuchEntityErrorCode : ConstantClass
    {

        /// <summary>
        /// Constant ASSESSMENT_RUN_DOES_NOT_EXIST for NoSuchEntityErrorCode
        /// </summary>
        public static readonly NoSuchEntityErrorCode ASSESSMENT_RUN_DOES_NOT_EXIST = new NoSuchEntityErrorCode("ASSESSMENT_RUN_DOES_NOT_EXIST");
        /// <summary>
        /// Constant ASSESSMENT_TARGET_DOES_NOT_EXIST for NoSuchEntityErrorCode
        /// </summary>
        public static readonly NoSuchEntityErrorCode ASSESSMENT_TARGET_DOES_NOT_EXIST = new NoSuchEntityErrorCode("ASSESSMENT_TARGET_DOES_NOT_EXIST");
        /// <summary>
        /// Constant ASSESSMENT_TEMPLATE_DOES_NOT_EXIST for NoSuchEntityErrorCode
        /// </summary>
        public static readonly NoSuchEntityErrorCode ASSESSMENT_TEMPLATE_DOES_NOT_EXIST = new NoSuchEntityErrorCode("ASSESSMENT_TEMPLATE_DOES_NOT_EXIST");
        /// <summary>
        /// Constant FINDING_DOES_NOT_EXIST for NoSuchEntityErrorCode
        /// </summary>
        public static readonly NoSuchEntityErrorCode FINDING_DOES_NOT_EXIST = new NoSuchEntityErrorCode("FINDING_DOES_NOT_EXIST");
        /// <summary>
        /// Constant IAM_ROLE_DOES_NOT_EXIST for NoSuchEntityErrorCode
        /// </summary>
        public static readonly NoSuchEntityErrorCode IAM_ROLE_DOES_NOT_EXIST = new NoSuchEntityErrorCode("IAM_ROLE_DOES_NOT_EXIST");
        /// <summary>
        /// Constant RESOURCE_GROUP_DOES_NOT_EXIST for NoSuchEntityErrorCode
        /// </summary>
        public static readonly NoSuchEntityErrorCode RESOURCE_GROUP_DOES_NOT_EXIST = new NoSuchEntityErrorCode("RESOURCE_GROUP_DOES_NOT_EXIST");
        /// <summary>
        /// Constant RULES_PACKAGE_DOES_NOT_EXIST for NoSuchEntityErrorCode
        /// </summary>
        public static readonly NoSuchEntityErrorCode RULES_PACKAGE_DOES_NOT_EXIST = new NoSuchEntityErrorCode("RULES_PACKAGE_DOES_NOT_EXIST");
        /// <summary>
        /// Constant SNS_TOPIC_DOES_NOT_EXIST for NoSuchEntityErrorCode
        /// </summary>
        public static readonly NoSuchEntityErrorCode SNS_TOPIC_DOES_NOT_EXIST = new NoSuchEntityErrorCode("SNS_TOPIC_DOES_NOT_EXIST");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public NoSuchEntityErrorCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static NoSuchEntityErrorCode FindValue(string value)
        {
            return FindValue<NoSuchEntityErrorCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator NoSuchEntityErrorCode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PreviewStatus.
    /// </summary>
    public class PreviewStatus : ConstantClass
    {

        /// <summary>
        /// Constant COMPLETED for PreviewStatus
        /// </summary>
        public static readonly PreviewStatus COMPLETED = new PreviewStatus("COMPLETED");
        /// <summary>
        /// Constant WORK_IN_PROGRESS for PreviewStatus
        /// </summary>
        public static readonly PreviewStatus WORK_IN_PROGRESS = new PreviewStatus("WORK_IN_PROGRESS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PreviewStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PreviewStatus FindValue(string value)
        {
            return FindValue<PreviewStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PreviewStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ReportFileFormat.
    /// </summary>
    public class ReportFileFormat : ConstantClass
    {

        /// <summary>
        /// Constant HTML for ReportFileFormat
        /// </summary>
        public static readonly ReportFileFormat HTML = new ReportFileFormat("HTML");
        /// <summary>
        /// Constant PDF for ReportFileFormat
        /// </summary>
        public static readonly ReportFileFormat PDF = new ReportFileFormat("PDF");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ReportFileFormat(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ReportFileFormat FindValue(string value)
        {
            return FindValue<ReportFileFormat>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ReportFileFormat(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ReportStatus.
    /// </summary>
    public class ReportStatus : ConstantClass
    {

        /// <summary>
        /// Constant COMPLETED for ReportStatus
        /// </summary>
        public static readonly ReportStatus COMPLETED = new ReportStatus("COMPLETED");
        /// <summary>
        /// Constant FAILED for ReportStatus
        /// </summary>
        public static readonly ReportStatus FAILED = new ReportStatus("FAILED");
        /// <summary>
        /// Constant WORK_IN_PROGRESS for ReportStatus
        /// </summary>
        public static readonly ReportStatus WORK_IN_PROGRESS = new ReportStatus("WORK_IN_PROGRESS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ReportStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ReportStatus FindValue(string value)
        {
            return FindValue<ReportStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ReportStatus(string value)
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
        /// Constant FINDING for ReportType
        /// </summary>
        public static readonly ReportType FINDING = new ReportType("FINDING");
        /// <summary>
        /// Constant FULL for ReportType
        /// </summary>
        public static readonly ReportType FULL = new ReportType("FULL");

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
    /// Constants used for properties of type ScopeType.
    /// </summary>
    public class ScopeType : ConstantClass
    {

        /// <summary>
        /// Constant INSTANCE_ID for ScopeType
        /// </summary>
        public static readonly ScopeType INSTANCE_ID = new ScopeType("INSTANCE_ID");
        /// <summary>
        /// Constant RULES_PACKAGE_ARN for ScopeType
        /// </summary>
        public static readonly ScopeType RULES_PACKAGE_ARN = new ScopeType("RULES_PACKAGE_ARN");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ScopeType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ScopeType FindValue(string value)
        {
            return FindValue<ScopeType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ScopeType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Severity.
    /// </summary>
    public class Severity : ConstantClass
    {

        /// <summary>
        /// Constant High for Severity
        /// </summary>
        public static readonly Severity High = new Severity("High");
        /// <summary>
        /// Constant Informational for Severity
        /// </summary>
        public static readonly Severity Informational = new Severity("Informational");
        /// <summary>
        /// Constant Low for Severity
        /// </summary>
        public static readonly Severity Low = new Severity("Low");
        /// <summary>
        /// Constant Medium for Severity
        /// </summary>
        public static readonly Severity Medium = new Severity("Medium");
        /// <summary>
        /// Constant Undefined for Severity
        /// </summary>
        public static readonly Severity Undefined = new Severity("Undefined");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Severity(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Severity FindValue(string value)
        {
            return FindValue<Severity>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Severity(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type StopAction.
    /// </summary>
    public class StopAction : ConstantClass
    {

        /// <summary>
        /// Constant SKIP_EVALUATION for StopAction
        /// </summary>
        public static readonly StopAction SKIP_EVALUATION = new StopAction("SKIP_EVALUATION");
        /// <summary>
        /// Constant START_EVALUATION for StopAction
        /// </summary>
        public static readonly StopAction START_EVALUATION = new StopAction("START_EVALUATION");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public StopAction(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static StopAction FindValue(string value)
        {
            return FindValue<StopAction>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator StopAction(string value)
        {
            return FindValue(value);
        }
    }

}