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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.SecurityHub
{

    /// <summary>
    /// Constants used for properties of type ActorSessionMfaStatus.
    /// </summary>
    public class ActorSessionMfaStatus : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for ActorSessionMfaStatus
        /// </summary>
        public static readonly ActorSessionMfaStatus DISABLED = new ActorSessionMfaStatus("DISABLED");
        /// <summary>
        /// Constant ENABLED for ActorSessionMfaStatus
        /// </summary>
        public static readonly ActorSessionMfaStatus ENABLED = new ActorSessionMfaStatus("ENABLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ActorSessionMfaStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ActorSessionMfaStatus FindValue(string value)
        {
            return FindValue<ActorSessionMfaStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ActorSessionMfaStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AdminStatus.
    /// </summary>
    public class AdminStatus : ConstantClass
    {

        /// <summary>
        /// Constant DISABLE_IN_PROGRESS for AdminStatus
        /// </summary>
        public static readonly AdminStatus DISABLE_IN_PROGRESS = new AdminStatus("DISABLE_IN_PROGRESS");
        /// <summary>
        /// Constant ENABLED for AdminStatus
        /// </summary>
        public static readonly AdminStatus ENABLED = new AdminStatus("ENABLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AdminStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AdminStatus FindValue(string value)
        {
            return FindValue<AdminStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AdminStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AllowedOperators.
    /// </summary>
    public class AllowedOperators : ConstantClass
    {

        /// <summary>
        /// Constant AND for AllowedOperators
        /// </summary>
        public static readonly AllowedOperators AND = new AllowedOperators("AND");
        /// <summary>
        /// Constant OR for AllowedOperators
        /// </summary>
        public static readonly AllowedOperators OR = new AllowedOperators("OR");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AllowedOperators(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AllowedOperators FindValue(string value)
        {
            return FindValue<AllowedOperators>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AllowedOperators(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AssociationStatus.
    /// </summary>
    public class AssociationStatus : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for AssociationStatus
        /// </summary>
        public static readonly AssociationStatus DISABLED = new AssociationStatus("DISABLED");
        /// <summary>
        /// Constant ENABLED for AssociationStatus
        /// </summary>
        public static readonly AssociationStatus ENABLED = new AssociationStatus("ENABLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AssociationStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AssociationStatus FindValue(string value)
        {
            return FindValue<AssociationStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AssociationStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AssociationType.
    /// </summary>
    public class AssociationType : ConstantClass
    {

        /// <summary>
        /// Constant APPLIED for AssociationType
        /// </summary>
        public static readonly AssociationType APPLIED = new AssociationType("APPLIED");
        /// <summary>
        /// Constant INHERITED for AssociationType
        /// </summary>
        public static readonly AssociationType INHERITED = new AssociationType("INHERITED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AssociationType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AssociationType FindValue(string value)
        {
            return FindValue<AssociationType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AssociationType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AutoEnableStandards.
    /// </summary>
    public class AutoEnableStandards : ConstantClass
    {

        /// <summary>
        /// Constant DEFAULT for AutoEnableStandards
        /// </summary>
        public static readonly AutoEnableStandards DEFAULT = new AutoEnableStandards("DEFAULT");
        /// <summary>
        /// Constant NONE for AutoEnableStandards
        /// </summary>
        public static readonly AutoEnableStandards NONE = new AutoEnableStandards("NONE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AutoEnableStandards(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AutoEnableStandards FindValue(string value)
        {
            return FindValue<AutoEnableStandards>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AutoEnableStandards(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AutomationRulesActionType.
    /// </summary>
    public class AutomationRulesActionType : ConstantClass
    {

        /// <summary>
        /// Constant FINDING_FIELDS_UPDATE for AutomationRulesActionType
        /// </summary>
        public static readonly AutomationRulesActionType FINDING_FIELDS_UPDATE = new AutomationRulesActionType("FINDING_FIELDS_UPDATE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AutomationRulesActionType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AutomationRulesActionType FindValue(string value)
        {
            return FindValue<AutomationRulesActionType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AutomationRulesActionType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AutomationRulesActionTypeV2.
    /// </summary>
    public class AutomationRulesActionTypeV2 : ConstantClass
    {

        /// <summary>
        /// Constant EXTERNAL_INTEGRATION for AutomationRulesActionTypeV2
        /// </summary>
        public static readonly AutomationRulesActionTypeV2 EXTERNAL_INTEGRATION = new AutomationRulesActionTypeV2("EXTERNAL_INTEGRATION");
        /// <summary>
        /// Constant FINDING_FIELDS_UPDATE for AutomationRulesActionTypeV2
        /// </summary>
        public static readonly AutomationRulesActionTypeV2 FINDING_FIELDS_UPDATE = new AutomationRulesActionTypeV2("FINDING_FIELDS_UPDATE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AutomationRulesActionTypeV2(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AutomationRulesActionTypeV2 FindValue(string value)
        {
            return FindValue<AutomationRulesActionTypeV2>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AutomationRulesActionTypeV2(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AwsIamAccessKeyStatus.
    /// </summary>
    public class AwsIamAccessKeyStatus : ConstantClass
    {

        /// <summary>
        /// Constant Active for AwsIamAccessKeyStatus
        /// </summary>
        public static readonly AwsIamAccessKeyStatus Active = new AwsIamAccessKeyStatus("Active");
        /// <summary>
        /// Constant Inactive for AwsIamAccessKeyStatus
        /// </summary>
        public static readonly AwsIamAccessKeyStatus Inactive = new AwsIamAccessKeyStatus("Inactive");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AwsIamAccessKeyStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AwsIamAccessKeyStatus FindValue(string value)
        {
            return FindValue<AwsIamAccessKeyStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AwsIamAccessKeyStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AwsS3BucketNotificationConfigurationS3KeyFilterRuleName.
    /// </summary>
    public class AwsS3BucketNotificationConfigurationS3KeyFilterRuleName : ConstantClass
    {

        /// <summary>
        /// Constant Prefix for AwsS3BucketNotificationConfigurationS3KeyFilterRuleName
        /// </summary>
        public static readonly AwsS3BucketNotificationConfigurationS3KeyFilterRuleName Prefix = new AwsS3BucketNotificationConfigurationS3KeyFilterRuleName("Prefix");
        /// <summary>
        /// Constant Suffix for AwsS3BucketNotificationConfigurationS3KeyFilterRuleName
        /// </summary>
        public static readonly AwsS3BucketNotificationConfigurationS3KeyFilterRuleName Suffix = new AwsS3BucketNotificationConfigurationS3KeyFilterRuleName("Suffix");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AwsS3BucketNotificationConfigurationS3KeyFilterRuleName(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AwsS3BucketNotificationConfigurationS3KeyFilterRuleName FindValue(string value)
        {
            return FindValue<AwsS3BucketNotificationConfigurationS3KeyFilterRuleName>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AwsS3BucketNotificationConfigurationS3KeyFilterRuleName(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type BatchUpdateFindingsV2UnprocessedFindingErrorCode.
    /// </summary>
    public class BatchUpdateFindingsV2UnprocessedFindingErrorCode : ConstantClass
    {

        /// <summary>
        /// Constant ConflictException for BatchUpdateFindingsV2UnprocessedFindingErrorCode
        /// </summary>
        public static readonly BatchUpdateFindingsV2UnprocessedFindingErrorCode ConflictException = new BatchUpdateFindingsV2UnprocessedFindingErrorCode("ConflictException");
        /// <summary>
        /// Constant InternalServerException for BatchUpdateFindingsV2UnprocessedFindingErrorCode
        /// </summary>
        public static readonly BatchUpdateFindingsV2UnprocessedFindingErrorCode InternalServerException = new BatchUpdateFindingsV2UnprocessedFindingErrorCode("InternalServerException");
        /// <summary>
        /// Constant ResourceNotFoundException for BatchUpdateFindingsV2UnprocessedFindingErrorCode
        /// </summary>
        public static readonly BatchUpdateFindingsV2UnprocessedFindingErrorCode ResourceNotFoundException = new BatchUpdateFindingsV2UnprocessedFindingErrorCode("ResourceNotFoundException");
        /// <summary>
        /// Constant ValidationException for BatchUpdateFindingsV2UnprocessedFindingErrorCode
        /// </summary>
        public static readonly BatchUpdateFindingsV2UnprocessedFindingErrorCode ValidationException = new BatchUpdateFindingsV2UnprocessedFindingErrorCode("ValidationException");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public BatchUpdateFindingsV2UnprocessedFindingErrorCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static BatchUpdateFindingsV2UnprocessedFindingErrorCode FindValue(string value)
        {
            return FindValue<BatchUpdateFindingsV2UnprocessedFindingErrorCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator BatchUpdateFindingsV2UnprocessedFindingErrorCode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ComplianceStatus.
    /// </summary>
    public class ComplianceStatus : ConstantClass
    {

        /// <summary>
        /// Constant FAILED for ComplianceStatus
        /// </summary>
        public static readonly ComplianceStatus FAILED = new ComplianceStatus("FAILED");
        /// <summary>
        /// Constant NOT_AVAILABLE for ComplianceStatus
        /// </summary>
        public static readonly ComplianceStatus NOT_AVAILABLE = new ComplianceStatus("NOT_AVAILABLE");
        /// <summary>
        /// Constant PASSED for ComplianceStatus
        /// </summary>
        public static readonly ComplianceStatus PASSED = new ComplianceStatus("PASSED");
        /// <summary>
        /// Constant WARNING for ComplianceStatus
        /// </summary>
        public static readonly ComplianceStatus WARNING = new ComplianceStatus("WARNING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ComplianceStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ComplianceStatus FindValue(string value)
        {
            return FindValue<ComplianceStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ComplianceStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ConfigurationPolicyAssociationStatus.
    /// </summary>
    public class ConfigurationPolicyAssociationStatus : ConstantClass
    {

        /// <summary>
        /// Constant FAILED for ConfigurationPolicyAssociationStatus
        /// </summary>
        public static readonly ConfigurationPolicyAssociationStatus FAILED = new ConfigurationPolicyAssociationStatus("FAILED");
        /// <summary>
        /// Constant PENDING for ConfigurationPolicyAssociationStatus
        /// </summary>
        public static readonly ConfigurationPolicyAssociationStatus PENDING = new ConfigurationPolicyAssociationStatus("PENDING");
        /// <summary>
        /// Constant SUCCESS for ConfigurationPolicyAssociationStatus
        /// </summary>
        public static readonly ConfigurationPolicyAssociationStatus SUCCESS = new ConfigurationPolicyAssociationStatus("SUCCESS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ConfigurationPolicyAssociationStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ConfigurationPolicyAssociationStatus FindValue(string value)
        {
            return FindValue<ConfigurationPolicyAssociationStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ConfigurationPolicyAssociationStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ConnectionDirection.
    /// </summary>
    public class ConnectionDirection : ConstantClass
    {

        /// <summary>
        /// Constant INBOUND for ConnectionDirection
        /// </summary>
        public static readonly ConnectionDirection INBOUND = new ConnectionDirection("INBOUND");
        /// <summary>
        /// Constant OUTBOUND for ConnectionDirection
        /// </summary>
        public static readonly ConnectionDirection OUTBOUND = new ConnectionDirection("OUTBOUND");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ConnectionDirection(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ConnectionDirection FindValue(string value)
        {
            return FindValue<ConnectionDirection>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ConnectionDirection(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ConnectorAuthStatus.
    /// </summary>
    public class ConnectorAuthStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for ConnectorAuthStatus
        /// </summary>
        public static readonly ConnectorAuthStatus ACTIVE = new ConnectorAuthStatus("ACTIVE");
        /// <summary>
        /// Constant FAILED for ConnectorAuthStatus
        /// </summary>
        public static readonly ConnectorAuthStatus FAILED = new ConnectorAuthStatus("FAILED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ConnectorAuthStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ConnectorAuthStatus FindValue(string value)
        {
            return FindValue<ConnectorAuthStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ConnectorAuthStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ConnectorProviderName.
    /// </summary>
    public class ConnectorProviderName : ConstantClass
    {

        /// <summary>
        /// Constant JIRA_CLOUD for ConnectorProviderName
        /// </summary>
        public static readonly ConnectorProviderName JIRA_CLOUD = new ConnectorProviderName("JIRA_CLOUD");
        /// <summary>
        /// Constant SERVICENOW for ConnectorProviderName
        /// </summary>
        public static readonly ConnectorProviderName SERVICENOW = new ConnectorProviderName("SERVICENOW");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ConnectorProviderName(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ConnectorProviderName FindValue(string value)
        {
            return FindValue<ConnectorProviderName>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ConnectorProviderName(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ConnectorStatus.
    /// </summary>
    public class ConnectorStatus : ConstantClass
    {

        /// <summary>
        /// Constant CONNECTED for ConnectorStatus
        /// </summary>
        public static readonly ConnectorStatus CONNECTED = new ConnectorStatus("CONNECTED");
        /// <summary>
        /// Constant FAILED_TO_CONNECT for ConnectorStatus
        /// </summary>
        public static readonly ConnectorStatus FAILED_TO_CONNECT = new ConnectorStatus("FAILED_TO_CONNECT");
        /// <summary>
        /// Constant PENDING_AUTHORIZATION for ConnectorStatus
        /// </summary>
        public static readonly ConnectorStatus PENDING_AUTHORIZATION = new ConnectorStatus("PENDING_AUTHORIZATION");
        /// <summary>
        /// Constant PENDING_CONFIGURATION for ConnectorStatus
        /// </summary>
        public static readonly ConnectorStatus PENDING_CONFIGURATION = new ConnectorStatus("PENDING_CONFIGURATION");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ConnectorStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ConnectorStatus FindValue(string value)
        {
            return FindValue<ConnectorStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ConnectorStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ControlFindingGenerator.
    /// </summary>
    public class ControlFindingGenerator : ConstantClass
    {

        /// <summary>
        /// Constant SECURITY_CONTROL for ControlFindingGenerator
        /// </summary>
        public static readonly ControlFindingGenerator SECURITY_CONTROL = new ControlFindingGenerator("SECURITY_CONTROL");
        /// <summary>
        /// Constant STANDARD_CONTROL for ControlFindingGenerator
        /// </summary>
        public static readonly ControlFindingGenerator STANDARD_CONTROL = new ControlFindingGenerator("STANDARD_CONTROL");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ControlFindingGenerator(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ControlFindingGenerator FindValue(string value)
        {
            return FindValue<ControlFindingGenerator>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ControlFindingGenerator(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ControlStatus.
    /// </summary>
    public class ControlStatus : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for ControlStatus
        /// </summary>
        public static readonly ControlStatus DISABLED = new ControlStatus("DISABLED");
        /// <summary>
        /// Constant ENABLED for ControlStatus
        /// </summary>
        public static readonly ControlStatus ENABLED = new ControlStatus("ENABLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ControlStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ControlStatus FindValue(string value)
        {
            return FindValue<ControlStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ControlStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DateRangeUnit.
    /// </summary>
    public class DateRangeUnit : ConstantClass
    {

        /// <summary>
        /// Constant DAYS for DateRangeUnit
        /// </summary>
        public static readonly DateRangeUnit DAYS = new DateRangeUnit("DAYS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DateRangeUnit(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DateRangeUnit FindValue(string value)
        {
            return FindValue<DateRangeUnit>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DateRangeUnit(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type FindingHistoryUpdateSourceType.
    /// </summary>
    public class FindingHistoryUpdateSourceType : ConstantClass
    {

        /// <summary>
        /// Constant BATCH_IMPORT_FINDINGS for FindingHistoryUpdateSourceType
        /// </summary>
        public static readonly FindingHistoryUpdateSourceType BATCH_IMPORT_FINDINGS = new FindingHistoryUpdateSourceType("BATCH_IMPORT_FINDINGS");
        /// <summary>
        /// Constant BATCH_UPDATE_FINDINGS for FindingHistoryUpdateSourceType
        /// </summary>
        public static readonly FindingHistoryUpdateSourceType BATCH_UPDATE_FINDINGS = new FindingHistoryUpdateSourceType("BATCH_UPDATE_FINDINGS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FindingHistoryUpdateSourceType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FindingHistoryUpdateSourceType FindValue(string value)
        {
            return FindValue<FindingHistoryUpdateSourceType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FindingHistoryUpdateSourceType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type GroupByField.
    /// </summary>
    public class GroupByField : ConstantClass
    {

        /// <summary>
        /// Constant Activity_name for GroupByField
        /// </summary>
        public static readonly GroupByField Activity_name = new GroupByField("activity_name");
        /// <summary>
        /// Constant Class_name for GroupByField
        /// </summary>
        public static readonly GroupByField Class_name = new GroupByField("class_name");
        /// <summary>
        /// Constant CloudAccountUid for GroupByField
        /// </summary>
        public static readonly GroupByField CloudAccountUid = new GroupByField("cloud.account.uid");
        /// <summary>
        /// Constant CloudProvider for GroupByField
        /// </summary>
        public static readonly GroupByField CloudProvider = new GroupByField("cloud.provider");
        /// <summary>
        /// Constant CloudRegion for GroupByField
        /// </summary>
        public static readonly GroupByField CloudRegion = new GroupByField("cloud.region");
        /// <summary>
        /// Constant ComplianceAssessmentsName for GroupByField
        /// </summary>
        public static readonly GroupByField ComplianceAssessmentsName = new GroupByField("compliance.assessments.name");
        /// <summary>
        /// Constant ComplianceControl for GroupByField
        /// </summary>
        public static readonly GroupByField ComplianceControl = new GroupByField("compliance.control");
        /// <summary>
        /// Constant ComplianceStatus for GroupByField
        /// </summary>
        public static readonly GroupByField ComplianceStatus = new GroupByField("compliance.status");
        /// <summary>
        /// Constant Finding_infoTitle for GroupByField
        /// </summary>
        public static readonly GroupByField Finding_infoTitle = new GroupByField("finding_info.title");
        /// <summary>
        /// Constant Finding_infoTypes for GroupByField
        /// </summary>
        public static readonly GroupByField Finding_infoTypes = new GroupByField("finding_info.types");
        /// <summary>
        /// Constant MetadataProductName for GroupByField
        /// </summary>
        public static readonly GroupByField MetadataProductName = new GroupByField("metadata.product.name");
        /// <summary>
        /// Constant MetadataProductUid for GroupByField
        /// </summary>
        public static readonly GroupByField MetadataProductUid = new GroupByField("metadata.product.uid");
        /// <summary>
        /// Constant ResourcesType for GroupByField
        /// </summary>
        public static readonly GroupByField ResourcesType = new GroupByField("resources.type");
        /// <summary>
        /// Constant ResourcesUid for GroupByField
        /// </summary>
        public static readonly GroupByField ResourcesUid = new GroupByField("resources.uid");
        /// <summary>
        /// Constant Severity for GroupByField
        /// </summary>
        public static readonly GroupByField Severity = new GroupByField("severity");
        /// <summary>
        /// Constant Status for GroupByField
        /// </summary>
        public static readonly GroupByField Status = new GroupByField("status");
        /// <summary>
        /// Constant VulnerabilitiesFix_coverage for GroupByField
        /// </summary>
        public static readonly GroupByField VulnerabilitiesFix_coverage = new GroupByField("vulnerabilities.fix_coverage");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public GroupByField(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static GroupByField FindValue(string value)
        {
            return FindValue<GroupByField>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator GroupByField(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type IntegrationType.
    /// </summary>
    public class IntegrationType : ConstantClass
    {

        /// <summary>
        /// Constant RECEIVE_FINDINGS_FROM_SECURITY_HUB for IntegrationType
        /// </summary>
        public static readonly IntegrationType RECEIVE_FINDINGS_FROM_SECURITY_HUB = new IntegrationType("RECEIVE_FINDINGS_FROM_SECURITY_HUB");
        /// <summary>
        /// Constant SEND_FINDINGS_TO_SECURITY_HUB for IntegrationType
        /// </summary>
        public static readonly IntegrationType SEND_FINDINGS_TO_SECURITY_HUB = new IntegrationType("SEND_FINDINGS_TO_SECURITY_HUB");
        /// <summary>
        /// Constant UPDATE_FINDINGS_IN_SECURITY_HUB for IntegrationType
        /// </summary>
        public static readonly IntegrationType UPDATE_FINDINGS_IN_SECURITY_HUB = new IntegrationType("UPDATE_FINDINGS_IN_SECURITY_HUB");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public IntegrationType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static IntegrationType FindValue(string value)
        {
            return FindValue<IntegrationType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator IntegrationType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type IntegrationV2Type.
    /// </summary>
    public class IntegrationV2Type : ConstantClass
    {

        /// <summary>
        /// Constant RECEIVE_FINDINGS_FROM_SECURITY_HUB for IntegrationV2Type
        /// </summary>
        public static readonly IntegrationV2Type RECEIVE_FINDINGS_FROM_SECURITY_HUB = new IntegrationV2Type("RECEIVE_FINDINGS_FROM_SECURITY_HUB");
        /// <summary>
        /// Constant SEND_FINDINGS_TO_SECURITY_HUB for IntegrationV2Type
        /// </summary>
        public static readonly IntegrationV2Type SEND_FINDINGS_TO_SECURITY_HUB = new IntegrationV2Type("SEND_FINDINGS_TO_SECURITY_HUB");
        /// <summary>
        /// Constant UPDATE_FINDINGS_IN_SECURITY_HUB for IntegrationV2Type
        /// </summary>
        public static readonly IntegrationV2Type UPDATE_FINDINGS_IN_SECURITY_HUB = new IntegrationV2Type("UPDATE_FINDINGS_IN_SECURITY_HUB");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public IntegrationV2Type(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static IntegrationV2Type FindValue(string value)
        {
            return FindValue<IntegrationV2Type>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator IntegrationV2Type(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type MalwareState.
    /// </summary>
    public class MalwareState : ConstantClass
    {

        /// <summary>
        /// Constant OBSERVED for MalwareState
        /// </summary>
        public static readonly MalwareState OBSERVED = new MalwareState("OBSERVED");
        /// <summary>
        /// Constant REMOVAL_FAILED for MalwareState
        /// </summary>
        public static readonly MalwareState REMOVAL_FAILED = new MalwareState("REMOVAL_FAILED");
        /// <summary>
        /// Constant REMOVED for MalwareState
        /// </summary>
        public static readonly MalwareState REMOVED = new MalwareState("REMOVED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MalwareState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MalwareState FindValue(string value)
        {
            return FindValue<MalwareState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MalwareState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type MalwareType.
    /// </summary>
    public class MalwareType : ConstantClass
    {

        /// <summary>
        /// Constant ADWARE for MalwareType
        /// </summary>
        public static readonly MalwareType ADWARE = new MalwareType("ADWARE");
        /// <summary>
        /// Constant BLENDED_THREAT for MalwareType
        /// </summary>
        public static readonly MalwareType BLENDED_THREAT = new MalwareType("BLENDED_THREAT");
        /// <summary>
        /// Constant BOTNET_AGENT for MalwareType
        /// </summary>
        public static readonly MalwareType BOTNET_AGENT = new MalwareType("BOTNET_AGENT");
        /// <summary>
        /// Constant COIN_MINER for MalwareType
        /// </summary>
        public static readonly MalwareType COIN_MINER = new MalwareType("COIN_MINER");
        /// <summary>
        /// Constant EXPLOIT_KIT for MalwareType
        /// </summary>
        public static readonly MalwareType EXPLOIT_KIT = new MalwareType("EXPLOIT_KIT");
        /// <summary>
        /// Constant KEYLOGGER for MalwareType
        /// </summary>
        public static readonly MalwareType KEYLOGGER = new MalwareType("KEYLOGGER");
        /// <summary>
        /// Constant MACRO for MalwareType
        /// </summary>
        public static readonly MalwareType MACRO = new MalwareType("MACRO");
        /// <summary>
        /// Constant POTENTIALLY_UNWANTED for MalwareType
        /// </summary>
        public static readonly MalwareType POTENTIALLY_UNWANTED = new MalwareType("POTENTIALLY_UNWANTED");
        /// <summary>
        /// Constant RANSOMWARE for MalwareType
        /// </summary>
        public static readonly MalwareType RANSOMWARE = new MalwareType("RANSOMWARE");
        /// <summary>
        /// Constant REMOTE_ACCESS for MalwareType
        /// </summary>
        public static readonly MalwareType REMOTE_ACCESS = new MalwareType("REMOTE_ACCESS");
        /// <summary>
        /// Constant ROOTKIT for MalwareType
        /// </summary>
        public static readonly MalwareType ROOTKIT = new MalwareType("ROOTKIT");
        /// <summary>
        /// Constant SPYWARE for MalwareType
        /// </summary>
        public static readonly MalwareType SPYWARE = new MalwareType("SPYWARE");
        /// <summary>
        /// Constant TROJAN for MalwareType
        /// </summary>
        public static readonly MalwareType TROJAN = new MalwareType("TROJAN");
        /// <summary>
        /// Constant VIRUS for MalwareType
        /// </summary>
        public static readonly MalwareType VIRUS = new MalwareType("VIRUS");
        /// <summary>
        /// Constant WORM for MalwareType
        /// </summary>
        public static readonly MalwareType WORM = new MalwareType("WORM");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MalwareType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MalwareType FindValue(string value)
        {
            return FindValue<MalwareType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MalwareType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type MapFilterComparison.
    /// </summary>
    public class MapFilterComparison : ConstantClass
    {

        /// <summary>
        /// Constant CONTAINS for MapFilterComparison
        /// </summary>
        public static readonly MapFilterComparison CONTAINS = new MapFilterComparison("CONTAINS");
        /// <summary>
        /// Constant EQUALS for MapFilterComparison
        /// </summary>
        public static readonly MapFilterComparison EQUALS = new MapFilterComparison("EQUALS");
        /// <summary>
        /// Constant NOT_CONTAINS for MapFilterComparison
        /// </summary>
        public static readonly MapFilterComparison NOT_CONTAINS = new MapFilterComparison("NOT_CONTAINS");
        /// <summary>
        /// Constant NOT_EQUALS for MapFilterComparison
        /// </summary>
        public static readonly MapFilterComparison NOT_EQUALS = new MapFilterComparison("NOT_EQUALS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MapFilterComparison(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MapFilterComparison FindValue(string value)
        {
            return FindValue<MapFilterComparison>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MapFilterComparison(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type NetworkDirection.
    /// </summary>
    public class NetworkDirection : ConstantClass
    {

        /// <summary>
        /// Constant IN for NetworkDirection
        /// </summary>
        public static readonly NetworkDirection IN = new NetworkDirection("IN");
        /// <summary>
        /// Constant OUT for NetworkDirection
        /// </summary>
        public static readonly NetworkDirection OUT = new NetworkDirection("OUT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public NetworkDirection(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static NetworkDirection FindValue(string value)
        {
            return FindValue<NetworkDirection>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator NetworkDirection(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type OcsfBooleanField.
    /// </summary>
    public class OcsfBooleanField : ConstantClass
    {

        /// <summary>
        /// Constant ComplianceAssessmentsMeets_criteria for OcsfBooleanField
        /// </summary>
        public static readonly OcsfBooleanField ComplianceAssessmentsMeets_criteria = new OcsfBooleanField("compliance.assessments.meets_criteria");
        /// <summary>
        /// Constant VulnerabilitiesIs_exploit_available for OcsfBooleanField
        /// </summary>
        public static readonly OcsfBooleanField VulnerabilitiesIs_exploit_available = new OcsfBooleanField("vulnerabilities.is_exploit_available");
        /// <summary>
        /// Constant VulnerabilitiesIs_fix_available for OcsfBooleanField
        /// </summary>
        public static readonly OcsfBooleanField VulnerabilitiesIs_fix_available = new OcsfBooleanField("vulnerabilities.is_fix_available");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public OcsfBooleanField(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static OcsfBooleanField FindValue(string value)
        {
            return FindValue<OcsfBooleanField>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator OcsfBooleanField(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type OcsfDateField.
    /// </summary>
    public class OcsfDateField : ConstantClass
    {

        /// <summary>
        /// Constant Finding_infoCreated_time_dt for OcsfDateField
        /// </summary>
        public static readonly OcsfDateField Finding_infoCreated_time_dt = new OcsfDateField("finding_info.created_time_dt");
        /// <summary>
        /// Constant Finding_infoFirst_seen_time_dt for OcsfDateField
        /// </summary>
        public static readonly OcsfDateField Finding_infoFirst_seen_time_dt = new OcsfDateField("finding_info.first_seen_time_dt");
        /// <summary>
        /// Constant Finding_infoLast_seen_time_dt for OcsfDateField
        /// </summary>
        public static readonly OcsfDateField Finding_infoLast_seen_time_dt = new OcsfDateField("finding_info.last_seen_time_dt");
        /// <summary>
        /// Constant Finding_infoModified_time_dt for OcsfDateField
        /// </summary>
        public static readonly OcsfDateField Finding_infoModified_time_dt = new OcsfDateField("finding_info.modified_time_dt");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public OcsfDateField(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static OcsfDateField FindValue(string value)
        {
            return FindValue<OcsfDateField>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator OcsfDateField(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type OcsfMapField.
    /// </summary>
    public class OcsfMapField : ConstantClass
    {

        /// <summary>
        /// Constant ResourcesTags for OcsfMapField
        /// </summary>
        public static readonly OcsfMapField ResourcesTags = new OcsfMapField("resources.tags");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public OcsfMapField(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static OcsfMapField FindValue(string value)
        {
            return FindValue<OcsfMapField>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator OcsfMapField(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type OcsfNumberField.
    /// </summary>
    public class OcsfNumberField : ConstantClass
    {

        /// <summary>
        /// Constant Activity_id for OcsfNumberField
        /// </summary>
        public static readonly OcsfNumberField Activity_id = new OcsfNumberField("activity_id");
        /// <summary>
        /// Constant ComplianceStatus_id for OcsfNumberField
        /// </summary>
        public static readonly OcsfNumberField ComplianceStatus_id = new OcsfNumberField("compliance.status_id");
        /// <summary>
        /// Constant Confidence_score for OcsfNumberField
        /// </summary>
        public static readonly OcsfNumberField Confidence_score = new OcsfNumberField("confidence_score");
        /// <summary>
        /// Constant Finding_infoRelated_events_count for OcsfNumberField
        /// </summary>
        public static readonly OcsfNumberField Finding_infoRelated_events_count = new OcsfNumberField("finding_info.related_events_count");
        /// <summary>
        /// Constant Severity_id for OcsfNumberField
        /// </summary>
        public static readonly OcsfNumberField Severity_id = new OcsfNumberField("severity_id");
        /// <summary>
        /// Constant Status_id for OcsfNumberField
        /// </summary>
        public static readonly OcsfNumberField Status_id = new OcsfNumberField("status_id");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public OcsfNumberField(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static OcsfNumberField FindValue(string value)
        {
            return FindValue<OcsfNumberField>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator OcsfNumberField(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type OcsfStringField.
    /// </summary>
    public class OcsfStringField : ConstantClass
    {

        /// <summary>
        /// Constant Activity_name for OcsfStringField
        /// </summary>
        public static readonly OcsfStringField Activity_name = new OcsfStringField("activity_name");
        /// <summary>
        /// Constant Class_name for OcsfStringField
        /// </summary>
        public static readonly OcsfStringField Class_name = new OcsfStringField("class_name");
        /// <summary>
        /// Constant CloudAccountUid for OcsfStringField
        /// </summary>
        public static readonly OcsfStringField CloudAccountUid = new OcsfStringField("cloud.account.uid");
        /// <summary>
        /// Constant CloudProvider for OcsfStringField
        /// </summary>
        public static readonly OcsfStringField CloudProvider = new OcsfStringField("cloud.provider");
        /// <summary>
        /// Constant CloudRegion for OcsfStringField
        /// </summary>
        public static readonly OcsfStringField CloudRegion = new OcsfStringField("cloud.region");
        /// <summary>
        /// Constant Comment for OcsfStringField
        /// </summary>
        public static readonly OcsfStringField Comment = new OcsfStringField("comment");
        /// <summary>
        /// Constant ComplianceAssessmentsCategory for OcsfStringField
        /// </summary>
        public static readonly OcsfStringField ComplianceAssessmentsCategory = new OcsfStringField("compliance.assessments.category");
        /// <summary>
        /// Constant ComplianceAssessmentsName for OcsfStringField
        /// </summary>
        public static readonly OcsfStringField ComplianceAssessmentsName = new OcsfStringField("compliance.assessments.name");
        /// <summary>
        /// Constant ComplianceControl for OcsfStringField
        /// </summary>
        public static readonly OcsfStringField ComplianceControl = new OcsfStringField("compliance.control");
        /// <summary>
        /// Constant ComplianceStandards for OcsfStringField
        /// </summary>
        public static readonly OcsfStringField ComplianceStandards = new OcsfStringField("compliance.standards");
        /// <summary>
        /// Constant ComplianceStatus for OcsfStringField
        /// </summary>
        public static readonly OcsfStringField ComplianceStatus = new OcsfStringField("compliance.status");
        /// <summary>
        /// Constant Finding_infoDesc for OcsfStringField
        /// </summary>
        public static readonly OcsfStringField Finding_infoDesc = new OcsfStringField("finding_info.desc");
        /// <summary>
        /// Constant Finding_infoRelated_eventsProductUid for OcsfStringField
        /// </summary>
        public static readonly OcsfStringField Finding_infoRelated_eventsProductUid = new OcsfStringField("finding_info.related_events.product.uid");
        /// <summary>
        /// Constant Finding_infoRelated_eventsTitle for OcsfStringField
        /// </summary>
        public static readonly OcsfStringField Finding_infoRelated_eventsTitle = new OcsfStringField("finding_info.related_events.title");
        /// <summary>
        /// Constant Finding_infoRelated_eventsUid for OcsfStringField
        /// </summary>
        public static readonly OcsfStringField Finding_infoRelated_eventsUid = new OcsfStringField("finding_info.related_events.uid");
        /// <summary>
        /// Constant Finding_infoSrc_url for OcsfStringField
        /// </summary>
        public static readonly OcsfStringField Finding_infoSrc_url = new OcsfStringField("finding_info.src_url");
        /// <summary>
        /// Constant Finding_infoTitle for OcsfStringField
        /// </summary>
        public static readonly OcsfStringField Finding_infoTitle = new OcsfStringField("finding_info.title");
        /// <summary>
        /// Constant Finding_infoTypes for OcsfStringField
        /// </summary>
        public static readonly OcsfStringField Finding_infoTypes = new OcsfStringField("finding_info.types");
        /// <summary>
        /// Constant Finding_infoUid for OcsfStringField
        /// </summary>
        public static readonly OcsfStringField Finding_infoUid = new OcsfStringField("finding_info.uid");
        /// <summary>
        /// Constant MetadataProductName for OcsfStringField
        /// </summary>
        public static readonly OcsfStringField MetadataProductName = new OcsfStringField("metadata.product.name");
        /// <summary>
        /// Constant MetadataProductUid for OcsfStringField
        /// </summary>
        public static readonly OcsfStringField MetadataProductUid = new OcsfStringField("metadata.product.uid");
        /// <summary>
        /// Constant MetadataProductVendor_name for OcsfStringField
        /// </summary>
        public static readonly OcsfStringField MetadataProductVendor_name = new OcsfStringField("metadata.product.vendor_name");
        /// <summary>
        /// Constant MetadataUid for OcsfStringField
        /// </summary>
        public static readonly OcsfStringField MetadataUid = new OcsfStringField("metadata.uid");
        /// <summary>
        /// Constant RemediationDesc for OcsfStringField
        /// </summary>
        public static readonly OcsfStringField RemediationDesc = new OcsfStringField("remediation.desc");
        /// <summary>
        /// Constant RemediationReferences for OcsfStringField
        /// </summary>
        public static readonly OcsfStringField RemediationReferences = new OcsfStringField("remediation.references");
        /// <summary>
        /// Constant ResourcesCloud_partition for OcsfStringField
        /// </summary>
        public static readonly OcsfStringField ResourcesCloud_partition = new OcsfStringField("resources.cloud_partition");
        /// <summary>
        /// Constant ResourcesRegion for OcsfStringField
        /// </summary>
        public static readonly OcsfStringField ResourcesRegion = new OcsfStringField("resources.region");
        /// <summary>
        /// Constant ResourcesType for OcsfStringField
        /// </summary>
        public static readonly OcsfStringField ResourcesType = new OcsfStringField("resources.type");
        /// <summary>
        /// Constant ResourcesUid for OcsfStringField
        /// </summary>
        public static readonly OcsfStringField ResourcesUid = new OcsfStringField("resources.uid");
        /// <summary>
        /// Constant Severity for OcsfStringField
        /// </summary>
        public static readonly OcsfStringField Severity = new OcsfStringField("severity");
        /// <summary>
        /// Constant Status for OcsfStringField
        /// </summary>
        public static readonly OcsfStringField Status = new OcsfStringField("status");
        /// <summary>
        /// Constant VulnerabilitiesFix_coverage for OcsfStringField
        /// </summary>
        public static readonly OcsfStringField VulnerabilitiesFix_coverage = new OcsfStringField("vulnerabilities.fix_coverage");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public OcsfStringField(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static OcsfStringField FindValue(string value)
        {
            return FindValue<OcsfStringField>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator OcsfStringField(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type OrganizationConfigurationConfigurationType.
    /// </summary>
    public class OrganizationConfigurationConfigurationType : ConstantClass
    {

        /// <summary>
        /// Constant CENTRAL for OrganizationConfigurationConfigurationType
        /// </summary>
        public static readonly OrganizationConfigurationConfigurationType CENTRAL = new OrganizationConfigurationConfigurationType("CENTRAL");
        /// <summary>
        /// Constant LOCAL for OrganizationConfigurationConfigurationType
        /// </summary>
        public static readonly OrganizationConfigurationConfigurationType LOCAL = new OrganizationConfigurationConfigurationType("LOCAL");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public OrganizationConfigurationConfigurationType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static OrganizationConfigurationConfigurationType FindValue(string value)
        {
            return FindValue<OrganizationConfigurationConfigurationType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator OrganizationConfigurationConfigurationType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type OrganizationConfigurationStatus.
    /// </summary>
    public class OrganizationConfigurationStatus : ConstantClass
    {

        /// <summary>
        /// Constant ENABLED for OrganizationConfigurationStatus
        /// </summary>
        public static readonly OrganizationConfigurationStatus ENABLED = new OrganizationConfigurationStatus("ENABLED");
        /// <summary>
        /// Constant FAILED for OrganizationConfigurationStatus
        /// </summary>
        public static readonly OrganizationConfigurationStatus FAILED = new OrganizationConfigurationStatus("FAILED");
        /// <summary>
        /// Constant PENDING for OrganizationConfigurationStatus
        /// </summary>
        public static readonly OrganizationConfigurationStatus PENDING = new OrganizationConfigurationStatus("PENDING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public OrganizationConfigurationStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static OrganizationConfigurationStatus FindValue(string value)
        {
            return FindValue<OrganizationConfigurationStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator OrganizationConfigurationStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ParameterValueType.
    /// </summary>
    public class ParameterValueType : ConstantClass
    {

        /// <summary>
        /// Constant CUSTOM for ParameterValueType
        /// </summary>
        public static readonly ParameterValueType CUSTOM = new ParameterValueType("CUSTOM");
        /// <summary>
        /// Constant DEFAULT for ParameterValueType
        /// </summary>
        public static readonly ParameterValueType DEFAULT = new ParameterValueType("DEFAULT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ParameterValueType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ParameterValueType FindValue(string value)
        {
            return FindValue<ParameterValueType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ParameterValueType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Partition.
    /// </summary>
    public class Partition : ConstantClass
    {

        /// <summary>
        /// Constant Aws for Partition
        /// </summary>
        public static readonly Partition Aws = new Partition("aws");
        /// <summary>
        /// Constant AwsCn for Partition
        /// </summary>
        public static readonly Partition AwsCn = new Partition("aws-cn");
        /// <summary>
        /// Constant AwsUsGov for Partition
        /// </summary>
        public static readonly Partition AwsUsGov = new Partition("aws-us-gov");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Partition(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Partition FindValue(string value)
        {
            return FindValue<Partition>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Partition(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RecordState.
    /// </summary>
    public class RecordState : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for RecordState
        /// </summary>
        public static readonly RecordState ACTIVE = new RecordState("ACTIVE");
        /// <summary>
        /// Constant ARCHIVED for RecordState
        /// </summary>
        public static readonly RecordState ARCHIVED = new RecordState("ARCHIVED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RecordState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RecordState FindValue(string value)
        {
            return FindValue<RecordState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RecordState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RegionAvailabilityStatus.
    /// </summary>
    public class RegionAvailabilityStatus : ConstantClass
    {

        /// <summary>
        /// Constant AVAILABLE for RegionAvailabilityStatus
        /// </summary>
        public static readonly RegionAvailabilityStatus AVAILABLE = new RegionAvailabilityStatus("AVAILABLE");
        /// <summary>
        /// Constant UNAVAILABLE for RegionAvailabilityStatus
        /// </summary>
        public static readonly RegionAvailabilityStatus UNAVAILABLE = new RegionAvailabilityStatus("UNAVAILABLE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RegionAvailabilityStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RegionAvailabilityStatus FindValue(string value)
        {
            return FindValue<RegionAvailabilityStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RegionAvailabilityStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ResourceCategory.
    /// </summary>
    public class ResourceCategory : ConstantClass
    {

        /// <summary>
        /// Constant AIML for ResourceCategory
        /// </summary>
        public static readonly ResourceCategory AIML = new ResourceCategory("AI/ML");
        /// <summary>
        /// Constant Code for ResourceCategory
        /// </summary>
        public static readonly ResourceCategory Code = new ResourceCategory("Code");
        /// <summary>
        /// Constant Compute for ResourceCategory
        /// </summary>
        public static readonly ResourceCategory Compute = new ResourceCategory("Compute");
        /// <summary>
        /// Constant Database for ResourceCategory
        /// </summary>
        public static readonly ResourceCategory Database = new ResourceCategory("Database");
        /// <summary>
        /// Constant Identity for ResourceCategory
        /// </summary>
        public static readonly ResourceCategory Identity = new ResourceCategory("Identity");
        /// <summary>
        /// Constant Network for ResourceCategory
        /// </summary>
        public static readonly ResourceCategory Network = new ResourceCategory("Network");
        /// <summary>
        /// Constant Other for ResourceCategory
        /// </summary>
        public static readonly ResourceCategory Other = new ResourceCategory("Other");
        /// <summary>
        /// Constant Storage for ResourceCategory
        /// </summary>
        public static readonly ResourceCategory Storage = new ResourceCategory("Storage");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ResourceCategory(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ResourceCategory FindValue(string value)
        {
            return FindValue<ResourceCategory>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ResourceCategory(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ResourceGroupByField.
    /// </summary>
    public class ResourceGroupByField : ConstantClass
    {

        /// <summary>
        /// Constant Account_id for ResourceGroupByField
        /// </summary>
        public static readonly ResourceGroupByField Account_id = new ResourceGroupByField("account_id");
        /// <summary>
        /// Constant Findings_summaryFinding_type for ResourceGroupByField
        /// </summary>
        public static readonly ResourceGroupByField Findings_summaryFinding_type = new ResourceGroupByField("findings_summary.finding_type");
        /// <summary>
        /// Constant Region for ResourceGroupByField
        /// </summary>
        public static readonly ResourceGroupByField Region = new ResourceGroupByField("region");
        /// <summary>
        /// Constant Resource_category for ResourceGroupByField
        /// </summary>
        public static readonly ResourceGroupByField Resource_category = new ResourceGroupByField("resource_category");
        /// <summary>
        /// Constant Resource_name for ResourceGroupByField
        /// </summary>
        public static readonly ResourceGroupByField Resource_name = new ResourceGroupByField("resource_name");
        /// <summary>
        /// Constant Resource_type for ResourceGroupByField
        /// </summary>
        public static readonly ResourceGroupByField Resource_type = new ResourceGroupByField("resource_type");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ResourceGroupByField(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ResourceGroupByField FindValue(string value)
        {
            return FindValue<ResourceGroupByField>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ResourceGroupByField(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ResourcesDateField.
    /// </summary>
    public class ResourcesDateField : ConstantClass
    {

        /// <summary>
        /// Constant Resource_creation_time_dt for ResourcesDateField
        /// </summary>
        public static readonly ResourcesDateField Resource_creation_time_dt = new ResourcesDateField("resource_creation_time_dt");
        /// <summary>
        /// Constant Resource_detail_capture_time_dt for ResourcesDateField
        /// </summary>
        public static readonly ResourcesDateField Resource_detail_capture_time_dt = new ResourcesDateField("resource_detail_capture_time_dt");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ResourcesDateField(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ResourcesDateField FindValue(string value)
        {
            return FindValue<ResourcesDateField>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ResourcesDateField(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ResourcesMapField.
    /// </summary>
    public class ResourcesMapField : ConstantClass
    {

        /// <summary>
        /// Constant Tags for ResourcesMapField
        /// </summary>
        public static readonly ResourcesMapField Tags = new ResourcesMapField("tags");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ResourcesMapField(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ResourcesMapField FindValue(string value)
        {
            return FindValue<ResourcesMapField>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ResourcesMapField(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ResourcesNumberField.
    /// </summary>
    public class ResourcesNumberField : ConstantClass
    {

        /// <summary>
        /// Constant Findings_summarySeveritiesCritical for ResourcesNumberField
        /// </summary>
        public static readonly ResourcesNumberField Findings_summarySeveritiesCritical = new ResourcesNumberField("findings_summary.severities.critical");
        /// <summary>
        /// Constant Findings_summarySeveritiesFatal for ResourcesNumberField
        /// </summary>
        public static readonly ResourcesNumberField Findings_summarySeveritiesFatal = new ResourcesNumberField("findings_summary.severities.fatal");
        /// <summary>
        /// Constant Findings_summarySeveritiesHigh for ResourcesNumberField
        /// </summary>
        public static readonly ResourcesNumberField Findings_summarySeveritiesHigh = new ResourcesNumberField("findings_summary.severities.high");
        /// <summary>
        /// Constant Findings_summarySeveritiesInformational for ResourcesNumberField
        /// </summary>
        public static readonly ResourcesNumberField Findings_summarySeveritiesInformational = new ResourcesNumberField("findings_summary.severities.informational");
        /// <summary>
        /// Constant Findings_summarySeveritiesLow for ResourcesNumberField
        /// </summary>
        public static readonly ResourcesNumberField Findings_summarySeveritiesLow = new ResourcesNumberField("findings_summary.severities.low");
        /// <summary>
        /// Constant Findings_summarySeveritiesMedium for ResourcesNumberField
        /// </summary>
        public static readonly ResourcesNumberField Findings_summarySeveritiesMedium = new ResourcesNumberField("findings_summary.severities.medium");
        /// <summary>
        /// Constant Findings_summarySeveritiesOther for ResourcesNumberField
        /// </summary>
        public static readonly ResourcesNumberField Findings_summarySeveritiesOther = new ResourcesNumberField("findings_summary.severities.other");
        /// <summary>
        /// Constant Findings_summarySeveritiesUnknown for ResourcesNumberField
        /// </summary>
        public static readonly ResourcesNumberField Findings_summarySeveritiesUnknown = new ResourcesNumberField("findings_summary.severities.unknown");
        /// <summary>
        /// Constant Findings_summaryTotal_findings for ResourcesNumberField
        /// </summary>
        public static readonly ResourcesNumberField Findings_summaryTotal_findings = new ResourcesNumberField("findings_summary.total_findings");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ResourcesNumberField(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ResourcesNumberField FindValue(string value)
        {
            return FindValue<ResourcesNumberField>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ResourcesNumberField(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ResourcesStringField.
    /// </summary>
    public class ResourcesStringField : ConstantClass
    {

        /// <summary>
        /// Constant Account_id for ResourcesStringField
        /// </summary>
        public static readonly ResourcesStringField Account_id = new ResourcesStringField("account_id");
        /// <summary>
        /// Constant Findings_summaryFinding_type for ResourcesStringField
        /// </summary>
        public static readonly ResourcesStringField Findings_summaryFinding_type = new ResourcesStringField("findings_summary.finding_type");
        /// <summary>
        /// Constant Findings_summaryProduct_name for ResourcesStringField
        /// </summary>
        public static readonly ResourcesStringField Findings_summaryProduct_name = new ResourcesStringField("findings_summary.product_name");
        /// <summary>
        /// Constant Region for ResourcesStringField
        /// </summary>
        public static readonly ResourcesStringField Region = new ResourcesStringField("region");
        /// <summary>
        /// Constant Resource_arn for ResourcesStringField
        /// </summary>
        public static readonly ResourcesStringField Resource_arn = new ResourcesStringField("resource_arn");
        /// <summary>
        /// Constant Resource_category for ResourcesStringField
        /// </summary>
        public static readonly ResourcesStringField Resource_category = new ResourcesStringField("resource_category");
        /// <summary>
        /// Constant Resource_id for ResourcesStringField
        /// </summary>
        public static readonly ResourcesStringField Resource_id = new ResourcesStringField("resource_id");
        /// <summary>
        /// Constant Resource_name for ResourcesStringField
        /// </summary>
        public static readonly ResourcesStringField Resource_name = new ResourcesStringField("resource_name");
        /// <summary>
        /// Constant Resource_type for ResourcesStringField
        /// </summary>
        public static readonly ResourcesStringField Resource_type = new ResourcesStringField("resource_type");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ResourcesStringField(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ResourcesStringField FindValue(string value)
        {
            return FindValue<ResourcesStringField>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ResourcesStringField(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RuleStatus.
    /// </summary>
    public class RuleStatus : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for RuleStatus
        /// </summary>
        public static readonly RuleStatus DISABLED = new RuleStatus("DISABLED");
        /// <summary>
        /// Constant ENABLED for RuleStatus
        /// </summary>
        public static readonly RuleStatus ENABLED = new RuleStatus("ENABLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RuleStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RuleStatus FindValue(string value)
        {
            return FindValue<RuleStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RuleStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RuleStatusV2.
    /// </summary>
    public class RuleStatusV2 : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for RuleStatusV2
        /// </summary>
        public static readonly RuleStatusV2 DISABLED = new RuleStatusV2("DISABLED");
        /// <summary>
        /// Constant ENABLED for RuleStatusV2
        /// </summary>
        public static readonly RuleStatusV2 ENABLED = new RuleStatusV2("ENABLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RuleStatusV2(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RuleStatusV2 FindValue(string value)
        {
            return FindValue<RuleStatusV2>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RuleStatusV2(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SecurityControlProperty.
    /// </summary>
    public class SecurityControlProperty : ConstantClass
    {

        /// <summary>
        /// Constant Parameters for SecurityControlProperty
        /// </summary>
        public static readonly SecurityControlProperty Parameters = new SecurityControlProperty("Parameters");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SecurityControlProperty(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SecurityControlProperty FindValue(string value)
        {
            return FindValue<SecurityControlProperty>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SecurityControlProperty(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SecurityHubFeature.
    /// </summary>
    public class SecurityHubFeature : ConstantClass
    {

        /// <summary>
        /// Constant SecurityHub for SecurityHubFeature
        /// </summary>
        public static readonly SecurityHubFeature SecurityHub = new SecurityHubFeature("SecurityHub");
        /// <summary>
        /// Constant SecurityHubV2 for SecurityHubFeature
        /// </summary>
        public static readonly SecurityHubFeature SecurityHubV2 = new SecurityHubFeature("SecurityHubV2");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SecurityHubFeature(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SecurityHubFeature FindValue(string value)
        {
            return FindValue<SecurityHubFeature>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SecurityHubFeature(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SeverityLabel.
    /// </summary>
    public class SeverityLabel : ConstantClass
    {

        /// <summary>
        /// Constant CRITICAL for SeverityLabel
        /// </summary>
        public static readonly SeverityLabel CRITICAL = new SeverityLabel("CRITICAL");
        /// <summary>
        /// Constant HIGH for SeverityLabel
        /// </summary>
        public static readonly SeverityLabel HIGH = new SeverityLabel("HIGH");
        /// <summary>
        /// Constant INFORMATIONAL for SeverityLabel
        /// </summary>
        public static readonly SeverityLabel INFORMATIONAL = new SeverityLabel("INFORMATIONAL");
        /// <summary>
        /// Constant LOW for SeverityLabel
        /// </summary>
        public static readonly SeverityLabel LOW = new SeverityLabel("LOW");
        /// <summary>
        /// Constant MEDIUM for SeverityLabel
        /// </summary>
        public static readonly SeverityLabel MEDIUM = new SeverityLabel("MEDIUM");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SeverityLabel(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SeverityLabel FindValue(string value)
        {
            return FindValue<SeverityLabel>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SeverityLabel(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SeverityRating.
    /// </summary>
    public class SeverityRating : ConstantClass
    {

        /// <summary>
        /// Constant CRITICAL for SeverityRating
        /// </summary>
        public static readonly SeverityRating CRITICAL = new SeverityRating("CRITICAL");
        /// <summary>
        /// Constant HIGH for SeverityRating
        /// </summary>
        public static readonly SeverityRating HIGH = new SeverityRating("HIGH");
        /// <summary>
        /// Constant LOW for SeverityRating
        /// </summary>
        public static readonly SeverityRating LOW = new SeverityRating("LOW");
        /// <summary>
        /// Constant MEDIUM for SeverityRating
        /// </summary>
        public static readonly SeverityRating MEDIUM = new SeverityRating("MEDIUM");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SeverityRating(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SeverityRating FindValue(string value)
        {
            return FindValue<SeverityRating>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SeverityRating(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SortOrder.
    /// </summary>
    public class SortOrder : ConstantClass
    {

        /// <summary>
        /// Constant Asc for SortOrder
        /// </summary>
        public static readonly SortOrder Asc = new SortOrder("asc");
        /// <summary>
        /// Constant Desc for SortOrder
        /// </summary>
        public static readonly SortOrder Desc = new SortOrder("desc");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SortOrder(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SortOrder FindValue(string value)
        {
            return FindValue<SortOrder>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SortOrder(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type StandardsControlsUpdatable.
    /// </summary>
    public class StandardsControlsUpdatable : ConstantClass
    {

        /// <summary>
        /// Constant NOT_READY_FOR_UPDATES for StandardsControlsUpdatable
        /// </summary>
        public static readonly StandardsControlsUpdatable NOT_READY_FOR_UPDATES = new StandardsControlsUpdatable("NOT_READY_FOR_UPDATES");
        /// <summary>
        /// Constant READY_FOR_UPDATES for StandardsControlsUpdatable
        /// </summary>
        public static readonly StandardsControlsUpdatable READY_FOR_UPDATES = new StandardsControlsUpdatable("READY_FOR_UPDATES");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public StandardsControlsUpdatable(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static StandardsControlsUpdatable FindValue(string value)
        {
            return FindValue<StandardsControlsUpdatable>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator StandardsControlsUpdatable(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type StandardsStatus.
    /// </summary>
    public class StandardsStatus : ConstantClass
    {

        /// <summary>
        /// Constant DELETING for StandardsStatus
        /// </summary>
        public static readonly StandardsStatus DELETING = new StandardsStatus("DELETING");
        /// <summary>
        /// Constant FAILED for StandardsStatus
        /// </summary>
        public static readonly StandardsStatus FAILED = new StandardsStatus("FAILED");
        /// <summary>
        /// Constant INCOMPLETE for StandardsStatus
        /// </summary>
        public static readonly StandardsStatus INCOMPLETE = new StandardsStatus("INCOMPLETE");
        /// <summary>
        /// Constant PENDING for StandardsStatus
        /// </summary>
        public static readonly StandardsStatus PENDING = new StandardsStatus("PENDING");
        /// <summary>
        /// Constant READY for StandardsStatus
        /// </summary>
        public static readonly StandardsStatus READY = new StandardsStatus("READY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public StandardsStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static StandardsStatus FindValue(string value)
        {
            return FindValue<StandardsStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator StandardsStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type StatusReasonCode.
    /// </summary>
    public class StatusReasonCode : ConstantClass
    {

        /// <summary>
        /// Constant INTERNAL_ERROR for StatusReasonCode
        /// </summary>
        public static readonly StatusReasonCode INTERNAL_ERROR = new StatusReasonCode("INTERNAL_ERROR");
        /// <summary>
        /// Constant MAXIMUM_NUMBER_OF_CONFIG_RULES_EXCEEDED for StatusReasonCode
        /// </summary>
        public static readonly StatusReasonCode MAXIMUM_NUMBER_OF_CONFIG_RULES_EXCEEDED = new StatusReasonCode("MAXIMUM_NUMBER_OF_CONFIG_RULES_EXCEEDED");
        /// <summary>
        /// Constant NO_AVAILABLE_CONFIGURATION_RECORDER for StatusReasonCode
        /// </summary>
        public static readonly StatusReasonCode NO_AVAILABLE_CONFIGURATION_RECORDER = new StatusReasonCode("NO_AVAILABLE_CONFIGURATION_RECORDER");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public StatusReasonCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static StatusReasonCode FindValue(string value)
        {
            return FindValue<StatusReasonCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator StatusReasonCode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type StringFilterComparison.
    /// </summary>
    public class StringFilterComparison : ConstantClass
    {

        /// <summary>
        /// Constant CONTAINS for StringFilterComparison
        /// </summary>
        public static readonly StringFilterComparison CONTAINS = new StringFilterComparison("CONTAINS");
        /// <summary>
        /// Constant CONTAINS_WORD for StringFilterComparison
        /// </summary>
        public static readonly StringFilterComparison CONTAINS_WORD = new StringFilterComparison("CONTAINS_WORD");
        /// <summary>
        /// Constant EQUALS for StringFilterComparison
        /// </summary>
        public static readonly StringFilterComparison EQUALS = new StringFilterComparison("EQUALS");
        /// <summary>
        /// Constant NOT_CONTAINS for StringFilterComparison
        /// </summary>
        public static readonly StringFilterComparison NOT_CONTAINS = new StringFilterComparison("NOT_CONTAINS");
        /// <summary>
        /// Constant NOT_EQUALS for StringFilterComparison
        /// </summary>
        public static readonly StringFilterComparison NOT_EQUALS = new StringFilterComparison("NOT_EQUALS");
        /// <summary>
        /// Constant PREFIX for StringFilterComparison
        /// </summary>
        public static readonly StringFilterComparison PREFIX = new StringFilterComparison("PREFIX");
        /// <summary>
        /// Constant PREFIX_NOT_EQUALS for StringFilterComparison
        /// </summary>
        public static readonly StringFilterComparison PREFIX_NOT_EQUALS = new StringFilterComparison("PREFIX_NOT_EQUALS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public StringFilterComparison(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static StringFilterComparison FindValue(string value)
        {
            return FindValue<StringFilterComparison>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator StringFilterComparison(string value)
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
        /// Constant ACCOUNT for TargetType
        /// </summary>
        public static readonly TargetType ACCOUNT = new TargetType("ACCOUNT");
        /// <summary>
        /// Constant ORGANIZATIONAL_UNIT for TargetType
        /// </summary>
        public static readonly TargetType ORGANIZATIONAL_UNIT = new TargetType("ORGANIZATIONAL_UNIT");
        /// <summary>
        /// Constant ROOT for TargetType
        /// </summary>
        public static readonly TargetType ROOT = new TargetType("ROOT");

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
    /// Constants used for properties of type ThreatIntelIndicatorCategory.
    /// </summary>
    public class ThreatIntelIndicatorCategory : ConstantClass
    {

        /// <summary>
        /// Constant BACKDOOR for ThreatIntelIndicatorCategory
        /// </summary>
        public static readonly ThreatIntelIndicatorCategory BACKDOOR = new ThreatIntelIndicatorCategory("BACKDOOR");
        /// <summary>
        /// Constant CARD_STEALER for ThreatIntelIndicatorCategory
        /// </summary>
        public static readonly ThreatIntelIndicatorCategory CARD_STEALER = new ThreatIntelIndicatorCategory("CARD_STEALER");
        /// <summary>
        /// Constant COMMAND_AND_CONTROL for ThreatIntelIndicatorCategory
        /// </summary>
        public static readonly ThreatIntelIndicatorCategory COMMAND_AND_CONTROL = new ThreatIntelIndicatorCategory("COMMAND_AND_CONTROL");
        /// <summary>
        /// Constant DROP_SITE for ThreatIntelIndicatorCategory
        /// </summary>
        public static readonly ThreatIntelIndicatorCategory DROP_SITE = new ThreatIntelIndicatorCategory("DROP_SITE");
        /// <summary>
        /// Constant EXPLOIT_SITE for ThreatIntelIndicatorCategory
        /// </summary>
        public static readonly ThreatIntelIndicatorCategory EXPLOIT_SITE = new ThreatIntelIndicatorCategory("EXPLOIT_SITE");
        /// <summary>
        /// Constant KEYLOGGER for ThreatIntelIndicatorCategory
        /// </summary>
        public static readonly ThreatIntelIndicatorCategory KEYLOGGER = new ThreatIntelIndicatorCategory("KEYLOGGER");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ThreatIntelIndicatorCategory(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ThreatIntelIndicatorCategory FindValue(string value)
        {
            return FindValue<ThreatIntelIndicatorCategory>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ThreatIntelIndicatorCategory(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ThreatIntelIndicatorType.
    /// </summary>
    public class ThreatIntelIndicatorType : ConstantClass
    {

        /// <summary>
        /// Constant DOMAIN for ThreatIntelIndicatorType
        /// </summary>
        public static readonly ThreatIntelIndicatorType DOMAIN = new ThreatIntelIndicatorType("DOMAIN");
        /// <summary>
        /// Constant EMAIL_ADDRESS for ThreatIntelIndicatorType
        /// </summary>
        public static readonly ThreatIntelIndicatorType EMAIL_ADDRESS = new ThreatIntelIndicatorType("EMAIL_ADDRESS");
        /// <summary>
        /// Constant HASH_MD5 for ThreatIntelIndicatorType
        /// </summary>
        public static readonly ThreatIntelIndicatorType HASH_MD5 = new ThreatIntelIndicatorType("HASH_MD5");
        /// <summary>
        /// Constant HASH_SHA1 for ThreatIntelIndicatorType
        /// </summary>
        public static readonly ThreatIntelIndicatorType HASH_SHA1 = new ThreatIntelIndicatorType("HASH_SHA1");
        /// <summary>
        /// Constant HASH_SHA256 for ThreatIntelIndicatorType
        /// </summary>
        public static readonly ThreatIntelIndicatorType HASH_SHA256 = new ThreatIntelIndicatorType("HASH_SHA256");
        /// <summary>
        /// Constant HASH_SHA512 for ThreatIntelIndicatorType
        /// </summary>
        public static readonly ThreatIntelIndicatorType HASH_SHA512 = new ThreatIntelIndicatorType("HASH_SHA512");
        /// <summary>
        /// Constant IPV4_ADDRESS for ThreatIntelIndicatorType
        /// </summary>
        public static readonly ThreatIntelIndicatorType IPV4_ADDRESS = new ThreatIntelIndicatorType("IPV4_ADDRESS");
        /// <summary>
        /// Constant IPV6_ADDRESS for ThreatIntelIndicatorType
        /// </summary>
        public static readonly ThreatIntelIndicatorType IPV6_ADDRESS = new ThreatIntelIndicatorType("IPV6_ADDRESS");
        /// <summary>
        /// Constant MUTEX for ThreatIntelIndicatorType
        /// </summary>
        public static readonly ThreatIntelIndicatorType MUTEX = new ThreatIntelIndicatorType("MUTEX");
        /// <summary>
        /// Constant PROCESS for ThreatIntelIndicatorType
        /// </summary>
        public static readonly ThreatIntelIndicatorType PROCESS = new ThreatIntelIndicatorType("PROCESS");
        /// <summary>
        /// Constant URL for ThreatIntelIndicatorType
        /// </summary>
        public static readonly ThreatIntelIndicatorType URL = new ThreatIntelIndicatorType("URL");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ThreatIntelIndicatorType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ThreatIntelIndicatorType FindValue(string value)
        {
            return FindValue<ThreatIntelIndicatorType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ThreatIntelIndicatorType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type UnprocessedErrorCode.
    /// </summary>
    public class UnprocessedErrorCode : ConstantClass
    {

        /// <summary>
        /// Constant ACCESS_DENIED for UnprocessedErrorCode
        /// </summary>
        public static readonly UnprocessedErrorCode ACCESS_DENIED = new UnprocessedErrorCode("ACCESS_DENIED");
        /// <summary>
        /// Constant INVALID_INPUT for UnprocessedErrorCode
        /// </summary>
        public static readonly UnprocessedErrorCode INVALID_INPUT = new UnprocessedErrorCode("INVALID_INPUT");
        /// <summary>
        /// Constant LIMIT_EXCEEDED for UnprocessedErrorCode
        /// </summary>
        public static readonly UnprocessedErrorCode LIMIT_EXCEEDED = new UnprocessedErrorCode("LIMIT_EXCEEDED");
        /// <summary>
        /// Constant NOT_FOUND for UnprocessedErrorCode
        /// </summary>
        public static readonly UnprocessedErrorCode NOT_FOUND = new UnprocessedErrorCode("NOT_FOUND");
        /// <summary>
        /// Constant RESOURCE_NOT_FOUND for UnprocessedErrorCode
        /// </summary>
        public static readonly UnprocessedErrorCode RESOURCE_NOT_FOUND = new UnprocessedErrorCode("RESOURCE_NOT_FOUND");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public UnprocessedErrorCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static UnprocessedErrorCode FindValue(string value)
        {
            return FindValue<UnprocessedErrorCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator UnprocessedErrorCode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type UpdateStatus.
    /// </summary>
    public class UpdateStatus : ConstantClass
    {

        /// <summary>
        /// Constant READY for UpdateStatus
        /// </summary>
        public static readonly UpdateStatus READY = new UpdateStatus("READY");
        /// <summary>
        /// Constant UPDATING for UpdateStatus
        /// </summary>
        public static readonly UpdateStatus UPDATING = new UpdateStatus("UPDATING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public UpdateStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static UpdateStatus FindValue(string value)
        {
            return FindValue<UpdateStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator UpdateStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type VerificationState.
    /// </summary>
    public class VerificationState : ConstantClass
    {

        /// <summary>
        /// Constant BENIGN_POSITIVE for VerificationState
        /// </summary>
        public static readonly VerificationState BENIGN_POSITIVE = new VerificationState("BENIGN_POSITIVE");
        /// <summary>
        /// Constant FALSE_POSITIVE for VerificationState
        /// </summary>
        public static readonly VerificationState FALSE_POSITIVE = new VerificationState("FALSE_POSITIVE");
        /// <summary>
        /// Constant TRUE_POSITIVE for VerificationState
        /// </summary>
        public static readonly VerificationState TRUE_POSITIVE = new VerificationState("TRUE_POSITIVE");
        /// <summary>
        /// Constant UNKNOWN for VerificationState
        /// </summary>
        public static readonly VerificationState UNKNOWN = new VerificationState("UNKNOWN");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public VerificationState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static VerificationState FindValue(string value)
        {
            return FindValue<VerificationState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator VerificationState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type VulnerabilityExploitAvailable.
    /// </summary>
    public class VulnerabilityExploitAvailable : ConstantClass
    {

        /// <summary>
        /// Constant NO for VulnerabilityExploitAvailable
        /// </summary>
        public static readonly VulnerabilityExploitAvailable NO = new VulnerabilityExploitAvailable("NO");
        /// <summary>
        /// Constant YES for VulnerabilityExploitAvailable
        /// </summary>
        public static readonly VulnerabilityExploitAvailable YES = new VulnerabilityExploitAvailable("YES");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public VulnerabilityExploitAvailable(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static VulnerabilityExploitAvailable FindValue(string value)
        {
            return FindValue<VulnerabilityExploitAvailable>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator VulnerabilityExploitAvailable(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type VulnerabilityFixAvailable.
    /// </summary>
    public class VulnerabilityFixAvailable : ConstantClass
    {

        /// <summary>
        /// Constant NO for VulnerabilityFixAvailable
        /// </summary>
        public static readonly VulnerabilityFixAvailable NO = new VulnerabilityFixAvailable("NO");
        /// <summary>
        /// Constant PARTIAL for VulnerabilityFixAvailable
        /// </summary>
        public static readonly VulnerabilityFixAvailable PARTIAL = new VulnerabilityFixAvailable("PARTIAL");
        /// <summary>
        /// Constant YES for VulnerabilityFixAvailable
        /// </summary>
        public static readonly VulnerabilityFixAvailable YES = new VulnerabilityFixAvailable("YES");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public VulnerabilityFixAvailable(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static VulnerabilityFixAvailable FindValue(string value)
        {
            return FindValue<VulnerabilityFixAvailable>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator VulnerabilityFixAvailable(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type WorkflowState.
    /// </summary>
    public class WorkflowState : ConstantClass
    {

        /// <summary>
        /// Constant ASSIGNED for WorkflowState
        /// </summary>
        public static readonly WorkflowState ASSIGNED = new WorkflowState("ASSIGNED");
        /// <summary>
        /// Constant DEFERRED for WorkflowState
        /// </summary>
        public static readonly WorkflowState DEFERRED = new WorkflowState("DEFERRED");
        /// <summary>
        /// Constant IN_PROGRESS for WorkflowState
        /// </summary>
        public static readonly WorkflowState IN_PROGRESS = new WorkflowState("IN_PROGRESS");
        /// <summary>
        /// Constant NEW for WorkflowState
        /// </summary>
        public static readonly WorkflowState NEW = new WorkflowState("NEW");
        /// <summary>
        /// Constant RESOLVED for WorkflowState
        /// </summary>
        public static readonly WorkflowState RESOLVED = new WorkflowState("RESOLVED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public WorkflowState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static WorkflowState FindValue(string value)
        {
            return FindValue<WorkflowState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator WorkflowState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type WorkflowStatus.
    /// </summary>
    public class WorkflowStatus : ConstantClass
    {

        /// <summary>
        /// Constant NEW for WorkflowStatus
        /// </summary>
        public static readonly WorkflowStatus NEW = new WorkflowStatus("NEW");
        /// <summary>
        /// Constant NOTIFIED for WorkflowStatus
        /// </summary>
        public static readonly WorkflowStatus NOTIFIED = new WorkflowStatus("NOTIFIED");
        /// <summary>
        /// Constant RESOLVED for WorkflowStatus
        /// </summary>
        public static readonly WorkflowStatus RESOLVED = new WorkflowStatus("RESOLVED");
        /// <summary>
        /// Constant SUPPRESSED for WorkflowStatus
        /// </summary>
        public static readonly WorkflowStatus SUPPRESSED = new WorkflowStatus("SUPPRESSED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public WorkflowStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static WorkflowStatus FindValue(string value)
        {
            return FindValue<WorkflowStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator WorkflowStatus(string value)
        {
            return FindValue(value);
        }
    }

}