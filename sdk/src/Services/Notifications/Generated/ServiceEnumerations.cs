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
 * Do not modify this file. This file is generated from the notifications-2018-05-10.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.Notifications
{

    /// <summary>
    /// Constants used for properties of type AccessStatus.
    /// </summary>
    public class AccessStatus : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for AccessStatus
        /// </summary>
        public static readonly AccessStatus DISABLED = new AccessStatus("DISABLED");
        /// <summary>
        /// Constant ENABLED for AccessStatus
        /// </summary>
        public static readonly AccessStatus ENABLED = new AccessStatus("ENABLED");
        /// <summary>
        /// Constant FAILED for AccessStatus
        /// </summary>
        public static readonly AccessStatus FAILED = new AccessStatus("FAILED");
        /// <summary>
        /// Constant PENDING for AccessStatus
        /// </summary>
        public static readonly AccessStatus PENDING = new AccessStatus("PENDING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AccessStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AccessStatus FindValue(string value)
        {
            return FindValue<AccessStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AccessStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AccountContactType.
    /// </summary>
    public class AccountContactType : ConstantClass
    {

        /// <summary>
        /// Constant ACCOUNT_ALTERNATE_BILLING for AccountContactType
        /// </summary>
        public static readonly AccountContactType ACCOUNT_ALTERNATE_BILLING = new AccountContactType("ACCOUNT_ALTERNATE_BILLING");
        /// <summary>
        /// Constant ACCOUNT_ALTERNATE_OPERATIONS for AccountContactType
        /// </summary>
        public static readonly AccountContactType ACCOUNT_ALTERNATE_OPERATIONS = new AccountContactType("ACCOUNT_ALTERNATE_OPERATIONS");
        /// <summary>
        /// Constant ACCOUNT_ALTERNATE_SECURITY for AccountContactType
        /// </summary>
        public static readonly AccountContactType ACCOUNT_ALTERNATE_SECURITY = new AccountContactType("ACCOUNT_ALTERNATE_SECURITY");
        /// <summary>
        /// Constant ACCOUNT_PRIMARY for AccountContactType
        /// </summary>
        public static readonly AccountContactType ACCOUNT_PRIMARY = new AccountContactType("ACCOUNT_PRIMARY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AccountContactType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AccountContactType FindValue(string value)
        {
            return FindValue<AccountContactType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AccountContactType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AggregationDuration.
    /// </summary>
    public class AggregationDuration : ConstantClass
    {

        /// <summary>
        /// Constant LONG for AggregationDuration
        /// </summary>
        public static readonly AggregationDuration LONG = new AggregationDuration("LONG");
        /// <summary>
        /// Constant NONE for AggregationDuration
        /// </summary>
        public static readonly AggregationDuration NONE = new AggregationDuration("NONE");
        /// <summary>
        /// Constant SHORT for AggregationDuration
        /// </summary>
        public static readonly AggregationDuration SHORT = new AggregationDuration("SHORT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AggregationDuration(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AggregationDuration FindValue(string value)
        {
            return FindValue<AggregationDuration>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AggregationDuration(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AggregationEventType.
    /// </summary>
    public class AggregationEventType : ConstantClass
    {

        /// <summary>
        /// Constant AGGREGATE for AggregationEventType
        /// </summary>
        public static readonly AggregationEventType AGGREGATE = new AggregationEventType("AGGREGATE");
        /// <summary>
        /// Constant CHILD for AggregationEventType
        /// </summary>
        public static readonly AggregationEventType CHILD = new AggregationEventType("CHILD");
        /// <summary>
        /// Constant NONE for AggregationEventType
        /// </summary>
        public static readonly AggregationEventType NONE = new AggregationEventType("NONE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AggregationEventType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AggregationEventType FindValue(string value)
        {
            return FindValue<AggregationEventType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AggregationEventType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ChannelAssociationOverrideOption.
    /// </summary>
    public class ChannelAssociationOverrideOption : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for ChannelAssociationOverrideOption
        /// </summary>
        public static readonly ChannelAssociationOverrideOption DISABLED = new ChannelAssociationOverrideOption("DISABLED");
        /// <summary>
        /// Constant ENABLED for ChannelAssociationOverrideOption
        /// </summary>
        public static readonly ChannelAssociationOverrideOption ENABLED = new ChannelAssociationOverrideOption("ENABLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ChannelAssociationOverrideOption(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ChannelAssociationOverrideOption FindValue(string value)
        {
            return FindValue<ChannelAssociationOverrideOption>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ChannelAssociationOverrideOption(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ChannelType.
    /// </summary>
    public class ChannelType : ConstantClass
    {

        /// <summary>
        /// Constant ACCOUNT_CONTACT for ChannelType
        /// </summary>
        public static readonly ChannelType ACCOUNT_CONTACT = new ChannelType("ACCOUNT_CONTACT");
        /// <summary>
        /// Constant CHATBOT for ChannelType
        /// </summary>
        public static readonly ChannelType CHATBOT = new ChannelType("CHATBOT");
        /// <summary>
        /// Constant EMAIL for ChannelType
        /// </summary>
        public static readonly ChannelType EMAIL = new ChannelType("EMAIL");
        /// <summary>
        /// Constant MOBILE for ChannelType
        /// </summary>
        public static readonly ChannelType MOBILE = new ChannelType("MOBILE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ChannelType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ChannelType FindValue(string value)
        {
            return FindValue<ChannelType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ChannelType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type EventRuleStatus.
    /// </summary>
    public class EventRuleStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for EventRuleStatus
        /// </summary>
        public static readonly EventRuleStatus ACTIVE = new EventRuleStatus("ACTIVE");
        /// <summary>
        /// Constant CREATING for EventRuleStatus
        /// </summary>
        public static readonly EventRuleStatus CREATING = new EventRuleStatus("CREATING");
        /// <summary>
        /// Constant DELETING for EventRuleStatus
        /// </summary>
        public static readonly EventRuleStatus DELETING = new EventRuleStatus("DELETING");
        /// <summary>
        /// Constant INACTIVE for EventRuleStatus
        /// </summary>
        public static readonly EventRuleStatus INACTIVE = new EventRuleStatus("INACTIVE");
        /// <summary>
        /// Constant UPDATING for EventRuleStatus
        /// </summary>
        public static readonly EventRuleStatus UPDATING = new EventRuleStatus("UPDATING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EventRuleStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EventRuleStatus FindValue(string value)
        {
            return FindValue<EventRuleStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EventRuleStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type EventStatus.
    /// </summary>
    public class EventStatus : ConstantClass
    {

        /// <summary>
        /// Constant HEALTHY for EventStatus
        /// </summary>
        public static readonly EventStatus HEALTHY = new EventStatus("HEALTHY");
        /// <summary>
        /// Constant UNHEALTHY for EventStatus
        /// </summary>
        public static readonly EventStatus UNHEALTHY = new EventStatus("UNHEALTHY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EventStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EventStatus FindValue(string value)
        {
            return FindValue<EventStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EventStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type LocaleCode.
    /// </summary>
    public class LocaleCode : ConstantClass
    {

        /// <summary>
        /// Constant De_DE for LocaleCode
        /// </summary>
        public static readonly LocaleCode De_DE = new LocaleCode("de_DE");
        /// <summary>
        /// Constant En_CA for LocaleCode
        /// </summary>
        public static readonly LocaleCode En_CA = new LocaleCode("en_CA");
        /// <summary>
        /// Constant En_UK for LocaleCode
        /// </summary>
        public static readonly LocaleCode En_UK = new LocaleCode("en_UK");
        /// <summary>
        /// Constant En_US for LocaleCode
        /// </summary>
        public static readonly LocaleCode En_US = new LocaleCode("en_US");
        /// <summary>
        /// Constant Es_ES for LocaleCode
        /// </summary>
        public static readonly LocaleCode Es_ES = new LocaleCode("es_ES");
        /// <summary>
        /// Constant Fr_CA for LocaleCode
        /// </summary>
        public static readonly LocaleCode Fr_CA = new LocaleCode("fr_CA");
        /// <summary>
        /// Constant Fr_FR for LocaleCode
        /// </summary>
        public static readonly LocaleCode Fr_FR = new LocaleCode("fr_FR");
        /// <summary>
        /// Constant Id_ID for LocaleCode
        /// </summary>
        public static readonly LocaleCode Id_ID = new LocaleCode("id_ID");
        /// <summary>
        /// Constant It_IT for LocaleCode
        /// </summary>
        public static readonly LocaleCode It_IT = new LocaleCode("it_IT");
        /// <summary>
        /// Constant Ja_JP for LocaleCode
        /// </summary>
        public static readonly LocaleCode Ja_JP = new LocaleCode("ja_JP");
        /// <summary>
        /// Constant Ko_KR for LocaleCode
        /// </summary>
        public static readonly LocaleCode Ko_KR = new LocaleCode("ko_KR");
        /// <summary>
        /// Constant Pt_BR for LocaleCode
        /// </summary>
        public static readonly LocaleCode Pt_BR = new LocaleCode("pt_BR");
        /// <summary>
        /// Constant Tr_TR for LocaleCode
        /// </summary>
        public static readonly LocaleCode Tr_TR = new LocaleCode("tr_TR");
        /// <summary>
        /// Constant Zh_CN for LocaleCode
        /// </summary>
        public static readonly LocaleCode Zh_CN = new LocaleCode("zh_CN");
        /// <summary>
        /// Constant Zh_TW for LocaleCode
        /// </summary>
        public static readonly LocaleCode Zh_TW = new LocaleCode("zh_TW");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public LocaleCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LocaleCode FindValue(string value)
        {
            return FindValue<LocaleCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator LocaleCode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type MediaElementType.
    /// </summary>
    public class MediaElementType : ConstantClass
    {

        /// <summary>
        /// Constant IMAGE for MediaElementType
        /// </summary>
        public static readonly MediaElementType IMAGE = new MediaElementType("IMAGE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MediaElementType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MediaElementType FindValue(string value)
        {
            return FindValue<MediaElementType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MediaElementType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type MemberAccountNotificationConfigurationStatus.
    /// </summary>
    public class MemberAccountNotificationConfigurationStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for MemberAccountNotificationConfigurationStatus
        /// </summary>
        public static readonly MemberAccountNotificationConfigurationStatus ACTIVE = new MemberAccountNotificationConfigurationStatus("ACTIVE");
        /// <summary>
        /// Constant CREATING for MemberAccountNotificationConfigurationStatus
        /// </summary>
        public static readonly MemberAccountNotificationConfigurationStatus CREATING = new MemberAccountNotificationConfigurationStatus("CREATING");
        /// <summary>
        /// Constant DELETING for MemberAccountNotificationConfigurationStatus
        /// </summary>
        public static readonly MemberAccountNotificationConfigurationStatus DELETING = new MemberAccountNotificationConfigurationStatus("DELETING");
        /// <summary>
        /// Constant INACTIVE for MemberAccountNotificationConfigurationStatus
        /// </summary>
        public static readonly MemberAccountNotificationConfigurationStatus INACTIVE = new MemberAccountNotificationConfigurationStatus("INACTIVE");
        /// <summary>
        /// Constant PENDING for MemberAccountNotificationConfigurationStatus
        /// </summary>
        public static readonly MemberAccountNotificationConfigurationStatus PENDING = new MemberAccountNotificationConfigurationStatus("PENDING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MemberAccountNotificationConfigurationStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MemberAccountNotificationConfigurationStatus FindValue(string value)
        {
            return FindValue<MemberAccountNotificationConfigurationStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MemberAccountNotificationConfigurationStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type NotificationConfigurationStatus.
    /// </summary>
    public class NotificationConfigurationStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for NotificationConfigurationStatus
        /// </summary>
        public static readonly NotificationConfigurationStatus ACTIVE = new NotificationConfigurationStatus("ACTIVE");
        /// <summary>
        /// Constant DELETING for NotificationConfigurationStatus
        /// </summary>
        public static readonly NotificationConfigurationStatus DELETING = new NotificationConfigurationStatus("DELETING");
        /// <summary>
        /// Constant INACTIVE for NotificationConfigurationStatus
        /// </summary>
        public static readonly NotificationConfigurationStatus INACTIVE = new NotificationConfigurationStatus("INACTIVE");
        /// <summary>
        /// Constant PARTIALLY_ACTIVE for NotificationConfigurationStatus
        /// </summary>
        public static readonly NotificationConfigurationStatus PARTIALLY_ACTIVE = new NotificationConfigurationStatus("PARTIALLY_ACTIVE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public NotificationConfigurationStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static NotificationConfigurationStatus FindValue(string value)
        {
            return FindValue<NotificationConfigurationStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator NotificationConfigurationStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type NotificationConfigurationSubtype.
    /// </summary>
    public class NotificationConfigurationSubtype : ConstantClass
    {

        /// <summary>
        /// Constant ACCOUNT for NotificationConfigurationSubtype
        /// </summary>
        public static readonly NotificationConfigurationSubtype ACCOUNT = new NotificationConfigurationSubtype("ACCOUNT");
        /// <summary>
        /// Constant ADMIN_MANAGED for NotificationConfigurationSubtype
        /// </summary>
        public static readonly NotificationConfigurationSubtype ADMIN_MANAGED = new NotificationConfigurationSubtype("ADMIN_MANAGED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public NotificationConfigurationSubtype(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static NotificationConfigurationSubtype FindValue(string value)
        {
            return FindValue<NotificationConfigurationSubtype>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator NotificationConfigurationSubtype(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type NotificationHubStatus.
    /// </summary>
    public class NotificationHubStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for NotificationHubStatus
        /// </summary>
        public static readonly NotificationHubStatus ACTIVE = new NotificationHubStatus("ACTIVE");
        /// <summary>
        /// Constant DEREGISTERING for NotificationHubStatus
        /// </summary>
        public static readonly NotificationHubStatus DEREGISTERING = new NotificationHubStatus("DEREGISTERING");
        /// <summary>
        /// Constant INACTIVE for NotificationHubStatus
        /// </summary>
        public static readonly NotificationHubStatus INACTIVE = new NotificationHubStatus("INACTIVE");
        /// <summary>
        /// Constant REGISTERING for NotificationHubStatus
        /// </summary>
        public static readonly NotificationHubStatus REGISTERING = new NotificationHubStatus("REGISTERING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public NotificationHubStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static NotificationHubStatus FindValue(string value)
        {
            return FindValue<NotificationHubStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator NotificationHubStatus(string value)
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
        /// Constant ALERT for NotificationType
        /// </summary>
        public static readonly NotificationType ALERT = new NotificationType("ALERT");
        /// <summary>
        /// Constant ANNOUNCEMENT for NotificationType
        /// </summary>
        public static readonly NotificationType ANNOUNCEMENT = new NotificationType("ANNOUNCEMENT");
        /// <summary>
        /// Constant INFORMATIONAL for NotificationType
        /// </summary>
        public static readonly NotificationType INFORMATIONAL = new NotificationType("INFORMATIONAL");
        /// <summary>
        /// Constant WARNING for NotificationType
        /// </summary>
        public static readonly NotificationType WARNING = new NotificationType("WARNING");

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
    /// Constants used for properties of type SchemaVersion.
    /// </summary>
    public class SchemaVersion : ConstantClass
    {

        /// <summary>
        /// Constant V10 for SchemaVersion
        /// </summary>
        public static readonly SchemaVersion V10 = new SchemaVersion("v1.0");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SchemaVersion(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SchemaVersion FindValue(string value)
        {
            return FindValue<SchemaVersion>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SchemaVersion(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TextPartType.
    /// </summary>
    public class TextPartType : ConstantClass
    {

        /// <summary>
        /// Constant LOCALIZED_TEXT for TextPartType
        /// </summary>
        public static readonly TextPartType LOCALIZED_TEXT = new TextPartType("LOCALIZED_TEXT");
        /// <summary>
        /// Constant PLAIN_TEXT for TextPartType
        /// </summary>
        public static readonly TextPartType PLAIN_TEXT = new TextPartType("PLAIN_TEXT");
        /// <summary>
        /// Constant URL for TextPartType
        /// </summary>
        public static readonly TextPartType URL = new TextPartType("URL");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TextPartType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TextPartType FindValue(string value)
        {
            return FindValue<TextPartType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TextPartType(string value)
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
        public static readonly ValidationExceptionReason FieldValidationFailed = new ValidationExceptionReason("fieldValidationFailed");
        /// <summary>
        /// Constant Other for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason Other = new ValidationExceptionReason("other");

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

}