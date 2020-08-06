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
 * Do not modify this file. This file is generated from the kinesis-video-media-2017-09-30.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.KinesisVideoMedia
{

    /// <summary>
    /// Constants used for properties of type StartSelectorType.
    /// </summary>
    public class StartSelectorType : ConstantClass
    {

        /// <summary>
        /// Constant CONTINUATION_TOKEN for StartSelectorType
        /// </summary>
        public static readonly StartSelectorType CONTINUATION_TOKEN = new StartSelectorType("CONTINUATION_TOKEN");
        /// <summary>
        /// Constant EARLIEST for StartSelectorType
        /// </summary>
        public static readonly StartSelectorType EARLIEST = new StartSelectorType("EARLIEST");
        /// <summary>
        /// Constant FRAGMENT_NUMBER for StartSelectorType
        /// </summary>
        public static readonly StartSelectorType FRAGMENT_NUMBER = new StartSelectorType("FRAGMENT_NUMBER");
        /// <summary>
        /// Constant NOW for StartSelectorType
        /// </summary>
        public static readonly StartSelectorType NOW = new StartSelectorType("NOW");
        /// <summary>
        /// Constant PRODUCER_TIMESTAMP for StartSelectorType
        /// </summary>
        public static readonly StartSelectorType PRODUCER_TIMESTAMP = new StartSelectorType("PRODUCER_TIMESTAMP");
        /// <summary>
        /// Constant SERVER_TIMESTAMP for StartSelectorType
        /// </summary>
        public static readonly StartSelectorType SERVER_TIMESTAMP = new StartSelectorType("SERVER_TIMESTAMP");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public StartSelectorType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static StartSelectorType FindValue(string value)
        {
            return FindValue<StartSelectorType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator StartSelectorType(string value)
        {
            return FindValue(value);
        }
    }

}