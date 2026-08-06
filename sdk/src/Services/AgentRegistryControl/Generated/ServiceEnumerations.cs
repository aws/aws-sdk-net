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
 * Do not modify this file. This file is generated from the agent-registry-control-2025-12-01.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.AgentRegistryControl
{

    /// <summary>
    /// Constants used for properties of type AutoApprovalRule.
    /// </summary>
    public class AutoApprovalRule : ConstantClass
    {

        /// <summary>
        /// Constant APPROVE_ALL for AutoApprovalRule
        /// </summary>
        public static readonly AutoApprovalRule APPROVE_ALL = new AutoApprovalRule("APPROVE_ALL");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AutoApprovalRule(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AutoApprovalRule FindValue(string value)
        {
            return FindValue<AutoApprovalRule>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AutoApprovalRule(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ClaimMatchOperatorType.
    /// </summary>
    public class ClaimMatchOperatorType : ConstantClass
    {

        /// <summary>
        /// Constant CONTAINS for ClaimMatchOperatorType
        /// </summary>
        public static readonly ClaimMatchOperatorType CONTAINS = new ClaimMatchOperatorType("CONTAINS");
        /// <summary>
        /// Constant CONTAINS_ANY for ClaimMatchOperatorType
        /// </summary>
        public static readonly ClaimMatchOperatorType CONTAINS_ANY = new ClaimMatchOperatorType("CONTAINS_ANY");
        /// <summary>
        /// Constant EQUALS for ClaimMatchOperatorType
        /// </summary>
        public static readonly ClaimMatchOperatorType EQUALS = new ClaimMatchOperatorType("EQUALS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ClaimMatchOperatorType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ClaimMatchOperatorType FindValue(string value)
        {
            return FindValue<ClaimMatchOperatorType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ClaimMatchOperatorType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type EndpointIpAddressType.
    /// </summary>
    public class EndpointIpAddressType : ConstantClass
    {

        /// <summary>
        /// Constant IPV4 for EndpointIpAddressType
        /// </summary>
        public static readonly EndpointIpAddressType IPV4 = new EndpointIpAddressType("IPV4");
        /// <summary>
        /// Constant IPV6 for EndpointIpAddressType
        /// </summary>
        public static readonly EndpointIpAddressType IPV6 = new EndpointIpAddressType("IPV6");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EndpointIpAddressType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EndpointIpAddressType FindValue(string value)
        {
            return FindValue<EndpointIpAddressType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EndpointIpAddressType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type InboundTokenClaimValueType.
    /// </summary>
    public class InboundTokenClaimValueType : ConstantClass
    {

        /// <summary>
        /// Constant STRING for InboundTokenClaimValueType
        /// </summary>
        public static readonly InboundTokenClaimValueType STRING = new InboundTokenClaimValueType("STRING");
        /// <summary>
        /// Constant STRING_ARRAY for InboundTokenClaimValueType
        /// </summary>
        public static readonly InboundTokenClaimValueType STRING_ARRAY = new InboundTokenClaimValueType("STRING_ARRAY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public InboundTokenClaimValueType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static InboundTokenClaimValueType FindValue(string value)
        {
            return FindValue<InboundTokenClaimValueType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator InboundTokenClaimValueType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RecordType.
    /// </summary>
    public class RecordType : ConstantClass
    {

        /// <summary>
        /// Constant AGENT for RecordType
        /// </summary>
        public static readonly RecordType AGENT = new RecordType("AGENT");
        /// <summary>
        /// Constant CUSTOM for RecordType
        /// </summary>
        public static readonly RecordType CUSTOM = new RecordType("CUSTOM");
        /// <summary>
        /// Constant MCP for RecordType
        /// </summary>
        public static readonly RecordType MCP = new RecordType("MCP");
        /// <summary>
        /// Constant SKILL for RecordType
        /// </summary>
        public static readonly RecordType SKILL = new RecordType("SKILL");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RecordType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RecordType FindValue(string value)
        {
            return FindValue<RecordType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RecordType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RegistryAuthorizerType.
    /// </summary>
    public class RegistryAuthorizerType : ConstantClass
    {

        /// <summary>
        /// Constant AWS_IAM for RegistryAuthorizerType
        /// </summary>
        public static readonly RegistryAuthorizerType AWS_IAM = new RegistryAuthorizerType("AWS_IAM");
        /// <summary>
        /// Constant CUSTOM_JWT for RegistryAuthorizerType
        /// </summary>
        public static readonly RegistryAuthorizerType CUSTOM_JWT = new RegistryAuthorizerType("CUSTOM_JWT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RegistryAuthorizerType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RegistryAuthorizerType FindValue(string value)
        {
            return FindValue<RegistryAuthorizerType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RegistryAuthorizerType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RegistryFilterName.
    /// </summary>
    public class RegistryFilterName : ConstantClass
    {

        /// <summary>
        /// Constant DiscoveryConfigurationAuthorizerType for RegistryFilterName
        /// </summary>
        public static readonly RegistryFilterName DiscoveryConfigurationAuthorizerType = new RegistryFilterName("discoveryConfiguration.authorizerType");
        /// <summary>
        /// Constant Status for RegistryFilterName
        /// </summary>
        public static readonly RegistryFilterName Status = new RegistryFilterName("status");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RegistryFilterName(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RegistryFilterName FindValue(string value)
        {
            return FindValue<RegistryFilterName>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RegistryFilterName(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RegistryRecordCredentialProviderType.
    /// </summary>
    public class RegistryRecordCredentialProviderType : ConstantClass
    {

        /// <summary>
        /// Constant IAM for RegistryRecordCredentialProviderType
        /// </summary>
        public static readonly RegistryRecordCredentialProviderType IAM = new RegistryRecordCredentialProviderType("IAM");
        /// <summary>
        /// Constant OAUTH for RegistryRecordCredentialProviderType
        /// </summary>
        public static readonly RegistryRecordCredentialProviderType OAUTH = new RegistryRecordCredentialProviderType("OAUTH");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RegistryRecordCredentialProviderType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RegistryRecordCredentialProviderType FindValue(string value)
        {
            return FindValue<RegistryRecordCredentialProviderType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RegistryRecordCredentialProviderType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RegistryRecordFilterName.
    /// </summary>
    public class RegistryRecordFilterName : ConstantClass
    {

        /// <summary>
        /// Constant Name for RegistryRecordFilterName
        /// </summary>
        public static readonly RegistryRecordFilterName Name = new RegistryRecordFilterName("name");
        /// <summary>
        /// Constant RecordType for RegistryRecordFilterName
        /// </summary>
        public static readonly RegistryRecordFilterName RecordType = new RegistryRecordFilterName("recordType");
        /// <summary>
        /// Constant Status for RegistryRecordFilterName
        /// </summary>
        public static readonly RegistryRecordFilterName Status = new RegistryRecordFilterName("status");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RegistryRecordFilterName(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RegistryRecordFilterName FindValue(string value)
        {
            return FindValue<RegistryRecordFilterName>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RegistryRecordFilterName(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RegistryRecordOAuthGrantType.
    /// </summary>
    public class RegistryRecordOAuthGrantType : ConstantClass
    {

        /// <summary>
        /// Constant CLIENT_CREDENTIALS for RegistryRecordOAuthGrantType
        /// </summary>
        public static readonly RegistryRecordOAuthGrantType CLIENT_CREDENTIALS = new RegistryRecordOAuthGrantType("CLIENT_CREDENTIALS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RegistryRecordOAuthGrantType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RegistryRecordOAuthGrantType FindValue(string value)
        {
            return FindValue<RegistryRecordOAuthGrantType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RegistryRecordOAuthGrantType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RegistryRecordStatus.
    /// </summary>
    public class RegistryRecordStatus : ConstantClass
    {

        /// <summary>
        /// Constant APPROVED for RegistryRecordStatus
        /// </summary>
        public static readonly RegistryRecordStatus APPROVED = new RegistryRecordStatus("APPROVED");
        /// <summary>
        /// Constant CREATE_FAILED for RegistryRecordStatus
        /// </summary>
        public static readonly RegistryRecordStatus CREATE_FAILED = new RegistryRecordStatus("CREATE_FAILED");
        /// <summary>
        /// Constant CREATING for RegistryRecordStatus
        /// </summary>
        public static readonly RegistryRecordStatus CREATING = new RegistryRecordStatus("CREATING");
        /// <summary>
        /// Constant DEPRECATED for RegistryRecordStatus
        /// </summary>
        public static readonly RegistryRecordStatus DEPRECATED = new RegistryRecordStatus("DEPRECATED");
        /// <summary>
        /// Constant DRAFT for RegistryRecordStatus
        /// </summary>
        public static readonly RegistryRecordStatus DRAFT = new RegistryRecordStatus("DRAFT");
        /// <summary>
        /// Constant PENDING_APPROVAL for RegistryRecordStatus
        /// </summary>
        public static readonly RegistryRecordStatus PENDING_APPROVAL = new RegistryRecordStatus("PENDING_APPROVAL");
        /// <summary>
        /// Constant REJECTED for RegistryRecordStatus
        /// </summary>
        public static readonly RegistryRecordStatus REJECTED = new RegistryRecordStatus("REJECTED");
        /// <summary>
        /// Constant UPDATE_FAILED for RegistryRecordStatus
        /// </summary>
        public static readonly RegistryRecordStatus UPDATE_FAILED = new RegistryRecordStatus("UPDATE_FAILED");
        /// <summary>
        /// Constant UPDATING for RegistryRecordStatus
        /// </summary>
        public static readonly RegistryRecordStatus UPDATING = new RegistryRecordStatus("UPDATING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RegistryRecordStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RegistryRecordStatus FindValue(string value)
        {
            return FindValue<RegistryRecordStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RegistryRecordStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RegistryStatus.
    /// </summary>
    public class RegistryStatus : ConstantClass
    {

        /// <summary>
        /// Constant CREATE_FAILED for RegistryStatus
        /// </summary>
        public static readonly RegistryStatus CREATE_FAILED = new RegistryStatus("CREATE_FAILED");
        /// <summary>
        /// Constant CREATING for RegistryStatus
        /// </summary>
        public static readonly RegistryStatus CREATING = new RegistryStatus("CREATING");
        /// <summary>
        /// Constant DELETE_FAILED for RegistryStatus
        /// </summary>
        public static readonly RegistryStatus DELETE_FAILED = new RegistryStatus("DELETE_FAILED");
        /// <summary>
        /// Constant DELETING for RegistryStatus
        /// </summary>
        public static readonly RegistryStatus DELETING = new RegistryStatus("DELETING");
        /// <summary>
        /// Constant READY for RegistryStatus
        /// </summary>
        public static readonly RegistryStatus READY = new RegistryStatus("READY");
        /// <summary>
        /// Constant UPDATE_FAILED for RegistryStatus
        /// </summary>
        public static readonly RegistryStatus UPDATE_FAILED = new RegistryStatus("UPDATE_FAILED");
        /// <summary>
        /// Constant UPDATING for RegistryStatus
        /// </summary>
        public static readonly RegistryStatus UPDATING = new RegistryStatus("UPDATING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RegistryStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RegistryStatus FindValue(string value)
        {
            return FindValue<RegistryStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RegistryStatus(string value)
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
        /// Constant CannotParse for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason CannotParse = new ValidationExceptionReason("CannotParse");
        /// <summary>
        /// Constant EventInOtherSession for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason EventInOtherSession = new ValidationExceptionReason("EventInOtherSession");
        /// <summary>
        /// Constant FieldValidationFailed for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason FieldValidationFailed = new ValidationExceptionReason("FieldValidationFailed");
        /// <summary>
        /// Constant IdempotentParameterMismatchException for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason IdempotentParameterMismatchException = new ValidationExceptionReason("IdempotentParameterMismatchException");
        /// <summary>
        /// Constant ResourceConflict for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason ResourceConflict = new ValidationExceptionReason("ResourceConflict");

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