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
 * Do not modify this file. This file is generated from the secretsmanager-2017-10-17.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.SecretsManager
{

    /// <summary>
    /// Constants used for properties of type FilterNameStringType.
    /// </summary>
    public class FilterNameStringType : ConstantClass
    {

        /// <summary>
        /// Constant All for FilterNameStringType
        /// </summary>
        public static readonly FilterNameStringType All = new FilterNameStringType("all");
        /// <summary>
        /// Constant Description for FilterNameStringType
        /// </summary>
        public static readonly FilterNameStringType Description = new FilterNameStringType("description");
        /// <summary>
        /// Constant Name for FilterNameStringType
        /// </summary>
        public static readonly FilterNameStringType Name = new FilterNameStringType("name");
        /// <summary>
        /// Constant OwningService for FilterNameStringType
        /// </summary>
        public static readonly FilterNameStringType OwningService = new FilterNameStringType("owning-service");
        /// <summary>
        /// Constant PrimaryRegion for FilterNameStringType
        /// </summary>
        public static readonly FilterNameStringType PrimaryRegion = new FilterNameStringType("primary-region");
        /// <summary>
        /// Constant TagKey for FilterNameStringType
        /// </summary>
        public static readonly FilterNameStringType TagKey = new FilterNameStringType("tag-key");
        /// <summary>
        /// Constant TagValue for FilterNameStringType
        /// </summary>
        public static readonly FilterNameStringType TagValue = new FilterNameStringType("tag-value");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FilterNameStringType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FilterNameStringType FindValue(string value)
        {
            return FindValue<FilterNameStringType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FilterNameStringType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SortOrderType.
    /// </summary>
    public class SortOrderType : ConstantClass
    {

        /// <summary>
        /// Constant Asc for SortOrderType
        /// </summary>
        public static readonly SortOrderType Asc = new SortOrderType("asc");
        /// <summary>
        /// Constant Desc for SortOrderType
        /// </summary>
        public static readonly SortOrderType Desc = new SortOrderType("desc");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SortOrderType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SortOrderType FindValue(string value)
        {
            return FindValue<SortOrderType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SortOrderType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type StatusType.
    /// </summary>
    public class StatusType : ConstantClass
    {

        /// <summary>
        /// Constant Failed for StatusType
        /// </summary>
        public static readonly StatusType Failed = new StatusType("Failed");
        /// <summary>
        /// Constant InProgress for StatusType
        /// </summary>
        public static readonly StatusType InProgress = new StatusType("InProgress");
        /// <summary>
        /// Constant InSync for StatusType
        /// </summary>
        public static readonly StatusType InSync = new StatusType("InSync");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public StatusType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static StatusType FindValue(string value)
        {
            return FindValue<StatusType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator StatusType(string value)
        {
            return FindValue(value);
        }
    }

}