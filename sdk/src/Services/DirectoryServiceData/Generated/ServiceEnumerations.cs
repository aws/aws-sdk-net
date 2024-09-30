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
 * Do not modify this file. This file is generated from the directory-service-data-2023-05-31.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.DirectoryServiceData
{

    /// <summary>
    /// Constants used for properties of type AccessDeniedReason.
    /// </summary>
    public class AccessDeniedReason : ConstantClass
    {

        /// <summary>
        /// Constant DATA_DISABLED for AccessDeniedReason
        /// </summary>
        public static readonly AccessDeniedReason DATA_DISABLED = new AccessDeniedReason("DATA_DISABLED");
        /// <summary>
        /// Constant DIRECTORY_AUTH for AccessDeniedReason
        /// </summary>
        public static readonly AccessDeniedReason DIRECTORY_AUTH = new AccessDeniedReason("DIRECTORY_AUTH");
        /// <summary>
        /// Constant IAM_AUTH for AccessDeniedReason
        /// </summary>
        public static readonly AccessDeniedReason IAM_AUTH = new AccessDeniedReason("IAM_AUTH");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AccessDeniedReason(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AccessDeniedReason FindValue(string value)
        {
            return FindValue<AccessDeniedReason>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AccessDeniedReason(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DirectoryUnavailableReason.
    /// </summary>
    public class DirectoryUnavailableReason : ConstantClass
    {

        /// <summary>
        /// Constant DIRECTORY_RESOURCES_EXCEEDED for DirectoryUnavailableReason
        /// </summary>
        public static readonly DirectoryUnavailableReason DIRECTORY_RESOURCES_EXCEEDED = new DirectoryUnavailableReason("DIRECTORY_RESOURCES_EXCEEDED");
        /// <summary>
        /// Constant DIRECTORY_TIMEOUT for DirectoryUnavailableReason
        /// </summary>
        public static readonly DirectoryUnavailableReason DIRECTORY_TIMEOUT = new DirectoryUnavailableReason("DIRECTORY_TIMEOUT");
        /// <summary>
        /// Constant INVALID_DIRECTORY_STATE for DirectoryUnavailableReason
        /// </summary>
        public static readonly DirectoryUnavailableReason INVALID_DIRECTORY_STATE = new DirectoryUnavailableReason("INVALID_DIRECTORY_STATE");
        /// <summary>
        /// Constant NO_DISK_SPACE for DirectoryUnavailableReason
        /// </summary>
        public static readonly DirectoryUnavailableReason NO_DISK_SPACE = new DirectoryUnavailableReason("NO_DISK_SPACE");
        /// <summary>
        /// Constant TRUST_AUTH_FAILURE for DirectoryUnavailableReason
        /// </summary>
        public static readonly DirectoryUnavailableReason TRUST_AUTH_FAILURE = new DirectoryUnavailableReason("TRUST_AUTH_FAILURE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DirectoryUnavailableReason(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DirectoryUnavailableReason FindValue(string value)
        {
            return FindValue<DirectoryUnavailableReason>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DirectoryUnavailableReason(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type GroupScope.
    /// </summary>
    public class GroupScope : ConstantClass
    {

        /// <summary>
        /// Constant BuiltinLocal for GroupScope
        /// </summary>
        public static readonly GroupScope BuiltinLocal = new GroupScope("BuiltinLocal");
        /// <summary>
        /// Constant DomainLocal for GroupScope
        /// </summary>
        public static readonly GroupScope DomainLocal = new GroupScope("DomainLocal");
        /// <summary>
        /// Constant Global for GroupScope
        /// </summary>
        public static readonly GroupScope Global = new GroupScope("Global");
        /// <summary>
        /// Constant Universal for GroupScope
        /// </summary>
        public static readonly GroupScope Universal = new GroupScope("Universal");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public GroupScope(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static GroupScope FindValue(string value)
        {
            return FindValue<GroupScope>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator GroupScope(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type GroupType.
    /// </summary>
    public class GroupType : ConstantClass
    {

        /// <summary>
        /// Constant Distribution for GroupType
        /// </summary>
        public static readonly GroupType Distribution = new GroupType("Distribution");
        /// <summary>
        /// Constant Security for GroupType
        /// </summary>
        public static readonly GroupType Security = new GroupType("Security");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public GroupType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static GroupType FindValue(string value)
        {
            return FindValue<GroupType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator GroupType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type MemberType.
    /// </summary>
    public class MemberType : ConstantClass
    {

        /// <summary>
        /// Constant COMPUTER for MemberType
        /// </summary>
        public static readonly MemberType COMPUTER = new MemberType("COMPUTER");
        /// <summary>
        /// Constant GROUP for MemberType
        /// </summary>
        public static readonly MemberType GROUP = new MemberType("GROUP");
        /// <summary>
        /// Constant USER for MemberType
        /// </summary>
        public static readonly MemberType USER = new MemberType("USER");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MemberType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MemberType FindValue(string value)
        {
            return FindValue<MemberType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MemberType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type UpdateType.
    /// </summary>
    public class UpdateType : ConstantClass
    {

        /// <summary>
        /// Constant ADD for UpdateType
        /// </summary>
        public static readonly UpdateType ADD = new UpdateType("ADD");
        /// <summary>
        /// Constant REMOVE for UpdateType
        /// </summary>
        public static readonly UpdateType REMOVE = new UpdateType("REMOVE");
        /// <summary>
        /// Constant REPLACE for UpdateType
        /// </summary>
        public static readonly UpdateType REPLACE = new UpdateType("REPLACE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public UpdateType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static UpdateType FindValue(string value)
        {
            return FindValue<UpdateType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator UpdateType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ValidationExceptionReason.
    /// </summary>
    public class ValidationExceptionReason : ConstantClass
    {

        /// <summary>
        /// Constant ATTRIBUTE_EXISTS for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason ATTRIBUTE_EXISTS = new ValidationExceptionReason("ATTRIBUTE_EXISTS");
        /// <summary>
        /// Constant DUPLICATE_ATTRIBUTE for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason DUPLICATE_ATTRIBUTE = new ValidationExceptionReason("DUPLICATE_ATTRIBUTE");
        /// <summary>
        /// Constant INVALID_ATTRIBUTE_FOR_GROUP for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason INVALID_ATTRIBUTE_FOR_GROUP = new ValidationExceptionReason("INVALID_ATTRIBUTE_FOR_GROUP");
        /// <summary>
        /// Constant INVALID_ATTRIBUTE_FOR_MODIFY for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason INVALID_ATTRIBUTE_FOR_MODIFY = new ValidationExceptionReason("INVALID_ATTRIBUTE_FOR_MODIFY");
        /// <summary>
        /// Constant INVALID_ATTRIBUTE_FOR_SEARCH for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason INVALID_ATTRIBUTE_FOR_SEARCH = new ValidationExceptionReason("INVALID_ATTRIBUTE_FOR_SEARCH");
        /// <summary>
        /// Constant INVALID_ATTRIBUTE_FOR_USER for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason INVALID_ATTRIBUTE_FOR_USER = new ValidationExceptionReason("INVALID_ATTRIBUTE_FOR_USER");
        /// <summary>
        /// Constant INVALID_ATTRIBUTE_NAME for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason INVALID_ATTRIBUTE_NAME = new ValidationExceptionReason("INVALID_ATTRIBUTE_NAME");
        /// <summary>
        /// Constant INVALID_ATTRIBUTE_VALUE for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason INVALID_ATTRIBUTE_VALUE = new ValidationExceptionReason("INVALID_ATTRIBUTE_VALUE");
        /// <summary>
        /// Constant INVALID_DIRECTORY_TYPE for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason INVALID_DIRECTORY_TYPE = new ValidationExceptionReason("INVALID_DIRECTORY_TYPE");
        /// <summary>
        /// Constant INVALID_NEXT_TOKEN for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason INVALID_NEXT_TOKEN = new ValidationExceptionReason("INVALID_NEXT_TOKEN");
        /// <summary>
        /// Constant INVALID_REALM for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason INVALID_REALM = new ValidationExceptionReason("INVALID_REALM");
        /// <summary>
        /// Constant INVALID_SECONDARY_REGION for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason INVALID_SECONDARY_REGION = new ValidationExceptionReason("INVALID_SECONDARY_REGION");
        /// <summary>
        /// Constant LDAP_SIZE_LIMIT_EXCEEDED for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason LDAP_SIZE_LIMIT_EXCEEDED = new ValidationExceptionReason("LDAP_SIZE_LIMIT_EXCEEDED");
        /// <summary>
        /// Constant LDAP_UNSUPPORTED_OPERATION for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason LDAP_UNSUPPORTED_OPERATION = new ValidationExceptionReason("LDAP_UNSUPPORTED_OPERATION");
        /// <summary>
        /// Constant MISSING_ATTRIBUTE for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason MISSING_ATTRIBUTE = new ValidationExceptionReason("MISSING_ATTRIBUTE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ValidationExceptionReason(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ValidationExceptionReason FindValue(string value)
        {
            return FindValue<ValidationExceptionReason>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ValidationExceptionReason(string value)
        {
            return FindValue(value);
        }
    }

}