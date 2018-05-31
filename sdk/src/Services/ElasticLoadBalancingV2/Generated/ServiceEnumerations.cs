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
        /// Constant Forward for ActionTypeEnum
        /// </summary>
        public static readonly ActionTypeEnum Forward = new ActionTypeEnum("forward");

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
    /// Constants used for properties of type IpAddressType.
    /// </summary>
    public class IpAddressType : ConstantClass
    {

        /// <summary>
        /// Constant Dualstack for IpAddressType
        /// </summary>
        public static readonly IpAddressType Dualstack = new IpAddressType("dualstack");
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
    /// Constants used for properties of type ProtocolEnum.
    /// </summary>
    public class ProtocolEnum : ConstantClass
    {

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
        /// Constant Instance for TargetTypeEnum
        /// </summary>
        public static readonly TargetTypeEnum Instance = new TargetTypeEnum("instance");
        /// <summary>
        /// Constant Ip for TargetTypeEnum
        /// </summary>
        public static readonly TargetTypeEnum Ip = new TargetTypeEnum("ip");

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

}