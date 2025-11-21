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
 * Do not modify this file. This file is generated from the workspaces-2015-04-08.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.WorkSpaces
{

    /// <summary>
    /// Constants used for properties of type AccessEndpointType.
    /// </summary>
    public class AccessEndpointType : ConstantClass
    {

        /// <summary>
        /// Constant STREAMING_WSP for AccessEndpointType
        /// </summary>
        public static readonly AccessEndpointType STREAMING_WSP = new AccessEndpointType("STREAMING_WSP");

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
    /// Constants used for properties of type AccessPropertyValue.
    /// </summary>
    public class AccessPropertyValue : ConstantClass
    {

        /// <summary>
        /// Constant ALLOW for AccessPropertyValue
        /// </summary>
        public static readonly AccessPropertyValue ALLOW = new AccessPropertyValue("ALLOW");
        /// <summary>
        /// Constant DENY for AccessPropertyValue
        /// </summary>
        public static readonly AccessPropertyValue DENY = new AccessPropertyValue("DENY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AccessPropertyValue(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AccessPropertyValue FindValue(string value)
        {
            return FindValue<AccessPropertyValue>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AccessPropertyValue(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AccountLinkStatusEnum.
    /// </summary>
    public class AccountLinkStatusEnum : ConstantClass
    {

        /// <summary>
        /// Constant LINK_NOT_FOUND for AccountLinkStatusEnum
        /// </summary>
        public static readonly AccountLinkStatusEnum LINK_NOT_FOUND = new AccountLinkStatusEnum("LINK_NOT_FOUND");
        /// <summary>
        /// Constant LINKED for AccountLinkStatusEnum
        /// </summary>
        public static readonly AccountLinkStatusEnum LINKED = new AccountLinkStatusEnum("LINKED");
        /// <summary>
        /// Constant LINKING_FAILED for AccountLinkStatusEnum
        /// </summary>
        public static readonly AccountLinkStatusEnum LINKING_FAILED = new AccountLinkStatusEnum("LINKING_FAILED");
        /// <summary>
        /// Constant PENDING_ACCEPTANCE_BY_TARGET_ACCOUNT for AccountLinkStatusEnum
        /// </summary>
        public static readonly AccountLinkStatusEnum PENDING_ACCEPTANCE_BY_TARGET_ACCOUNT = new AccountLinkStatusEnum("PENDING_ACCEPTANCE_BY_TARGET_ACCOUNT");
        /// <summary>
        /// Constant REJECTED for AccountLinkStatusEnum
        /// </summary>
        public static readonly AccountLinkStatusEnum REJECTED = new AccountLinkStatusEnum("REJECTED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AccountLinkStatusEnum(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AccountLinkStatusEnum FindValue(string value)
        {
            return FindValue<AccountLinkStatusEnum>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AccountLinkStatusEnum(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AGAModeForDirectoryEnum.
    /// </summary>
    public class AGAModeForDirectoryEnum : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for AGAModeForDirectoryEnum
        /// </summary>
        public static readonly AGAModeForDirectoryEnum DISABLED = new AGAModeForDirectoryEnum("DISABLED");
        /// <summary>
        /// Constant ENABLED_AUTO for AGAModeForDirectoryEnum
        /// </summary>
        public static readonly AGAModeForDirectoryEnum ENABLED_AUTO = new AGAModeForDirectoryEnum("ENABLED_AUTO");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AGAModeForDirectoryEnum(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AGAModeForDirectoryEnum FindValue(string value)
        {
            return FindValue<AGAModeForDirectoryEnum>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AGAModeForDirectoryEnum(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AGAModeForWorkSpaceEnum.
    /// </summary>
    public class AGAModeForWorkSpaceEnum : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for AGAModeForWorkSpaceEnum
        /// </summary>
        public static readonly AGAModeForWorkSpaceEnum DISABLED = new AGAModeForWorkSpaceEnum("DISABLED");
        /// <summary>
        /// Constant ENABLED_AUTO for AGAModeForWorkSpaceEnum
        /// </summary>
        public static readonly AGAModeForWorkSpaceEnum ENABLED_AUTO = new AGAModeForWorkSpaceEnum("ENABLED_AUTO");
        /// <summary>
        /// Constant INHERITED for AGAModeForWorkSpaceEnum
        /// </summary>
        public static readonly AGAModeForWorkSpaceEnum INHERITED = new AGAModeForWorkSpaceEnum("INHERITED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AGAModeForWorkSpaceEnum(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AGAModeForWorkSpaceEnum FindValue(string value)
        {
            return FindValue<AGAModeForWorkSpaceEnum>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AGAModeForWorkSpaceEnum(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AGAPreferredProtocolForDirectory.
    /// </summary>
    public class AGAPreferredProtocolForDirectory : ConstantClass
    {

        /// <summary>
        /// Constant NONE for AGAPreferredProtocolForDirectory
        /// </summary>
        public static readonly AGAPreferredProtocolForDirectory NONE = new AGAPreferredProtocolForDirectory("NONE");
        /// <summary>
        /// Constant TCP for AGAPreferredProtocolForDirectory
        /// </summary>
        public static readonly AGAPreferredProtocolForDirectory TCP = new AGAPreferredProtocolForDirectory("TCP");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AGAPreferredProtocolForDirectory(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AGAPreferredProtocolForDirectory FindValue(string value)
        {
            return FindValue<AGAPreferredProtocolForDirectory>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AGAPreferredProtocolForDirectory(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AGAPreferredProtocolForWorkSpace.
    /// </summary>
    public class AGAPreferredProtocolForWorkSpace : ConstantClass
    {

        /// <summary>
        /// Constant INHERITED for AGAPreferredProtocolForWorkSpace
        /// </summary>
        public static readonly AGAPreferredProtocolForWorkSpace INHERITED = new AGAPreferredProtocolForWorkSpace("INHERITED");
        /// <summary>
        /// Constant NONE for AGAPreferredProtocolForWorkSpace
        /// </summary>
        public static readonly AGAPreferredProtocolForWorkSpace NONE = new AGAPreferredProtocolForWorkSpace("NONE");
        /// <summary>
        /// Constant TCP for AGAPreferredProtocolForWorkSpace
        /// </summary>
        public static readonly AGAPreferredProtocolForWorkSpace TCP = new AGAPreferredProtocolForWorkSpace("TCP");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AGAPreferredProtocolForWorkSpace(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AGAPreferredProtocolForWorkSpace FindValue(string value)
        {
            return FindValue<AGAPreferredProtocolForWorkSpace>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AGAPreferredProtocolForWorkSpace(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Application.
    /// </summary>
    public class Application : ConstantClass
    {

        /// <summary>
        /// Constant Microsoft_Office_2016 for Application
        /// </summary>
        public static readonly Application Microsoft_Office_2016 = new Application("Microsoft_Office_2016");
        /// <summary>
        /// Constant Microsoft_Office_2019 for Application
        /// </summary>
        public static readonly Application Microsoft_Office_2019 = new Application("Microsoft_Office_2019");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Application(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Application FindValue(string value)
        {
            return FindValue<Application>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Application(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ApplicationAssociatedResourceType.
    /// </summary>
    public class ApplicationAssociatedResourceType : ConstantClass
    {

        /// <summary>
        /// Constant BUNDLE for ApplicationAssociatedResourceType
        /// </summary>
        public static readonly ApplicationAssociatedResourceType BUNDLE = new ApplicationAssociatedResourceType("BUNDLE");
        /// <summary>
        /// Constant IMAGE for ApplicationAssociatedResourceType
        /// </summary>
        public static readonly ApplicationAssociatedResourceType IMAGE = new ApplicationAssociatedResourceType("IMAGE");
        /// <summary>
        /// Constant WORKSPACE for ApplicationAssociatedResourceType
        /// </summary>
        public static readonly ApplicationAssociatedResourceType WORKSPACE = new ApplicationAssociatedResourceType("WORKSPACE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ApplicationAssociatedResourceType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ApplicationAssociatedResourceType FindValue(string value)
        {
            return FindValue<ApplicationAssociatedResourceType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ApplicationAssociatedResourceType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ApplicationSettingsStatusEnum.
    /// </summary>
    public class ApplicationSettingsStatusEnum : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for ApplicationSettingsStatusEnum
        /// </summary>
        public static readonly ApplicationSettingsStatusEnum DISABLED = new ApplicationSettingsStatusEnum("DISABLED");
        /// <summary>
        /// Constant ENABLED for ApplicationSettingsStatusEnum
        /// </summary>
        public static readonly ApplicationSettingsStatusEnum ENABLED = new ApplicationSettingsStatusEnum("ENABLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ApplicationSettingsStatusEnum(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ApplicationSettingsStatusEnum FindValue(string value)
        {
            return FindValue<ApplicationSettingsStatusEnum>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ApplicationSettingsStatusEnum(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AssociationErrorCode.
    /// </summary>
    public class AssociationErrorCode : ConstantClass
    {

        /// <summary>
        /// Constant DeploymentErrorInternalServerError for AssociationErrorCode
        /// </summary>
        public static readonly AssociationErrorCode DeploymentErrorInternalServerError = new AssociationErrorCode("DeploymentError.InternalServerError");
        /// <summary>
        /// Constant DeploymentErrorWorkspaceUnreachable for AssociationErrorCode
        /// </summary>
        public static readonly AssociationErrorCode DeploymentErrorWorkspaceUnreachable = new AssociationErrorCode("DeploymentError.WorkspaceUnreachable");
        /// <summary>
        /// Constant ValidationErrorInsufficientDiskSpace for AssociationErrorCode
        /// </summary>
        public static readonly AssociationErrorCode ValidationErrorInsufficientDiskSpace = new AssociationErrorCode("ValidationError.InsufficientDiskSpace");
        /// <summary>
        /// Constant ValidationErrorInsufficientMemory for AssociationErrorCode
        /// </summary>
        public static readonly AssociationErrorCode ValidationErrorInsufficientMemory = new AssociationErrorCode("ValidationError.InsufficientMemory");
        /// <summary>
        /// Constant ValidationErrorUnsupportedOperatingSystem for AssociationErrorCode
        /// </summary>
        public static readonly AssociationErrorCode ValidationErrorUnsupportedOperatingSystem = new AssociationErrorCode("ValidationError.UnsupportedOperatingSystem");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AssociationErrorCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AssociationErrorCode FindValue(string value)
        {
            return FindValue<AssociationErrorCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AssociationErrorCode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AssociationState.
    /// </summary>
    public class AssociationState : ConstantClass
    {

        /// <summary>
        /// Constant COMPLETED for AssociationState
        /// </summary>
        public static readonly AssociationState COMPLETED = new AssociationState("COMPLETED");
        /// <summary>
        /// Constant ERROR for AssociationState
        /// </summary>
        public static readonly AssociationState ERROR = new AssociationState("ERROR");
        /// <summary>
        /// Constant INSTALLING for AssociationState
        /// </summary>
        public static readonly AssociationState INSTALLING = new AssociationState("INSTALLING");
        /// <summary>
        /// Constant PENDING_INSTALL for AssociationState
        /// </summary>
        public static readonly AssociationState PENDING_INSTALL = new AssociationState("PENDING_INSTALL");
        /// <summary>
        /// Constant PENDING_INSTALL_DEPLOYMENT for AssociationState
        /// </summary>
        public static readonly AssociationState PENDING_INSTALL_DEPLOYMENT = new AssociationState("PENDING_INSTALL_DEPLOYMENT");
        /// <summary>
        /// Constant PENDING_UNINSTALL for AssociationState
        /// </summary>
        public static readonly AssociationState PENDING_UNINSTALL = new AssociationState("PENDING_UNINSTALL");
        /// <summary>
        /// Constant PENDING_UNINSTALL_DEPLOYMENT for AssociationState
        /// </summary>
        public static readonly AssociationState PENDING_UNINSTALL_DEPLOYMENT = new AssociationState("PENDING_UNINSTALL_DEPLOYMENT");
        /// <summary>
        /// Constant REMOVED for AssociationState
        /// </summary>
        public static readonly AssociationState REMOVED = new AssociationState("REMOVED");
        /// <summary>
        /// Constant UNINSTALLING for AssociationState
        /// </summary>
        public static readonly AssociationState UNINSTALLING = new AssociationState("UNINSTALLING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AssociationState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AssociationState FindValue(string value)
        {
            return FindValue<AssociationState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AssociationState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AssociationStatus.
    /// </summary>
    public class AssociationStatus : ConstantClass
    {

        /// <summary>
        /// Constant ASSOCIATED_WITH_OWNER_ACCOUNT for AssociationStatus
        /// </summary>
        public static readonly AssociationStatus ASSOCIATED_WITH_OWNER_ACCOUNT = new AssociationStatus("ASSOCIATED_WITH_OWNER_ACCOUNT");
        /// <summary>
        /// Constant ASSOCIATED_WITH_SHARED_ACCOUNT for AssociationStatus
        /// </summary>
        public static readonly AssociationStatus ASSOCIATED_WITH_SHARED_ACCOUNT = new AssociationStatus("ASSOCIATED_WITH_SHARED_ACCOUNT");
        /// <summary>
        /// Constant NOT_ASSOCIATED for AssociationStatus
        /// </summary>
        public static readonly AssociationStatus NOT_ASSOCIATED = new AssociationStatus("NOT_ASSOCIATED");
        /// <summary>
        /// Constant PENDING_ASSOCIATION for AssociationStatus
        /// </summary>
        public static readonly AssociationStatus PENDING_ASSOCIATION = new AssociationStatus("PENDING_ASSOCIATION");
        /// <summary>
        /// Constant PENDING_DISASSOCIATION for AssociationStatus
        /// </summary>
        public static readonly AssociationStatus PENDING_DISASSOCIATION = new AssociationStatus("PENDING_DISASSOCIATION");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AssociationStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AssociationStatus FindValue(string value)
        {
            return FindValue<AssociationStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AssociationStatus(string value)
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
        /// Constant SAML for AuthenticationType
        /// </summary>
        public static readonly AuthenticationType SAML = new AuthenticationType("SAML");

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
    /// Constants used for properties of type BundleAssociatedResourceType.
    /// </summary>
    public class BundleAssociatedResourceType : ConstantClass
    {

        /// <summary>
        /// Constant APPLICATION for BundleAssociatedResourceType
        /// </summary>
        public static readonly BundleAssociatedResourceType APPLICATION = new BundleAssociatedResourceType("APPLICATION");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public BundleAssociatedResourceType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static BundleAssociatedResourceType FindValue(string value)
        {
            return FindValue<BundleAssociatedResourceType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator BundleAssociatedResourceType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type BundleType.
    /// </summary>
    public class BundleType : ConstantClass
    {

        /// <summary>
        /// Constant REGULAR for BundleType
        /// </summary>
        public static readonly BundleType REGULAR = new BundleType("REGULAR");
        /// <summary>
        /// Constant STANDBY for BundleType
        /// </summary>
        public static readonly BundleType STANDBY = new BundleType("STANDBY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public BundleType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static BundleType FindValue(string value)
        {
            return FindValue<BundleType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator BundleType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CertificateBasedAuthStatusEnum.
    /// </summary>
    public class CertificateBasedAuthStatusEnum : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for CertificateBasedAuthStatusEnum
        /// </summary>
        public static readonly CertificateBasedAuthStatusEnum DISABLED = new CertificateBasedAuthStatusEnum("DISABLED");
        /// <summary>
        /// Constant ENABLED for CertificateBasedAuthStatusEnum
        /// </summary>
        public static readonly CertificateBasedAuthStatusEnum ENABLED = new CertificateBasedAuthStatusEnum("ENABLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CertificateBasedAuthStatusEnum(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CertificateBasedAuthStatusEnum FindValue(string value)
        {
            return FindValue<CertificateBasedAuthStatusEnum>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CertificateBasedAuthStatusEnum(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ClientDeviceType.
    /// </summary>
    public class ClientDeviceType : ConstantClass
    {

        /// <summary>
        /// Constant DeviceTypeAndroid for ClientDeviceType
        /// </summary>
        public static readonly ClientDeviceType DeviceTypeAndroid = new ClientDeviceType("DeviceTypeAndroid");
        /// <summary>
        /// Constant DeviceTypeIos for ClientDeviceType
        /// </summary>
        public static readonly ClientDeviceType DeviceTypeIos = new ClientDeviceType("DeviceTypeIos");
        /// <summary>
        /// Constant DeviceTypeLinux for ClientDeviceType
        /// </summary>
        public static readonly ClientDeviceType DeviceTypeLinux = new ClientDeviceType("DeviceTypeLinux");
        /// <summary>
        /// Constant DeviceTypeOsx for ClientDeviceType
        /// </summary>
        public static readonly ClientDeviceType DeviceTypeOsx = new ClientDeviceType("DeviceTypeOsx");
        /// <summary>
        /// Constant DeviceTypeWeb for ClientDeviceType
        /// </summary>
        public static readonly ClientDeviceType DeviceTypeWeb = new ClientDeviceType("DeviceTypeWeb");
        /// <summary>
        /// Constant DeviceTypeWindows for ClientDeviceType
        /// </summary>
        public static readonly ClientDeviceType DeviceTypeWindows = new ClientDeviceType("DeviceTypeWindows");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ClientDeviceType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ClientDeviceType FindValue(string value)
        {
            return FindValue<ClientDeviceType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ClientDeviceType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Compute.
    /// </summary>
    public class Compute : ConstantClass
    {

        /// <summary>
        /// Constant GENERALPURPOSE_4XLARGE for Compute
        /// </summary>
        public static readonly Compute GENERALPURPOSE_4XLARGE = new Compute("GENERALPURPOSE_4XLARGE");
        /// <summary>
        /// Constant GENERALPURPOSE_8XLARGE for Compute
        /// </summary>
        public static readonly Compute GENERALPURPOSE_8XLARGE = new Compute("GENERALPURPOSE_8XLARGE");
        /// <summary>
        /// Constant GRAPHICS for Compute
        /// </summary>
        public static readonly Compute GRAPHICS = new Compute("GRAPHICS");
        /// <summary>
        /// Constant GRAPHICS_G4DN for Compute
        /// </summary>
        public static readonly Compute GRAPHICS_G4DN = new Compute("GRAPHICS_G4DN");
        /// <summary>
        /// Constant GRAPHICSPRO for Compute
        /// </summary>
        public static readonly Compute GRAPHICSPRO = new Compute("GRAPHICSPRO");
        /// <summary>
        /// Constant GRAPHICSPRO_G4DN for Compute
        /// </summary>
        public static readonly Compute GRAPHICSPRO_G4DN = new Compute("GRAPHICSPRO_G4DN");
        /// <summary>
        /// Constant PERFORMANCE for Compute
        /// </summary>
        public static readonly Compute PERFORMANCE = new Compute("PERFORMANCE");
        /// <summary>
        /// Constant POWER for Compute
        /// </summary>
        public static readonly Compute POWER = new Compute("POWER");
        /// <summary>
        /// Constant POWERPRO for Compute
        /// </summary>
        public static readonly Compute POWERPRO = new Compute("POWERPRO");
        /// <summary>
        /// Constant STANDARD for Compute
        /// </summary>
        public static readonly Compute STANDARD = new Compute("STANDARD");
        /// <summary>
        /// Constant VALUE_TYPE for Compute
        /// </summary>
        public static readonly Compute VALUE_TYPE = new Compute("VALUE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Compute(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Compute FindValue(string value)
        {
            return FindValue<Compute>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Compute(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ConnectionAliasState.
    /// </summary>
    public class ConnectionAliasState : ConstantClass
    {

        /// <summary>
        /// Constant CREATED for ConnectionAliasState
        /// </summary>
        public static readonly ConnectionAliasState CREATED = new ConnectionAliasState("CREATED");
        /// <summary>
        /// Constant CREATING for ConnectionAliasState
        /// </summary>
        public static readonly ConnectionAliasState CREATING = new ConnectionAliasState("CREATING");
        /// <summary>
        /// Constant DELETING for ConnectionAliasState
        /// </summary>
        public static readonly ConnectionAliasState DELETING = new ConnectionAliasState("DELETING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ConnectionAliasState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ConnectionAliasState FindValue(string value)
        {
            return FindValue<ConnectionAliasState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ConnectionAliasState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ConnectionState.
    /// </summary>
    public class ConnectionState : ConstantClass
    {

        /// <summary>
        /// Constant CONNECTED for ConnectionState
        /// </summary>
        public static readonly ConnectionState CONNECTED = new ConnectionState("CONNECTED");
        /// <summary>
        /// Constant DISCONNECTED for ConnectionState
        /// </summary>
        public static readonly ConnectionState DISCONNECTED = new ConnectionState("DISCONNECTED");
        /// <summary>
        /// Constant UNKNOWN for ConnectionState
        /// </summary>
        public static readonly ConnectionState UNKNOWN = new ConnectionState("UNKNOWN");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ConnectionState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ConnectionState FindValue(string value)
        {
            return FindValue<ConnectionState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ConnectionState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CustomImageProtocol.
    /// </summary>
    public class CustomImageProtocol : ConstantClass
    {

        /// <summary>
        /// Constant BYOP for CustomImageProtocol
        /// </summary>
        public static readonly CustomImageProtocol BYOP = new CustomImageProtocol("BYOP");
        /// <summary>
        /// Constant DCV for CustomImageProtocol
        /// </summary>
        public static readonly CustomImageProtocol DCV = new CustomImageProtocol("DCV");
        /// <summary>
        /// Constant PCOIP for CustomImageProtocol
        /// </summary>
        public static readonly CustomImageProtocol PCOIP = new CustomImageProtocol("PCOIP");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CustomImageProtocol(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CustomImageProtocol FindValue(string value)
        {
            return FindValue<CustomImageProtocol>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CustomImageProtocol(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CustomWorkspaceImageImportState.
    /// </summary>
    public class CustomWorkspaceImageImportState : ConstantClass
    {

        /// <summary>
        /// Constant COMPLETED for CustomWorkspaceImageImportState
        /// </summary>
        public static readonly CustomWorkspaceImageImportState COMPLETED = new CustomWorkspaceImageImportState("COMPLETED");
        /// <summary>
        /// Constant ERROR for CustomWorkspaceImageImportState
        /// </summary>
        public static readonly CustomWorkspaceImageImportState ERROR = new CustomWorkspaceImageImportState("ERROR");
        /// <summary>
        /// Constant IN_PROGRESS for CustomWorkspaceImageImportState
        /// </summary>
        public static readonly CustomWorkspaceImageImportState IN_PROGRESS = new CustomWorkspaceImageImportState("IN_PROGRESS");
        /// <summary>
        /// Constant PENDING for CustomWorkspaceImageImportState
        /// </summary>
        public static readonly CustomWorkspaceImageImportState PENDING = new CustomWorkspaceImageImportState("PENDING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CustomWorkspaceImageImportState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CustomWorkspaceImageImportState FindValue(string value)
        {
            return FindValue<CustomWorkspaceImageImportState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CustomWorkspaceImageImportState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DataReplication.
    /// </summary>
    public class DataReplication : ConstantClass
    {

        /// <summary>
        /// Constant NO_REPLICATION for DataReplication
        /// </summary>
        public static readonly DataReplication NO_REPLICATION = new DataReplication("NO_REPLICATION");
        /// <summary>
        /// Constant PRIMARY_AS_SOURCE for DataReplication
        /// </summary>
        public static readonly DataReplication PRIMARY_AS_SOURCE = new DataReplication("PRIMARY_AS_SOURCE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DataReplication(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DataReplication FindValue(string value)
        {
            return FindValue<DataReplication>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DataReplication(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DedicatedTenancyAccountType.
    /// </summary>
    public class DedicatedTenancyAccountType : ConstantClass
    {

        /// <summary>
        /// Constant SOURCE_ACCOUNT for DedicatedTenancyAccountType
        /// </summary>
        public static readonly DedicatedTenancyAccountType SOURCE_ACCOUNT = new DedicatedTenancyAccountType("SOURCE_ACCOUNT");
        /// <summary>
        /// Constant TARGET_ACCOUNT for DedicatedTenancyAccountType
        /// </summary>
        public static readonly DedicatedTenancyAccountType TARGET_ACCOUNT = new DedicatedTenancyAccountType("TARGET_ACCOUNT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DedicatedTenancyAccountType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DedicatedTenancyAccountType FindValue(string value)
        {
            return FindValue<DedicatedTenancyAccountType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DedicatedTenancyAccountType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DedicatedTenancyModificationStateEnum.
    /// </summary>
    public class DedicatedTenancyModificationStateEnum : ConstantClass
    {

        /// <summary>
        /// Constant COMPLETED for DedicatedTenancyModificationStateEnum
        /// </summary>
        public static readonly DedicatedTenancyModificationStateEnum COMPLETED = new DedicatedTenancyModificationStateEnum("COMPLETED");
        /// <summary>
        /// Constant FAILED for DedicatedTenancyModificationStateEnum
        /// </summary>
        public static readonly DedicatedTenancyModificationStateEnum FAILED = new DedicatedTenancyModificationStateEnum("FAILED");
        /// <summary>
        /// Constant PENDING for DedicatedTenancyModificationStateEnum
        /// </summary>
        public static readonly DedicatedTenancyModificationStateEnum PENDING = new DedicatedTenancyModificationStateEnum("PENDING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DedicatedTenancyModificationStateEnum(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DedicatedTenancyModificationStateEnum FindValue(string value)
        {
            return FindValue<DedicatedTenancyModificationStateEnum>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DedicatedTenancyModificationStateEnum(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DedicatedTenancySupportEnum.
    /// </summary>
    public class DedicatedTenancySupportEnum : ConstantClass
    {

        /// <summary>
        /// Constant ENABLED for DedicatedTenancySupportEnum
        /// </summary>
        public static readonly DedicatedTenancySupportEnum ENABLED = new DedicatedTenancySupportEnum("ENABLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DedicatedTenancySupportEnum(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DedicatedTenancySupportEnum FindValue(string value)
        {
            return FindValue<DedicatedTenancySupportEnum>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DedicatedTenancySupportEnum(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DedicatedTenancySupportResultEnum.
    /// </summary>
    public class DedicatedTenancySupportResultEnum : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for DedicatedTenancySupportResultEnum
        /// </summary>
        public static readonly DedicatedTenancySupportResultEnum DISABLED = new DedicatedTenancySupportResultEnum("DISABLED");
        /// <summary>
        /// Constant ENABLED for DedicatedTenancySupportResultEnum
        /// </summary>
        public static readonly DedicatedTenancySupportResultEnum ENABLED = new DedicatedTenancySupportResultEnum("ENABLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DedicatedTenancySupportResultEnum(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DedicatedTenancySupportResultEnum FindValue(string value)
        {
            return FindValue<DedicatedTenancySupportResultEnum>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DedicatedTenancySupportResultEnum(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DeletableCertificateBasedAuthProperty.
    /// </summary>
    public class DeletableCertificateBasedAuthProperty : ConstantClass
    {

        /// <summary>
        /// Constant CERTIFICATE_BASED_AUTH_PROPERTIES_CERTIFICATE_AUTHORITY_ARN for DeletableCertificateBasedAuthProperty
        /// </summary>
        public static readonly DeletableCertificateBasedAuthProperty CERTIFICATE_BASED_AUTH_PROPERTIES_CERTIFICATE_AUTHORITY_ARN = new DeletableCertificateBasedAuthProperty("CERTIFICATE_BASED_AUTH_PROPERTIES_CERTIFICATE_AUTHORITY_ARN");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DeletableCertificateBasedAuthProperty(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DeletableCertificateBasedAuthProperty FindValue(string value)
        {
            return FindValue<DeletableCertificateBasedAuthProperty>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DeletableCertificateBasedAuthProperty(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DeletableSamlProperty.
    /// </summary>
    public class DeletableSamlProperty : ConstantClass
    {

        /// <summary>
        /// Constant SAML_PROPERTIES_RELAY_STATE_PARAMETER_NAME for DeletableSamlProperty
        /// </summary>
        public static readonly DeletableSamlProperty SAML_PROPERTIES_RELAY_STATE_PARAMETER_NAME = new DeletableSamlProperty("SAML_PROPERTIES_RELAY_STATE_PARAMETER_NAME");
        /// <summary>
        /// Constant SAML_PROPERTIES_USER_ACCESS_URL for DeletableSamlProperty
        /// </summary>
        public static readonly DeletableSamlProperty SAML_PROPERTIES_USER_ACCESS_URL = new DeletableSamlProperty("SAML_PROPERTIES_USER_ACCESS_URL");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DeletableSamlProperty(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DeletableSamlProperty FindValue(string value)
        {
            return FindValue<DeletableSamlProperty>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DeletableSamlProperty(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DescribeWorkspaceDirectoriesFilterName.
    /// </summary>
    public class DescribeWorkspaceDirectoriesFilterName : ConstantClass
    {

        /// <summary>
        /// Constant USER_IDENTITY_TYPE for DescribeWorkspaceDirectoriesFilterName
        /// </summary>
        public static readonly DescribeWorkspaceDirectoriesFilterName USER_IDENTITY_TYPE = new DescribeWorkspaceDirectoriesFilterName("USER_IDENTITY_TYPE");
        /// <summary>
        /// Constant WORKSPACE_TYPE for DescribeWorkspaceDirectoriesFilterName
        /// </summary>
        public static readonly DescribeWorkspaceDirectoriesFilterName WORKSPACE_TYPE = new DescribeWorkspaceDirectoriesFilterName("WORKSPACE_TYPE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DescribeWorkspaceDirectoriesFilterName(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DescribeWorkspaceDirectoriesFilterName FindValue(string value)
        {
            return FindValue<DescribeWorkspaceDirectoriesFilterName>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DescribeWorkspaceDirectoriesFilterName(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DescribeWorkspacesPoolsFilterName.
    /// </summary>
    public class DescribeWorkspacesPoolsFilterName : ConstantClass
    {

        /// <summary>
        /// Constant PoolName for DescribeWorkspacesPoolsFilterName
        /// </summary>
        public static readonly DescribeWorkspacesPoolsFilterName PoolName = new DescribeWorkspacesPoolsFilterName("PoolName");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DescribeWorkspacesPoolsFilterName(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DescribeWorkspacesPoolsFilterName FindValue(string value)
        {
            return FindValue<DescribeWorkspacesPoolsFilterName>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DescribeWorkspacesPoolsFilterName(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DescribeWorkspacesPoolsFilterOperator.
    /// </summary>
    public class DescribeWorkspacesPoolsFilterOperator : ConstantClass
    {

        /// <summary>
        /// Constant CONTAINS for DescribeWorkspacesPoolsFilterOperator
        /// </summary>
        public static readonly DescribeWorkspacesPoolsFilterOperator CONTAINS = new DescribeWorkspacesPoolsFilterOperator("CONTAINS");
        /// <summary>
        /// Constant EQUALS for DescribeWorkspacesPoolsFilterOperator
        /// </summary>
        public static readonly DescribeWorkspacesPoolsFilterOperator EQUALS = new DescribeWorkspacesPoolsFilterOperator("EQUALS");
        /// <summary>
        /// Constant NOTCONTAINS for DescribeWorkspacesPoolsFilterOperator
        /// </summary>
        public static readonly DescribeWorkspacesPoolsFilterOperator NOTCONTAINS = new DescribeWorkspacesPoolsFilterOperator("NOTCONTAINS");
        /// <summary>
        /// Constant NOTEQUALS for DescribeWorkspacesPoolsFilterOperator
        /// </summary>
        public static readonly DescribeWorkspacesPoolsFilterOperator NOTEQUALS = new DescribeWorkspacesPoolsFilterOperator("NOTEQUALS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DescribeWorkspacesPoolsFilterOperator(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DescribeWorkspacesPoolsFilterOperator FindValue(string value)
        {
            return FindValue<DescribeWorkspacesPoolsFilterOperator>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DescribeWorkspacesPoolsFilterOperator(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type EndpointEncryptionMode.
    /// </summary>
    public class EndpointEncryptionMode : ConstantClass
    {

        /// <summary>
        /// Constant FIPS_VALIDATED for EndpointEncryptionMode
        /// </summary>
        public static readonly EndpointEncryptionMode FIPS_VALIDATED = new EndpointEncryptionMode("FIPS_VALIDATED");
        /// <summary>
        /// Constant STANDARD_TLS for EndpointEncryptionMode
        /// </summary>
        public static readonly EndpointEncryptionMode STANDARD_TLS = new EndpointEncryptionMode("STANDARD_TLS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EndpointEncryptionMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EndpointEncryptionMode FindValue(string value)
        {
            return FindValue<EndpointEncryptionMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EndpointEncryptionMode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ImageAssociatedResourceType.
    /// </summary>
    public class ImageAssociatedResourceType : ConstantClass
    {

        /// <summary>
        /// Constant APPLICATION for ImageAssociatedResourceType
        /// </summary>
        public static readonly ImageAssociatedResourceType APPLICATION = new ImageAssociatedResourceType("APPLICATION");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ImageAssociatedResourceType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ImageAssociatedResourceType FindValue(string value)
        {
            return FindValue<ImageAssociatedResourceType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ImageAssociatedResourceType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ImageComputeType.
    /// </summary>
    public class ImageComputeType : ConstantClass
    {

        /// <summary>
        /// Constant BASE for ImageComputeType
        /// </summary>
        public static readonly ImageComputeType BASE = new ImageComputeType("BASE");
        /// <summary>
        /// Constant GRAPHICS_G4DN for ImageComputeType
        /// </summary>
        public static readonly ImageComputeType GRAPHICS_G4DN = new ImageComputeType("GRAPHICS_G4DN");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ImageComputeType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ImageComputeType FindValue(string value)
        {
            return FindValue<ImageComputeType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ImageComputeType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ImageType.
    /// </summary>
    public class ImageType : ConstantClass
    {

        /// <summary>
        /// Constant OWNED for ImageType
        /// </summary>
        public static readonly ImageType OWNED = new ImageType("OWNED");
        /// <summary>
        /// Constant SHARED for ImageType
        /// </summary>
        public static readonly ImageType SHARED = new ImageType("SHARED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ImageType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ImageType FindValue(string value)
        {
            return FindValue<ImageType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ImageType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type InternetFallbackProtocol.
    /// </summary>
    public class InternetFallbackProtocol : ConstantClass
    {

        /// <summary>
        /// Constant PCOIP for InternetFallbackProtocol
        /// </summary>
        public static readonly InternetFallbackProtocol PCOIP = new InternetFallbackProtocol("PCOIP");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public InternetFallbackProtocol(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static InternetFallbackProtocol FindValue(string value)
        {
            return FindValue<InternetFallbackProtocol>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator InternetFallbackProtocol(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type LogUploadEnum.
    /// </summary>
    public class LogUploadEnum : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for LogUploadEnum
        /// </summary>
        public static readonly LogUploadEnum DISABLED = new LogUploadEnum("DISABLED");
        /// <summary>
        /// Constant ENABLED for LogUploadEnum
        /// </summary>
        public static readonly LogUploadEnum ENABLED = new LogUploadEnum("ENABLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public LogUploadEnum(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LogUploadEnum FindValue(string value)
        {
            return FindValue<LogUploadEnum>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator LogUploadEnum(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ModificationResourceEnum.
    /// </summary>
    public class ModificationResourceEnum : ConstantClass
    {

        /// <summary>
        /// Constant COMPUTE_TYPE for ModificationResourceEnum
        /// </summary>
        public static readonly ModificationResourceEnum COMPUTE_TYPE = new ModificationResourceEnum("COMPUTE_TYPE");
        /// <summary>
        /// Constant ROOT_VOLUME for ModificationResourceEnum
        /// </summary>
        public static readonly ModificationResourceEnum ROOT_VOLUME = new ModificationResourceEnum("ROOT_VOLUME");
        /// <summary>
        /// Constant USER_VOLUME for ModificationResourceEnum
        /// </summary>
        public static readonly ModificationResourceEnum USER_VOLUME = new ModificationResourceEnum("USER_VOLUME");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ModificationResourceEnum(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ModificationResourceEnum FindValue(string value)
        {
            return FindValue<ModificationResourceEnum>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ModificationResourceEnum(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ModificationStateEnum.
    /// </summary>
    public class ModificationStateEnum : ConstantClass
    {

        /// <summary>
        /// Constant UPDATE_IN_PROGRESS for ModificationStateEnum
        /// </summary>
        public static readonly ModificationStateEnum UPDATE_IN_PROGRESS = new ModificationStateEnum("UPDATE_IN_PROGRESS");
        /// <summary>
        /// Constant UPDATE_INITIATED for ModificationStateEnum
        /// </summary>
        public static readonly ModificationStateEnum UPDATE_INITIATED = new ModificationStateEnum("UPDATE_INITIATED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ModificationStateEnum(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ModificationStateEnum FindValue(string value)
        {
            return FindValue<ModificationStateEnum>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ModificationStateEnum(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type OperatingSystemName.
    /// </summary>
    public class OperatingSystemName : ConstantClass
    {

        /// <summary>
        /// Constant AMAZON_LINUX_2 for OperatingSystemName
        /// </summary>
        public static readonly OperatingSystemName AMAZON_LINUX_2 = new OperatingSystemName("AMAZON_LINUX_2");
        /// <summary>
        /// Constant RHEL_8 for OperatingSystemName
        /// </summary>
        public static readonly OperatingSystemName RHEL_8 = new OperatingSystemName("RHEL_8");
        /// <summary>
        /// Constant ROCKY_8 for OperatingSystemName
        /// </summary>
        public static readonly OperatingSystemName ROCKY_8 = new OperatingSystemName("ROCKY_8");
        /// <summary>
        /// Constant UBUNTU_18_04 for OperatingSystemName
        /// </summary>
        public static readonly OperatingSystemName UBUNTU_18_04 = new OperatingSystemName("UBUNTU_18_04");
        /// <summary>
        /// Constant UBUNTU_20_04 for OperatingSystemName
        /// </summary>
        public static readonly OperatingSystemName UBUNTU_20_04 = new OperatingSystemName("UBUNTU_20_04");
        /// <summary>
        /// Constant UBUNTU_22_04 for OperatingSystemName
        /// </summary>
        public static readonly OperatingSystemName UBUNTU_22_04 = new OperatingSystemName("UBUNTU_22_04");
        /// <summary>
        /// Constant UNKNOWN for OperatingSystemName
        /// </summary>
        public static readonly OperatingSystemName UNKNOWN = new OperatingSystemName("UNKNOWN");
        /// <summary>
        /// Constant WINDOWS_10 for OperatingSystemName
        /// </summary>
        public static readonly OperatingSystemName WINDOWS_10 = new OperatingSystemName("WINDOWS_10");
        /// <summary>
        /// Constant WINDOWS_11 for OperatingSystemName
        /// </summary>
        public static readonly OperatingSystemName WINDOWS_11 = new OperatingSystemName("WINDOWS_11");
        /// <summary>
        /// Constant WINDOWS_7 for OperatingSystemName
        /// </summary>
        public static readonly OperatingSystemName WINDOWS_7 = new OperatingSystemName("WINDOWS_7");
        /// <summary>
        /// Constant WINDOWS_SERVER_2016 for OperatingSystemName
        /// </summary>
        public static readonly OperatingSystemName WINDOWS_SERVER_2016 = new OperatingSystemName("WINDOWS_SERVER_2016");
        /// <summary>
        /// Constant WINDOWS_SERVER_2019 for OperatingSystemName
        /// </summary>
        public static readonly OperatingSystemName WINDOWS_SERVER_2019 = new OperatingSystemName("WINDOWS_SERVER_2019");
        /// <summary>
        /// Constant WINDOWS_SERVER_2022 for OperatingSystemName
        /// </summary>
        public static readonly OperatingSystemName WINDOWS_SERVER_2022 = new OperatingSystemName("WINDOWS_SERVER_2022");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public OperatingSystemName(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static OperatingSystemName FindValue(string value)
        {
            return FindValue<OperatingSystemName>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator OperatingSystemName(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type OperatingSystemType.
    /// </summary>
    public class OperatingSystemType : ConstantClass
    {

        /// <summary>
        /// Constant LINUX for OperatingSystemType
        /// </summary>
        public static readonly OperatingSystemType LINUX = new OperatingSystemType("LINUX");
        /// <summary>
        /// Constant WINDOWS for OperatingSystemType
        /// </summary>
        public static readonly OperatingSystemType WINDOWS = new OperatingSystemType("WINDOWS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public OperatingSystemType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static OperatingSystemType FindValue(string value)
        {
            return FindValue<OperatingSystemType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator OperatingSystemType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type OSVersion.
    /// </summary>
    public class OSVersion : ConstantClass
    {

        /// <summary>
        /// Constant Windows_10 for OSVersion
        /// </summary>
        public static readonly OSVersion Windows_10 = new OSVersion("Windows_10");
        /// <summary>
        /// Constant Windows_11 for OSVersion
        /// </summary>
        public static readonly OSVersion Windows_11 = new OSVersion("Windows_11");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public OSVersion(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static OSVersion FindValue(string value)
        {
            return FindValue<OSVersion>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator OSVersion(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Platform.
    /// </summary>
    public class Platform : ConstantClass
    {

        /// <summary>
        /// Constant WINDOWS for Platform
        /// </summary>
        public static readonly Platform WINDOWS = new Platform("WINDOWS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Platform(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Platform FindValue(string value)
        {
            return FindValue<Platform>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Platform(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PoolsRunningMode.
    /// </summary>
    public class PoolsRunningMode : ConstantClass
    {

        /// <summary>
        /// Constant ALWAYS_ON for PoolsRunningMode
        /// </summary>
        public static readonly PoolsRunningMode ALWAYS_ON = new PoolsRunningMode("ALWAYS_ON");
        /// <summary>
        /// Constant AUTO_STOP for PoolsRunningMode
        /// </summary>
        public static readonly PoolsRunningMode AUTO_STOP = new PoolsRunningMode("AUTO_STOP");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PoolsRunningMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PoolsRunningMode FindValue(string value)
        {
            return FindValue<PoolsRunningMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PoolsRunningMode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Protocol.
    /// </summary>
    public class Protocol : ConstantClass
    {

        /// <summary>
        /// Constant PCOIP for Protocol
        /// </summary>
        public static readonly Protocol PCOIP = new Protocol("PCOIP");
        /// <summary>
        /// Constant WSP for Protocol
        /// </summary>
        public static readonly Protocol WSP = new Protocol("WSP");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Protocol(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Protocol FindValue(string value)
        {
            return FindValue<Protocol>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Protocol(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ReconnectEnum.
    /// </summary>
    public class ReconnectEnum : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for ReconnectEnum
        /// </summary>
        public static readonly ReconnectEnum DISABLED = new ReconnectEnum("DISABLED");
        /// <summary>
        /// Constant ENABLED for ReconnectEnum
        /// </summary>
        public static readonly ReconnectEnum ENABLED = new ReconnectEnum("ENABLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ReconnectEnum(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ReconnectEnum FindValue(string value)
        {
            return FindValue<ReconnectEnum>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ReconnectEnum(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RunningMode.
    /// </summary>
    public class RunningMode : ConstantClass
    {

        /// <summary>
        /// Constant ALWAYS_ON for RunningMode
        /// </summary>
        public static readonly RunningMode ALWAYS_ON = new RunningMode("ALWAYS_ON");
        /// <summary>
        /// Constant AUTO_STOP for RunningMode
        /// </summary>
        public static readonly RunningMode AUTO_STOP = new RunningMode("AUTO_STOP");
        /// <summary>
        /// Constant MANUAL for RunningMode
        /// </summary>
        public static readonly RunningMode MANUAL = new RunningMode("MANUAL");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RunningMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RunningMode FindValue(string value)
        {
            return FindValue<RunningMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RunningMode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SamlStatusEnum.
    /// </summary>
    public class SamlStatusEnum : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for SamlStatusEnum
        /// </summary>
        public static readonly SamlStatusEnum DISABLED = new SamlStatusEnum("DISABLED");
        /// <summary>
        /// Constant ENABLED for SamlStatusEnum
        /// </summary>
        public static readonly SamlStatusEnum ENABLED = new SamlStatusEnum("ENABLED");
        /// <summary>
        /// Constant ENABLED_WITH_DIRECTORY_LOGIN_FALLBACK for SamlStatusEnum
        /// </summary>
        public static readonly SamlStatusEnum ENABLED_WITH_DIRECTORY_LOGIN_FALLBACK = new SamlStatusEnum("ENABLED_WITH_DIRECTORY_LOGIN_FALLBACK");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SamlStatusEnum(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SamlStatusEnum FindValue(string value)
        {
            return FindValue<SamlStatusEnum>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SamlStatusEnum(string value)
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
    /// Constants used for properties of type StandbyWorkspaceRelationshipType.
    /// </summary>
    public class StandbyWorkspaceRelationshipType : ConstantClass
    {

        /// <summary>
        /// Constant PRIMARY for StandbyWorkspaceRelationshipType
        /// </summary>
        public static readonly StandbyWorkspaceRelationshipType PRIMARY = new StandbyWorkspaceRelationshipType("PRIMARY");
        /// <summary>
        /// Constant STANDBY for StandbyWorkspaceRelationshipType
        /// </summary>
        public static readonly StandbyWorkspaceRelationshipType STANDBY = new StandbyWorkspaceRelationshipType("STANDBY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public StandbyWorkspaceRelationshipType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static StandbyWorkspaceRelationshipType FindValue(string value)
        {
            return FindValue<StandbyWorkspaceRelationshipType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator StandbyWorkspaceRelationshipType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type StorageConnectorStatusEnum.
    /// </summary>
    public class StorageConnectorStatusEnum : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for StorageConnectorStatusEnum
        /// </summary>
        public static readonly StorageConnectorStatusEnum DISABLED = new StorageConnectorStatusEnum("DISABLED");
        /// <summary>
        /// Constant ENABLED for StorageConnectorStatusEnum
        /// </summary>
        public static readonly StorageConnectorStatusEnum ENABLED = new StorageConnectorStatusEnum("ENABLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public StorageConnectorStatusEnum(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static StorageConnectorStatusEnum FindValue(string value)
        {
            return FindValue<StorageConnectorStatusEnum>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator StorageConnectorStatusEnum(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type StorageConnectorTypeEnum.
    /// </summary>
    public class StorageConnectorTypeEnum : ConstantClass
    {

        /// <summary>
        /// Constant HOME_FOLDER for StorageConnectorTypeEnum
        /// </summary>
        public static readonly StorageConnectorTypeEnum HOME_FOLDER = new StorageConnectorTypeEnum("HOME_FOLDER");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public StorageConnectorTypeEnum(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static StorageConnectorTypeEnum FindValue(string value)
        {
            return FindValue<StorageConnectorTypeEnum>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator StorageConnectorTypeEnum(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type StreamingExperiencePreferredProtocolEnum.
    /// </summary>
    public class StreamingExperiencePreferredProtocolEnum : ConstantClass
    {

        /// <summary>
        /// Constant TCP for StreamingExperiencePreferredProtocolEnum
        /// </summary>
        public static readonly StreamingExperiencePreferredProtocolEnum TCP = new StreamingExperiencePreferredProtocolEnum("TCP");
        /// <summary>
        /// Constant UDP for StreamingExperiencePreferredProtocolEnum
        /// </summary>
        public static readonly StreamingExperiencePreferredProtocolEnum UDP = new StreamingExperiencePreferredProtocolEnum("UDP");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public StreamingExperiencePreferredProtocolEnum(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static StreamingExperiencePreferredProtocolEnum FindValue(string value)
        {
            return FindValue<StreamingExperiencePreferredProtocolEnum>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator StreamingExperiencePreferredProtocolEnum(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TargetWorkspaceState.
    /// </summary>
    public class TargetWorkspaceState : ConstantClass
    {

        /// <summary>
        /// Constant ADMIN_MAINTENANCE for TargetWorkspaceState
        /// </summary>
        public static readonly TargetWorkspaceState ADMIN_MAINTENANCE = new TargetWorkspaceState("ADMIN_MAINTENANCE");
        /// <summary>
        /// Constant AVAILABLE for TargetWorkspaceState
        /// </summary>
        public static readonly TargetWorkspaceState AVAILABLE = new TargetWorkspaceState("AVAILABLE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TargetWorkspaceState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TargetWorkspaceState FindValue(string value)
        {
            return FindValue<TargetWorkspaceState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TargetWorkspaceState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Tenancy.
    /// </summary>
    public class Tenancy : ConstantClass
    {

        /// <summary>
        /// Constant DEDICATED for Tenancy
        /// </summary>
        public static readonly Tenancy DEDICATED = new Tenancy("DEDICATED");
        /// <summary>
        /// Constant SHARED for Tenancy
        /// </summary>
        public static readonly Tenancy SHARED = new Tenancy("SHARED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Tenancy(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Tenancy FindValue(string value)
        {
            return FindValue<Tenancy>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Tenancy(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type UserIdentityType.
    /// </summary>
    public class UserIdentityType : ConstantClass
    {

        /// <summary>
        /// Constant AWS_DIRECTORY_SERVICE for UserIdentityType
        /// </summary>
        public static readonly UserIdentityType AWS_DIRECTORY_SERVICE = new UserIdentityType("AWS_DIRECTORY_SERVICE");
        /// <summary>
        /// Constant AWS_IAM_IDENTITY_CENTER for UserIdentityType
        /// </summary>
        public static readonly UserIdentityType AWS_IAM_IDENTITY_CENTER = new UserIdentityType("AWS_IAM_IDENTITY_CENTER");
        /// <summary>
        /// Constant CUSTOMER_MANAGED for UserIdentityType
        /// </summary>
        public static readonly UserIdentityType CUSTOMER_MANAGED = new UserIdentityType("CUSTOMER_MANAGED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public UserIdentityType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static UserIdentityType FindValue(string value)
        {
            return FindValue<UserIdentityType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator UserIdentityType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type UserSettingActionEnum.
    /// </summary>
    public class UserSettingActionEnum : ConstantClass
    {

        /// <summary>
        /// Constant CLIPBOARD_COPY_FROM_LOCAL_DEVICE for UserSettingActionEnum
        /// </summary>
        public static readonly UserSettingActionEnum CLIPBOARD_COPY_FROM_LOCAL_DEVICE = new UserSettingActionEnum("CLIPBOARD_COPY_FROM_LOCAL_DEVICE");
        /// <summary>
        /// Constant CLIPBOARD_COPY_TO_LOCAL_DEVICE for UserSettingActionEnum
        /// </summary>
        public static readonly UserSettingActionEnum CLIPBOARD_COPY_TO_LOCAL_DEVICE = new UserSettingActionEnum("CLIPBOARD_COPY_TO_LOCAL_DEVICE");
        /// <summary>
        /// Constant PRINTING_TO_LOCAL_DEVICE for UserSettingActionEnum
        /// </summary>
        public static readonly UserSettingActionEnum PRINTING_TO_LOCAL_DEVICE = new UserSettingActionEnum("PRINTING_TO_LOCAL_DEVICE");
        /// <summary>
        /// Constant SMART_CARD for UserSettingActionEnum
        /// </summary>
        public static readonly UserSettingActionEnum SMART_CARD = new UserSettingActionEnum("SMART_CARD");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public UserSettingActionEnum(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static UserSettingActionEnum FindValue(string value)
        {
            return FindValue<UserSettingActionEnum>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator UserSettingActionEnum(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type UserSettingPermissionEnum.
    /// </summary>
    public class UserSettingPermissionEnum : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for UserSettingPermissionEnum
        /// </summary>
        public static readonly UserSettingPermissionEnum DISABLED = new UserSettingPermissionEnum("DISABLED");
        /// <summary>
        /// Constant ENABLED for UserSettingPermissionEnum
        /// </summary>
        public static readonly UserSettingPermissionEnum ENABLED = new UserSettingPermissionEnum("ENABLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public UserSettingPermissionEnum(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static UserSettingPermissionEnum FindValue(string value)
        {
            return FindValue<UserSettingPermissionEnum>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator UserSettingPermissionEnum(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type WorkSpaceApplicationLicenseType.
    /// </summary>
    public class WorkSpaceApplicationLicenseType : ConstantClass
    {

        /// <summary>
        /// Constant LICENSED for WorkSpaceApplicationLicenseType
        /// </summary>
        public static readonly WorkSpaceApplicationLicenseType LICENSED = new WorkSpaceApplicationLicenseType("LICENSED");
        /// <summary>
        /// Constant UNLICENSED for WorkSpaceApplicationLicenseType
        /// </summary>
        public static readonly WorkSpaceApplicationLicenseType UNLICENSED = new WorkSpaceApplicationLicenseType("UNLICENSED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public WorkSpaceApplicationLicenseType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static WorkSpaceApplicationLicenseType FindValue(string value)
        {
            return FindValue<WorkSpaceApplicationLicenseType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator WorkSpaceApplicationLicenseType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type WorkSpaceApplicationState.
    /// </summary>
    public class WorkSpaceApplicationState : ConstantClass
    {

        /// <summary>
        /// Constant AVAILABLE for WorkSpaceApplicationState
        /// </summary>
        public static readonly WorkSpaceApplicationState AVAILABLE = new WorkSpaceApplicationState("AVAILABLE");
        /// <summary>
        /// Constant ERROR for WorkSpaceApplicationState
        /// </summary>
        public static readonly WorkSpaceApplicationState ERROR = new WorkSpaceApplicationState("ERROR");
        /// <summary>
        /// Constant PENDING for WorkSpaceApplicationState
        /// </summary>
        public static readonly WorkSpaceApplicationState PENDING = new WorkSpaceApplicationState("PENDING");
        /// <summary>
        /// Constant UNINSTALL_ONLY for WorkSpaceApplicationState
        /// </summary>
        public static readonly WorkSpaceApplicationState UNINSTALL_ONLY = new WorkSpaceApplicationState("UNINSTALL_ONLY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public WorkSpaceApplicationState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static WorkSpaceApplicationState FindValue(string value)
        {
            return FindValue<WorkSpaceApplicationState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator WorkSpaceApplicationState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type WorkSpaceAssociatedResourceType.
    /// </summary>
    public class WorkSpaceAssociatedResourceType : ConstantClass
    {

        /// <summary>
        /// Constant APPLICATION for WorkSpaceAssociatedResourceType
        /// </summary>
        public static readonly WorkSpaceAssociatedResourceType APPLICATION = new WorkSpaceAssociatedResourceType("APPLICATION");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public WorkSpaceAssociatedResourceType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static WorkSpaceAssociatedResourceType FindValue(string value)
        {
            return FindValue<WorkSpaceAssociatedResourceType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator WorkSpaceAssociatedResourceType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type WorkspaceBundleState.
    /// </summary>
    public class WorkspaceBundleState : ConstantClass
    {

        /// <summary>
        /// Constant AVAILABLE for WorkspaceBundleState
        /// </summary>
        public static readonly WorkspaceBundleState AVAILABLE = new WorkspaceBundleState("AVAILABLE");
        /// <summary>
        /// Constant ERROR for WorkspaceBundleState
        /// </summary>
        public static readonly WorkspaceBundleState ERROR = new WorkspaceBundleState("ERROR");
        /// <summary>
        /// Constant PENDING for WorkspaceBundleState
        /// </summary>
        public static readonly WorkspaceBundleState PENDING = new WorkspaceBundleState("PENDING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public WorkspaceBundleState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static WorkspaceBundleState FindValue(string value)
        {
            return FindValue<WorkspaceBundleState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator WorkspaceBundleState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type WorkspaceDirectoryState.
    /// </summary>
    public class WorkspaceDirectoryState : ConstantClass
    {

        /// <summary>
        /// Constant DEREGISTERED for WorkspaceDirectoryState
        /// </summary>
        public static readonly WorkspaceDirectoryState DEREGISTERED = new WorkspaceDirectoryState("DEREGISTERED");
        /// <summary>
        /// Constant DEREGISTERING for WorkspaceDirectoryState
        /// </summary>
        public static readonly WorkspaceDirectoryState DEREGISTERING = new WorkspaceDirectoryState("DEREGISTERING");
        /// <summary>
        /// Constant ERROR for WorkspaceDirectoryState
        /// </summary>
        public static readonly WorkspaceDirectoryState ERROR = new WorkspaceDirectoryState("ERROR");
        /// <summary>
        /// Constant REGISTERED for WorkspaceDirectoryState
        /// </summary>
        public static readonly WorkspaceDirectoryState REGISTERED = new WorkspaceDirectoryState("REGISTERED");
        /// <summary>
        /// Constant REGISTERING for WorkspaceDirectoryState
        /// </summary>
        public static readonly WorkspaceDirectoryState REGISTERING = new WorkspaceDirectoryState("REGISTERING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public WorkspaceDirectoryState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static WorkspaceDirectoryState FindValue(string value)
        {
            return FindValue<WorkspaceDirectoryState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator WorkspaceDirectoryState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type WorkspaceDirectoryType.
    /// </summary>
    public class WorkspaceDirectoryType : ConstantClass
    {

        /// <summary>
        /// Constant AD_CONNECTOR for WorkspaceDirectoryType
        /// </summary>
        public static readonly WorkspaceDirectoryType AD_CONNECTOR = new WorkspaceDirectoryType("AD_CONNECTOR");
        /// <summary>
        /// Constant AWS_IAM_IDENTITY_CENTER for WorkspaceDirectoryType
        /// </summary>
        public static readonly WorkspaceDirectoryType AWS_IAM_IDENTITY_CENTER = new WorkspaceDirectoryType("AWS_IAM_IDENTITY_CENTER");
        /// <summary>
        /// Constant CUSTOMER_MANAGED for WorkspaceDirectoryType
        /// </summary>
        public static readonly WorkspaceDirectoryType CUSTOMER_MANAGED = new WorkspaceDirectoryType("CUSTOMER_MANAGED");
        /// <summary>
        /// Constant SIMPLE_AD for WorkspaceDirectoryType
        /// </summary>
        public static readonly WorkspaceDirectoryType SIMPLE_AD = new WorkspaceDirectoryType("SIMPLE_AD");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public WorkspaceDirectoryType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static WorkspaceDirectoryType FindValue(string value)
        {
            return FindValue<WorkspaceDirectoryType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator WorkspaceDirectoryType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type WorkspaceImageErrorDetailCode.
    /// </summary>
    public class WorkspaceImageErrorDetailCode : ConstantClass
    {

        /// <summary>
        /// Constant AdditionalDrivesAttached for WorkspaceImageErrorDetailCode
        /// </summary>
        public static readonly WorkspaceImageErrorDetailCode AdditionalDrivesAttached = new WorkspaceImageErrorDetailCode("AdditionalDrivesAttached");
        /// <summary>
        /// Constant AdditionalDrivesPresent for WorkspaceImageErrorDetailCode
        /// </summary>
        public static readonly WorkspaceImageErrorDetailCode AdditionalDrivesPresent = new WorkspaceImageErrorDetailCode("AdditionalDrivesPresent");
        /// <summary>
        /// Constant AmazonSsmAgentEnabled for WorkspaceImageErrorDetailCode
        /// </summary>
        public static readonly WorkspaceImageErrorDetailCode AmazonSsmAgentEnabled = new WorkspaceImageErrorDetailCode("AmazonSsmAgentEnabled");
        /// <summary>
        /// Constant AntiVirusInstalled for WorkspaceImageErrorDetailCode
        /// </summary>
        public static readonly WorkspaceImageErrorDetailCode AntiVirusInstalled = new WorkspaceImageErrorDetailCode("AntiVirusInstalled");
        /// <summary>
        /// Constant AppXPackagesInstalled for WorkspaceImageErrorDetailCode
        /// </summary>
        public static readonly WorkspaceImageErrorDetailCode AppXPackagesInstalled = new WorkspaceImageErrorDetailCode("AppXPackagesInstalled");
        /// <summary>
        /// Constant AutoLogonEnabled for WorkspaceImageErrorDetailCode
        /// </summary>
        public static readonly WorkspaceImageErrorDetailCode AutoLogonEnabled = new WorkspaceImageErrorDetailCode("AutoLogonEnabled");
        /// <summary>
        /// Constant AutoMountDisabled for WorkspaceImageErrorDetailCode
        /// </summary>
        public static readonly WorkspaceImageErrorDetailCode AutoMountDisabled = new WorkspaceImageErrorDetailCode("AutoMountDisabled");
        /// <summary>
        /// Constant AzureDomainJoined for WorkspaceImageErrorDetailCode
        /// </summary>
        public static readonly WorkspaceImageErrorDetailCode AzureDomainJoined = new WorkspaceImageErrorDetailCode("AzureDomainJoined");
        /// <summary>
        /// Constant DHCPDisabled for WorkspaceImageErrorDetailCode
        /// </summary>
        public static readonly WorkspaceImageErrorDetailCode DHCPDisabled = new WorkspaceImageErrorDetailCode("DHCPDisabled");
        /// <summary>
        /// Constant DiskFreeSpace for WorkspaceImageErrorDetailCode
        /// </summary>
        public static readonly WorkspaceImageErrorDetailCode DiskFreeSpace = new WorkspaceImageErrorDetailCode("DiskFreeSpace");
        /// <summary>
        /// Constant DiskSizeExceeded for WorkspaceImageErrorDetailCode
        /// </summary>
        public static readonly WorkspaceImageErrorDetailCode DiskSizeExceeded = new WorkspaceImageErrorDetailCode("DiskSizeExceeded");
        /// <summary>
        /// Constant DomainAccountServicesFound for WorkspaceImageErrorDetailCode
        /// </summary>
        public static readonly WorkspaceImageErrorDetailCode DomainAccountServicesFound = new WorkspaceImageErrorDetailCode("DomainAccountServicesFound");
        /// <summary>
        /// Constant DomainJoined for WorkspaceImageErrorDetailCode
        /// </summary>
        public static readonly WorkspaceImageErrorDetailCode DomainJoined = new WorkspaceImageErrorDetailCode("DomainJoined");
        /// <summary>
        /// Constant EnvironmentVariablesPathMissingEntries for WorkspaceImageErrorDetailCode
        /// </summary>
        public static readonly WorkspaceImageErrorDetailCode EnvironmentVariablesPathMissingEntries = new WorkspaceImageErrorDetailCode("EnvironmentVariablesPathMissingEntries");
        /// <summary>
        /// Constant FirewallEnabled for WorkspaceImageErrorDetailCode
        /// </summary>
        public static readonly WorkspaceImageErrorDetailCode FirewallEnabled = new WorkspaceImageErrorDetailCode("FirewallEnabled");
        /// <summary>
        /// Constant IncompatiblePartitioning for WorkspaceImageErrorDetailCode
        /// </summary>
        public static readonly WorkspaceImageErrorDetailCode IncompatiblePartitioning = new WorkspaceImageErrorDetailCode("IncompatiblePartitioning");
        /// <summary>
        /// Constant InPlaceUpgrade for WorkspaceImageErrorDetailCode
        /// </summary>
        public static readonly WorkspaceImageErrorDetailCode InPlaceUpgrade = new WorkspaceImageErrorDetailCode("InPlaceUpgrade");
        /// <summary>
        /// Constant InsufficientDiskSpace for WorkspaceImageErrorDetailCode
        /// </summary>
        public static readonly WorkspaceImageErrorDetailCode InsufficientDiskSpace = new WorkspaceImageErrorDetailCode("InsufficientDiskSpace");
        /// <summary>
        /// Constant InsufficientRearmCount for WorkspaceImageErrorDetailCode
        /// </summary>
        public static readonly WorkspaceImageErrorDetailCode InsufficientRearmCount = new WorkspaceImageErrorDetailCode("InsufficientRearmCount");
        /// <summary>
        /// Constant InvalidIp for WorkspaceImageErrorDetailCode
        /// </summary>
        public static readonly WorkspaceImageErrorDetailCode InvalidIp = new WorkspaceImageErrorDetailCode("InvalidIp");
        /// <summary>
        /// Constant MemoryIntegrityIncompatibility for WorkspaceImageErrorDetailCode
        /// </summary>
        public static readonly WorkspaceImageErrorDetailCode MemoryIntegrityIncompatibility = new WorkspaceImageErrorDetailCode("MemoryIntegrityIncompatibility");
        /// <summary>
        /// Constant MultipleBootPartition for WorkspaceImageErrorDetailCode
        /// </summary>
        public static readonly WorkspaceImageErrorDetailCode MultipleBootPartition = new WorkspaceImageErrorDetailCode("MultipleBootPartition");
        /// <summary>
        /// Constant MultipleUserProfiles for WorkspaceImageErrorDetailCode
        /// </summary>
        public static readonly WorkspaceImageErrorDetailCode MultipleUserProfiles = new WorkspaceImageErrorDetailCode("MultipleUserProfiles");
        /// <summary>
        /// Constant OfficeInstalled for WorkspaceImageErrorDetailCode
        /// </summary>
        public static readonly WorkspaceImageErrorDetailCode OfficeInstalled = new WorkspaceImageErrorDetailCode("OfficeInstalled");
        /// <summary>
        /// Constant OSNotSupported for WorkspaceImageErrorDetailCode
        /// </summary>
        public static readonly WorkspaceImageErrorDetailCode OSNotSupported = new WorkspaceImageErrorDetailCode("OSNotSupported");
        /// <summary>
        /// Constant OutdatedPowershellVersion for WorkspaceImageErrorDetailCode
        /// </summary>
        public static readonly WorkspaceImageErrorDetailCode OutdatedPowershellVersion = new WorkspaceImageErrorDetailCode("OutdatedPowershellVersion");
        /// <summary>
        /// Constant PCoIPAgentInstalled for WorkspaceImageErrorDetailCode
        /// </summary>
        public static readonly WorkspaceImageErrorDetailCode PCoIPAgentInstalled = new WorkspaceImageErrorDetailCode("PCoIPAgentInstalled");
        /// <summary>
        /// Constant PendingReboot for WorkspaceImageErrorDetailCode
        /// </summary>
        public static readonly WorkspaceImageErrorDetailCode PendingReboot = new WorkspaceImageErrorDetailCode("PendingReboot");
        /// <summary>
        /// Constant ProtocolOSIncompatibility for WorkspaceImageErrorDetailCode
        /// </summary>
        public static readonly WorkspaceImageErrorDetailCode ProtocolOSIncompatibility = new WorkspaceImageErrorDetailCode("ProtocolOSIncompatibility");
        /// <summary>
        /// Constant RealTimeUniversalDisabled for WorkspaceImageErrorDetailCode
        /// </summary>
        public static readonly WorkspaceImageErrorDetailCode RealTimeUniversalDisabled = new WorkspaceImageErrorDetailCode("RealTimeUniversalDisabled");
        /// <summary>
        /// Constant RemoteDesktopServicesDisabled for WorkspaceImageErrorDetailCode
        /// </summary>
        public static readonly WorkspaceImageErrorDetailCode RemoteDesktopServicesDisabled = new WorkspaceImageErrorDetailCode("RemoteDesktopServicesDisabled");
        /// <summary>
        /// Constant Requires64BitOS for WorkspaceImageErrorDetailCode
        /// </summary>
        public static readonly WorkspaceImageErrorDetailCode Requires64BitOS = new WorkspaceImageErrorDetailCode("Requires64BitOS");
        /// <summary>
        /// Constant ReservedStorageInUse for WorkspaceImageErrorDetailCode
        /// </summary>
        public static readonly WorkspaceImageErrorDetailCode ReservedStorageInUse = new WorkspaceImageErrorDetailCode("ReservedStorageInUse");
        /// <summary>
        /// Constant RestrictedDriveLetterInUse for WorkspaceImageErrorDetailCode
        /// </summary>
        public static readonly WorkspaceImageErrorDetailCode RestrictedDriveLetterInUse = new WorkspaceImageErrorDetailCode("RestrictedDriveLetterInUse");
        /// <summary>
        /// Constant StagedAppxPackage for WorkspaceImageErrorDetailCode
        /// </summary>
        public static readonly WorkspaceImageErrorDetailCode StagedAppxPackage = new WorkspaceImageErrorDetailCode("StagedAppxPackage");
        /// <summary>
        /// Constant SysPrepFileMissing for WorkspaceImageErrorDetailCode
        /// </summary>
        public static readonly WorkspaceImageErrorDetailCode SysPrepFileMissing = new WorkspaceImageErrorDetailCode("SysPrepFileMissing");
        /// <summary>
        /// Constant UEFINotSupported for WorkspaceImageErrorDetailCode
        /// </summary>
        public static readonly WorkspaceImageErrorDetailCode UEFINotSupported = new WorkspaceImageErrorDetailCode("UEFINotSupported");
        /// <summary>
        /// Constant UnknownError for WorkspaceImageErrorDetailCode
        /// </summary>
        public static readonly WorkspaceImageErrorDetailCode UnknownError = new WorkspaceImageErrorDetailCode("UnknownError");
        /// <summary>
        /// Constant UnsupportedOsUpgrade for WorkspaceImageErrorDetailCode
        /// </summary>
        public static readonly WorkspaceImageErrorDetailCode UnsupportedOsUpgrade = new WorkspaceImageErrorDetailCode("UnsupportedOsUpgrade");
        /// <summary>
        /// Constant UnsupportedSecurityProtocol for WorkspaceImageErrorDetailCode
        /// </summary>
        public static readonly WorkspaceImageErrorDetailCode UnsupportedSecurityProtocol = new WorkspaceImageErrorDetailCode("UnsupportedSecurityProtocol");
        /// <summary>
        /// Constant UserProfileMissing for WorkspaceImageErrorDetailCode
        /// </summary>
        public static readonly WorkspaceImageErrorDetailCode UserProfileMissing = new WorkspaceImageErrorDetailCode("UserProfileMissing");
        /// <summary>
        /// Constant VMWareToolsInstalled for WorkspaceImageErrorDetailCode
        /// </summary>
        public static readonly WorkspaceImageErrorDetailCode VMWareToolsInstalled = new WorkspaceImageErrorDetailCode("VMWareToolsInstalled");
        /// <summary>
        /// Constant WindowsModulesInstallerDisabled for WorkspaceImageErrorDetailCode
        /// </summary>
        public static readonly WorkspaceImageErrorDetailCode WindowsModulesInstallerDisabled = new WorkspaceImageErrorDetailCode("WindowsModulesInstallerDisabled");
        /// <summary>
        /// Constant WindowsUpdatesEnabled for WorkspaceImageErrorDetailCode
        /// </summary>
        public static readonly WorkspaceImageErrorDetailCode WindowsUpdatesEnabled = new WorkspaceImageErrorDetailCode("WindowsUpdatesEnabled");
        /// <summary>
        /// Constant WindowsUpdatesRequired for WorkspaceImageErrorDetailCode
        /// </summary>
        public static readonly WorkspaceImageErrorDetailCode WindowsUpdatesRequired = new WorkspaceImageErrorDetailCode("WindowsUpdatesRequired");
        /// <summary>
        /// Constant WorkspacesBYOLAccountDisabled for WorkspaceImageErrorDetailCode
        /// </summary>
        public static readonly WorkspaceImageErrorDetailCode WorkspacesBYOLAccountDisabled = new WorkspaceImageErrorDetailCode("WorkspacesBYOLAccountDisabled");
        /// <summary>
        /// Constant WorkspacesBYOLAccountNotFound for WorkspaceImageErrorDetailCode
        /// </summary>
        public static readonly WorkspaceImageErrorDetailCode WorkspacesBYOLAccountNotFound = new WorkspaceImageErrorDetailCode("WorkspacesBYOLAccountNotFound");
        /// <summary>
        /// Constant ZeroRearmCount for WorkspaceImageErrorDetailCode
        /// </summary>
        public static readonly WorkspaceImageErrorDetailCode ZeroRearmCount = new WorkspaceImageErrorDetailCode("ZeroRearmCount");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public WorkspaceImageErrorDetailCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static WorkspaceImageErrorDetailCode FindValue(string value)
        {
            return FindValue<WorkspaceImageErrorDetailCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator WorkspaceImageErrorDetailCode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type WorkspaceImageIngestionProcess.
    /// </summary>
    public class WorkspaceImageIngestionProcess : ConstantClass
    {

        /// <summary>
        /// Constant BYOL_GRAPHICS for WorkspaceImageIngestionProcess
        /// </summary>
        public static readonly WorkspaceImageIngestionProcess BYOL_GRAPHICS = new WorkspaceImageIngestionProcess("BYOL_GRAPHICS");
        /// <summary>
        /// Constant BYOL_GRAPHICS_G4DN for WorkspaceImageIngestionProcess
        /// </summary>
        public static readonly WorkspaceImageIngestionProcess BYOL_GRAPHICS_G4DN = new WorkspaceImageIngestionProcess("BYOL_GRAPHICS_G4DN");
        /// <summary>
        /// Constant BYOL_GRAPHICS_G4DN_BYOP for WorkspaceImageIngestionProcess
        /// </summary>
        public static readonly WorkspaceImageIngestionProcess BYOL_GRAPHICS_G4DN_BYOP = new WorkspaceImageIngestionProcess("BYOL_GRAPHICS_G4DN_BYOP");
        /// <summary>
        /// Constant BYOL_GRAPHICS_G4DN_WSP for WorkspaceImageIngestionProcess
        /// </summary>
        public static readonly WorkspaceImageIngestionProcess BYOL_GRAPHICS_G4DN_WSP = new WorkspaceImageIngestionProcess("BYOL_GRAPHICS_G4DN_WSP");
        /// <summary>
        /// Constant BYOL_GRAPHICSPRO for WorkspaceImageIngestionProcess
        /// </summary>
        public static readonly WorkspaceImageIngestionProcess BYOL_GRAPHICSPRO = new WorkspaceImageIngestionProcess("BYOL_GRAPHICSPRO");
        /// <summary>
        /// Constant BYOL_REGULAR for WorkspaceImageIngestionProcess
        /// </summary>
        public static readonly WorkspaceImageIngestionProcess BYOL_REGULAR = new WorkspaceImageIngestionProcess("BYOL_REGULAR");
        /// <summary>
        /// Constant BYOL_REGULAR_BYOP for WorkspaceImageIngestionProcess
        /// </summary>
        public static readonly WorkspaceImageIngestionProcess BYOL_REGULAR_BYOP = new WorkspaceImageIngestionProcess("BYOL_REGULAR_BYOP");
        /// <summary>
        /// Constant BYOL_REGULAR_WSP for WorkspaceImageIngestionProcess
        /// </summary>
        public static readonly WorkspaceImageIngestionProcess BYOL_REGULAR_WSP = new WorkspaceImageIngestionProcess("BYOL_REGULAR_WSP");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public WorkspaceImageIngestionProcess(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static WorkspaceImageIngestionProcess FindValue(string value)
        {
            return FindValue<WorkspaceImageIngestionProcess>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator WorkspaceImageIngestionProcess(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type WorkspaceImageRequiredTenancy.
    /// </summary>
    public class WorkspaceImageRequiredTenancy : ConstantClass
    {

        /// <summary>
        /// Constant DEDICATED for WorkspaceImageRequiredTenancy
        /// </summary>
        public static readonly WorkspaceImageRequiredTenancy DEDICATED = new WorkspaceImageRequiredTenancy("DEDICATED");
        /// <summary>
        /// Constant DEFAULT for WorkspaceImageRequiredTenancy
        /// </summary>
        public static readonly WorkspaceImageRequiredTenancy DEFAULT = new WorkspaceImageRequiredTenancy("DEFAULT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public WorkspaceImageRequiredTenancy(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static WorkspaceImageRequiredTenancy FindValue(string value)
        {
            return FindValue<WorkspaceImageRequiredTenancy>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator WorkspaceImageRequiredTenancy(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type WorkspaceImageState.
    /// </summary>
    public class WorkspaceImageState : ConstantClass
    {

        /// <summary>
        /// Constant AVAILABLE for WorkspaceImageState
        /// </summary>
        public static readonly WorkspaceImageState AVAILABLE = new WorkspaceImageState("AVAILABLE");
        /// <summary>
        /// Constant ERROR for WorkspaceImageState
        /// </summary>
        public static readonly WorkspaceImageState ERROR = new WorkspaceImageState("ERROR");
        /// <summary>
        /// Constant PENDING for WorkspaceImageState
        /// </summary>
        public static readonly WorkspaceImageState PENDING = new WorkspaceImageState("PENDING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public WorkspaceImageState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static WorkspaceImageState FindValue(string value)
        {
            return FindValue<WorkspaceImageState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator WorkspaceImageState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type WorkspacesPoolErrorCode.
    /// </summary>
    public class WorkspacesPoolErrorCode : ConstantClass
    {

        /// <summary>
        /// Constant BUNDLE_NOT_FOUND for WorkspacesPoolErrorCode
        /// </summary>
        public static readonly WorkspacesPoolErrorCode BUNDLE_NOT_FOUND = new WorkspacesPoolErrorCode("BUNDLE_NOT_FOUND");
        /// <summary>
        /// Constant DEFAULT_OU_IS_MISSING for WorkspacesPoolErrorCode
        /// </summary>
        public static readonly WorkspacesPoolErrorCode DEFAULT_OU_IS_MISSING = new WorkspacesPoolErrorCode("DEFAULT_OU_IS_MISSING");
        /// <summary>
        /// Constant DIRECTORY_NOT_FOUND for WorkspacesPoolErrorCode
        /// </summary>
        public static readonly WorkspacesPoolErrorCode DIRECTORY_NOT_FOUND = new WorkspacesPoolErrorCode("DIRECTORY_NOT_FOUND");
        /// <summary>
        /// Constant DOMAIN_JOIN_ERROR_ACCESS_DENIED for WorkspacesPoolErrorCode
        /// </summary>
        public static readonly WorkspacesPoolErrorCode DOMAIN_JOIN_ERROR_ACCESS_DENIED = new WorkspacesPoolErrorCode("DOMAIN_JOIN_ERROR_ACCESS_DENIED");
        /// <summary>
        /// Constant DOMAIN_JOIN_ERROR_DS_MACHINE_ACCOUNT_QUOTA_EXCEEDED for WorkspacesPoolErrorCode
        /// </summary>
        public static readonly WorkspacesPoolErrorCode DOMAIN_JOIN_ERROR_DS_MACHINE_ACCOUNT_QUOTA_EXCEEDED = new WorkspacesPoolErrorCode("DOMAIN_JOIN_ERROR_DS_MACHINE_ACCOUNT_QUOTA_EXCEEDED");
        /// <summary>
        /// Constant DOMAIN_JOIN_ERROR_FILE_NOT_FOUND for WorkspacesPoolErrorCode
        /// </summary>
        public static readonly WorkspacesPoolErrorCode DOMAIN_JOIN_ERROR_FILE_NOT_FOUND = new WorkspacesPoolErrorCode("DOMAIN_JOIN_ERROR_FILE_NOT_FOUND");
        /// <summary>
        /// Constant DOMAIN_JOIN_ERROR_INVALID_PARAMETER for WorkspacesPoolErrorCode
        /// </summary>
        public static readonly WorkspacesPoolErrorCode DOMAIN_JOIN_ERROR_INVALID_PARAMETER = new WorkspacesPoolErrorCode("DOMAIN_JOIN_ERROR_INVALID_PARAMETER");
        /// <summary>
        /// Constant DOMAIN_JOIN_ERROR_LOGON_FAILURE for WorkspacesPoolErrorCode
        /// </summary>
        public static readonly WorkspacesPoolErrorCode DOMAIN_JOIN_ERROR_LOGON_FAILURE = new WorkspacesPoolErrorCode("DOMAIN_JOIN_ERROR_LOGON_FAILURE");
        /// <summary>
        /// Constant DOMAIN_JOIN_ERROR_MORE_DATA for WorkspacesPoolErrorCode
        /// </summary>
        public static readonly WorkspacesPoolErrorCode DOMAIN_JOIN_ERROR_MORE_DATA = new WorkspacesPoolErrorCode("DOMAIN_JOIN_ERROR_MORE_DATA");
        /// <summary>
        /// Constant DOMAIN_JOIN_ERROR_NO_SUCH_DOMAIN for WorkspacesPoolErrorCode
        /// </summary>
        public static readonly WorkspacesPoolErrorCode DOMAIN_JOIN_ERROR_NO_SUCH_DOMAIN = new WorkspacesPoolErrorCode("DOMAIN_JOIN_ERROR_NO_SUCH_DOMAIN");
        /// <summary>
        /// Constant DOMAIN_JOIN_ERROR_NOT_SUPPORTED for WorkspacesPoolErrorCode
        /// </summary>
        public static readonly WorkspacesPoolErrorCode DOMAIN_JOIN_ERROR_NOT_SUPPORTED = new WorkspacesPoolErrorCode("DOMAIN_JOIN_ERROR_NOT_SUPPORTED");
        /// <summary>
        /// Constant DOMAIN_JOIN_ERROR_SECRET_ACTION_PERMISSION_IS_MISSING for WorkspacesPoolErrorCode
        /// </summary>
        public static readonly WorkspacesPoolErrorCode DOMAIN_JOIN_ERROR_SECRET_ACTION_PERMISSION_IS_MISSING = new WorkspacesPoolErrorCode("DOMAIN_JOIN_ERROR_SECRET_ACTION_PERMISSION_IS_MISSING");
        /// <summary>
        /// Constant DOMAIN_JOIN_ERROR_SECRET_DECRYPTION_FAILURE for WorkspacesPoolErrorCode
        /// </summary>
        public static readonly WorkspacesPoolErrorCode DOMAIN_JOIN_ERROR_SECRET_DECRYPTION_FAILURE = new WorkspacesPoolErrorCode("DOMAIN_JOIN_ERROR_SECRET_DECRYPTION_FAILURE");
        /// <summary>
        /// Constant DOMAIN_JOIN_ERROR_SECRET_INVALID for WorkspacesPoolErrorCode
        /// </summary>
        public static readonly WorkspacesPoolErrorCode DOMAIN_JOIN_ERROR_SECRET_INVALID = new WorkspacesPoolErrorCode("DOMAIN_JOIN_ERROR_SECRET_INVALID");
        /// <summary>
        /// Constant DOMAIN_JOIN_ERROR_SECRET_NOT_FOUND for WorkspacesPoolErrorCode
        /// </summary>
        public static readonly WorkspacesPoolErrorCode DOMAIN_JOIN_ERROR_SECRET_NOT_FOUND = new WorkspacesPoolErrorCode("DOMAIN_JOIN_ERROR_SECRET_NOT_FOUND");
        /// <summary>
        /// Constant DOMAIN_JOIN_ERROR_SECRET_STATE_INVALID for WorkspacesPoolErrorCode
        /// </summary>
        public static readonly WorkspacesPoolErrorCode DOMAIN_JOIN_ERROR_SECRET_STATE_INVALID = new WorkspacesPoolErrorCode("DOMAIN_JOIN_ERROR_SECRET_STATE_INVALID");
        /// <summary>
        /// Constant DOMAIN_JOIN_ERROR_SECRET_VALUE_KEY_NOT_FOUND for WorkspacesPoolErrorCode
        /// </summary>
        public static readonly WorkspacesPoolErrorCode DOMAIN_JOIN_ERROR_SECRET_VALUE_KEY_NOT_FOUND = new WorkspacesPoolErrorCode("DOMAIN_JOIN_ERROR_SECRET_VALUE_KEY_NOT_FOUND");
        /// <summary>
        /// Constant DOMAIN_JOIN_INTERNAL_SERVICE_ERROR for WorkspacesPoolErrorCode
        /// </summary>
        public static readonly WorkspacesPoolErrorCode DOMAIN_JOIN_INTERNAL_SERVICE_ERROR = new WorkspacesPoolErrorCode("DOMAIN_JOIN_INTERNAL_SERVICE_ERROR");
        /// <summary>
        /// Constant DOMAIN_JOIN_NERR_INVALID_WORKGROUP_NAME for WorkspacesPoolErrorCode
        /// </summary>
        public static readonly WorkspacesPoolErrorCode DOMAIN_JOIN_NERR_INVALID_WORKGROUP_NAME = new WorkspacesPoolErrorCode("DOMAIN_JOIN_NERR_INVALID_WORKGROUP_NAME");
        /// <summary>
        /// Constant DOMAIN_JOIN_NERR_PASSWORD_EXPIRED for WorkspacesPoolErrorCode
        /// </summary>
        public static readonly WorkspacesPoolErrorCode DOMAIN_JOIN_NERR_PASSWORD_EXPIRED = new WorkspacesPoolErrorCode("DOMAIN_JOIN_NERR_PASSWORD_EXPIRED");
        /// <summary>
        /// Constant DOMAIN_JOIN_NERR_WORKSTATION_NOT_STARTED for WorkspacesPoolErrorCode
        /// </summary>
        public static readonly WorkspacesPoolErrorCode DOMAIN_JOIN_NERR_WORKSTATION_NOT_STARTED = new WorkspacesPoolErrorCode("DOMAIN_JOIN_NERR_WORKSTATION_NOT_STARTED");
        /// <summary>
        /// Constant IAM_SERVICE_ROLE_IS_MISSING for WorkspacesPoolErrorCode
        /// </summary>
        public static readonly WorkspacesPoolErrorCode IAM_SERVICE_ROLE_IS_MISSING = new WorkspacesPoolErrorCode("IAM_SERVICE_ROLE_IS_MISSING");
        /// <summary>
        /// Constant IAM_SERVICE_ROLE_MISSING_DESCRIBE_SECURITY_GROUPS_ACTION for WorkspacesPoolErrorCode
        /// </summary>
        public static readonly WorkspacesPoolErrorCode IAM_SERVICE_ROLE_MISSING_DESCRIBE_SECURITY_GROUPS_ACTION = new WorkspacesPoolErrorCode("IAM_SERVICE_ROLE_MISSING_DESCRIBE_SECURITY_GROUPS_ACTION");
        /// <summary>
        /// Constant IAM_SERVICE_ROLE_MISSING_DESCRIBE_SUBNET_ACTION for WorkspacesPoolErrorCode
        /// </summary>
        public static readonly WorkspacesPoolErrorCode IAM_SERVICE_ROLE_MISSING_DESCRIBE_SUBNET_ACTION = new WorkspacesPoolErrorCode("IAM_SERVICE_ROLE_MISSING_DESCRIBE_SUBNET_ACTION");
        /// <summary>
        /// Constant IAM_SERVICE_ROLE_MISSING_ENI_CREATE_ACTION for WorkspacesPoolErrorCode
        /// </summary>
        public static readonly WorkspacesPoolErrorCode IAM_SERVICE_ROLE_MISSING_ENI_CREATE_ACTION = new WorkspacesPoolErrorCode("IAM_SERVICE_ROLE_MISSING_ENI_CREATE_ACTION");
        /// <summary>
        /// Constant IAM_SERVICE_ROLE_MISSING_ENI_DELETE_ACTION for WorkspacesPoolErrorCode
        /// </summary>
        public static readonly WorkspacesPoolErrorCode IAM_SERVICE_ROLE_MISSING_ENI_DELETE_ACTION = new WorkspacesPoolErrorCode("IAM_SERVICE_ROLE_MISSING_ENI_DELETE_ACTION");
        /// <summary>
        /// Constant IAM_SERVICE_ROLE_MISSING_ENI_DESCRIBE_ACTION for WorkspacesPoolErrorCode
        /// </summary>
        public static readonly WorkspacesPoolErrorCode IAM_SERVICE_ROLE_MISSING_ENI_DESCRIBE_ACTION = new WorkspacesPoolErrorCode("IAM_SERVICE_ROLE_MISSING_ENI_DESCRIBE_ACTION");
        /// <summary>
        /// Constant IGW_NOT_ATTACHED for WorkspacesPoolErrorCode
        /// </summary>
        public static readonly WorkspacesPoolErrorCode IGW_NOT_ATTACHED = new WorkspacesPoolErrorCode("IGW_NOT_ATTACHED");
        /// <summary>
        /// Constant IMAGE_NOT_FOUND for WorkspacesPoolErrorCode
        /// </summary>
        public static readonly WorkspacesPoolErrorCode IMAGE_NOT_FOUND = new WorkspacesPoolErrorCode("IMAGE_NOT_FOUND");
        /// <summary>
        /// Constant INSUFFICIENT_PERMISSIONS_ERROR for WorkspacesPoolErrorCode
        /// </summary>
        public static readonly WorkspacesPoolErrorCode INSUFFICIENT_PERMISSIONS_ERROR = new WorkspacesPoolErrorCode("INSUFFICIENT_PERMISSIONS_ERROR");
        /// <summary>
        /// Constant INTERNAL_SERVICE_ERROR for WorkspacesPoolErrorCode
        /// </summary>
        public static readonly WorkspacesPoolErrorCode INTERNAL_SERVICE_ERROR = new WorkspacesPoolErrorCode("INTERNAL_SERVICE_ERROR");
        /// <summary>
        /// Constant INVALID_SUBNET_CONFIGURATION for WorkspacesPoolErrorCode
        /// </summary>
        public static readonly WorkspacesPoolErrorCode INVALID_SUBNET_CONFIGURATION = new WorkspacesPoolErrorCode("INVALID_SUBNET_CONFIGURATION");
        /// <summary>
        /// Constant MACHINE_ROLE_IS_MISSING for WorkspacesPoolErrorCode
        /// </summary>
        public static readonly WorkspacesPoolErrorCode MACHINE_ROLE_IS_MISSING = new WorkspacesPoolErrorCode("MACHINE_ROLE_IS_MISSING");
        /// <summary>
        /// Constant NETWORK_INTERFACE_LIMIT_EXCEEDED for WorkspacesPoolErrorCode
        /// </summary>
        public static readonly WorkspacesPoolErrorCode NETWORK_INTERFACE_LIMIT_EXCEEDED = new WorkspacesPoolErrorCode("NETWORK_INTERFACE_LIMIT_EXCEEDED");
        /// <summary>
        /// Constant SECURITY_GROUPS_NOT_FOUND for WorkspacesPoolErrorCode
        /// </summary>
        public static readonly WorkspacesPoolErrorCode SECURITY_GROUPS_NOT_FOUND = new WorkspacesPoolErrorCode("SECURITY_GROUPS_NOT_FOUND");
        /// <summary>
        /// Constant STS_DISABLED_IN_REGION for WorkspacesPoolErrorCode
        /// </summary>
        public static readonly WorkspacesPoolErrorCode STS_DISABLED_IN_REGION = new WorkspacesPoolErrorCode("STS_DISABLED_IN_REGION");
        /// <summary>
        /// Constant SUBNET_HAS_INSUFFICIENT_IP_ADDRESSES for WorkspacesPoolErrorCode
        /// </summary>
        public static readonly WorkspacesPoolErrorCode SUBNET_HAS_INSUFFICIENT_IP_ADDRESSES = new WorkspacesPoolErrorCode("SUBNET_HAS_INSUFFICIENT_IP_ADDRESSES");
        /// <summary>
        /// Constant SUBNET_NOT_FOUND for WorkspacesPoolErrorCode
        /// </summary>
        public static readonly WorkspacesPoolErrorCode SUBNET_NOT_FOUND = new WorkspacesPoolErrorCode("SUBNET_NOT_FOUND");
        /// <summary>
        /// Constant WORKSPACES_POOL_INSTANCE_PROVISIONING_FAILURE for WorkspacesPoolErrorCode
        /// </summary>
        public static readonly WorkspacesPoolErrorCode WORKSPACES_POOL_INSTANCE_PROVISIONING_FAILURE = new WorkspacesPoolErrorCode("WORKSPACES_POOL_INSTANCE_PROVISIONING_FAILURE");
        /// <summary>
        /// Constant WORKSPACES_POOL_STOPPED for WorkspacesPoolErrorCode
        /// </summary>
        public static readonly WorkspacesPoolErrorCode WORKSPACES_POOL_STOPPED = new WorkspacesPoolErrorCode("WORKSPACES_POOL_STOPPED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public WorkspacesPoolErrorCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static WorkspacesPoolErrorCode FindValue(string value)
        {
            return FindValue<WorkspacesPoolErrorCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator WorkspacesPoolErrorCode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type WorkspacesPoolState.
    /// </summary>
    public class WorkspacesPoolState : ConstantClass
    {

        /// <summary>
        /// Constant CREATING for WorkspacesPoolState
        /// </summary>
        public static readonly WorkspacesPoolState CREATING = new WorkspacesPoolState("CREATING");
        /// <summary>
        /// Constant DELETING for WorkspacesPoolState
        /// </summary>
        public static readonly WorkspacesPoolState DELETING = new WorkspacesPoolState("DELETING");
        /// <summary>
        /// Constant RUNNING for WorkspacesPoolState
        /// </summary>
        public static readonly WorkspacesPoolState RUNNING = new WorkspacesPoolState("RUNNING");
        /// <summary>
        /// Constant STARTING for WorkspacesPoolState
        /// </summary>
        public static readonly WorkspacesPoolState STARTING = new WorkspacesPoolState("STARTING");
        /// <summary>
        /// Constant STOPPED for WorkspacesPoolState
        /// </summary>
        public static readonly WorkspacesPoolState STOPPED = new WorkspacesPoolState("STOPPED");
        /// <summary>
        /// Constant STOPPING for WorkspacesPoolState
        /// </summary>
        public static readonly WorkspacesPoolState STOPPING = new WorkspacesPoolState("STOPPING");
        /// <summary>
        /// Constant UPDATING for WorkspacesPoolState
        /// </summary>
        public static readonly WorkspacesPoolState UPDATING = new WorkspacesPoolState("UPDATING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public WorkspacesPoolState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static WorkspacesPoolState FindValue(string value)
        {
            return FindValue<WorkspacesPoolState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator WorkspacesPoolState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type WorkspaceState.
    /// </summary>
    public class WorkspaceState : ConstantClass
    {

        /// <summary>
        /// Constant ADMIN_MAINTENANCE for WorkspaceState
        /// </summary>
        public static readonly WorkspaceState ADMIN_MAINTENANCE = new WorkspaceState("ADMIN_MAINTENANCE");
        /// <summary>
        /// Constant AVAILABLE for WorkspaceState
        /// </summary>
        public static readonly WorkspaceState AVAILABLE = new WorkspaceState("AVAILABLE");
        /// <summary>
        /// Constant ERROR for WorkspaceState
        /// </summary>
        public static readonly WorkspaceState ERROR = new WorkspaceState("ERROR");
        /// <summary>
        /// Constant IMPAIRED for WorkspaceState
        /// </summary>
        public static readonly WorkspaceState IMPAIRED = new WorkspaceState("IMPAIRED");
        /// <summary>
        /// Constant MAINTENANCE for WorkspaceState
        /// </summary>
        public static readonly WorkspaceState MAINTENANCE = new WorkspaceState("MAINTENANCE");
        /// <summary>
        /// Constant PENDING for WorkspaceState
        /// </summary>
        public static readonly WorkspaceState PENDING = new WorkspaceState("PENDING");
        /// <summary>
        /// Constant REBOOTING for WorkspaceState
        /// </summary>
        public static readonly WorkspaceState REBOOTING = new WorkspaceState("REBOOTING");
        /// <summary>
        /// Constant REBUILDING for WorkspaceState
        /// </summary>
        public static readonly WorkspaceState REBUILDING = new WorkspaceState("REBUILDING");
        /// <summary>
        /// Constant RESTORING for WorkspaceState
        /// </summary>
        public static readonly WorkspaceState RESTORING = new WorkspaceState("RESTORING");
        /// <summary>
        /// Constant STARTING for WorkspaceState
        /// </summary>
        public static readonly WorkspaceState STARTING = new WorkspaceState("STARTING");
        /// <summary>
        /// Constant STOPPED for WorkspaceState
        /// </summary>
        public static readonly WorkspaceState STOPPED = new WorkspaceState("STOPPED");
        /// <summary>
        /// Constant STOPPING for WorkspaceState
        /// </summary>
        public static readonly WorkspaceState STOPPING = new WorkspaceState("STOPPING");
        /// <summary>
        /// Constant SUSPENDED for WorkspaceState
        /// </summary>
        public static readonly WorkspaceState SUSPENDED = new WorkspaceState("SUSPENDED");
        /// <summary>
        /// Constant TERMINATED for WorkspaceState
        /// </summary>
        public static readonly WorkspaceState TERMINATED = new WorkspaceState("TERMINATED");
        /// <summary>
        /// Constant TERMINATING for WorkspaceState
        /// </summary>
        public static readonly WorkspaceState TERMINATING = new WorkspaceState("TERMINATING");
        /// <summary>
        /// Constant UNHEALTHY for WorkspaceState
        /// </summary>
        public static readonly WorkspaceState UNHEALTHY = new WorkspaceState("UNHEALTHY");
        /// <summary>
        /// Constant UPDATING for WorkspaceState
        /// </summary>
        public static readonly WorkspaceState UPDATING = new WorkspaceState("UPDATING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public WorkspaceState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static WorkspaceState FindValue(string value)
        {
            return FindValue<WorkspaceState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator WorkspaceState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type WorkspaceType.
    /// </summary>
    public class WorkspaceType : ConstantClass
    {

        /// <summary>
        /// Constant PERSONAL for WorkspaceType
        /// </summary>
        public static readonly WorkspaceType PERSONAL = new WorkspaceType("PERSONAL");
        /// <summary>
        /// Constant POOLS for WorkspaceType
        /// </summary>
        public static readonly WorkspaceType POOLS = new WorkspaceType("POOLS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public WorkspaceType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static WorkspaceType FindValue(string value)
        {
            return FindValue<WorkspaceType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator WorkspaceType(string value)
        {
            return FindValue(value);
        }
    }

}