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
 * Do not modify this file. This file is generated from the kinesis-video-archived-media-2017-09-30.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.KinesisVideoArchivedMedia
{

    /// <summary>
    /// Constants used for properties of type ContainerFormat.
    /// </summary>
    public class ContainerFormat : ConstantClass
    {

        /// <summary>
        /// Constant FRAGMENTED_MP4 for ContainerFormat
        /// </summary>
        public static readonly ContainerFormat FRAGMENTED_MP4 = new ContainerFormat("FRAGMENTED_MP4");
        /// <summary>
        /// Constant MPEG_TS for ContainerFormat
        /// </summary>
        public static readonly ContainerFormat MPEG_TS = new ContainerFormat("MPEG_TS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ContainerFormat(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ContainerFormat FindValue(string value)
        {
            return FindValue<ContainerFormat>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ContainerFormat(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DiscontinuityMode.
    /// </summary>
    public class DiscontinuityMode : ConstantClass
    {

        /// <summary>
        /// Constant ALWAYS for DiscontinuityMode
        /// </summary>
        public static readonly DiscontinuityMode ALWAYS = new DiscontinuityMode("ALWAYS");
        /// <summary>
        /// Constant NEVER for DiscontinuityMode
        /// </summary>
        public static readonly DiscontinuityMode NEVER = new DiscontinuityMode("NEVER");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DiscontinuityMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DiscontinuityMode FindValue(string value)
        {
            return FindValue<DiscontinuityMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DiscontinuityMode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DisplayFragmentTimestamp.
    /// </summary>
    public class DisplayFragmentTimestamp : ConstantClass
    {

        /// <summary>
        /// Constant ALWAYS for DisplayFragmentTimestamp
        /// </summary>
        public static readonly DisplayFragmentTimestamp ALWAYS = new DisplayFragmentTimestamp("ALWAYS");
        /// <summary>
        /// Constant NEVER for DisplayFragmentTimestamp
        /// </summary>
        public static readonly DisplayFragmentTimestamp NEVER = new DisplayFragmentTimestamp("NEVER");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DisplayFragmentTimestamp(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DisplayFragmentTimestamp FindValue(string value)
        {
            return FindValue<DisplayFragmentTimestamp>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DisplayFragmentTimestamp(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type FragmentSelectorType.
    /// </summary>
    public class FragmentSelectorType : ConstantClass
    {

        /// <summary>
        /// Constant PRODUCER_TIMESTAMP for FragmentSelectorType
        /// </summary>
        public static readonly FragmentSelectorType PRODUCER_TIMESTAMP = new FragmentSelectorType("PRODUCER_TIMESTAMP");
        /// <summary>
        /// Constant SERVER_TIMESTAMP for FragmentSelectorType
        /// </summary>
        public static readonly FragmentSelectorType SERVER_TIMESTAMP = new FragmentSelectorType("SERVER_TIMESTAMP");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FragmentSelectorType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FragmentSelectorType FindValue(string value)
        {
            return FindValue<FragmentSelectorType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FragmentSelectorType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type HLSFragmentSelectorType.
    /// </summary>
    public class HLSFragmentSelectorType : ConstantClass
    {

        /// <summary>
        /// Constant PRODUCER_TIMESTAMP for HLSFragmentSelectorType
        /// </summary>
        public static readonly HLSFragmentSelectorType PRODUCER_TIMESTAMP = new HLSFragmentSelectorType("PRODUCER_TIMESTAMP");
        /// <summary>
        /// Constant SERVER_TIMESTAMP for HLSFragmentSelectorType
        /// </summary>
        public static readonly HLSFragmentSelectorType SERVER_TIMESTAMP = new HLSFragmentSelectorType("SERVER_TIMESTAMP");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public HLSFragmentSelectorType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static HLSFragmentSelectorType FindValue(string value)
        {
            return FindValue<HLSFragmentSelectorType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator HLSFragmentSelectorType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PlaybackMode.
    /// </summary>
    public class PlaybackMode : ConstantClass
    {

        /// <summary>
        /// Constant LIVE for PlaybackMode
        /// </summary>
        public static readonly PlaybackMode LIVE = new PlaybackMode("LIVE");
        /// <summary>
        /// Constant ON_DEMAND for PlaybackMode
        /// </summary>
        public static readonly PlaybackMode ON_DEMAND = new PlaybackMode("ON_DEMAND");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PlaybackMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PlaybackMode FindValue(string value)
        {
            return FindValue<PlaybackMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PlaybackMode(string value)
        {
            return FindValue(value);
        }
    }

}