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
 * Do not modify this file. This file is generated from the elasticloadbalancingv2-2015-12-01.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.ElasticLoadBalancingV2
{

    /// <summary>
    /// Constants used for properties of type ActionTypeEnum.
    /// </summary>
    public class ActionTypeEnum : ConstantClass
    {

        /// <summary>
        /// Constant AuthenticateCognito for ActionTypeEnum
        /// </summary>
        public static readonly ActionTypeEnum AuthenticateCognito = new ActionTypeEnum("authenticate-cognito");
        /// <summary>
        /// Constant AuthenticateOidc for ActionTypeEnum
        /// </summary>
        public static readonly ActionTypeEnum AuthenticateOidc = new ActionTypeEnum("authenticate-oidc");
        /// <summary>
        /// Constant FixedResponse for ActionTypeEnum
        /// </summary>
        public static readonly ActionTypeEnum FixedResponse = new ActionTypeEnum("fixed-response");
        /// <summary>
        /// Constant Forward for ActionTypeEnum
        /// </summary>
        public static readonly ActionTypeEnum Forward = new ActionTypeEnum("forward");
        /// <summary>
        /// Constant Redirect for ActionTypeEnum
        /// </summary>
        public static readonly ActionTypeEnum Redirect = new ActionTypeEnum("redirect");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ActionTypeEnum(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ActionTypeEnum FindValue(string value)
        {
            return FindValue<ActionTypeEnum>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ActionTypeEnum(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AdvertiseTrustStoreCaNamesEnum.
    /// </summary>
    public class AdvertiseTrustStoreCaNamesEnum : ConstantClass
    {

        /// <summary>
        /// Constant Off for AdvertiseTrustStoreCaNamesEnum
        /// </summary>
        public static readonly AdvertiseTrustStoreCaNamesEnum Off = new AdvertiseTrustStoreCaNamesEnum("off");
        /// <summary>
        /// Constant On for AdvertiseTrustStoreCaNamesEnum
        /// </summary>
        public static readonly AdvertiseTrustStoreCaNamesEnum On = new AdvertiseTrustStoreCaNamesEnum("on");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AdvertiseTrustStoreCaNamesEnum(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AdvertiseTrustStoreCaNamesEnum FindValue(string value)
        {
            return FindValue<AdvertiseTrustStoreCaNamesEnum>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AdvertiseTrustStoreCaNamesEnum(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AnomalyResultEnum.
    /// </summary>
    public class AnomalyResultEnum : ConstantClass
    {

        /// <summary>
        /// Constant Anomalous for AnomalyResultEnum
        /// </summary>
        public static readonly AnomalyResultEnum Anomalous = new AnomalyResultEnum("anomalous");
        /// <summary>
        /// Constant Normal for AnomalyResultEnum
        /// </summary>
        public static readonly AnomalyResultEnum Normal = new AnomalyResultEnum("normal");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AnomalyResultEnum(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AnomalyResultEnum FindValue(string value)
        {
            return FindValue<AnomalyResultEnum>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AnomalyResultEnum(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AuthenticateCognitoActionConditionalBehaviorEnum.
    /// </summary>
    public class AuthenticateCognitoActionConditionalBehaviorEnum : ConstantClass
    {

        /// <summary>
        /// Constant Allow for AuthenticateCognitoActionConditionalBehaviorEnum
        /// </summary>
        public static readonly AuthenticateCognitoActionConditionalBehaviorEnum Allow = new AuthenticateCognitoActionConditionalBehaviorEnum("allow");
        /// <summary>
        /// Constant Authenticate for AuthenticateCognitoActionConditionalBehaviorEnum
        /// </summary>
        public static readonly AuthenticateCognitoActionConditionalBehaviorEnum Authenticate = new AuthenticateCognitoActionConditionalBehaviorEnum("authenticate");
        /// <summary>
        /// Constant Deny for AuthenticateCognitoActionConditionalBehaviorEnum
        /// </summary>
        public static readonly AuthenticateCognitoActionConditionalBehaviorEnum Deny = new AuthenticateCognitoActionConditionalBehaviorEnum("deny");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AuthenticateCognitoActionConditionalBehaviorEnum(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AuthenticateCognitoActionConditionalBehaviorEnum FindValue(string value)
        {
            return FindValue<AuthenticateCognitoActionConditionalBehaviorEnum>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AuthenticateCognitoActionConditionalBehaviorEnum(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AuthenticateOidcActionConditionalBehaviorEnum.
    /// </summary>
    public class AuthenticateOidcActionConditionalBehaviorEnum : ConstantClass
    {

        /// <summary>
        /// Constant Allow for AuthenticateOidcActionConditionalBehaviorEnum
        /// </summary>
        public static readonly AuthenticateOidcActionConditionalBehaviorEnum Allow = new AuthenticateOidcActionConditionalBehaviorEnum("allow");
        /// <summary>
        /// Constant Authenticate for AuthenticateOidcActionConditionalBehaviorEnum
        /// </summary>
        public static readonly AuthenticateOidcActionConditionalBehaviorEnum Authenticate = new AuthenticateOidcActionConditionalBehaviorEnum("authenticate");
        /// <summary>
        /// Constant Deny for AuthenticateOidcActionConditionalBehaviorEnum
        /// </summary>
        public static readonly AuthenticateOidcActionConditionalBehaviorEnum Deny = new AuthenticateOidcActionConditionalBehaviorEnum("deny");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AuthenticateOidcActionConditionalBehaviorEnum(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AuthenticateOidcActionConditionalBehaviorEnum FindValue(string value)
        {
            return FindValue<AuthenticateOidcActionConditionalBehaviorEnum>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AuthenticateOidcActionConditionalBehaviorEnum(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CapacityReservationStateEnum.
    /// </summary>
    public class CapacityReservationStateEnum : ConstantClass
    {

        /// <summary>
        /// Constant Failed for CapacityReservationStateEnum
        /// </summary>
        public static readonly CapacityReservationStateEnum Failed = new CapacityReservationStateEnum("failed");
        /// <summary>
        /// Constant Pending for CapacityReservationStateEnum
        /// </summary>
        public static readonly CapacityReservationStateEnum Pending = new CapacityReservationStateEnum("pending");
        /// <summary>
        /// Constant Provisioned for CapacityReservationStateEnum
        /// </summary>
        public static readonly CapacityReservationStateEnum Provisioned = new CapacityReservationStateEnum("provisioned");
        /// <summary>
        /// Constant Rebalancing for CapacityReservationStateEnum
        /// </summary>
        public static readonly CapacityReservationStateEnum Rebalancing = new CapacityReservationStateEnum("rebalancing");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CapacityReservationStateEnum(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CapacityReservationStateEnum FindValue(string value)
        {
            return FindValue<CapacityReservationStateEnum>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CapacityReservationStateEnum(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DescribeTargetHealthInputIncludeEnum.
    /// </summary>
    public class DescribeTargetHealthInputIncludeEnum : ConstantClass
    {

        /// <summary>
        /// Constant All for DescribeTargetHealthInputIncludeEnum
        /// </summary>
        public static readonly DescribeTargetHealthInputIncludeEnum All = new DescribeTargetHealthInputIncludeEnum("All");
        /// <summary>
        /// Constant AnomalyDetection for DescribeTargetHealthInputIncludeEnum
        /// </summary>
        public static readonly DescribeTargetHealthInputIncludeEnum AnomalyDetection = new DescribeTargetHealthInputIncludeEnum("AnomalyDetection");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DescribeTargetHealthInputIncludeEnum(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DescribeTargetHealthInputIncludeEnum FindValue(string value)
        {
            return FindValue<DescribeTargetHealthInputIncludeEnum>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DescribeTargetHealthInputIncludeEnum(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type EnablePrefixForIpv6SourceNatEnum.
    /// </summary>
    public class EnablePrefixForIpv6SourceNatEnum : ConstantClass
    {

        /// <summary>
        /// Constant Off for EnablePrefixForIpv6SourceNatEnum
        /// </summary>
        public static readonly EnablePrefixForIpv6SourceNatEnum Off = new EnablePrefixForIpv6SourceNatEnum("off");
        /// <summary>
        /// Constant On for EnablePrefixForIpv6SourceNatEnum
        /// </summary>
        public static readonly EnablePrefixForIpv6SourceNatEnum On = new EnablePrefixForIpv6SourceNatEnum("on");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EnablePrefixForIpv6SourceNatEnum(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EnablePrefixForIpv6SourceNatEnum FindValue(string value)
        {
            return FindValue<EnablePrefixForIpv6SourceNatEnum>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EnablePrefixForIpv6SourceNatEnum(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type EnforceSecurityGroupInboundRulesOnPrivateLinkTrafficEnum.
    /// </summary>
    public class EnforceSecurityGroupInboundRulesOnPrivateLinkTrafficEnum : ConstantClass
    {

        /// <summary>
        /// Constant Off for EnforceSecurityGroupInboundRulesOnPrivateLinkTrafficEnum
        /// </summary>
        public static readonly EnforceSecurityGroupInboundRulesOnPrivateLinkTrafficEnum Off = new EnforceSecurityGroupInboundRulesOnPrivateLinkTrafficEnum("off");
        /// <summary>
        /// Constant On for EnforceSecurityGroupInboundRulesOnPrivateLinkTrafficEnum
        /// </summary>
        public static readonly EnforceSecurityGroupInboundRulesOnPrivateLinkTrafficEnum On = new EnforceSecurityGroupInboundRulesOnPrivateLinkTrafficEnum("on");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EnforceSecurityGroupInboundRulesOnPrivateLinkTrafficEnum(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EnforceSecurityGroupInboundRulesOnPrivateLinkTrafficEnum FindValue(string value)
        {
            return FindValue<EnforceSecurityGroupInboundRulesOnPrivateLinkTrafficEnum>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EnforceSecurityGroupInboundRulesOnPrivateLinkTrafficEnum(string value)
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
    /// Constants used for properties of type LoadBalancerSchemeEnum.
    /// </summary>
    public class LoadBalancerSchemeEnum : ConstantClass
    {

        /// <summary>
        /// Constant Internal for LoadBalancerSchemeEnum
        /// </summary>
        public static readonly LoadBalancerSchemeEnum Internal = new LoadBalancerSchemeEnum("internal");
        /// <summary>
        /// Constant InternetFacing for LoadBalancerSchemeEnum
        /// </summary>
        public static readonly LoadBalancerSchemeEnum InternetFacing = new LoadBalancerSchemeEnum("internet-facing");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public LoadBalancerSchemeEnum(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LoadBalancerSchemeEnum FindValue(string value)
        {
            return FindValue<LoadBalancerSchemeEnum>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator LoadBalancerSchemeEnum(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type LoadBalancerStateEnum.
    /// </summary>
    public class LoadBalancerStateEnum : ConstantClass
    {

        /// <summary>
        /// Constant Active for LoadBalancerStateEnum
        /// </summary>
        public static readonly LoadBalancerStateEnum Active = new LoadBalancerStateEnum("active");
        /// <summary>
        /// Constant Active_impaired for LoadBalancerStateEnum
        /// </summary>
        public static readonly LoadBalancerStateEnum Active_impaired = new LoadBalancerStateEnum("active_impaired");
        /// <summary>
        /// Constant Failed for LoadBalancerStateEnum
        /// </summary>
        public static readonly LoadBalancerStateEnum Failed = new LoadBalancerStateEnum("failed");
        /// <summary>
        /// Constant Provisioning for LoadBalancerStateEnum
        /// </summary>
        public static readonly LoadBalancerStateEnum Provisioning = new LoadBalancerStateEnum("provisioning");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public LoadBalancerStateEnum(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LoadBalancerStateEnum FindValue(string value)
        {
            return FindValue<LoadBalancerStateEnum>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator LoadBalancerStateEnum(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type LoadBalancerTypeEnum.
    /// </summary>
    public class LoadBalancerTypeEnum : ConstantClass
    {

        /// <summary>
        /// Constant Application for LoadBalancerTypeEnum
        /// </summary>
        public static readonly LoadBalancerTypeEnum Application = new LoadBalancerTypeEnum("application");
        /// <summary>
        /// Constant Gateway for LoadBalancerTypeEnum
        /// </summary>
        public static readonly LoadBalancerTypeEnum Gateway = new LoadBalancerTypeEnum("gateway");
        /// <summary>
        /// Constant Network for LoadBalancerTypeEnum
        /// </summary>
        public static readonly LoadBalancerTypeEnum Network = new LoadBalancerTypeEnum("network");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public LoadBalancerTypeEnum(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LoadBalancerTypeEnum FindValue(string value)
        {
            return FindValue<LoadBalancerTypeEnum>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator LoadBalancerTypeEnum(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type MitigationInEffectEnum.
    /// </summary>
    public class MitigationInEffectEnum : ConstantClass
    {

        /// <summary>
        /// Constant No for MitigationInEffectEnum
        /// </summary>
        public static readonly MitigationInEffectEnum No = new MitigationInEffectEnum("no");
        /// <summary>
        /// Constant Yes for MitigationInEffectEnum
        /// </summary>
        public static readonly MitigationInEffectEnum Yes = new MitigationInEffectEnum("yes");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MitigationInEffectEnum(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MitigationInEffectEnum FindValue(string value)
        {
            return FindValue<MitigationInEffectEnum>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MitigationInEffectEnum(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ProtocolEnum.
    /// </summary>
    public class ProtocolEnum : ConstantClass
    {

        /// <summary>
        /// Constant GENEVE for ProtocolEnum
        /// </summary>
        public static readonly ProtocolEnum GENEVE = new ProtocolEnum("GENEVE");
        /// <summary>
        /// Constant HTTP for ProtocolEnum
        /// </summary>
        public static readonly ProtocolEnum HTTP = new ProtocolEnum("HTTP");
        /// <summary>
        /// Constant HTTPS for ProtocolEnum
        /// </summary>
        public static readonly ProtocolEnum HTTPS = new ProtocolEnum("HTTPS");
        /// <summary>
        /// Constant TCP for ProtocolEnum
        /// </summary>
        public static readonly ProtocolEnum TCP = new ProtocolEnum("TCP");
        /// <summary>
        /// Constant TCP_UDP for ProtocolEnum
        /// </summary>
        public static readonly ProtocolEnum TCP_UDP = new ProtocolEnum("TCP_UDP");
        /// <summary>
        /// Constant TLS for ProtocolEnum
        /// </summary>
        public static readonly ProtocolEnum TLS = new ProtocolEnum("TLS");
        /// <summary>
        /// Constant UDP for ProtocolEnum
        /// </summary>
        public static readonly ProtocolEnum UDP = new ProtocolEnum("UDP");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ProtocolEnum(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ProtocolEnum FindValue(string value)
        {
            return FindValue<ProtocolEnum>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ProtocolEnum(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RedirectActionStatusCodeEnum.
    /// </summary>
    public class RedirectActionStatusCodeEnum : ConstantClass
    {

        /// <summary>
        /// Constant HTTP_301 for RedirectActionStatusCodeEnum
        /// </summary>
        public static readonly RedirectActionStatusCodeEnum HTTP_301 = new RedirectActionStatusCodeEnum("HTTP_301");
        /// <summary>
        /// Constant HTTP_302 for RedirectActionStatusCodeEnum
        /// </summary>
        public static readonly RedirectActionStatusCodeEnum HTTP_302 = new RedirectActionStatusCodeEnum("HTTP_302");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RedirectActionStatusCodeEnum(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RedirectActionStatusCodeEnum FindValue(string value)
        {
            return FindValue<RedirectActionStatusCodeEnum>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RedirectActionStatusCodeEnum(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RemoveIpamPoolEnum.
    /// </summary>
    public class RemoveIpamPoolEnum : ConstantClass
    {

        /// <summary>
        /// Constant Ipv4 for RemoveIpamPoolEnum
        /// </summary>
        public static readonly RemoveIpamPoolEnum Ipv4 = new RemoveIpamPoolEnum("ipv4");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RemoveIpamPoolEnum(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RemoveIpamPoolEnum FindValue(string value)
        {
            return FindValue<RemoveIpamPoolEnum>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RemoveIpamPoolEnum(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RevocationType.
    /// </summary>
    public class RevocationType : ConstantClass
    {

        /// <summary>
        /// Constant CRL for RevocationType
        /// </summary>
        public static readonly RevocationType CRL = new RevocationType("CRL");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RevocationType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RevocationType FindValue(string value)
        {
            return FindValue<RevocationType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RevocationType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TargetAdministrativeOverrideReasonEnum.
    /// </summary>
    public class TargetAdministrativeOverrideReasonEnum : ConstantClass
    {

        /// <summary>
        /// Constant AdministrativeOverrideNoOverride for TargetAdministrativeOverrideReasonEnum
        /// </summary>
        public static readonly TargetAdministrativeOverrideReasonEnum AdministrativeOverrideNoOverride = new TargetAdministrativeOverrideReasonEnum("AdministrativeOverride.NoOverride");
        /// <summary>
        /// Constant AdministrativeOverrideUnknown for TargetAdministrativeOverrideReasonEnum
        /// </summary>
        public static readonly TargetAdministrativeOverrideReasonEnum AdministrativeOverrideUnknown = new TargetAdministrativeOverrideReasonEnum("AdministrativeOverride.Unknown");
        /// <summary>
        /// Constant AdministrativeOverrideZonalShiftActive for TargetAdministrativeOverrideReasonEnum
        /// </summary>
        public static readonly TargetAdministrativeOverrideReasonEnum AdministrativeOverrideZonalShiftActive = new TargetAdministrativeOverrideReasonEnum("AdministrativeOverride.ZonalShiftActive");
        /// <summary>
        /// Constant AdministrativeOverrideZonalShiftDelegatedToDns for TargetAdministrativeOverrideReasonEnum
        /// </summary>
        public static readonly TargetAdministrativeOverrideReasonEnum AdministrativeOverrideZonalShiftDelegatedToDns = new TargetAdministrativeOverrideReasonEnum("AdministrativeOverride.ZonalShiftDelegatedToDns");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TargetAdministrativeOverrideReasonEnum(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TargetAdministrativeOverrideReasonEnum FindValue(string value)
        {
            return FindValue<TargetAdministrativeOverrideReasonEnum>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TargetAdministrativeOverrideReasonEnum(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TargetAdministrativeOverrideStateEnum.
    /// </summary>
    public class TargetAdministrativeOverrideStateEnum : ConstantClass
    {

        /// <summary>
        /// Constant No_override for TargetAdministrativeOverrideStateEnum
        /// </summary>
        public static readonly TargetAdministrativeOverrideStateEnum No_override = new TargetAdministrativeOverrideStateEnum("no_override");
        /// <summary>
        /// Constant Unknown for TargetAdministrativeOverrideStateEnum
        /// </summary>
        public static readonly TargetAdministrativeOverrideStateEnum Unknown = new TargetAdministrativeOverrideStateEnum("unknown");
        /// <summary>
        /// Constant Zonal_shift_active for TargetAdministrativeOverrideStateEnum
        /// </summary>
        public static readonly TargetAdministrativeOverrideStateEnum Zonal_shift_active = new TargetAdministrativeOverrideStateEnum("zonal_shift_active");
        /// <summary>
        /// Constant Zonal_shift_delegated_to_dns for TargetAdministrativeOverrideStateEnum
        /// </summary>
        public static readonly TargetAdministrativeOverrideStateEnum Zonal_shift_delegated_to_dns = new TargetAdministrativeOverrideStateEnum("zonal_shift_delegated_to_dns");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TargetAdministrativeOverrideStateEnum(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TargetAdministrativeOverrideStateEnum FindValue(string value)
        {
            return FindValue<TargetAdministrativeOverrideStateEnum>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TargetAdministrativeOverrideStateEnum(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TargetGroupIpAddressTypeEnum.
    /// </summary>
    public class TargetGroupIpAddressTypeEnum : ConstantClass
    {

        /// <summary>
        /// Constant Ipv4 for TargetGroupIpAddressTypeEnum
        /// </summary>
        public static readonly TargetGroupIpAddressTypeEnum Ipv4 = new TargetGroupIpAddressTypeEnum("ipv4");
        /// <summary>
        /// Constant Ipv6 for TargetGroupIpAddressTypeEnum
        /// </summary>
        public static readonly TargetGroupIpAddressTypeEnum Ipv6 = new TargetGroupIpAddressTypeEnum("ipv6");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TargetGroupIpAddressTypeEnum(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TargetGroupIpAddressTypeEnum FindValue(string value)
        {
            return FindValue<TargetGroupIpAddressTypeEnum>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TargetGroupIpAddressTypeEnum(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TargetHealthReasonEnum.
    /// </summary>
    public class TargetHealthReasonEnum : ConstantClass
    {

        /// <summary>
        /// Constant ElbInitialHealthChecking for TargetHealthReasonEnum
        /// </summary>
        public static readonly TargetHealthReasonEnum ElbInitialHealthChecking = new TargetHealthReasonEnum("Elb.InitialHealthChecking");
        /// <summary>
        /// Constant ElbInternalError for TargetHealthReasonEnum
        /// </summary>
        public static readonly TargetHealthReasonEnum ElbInternalError = new TargetHealthReasonEnum("Elb.InternalError");
        /// <summary>
        /// Constant ElbRegistrationInProgress for TargetHealthReasonEnum
        /// </summary>
        public static readonly TargetHealthReasonEnum ElbRegistrationInProgress = new TargetHealthReasonEnum("Elb.RegistrationInProgress");
        /// <summary>
        /// Constant TargetDeregistrationInProgress for TargetHealthReasonEnum
        /// </summary>
        public static readonly TargetHealthReasonEnum TargetDeregistrationInProgress = new TargetHealthReasonEnum("Target.DeregistrationInProgress");
        /// <summary>
        /// Constant TargetFailedHealthChecks for TargetHealthReasonEnum
        /// </summary>
        public static readonly TargetHealthReasonEnum TargetFailedHealthChecks = new TargetHealthReasonEnum("Target.FailedHealthChecks");
        /// <summary>
        /// Constant TargetHealthCheckDisabled for TargetHealthReasonEnum
        /// </summary>
        public static readonly TargetHealthReasonEnum TargetHealthCheckDisabled = new TargetHealthReasonEnum("Target.HealthCheckDisabled");
        /// <summary>
        /// Constant TargetInvalidState for TargetHealthReasonEnum
        /// </summary>
        public static readonly TargetHealthReasonEnum TargetInvalidState = new TargetHealthReasonEnum("Target.InvalidState");
        /// <summary>
        /// Constant TargetIpUnusable for TargetHealthReasonEnum
        /// </summary>
        public static readonly TargetHealthReasonEnum TargetIpUnusable = new TargetHealthReasonEnum("Target.IpUnusable");
        /// <summary>
        /// Constant TargetNotInUse for TargetHealthReasonEnum
        /// </summary>
        public static readonly TargetHealthReasonEnum TargetNotInUse = new TargetHealthReasonEnum("Target.NotInUse");
        /// <summary>
        /// Constant TargetNotRegistered for TargetHealthReasonEnum
        /// </summary>
        public static readonly TargetHealthReasonEnum TargetNotRegistered = new TargetHealthReasonEnum("Target.NotRegistered");
        /// <summary>
        /// Constant TargetResponseCodeMismatch for TargetHealthReasonEnum
        /// </summary>
        public static readonly TargetHealthReasonEnum TargetResponseCodeMismatch = new TargetHealthReasonEnum("Target.ResponseCodeMismatch");
        /// <summary>
        /// Constant TargetTimeout for TargetHealthReasonEnum
        /// </summary>
        public static readonly TargetHealthReasonEnum TargetTimeout = new TargetHealthReasonEnum("Target.Timeout");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TargetHealthReasonEnum(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TargetHealthReasonEnum FindValue(string value)
        {
            return FindValue<TargetHealthReasonEnum>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TargetHealthReasonEnum(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TargetHealthStateEnum.
    /// </summary>
    public class TargetHealthStateEnum : ConstantClass
    {

        /// <summary>
        /// Constant Draining for TargetHealthStateEnum
        /// </summary>
        public static readonly TargetHealthStateEnum Draining = new TargetHealthStateEnum("draining");
        /// <summary>
        /// Constant Healthy for TargetHealthStateEnum
        /// </summary>
        public static readonly TargetHealthStateEnum Healthy = new TargetHealthStateEnum("healthy");
        /// <summary>
        /// Constant Initial for TargetHealthStateEnum
        /// </summary>
        public static readonly TargetHealthStateEnum Initial = new TargetHealthStateEnum("initial");
        /// <summary>
        /// Constant Unavailable for TargetHealthStateEnum
        /// </summary>
        public static readonly TargetHealthStateEnum Unavailable = new TargetHealthStateEnum("unavailable");
        /// <summary>
        /// Constant Unhealthy for TargetHealthStateEnum
        /// </summary>
        public static readonly TargetHealthStateEnum Unhealthy = new TargetHealthStateEnum("unhealthy");
        /// <summary>
        /// Constant UnhealthyDraining for TargetHealthStateEnum
        /// </summary>
        public static readonly TargetHealthStateEnum UnhealthyDraining = new TargetHealthStateEnum("unhealthy.draining");
        /// <summary>
        /// Constant Unused for TargetHealthStateEnum
        /// </summary>
        public static readonly TargetHealthStateEnum Unused = new TargetHealthStateEnum("unused");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TargetHealthStateEnum(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TargetHealthStateEnum FindValue(string value)
        {
            return FindValue<TargetHealthStateEnum>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TargetHealthStateEnum(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TargetTypeEnum.
    /// </summary>
    public class TargetTypeEnum : ConstantClass
    {

        /// <summary>
        /// Constant Alb for TargetTypeEnum
        /// </summary>
        public static readonly TargetTypeEnum Alb = new TargetTypeEnum("alb");
        /// <summary>
        /// Constant Instance for TargetTypeEnum
        /// </summary>
        public static readonly TargetTypeEnum Instance = new TargetTypeEnum("instance");
        /// <summary>
        /// Constant Ip for TargetTypeEnum
        /// </summary>
        public static readonly TargetTypeEnum Ip = new TargetTypeEnum("ip");
        /// <summary>
        /// Constant Lambda for TargetTypeEnum
        /// </summary>
        public static readonly TargetTypeEnum Lambda = new TargetTypeEnum("lambda");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TargetTypeEnum(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TargetTypeEnum FindValue(string value)
        {
            return FindValue<TargetTypeEnum>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TargetTypeEnum(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TrustStoreAssociationStatusEnum.
    /// </summary>
    public class TrustStoreAssociationStatusEnum : ConstantClass
    {

        /// <summary>
        /// Constant Active for TrustStoreAssociationStatusEnum
        /// </summary>
        public static readonly TrustStoreAssociationStatusEnum Active = new TrustStoreAssociationStatusEnum("active");
        /// <summary>
        /// Constant Removed for TrustStoreAssociationStatusEnum
        /// </summary>
        public static readonly TrustStoreAssociationStatusEnum Removed = new TrustStoreAssociationStatusEnum("removed");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TrustStoreAssociationStatusEnum(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TrustStoreAssociationStatusEnum FindValue(string value)
        {
            return FindValue<TrustStoreAssociationStatusEnum>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TrustStoreAssociationStatusEnum(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TrustStoreStatus.
    /// </summary>
    public class TrustStoreStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for TrustStoreStatus
        /// </summary>
        public static readonly TrustStoreStatus ACTIVE = new TrustStoreStatus("ACTIVE");
        /// <summary>
        /// Constant CREATING for TrustStoreStatus
        /// </summary>
        public static readonly TrustStoreStatus CREATING = new TrustStoreStatus("CREATING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TrustStoreStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TrustStoreStatus FindValue(string value)
        {
            return FindValue<TrustStoreStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TrustStoreStatus(string value)
        {
            return FindValue(value);
        }
    }

}