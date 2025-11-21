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
    /// Constants used for properties of type AccessDeniedExceptionReason.
    /// </summary>
    public class AccessDeniedExceptionReason : ConstantClass
    {

        /// <summary>
        /// Constant KMS_AccessDeniedException for AccessDeniedExceptionReason
        /// </summary>
        public static readonly AccessDeniedExceptionReason KMS_AccessDeniedException = new AccessDeniedExceptionReason("KMS_AccessDeniedException");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AccessDeniedExceptionReason(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AccessDeniedExceptionReason FindValue(string value)
        {
            return FindValue<AccessDeniedExceptionReason>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AccessDeniedExceptionReason(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ApplicationStatus.
    /// </summary>
    public class ApplicationStatus : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for ApplicationStatus
        /// </summary>
        public static readonly ApplicationStatus DISABLED = new ApplicationStatus("DISABLED");
        /// <summary>
        /// Constant ENABLED for ApplicationStatus
        /// </summary>
        public static readonly ApplicationStatus ENABLED = new ApplicationStatus("ENABLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ApplicationStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ApplicationStatus FindValue(string value)
        {
            return FindValue<ApplicationStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ApplicationStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ApplicationVisibility.
    /// </summary>
    public class ApplicationVisibility : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for ApplicationVisibility
        /// </summary>
        public static readonly ApplicationVisibility DISABLED = new ApplicationVisibility("DISABLED");
        /// <summary>
        /// Constant ENABLED for ApplicationVisibility
        /// </summary>
        public static readonly ApplicationVisibility ENABLED = new ApplicationVisibility("ENABLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ApplicationVisibility(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ApplicationVisibility FindValue(string value)
        {
            return FindValue<ApplicationVisibility>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ApplicationVisibility(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AuthenticationMethodType.
    /// </summary>
    public class AuthenticationMethodType : ConstantClass
    {

        /// <summary>
        /// Constant IAM for AuthenticationMethodType
        /// </summary>
        public static readonly AuthenticationMethodType IAM = new AuthenticationMethodType("IAM");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AuthenticationMethodType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AuthenticationMethodType FindValue(string value)
        {
            return FindValue<AuthenticationMethodType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AuthenticationMethodType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type FederationProtocol.
    /// </summary>
    public class FederationProtocol : ConstantClass
    {

        /// <summary>
        /// Constant OAUTH for FederationProtocol
        /// </summary>
        public static readonly FederationProtocol OAUTH = new FederationProtocol("OAUTH");
        /// <summary>
        /// Constant SAML for FederationProtocol
        /// </summary>
        public static readonly FederationProtocol SAML = new FederationProtocol("SAML");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FederationProtocol(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FederationProtocol FindValue(string value)
        {
            return FindValue<FederationProtocol>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FederationProtocol(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type GrantType.
    /// </summary>
    public class GrantType : ConstantClass
    {

        /// <summary>
        /// Constant Authorization_code for GrantType
        /// </summary>
        public static readonly GrantType Authorization_code = new GrantType("authorization_code");
        /// <summary>
        /// Constant Refresh_token for GrantType
        /// </summary>
        public static readonly GrantType Refresh_token = new GrantType("refresh_token");
        /// <summary>
        /// Constant UrnIetfParamsOauthGrantTypeJwtBearer for GrantType
        /// </summary>
        public static readonly GrantType UrnIetfParamsOauthGrantTypeJwtBearer = new GrantType("urn:ietf:params:oauth:grant-type:jwt-bearer");
        /// <summary>
        /// Constant UrnIetfParamsOauthGrantTypeTokenExchange for GrantType
        /// </summary>
        public static readonly GrantType UrnIetfParamsOauthGrantTypeTokenExchange = new GrantType("urn:ietf:params:oauth:grant-type:token-exchange");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public GrantType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static GrantType FindValue(string value)
        {
            return FindValue<GrantType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator GrantType(string value)
        {
            return FindValue(value);
        }
    }


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
    /// Constants used for properties of type InstanceStatus.
    /// </summary>
    public class InstanceStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for InstanceStatus
        /// </summary>
        public static readonly InstanceStatus ACTIVE = new InstanceStatus("ACTIVE");
        /// <summary>
        /// Constant CREATE_FAILED for InstanceStatus
        /// </summary>
        public static readonly InstanceStatus CREATE_FAILED = new InstanceStatus("CREATE_FAILED");
        /// <summary>
        /// Constant CREATE_IN_PROGRESS for InstanceStatus
        /// </summary>
        public static readonly InstanceStatus CREATE_IN_PROGRESS = new InstanceStatus("CREATE_IN_PROGRESS");
        /// <summary>
        /// Constant DELETE_IN_PROGRESS for InstanceStatus
        /// </summary>
        public static readonly InstanceStatus DELETE_IN_PROGRESS = new InstanceStatus("DELETE_IN_PROGRESS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public InstanceStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static InstanceStatus FindValue(string value)
        {
            return FindValue<InstanceStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator InstanceStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type JwksRetrievalOption.
    /// </summary>
    public class JwksRetrievalOption : ConstantClass
    {

        /// <summary>
        /// Constant OPEN_ID_DISCOVERY for JwksRetrievalOption
        /// </summary>
        public static readonly JwksRetrievalOption OPEN_ID_DISCOVERY = new JwksRetrievalOption("OPEN_ID_DISCOVERY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public JwksRetrievalOption(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static JwksRetrievalOption FindValue(string value)
        {
            return FindValue<JwksRetrievalOption>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator JwksRetrievalOption(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type KmsKeyStatus.
    /// </summary>
    public class KmsKeyStatus : ConstantClass
    {

        /// <summary>
        /// Constant ENABLED for KmsKeyStatus
        /// </summary>
        public static readonly KmsKeyStatus ENABLED = new KmsKeyStatus("ENABLED");
        /// <summary>
        /// Constant UPDATE_FAILED for KmsKeyStatus
        /// </summary>
        public static readonly KmsKeyStatus UPDATE_FAILED = new KmsKeyStatus("UPDATE_FAILED");
        /// <summary>
        /// Constant UPDATING for KmsKeyStatus
        /// </summary>
        public static readonly KmsKeyStatus UPDATING = new KmsKeyStatus("UPDATING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public KmsKeyStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static KmsKeyStatus FindValue(string value)
        {
            return FindValue<KmsKeyStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator KmsKeyStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type KmsKeyType.
    /// </summary>
    public class KmsKeyType : ConstantClass
    {

        /// <summary>
        /// Constant AWS_OWNED_KMS_KEY for KmsKeyType
        /// </summary>
        public static readonly KmsKeyType AWS_OWNED_KMS_KEY = new KmsKeyType("AWS_OWNED_KMS_KEY");
        /// <summary>
        /// Constant CUSTOMER_MANAGED_KEY for KmsKeyType
        /// </summary>
        public static readonly KmsKeyType CUSTOMER_MANAGED_KEY = new KmsKeyType("CUSTOMER_MANAGED_KEY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public KmsKeyType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static KmsKeyType FindValue(string value)
        {
            return FindValue<KmsKeyType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator KmsKeyType(string value)
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
    /// Constants used for properties of type ResourceNotFoundExceptionReason.
    /// </summary>
    public class ResourceNotFoundExceptionReason : ConstantClass
    {

        /// <summary>
        /// Constant KMS_NotFoundException for ResourceNotFoundExceptionReason
        /// </summary>
        public static readonly ResourceNotFoundExceptionReason KMS_NotFoundException = new ResourceNotFoundExceptionReason("KMS_NotFoundException");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ResourceNotFoundExceptionReason(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ResourceNotFoundExceptionReason FindValue(string value)
        {
            return FindValue<ResourceNotFoundExceptionReason>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ResourceNotFoundExceptionReason(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SignInOrigin.
    /// </summary>
    public class SignInOrigin : ConstantClass
    {

        /// <summary>
        /// Constant APPLICATION for SignInOrigin
        /// </summary>
        public static readonly SignInOrigin APPLICATION = new SignInOrigin("APPLICATION");
        /// <summary>
        /// Constant IDENTITY_CENTER for SignInOrigin
        /// </summary>
        public static readonly SignInOrigin IDENTITY_CENTER = new SignInOrigin("IDENTITY_CENTER");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SignInOrigin(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SignInOrigin FindValue(string value)
        {
            return FindValue<SignInOrigin>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SignInOrigin(string value)
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


    /// <summary>
    /// Constants used for properties of type ThrottlingExceptionReason.
    /// </summary>
    public class ThrottlingExceptionReason : ConstantClass
    {

        /// <summary>
        /// Constant KMS_ThrottlingException for ThrottlingExceptionReason
        /// </summary>
        public static readonly ThrottlingExceptionReason KMS_ThrottlingException = new ThrottlingExceptionReason("KMS_ThrottlingException");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ThrottlingExceptionReason(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ThrottlingExceptionReason FindValue(string value)
        {
            return FindValue<ThrottlingExceptionReason>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ThrottlingExceptionReason(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TrustedTokenIssuerType.
    /// </summary>
    public class TrustedTokenIssuerType : ConstantClass
    {

        /// <summary>
        /// Constant OIDC_JWT for TrustedTokenIssuerType
        /// </summary>
        public static readonly TrustedTokenIssuerType OIDC_JWT = new TrustedTokenIssuerType("OIDC_JWT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TrustedTokenIssuerType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TrustedTokenIssuerType FindValue(string value)
        {
            return FindValue<TrustedTokenIssuerType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TrustedTokenIssuerType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type UserBackgroundSessionApplicationStatus.
    /// </summary>
    public class UserBackgroundSessionApplicationStatus : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for UserBackgroundSessionApplicationStatus
        /// </summary>
        public static readonly UserBackgroundSessionApplicationStatus DISABLED = new UserBackgroundSessionApplicationStatus("DISABLED");
        /// <summary>
        /// Constant ENABLED for UserBackgroundSessionApplicationStatus
        /// </summary>
        public static readonly UserBackgroundSessionApplicationStatus ENABLED = new UserBackgroundSessionApplicationStatus("ENABLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public UserBackgroundSessionApplicationStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static UserBackgroundSessionApplicationStatus FindValue(string value)
        {
            return FindValue<UserBackgroundSessionApplicationStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator UserBackgroundSessionApplicationStatus(string value)
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
        /// Constant KMS_DisabledException for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason KMS_DisabledException = new ValidationExceptionReason("KMS_DisabledException");
        /// <summary>
        /// Constant KMS_InvalidKeyUsageException for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason KMS_InvalidKeyUsageException = new ValidationExceptionReason("KMS_InvalidKeyUsageException");
        /// <summary>
        /// Constant KMS_InvalidStateException for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason KMS_InvalidStateException = new ValidationExceptionReason("KMS_InvalidStateException");

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