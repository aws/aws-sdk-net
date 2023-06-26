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
 * Do not modify this file. This file is generated from the pinpoint-2016-12-01.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.Pinpoint
{

    /// <summary>
    /// Constants used for properties of type __EndpointTypesElement.
    /// </summary>
    public class __EndpointTypesElement : ConstantClass
    {

        /// <summary>
        /// Constant ADM for __EndpointTypesElement
        /// </summary>
        public static readonly __EndpointTypesElement ADM = new __EndpointTypesElement("ADM");
        /// <summary>
        /// Constant APNS for __EndpointTypesElement
        /// </summary>
        public static readonly __EndpointTypesElement APNS = new __EndpointTypesElement("APNS");
        /// <summary>
        /// Constant APNS_SANDBOX for __EndpointTypesElement
        /// </summary>
        public static readonly __EndpointTypesElement APNS_SANDBOX = new __EndpointTypesElement("APNS_SANDBOX");
        /// <summary>
        /// Constant APNS_VOIP for __EndpointTypesElement
        /// </summary>
        public static readonly __EndpointTypesElement APNS_VOIP = new __EndpointTypesElement("APNS_VOIP");
        /// <summary>
        /// Constant APNS_VOIP_SANDBOX for __EndpointTypesElement
        /// </summary>
        public static readonly __EndpointTypesElement APNS_VOIP_SANDBOX = new __EndpointTypesElement("APNS_VOIP_SANDBOX");
        /// <summary>
        /// Constant BAIDU for __EndpointTypesElement
        /// </summary>
        public static readonly __EndpointTypesElement BAIDU = new __EndpointTypesElement("BAIDU");
        /// <summary>
        /// Constant CUSTOM for __EndpointTypesElement
        /// </summary>
        public static readonly __EndpointTypesElement CUSTOM = new __EndpointTypesElement("CUSTOM");
        /// <summary>
        /// Constant EMAIL for __EndpointTypesElement
        /// </summary>
        public static readonly __EndpointTypesElement EMAIL = new __EndpointTypesElement("EMAIL");
        /// <summary>
        /// Constant GCM for __EndpointTypesElement
        /// </summary>
        public static readonly __EndpointTypesElement GCM = new __EndpointTypesElement("GCM");
        /// <summary>
        /// Constant IN_APP for __EndpointTypesElement
        /// </summary>
        public static readonly __EndpointTypesElement IN_APP = new __EndpointTypesElement("IN_APP");
        /// <summary>
        /// Constant PUSH for __EndpointTypesElement
        /// </summary>
        public static readonly __EndpointTypesElement PUSH = new __EndpointTypesElement("PUSH");
        /// <summary>
        /// Constant SMS for __EndpointTypesElement
        /// </summary>
        public static readonly __EndpointTypesElement SMS = new __EndpointTypesElement("SMS");
        /// <summary>
        /// Constant VOICE for __EndpointTypesElement
        /// </summary>
        public static readonly __EndpointTypesElement VOICE = new __EndpointTypesElement("VOICE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public __EndpointTypesElement(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static __EndpointTypesElement FindValue(string value)
        {
            return FindValue<__EndpointTypesElement>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator __EndpointTypesElement(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type __TimezoneEstimationMethodsElement.
    /// </summary>
    public class __TimezoneEstimationMethodsElement : ConstantClass
    {

        /// <summary>
        /// Constant PHONE_NUMBER for __TimezoneEstimationMethodsElement
        /// </summary>
        public static readonly __TimezoneEstimationMethodsElement PHONE_NUMBER = new __TimezoneEstimationMethodsElement("PHONE_NUMBER");
        /// <summary>
        /// Constant POSTAL_CODE for __TimezoneEstimationMethodsElement
        /// </summary>
        public static readonly __TimezoneEstimationMethodsElement POSTAL_CODE = new __TimezoneEstimationMethodsElement("POSTAL_CODE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public __TimezoneEstimationMethodsElement(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static __TimezoneEstimationMethodsElement FindValue(string value)
        {
            return FindValue<__TimezoneEstimationMethodsElement>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator __TimezoneEstimationMethodsElement(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Action.
    /// </summary>
    public class Action : ConstantClass
    {

        /// <summary>
        /// Constant DEEP_LINK for Action
        /// </summary>
        public static readonly Action DEEP_LINK = new Action("DEEP_LINK");
        /// <summary>
        /// Constant OPEN_APP for Action
        /// </summary>
        public static readonly Action OPEN_APP = new Action("OPEN_APP");
        /// <summary>
        /// Constant URL for Action
        /// </summary>
        public static readonly Action URL = new Action("URL");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Action(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Action FindValue(string value)
        {
            return FindValue<Action>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Action(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Alignment.
    /// </summary>
    public class Alignment : ConstantClass
    {

        /// <summary>
        /// Constant CENTER for Alignment
        /// </summary>
        public static readonly Alignment CENTER = new Alignment("CENTER");
        /// <summary>
        /// Constant LEFT for Alignment
        /// </summary>
        public static readonly Alignment LEFT = new Alignment("LEFT");
        /// <summary>
        /// Constant RIGHT for Alignment
        /// </summary>
        public static readonly Alignment RIGHT = new Alignment("RIGHT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Alignment(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Alignment FindValue(string value)
        {
            return FindValue<Alignment>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Alignment(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AttributeType.
    /// </summary>
    public class AttributeType : ConstantClass
    {

        /// <summary>
        /// Constant AFTER for AttributeType
        /// </summary>
        public static readonly AttributeType AFTER = new AttributeType("AFTER");
        /// <summary>
        /// Constant BEFORE for AttributeType
        /// </summary>
        public static readonly AttributeType BEFORE = new AttributeType("BEFORE");
        /// <summary>
        /// Constant BETWEEN for AttributeType
        /// </summary>
        public static readonly AttributeType BETWEEN = new AttributeType("BETWEEN");
        /// <summary>
        /// Constant CONTAINS for AttributeType
        /// </summary>
        public static readonly AttributeType CONTAINS = new AttributeType("CONTAINS");
        /// <summary>
        /// Constant EXCLUSIVE for AttributeType
        /// </summary>
        public static readonly AttributeType EXCLUSIVE = new AttributeType("EXCLUSIVE");
        /// <summary>
        /// Constant INCLUSIVE for AttributeType
        /// </summary>
        public static readonly AttributeType INCLUSIVE = new AttributeType("INCLUSIVE");
        /// <summary>
        /// Constant ON for AttributeType
        /// </summary>
        public static readonly AttributeType ON = new AttributeType("ON");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AttributeType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AttributeType FindValue(string value)
        {
            return FindValue<AttributeType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AttributeType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ButtonAction.
    /// </summary>
    public class ButtonAction : ConstantClass
    {

        /// <summary>
        /// Constant CLOSE for ButtonAction
        /// </summary>
        public static readonly ButtonAction CLOSE = new ButtonAction("CLOSE");
        /// <summary>
        /// Constant DEEP_LINK for ButtonAction
        /// </summary>
        public static readonly ButtonAction DEEP_LINK = new ButtonAction("DEEP_LINK");
        /// <summary>
        /// Constant LINK for ButtonAction
        /// </summary>
        public static readonly ButtonAction LINK = new ButtonAction("LINK");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ButtonAction(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ButtonAction FindValue(string value)
        {
            return FindValue<ButtonAction>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ButtonAction(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CampaignStatus.
    /// </summary>
    public class CampaignStatus : ConstantClass
    {

        /// <summary>
        /// Constant COMPLETED for CampaignStatus
        /// </summary>
        public static readonly CampaignStatus COMPLETED = new CampaignStatus("COMPLETED");
        /// <summary>
        /// Constant DELETED for CampaignStatus
        /// </summary>
        public static readonly CampaignStatus DELETED = new CampaignStatus("DELETED");
        /// <summary>
        /// Constant EXECUTING for CampaignStatus
        /// </summary>
        public static readonly CampaignStatus EXECUTING = new CampaignStatus("EXECUTING");
        /// <summary>
        /// Constant INVALID for CampaignStatus
        /// </summary>
        public static readonly CampaignStatus INVALID = new CampaignStatus("INVALID");
        /// <summary>
        /// Constant PAUSED for CampaignStatus
        /// </summary>
        public static readonly CampaignStatus PAUSED = new CampaignStatus("PAUSED");
        /// <summary>
        /// Constant PENDING_NEXT_RUN for CampaignStatus
        /// </summary>
        public static readonly CampaignStatus PENDING_NEXT_RUN = new CampaignStatus("PENDING_NEXT_RUN");
        /// <summary>
        /// Constant SCHEDULED for CampaignStatus
        /// </summary>
        public static readonly CampaignStatus SCHEDULED = new CampaignStatus("SCHEDULED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CampaignStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CampaignStatus FindValue(string value)
        {
            return FindValue<CampaignStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CampaignStatus(string value)
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
        /// Constant ADM for ChannelType
        /// </summary>
        public static readonly ChannelType ADM = new ChannelType("ADM");
        /// <summary>
        /// Constant APNS for ChannelType
        /// </summary>
        public static readonly ChannelType APNS = new ChannelType("APNS");
        /// <summary>
        /// Constant APNS_SANDBOX for ChannelType
        /// </summary>
        public static readonly ChannelType APNS_SANDBOX = new ChannelType("APNS_SANDBOX");
        /// <summary>
        /// Constant APNS_VOIP for ChannelType
        /// </summary>
        public static readonly ChannelType APNS_VOIP = new ChannelType("APNS_VOIP");
        /// <summary>
        /// Constant APNS_VOIP_SANDBOX for ChannelType
        /// </summary>
        public static readonly ChannelType APNS_VOIP_SANDBOX = new ChannelType("APNS_VOIP_SANDBOX");
        /// <summary>
        /// Constant BAIDU for ChannelType
        /// </summary>
        public static readonly ChannelType BAIDU = new ChannelType("BAIDU");
        /// <summary>
        /// Constant CUSTOM for ChannelType
        /// </summary>
        public static readonly ChannelType CUSTOM = new ChannelType("CUSTOM");
        /// <summary>
        /// Constant EMAIL for ChannelType
        /// </summary>
        public static readonly ChannelType EMAIL = new ChannelType("EMAIL");
        /// <summary>
        /// Constant GCM for ChannelType
        /// </summary>
        public static readonly ChannelType GCM = new ChannelType("GCM");
        /// <summary>
        /// Constant IN_APP for ChannelType
        /// </summary>
        public static readonly ChannelType IN_APP = new ChannelType("IN_APP");
        /// <summary>
        /// Constant PUSH for ChannelType
        /// </summary>
        public static readonly ChannelType PUSH = new ChannelType("PUSH");
        /// <summary>
        /// Constant SMS for ChannelType
        /// </summary>
        public static readonly ChannelType SMS = new ChannelType("SMS");
        /// <summary>
        /// Constant VOICE for ChannelType
        /// </summary>
        public static readonly ChannelType VOICE = new ChannelType("VOICE");

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
    /// Constants used for properties of type DeliveryStatus.
    /// </summary>
    public class DeliveryStatus : ConstantClass
    {

        /// <summary>
        /// Constant DUPLICATE for DeliveryStatus
        /// </summary>
        public static readonly DeliveryStatus DUPLICATE = new DeliveryStatus("DUPLICATE");
        /// <summary>
        /// Constant OPT_OUT for DeliveryStatus
        /// </summary>
        public static readonly DeliveryStatus OPT_OUT = new DeliveryStatus("OPT_OUT");
        /// <summary>
        /// Constant PERMANENT_FAILURE for DeliveryStatus
        /// </summary>
        public static readonly DeliveryStatus PERMANENT_FAILURE = new DeliveryStatus("PERMANENT_FAILURE");
        /// <summary>
        /// Constant SUCCESSFUL for DeliveryStatus
        /// </summary>
        public static readonly DeliveryStatus SUCCESSFUL = new DeliveryStatus("SUCCESSFUL");
        /// <summary>
        /// Constant TEMPORARY_FAILURE for DeliveryStatus
        /// </summary>
        public static readonly DeliveryStatus TEMPORARY_FAILURE = new DeliveryStatus("TEMPORARY_FAILURE");
        /// <summary>
        /// Constant THROTTLED for DeliveryStatus
        /// </summary>
        public static readonly DeliveryStatus THROTTLED = new DeliveryStatus("THROTTLED");
        /// <summary>
        /// Constant UNKNOWN_FAILURE for DeliveryStatus
        /// </summary>
        public static readonly DeliveryStatus UNKNOWN_FAILURE = new DeliveryStatus("UNKNOWN_FAILURE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DeliveryStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DeliveryStatus FindValue(string value)
        {
            return FindValue<DeliveryStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DeliveryStatus(string value)
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
        /// Constant EXCLUSIVE for DimensionType
        /// </summary>
        public static readonly DimensionType EXCLUSIVE = new DimensionType("EXCLUSIVE");
        /// <summary>
        /// Constant INCLUSIVE for DimensionType
        /// </summary>
        public static readonly DimensionType INCLUSIVE = new DimensionType("INCLUSIVE");

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
    /// Constants used for properties of type Duration.
    /// </summary>
    public class Duration : ConstantClass
    {

        /// <summary>
        /// Constant DAY_14 for Duration
        /// </summary>
        public static readonly Duration DAY_14 = new Duration("DAY_14");
        /// <summary>
        /// Constant DAY_30 for Duration
        /// </summary>
        public static readonly Duration DAY_30 = new Duration("DAY_30");
        /// <summary>
        /// Constant DAY_7 for Duration
        /// </summary>
        public static readonly Duration DAY_7 = new Duration("DAY_7");
        /// <summary>
        /// Constant HR_24 for Duration
        /// </summary>
        public static readonly Duration HR_24 = new Duration("HR_24");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Duration(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Duration FindValue(string value)
        {
            return FindValue<Duration>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Duration(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type FilterType.
    /// </summary>
    public class FilterType : ConstantClass
    {

        /// <summary>
        /// Constant ENDPOINT for FilterType
        /// </summary>
        public static readonly FilterType ENDPOINT = new FilterType("ENDPOINT");
        /// <summary>
        /// Constant SYSTEM for FilterType
        /// </summary>
        public static readonly FilterType SYSTEM = new FilterType("SYSTEM");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FilterType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FilterType FindValue(string value)
        {
            return FindValue<FilterType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FilterType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Format.
    /// </summary>
    public class Format : ConstantClass
    {

        /// <summary>
        /// Constant CSV for Format
        /// </summary>
        public static readonly Format CSV = new Format("CSV");
        /// <summary>
        /// Constant JSON for Format
        /// </summary>
        public static readonly Format JSON = new Format("JSON");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Format(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Format FindValue(string value)
        {
            return FindValue<Format>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Format(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Frequency.
    /// </summary>
    public class Frequency : ConstantClass
    {

        /// <summary>
        /// Constant DAILY for Frequency
        /// </summary>
        public static readonly Frequency DAILY = new Frequency("DAILY");
        /// <summary>
        /// Constant EVENT for Frequency
        /// </summary>
        public static readonly Frequency EVENT = new Frequency("EVENT");
        /// <summary>
        /// Constant HOURLY for Frequency
        /// </summary>
        public static readonly Frequency HOURLY = new Frequency("HOURLY");
        /// <summary>
        /// Constant IN_APP_EVENT for Frequency
        /// </summary>
        public static readonly Frequency IN_APP_EVENT = new Frequency("IN_APP_EVENT");
        /// <summary>
        /// Constant MONTHLY for Frequency
        /// </summary>
        public static readonly Frequency MONTHLY = new Frequency("MONTHLY");
        /// <summary>
        /// Constant ONCE for Frequency
        /// </summary>
        public static readonly Frequency ONCE = new Frequency("ONCE");
        /// <summary>
        /// Constant WEEKLY for Frequency
        /// </summary>
        public static readonly Frequency WEEKLY = new Frequency("WEEKLY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Frequency(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Frequency FindValue(string value)
        {
            return FindValue<Frequency>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Frequency(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Include.
    /// </summary>
    public class Include : ConstantClass
    {

        /// <summary>
        /// Constant ALL for Include
        /// </summary>
        public static readonly Include ALL = new Include("ALL");
        /// <summary>
        /// Constant ANY for Include
        /// </summary>
        public static readonly Include ANY = new Include("ANY");
        /// <summary>
        /// Constant NONE for Include
        /// </summary>
        public static readonly Include NONE = new Include("NONE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Include(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Include FindValue(string value)
        {
            return FindValue<Include>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Include(string value)
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
        /// Constant COMPLETED for JobStatus
        /// </summary>
        public static readonly JobStatus COMPLETED = new JobStatus("COMPLETED");
        /// <summary>
        /// Constant COMPLETING for JobStatus
        /// </summary>
        public static readonly JobStatus COMPLETING = new JobStatus("COMPLETING");
        /// <summary>
        /// Constant CREATED for JobStatus
        /// </summary>
        public static readonly JobStatus CREATED = new JobStatus("CREATED");
        /// <summary>
        /// Constant FAILED for JobStatus
        /// </summary>
        public static readonly JobStatus FAILED = new JobStatus("FAILED");
        /// <summary>
        /// Constant FAILING for JobStatus
        /// </summary>
        public static readonly JobStatus FAILING = new JobStatus("FAILING");
        /// <summary>
        /// Constant INITIALIZING for JobStatus
        /// </summary>
        public static readonly JobStatus INITIALIZING = new JobStatus("INITIALIZING");
        /// <summary>
        /// Constant PENDING_JOB for JobStatus
        /// </summary>
        public static readonly JobStatus PENDING_JOB = new JobStatus("PENDING_JOB");
        /// <summary>
        /// Constant PREPARING_FOR_INITIALIZATION for JobStatus
        /// </summary>
        public static readonly JobStatus PREPARING_FOR_INITIALIZATION = new JobStatus("PREPARING_FOR_INITIALIZATION");
        /// <summary>
        /// Constant PROCESSING for JobStatus
        /// </summary>
        public static readonly JobStatus PROCESSING = new JobStatus("PROCESSING");

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
    /// Constants used for properties of type JourneyRunStatus.
    /// </summary>
    public class JourneyRunStatus : ConstantClass
    {

        /// <summary>
        /// Constant CANCELLED for JourneyRunStatus
        /// </summary>
        public static readonly JourneyRunStatus CANCELLED = new JourneyRunStatus("CANCELLED");
        /// <summary>
        /// Constant COMPLETED for JourneyRunStatus
        /// </summary>
        public static readonly JourneyRunStatus COMPLETED = new JourneyRunStatus("COMPLETED");
        /// <summary>
        /// Constant RUNNING for JourneyRunStatus
        /// </summary>
        public static readonly JourneyRunStatus RUNNING = new JourneyRunStatus("RUNNING");
        /// <summary>
        /// Constant SCHEDULED for JourneyRunStatus
        /// </summary>
        public static readonly JourneyRunStatus SCHEDULED = new JourneyRunStatus("SCHEDULED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public JourneyRunStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static JourneyRunStatus FindValue(string value)
        {
            return FindValue<JourneyRunStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator JourneyRunStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Layout.
    /// </summary>
    public class Layout : ConstantClass
    {

        /// <summary>
        /// Constant BOTTOM_BANNER for Layout
        /// </summary>
        public static readonly Layout BOTTOM_BANNER = new Layout("BOTTOM_BANNER");
        /// <summary>
        /// Constant CAROUSEL for Layout
        /// </summary>
        public static readonly Layout CAROUSEL = new Layout("CAROUSEL");
        /// <summary>
        /// Constant MIDDLE_BANNER for Layout
        /// </summary>
        public static readonly Layout MIDDLE_BANNER = new Layout("MIDDLE_BANNER");
        /// <summary>
        /// Constant MOBILE_FEED for Layout
        /// </summary>
        public static readonly Layout MOBILE_FEED = new Layout("MOBILE_FEED");
        /// <summary>
        /// Constant OVERLAYS for Layout
        /// </summary>
        public static readonly Layout OVERLAYS = new Layout("OVERLAYS");
        /// <summary>
        /// Constant TOP_BANNER for Layout
        /// </summary>
        public static readonly Layout TOP_BANNER = new Layout("TOP_BANNER");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Layout(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Layout FindValue(string value)
        {
            return FindValue<Layout>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Layout(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type MessageType.
    /// </summary>
    public class MessageType : ConstantClass
    {

        /// <summary>
        /// Constant PROMOTIONAL for MessageType
        /// </summary>
        public static readonly MessageType PROMOTIONAL = new MessageType("PROMOTIONAL");
        /// <summary>
        /// Constant TRANSACTIONAL for MessageType
        /// </summary>
        public static readonly MessageType TRANSACTIONAL = new MessageType("TRANSACTIONAL");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MessageType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MessageType FindValue(string value)
        {
            return FindValue<MessageType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MessageType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Mode.
    /// </summary>
    public class Mode : ConstantClass
    {

        /// <summary>
        /// Constant DELIVERY for Mode
        /// </summary>
        public static readonly Mode DELIVERY = new Mode("DELIVERY");
        /// <summary>
        /// Constant FILTER for Mode
        /// </summary>
        public static readonly Mode FILTER = new Mode("FILTER");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Mode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Mode FindValue(string value)
        {
            return FindValue<Mode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Mode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Operator.
    /// </summary>
    public class Operator : ConstantClass
    {

        /// <summary>
        /// Constant ALL for Operator
        /// </summary>
        public static readonly Operator ALL = new Operator("ALL");
        /// <summary>
        /// Constant ANY for Operator
        /// </summary>
        public static readonly Operator ANY = new Operator("ANY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Operator(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Operator FindValue(string value)
        {
            return FindValue<Operator>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Operator(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RecencyType.
    /// </summary>
    public class RecencyType : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for RecencyType
        /// </summary>
        public static readonly RecencyType ACTIVE = new RecencyType("ACTIVE");
        /// <summary>
        /// Constant INACTIVE for RecencyType
        /// </summary>
        public static readonly RecencyType INACTIVE = new RecencyType("INACTIVE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RecencyType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RecencyType FindValue(string value)
        {
            return FindValue<RecencyType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RecencyType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SegmentType.
    /// </summary>
    public class SegmentType : ConstantClass
    {

        /// <summary>
        /// Constant DIMENSIONAL for SegmentType
        /// </summary>
        public static readonly SegmentType DIMENSIONAL = new SegmentType("DIMENSIONAL");
        /// <summary>
        /// Constant IMPORT for SegmentType
        /// </summary>
        public static readonly SegmentType IMPORT = new SegmentType("IMPORT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SegmentType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SegmentType FindValue(string value)
        {
            return FindValue<SegmentType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SegmentType(string value)
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
        /// Constant ALL for SourceType
        /// </summary>
        public static readonly SourceType ALL = new SourceType("ALL");
        /// <summary>
        /// Constant ANY for SourceType
        /// </summary>
        public static readonly SourceType ANY = new SourceType("ANY");
        /// <summary>
        /// Constant NONE for SourceType
        /// </summary>
        public static readonly SourceType NONE = new SourceType("NONE");

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
    /// Constants used for properties of type State.
    /// </summary>
    public class State : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for State
        /// </summary>
        public static readonly State ACTIVE = new State("ACTIVE");
        /// <summary>
        /// Constant CANCELLED for State
        /// </summary>
        public static readonly State CANCELLED = new State("CANCELLED");
        /// <summary>
        /// Constant CLOSED for State
        /// </summary>
        public static readonly State CLOSED = new State("CLOSED");
        /// <summary>
        /// Constant COMPLETED for State
        /// </summary>
        public static readonly State COMPLETED = new State("COMPLETED");
        /// <summary>
        /// Constant DRAFT for State
        /// </summary>
        public static readonly State DRAFT = new State("DRAFT");
        /// <summary>
        /// Constant PAUSED for State
        /// </summary>
        public static readonly State PAUSED = new State("PAUSED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public State(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static State FindValue(string value)
        {
            return FindValue<State>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator State(string value)
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
        /// Constant EMAIL for TemplateType
        /// </summary>
        public static readonly TemplateType EMAIL = new TemplateType("EMAIL");
        /// <summary>
        /// Constant INAPP for TemplateType
        /// </summary>
        public static readonly TemplateType INAPP = new TemplateType("INAPP");
        /// <summary>
        /// Constant PUSH for TemplateType
        /// </summary>
        public static readonly TemplateType PUSH = new TemplateType("PUSH");
        /// <summary>
        /// Constant SMS for TemplateType
        /// </summary>
        public static readonly TemplateType SMS = new TemplateType("SMS");
        /// <summary>
        /// Constant VOICE for TemplateType
        /// </summary>
        public static readonly TemplateType VOICE = new TemplateType("VOICE");

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
    /// Constants used for properties of type Type.
    /// </summary>
    public class Type : ConstantClass
    {

        /// <summary>
        /// Constant ALL for Type
        /// </summary>
        public static readonly Type ALL = new Type("ALL");
        /// <summary>
        /// Constant ANY for Type
        /// </summary>
        public static readonly Type ANY = new Type("ANY");
        /// <summary>
        /// Constant NONE for Type
        /// </summary>
        public static readonly Type NONE = new Type("NONE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Type(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Type FindValue(string value)
        {
            return FindValue<Type>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Type(string value)
        {
            return FindValue(value);
        }
    }

}