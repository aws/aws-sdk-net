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
        /// Constant ORG_UNIT for CustomerPolicyScopeIdType
        /// </summary>
        public static readonly CustomerPolicyScopeIdType ORG_UNIT = new CustomerPolicyScopeIdType("ORG_UNIT");

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
        /// Constant AWSSHIELD_ADVANCED for DependentServiceName
        /// </summary>
        public static readonly DependentServiceName AWSSHIELD_ADVANCED = new DependentServiceName("AWSSHIELD_ADVANCED");
        /// <summary>
        /// Constant AWSVPC for DependentServiceName
        /// </summary>
        public static readonly DependentServiceName AWSVPC = new DependentServiceName("AWSVPC");
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
    /// Constants used for properties of type DestinationType.
    /// </summary>
    public class DestinationType : ConstantClass
    {

        /// <summary>
        /// Constant IPV4 for DestinationType
        /// </summary>
        public static readonly DestinationType IPV4 = new DestinationType("IPV4");
        /// <summary>
        /// Constant IPV6 for DestinationType
        /// </summary>
        public static readonly DestinationType IPV6 = new DestinationType("IPV6");
        /// <summary>
        /// Constant PREFIX_LIST for DestinationType
        /// </summary>
        public static readonly DestinationType PREFIX_LIST = new DestinationType("PREFIX_LIST");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DestinationType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DestinationType FindValue(string value)
        {
            return FindValue<DestinationType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DestinationType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type FirewallDeploymentModel.
    /// </summary>
    public class FirewallDeploymentModel : ConstantClass
    {

        /// <summary>
        /// Constant CENTRALIZED for FirewallDeploymentModel
        /// </summary>
        public static readonly FirewallDeploymentModel CENTRALIZED = new FirewallDeploymentModel("CENTRALIZED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FirewallDeploymentModel(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FirewallDeploymentModel FindValue(string value)
        {
            return FindValue<FirewallDeploymentModel>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FirewallDeploymentModel(string value)
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
    /// Constants used for properties of type RemediationActionType.
    /// </summary>
    public class RemediationActionType : ConstantClass
    {

        /// <summary>
        /// Constant MODIFY for RemediationActionType
        /// </summary>
        public static readonly RemediationActionType MODIFY = new RemediationActionType("MODIFY");
        /// <summary>
        /// Constant REMOVE for RemediationActionType
        /// </summary>
        public static readonly RemediationActionType REMOVE = new RemediationActionType("REMOVE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RemediationActionType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RemediationActionType FindValue(string value)
        {
            return FindValue<RemediationActionType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RemediationActionType(string value)
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
        /// Constant DNS_FIREWALL for SecurityServiceType
        /// </summary>
        public static readonly SecurityServiceType DNS_FIREWALL = new SecurityServiceType("DNS_FIREWALL");
        /// <summary>
        /// Constant NETWORK_FIREWALL for SecurityServiceType
        /// </summary>
        public static readonly SecurityServiceType NETWORK_FIREWALL = new SecurityServiceType("NETWORK_FIREWALL");
        /// <summary>
        /// Constant SECURITY_GROUPS_COMMON for SecurityServiceType
        /// </summary>
        public static readonly SecurityServiceType SECURITY_GROUPS_COMMON = new SecurityServiceType("SECURITY_GROUPS_COMMON");
        /// <summary>
        /// Constant SECURITY_GROUPS_CONTENT_AUDIT for SecurityServiceType
        /// </summary>
        public static readonly SecurityServiceType SECURITY_GROUPS_CONTENT_AUDIT = new SecurityServiceType("SECURITY_GROUPS_CONTENT_AUDIT");
        /// <summary>
        /// Constant SECURITY_GROUPS_USAGE_AUDIT for SecurityServiceType
        /// </summary>
        public static readonly SecurityServiceType SECURITY_GROUPS_USAGE_AUDIT = new SecurityServiceType("SECURITY_GROUPS_USAGE_AUDIT");
        /// <summary>
        /// Constant SHIELD_ADVANCED for SecurityServiceType
        /// </summary>
        public static readonly SecurityServiceType SHIELD_ADVANCED = new SecurityServiceType("SHIELD_ADVANCED");
        /// <summary>
        /// Constant WAF for SecurityServiceType
        /// </summary>
        public static readonly SecurityServiceType WAF = new SecurityServiceType("WAF");
        /// <summary>
        /// Constant WAFV2 for SecurityServiceType
        /// </summary>
        public static readonly SecurityServiceType WAFV2 = new SecurityServiceType("WAFV2");

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
    /// Constants used for properties of type TargetType.
    /// </summary>
    public class TargetType : ConstantClass
    {

        /// <summary>
        /// Constant CARRIER_GATEWAY for TargetType
        /// </summary>
        public static readonly TargetType CARRIER_GATEWAY = new TargetType("CARRIER_GATEWAY");
        /// <summary>
        /// Constant EGRESS_ONLY_INTERNET_GATEWAY for TargetType
        /// </summary>
        public static readonly TargetType EGRESS_ONLY_INTERNET_GATEWAY = new TargetType("EGRESS_ONLY_INTERNET_GATEWAY");
        /// <summary>
        /// Constant GATEWAY for TargetType
        /// </summary>
        public static readonly TargetType GATEWAY = new TargetType("GATEWAY");
        /// <summary>
        /// Constant INSTANCE for TargetType
        /// </summary>
        public static readonly TargetType INSTANCE = new TargetType("INSTANCE");
        /// <summary>
        /// Constant LOCAL_GATEWAY for TargetType
        /// </summary>
        public static readonly TargetType LOCAL_GATEWAY = new TargetType("LOCAL_GATEWAY");
        /// <summary>
        /// Constant NAT_GATEWAY for TargetType
        /// </summary>
        public static readonly TargetType NAT_GATEWAY = new TargetType("NAT_GATEWAY");
        /// <summary>
        /// Constant NETWORK_INTERFACE for TargetType
        /// </summary>
        public static readonly TargetType NETWORK_INTERFACE = new TargetType("NETWORK_INTERFACE");
        /// <summary>
        /// Constant TRANSIT_GATEWAY for TargetType
        /// </summary>
        public static readonly TargetType TRANSIT_GATEWAY = new TargetType("TRANSIT_GATEWAY");
        /// <summary>
        /// Constant VPC_ENDPOINT for TargetType
        /// </summary>
        public static readonly TargetType VPC_ENDPOINT = new TargetType("VPC_ENDPOINT");
        /// <summary>
        /// Constant VPC_PEERING_CONNECTION for TargetType
        /// </summary>
        public static readonly TargetType VPC_PEERING_CONNECTION = new TargetType("VPC_PEERING_CONNECTION");

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
    /// Constants used for properties of type ViolationReason.
    /// </summary>
    public class ViolationReason : ConstantClass
    {

        /// <summary>
        /// Constant BLACK_HOLE_ROUTE_DETECTED for ViolationReason
        /// </summary>
        public static readonly ViolationReason BLACK_HOLE_ROUTE_DETECTED = new ViolationReason("BLACK_HOLE_ROUTE_DETECTED");
        /// <summary>
        /// Constant BLACK_HOLE_ROUTE_DETECTED_IN_FIREWALL_SUBNET for ViolationReason
        /// </summary>
        public static readonly ViolationReason BLACK_HOLE_ROUTE_DETECTED_IN_FIREWALL_SUBNET = new ViolationReason("BLACK_HOLE_ROUTE_DETECTED_IN_FIREWALL_SUBNET");
        /// <summary>
        /// Constant FIREWALL_SUBNET_IS_OUT_OF_SCOPE for ViolationReason
        /// </summary>
        public static readonly ViolationReason FIREWALL_SUBNET_IS_OUT_OF_SCOPE = new ViolationReason("FIREWALL_SUBNET_IS_OUT_OF_SCOPE");
        /// <summary>
        /// Constant FIREWALL_SUBNET_MISSING_EXPECTED_ROUTE for ViolationReason
        /// </summary>
        public static readonly ViolationReason FIREWALL_SUBNET_MISSING_EXPECTED_ROUTE = new ViolationReason("FIREWALL_SUBNET_MISSING_EXPECTED_ROUTE");
        /// <summary>
        /// Constant FMS_CREATED_SECURITY_GROUP_EDITED for ViolationReason
        /// </summary>
        public static readonly ViolationReason FMS_CREATED_SECURITY_GROUP_EDITED = new ViolationReason("FMS_CREATED_SECURITY_GROUP_EDITED");
        /// <summary>
        /// Constant INTERNET_GATEWAY_MISSING_EXPECTED_ROUTE for ViolationReason
        /// </summary>
        public static readonly ViolationReason INTERNET_GATEWAY_MISSING_EXPECTED_ROUTE = new ViolationReason("INTERNET_GATEWAY_MISSING_EXPECTED_ROUTE");
        /// <summary>
        /// Constant INTERNET_TRAFFIC_NOT_INSPECTED for ViolationReason
        /// </summary>
        public static readonly ViolationReason INTERNET_TRAFFIC_NOT_INSPECTED = new ViolationReason("INTERNET_TRAFFIC_NOT_INSPECTED");
        /// <summary>
        /// Constant INVALID_ROUTE_CONFIGURATION for ViolationReason
        /// </summary>
        public static readonly ViolationReason INVALID_ROUTE_CONFIGURATION = new ViolationReason("INVALID_ROUTE_CONFIGURATION");
        /// <summary>
        /// Constant MISSING_EXPECTED_ROUTE_TABLE for ViolationReason
        /// </summary>
        public static readonly ViolationReason MISSING_EXPECTED_ROUTE_TABLE = new ViolationReason("MISSING_EXPECTED_ROUTE_TABLE");
        /// <summary>
        /// Constant MISSING_FIREWALL for ViolationReason
        /// </summary>
        public static readonly ViolationReason MISSING_FIREWALL = new ViolationReason("MISSING_FIREWALL");
        /// <summary>
        /// Constant MISSING_FIREWALL_SUBNET_IN_AZ for ViolationReason
        /// </summary>
        public static readonly ViolationReason MISSING_FIREWALL_SUBNET_IN_AZ = new ViolationReason("MISSING_FIREWALL_SUBNET_IN_AZ");
        /// <summary>
        /// Constant MISSING_TARGET_GATEWAY for ViolationReason
        /// </summary>
        public static readonly ViolationReason MISSING_TARGET_GATEWAY = new ViolationReason("MISSING_TARGET_GATEWAY");
        /// <summary>
        /// Constant NETWORK_FIREWALL_POLICY_MODIFIED for ViolationReason
        /// </summary>
        public static readonly ViolationReason NETWORK_FIREWALL_POLICY_MODIFIED = new ViolationReason("NETWORK_FIREWALL_POLICY_MODIFIED");
        /// <summary>
        /// Constant RESOURCE_INCORRECT_WEB_ACL for ViolationReason
        /// </summary>
        public static readonly ViolationReason RESOURCE_INCORRECT_WEB_ACL = new ViolationReason("RESOURCE_INCORRECT_WEB_ACL");
        /// <summary>
        /// Constant RESOURCE_MISSING_DNS_FIREWALL for ViolationReason
        /// </summary>
        public static readonly ViolationReason RESOURCE_MISSING_DNS_FIREWALL = new ViolationReason("RESOURCE_MISSING_DNS_FIREWALL");
        /// <summary>
        /// Constant RESOURCE_MISSING_SECURITY_GROUP for ViolationReason
        /// </summary>
        public static readonly ViolationReason RESOURCE_MISSING_SECURITY_GROUP = new ViolationReason("RESOURCE_MISSING_SECURITY_GROUP");
        /// <summary>
        /// Constant RESOURCE_MISSING_SHIELD_PROTECTION for ViolationReason
        /// </summary>
        public static readonly ViolationReason RESOURCE_MISSING_SHIELD_PROTECTION = new ViolationReason("RESOURCE_MISSING_SHIELD_PROTECTION");
        /// <summary>
        /// Constant RESOURCE_MISSING_WEB_ACL for ViolationReason
        /// </summary>
        public static readonly ViolationReason RESOURCE_MISSING_WEB_ACL = new ViolationReason("RESOURCE_MISSING_WEB_ACL");
        /// <summary>
        /// Constant RESOURCE_MISSING_WEB_ACL_OR_SHIELD_PROTECTION for ViolationReason
        /// </summary>
        public static readonly ViolationReason RESOURCE_MISSING_WEB_ACL_OR_SHIELD_PROTECTION = new ViolationReason("RESOURCE_MISSING_WEB_ACL_OR_SHIELD_PROTECTION");
        /// <summary>
        /// Constant RESOURCE_VIOLATES_AUDIT_SECURITY_GROUP for ViolationReason
        /// </summary>
        public static readonly ViolationReason RESOURCE_VIOLATES_AUDIT_SECURITY_GROUP = new ViolationReason("RESOURCE_VIOLATES_AUDIT_SECURITY_GROUP");
        /// <summary>
        /// Constant ROUTE_HAS_OUT_OF_SCOPE_ENDPOINT for ViolationReason
        /// </summary>
        public static readonly ViolationReason ROUTE_HAS_OUT_OF_SCOPE_ENDPOINT = new ViolationReason("ROUTE_HAS_OUT_OF_SCOPE_ENDPOINT");
        /// <summary>
        /// Constant SECURITY_GROUP_REDUNDANT for ViolationReason
        /// </summary>
        public static readonly ViolationReason SECURITY_GROUP_REDUNDANT = new ViolationReason("SECURITY_GROUP_REDUNDANT");
        /// <summary>
        /// Constant SECURITY_GROUP_UNUSED for ViolationReason
        /// </summary>
        public static readonly ViolationReason SECURITY_GROUP_UNUSED = new ViolationReason("SECURITY_GROUP_UNUSED");
        /// <summary>
        /// Constant TRAFFIC_INSPECTION_CROSSES_AZ_BOUNDARY for ViolationReason
        /// </summary>
        public static readonly ViolationReason TRAFFIC_INSPECTION_CROSSES_AZ_BOUNDARY = new ViolationReason("TRAFFIC_INSPECTION_CROSSES_AZ_BOUNDARY");
        /// <summary>
        /// Constant UNEXPECTED_FIREWALL_ROUTES for ViolationReason
        /// </summary>
        public static readonly ViolationReason UNEXPECTED_FIREWALL_ROUTES = new ViolationReason("UNEXPECTED_FIREWALL_ROUTES");
        /// <summary>
        /// Constant UNEXPECTED_TARGET_GATEWAY_ROUTES for ViolationReason
        /// </summary>
        public static readonly ViolationReason UNEXPECTED_TARGET_GATEWAY_ROUTES = new ViolationReason("UNEXPECTED_TARGET_GATEWAY_ROUTES");
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