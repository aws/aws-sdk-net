/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;

using Amazon.Runtime;


namespace Amazon.IdentityManagement
{


    /// <summary>assignment Status Type
    /// </summary>
    public class AssignmentStatusType : ConstantClass
    {


       /// <summary>Constant Any for AssignmentStatusType
       /// </summary>
        public static readonly AssignmentStatusType Any = new AssignmentStatusType("Any");
    

       /// <summary>Constant Assigned for AssignmentStatusType
       /// </summary>
        public static readonly AssignmentStatusType Assigned = new AssignmentStatusType("Assigned");
    

       /// <summary>Constant Unassigned for AssignmentStatusType
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

        public static implicit operator AssignmentStatusType(string value)
        {
            return FindValue(value);
        }
    }
    

    /// <summary>status Type
    /// </summary>
    public class StatusType : ConstantClass
    {


       /// <summary>Constant Active for StatusType
       /// </summary>
        public static readonly StatusType Active = new StatusType("Active");
    

       /// <summary>Constant Inactive for StatusType
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

        public static implicit operator StatusType(string value)
        {
            return FindValue(value);
        }
    }
    

    /// <summary>summary Key Type
    /// </summary>
    public class SummaryKeyType : ConstantClass
    {


       /// <summary>Constant AccessKeysPerUserQuota for SummaryKeyType
       /// </summary>
        public static readonly SummaryKeyType AccessKeysPerUserQuota = new SummaryKeyType("AccessKeysPerUserQuota");
    

       /// <summary>Constant AccountMFAEnabled for SummaryKeyType
       /// </summary>
        public static readonly SummaryKeyType AccountMFAEnabled = new SummaryKeyType("AccountMFAEnabled");
    

       /// <summary>Constant GroupPolicySizeQuota for SummaryKeyType
       /// </summary>
        public static readonly SummaryKeyType GroupPolicySizeQuota = new SummaryKeyType("GroupPolicySizeQuota");
    

       /// <summary>Constant Groups for SummaryKeyType
       /// </summary>
        public static readonly SummaryKeyType Groups = new SummaryKeyType("Groups");
    

       /// <summary>Constant GroupsPerUserQuota for SummaryKeyType
       /// </summary>
        public static readonly SummaryKeyType GroupsPerUserQuota = new SummaryKeyType("GroupsPerUserQuota");
    

       /// <summary>Constant GroupsQuota for SummaryKeyType
       /// </summary>
        public static readonly SummaryKeyType GroupsQuota = new SummaryKeyType("GroupsQuota");
    

       /// <summary>Constant MFADevices for SummaryKeyType
       /// </summary>
        public static readonly SummaryKeyType MFADevices = new SummaryKeyType("MFADevices");
    

       /// <summary>Constant MFADevicesInUse for SummaryKeyType
       /// </summary>
        public static readonly SummaryKeyType MFADevicesInUse = new SummaryKeyType("MFADevicesInUse");
    

       /// <summary>Constant ServerCertificates for SummaryKeyType
       /// </summary>
        public static readonly SummaryKeyType ServerCertificates = new SummaryKeyType("ServerCertificates");
    

       /// <summary>Constant ServerCertificatesQuota for SummaryKeyType
       /// </summary>
        public static readonly SummaryKeyType ServerCertificatesQuota = new SummaryKeyType("ServerCertificatesQuota");
    

       /// <summary>Constant SigningCertificatesPerUserQuota for SummaryKeyType
       /// </summary>
        public static readonly SummaryKeyType SigningCertificatesPerUserQuota = new SummaryKeyType("SigningCertificatesPerUserQuota");
    

       /// <summary>Constant UserPolicySizeQuota for SummaryKeyType
       /// </summary>
        public static readonly SummaryKeyType UserPolicySizeQuota = new SummaryKeyType("UserPolicySizeQuota");
    

       /// <summary>Constant Users for SummaryKeyType
       /// </summary>
        public static readonly SummaryKeyType Users = new SummaryKeyType("Users");
    

       /// <summary>Constant UsersQuota for SummaryKeyType
       /// </summary>
        public static readonly SummaryKeyType UsersQuota = new SummaryKeyType("UsersQuota");
    

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

        public static implicit operator SummaryKeyType(string value)
        {
            return FindValue(value);
        }
    }
    

}
        
