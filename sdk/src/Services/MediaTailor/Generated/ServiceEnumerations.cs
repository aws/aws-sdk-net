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
 * Do not modify this file. This file is generated from the mediatailor-2018-04-23.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.MediaTailor
{

    /// <summary>
    /// Constants used for properties of type Mode.
    /// </summary>
    public class Mode : ConstantClass
    {

        /// <summary>
        /// Constant BEHIND_LIVE_EDGE for Mode
        /// </summary>
        public static readonly Mode BEHIND_LIVE_EDGE = new Mode("BEHIND_LIVE_EDGE");
        /// <summary>
        /// Constant OFF for Mode
        /// </summary>
        public static readonly Mode OFF = new Mode("OFF");

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
    /// Constants used for properties of type OriginManifestType.
    /// </summary>
    public class OriginManifestType : ConstantClass
    {

        /// <summary>
        /// Constant MULTI_PERIOD for OriginManifestType
        /// </summary>
        public static readonly OriginManifestType MULTI_PERIOD = new OriginManifestType("MULTI_PERIOD");
        /// <summary>
        /// Constant SINGLE_PERIOD for OriginManifestType
        /// </summary>
        public static readonly OriginManifestType SINGLE_PERIOD = new OriginManifestType("SINGLE_PERIOD");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public OriginManifestType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static OriginManifestType FindValue(string value)
        {
            return FindValue<OriginManifestType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator OriginManifestType(string value)
        {
            return FindValue(value);
        }
    }

}