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
using Amazon.Runtime;

namespace Amazon.MediaLive
{
    /// <summary>
    /// Constants used for properties of type ArchiveS3LogUploads.
    /// </summary>
    public class ArchiveS3LogUploads : ConstantClass
    {
        /// <summary>
        /// Constant DISABLED for ArchiveS3LogUploads
        /// </summary>
        public static readonly ArchiveS3LogUploads DISABLED = new ArchiveS3LogUploads("DISABLED");

        /// <summary>
        /// Constant ENABLED for ArchiveS3LogUploads
        /// </summary>
        public static readonly ArchiveS3LogUploads ENABLED = new ArchiveS3LogUploads("ENABLED");

        /// <summary>
        /// Constructs a custom ArchiveS3LogUploads for a value not among the defined constants.
        /// </summary>
        public ArchiveS3LogUploads(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ArchiveS3LogUploads FindValue(string value)
        {
            return FindValue<ArchiveS3LogUploads>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ArchiveS3LogUploads(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type FrameCaptureS3LogUploads.
    /// </summary>
    public class FrameCaptureS3LogUploads : ConstantClass
    {
        /// <summary>
        /// Constant DISABLED for FrameCaptureS3LogUploads
        /// </summary>
        public static readonly FrameCaptureS3LogUploads DISABLED = new FrameCaptureS3LogUploads("DISABLED");

        /// <summary>
        /// Constant ENABLED for FrameCaptureS3LogUploads
        /// </summary>
        public static readonly FrameCaptureS3LogUploads ENABLED = new FrameCaptureS3LogUploads("ENABLED");

        /// <summary>
        /// Constructs a custom FrameCaptureS3LogUploads for a value not among the defined constants.
        /// </summary>
        public FrameCaptureS3LogUploads(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FrameCaptureS3LogUploads FindValue(string value)
        {
            return FindValue<FrameCaptureS3LogUploads>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FrameCaptureS3LogUploads(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type HlsS3LogUploads.
    /// </summary>
    public class HlsS3LogUploads : ConstantClass
    {
        /// <summary>
        /// Constant DISABLED for HlsS3LogUploads
        /// </summary>
        public static readonly HlsS3LogUploads DISABLED = new HlsS3LogUploads("DISABLED");

        /// <summary>
        /// Constant ENABLED for HlsS3LogUploads
        /// </summary>
        public static readonly HlsS3LogUploads ENABLED = new HlsS3LogUploads("ENABLED");

        /// <summary>
        /// Constructs a custom HlsS3LogUploads for a value not among the defined constants.
        /// </summary>
        public HlsS3LogUploads(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static HlsS3LogUploads FindValue(string value)
        {
            return FindValue<HlsS3LogUploads>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator HlsS3LogUploads(string value)
        {
            return FindValue(value);
        }
    }
}
