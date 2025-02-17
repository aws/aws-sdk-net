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
        /// Constant ADVANCED_HD for ChannelType
        /// </summary>
        public static readonly ChannelType ADVANCED_HD = new ChannelType("ADVANCED_HD");
        /// <summary>
        /// Constant ADVANCED_SD for ChannelType
        /// </summary>
        public static readonly ChannelType ADVANCED_SD = new ChannelType("ADVANCED_SD");
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
    /// Constants used for properties of type ContainerFormat.
    /// </summary>
    public class ContainerFormat : ConstantClass
    {

        /// <summary>
        /// Constant FRAGMENTED_MP4 for ContainerFormat
        /// </summary>
        public static readonly ContainerFormat FRAGMENTED_MP4 = new ContainerFormat("FRAGMENTED_MP4");
        /// <summary>
        /// Constant TS for ContainerFormat
        /// </summary>
        public static readonly ContainerFormat TS = new ContainerFormat("TS");

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
    /// Constants used for properties of type MultitrackMaximumResolution.
    /// </summary>
    public class MultitrackMaximumResolution : ConstantClass
    {

        /// <summary>
        /// Constant FULL_HD for MultitrackMaximumResolution
        /// </summary>
        public static readonly MultitrackMaximumResolution FULL_HD = new MultitrackMaximumResolution("FULL_HD");
        /// <summary>
        /// Constant HD for MultitrackMaximumResolution
        /// </summary>
        public static readonly MultitrackMaximumResolution HD = new MultitrackMaximumResolution("HD");
        /// <summary>
        /// Constant SD for MultitrackMaximumResolution
        /// </summary>
        public static readonly MultitrackMaximumResolution SD = new MultitrackMaximumResolution("SD");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MultitrackMaximumResolution(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MultitrackMaximumResolution FindValue(string value)
        {
            return FindValue<MultitrackMaximumResolution>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MultitrackMaximumResolution(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type MultitrackPolicy.
    /// </summary>
    public class MultitrackPolicy : ConstantClass
    {

        /// <summary>
        /// Constant ALLOW for MultitrackPolicy
        /// </summary>
        public static readonly MultitrackPolicy ALLOW = new MultitrackPolicy("ALLOW");
        /// <summary>
        /// Constant REQUIRE for MultitrackPolicy
        /// </summary>
        public static readonly MultitrackPolicy REQUIRE = new MultitrackPolicy("REQUIRE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MultitrackPolicy(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MultitrackPolicy FindValue(string value)
        {
            return FindValue<MultitrackPolicy>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MultitrackPolicy(string value)
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
    /// Constants used for properties of type RecordingMode.
    /// </summary>
    public class RecordingMode : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for RecordingMode
        /// </summary>
        public static readonly RecordingMode DISABLED = new RecordingMode("DISABLED");
        /// <summary>
        /// Constant INTERVAL for RecordingMode
        /// </summary>
        public static readonly RecordingMode INTERVAL = new RecordingMode("INTERVAL");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RecordingMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RecordingMode FindValue(string value)
        {
            return FindValue<RecordingMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RecordingMode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RenditionConfigurationRendition.
    /// </summary>
    public class RenditionConfigurationRendition : ConstantClass
    {

        /// <summary>
        /// Constant FULL_HD for RenditionConfigurationRendition
        /// </summary>
        public static readonly RenditionConfigurationRendition FULL_HD = new RenditionConfigurationRendition("FULL_HD");
        /// <summary>
        /// Constant HD for RenditionConfigurationRendition
        /// </summary>
        public static readonly RenditionConfigurationRendition HD = new RenditionConfigurationRendition("HD");
        /// <summary>
        /// Constant LOWEST_RESOLUTION for RenditionConfigurationRendition
        /// </summary>
        public static readonly RenditionConfigurationRendition LOWEST_RESOLUTION = new RenditionConfigurationRendition("LOWEST_RESOLUTION");
        /// <summary>
        /// Constant SD for RenditionConfigurationRendition
        /// </summary>
        public static readonly RenditionConfigurationRendition SD = new RenditionConfigurationRendition("SD");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RenditionConfigurationRendition(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RenditionConfigurationRendition FindValue(string value)
        {
            return FindValue<RenditionConfigurationRendition>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RenditionConfigurationRendition(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RenditionConfigurationRenditionSelection.
    /// </summary>
    public class RenditionConfigurationRenditionSelection : ConstantClass
    {

        /// <summary>
        /// Constant ALL for RenditionConfigurationRenditionSelection
        /// </summary>
        public static readonly RenditionConfigurationRenditionSelection ALL = new RenditionConfigurationRenditionSelection("ALL");
        /// <summary>
        /// Constant CUSTOM for RenditionConfigurationRenditionSelection
        /// </summary>
        public static readonly RenditionConfigurationRenditionSelection CUSTOM = new RenditionConfigurationRenditionSelection("CUSTOM");
        /// <summary>
        /// Constant NONE for RenditionConfigurationRenditionSelection
        /// </summary>
        public static readonly RenditionConfigurationRenditionSelection NONE = new RenditionConfigurationRenditionSelection("NONE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RenditionConfigurationRenditionSelection(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RenditionConfigurationRenditionSelection FindValue(string value)
        {
            return FindValue<RenditionConfigurationRenditionSelection>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RenditionConfigurationRenditionSelection(string value)
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


    /// <summary>
    /// Constants used for properties of type ThumbnailConfigurationResolution.
    /// </summary>
    public class ThumbnailConfigurationResolution : ConstantClass
    {

        /// <summary>
        /// Constant FULL_HD for ThumbnailConfigurationResolution
        /// </summary>
        public static readonly ThumbnailConfigurationResolution FULL_HD = new ThumbnailConfigurationResolution("FULL_HD");
        /// <summary>
        /// Constant HD for ThumbnailConfigurationResolution
        /// </summary>
        public static readonly ThumbnailConfigurationResolution HD = new ThumbnailConfigurationResolution("HD");
        /// <summary>
        /// Constant LOWEST_RESOLUTION for ThumbnailConfigurationResolution
        /// </summary>
        public static readonly ThumbnailConfigurationResolution LOWEST_RESOLUTION = new ThumbnailConfigurationResolution("LOWEST_RESOLUTION");
        /// <summary>
        /// Constant SD for ThumbnailConfigurationResolution
        /// </summary>
        public static readonly ThumbnailConfigurationResolution SD = new ThumbnailConfigurationResolution("SD");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ThumbnailConfigurationResolution(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ThumbnailConfigurationResolution FindValue(string value)
        {
            return FindValue<ThumbnailConfigurationResolution>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ThumbnailConfigurationResolution(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ThumbnailConfigurationStorage.
    /// </summary>
    public class ThumbnailConfigurationStorage : ConstantClass
    {

        /// <summary>
        /// Constant LATEST for ThumbnailConfigurationStorage
        /// </summary>
        public static readonly ThumbnailConfigurationStorage LATEST = new ThumbnailConfigurationStorage("LATEST");
        /// <summary>
        /// Constant SEQUENTIAL for ThumbnailConfigurationStorage
        /// </summary>
        public static readonly ThumbnailConfigurationStorage SEQUENTIAL = new ThumbnailConfigurationStorage("SEQUENTIAL");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ThumbnailConfigurationStorage(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ThumbnailConfigurationStorage FindValue(string value)
        {
            return FindValue<ThumbnailConfigurationStorage>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ThumbnailConfigurationStorage(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TranscodePreset.
    /// </summary>
    public class TranscodePreset : ConstantClass
    {

        /// <summary>
        /// Constant CONSTRAINED_BANDWIDTH_DELIVERY for TranscodePreset
        /// </summary>
        public static readonly TranscodePreset CONSTRAINED_BANDWIDTH_DELIVERY = new TranscodePreset("CONSTRAINED_BANDWIDTH_DELIVERY");
        /// <summary>
        /// Constant HIGHER_BANDWIDTH_DELIVERY for TranscodePreset
        /// </summary>
        public static readonly TranscodePreset HIGHER_BANDWIDTH_DELIVERY = new TranscodePreset("HIGHER_BANDWIDTH_DELIVERY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TranscodePreset(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TranscodePreset FindValue(string value)
        {
            return FindValue<TranscodePreset>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TranscodePreset(string value)
        {
            return FindValue(value);
        }
    }

}