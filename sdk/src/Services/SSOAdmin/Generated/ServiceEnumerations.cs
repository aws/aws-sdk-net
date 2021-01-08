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
 * Do not modify this file. This file is generated from the sso-admin-2020-07-20.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.SSOAdmin
{

    /// <summary>
    /// Constants used for properties of type InstanceAccessControlAttributeConfigurationStatus.
    /// </summary>
    public class InstanceAccessControlAttributeConfigurationStatus : ConstantClass
    {

        /// <summary>
        /// Constant CREATION_FAILED for InstanceAccessControlAttributeConfigurationStatus
        /// </summary>
        public static readonly InstanceAccessControlAttributeConfigurationStatus CREATION_FAILED = new InstanceAccessControlAttributeConfigurationStatus("CREATION_FAILED");
        /// <summary>
        /// Constant CREATION_IN_PROGRESS for InstanceAccessControlAttributeConfigurationStatus
        /// </summary>
        public static readonly InstanceAccessControlAttributeConfigurationStatus CREATION_IN_PROGRESS = new InstanceAccessControlAttributeConfigurationStatus("CREATION_IN_PROGRESS");
        /// <summary>
        /// Constant ENABLED for InstanceAccessControlAttributeConfigurationStatus
        /// </summary>
        public static readonly InstanceAccessControlAttributeConfigurationStatus ENABLED = new InstanceAccessControlAttributeConfigurationStatus("ENABLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public InstanceAccessControlAttributeConfigurationStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static InstanceAccessControlAttributeConfigurationStatus FindValue(string value)
        {
            return FindValue<InstanceAccessControlAttributeConfigurationStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator InstanceAccessControlAttributeConfigurationStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PrincipalType.
    /// </summary>
    public class PrincipalType : ConstantClass
    {

        /// <summary>
        /// Constant GROUP for PrincipalType
        /// </summary>
        public static readonly PrincipalType GROUP = new PrincipalType("GROUP");
        /// <summary>
        /// Constant USER for PrincipalType
        /// </summary>
        public static readonly PrincipalType USER = new PrincipalType("USER");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PrincipalType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PrincipalType FindValue(string value)
        {
            return FindValue<PrincipalType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PrincipalType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ProvisioningStatus.
    /// </summary>
    public class ProvisioningStatus : ConstantClass
    {

        /// <summary>
        /// Constant LATEST_PERMISSION_SET_NOT_PROVISIONED for ProvisioningStatus
        /// </summary>
        public static readonly ProvisioningStatus LATEST_PERMISSION_SET_NOT_PROVISIONED = new ProvisioningStatus("LATEST_PERMISSION_SET_NOT_PROVISIONED");
        /// <summary>
        /// Constant LATEST_PERMISSION_SET_PROVISIONED for ProvisioningStatus
        /// </summary>
        public static readonly ProvisioningStatus LATEST_PERMISSION_SET_PROVISIONED = new ProvisioningStatus("LATEST_PERMISSION_SET_PROVISIONED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ProvisioningStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ProvisioningStatus FindValue(string value)
        {
            return FindValue<ProvisioningStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ProvisioningStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ProvisionTargetType.
    /// </summary>
    public class ProvisionTargetType : ConstantClass
    {

        /// <summary>
        /// Constant ALL_PROVISIONED_ACCOUNTS for ProvisionTargetType
        /// </summary>
        public static readonly ProvisionTargetType ALL_PROVISIONED_ACCOUNTS = new ProvisionTargetType("ALL_PROVISIONED_ACCOUNTS");
        /// <summary>
        /// Constant AWS_ACCOUNT for ProvisionTargetType
        /// </summary>
        public static readonly ProvisionTargetType AWS_ACCOUNT = new ProvisionTargetType("AWS_ACCOUNT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ProvisionTargetType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ProvisionTargetType FindValue(string value)
        {
            return FindValue<ProvisionTargetType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ProvisionTargetType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type StatusValues.
    /// </summary>
    public class StatusValues : ConstantClass
    {

        /// <summary>
        /// Constant FAILED for StatusValues
        /// </summary>
        public static readonly StatusValues FAILED = new StatusValues("FAILED");
        /// <summary>
        /// Constant IN_PROGRESS for StatusValues
        /// </summary>
        public static readonly StatusValues IN_PROGRESS = new StatusValues("IN_PROGRESS");
        /// <summary>
        /// Constant SUCCEEDED for StatusValues
        /// </summary>
        public static readonly StatusValues SUCCEEDED = new StatusValues("SUCCEEDED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public StatusValues(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static StatusValues FindValue(string value)
        {
            return FindValue<StatusValues>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator StatusValues(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TargetType.
    /// </summary>
    public class TargetType : ConstantClass
    {

        /// <summary>
        /// Constant AWS_ACCOUNT for TargetType
        /// </summary>
        public static readonly TargetType AWS_ACCOUNT = new TargetType("AWS_ACCOUNT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TargetType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TargetType FindValue(string value)
        {
            return FindValue<TargetType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TargetType(string value)
        {
            return FindValue(value);
        }
    }

}