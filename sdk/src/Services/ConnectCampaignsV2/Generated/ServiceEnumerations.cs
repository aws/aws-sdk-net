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
 * Do not modify this file. This file is generated from the connectcampaignsv2-2024-04-23.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.ConnectCampaignsV2
{

    /// <summary>
    /// Constants used for properties of type CampaignDeletionPolicy.
    /// </summary>
    public class CampaignDeletionPolicy : ConstantClass
    {

        /// <summary>
        /// Constant DELETE_ALL for CampaignDeletionPolicy
        /// </summary>
        public static readonly CampaignDeletionPolicy DELETE_ALL = new CampaignDeletionPolicy("DELETE_ALL");
        /// <summary>
        /// Constant RETAIN_ALL for CampaignDeletionPolicy
        /// </summary>
        public static readonly CampaignDeletionPolicy RETAIN_ALL = new CampaignDeletionPolicy("RETAIN_ALL");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CampaignDeletionPolicy(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CampaignDeletionPolicy FindValue(string value)
        {
            return FindValue<CampaignDeletionPolicy>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CampaignDeletionPolicy(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CampaignState.
    /// </summary>
    public class CampaignState : ConstantClass
    {

        /// <summary>
        /// Constant Completed for CampaignState
        /// </summary>
        public static readonly CampaignState Completed = new CampaignState("Completed");
        /// <summary>
        /// Constant Failed for CampaignState
        /// </summary>
        public static readonly CampaignState Failed = new CampaignState("Failed");
        /// <summary>
        /// Constant Initialized for CampaignState
        /// </summary>
        public static readonly CampaignState Initialized = new CampaignState("Initialized");
        /// <summary>
        /// Constant Paused for CampaignState
        /// </summary>
        public static readonly CampaignState Paused = new CampaignState("Paused");
        /// <summary>
        /// Constant Running for CampaignState
        /// </summary>
        public static readonly CampaignState Running = new CampaignState("Running");
        /// <summary>
        /// Constant Stopped for CampaignState
        /// </summary>
        public static readonly CampaignState Stopped = new CampaignState("Stopped");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CampaignState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CampaignState FindValue(string value)
        {
            return FindValue<CampaignState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CampaignState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ChannelSubtype.
    /// </summary>
    public class ChannelSubtype : ConstantClass
    {

        /// <summary>
        /// Constant EMAIL for ChannelSubtype
        /// </summary>
        public static readonly ChannelSubtype EMAIL = new ChannelSubtype("EMAIL");
        /// <summary>
        /// Constant SMS for ChannelSubtype
        /// </summary>
        public static readonly ChannelSubtype SMS = new ChannelSubtype("SMS");
        /// <summary>
        /// Constant TELEPHONY for ChannelSubtype
        /// </summary>
        public static readonly ChannelSubtype TELEPHONY = new ChannelSubtype("TELEPHONY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ChannelSubtype(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ChannelSubtype FindValue(string value)
        {
            return FindValue<ChannelSubtype>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ChannelSubtype(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CommunicationLimitsConfigType.
    /// </summary>
    public class CommunicationLimitsConfigType : ConstantClass
    {

        /// <summary>
        /// Constant ALL_CHANNEL_SUBTYPES for CommunicationLimitsConfigType
        /// </summary>
        public static readonly CommunicationLimitsConfigType ALL_CHANNEL_SUBTYPES = new CommunicationLimitsConfigType("ALL_CHANNEL_SUBTYPES");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CommunicationLimitsConfigType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CommunicationLimitsConfigType FindValue(string value)
        {
            return FindValue<CommunicationLimitsConfigType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CommunicationLimitsConfigType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CommunicationLimitTimeUnit.
    /// </summary>
    public class CommunicationLimitTimeUnit : ConstantClass
    {

        /// <summary>
        /// Constant DAY for CommunicationLimitTimeUnit
        /// </summary>
        public static readonly CommunicationLimitTimeUnit DAY = new CommunicationLimitTimeUnit("DAY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CommunicationLimitTimeUnit(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CommunicationLimitTimeUnit FindValue(string value)
        {
            return FindValue<CommunicationLimitTimeUnit>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CommunicationLimitTimeUnit(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CommunicationTimeConfigType.
    /// </summary>
    public class CommunicationTimeConfigType : ConstantClass
    {

        /// <summary>
        /// Constant EMAIL for CommunicationTimeConfigType
        /// </summary>
        public static readonly CommunicationTimeConfigType EMAIL = new CommunicationTimeConfigType("EMAIL");
        /// <summary>
        /// Constant SMS for CommunicationTimeConfigType
        /// </summary>
        public static readonly CommunicationTimeConfigType SMS = new CommunicationTimeConfigType("SMS");
        /// <summary>
        /// Constant TELEPHONY for CommunicationTimeConfigType
        /// </summary>
        public static readonly CommunicationTimeConfigType TELEPHONY = new CommunicationTimeConfigType("TELEPHONY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CommunicationTimeConfigType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CommunicationTimeConfigType FindValue(string value)
        {
            return FindValue<CommunicationTimeConfigType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CommunicationTimeConfigType(string value)
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
        /// Constant FRIDAY for DayOfWeek
        /// </summary>
        public static readonly DayOfWeek FRIDAY = new DayOfWeek("FRIDAY");
        /// <summary>
        /// Constant MONDAY for DayOfWeek
        /// </summary>
        public static readonly DayOfWeek MONDAY = new DayOfWeek("MONDAY");
        /// <summary>
        /// Constant SATURDAY for DayOfWeek
        /// </summary>
        public static readonly DayOfWeek SATURDAY = new DayOfWeek("SATURDAY");
        /// <summary>
        /// Constant SUNDAY for DayOfWeek
        /// </summary>
        public static readonly DayOfWeek SUNDAY = new DayOfWeek("SUNDAY");
        /// <summary>
        /// Constant THURSDAY for DayOfWeek
        /// </summary>
        public static readonly DayOfWeek THURSDAY = new DayOfWeek("THURSDAY");
        /// <summary>
        /// Constant TUESDAY for DayOfWeek
        /// </summary>
        public static readonly DayOfWeek TUESDAY = new DayOfWeek("TUESDAY");
        /// <summary>
        /// Constant WEDNESDAY for DayOfWeek
        /// </summary>
        public static readonly DayOfWeek WEDNESDAY = new DayOfWeek("WEDNESDAY");

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
    /// Constants used for properties of type EventType.
    /// </summary>
    public class EventType : ConstantClass
    {

        /// <summary>
        /// Constant CampaignEmail for EventType
        /// </summary>
        public static readonly EventType CampaignEmail = new EventType("Campaign-Email");
        /// <summary>
        /// Constant CampaignOrchestration for EventType
        /// </summary>
        public static readonly EventType CampaignOrchestration = new EventType("Campaign-Orchestration");
        /// <summary>
        /// Constant CampaignSMS for EventType
        /// </summary>
        public static readonly EventType CampaignSMS = new EventType("Campaign-SMS");
        /// <summary>
        /// Constant CampaignTelephony for EventType
        /// </summary>
        public static readonly EventType CampaignTelephony = new EventType("Campaign-Telephony");

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
    /// Constants used for properties of type FailureCode.
    /// </summary>
    public class FailureCode : ConstantClass
    {

        /// <summary>
        /// Constant BufferLimitExceeded for FailureCode
        /// </summary>
        public static readonly FailureCode BufferLimitExceeded = new FailureCode("BufferLimitExceeded");
        /// <summary>
        /// Constant InvalidInput for FailureCode
        /// </summary>
        public static readonly FailureCode InvalidInput = new FailureCode("InvalidInput");
        /// <summary>
        /// Constant RequestThrottled for FailureCode
        /// </summary>
        public static readonly FailureCode RequestThrottled = new FailureCode("RequestThrottled");
        /// <summary>
        /// Constant UnknownError for FailureCode
        /// </summary>
        public static readonly FailureCode UnknownError = new FailureCode("UnknownError");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FailureCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FailureCode FindValue(string value)
        {
            return FindValue<FailureCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FailureCode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type GetCampaignStateBatchFailureCode.
    /// </summary>
    public class GetCampaignStateBatchFailureCode : ConstantClass
    {

        /// <summary>
        /// Constant ResourceNotFound for GetCampaignStateBatchFailureCode
        /// </summary>
        public static readonly GetCampaignStateBatchFailureCode ResourceNotFound = new GetCampaignStateBatchFailureCode("ResourceNotFound");
        /// <summary>
        /// Constant UnknownError for GetCampaignStateBatchFailureCode
        /// </summary>
        public static readonly GetCampaignStateBatchFailureCode UnknownError = new GetCampaignStateBatchFailureCode("UnknownError");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public GetCampaignStateBatchFailureCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static GetCampaignStateBatchFailureCode FindValue(string value)
        {
            return FindValue<GetCampaignStateBatchFailureCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator GetCampaignStateBatchFailureCode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type InstanceIdFilterOperator.
    /// </summary>
    public class InstanceIdFilterOperator : ConstantClass
    {

        /// <summary>
        /// Constant Eq for InstanceIdFilterOperator
        /// </summary>
        public static readonly InstanceIdFilterOperator Eq = new InstanceIdFilterOperator("Eq");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public InstanceIdFilterOperator(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static InstanceIdFilterOperator FindValue(string value)
        {
            return FindValue<InstanceIdFilterOperator>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator InstanceIdFilterOperator(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type InstanceLimitsHandling.
    /// </summary>
    public class InstanceLimitsHandling : ConstantClass
    {

        /// <summary>
        /// Constant OPT_IN for InstanceLimitsHandling
        /// </summary>
        public static readonly InstanceLimitsHandling OPT_IN = new InstanceLimitsHandling("OPT_IN");
        /// <summary>
        /// Constant OPT_OUT for InstanceLimitsHandling
        /// </summary>
        public static readonly InstanceLimitsHandling OPT_OUT = new InstanceLimitsHandling("OPT_OUT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public InstanceLimitsHandling(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static InstanceLimitsHandling FindValue(string value)
        {
            return FindValue<InstanceLimitsHandling>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator InstanceLimitsHandling(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type InstanceOnboardingJobFailureCode.
    /// </summary>
    public class InstanceOnboardingJobFailureCode : ConstantClass
    {

        /// <summary>
        /// Constant EVENT_BRIDGE_ACCESS_DENIED for InstanceOnboardingJobFailureCode
        /// </summary>
        public static readonly InstanceOnboardingJobFailureCode EVENT_BRIDGE_ACCESS_DENIED = new InstanceOnboardingJobFailureCode("EVENT_BRIDGE_ACCESS_DENIED");
        /// <summary>
        /// Constant EVENT_BRIDGE_MANAGED_RULE_LIMIT_EXCEEDED for InstanceOnboardingJobFailureCode
        /// </summary>
        public static readonly InstanceOnboardingJobFailureCode EVENT_BRIDGE_MANAGED_RULE_LIMIT_EXCEEDED = new InstanceOnboardingJobFailureCode("EVENT_BRIDGE_MANAGED_RULE_LIMIT_EXCEEDED");
        /// <summary>
        /// Constant IAM_ACCESS_DENIED for InstanceOnboardingJobFailureCode
        /// </summary>
        public static readonly InstanceOnboardingJobFailureCode IAM_ACCESS_DENIED = new InstanceOnboardingJobFailureCode("IAM_ACCESS_DENIED");
        /// <summary>
        /// Constant INTERNAL_FAILURE for InstanceOnboardingJobFailureCode
        /// </summary>
        public static readonly InstanceOnboardingJobFailureCode INTERNAL_FAILURE = new InstanceOnboardingJobFailureCode("INTERNAL_FAILURE");
        /// <summary>
        /// Constant KMS_ACCESS_DENIED for InstanceOnboardingJobFailureCode
        /// </summary>
        public static readonly InstanceOnboardingJobFailureCode KMS_ACCESS_DENIED = new InstanceOnboardingJobFailureCode("KMS_ACCESS_DENIED");
        /// <summary>
        /// Constant KMS_KEY_NOT_FOUND for InstanceOnboardingJobFailureCode
        /// </summary>
        public static readonly InstanceOnboardingJobFailureCode KMS_KEY_NOT_FOUND = new InstanceOnboardingJobFailureCode("KMS_KEY_NOT_FOUND");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public InstanceOnboardingJobFailureCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static InstanceOnboardingJobFailureCode FindValue(string value)
        {
            return FindValue<InstanceOnboardingJobFailureCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator InstanceOnboardingJobFailureCode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type InstanceOnboardingJobStatusCode.
    /// </summary>
    public class InstanceOnboardingJobStatusCode : ConstantClass
    {

        /// <summary>
        /// Constant FAILED for InstanceOnboardingJobStatusCode
        /// </summary>
        public static readonly InstanceOnboardingJobStatusCode FAILED = new InstanceOnboardingJobStatusCode("FAILED");
        /// <summary>
        /// Constant IN_PROGRESS for InstanceOnboardingJobStatusCode
        /// </summary>
        public static readonly InstanceOnboardingJobStatusCode IN_PROGRESS = new InstanceOnboardingJobStatusCode("IN_PROGRESS");
        /// <summary>
        /// Constant SUCCEEDED for InstanceOnboardingJobStatusCode
        /// </summary>
        public static readonly InstanceOnboardingJobStatusCode SUCCEEDED = new InstanceOnboardingJobStatusCode("SUCCEEDED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public InstanceOnboardingJobStatusCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static InstanceOnboardingJobStatusCode FindValue(string value)
        {
            return FindValue<InstanceOnboardingJobStatusCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator InstanceOnboardingJobStatusCode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type LocalTimeZoneDetectionType.
    /// </summary>
    public class LocalTimeZoneDetectionType : ConstantClass
    {

        /// <summary>
        /// Constant AREA_CODE for LocalTimeZoneDetectionType
        /// </summary>
        public static readonly LocalTimeZoneDetectionType AREA_CODE = new LocalTimeZoneDetectionType("AREA_CODE");
        /// <summary>
        /// Constant ZIP_CODE for LocalTimeZoneDetectionType
        /// </summary>
        public static readonly LocalTimeZoneDetectionType ZIP_CODE = new LocalTimeZoneDetectionType("ZIP_CODE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public LocalTimeZoneDetectionType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LocalTimeZoneDetectionType FindValue(string value)
        {
            return FindValue<LocalTimeZoneDetectionType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator LocalTimeZoneDetectionType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ProfileOutboundRequestFailureCode.
    /// </summary>
    public class ProfileOutboundRequestFailureCode : ConstantClass
    {

        /// <summary>
        /// Constant Conflict for ProfileOutboundRequestFailureCode
        /// </summary>
        public static readonly ProfileOutboundRequestFailureCode Conflict = new ProfileOutboundRequestFailureCode("Conflict");
        /// <summary>
        /// Constant InvalidInput for ProfileOutboundRequestFailureCode
        /// </summary>
        public static readonly ProfileOutboundRequestFailureCode InvalidInput = new ProfileOutboundRequestFailureCode("InvalidInput");
        /// <summary>
        /// Constant RequestThrottled for ProfileOutboundRequestFailureCode
        /// </summary>
        public static readonly ProfileOutboundRequestFailureCode RequestThrottled = new ProfileOutboundRequestFailureCode("RequestThrottled");
        /// <summary>
        /// Constant ResourceNotFound for ProfileOutboundRequestFailureCode
        /// </summary>
        public static readonly ProfileOutboundRequestFailureCode ResourceNotFound = new ProfileOutboundRequestFailureCode("ResourceNotFound");
        /// <summary>
        /// Constant UnknownError for ProfileOutboundRequestFailureCode
        /// </summary>
        public static readonly ProfileOutboundRequestFailureCode UnknownError = new ProfileOutboundRequestFailureCode("UnknownError");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ProfileOutboundRequestFailureCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ProfileOutboundRequestFailureCode FindValue(string value)
        {
            return FindValue<ProfileOutboundRequestFailureCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ProfileOutboundRequestFailureCode(string value)
        {
            return FindValue(value);
        }
    }

}