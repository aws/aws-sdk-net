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