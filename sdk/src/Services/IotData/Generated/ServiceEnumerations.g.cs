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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
        /// Constructs a custom PayloadFormatIndicator for a value not among the defined constants.
        /// </summary>
        public PayloadFormatIndicator(string value) : base(value) { }

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
