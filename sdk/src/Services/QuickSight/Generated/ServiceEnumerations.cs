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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.QuickSight
{

    /// <summary>
    /// Constants used for properties of type ExceptionResourceType.
    /// </summary>
    public class ExceptionResourceType : ConstantClass
    {

        /// <summary>
        /// Constant DATA_SET for ExceptionResourceType
        /// </summary>
        public static readonly ExceptionResourceType DATA_SET = new ExceptionResourceType("DATA_SET");
        /// <summary>
        /// Constant DATA_SOURCE for ExceptionResourceType
        /// </summary>
        public static readonly ExceptionResourceType DATA_SOURCE = new ExceptionResourceType("DATA_SOURCE");
        /// <summary>
        /// Constant GROUP for ExceptionResourceType
        /// </summary>
        public static readonly ExceptionResourceType GROUP = new ExceptionResourceType("GROUP");
        /// <summary>
        /// Constant INGESTION for ExceptionResourceType
        /// </summary>
        public static readonly ExceptionResourceType INGESTION = new ExceptionResourceType("INGESTION");
        /// <summary>
        /// Constant NAMESPACE for ExceptionResourceType
        /// </summary>
        public static readonly ExceptionResourceType NAMESPACE = new ExceptionResourceType("NAMESPACE");
        /// <summary>
        /// Constant USER for ExceptionResourceType
        /// </summary>
        public static readonly ExceptionResourceType USER = new ExceptionResourceType("USER");
        /// <summary>
        /// Constant VPC_CONNECTION for ExceptionResourceType
        /// </summary>
        public static readonly ExceptionResourceType VPC_CONNECTION = new ExceptionResourceType("VPC_CONNECTION");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ExceptionResourceType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ExceptionResourceType FindValue(string value)
        {
            return FindValue<ExceptionResourceType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ExceptionResourceType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type IdentityType.
    /// </summary>
    public class IdentityType : ConstantClass
    {

        /// <summary>
        /// Constant IAM for IdentityType
        /// </summary>
        public static readonly IdentityType IAM = new IdentityType("IAM");
        /// <summary>
        /// Constant QUICKSIGHT for IdentityType
        /// </summary>
        public static readonly IdentityType QUICKSIGHT = new IdentityType("QUICKSIGHT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public IdentityType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static IdentityType FindValue(string value)
        {
            return FindValue<IdentityType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator IdentityType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type UserRole.
    /// </summary>
    public class UserRole : ConstantClass
    {

        /// <summary>
        /// Constant ADMIN for UserRole
        /// </summary>
        public static readonly UserRole ADMIN = new UserRole("ADMIN");
        /// <summary>
        /// Constant AUTHOR for UserRole
        /// </summary>
        public static readonly UserRole AUTHOR = new UserRole("AUTHOR");
        /// <summary>
        /// Constant READER for UserRole
        /// </summary>
        public static readonly UserRole READER = new UserRole("READER");
        /// <summary>
        /// Constant RESTRICTED_AUTHOR for UserRole
        /// </summary>
        public static readonly UserRole RESTRICTED_AUTHOR = new UserRole("RESTRICTED_AUTHOR");
        /// <summary>
        /// Constant RESTRICTED_READER for UserRole
        /// </summary>
        public static readonly UserRole RESTRICTED_READER = new UserRole("RESTRICTED_READER");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public UserRole(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static UserRole FindValue(string value)
        {
            return FindValue<UserRole>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator UserRole(string value)
        {
            return FindValue(value);
        }
    }

}