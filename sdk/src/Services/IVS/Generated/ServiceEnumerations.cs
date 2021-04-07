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
 * Do not modify this file. This file is generated from the ivs-2020-07-14.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.IVS
{

    /// <summary>
    /// Constants used for properties of type ChannelLatencyMode.
    /// </summary>
    public class ChannelLatencyMode : ConstantClass
    {

        /// <summary>
        /// Constant LOW for ChannelLatencyMode
        /// </summary>
        public static readonly ChannelLatencyMode LOW = new ChannelLatencyMode("LOW");
        /// <summary>
        /// Constant NORMAL for ChannelLatencyMode
        /// </summary>
        public static readonly ChannelLatencyMode NORMAL = new ChannelLatencyMode("NORMAL");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ChannelLatencyMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ChannelLatencyMode FindValue(string value)
        {
            return FindValue<ChannelLatencyMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ChannelLatencyMode(string value)
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
        /// Constant BASIC for ChannelType
        /// </summary>
        public static readonly ChannelType BASIC = new ChannelType("BASIC");
        /// <summary>
        /// Constant STANDARD for ChannelType
        /// </summary>
        public static readonly ChannelType STANDARD = new ChannelType("STANDARD");

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
    /// Constants used for properties of type RecordingConfigurationState.
    /// </summary>
    public class RecordingConfigurationState : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for RecordingConfigurationState
        /// </summary>
        public static readonly RecordingConfigurationState ACTIVE = new RecordingConfigurationState("ACTIVE");
        /// <summary>
        /// Constant CREATE_FAILED for RecordingConfigurationState
        /// </summary>
        public static readonly RecordingConfigurationState CREATE_FAILED = new RecordingConfigurationState("CREATE_FAILED");
        /// <summary>
        /// Constant CREATING for RecordingConfigurationState
        /// </summary>
        public static readonly RecordingConfigurationState CREATING = new RecordingConfigurationState("CREATING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RecordingConfigurationState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RecordingConfigurationState FindValue(string value)
        {
            return FindValue<RecordingConfigurationState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RecordingConfigurationState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type StreamHealth.
    /// </summary>
    public class StreamHealth : ConstantClass
    {

        /// <summary>
        /// Constant HEALTHY for StreamHealth
        /// </summary>
        public static readonly StreamHealth HEALTHY = new StreamHealth("HEALTHY");
        /// <summary>
        /// Constant STARVING for StreamHealth
        /// </summary>
        public static readonly StreamHealth STARVING = new StreamHealth("STARVING");
        /// <summary>
        /// Constant UNKNOWN for StreamHealth
        /// </summary>
        public static readonly StreamHealth UNKNOWN = new StreamHealth("UNKNOWN");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public StreamHealth(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static StreamHealth FindValue(string value)
        {
            return FindValue<StreamHealth>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator StreamHealth(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type StreamState.
    /// </summary>
    public class StreamState : ConstantClass
    {

        /// <summary>
        /// Constant LIVE for StreamState
        /// </summary>
        public static readonly StreamState LIVE = new StreamState("LIVE");
        /// <summary>
        /// Constant OFFLINE for StreamState
        /// </summary>
        public static readonly StreamState OFFLINE = new StreamState("OFFLINE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public StreamState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static StreamState FindValue(string value)
        {
            return FindValue<StreamState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator StreamState(string value)
        {
            return FindValue(value);
        }
    }

}