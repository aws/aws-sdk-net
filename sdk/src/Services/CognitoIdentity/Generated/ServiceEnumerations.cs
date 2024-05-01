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
 * Do not modify this file. This file is generated from the cognito-identity-2014-06-30.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.CognitoIdentity
{

    /// <summary>
    /// Constants used for properties of type AmbiguousRoleResolutionType.
    /// </summary>
    public class AmbiguousRoleResolutionType : ConstantClass
    {

        /// <summary>
        /// Constant AuthenticatedRole for AmbiguousRoleResolutionType
        /// </summary>
        public static readonly AmbiguousRoleResolutionType AuthenticatedRole = new AmbiguousRoleResolutionType("AuthenticatedRole");
        /// <summary>
        /// Constant Deny for AmbiguousRoleResolutionType
        /// </summary>
        public static readonly AmbiguousRoleResolutionType Deny = new AmbiguousRoleResolutionType("Deny");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AmbiguousRoleResolutionType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AmbiguousRoleResolutionType FindValue(string value)
        {
            return FindValue<AmbiguousRoleResolutionType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AmbiguousRoleResolutionType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ErrorCode.
    /// </summary>
    public class ErrorCode : ConstantClass
    {

        /// <summary>
        /// Constant AccessDenied for ErrorCode
        /// </summary>
        public static readonly ErrorCode AccessDenied = new ErrorCode("AccessDenied");
        /// <summary>
        /// Constant InternalServerError for ErrorCode
        /// </summary>
        public static readonly ErrorCode InternalServerError = new ErrorCode("InternalServerError");

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
    /// Constants used for properties of type MappingRuleMatchType.
    /// </summary>
    public class MappingRuleMatchType : ConstantClass
    {

        /// <summary>
        /// Constant Contains for MappingRuleMatchType
        /// </summary>
        public static readonly MappingRuleMatchType Contains = new MappingRuleMatchType("Contains");
        /// <summary>
        /// Constant Equals for MappingRuleMatchType
        /// </summary>
        public new static readonly MappingRuleMatchType Equals = new MappingRuleMatchType("Equals");
        /// <summary>
        /// Constant NotEqual for MappingRuleMatchType
        /// </summary>
        public static readonly MappingRuleMatchType NotEqual = new MappingRuleMatchType("NotEqual");
        /// <summary>
        /// Constant StartsWith for MappingRuleMatchType
        /// </summary>
        public static readonly MappingRuleMatchType StartsWith = new MappingRuleMatchType("StartsWith");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MappingRuleMatchType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MappingRuleMatchType FindValue(string value)
        {
            return FindValue<MappingRuleMatchType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MappingRuleMatchType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RoleMappingType.
    /// </summary>
    public class RoleMappingType : ConstantClass
    {

        /// <summary>
        /// Constant Rules for RoleMappingType
        /// </summary>
        public static readonly RoleMappingType Rules = new RoleMappingType("Rules");
        /// <summary>
        /// Constant Token for RoleMappingType
        /// </summary>
        public static readonly RoleMappingType Token = new RoleMappingType("Token");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RoleMappingType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RoleMappingType FindValue(string value)
        {
            return FindValue<RoleMappingType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RoleMappingType(string value)
        {
            return FindValue(value);
        }
    }

}