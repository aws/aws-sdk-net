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
 * Do not modify this file. This file is generated from the repostspace-2022-05-13.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.Repostspace
{

    /// <summary>
    /// Constants used for properties of type ChannelRole.
    /// </summary>
    public class ChannelRole : ConstantClass
    {

        /// <summary>
        /// Constant ASKER for ChannelRole
        /// </summary>
        public static readonly ChannelRole ASKER = new ChannelRole("ASKER");
        /// <summary>
        /// Constant EXPERT for ChannelRole
        /// </summary>
        public static readonly ChannelRole EXPERT = new ChannelRole("EXPERT");
        /// <summary>
        /// Constant MODERATOR for ChannelRole
        /// </summary>
        public static readonly ChannelRole MODERATOR = new ChannelRole("MODERATOR");
        /// <summary>
        /// Constant SUPPORTREQUESTOR for ChannelRole
        /// </summary>
        public static readonly ChannelRole SUPPORTREQUESTOR = new ChannelRole("SUPPORTREQUESTOR");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ChannelRole(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ChannelRole FindValue(string value)
        {
            return FindValue<ChannelRole>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ChannelRole(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ChannelStatus.
    /// </summary>
    public class ChannelStatus : ConstantClass
    {

        /// <summary>
        /// Constant CREATE_FAILED for ChannelStatus
        /// </summary>
        public static readonly ChannelStatus CREATE_FAILED = new ChannelStatus("CREATE_FAILED");
        /// <summary>
        /// Constant CREATED for ChannelStatus
        /// </summary>
        public static readonly ChannelStatus CREATED = new ChannelStatus("CREATED");
        /// <summary>
        /// Constant CREATING for ChannelStatus
        /// </summary>
        public static readonly ChannelStatus CREATING = new ChannelStatus("CREATING");
        /// <summary>
        /// Constant DELETE_FAILED for ChannelStatus
        /// </summary>
        public static readonly ChannelStatus DELETE_FAILED = new ChannelStatus("DELETE_FAILED");
        /// <summary>
        /// Constant DELETED for ChannelStatus
        /// </summary>
        public static readonly ChannelStatus DELETED = new ChannelStatus("DELETED");
        /// <summary>
        /// Constant DELETING for ChannelStatus
        /// </summary>
        public static readonly ChannelStatus DELETING = new ChannelStatus("DELETING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ChannelStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ChannelStatus FindValue(string value)
        {
            return FindValue<ChannelStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ChannelStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ConfigurationStatus.
    /// </summary>
    public class ConfigurationStatus : ConstantClass
    {

        /// <summary>
        /// Constant CONFIGURED for ConfigurationStatus
        /// </summary>
        public static readonly ConfigurationStatus CONFIGURED = new ConfigurationStatus("CONFIGURED");
        /// <summary>
        /// Constant UNCONFIGURED for ConfigurationStatus
        /// </summary>
        public static readonly ConfigurationStatus UNCONFIGURED = new ConfigurationStatus("UNCONFIGURED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ConfigurationStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ConfigurationStatus FindValue(string value)
        {
            return FindValue<ConfigurationStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ConfigurationStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type FeatureEnableParameter.
    /// </summary>
    public class FeatureEnableParameter : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for FeatureEnableParameter
        /// </summary>
        public static readonly FeatureEnableParameter DISABLED = new FeatureEnableParameter("DISABLED");
        /// <summary>
        /// Constant ENABLED for FeatureEnableParameter
        /// </summary>
        public static readonly FeatureEnableParameter ENABLED = new FeatureEnableParameter("ENABLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FeatureEnableParameter(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FeatureEnableParameter FindValue(string value)
        {
            return FindValue<FeatureEnableParameter>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FeatureEnableParameter(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type FeatureEnableStatus.
    /// </summary>
    public class FeatureEnableStatus : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for FeatureEnableStatus
        /// </summary>
        public static readonly FeatureEnableStatus DISABLED = new FeatureEnableStatus("DISABLED");
        /// <summary>
        /// Constant ENABLED for FeatureEnableStatus
        /// </summary>
        public static readonly FeatureEnableStatus ENABLED = new FeatureEnableStatus("ENABLED");
        /// <summary>
        /// Constant NOT_ALLOWED for FeatureEnableStatus
        /// </summary>
        public static readonly FeatureEnableStatus NOT_ALLOWED = new FeatureEnableStatus("NOT_ALLOWED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FeatureEnableStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FeatureEnableStatus FindValue(string value)
        {
            return FindValue<FeatureEnableStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FeatureEnableStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Role.
    /// </summary>
    public class Role : ConstantClass
    {

        /// <summary>
        /// Constant ADMINISTRATOR for Role
        /// </summary>
        public static readonly Role ADMINISTRATOR = new Role("ADMINISTRATOR");
        /// <summary>
        /// Constant EXPERT for Role
        /// </summary>
        public static readonly Role EXPERT = new Role("EXPERT");
        /// <summary>
        /// Constant MODERATOR for Role
        /// </summary>
        public static readonly Role MODERATOR = new Role("MODERATOR");
        /// <summary>
        /// Constant SUPPORTREQUESTOR for Role
        /// </summary>
        public static readonly Role SUPPORTREQUESTOR = new Role("SUPPORTREQUESTOR");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Role(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Role FindValue(string value)
        {
            return FindValue<Role>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Role(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TierLevel.
    /// </summary>
    public class TierLevel : ConstantClass
    {

        /// <summary>
        /// Constant BASIC for TierLevel
        /// </summary>
        public static readonly TierLevel BASIC = new TierLevel("BASIC");
        /// <summary>
        /// Constant STANDARD for TierLevel
        /// </summary>
        public static readonly TierLevel STANDARD = new TierLevel("STANDARD");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TierLevel(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TierLevel FindValue(string value)
        {
            return FindValue<TierLevel>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TierLevel(string value)
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
        /// Constant CannotParse for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason CannotParse = new ValidationExceptionReason("cannotParse");
        /// <summary>
        /// Constant FieldValidationFailed for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason FieldValidationFailed = new ValidationExceptionReason("fieldValidationFailed");
        /// <summary>
        /// Constant Other for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason Other = new ValidationExceptionReason("other");
        /// <summary>
        /// Constant UnknownOperation for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason UnknownOperation = new ValidationExceptionReason("unknownOperation");

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


    /// <summary>
    /// Constants used for properties of type VanityDomainStatus.
    /// </summary>
    public class VanityDomainStatus : ConstantClass
    {

        /// <summary>
        /// Constant APPROVED for VanityDomainStatus
        /// </summary>
        public static readonly VanityDomainStatus APPROVED = new VanityDomainStatus("APPROVED");
        /// <summary>
        /// Constant PENDING for VanityDomainStatus
        /// </summary>
        public static readonly VanityDomainStatus PENDING = new VanityDomainStatus("PENDING");
        /// <summary>
        /// Constant UNAPPROVED for VanityDomainStatus
        /// </summary>
        public static readonly VanityDomainStatus UNAPPROVED = new VanityDomainStatus("UNAPPROVED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public VanityDomainStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static VanityDomainStatus FindValue(string value)
        {
            return FindValue<VanityDomainStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator VanityDomainStatus(string value)
        {
            return FindValue(value);
        }
    }

}