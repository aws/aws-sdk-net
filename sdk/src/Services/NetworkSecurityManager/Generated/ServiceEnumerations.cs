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
 * Do not modify this file. This file is generated from the network-security-manager-2025-10-30.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.NetworkSecurityManager
{

    /// <summary>
    /// Constants used for properties of type AdminAccountStatus.
    /// </summary>
    public class AdminAccountStatus : ConstantClass
    {

        /// <summary>
        /// Constant OFFBOARDED for AdminAccountStatus
        /// </summary>
        public static readonly AdminAccountStatus OFFBOARDED = new AdminAccountStatus("OFFBOARDED");
        /// <summary>
        /// Constant ONBOARDED for AdminAccountStatus
        /// </summary>
        public static readonly AdminAccountStatus ONBOARDED = new AdminAccountStatus("ONBOARDED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AdminAccountStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AdminAccountStatus FindValue(string value)
        {
            return FindValue<AdminAccountStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AdminAccountStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type EntityStatus.
    /// </summary>
    public class EntityStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for EntityStatus
        /// </summary>
        public static readonly EntityStatus ACTIVE = new EntityStatus("ACTIVE");
        /// <summary>
        /// Constant DISABLED for EntityStatus
        /// </summary>
        public static readonly EntityStatus DISABLED = new EntityStatus("DISABLED");
        /// <summary>
        /// Constant DRAFT for EntityStatus
        /// </summary>
        public static readonly EntityStatus DRAFT = new EntityStatus("DRAFT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EntityStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EntityStatus FindValue(string value)
        {
            return FindValue<EntityStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EntityStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type EntityStatusFilter.
    /// </summary>
    public class EntityStatusFilter : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for EntityStatusFilter
        /// </summary>
        public static readonly EntityStatusFilter ACTIVE = new EntityStatusFilter("ACTIVE");
        /// <summary>
        /// Constant DISABLED for EntityStatusFilter
        /// </summary>
        public static readonly EntityStatusFilter DISABLED = new EntityStatusFilter("DISABLED");
        /// <summary>
        /// Constant DRAFT for EntityStatusFilter
        /// </summary>
        public static readonly EntityStatusFilter DRAFT = new EntityStatusFilter("DRAFT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EntityStatusFilter(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EntityStatusFilter FindValue(string value)
        {
            return FindValue<EntityStatusFilter>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EntityStatusFilter(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ExistingCustomerWebACLResolution.
    /// </summary>
    public class ExistingCustomerWebACLResolution : ConstantClass
    {

        /// <summary>
        /// Constant NO_REMEDIATION for ExistingCustomerWebACLResolution
        /// </summary>
        public static readonly ExistingCustomerWebACLResolution NO_REMEDIATION = new ExistingCustomerWebACLResolution("NO_REMEDIATION");
        /// <summary>
        /// Constant OVERRIDE_ASSOCIATION for ExistingCustomerWebACLResolution
        /// </summary>
        public static readonly ExistingCustomerWebACLResolution OVERRIDE_ASSOCIATION = new ExistingCustomerWebACLResolution("OVERRIDE_ASSOCIATION");
        /// <summary>
        /// Constant RETROFIT for ExistingCustomerWebACLResolution
        /// </summary>
        public static readonly ExistingCustomerWebACLResolution RETROFIT = new ExistingCustomerWebACLResolution("RETROFIT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ExistingCustomerWebACLResolution(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ExistingCustomerWebACLResolution FindValue(string value)
        {
            return FindValue<ExistingCustomerWebACLResolution>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ExistingCustomerWebACLResolution(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type IpAddressType.
    /// </summary>
    public class IpAddressType : ConstantClass
    {

        /// <summary>
        /// Constant Dualstack for IpAddressType
        /// </summary>
        public static readonly IpAddressType Dualstack = new IpAddressType("dualstack");
        /// <summary>
        /// Constant DualstackWithoutPublicIpv4 for IpAddressType
        /// </summary>
        public static readonly IpAddressType DualstackWithoutPublicIpv4 = new IpAddressType("dualstack-without-public-ipv4");
        /// <summary>
        /// Constant Ipv4 for IpAddressType
        /// </summary>
        public static readonly IpAddressType Ipv4 = new IpAddressType("ipv4");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public IpAddressType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static IpAddressType FindValue(string value)
        {
            return FindValue<IpAddressType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator IpAddressType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PolicyFirewallType.
    /// </summary>
    public class PolicyFirewallType : ConstantClass
    {

        /// <summary>
        /// Constant SHIELD_ADVANCED for PolicyFirewallType
        /// </summary>
        public static readonly PolicyFirewallType SHIELD_ADVANCED = new PolicyFirewallType("SHIELD_ADVANCED");
        /// <summary>
        /// Constant WAF for PolicyFirewallType
        /// </summary>
        public static readonly PolicyFirewallType WAF = new PolicyFirewallType("WAF");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PolicyFirewallType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PolicyFirewallType FindValue(string value)
        {
            return FindValue<PolicyFirewallType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PolicyFirewallType(string value)
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
        /// Constant AWSApiGatewayStage for ResourceType
        /// </summary>
        public static readonly ResourceType AWSApiGatewayStage = new ResourceType("AWS::ApiGateway::Stage");
        /// <summary>
        /// Constant AWSCloudFrontDistribution for ResourceType
        /// </summary>
        public static readonly ResourceType AWSCloudFrontDistribution = new ResourceType("AWS::CloudFront::Distribution");
        /// <summary>
        /// Constant AWSEC2EIP for ResourceType
        /// </summary>
        public static readonly ResourceType AWSEC2EIP = new ResourceType("AWS::EC2::EIP");
        /// <summary>
        /// Constant AWSElasticLoadBalancingLoadBalancer for ResourceType
        /// </summary>
        public static readonly ResourceType AWSElasticLoadBalancingLoadBalancer = new ResourceType("AWS::ElasticLoadBalancing::LoadBalancer");
        /// <summary>
        /// Constant AWSElasticLoadBalancingV2LoadBalancerApplication for ResourceType
        /// </summary>
        public static readonly ResourceType AWSElasticLoadBalancingV2LoadBalancerApplication = new ResourceType("AWS::ElasticLoadBalancingV2::LoadBalancer::application");
        /// <summary>
        /// Constant AWSShieldProtection for ResourceType
        /// </summary>
        public static readonly ResourceType AWSShieldProtection = new ResourceType("AWS::Shield::Protection");
        /// <summary>
        /// Constant AWSShieldRegionalProtection for ResourceType
        /// </summary>
        public static readonly ResourceType AWSShieldRegionalProtection = new ResourceType("AWS::ShieldRegional::Protection");
        /// <summary>
        /// Constant AWSWAFv2WebACL for ResourceType
        /// </summary>
        public static readonly ResourceType AWSWAFv2WebACL = new ResourceType("AWS::WAFv2::WebACL");

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
    /// Constants used for properties of type RuleFirewallType.
    /// </summary>
    public class RuleFirewallType : ConstantClass
    {

        /// <summary>
        /// Constant WAF for RuleFirewallType
        /// </summary>
        public static readonly RuleFirewallType WAF = new RuleFirewallType("WAF");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RuleFirewallType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RuleFirewallType FindValue(string value)
        {
            return FindValue<RuleFirewallType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RuleFirewallType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RuleType.
    /// </summary>
    public class RuleType : ConstantClass
    {

        /// <summary>
        /// Constant CONFIGURATION for RuleType
        /// </summary>
        public static readonly RuleType CONFIGURATION = new RuleType("CONFIGURATION");
        /// <summary>
        /// Constant INSPECTION for RuleType
        /// </summary>
        public static readonly RuleType INSPECTION = new RuleType("INSPECTION");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RuleType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RuleType FindValue(string value)
        {
            return FindValue<RuleType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RuleType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Scheme.
    /// </summary>
    public class Scheme : ConstantClass
    {

        /// <summary>
        /// Constant Internal for Scheme
        /// </summary>
        public static readonly Scheme Internal = new Scheme("internal");
        /// <summary>
        /// Constant InternetFacing for Scheme
        /// </summary>
        public static readonly Scheme InternetFacing = new Scheme("internet-facing");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Scheme(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Scheme FindValue(string value)
        {
            return FindValue<Scheme>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Scheme(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ScopeResourceType.
    /// </summary>
    public class ScopeResourceType : ConstantClass
    {

        /// <summary>
        /// Constant AWSApiGatewayStage for ScopeResourceType
        /// </summary>
        public static readonly ScopeResourceType AWSApiGatewayStage = new ScopeResourceType("AWS::ApiGateway::Stage");
        /// <summary>
        /// Constant AWSCloudFrontDistribution for ScopeResourceType
        /// </summary>
        public static readonly ScopeResourceType AWSCloudFrontDistribution = new ScopeResourceType("AWS::CloudFront::Distribution");
        /// <summary>
        /// Constant AWSEC2EIP for ScopeResourceType
        /// </summary>
        public static readonly ScopeResourceType AWSEC2EIP = new ScopeResourceType("AWS::EC2::EIP");
        /// <summary>
        /// Constant AWSElasticLoadBalancingLoadBalancer for ScopeResourceType
        /// </summary>
        public static readonly ScopeResourceType AWSElasticLoadBalancingLoadBalancer = new ScopeResourceType("AWS::ElasticLoadBalancing::LoadBalancer");
        /// <summary>
        /// Constant AWSElasticLoadBalancingV2LoadBalancerApplication for ScopeResourceType
        /// </summary>
        public static readonly ScopeResourceType AWSElasticLoadBalancingV2LoadBalancerApplication = new ScopeResourceType("AWS::ElasticLoadBalancingV2::LoadBalancer::application");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ScopeResourceType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ScopeResourceType FindValue(string value)
        {
            return FindValue<ScopeResourceType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ScopeResourceType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ServiceResourceType.
    /// </summary>
    public class ServiceResourceType : ConstantClass
    {

        /// <summary>
        /// Constant Deployment for ServiceResourceType
        /// </summary>
        public static readonly ServiceResourceType Deployment = new ServiceResourceType("Deployment");
        /// <summary>
        /// Constant Policy for ServiceResourceType
        /// </summary>
        public static readonly ServiceResourceType Policy = new ServiceResourceType("Policy");
        /// <summary>
        /// Constant Rule for ServiceResourceType
        /// </summary>
        public static readonly ServiceResourceType Rule = new ServiceResourceType("Rule");
        /// <summary>
        /// Constant Scope for ServiceResourceType
        /// </summary>
        public static readonly ServiceResourceType Scope = new ServiceResourceType("Scope");
        /// <summary>
        /// Constant Template for ServiceResourceType
        /// </summary>
        public static readonly ServiceResourceType Template = new ServiceResourceType("Template");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ServiceResourceType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ServiceResourceType FindValue(string value)
        {
            return FindValue<ServiceResourceType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ServiceResourceType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SynchronizationStatus.
    /// </summary>
    public class SynchronizationStatus : ConstantClass
    {

        /// <summary>
        /// Constant IN_SYNC for SynchronizationStatus
        /// </summary>
        public static readonly SynchronizationStatus IN_SYNC = new SynchronizationStatus("IN_SYNC");
        /// <summary>
        /// Constant NOT_APPLICABLE for SynchronizationStatus
        /// </summary>
        public static readonly SynchronizationStatus NOT_APPLICABLE = new SynchronizationStatus("NOT_APPLICABLE");
        /// <summary>
        /// Constant OUT_OF_SYNC for SynchronizationStatus
        /// </summary>
        public static readonly SynchronizationStatus OUT_OF_SYNC = new SynchronizationStatus("OUT_OF_SYNC");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SynchronizationStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SynchronizationStatus FindValue(string value)
        {
            return FindValue<SynchronizationStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SynchronizationStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TemplateFirewallType.
    /// </summary>
    public class TemplateFirewallType : ConstantClass
    {

        /// <summary>
        /// Constant WAF for TemplateFirewallType
        /// </summary>
        public static readonly TemplateFirewallType WAF = new TemplateFirewallType("WAF");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TemplateFirewallType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TemplateFirewallType FindValue(string value)
        {
            return FindValue<TemplateFirewallType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TemplateFirewallType(string value)
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
        /// Constant ACCOUNT_NOT_ONBOARDED for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason ACCOUNT_NOT_ONBOARDED = new ValidationExceptionReason("ACCOUNT_NOT_ONBOARDED");
        /// <summary>
        /// Constant FIELD_VALIDATION_FAILED for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason FIELD_VALIDATION_FAILED = new ValidationExceptionReason("FIELD_VALIDATION_FAILED");
        /// <summary>
        /// Constant OTHER for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason OTHER = new ValidationExceptionReason("OTHER");

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
    /// Constants used for properties of type WAFConfigDataType.
    /// </summary>
    public class WAFConfigDataType : ConstantClass
    {

        /// <summary>
        /// Constant AssociationConfig for WAFConfigDataType
        /// </summary>
        public static readonly WAFConfigDataType AssociationConfig = new WAFConfigDataType("AssociationConfig");
        /// <summary>
        /// Constant CaptchaConfig for WAFConfigDataType
        /// </summary>
        public static readonly WAFConfigDataType CaptchaConfig = new WAFConfigDataType("CaptchaConfig");
        /// <summary>
        /// Constant ChallengeConfig for WAFConfigDataType
        /// </summary>
        public static readonly WAFConfigDataType ChallengeConfig = new WAFConfigDataType("ChallengeConfig");
        /// <summary>
        /// Constant CustomResponseBodies for WAFConfigDataType
        /// </summary>
        public static readonly WAFConfigDataType CustomResponseBodies = new WAFConfigDataType("CustomResponseBodies");
        /// <summary>
        /// Constant DataProtectionConfig for WAFConfigDataType
        /// </summary>
        public static readonly WAFConfigDataType DataProtectionConfig = new WAFConfigDataType("DataProtectionConfig");
        /// <summary>
        /// Constant DefaultAction for WAFConfigDataType
        /// </summary>
        public static readonly WAFConfigDataType DefaultAction = new WAFConfigDataType("DefaultAction");
        /// <summary>
        /// Constant LoggingConfiguration for WAFConfigDataType
        /// </summary>
        public static readonly WAFConfigDataType LoggingConfiguration = new WAFConfigDataType("LoggingConfiguration");
        /// <summary>
        /// Constant OnSourceDDoSProtectionConfig for WAFConfigDataType
        /// </summary>
        public static readonly WAFConfigDataType OnSourceDDoSProtectionConfig = new WAFConfigDataType("OnSourceDDoSProtectionConfig");
        /// <summary>
        /// Constant TokenDomains for WAFConfigDataType
        /// </summary>
        public static readonly WAFConfigDataType TokenDomains = new WAFConfigDataType("TokenDomains");
        /// <summary>
        /// Constant VisibilityConfig for WAFConfigDataType
        /// </summary>
        public static readonly WAFConfigDataType VisibilityConfig = new WAFConfigDataType("VisibilityConfig");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public WAFConfigDataType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static WAFConfigDataType FindValue(string value)
        {
            return FindValue<WAFConfigDataType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator WAFConfigDataType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type WAFConflictResolutionOptions.
    /// </summary>
    public class WAFConflictResolutionOptions : ConstantClass
    {

        /// <summary>
        /// Constant MERGE_WHERE_APPLICABLE for WAFConflictResolutionOptions
        /// </summary>
        public static readonly WAFConflictResolutionOptions MERGE_WHERE_APPLICABLE = new WAFConflictResolutionOptions("MERGE_WHERE_APPLICABLE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public WAFConflictResolutionOptions(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static WAFConflictResolutionOptions FindValue(string value)
        {
            return FindValue<WAFConflictResolutionOptions>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator WAFConflictResolutionOptions(string value)
        {
            return FindValue(value);
        }
    }

}