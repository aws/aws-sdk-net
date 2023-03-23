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
 * Do not modify this file. This file is generated from the chime-sdk-voice-2022-08-03.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.ChimeSDKVoice
{

    /// <summary>
    /// Constants used for properties of type AlexaSkillStatus.
    /// </summary>
    public class AlexaSkillStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for AlexaSkillStatus
        /// </summary>
        public static readonly AlexaSkillStatus ACTIVE = new AlexaSkillStatus("ACTIVE");
        /// <summary>
        /// Constant INACTIVE for AlexaSkillStatus
        /// </summary>
        public static readonly AlexaSkillStatus INACTIVE = new AlexaSkillStatus("INACTIVE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AlexaSkillStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AlexaSkillStatus FindValue(string value)
        {
            return FindValue<AlexaSkillStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AlexaSkillStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CallingNameStatus.
    /// </summary>
    public class CallingNameStatus : ConstantClass
    {

        /// <summary>
        /// Constant Unassigned for CallingNameStatus
        /// </summary>
        public static readonly CallingNameStatus Unassigned = new CallingNameStatus("Unassigned");
        /// <summary>
        /// Constant UpdateFailed for CallingNameStatus
        /// </summary>
        public static readonly CallingNameStatus UpdateFailed = new CallingNameStatus("UpdateFailed");
        /// <summary>
        /// Constant UpdateInProgress for CallingNameStatus
        /// </summary>
        public static readonly CallingNameStatus UpdateInProgress = new CallingNameStatus("UpdateInProgress");
        /// <summary>
        /// Constant UpdateSucceeded for CallingNameStatus
        /// </summary>
        public static readonly CallingNameStatus UpdateSucceeded = new CallingNameStatus("UpdateSucceeded");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CallingNameStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CallingNameStatus FindValue(string value)
        {
            return FindValue<CallingNameStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CallingNameStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Capability.
    /// </summary>
    public class Capability : ConstantClass
    {

        /// <summary>
        /// Constant SMS for Capability
        /// </summary>
        public static readonly Capability SMS = new Capability("SMS");
        /// <summary>
        /// Constant Voice for Capability
        /// </summary>
        public static readonly Capability Voice = new Capability("Voice");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Capability(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Capability FindValue(string value)
        {
            return FindValue<Capability>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Capability(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ErrorCode.
    /// </summary>
    public class ErrorCode : ConstantClass
    {

        /// <summary>
        /// Constant AccessDenied for ErrorCode
        /// </summary>
        public static readonly ErrorCode AccessDenied = new ErrorCode("AccessDenied");
        /// <summary>
        /// Constant BadRequest for ErrorCode
        /// </summary>
        public static readonly ErrorCode BadRequest = new ErrorCode("BadRequest");
        /// <summary>
        /// Constant Conflict for ErrorCode
        /// </summary>
        public static readonly ErrorCode Conflict = new ErrorCode("Conflict");
        /// <summary>
        /// Constant Forbidden for ErrorCode
        /// </summary>
        public static readonly ErrorCode Forbidden = new ErrorCode("Forbidden");
        /// <summary>
        /// Constant Gone for ErrorCode
        /// </summary>
        public static readonly ErrorCode Gone = new ErrorCode("Gone");
        /// <summary>
        /// Constant NotFound for ErrorCode
        /// </summary>
        public static readonly ErrorCode NotFound = new ErrorCode("NotFound");
        /// <summary>
        /// Constant PhoneNumberAssociationsExist for ErrorCode
        /// </summary>
        public static readonly ErrorCode PhoneNumberAssociationsExist = new ErrorCode("PhoneNumberAssociationsExist");
        /// <summary>
        /// Constant PreconditionFailed for ErrorCode
        /// </summary>
        public static readonly ErrorCode PreconditionFailed = new ErrorCode("PreconditionFailed");
        /// <summary>
        /// Constant ResourceLimitExceeded for ErrorCode
        /// </summary>
        public static readonly ErrorCode ResourceLimitExceeded = new ErrorCode("ResourceLimitExceeded");
        /// <summary>
        /// Constant ServiceFailure for ErrorCode
        /// </summary>
        public static readonly ErrorCode ServiceFailure = new ErrorCode("ServiceFailure");
        /// <summary>
        /// Constant ServiceUnavailable for ErrorCode
        /// </summary>
        public static readonly ErrorCode ServiceUnavailable = new ErrorCode("ServiceUnavailable");
        /// <summary>
        /// Constant Throttled for ErrorCode
        /// </summary>
        public static readonly ErrorCode Throttled = new ErrorCode("Throttled");
        /// <summary>
        /// Constant Throttling for ErrorCode
        /// </summary>
        public static readonly ErrorCode Throttling = new ErrorCode("Throttling");
        /// <summary>
        /// Constant Unauthorized for ErrorCode
        /// </summary>
        public static readonly ErrorCode Unauthorized = new ErrorCode("Unauthorized");
        /// <summary>
        /// Constant Unprocessable for ErrorCode
        /// </summary>
        public static readonly ErrorCode Unprocessable = new ErrorCode("Unprocessable");
        /// <summary>
        /// Constant VoiceConnectorGroupAssociationsExist for ErrorCode
        /// </summary>
        public static readonly ErrorCode VoiceConnectorGroupAssociationsExist = new ErrorCode("VoiceConnectorGroupAssociationsExist");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ErrorCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ErrorCode FindValue(string value)
        {
            return FindValue<ErrorCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ErrorCode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type GeoMatchLevel.
    /// </summary>
    public class GeoMatchLevel : ConstantClass
    {

        /// <summary>
        /// Constant AreaCode for GeoMatchLevel
        /// </summary>
        public static readonly GeoMatchLevel AreaCode = new GeoMatchLevel("AreaCode");
        /// <summary>
        /// Constant Country for GeoMatchLevel
        /// </summary>
        public static readonly GeoMatchLevel Country = new GeoMatchLevel("Country");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public GeoMatchLevel(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static GeoMatchLevel FindValue(string value)
        {
            return FindValue<GeoMatchLevel>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator GeoMatchLevel(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type LanguageCode.
    /// </summary>
    public class LanguageCode : ConstantClass
    {

        /// <summary>
        /// Constant EnUS for LanguageCode
        /// </summary>
        public static readonly LanguageCode EnUS = new LanguageCode("en-US");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public LanguageCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LanguageCode FindValue(string value)
        {
            return FindValue<LanguageCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator LanguageCode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type NotificationTarget.
    /// </summary>
    public class NotificationTarget : ConstantClass
    {

        /// <summary>
        /// Constant EventBridge for NotificationTarget
        /// </summary>
        public static readonly NotificationTarget EventBridge = new NotificationTarget("EventBridge");
        /// <summary>
        /// Constant SNS for NotificationTarget
        /// </summary>
        public static readonly NotificationTarget SNS = new NotificationTarget("SNS");
        /// <summary>
        /// Constant SQS for NotificationTarget
        /// </summary>
        public static readonly NotificationTarget SQS = new NotificationTarget("SQS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public NotificationTarget(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static NotificationTarget FindValue(string value)
        {
            return FindValue<NotificationTarget>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator NotificationTarget(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type NumberSelectionBehavior.
    /// </summary>
    public class NumberSelectionBehavior : ConstantClass
    {

        /// <summary>
        /// Constant AvoidSticky for NumberSelectionBehavior
        /// </summary>
        public static readonly NumberSelectionBehavior AvoidSticky = new NumberSelectionBehavior("AvoidSticky");
        /// <summary>
        /// Constant PreferSticky for NumberSelectionBehavior
        /// </summary>
        public static readonly NumberSelectionBehavior PreferSticky = new NumberSelectionBehavior("PreferSticky");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public NumberSelectionBehavior(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static NumberSelectionBehavior FindValue(string value)
        {
            return FindValue<NumberSelectionBehavior>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator NumberSelectionBehavior(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type OrderedPhoneNumberStatus.
    /// </summary>
    public class OrderedPhoneNumberStatus : ConstantClass
    {

        /// <summary>
        /// Constant Acquired for OrderedPhoneNumberStatus
        /// </summary>
        public static readonly OrderedPhoneNumberStatus Acquired = new OrderedPhoneNumberStatus("Acquired");
        /// <summary>
        /// Constant Failed for OrderedPhoneNumberStatus
        /// </summary>
        public static readonly OrderedPhoneNumberStatus Failed = new OrderedPhoneNumberStatus("Failed");
        /// <summary>
        /// Constant Processing for OrderedPhoneNumberStatus
        /// </summary>
        public static readonly OrderedPhoneNumberStatus Processing = new OrderedPhoneNumberStatus("Processing");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public OrderedPhoneNumberStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static OrderedPhoneNumberStatus FindValue(string value)
        {
            return FindValue<OrderedPhoneNumberStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator OrderedPhoneNumberStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type OriginationRouteProtocol.
    /// </summary>
    public class OriginationRouteProtocol : ConstantClass
    {

        /// <summary>
        /// Constant TCP for OriginationRouteProtocol
        /// </summary>
        public static readonly OriginationRouteProtocol TCP = new OriginationRouteProtocol("TCP");
        /// <summary>
        /// Constant UDP for OriginationRouteProtocol
        /// </summary>
        public static readonly OriginationRouteProtocol UDP = new OriginationRouteProtocol("UDP");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public OriginationRouteProtocol(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static OriginationRouteProtocol FindValue(string value)
        {
            return FindValue<OriginationRouteProtocol>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator OriginationRouteProtocol(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PhoneNumberAssociationName.
    /// </summary>
    public class PhoneNumberAssociationName : ConstantClass
    {

        /// <summary>
        /// Constant SipRuleId for PhoneNumberAssociationName
        /// </summary>
        public static readonly PhoneNumberAssociationName SipRuleId = new PhoneNumberAssociationName("SipRuleId");
        /// <summary>
        /// Constant VoiceConnectorGroupId for PhoneNumberAssociationName
        /// </summary>
        public static readonly PhoneNumberAssociationName VoiceConnectorGroupId = new PhoneNumberAssociationName("VoiceConnectorGroupId");
        /// <summary>
        /// Constant VoiceConnectorId for PhoneNumberAssociationName
        /// </summary>
        public static readonly PhoneNumberAssociationName VoiceConnectorId = new PhoneNumberAssociationName("VoiceConnectorId");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PhoneNumberAssociationName(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PhoneNumberAssociationName FindValue(string value)
        {
            return FindValue<PhoneNumberAssociationName>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PhoneNumberAssociationName(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PhoneNumberOrderStatus.
    /// </summary>
    public class PhoneNumberOrderStatus : ConstantClass
    {

        /// <summary>
        /// Constant Cancelled for PhoneNumberOrderStatus
        /// </summary>
        public static readonly PhoneNumberOrderStatus Cancelled = new PhoneNumberOrderStatus("Cancelled");
        /// <summary>
        /// Constant CancelRequested for PhoneNumberOrderStatus
        /// </summary>
        public static readonly PhoneNumberOrderStatus CancelRequested = new PhoneNumberOrderStatus("CancelRequested");
        /// <summary>
        /// Constant ChangeRequested for PhoneNumberOrderStatus
        /// </summary>
        public static readonly PhoneNumberOrderStatus ChangeRequested = new PhoneNumberOrderStatus("ChangeRequested");
        /// <summary>
        /// Constant Exception for PhoneNumberOrderStatus
        /// </summary>
        public static readonly PhoneNumberOrderStatus Exception = new PhoneNumberOrderStatus("Exception");
        /// <summary>
        /// Constant Failed for PhoneNumberOrderStatus
        /// </summary>
        public static readonly PhoneNumberOrderStatus Failed = new PhoneNumberOrderStatus("Failed");
        /// <summary>
        /// Constant FOC for PhoneNumberOrderStatus
        /// </summary>
        public static readonly PhoneNumberOrderStatus FOC = new PhoneNumberOrderStatus("FOC");
        /// <summary>
        /// Constant Partial for PhoneNumberOrderStatus
        /// </summary>
        public static readonly PhoneNumberOrderStatus Partial = new PhoneNumberOrderStatus("Partial");
        /// <summary>
        /// Constant PendingDocuments for PhoneNumberOrderStatus
        /// </summary>
        public static readonly PhoneNumberOrderStatus PendingDocuments = new PhoneNumberOrderStatus("PendingDocuments");
        /// <summary>
        /// Constant Processing for PhoneNumberOrderStatus
        /// </summary>
        public static readonly PhoneNumberOrderStatus Processing = new PhoneNumberOrderStatus("Processing");
        /// <summary>
        /// Constant Submitted for PhoneNumberOrderStatus
        /// </summary>
        public static readonly PhoneNumberOrderStatus Submitted = new PhoneNumberOrderStatus("Submitted");
        /// <summary>
        /// Constant Successful for PhoneNumberOrderStatus
        /// </summary>
        public static readonly PhoneNumberOrderStatus Successful = new PhoneNumberOrderStatus("Successful");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PhoneNumberOrderStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PhoneNumberOrderStatus FindValue(string value)
        {
            return FindValue<PhoneNumberOrderStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PhoneNumberOrderStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PhoneNumberOrderType.
    /// </summary>
    public class PhoneNumberOrderType : ConstantClass
    {

        /// <summary>
        /// Constant New for PhoneNumberOrderType
        /// </summary>
        public static readonly PhoneNumberOrderType New = new PhoneNumberOrderType("New");
        /// <summary>
        /// Constant Porting for PhoneNumberOrderType
        /// </summary>
        public static readonly PhoneNumberOrderType Porting = new PhoneNumberOrderType("Porting");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PhoneNumberOrderType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PhoneNumberOrderType FindValue(string value)
        {
            return FindValue<PhoneNumberOrderType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PhoneNumberOrderType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PhoneNumberProductType.
    /// </summary>
    public class PhoneNumberProductType : ConstantClass
    {

        /// <summary>
        /// Constant SipMediaApplicationDialIn for PhoneNumberProductType
        /// </summary>
        public static readonly PhoneNumberProductType SipMediaApplicationDialIn = new PhoneNumberProductType("SipMediaApplicationDialIn");
        /// <summary>
        /// Constant VoiceConnector for PhoneNumberProductType
        /// </summary>
        public static readonly PhoneNumberProductType VoiceConnector = new PhoneNumberProductType("VoiceConnector");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PhoneNumberProductType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PhoneNumberProductType FindValue(string value)
        {
            return FindValue<PhoneNumberProductType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PhoneNumberProductType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PhoneNumberStatus.
    /// </summary>
    public class PhoneNumberStatus : ConstantClass
    {

        /// <summary>
        /// Constant AcquireFailed for PhoneNumberStatus
        /// </summary>
        public static readonly PhoneNumberStatus AcquireFailed = new PhoneNumberStatus("AcquireFailed");
        /// <summary>
        /// Constant AcquireInProgress for PhoneNumberStatus
        /// </summary>
        public static readonly PhoneNumberStatus AcquireInProgress = new PhoneNumberStatus("AcquireInProgress");
        /// <summary>
        /// Constant Assigned for PhoneNumberStatus
        /// </summary>
        public static readonly PhoneNumberStatus Assigned = new PhoneNumberStatus("Assigned");
        /// <summary>
        /// Constant Cancelled for PhoneNumberStatus
        /// </summary>
        public static readonly PhoneNumberStatus Cancelled = new PhoneNumberStatus("Cancelled");
        /// <summary>
        /// Constant DeleteFailed for PhoneNumberStatus
        /// </summary>
        public static readonly PhoneNumberStatus DeleteFailed = new PhoneNumberStatus("DeleteFailed");
        /// <summary>
        /// Constant DeleteInProgress for PhoneNumberStatus
        /// </summary>
        public static readonly PhoneNumberStatus DeleteInProgress = new PhoneNumberStatus("DeleteInProgress");
        /// <summary>
        /// Constant PortinCancelRequested for PhoneNumberStatus
        /// </summary>
        public static readonly PhoneNumberStatus PortinCancelRequested = new PhoneNumberStatus("PortinCancelRequested");
        /// <summary>
        /// Constant PortinInProgress for PhoneNumberStatus
        /// </summary>
        public static readonly PhoneNumberStatus PortinInProgress = new PhoneNumberStatus("PortinInProgress");
        /// <summary>
        /// Constant ReleaseFailed for PhoneNumberStatus
        /// </summary>
        public static readonly PhoneNumberStatus ReleaseFailed = new PhoneNumberStatus("ReleaseFailed");
        /// <summary>
        /// Constant ReleaseInProgress for PhoneNumberStatus
        /// </summary>
        public static readonly PhoneNumberStatus ReleaseInProgress = new PhoneNumberStatus("ReleaseInProgress");
        /// <summary>
        /// Constant Unassigned for PhoneNumberStatus
        /// </summary>
        public static readonly PhoneNumberStatus Unassigned = new PhoneNumberStatus("Unassigned");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PhoneNumberStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PhoneNumberStatus FindValue(string value)
        {
            return FindValue<PhoneNumberStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PhoneNumberStatus(string value)
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
        /// Constant Local for PhoneNumberType
        /// </summary>
        public static readonly PhoneNumberType Local = new PhoneNumberType("Local");
        /// <summary>
        /// Constant TollFree for PhoneNumberType
        /// </summary>
        public static readonly PhoneNumberType TollFree = new PhoneNumberType("TollFree");

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
    /// Constants used for properties of type ProxySessionStatus.
    /// </summary>
    public class ProxySessionStatus : ConstantClass
    {

        /// <summary>
        /// Constant Closed for ProxySessionStatus
        /// </summary>
        public static readonly ProxySessionStatus Closed = new ProxySessionStatus("Closed");
        /// <summary>
        /// Constant InProgress for ProxySessionStatus
        /// </summary>
        public static readonly ProxySessionStatus InProgress = new ProxySessionStatus("InProgress");
        /// <summary>
        /// Constant Open for ProxySessionStatus
        /// </summary>
        public static readonly ProxySessionStatus Open = new ProxySessionStatus("Open");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ProxySessionStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ProxySessionStatus FindValue(string value)
        {
            return FindValue<ProxySessionStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ProxySessionStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SipRuleTriggerType.
    /// </summary>
    public class SipRuleTriggerType : ConstantClass
    {

        /// <summary>
        /// Constant RequestUriHostname for SipRuleTriggerType
        /// </summary>
        public static readonly SipRuleTriggerType RequestUriHostname = new SipRuleTriggerType("RequestUriHostname");
        /// <summary>
        /// Constant ToPhoneNumber for SipRuleTriggerType
        /// </summary>
        public static readonly SipRuleTriggerType ToPhoneNumber = new SipRuleTriggerType("ToPhoneNumber");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SipRuleTriggerType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SipRuleTriggerType FindValue(string value)
        {
            return FindValue<SipRuleTriggerType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SipRuleTriggerType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type VoiceConnectorAwsRegion.
    /// </summary>
    public class VoiceConnectorAwsRegion : ConstantClass
    {

        /// <summary>
        /// Constant ApNortheast1 for VoiceConnectorAwsRegion
        /// </summary>
        public static readonly VoiceConnectorAwsRegion ApNortheast1 = new VoiceConnectorAwsRegion("ap-northeast-1");
        /// <summary>
        /// Constant ApNortheast2 for VoiceConnectorAwsRegion
        /// </summary>
        public static readonly VoiceConnectorAwsRegion ApNortheast2 = new VoiceConnectorAwsRegion("ap-northeast-2");
        /// <summary>
        /// Constant ApSoutheast1 for VoiceConnectorAwsRegion
        /// </summary>
        public static readonly VoiceConnectorAwsRegion ApSoutheast1 = new VoiceConnectorAwsRegion("ap-southeast-1");
        /// <summary>
        /// Constant ApSoutheast2 for VoiceConnectorAwsRegion
        /// </summary>
        public static readonly VoiceConnectorAwsRegion ApSoutheast2 = new VoiceConnectorAwsRegion("ap-southeast-2");
        /// <summary>
        /// Constant CaCentral1 for VoiceConnectorAwsRegion
        /// </summary>
        public static readonly VoiceConnectorAwsRegion CaCentral1 = new VoiceConnectorAwsRegion("ca-central-1");
        /// <summary>
        /// Constant EuCentral1 for VoiceConnectorAwsRegion
        /// </summary>
        public static readonly VoiceConnectorAwsRegion EuCentral1 = new VoiceConnectorAwsRegion("eu-central-1");
        /// <summary>
        /// Constant EuWest1 for VoiceConnectorAwsRegion
        /// </summary>
        public static readonly VoiceConnectorAwsRegion EuWest1 = new VoiceConnectorAwsRegion("eu-west-1");
        /// <summary>
        /// Constant EuWest2 for VoiceConnectorAwsRegion
        /// </summary>
        public static readonly VoiceConnectorAwsRegion EuWest2 = new VoiceConnectorAwsRegion("eu-west-2");
        /// <summary>
        /// Constant UsEast1 for VoiceConnectorAwsRegion
        /// </summary>
        public static readonly VoiceConnectorAwsRegion UsEast1 = new VoiceConnectorAwsRegion("us-east-1");
        /// <summary>
        /// Constant UsWest2 for VoiceConnectorAwsRegion
        /// </summary>
        public static readonly VoiceConnectorAwsRegion UsWest2 = new VoiceConnectorAwsRegion("us-west-2");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public VoiceConnectorAwsRegion(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static VoiceConnectorAwsRegion FindValue(string value)
        {
            return FindValue<VoiceConnectorAwsRegion>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator VoiceConnectorAwsRegion(string value)
        {
            return FindValue(value);
        }
    }

}