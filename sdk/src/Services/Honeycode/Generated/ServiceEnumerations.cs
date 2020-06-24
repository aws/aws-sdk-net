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
 * Do not modify this file. This file is generated from the honeycode-2020-03-01.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.Honeycode
{

    /// <summary>
    /// Constants used for properties of type Format.
    /// </summary>
    public class Format : ConstantClass
    {

        /// <summary>
        /// Constant ACCOUNTING for Format
        /// </summary>
        public static readonly Format ACCOUNTING = new Format("ACCOUNTING");
        /// <summary>
        /// Constant AUTO for Format
        /// </summary>
        public static readonly Format AUTO = new Format("AUTO");
        /// <summary>
        /// Constant CONTACT for Format
        /// </summary>
        public static readonly Format CONTACT = new Format("CONTACT");
        /// <summary>
        /// Constant CURRENCY for Format
        /// </summary>
        public static readonly Format CURRENCY = new Format("CURRENCY");
        /// <summary>
        /// Constant DATE for Format
        /// </summary>
        public static readonly Format DATE = new Format("DATE");
        /// <summary>
        /// Constant DATE_TIME for Format
        /// </summary>
        public static readonly Format DATE_TIME = new Format("DATE_TIME");
        /// <summary>
        /// Constant NUMBER for Format
        /// </summary>
        public static readonly Format NUMBER = new Format("NUMBER");
        /// <summary>
        /// Constant PERCENTAGE for Format
        /// </summary>
        public static readonly Format PERCENTAGE = new Format("PERCENTAGE");
        /// <summary>
        /// Constant ROWLINK for Format
        /// </summary>
        public static readonly Format ROWLINK = new Format("ROWLINK");
        /// <summary>
        /// Constant TEXT for Format
        /// </summary>
        public static readonly Format TEXT = new Format("TEXT");
        /// <summary>
        /// Constant TIME for Format
        /// </summary>
        public static readonly Format TIME = new Format("TIME");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Format(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Format FindValue(string value)
        {
            return FindValue<Format>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Format(string value)
        {
            return FindValue(value);
        }
    }

}