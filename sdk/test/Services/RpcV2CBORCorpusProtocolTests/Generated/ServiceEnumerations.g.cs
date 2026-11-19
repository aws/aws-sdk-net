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

namespace Amazon.RpcV2CBORCorpusProtocolTests
{
    /// <summary>
    /// Constants used for properties of type CorpusStringEnum.
    /// </summary>
    public class CorpusStringEnum : ConstantClass
    {
        /// <summary>
        /// Constant Bar for CorpusStringEnum
        /// </summary>
        public static readonly CorpusStringEnum Bar = new CorpusStringEnum("Bar");

        /// <summary>
        /// Constant Baz for CorpusStringEnum
        /// </summary>
        public static readonly CorpusStringEnum Baz = new CorpusStringEnum("Baz");

        /// <summary>
        /// Constant Foo for CorpusStringEnum
        /// </summary>
        public static readonly CorpusStringEnum Foo = new CorpusStringEnum("Foo");

        /// <summary>
        /// Constructs a custom CorpusStringEnum for a value not among the defined constants.
        /// </summary>
        public CorpusStringEnum(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CorpusStringEnum FindValue(string value)
        {
            return FindValue<CorpusStringEnum>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CorpusStringEnum(string value)
        {
            return FindValue(value);
        }
    }
}
