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
 * Do not modify this file. This file is generated from the mediaconnect-2018-11-14.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.MediaConnect
{

    /// <summary>
    /// Constants used for properties of type Algorithm.
    /// </summary>
    public class Algorithm : ConstantClass
    {

        /// <summary>
        /// Constant Aes128 for Algorithm
        /// </summary>
        public static readonly Algorithm Aes128 = new Algorithm("aes128");
        /// <summary>
        /// Constant Aes192 for Algorithm
        /// </summary>
        public static readonly Algorithm Aes192 = new Algorithm("aes192");
        /// <summary>
        /// Constant Aes256 for Algorithm
        /// </summary>
        public static readonly Algorithm Aes256 = new Algorithm("aes256");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Algorithm(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Algorithm FindValue(string value)
        {
            return FindValue<Algorithm>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Algorithm(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type BridgePlacement.
    /// </summary>
    public class BridgePlacement : ConstantClass
    {

        /// <summary>
        /// Constant AVAILABLE for BridgePlacement
        /// </summary>
        public static readonly BridgePlacement AVAILABLE = new BridgePlacement("AVAILABLE");
        /// <summary>
        /// Constant LOCKED for BridgePlacement
        /// </summary>
        public static readonly BridgePlacement LOCKED = new BridgePlacement("LOCKED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public BridgePlacement(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static BridgePlacement FindValue(string value)
        {
            return FindValue<BridgePlacement>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator BridgePlacement(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type BridgeState.
    /// </summary>
    public class BridgeState : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for BridgeState
        /// </summary>
        public static readonly BridgeState ACTIVE = new BridgeState("ACTIVE");
        /// <summary>
        /// Constant CREATING for BridgeState
        /// </summary>
        public static readonly BridgeState CREATING = new BridgeState("CREATING");
        /// <summary>
        /// Constant DELETED for BridgeState
        /// </summary>
        public static readonly BridgeState DELETED = new BridgeState("DELETED");
        /// <summary>
        /// Constant DELETING for BridgeState
        /// </summary>
        public static readonly BridgeState DELETING = new BridgeState("DELETING");
        /// <summary>
        /// Constant DEPLOYING for BridgeState
        /// </summary>
        public static readonly BridgeState DEPLOYING = new BridgeState("DEPLOYING");
        /// <summary>
        /// Constant STANDBY for BridgeState
        /// </summary>
        public static readonly BridgeState STANDBY = new BridgeState("STANDBY");
        /// <summary>
        /// Constant START_FAILED for BridgeState
        /// </summary>
        public static readonly BridgeState START_FAILED = new BridgeState("START_FAILED");
        /// <summary>
        /// Constant START_PENDING for BridgeState
        /// </summary>
        public static readonly BridgeState START_PENDING = new BridgeState("START_PENDING");
        /// <summary>
        /// Constant STARTING for BridgeState
        /// </summary>
        public static readonly BridgeState STARTING = new BridgeState("STARTING");
        /// <summary>
        /// Constant STOP_FAILED for BridgeState
        /// </summary>
        public static readonly BridgeState STOP_FAILED = new BridgeState("STOP_FAILED");
        /// <summary>
        /// Constant STOPPING for BridgeState
        /// </summary>
        public static readonly BridgeState STOPPING = new BridgeState("STOPPING");
        /// <summary>
        /// Constant UPDATING for BridgeState
        /// </summary>
        public static readonly BridgeState UPDATING = new BridgeState("UPDATING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public BridgeState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static BridgeState FindValue(string value)
        {
            return FindValue<BridgeState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator BridgeState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Colorimetry.
    /// </summary>
    public class Colorimetry : ConstantClass
    {

        /// <summary>
        /// Constant BT2020 for Colorimetry
        /// </summary>
        public static readonly Colorimetry BT2020 = new Colorimetry("BT2020");
        /// <summary>
        /// Constant BT2100 for Colorimetry
        /// </summary>
        public static readonly Colorimetry BT2100 = new Colorimetry("BT2100");
        /// <summary>
        /// Constant BT601 for Colorimetry
        /// </summary>
        public static readonly Colorimetry BT601 = new Colorimetry("BT601");
        /// <summary>
        /// Constant BT709 for Colorimetry
        /// </summary>
        public static readonly Colorimetry BT709 = new Colorimetry("BT709");
        /// <summary>
        /// Constant ST20651 for Colorimetry
        /// </summary>
        public static readonly Colorimetry ST20651 = new Colorimetry("ST2065-1");
        /// <summary>
        /// Constant ST20653 for Colorimetry
        /// </summary>
        public static readonly Colorimetry ST20653 = new Colorimetry("ST2065-3");
        /// <summary>
        /// Constant XYZ for Colorimetry
        /// </summary>
        public static readonly Colorimetry XYZ = new Colorimetry("XYZ");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Colorimetry(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Colorimetry FindValue(string value)
        {
            return FindValue<Colorimetry>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Colorimetry(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ConnectionStatus.
    /// </summary>
    public class ConnectionStatus : ConstantClass
    {

        /// <summary>
        /// Constant CONNECTED for ConnectionStatus
        /// </summary>
        public static readonly ConnectionStatus CONNECTED = new ConnectionStatus("CONNECTED");
        /// <summary>
        /// Constant DISCONNECTED for ConnectionStatus
        /// </summary>
        public static readonly ConnectionStatus DISCONNECTED = new ConnectionStatus("DISCONNECTED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ConnectionStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ConnectionStatus FindValue(string value)
        {
            return FindValue<ConnectionStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ConnectionStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ContentQualityAnalysisState.
    /// </summary>
    public class ContentQualityAnalysisState : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for ContentQualityAnalysisState
        /// </summary>
        public static readonly ContentQualityAnalysisState DISABLED = new ContentQualityAnalysisState("DISABLED");
        /// <summary>
        /// Constant ENABLED for ContentQualityAnalysisState
        /// </summary>
        public static readonly ContentQualityAnalysisState ENABLED = new ContentQualityAnalysisState("ENABLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ContentQualityAnalysisState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ContentQualityAnalysisState FindValue(string value)
        {
            return FindValue<ContentQualityAnalysisState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ContentQualityAnalysisState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Day.
    /// </summary>
    public class Day : ConstantClass
    {

        /// <summary>
        /// Constant FRIDAY for Day
        /// </summary>
        public static readonly Day FRIDAY = new Day("FRIDAY");
        /// <summary>
        /// Constant MONDAY for Day
        /// </summary>
        public static readonly Day MONDAY = new Day("MONDAY");
        /// <summary>
        /// Constant SATURDAY for Day
        /// </summary>
        public static readonly Day SATURDAY = new Day("SATURDAY");
        /// <summary>
        /// Constant SUNDAY for Day
        /// </summary>
        public static readonly Day SUNDAY = new Day("SUNDAY");
        /// <summary>
        /// Constant THURSDAY for Day
        /// </summary>
        public static readonly Day THURSDAY = new Day("THURSDAY");
        /// <summary>
        /// Constant TUESDAY for Day
        /// </summary>
        public static readonly Day TUESDAY = new Day("TUESDAY");
        /// <summary>
        /// Constant WEDNESDAY for Day
        /// </summary>
        public static readonly Day WEDNESDAY = new Day("WEDNESDAY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Day(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Day FindValue(string value)
        {
            return FindValue<Day>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Day(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DesiredState.
    /// </summary>
    public class DesiredState : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for DesiredState
        /// </summary>
        public static readonly DesiredState ACTIVE = new DesiredState("ACTIVE");
        /// <summary>
        /// Constant DELETED for DesiredState
        /// </summary>
        public static readonly DesiredState DELETED = new DesiredState("DELETED");
        /// <summary>
        /// Constant STANDBY for DesiredState
        /// </summary>
        public static readonly DesiredState STANDBY = new DesiredState("STANDBY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DesiredState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DesiredState FindValue(string value)
        {
            return FindValue<DesiredState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DesiredState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DurationUnits.
    /// </summary>
    public class DurationUnits : ConstantClass
    {

        /// <summary>
        /// Constant MONTHS for DurationUnits
        /// </summary>
        public static readonly DurationUnits MONTHS = new DurationUnits("MONTHS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DurationUnits(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DurationUnits FindValue(string value)
        {
            return FindValue<DurationUnits>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DurationUnits(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type EncoderProfile.
    /// </summary>
    public class EncoderProfile : ConstantClass
    {

        /// <summary>
        /// Constant High for EncoderProfile
        /// </summary>
        public static readonly EncoderProfile High = new EncoderProfile("high");
        /// <summary>
        /// Constant Main for EncoderProfile
        /// </summary>
        public static readonly EncoderProfile Main = new EncoderProfile("main");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EncoderProfile(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EncoderProfile FindValue(string value)
        {
            return FindValue<EncoderProfile>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EncoderProfile(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type EncodingName.
    /// </summary>
    public class EncodingName : ConstantClass
    {

        /// <summary>
        /// Constant Jxsv for EncodingName
        /// </summary>
        public static readonly EncodingName Jxsv = new EncodingName("jxsv");
        /// <summary>
        /// Constant Pcm for EncodingName
        /// </summary>
        public static readonly EncodingName Pcm = new EncodingName("pcm");
        /// <summary>
        /// Constant Raw for EncodingName
        /// </summary>
        public static readonly EncodingName Raw = new EncodingName("raw");
        /// <summary>
        /// Constant Smpte291 for EncodingName
        /// </summary>
        public static readonly EncodingName Smpte291 = new EncodingName("smpte291");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EncodingName(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EncodingName FindValue(string value)
        {
            return FindValue<EncodingName>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EncodingName(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type EncodingProfile.
    /// </summary>
    public class EncodingProfile : ConstantClass
    {

        /// <summary>
        /// Constant CONTRIBUTION_H264_DEFAULT for EncodingProfile
        /// </summary>
        public static readonly EncodingProfile CONTRIBUTION_H264_DEFAULT = new EncodingProfile("CONTRIBUTION_H264_DEFAULT");
        /// <summary>
        /// Constant DISTRIBUTION_H264_DEFAULT for EncodingProfile
        /// </summary>
        public static readonly EncodingProfile DISTRIBUTION_H264_DEFAULT = new EncodingProfile("DISTRIBUTION_H264_DEFAULT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EncodingProfile(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EncodingProfile FindValue(string value)
        {
            return FindValue<EncodingProfile>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EncodingProfile(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type EntitlementStatus.
    /// </summary>
    public class EntitlementStatus : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for EntitlementStatus
        /// </summary>
        public static readonly EntitlementStatus DISABLED = new EntitlementStatus("DISABLED");
        /// <summary>
        /// Constant ENABLED for EntitlementStatus
        /// </summary>
        public static readonly EntitlementStatus ENABLED = new EntitlementStatus("ENABLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EntitlementStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EntitlementStatus FindValue(string value)
        {
            return FindValue<EntitlementStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EntitlementStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type FailoverInputSourcePriorityMode.
    /// </summary>
    public class FailoverInputSourcePriorityMode : ConstantClass
    {

        /// <summary>
        /// Constant NO_PRIORITY for FailoverInputSourcePriorityMode
        /// </summary>
        public static readonly FailoverInputSourcePriorityMode NO_PRIORITY = new FailoverInputSourcePriorityMode("NO_PRIORITY");
        /// <summary>
        /// Constant PRIMARY_SECONDARY for FailoverInputSourcePriorityMode
        /// </summary>
        public static readonly FailoverInputSourcePriorityMode PRIMARY_SECONDARY = new FailoverInputSourcePriorityMode("PRIMARY_SECONDARY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FailoverInputSourcePriorityMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FailoverInputSourcePriorityMode FindValue(string value)
        {
            return FindValue<FailoverInputSourcePriorityMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FailoverInputSourcePriorityMode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type FailoverMode.
    /// </summary>
    public class FailoverMode : ConstantClass
    {

        /// <summary>
        /// Constant FAILOVER for FailoverMode
        /// </summary>
        public static readonly FailoverMode FAILOVER = new FailoverMode("FAILOVER");
        /// <summary>
        /// Constant MERGE for FailoverMode
        /// </summary>
        public static readonly FailoverMode MERGE = new FailoverMode("MERGE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FailoverMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FailoverMode FindValue(string value)
        {
            return FindValue<FailoverMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FailoverMode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type FlowSize.
    /// </summary>
    public class FlowSize : ConstantClass
    {

        /// <summary>
        /// Constant LARGE for FlowSize
        /// </summary>
        public static readonly FlowSize LARGE = new FlowSize("LARGE");
        /// <summary>
        /// Constant LARGE_4X for FlowSize
        /// </summary>
        public static readonly FlowSize LARGE_4X = new FlowSize("LARGE_4X");
        /// <summary>
        /// Constant MEDIUM for FlowSize
        /// </summary>
        public static readonly FlowSize MEDIUM = new FlowSize("MEDIUM");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FlowSize(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FlowSize FindValue(string value)
        {
            return FindValue<FlowSize>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FlowSize(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type FlowTransitEncryptionKeyType.
    /// </summary>
    public class FlowTransitEncryptionKeyType : ConstantClass
    {

        /// <summary>
        /// Constant AUTOMATIC for FlowTransitEncryptionKeyType
        /// </summary>
        public static readonly FlowTransitEncryptionKeyType AUTOMATIC = new FlowTransitEncryptionKeyType("AUTOMATIC");
        /// <summary>
        /// Constant SECRETS_MANAGER for FlowTransitEncryptionKeyType
        /// </summary>
        public static readonly FlowTransitEncryptionKeyType SECRETS_MANAGER = new FlowTransitEncryptionKeyType("SECRETS_MANAGER");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FlowTransitEncryptionKeyType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FlowTransitEncryptionKeyType FindValue(string value)
        {
            return FindValue<FlowTransitEncryptionKeyType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FlowTransitEncryptionKeyType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ForwardErrorCorrectionState.
    /// </summary>
    public class ForwardErrorCorrectionState : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for ForwardErrorCorrectionState
        /// </summary>
        public static readonly ForwardErrorCorrectionState DISABLED = new ForwardErrorCorrectionState("DISABLED");
        /// <summary>
        /// Constant ENABLED for ForwardErrorCorrectionState
        /// </summary>
        public static readonly ForwardErrorCorrectionState ENABLED = new ForwardErrorCorrectionState("ENABLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ForwardErrorCorrectionState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ForwardErrorCorrectionState FindValue(string value)
        {
            return FindValue<ForwardErrorCorrectionState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ForwardErrorCorrectionState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type GatewayState.
    /// </summary>
    public class GatewayState : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for GatewayState
        /// </summary>
        public static readonly GatewayState ACTIVE = new GatewayState("ACTIVE");
        /// <summary>
        /// Constant CREATING for GatewayState
        /// </summary>
        public static readonly GatewayState CREATING = new GatewayState("CREATING");
        /// <summary>
        /// Constant DELETED for GatewayState
        /// </summary>
        public static readonly GatewayState DELETED = new GatewayState("DELETED");
        /// <summary>
        /// Constant DELETING for GatewayState
        /// </summary>
        public static readonly GatewayState DELETING = new GatewayState("DELETING");
        /// <summary>
        /// Constant ERROR for GatewayState
        /// </summary>
        public static readonly GatewayState ERROR = new GatewayState("ERROR");
        /// <summary>
        /// Constant UPDATING for GatewayState
        /// </summary>
        public static readonly GatewayState UPDATING = new GatewayState("UPDATING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public GatewayState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static GatewayState FindValue(string value)
        {
            return FindValue<GatewayState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator GatewayState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type InstanceState.
    /// </summary>
    public class InstanceState : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for InstanceState
        /// </summary>
        public static readonly InstanceState ACTIVE = new InstanceState("ACTIVE");
        /// <summary>
        /// Constant DEREGISTERED for InstanceState
        /// </summary>
        public static readonly InstanceState DEREGISTERED = new InstanceState("DEREGISTERED");
        /// <summary>
        /// Constant DEREGISTERING for InstanceState
        /// </summary>
        public static readonly InstanceState DEREGISTERING = new InstanceState("DEREGISTERING");
        /// <summary>
        /// Constant DEREGISTRATION_ERROR for InstanceState
        /// </summary>
        public static readonly InstanceState DEREGISTRATION_ERROR = new InstanceState("DEREGISTRATION_ERROR");
        /// <summary>
        /// Constant REGISTERING for InstanceState
        /// </summary>
        public static readonly InstanceState REGISTERING = new InstanceState("REGISTERING");
        /// <summary>
        /// Constant REGISTRATION_ERROR for InstanceState
        /// </summary>
        public static readonly InstanceState REGISTRATION_ERROR = new InstanceState("REGISTRATION_ERROR");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public InstanceState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static InstanceState FindValue(string value)
        {
            return FindValue<InstanceState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator InstanceState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type KeyType.
    /// </summary>
    public class KeyType : ConstantClass
    {

        /// <summary>
        /// Constant Speke for KeyType
        /// </summary>
        public static readonly KeyType Speke = new KeyType("speke");
        /// <summary>
        /// Constant SrtPassword for KeyType
        /// </summary>
        public static readonly KeyType SrtPassword = new KeyType("srt-password");
        /// <summary>
        /// Constant StaticKey for KeyType
        /// </summary>
        public static readonly KeyType StaticKey = new KeyType("static-key");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public KeyType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static KeyType FindValue(string value)
        {
            return FindValue<KeyType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator KeyType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type MaintenanceDay.
    /// </summary>
    public class MaintenanceDay : ConstantClass
    {

        /// <summary>
        /// Constant Friday for MaintenanceDay
        /// </summary>
        public static readonly MaintenanceDay Friday = new MaintenanceDay("Friday");
        /// <summary>
        /// Constant Monday for MaintenanceDay
        /// </summary>
        public static readonly MaintenanceDay Monday = new MaintenanceDay("Monday");
        /// <summary>
        /// Constant Saturday for MaintenanceDay
        /// </summary>
        public static readonly MaintenanceDay Saturday = new MaintenanceDay("Saturday");
        /// <summary>
        /// Constant Sunday for MaintenanceDay
        /// </summary>
        public static readonly MaintenanceDay Sunday = new MaintenanceDay("Sunday");
        /// <summary>
        /// Constant Thursday for MaintenanceDay
        /// </summary>
        public static readonly MaintenanceDay Thursday = new MaintenanceDay("Thursday");
        /// <summary>
        /// Constant Tuesday for MaintenanceDay
        /// </summary>
        public static readonly MaintenanceDay Tuesday = new MaintenanceDay("Tuesday");
        /// <summary>
        /// Constant Wednesday for MaintenanceDay
        /// </summary>
        public static readonly MaintenanceDay Wednesday = new MaintenanceDay("Wednesday");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MaintenanceDay(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MaintenanceDay FindValue(string value)
        {
            return FindValue<MaintenanceDay>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MaintenanceDay(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type MaintenanceScheduleType.
    /// </summary>
    public class MaintenanceScheduleType : ConstantClass
    {

        /// <summary>
        /// Constant WINDOW for MaintenanceScheduleType
        /// </summary>
        public static readonly MaintenanceScheduleType WINDOW = new MaintenanceScheduleType("WINDOW");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MaintenanceScheduleType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MaintenanceScheduleType FindValue(string value)
        {
            return FindValue<MaintenanceScheduleType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MaintenanceScheduleType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type MaintenanceType.
    /// </summary>
    public class MaintenanceType : ConstantClass
    {

        /// <summary>
        /// Constant DEFAULT for MaintenanceType
        /// </summary>
        public static readonly MaintenanceType DEFAULT = new MaintenanceType("DEFAULT");
        /// <summary>
        /// Constant PREFERRED_DAY_TIME for MaintenanceType
        /// </summary>
        public static readonly MaintenanceType PREFERRED_DAY_TIME = new MaintenanceType("PREFERRED_DAY_TIME");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MaintenanceType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MaintenanceType FindValue(string value)
        {
            return FindValue<MaintenanceType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MaintenanceType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type MediaLiveInputPipelineId.
    /// </summary>
    public class MediaLiveInputPipelineId : ConstantClass
    {

        /// <summary>
        /// Constant PIPELINE_0 for MediaLiveInputPipelineId
        /// </summary>
        public static readonly MediaLiveInputPipelineId PIPELINE_0 = new MediaLiveInputPipelineId("PIPELINE_0");
        /// <summary>
        /// Constant PIPELINE_1 for MediaLiveInputPipelineId
        /// </summary>
        public static readonly MediaLiveInputPipelineId PIPELINE_1 = new MediaLiveInputPipelineId("PIPELINE_1");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MediaLiveInputPipelineId(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MediaLiveInputPipelineId FindValue(string value)
        {
            return FindValue<MediaLiveInputPipelineId>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MediaLiveInputPipelineId(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type MediaLiveTransitEncryptionKeyType.
    /// </summary>
    public class MediaLiveTransitEncryptionKeyType : ConstantClass
    {

        /// <summary>
        /// Constant AUTOMATIC for MediaLiveTransitEncryptionKeyType
        /// </summary>
        public static readonly MediaLiveTransitEncryptionKeyType AUTOMATIC = new MediaLiveTransitEncryptionKeyType("AUTOMATIC");
        /// <summary>
        /// Constant SECRETS_MANAGER for MediaLiveTransitEncryptionKeyType
        /// </summary>
        public static readonly MediaLiveTransitEncryptionKeyType SECRETS_MANAGER = new MediaLiveTransitEncryptionKeyType("SECRETS_MANAGER");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MediaLiveTransitEncryptionKeyType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MediaLiveTransitEncryptionKeyType FindValue(string value)
        {
            return FindValue<MediaLiveTransitEncryptionKeyType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MediaLiveTransitEncryptionKeyType(string value)
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
        /// Constant AncillaryData for MediaStreamType
        /// </summary>
        public static readonly MediaStreamType AncillaryData = new MediaStreamType("ancillary-data");
        /// <summary>
        /// Constant Audio for MediaStreamType
        /// </summary>
        public static readonly MediaStreamType Audio = new MediaStreamType("audio");
        /// <summary>
        /// Constant Video for MediaStreamType
        /// </summary>
        public static readonly MediaStreamType Video = new MediaStreamType("video");

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
    /// Constants used for properties of type NdiState.
    /// </summary>
    public class NdiState : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for NdiState
        /// </summary>
        public static readonly NdiState DISABLED = new NdiState("DISABLED");
        /// <summary>
        /// Constant ENABLED for NdiState
        /// </summary>
        public static readonly NdiState ENABLED = new NdiState("ENABLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public NdiState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static NdiState FindValue(string value)
        {
            return FindValue<NdiState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator NdiState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type NetworkInterfaceType.
    /// </summary>
    public class NetworkInterfaceType : ConstantClass
    {

        /// <summary>
        /// Constant Efa for NetworkInterfaceType
        /// </summary>
        public static readonly NetworkInterfaceType Efa = new NetworkInterfaceType("efa");
        /// <summary>
        /// Constant Ena for NetworkInterfaceType
        /// </summary>
        public static readonly NetworkInterfaceType Ena = new NetworkInterfaceType("ena");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public NetworkInterfaceType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static NetworkInterfaceType FindValue(string value)
        {
            return FindValue<NetworkInterfaceType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator NetworkInterfaceType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type OutputStatus.
    /// </summary>
    public class OutputStatus : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for OutputStatus
        /// </summary>
        public static readonly OutputStatus DISABLED = new OutputStatus("DISABLED");
        /// <summary>
        /// Constant ENABLED for OutputStatus
        /// </summary>
        public static readonly OutputStatus ENABLED = new OutputStatus("ENABLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public OutputStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static OutputStatus FindValue(string value)
        {
            return FindValue<OutputStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator OutputStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PriceUnits.
    /// </summary>
    public class PriceUnits : ConstantClass
    {

        /// <summary>
        /// Constant HOURLY for PriceUnits
        /// </summary>
        public static readonly PriceUnits HOURLY = new PriceUnits("HOURLY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PriceUnits(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PriceUnits FindValue(string value)
        {
            return FindValue<PriceUnits>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PriceUnits(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Protocol.
    /// </summary>
    public class Protocol : ConstantClass
    {

        /// <summary>
        /// Constant Cdi for Protocol
        /// </summary>
        public static readonly Protocol Cdi = new Protocol("cdi");
        /// <summary>
        /// Constant FujitsuQos for Protocol
        /// </summary>
        public static readonly Protocol FujitsuQos = new Protocol("fujitsu-qos");
        /// <summary>
        /// Constant NdiSpeedHq for Protocol
        /// </summary>
        public static readonly Protocol NdiSpeedHq = new Protocol("ndi-speed-hq");
        /// <summary>
        /// Constant Rist for Protocol
        /// </summary>
        public static readonly Protocol Rist = new Protocol("rist");
        /// <summary>
        /// Constant Rtp for Protocol
        /// </summary>
        public static readonly Protocol Rtp = new Protocol("rtp");
        /// <summary>
        /// Constant RtpFec for Protocol
        /// </summary>
        public static readonly Protocol RtpFec = new Protocol("rtp-fec");
        /// <summary>
        /// Constant SrtCaller for Protocol
        /// </summary>
        public static readonly Protocol SrtCaller = new Protocol("srt-caller");
        /// <summary>
        /// Constant SrtListener for Protocol
        /// </summary>
        public static readonly Protocol SrtListener = new Protocol("srt-listener");
        /// <summary>
        /// Constant St2110Jpegxs for Protocol
        /// </summary>
        public static readonly Protocol St2110Jpegxs = new Protocol("st2110-jpegxs");
        /// <summary>
        /// Constant Udp for Protocol
        /// </summary>
        public static readonly Protocol Udp = new Protocol("udp");
        /// <summary>
        /// Constant ZixiPull for Protocol
        /// </summary>
        public static readonly Protocol ZixiPull = new Protocol("zixi-pull");
        /// <summary>
        /// Constant ZixiPush for Protocol
        /// </summary>
        public static readonly Protocol ZixiPush = new Protocol("zixi-push");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Protocol(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Protocol FindValue(string value)
        {
            return FindValue<Protocol>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Protocol(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Range.
    /// </summary>
    public class Range : ConstantClass
    {

        /// <summary>
        /// Constant FULL for Range
        /// </summary>
        public static readonly Range FULL = new Range("FULL");
        /// <summary>
        /// Constant FULLPROTECT for Range
        /// </summary>
        public static readonly Range FULLPROTECT = new Range("FULLPROTECT");
        /// <summary>
        /// Constant NARROW for Range
        /// </summary>
        public static readonly Range NARROW = new Range("NARROW");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Range(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Range FindValue(string value)
        {
            return FindValue<Range>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Range(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ReservationState.
    /// </summary>
    public class ReservationState : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for ReservationState
        /// </summary>
        public static readonly ReservationState ACTIVE = new ReservationState("ACTIVE");
        /// <summary>
        /// Constant CANCELED for ReservationState
        /// </summary>
        public static readonly ReservationState CANCELED = new ReservationState("CANCELED");
        /// <summary>
        /// Constant EXPIRED for ReservationState
        /// </summary>
        public static readonly ReservationState EXPIRED = new ReservationState("EXPIRED");
        /// <summary>
        /// Constant PROCESSING for ReservationState
        /// </summary>
        public static readonly ReservationState PROCESSING = new ReservationState("PROCESSING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ReservationState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ReservationState FindValue(string value)
        {
            return FindValue<ReservationState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ReservationState(string value)
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
        /// Constant Mbps_Outbound_Bandwidth for ResourceType
        /// </summary>
        public static readonly ResourceType Mbps_Outbound_Bandwidth = new ResourceType("Mbps_Outbound_Bandwidth");

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
    /// Constants used for properties of type RouterInputProtocol.
    /// </summary>
    public class RouterInputProtocol : ConstantClass
    {

        /// <summary>
        /// Constant RIST for RouterInputProtocol
        /// </summary>
        public static readonly RouterInputProtocol RIST = new RouterInputProtocol("RIST");
        /// <summary>
        /// Constant RTP for RouterInputProtocol
        /// </summary>
        public static readonly RouterInputProtocol RTP = new RouterInputProtocol("RTP");
        /// <summary>
        /// Constant SRT_CALLER for RouterInputProtocol
        /// </summary>
        public static readonly RouterInputProtocol SRT_CALLER = new RouterInputProtocol("SRT_CALLER");
        /// <summary>
        /// Constant SRT_LISTENER for RouterInputProtocol
        /// </summary>
        public static readonly RouterInputProtocol SRT_LISTENER = new RouterInputProtocol("SRT_LISTENER");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RouterInputProtocol(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RouterInputProtocol FindValue(string value)
        {
            return FindValue<RouterInputProtocol>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RouterInputProtocol(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RouterInputState.
    /// </summary>
    public class RouterInputState : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for RouterInputState
        /// </summary>
        public static readonly RouterInputState ACTIVE = new RouterInputState("ACTIVE");
        /// <summary>
        /// Constant CREATING for RouterInputState
        /// </summary>
        public static readonly RouterInputState CREATING = new RouterInputState("CREATING");
        /// <summary>
        /// Constant DELETING for RouterInputState
        /// </summary>
        public static readonly RouterInputState DELETING = new RouterInputState("DELETING");
        /// <summary>
        /// Constant ERROR for RouterInputState
        /// </summary>
        public static readonly RouterInputState ERROR = new RouterInputState("ERROR");
        /// <summary>
        /// Constant MIGRATING for RouterInputState
        /// </summary>
        public static readonly RouterInputState MIGRATING = new RouterInputState("MIGRATING");
        /// <summary>
        /// Constant RECOVERING for RouterInputState
        /// </summary>
        public static readonly RouterInputState RECOVERING = new RouterInputState("RECOVERING");
        /// <summary>
        /// Constant STANDBY for RouterInputState
        /// </summary>
        public static readonly RouterInputState STANDBY = new RouterInputState("STANDBY");
        /// <summary>
        /// Constant STARTING for RouterInputState
        /// </summary>
        public static readonly RouterInputState STARTING = new RouterInputState("STARTING");
        /// <summary>
        /// Constant STOPPING for RouterInputState
        /// </summary>
        public static readonly RouterInputState STOPPING = new RouterInputState("STOPPING");
        /// <summary>
        /// Constant UPDATING for RouterInputState
        /// </summary>
        public static readonly RouterInputState UPDATING = new RouterInputState("UPDATING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RouterInputState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RouterInputState FindValue(string value)
        {
            return FindValue<RouterInputState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RouterInputState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RouterInputTier.
    /// </summary>
    public class RouterInputTier : ConstantClass
    {

        /// <summary>
        /// Constant INPUT_100 for RouterInputTier
        /// </summary>
        public static readonly RouterInputTier INPUT_100 = new RouterInputTier("INPUT_100");
        /// <summary>
        /// Constant INPUT_20 for RouterInputTier
        /// </summary>
        public static readonly RouterInputTier INPUT_20 = new RouterInputTier("INPUT_20");
        /// <summary>
        /// Constant INPUT_50 for RouterInputTier
        /// </summary>
        public static readonly RouterInputTier INPUT_50 = new RouterInputTier("INPUT_50");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RouterInputTier(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RouterInputTier FindValue(string value)
        {
            return FindValue<RouterInputTier>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RouterInputTier(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RouterInputTransitEncryptionKeyType.
    /// </summary>
    public class RouterInputTransitEncryptionKeyType : ConstantClass
    {

        /// <summary>
        /// Constant AUTOMATIC for RouterInputTransitEncryptionKeyType
        /// </summary>
        public static readonly RouterInputTransitEncryptionKeyType AUTOMATIC = new RouterInputTransitEncryptionKeyType("AUTOMATIC");
        /// <summary>
        /// Constant SECRETS_MANAGER for RouterInputTransitEncryptionKeyType
        /// </summary>
        public static readonly RouterInputTransitEncryptionKeyType SECRETS_MANAGER = new RouterInputTransitEncryptionKeyType("SECRETS_MANAGER");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RouterInputTransitEncryptionKeyType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RouterInputTransitEncryptionKeyType FindValue(string value)
        {
            return FindValue<RouterInputTransitEncryptionKeyType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RouterInputTransitEncryptionKeyType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RouterInputType.
    /// </summary>
    public class RouterInputType : ConstantClass
    {

        /// <summary>
        /// Constant FAILOVER for RouterInputType
        /// </summary>
        public static readonly RouterInputType FAILOVER = new RouterInputType("FAILOVER");
        /// <summary>
        /// Constant MEDIACONNECT_FLOW for RouterInputType
        /// </summary>
        public static readonly RouterInputType MEDIACONNECT_FLOW = new RouterInputType("MEDIACONNECT_FLOW");
        /// <summary>
        /// Constant MERGE for RouterInputType
        /// </summary>
        public static readonly RouterInputType MERGE = new RouterInputType("MERGE");
        /// <summary>
        /// Constant STANDARD for RouterInputType
        /// </summary>
        public static readonly RouterInputType STANDARD = new RouterInputType("STANDARD");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RouterInputType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RouterInputType FindValue(string value)
        {
            return FindValue<RouterInputType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RouterInputType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RouterNetworkInterfaceState.
    /// </summary>
    public class RouterNetworkInterfaceState : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for RouterNetworkInterfaceState
        /// </summary>
        public static readonly RouterNetworkInterfaceState ACTIVE = new RouterNetworkInterfaceState("ACTIVE");
        /// <summary>
        /// Constant CREATING for RouterNetworkInterfaceState
        /// </summary>
        public static readonly RouterNetworkInterfaceState CREATING = new RouterNetworkInterfaceState("CREATING");
        /// <summary>
        /// Constant DELETING for RouterNetworkInterfaceState
        /// </summary>
        public static readonly RouterNetworkInterfaceState DELETING = new RouterNetworkInterfaceState("DELETING");
        /// <summary>
        /// Constant ERROR for RouterNetworkInterfaceState
        /// </summary>
        public static readonly RouterNetworkInterfaceState ERROR = new RouterNetworkInterfaceState("ERROR");
        /// <summary>
        /// Constant RECOVERING for RouterNetworkInterfaceState
        /// </summary>
        public static readonly RouterNetworkInterfaceState RECOVERING = new RouterNetworkInterfaceState("RECOVERING");
        /// <summary>
        /// Constant UPDATING for RouterNetworkInterfaceState
        /// </summary>
        public static readonly RouterNetworkInterfaceState UPDATING = new RouterNetworkInterfaceState("UPDATING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RouterNetworkInterfaceState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RouterNetworkInterfaceState FindValue(string value)
        {
            return FindValue<RouterNetworkInterfaceState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RouterNetworkInterfaceState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RouterNetworkInterfaceType.
    /// </summary>
    public class RouterNetworkInterfaceType : ConstantClass
    {

        /// <summary>
        /// Constant PUBLIC for RouterNetworkInterfaceType
        /// </summary>
        public static readonly RouterNetworkInterfaceType PUBLIC = new RouterNetworkInterfaceType("PUBLIC");
        /// <summary>
        /// Constant VPC for RouterNetworkInterfaceType
        /// </summary>
        public static readonly RouterNetworkInterfaceType VPC = new RouterNetworkInterfaceType("VPC");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RouterNetworkInterfaceType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RouterNetworkInterfaceType FindValue(string value)
        {
            return FindValue<RouterNetworkInterfaceType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RouterNetworkInterfaceType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RouterOutputProtocol.
    /// </summary>
    public class RouterOutputProtocol : ConstantClass
    {

        /// <summary>
        /// Constant RIST for RouterOutputProtocol
        /// </summary>
        public static readonly RouterOutputProtocol RIST = new RouterOutputProtocol("RIST");
        /// <summary>
        /// Constant RTP for RouterOutputProtocol
        /// </summary>
        public static readonly RouterOutputProtocol RTP = new RouterOutputProtocol("RTP");
        /// <summary>
        /// Constant SRT_CALLER for RouterOutputProtocol
        /// </summary>
        public static readonly RouterOutputProtocol SRT_CALLER = new RouterOutputProtocol("SRT_CALLER");
        /// <summary>
        /// Constant SRT_LISTENER for RouterOutputProtocol
        /// </summary>
        public static readonly RouterOutputProtocol SRT_LISTENER = new RouterOutputProtocol("SRT_LISTENER");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RouterOutputProtocol(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RouterOutputProtocol FindValue(string value)
        {
            return FindValue<RouterOutputProtocol>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RouterOutputProtocol(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RouterOutputRoutedState.
    /// </summary>
    public class RouterOutputRoutedState : ConstantClass
    {

        /// <summary>
        /// Constant ROUTED for RouterOutputRoutedState
        /// </summary>
        public static readonly RouterOutputRoutedState ROUTED = new RouterOutputRoutedState("ROUTED");
        /// <summary>
        /// Constant ROUTING for RouterOutputRoutedState
        /// </summary>
        public static readonly RouterOutputRoutedState ROUTING = new RouterOutputRoutedState("ROUTING");
        /// <summary>
        /// Constant UNROUTED for RouterOutputRoutedState
        /// </summary>
        public static readonly RouterOutputRoutedState UNROUTED = new RouterOutputRoutedState("UNROUTED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RouterOutputRoutedState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RouterOutputRoutedState FindValue(string value)
        {
            return FindValue<RouterOutputRoutedState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RouterOutputRoutedState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RouterOutputState.
    /// </summary>
    public class RouterOutputState : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for RouterOutputState
        /// </summary>
        public static readonly RouterOutputState ACTIVE = new RouterOutputState("ACTIVE");
        /// <summary>
        /// Constant CREATING for RouterOutputState
        /// </summary>
        public static readonly RouterOutputState CREATING = new RouterOutputState("CREATING");
        /// <summary>
        /// Constant DELETING for RouterOutputState
        /// </summary>
        public static readonly RouterOutputState DELETING = new RouterOutputState("DELETING");
        /// <summary>
        /// Constant ERROR for RouterOutputState
        /// </summary>
        public static readonly RouterOutputState ERROR = new RouterOutputState("ERROR");
        /// <summary>
        /// Constant MIGRATING for RouterOutputState
        /// </summary>
        public static readonly RouterOutputState MIGRATING = new RouterOutputState("MIGRATING");
        /// <summary>
        /// Constant RECOVERING for RouterOutputState
        /// </summary>
        public static readonly RouterOutputState RECOVERING = new RouterOutputState("RECOVERING");
        /// <summary>
        /// Constant STANDBY for RouterOutputState
        /// </summary>
        public static readonly RouterOutputState STANDBY = new RouterOutputState("STANDBY");
        /// <summary>
        /// Constant STARTING for RouterOutputState
        /// </summary>
        public static readonly RouterOutputState STARTING = new RouterOutputState("STARTING");
        /// <summary>
        /// Constant STOPPING for RouterOutputState
        /// </summary>
        public static readonly RouterOutputState STOPPING = new RouterOutputState("STOPPING");
        /// <summary>
        /// Constant UPDATING for RouterOutputState
        /// </summary>
        public static readonly RouterOutputState UPDATING = new RouterOutputState("UPDATING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RouterOutputState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RouterOutputState FindValue(string value)
        {
            return FindValue<RouterOutputState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RouterOutputState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RouterOutputTier.
    /// </summary>
    public class RouterOutputTier : ConstantClass
    {

        /// <summary>
        /// Constant OUTPUT_100 for RouterOutputTier
        /// </summary>
        public static readonly RouterOutputTier OUTPUT_100 = new RouterOutputTier("OUTPUT_100");
        /// <summary>
        /// Constant OUTPUT_20 for RouterOutputTier
        /// </summary>
        public static readonly RouterOutputTier OUTPUT_20 = new RouterOutputTier("OUTPUT_20");
        /// <summary>
        /// Constant OUTPUT_50 for RouterOutputTier
        /// </summary>
        public static readonly RouterOutputTier OUTPUT_50 = new RouterOutputTier("OUTPUT_50");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RouterOutputTier(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RouterOutputTier FindValue(string value)
        {
            return FindValue<RouterOutputTier>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RouterOutputTier(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RouterOutputType.
    /// </summary>
    public class RouterOutputType : ConstantClass
    {

        /// <summary>
        /// Constant MEDIACONNECT_FLOW for RouterOutputType
        /// </summary>
        public static readonly RouterOutputType MEDIACONNECT_FLOW = new RouterOutputType("MEDIACONNECT_FLOW");
        /// <summary>
        /// Constant MEDIALIVE_INPUT for RouterOutputType
        /// </summary>
        public static readonly RouterOutputType MEDIALIVE_INPUT = new RouterOutputType("MEDIALIVE_INPUT");
        /// <summary>
        /// Constant STANDARD for RouterOutputType
        /// </summary>
        public static readonly RouterOutputType STANDARD = new RouterOutputType("STANDARD");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RouterOutputType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RouterOutputType FindValue(string value)
        {
            return FindValue<RouterOutputType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RouterOutputType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RoutingScope.
    /// </summary>
    public class RoutingScope : ConstantClass
    {

        /// <summary>
        /// Constant GLOBAL for RoutingScope
        /// </summary>
        public static readonly RoutingScope GLOBAL = new RoutingScope("GLOBAL");
        /// <summary>
        /// Constant REGIONAL for RoutingScope
        /// </summary>
        public static readonly RoutingScope REGIONAL = new RoutingScope("REGIONAL");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RoutingScope(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RoutingScope FindValue(string value)
        {
            return FindValue<RoutingScope>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RoutingScope(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ScanMode.
    /// </summary>
    public class ScanMode : ConstantClass
    {

        /// <summary>
        /// Constant Interlace for ScanMode
        /// </summary>
        public static readonly ScanMode Interlace = new ScanMode("interlace");
        /// <summary>
        /// Constant Progressive for ScanMode
        /// </summary>
        public static readonly ScanMode Progressive = new ScanMode("progressive");
        /// <summary>
        /// Constant ProgressiveSegmentedFrame for ScanMode
        /// </summary>
        public static readonly ScanMode ProgressiveSegmentedFrame = new ScanMode("progressive-segmented-frame");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ScanMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ScanMode FindValue(string value)
        {
            return FindValue<ScanMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ScanMode(string value)
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
        /// Constant ENTITLED for SourceType
        /// </summary>
        public static readonly SourceType ENTITLED = new SourceType("ENTITLED");
        /// <summary>
        /// Constant OWNED for SourceType
        /// </summary>
        public static readonly SourceType OWNED = new SourceType("OWNED");

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
        /// Constant DISABLED for State
        /// </summary>
        public static readonly State DISABLED = new State("DISABLED");
        /// <summary>
        /// Constant ENABLED for State
        /// </summary>
        public static readonly State ENABLED = new State("ENABLED");

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
    /// Constants used for properties of type Status.
    /// </summary>
    public class Status : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for Status
        /// </summary>
        public static readonly Status ACTIVE = new Status("ACTIVE");
        /// <summary>
        /// Constant DELETING for Status
        /// </summary>
        public static readonly Status DELETING = new Status("DELETING");
        /// <summary>
        /// Constant ERROR for Status
        /// </summary>
        public static readonly Status ERROR = new Status("ERROR");
        /// <summary>
        /// Constant STANDBY for Status
        /// </summary>
        public static readonly Status STANDBY = new Status("STANDBY");
        /// <summary>
        /// Constant STARTING for Status
        /// </summary>
        public static readonly Status STARTING = new Status("STARTING");
        /// <summary>
        /// Constant STOPPING for Status
        /// </summary>
        public static readonly Status STOPPING = new Status("STOPPING");
        /// <summary>
        /// Constant UPDATING for Status
        /// </summary>
        public static readonly Status UPDATING = new Status("UPDATING");

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
    /// Constants used for properties of type Tcs.
    /// </summary>
    public class Tcs : ConstantClass
    {

        /// <summary>
        /// Constant BT2100LINHLG for Tcs
        /// </summary>
        public static readonly Tcs BT2100LINHLG = new Tcs("BT2100LINHLG");
        /// <summary>
        /// Constant BT2100LINPQ for Tcs
        /// </summary>
        public static readonly Tcs BT2100LINPQ = new Tcs("BT2100LINPQ");
        /// <summary>
        /// Constant DENSITY for Tcs
        /// </summary>
        public static readonly Tcs DENSITY = new Tcs("DENSITY");
        /// <summary>
        /// Constant HLG for Tcs
        /// </summary>
        public static readonly Tcs HLG = new Tcs("HLG");
        /// <summary>
        /// Constant LINEAR for Tcs
        /// </summary>
        public static readonly Tcs LINEAR = new Tcs("LINEAR");
        /// <summary>
        /// Constant PQ for Tcs
        /// </summary>
        public static readonly Tcs PQ = new Tcs("PQ");
        /// <summary>
        /// Constant SDR for Tcs
        /// </summary>
        public static readonly Tcs SDR = new Tcs("SDR");
        /// <summary>
        /// Constant ST20651 for Tcs
        /// </summary>
        public static readonly Tcs ST20651 = new Tcs("ST2065-1");
        /// <summary>
        /// Constant ST4281 for Tcs
        /// </summary>
        public static readonly Tcs ST4281 = new Tcs("ST428-1");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Tcs(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Tcs FindValue(string value)
        {
            return FindValue<Tcs>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Tcs(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ThumbnailState.
    /// </summary>
    public class ThumbnailState : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for ThumbnailState
        /// </summary>
        public static readonly ThumbnailState DISABLED = new ThumbnailState("DISABLED");
        /// <summary>
        /// Constant ENABLED for ThumbnailState
        /// </summary>
        public static readonly ThumbnailState ENABLED = new ThumbnailState("ENABLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ThumbnailState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ThumbnailState FindValue(string value)
        {
            return FindValue<ThumbnailState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ThumbnailState(string value)
        {
            return FindValue(value);
        }
    }

}