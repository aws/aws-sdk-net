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
 * Do not modify this file. This file is generated from the appstream-2016-12-01.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.AppStream
{

    /// <summary>
    /// Constants used for properties of type AccessEndpointType.
    /// </summary>
    public class AccessEndpointType : ConstantClass
    {

        /// <summary>
        /// Constant STREAMING for AccessEndpointType
        /// </summary>
        public static readonly AccessEndpointType STREAMING = new AccessEndpointType("STREAMING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AccessEndpointType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AccessEndpointType FindValue(string value)
        {
            return FindValue<AccessEndpointType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AccessEndpointType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Action.
    /// </summary>
    public class Action : ConstantClass
    {

        /// <summary>
        /// Constant AUTO_TIME_ZONE_REDIRECTION for Action
        /// </summary>
        public static readonly Action AUTO_TIME_ZONE_REDIRECTION = new Action("AUTO_TIME_ZONE_REDIRECTION");
        /// <summary>
        /// Constant CLIPBOARD_COPY_FROM_LOCAL_DEVICE for Action
        /// </summary>
        public static readonly Action CLIPBOARD_COPY_FROM_LOCAL_DEVICE = new Action("CLIPBOARD_COPY_FROM_LOCAL_DEVICE");
        /// <summary>
        /// Constant CLIPBOARD_COPY_TO_LOCAL_DEVICE for Action
        /// </summary>
        public static readonly Action CLIPBOARD_COPY_TO_LOCAL_DEVICE = new Action("CLIPBOARD_COPY_TO_LOCAL_DEVICE");
        /// <summary>
        /// Constant DOMAIN_PASSWORD_SIGNIN for Action
        /// </summary>
        public static readonly Action DOMAIN_PASSWORD_SIGNIN = new Action("DOMAIN_PASSWORD_SIGNIN");
        /// <summary>
        /// Constant DOMAIN_SMART_CARD_SIGNIN for Action
        /// </summary>
        public static readonly Action DOMAIN_SMART_CARD_SIGNIN = new Action("DOMAIN_SMART_CARD_SIGNIN");
        /// <summary>
        /// Constant FILE_DOWNLOAD for Action
        /// </summary>
        public static readonly Action FILE_DOWNLOAD = new Action("FILE_DOWNLOAD");
        /// <summary>
        /// Constant FILE_UPLOAD for Action
        /// </summary>
        public static readonly Action FILE_UPLOAD = new Action("FILE_UPLOAD");
        /// <summary>
        /// Constant PRINTING_TO_LOCAL_DEVICE for Action
        /// </summary>
        public static readonly Action PRINTING_TO_LOCAL_DEVICE = new Action("PRINTING_TO_LOCAL_DEVICE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Action(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Action FindValue(string value)
        {
            return FindValue<Action>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Action(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AppBlockBuilderAttribute.
    /// </summary>
    public class AppBlockBuilderAttribute : ConstantClass
    {

        /// <summary>
        /// Constant ACCESS_ENDPOINTS for AppBlockBuilderAttribute
        /// </summary>
        public static readonly AppBlockBuilderAttribute ACCESS_ENDPOINTS = new AppBlockBuilderAttribute("ACCESS_ENDPOINTS");
        /// <summary>
        /// Constant IAM_ROLE_ARN for AppBlockBuilderAttribute
        /// </summary>
        public static readonly AppBlockBuilderAttribute IAM_ROLE_ARN = new AppBlockBuilderAttribute("IAM_ROLE_ARN");
        /// <summary>
        /// Constant VPC_CONFIGURATION_SECURITY_GROUP_IDS for AppBlockBuilderAttribute
        /// </summary>
        public static readonly AppBlockBuilderAttribute VPC_CONFIGURATION_SECURITY_GROUP_IDS = new AppBlockBuilderAttribute("VPC_CONFIGURATION_SECURITY_GROUP_IDS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AppBlockBuilderAttribute(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AppBlockBuilderAttribute FindValue(string value)
        {
            return FindValue<AppBlockBuilderAttribute>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AppBlockBuilderAttribute(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AppBlockBuilderPlatformType.
    /// </summary>
    public class AppBlockBuilderPlatformType : ConstantClass
    {

        /// <summary>
        /// Constant WINDOWS_SERVER_2019 for AppBlockBuilderPlatformType
        /// </summary>
        public static readonly AppBlockBuilderPlatformType WINDOWS_SERVER_2019 = new AppBlockBuilderPlatformType("WINDOWS_SERVER_2019");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AppBlockBuilderPlatformType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AppBlockBuilderPlatformType FindValue(string value)
        {
            return FindValue<AppBlockBuilderPlatformType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AppBlockBuilderPlatformType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AppBlockBuilderState.
    /// </summary>
    public class AppBlockBuilderState : ConstantClass
    {

        /// <summary>
        /// Constant RUNNING for AppBlockBuilderState
        /// </summary>
        public static readonly AppBlockBuilderState RUNNING = new AppBlockBuilderState("RUNNING");
        /// <summary>
        /// Constant STARTING for AppBlockBuilderState
        /// </summary>
        public static readonly AppBlockBuilderState STARTING = new AppBlockBuilderState("STARTING");
        /// <summary>
        /// Constant STOPPED for AppBlockBuilderState
        /// </summary>
        public static readonly AppBlockBuilderState STOPPED = new AppBlockBuilderState("STOPPED");
        /// <summary>
        /// Constant STOPPING for AppBlockBuilderState
        /// </summary>
        public static readonly AppBlockBuilderState STOPPING = new AppBlockBuilderState("STOPPING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AppBlockBuilderState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AppBlockBuilderState FindValue(string value)
        {
            return FindValue<AppBlockBuilderState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AppBlockBuilderState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AppBlockBuilderStateChangeReasonCode.
    /// </summary>
    public class AppBlockBuilderStateChangeReasonCode : ConstantClass
    {

        /// <summary>
        /// Constant INTERNAL_ERROR for AppBlockBuilderStateChangeReasonCode
        /// </summary>
        public static readonly AppBlockBuilderStateChangeReasonCode INTERNAL_ERROR = new AppBlockBuilderStateChangeReasonCode("INTERNAL_ERROR");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AppBlockBuilderStateChangeReasonCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AppBlockBuilderStateChangeReasonCode FindValue(string value)
        {
            return FindValue<AppBlockBuilderStateChangeReasonCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AppBlockBuilderStateChangeReasonCode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AppBlockState.
    /// </summary>
    public class AppBlockState : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for AppBlockState
        /// </summary>
        public static readonly AppBlockState ACTIVE = new AppBlockState("ACTIVE");
        /// <summary>
        /// Constant INACTIVE for AppBlockState
        /// </summary>
        public static readonly AppBlockState INACTIVE = new AppBlockState("INACTIVE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AppBlockState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AppBlockState FindValue(string value)
        {
            return FindValue<AppBlockState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AppBlockState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ApplicationAttribute.
    /// </summary>
    public class ApplicationAttribute : ConstantClass
    {

        /// <summary>
        /// Constant LAUNCH_PARAMETERS for ApplicationAttribute
        /// </summary>
        public static readonly ApplicationAttribute LAUNCH_PARAMETERS = new ApplicationAttribute("LAUNCH_PARAMETERS");
        /// <summary>
        /// Constant WORKING_DIRECTORY for ApplicationAttribute
        /// </summary>
        public static readonly ApplicationAttribute WORKING_DIRECTORY = new ApplicationAttribute("WORKING_DIRECTORY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ApplicationAttribute(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ApplicationAttribute FindValue(string value)
        {
            return FindValue<ApplicationAttribute>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ApplicationAttribute(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AppVisibility.
    /// </summary>
    public class AppVisibility : ConstantClass
    {

        /// <summary>
        /// Constant ALL for AppVisibility
        /// </summary>
        public static readonly AppVisibility ALL = new AppVisibility("ALL");
        /// <summary>
        /// Constant ASSOCIATED for AppVisibility
        /// </summary>
        public static readonly AppVisibility ASSOCIATED = new AppVisibility("ASSOCIATED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AppVisibility(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AppVisibility FindValue(string value)
        {
            return FindValue<AppVisibility>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AppVisibility(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AuthenticationType.
    /// </summary>
    public class AuthenticationType : ConstantClass
    {

        /// <summary>
        /// Constant API for AuthenticationType
        /// </summary>
        public static readonly AuthenticationType API = new AuthenticationType("API");
        /// <summary>
        /// Constant AWS_AD for AuthenticationType
        /// </summary>
        public static readonly AuthenticationType AWS_AD = new AuthenticationType("AWS_AD");
        /// <summary>
        /// Constant SAML for AuthenticationType
        /// </summary>
        public static readonly AuthenticationType SAML = new AuthenticationType("SAML");
        /// <summary>
        /// Constant USERPOOL for AuthenticationType
        /// </summary>
        public static readonly AuthenticationType USERPOOL = new AuthenticationType("USERPOOL");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AuthenticationType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AuthenticationType FindValue(string value)
        {
            return FindValue<AuthenticationType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AuthenticationType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CertificateBasedAuthStatus.
    /// </summary>
    public class CertificateBasedAuthStatus : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for CertificateBasedAuthStatus
        /// </summary>
        public static readonly CertificateBasedAuthStatus DISABLED = new CertificateBasedAuthStatus("DISABLED");
        /// <summary>
        /// Constant ENABLED for CertificateBasedAuthStatus
        /// </summary>
        public static readonly CertificateBasedAuthStatus ENABLED = new CertificateBasedAuthStatus("ENABLED");
        /// <summary>
        /// Constant ENABLED_NO_DIRECTORY_LOGIN_FALLBACK for CertificateBasedAuthStatus
        /// </summary>
        public static readonly CertificateBasedAuthStatus ENABLED_NO_DIRECTORY_LOGIN_FALLBACK = new CertificateBasedAuthStatus("ENABLED_NO_DIRECTORY_LOGIN_FALLBACK");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CertificateBasedAuthStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CertificateBasedAuthStatus FindValue(string value)
        {
            return FindValue<CertificateBasedAuthStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CertificateBasedAuthStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DynamicAppProvidersEnabled.
    /// </summary>
    public class DynamicAppProvidersEnabled : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for DynamicAppProvidersEnabled
        /// </summary>
        public static readonly DynamicAppProvidersEnabled DISABLED = new DynamicAppProvidersEnabled("DISABLED");
        /// <summary>
        /// Constant ENABLED for DynamicAppProvidersEnabled
        /// </summary>
        public static readonly DynamicAppProvidersEnabled ENABLED = new DynamicAppProvidersEnabled("ENABLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DynamicAppProvidersEnabled(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DynamicAppProvidersEnabled FindValue(string value)
        {
            return FindValue<DynamicAppProvidersEnabled>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DynamicAppProvidersEnabled(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type FleetAttribute.
    /// </summary>
    public class FleetAttribute : ConstantClass
    {

        /// <summary>
        /// Constant DOMAIN_JOIN_INFO for FleetAttribute
        /// </summary>
        public static readonly FleetAttribute DOMAIN_JOIN_INFO = new FleetAttribute("DOMAIN_JOIN_INFO");
        /// <summary>
        /// Constant IAM_ROLE_ARN for FleetAttribute
        /// </summary>
        public static readonly FleetAttribute IAM_ROLE_ARN = new FleetAttribute("IAM_ROLE_ARN");
        /// <summary>
        /// Constant MAX_SESSIONS_PER_INSTANCE for FleetAttribute
        /// </summary>
        public static readonly FleetAttribute MAX_SESSIONS_PER_INSTANCE = new FleetAttribute("MAX_SESSIONS_PER_INSTANCE");
        /// <summary>
        /// Constant SESSION_SCRIPT_S3_LOCATION for FleetAttribute
        /// </summary>
        public static readonly FleetAttribute SESSION_SCRIPT_S3_LOCATION = new FleetAttribute("SESSION_SCRIPT_S3_LOCATION");
        /// <summary>
        /// Constant USB_DEVICE_FILTER_STRINGS for FleetAttribute
        /// </summary>
        public static readonly FleetAttribute USB_DEVICE_FILTER_STRINGS = new FleetAttribute("USB_DEVICE_FILTER_STRINGS");
        /// <summary>
        /// Constant VPC_CONFIGURATION for FleetAttribute
        /// </summary>
        public static readonly FleetAttribute VPC_CONFIGURATION = new FleetAttribute("VPC_CONFIGURATION");
        /// <summary>
        /// Constant VPC_CONFIGURATION_SECURITY_GROUP_IDS for FleetAttribute
        /// </summary>
        public static readonly FleetAttribute VPC_CONFIGURATION_SECURITY_GROUP_IDS = new FleetAttribute("VPC_CONFIGURATION_SECURITY_GROUP_IDS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FleetAttribute(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FleetAttribute FindValue(string value)
        {
            return FindValue<FleetAttribute>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FleetAttribute(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type FleetErrorCode.
    /// </summary>
    public class FleetErrorCode : ConstantClass
    {

        /// <summary>
        /// Constant DOMAIN_JOIN_ERROR_ACCESS_DENIED for FleetErrorCode
        /// </summary>
        public static readonly FleetErrorCode DOMAIN_JOIN_ERROR_ACCESS_DENIED = new FleetErrorCode("DOMAIN_JOIN_ERROR_ACCESS_DENIED");
        /// <summary>
        /// Constant DOMAIN_JOIN_ERROR_DS_MACHINE_ACCOUNT_QUOTA_EXCEEDED for FleetErrorCode
        /// </summary>
        public static readonly FleetErrorCode DOMAIN_JOIN_ERROR_DS_MACHINE_ACCOUNT_QUOTA_EXCEEDED = new FleetErrorCode("DOMAIN_JOIN_ERROR_DS_MACHINE_ACCOUNT_QUOTA_EXCEEDED");
        /// <summary>
        /// Constant DOMAIN_JOIN_ERROR_FILE_NOT_FOUND for FleetErrorCode
        /// </summary>
        public static readonly FleetErrorCode DOMAIN_JOIN_ERROR_FILE_NOT_FOUND = new FleetErrorCode("DOMAIN_JOIN_ERROR_FILE_NOT_FOUND");
        /// <summary>
        /// Constant DOMAIN_JOIN_ERROR_INVALID_PARAMETER for FleetErrorCode
        /// </summary>
        public static readonly FleetErrorCode DOMAIN_JOIN_ERROR_INVALID_PARAMETER = new FleetErrorCode("DOMAIN_JOIN_ERROR_INVALID_PARAMETER");
        /// <summary>
        /// Constant DOMAIN_JOIN_ERROR_LOGON_FAILURE for FleetErrorCode
        /// </summary>
        public static readonly FleetErrorCode DOMAIN_JOIN_ERROR_LOGON_FAILURE = new FleetErrorCode("DOMAIN_JOIN_ERROR_LOGON_FAILURE");
        /// <summary>
        /// Constant DOMAIN_JOIN_ERROR_MORE_DATA for FleetErrorCode
        /// </summary>
        public static readonly FleetErrorCode DOMAIN_JOIN_ERROR_MORE_DATA = new FleetErrorCode("DOMAIN_JOIN_ERROR_MORE_DATA");
        /// <summary>
        /// Constant DOMAIN_JOIN_ERROR_NO_SUCH_DOMAIN for FleetErrorCode
        /// </summary>
        public static readonly FleetErrorCode DOMAIN_JOIN_ERROR_NO_SUCH_DOMAIN = new FleetErrorCode("DOMAIN_JOIN_ERROR_NO_SUCH_DOMAIN");
        /// <summary>
        /// Constant DOMAIN_JOIN_ERROR_NOT_SUPPORTED for FleetErrorCode
        /// </summary>
        public static readonly FleetErrorCode DOMAIN_JOIN_ERROR_NOT_SUPPORTED = new FleetErrorCode("DOMAIN_JOIN_ERROR_NOT_SUPPORTED");
        /// <summary>
        /// Constant DOMAIN_JOIN_INTERNAL_SERVICE_ERROR for FleetErrorCode
        /// </summary>
        public static readonly FleetErrorCode DOMAIN_JOIN_INTERNAL_SERVICE_ERROR = new FleetErrorCode("DOMAIN_JOIN_INTERNAL_SERVICE_ERROR");
        /// <summary>
        /// Constant DOMAIN_JOIN_NERR_INVALID_WORKGROUP_NAME for FleetErrorCode
        /// </summary>
        public static readonly FleetErrorCode DOMAIN_JOIN_NERR_INVALID_WORKGROUP_NAME = new FleetErrorCode("DOMAIN_JOIN_NERR_INVALID_WORKGROUP_NAME");
        /// <summary>
        /// Constant DOMAIN_JOIN_NERR_PASSWORD_EXPIRED for FleetErrorCode
        /// </summary>
        public static readonly FleetErrorCode DOMAIN_JOIN_NERR_PASSWORD_EXPIRED = new FleetErrorCode("DOMAIN_JOIN_NERR_PASSWORD_EXPIRED");
        /// <summary>
        /// Constant DOMAIN_JOIN_NERR_WORKSTATION_NOT_STARTED for FleetErrorCode
        /// </summary>
        public static readonly FleetErrorCode DOMAIN_JOIN_NERR_WORKSTATION_NOT_STARTED = new FleetErrorCode("DOMAIN_JOIN_NERR_WORKSTATION_NOT_STARTED");
        /// <summary>
        /// Constant FLEET_INSTANCE_PROVISIONING_FAILURE for FleetErrorCode
        /// </summary>
        public static readonly FleetErrorCode FLEET_INSTANCE_PROVISIONING_FAILURE = new FleetErrorCode("FLEET_INSTANCE_PROVISIONING_FAILURE");
        /// <summary>
        /// Constant FLEET_STOPPED for FleetErrorCode
        /// </summary>
        public static readonly FleetErrorCode FLEET_STOPPED = new FleetErrorCode("FLEET_STOPPED");
        /// <summary>
        /// Constant IAM_SERVICE_ROLE_IS_MISSING for FleetErrorCode
        /// </summary>
        public static readonly FleetErrorCode IAM_SERVICE_ROLE_IS_MISSING = new FleetErrorCode("IAM_SERVICE_ROLE_IS_MISSING");
        /// <summary>
        /// Constant IAM_SERVICE_ROLE_MISSING_DESCRIBE_SECURITY_GROUPS_ACTION for FleetErrorCode
        /// </summary>
        public static readonly FleetErrorCode IAM_SERVICE_ROLE_MISSING_DESCRIBE_SECURITY_GROUPS_ACTION = new FleetErrorCode("IAM_SERVICE_ROLE_MISSING_DESCRIBE_SECURITY_GROUPS_ACTION");
        /// <summary>
        /// Constant IAM_SERVICE_ROLE_MISSING_DESCRIBE_SUBNET_ACTION for FleetErrorCode
        /// </summary>
        public static readonly FleetErrorCode IAM_SERVICE_ROLE_MISSING_DESCRIBE_SUBNET_ACTION = new FleetErrorCode("IAM_SERVICE_ROLE_MISSING_DESCRIBE_SUBNET_ACTION");
        /// <summary>
        /// Constant IAM_SERVICE_ROLE_MISSING_ENI_CREATE_ACTION for FleetErrorCode
        /// </summary>
        public static readonly FleetErrorCode IAM_SERVICE_ROLE_MISSING_ENI_CREATE_ACTION = new FleetErrorCode("IAM_SERVICE_ROLE_MISSING_ENI_CREATE_ACTION");
        /// <summary>
        /// Constant IAM_SERVICE_ROLE_MISSING_ENI_DELETE_ACTION for FleetErrorCode
        /// </summary>
        public static readonly FleetErrorCode IAM_SERVICE_ROLE_MISSING_ENI_DELETE_ACTION = new FleetErrorCode("IAM_SERVICE_ROLE_MISSING_ENI_DELETE_ACTION");
        /// <summary>
        /// Constant IAM_SERVICE_ROLE_MISSING_ENI_DESCRIBE_ACTION for FleetErrorCode
        /// </summary>
        public static readonly FleetErrorCode IAM_SERVICE_ROLE_MISSING_ENI_DESCRIBE_ACTION = new FleetErrorCode("IAM_SERVICE_ROLE_MISSING_ENI_DESCRIBE_ACTION");
        /// <summary>
        /// Constant IGW_NOT_ATTACHED for FleetErrorCode
        /// </summary>
        public static readonly FleetErrorCode IGW_NOT_ATTACHED = new FleetErrorCode("IGW_NOT_ATTACHED");
        /// <summary>
        /// Constant IMAGE_NOT_FOUND for FleetErrorCode
        /// </summary>
        public static readonly FleetErrorCode IMAGE_NOT_FOUND = new FleetErrorCode("IMAGE_NOT_FOUND");
        /// <summary>
        /// Constant INTERNAL_SERVICE_ERROR for FleetErrorCode
        /// </summary>
        public static readonly FleetErrorCode INTERNAL_SERVICE_ERROR = new FleetErrorCode("INTERNAL_SERVICE_ERROR");
        /// <summary>
        /// Constant INVALID_SUBNET_CONFIGURATION for FleetErrorCode
        /// </summary>
        public static readonly FleetErrorCode INVALID_SUBNET_CONFIGURATION = new FleetErrorCode("INVALID_SUBNET_CONFIGURATION");
        /// <summary>
        /// Constant MACHINE_ROLE_IS_MISSING for FleetErrorCode
        /// </summary>
        public static readonly FleetErrorCode MACHINE_ROLE_IS_MISSING = new FleetErrorCode("MACHINE_ROLE_IS_MISSING");
        /// <summary>
        /// Constant NETWORK_INTERFACE_LIMIT_EXCEEDED for FleetErrorCode
        /// </summary>
        public static readonly FleetErrorCode NETWORK_INTERFACE_LIMIT_EXCEEDED = new FleetErrorCode("NETWORK_INTERFACE_LIMIT_EXCEEDED");
        /// <summary>
        /// Constant SECURITY_GROUPS_NOT_FOUND for FleetErrorCode
        /// </summary>
        public static readonly FleetErrorCode SECURITY_GROUPS_NOT_FOUND = new FleetErrorCode("SECURITY_GROUPS_NOT_FOUND");
        /// <summary>
        /// Constant STS_DISABLED_IN_REGION for FleetErrorCode
        /// </summary>
        public static readonly FleetErrorCode STS_DISABLED_IN_REGION = new FleetErrorCode("STS_DISABLED_IN_REGION");
        /// <summary>
        /// Constant SUBNET_HAS_INSUFFICIENT_IP_ADDRESSES for FleetErrorCode
        /// </summary>
        public static readonly FleetErrorCode SUBNET_HAS_INSUFFICIENT_IP_ADDRESSES = new FleetErrorCode("SUBNET_HAS_INSUFFICIENT_IP_ADDRESSES");
        /// <summary>
        /// Constant SUBNET_NOT_FOUND for FleetErrorCode
        /// </summary>
        public static readonly FleetErrorCode SUBNET_NOT_FOUND = new FleetErrorCode("SUBNET_NOT_FOUND");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FleetErrorCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FleetErrorCode FindValue(string value)
        {
            return FindValue<FleetErrorCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FleetErrorCode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type FleetState.
    /// </summary>
    public class FleetState : ConstantClass
    {

        /// <summary>
        /// Constant RUNNING for FleetState
        /// </summary>
        public static readonly FleetState RUNNING = new FleetState("RUNNING");
        /// <summary>
        /// Constant STARTING for FleetState
        /// </summary>
        public static readonly FleetState STARTING = new FleetState("STARTING");
        /// <summary>
        /// Constant STOPPED for FleetState
        /// </summary>
        public static readonly FleetState STOPPED = new FleetState("STOPPED");
        /// <summary>
        /// Constant STOPPING for FleetState
        /// </summary>
        public static readonly FleetState STOPPING = new FleetState("STOPPING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FleetState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FleetState FindValue(string value)
        {
            return FindValue<FleetState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FleetState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type FleetType.
    /// </summary>
    public class FleetType : ConstantClass
    {

        /// <summary>
        /// Constant ALWAYS_ON for FleetType
        /// </summary>
        public static readonly FleetType ALWAYS_ON = new FleetType("ALWAYS_ON");
        /// <summary>
        /// Constant ELASTIC for FleetType
        /// </summary>
        public static readonly FleetType ELASTIC = new FleetType("ELASTIC");
        /// <summary>
        /// Constant ON_DEMAND for FleetType
        /// </summary>
        public static readonly FleetType ON_DEMAND = new FleetType("ON_DEMAND");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FleetType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FleetType FindValue(string value)
        {
            return FindValue<FleetType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FleetType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ImageBuilderState.
    /// </summary>
    public class ImageBuilderState : ConstantClass
    {

        /// <summary>
        /// Constant DELETING for ImageBuilderState
        /// </summary>
        public static readonly ImageBuilderState DELETING = new ImageBuilderState("DELETING");
        /// <summary>
        /// Constant FAILED for ImageBuilderState
        /// </summary>
        public static readonly ImageBuilderState FAILED = new ImageBuilderState("FAILED");
        /// <summary>
        /// Constant PENDING for ImageBuilderState
        /// </summary>
        public static readonly ImageBuilderState PENDING = new ImageBuilderState("PENDING");
        /// <summary>
        /// Constant PENDING_QUALIFICATION for ImageBuilderState
        /// </summary>
        public static readonly ImageBuilderState PENDING_QUALIFICATION = new ImageBuilderState("PENDING_QUALIFICATION");
        /// <summary>
        /// Constant REBOOTING for ImageBuilderState
        /// </summary>
        public static readonly ImageBuilderState REBOOTING = new ImageBuilderState("REBOOTING");
        /// <summary>
        /// Constant RUNNING for ImageBuilderState
        /// </summary>
        public static readonly ImageBuilderState RUNNING = new ImageBuilderState("RUNNING");
        /// <summary>
        /// Constant SNAPSHOTTING for ImageBuilderState
        /// </summary>
        public static readonly ImageBuilderState SNAPSHOTTING = new ImageBuilderState("SNAPSHOTTING");
        /// <summary>
        /// Constant STOPPED for ImageBuilderState
        /// </summary>
        public static readonly ImageBuilderState STOPPED = new ImageBuilderState("STOPPED");
        /// <summary>
        /// Constant STOPPING for ImageBuilderState
        /// </summary>
        public static readonly ImageBuilderState STOPPING = new ImageBuilderState("STOPPING");
        /// <summary>
        /// Constant UPDATING for ImageBuilderState
        /// </summary>
        public static readonly ImageBuilderState UPDATING = new ImageBuilderState("UPDATING");
        /// <summary>
        /// Constant UPDATING_AGENT for ImageBuilderState
        /// </summary>
        public static readonly ImageBuilderState UPDATING_AGENT = new ImageBuilderState("UPDATING_AGENT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ImageBuilderState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ImageBuilderState FindValue(string value)
        {
            return FindValue<ImageBuilderState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ImageBuilderState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ImageBuilderStateChangeReasonCode.
    /// </summary>
    public class ImageBuilderStateChangeReasonCode : ConstantClass
    {

        /// <summary>
        /// Constant IMAGE_UNAVAILABLE for ImageBuilderStateChangeReasonCode
        /// </summary>
        public static readonly ImageBuilderStateChangeReasonCode IMAGE_UNAVAILABLE = new ImageBuilderStateChangeReasonCode("IMAGE_UNAVAILABLE");
        /// <summary>
        /// Constant INTERNAL_ERROR for ImageBuilderStateChangeReasonCode
        /// </summary>
        public static readonly ImageBuilderStateChangeReasonCode INTERNAL_ERROR = new ImageBuilderStateChangeReasonCode("INTERNAL_ERROR");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ImageBuilderStateChangeReasonCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ImageBuilderStateChangeReasonCode FindValue(string value)
        {
            return FindValue<ImageBuilderStateChangeReasonCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ImageBuilderStateChangeReasonCode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ImageSharedWithOthers.
    /// </summary>
    public class ImageSharedWithOthers : ConstantClass
    {

        /// <summary>
        /// Constant FALSE for ImageSharedWithOthers
        /// </summary>
        public static readonly ImageSharedWithOthers FALSE = new ImageSharedWithOthers("FALSE");
        /// <summary>
        /// Constant TRUE for ImageSharedWithOthers
        /// </summary>
        public static readonly ImageSharedWithOthers TRUE = new ImageSharedWithOthers("TRUE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ImageSharedWithOthers(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ImageSharedWithOthers FindValue(string value)
        {
            return FindValue<ImageSharedWithOthers>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ImageSharedWithOthers(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ImageState.
    /// </summary>
    public class ImageState : ConstantClass
    {

        /// <summary>
        /// Constant AVAILABLE for ImageState
        /// </summary>
        public static readonly ImageState AVAILABLE = new ImageState("AVAILABLE");
        /// <summary>
        /// Constant COPYING for ImageState
        /// </summary>
        public static readonly ImageState COPYING = new ImageState("COPYING");
        /// <summary>
        /// Constant CREATING for ImageState
        /// </summary>
        public static readonly ImageState CREATING = new ImageState("CREATING");
        /// <summary>
        /// Constant DELETING for ImageState
        /// </summary>
        public static readonly ImageState DELETING = new ImageState("DELETING");
        /// <summary>
        /// Constant FAILED for ImageState
        /// </summary>
        public static readonly ImageState FAILED = new ImageState("FAILED");
        /// <summary>
        /// Constant IMPORTING for ImageState
        /// </summary>
        public static readonly ImageState IMPORTING = new ImageState("IMPORTING");
        /// <summary>
        /// Constant PENDING for ImageState
        /// </summary>
        public static readonly ImageState PENDING = new ImageState("PENDING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ImageState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ImageState FindValue(string value)
        {
            return FindValue<ImageState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ImageState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ImageStateChangeReasonCode.
    /// </summary>
    public class ImageStateChangeReasonCode : ConstantClass
    {

        /// <summary>
        /// Constant IMAGE_BUILDER_NOT_AVAILABLE for ImageStateChangeReasonCode
        /// </summary>
        public static readonly ImageStateChangeReasonCode IMAGE_BUILDER_NOT_AVAILABLE = new ImageStateChangeReasonCode("IMAGE_BUILDER_NOT_AVAILABLE");
        /// <summary>
        /// Constant IMAGE_COPY_FAILURE for ImageStateChangeReasonCode
        /// </summary>
        public static readonly ImageStateChangeReasonCode IMAGE_COPY_FAILURE = new ImageStateChangeReasonCode("IMAGE_COPY_FAILURE");
        /// <summary>
        /// Constant INTERNAL_ERROR for ImageStateChangeReasonCode
        /// </summary>
        public static readonly ImageStateChangeReasonCode INTERNAL_ERROR = new ImageStateChangeReasonCode("INTERNAL_ERROR");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ImageStateChangeReasonCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ImageStateChangeReasonCode FindValue(string value)
        {
            return FindValue<ImageStateChangeReasonCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ImageStateChangeReasonCode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type LatestAppstreamAgentVersion.
    /// </summary>
    public class LatestAppstreamAgentVersion : ConstantClass
    {

        /// <summary>
        /// Constant FALSE for LatestAppstreamAgentVersion
        /// </summary>
        public static readonly LatestAppstreamAgentVersion FALSE = new LatestAppstreamAgentVersion("FALSE");
        /// <summary>
        /// Constant TRUE for LatestAppstreamAgentVersion
        /// </summary>
        public static readonly LatestAppstreamAgentVersion TRUE = new LatestAppstreamAgentVersion("TRUE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public LatestAppstreamAgentVersion(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LatestAppstreamAgentVersion FindValue(string value)
        {
            return FindValue<LatestAppstreamAgentVersion>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator LatestAppstreamAgentVersion(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type MessageAction.
    /// </summary>
    public class MessageAction : ConstantClass
    {

        /// <summary>
        /// Constant RESEND for MessageAction
        /// </summary>
        public static readonly MessageAction RESEND = new MessageAction("RESEND");
        /// <summary>
        /// Constant SUPPRESS for MessageAction
        /// </summary>
        public static readonly MessageAction SUPPRESS = new MessageAction("SUPPRESS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MessageAction(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MessageAction FindValue(string value)
        {
            return FindValue<MessageAction>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MessageAction(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PackagingType.
    /// </summary>
    public class PackagingType : ConstantClass
    {

        /// <summary>
        /// Constant APPSTREAM2 for PackagingType
        /// </summary>
        public static readonly PackagingType APPSTREAM2 = new PackagingType("APPSTREAM2");
        /// <summary>
        /// Constant CUSTOM for PackagingType
        /// </summary>
        public static readonly PackagingType CUSTOM = new PackagingType("CUSTOM");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PackagingType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PackagingType FindValue(string value)
        {
            return FindValue<PackagingType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PackagingType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Permission.
    /// </summary>
    public class Permission : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for Permission
        /// </summary>
        public static readonly Permission DISABLED = new Permission("DISABLED");
        /// <summary>
        /// Constant ENABLED for Permission
        /// </summary>
        public static readonly Permission ENABLED = new Permission("ENABLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Permission(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Permission FindValue(string value)
        {
            return FindValue<Permission>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Permission(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PlatformType.
    /// </summary>
    public class PlatformType : ConstantClass
    {

        /// <summary>
        /// Constant AMAZON_LINUX2 for PlatformType
        /// </summary>
        public static readonly PlatformType AMAZON_LINUX2 = new PlatformType("AMAZON_LINUX2");
        /// <summary>
        /// Constant RHEL8 for PlatformType
        /// </summary>
        public static readonly PlatformType RHEL8 = new PlatformType("RHEL8");
        /// <summary>
        /// Constant ROCKY_LINUX8 for PlatformType
        /// </summary>
        public static readonly PlatformType ROCKY_LINUX8 = new PlatformType("ROCKY_LINUX8");
        /// <summary>
        /// Constant WINDOWS for PlatformType
        /// </summary>
        public static readonly PlatformType WINDOWS = new PlatformType("WINDOWS");
        /// <summary>
        /// Constant WINDOWS_SERVER_2016 for PlatformType
        /// </summary>
        public static readonly PlatformType WINDOWS_SERVER_2016 = new PlatformType("WINDOWS_SERVER_2016");
        /// <summary>
        /// Constant WINDOWS_SERVER_2019 for PlatformType
        /// </summary>
        public static readonly PlatformType WINDOWS_SERVER_2019 = new PlatformType("WINDOWS_SERVER_2019");
        /// <summary>
        /// Constant WINDOWS_SERVER_2022 for PlatformType
        /// </summary>
        public static readonly PlatformType WINDOWS_SERVER_2022 = new PlatformType("WINDOWS_SERVER_2022");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PlatformType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PlatformType FindValue(string value)
        {
            return FindValue<PlatformType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PlatformType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PreferredProtocol.
    /// </summary>
    public class PreferredProtocol : ConstantClass
    {

        /// <summary>
        /// Constant TCP for PreferredProtocol
        /// </summary>
        public static readonly PreferredProtocol TCP = new PreferredProtocol("TCP");
        /// <summary>
        /// Constant UDP for PreferredProtocol
        /// </summary>
        public static readonly PreferredProtocol UDP = new PreferredProtocol("UDP");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PreferredProtocol(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PreferredProtocol FindValue(string value)
        {
            return FindValue<PreferredProtocol>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PreferredProtocol(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SessionConnectionState.
    /// </summary>
    public class SessionConnectionState : ConstantClass
    {

        /// <summary>
        /// Constant CONNECTED for SessionConnectionState
        /// </summary>
        public static readonly SessionConnectionState CONNECTED = new SessionConnectionState("CONNECTED");
        /// <summary>
        /// Constant NOT_CONNECTED for SessionConnectionState
        /// </summary>
        public static readonly SessionConnectionState NOT_CONNECTED = new SessionConnectionState("NOT_CONNECTED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SessionConnectionState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SessionConnectionState FindValue(string value)
        {
            return FindValue<SessionConnectionState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SessionConnectionState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type StackAttribute.
    /// </summary>
    public class StackAttribute : ConstantClass
    {

        /// <summary>
        /// Constant ACCESS_ENDPOINTS for StackAttribute
        /// </summary>
        public static readonly StackAttribute ACCESS_ENDPOINTS = new StackAttribute("ACCESS_ENDPOINTS");
        /// <summary>
        /// Constant EMBED_HOST_DOMAINS for StackAttribute
        /// </summary>
        public static readonly StackAttribute EMBED_HOST_DOMAINS = new StackAttribute("EMBED_HOST_DOMAINS");
        /// <summary>
        /// Constant FEEDBACK_URL for StackAttribute
        /// </summary>
        public static readonly StackAttribute FEEDBACK_URL = new StackAttribute("FEEDBACK_URL");
        /// <summary>
        /// Constant IAM_ROLE_ARN for StackAttribute
        /// </summary>
        public static readonly StackAttribute IAM_ROLE_ARN = new StackAttribute("IAM_ROLE_ARN");
        /// <summary>
        /// Constant REDIRECT_URL for StackAttribute
        /// </summary>
        public static readonly StackAttribute REDIRECT_URL = new StackAttribute("REDIRECT_URL");
        /// <summary>
        /// Constant STORAGE_CONNECTOR_GOOGLE_DRIVE for StackAttribute
        /// </summary>
        public static readonly StackAttribute STORAGE_CONNECTOR_GOOGLE_DRIVE = new StackAttribute("STORAGE_CONNECTOR_GOOGLE_DRIVE");
        /// <summary>
        /// Constant STORAGE_CONNECTOR_HOMEFOLDERS for StackAttribute
        /// </summary>
        public static readonly StackAttribute STORAGE_CONNECTOR_HOMEFOLDERS = new StackAttribute("STORAGE_CONNECTOR_HOMEFOLDERS");
        /// <summary>
        /// Constant STORAGE_CONNECTOR_ONE_DRIVE for StackAttribute
        /// </summary>
        public static readonly StackAttribute STORAGE_CONNECTOR_ONE_DRIVE = new StackAttribute("STORAGE_CONNECTOR_ONE_DRIVE");
        /// <summary>
        /// Constant STORAGE_CONNECTORS for StackAttribute
        /// </summary>
        public static readonly StackAttribute STORAGE_CONNECTORS = new StackAttribute("STORAGE_CONNECTORS");
        /// <summary>
        /// Constant STREAMING_EXPERIENCE_SETTINGS for StackAttribute
        /// </summary>
        public static readonly StackAttribute STREAMING_EXPERIENCE_SETTINGS = new StackAttribute("STREAMING_EXPERIENCE_SETTINGS");
        /// <summary>
        /// Constant THEME_NAME for StackAttribute
        /// </summary>
        public static readonly StackAttribute THEME_NAME = new StackAttribute("THEME_NAME");
        /// <summary>
        /// Constant USER_SETTINGS for StackAttribute
        /// </summary>
        public static readonly StackAttribute USER_SETTINGS = new StackAttribute("USER_SETTINGS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public StackAttribute(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static StackAttribute FindValue(string value)
        {
            return FindValue<StackAttribute>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator StackAttribute(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type StackErrorCode.
    /// </summary>
    public class StackErrorCode : ConstantClass
    {

        /// <summary>
        /// Constant INTERNAL_SERVICE_ERROR for StackErrorCode
        /// </summary>
        public static readonly StackErrorCode INTERNAL_SERVICE_ERROR = new StackErrorCode("INTERNAL_SERVICE_ERROR");
        /// <summary>
        /// Constant STORAGE_CONNECTOR_ERROR for StackErrorCode
        /// </summary>
        public static readonly StackErrorCode STORAGE_CONNECTOR_ERROR = new StackErrorCode("STORAGE_CONNECTOR_ERROR");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public StackErrorCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static StackErrorCode FindValue(string value)
        {
            return FindValue<StackErrorCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator StackErrorCode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type StorageConnectorType.
    /// </summary>
    public class StorageConnectorType : ConstantClass
    {

        /// <summary>
        /// Constant GOOGLE_DRIVE for StorageConnectorType
        /// </summary>
        public static readonly StorageConnectorType GOOGLE_DRIVE = new StorageConnectorType("GOOGLE_DRIVE");
        /// <summary>
        /// Constant HOMEFOLDERS for StorageConnectorType
        /// </summary>
        public static readonly StorageConnectorType HOMEFOLDERS = new StorageConnectorType("HOMEFOLDERS");
        /// <summary>
        /// Constant ONE_DRIVE for StorageConnectorType
        /// </summary>
        public static readonly StorageConnectorType ONE_DRIVE = new StorageConnectorType("ONE_DRIVE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public StorageConnectorType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static StorageConnectorType FindValue(string value)
        {
            return FindValue<StorageConnectorType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator StorageConnectorType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type StreamSessionState.
    /// </summary>
    public class StreamSessionState : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for StreamSessionState
        /// </summary>
        public static readonly StreamSessionState ACTIVE = new StreamSessionState("ACTIVE");
        /// <summary>
        /// Constant EXPIRED for StreamSessionState
        /// </summary>
        public static readonly StreamSessionState EXPIRED = new StreamSessionState("EXPIRED");
        /// <summary>
        /// Constant PENDING for StreamSessionState
        /// </summary>
        public static readonly StreamSessionState PENDING = new StreamSessionState("PENDING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public StreamSessionState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static StreamSessionState FindValue(string value)
        {
            return FindValue<StreamSessionState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator StreamSessionState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type StreamView.
    /// </summary>
    public class StreamView : ConstantClass
    {

        /// <summary>
        /// Constant APP for StreamView
        /// </summary>
        public static readonly StreamView APP = new StreamView("APP");
        /// <summary>
        /// Constant DESKTOP for StreamView
        /// </summary>
        public static readonly StreamView DESKTOP = new StreamView("DESKTOP");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public StreamView(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static StreamView FindValue(string value)
        {
            return FindValue<StreamView>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator StreamView(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ThemeAttribute.
    /// </summary>
    public class ThemeAttribute : ConstantClass
    {

        /// <summary>
        /// Constant FOOTER_LINKS for ThemeAttribute
        /// </summary>
        public static readonly ThemeAttribute FOOTER_LINKS = new ThemeAttribute("FOOTER_LINKS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ThemeAttribute(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ThemeAttribute FindValue(string value)
        {
            return FindValue<ThemeAttribute>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ThemeAttribute(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ThemeState.
    /// </summary>
    public class ThemeState : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for ThemeState
        /// </summary>
        public static readonly ThemeState DISABLED = new ThemeState("DISABLED");
        /// <summary>
        /// Constant ENABLED for ThemeState
        /// </summary>
        public static readonly ThemeState ENABLED = new ThemeState("ENABLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ThemeState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ThemeState FindValue(string value)
        {
            return FindValue<ThemeState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ThemeState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ThemeStyling.
    /// </summary>
    public class ThemeStyling : ConstantClass
    {

        /// <summary>
        /// Constant BLUE for ThemeStyling
        /// </summary>
        public static readonly ThemeStyling BLUE = new ThemeStyling("BLUE");
        /// <summary>
        /// Constant LIGHT_BLUE for ThemeStyling
        /// </summary>
        public static readonly ThemeStyling LIGHT_BLUE = new ThemeStyling("LIGHT_BLUE");
        /// <summary>
        /// Constant PINK for ThemeStyling
        /// </summary>
        public static readonly ThemeStyling PINK = new ThemeStyling("PINK");
        /// <summary>
        /// Constant RED for ThemeStyling
        /// </summary>
        public static readonly ThemeStyling RED = new ThemeStyling("RED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ThemeStyling(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ThemeStyling FindValue(string value)
        {
            return FindValue<ThemeStyling>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ThemeStyling(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type UsageReportExecutionErrorCode.
    /// </summary>
    public class UsageReportExecutionErrorCode : ConstantClass
    {

        /// <summary>
        /// Constant ACCESS_DENIED for UsageReportExecutionErrorCode
        /// </summary>
        public static readonly UsageReportExecutionErrorCode ACCESS_DENIED = new UsageReportExecutionErrorCode("ACCESS_DENIED");
        /// <summary>
        /// Constant INTERNAL_SERVICE_ERROR for UsageReportExecutionErrorCode
        /// </summary>
        public static readonly UsageReportExecutionErrorCode INTERNAL_SERVICE_ERROR = new UsageReportExecutionErrorCode("INTERNAL_SERVICE_ERROR");
        /// <summary>
        /// Constant RESOURCE_NOT_FOUND for UsageReportExecutionErrorCode
        /// </summary>
        public static readonly UsageReportExecutionErrorCode RESOURCE_NOT_FOUND = new UsageReportExecutionErrorCode("RESOURCE_NOT_FOUND");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public UsageReportExecutionErrorCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static UsageReportExecutionErrorCode FindValue(string value)
        {
            return FindValue<UsageReportExecutionErrorCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator UsageReportExecutionErrorCode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type UsageReportSchedule.
    /// </summary>
    public class UsageReportSchedule : ConstantClass
    {

        /// <summary>
        /// Constant DAILY for UsageReportSchedule
        /// </summary>
        public static readonly UsageReportSchedule DAILY = new UsageReportSchedule("DAILY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public UsageReportSchedule(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static UsageReportSchedule FindValue(string value)
        {
            return FindValue<UsageReportSchedule>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator UsageReportSchedule(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type UserStackAssociationErrorCode.
    /// </summary>
    public class UserStackAssociationErrorCode : ConstantClass
    {

        /// <summary>
        /// Constant DIRECTORY_NOT_FOUND for UserStackAssociationErrorCode
        /// </summary>
        public static readonly UserStackAssociationErrorCode DIRECTORY_NOT_FOUND = new UserStackAssociationErrorCode("DIRECTORY_NOT_FOUND");
        /// <summary>
        /// Constant INTERNAL_ERROR for UserStackAssociationErrorCode
        /// </summary>
        public static readonly UserStackAssociationErrorCode INTERNAL_ERROR = new UserStackAssociationErrorCode("INTERNAL_ERROR");
        /// <summary>
        /// Constant STACK_NOT_FOUND for UserStackAssociationErrorCode
        /// </summary>
        public static readonly UserStackAssociationErrorCode STACK_NOT_FOUND = new UserStackAssociationErrorCode("STACK_NOT_FOUND");
        /// <summary>
        /// Constant USER_NAME_NOT_FOUND for UserStackAssociationErrorCode
        /// </summary>
        public static readonly UserStackAssociationErrorCode USER_NAME_NOT_FOUND = new UserStackAssociationErrorCode("USER_NAME_NOT_FOUND");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public UserStackAssociationErrorCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static UserStackAssociationErrorCode FindValue(string value)
        {
            return FindValue<UserStackAssociationErrorCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator UserStackAssociationErrorCode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type VisibilityType.
    /// </summary>
    public class VisibilityType : ConstantClass
    {

        /// <summary>
        /// Constant PRIVATE for VisibilityType
        /// </summary>
        public static readonly VisibilityType PRIVATE = new VisibilityType("PRIVATE");
        /// <summary>
        /// Constant PUBLIC for VisibilityType
        /// </summary>
        public static readonly VisibilityType PUBLIC = new VisibilityType("PUBLIC");
        /// <summary>
        /// Constant SHARED for VisibilityType
        /// </summary>
        public static readonly VisibilityType SHARED = new VisibilityType("SHARED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public VisibilityType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static VisibilityType FindValue(string value)
        {
            return FindValue<VisibilityType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator VisibilityType(string value)
        {
            return FindValue(value);
        }
    }

}