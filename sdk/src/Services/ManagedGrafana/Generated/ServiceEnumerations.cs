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
 * Do not modify this file. This file is generated from the grafana-2020-08-18.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.ManagedGrafana
{

    /// <summary>
    /// Constants used for properties of type AccountAccessType.
    /// </summary>
    public class AccountAccessType : ConstantClass
    {

        /// <summary>
        /// Constant CURRENT_ACCOUNT for AccountAccessType
        /// </summary>
        public static readonly AccountAccessType CURRENT_ACCOUNT = new AccountAccessType("CURRENT_ACCOUNT");
        /// <summary>
        /// Constant ORGANIZATION for AccountAccessType
        /// </summary>
        public static readonly AccountAccessType ORGANIZATION = new AccountAccessType("ORGANIZATION");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AccountAccessType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AccountAccessType FindValue(string value)
        {
            return FindValue<AccountAccessType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AccountAccessType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AuthenticationProviderTypes.
    /// </summary>
    public class AuthenticationProviderTypes : ConstantClass
    {

        /// <summary>
        /// Constant AWS_SSO for AuthenticationProviderTypes
        /// </summary>
        public static readonly AuthenticationProviderTypes AWS_SSO = new AuthenticationProviderTypes("AWS_SSO");
        /// <summary>
        /// Constant SAML for AuthenticationProviderTypes
        /// </summary>
        public static readonly AuthenticationProviderTypes SAML = new AuthenticationProviderTypes("SAML");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AuthenticationProviderTypes(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AuthenticationProviderTypes FindValue(string value)
        {
            return FindValue<AuthenticationProviderTypes>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AuthenticationProviderTypes(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DataSourceType.
    /// </summary>
    public class DataSourceType : ConstantClass
    {

        /// <summary>
        /// Constant AMAZON_OPENSEARCH_SERVICE for DataSourceType
        /// </summary>
        public static readonly DataSourceType AMAZON_OPENSEARCH_SERVICE = new DataSourceType("AMAZON_OPENSEARCH_SERVICE");
        /// <summary>
        /// Constant ATHENA for DataSourceType
        /// </summary>
        public static readonly DataSourceType ATHENA = new DataSourceType("ATHENA");
        /// <summary>
        /// Constant CLOUDWATCH for DataSourceType
        /// </summary>
        public static readonly DataSourceType CLOUDWATCH = new DataSourceType("CLOUDWATCH");
        /// <summary>
        /// Constant PROMETHEUS for DataSourceType
        /// </summary>
        public static readonly DataSourceType PROMETHEUS = new DataSourceType("PROMETHEUS");
        /// <summary>
        /// Constant REDSHIFT for DataSourceType
        /// </summary>
        public static readonly DataSourceType REDSHIFT = new DataSourceType("REDSHIFT");
        /// <summary>
        /// Constant SITEWISE for DataSourceType
        /// </summary>
        public static readonly DataSourceType SITEWISE = new DataSourceType("SITEWISE");
        /// <summary>
        /// Constant TIMESTREAM for DataSourceType
        /// </summary>
        public static readonly DataSourceType TIMESTREAM = new DataSourceType("TIMESTREAM");
        /// <summary>
        /// Constant TWINMAKER for DataSourceType
        /// </summary>
        public static readonly DataSourceType TWINMAKER = new DataSourceType("TWINMAKER");
        /// <summary>
        /// Constant XRAY for DataSourceType
        /// </summary>
        public static readonly DataSourceType XRAY = new DataSourceType("XRAY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DataSourceType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DataSourceType FindValue(string value)
        {
            return FindValue<DataSourceType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DataSourceType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type LicenseType.
    /// </summary>
    public class LicenseType : ConstantClass
    {

        /// <summary>
        /// Constant ENTERPRISE for LicenseType
        /// </summary>
        public static readonly LicenseType ENTERPRISE = new LicenseType("ENTERPRISE");
        /// <summary>
        /// Constant ENTERPRISE_FREE_TRIAL for LicenseType
        /// </summary>
        public static readonly LicenseType ENTERPRISE_FREE_TRIAL = new LicenseType("ENTERPRISE_FREE_TRIAL");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public LicenseType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LicenseType FindValue(string value)
        {
            return FindValue<LicenseType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator LicenseType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type NotificationDestinationType.
    /// </summary>
    public class NotificationDestinationType : ConstantClass
    {

        /// <summary>
        /// Constant SNS for NotificationDestinationType
        /// </summary>
        public static readonly NotificationDestinationType SNS = new NotificationDestinationType("SNS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public NotificationDestinationType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static NotificationDestinationType FindValue(string value)
        {
            return FindValue<NotificationDestinationType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator NotificationDestinationType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PermissionType.
    /// </summary>
    public class PermissionType : ConstantClass
    {

        /// <summary>
        /// Constant CUSTOMER_MANAGED for PermissionType
        /// </summary>
        public static readonly PermissionType CUSTOMER_MANAGED = new PermissionType("CUSTOMER_MANAGED");
        /// <summary>
        /// Constant SERVICE_MANAGED for PermissionType
        /// </summary>
        public static readonly PermissionType SERVICE_MANAGED = new PermissionType("SERVICE_MANAGED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PermissionType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PermissionType FindValue(string value)
        {
            return FindValue<PermissionType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PermissionType(string value)
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
        /// Constant ADMIN for Role
        /// </summary>
        public static readonly Role ADMIN = new Role("ADMIN");
        /// <summary>
        /// Constant EDITOR for Role
        /// </summary>
        public static readonly Role EDITOR = new Role("EDITOR");
        /// <summary>
        /// Constant VIEWER for Role
        /// </summary>
        public static readonly Role VIEWER = new Role("VIEWER");

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
    /// Constants used for properties of type SamlConfigurationStatus.
    /// </summary>
    public class SamlConfigurationStatus : ConstantClass
    {

        /// <summary>
        /// Constant CONFIGURED for SamlConfigurationStatus
        /// </summary>
        public static readonly SamlConfigurationStatus CONFIGURED = new SamlConfigurationStatus("CONFIGURED");
        /// <summary>
        /// Constant NOT_CONFIGURED for SamlConfigurationStatus
        /// </summary>
        public static readonly SamlConfigurationStatus NOT_CONFIGURED = new SamlConfigurationStatus("NOT_CONFIGURED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SamlConfigurationStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SamlConfigurationStatus FindValue(string value)
        {
            return FindValue<SamlConfigurationStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SamlConfigurationStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type UpdateAction.
    /// </summary>
    public class UpdateAction : ConstantClass
    {

        /// <summary>
        /// Constant ADD for UpdateAction
        /// </summary>
        public static readonly UpdateAction ADD = new UpdateAction("ADD");
        /// <summary>
        /// Constant REVOKE for UpdateAction
        /// </summary>
        public static readonly UpdateAction REVOKE = new UpdateAction("REVOKE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public UpdateAction(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static UpdateAction FindValue(string value)
        {
            return FindValue<UpdateAction>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator UpdateAction(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type UserType.
    /// </summary>
    public class UserType : ConstantClass
    {

        /// <summary>
        /// Constant SSO_GROUP for UserType
        /// </summary>
        public static readonly UserType SSO_GROUP = new UserType("SSO_GROUP");
        /// <summary>
        /// Constant SSO_USER for UserType
        /// </summary>
        public static readonly UserType SSO_USER = new UserType("SSO_USER");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public UserType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static UserType FindValue(string value)
        {
            return FindValue<UserType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator UserType(string value)
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
        /// Constant CANNOT_PARSE for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason CANNOT_PARSE = new ValidationExceptionReason("CANNOT_PARSE");
        /// <summary>
        /// Constant FIELD_VALIDATION_FAILED for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason FIELD_VALIDATION_FAILED = new ValidationExceptionReason("FIELD_VALIDATION_FAILED");
        /// <summary>
        /// Constant OTHER for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason OTHER = new ValidationExceptionReason("OTHER");
        /// <summary>
        /// Constant UNKNOWN_OPERATION for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason UNKNOWN_OPERATION = new ValidationExceptionReason("UNKNOWN_OPERATION");

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
    /// Constants used for properties of type WorkspaceStatus.
    /// </summary>
    public class WorkspaceStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for WorkspaceStatus
        /// </summary>
        public static readonly WorkspaceStatus ACTIVE = new WorkspaceStatus("ACTIVE");
        /// <summary>
        /// Constant CREATING for WorkspaceStatus
        /// </summary>
        public static readonly WorkspaceStatus CREATING = new WorkspaceStatus("CREATING");
        /// <summary>
        /// Constant CREATION_FAILED for WorkspaceStatus
        /// </summary>
        public static readonly WorkspaceStatus CREATION_FAILED = new WorkspaceStatus("CREATION_FAILED");
        /// <summary>
        /// Constant DELETING for WorkspaceStatus
        /// </summary>
        public static readonly WorkspaceStatus DELETING = new WorkspaceStatus("DELETING");
        /// <summary>
        /// Constant DELETION_FAILED for WorkspaceStatus
        /// </summary>
        public static readonly WorkspaceStatus DELETION_FAILED = new WorkspaceStatus("DELETION_FAILED");
        /// <summary>
        /// Constant FAILED for WorkspaceStatus
        /// </summary>
        public static readonly WorkspaceStatus FAILED = new WorkspaceStatus("FAILED");
        /// <summary>
        /// Constant LICENSE_REMOVAL_FAILED for WorkspaceStatus
        /// </summary>
        public static readonly WorkspaceStatus LICENSE_REMOVAL_FAILED = new WorkspaceStatus("LICENSE_REMOVAL_FAILED");
        /// <summary>
        /// Constant UPDATE_FAILED for WorkspaceStatus
        /// </summary>
        public static readonly WorkspaceStatus UPDATE_FAILED = new WorkspaceStatus("UPDATE_FAILED");
        /// <summary>
        /// Constant UPDATING for WorkspaceStatus
        /// </summary>
        public static readonly WorkspaceStatus UPDATING = new WorkspaceStatus("UPDATING");
        /// <summary>
        /// Constant UPGRADE_FAILED for WorkspaceStatus
        /// </summary>
        public static readonly WorkspaceStatus UPGRADE_FAILED = new WorkspaceStatus("UPGRADE_FAILED");
        /// <summary>
        /// Constant UPGRADING for WorkspaceStatus
        /// </summary>
        public static readonly WorkspaceStatus UPGRADING = new WorkspaceStatus("UPGRADING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public WorkspaceStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static WorkspaceStatus FindValue(string value)
        {
            return FindValue<WorkspaceStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator WorkspaceStatus(string value)
        {
            return FindValue(value);
        }
    }

}