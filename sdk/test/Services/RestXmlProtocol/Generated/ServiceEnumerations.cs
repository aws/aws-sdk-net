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
 * Do not modify this file. This file is generated from the rest-xml-protocol-2019-12-16.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.RestXmlProtocol
{

    /// <summary>
    /// Constants used for properties of type FooEnum.
    /// </summary>
    public class FooEnum : ConstantClass
    {

        /// <summary>
        /// Constant Bar for FooEnum
        /// </summary>
        public static readonly FooEnum Bar = new FooEnum("Bar");
        /// <summary>
        /// Constant Baz for FooEnum
        /// </summary>
        public static readonly FooEnum Baz = new FooEnum("Baz");
        /// <summary>
        /// Constant Foo for FooEnum
        /// </summary>
        public static readonly FooEnum Foo = new FooEnum("Foo");
        /// <summary>
        /// Constant Num_0 for FooEnum
        /// </summary>
        public static readonly FooEnum Num_0 = new FooEnum("0");
        /// <summary>
        /// Constant Num_1 for FooEnum
        /// </summary>
        public static readonly FooEnum Num_1 = new FooEnum("1");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FooEnum(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FooEnum FindValue(string value)
        {
            return FindValue<FooEnum>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FooEnum(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type StringEnum.
    /// </summary>
    public class StringEnum : ConstantClass
    {

        /// <summary>
        /// Constant Enumvalue for StringEnum
        /// </summary>
        public static readonly StringEnum Enumvalue = new StringEnum("enumvalue");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public StringEnum(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static StringEnum FindValue(string value)
        {
            return FindValue<StringEnum>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator StringEnum(string value)
        {
            return FindValue(value);
        }
    }

}