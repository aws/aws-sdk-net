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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.Connect
{

    /// <summary>
    /// Constants used for properties of type ActionType.
    /// </summary>
    public class ActionType : ConstantClass
    {

        /// <summary>
        /// Constant ASSIGN_CONTACT_CATEGORY for ActionType
        /// </summary>
        public static readonly ActionType ASSIGN_CONTACT_CATEGORY = new ActionType("ASSIGN_CONTACT_CATEGORY");
        /// <summary>
        /// Constant ASSIGN_SLA for ActionType
        /// </summary>
        public static readonly ActionType ASSIGN_SLA = new ActionType("ASSIGN_SLA");
        /// <summary>
        /// Constant CREATE_CASE for ActionType
        /// </summary>
        public static readonly ActionType CREATE_CASE = new ActionType("CREATE_CASE");
        /// <summary>
        /// Constant CREATE_TASK for ActionType
        /// </summary>
        public static readonly ActionType CREATE_TASK = new ActionType("CREATE_TASK");
        /// <summary>
        /// Constant END_ASSOCIATED_TASKS for ActionType
        /// </summary>
        public static readonly ActionType END_ASSOCIATED_TASKS = new ActionType("END_ASSOCIATED_TASKS");
        /// <summary>
        /// Constant GENERATE_EVENTBRIDGE_EVENT for ActionType
        /// </summary>
        public static readonly ActionType GENERATE_EVENTBRIDGE_EVENT = new ActionType("GENERATE_EVENTBRIDGE_EVENT");
        /// <summary>
        /// Constant SEND_NOTIFICATION for ActionType
        /// </summary>
        public static readonly ActionType SEND_NOTIFICATION = new ActionType("SEND_NOTIFICATION");
        /// <summary>
        /// Constant SUBMIT_AUTO_EVALUATION for ActionType
        /// </summary>
        public static readonly ActionType SUBMIT_AUTO_EVALUATION = new ActionType("SUBMIT_AUTO_EVALUATION");
        /// <summary>
        /// Constant UPDATE_CASE for ActionType
        /// </summary>
        public static readonly ActionType UPDATE_CASE = new ActionType("UPDATE_CASE");

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
    /// Constants used for properties of type AgentAvailabilityTimer.
    /// </summary>
    public class AgentAvailabilityTimer : ConstantClass
    {

        /// <summary>
        /// Constant TIME_SINCE_LAST_ACTIVITY for AgentAvailabilityTimer
        /// </summary>
        public static readonly AgentAvailabilityTimer TIME_SINCE_LAST_ACTIVITY = new AgentAvailabilityTimer("TIME_SINCE_LAST_ACTIVITY");
        /// <summary>
        /// Constant TIME_SINCE_LAST_INBOUND for AgentAvailabilityTimer
        /// </summary>
        public static readonly AgentAvailabilityTimer TIME_SINCE_LAST_INBOUND = new AgentAvailabilityTimer("TIME_SINCE_LAST_INBOUND");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AgentAvailabilityTimer(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AgentAvailabilityTimer FindValue(string value)
        {
            return FindValue<AgentAvailabilityTimer>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AgentAvailabilityTimer(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AgentStatusState.
    /// </summary>
    public class AgentStatusState : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for AgentStatusState
        /// </summary>
        public static readonly AgentStatusState DISABLED = new AgentStatusState("DISABLED");
        /// <summary>
        /// Constant ENABLED for AgentStatusState
        /// </summary>
        public static readonly AgentStatusState ENABLED = new AgentStatusState("ENABLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AgentStatusState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AgentStatusState FindValue(string value)
        {
            return FindValue<AgentStatusState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AgentStatusState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AgentStatusType.
    /// </summary>
    public class AgentStatusType : ConstantClass
    {

        /// <summary>
        /// Constant CUSTOM for AgentStatusType
        /// </summary>
        public static readonly AgentStatusType CUSTOM = new AgentStatusType("CUSTOM");
        /// <summary>
        /// Constant OFFLINE for AgentStatusType
        /// </summary>
        public static readonly AgentStatusType OFFLINE = new AgentStatusType("OFFLINE");
        /// <summary>
        /// Constant ROUTABLE for AgentStatusType
        /// </summary>
        public static readonly AgentStatusType ROUTABLE = new AgentStatusType("ROUTABLE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AgentStatusType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AgentStatusType FindValue(string value)
        {
            return FindValue<AgentStatusType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AgentStatusType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AnsweringMachineDetectionStatus.
    /// </summary>
    public class AnsweringMachineDetectionStatus : ConstantClass
    {

        /// <summary>
        /// Constant AMD_ERROR for AnsweringMachineDetectionStatus
        /// </summary>
        public static readonly AnsweringMachineDetectionStatus AMD_ERROR = new AnsweringMachineDetectionStatus("AMD_ERROR");
        /// <summary>
        /// Constant AMD_NOT_APPLICABLE for AnsweringMachineDetectionStatus
        /// </summary>
        public static readonly AnsweringMachineDetectionStatus AMD_NOT_APPLICABLE = new AnsweringMachineDetectionStatus("AMD_NOT_APPLICABLE");
        /// <summary>
        /// Constant AMD_UNANSWERED for AnsweringMachineDetectionStatus
        /// </summary>
        public static readonly AnsweringMachineDetectionStatus AMD_UNANSWERED = new AnsweringMachineDetectionStatus("AMD_UNANSWERED");
        /// <summary>
        /// Constant AMD_UNRESOLVED for AnsweringMachineDetectionStatus
        /// </summary>
        public static readonly AnsweringMachineDetectionStatus AMD_UNRESOLVED = new AnsweringMachineDetectionStatus("AMD_UNRESOLVED");
        /// <summary>
        /// Constant ANSWERED for AnsweringMachineDetectionStatus
        /// </summary>
        public static readonly AnsweringMachineDetectionStatus ANSWERED = new AnsweringMachineDetectionStatus("ANSWERED");
        /// <summary>
        /// Constant ERROR for AnsweringMachineDetectionStatus
        /// </summary>
        public static readonly AnsweringMachineDetectionStatus ERROR = new AnsweringMachineDetectionStatus("ERROR");
        /// <summary>
        /// Constant FAX_MACHINE_DETECTED for AnsweringMachineDetectionStatus
        /// </summary>
        public static readonly AnsweringMachineDetectionStatus FAX_MACHINE_DETECTED = new AnsweringMachineDetectionStatus("FAX_MACHINE_DETECTED");
        /// <summary>
        /// Constant HUMAN_ANSWERED for AnsweringMachineDetectionStatus
        /// </summary>
        public static readonly AnsweringMachineDetectionStatus HUMAN_ANSWERED = new AnsweringMachineDetectionStatus("HUMAN_ANSWERED");
        /// <summary>
        /// Constant SIT_TONE_BUSY for AnsweringMachineDetectionStatus
        /// </summary>
        public static readonly AnsweringMachineDetectionStatus SIT_TONE_BUSY = new AnsweringMachineDetectionStatus("SIT_TONE_BUSY");
        /// <summary>
        /// Constant SIT_TONE_DETECTED for AnsweringMachineDetectionStatus
        /// </summary>
        public static readonly AnsweringMachineDetectionStatus SIT_TONE_DETECTED = new AnsweringMachineDetectionStatus("SIT_TONE_DETECTED");
        /// <summary>
        /// Constant SIT_TONE_INVALID_NUMBER for AnsweringMachineDetectionStatus
        /// </summary>
        public static readonly AnsweringMachineDetectionStatus SIT_TONE_INVALID_NUMBER = new AnsweringMachineDetectionStatus("SIT_TONE_INVALID_NUMBER");
        /// <summary>
        /// Constant UNDETECTED for AnsweringMachineDetectionStatus
        /// </summary>
        public static readonly AnsweringMachineDetectionStatus UNDETECTED = new AnsweringMachineDetectionStatus("UNDETECTED");
        /// <summary>
        /// Constant VOICEMAIL_BEEP for AnsweringMachineDetectionStatus
        /// </summary>
        public static readonly AnsweringMachineDetectionStatus VOICEMAIL_BEEP = new AnsweringMachineDetectionStatus("VOICEMAIL_BEEP");
        /// <summary>
        /// Constant VOICEMAIL_NO_BEEP for AnsweringMachineDetectionStatus
        /// </summary>
        public static readonly AnsweringMachineDetectionStatus VOICEMAIL_NO_BEEP = new AnsweringMachineDetectionStatus("VOICEMAIL_NO_BEEP");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AnsweringMachineDetectionStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AnsweringMachineDetectionStatus FindValue(string value)
        {
            return FindValue<AnsweringMachineDetectionStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AnsweringMachineDetectionStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ArtifactStatus.
    /// </summary>
    public class ArtifactStatus : ConstantClass
    {

        /// <summary>
        /// Constant APPROVED for ArtifactStatus
        /// </summary>
        public static readonly ArtifactStatus APPROVED = new ArtifactStatus("APPROVED");
        /// <summary>
        /// Constant IN_PROGRESS for ArtifactStatus
        /// </summary>
        public static readonly ArtifactStatus IN_PROGRESS = new ArtifactStatus("IN_PROGRESS");
        /// <summary>
        /// Constant REJECTED for ArtifactStatus
        /// </summary>
        public static readonly ArtifactStatus REJECTED = new ArtifactStatus("REJECTED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ArtifactStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ArtifactStatus FindValue(string value)
        {
            return FindValue<ArtifactStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ArtifactStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AttachedFileInvalidRequestExceptionReason.
    /// </summary>
    public class AttachedFileInvalidRequestExceptionReason : ConstantClass
    {

        /// <summary>
        /// Constant INVALID_FILE_NAME for AttachedFileInvalidRequestExceptionReason
        /// </summary>
        public static readonly AttachedFileInvalidRequestExceptionReason INVALID_FILE_NAME = new AttachedFileInvalidRequestExceptionReason("INVALID_FILE_NAME");
        /// <summary>
        /// Constant INVALID_FILE_SIZE for AttachedFileInvalidRequestExceptionReason
        /// </summary>
        public static readonly AttachedFileInvalidRequestExceptionReason INVALID_FILE_SIZE = new AttachedFileInvalidRequestExceptionReason("INVALID_FILE_SIZE");
        /// <summary>
        /// Constant INVALID_FILE_TYPE for AttachedFileInvalidRequestExceptionReason
        /// </summary>
        public static readonly AttachedFileInvalidRequestExceptionReason INVALID_FILE_TYPE = new AttachedFileInvalidRequestExceptionReason("INVALID_FILE_TYPE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AttachedFileInvalidRequestExceptionReason(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AttachedFileInvalidRequestExceptionReason FindValue(string value)
        {
            return FindValue<AttachedFileInvalidRequestExceptionReason>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AttachedFileInvalidRequestExceptionReason(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AttachedFileServiceQuotaExceededExceptionReason.
    /// </summary>
    public class AttachedFileServiceQuotaExceededExceptionReason : ConstantClass
    {

        /// <summary>
        /// Constant TOTAL_FILE_COUNT_EXCEEDED for AttachedFileServiceQuotaExceededExceptionReason
        /// </summary>
        public static readonly AttachedFileServiceQuotaExceededExceptionReason TOTAL_FILE_COUNT_EXCEEDED = new AttachedFileServiceQuotaExceededExceptionReason("TOTAL_FILE_COUNT_EXCEEDED");
        /// <summary>
        /// Constant TOTAL_FILE_SIZE_EXCEEDED for AttachedFileServiceQuotaExceededExceptionReason
        /// </summary>
        public static readonly AttachedFileServiceQuotaExceededExceptionReason TOTAL_FILE_SIZE_EXCEEDED = new AttachedFileServiceQuotaExceededExceptionReason("TOTAL_FILE_SIZE_EXCEEDED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AttachedFileServiceQuotaExceededExceptionReason(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AttachedFileServiceQuotaExceededExceptionReason FindValue(string value)
        {
            return FindValue<AttachedFileServiceQuotaExceededExceptionReason>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AttachedFileServiceQuotaExceededExceptionReason(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type BehaviorType.
    /// </summary>
    public class BehaviorType : ConstantClass
    {

        /// <summary>
        /// Constant ROUTE_ANY_CHANNEL for BehaviorType
        /// </summary>
        public static readonly BehaviorType ROUTE_ANY_CHANNEL = new BehaviorType("ROUTE_ANY_CHANNEL");
        /// <summary>
        /// Constant ROUTE_CURRENT_CHANNEL_ONLY for BehaviorType
        /// </summary>
        public static readonly BehaviorType ROUTE_CURRENT_CHANNEL_ONLY = new BehaviorType("ROUTE_CURRENT_CHANNEL_ONLY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public BehaviorType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static BehaviorType FindValue(string value)
        {
            return FindValue<BehaviorType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator BehaviorType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Channel.
    /// </summary>
    public class Channel : ConstantClass
    {

        /// <summary>
        /// Constant CHAT for Channel
        /// </summary>
        public static readonly Channel CHAT = new Channel("CHAT");
        /// <summary>
        /// Constant EMAIL for Channel
        /// </summary>
        public static readonly Channel EMAIL = new Channel("EMAIL");
        /// <summary>
        /// Constant TASK for Channel
        /// </summary>
        public static readonly Channel TASK = new Channel("TASK");
        /// <summary>
        /// Constant VOICE for Channel
        /// </summary>
        public static readonly Channel VOICE = new Channel("VOICE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Channel(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Channel FindValue(string value)
        {
            return FindValue<Channel>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Channel(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ChatEventType.
    /// </summary>
    public class ChatEventType : ConstantClass
    {

        /// <summary>
        /// Constant DISCONNECT for ChatEventType
        /// </summary>
        public static readonly ChatEventType DISCONNECT = new ChatEventType("DISCONNECT");
        /// <summary>
        /// Constant EVENT for ChatEventType
        /// </summary>
        public static readonly ChatEventType EVENT = new ChatEventType("EVENT");
        /// <summary>
        /// Constant MESSAGE for ChatEventType
        /// </summary>
        public static readonly ChatEventType MESSAGE = new ChatEventType("MESSAGE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ChatEventType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ChatEventType FindValue(string value)
        {
            return FindValue<ChatEventType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ChatEventType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Comparison.
    /// </summary>
    public class Comparison : ConstantClass
    {

        /// <summary>
        /// Constant LT for Comparison
        /// </summary>
        public static readonly Comparison LT = new Comparison("LT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Comparison(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Comparison FindValue(string value)
        {
            return FindValue<Comparison>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Comparison(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ContactFlowModuleState.
    /// </summary>
    public class ContactFlowModuleState : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for ContactFlowModuleState
        /// </summary>
        public static readonly ContactFlowModuleState ACTIVE = new ContactFlowModuleState("ACTIVE");
        /// <summary>
        /// Constant ARCHIVED for ContactFlowModuleState
        /// </summary>
        public static readonly ContactFlowModuleState ARCHIVED = new ContactFlowModuleState("ARCHIVED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ContactFlowModuleState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ContactFlowModuleState FindValue(string value)
        {
            return FindValue<ContactFlowModuleState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ContactFlowModuleState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ContactFlowModuleStatus.
    /// </summary>
    public class ContactFlowModuleStatus : ConstantClass
    {

        /// <summary>
        /// Constant PUBLISHED for ContactFlowModuleStatus
        /// </summary>
        public static readonly ContactFlowModuleStatus PUBLISHED = new ContactFlowModuleStatus("PUBLISHED");
        /// <summary>
        /// Constant SAVED for ContactFlowModuleStatus
        /// </summary>
        public static readonly ContactFlowModuleStatus SAVED = new ContactFlowModuleStatus("SAVED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ContactFlowModuleStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ContactFlowModuleStatus FindValue(string value)
        {
            return FindValue<ContactFlowModuleStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ContactFlowModuleStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ContactFlowState.
    /// </summary>
    public class ContactFlowState : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for ContactFlowState
        /// </summary>
        public static readonly ContactFlowState ACTIVE = new ContactFlowState("ACTIVE");
        /// <summary>
        /// Constant ARCHIVED for ContactFlowState
        /// </summary>
        public static readonly ContactFlowState ARCHIVED = new ContactFlowState("ARCHIVED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ContactFlowState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ContactFlowState FindValue(string value)
        {
            return FindValue<ContactFlowState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ContactFlowState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ContactFlowStatus.
    /// </summary>
    public class ContactFlowStatus : ConstantClass
    {

        /// <summary>
        /// Constant PUBLISHED for ContactFlowStatus
        /// </summary>
        public static readonly ContactFlowStatus PUBLISHED = new ContactFlowStatus("PUBLISHED");
        /// <summary>
        /// Constant SAVED for ContactFlowStatus
        /// </summary>
        public static readonly ContactFlowStatus SAVED = new ContactFlowStatus("SAVED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ContactFlowStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ContactFlowStatus FindValue(string value)
        {
            return FindValue<ContactFlowStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ContactFlowStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ContactFlowType.
    /// </summary>
    public class ContactFlowType : ConstantClass
    {

        /// <summary>
        /// Constant AGENT_HOLD for ContactFlowType
        /// </summary>
        public static readonly ContactFlowType AGENT_HOLD = new ContactFlowType("AGENT_HOLD");
        /// <summary>
        /// Constant AGENT_TRANSFER for ContactFlowType
        /// </summary>
        public static readonly ContactFlowType AGENT_TRANSFER = new ContactFlowType("AGENT_TRANSFER");
        /// <summary>
        /// Constant AGENT_WHISPER for ContactFlowType
        /// </summary>
        public static readonly ContactFlowType AGENT_WHISPER = new ContactFlowType("AGENT_WHISPER");
        /// <summary>
        /// Constant CAMPAIGN for ContactFlowType
        /// </summary>
        public static readonly ContactFlowType CAMPAIGN = new ContactFlowType("CAMPAIGN");
        /// <summary>
        /// Constant CONTACT_FLOW for ContactFlowType
        /// </summary>
        public static readonly ContactFlowType CONTACT_FLOW = new ContactFlowType("CONTACT_FLOW");
        /// <summary>
        /// Constant CUSTOMER_HOLD for ContactFlowType
        /// </summary>
        public static readonly ContactFlowType CUSTOMER_HOLD = new ContactFlowType("CUSTOMER_HOLD");
        /// <summary>
        /// Constant CUSTOMER_QUEUE for ContactFlowType
        /// </summary>
        public static readonly ContactFlowType CUSTOMER_QUEUE = new ContactFlowType("CUSTOMER_QUEUE");
        /// <summary>
        /// Constant CUSTOMER_WHISPER for ContactFlowType
        /// </summary>
        public static readonly ContactFlowType CUSTOMER_WHISPER = new ContactFlowType("CUSTOMER_WHISPER");
        /// <summary>
        /// Constant OUTBOUND_WHISPER for ContactFlowType
        /// </summary>
        public static readonly ContactFlowType OUTBOUND_WHISPER = new ContactFlowType("OUTBOUND_WHISPER");
        /// <summary>
        /// Constant QUEUE_TRANSFER for ContactFlowType
        /// </summary>
        public static readonly ContactFlowType QUEUE_TRANSFER = new ContactFlowType("QUEUE_TRANSFER");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ContactFlowType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ContactFlowType FindValue(string value)
        {
            return FindValue<ContactFlowType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ContactFlowType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ContactInitiationMethod.
    /// </summary>
    public class ContactInitiationMethod : ConstantClass
    {

        /// <summary>
        /// Constant AGENT_REPLY for ContactInitiationMethod
        /// </summary>
        public static readonly ContactInitiationMethod AGENT_REPLY = new ContactInitiationMethod("AGENT_REPLY");
        /// <summary>
        /// Constant API for ContactInitiationMethod
        /// </summary>
        public static readonly ContactInitiationMethod API = new ContactInitiationMethod("API");
        /// <summary>
        /// Constant CALLBACK for ContactInitiationMethod
        /// </summary>
        public static readonly ContactInitiationMethod CALLBACK = new ContactInitiationMethod("CALLBACK");
        /// <summary>
        /// Constant DISCONNECT for ContactInitiationMethod
        /// </summary>
        public static readonly ContactInitiationMethod DISCONNECT = new ContactInitiationMethod("DISCONNECT");
        /// <summary>
        /// Constant EXTERNAL_OUTBOUND for ContactInitiationMethod
        /// </summary>
        public static readonly ContactInitiationMethod EXTERNAL_OUTBOUND = new ContactInitiationMethod("EXTERNAL_OUTBOUND");
        /// <summary>
        /// Constant FLOW for ContactInitiationMethod
        /// </summary>
        public static readonly ContactInitiationMethod FLOW = new ContactInitiationMethod("FLOW");
        /// <summary>
        /// Constant INBOUND for ContactInitiationMethod
        /// </summary>
        public static readonly ContactInitiationMethod INBOUND = new ContactInitiationMethod("INBOUND");
        /// <summary>
        /// Constant MONITOR for ContactInitiationMethod
        /// </summary>
        public static readonly ContactInitiationMethod MONITOR = new ContactInitiationMethod("MONITOR");
        /// <summary>
        /// Constant OUTBOUND for ContactInitiationMethod
        /// </summary>
        public static readonly ContactInitiationMethod OUTBOUND = new ContactInitiationMethod("OUTBOUND");
        /// <summary>
        /// Constant QUEUE_TRANSFER for ContactInitiationMethod
        /// </summary>
        public static readonly ContactInitiationMethod QUEUE_TRANSFER = new ContactInitiationMethod("QUEUE_TRANSFER");
        /// <summary>
        /// Constant TRANSFER for ContactInitiationMethod
        /// </summary>
        public static readonly ContactInitiationMethod TRANSFER = new ContactInitiationMethod("TRANSFER");
        /// <summary>
        /// Constant WEBRTC_API for ContactInitiationMethod
        /// </summary>
        public static readonly ContactInitiationMethod WEBRTC_API = new ContactInitiationMethod("WEBRTC_API");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ContactInitiationMethod(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ContactInitiationMethod FindValue(string value)
        {
            return FindValue<ContactInitiationMethod>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ContactInitiationMethod(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ContactMetricName.
    /// </summary>
    public class ContactMetricName : ConstantClass
    {

        /// <summary>
        /// Constant POSITION_IN_QUEUE for ContactMetricName
        /// </summary>
        public static readonly ContactMetricName POSITION_IN_QUEUE = new ContactMetricName("POSITION_IN_QUEUE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ContactMetricName(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ContactMetricName FindValue(string value)
        {
            return FindValue<ContactMetricName>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ContactMetricName(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ContactRecordingType.
    /// </summary>
    public class ContactRecordingType : ConstantClass
    {

        /// <summary>
        /// Constant AGENT for ContactRecordingType
        /// </summary>
        public static readonly ContactRecordingType AGENT = new ContactRecordingType("AGENT");
        /// <summary>
        /// Constant IVR for ContactRecordingType
        /// </summary>
        public static readonly ContactRecordingType IVR = new ContactRecordingType("IVR");
        /// <summary>
        /// Constant SCREEN for ContactRecordingType
        /// </summary>
        public static readonly ContactRecordingType SCREEN = new ContactRecordingType("SCREEN");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ContactRecordingType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ContactRecordingType FindValue(string value)
        {
            return FindValue<ContactRecordingType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ContactRecordingType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ContactState.
    /// </summary>
    public class ContactState : ConstantClass
    {

        /// <summary>
        /// Constant CONNECTED for ContactState
        /// </summary>
        public static readonly ContactState CONNECTED = new ContactState("CONNECTED");
        /// <summary>
        /// Constant CONNECTED_ONHOLD for ContactState
        /// </summary>
        public static readonly ContactState CONNECTED_ONHOLD = new ContactState("CONNECTED_ONHOLD");
        /// <summary>
        /// Constant CONNECTING for ContactState
        /// </summary>
        public static readonly ContactState CONNECTING = new ContactState("CONNECTING");
        /// <summary>
        /// Constant ENDED for ContactState
        /// </summary>
        public static readonly ContactState ENDED = new ContactState("ENDED");
        /// <summary>
        /// Constant ERROR for ContactState
        /// </summary>
        public static readonly ContactState ERROR = new ContactState("ERROR");
        /// <summary>
        /// Constant INCOMING for ContactState
        /// </summary>
        public static readonly ContactState INCOMING = new ContactState("INCOMING");
        /// <summary>
        /// Constant MISSED for ContactState
        /// </summary>
        public static readonly ContactState MISSED = new ContactState("MISSED");
        /// <summary>
        /// Constant PENDING for ContactState
        /// </summary>
        public static readonly ContactState PENDING = new ContactState("PENDING");
        /// <summary>
        /// Constant REJECTED for ContactState
        /// </summary>
        public static readonly ContactState REJECTED = new ContactState("REJECTED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ContactState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ContactState FindValue(string value)
        {
            return FindValue<ContactState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ContactState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CurrentMetricName.
    /// </summary>
    public class CurrentMetricName : ConstantClass
    {

        /// <summary>
        /// Constant AGENTS_AFTER_CONTACT_WORK for CurrentMetricName
        /// </summary>
        public static readonly CurrentMetricName AGENTS_AFTER_CONTACT_WORK = new CurrentMetricName("AGENTS_AFTER_CONTACT_WORK");
        /// <summary>
        /// Constant AGENTS_AVAILABLE for CurrentMetricName
        /// </summary>
        public static readonly CurrentMetricName AGENTS_AVAILABLE = new CurrentMetricName("AGENTS_AVAILABLE");
        /// <summary>
        /// Constant AGENTS_ERROR for CurrentMetricName
        /// </summary>
        public static readonly CurrentMetricName AGENTS_ERROR = new CurrentMetricName("AGENTS_ERROR");
        /// <summary>
        /// Constant AGENTS_NON_PRODUCTIVE for CurrentMetricName
        /// </summary>
        public static readonly CurrentMetricName AGENTS_NON_PRODUCTIVE = new CurrentMetricName("AGENTS_NON_PRODUCTIVE");
        /// <summary>
        /// Constant AGENTS_ON_CALL for CurrentMetricName
        /// </summary>
        public static readonly CurrentMetricName AGENTS_ON_CALL = new CurrentMetricName("AGENTS_ON_CALL");
        /// <summary>
        /// Constant AGENTS_ON_CONTACT for CurrentMetricName
        /// </summary>
        public static readonly CurrentMetricName AGENTS_ON_CONTACT = new CurrentMetricName("AGENTS_ON_CONTACT");
        /// <summary>
        /// Constant AGENTS_ONLINE for CurrentMetricName
        /// </summary>
        public static readonly CurrentMetricName AGENTS_ONLINE = new CurrentMetricName("AGENTS_ONLINE");
        /// <summary>
        /// Constant AGENTS_STAFFED for CurrentMetricName
        /// </summary>
        public static readonly CurrentMetricName AGENTS_STAFFED = new CurrentMetricName("AGENTS_STAFFED");
        /// <summary>
        /// Constant CONTACTS_IN_QUEUE for CurrentMetricName
        /// </summary>
        public static readonly CurrentMetricName CONTACTS_IN_QUEUE = new CurrentMetricName("CONTACTS_IN_QUEUE");
        /// <summary>
        /// Constant CONTACTS_SCHEDULED for CurrentMetricName
        /// </summary>
        public static readonly CurrentMetricName CONTACTS_SCHEDULED = new CurrentMetricName("CONTACTS_SCHEDULED");
        /// <summary>
        /// Constant OLDEST_CONTACT_AGE for CurrentMetricName
        /// </summary>
        public static readonly CurrentMetricName OLDEST_CONTACT_AGE = new CurrentMetricName("OLDEST_CONTACT_AGE");
        /// <summary>
        /// Constant SLOTS_ACTIVE for CurrentMetricName
        /// </summary>
        public static readonly CurrentMetricName SLOTS_ACTIVE = new CurrentMetricName("SLOTS_ACTIVE");
        /// <summary>
        /// Constant SLOTS_AVAILABLE for CurrentMetricName
        /// </summary>
        public static readonly CurrentMetricName SLOTS_AVAILABLE = new CurrentMetricName("SLOTS_AVAILABLE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CurrentMetricName(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CurrentMetricName FindValue(string value)
        {
            return FindValue<CurrentMetricName>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CurrentMetricName(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DateComparisonType.
    /// </summary>
    public class DateComparisonType : ConstantClass
    {

        /// <summary>
        /// Constant EQUAL_TO for DateComparisonType
        /// </summary>
        public static readonly DateComparisonType EQUAL_TO = new DateComparisonType("EQUAL_TO");
        /// <summary>
        /// Constant GREATER_THAN for DateComparisonType
        /// </summary>
        public static readonly DateComparisonType GREATER_THAN = new DateComparisonType("GREATER_THAN");
        /// <summary>
        /// Constant GREATER_THAN_OR_EQUAL_TO for DateComparisonType
        /// </summary>
        public static readonly DateComparisonType GREATER_THAN_OR_EQUAL_TO = new DateComparisonType("GREATER_THAN_OR_EQUAL_TO");
        /// <summary>
        /// Constant LESS_THAN for DateComparisonType
        /// </summary>
        public static readonly DateComparisonType LESS_THAN = new DateComparisonType("LESS_THAN");
        /// <summary>
        /// Constant LESS_THAN_OR_EQUAL_TO for DateComparisonType
        /// </summary>
        public static readonly DateComparisonType LESS_THAN_OR_EQUAL_TO = new DateComparisonType("LESS_THAN_OR_EQUAL_TO");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DateComparisonType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DateComparisonType FindValue(string value)
        {
            return FindValue<DateComparisonType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DateComparisonType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DeviceType.
    /// </summary>
    public class DeviceType : ConstantClass
    {

        /// <summary>
        /// Constant APNS for DeviceType
        /// </summary>
        public static readonly DeviceType APNS = new DeviceType("APNS");
        /// <summary>
        /// Constant APNS_SANDBOX for DeviceType
        /// </summary>
        public static readonly DeviceType APNS_SANDBOX = new DeviceType("APNS_SANDBOX");
        /// <summary>
        /// Constant GCM for DeviceType
        /// </summary>
        public static readonly DeviceType GCM = new DeviceType("GCM");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DeviceType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DeviceType FindValue(string value)
        {
            return FindValue<DeviceType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DeviceType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DirectoryType.
    /// </summary>
    public class DirectoryType : ConstantClass
    {

        /// <summary>
        /// Constant CONNECT_MANAGED for DirectoryType
        /// </summary>
        public static readonly DirectoryType CONNECT_MANAGED = new DirectoryType("CONNECT_MANAGED");
        /// <summary>
        /// Constant EXISTING_DIRECTORY for DirectoryType
        /// </summary>
        public static readonly DirectoryType EXISTING_DIRECTORY = new DirectoryType("EXISTING_DIRECTORY");
        /// <summary>
        /// Constant SAML for DirectoryType
        /// </summary>
        public static readonly DirectoryType SAML = new DirectoryType("SAML");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DirectoryType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DirectoryType FindValue(string value)
        {
            return FindValue<DirectoryType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DirectoryType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type EmailHeaderType.
    /// </summary>
    public class EmailHeaderType : ConstantClass
    {

        /// <summary>
        /// Constant IN_REPLY_TO for EmailHeaderType
        /// </summary>
        public static readonly EmailHeaderType IN_REPLY_TO = new EmailHeaderType("IN_REPLY_TO");
        /// <summary>
        /// Constant MESSAGE_ID for EmailHeaderType
        /// </summary>
        public static readonly EmailHeaderType MESSAGE_ID = new EmailHeaderType("MESSAGE_ID");
        /// <summary>
        /// Constant REFERENCES for EmailHeaderType
        /// </summary>
        public static readonly EmailHeaderType REFERENCES = new EmailHeaderType("REFERENCES");
        /// <summary>
        /// Constant X_SES_SPAM_VERDICT for EmailHeaderType
        /// </summary>
        public static readonly EmailHeaderType X_SES_SPAM_VERDICT = new EmailHeaderType("X_SES_SPAM_VERDICT");
        /// <summary>
        /// Constant X_SES_VIRUS_VERDICT for EmailHeaderType
        /// </summary>
        public static readonly EmailHeaderType X_SES_VIRUS_VERDICT = new EmailHeaderType("X_SES_VIRUS_VERDICT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EmailHeaderType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EmailHeaderType FindValue(string value)
        {
            return FindValue<EmailHeaderType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EmailHeaderType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type EncryptionType.
    /// </summary>
    public class EncryptionType : ConstantClass
    {

        /// <summary>
        /// Constant KMS for EncryptionType
        /// </summary>
        public static readonly EncryptionType KMS = new EncryptionType("KMS");

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
    /// Constants used for properties of type EndpointType.
    /// </summary>
    public class EndpointType : ConstantClass
    {

        /// <summary>
        /// Constant CONNECT_PHONENUMBER_ARN for EndpointType
        /// </summary>
        public static readonly EndpointType CONNECT_PHONENUMBER_ARN = new EndpointType("CONNECT_PHONENUMBER_ARN");
        /// <summary>
        /// Constant CONTACT_FLOW for EndpointType
        /// </summary>
        public static readonly EndpointType CONTACT_FLOW = new EndpointType("CONTACT_FLOW");
        /// <summary>
        /// Constant EMAIL_ADDRESS for EndpointType
        /// </summary>
        public static readonly EndpointType EMAIL_ADDRESS = new EndpointType("EMAIL_ADDRESS");
        /// <summary>
        /// Constant TELEPHONE_NUMBER for EndpointType
        /// </summary>
        public static readonly EndpointType TELEPHONE_NUMBER = new EndpointType("TELEPHONE_NUMBER");
        /// <summary>
        /// Constant VOIP for EndpointType
        /// </summary>
        public static readonly EndpointType VOIP = new EndpointType("VOIP");

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
    /// Constants used for properties of type EvaluationFormQuestionType.
    /// </summary>
    public class EvaluationFormQuestionType : ConstantClass
    {

        /// <summary>
        /// Constant NUMERIC for EvaluationFormQuestionType
        /// </summary>
        public static readonly EvaluationFormQuestionType NUMERIC = new EvaluationFormQuestionType("NUMERIC");
        /// <summary>
        /// Constant SINGLESELECT for EvaluationFormQuestionType
        /// </summary>
        public static readonly EvaluationFormQuestionType SINGLESELECT = new EvaluationFormQuestionType("SINGLESELECT");
        /// <summary>
        /// Constant TEXT for EvaluationFormQuestionType
        /// </summary>
        public static readonly EvaluationFormQuestionType TEXT = new EvaluationFormQuestionType("TEXT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EvaluationFormQuestionType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EvaluationFormQuestionType FindValue(string value)
        {
            return FindValue<EvaluationFormQuestionType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EvaluationFormQuestionType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type EvaluationFormScoringMode.
    /// </summary>
    public class EvaluationFormScoringMode : ConstantClass
    {

        /// <summary>
        /// Constant QUESTION_ONLY for EvaluationFormScoringMode
        /// </summary>
        public static readonly EvaluationFormScoringMode QUESTION_ONLY = new EvaluationFormScoringMode("QUESTION_ONLY");
        /// <summary>
        /// Constant SECTION_ONLY for EvaluationFormScoringMode
        /// </summary>
        public static readonly EvaluationFormScoringMode SECTION_ONLY = new EvaluationFormScoringMode("SECTION_ONLY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EvaluationFormScoringMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EvaluationFormScoringMode FindValue(string value)
        {
            return FindValue<EvaluationFormScoringMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EvaluationFormScoringMode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type EvaluationFormScoringStatus.
    /// </summary>
    public class EvaluationFormScoringStatus : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for EvaluationFormScoringStatus
        /// </summary>
        public static readonly EvaluationFormScoringStatus DISABLED = new EvaluationFormScoringStatus("DISABLED");
        /// <summary>
        /// Constant ENABLED for EvaluationFormScoringStatus
        /// </summary>
        public static readonly EvaluationFormScoringStatus ENABLED = new EvaluationFormScoringStatus("ENABLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EvaluationFormScoringStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EvaluationFormScoringStatus FindValue(string value)
        {
            return FindValue<EvaluationFormScoringStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EvaluationFormScoringStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type EvaluationFormSingleSelectQuestionDisplayMode.
    /// </summary>
    public class EvaluationFormSingleSelectQuestionDisplayMode : ConstantClass
    {

        /// <summary>
        /// Constant DROPDOWN for EvaluationFormSingleSelectQuestionDisplayMode
        /// </summary>
        public static readonly EvaluationFormSingleSelectQuestionDisplayMode DROPDOWN = new EvaluationFormSingleSelectQuestionDisplayMode("DROPDOWN");
        /// <summary>
        /// Constant RADIO for EvaluationFormSingleSelectQuestionDisplayMode
        /// </summary>
        public static readonly EvaluationFormSingleSelectQuestionDisplayMode RADIO = new EvaluationFormSingleSelectQuestionDisplayMode("RADIO");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EvaluationFormSingleSelectQuestionDisplayMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EvaluationFormSingleSelectQuestionDisplayMode FindValue(string value)
        {
            return FindValue<EvaluationFormSingleSelectQuestionDisplayMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EvaluationFormSingleSelectQuestionDisplayMode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type EvaluationFormVersionStatus.
    /// </summary>
    public class EvaluationFormVersionStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for EvaluationFormVersionStatus
        /// </summary>
        public static readonly EvaluationFormVersionStatus ACTIVE = new EvaluationFormVersionStatus("ACTIVE");
        /// <summary>
        /// Constant DRAFT for EvaluationFormVersionStatus
        /// </summary>
        public static readonly EvaluationFormVersionStatus DRAFT = new EvaluationFormVersionStatus("DRAFT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EvaluationFormVersionStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EvaluationFormVersionStatus FindValue(string value)
        {
            return FindValue<EvaluationFormVersionStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EvaluationFormVersionStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type EvaluationStatus.
    /// </summary>
    public class EvaluationStatus : ConstantClass
    {

        /// <summary>
        /// Constant DRAFT for EvaluationStatus
        /// </summary>
        public static readonly EvaluationStatus DRAFT = new EvaluationStatus("DRAFT");
        /// <summary>
        /// Constant SUBMITTED for EvaluationStatus
        /// </summary>
        public static readonly EvaluationStatus SUBMITTED = new EvaluationStatus("SUBMITTED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EvaluationStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EvaluationStatus FindValue(string value)
        {
            return FindValue<EvaluationStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EvaluationStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type EventSourceName.
    /// </summary>
    public class EventSourceName : ConstantClass
    {

        /// <summary>
        /// Constant OnCaseCreate for EventSourceName
        /// </summary>
        public static readonly EventSourceName OnCaseCreate = new EventSourceName("OnCaseCreate");
        /// <summary>
        /// Constant OnCaseUpdate for EventSourceName
        /// </summary>
        public static readonly EventSourceName OnCaseUpdate = new EventSourceName("OnCaseUpdate");
        /// <summary>
        /// Constant OnContactEvaluationSubmit for EventSourceName
        /// </summary>
        public static readonly EventSourceName OnContactEvaluationSubmit = new EventSourceName("OnContactEvaluationSubmit");
        /// <summary>
        /// Constant OnMetricDataUpdate for EventSourceName
        /// </summary>
        public static readonly EventSourceName OnMetricDataUpdate = new EventSourceName("OnMetricDataUpdate");
        /// <summary>
        /// Constant OnPostCallAnalysisAvailable for EventSourceName
        /// </summary>
        public static readonly EventSourceName OnPostCallAnalysisAvailable = new EventSourceName("OnPostCallAnalysisAvailable");
        /// <summary>
        /// Constant OnPostChatAnalysisAvailable for EventSourceName
        /// </summary>
        public static readonly EventSourceName OnPostChatAnalysisAvailable = new EventSourceName("OnPostChatAnalysisAvailable");
        /// <summary>
        /// Constant OnRealTimeCallAnalysisAvailable for EventSourceName
        /// </summary>
        public static readonly EventSourceName OnRealTimeCallAnalysisAvailable = new EventSourceName("OnRealTimeCallAnalysisAvailable");
        /// <summary>
        /// Constant OnRealTimeChatAnalysisAvailable for EventSourceName
        /// </summary>
        public static readonly EventSourceName OnRealTimeChatAnalysisAvailable = new EventSourceName("OnRealTimeChatAnalysisAvailable");
        /// <summary>
        /// Constant OnSalesforceCaseCreate for EventSourceName
        /// </summary>
        public static readonly EventSourceName OnSalesforceCaseCreate = new EventSourceName("OnSalesforceCaseCreate");
        /// <summary>
        /// Constant OnSlaBreach for EventSourceName
        /// </summary>
        public static readonly EventSourceName OnSlaBreach = new EventSourceName("OnSlaBreach");
        /// <summary>
        /// Constant OnZendeskTicketCreate for EventSourceName
        /// </summary>
        public static readonly EventSourceName OnZendeskTicketCreate = new EventSourceName("OnZendeskTicketCreate");
        /// <summary>
        /// Constant OnZendeskTicketStatusUpdate for EventSourceName
        /// </summary>
        public static readonly EventSourceName OnZendeskTicketStatusUpdate = new EventSourceName("OnZendeskTicketStatusUpdate");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EventSourceName(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EventSourceName FindValue(string value)
        {
            return FindValue<EventSourceName>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EventSourceName(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type FailureReasonCode.
    /// </summary>
    public class FailureReasonCode : ConstantClass
    {

        /// <summary>
        /// Constant IDEMPOTENCY_EXCEPTION for FailureReasonCode
        /// </summary>
        public static readonly FailureReasonCode IDEMPOTENCY_EXCEPTION = new FailureReasonCode("IDEMPOTENCY_EXCEPTION");
        /// <summary>
        /// Constant INTERNAL_ERROR for FailureReasonCode
        /// </summary>
        public static readonly FailureReasonCode INTERNAL_ERROR = new FailureReasonCode("INTERNAL_ERROR");
        /// <summary>
        /// Constant INVALID_ATTRIBUTE_KEY for FailureReasonCode
        /// </summary>
        public static readonly FailureReasonCode INVALID_ATTRIBUTE_KEY = new FailureReasonCode("INVALID_ATTRIBUTE_KEY");
        /// <summary>
        /// Constant INVALID_CUSTOMER_ENDPOINT for FailureReasonCode
        /// </summary>
        public static readonly FailureReasonCode INVALID_CUSTOMER_ENDPOINT = new FailureReasonCode("INVALID_CUSTOMER_ENDPOINT");
        /// <summary>
        /// Constant INVALID_QUEUE for FailureReasonCode
        /// </summary>
        public static readonly FailureReasonCode INVALID_QUEUE = new FailureReasonCode("INVALID_QUEUE");
        /// <summary>
        /// Constant INVALID_SYSTEM_ENDPOINT for FailureReasonCode
        /// </summary>
        public static readonly FailureReasonCode INVALID_SYSTEM_ENDPOINT = new FailureReasonCode("INVALID_SYSTEM_ENDPOINT");
        /// <summary>
        /// Constant MISSING_CAMPAIGN for FailureReasonCode
        /// </summary>
        public static readonly FailureReasonCode MISSING_CAMPAIGN = new FailureReasonCode("MISSING_CAMPAIGN");
        /// <summary>
        /// Constant MISSING_CUSTOMER_ENDPOINT for FailureReasonCode
        /// </summary>
        public static readonly FailureReasonCode MISSING_CUSTOMER_ENDPOINT = new FailureReasonCode("MISSING_CUSTOMER_ENDPOINT");
        /// <summary>
        /// Constant MISSING_QUEUE_ID_AND_SYSTEM_ENDPOINT for FailureReasonCode
        /// </summary>
        public static readonly FailureReasonCode MISSING_QUEUE_ID_AND_SYSTEM_ENDPOINT = new FailureReasonCode("MISSING_QUEUE_ID_AND_SYSTEM_ENDPOINT");
        /// <summary>
        /// Constant REQUEST_THROTTLED for FailureReasonCode
        /// </summary>
        public static readonly FailureReasonCode REQUEST_THROTTLED = new FailureReasonCode("REQUEST_THROTTLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FailureReasonCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FailureReasonCode FindValue(string value)
        {
            return FindValue<FailureReasonCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FailureReasonCode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type FileStatusType.
    /// </summary>
    public class FileStatusType : ConstantClass
    {

        /// <summary>
        /// Constant APPROVED for FileStatusType
        /// </summary>
        public static readonly FileStatusType APPROVED = new FileStatusType("APPROVED");
        /// <summary>
        /// Constant FAILED for FileStatusType
        /// </summary>
        public static readonly FileStatusType FAILED = new FileStatusType("FAILED");
        /// <summary>
        /// Constant PROCESSING for FileStatusType
        /// </summary>
        public static readonly FileStatusType PROCESSING = new FileStatusType("PROCESSING");
        /// <summary>
        /// Constant REJECTED for FileStatusType
        /// </summary>
        public static readonly FileStatusType REJECTED = new FileStatusType("REJECTED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FileStatusType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FileStatusType FindValue(string value)
        {
            return FindValue<FileStatusType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FileStatusType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type FileUseCaseType.
    /// </summary>
    public class FileUseCaseType : ConstantClass
    {

        /// <summary>
        /// Constant ATTACHMENT for FileUseCaseType
        /// </summary>
        public static readonly FileUseCaseType ATTACHMENT = new FileUseCaseType("ATTACHMENT");
        /// <summary>
        /// Constant EMAIL_MESSAGE for FileUseCaseType
        /// </summary>
        public static readonly FileUseCaseType EMAIL_MESSAGE = new FileUseCaseType("EMAIL_MESSAGE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FileUseCaseType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FileUseCaseType FindValue(string value)
        {
            return FindValue<FileUseCaseType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FileUseCaseType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type FlowAssociationResourceType.
    /// </summary>
    public class FlowAssociationResourceType : ConstantClass
    {

        /// <summary>
        /// Constant ANALYTICS_CONNECTOR for FlowAssociationResourceType
        /// </summary>
        public static readonly FlowAssociationResourceType ANALYTICS_CONNECTOR = new FlowAssociationResourceType("ANALYTICS_CONNECTOR");
        /// <summary>
        /// Constant INBOUND_EMAIL for FlowAssociationResourceType
        /// </summary>
        public static readonly FlowAssociationResourceType INBOUND_EMAIL = new FlowAssociationResourceType("INBOUND_EMAIL");
        /// <summary>
        /// Constant OUTBOUND_EMAIL for FlowAssociationResourceType
        /// </summary>
        public static readonly FlowAssociationResourceType OUTBOUND_EMAIL = new FlowAssociationResourceType("OUTBOUND_EMAIL");
        /// <summary>
        /// Constant SMS_PHONE_NUMBER for FlowAssociationResourceType
        /// </summary>
        public static readonly FlowAssociationResourceType SMS_PHONE_NUMBER = new FlowAssociationResourceType("SMS_PHONE_NUMBER");
        /// <summary>
        /// Constant WHATSAPP_MESSAGING_PHONE_NUMBER for FlowAssociationResourceType
        /// </summary>
        public static readonly FlowAssociationResourceType WHATSAPP_MESSAGING_PHONE_NUMBER = new FlowAssociationResourceType("WHATSAPP_MESSAGING_PHONE_NUMBER");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FlowAssociationResourceType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FlowAssociationResourceType FindValue(string value)
        {
            return FindValue<FlowAssociationResourceType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FlowAssociationResourceType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Grouping.
    /// </summary>
    public class Grouping : ConstantClass
    {

        /// <summary>
        /// Constant AGENT_STATUS for Grouping
        /// </summary>
        public static readonly Grouping AGENT_STATUS = new Grouping("AGENT_STATUS");
        /// <summary>
        /// Constant CHANNEL for Grouping
        /// </summary>
        public static readonly Grouping CHANNEL = new Grouping("CHANNEL");
        /// <summary>
        /// Constant QUEUE for Grouping
        /// </summary>
        public static readonly Grouping QUEUE = new Grouping("QUEUE");
        /// <summary>
        /// Constant ROUTING_PROFILE for Grouping
        /// </summary>
        public static readonly Grouping ROUTING_PROFILE = new Grouping("ROUTING_PROFILE");
        /// <summary>
        /// Constant ROUTING_STEP_EXPRESSION for Grouping
        /// </summary>
        public static readonly Grouping ROUTING_STEP_EXPRESSION = new Grouping("ROUTING_STEP_EXPRESSION");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Grouping(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Grouping FindValue(string value)
        {
            return FindValue<Grouping>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Grouping(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type HierarchyGroupMatchType.
    /// </summary>
    public class HierarchyGroupMatchType : ConstantClass
    {

        /// <summary>
        /// Constant EXACT for HierarchyGroupMatchType
        /// </summary>
        public static readonly HierarchyGroupMatchType EXACT = new HierarchyGroupMatchType("EXACT");
        /// <summary>
        /// Constant WITH_CHILD_GROUPS for HierarchyGroupMatchType
        /// </summary>
        public static readonly HierarchyGroupMatchType WITH_CHILD_GROUPS = new HierarchyGroupMatchType("WITH_CHILD_GROUPS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public HierarchyGroupMatchType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static HierarchyGroupMatchType FindValue(string value)
        {
            return FindValue<HierarchyGroupMatchType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator HierarchyGroupMatchType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type HistoricalMetricName.
    /// </summary>
    public class HistoricalMetricName : ConstantClass
    {

        /// <summary>
        /// Constant ABANDON_TIME for HistoricalMetricName
        /// </summary>
        public static readonly HistoricalMetricName ABANDON_TIME = new HistoricalMetricName("ABANDON_TIME");
        /// <summary>
        /// Constant AFTER_CONTACT_WORK_TIME for HistoricalMetricName
        /// </summary>
        public static readonly HistoricalMetricName AFTER_CONTACT_WORK_TIME = new HistoricalMetricName("AFTER_CONTACT_WORK_TIME");
        /// <summary>
        /// Constant API_CONTACTS_HANDLED for HistoricalMetricName
        /// </summary>
        public static readonly HistoricalMetricName API_CONTACTS_HANDLED = new HistoricalMetricName("API_CONTACTS_HANDLED");
        /// <summary>
        /// Constant CALLBACK_CONTACTS_HANDLED for HistoricalMetricName
        /// </summary>
        public static readonly HistoricalMetricName CALLBACK_CONTACTS_HANDLED = new HistoricalMetricName("CALLBACK_CONTACTS_HANDLED");
        /// <summary>
        /// Constant CONTACTS_ABANDONED for HistoricalMetricName
        /// </summary>
        public static readonly HistoricalMetricName CONTACTS_ABANDONED = new HistoricalMetricName("CONTACTS_ABANDONED");
        /// <summary>
        /// Constant CONTACTS_AGENT_HUNG_UP_FIRST for HistoricalMetricName
        /// </summary>
        public static readonly HistoricalMetricName CONTACTS_AGENT_HUNG_UP_FIRST = new HistoricalMetricName("CONTACTS_AGENT_HUNG_UP_FIRST");
        /// <summary>
        /// Constant CONTACTS_CONSULTED for HistoricalMetricName
        /// </summary>
        public static readonly HistoricalMetricName CONTACTS_CONSULTED = new HistoricalMetricName("CONTACTS_CONSULTED");
        /// <summary>
        /// Constant CONTACTS_HANDLED for HistoricalMetricName
        /// </summary>
        public static readonly HistoricalMetricName CONTACTS_HANDLED = new HistoricalMetricName("CONTACTS_HANDLED");
        /// <summary>
        /// Constant CONTACTS_HANDLED_INCOMING for HistoricalMetricName
        /// </summary>
        public static readonly HistoricalMetricName CONTACTS_HANDLED_INCOMING = new HistoricalMetricName("CONTACTS_HANDLED_INCOMING");
        /// <summary>
        /// Constant CONTACTS_HANDLED_OUTBOUND for HistoricalMetricName
        /// </summary>
        public static readonly HistoricalMetricName CONTACTS_HANDLED_OUTBOUND = new HistoricalMetricName("CONTACTS_HANDLED_OUTBOUND");
        /// <summary>
        /// Constant CONTACTS_HOLD_ABANDONS for HistoricalMetricName
        /// </summary>
        public static readonly HistoricalMetricName CONTACTS_HOLD_ABANDONS = new HistoricalMetricName("CONTACTS_HOLD_ABANDONS");
        /// <summary>
        /// Constant CONTACTS_MISSED for HistoricalMetricName
        /// </summary>
        public static readonly HistoricalMetricName CONTACTS_MISSED = new HistoricalMetricName("CONTACTS_MISSED");
        /// <summary>
        /// Constant CONTACTS_QUEUED for HistoricalMetricName
        /// </summary>
        public static readonly HistoricalMetricName CONTACTS_QUEUED = new HistoricalMetricName("CONTACTS_QUEUED");
        /// <summary>
        /// Constant CONTACTS_TRANSFERRED_IN for HistoricalMetricName
        /// </summary>
        public static readonly HistoricalMetricName CONTACTS_TRANSFERRED_IN = new HistoricalMetricName("CONTACTS_TRANSFERRED_IN");
        /// <summary>
        /// Constant CONTACTS_TRANSFERRED_IN_FROM_QUEUE for HistoricalMetricName
        /// </summary>
        public static readonly HistoricalMetricName CONTACTS_TRANSFERRED_IN_FROM_QUEUE = new HistoricalMetricName("CONTACTS_TRANSFERRED_IN_FROM_QUEUE");
        /// <summary>
        /// Constant CONTACTS_TRANSFERRED_OUT for HistoricalMetricName
        /// </summary>
        public static readonly HistoricalMetricName CONTACTS_TRANSFERRED_OUT = new HistoricalMetricName("CONTACTS_TRANSFERRED_OUT");
        /// <summary>
        /// Constant CONTACTS_TRANSFERRED_OUT_FROM_QUEUE for HistoricalMetricName
        /// </summary>
        public static readonly HistoricalMetricName CONTACTS_TRANSFERRED_OUT_FROM_QUEUE = new HistoricalMetricName("CONTACTS_TRANSFERRED_OUT_FROM_QUEUE");
        /// <summary>
        /// Constant HANDLE_TIME for HistoricalMetricName
        /// </summary>
        public static readonly HistoricalMetricName HANDLE_TIME = new HistoricalMetricName("HANDLE_TIME");
        /// <summary>
        /// Constant HOLD_TIME for HistoricalMetricName
        /// </summary>
        public static readonly HistoricalMetricName HOLD_TIME = new HistoricalMetricName("HOLD_TIME");
        /// <summary>
        /// Constant INTERACTION_AND_HOLD_TIME for HistoricalMetricName
        /// </summary>
        public static readonly HistoricalMetricName INTERACTION_AND_HOLD_TIME = new HistoricalMetricName("INTERACTION_AND_HOLD_TIME");
        /// <summary>
        /// Constant INTERACTION_TIME for HistoricalMetricName
        /// </summary>
        public static readonly HistoricalMetricName INTERACTION_TIME = new HistoricalMetricName("INTERACTION_TIME");
        /// <summary>
        /// Constant OCCUPANCY for HistoricalMetricName
        /// </summary>
        public static readonly HistoricalMetricName OCCUPANCY = new HistoricalMetricName("OCCUPANCY");
        /// <summary>
        /// Constant QUEUE_ANSWER_TIME for HistoricalMetricName
        /// </summary>
        public static readonly HistoricalMetricName QUEUE_ANSWER_TIME = new HistoricalMetricName("QUEUE_ANSWER_TIME");
        /// <summary>
        /// Constant QUEUED_TIME for HistoricalMetricName
        /// </summary>
        public static readonly HistoricalMetricName QUEUED_TIME = new HistoricalMetricName("QUEUED_TIME");
        /// <summary>
        /// Constant SERVICE_LEVEL for HistoricalMetricName
        /// </summary>
        public static readonly HistoricalMetricName SERVICE_LEVEL = new HistoricalMetricName("SERVICE_LEVEL");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public HistoricalMetricName(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static HistoricalMetricName FindValue(string value)
        {
            return FindValue<HistoricalMetricName>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator HistoricalMetricName(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type HoursOfOperationDays.
    /// </summary>
    public class HoursOfOperationDays : ConstantClass
    {

        /// <summary>
        /// Constant FRIDAY for HoursOfOperationDays
        /// </summary>
        public static readonly HoursOfOperationDays FRIDAY = new HoursOfOperationDays("FRIDAY");
        /// <summary>
        /// Constant MONDAY for HoursOfOperationDays
        /// </summary>
        public static readonly HoursOfOperationDays MONDAY = new HoursOfOperationDays("MONDAY");
        /// <summary>
        /// Constant SATURDAY for HoursOfOperationDays
        /// </summary>
        public static readonly HoursOfOperationDays SATURDAY = new HoursOfOperationDays("SATURDAY");
        /// <summary>
        /// Constant SUNDAY for HoursOfOperationDays
        /// </summary>
        public static readonly HoursOfOperationDays SUNDAY = new HoursOfOperationDays("SUNDAY");
        /// <summary>
        /// Constant THURSDAY for HoursOfOperationDays
        /// </summary>
        public static readonly HoursOfOperationDays THURSDAY = new HoursOfOperationDays("THURSDAY");
        /// <summary>
        /// Constant TUESDAY for HoursOfOperationDays
        /// </summary>
        public static readonly HoursOfOperationDays TUESDAY = new HoursOfOperationDays("TUESDAY");
        /// <summary>
        /// Constant WEDNESDAY for HoursOfOperationDays
        /// </summary>
        public static readonly HoursOfOperationDays WEDNESDAY = new HoursOfOperationDays("WEDNESDAY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public HoursOfOperationDays(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static HoursOfOperationDays FindValue(string value)
        {
            return FindValue<HoursOfOperationDays>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator HoursOfOperationDays(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type InboundMessageSourceType.
    /// </summary>
    public class InboundMessageSourceType : ConstantClass
    {

        /// <summary>
        /// Constant RAW for InboundMessageSourceType
        /// </summary>
        public static readonly InboundMessageSourceType RAW = new InboundMessageSourceType("RAW");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public InboundMessageSourceType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static InboundMessageSourceType FindValue(string value)
        {
            return FindValue<InboundMessageSourceType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator InboundMessageSourceType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type InitiateAs.
    /// </summary>
    public class InitiateAs : ConstantClass
    {

        /// <summary>
        /// Constant COMPLETED for InitiateAs
        /// </summary>
        public static readonly InitiateAs COMPLETED = new InitiateAs("COMPLETED");
        /// <summary>
        /// Constant CONNECTED_TO_USER for InitiateAs
        /// </summary>
        public static readonly InitiateAs CONNECTED_TO_USER = new InitiateAs("CONNECTED_TO_USER");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public InitiateAs(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static InitiateAs FindValue(string value)
        {
            return FindValue<InitiateAs>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator InitiateAs(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type InstanceAttributeType.
    /// </summary>
    public class InstanceAttributeType : ConstantClass
    {

        /// <summary>
        /// Constant AUTO_RESOLVE_BEST_VOICES for InstanceAttributeType
        /// </summary>
        public static readonly InstanceAttributeType AUTO_RESOLVE_BEST_VOICES = new InstanceAttributeType("AUTO_RESOLVE_BEST_VOICES");
        /// <summary>
        /// Constant CONTACT_LENS for InstanceAttributeType
        /// </summary>
        public static readonly InstanceAttributeType CONTACT_LENS = new InstanceAttributeType("CONTACT_LENS");
        /// <summary>
        /// Constant CONTACTFLOW_LOGS for InstanceAttributeType
        /// </summary>
        public static readonly InstanceAttributeType CONTACTFLOW_LOGS = new InstanceAttributeType("CONTACTFLOW_LOGS");
        /// <summary>
        /// Constant EARLY_MEDIA for InstanceAttributeType
        /// </summary>
        public static readonly InstanceAttributeType EARLY_MEDIA = new InstanceAttributeType("EARLY_MEDIA");
        /// <summary>
        /// Constant ENHANCED_CHAT_MONITORING for InstanceAttributeType
        /// </summary>
        public static readonly InstanceAttributeType ENHANCED_CHAT_MONITORING = new InstanceAttributeType("ENHANCED_CHAT_MONITORING");
        /// <summary>
        /// Constant ENHANCED_CONTACT_MONITORING for InstanceAttributeType
        /// </summary>
        public static readonly InstanceAttributeType ENHANCED_CONTACT_MONITORING = new InstanceAttributeType("ENHANCED_CONTACT_MONITORING");
        /// <summary>
        /// Constant HIGH_VOLUME_OUTBOUND for InstanceAttributeType
        /// </summary>
        public static readonly InstanceAttributeType HIGH_VOLUME_OUTBOUND = new InstanceAttributeType("HIGH_VOLUME_OUTBOUND");
        /// <summary>
        /// Constant INBOUND_CALLS for InstanceAttributeType
        /// </summary>
        public static readonly InstanceAttributeType INBOUND_CALLS = new InstanceAttributeType("INBOUND_CALLS");
        /// <summary>
        /// Constant MULTI_PARTY_CHAT_CONFERENCE for InstanceAttributeType
        /// </summary>
        public static readonly InstanceAttributeType MULTI_PARTY_CHAT_CONFERENCE = new InstanceAttributeType("MULTI_PARTY_CHAT_CONFERENCE");
        /// <summary>
        /// Constant MULTI_PARTY_CONFERENCE for InstanceAttributeType
        /// </summary>
        public static readonly InstanceAttributeType MULTI_PARTY_CONFERENCE = new InstanceAttributeType("MULTI_PARTY_CONFERENCE");
        /// <summary>
        /// Constant OUTBOUND_CALLS for InstanceAttributeType
        /// </summary>
        public static readonly InstanceAttributeType OUTBOUND_CALLS = new InstanceAttributeType("OUTBOUND_CALLS");
        /// <summary>
        /// Constant USE_CUSTOM_TTS_VOICES for InstanceAttributeType
        /// </summary>
        public static readonly InstanceAttributeType USE_CUSTOM_TTS_VOICES = new InstanceAttributeType("USE_CUSTOM_TTS_VOICES");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public InstanceAttributeType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static InstanceAttributeType FindValue(string value)
        {
            return FindValue<InstanceAttributeType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator InstanceAttributeType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type InstanceReplicationStatus.
    /// </summary>
    public class InstanceReplicationStatus : ConstantClass
    {

        /// <summary>
        /// Constant INSTANCE_REPLICA_DELETING for InstanceReplicationStatus
        /// </summary>
        public static readonly InstanceReplicationStatus INSTANCE_REPLICA_DELETING = new InstanceReplicationStatus("INSTANCE_REPLICA_DELETING");
        /// <summary>
        /// Constant INSTANCE_REPLICATION_COMPLETE for InstanceReplicationStatus
        /// </summary>
        public static readonly InstanceReplicationStatus INSTANCE_REPLICATION_COMPLETE = new InstanceReplicationStatus("INSTANCE_REPLICATION_COMPLETE");
        /// <summary>
        /// Constant INSTANCE_REPLICATION_DELETION_FAILED for InstanceReplicationStatus
        /// </summary>
        public static readonly InstanceReplicationStatus INSTANCE_REPLICATION_DELETION_FAILED = new InstanceReplicationStatus("INSTANCE_REPLICATION_DELETION_FAILED");
        /// <summary>
        /// Constant INSTANCE_REPLICATION_FAILED for InstanceReplicationStatus
        /// </summary>
        public static readonly InstanceReplicationStatus INSTANCE_REPLICATION_FAILED = new InstanceReplicationStatus("INSTANCE_REPLICATION_FAILED");
        /// <summary>
        /// Constant INSTANCE_REPLICATION_IN_PROGRESS for InstanceReplicationStatus
        /// </summary>
        public static readonly InstanceReplicationStatus INSTANCE_REPLICATION_IN_PROGRESS = new InstanceReplicationStatus("INSTANCE_REPLICATION_IN_PROGRESS");
        /// <summary>
        /// Constant RESOURCE_REPLICATION_NOT_STARTED for InstanceReplicationStatus
        /// </summary>
        public static readonly InstanceReplicationStatus RESOURCE_REPLICATION_NOT_STARTED = new InstanceReplicationStatus("RESOURCE_REPLICATION_NOT_STARTED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public InstanceReplicationStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static InstanceReplicationStatus FindValue(string value)
        {
            return FindValue<InstanceReplicationStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator InstanceReplicationStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type InstanceStatus.
    /// </summary>
    public class InstanceStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for InstanceStatus
        /// </summary>
        public static readonly InstanceStatus ACTIVE = new InstanceStatus("ACTIVE");
        /// <summary>
        /// Constant CREATION_FAILED for InstanceStatus
        /// </summary>
        public static readonly InstanceStatus CREATION_FAILED = new InstanceStatus("CREATION_FAILED");
        /// <summary>
        /// Constant CREATION_IN_PROGRESS for InstanceStatus
        /// </summary>
        public static readonly InstanceStatus CREATION_IN_PROGRESS = new InstanceStatus("CREATION_IN_PROGRESS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public InstanceStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static InstanceStatus FindValue(string value)
        {
            return FindValue<InstanceStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator InstanceStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type InstanceStorageResourceType.
    /// </summary>
    public class InstanceStorageResourceType : ConstantClass
    {

        /// <summary>
        /// Constant AGENT_EVENTS for InstanceStorageResourceType
        /// </summary>
        public static readonly InstanceStorageResourceType AGENT_EVENTS = new InstanceStorageResourceType("AGENT_EVENTS");
        /// <summary>
        /// Constant ATTACHMENTS for InstanceStorageResourceType
        /// </summary>
        public static readonly InstanceStorageResourceType ATTACHMENTS = new InstanceStorageResourceType("ATTACHMENTS");
        /// <summary>
        /// Constant CALL_RECORDINGS for InstanceStorageResourceType
        /// </summary>
        public static readonly InstanceStorageResourceType CALL_RECORDINGS = new InstanceStorageResourceType("CALL_RECORDINGS");
        /// <summary>
        /// Constant CHAT_TRANSCRIPTS for InstanceStorageResourceType
        /// </summary>
        public static readonly InstanceStorageResourceType CHAT_TRANSCRIPTS = new InstanceStorageResourceType("CHAT_TRANSCRIPTS");
        /// <summary>
        /// Constant CONTACT_EVALUATIONS for InstanceStorageResourceType
        /// </summary>
        public static readonly InstanceStorageResourceType CONTACT_EVALUATIONS = new InstanceStorageResourceType("CONTACT_EVALUATIONS");
        /// <summary>
        /// Constant CONTACT_TRACE_RECORDS for InstanceStorageResourceType
        /// </summary>
        public static readonly InstanceStorageResourceType CONTACT_TRACE_RECORDS = new InstanceStorageResourceType("CONTACT_TRACE_RECORDS");
        /// <summary>
        /// Constant EMAIL_MESSAGES for InstanceStorageResourceType
        /// </summary>
        public static readonly InstanceStorageResourceType EMAIL_MESSAGES = new InstanceStorageResourceType("EMAIL_MESSAGES");
        /// <summary>
        /// Constant MEDIA_STREAMS for InstanceStorageResourceType
        /// </summary>
        public static readonly InstanceStorageResourceType MEDIA_STREAMS = new InstanceStorageResourceType("MEDIA_STREAMS");
        /// <summary>
        /// Constant REAL_TIME_CONTACT_ANALYSIS_CHAT_SEGMENTS for InstanceStorageResourceType
        /// </summary>
        public static readonly InstanceStorageResourceType REAL_TIME_CONTACT_ANALYSIS_CHAT_SEGMENTS = new InstanceStorageResourceType("REAL_TIME_CONTACT_ANALYSIS_CHAT_SEGMENTS");
        /// <summary>
        /// Constant REAL_TIME_CONTACT_ANALYSIS_SEGMENTS for InstanceStorageResourceType
        /// </summary>
        public static readonly InstanceStorageResourceType REAL_TIME_CONTACT_ANALYSIS_SEGMENTS = new InstanceStorageResourceType("REAL_TIME_CONTACT_ANALYSIS_SEGMENTS");
        /// <summary>
        /// Constant REAL_TIME_CONTACT_ANALYSIS_VOICE_SEGMENTS for InstanceStorageResourceType
        /// </summary>
        public static readonly InstanceStorageResourceType REAL_TIME_CONTACT_ANALYSIS_VOICE_SEGMENTS = new InstanceStorageResourceType("REAL_TIME_CONTACT_ANALYSIS_VOICE_SEGMENTS");
        /// <summary>
        /// Constant SCHEDULED_REPORTS for InstanceStorageResourceType
        /// </summary>
        public static readonly InstanceStorageResourceType SCHEDULED_REPORTS = new InstanceStorageResourceType("SCHEDULED_REPORTS");
        /// <summary>
        /// Constant SCREEN_RECORDINGS for InstanceStorageResourceType
        /// </summary>
        public static readonly InstanceStorageResourceType SCREEN_RECORDINGS = new InstanceStorageResourceType("SCREEN_RECORDINGS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public InstanceStorageResourceType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static InstanceStorageResourceType FindValue(string value)
        {
            return FindValue<InstanceStorageResourceType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator InstanceStorageResourceType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type IntegrationType.
    /// </summary>
    public class IntegrationType : ConstantClass
    {

        /// <summary>
        /// Constant ANALYTICS_CONNECTOR for IntegrationType
        /// </summary>
        public static readonly IntegrationType ANALYTICS_CONNECTOR = new IntegrationType("ANALYTICS_CONNECTOR");
        /// <summary>
        /// Constant APPLICATION for IntegrationType
        /// </summary>
        public static readonly IntegrationType APPLICATION = new IntegrationType("APPLICATION");
        /// <summary>
        /// Constant CALL_TRANSFER_CONNECTOR for IntegrationType
        /// </summary>
        public static readonly IntegrationType CALL_TRANSFER_CONNECTOR = new IntegrationType("CALL_TRANSFER_CONNECTOR");
        /// <summary>
        /// Constant CASES_DOMAIN for IntegrationType
        /// </summary>
        public static readonly IntegrationType CASES_DOMAIN = new IntegrationType("CASES_DOMAIN");
        /// <summary>
        /// Constant COGNITO_USER_POOL for IntegrationType
        /// </summary>
        public static readonly IntegrationType COGNITO_USER_POOL = new IntegrationType("COGNITO_USER_POOL");
        /// <summary>
        /// Constant EVENT for IntegrationType
        /// </summary>
        public static readonly IntegrationType EVENT = new IntegrationType("EVENT");
        /// <summary>
        /// Constant FILE_SCANNER for IntegrationType
        /// </summary>
        public static readonly IntegrationType FILE_SCANNER = new IntegrationType("FILE_SCANNER");
        /// <summary>
        /// Constant PINPOINT_APP for IntegrationType
        /// </summary>
        public static readonly IntegrationType PINPOINT_APP = new IntegrationType("PINPOINT_APP");
        /// <summary>
        /// Constant Q_MESSAGE_TEMPLATES for IntegrationType
        /// </summary>
        public static readonly IntegrationType Q_MESSAGE_TEMPLATES = new IntegrationType("Q_MESSAGE_TEMPLATES");
        /// <summary>
        /// Constant SES_IDENTITY for IntegrationType
        /// </summary>
        public static readonly IntegrationType SES_IDENTITY = new IntegrationType("SES_IDENTITY");
        /// <summary>
        /// Constant VOICE_ID for IntegrationType
        /// </summary>
        public static readonly IntegrationType VOICE_ID = new IntegrationType("VOICE_ID");
        /// <summary>
        /// Constant WISDOM_ASSISTANT for IntegrationType
        /// </summary>
        public static readonly IntegrationType WISDOM_ASSISTANT = new IntegrationType("WISDOM_ASSISTANT");
        /// <summary>
        /// Constant WISDOM_KNOWLEDGE_BASE for IntegrationType
        /// </summary>
        public static readonly IntegrationType WISDOM_KNOWLEDGE_BASE = new IntegrationType("WISDOM_KNOWLEDGE_BASE");
        /// <summary>
        /// Constant WISDOM_QUICK_RESPONSES for IntegrationType
        /// </summary>
        public static readonly IntegrationType WISDOM_QUICK_RESPONSES = new IntegrationType("WISDOM_QUICK_RESPONSES");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public IntegrationType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static IntegrationType FindValue(string value)
        {
            return FindValue<IntegrationType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator IntegrationType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type IntervalPeriod.
    /// </summary>
    public class IntervalPeriod : ConstantClass
    {

        /// <summary>
        /// Constant DAY for IntervalPeriod
        /// </summary>
        public static readonly IntervalPeriod DAY = new IntervalPeriod("DAY");
        /// <summary>
        /// Constant FIFTEEN_MIN for IntervalPeriod
        /// </summary>
        public static readonly IntervalPeriod FIFTEEN_MIN = new IntervalPeriod("FIFTEEN_MIN");
        /// <summary>
        /// Constant HOUR for IntervalPeriod
        /// </summary>
        public static readonly IntervalPeriod HOUR = new IntervalPeriod("HOUR");
        /// <summary>
        /// Constant THIRTY_MIN for IntervalPeriod
        /// </summary>
        public static readonly IntervalPeriod THIRTY_MIN = new IntervalPeriod("THIRTY_MIN");
        /// <summary>
        /// Constant TOTAL for IntervalPeriod
        /// </summary>
        public static readonly IntervalPeriod TOTAL = new IntervalPeriod("TOTAL");
        /// <summary>
        /// Constant WEEK for IntervalPeriod
        /// </summary>
        public static readonly IntervalPeriod WEEK = new IntervalPeriod("WEEK");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public IntervalPeriod(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static IntervalPeriod FindValue(string value)
        {
            return FindValue<IntervalPeriod>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator IntervalPeriod(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type IvrRecordingTrack.
    /// </summary>
    public class IvrRecordingTrack : ConstantClass
    {

        /// <summary>
        /// Constant ALL for IvrRecordingTrack
        /// </summary>
        public static readonly IvrRecordingTrack ALL = new IvrRecordingTrack("ALL");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public IvrRecordingTrack(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static IvrRecordingTrack FindValue(string value)
        {
            return FindValue<IvrRecordingTrack>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator IvrRecordingTrack(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type LexVersion.
    /// </summary>
    public class LexVersion : ConstantClass
    {

        /// <summary>
        /// Constant V1 for LexVersion
        /// </summary>
        public static readonly LexVersion V1 = new LexVersion("V1");
        /// <summary>
        /// Constant V2 for LexVersion
        /// </summary>
        public static readonly LexVersion V2 = new LexVersion("V2");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public LexVersion(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LexVersion FindValue(string value)
        {
            return FindValue<LexVersion>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator LexVersion(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ListFlowAssociationResourceType.
    /// </summary>
    public class ListFlowAssociationResourceType : ConstantClass
    {

        /// <summary>
        /// Constant ANALYTICS_CONNECTOR for ListFlowAssociationResourceType
        /// </summary>
        public static readonly ListFlowAssociationResourceType ANALYTICS_CONNECTOR = new ListFlowAssociationResourceType("ANALYTICS_CONNECTOR");
        /// <summary>
        /// Constant INBOUND_EMAIL for ListFlowAssociationResourceType
        /// </summary>
        public static readonly ListFlowAssociationResourceType INBOUND_EMAIL = new ListFlowAssociationResourceType("INBOUND_EMAIL");
        /// <summary>
        /// Constant OUTBOUND_EMAIL for ListFlowAssociationResourceType
        /// </summary>
        public static readonly ListFlowAssociationResourceType OUTBOUND_EMAIL = new ListFlowAssociationResourceType("OUTBOUND_EMAIL");
        /// <summary>
        /// Constant VOICE_PHONE_NUMBER for ListFlowAssociationResourceType
        /// </summary>
        public static readonly ListFlowAssociationResourceType VOICE_PHONE_NUMBER = new ListFlowAssociationResourceType("VOICE_PHONE_NUMBER");
        /// <summary>
        /// Constant WHATSAPP_MESSAGING_PHONE_NUMBER for ListFlowAssociationResourceType
        /// </summary>
        public static readonly ListFlowAssociationResourceType WHATSAPP_MESSAGING_PHONE_NUMBER = new ListFlowAssociationResourceType("WHATSAPP_MESSAGING_PHONE_NUMBER");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ListFlowAssociationResourceType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ListFlowAssociationResourceType FindValue(string value)
        {
            return FindValue<ListFlowAssociationResourceType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ListFlowAssociationResourceType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type MediaStreamType.
    /// </summary>
    public class MediaStreamType : ConstantClass
    {

        /// <summary>
        /// Constant AUDIO for MediaStreamType
        /// </summary>
        public static readonly MediaStreamType AUDIO = new MediaStreamType("AUDIO");
        /// <summary>
        /// Constant VIDEO for MediaStreamType
        /// </summary>
        public static readonly MediaStreamType VIDEO = new MediaStreamType("VIDEO");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MediaStreamType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MediaStreamType FindValue(string value)
        {
            return FindValue<MediaStreamType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MediaStreamType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type MeetingFeatureStatus.
    /// </summary>
    public class MeetingFeatureStatus : ConstantClass
    {

        /// <summary>
        /// Constant AVAILABLE for MeetingFeatureStatus
        /// </summary>
        public static readonly MeetingFeatureStatus AVAILABLE = new MeetingFeatureStatus("AVAILABLE");
        /// <summary>
        /// Constant UNAVAILABLE for MeetingFeatureStatus
        /// </summary>
        public static readonly MeetingFeatureStatus UNAVAILABLE = new MeetingFeatureStatus("UNAVAILABLE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MeetingFeatureStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MeetingFeatureStatus FindValue(string value)
        {
            return FindValue<MeetingFeatureStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MeetingFeatureStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type MonitorCapability.
    /// </summary>
    public class MonitorCapability : ConstantClass
    {

        /// <summary>
        /// Constant BARGE for MonitorCapability
        /// </summary>
        public static readonly MonitorCapability BARGE = new MonitorCapability("BARGE");
        /// <summary>
        /// Constant SILENT_MONITOR for MonitorCapability
        /// </summary>
        public static readonly MonitorCapability SILENT_MONITOR = new MonitorCapability("SILENT_MONITOR");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MonitorCapability(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MonitorCapability FindValue(string value)
        {
            return FindValue<MonitorCapability>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MonitorCapability(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type NotificationContentType.
    /// </summary>
    public class NotificationContentType : ConstantClass
    {

        /// <summary>
        /// Constant PLAIN_TEXT for NotificationContentType
        /// </summary>
        public static readonly NotificationContentType PLAIN_TEXT = new NotificationContentType("PLAIN_TEXT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public NotificationContentType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static NotificationContentType FindValue(string value)
        {
            return FindValue<NotificationContentType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator NotificationContentType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type NotificationDeliveryType.
    /// </summary>
    public class NotificationDeliveryType : ConstantClass
    {

        /// <summary>
        /// Constant EMAIL for NotificationDeliveryType
        /// </summary>
        public static readonly NotificationDeliveryType EMAIL = new NotificationDeliveryType("EMAIL");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public NotificationDeliveryType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static NotificationDeliveryType FindValue(string value)
        {
            return FindValue<NotificationDeliveryType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator NotificationDeliveryType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type NumberComparisonType.
    /// </summary>
    public class NumberComparisonType : ConstantClass
    {

        /// <summary>
        /// Constant EQUAL for NumberComparisonType
        /// </summary>
        public static readonly NumberComparisonType EQUAL = new NumberComparisonType("EQUAL");
        /// <summary>
        /// Constant GREATER for NumberComparisonType
        /// </summary>
        public static readonly NumberComparisonType GREATER = new NumberComparisonType("GREATER");
        /// <summary>
        /// Constant GREATER_OR_EQUAL for NumberComparisonType
        /// </summary>
        public static readonly NumberComparisonType GREATER_OR_EQUAL = new NumberComparisonType("GREATER_OR_EQUAL");
        /// <summary>
        /// Constant LESSER for NumberComparisonType
        /// </summary>
        public static readonly NumberComparisonType LESSER = new NumberComparisonType("LESSER");
        /// <summary>
        /// Constant LESSER_OR_EQUAL for NumberComparisonType
        /// </summary>
        public static readonly NumberComparisonType LESSER_OR_EQUAL = new NumberComparisonType("LESSER_OR_EQUAL");
        /// <summary>
        /// Constant NOT_EQUAL for NumberComparisonType
        /// </summary>
        public static readonly NumberComparisonType NOT_EQUAL = new NumberComparisonType("NOT_EQUAL");
        /// <summary>
        /// Constant RANGE for NumberComparisonType
        /// </summary>
        public static readonly NumberComparisonType RANGE = new NumberComparisonType("RANGE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public NumberComparisonType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static NumberComparisonType FindValue(string value)
        {
            return FindValue<NumberComparisonType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator NumberComparisonType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type NumericQuestionPropertyAutomationLabel.
    /// </summary>
    public class NumericQuestionPropertyAutomationLabel : ConstantClass
    {

        /// <summary>
        /// Constant AGENT_INTERACTION_DURATION for NumericQuestionPropertyAutomationLabel
        /// </summary>
        public static readonly NumericQuestionPropertyAutomationLabel AGENT_INTERACTION_DURATION = new NumericQuestionPropertyAutomationLabel("AGENT_INTERACTION_DURATION");
        /// <summary>
        /// Constant CONTACT_DURATION for NumericQuestionPropertyAutomationLabel
        /// </summary>
        public static readonly NumericQuestionPropertyAutomationLabel CONTACT_DURATION = new NumericQuestionPropertyAutomationLabel("CONTACT_DURATION");
        /// <summary>
        /// Constant CUSTOMER_HOLD_TIME for NumericQuestionPropertyAutomationLabel
        /// </summary>
        public static readonly NumericQuestionPropertyAutomationLabel CUSTOMER_HOLD_TIME = new NumericQuestionPropertyAutomationLabel("CUSTOMER_HOLD_TIME");
        /// <summary>
        /// Constant NON_TALK_TIME for NumericQuestionPropertyAutomationLabel
        /// </summary>
        public static readonly NumericQuestionPropertyAutomationLabel NON_TALK_TIME = new NumericQuestionPropertyAutomationLabel("NON_TALK_TIME");
        /// <summary>
        /// Constant NON_TALK_TIME_PERCENTAGE for NumericQuestionPropertyAutomationLabel
        /// </summary>
        public static readonly NumericQuestionPropertyAutomationLabel NON_TALK_TIME_PERCENTAGE = new NumericQuestionPropertyAutomationLabel("NON_TALK_TIME_PERCENTAGE");
        /// <summary>
        /// Constant NUMBER_OF_INTERRUPTIONS for NumericQuestionPropertyAutomationLabel
        /// </summary>
        public static readonly NumericQuestionPropertyAutomationLabel NUMBER_OF_INTERRUPTIONS = new NumericQuestionPropertyAutomationLabel("NUMBER_OF_INTERRUPTIONS");
        /// <summary>
        /// Constant OVERALL_AGENT_SENTIMENT_SCORE for NumericQuestionPropertyAutomationLabel
        /// </summary>
        public static readonly NumericQuestionPropertyAutomationLabel OVERALL_AGENT_SENTIMENT_SCORE = new NumericQuestionPropertyAutomationLabel("OVERALL_AGENT_SENTIMENT_SCORE");
        /// <summary>
        /// Constant OVERALL_CUSTOMER_SENTIMENT_SCORE for NumericQuestionPropertyAutomationLabel
        /// </summary>
        public static readonly NumericQuestionPropertyAutomationLabel OVERALL_CUSTOMER_SENTIMENT_SCORE = new NumericQuestionPropertyAutomationLabel("OVERALL_CUSTOMER_SENTIMENT_SCORE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public NumericQuestionPropertyAutomationLabel(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static NumericQuestionPropertyAutomationLabel FindValue(string value)
        {
            return FindValue<NumericQuestionPropertyAutomationLabel>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator NumericQuestionPropertyAutomationLabel(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type OutboundMessageSourceType.
    /// </summary>
    public class OutboundMessageSourceType : ConstantClass
    {

        /// <summary>
        /// Constant RAW for OutboundMessageSourceType
        /// </summary>
        public static readonly OutboundMessageSourceType RAW = new OutboundMessageSourceType("RAW");
        /// <summary>
        /// Constant TEMPLATE for OutboundMessageSourceType
        /// </summary>
        public static readonly OutboundMessageSourceType TEMPLATE = new OutboundMessageSourceType("TEMPLATE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public OutboundMessageSourceType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static OutboundMessageSourceType FindValue(string value)
        {
            return FindValue<OutboundMessageSourceType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator OutboundMessageSourceType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type OverrideDays.
    /// </summary>
    public class OverrideDays : ConstantClass
    {

        /// <summary>
        /// Constant FRIDAY for OverrideDays
        /// </summary>
        public static readonly OverrideDays FRIDAY = new OverrideDays("FRIDAY");
        /// <summary>
        /// Constant MONDAY for OverrideDays
        /// </summary>
        public static readonly OverrideDays MONDAY = new OverrideDays("MONDAY");
        /// <summary>
        /// Constant SATURDAY for OverrideDays
        /// </summary>
        public static readonly OverrideDays SATURDAY = new OverrideDays("SATURDAY");
        /// <summary>
        /// Constant SUNDAY for OverrideDays
        /// </summary>
        public static readonly OverrideDays SUNDAY = new OverrideDays("SUNDAY");
        /// <summary>
        /// Constant THURSDAY for OverrideDays
        /// </summary>
        public static readonly OverrideDays THURSDAY = new OverrideDays("THURSDAY");
        /// <summary>
        /// Constant TUESDAY for OverrideDays
        /// </summary>
        public static readonly OverrideDays TUESDAY = new OverrideDays("TUESDAY");
        /// <summary>
        /// Constant WEDNESDAY for OverrideDays
        /// </summary>
        public static readonly OverrideDays WEDNESDAY = new OverrideDays("WEDNESDAY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public OverrideDays(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static OverrideDays FindValue(string value)
        {
            return FindValue<OverrideDays>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator OverrideDays(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ParticipantRole.
    /// </summary>
    public class ParticipantRole : ConstantClass
    {

        /// <summary>
        /// Constant AGENT for ParticipantRole
        /// </summary>
        public static readonly ParticipantRole AGENT = new ParticipantRole("AGENT");
        /// <summary>
        /// Constant CUSTOM_BOT for ParticipantRole
        /// </summary>
        public static readonly ParticipantRole CUSTOM_BOT = new ParticipantRole("CUSTOM_BOT");
        /// <summary>
        /// Constant CUSTOMER for ParticipantRole
        /// </summary>
        public static readonly ParticipantRole CUSTOMER = new ParticipantRole("CUSTOMER");
        /// <summary>
        /// Constant SUPERVISOR for ParticipantRole
        /// </summary>
        public static readonly ParticipantRole SUPERVISOR = new ParticipantRole("SUPERVISOR");
        /// <summary>
        /// Constant SYSTEM for ParticipantRole
        /// </summary>
        public static readonly ParticipantRole SYSTEM = new ParticipantRole("SYSTEM");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ParticipantRole(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ParticipantRole FindValue(string value)
        {
            return FindValue<ParticipantRole>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ParticipantRole(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ParticipantState.
    /// </summary>
    public class ParticipantState : ConstantClass
    {

        /// <summary>
        /// Constant CONNECTED for ParticipantState
        /// </summary>
        public static readonly ParticipantState CONNECTED = new ParticipantState("CONNECTED");
        /// <summary>
        /// Constant DISCONNECTED for ParticipantState
        /// </summary>
        public static readonly ParticipantState DISCONNECTED = new ParticipantState("DISCONNECTED");
        /// <summary>
        /// Constant INITIAL for ParticipantState
        /// </summary>
        public static readonly ParticipantState INITIAL = new ParticipantState("INITIAL");
        /// <summary>
        /// Constant MISSED for ParticipantState
        /// </summary>
        public static readonly ParticipantState MISSED = new ParticipantState("MISSED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ParticipantState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ParticipantState FindValue(string value)
        {
            return FindValue<ParticipantState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ParticipantState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ParticipantTimerAction.
    /// </summary>
    public class ParticipantTimerAction : ConstantClass
    {

        /// <summary>
        /// Constant Unset for ParticipantTimerAction
        /// </summary>
        public static readonly ParticipantTimerAction Unset = new ParticipantTimerAction("Unset");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ParticipantTimerAction(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ParticipantTimerAction FindValue(string value)
        {
            return FindValue<ParticipantTimerAction>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ParticipantTimerAction(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ParticipantTimerType.
    /// </summary>
    public class ParticipantTimerType : ConstantClass
    {

        /// <summary>
        /// Constant DISCONNECT_NONCUSTOMER for ParticipantTimerType
        /// </summary>
        public static readonly ParticipantTimerType DISCONNECT_NONCUSTOMER = new ParticipantTimerType("DISCONNECT_NONCUSTOMER");
        /// <summary>
        /// Constant IDLE for ParticipantTimerType
        /// </summary>
        public static readonly ParticipantTimerType IDLE = new ParticipantTimerType("IDLE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ParticipantTimerType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ParticipantTimerType FindValue(string value)
        {
            return FindValue<ParticipantTimerType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ParticipantTimerType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ParticipantType.
    /// </summary>
    public class ParticipantType : ConstantClass
    {

        /// <summary>
        /// Constant AGENT for ParticipantType
        /// </summary>
        public static readonly ParticipantType AGENT = new ParticipantType("AGENT");
        /// <summary>
        /// Constant ALL for ParticipantType
        /// </summary>
        public static readonly ParticipantType ALL = new ParticipantType("ALL");
        /// <summary>
        /// Constant CUSTOMER for ParticipantType
        /// </summary>
        public static readonly ParticipantType CUSTOMER = new ParticipantType("CUSTOMER");
        /// <summary>
        /// Constant MANAGER for ParticipantType
        /// </summary>
        public static readonly ParticipantType MANAGER = new ParticipantType("MANAGER");
        /// <summary>
        /// Constant THIRDPARTY for ParticipantType
        /// </summary>
        public static readonly ParticipantType THIRDPARTY = new ParticipantType("THIRDPARTY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ParticipantType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ParticipantType FindValue(string value)
        {
            return FindValue<ParticipantType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ParticipantType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PhoneNumberCountryCode.
    /// </summary>
    public class PhoneNumberCountryCode : ConstantClass
    {

        /// <summary>
        /// Constant AD for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode AD = new PhoneNumberCountryCode("AD");
        /// <summary>
        /// Constant AE for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode AE = new PhoneNumberCountryCode("AE");
        /// <summary>
        /// Constant AF for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode AF = new PhoneNumberCountryCode("AF");
        /// <summary>
        /// Constant AG for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode AG = new PhoneNumberCountryCode("AG");
        /// <summary>
        /// Constant AI for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode AI = new PhoneNumberCountryCode("AI");
        /// <summary>
        /// Constant AL for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode AL = new PhoneNumberCountryCode("AL");
        /// <summary>
        /// Constant AM for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode AM = new PhoneNumberCountryCode("AM");
        /// <summary>
        /// Constant AN for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode AN = new PhoneNumberCountryCode("AN");
        /// <summary>
        /// Constant AO for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode AO = new PhoneNumberCountryCode("AO");
        /// <summary>
        /// Constant AQ for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode AQ = new PhoneNumberCountryCode("AQ");
        /// <summary>
        /// Constant AR for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode AR = new PhoneNumberCountryCode("AR");
        /// <summary>
        /// Constant AS for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode AS = new PhoneNumberCountryCode("AS");
        /// <summary>
        /// Constant AT for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode AT = new PhoneNumberCountryCode("AT");
        /// <summary>
        /// Constant AU for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode AU = new PhoneNumberCountryCode("AU");
        /// <summary>
        /// Constant AW for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode AW = new PhoneNumberCountryCode("AW");
        /// <summary>
        /// Constant AZ for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode AZ = new PhoneNumberCountryCode("AZ");
        /// <summary>
        /// Constant BA for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode BA = new PhoneNumberCountryCode("BA");
        /// <summary>
        /// Constant BB for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode BB = new PhoneNumberCountryCode("BB");
        /// <summary>
        /// Constant BD for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode BD = new PhoneNumberCountryCode("BD");
        /// <summary>
        /// Constant BE for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode BE = new PhoneNumberCountryCode("BE");
        /// <summary>
        /// Constant BF for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode BF = new PhoneNumberCountryCode("BF");
        /// <summary>
        /// Constant BG for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode BG = new PhoneNumberCountryCode("BG");
        /// <summary>
        /// Constant BH for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode BH = new PhoneNumberCountryCode("BH");
        /// <summary>
        /// Constant BI for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode BI = new PhoneNumberCountryCode("BI");
        /// <summary>
        /// Constant BJ for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode BJ = new PhoneNumberCountryCode("BJ");
        /// <summary>
        /// Constant BL for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode BL = new PhoneNumberCountryCode("BL");
        /// <summary>
        /// Constant BM for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode BM = new PhoneNumberCountryCode("BM");
        /// <summary>
        /// Constant BN for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode BN = new PhoneNumberCountryCode("BN");
        /// <summary>
        /// Constant BO for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode BO = new PhoneNumberCountryCode("BO");
        /// <summary>
        /// Constant BR for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode BR = new PhoneNumberCountryCode("BR");
        /// <summary>
        /// Constant BS for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode BS = new PhoneNumberCountryCode("BS");
        /// <summary>
        /// Constant BT for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode BT = new PhoneNumberCountryCode("BT");
        /// <summary>
        /// Constant BW for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode BW = new PhoneNumberCountryCode("BW");
        /// <summary>
        /// Constant BY for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode BY = new PhoneNumberCountryCode("BY");
        /// <summary>
        /// Constant BZ for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode BZ = new PhoneNumberCountryCode("BZ");
        /// <summary>
        /// Constant CA for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode CA = new PhoneNumberCountryCode("CA");
        /// <summary>
        /// Constant CC for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode CC = new PhoneNumberCountryCode("CC");
        /// <summary>
        /// Constant CD for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode CD = new PhoneNumberCountryCode("CD");
        /// <summary>
        /// Constant CF for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode CF = new PhoneNumberCountryCode("CF");
        /// <summary>
        /// Constant CG for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode CG = new PhoneNumberCountryCode("CG");
        /// <summary>
        /// Constant CH for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode CH = new PhoneNumberCountryCode("CH");
        /// <summary>
        /// Constant CI for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode CI = new PhoneNumberCountryCode("CI");
        /// <summary>
        /// Constant CK for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode CK = new PhoneNumberCountryCode("CK");
        /// <summary>
        /// Constant CL for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode CL = new PhoneNumberCountryCode("CL");
        /// <summary>
        /// Constant CM for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode CM = new PhoneNumberCountryCode("CM");
        /// <summary>
        /// Constant CN for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode CN = new PhoneNumberCountryCode("CN");
        /// <summary>
        /// Constant CO for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode CO = new PhoneNumberCountryCode("CO");
        /// <summary>
        /// Constant CR for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode CR = new PhoneNumberCountryCode("CR");
        /// <summary>
        /// Constant CU for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode CU = new PhoneNumberCountryCode("CU");
        /// <summary>
        /// Constant CV for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode CV = new PhoneNumberCountryCode("CV");
        /// <summary>
        /// Constant CW for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode CW = new PhoneNumberCountryCode("CW");
        /// <summary>
        /// Constant CX for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode CX = new PhoneNumberCountryCode("CX");
        /// <summary>
        /// Constant CY for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode CY = new PhoneNumberCountryCode("CY");
        /// <summary>
        /// Constant CZ for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode CZ = new PhoneNumberCountryCode("CZ");
        /// <summary>
        /// Constant DE for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode DE = new PhoneNumberCountryCode("DE");
        /// <summary>
        /// Constant DJ for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode DJ = new PhoneNumberCountryCode("DJ");
        /// <summary>
        /// Constant DK for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode DK = new PhoneNumberCountryCode("DK");
        /// <summary>
        /// Constant DM for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode DM = new PhoneNumberCountryCode("DM");
        /// <summary>
        /// Constant DO for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode DO = new PhoneNumberCountryCode("DO");
        /// <summary>
        /// Constant DZ for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode DZ = new PhoneNumberCountryCode("DZ");
        /// <summary>
        /// Constant EC for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode EC = new PhoneNumberCountryCode("EC");
        /// <summary>
        /// Constant EE for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode EE = new PhoneNumberCountryCode("EE");
        /// <summary>
        /// Constant EG for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode EG = new PhoneNumberCountryCode("EG");
        /// <summary>
        /// Constant EH for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode EH = new PhoneNumberCountryCode("EH");
        /// <summary>
        /// Constant ER for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode ER = new PhoneNumberCountryCode("ER");
        /// <summary>
        /// Constant ES for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode ES = new PhoneNumberCountryCode("ES");
        /// <summary>
        /// Constant ET for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode ET = new PhoneNumberCountryCode("ET");
        /// <summary>
        /// Constant FI for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode FI = new PhoneNumberCountryCode("FI");
        /// <summary>
        /// Constant FJ for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode FJ = new PhoneNumberCountryCode("FJ");
        /// <summary>
        /// Constant FK for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode FK = new PhoneNumberCountryCode("FK");
        /// <summary>
        /// Constant FM for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode FM = new PhoneNumberCountryCode("FM");
        /// <summary>
        /// Constant FO for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode FO = new PhoneNumberCountryCode("FO");
        /// <summary>
        /// Constant FR for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode FR = new PhoneNumberCountryCode("FR");
        /// <summary>
        /// Constant GA for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode GA = new PhoneNumberCountryCode("GA");
        /// <summary>
        /// Constant GB for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode GB = new PhoneNumberCountryCode("GB");
        /// <summary>
        /// Constant GD for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode GD = new PhoneNumberCountryCode("GD");
        /// <summary>
        /// Constant GE for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode GE = new PhoneNumberCountryCode("GE");
        /// <summary>
        /// Constant GG for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode GG = new PhoneNumberCountryCode("GG");
        /// <summary>
        /// Constant GH for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode GH = new PhoneNumberCountryCode("GH");
        /// <summary>
        /// Constant GI for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode GI = new PhoneNumberCountryCode("GI");
        /// <summary>
        /// Constant GL for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode GL = new PhoneNumberCountryCode("GL");
        /// <summary>
        /// Constant GM for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode GM = new PhoneNumberCountryCode("GM");
        /// <summary>
        /// Constant GN for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode GN = new PhoneNumberCountryCode("GN");
        /// <summary>
        /// Constant GQ for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode GQ = new PhoneNumberCountryCode("GQ");
        /// <summary>
        /// Constant GR for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode GR = new PhoneNumberCountryCode("GR");
        /// <summary>
        /// Constant GT for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode GT = new PhoneNumberCountryCode("GT");
        /// <summary>
        /// Constant GU for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode GU = new PhoneNumberCountryCode("GU");
        /// <summary>
        /// Constant GW for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode GW = new PhoneNumberCountryCode("GW");
        /// <summary>
        /// Constant GY for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode GY = new PhoneNumberCountryCode("GY");
        /// <summary>
        /// Constant HK for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode HK = new PhoneNumberCountryCode("HK");
        /// <summary>
        /// Constant HN for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode HN = new PhoneNumberCountryCode("HN");
        /// <summary>
        /// Constant HR for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode HR = new PhoneNumberCountryCode("HR");
        /// <summary>
        /// Constant HT for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode HT = new PhoneNumberCountryCode("HT");
        /// <summary>
        /// Constant HU for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode HU = new PhoneNumberCountryCode("HU");
        /// <summary>
        /// Constant ID for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode ID = new PhoneNumberCountryCode("ID");
        /// <summary>
        /// Constant IE for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode IE = new PhoneNumberCountryCode("IE");
        /// <summary>
        /// Constant IL for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode IL = new PhoneNumberCountryCode("IL");
        /// <summary>
        /// Constant IM for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode IM = new PhoneNumberCountryCode("IM");
        /// <summary>
        /// Constant IN for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode IN = new PhoneNumberCountryCode("IN");
        /// <summary>
        /// Constant IO for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode IO = new PhoneNumberCountryCode("IO");
        /// <summary>
        /// Constant IQ for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode IQ = new PhoneNumberCountryCode("IQ");
        /// <summary>
        /// Constant IR for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode IR = new PhoneNumberCountryCode("IR");
        /// <summary>
        /// Constant IS for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode IS = new PhoneNumberCountryCode("IS");
        /// <summary>
        /// Constant IT for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode IT = new PhoneNumberCountryCode("IT");
        /// <summary>
        /// Constant JE for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode JE = new PhoneNumberCountryCode("JE");
        /// <summary>
        /// Constant JM for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode JM = new PhoneNumberCountryCode("JM");
        /// <summary>
        /// Constant JO for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode JO = new PhoneNumberCountryCode("JO");
        /// <summary>
        /// Constant JP for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode JP = new PhoneNumberCountryCode("JP");
        /// <summary>
        /// Constant KE for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode KE = new PhoneNumberCountryCode("KE");
        /// <summary>
        /// Constant KG for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode KG = new PhoneNumberCountryCode("KG");
        /// <summary>
        /// Constant KH for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode KH = new PhoneNumberCountryCode("KH");
        /// <summary>
        /// Constant KI for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode KI = new PhoneNumberCountryCode("KI");
        /// <summary>
        /// Constant KM for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode KM = new PhoneNumberCountryCode("KM");
        /// <summary>
        /// Constant KN for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode KN = new PhoneNumberCountryCode("KN");
        /// <summary>
        /// Constant KP for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode KP = new PhoneNumberCountryCode("KP");
        /// <summary>
        /// Constant KR for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode KR = new PhoneNumberCountryCode("KR");
        /// <summary>
        /// Constant KW for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode KW = new PhoneNumberCountryCode("KW");
        /// <summary>
        /// Constant KY for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode KY = new PhoneNumberCountryCode("KY");
        /// <summary>
        /// Constant KZ for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode KZ = new PhoneNumberCountryCode("KZ");
        /// <summary>
        /// Constant LA for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode LA = new PhoneNumberCountryCode("LA");
        /// <summary>
        /// Constant LB for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode LB = new PhoneNumberCountryCode("LB");
        /// <summary>
        /// Constant LC for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode LC = new PhoneNumberCountryCode("LC");
        /// <summary>
        /// Constant LI for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode LI = new PhoneNumberCountryCode("LI");
        /// <summary>
        /// Constant LK for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode LK = new PhoneNumberCountryCode("LK");
        /// <summary>
        /// Constant LR for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode LR = new PhoneNumberCountryCode("LR");
        /// <summary>
        /// Constant LS for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode LS = new PhoneNumberCountryCode("LS");
        /// <summary>
        /// Constant LT for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode LT = new PhoneNumberCountryCode("LT");
        /// <summary>
        /// Constant LU for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode LU = new PhoneNumberCountryCode("LU");
        /// <summary>
        /// Constant LV for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode LV = new PhoneNumberCountryCode("LV");
        /// <summary>
        /// Constant LY for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode LY = new PhoneNumberCountryCode("LY");
        /// <summary>
        /// Constant MA for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode MA = new PhoneNumberCountryCode("MA");
        /// <summary>
        /// Constant MC for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode MC = new PhoneNumberCountryCode("MC");
        /// <summary>
        /// Constant MD for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode MD = new PhoneNumberCountryCode("MD");
        /// <summary>
        /// Constant ME for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode ME = new PhoneNumberCountryCode("ME");
        /// <summary>
        /// Constant MF for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode MF = new PhoneNumberCountryCode("MF");
        /// <summary>
        /// Constant MG for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode MG = new PhoneNumberCountryCode("MG");
        /// <summary>
        /// Constant MH for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode MH = new PhoneNumberCountryCode("MH");
        /// <summary>
        /// Constant MK for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode MK = new PhoneNumberCountryCode("MK");
        /// <summary>
        /// Constant ML for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode ML = new PhoneNumberCountryCode("ML");
        /// <summary>
        /// Constant MM for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode MM = new PhoneNumberCountryCode("MM");
        /// <summary>
        /// Constant MN for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode MN = new PhoneNumberCountryCode("MN");
        /// <summary>
        /// Constant MO for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode MO = new PhoneNumberCountryCode("MO");
        /// <summary>
        /// Constant MP for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode MP = new PhoneNumberCountryCode("MP");
        /// <summary>
        /// Constant MR for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode MR = new PhoneNumberCountryCode("MR");
        /// <summary>
        /// Constant MS for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode MS = new PhoneNumberCountryCode("MS");
        /// <summary>
        /// Constant MT for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode MT = new PhoneNumberCountryCode("MT");
        /// <summary>
        /// Constant MU for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode MU = new PhoneNumberCountryCode("MU");
        /// <summary>
        /// Constant MV for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode MV = new PhoneNumberCountryCode("MV");
        /// <summary>
        /// Constant MW for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode MW = new PhoneNumberCountryCode("MW");
        /// <summary>
        /// Constant MX for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode MX = new PhoneNumberCountryCode("MX");
        /// <summary>
        /// Constant MY for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode MY = new PhoneNumberCountryCode("MY");
        /// <summary>
        /// Constant MZ for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode MZ = new PhoneNumberCountryCode("MZ");
        /// <summary>
        /// Constant NA for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode NA = new PhoneNumberCountryCode("NA");
        /// <summary>
        /// Constant NC for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode NC = new PhoneNumberCountryCode("NC");
        /// <summary>
        /// Constant NE for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode NE = new PhoneNumberCountryCode("NE");
        /// <summary>
        /// Constant NG for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode NG = new PhoneNumberCountryCode("NG");
        /// <summary>
        /// Constant NI for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode NI = new PhoneNumberCountryCode("NI");
        /// <summary>
        /// Constant NL for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode NL = new PhoneNumberCountryCode("NL");
        /// <summary>
        /// Constant NO for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode NO = new PhoneNumberCountryCode("NO");
        /// <summary>
        /// Constant NP for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode NP = new PhoneNumberCountryCode("NP");
        /// <summary>
        /// Constant NR for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode NR = new PhoneNumberCountryCode("NR");
        /// <summary>
        /// Constant NU for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode NU = new PhoneNumberCountryCode("NU");
        /// <summary>
        /// Constant NZ for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode NZ = new PhoneNumberCountryCode("NZ");
        /// <summary>
        /// Constant OM for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode OM = new PhoneNumberCountryCode("OM");
        /// <summary>
        /// Constant PA for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode PA = new PhoneNumberCountryCode("PA");
        /// <summary>
        /// Constant PE for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode PE = new PhoneNumberCountryCode("PE");
        /// <summary>
        /// Constant PF for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode PF = new PhoneNumberCountryCode("PF");
        /// <summary>
        /// Constant PG for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode PG = new PhoneNumberCountryCode("PG");
        /// <summary>
        /// Constant PH for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode PH = new PhoneNumberCountryCode("PH");
        /// <summary>
        /// Constant PK for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode PK = new PhoneNumberCountryCode("PK");
        /// <summary>
        /// Constant PL for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode PL = new PhoneNumberCountryCode("PL");
        /// <summary>
        /// Constant PM for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode PM = new PhoneNumberCountryCode("PM");
        /// <summary>
        /// Constant PN for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode PN = new PhoneNumberCountryCode("PN");
        /// <summary>
        /// Constant PR for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode PR = new PhoneNumberCountryCode("PR");
        /// <summary>
        /// Constant PT for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode PT = new PhoneNumberCountryCode("PT");
        /// <summary>
        /// Constant PW for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode PW = new PhoneNumberCountryCode("PW");
        /// <summary>
        /// Constant PY for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode PY = new PhoneNumberCountryCode("PY");
        /// <summary>
        /// Constant QA for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode QA = new PhoneNumberCountryCode("QA");
        /// <summary>
        /// Constant RE for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode RE = new PhoneNumberCountryCode("RE");
        /// <summary>
        /// Constant RO for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode RO = new PhoneNumberCountryCode("RO");
        /// <summary>
        /// Constant RS for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode RS = new PhoneNumberCountryCode("RS");
        /// <summary>
        /// Constant RU for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode RU = new PhoneNumberCountryCode("RU");
        /// <summary>
        /// Constant RW for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode RW = new PhoneNumberCountryCode("RW");
        /// <summary>
        /// Constant SA for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode SA = new PhoneNumberCountryCode("SA");
        /// <summary>
        /// Constant SB for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode SB = new PhoneNumberCountryCode("SB");
        /// <summary>
        /// Constant SC for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode SC = new PhoneNumberCountryCode("SC");
        /// <summary>
        /// Constant SD for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode SD = new PhoneNumberCountryCode("SD");
        /// <summary>
        /// Constant SE for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode SE = new PhoneNumberCountryCode("SE");
        /// <summary>
        /// Constant SG for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode SG = new PhoneNumberCountryCode("SG");
        /// <summary>
        /// Constant SH for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode SH = new PhoneNumberCountryCode("SH");
        /// <summary>
        /// Constant SI for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode SI = new PhoneNumberCountryCode("SI");
        /// <summary>
        /// Constant SJ for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode SJ = new PhoneNumberCountryCode("SJ");
        /// <summary>
        /// Constant SK for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode SK = new PhoneNumberCountryCode("SK");
        /// <summary>
        /// Constant SL for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode SL = new PhoneNumberCountryCode("SL");
        /// <summary>
        /// Constant SM for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode SM = new PhoneNumberCountryCode("SM");
        /// <summary>
        /// Constant SN for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode SN = new PhoneNumberCountryCode("SN");
        /// <summary>
        /// Constant SO for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode SO = new PhoneNumberCountryCode("SO");
        /// <summary>
        /// Constant SR for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode SR = new PhoneNumberCountryCode("SR");
        /// <summary>
        /// Constant ST for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode ST = new PhoneNumberCountryCode("ST");
        /// <summary>
        /// Constant SV for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode SV = new PhoneNumberCountryCode("SV");
        /// <summary>
        /// Constant SX for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode SX = new PhoneNumberCountryCode("SX");
        /// <summary>
        /// Constant SY for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode SY = new PhoneNumberCountryCode("SY");
        /// <summary>
        /// Constant SZ for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode SZ = new PhoneNumberCountryCode("SZ");
        /// <summary>
        /// Constant TC for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode TC = new PhoneNumberCountryCode("TC");
        /// <summary>
        /// Constant TD for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode TD = new PhoneNumberCountryCode("TD");
        /// <summary>
        /// Constant TG for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode TG = new PhoneNumberCountryCode("TG");
        /// <summary>
        /// Constant TH for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode TH = new PhoneNumberCountryCode("TH");
        /// <summary>
        /// Constant TJ for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode TJ = new PhoneNumberCountryCode("TJ");
        /// <summary>
        /// Constant TK for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode TK = new PhoneNumberCountryCode("TK");
        /// <summary>
        /// Constant TL for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode TL = new PhoneNumberCountryCode("TL");
        /// <summary>
        /// Constant TM for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode TM = new PhoneNumberCountryCode("TM");
        /// <summary>
        /// Constant TN for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode TN = new PhoneNumberCountryCode("TN");
        /// <summary>
        /// Constant TO for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode TO = new PhoneNumberCountryCode("TO");
        /// <summary>
        /// Constant TR for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode TR = new PhoneNumberCountryCode("TR");
        /// <summary>
        /// Constant TT for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode TT = new PhoneNumberCountryCode("TT");
        /// <summary>
        /// Constant TV for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode TV = new PhoneNumberCountryCode("TV");
        /// <summary>
        /// Constant TW for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode TW = new PhoneNumberCountryCode("TW");
        /// <summary>
        /// Constant TZ for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode TZ = new PhoneNumberCountryCode("TZ");
        /// <summary>
        /// Constant UA for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode UA = new PhoneNumberCountryCode("UA");
        /// <summary>
        /// Constant UG for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode UG = new PhoneNumberCountryCode("UG");
        /// <summary>
        /// Constant US for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode US = new PhoneNumberCountryCode("US");
        /// <summary>
        /// Constant UY for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode UY = new PhoneNumberCountryCode("UY");
        /// <summary>
        /// Constant UZ for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode UZ = new PhoneNumberCountryCode("UZ");
        /// <summary>
        /// Constant VA for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode VA = new PhoneNumberCountryCode("VA");
        /// <summary>
        /// Constant VC for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode VC = new PhoneNumberCountryCode("VC");
        /// <summary>
        /// Constant VE for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode VE = new PhoneNumberCountryCode("VE");
        /// <summary>
        /// Constant VG for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode VG = new PhoneNumberCountryCode("VG");
        /// <summary>
        /// Constant VI for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode VI = new PhoneNumberCountryCode("VI");
        /// <summary>
        /// Constant VN for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode VN = new PhoneNumberCountryCode("VN");
        /// <summary>
        /// Constant VU for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode VU = new PhoneNumberCountryCode("VU");
        /// <summary>
        /// Constant WF for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode WF = new PhoneNumberCountryCode("WF");
        /// <summary>
        /// Constant WS for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode WS = new PhoneNumberCountryCode("WS");
        /// <summary>
        /// Constant YE for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode YE = new PhoneNumberCountryCode("YE");
        /// <summary>
        /// Constant YT for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode YT = new PhoneNumberCountryCode("YT");
        /// <summary>
        /// Constant ZA for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode ZA = new PhoneNumberCountryCode("ZA");
        /// <summary>
        /// Constant ZM for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode ZM = new PhoneNumberCountryCode("ZM");
        /// <summary>
        /// Constant ZW for PhoneNumberCountryCode
        /// </summary>
        public static readonly PhoneNumberCountryCode ZW = new PhoneNumberCountryCode("ZW");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PhoneNumberCountryCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PhoneNumberCountryCode FindValue(string value)
        {
            return FindValue<PhoneNumberCountryCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PhoneNumberCountryCode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PhoneNumberType.
    /// </summary>
    public class PhoneNumberType : ConstantClass
    {

        /// <summary>
        /// Constant DID for PhoneNumberType
        /// </summary>
        public static readonly PhoneNumberType DID = new PhoneNumberType("DID");
        /// <summary>
        /// Constant SHARED for PhoneNumberType
        /// </summary>
        public static readonly PhoneNumberType SHARED = new PhoneNumberType("SHARED");
        /// <summary>
        /// Constant SHORT_CODE for PhoneNumberType
        /// </summary>
        public static readonly PhoneNumberType SHORT_CODE = new PhoneNumberType("SHORT_CODE");
        /// <summary>
        /// Constant THIRD_PARTY_DID for PhoneNumberType
        /// </summary>
        public static readonly PhoneNumberType THIRD_PARTY_DID = new PhoneNumberType("THIRD_PARTY_DID");
        /// <summary>
        /// Constant THIRD_PARTY_TF for PhoneNumberType
        /// </summary>
        public static readonly PhoneNumberType THIRD_PARTY_TF = new PhoneNumberType("THIRD_PARTY_TF");
        /// <summary>
        /// Constant TOLL_FREE for PhoneNumberType
        /// </summary>
        public static readonly PhoneNumberType TOLL_FREE = new PhoneNumberType("TOLL_FREE");
        /// <summary>
        /// Constant UIFN for PhoneNumberType
        /// </summary>
        public static readonly PhoneNumberType UIFN = new PhoneNumberType("UIFN");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PhoneNumberType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PhoneNumberType FindValue(string value)
        {
            return FindValue<PhoneNumberType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PhoneNumberType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PhoneNumberWorkflowStatus.
    /// </summary>
    public class PhoneNumberWorkflowStatus : ConstantClass
    {

        /// <summary>
        /// Constant CLAIMED for PhoneNumberWorkflowStatus
        /// </summary>
        public static readonly PhoneNumberWorkflowStatus CLAIMED = new PhoneNumberWorkflowStatus("CLAIMED");
        /// <summary>
        /// Constant FAILED for PhoneNumberWorkflowStatus
        /// </summary>
        public static readonly PhoneNumberWorkflowStatus FAILED = new PhoneNumberWorkflowStatus("FAILED");
        /// <summary>
        /// Constant IN_PROGRESS for PhoneNumberWorkflowStatus
        /// </summary>
        public static readonly PhoneNumberWorkflowStatus IN_PROGRESS = new PhoneNumberWorkflowStatus("IN_PROGRESS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PhoneNumberWorkflowStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PhoneNumberWorkflowStatus FindValue(string value)
        {
            return FindValue<PhoneNumberWorkflowStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PhoneNumberWorkflowStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PhoneType.
    /// </summary>
    public class PhoneType : ConstantClass
    {

        /// <summary>
        /// Constant DESK_PHONE for PhoneType
        /// </summary>
        public static readonly PhoneType DESK_PHONE = new PhoneType("DESK_PHONE");
        /// <summary>
        /// Constant SOFT_PHONE for PhoneType
        /// </summary>
        public static readonly PhoneType SOFT_PHONE = new PhoneType("SOFT_PHONE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PhoneType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PhoneType FindValue(string value)
        {
            return FindValue<PhoneType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PhoneType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PropertyValidationExceptionReason.
    /// </summary>
    public class PropertyValidationExceptionReason : ConstantClass
    {

        /// <summary>
        /// Constant INVALID_FORMAT for PropertyValidationExceptionReason
        /// </summary>
        public static readonly PropertyValidationExceptionReason INVALID_FORMAT = new PropertyValidationExceptionReason("INVALID_FORMAT");
        /// <summary>
        /// Constant NOT_SUPPORTED for PropertyValidationExceptionReason
        /// </summary>
        public static readonly PropertyValidationExceptionReason NOT_SUPPORTED = new PropertyValidationExceptionReason("NOT_SUPPORTED");
        /// <summary>
        /// Constant REFERENCED_RESOURCE_NOT_FOUND for PropertyValidationExceptionReason
        /// </summary>
        public static readonly PropertyValidationExceptionReason REFERENCED_RESOURCE_NOT_FOUND = new PropertyValidationExceptionReason("REFERENCED_RESOURCE_NOT_FOUND");
        /// <summary>
        /// Constant REQUIRED_PROPERTY_MISSING for PropertyValidationExceptionReason
        /// </summary>
        public static readonly PropertyValidationExceptionReason REQUIRED_PROPERTY_MISSING = new PropertyValidationExceptionReason("REQUIRED_PROPERTY_MISSING");
        /// <summary>
        /// Constant RESOURCE_NAME_ALREADY_EXISTS for PropertyValidationExceptionReason
        /// </summary>
        public static readonly PropertyValidationExceptionReason RESOURCE_NAME_ALREADY_EXISTS = new PropertyValidationExceptionReason("RESOURCE_NAME_ALREADY_EXISTS");
        /// <summary>
        /// Constant UNIQUE_CONSTRAINT_VIOLATED for PropertyValidationExceptionReason
        /// </summary>
        public static readonly PropertyValidationExceptionReason UNIQUE_CONSTRAINT_VIOLATED = new PropertyValidationExceptionReason("UNIQUE_CONSTRAINT_VIOLATED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PropertyValidationExceptionReason(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PropertyValidationExceptionReason FindValue(string value)
        {
            return FindValue<PropertyValidationExceptionReason>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PropertyValidationExceptionReason(string value)
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
        /// Constant DISABLED for QueueStatus
        /// </summary>
        public static readonly QueueStatus DISABLED = new QueueStatus("DISABLED");
        /// <summary>
        /// Constant ENABLED for QueueStatus
        /// </summary>
        public static readonly QueueStatus ENABLED = new QueueStatus("ENABLED");

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
    /// Constants used for properties of type QueueType.
    /// </summary>
    public class QueueType : ConstantClass
    {

        /// <summary>
        /// Constant AGENT for QueueType
        /// </summary>
        public static readonly QueueType AGENT = new QueueType("AGENT");
        /// <summary>
        /// Constant STANDARD for QueueType
        /// </summary>
        public static readonly QueueType STANDARD = new QueueType("STANDARD");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public QueueType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static QueueType FindValue(string value)
        {
            return FindValue<QueueType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator QueueType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type QuickConnectType.
    /// </summary>
    public class QuickConnectType : ConstantClass
    {

        /// <summary>
        /// Constant PHONE_NUMBER for QuickConnectType
        /// </summary>
        public static readonly QuickConnectType PHONE_NUMBER = new QuickConnectType("PHONE_NUMBER");
        /// <summary>
        /// Constant QUEUE for QuickConnectType
        /// </summary>
        public static readonly QuickConnectType QUEUE = new QuickConnectType("QUEUE");
        /// <summary>
        /// Constant USER for QuickConnectType
        /// </summary>
        public static readonly QuickConnectType USER = new QuickConnectType("USER");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public QuickConnectType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static QuickConnectType FindValue(string value)
        {
            return FindValue<QuickConnectType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator QuickConnectType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RealTimeContactAnalysisOutputType.
    /// </summary>
    public class RealTimeContactAnalysisOutputType : ConstantClass
    {

        /// <summary>
        /// Constant Raw for RealTimeContactAnalysisOutputType
        /// </summary>
        public static readonly RealTimeContactAnalysisOutputType Raw = new RealTimeContactAnalysisOutputType("Raw");
        /// <summary>
        /// Constant Redacted for RealTimeContactAnalysisOutputType
        /// </summary>
        public static readonly RealTimeContactAnalysisOutputType Redacted = new RealTimeContactAnalysisOutputType("Redacted");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RealTimeContactAnalysisOutputType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RealTimeContactAnalysisOutputType FindValue(string value)
        {
            return FindValue<RealTimeContactAnalysisOutputType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RealTimeContactAnalysisOutputType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RealTimeContactAnalysisPostContactSummaryFailureCode.
    /// </summary>
    public class RealTimeContactAnalysisPostContactSummaryFailureCode : ConstantClass
    {

        /// <summary>
        /// Constant FAILED_SAFETY_GUIDELINES for RealTimeContactAnalysisPostContactSummaryFailureCode
        /// </summary>
        public static readonly RealTimeContactAnalysisPostContactSummaryFailureCode FAILED_SAFETY_GUIDELINES = new RealTimeContactAnalysisPostContactSummaryFailureCode("FAILED_SAFETY_GUIDELINES");
        /// <summary>
        /// Constant INSUFFICIENT_CONVERSATION_CONTENT for RealTimeContactAnalysisPostContactSummaryFailureCode
        /// </summary>
        public static readonly RealTimeContactAnalysisPostContactSummaryFailureCode INSUFFICIENT_CONVERSATION_CONTENT = new RealTimeContactAnalysisPostContactSummaryFailureCode("INSUFFICIENT_CONVERSATION_CONTENT");
        /// <summary>
        /// Constant INTERNAL_ERROR for RealTimeContactAnalysisPostContactSummaryFailureCode
        /// </summary>
        public static readonly RealTimeContactAnalysisPostContactSummaryFailureCode INTERNAL_ERROR = new RealTimeContactAnalysisPostContactSummaryFailureCode("INTERNAL_ERROR");
        /// <summary>
        /// Constant INVALID_ANALYSIS_CONFIGURATION for RealTimeContactAnalysisPostContactSummaryFailureCode
        /// </summary>
        public static readonly RealTimeContactAnalysisPostContactSummaryFailureCode INVALID_ANALYSIS_CONFIGURATION = new RealTimeContactAnalysisPostContactSummaryFailureCode("INVALID_ANALYSIS_CONFIGURATION");
        /// <summary>
        /// Constant QUOTA_EXCEEDED for RealTimeContactAnalysisPostContactSummaryFailureCode
        /// </summary>
        public static readonly RealTimeContactAnalysisPostContactSummaryFailureCode QUOTA_EXCEEDED = new RealTimeContactAnalysisPostContactSummaryFailureCode("QUOTA_EXCEEDED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RealTimeContactAnalysisPostContactSummaryFailureCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RealTimeContactAnalysisPostContactSummaryFailureCode FindValue(string value)
        {
            return FindValue<RealTimeContactAnalysisPostContactSummaryFailureCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RealTimeContactAnalysisPostContactSummaryFailureCode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RealTimeContactAnalysisPostContactSummaryStatus.
    /// </summary>
    public class RealTimeContactAnalysisPostContactSummaryStatus : ConstantClass
    {

        /// <summary>
        /// Constant COMPLETED for RealTimeContactAnalysisPostContactSummaryStatus
        /// </summary>
        public static readonly RealTimeContactAnalysisPostContactSummaryStatus COMPLETED = new RealTimeContactAnalysisPostContactSummaryStatus("COMPLETED");
        /// <summary>
        /// Constant FAILED for RealTimeContactAnalysisPostContactSummaryStatus
        /// </summary>
        public static readonly RealTimeContactAnalysisPostContactSummaryStatus FAILED = new RealTimeContactAnalysisPostContactSummaryStatus("FAILED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RealTimeContactAnalysisPostContactSummaryStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RealTimeContactAnalysisPostContactSummaryStatus FindValue(string value)
        {
            return FindValue<RealTimeContactAnalysisPostContactSummaryStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RealTimeContactAnalysisPostContactSummaryStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RealTimeContactAnalysisSegmentType.
    /// </summary>
    public class RealTimeContactAnalysisSegmentType : ConstantClass
    {

        /// <summary>
        /// Constant Attachments for RealTimeContactAnalysisSegmentType
        /// </summary>
        public static readonly RealTimeContactAnalysisSegmentType Attachments = new RealTimeContactAnalysisSegmentType("Attachments");
        /// <summary>
        /// Constant Categories for RealTimeContactAnalysisSegmentType
        /// </summary>
        public static readonly RealTimeContactAnalysisSegmentType Categories = new RealTimeContactAnalysisSegmentType("Categories");
        /// <summary>
        /// Constant Event for RealTimeContactAnalysisSegmentType
        /// </summary>
        public static readonly RealTimeContactAnalysisSegmentType Event = new RealTimeContactAnalysisSegmentType("Event");
        /// <summary>
        /// Constant Issues for RealTimeContactAnalysisSegmentType
        /// </summary>
        public static readonly RealTimeContactAnalysisSegmentType Issues = new RealTimeContactAnalysisSegmentType("Issues");
        /// <summary>
        /// Constant PostContactSummary for RealTimeContactAnalysisSegmentType
        /// </summary>
        public static readonly RealTimeContactAnalysisSegmentType PostContactSummary = new RealTimeContactAnalysisSegmentType("PostContactSummary");
        /// <summary>
        /// Constant Transcript for RealTimeContactAnalysisSegmentType
        /// </summary>
        public static readonly RealTimeContactAnalysisSegmentType Transcript = new RealTimeContactAnalysisSegmentType("Transcript");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RealTimeContactAnalysisSegmentType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RealTimeContactAnalysisSegmentType FindValue(string value)
        {
            return FindValue<RealTimeContactAnalysisSegmentType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RealTimeContactAnalysisSegmentType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RealTimeContactAnalysisSentimentLabel.
    /// </summary>
    public class RealTimeContactAnalysisSentimentLabel : ConstantClass
    {

        /// <summary>
        /// Constant NEGATIVE for RealTimeContactAnalysisSentimentLabel
        /// </summary>
        public static readonly RealTimeContactAnalysisSentimentLabel NEGATIVE = new RealTimeContactAnalysisSentimentLabel("NEGATIVE");
        /// <summary>
        /// Constant NEUTRAL for RealTimeContactAnalysisSentimentLabel
        /// </summary>
        public static readonly RealTimeContactAnalysisSentimentLabel NEUTRAL = new RealTimeContactAnalysisSentimentLabel("NEUTRAL");
        /// <summary>
        /// Constant POSITIVE for RealTimeContactAnalysisSentimentLabel
        /// </summary>
        public static readonly RealTimeContactAnalysisSentimentLabel POSITIVE = new RealTimeContactAnalysisSentimentLabel("POSITIVE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RealTimeContactAnalysisSentimentLabel(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RealTimeContactAnalysisSentimentLabel FindValue(string value)
        {
            return FindValue<RealTimeContactAnalysisSentimentLabel>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RealTimeContactAnalysisSentimentLabel(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RealTimeContactAnalysisStatus.
    /// </summary>
    public class RealTimeContactAnalysisStatus : ConstantClass
    {

        /// <summary>
        /// Constant COMPLETED for RealTimeContactAnalysisStatus
        /// </summary>
        public static readonly RealTimeContactAnalysisStatus COMPLETED = new RealTimeContactAnalysisStatus("COMPLETED");
        /// <summary>
        /// Constant FAILED for RealTimeContactAnalysisStatus
        /// </summary>
        public static readonly RealTimeContactAnalysisStatus FAILED = new RealTimeContactAnalysisStatus("FAILED");
        /// <summary>
        /// Constant IN_PROGRESS for RealTimeContactAnalysisStatus
        /// </summary>
        public static readonly RealTimeContactAnalysisStatus IN_PROGRESS = new RealTimeContactAnalysisStatus("IN_PROGRESS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RealTimeContactAnalysisStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RealTimeContactAnalysisStatus FindValue(string value)
        {
            return FindValue<RealTimeContactAnalysisStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RealTimeContactAnalysisStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RealTimeContactAnalysisSupportedChannel.
    /// </summary>
    public class RealTimeContactAnalysisSupportedChannel : ConstantClass
    {

        /// <summary>
        /// Constant CHAT for RealTimeContactAnalysisSupportedChannel
        /// </summary>
        public static readonly RealTimeContactAnalysisSupportedChannel CHAT = new RealTimeContactAnalysisSupportedChannel("CHAT");
        /// <summary>
        /// Constant VOICE for RealTimeContactAnalysisSupportedChannel
        /// </summary>
        public static readonly RealTimeContactAnalysisSupportedChannel VOICE = new RealTimeContactAnalysisSupportedChannel("VOICE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RealTimeContactAnalysisSupportedChannel(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RealTimeContactAnalysisSupportedChannel FindValue(string value)
        {
            return FindValue<RealTimeContactAnalysisSupportedChannel>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RealTimeContactAnalysisSupportedChannel(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RecordingStatus.
    /// </summary>
    public class RecordingStatus : ConstantClass
    {

        /// <summary>
        /// Constant AVAILABLE for RecordingStatus
        /// </summary>
        public static readonly RecordingStatus AVAILABLE = new RecordingStatus("AVAILABLE");
        /// <summary>
        /// Constant DELETED for RecordingStatus
        /// </summary>
        public static readonly RecordingStatus DELETED = new RecordingStatus("DELETED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RecordingStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RecordingStatus FindValue(string value)
        {
            return FindValue<RecordingStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RecordingStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ReferenceStatus.
    /// </summary>
    public class ReferenceStatus : ConstantClass
    {

        /// <summary>
        /// Constant APPROVED for ReferenceStatus
        /// </summary>
        public static readonly ReferenceStatus APPROVED = new ReferenceStatus("APPROVED");
        /// <summary>
        /// Constant AVAILABLE for ReferenceStatus
        /// </summary>
        public static readonly ReferenceStatus AVAILABLE = new ReferenceStatus("AVAILABLE");
        /// <summary>
        /// Constant DELETED for ReferenceStatus
        /// </summary>
        public static readonly ReferenceStatus DELETED = new ReferenceStatus("DELETED");
        /// <summary>
        /// Constant FAILED for ReferenceStatus
        /// </summary>
        public static readonly ReferenceStatus FAILED = new ReferenceStatus("FAILED");
        /// <summary>
        /// Constant PROCESSING for ReferenceStatus
        /// </summary>
        public static readonly ReferenceStatus PROCESSING = new ReferenceStatus("PROCESSING");
        /// <summary>
        /// Constant REJECTED for ReferenceStatus
        /// </summary>
        public static readonly ReferenceStatus REJECTED = new ReferenceStatus("REJECTED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ReferenceStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ReferenceStatus FindValue(string value)
        {
            return FindValue<ReferenceStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ReferenceStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ReferenceType.
    /// </summary>
    public class ReferenceType : ConstantClass
    {

        /// <summary>
        /// Constant ATTACHMENT for ReferenceType
        /// </summary>
        public static readonly ReferenceType ATTACHMENT = new ReferenceType("ATTACHMENT");
        /// <summary>
        /// Constant CONTACT_ANALYSIS for ReferenceType
        /// </summary>
        public static readonly ReferenceType CONTACT_ANALYSIS = new ReferenceType("CONTACT_ANALYSIS");
        /// <summary>
        /// Constant DATE for ReferenceType
        /// </summary>
        public static readonly ReferenceType DATE = new ReferenceType("DATE");
        /// <summary>
        /// Constant EMAIL for ReferenceType
        /// </summary>
        public static readonly ReferenceType EMAIL = new ReferenceType("EMAIL");
        /// <summary>
        /// Constant EMAIL_MESSAGE for ReferenceType
        /// </summary>
        public static readonly ReferenceType EMAIL_MESSAGE = new ReferenceType("EMAIL_MESSAGE");
        /// <summary>
        /// Constant NUMBER for ReferenceType
        /// </summary>
        public static readonly ReferenceType NUMBER = new ReferenceType("NUMBER");
        /// <summary>
        /// Constant STRING for ReferenceType
        /// </summary>
        public static readonly ReferenceType STRING = new ReferenceType("STRING");
        /// <summary>
        /// Constant URL for ReferenceType
        /// </summary>
        public static readonly ReferenceType URL = new ReferenceType("URL");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ReferenceType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ReferenceType FindValue(string value)
        {
            return FindValue<ReferenceType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ReferenceType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RehydrationType.
    /// </summary>
    public class RehydrationType : ConstantClass
    {

        /// <summary>
        /// Constant ENTIRE_PAST_SESSION for RehydrationType
        /// </summary>
        public static readonly RehydrationType ENTIRE_PAST_SESSION = new RehydrationType("ENTIRE_PAST_SESSION");
        /// <summary>
        /// Constant FROM_SEGMENT for RehydrationType
        /// </summary>
        public static readonly RehydrationType FROM_SEGMENT = new RehydrationType("FROM_SEGMENT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RehydrationType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RehydrationType FindValue(string value)
        {
            return FindValue<RehydrationType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RehydrationType(string value)
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
        /// Constant CONTACT for ResourceType
        /// </summary>
        public static readonly ResourceType CONTACT = new ResourceType("CONTACT");
        /// <summary>
        /// Constant CONTACT_FLOW for ResourceType
        /// </summary>
        public static readonly ResourceType CONTACT_FLOW = new ResourceType("CONTACT_FLOW");
        /// <summary>
        /// Constant HIERARCHY_GROUP for ResourceType
        /// </summary>
        public static readonly ResourceType HIERARCHY_GROUP = new ResourceType("HIERARCHY_GROUP");
        /// <summary>
        /// Constant HIERARCHY_LEVEL for ResourceType
        /// </summary>
        public static readonly ResourceType HIERARCHY_LEVEL = new ResourceType("HIERARCHY_LEVEL");
        /// <summary>
        /// Constant INSTANCE for ResourceType
        /// </summary>
        public static readonly ResourceType INSTANCE = new ResourceType("INSTANCE");
        /// <summary>
        /// Constant PARTICIPANT for ResourceType
        /// </summary>
        public static readonly ResourceType PARTICIPANT = new ResourceType("PARTICIPANT");
        /// <summary>
        /// Constant PHONE_NUMBER for ResourceType
        /// </summary>
        public static readonly ResourceType PHONE_NUMBER = new ResourceType("PHONE_NUMBER");
        /// <summary>
        /// Constant USER for ResourceType
        /// </summary>
        public static readonly ResourceType USER = new ResourceType("USER");

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
    /// Constants used for properties of type RoutingCriteriaStepStatus.
    /// </summary>
    public class RoutingCriteriaStepStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for RoutingCriteriaStepStatus
        /// </summary>
        public static readonly RoutingCriteriaStepStatus ACTIVE = new RoutingCriteriaStepStatus("ACTIVE");
        /// <summary>
        /// Constant EXPIRED for RoutingCriteriaStepStatus
        /// </summary>
        public static readonly RoutingCriteriaStepStatus EXPIRED = new RoutingCriteriaStepStatus("EXPIRED");
        /// <summary>
        /// Constant INACTIVE for RoutingCriteriaStepStatus
        /// </summary>
        public static readonly RoutingCriteriaStepStatus INACTIVE = new RoutingCriteriaStepStatus("INACTIVE");
        /// <summary>
        /// Constant JOINED for RoutingCriteriaStepStatus
        /// </summary>
        public static readonly RoutingCriteriaStepStatus JOINED = new RoutingCriteriaStepStatus("JOINED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RoutingCriteriaStepStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RoutingCriteriaStepStatus FindValue(string value)
        {
            return FindValue<RoutingCriteriaStepStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RoutingCriteriaStepStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RulePublishStatus.
    /// </summary>
    public class RulePublishStatus : ConstantClass
    {

        /// <summary>
        /// Constant DRAFT for RulePublishStatus
        /// </summary>
        public static readonly RulePublishStatus DRAFT = new RulePublishStatus("DRAFT");
        /// <summary>
        /// Constant PUBLISHED for RulePublishStatus
        /// </summary>
        public static readonly RulePublishStatus PUBLISHED = new RulePublishStatus("PUBLISHED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RulePublishStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RulePublishStatus FindValue(string value)
        {
            return FindValue<RulePublishStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RulePublishStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ScreenShareCapability.
    /// </summary>
    public class ScreenShareCapability : ConstantClass
    {

        /// <summary>
        /// Constant SEND for ScreenShareCapability
        /// </summary>
        public static readonly ScreenShareCapability SEND = new ScreenShareCapability("SEND");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ScreenShareCapability(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ScreenShareCapability FindValue(string value)
        {
            return FindValue<ScreenShareCapability>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ScreenShareCapability(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SearchableQueueType.
    /// </summary>
    public class SearchableQueueType : ConstantClass
    {

        /// <summary>
        /// Constant STANDARD for SearchableQueueType
        /// </summary>
        public static readonly SearchableQueueType STANDARD = new SearchableQueueType("STANDARD");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SearchableQueueType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SearchableQueueType FindValue(string value)
        {
            return FindValue<SearchableQueueType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SearchableQueueType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SearchContactsMatchType.
    /// </summary>
    public class SearchContactsMatchType : ConstantClass
    {

        /// <summary>
        /// Constant MATCH_ALL for SearchContactsMatchType
        /// </summary>
        public static readonly SearchContactsMatchType MATCH_ALL = new SearchContactsMatchType("MATCH_ALL");
        /// <summary>
        /// Constant MATCH_ANY for SearchContactsMatchType
        /// </summary>
        public static readonly SearchContactsMatchType MATCH_ANY = new SearchContactsMatchType("MATCH_ANY");
        /// <summary>
        /// Constant MATCH_EXACT for SearchContactsMatchType
        /// </summary>
        public static readonly SearchContactsMatchType MATCH_EXACT = new SearchContactsMatchType("MATCH_EXACT");
        /// <summary>
        /// Constant MATCH_NONE for SearchContactsMatchType
        /// </summary>
        public static readonly SearchContactsMatchType MATCH_NONE = new SearchContactsMatchType("MATCH_NONE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SearchContactsMatchType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SearchContactsMatchType FindValue(string value)
        {
            return FindValue<SearchContactsMatchType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SearchContactsMatchType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SearchContactsTimeRangeConditionType.
    /// </summary>
    public class SearchContactsTimeRangeConditionType : ConstantClass
    {

        /// <summary>
        /// Constant NOT_EXISTS for SearchContactsTimeRangeConditionType
        /// </summary>
        public static readonly SearchContactsTimeRangeConditionType NOT_EXISTS = new SearchContactsTimeRangeConditionType("NOT_EXISTS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SearchContactsTimeRangeConditionType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SearchContactsTimeRangeConditionType FindValue(string value)
        {
            return FindValue<SearchContactsTimeRangeConditionType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SearchContactsTimeRangeConditionType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SearchContactsTimeRangeType.
    /// </summary>
    public class SearchContactsTimeRangeType : ConstantClass
    {

        /// <summary>
        /// Constant CONNECTED_TO_AGENT_TIMESTAMP for SearchContactsTimeRangeType
        /// </summary>
        public static readonly SearchContactsTimeRangeType CONNECTED_TO_AGENT_TIMESTAMP = new SearchContactsTimeRangeType("CONNECTED_TO_AGENT_TIMESTAMP");
        /// <summary>
        /// Constant DISCONNECT_TIMESTAMP for SearchContactsTimeRangeType
        /// </summary>
        public static readonly SearchContactsTimeRangeType DISCONNECT_TIMESTAMP = new SearchContactsTimeRangeType("DISCONNECT_TIMESTAMP");
        /// <summary>
        /// Constant ENQUEUE_TIMESTAMP for SearchContactsTimeRangeType
        /// </summary>
        public static readonly SearchContactsTimeRangeType ENQUEUE_TIMESTAMP = new SearchContactsTimeRangeType("ENQUEUE_TIMESTAMP");
        /// <summary>
        /// Constant INITIATION_TIMESTAMP for SearchContactsTimeRangeType
        /// </summary>
        public static readonly SearchContactsTimeRangeType INITIATION_TIMESTAMP = new SearchContactsTimeRangeType("INITIATION_TIMESTAMP");
        /// <summary>
        /// Constant SCHEDULED_TIMESTAMP for SearchContactsTimeRangeType
        /// </summary>
        public static readonly SearchContactsTimeRangeType SCHEDULED_TIMESTAMP = new SearchContactsTimeRangeType("SCHEDULED_TIMESTAMP");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SearchContactsTimeRangeType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SearchContactsTimeRangeType FindValue(string value)
        {
            return FindValue<SearchContactsTimeRangeType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SearchContactsTimeRangeType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SingleSelectQuestionRuleCategoryAutomationCondition.
    /// </summary>
    public class SingleSelectQuestionRuleCategoryAutomationCondition : ConstantClass
    {

        /// <summary>
        /// Constant NOT_PRESENT for SingleSelectQuestionRuleCategoryAutomationCondition
        /// </summary>
        public static readonly SingleSelectQuestionRuleCategoryAutomationCondition NOT_PRESENT = new SingleSelectQuestionRuleCategoryAutomationCondition("NOT_PRESENT");
        /// <summary>
        /// Constant PRESENT for SingleSelectQuestionRuleCategoryAutomationCondition
        /// </summary>
        public static readonly SingleSelectQuestionRuleCategoryAutomationCondition PRESENT = new SingleSelectQuestionRuleCategoryAutomationCondition("PRESENT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SingleSelectQuestionRuleCategoryAutomationCondition(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SingleSelectQuestionRuleCategoryAutomationCondition FindValue(string value)
        {
            return FindValue<SingleSelectQuestionRuleCategoryAutomationCondition>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SingleSelectQuestionRuleCategoryAutomationCondition(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SlaAssignmentType.
    /// </summary>
    public class SlaAssignmentType : ConstantClass
    {

        /// <summary>
        /// Constant CASES for SlaAssignmentType
        /// </summary>
        public static readonly SlaAssignmentType CASES = new SlaAssignmentType("CASES");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SlaAssignmentType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SlaAssignmentType FindValue(string value)
        {
            return FindValue<SlaAssignmentType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SlaAssignmentType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SlaType.
    /// </summary>
    public class SlaType : ConstantClass
    {

        /// <summary>
        /// Constant CaseField for SlaType
        /// </summary>
        public static readonly SlaType CaseField = new SlaType("CaseField");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SlaType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SlaType FindValue(string value)
        {
            return FindValue<SlaType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SlaType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SortableFieldName.
    /// </summary>
    public class SortableFieldName : ConstantClass
    {

        /// <summary>
        /// Constant CHANNEL for SortableFieldName
        /// </summary>
        public static readonly SortableFieldName CHANNEL = new SortableFieldName("CHANNEL");
        /// <summary>
        /// Constant CONNECTED_TO_AGENT_TIMESTAMP for SortableFieldName
        /// </summary>
        public static readonly SortableFieldName CONNECTED_TO_AGENT_TIMESTAMP = new SortableFieldName("CONNECTED_TO_AGENT_TIMESTAMP");
        /// <summary>
        /// Constant DISCONNECT_TIMESTAMP for SortableFieldName
        /// </summary>
        public static readonly SortableFieldName DISCONNECT_TIMESTAMP = new SortableFieldName("DISCONNECT_TIMESTAMP");
        /// <summary>
        /// Constant EXPIRY_TIMESTAMP for SortableFieldName
        /// </summary>
        public static readonly SortableFieldName EXPIRY_TIMESTAMP = new SortableFieldName("EXPIRY_TIMESTAMP");
        /// <summary>
        /// Constant INITIATION_METHOD for SortableFieldName
        /// </summary>
        public static readonly SortableFieldName INITIATION_METHOD = new SortableFieldName("INITIATION_METHOD");
        /// <summary>
        /// Constant INITIATION_TIMESTAMP for SortableFieldName
        /// </summary>
        public static readonly SortableFieldName INITIATION_TIMESTAMP = new SortableFieldName("INITIATION_TIMESTAMP");
        /// <summary>
        /// Constant SCHEDULED_TIMESTAMP for SortableFieldName
        /// </summary>
        public static readonly SortableFieldName SCHEDULED_TIMESTAMP = new SortableFieldName("SCHEDULED_TIMESTAMP");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SortableFieldName(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SortableFieldName FindValue(string value)
        {
            return FindValue<SortableFieldName>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SortableFieldName(string value)
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
    /// Constants used for properties of type SourceType.
    /// </summary>
    public class SourceType : ConstantClass
    {

        /// <summary>
        /// Constant CASES for SourceType
        /// </summary>
        public static readonly SourceType CASES = new SourceType("CASES");
        /// <summary>
        /// Constant SALESFORCE for SourceType
        /// </summary>
        public static readonly SourceType SALESFORCE = new SourceType("SALESFORCE");
        /// <summary>
        /// Constant ZENDESK for SourceType
        /// </summary>
        public static readonly SourceType ZENDESK = new SourceType("ZENDESK");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SourceType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SourceType FindValue(string value)
        {
            return FindValue<SourceType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SourceType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Statistic.
    /// </summary>
    public class Statistic : ConstantClass
    {

        /// <summary>
        /// Constant AVG for Statistic
        /// </summary>
        public static readonly Statistic AVG = new Statistic("AVG");
        /// <summary>
        /// Constant MAX for Statistic
        /// </summary>
        public static readonly Statistic MAX = new Statistic("MAX");
        /// <summary>
        /// Constant SUM for Statistic
        /// </summary>
        public static readonly Statistic SUM = new Statistic("SUM");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Statistic(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Statistic FindValue(string value)
        {
            return FindValue<Statistic>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Statistic(string value)
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
        /// Constant COMPLETE for Status
        /// </summary>
        public static readonly Status COMPLETE = new Status("COMPLETE");
        /// <summary>
        /// Constant DELETED for Status
        /// </summary>
        public static readonly Status DELETED = new Status("DELETED");
        /// <summary>
        /// Constant IN_PROGRESS for Status
        /// </summary>
        public static readonly Status IN_PROGRESS = new Status("IN_PROGRESS");

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
    /// Constants used for properties of type StorageType.
    /// </summary>
    public class StorageType : ConstantClass
    {

        /// <summary>
        /// Constant KINESIS_FIREHOSE for StorageType
        /// </summary>
        public static readonly StorageType KINESIS_FIREHOSE = new StorageType("KINESIS_FIREHOSE");
        /// <summary>
        /// Constant KINESIS_STREAM for StorageType
        /// </summary>
        public static readonly StorageType KINESIS_STREAM = new StorageType("KINESIS_STREAM");
        /// <summary>
        /// Constant KINESIS_VIDEO_STREAM for StorageType
        /// </summary>
        public static readonly StorageType KINESIS_VIDEO_STREAM = new StorageType("KINESIS_VIDEO_STREAM");
        /// <summary>
        /// Constant S3 for StorageType
        /// </summary>
        public static readonly StorageType S3 = new StorageType("S3");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public StorageType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static StorageType FindValue(string value)
        {
            return FindValue<StorageType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator StorageType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type StringComparisonType.
    /// </summary>
    public class StringComparisonType : ConstantClass
    {

        /// <summary>
        /// Constant CONTAINS for StringComparisonType
        /// </summary>
        public static readonly StringComparisonType CONTAINS = new StringComparisonType("CONTAINS");
        /// <summary>
        /// Constant EXACT for StringComparisonType
        /// </summary>
        public static readonly StringComparisonType EXACT = new StringComparisonType("EXACT");
        /// <summary>
        /// Constant STARTS_WITH for StringComparisonType
        /// </summary>
        public static readonly StringComparisonType STARTS_WITH = new StringComparisonType("STARTS_WITH");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public StringComparisonType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static StringComparisonType FindValue(string value)
        {
            return FindValue<StringComparisonType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator StringComparisonType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TargetListType.
    /// </summary>
    public class TargetListType : ConstantClass
    {

        /// <summary>
        /// Constant PROFICIENCIES for TargetListType
        /// </summary>
        public static readonly TargetListType PROFICIENCIES = new TargetListType("PROFICIENCIES");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TargetListType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TargetListType FindValue(string value)
        {
            return FindValue<TargetListType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TargetListType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TaskTemplateFieldType.
    /// </summary>
    public class TaskTemplateFieldType : ConstantClass
    {

        /// <summary>
        /// Constant BOOLEAN for TaskTemplateFieldType
        /// </summary>
        public static readonly TaskTemplateFieldType BOOLEAN = new TaskTemplateFieldType("BOOLEAN");
        /// <summary>
        /// Constant DATE_TIME for TaskTemplateFieldType
        /// </summary>
        public static readonly TaskTemplateFieldType DATE_TIME = new TaskTemplateFieldType("DATE_TIME");
        /// <summary>
        /// Constant DESCRIPTION for TaskTemplateFieldType
        /// </summary>
        public static readonly TaskTemplateFieldType DESCRIPTION = new TaskTemplateFieldType("DESCRIPTION");
        /// <summary>
        /// Constant EMAIL for TaskTemplateFieldType
        /// </summary>
        public static readonly TaskTemplateFieldType EMAIL = new TaskTemplateFieldType("EMAIL");
        /// <summary>
        /// Constant EXPIRY_DURATION for TaskTemplateFieldType
        /// </summary>
        public static readonly TaskTemplateFieldType EXPIRY_DURATION = new TaskTemplateFieldType("EXPIRY_DURATION");
        /// <summary>
        /// Constant NAME for TaskTemplateFieldType
        /// </summary>
        public static readonly TaskTemplateFieldType NAME = new TaskTemplateFieldType("NAME");
        /// <summary>
        /// Constant NUMBER for TaskTemplateFieldType
        /// </summary>
        public static readonly TaskTemplateFieldType NUMBER = new TaskTemplateFieldType("NUMBER");
        /// <summary>
        /// Constant QUICK_CONNECT for TaskTemplateFieldType
        /// </summary>
        public static readonly TaskTemplateFieldType QUICK_CONNECT = new TaskTemplateFieldType("QUICK_CONNECT");
        /// <summary>
        /// Constant SCHEDULED_TIME for TaskTemplateFieldType
        /// </summary>
        public static readonly TaskTemplateFieldType SCHEDULED_TIME = new TaskTemplateFieldType("SCHEDULED_TIME");
        /// <summary>
        /// Constant SELF_ASSIGN for TaskTemplateFieldType
        /// </summary>
        public static readonly TaskTemplateFieldType SELF_ASSIGN = new TaskTemplateFieldType("SELF_ASSIGN");
        /// <summary>
        /// Constant SINGLE_SELECT for TaskTemplateFieldType
        /// </summary>
        public static readonly TaskTemplateFieldType SINGLE_SELECT = new TaskTemplateFieldType("SINGLE_SELECT");
        /// <summary>
        /// Constant TEXT for TaskTemplateFieldType
        /// </summary>
        public static readonly TaskTemplateFieldType TEXT = new TaskTemplateFieldType("TEXT");
        /// <summary>
        /// Constant TEXT_AREA for TaskTemplateFieldType
        /// </summary>
        public static readonly TaskTemplateFieldType TEXT_AREA = new TaskTemplateFieldType("TEXT_AREA");
        /// <summary>
        /// Constant URL for TaskTemplateFieldType
        /// </summary>
        public static readonly TaskTemplateFieldType URL = new TaskTemplateFieldType("URL");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TaskTemplateFieldType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TaskTemplateFieldType FindValue(string value)
        {
            return FindValue<TaskTemplateFieldType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TaskTemplateFieldType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TaskTemplateStatus.
    /// </summary>
    public class TaskTemplateStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for TaskTemplateStatus
        /// </summary>
        public static readonly TaskTemplateStatus ACTIVE = new TaskTemplateStatus("ACTIVE");
        /// <summary>
        /// Constant INACTIVE for TaskTemplateStatus
        /// </summary>
        public static readonly TaskTemplateStatus INACTIVE = new TaskTemplateStatus("INACTIVE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TaskTemplateStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TaskTemplateStatus FindValue(string value)
        {
            return FindValue<TaskTemplateStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TaskTemplateStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TimerEligibleParticipantRoles.
    /// </summary>
    public class TimerEligibleParticipantRoles : ConstantClass
    {

        /// <summary>
        /// Constant AGENT for TimerEligibleParticipantRoles
        /// </summary>
        public static readonly TimerEligibleParticipantRoles AGENT = new TimerEligibleParticipantRoles("AGENT");
        /// <summary>
        /// Constant CUSTOMER for TimerEligibleParticipantRoles
        /// </summary>
        public static readonly TimerEligibleParticipantRoles CUSTOMER = new TimerEligibleParticipantRoles("CUSTOMER");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TimerEligibleParticipantRoles(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TimerEligibleParticipantRoles FindValue(string value)
        {
            return FindValue<TimerEligibleParticipantRoles>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TimerEligibleParticipantRoles(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TrafficDistributionGroupStatus.
    /// </summary>
    public class TrafficDistributionGroupStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for TrafficDistributionGroupStatus
        /// </summary>
        public static readonly TrafficDistributionGroupStatus ACTIVE = new TrafficDistributionGroupStatus("ACTIVE");
        /// <summary>
        /// Constant CREATION_FAILED for TrafficDistributionGroupStatus
        /// </summary>
        public static readonly TrafficDistributionGroupStatus CREATION_FAILED = new TrafficDistributionGroupStatus("CREATION_FAILED");
        /// <summary>
        /// Constant CREATION_IN_PROGRESS for TrafficDistributionGroupStatus
        /// </summary>
        public static readonly TrafficDistributionGroupStatus CREATION_IN_PROGRESS = new TrafficDistributionGroupStatus("CREATION_IN_PROGRESS");
        /// <summary>
        /// Constant DELETION_FAILED for TrafficDistributionGroupStatus
        /// </summary>
        public static readonly TrafficDistributionGroupStatus DELETION_FAILED = new TrafficDistributionGroupStatus("DELETION_FAILED");
        /// <summary>
        /// Constant PENDING_DELETION for TrafficDistributionGroupStatus
        /// </summary>
        public static readonly TrafficDistributionGroupStatus PENDING_DELETION = new TrafficDistributionGroupStatus("PENDING_DELETION");
        /// <summary>
        /// Constant UPDATE_IN_PROGRESS for TrafficDistributionGroupStatus
        /// </summary>
        public static readonly TrafficDistributionGroupStatus UPDATE_IN_PROGRESS = new TrafficDistributionGroupStatus("UPDATE_IN_PROGRESS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TrafficDistributionGroupStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TrafficDistributionGroupStatus FindValue(string value)
        {
            return FindValue<TrafficDistributionGroupStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TrafficDistributionGroupStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TrafficType.
    /// </summary>
    public class TrafficType : ConstantClass
    {

        /// <summary>
        /// Constant CAMPAIGN for TrafficType
        /// </summary>
        public static readonly TrafficType CAMPAIGN = new TrafficType("CAMPAIGN");
        /// <summary>
        /// Constant GENERAL for TrafficType
        /// </summary>
        public static readonly TrafficType GENERAL = new TrafficType("GENERAL");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TrafficType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TrafficType FindValue(string value)
        {
            return FindValue<TrafficType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TrafficType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Unit.
    /// </summary>
    public class Unit : ConstantClass
    {

        /// <summary>
        /// Constant COUNT for Unit
        /// </summary>
        public static readonly Unit COUNT = new Unit("COUNT");
        /// <summary>
        /// Constant PERCENT for Unit
        /// </summary>
        public static readonly Unit PERCENT = new Unit("PERCENT");
        /// <summary>
        /// Constant SECONDS for Unit
        /// </summary>
        public static readonly Unit SECONDS = new Unit("SECONDS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Unit(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Unit FindValue(string value)
        {
            return FindValue<Unit>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Unit(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type UseCaseType.
    /// </summary>
    public class UseCaseType : ConstantClass
    {

        /// <summary>
        /// Constant CONNECT_CAMPAIGNS for UseCaseType
        /// </summary>
        public static readonly UseCaseType CONNECT_CAMPAIGNS = new UseCaseType("CONNECT_CAMPAIGNS");
        /// <summary>
        /// Constant RULES_EVALUATION for UseCaseType
        /// </summary>
        public static readonly UseCaseType RULES_EVALUATION = new UseCaseType("RULES_EVALUATION");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public UseCaseType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static UseCaseType FindValue(string value)
        {
            return FindValue<UseCaseType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator UseCaseType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type VideoCapability.
    /// </summary>
    public class VideoCapability : ConstantClass
    {

        /// <summary>
        /// Constant SEND for VideoCapability
        /// </summary>
        public static readonly VideoCapability SEND = new VideoCapability("SEND");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public VideoCapability(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static VideoCapability FindValue(string value)
        {
            return FindValue<VideoCapability>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator VideoCapability(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ViewStatus.
    /// </summary>
    public class ViewStatus : ConstantClass
    {

        /// <summary>
        /// Constant PUBLISHED for ViewStatus
        /// </summary>
        public static readonly ViewStatus PUBLISHED = new ViewStatus("PUBLISHED");
        /// <summary>
        /// Constant SAVED for ViewStatus
        /// </summary>
        public static readonly ViewStatus SAVED = new ViewStatus("SAVED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ViewStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ViewStatus FindValue(string value)
        {
            return FindValue<ViewStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ViewStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ViewType.
    /// </summary>
    public class ViewType : ConstantClass
    {

        /// <summary>
        /// Constant AWS_MANAGED for ViewType
        /// </summary>
        public static readonly ViewType AWS_MANAGED = new ViewType("AWS_MANAGED");
        /// <summary>
        /// Constant CUSTOMER_MANAGED for ViewType
        /// </summary>
        public static readonly ViewType CUSTOMER_MANAGED = new ViewType("CUSTOMER_MANAGED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ViewType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ViewType FindValue(string value)
        {
            return FindValue<ViewType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ViewType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type VocabularyLanguageCode.
    /// </summary>
    public class VocabularyLanguageCode : ConstantClass
    {

        /// <summary>
        /// Constant ArAE for VocabularyLanguageCode
        /// </summary>
        public static readonly VocabularyLanguageCode ArAE = new VocabularyLanguageCode("ar-AE");
        /// <summary>
        /// Constant CaES for VocabularyLanguageCode
        /// </summary>
        public static readonly VocabularyLanguageCode CaES = new VocabularyLanguageCode("ca-ES");
        /// <summary>
        /// Constant DaDK for VocabularyLanguageCode
        /// </summary>
        public static readonly VocabularyLanguageCode DaDK = new VocabularyLanguageCode("da-DK");
        /// <summary>
        /// Constant DeCH for VocabularyLanguageCode
        /// </summary>
        public static readonly VocabularyLanguageCode DeCH = new VocabularyLanguageCode("de-CH");
        /// <summary>
        /// Constant DeDE for VocabularyLanguageCode
        /// </summary>
        public static readonly VocabularyLanguageCode DeDE = new VocabularyLanguageCode("de-DE");
        /// <summary>
        /// Constant EnAB for VocabularyLanguageCode
        /// </summary>
        public static readonly VocabularyLanguageCode EnAB = new VocabularyLanguageCode("en-AB");
        /// <summary>
        /// Constant EnAU for VocabularyLanguageCode
        /// </summary>
        public static readonly VocabularyLanguageCode EnAU = new VocabularyLanguageCode("en-AU");
        /// <summary>
        /// Constant EnGB for VocabularyLanguageCode
        /// </summary>
        public static readonly VocabularyLanguageCode EnGB = new VocabularyLanguageCode("en-GB");
        /// <summary>
        /// Constant EnIE for VocabularyLanguageCode
        /// </summary>
        public static readonly VocabularyLanguageCode EnIE = new VocabularyLanguageCode("en-IE");
        /// <summary>
        /// Constant EnIN for VocabularyLanguageCode
        /// </summary>
        public static readonly VocabularyLanguageCode EnIN = new VocabularyLanguageCode("en-IN");
        /// <summary>
        /// Constant EnNZ for VocabularyLanguageCode
        /// </summary>
        public static readonly VocabularyLanguageCode EnNZ = new VocabularyLanguageCode("en-NZ");
        /// <summary>
        /// Constant EnUS for VocabularyLanguageCode
        /// </summary>
        public static readonly VocabularyLanguageCode EnUS = new VocabularyLanguageCode("en-US");
        /// <summary>
        /// Constant EnWL for VocabularyLanguageCode
        /// </summary>
        public static readonly VocabularyLanguageCode EnWL = new VocabularyLanguageCode("en-WL");
        /// <summary>
        /// Constant EnZA for VocabularyLanguageCode
        /// </summary>
        public static readonly VocabularyLanguageCode EnZA = new VocabularyLanguageCode("en-ZA");
        /// <summary>
        /// Constant EsES for VocabularyLanguageCode
        /// </summary>
        public static readonly VocabularyLanguageCode EsES = new VocabularyLanguageCode("es-ES");
        /// <summary>
        /// Constant EsUS for VocabularyLanguageCode
        /// </summary>
        public static readonly VocabularyLanguageCode EsUS = new VocabularyLanguageCode("es-US");
        /// <summary>
        /// Constant FiFI for VocabularyLanguageCode
        /// </summary>
        public static readonly VocabularyLanguageCode FiFI = new VocabularyLanguageCode("fi-FI");
        /// <summary>
        /// Constant FrCA for VocabularyLanguageCode
        /// </summary>
        public static readonly VocabularyLanguageCode FrCA = new VocabularyLanguageCode("fr-CA");
        /// <summary>
        /// Constant FrFR for VocabularyLanguageCode
        /// </summary>
        public static readonly VocabularyLanguageCode FrFR = new VocabularyLanguageCode("fr-FR");
        /// <summary>
        /// Constant HiIN for VocabularyLanguageCode
        /// </summary>
        public static readonly VocabularyLanguageCode HiIN = new VocabularyLanguageCode("hi-IN");
        /// <summary>
        /// Constant IdID for VocabularyLanguageCode
        /// </summary>
        public static readonly VocabularyLanguageCode IdID = new VocabularyLanguageCode("id-ID");
        /// <summary>
        /// Constant ItIT for VocabularyLanguageCode
        /// </summary>
        public static readonly VocabularyLanguageCode ItIT = new VocabularyLanguageCode("it-IT");
        /// <summary>
        /// Constant JaJP for VocabularyLanguageCode
        /// </summary>
        public static readonly VocabularyLanguageCode JaJP = new VocabularyLanguageCode("ja-JP");
        /// <summary>
        /// Constant KoKR for VocabularyLanguageCode
        /// </summary>
        public static readonly VocabularyLanguageCode KoKR = new VocabularyLanguageCode("ko-KR");
        /// <summary>
        /// Constant MsMY for VocabularyLanguageCode
        /// </summary>
        public static readonly VocabularyLanguageCode MsMY = new VocabularyLanguageCode("ms-MY");
        /// <summary>
        /// Constant NlNL for VocabularyLanguageCode
        /// </summary>
        public static readonly VocabularyLanguageCode NlNL = new VocabularyLanguageCode("nl-NL");
        /// <summary>
        /// Constant NoNO for VocabularyLanguageCode
        /// </summary>
        public static readonly VocabularyLanguageCode NoNO = new VocabularyLanguageCode("no-NO");
        /// <summary>
        /// Constant PlPL for VocabularyLanguageCode
        /// </summary>
        public static readonly VocabularyLanguageCode PlPL = new VocabularyLanguageCode("pl-PL");
        /// <summary>
        /// Constant PtBR for VocabularyLanguageCode
        /// </summary>
        public static readonly VocabularyLanguageCode PtBR = new VocabularyLanguageCode("pt-BR");
        /// <summary>
        /// Constant PtPT for VocabularyLanguageCode
        /// </summary>
        public static readonly VocabularyLanguageCode PtPT = new VocabularyLanguageCode("pt-PT");
        /// <summary>
        /// Constant SvSE for VocabularyLanguageCode
        /// </summary>
        public static readonly VocabularyLanguageCode SvSE = new VocabularyLanguageCode("sv-SE");
        /// <summary>
        /// Constant TlPH for VocabularyLanguageCode
        /// </summary>
        public static readonly VocabularyLanguageCode TlPH = new VocabularyLanguageCode("tl-PH");
        /// <summary>
        /// Constant ZhCN for VocabularyLanguageCode
        /// </summary>
        public static readonly VocabularyLanguageCode ZhCN = new VocabularyLanguageCode("zh-CN");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public VocabularyLanguageCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static VocabularyLanguageCode FindValue(string value)
        {
            return FindValue<VocabularyLanguageCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator VocabularyLanguageCode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type VocabularyState.
    /// </summary>
    public class VocabularyState : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for VocabularyState
        /// </summary>
        public static readonly VocabularyState ACTIVE = new VocabularyState("ACTIVE");
        /// <summary>
        /// Constant CREATION_FAILED for VocabularyState
        /// </summary>
        public static readonly VocabularyState CREATION_FAILED = new VocabularyState("CREATION_FAILED");
        /// <summary>
        /// Constant CREATION_IN_PROGRESS for VocabularyState
        /// </summary>
        public static readonly VocabularyState CREATION_IN_PROGRESS = new VocabularyState("CREATION_IN_PROGRESS");
        /// <summary>
        /// Constant DELETE_IN_PROGRESS for VocabularyState
        /// </summary>
        public static readonly VocabularyState DELETE_IN_PROGRESS = new VocabularyState("DELETE_IN_PROGRESS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public VocabularyState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static VocabularyState FindValue(string value)
        {
            return FindValue<VocabularyState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator VocabularyState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type VoiceRecordingTrack.
    /// </summary>
    public class VoiceRecordingTrack : ConstantClass
    {

        /// <summary>
        /// Constant ALL for VoiceRecordingTrack
        /// </summary>
        public static readonly VoiceRecordingTrack ALL = new VoiceRecordingTrack("ALL");
        /// <summary>
        /// Constant FROM_AGENT for VoiceRecordingTrack
        /// </summary>
        public static readonly VoiceRecordingTrack FROM_AGENT = new VoiceRecordingTrack("FROM_AGENT");
        /// <summary>
        /// Constant TO_AGENT for VoiceRecordingTrack
        /// </summary>
        public static readonly VoiceRecordingTrack TO_AGENT = new VoiceRecordingTrack("TO_AGENT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public VoiceRecordingTrack(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static VoiceRecordingTrack FindValue(string value)
        {
            return FindValue<VoiceRecordingTrack>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator VoiceRecordingTrack(string value)
        {
            return FindValue(value);
        }
    }

}