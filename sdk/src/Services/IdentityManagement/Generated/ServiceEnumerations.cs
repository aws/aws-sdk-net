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
 * Do not modify this file. This file is generated from the iam-2010-05-08.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.IdentityManagement
{

    /// <summary>
    /// Constants used for properties of type AssignmentStatusType.
    /// </summary>
    public class AssignmentStatusType : ConstantClass
    {

        /// <summary>
        /// Constant Any for AssignmentStatusType
        /// </summary>
        public static readonly AssignmentStatusType Any = new AssignmentStatusType("Any");
        /// <summary>
        /// Constant Assigned for AssignmentStatusType
        /// </summary>
        public static readonly AssignmentStatusType Assigned = new AssignmentStatusType("Assigned");
        /// <summary>
        /// Constant Unassigned for AssignmentStatusType
        /// </summary>
        public static readonly AssignmentStatusType Unassigned = new AssignmentStatusType("Unassigned");

        /// <summary>
        /// Default Constructor
        /// </summary>
        public AssignmentStatusType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AssignmentStatusType FindValue(string value)
        {
            return FindValue<AssignmentStatusType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AssignmentStatusType(string value)
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
        /// Constant AWSManagedPolicy for EntityType
        /// </summary>
        public static readonly EntityType AWSManagedPolicy = new EntityType("AWSManagedPolicy");
        /// <summary>
        /// Constant Group for EntityType
        /// </summary>
        public static readonly EntityType Group = new EntityType("Group");
        /// <summary>
        /// Constant LocalManagedPolicy for EntityType
        /// </summary>
        public static readonly EntityType LocalManagedPolicy = new EntityType("LocalManagedPolicy");
        /// <summary>
        /// Constant Role for EntityType
        /// </summary>
        public static readonly EntityType Role = new EntityType("Role");
        /// <summary>
        /// Constant User for EntityType
        /// </summary>
        public static readonly EntityType User = new EntityType("User");

        /// <summary>
        /// Default Constructor
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
    /// Constants used for properties of type PolicyScopeType.
    /// </summary>
    public class PolicyScopeType : ConstantClass
    {

        /// <summary>
        /// Constant All for PolicyScopeType
        /// </summary>
        public static readonly PolicyScopeType All = new PolicyScopeType("All");
        /// <summary>
        /// Constant AWS for PolicyScopeType
        /// </summary>
        public static readonly PolicyScopeType AWS = new PolicyScopeType("AWS");
        /// <summary>
        /// Constant Local for PolicyScopeType
        /// </summary>
        public static readonly PolicyScopeType Local = new PolicyScopeType("Local");

        /// <summary>
        /// Default Constructor
        /// </summary>
        public PolicyScopeType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PolicyScopeType FindValue(string value)
        {
            return FindValue<PolicyScopeType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PolicyScopeType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ReportFormatType.
    /// </summary>
    public class ReportFormatType : ConstantClass
    {

        /// <summary>
        /// Constant TextCsv for ReportFormatType
        /// </summary>
        public static readonly ReportFormatType TextCsv = new ReportFormatType("text/csv");

        /// <summary>
        /// Default Constructor
        /// </summary>
        public ReportFormatType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ReportFormatType FindValue(string value)
        {
            return FindValue<ReportFormatType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ReportFormatType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ReportStateType.
    /// </summary>
    public class ReportStateType : ConstantClass
    {

        /// <summary>
        /// Constant COMPLETE for ReportStateType
        /// </summary>
        public static readonly ReportStateType COMPLETE = new ReportStateType("COMPLETE");
        /// <summary>
        /// Constant INPROGRESS for ReportStateType
        /// </summary>
        public static readonly ReportStateType INPROGRESS = new ReportStateType("INPROGRESS");
        /// <summary>
        /// Constant STARTED for ReportStateType
        /// </summary>
        public static readonly ReportStateType STARTED = new ReportStateType("STARTED");

        /// <summary>
        /// Default Constructor
        /// </summary>
        public ReportStateType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ReportStateType FindValue(string value)
        {
            return FindValue<ReportStateType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ReportStateType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type StatusType.
    /// </summary>
    public class StatusType : ConstantClass
    {

        /// <summary>
        /// Constant Active for StatusType
        /// </summary>
        public static readonly StatusType Active = new StatusType("Active");
        /// <summary>
        /// Constant Inactive for StatusType
        /// </summary>
        public static readonly StatusType Inactive = new StatusType("Inactive");

        /// <summary>
        /// Default Constructor
        /// </summary>
        public StatusType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static StatusType FindValue(string value)
        {
            return FindValue<StatusType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator StatusType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SummaryKeyType.
    /// </summary>
    public class SummaryKeyType : ConstantClass
    {

        /// <summary>
        /// Constant AccessKeysPerUserQuota for SummaryKeyType
        /// </summary>
        public static readonly SummaryKeyType AccessKeysPerUserQuota = new SummaryKeyType("AccessKeysPerUserQuota");
        /// <summary>
        /// Constant AccountAccessKeysPresent for SummaryKeyType
        /// </summary>
        public static readonly SummaryKeyType AccountAccessKeysPresent = new SummaryKeyType("AccountAccessKeysPresent");
        /// <summary>
        /// Constant AccountMFAEnabled for SummaryKeyType
        /// </summary>
        public static readonly SummaryKeyType AccountMFAEnabled = new SummaryKeyType("AccountMFAEnabled");
        /// <summary>
        /// Constant AccountSigningCertificatesPresent for SummaryKeyType
        /// </summary>
        public static readonly SummaryKeyType AccountSigningCertificatesPresent = new SummaryKeyType("AccountSigningCertificatesPresent");
        /// <summary>
        /// Constant AttachedPoliciesPerGroupQuota for SummaryKeyType
        /// </summary>
        public static readonly SummaryKeyType AttachedPoliciesPerGroupQuota = new SummaryKeyType("AttachedPoliciesPerGroupQuota");
        /// <summary>
        /// Constant AttachedPoliciesPerRoleQuota for SummaryKeyType
        /// </summary>
        public static readonly SummaryKeyType AttachedPoliciesPerRoleQuota = new SummaryKeyType("AttachedPoliciesPerRoleQuota");
        /// <summary>
        /// Constant AttachedPoliciesPerUserQuota for SummaryKeyType
        /// </summary>
        public static readonly SummaryKeyType AttachedPoliciesPerUserQuota = new SummaryKeyType("AttachedPoliciesPerUserQuota");
        /// <summary>
        /// Constant GroupPolicySizeQuota for SummaryKeyType
        /// </summary>
        public static readonly SummaryKeyType GroupPolicySizeQuota = new SummaryKeyType("GroupPolicySizeQuota");
        /// <summary>
        /// Constant Groups for SummaryKeyType
        /// </summary>
        public static readonly SummaryKeyType Groups = new SummaryKeyType("Groups");
        /// <summary>
        /// Constant GroupsPerUserQuota for SummaryKeyType
        /// </summary>
        public static readonly SummaryKeyType GroupsPerUserQuota = new SummaryKeyType("GroupsPerUserQuota");
        /// <summary>
        /// Constant GroupsQuota for SummaryKeyType
        /// </summary>
        public static readonly SummaryKeyType GroupsQuota = new SummaryKeyType("GroupsQuota");
        /// <summary>
        /// Constant MFADevices for SummaryKeyType
        /// </summary>
        public static readonly SummaryKeyType MFADevices = new SummaryKeyType("MFADevices");
        /// <summary>
        /// Constant MFADevicesInUse for SummaryKeyType
        /// </summary>
        public static readonly SummaryKeyType MFADevicesInUse = new SummaryKeyType("MFADevicesInUse");
        /// <summary>
        /// Constant Policies for SummaryKeyType
        /// </summary>
        public static readonly SummaryKeyType Policies = new SummaryKeyType("Policies");
        /// <summary>
        /// Constant PoliciesQuota for SummaryKeyType
        /// </summary>
        public static readonly SummaryKeyType PoliciesQuota = new SummaryKeyType("PoliciesQuota");
        /// <summary>
        /// Constant PolicySizeQuota for SummaryKeyType
        /// </summary>
        public static readonly SummaryKeyType PolicySizeQuota = new SummaryKeyType("PolicySizeQuota");
        /// <summary>
        /// Constant PolicyVersionsInUse for SummaryKeyType
        /// </summary>
        public static readonly SummaryKeyType PolicyVersionsInUse = new SummaryKeyType("PolicyVersionsInUse");
        /// <summary>
        /// Constant PolicyVersionsInUseQuota for SummaryKeyType
        /// </summary>
        public static readonly SummaryKeyType PolicyVersionsInUseQuota = new SummaryKeyType("PolicyVersionsInUseQuota");
        /// <summary>
        /// Constant ServerCertificates for SummaryKeyType
        /// </summary>
        public static readonly SummaryKeyType ServerCertificates = new SummaryKeyType("ServerCertificates");
        /// <summary>
        /// Constant ServerCertificatesQuota for SummaryKeyType
        /// </summary>
        public static readonly SummaryKeyType ServerCertificatesQuota = new SummaryKeyType("ServerCertificatesQuota");
        /// <summary>
        /// Constant SigningCertificatesPerUserQuota for SummaryKeyType
        /// </summary>
        public static readonly SummaryKeyType SigningCertificatesPerUserQuota = new SummaryKeyType("SigningCertificatesPerUserQuota");
        /// <summary>
        /// Constant UserPolicySizeQuota for SummaryKeyType
        /// </summary>
        public static readonly SummaryKeyType UserPolicySizeQuota = new SummaryKeyType("UserPolicySizeQuota");
        /// <summary>
        /// Constant Users for SummaryKeyType
        /// </summary>
        public static readonly SummaryKeyType Users = new SummaryKeyType("Users");
        /// <summary>
        /// Constant UsersQuota for SummaryKeyType
        /// </summary>
        public static readonly SummaryKeyType UsersQuota = new SummaryKeyType("UsersQuota");
        /// <summary>
        /// Constant VersionsPerPolicyQuota for SummaryKeyType
        /// </summary>
        public static readonly SummaryKeyType VersionsPerPolicyQuota = new SummaryKeyType("VersionsPerPolicyQuota");

        /// <summary>
        /// Default Constructor
        /// </summary>
        public SummaryKeyType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SummaryKeyType FindValue(string value)
        {
            return FindValue<SummaryKeyType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SummaryKeyType(string value)
        {
            return FindValue(value);
        }
    }

}