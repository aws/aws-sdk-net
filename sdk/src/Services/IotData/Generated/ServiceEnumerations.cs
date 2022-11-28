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
 * Do not modify this file. This file is generated from the iot-data-2015-05-28.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.IotData
{

    /// <summary>
    /// Constants used for properties of type PayloadFormatIndicator.
    /// </summary>
    public class PayloadFormatIndicator : ConstantClass
    {

        /// <summary>
        /// Constant UNSPECIFIED_BYTES for PayloadFormatIndicator
        /// </summary>
        public static readonly PayloadFormatIndicator UNSPECIFIED_BYTES = new PayloadFormatIndicator("UNSPECIFIED_BYTES");
        /// <summary>
        /// Constant UTF8_DATA for PayloadFormatIndicator
        /// </summary>
        public static readonly PayloadFormatIndicator UTF8_DATA = new PayloadFormatIndicator("UTF8_DATA");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PayloadFormatIndicator(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PayloadFormatIndicator FindValue(string value)
        {
            return FindValue<PayloadFormatIndicator>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PayloadFormatIndicator(string value)
        {
            return FindValue(value);
        }
    }

}