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
 * Do not modify this file. This file is generated from the route53globalresolver-2022-09-27.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.Route53GlobalResolver
{

    /// <summary>
    /// Constants used for properties of type BlockOverrideDnsQueryType.
    /// </summary>
    public class BlockOverrideDnsQueryType : ConstantClass
    {

        /// <summary>
        /// Constant CNAME for BlockOverrideDnsQueryType
        /// </summary>
        public static readonly BlockOverrideDnsQueryType CNAME = new BlockOverrideDnsQueryType("CNAME");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public BlockOverrideDnsQueryType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static BlockOverrideDnsQueryType FindValue(string value)
        {
            return FindValue<BlockOverrideDnsQueryType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator BlockOverrideDnsQueryType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ConfidenceThreshold.
    /// </summary>
    public class ConfidenceThreshold : ConstantClass
    {

        /// <summary>
        /// Constant HIGH for ConfidenceThreshold
        /// </summary>
        public static readonly ConfidenceThreshold HIGH = new ConfidenceThreshold("HIGH");
        /// <summary>
        /// Constant LOW for ConfidenceThreshold
        /// </summary>
        public static readonly ConfidenceThreshold LOW = new ConfidenceThreshold("LOW");
        /// <summary>
        /// Constant MEDIUM for ConfidenceThreshold
        /// </summary>
        public static readonly ConfidenceThreshold MEDIUM = new ConfidenceThreshold("MEDIUM");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ConfidenceThreshold(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ConfidenceThreshold FindValue(string value)
        {
            return FindValue<ConfidenceThreshold>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ConfidenceThreshold(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CRResourceStatus.
    /// </summary>
    public class CRResourceStatus : ConstantClass
    {

        /// <summary>
        /// Constant CREATING for CRResourceStatus
        /// </summary>
        public static readonly CRResourceStatus CREATING = new CRResourceStatus("CREATING");
        /// <summary>
        /// Constant DELETING for CRResourceStatus
        /// </summary>
        public static readonly CRResourceStatus DELETING = new CRResourceStatus("DELETING");
        /// <summary>
        /// Constant OPERATIONAL for CRResourceStatus
        /// </summary>
        public static readonly CRResourceStatus OPERATIONAL = new CRResourceStatus("OPERATIONAL");
        /// <summary>
        /// Constant UPDATING for CRResourceStatus
        /// </summary>
        public static readonly CRResourceStatus UPDATING = new CRResourceStatus("UPDATING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CRResourceStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CRResourceStatus FindValue(string value)
        {
            return FindValue<CRResourceStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CRResourceStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DnsAdvancedProtection.
    /// </summary>
    public class DnsAdvancedProtection : ConstantClass
    {

        /// <summary>
        /// Constant DGA for DnsAdvancedProtection
        /// </summary>
        public static readonly DnsAdvancedProtection DGA = new DnsAdvancedProtection("DGA");
        /// <summary>
        /// Constant DNS_TUNNELING for DnsAdvancedProtection
        /// </summary>
        public static readonly DnsAdvancedProtection DNS_TUNNELING = new DnsAdvancedProtection("DNS_TUNNELING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DnsAdvancedProtection(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DnsAdvancedProtection FindValue(string value)
        {
            return FindValue<DnsAdvancedProtection>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DnsAdvancedProtection(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DnsProtocol.
    /// </summary>
    public class DnsProtocol : ConstantClass
    {

        /// <summary>
        /// Constant DO53 for DnsProtocol
        /// </summary>
        public static readonly DnsProtocol DO53 = new DnsProtocol("DO53");
        /// <summary>
        /// Constant DOH for DnsProtocol
        /// </summary>
        public static readonly DnsProtocol DOH = new DnsProtocol("DOH");
        /// <summary>
        /// Constant DOT for DnsProtocol
        /// </summary>
        public static readonly DnsProtocol DOT = new DnsProtocol("DOT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DnsProtocol(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DnsProtocol FindValue(string value)
        {
            return FindValue<DnsProtocol>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DnsProtocol(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DnsSecValidationType.
    /// </summary>
    public class DnsSecValidationType : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for DnsSecValidationType
        /// </summary>
        public static readonly DnsSecValidationType DISABLED = new DnsSecValidationType("DISABLED");
        /// <summary>
        /// Constant ENABLED for DnsSecValidationType
        /// </summary>
        public static readonly DnsSecValidationType ENABLED = new DnsSecValidationType("ENABLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DnsSecValidationType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DnsSecValidationType FindValue(string value)
        {
            return FindValue<DnsSecValidationType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DnsSecValidationType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type EdnsClientSubnetType.
    /// </summary>
    public class EdnsClientSubnetType : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for EdnsClientSubnetType
        /// </summary>
        public static readonly EdnsClientSubnetType DISABLED = new EdnsClientSubnetType("DISABLED");
        /// <summary>
        /// Constant ENABLED for EdnsClientSubnetType
        /// </summary>
        public static readonly EdnsClientSubnetType ENABLED = new EdnsClientSubnetType("ENABLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EdnsClientSubnetType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EdnsClientSubnetType FindValue(string value)
        {
            return FindValue<EdnsClientSubnetType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EdnsClientSubnetType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type FirewallBlockResponse.
    /// </summary>
    public class FirewallBlockResponse : ConstantClass
    {

        /// <summary>
        /// Constant NODATA for FirewallBlockResponse
        /// </summary>
        public static readonly FirewallBlockResponse NODATA = new FirewallBlockResponse("NODATA");
        /// <summary>
        /// Constant NXDOMAIN for FirewallBlockResponse
        /// </summary>
        public static readonly FirewallBlockResponse NXDOMAIN = new FirewallBlockResponse("NXDOMAIN");
        /// <summary>
        /// Constant OVERRIDE for FirewallBlockResponse
        /// </summary>
        public static readonly FirewallBlockResponse OVERRIDE = new FirewallBlockResponse("OVERRIDE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FirewallBlockResponse(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FirewallBlockResponse FindValue(string value)
        {
            return FindValue<FirewallBlockResponse>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FirewallBlockResponse(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type FirewallRuleAction.
    /// </summary>
    public class FirewallRuleAction : ConstantClass
    {

        /// <summary>
        /// Constant ALERT for FirewallRuleAction
        /// </summary>
        public static readonly FirewallRuleAction ALERT = new FirewallRuleAction("ALERT");
        /// <summary>
        /// Constant ALLOW for FirewallRuleAction
        /// </summary>
        public static readonly FirewallRuleAction ALLOW = new FirewallRuleAction("ALLOW");
        /// <summary>
        /// Constant BLOCK for FirewallRuleAction
        /// </summary>
        public static readonly FirewallRuleAction BLOCK = new FirewallRuleAction("BLOCK");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FirewallRuleAction(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FirewallRuleAction FindValue(string value)
        {
            return FindValue<FirewallRuleAction>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FirewallRuleAction(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type FirewallRulesFailOpenType.
    /// </summary>
    public class FirewallRulesFailOpenType : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for FirewallRulesFailOpenType
        /// </summary>
        public static readonly FirewallRulesFailOpenType DISABLED = new FirewallRulesFailOpenType("DISABLED");
        /// <summary>
        /// Constant ENABLED for FirewallRulesFailOpenType
        /// </summary>
        public static readonly FirewallRulesFailOpenType ENABLED = new FirewallRulesFailOpenType("ENABLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FirewallRulesFailOpenType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FirewallRulesFailOpenType FindValue(string value)
        {
            return FindValue<FirewallRulesFailOpenType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FirewallRulesFailOpenType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type HostedZoneAssociationStatus.
    /// </summary>
    public class HostedZoneAssociationStatus : ConstantClass
    {

        /// <summary>
        /// Constant CREATING for HostedZoneAssociationStatus
        /// </summary>
        public static readonly HostedZoneAssociationStatus CREATING = new HostedZoneAssociationStatus("CREATING");
        /// <summary>
        /// Constant DELETING for HostedZoneAssociationStatus
        /// </summary>
        public static readonly HostedZoneAssociationStatus DELETING = new HostedZoneAssociationStatus("DELETING");
        /// <summary>
        /// Constant OPERATIONAL for HostedZoneAssociationStatus
        /// </summary>
        public static readonly HostedZoneAssociationStatus OPERATIONAL = new HostedZoneAssociationStatus("OPERATIONAL");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public HostedZoneAssociationStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static HostedZoneAssociationStatus FindValue(string value)
        {
            return FindValue<HostedZoneAssociationStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator HostedZoneAssociationStatus(string value)
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
        /// Constant IPV4 for IpAddressType
        /// </summary>
        public static readonly IpAddressType IPV4 = new IpAddressType("IPV4");
        /// <summary>
        /// Constant IPV6 for IpAddressType
        /// </summary>
        public static readonly IpAddressType IPV6 = new IpAddressType("IPV6");

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
    /// Constants used for properties of type ProfileResourceStatus.
    /// </summary>
    public class ProfileResourceStatus : ConstantClass
    {

        /// <summary>
        /// Constant CREATING for ProfileResourceStatus
        /// </summary>
        public static readonly ProfileResourceStatus CREATING = new ProfileResourceStatus("CREATING");
        /// <summary>
        /// Constant DELETING for ProfileResourceStatus
        /// </summary>
        public static readonly ProfileResourceStatus DELETING = new ProfileResourceStatus("DELETING");
        /// <summary>
        /// Constant DISABLED for ProfileResourceStatus
        /// </summary>
        public static readonly ProfileResourceStatus DISABLED = new ProfileResourceStatus("DISABLED");
        /// <summary>
        /// Constant DISABLING for ProfileResourceStatus
        /// </summary>
        public static readonly ProfileResourceStatus DISABLING = new ProfileResourceStatus("DISABLING");
        /// <summary>
        /// Constant ENABLING for ProfileResourceStatus
        /// </summary>
        public static readonly ProfileResourceStatus ENABLING = new ProfileResourceStatus("ENABLING");
        /// <summary>
        /// Constant OPERATIONAL for ProfileResourceStatus
        /// </summary>
        public static readonly ProfileResourceStatus OPERATIONAL = new ProfileResourceStatus("OPERATIONAL");
        /// <summary>
        /// Constant UPDATING for ProfileResourceStatus
        /// </summary>
        public static readonly ProfileResourceStatus UPDATING = new ProfileResourceStatus("UPDATING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ProfileResourceStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ProfileResourceStatus FindValue(string value)
        {
            return FindValue<ProfileResourceStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ProfileResourceStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TokenStatus.
    /// </summary>
    public class TokenStatus : ConstantClass
    {

        /// <summary>
        /// Constant CREATING for TokenStatus
        /// </summary>
        public static readonly TokenStatus CREATING = new TokenStatus("CREATING");
        /// <summary>
        /// Constant DELETING for TokenStatus
        /// </summary>
        public static readonly TokenStatus DELETING = new TokenStatus("DELETING");
        /// <summary>
        /// Constant OPERATIONAL for TokenStatus
        /// </summary>
        public static readonly TokenStatus OPERATIONAL = new TokenStatus("OPERATIONAL");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TokenStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TokenStatus FindValue(string value)
        {
            return FindValue<TokenStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TokenStatus(string value)
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
        /// Constant CANNOT_PARSE for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason CANNOT_PARSE = new ValidationExceptionReason("CANNOT_PARSE");
        /// <summary>
        /// Constant FIELD_VALIDATION_FAILED for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason FIELD_VALIDATION_FAILED = new ValidationExceptionReason("FIELD_VALIDATION_FAILED");
        /// <summary>
        /// Constant OTHER for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason OTHER = new ValidationExceptionReason("OTHER");
        /// <summary>
        /// Constant UNKNOWN_OPERATION for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason UNKNOWN_OPERATION = new ValidationExceptionReason("UNKNOWN_OPERATION");

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

}