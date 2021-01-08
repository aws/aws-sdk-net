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
 * Do not modify this file. This file is generated from the resourcegroupstaggingapi-2017-01-26.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.ResourceGroupsTaggingAPI
{

    /// <summary>
    /// Constants used for properties of type ErrorCode.
    /// </summary>
    public class ErrorCode : ConstantClass
    {

        /// <summary>
        /// Constant InternalServiceException for ErrorCode
        /// </summary>
        public static readonly ErrorCode InternalServiceException = new ErrorCode("InternalServiceException");
        /// <summary>
        /// Constant InvalidParameterException for ErrorCode
        /// </summary>
        public static readonly ErrorCode InvalidParameterException = new ErrorCode("InvalidParameterException");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ErrorCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ErrorCode FindValue(string value)
        {
            return FindValue<ErrorCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ErrorCode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type GroupByAttribute.
    /// </summary>
    public class GroupByAttribute : ConstantClass
    {

        /// <summary>
        /// Constant REGION for GroupByAttribute
        /// </summary>
        public static readonly GroupByAttribute REGION = new GroupByAttribute("REGION");
        /// <summary>
        /// Constant RESOURCE_TYPE for GroupByAttribute
        /// </summary>
        public static readonly GroupByAttribute RESOURCE_TYPE = new GroupByAttribute("RESOURCE_TYPE");
        /// <summary>
        /// Constant TARGET_ID for GroupByAttribute
        /// </summary>
        public static readonly GroupByAttribute TARGET_ID = new GroupByAttribute("TARGET_ID");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public GroupByAttribute(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static GroupByAttribute FindValue(string value)
        {
            return FindValue<GroupByAttribute>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator GroupByAttribute(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TargetIdType.
    /// </summary>
    public class TargetIdType : ConstantClass
    {

        /// <summary>
        /// Constant ACCOUNT for TargetIdType
        /// </summary>
        public static readonly TargetIdType ACCOUNT = new TargetIdType("ACCOUNT");
        /// <summary>
        /// Constant OU for TargetIdType
        /// </summary>
        public static readonly TargetIdType OU = new TargetIdType("OU");
        /// <summary>
        /// Constant ROOT for TargetIdType
        /// </summary>
        public static readonly TargetIdType ROOT = new TargetIdType("ROOT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TargetIdType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TargetIdType FindValue(string value)
        {
            return FindValue<TargetIdType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TargetIdType(string value)
        {
            return FindValue(value);
        }
    }

}