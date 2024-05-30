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
 * Do not modify this file. This file is generated from the bedrock-runtime-2023-09-30.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.BedrockRuntime
{

    /// <summary>
    /// Constants used for properties of type ConversationRole.
    /// </summary>
    public class ConversationRole : ConstantClass
    {

        /// <summary>
        /// Constant Assistant for ConversationRole
        /// </summary>
        public static readonly ConversationRole Assistant = new ConversationRole("assistant");
        /// <summary>
        /// Constant User for ConversationRole
        /// </summary>
        public static readonly ConversationRole User = new ConversationRole("user");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ConversationRole(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ConversationRole FindValue(string value)
        {
            return FindValue<ConversationRole>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ConversationRole(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ImageFormat.
    /// </summary>
    public class ImageFormat : ConstantClass
    {

        /// <summary>
        /// Constant Gif for ImageFormat
        /// </summary>
        public static readonly ImageFormat Gif = new ImageFormat("gif");
        /// <summary>
        /// Constant Jpeg for ImageFormat
        /// </summary>
        public static readonly ImageFormat Jpeg = new ImageFormat("jpeg");
        /// <summary>
        /// Constant Png for ImageFormat
        /// </summary>
        public static readonly ImageFormat Png = new ImageFormat("png");
        /// <summary>
        /// Constant Webp for ImageFormat
        /// </summary>
        public static readonly ImageFormat Webp = new ImageFormat("webp");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ImageFormat(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ImageFormat FindValue(string value)
        {
            return FindValue<ImageFormat>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ImageFormat(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type StopReason.
    /// </summary>
    public class StopReason : ConstantClass
    {

        /// <summary>
        /// Constant Content_filtered for StopReason
        /// </summary>
        public static readonly StopReason Content_filtered = new StopReason("content_filtered");
        /// <summary>
        /// Constant End_turn for StopReason
        /// </summary>
        public static readonly StopReason End_turn = new StopReason("end_turn");
        /// <summary>
        /// Constant Max_tokens for StopReason
        /// </summary>
        public static readonly StopReason Max_tokens = new StopReason("max_tokens");
        /// <summary>
        /// Constant Stop_sequence for StopReason
        /// </summary>
        public static readonly StopReason Stop_sequence = new StopReason("stop_sequence");
        /// <summary>
        /// Constant Tool_use for StopReason
        /// </summary>
        public static readonly StopReason Tool_use = new StopReason("tool_use");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public StopReason(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static StopReason FindValue(string value)
        {
            return FindValue<StopReason>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator StopReason(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ToolResultStatus.
    /// </summary>
    public class ToolResultStatus : ConstantClass
    {

        /// <summary>
        /// Constant Error for ToolResultStatus
        /// </summary>
        public static readonly ToolResultStatus Error = new ToolResultStatus("error");
        /// <summary>
        /// Constant Success for ToolResultStatus
        /// </summary>
        public static readonly ToolResultStatus Success = new ToolResultStatus("success");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ToolResultStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ToolResultStatus FindValue(string value)
        {
            return FindValue<ToolResultStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ToolResultStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Trace.
    /// </summary>
    public class Trace : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for Trace
        /// </summary>
        public static readonly Trace DISABLED = new Trace("DISABLED");
        /// <summary>
        /// Constant ENABLED for Trace
        /// </summary>
        public static readonly Trace ENABLED = new Trace("ENABLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Trace(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Trace FindValue(string value)
        {
            return FindValue<Trace>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Trace(string value)
        {
            return FindValue(value);
        }
    }

}