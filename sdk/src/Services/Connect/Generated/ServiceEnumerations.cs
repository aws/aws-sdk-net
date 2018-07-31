/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.Connect
{

    /// <summary>
    /// Constants used for properties of type PhoneType.
    /// </summary>
    public class PhoneType : ConstantClass
    {

        /// <summary>
        /// Constant DESK_PHONE for PhoneType
        /// </summary>
        public static readonly PhoneType DESK_PHONE = new PhoneType("DESK_PHONE");
        /// <summary>
        /// Constant SOFT_PHONE for PhoneType
        /// </summary>
        public static readonly PhoneType SOFT_PHONE = new PhoneType("SOFT_PHONE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PhoneType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PhoneType FindValue(string value)
        {
            return FindValue<PhoneType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PhoneType(string value)
        {
            return FindValue(value);
        }
    }

}