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
 * Do not modify this file. This file is generated from the workmail-2017-10-01.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.WorkMail
{

    /// <summary>
    /// Constants used for properties of type AccessControlRuleEffect.
    /// </summary>
    public class AccessControlRuleEffect : ConstantClass
    {

        /// <summary>
        /// Constant ALLOW for AccessControlRuleEffect
        /// </summary>
        public static readonly AccessControlRuleEffect ALLOW = new AccessControlRuleEffect("ALLOW");
        /// <summary>
        /// Constant DENY for AccessControlRuleEffect
        /// </summary>
        public static readonly AccessControlRuleEffect DENY = new AccessControlRuleEffect("DENY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AccessControlRuleEffect(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AccessControlRuleEffect FindValue(string value)
        {
            return FindValue<AccessControlRuleEffect>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AccessControlRuleEffect(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AccessEffect.
    /// </summary>
    public class AccessEffect : ConstantClass
    {

        /// <summary>
        /// Constant ALLOW for AccessEffect
        /// </summary>
        public static readonly AccessEffect ALLOW = new AccessEffect("ALLOW");
        /// <summary>
        /// Constant DENY for AccessEffect
        /// </summary>
        public static readonly AccessEffect DENY = new AccessEffect("DENY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AccessEffect(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AccessEffect FindValue(string value)
        {
            return FindValue<AccessEffect>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AccessEffect(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AvailabilityProviderType.
    /// </summary>
    public class AvailabilityProviderType : ConstantClass
    {

        /// <summary>
        /// Constant EWS for AvailabilityProviderType
        /// </summary>
        public static readonly AvailabilityProviderType EWS = new AvailabilityProviderType("EWS");
        /// <summary>
        /// Constant LAMBDA for AvailabilityProviderType
        /// </summary>
        public static readonly AvailabilityProviderType LAMBDA = new AvailabilityProviderType("LAMBDA");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AvailabilityProviderType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AvailabilityProviderType FindValue(string value)
        {
            return FindValue<AvailabilityProviderType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AvailabilityProviderType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DnsRecordVerificationStatus.
    /// </summary>
    public class DnsRecordVerificationStatus : ConstantClass
    {

        /// <summary>
        /// Constant FAILED for DnsRecordVerificationStatus
        /// </summary>
        public static readonly DnsRecordVerificationStatus FAILED = new DnsRecordVerificationStatus("FAILED");
        /// <summary>
        /// Constant PENDING for DnsRecordVerificationStatus
        /// </summary>
        public static readonly DnsRecordVerificationStatus PENDING = new DnsRecordVerificationStatus("PENDING");
        /// <summary>
        /// Constant VERIFIED for DnsRecordVerificationStatus
        /// </summary>
        public static readonly DnsRecordVerificationStatus VERIFIED = new DnsRecordVerificationStatus("VERIFIED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DnsRecordVerificationStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DnsRecordVerificationStatus FindValue(string value)
        {
            return FindValue<DnsRecordVerificationStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DnsRecordVerificationStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type EntityState.
    /// </summary>
    public class EntityState : ConstantClass
    {

        /// <summary>
        /// Constant DELETED for EntityState
        /// </summary>
        public static readonly EntityState DELETED = new EntityState("DELETED");
        /// <summary>
        /// Constant DISABLED for EntityState
        /// </summary>
        public static readonly EntityState DISABLED = new EntityState("DISABLED");
        /// <summary>
        /// Constant ENABLED for EntityState
        /// </summary>
        public static readonly EntityState ENABLED = new EntityState("ENABLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EntityState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EntityState FindValue(string value)
        {
            return FindValue<EntityState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EntityState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type EntityType.
    /// </summary>
    public class EntityType : ConstantClass
    {

        /// <summary>
        /// Constant GROUP for EntityType
        /// </summary>
        public static readonly EntityType GROUP = new EntityType("GROUP");
        /// <summary>
        /// Constant RESOURCE for EntityType
        /// </summary>
        public static readonly EntityType RESOURCE = new EntityType("RESOURCE");
        /// <summary>
        /// Constant USER for EntityType
        /// </summary>
        public static readonly EntityType USER = new EntityType("USER");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EntityType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EntityType FindValue(string value)
        {
            return FindValue<EntityType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EntityType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type FolderName.
    /// </summary>
    public class FolderName : ConstantClass
    {

        /// <summary>
        /// Constant DELETED_ITEMS for FolderName
        /// </summary>
        public static readonly FolderName DELETED_ITEMS = new FolderName("DELETED_ITEMS");
        /// <summary>
        /// Constant DRAFTS for FolderName
        /// </summary>
        public static readonly FolderName DRAFTS = new FolderName("DRAFTS");
        /// <summary>
        /// Constant INBOX for FolderName
        /// </summary>
        public static readonly FolderName INBOX = new FolderName("INBOX");
        /// <summary>
        /// Constant JUNK_EMAIL for FolderName
        /// </summary>
        public static readonly FolderName JUNK_EMAIL = new FolderName("JUNK_EMAIL");
        /// <summary>
        /// Constant SENT_ITEMS for FolderName
        /// </summary>
        public static readonly FolderName SENT_ITEMS = new FolderName("SENT_ITEMS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FolderName(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FolderName FindValue(string value)
        {
            return FindValue<FolderName>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FolderName(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type IdentityProviderAuthenticationMode.
    /// </summary>
    public class IdentityProviderAuthenticationMode : ConstantClass
    {

        /// <summary>
        /// Constant IDENTITY_PROVIDER_AND_DIRECTORY for IdentityProviderAuthenticationMode
        /// </summary>
        public static readonly IdentityProviderAuthenticationMode IDENTITY_PROVIDER_AND_DIRECTORY = new IdentityProviderAuthenticationMode("IDENTITY_PROVIDER_AND_DIRECTORY");
        /// <summary>
        /// Constant IDENTITY_PROVIDER_ONLY for IdentityProviderAuthenticationMode
        /// </summary>
        public static readonly IdentityProviderAuthenticationMode IDENTITY_PROVIDER_ONLY = new IdentityProviderAuthenticationMode("IDENTITY_PROVIDER_ONLY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public IdentityProviderAuthenticationMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static IdentityProviderAuthenticationMode FindValue(string value)
        {
            return FindValue<IdentityProviderAuthenticationMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator IdentityProviderAuthenticationMode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ImpersonationRoleType.
    /// </summary>
    public class ImpersonationRoleType : ConstantClass
    {

        /// <summary>
        /// Constant FULL_ACCESS for ImpersonationRoleType
        /// </summary>
        public static readonly ImpersonationRoleType FULL_ACCESS = new ImpersonationRoleType("FULL_ACCESS");
        /// <summary>
        /// Constant READ_ONLY for ImpersonationRoleType
        /// </summary>
        public static readonly ImpersonationRoleType READ_ONLY = new ImpersonationRoleType("READ_ONLY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ImpersonationRoleType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ImpersonationRoleType FindValue(string value)
        {
            return FindValue<ImpersonationRoleType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ImpersonationRoleType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type MailboxExportJobState.
    /// </summary>
    public class MailboxExportJobState : ConstantClass
    {

        /// <summary>
        /// Constant CANCELLED for MailboxExportJobState
        /// </summary>
        public static readonly MailboxExportJobState CANCELLED = new MailboxExportJobState("CANCELLED");
        /// <summary>
        /// Constant COMPLETED for MailboxExportJobState
        /// </summary>
        public static readonly MailboxExportJobState COMPLETED = new MailboxExportJobState("COMPLETED");
        /// <summary>
        /// Constant FAILED for MailboxExportJobState
        /// </summary>
        public static readonly MailboxExportJobState FAILED = new MailboxExportJobState("FAILED");
        /// <summary>
        /// Constant RUNNING for MailboxExportJobState
        /// </summary>
        public static readonly MailboxExportJobState RUNNING = new MailboxExportJobState("RUNNING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MailboxExportJobState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MailboxExportJobState FindValue(string value)
        {
            return FindValue<MailboxExportJobState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MailboxExportJobState(string value)
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
    /// Constants used for properties of type MobileDeviceAccessRuleEffect.
    /// </summary>
    public class MobileDeviceAccessRuleEffect : ConstantClass
    {

        /// <summary>
        /// Constant ALLOW for MobileDeviceAccessRuleEffect
        /// </summary>
        public static readonly MobileDeviceAccessRuleEffect ALLOW = new MobileDeviceAccessRuleEffect("ALLOW");
        /// <summary>
        /// Constant DENY for MobileDeviceAccessRuleEffect
        /// </summary>
        public static readonly MobileDeviceAccessRuleEffect DENY = new MobileDeviceAccessRuleEffect("DENY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MobileDeviceAccessRuleEffect(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MobileDeviceAccessRuleEffect FindValue(string value)
        {
            return FindValue<MobileDeviceAccessRuleEffect>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MobileDeviceAccessRuleEffect(string value)
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
        /// Constant FULL_ACCESS for PermissionType
        /// </summary>
        public static readonly PermissionType FULL_ACCESS = new PermissionType("FULL_ACCESS");
        /// <summary>
        /// Constant SEND_AS for PermissionType
        /// </summary>
        public static readonly PermissionType SEND_AS = new PermissionType("SEND_AS");
        /// <summary>
        /// Constant SEND_ON_BEHALF for PermissionType
        /// </summary>
        public static readonly PermissionType SEND_ON_BEHALF = new PermissionType("SEND_ON_BEHALF");

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
    /// Constants used for properties of type PersonalAccessTokenConfigurationStatus.
    /// </summary>
    public class PersonalAccessTokenConfigurationStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for PersonalAccessTokenConfigurationStatus
        /// </summary>
        public static readonly PersonalAccessTokenConfigurationStatus ACTIVE = new PersonalAccessTokenConfigurationStatus("ACTIVE");
        /// <summary>
        /// Constant INACTIVE for PersonalAccessTokenConfigurationStatus
        /// </summary>
        public static readonly PersonalAccessTokenConfigurationStatus INACTIVE = new PersonalAccessTokenConfigurationStatus("INACTIVE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PersonalAccessTokenConfigurationStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PersonalAccessTokenConfigurationStatus FindValue(string value)
        {
            return FindValue<PersonalAccessTokenConfigurationStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PersonalAccessTokenConfigurationStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ResourceType.
    /// </summary>
    public class ResourceType : ConstantClass
    {

        /// <summary>
        /// Constant EQUIPMENT for ResourceType
        /// </summary>
        public static readonly ResourceType EQUIPMENT = new ResourceType("EQUIPMENT");
        /// <summary>
        /// Constant ROOM for ResourceType
        /// </summary>
        public static readonly ResourceType ROOM = new ResourceType("ROOM");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ResourceType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ResourceType FindValue(string value)
        {
            return FindValue<ResourceType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ResourceType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RetentionAction.
    /// </summary>
    public class RetentionAction : ConstantClass
    {

        /// <summary>
        /// Constant DELETE for RetentionAction
        /// </summary>
        public static readonly RetentionAction DELETE = new RetentionAction("DELETE");
        /// <summary>
        /// Constant NONE for RetentionAction
        /// </summary>
        public static readonly RetentionAction NONE = new RetentionAction("NONE");
        /// <summary>
        /// Constant PERMANENTLY_DELETE for RetentionAction
        /// </summary>
        public static readonly RetentionAction PERMANENTLY_DELETE = new RetentionAction("PERMANENTLY_DELETE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RetentionAction(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RetentionAction FindValue(string value)
        {
            return FindValue<RetentionAction>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RetentionAction(string value)
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
        /// Constant REMOTE_USER for UserRole
        /// </summary>
        public static readonly UserRole REMOTE_USER = new UserRole("REMOTE_USER");
        /// <summary>
        /// Constant RESOURCE for UserRole
        /// </summary>
        public static readonly UserRole RESOURCE = new UserRole("RESOURCE");
        /// <summary>
        /// Constant SYSTEM_USER for UserRole
        /// </summary>
        public static readonly UserRole SYSTEM_USER = new UserRole("SYSTEM_USER");
        /// <summary>
        /// Constant USER for UserRole
        /// </summary>
        public static readonly UserRole USER = new UserRole("USER");

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