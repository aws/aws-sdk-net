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
 * Do not modify this file. This file is generated from the codestar-notifications-2019-10-15.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.CodeStarNotifications
{

    /// <summary>
    /// Constants used for properties of type DetailType.
    /// </summary>
    public class DetailType : ConstantClass
    {

        /// <summary>
        /// Constant BASIC for DetailType
        /// </summary>
        public static readonly DetailType BASIC = new DetailType("BASIC");
        /// <summary>
        /// Constant FULL for DetailType
        /// </summary>
        public static readonly DetailType FULL = new DetailType("FULL");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DetailType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DetailType FindValue(string value)
        {
            return FindValue<DetailType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DetailType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ListEventTypesFilterName.
    /// </summary>
    public class ListEventTypesFilterName : ConstantClass
    {

        /// <summary>
        /// Constant RESOURCE_TYPE for ListEventTypesFilterName
        /// </summary>
        public static readonly ListEventTypesFilterName RESOURCE_TYPE = new ListEventTypesFilterName("RESOURCE_TYPE");
        /// <summary>
        /// Constant SERVICE_NAME for ListEventTypesFilterName
        /// </summary>
        public static readonly ListEventTypesFilterName SERVICE_NAME = new ListEventTypesFilterName("SERVICE_NAME");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ListEventTypesFilterName(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ListEventTypesFilterName FindValue(string value)
        {
            return FindValue<ListEventTypesFilterName>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ListEventTypesFilterName(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ListNotificationRulesFilterName.
    /// </summary>
    public class ListNotificationRulesFilterName : ConstantClass
    {

        /// <summary>
        /// Constant CREATED_BY for ListNotificationRulesFilterName
        /// </summary>
        public static readonly ListNotificationRulesFilterName CREATED_BY = new ListNotificationRulesFilterName("CREATED_BY");
        /// <summary>
        /// Constant EVENT_TYPE_ID for ListNotificationRulesFilterName
        /// </summary>
        public static readonly ListNotificationRulesFilterName EVENT_TYPE_ID = new ListNotificationRulesFilterName("EVENT_TYPE_ID");
        /// <summary>
        /// Constant RESOURCE for ListNotificationRulesFilterName
        /// </summary>
        public static readonly ListNotificationRulesFilterName RESOURCE = new ListNotificationRulesFilterName("RESOURCE");
        /// <summary>
        /// Constant TARGET_ADDRESS for ListNotificationRulesFilterName
        /// </summary>
        public static readonly ListNotificationRulesFilterName TARGET_ADDRESS = new ListNotificationRulesFilterName("TARGET_ADDRESS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ListNotificationRulesFilterName(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ListNotificationRulesFilterName FindValue(string value)
        {
            return FindValue<ListNotificationRulesFilterName>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ListNotificationRulesFilterName(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ListTargetsFilterName.
    /// </summary>
    public class ListTargetsFilterName : ConstantClass
    {

        /// <summary>
        /// Constant TARGET_ADDRESS for ListTargetsFilterName
        /// </summary>
        public static readonly ListTargetsFilterName TARGET_ADDRESS = new ListTargetsFilterName("TARGET_ADDRESS");
        /// <summary>
        /// Constant TARGET_STATUS for ListTargetsFilterName
        /// </summary>
        public static readonly ListTargetsFilterName TARGET_STATUS = new ListTargetsFilterName("TARGET_STATUS");
        /// <summary>
        /// Constant TARGET_TYPE for ListTargetsFilterName
        /// </summary>
        public static readonly ListTargetsFilterName TARGET_TYPE = new ListTargetsFilterName("TARGET_TYPE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ListTargetsFilterName(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ListTargetsFilterName FindValue(string value)
        {
            return FindValue<ListTargetsFilterName>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ListTargetsFilterName(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type NotificationRuleStatus.
    /// </summary>
    public class NotificationRuleStatus : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for NotificationRuleStatus
        /// </summary>
        public static readonly NotificationRuleStatus DISABLED = new NotificationRuleStatus("DISABLED");
        /// <summary>
        /// Constant ENABLED for NotificationRuleStatus
        /// </summary>
        public static readonly NotificationRuleStatus ENABLED = new NotificationRuleStatus("ENABLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public NotificationRuleStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static NotificationRuleStatus FindValue(string value)
        {
            return FindValue<NotificationRuleStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator NotificationRuleStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TargetStatus.
    /// </summary>
    public class TargetStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for TargetStatus
        /// </summary>
        public static readonly TargetStatus ACTIVE = new TargetStatus("ACTIVE");
        /// <summary>
        /// Constant DEACTIVATED for TargetStatus
        /// </summary>
        public static readonly TargetStatus DEACTIVATED = new TargetStatus("DEACTIVATED");
        /// <summary>
        /// Constant INACTIVE for TargetStatus
        /// </summary>
        public static readonly TargetStatus INACTIVE = new TargetStatus("INACTIVE");
        /// <summary>
        /// Constant PENDING for TargetStatus
        /// </summary>
        public static readonly TargetStatus PENDING = new TargetStatus("PENDING");
        /// <summary>
        /// Constant UNREACHABLE for TargetStatus
        /// </summary>
        public static readonly TargetStatus UNREACHABLE = new TargetStatus("UNREACHABLE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TargetStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TargetStatus FindValue(string value)
        {
            return FindValue<TargetStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TargetStatus(string value)
        {
            return FindValue(value);
        }
    }

}