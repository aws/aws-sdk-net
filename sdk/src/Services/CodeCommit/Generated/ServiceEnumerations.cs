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
 * Do not modify this file. This file is generated from the codecommit-2015-04-13.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.CodeCommit
{

    /// <summary>
    /// Constants used for properties of type OrderEnum.
    /// </summary>
    public class OrderEnum : ConstantClass
    {

        /// <summary>
        /// Constant Ascending for OrderEnum
        /// </summary>
        public static readonly OrderEnum Ascending = new OrderEnum("ascending");
        /// <summary>
        /// Constant Descending for OrderEnum
        /// </summary>
        public static readonly OrderEnum Descending = new OrderEnum("descending");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public OrderEnum(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static OrderEnum FindValue(string value)
        {
            return FindValue<OrderEnum>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator OrderEnum(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RepositoryTriggerEventEnum.
    /// </summary>
    public class RepositoryTriggerEventEnum : ConstantClass
    {

        /// <summary>
        /// Constant All for RepositoryTriggerEventEnum
        /// </summary>
        public static readonly RepositoryTriggerEventEnum All = new RepositoryTriggerEventEnum("all");
        /// <summary>
        /// Constant CreateReference for RepositoryTriggerEventEnum
        /// </summary>
        public static readonly RepositoryTriggerEventEnum CreateReference = new RepositoryTriggerEventEnum("createReference");
        /// <summary>
        /// Constant DeleteReference for RepositoryTriggerEventEnum
        /// </summary>
        public static readonly RepositoryTriggerEventEnum DeleteReference = new RepositoryTriggerEventEnum("deleteReference");
        /// <summary>
        /// Constant UpdateReference for RepositoryTriggerEventEnum
        /// </summary>
        public static readonly RepositoryTriggerEventEnum UpdateReference = new RepositoryTriggerEventEnum("updateReference");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RepositoryTriggerEventEnum(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RepositoryTriggerEventEnum FindValue(string value)
        {
            return FindValue<RepositoryTriggerEventEnum>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RepositoryTriggerEventEnum(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SortByEnum.
    /// </summary>
    public class SortByEnum : ConstantClass
    {

        /// <summary>
        /// Constant LastModifiedDate for SortByEnum
        /// </summary>
        public static readonly SortByEnum LastModifiedDate = new SortByEnum("lastModifiedDate");
        /// <summary>
        /// Constant RepositoryName for SortByEnum
        /// </summary>
        public static readonly SortByEnum RepositoryName = new SortByEnum("repositoryName");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SortByEnum(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SortByEnum FindValue(string value)
        {
            return FindValue<SortByEnum>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SortByEnum(string value)
        {
            return FindValue(value);
        }
    }

}