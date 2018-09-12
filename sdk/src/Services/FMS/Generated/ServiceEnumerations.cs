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
 * Do not modify this file. This file is generated from the fms-2018-01-01.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.FMS
{

    /// <summary>
    /// Constants used for properties of type AccountRoleStatus.
    /// </summary>
    public class AccountRoleStatus : ConstantClass
    {

        /// <summary>
        /// Constant CREATING for AccountRoleStatus
        /// </summary>
        public static readonly AccountRoleStatus CREATING = new AccountRoleStatus("CREATING");
        /// <summary>
        /// Constant DELETED for AccountRoleStatus
        /// </summary>
        public static readonly AccountRoleStatus DELETED = new AccountRoleStatus("DELETED");
        /// <summary>
        /// Constant DELETING for AccountRoleStatus
        /// </summary>
        public static readonly AccountRoleStatus DELETING = new AccountRoleStatus("DELETING");
        /// <summary>
        /// Constant PENDING_DELETION for AccountRoleStatus
        /// </summary>
        public static readonly AccountRoleStatus PENDING_DELETION = new AccountRoleStatus("PENDING_DELETION");
        /// <summary>
        /// Constant READY for AccountRoleStatus
        /// </summary>
        public static readonly AccountRoleStatus READY = new AccountRoleStatus("READY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AccountRoleStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AccountRoleStatus FindValue(string value)
        {
            return FindValue<AccountRoleStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AccountRoleStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CustomerPolicyScopeIdType.
    /// </summary>
    public class CustomerPolicyScopeIdType : ConstantClass
    {

        /// <summary>
        /// Constant ACCOUNT for CustomerPolicyScopeIdType
        /// </summary>
        public static readonly CustomerPolicyScopeIdType ACCOUNT = new CustomerPolicyScopeIdType("ACCOUNT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CustomerPolicyScopeIdType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CustomerPolicyScopeIdType FindValue(string value)
        {
            return FindValue<CustomerPolicyScopeIdType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CustomerPolicyScopeIdType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DependentServiceName.
    /// </summary>
    public class DependentServiceName : ConstantClass
    {

        /// <summary>
        /// Constant AWSCONFIG for DependentServiceName
        /// </summary>
        public static readonly DependentServiceName AWSCONFIG = new DependentServiceName("AWSCONFIG");
        /// <summary>
        /// Constant AWSWAF for DependentServiceName
        /// </summary>
        public static readonly DependentServiceName AWSWAF = new DependentServiceName("AWSWAF");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DependentServiceName(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DependentServiceName FindValue(string value)
        {
            return FindValue<DependentServiceName>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DependentServiceName(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PolicyComplianceStatusType.
    /// </summary>
    public class PolicyComplianceStatusType : ConstantClass
    {

        /// <summary>
        /// Constant COMPLIANT for PolicyComplianceStatusType
        /// </summary>
        public static readonly PolicyComplianceStatusType COMPLIANT = new PolicyComplianceStatusType("COMPLIANT");
        /// <summary>
        /// Constant NON_COMPLIANT for PolicyComplianceStatusType
        /// </summary>
        public static readonly PolicyComplianceStatusType NON_COMPLIANT = new PolicyComplianceStatusType("NON_COMPLIANT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PolicyComplianceStatusType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PolicyComplianceStatusType FindValue(string value)
        {
            return FindValue<PolicyComplianceStatusType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PolicyComplianceStatusType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SecurityServiceType.
    /// </summary>
    public class SecurityServiceType : ConstantClass
    {

        /// <summary>
        /// Constant WAF for SecurityServiceType
        /// </summary>
        public static readonly SecurityServiceType WAF = new SecurityServiceType("WAF");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SecurityServiceType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SecurityServiceType FindValue(string value)
        {
            return FindValue<SecurityServiceType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SecurityServiceType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ViolationReason.
    /// </summary>
    public class ViolationReason : ConstantClass
    {

        /// <summary>
        /// Constant RESOURCE_INCORRECT_WEB_ACL for ViolationReason
        /// </summary>
        public static readonly ViolationReason RESOURCE_INCORRECT_WEB_ACL = new ViolationReason("RESOURCE_INCORRECT_WEB_ACL");
        /// <summary>
        /// Constant RESOURCE_MISSING_WEB_ACL for ViolationReason
        /// </summary>
        public static readonly ViolationReason RESOURCE_MISSING_WEB_ACL = new ViolationReason("RESOURCE_MISSING_WEB_ACL");
        /// <summary>
        /// Constant WEB_ACL_MISSING_RULE_GROUP for ViolationReason
        /// </summary>
        public static readonly ViolationReason WEB_ACL_MISSING_RULE_GROUP = new ViolationReason("WEB_ACL_MISSING_RULE_GROUP");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ViolationReason(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ViolationReason FindValue(string value)
        {
            return FindValue<ViolationReason>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ViolationReason(string value)
        {
            return FindValue(value);
        }
    }

}