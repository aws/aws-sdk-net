/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
    /// Constants used for properties of type AttributeType.
    /// </summary>
    public class AttributeType : ConstantClass
    {

        /// <summary>
        /// Constant EXCLUSIVE for AttributeType
        /// </summary>
        public static readonly AttributeType EXCLUSIVE = new AttributeType("EXCLUSIVE");
        /// <summary>
        /// Constant INCLUSIVE for AttributeType
        /// </summary>
        public static readonly AttributeType INCLUSIVE = new AttributeType("INCLUSIVE");

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
    /// Constants used for properties of type CampaignStatus.
    /// </summary>
    public class CampaignStatus : ConstantClass
    {

        /// <summary>
        /// Constant COMPLETED for CampaignStatus
        /// </summary>
        public static readonly CampaignStatus COMPLETED = new CampaignStatus("COMPLETED");
        /// <summary>
        /// Constant EXECUTING for CampaignStatus
        /// </summary>
        public static readonly CampaignStatus EXECUTING = new CampaignStatus("EXECUTING");
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
        /// Constant SMS for ChannelType
        /// </summary>
        public static readonly ChannelType SMS = new ChannelType("SMS");

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
        /// Constant HOURLY for Frequency
        /// </summary>
        public static readonly Frequency HOURLY = new Frequency("HOURLY");
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

}