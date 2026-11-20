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
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using Amazon.Runtime;

namespace Amazon.AgentRegistryControl
{
    /// <summary>
    /// Constants used for properties of type AgentCoreGatewayProtocolType.
    /// </summary>
    public class AgentCoreGatewayProtocolType : ConstantClass
    {
        /// <summary>
        /// Constant MCP for AgentCoreGatewayProtocolType
        /// </summary>
        public static readonly AgentCoreGatewayProtocolType MCP = new AgentCoreGatewayProtocolType("MCP");

        /// <summary>
        /// Constructs a custom AgentCoreGatewayProtocolType for a value not among the defined constants.
        /// </summary>
        public AgentCoreGatewayProtocolType(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AgentCoreGatewayProtocolType FindValue(string value)
        {
            return FindValue<AgentCoreGatewayProtocolType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AgentCoreGatewayProtocolType(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type AgentCoreRuntimeServerProtocol.
    /// </summary>
    public class AgentCoreRuntimeServerProtocol : ConstantClass
    {
        /// <summary>
        /// Constant A2A for AgentCoreRuntimeServerProtocol
        /// </summary>
        public static readonly AgentCoreRuntimeServerProtocol A2A = new AgentCoreRuntimeServerProtocol("A2A");

        /// <summary>
        /// Constant AGUI for AgentCoreRuntimeServerProtocol
        /// </summary>
        public static readonly AgentCoreRuntimeServerProtocol AGUI = new AgentCoreRuntimeServerProtocol("AGUI");

        /// <summary>
        /// Constant HTTP for AgentCoreRuntimeServerProtocol
        /// </summary>
        public static readonly AgentCoreRuntimeServerProtocol HTTP = new AgentCoreRuntimeServerProtocol("HTTP");

        /// <summary>
        /// Constant MCP for AgentCoreRuntimeServerProtocol
        /// </summary>
        public static readonly AgentCoreRuntimeServerProtocol MCP = new AgentCoreRuntimeServerProtocol("MCP");

        /// <summary>
        /// Constructs a custom AgentCoreRuntimeServerProtocol for a value not among the defined constants.
        /// </summary>
        public AgentCoreRuntimeServerProtocol(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AgentCoreRuntimeServerProtocol FindValue(string value)
        {
            return FindValue<AgentCoreRuntimeServerProtocol>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AgentCoreRuntimeServerProtocol(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type AgentSkillsRepositoryProvider.
    /// </summary>
    public class AgentSkillsRepositoryProvider : ConstantClass
    {
        /// <summary>
        /// Constant GITHUB for AgentSkillsRepositoryProvider
        /// </summary>
        public static readonly AgentSkillsRepositoryProvider GITHUB = new AgentSkillsRepositoryProvider("GITHUB");

        /// <summary>
        /// Constructs a custom AgentSkillsRepositoryProvider for a value not among the defined constants.
        /// </summary>
        public AgentSkillsRepositoryProvider(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AgentSkillsRepositoryProvider FindValue(string value)
        {
            return FindValue<AgentSkillsRepositoryProvider>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AgentSkillsRepositoryProvider(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type AssociationApprovalStatus.
    /// </summary>
    public class AssociationApprovalStatus : ConstantClass
    {
        /// <summary>
        /// Constant APPROVED for AssociationApprovalStatus
        /// </summary>
        public static readonly AssociationApprovalStatus APPROVED = new AssociationApprovalStatus("APPROVED");

        /// <summary>
        /// Constant REJECTED for AssociationApprovalStatus
        /// </summary>
        public static readonly AssociationApprovalStatus REJECTED = new AssociationApprovalStatus("REJECTED");

        /// <summary>
        /// Constructs a custom AssociationApprovalStatus for a value not among the defined constants.
        /// </summary>
        public AssociationApprovalStatus(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AssociationApprovalStatus FindValue(string value)
        {
            return FindValue<AssociationApprovalStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AssociationApprovalStatus(string value)
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
        /// Constant APPROVED for AssociationStatus
        /// </summary>
        public static readonly AssociationStatus APPROVED = new AssociationStatus("APPROVED");

        /// <summary>
        /// Constant PENDING_APPROVAL for AssociationStatus
        /// </summary>
        public static readonly AssociationStatus PENDING_APPROVAL = new AssociationStatus("PENDING_APPROVAL");

        /// <summary>
        /// Constant REJECTED for AssociationStatus
        /// </summary>
        public static readonly AssociationStatus REJECTED = new AssociationStatus("REJECTED");

        /// <summary>
        /// Constant SUSPENDED for AssociationStatus
        /// </summary>
        public static readonly AssociationStatus SUSPENDED = new AssociationStatus("SUSPENDED");

        /// <summary>
        /// Constructs a custom AssociationStatus for a value not among the defined constants.
        /// </summary>
        public AssociationStatus(string value) : base(value) { }

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
    /// Constants used for properties of type AutoApprovalRule.
    /// </summary>
    public class AutoApprovalRule : ConstantClass
    {
        /// <summary>
        /// Constant APPROVE_ALL for AutoApprovalRule
        /// </summary>
        public static readonly AutoApprovalRule APPROVE_ALL = new AutoApprovalRule("APPROVE_ALL");

        /// <summary>
        /// Constructs a custom AutoApprovalRule for a value not among the defined constants.
        /// </summary>
        public AutoApprovalRule(string value) : base(value) { }

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
    /// Constants used for properties of type AutoDetectionScope.
    /// </summary>
    public class AutoDetectionScope : ConstantClass
    {
        /// <summary>
        /// Constant ORGANIZATION for AutoDetectionScope
        /// </summary>
        public static readonly AutoDetectionScope ORGANIZATION = new AutoDetectionScope("ORGANIZATION");

        /// <summary>
        /// Constructs a custom AutoDetectionScope for a value not among the defined constants.
        /// </summary>
        public AutoDetectionScope(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AutoDetectionScope FindValue(string value)
        {
            return FindValue<AutoDetectionScope>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AutoDetectionScope(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type AutoDetectionStatus.
    /// </summary>
    public class AutoDetectionStatus : ConstantClass
    {
        /// <summary>
        /// Constant ACTIVE for AutoDetectionStatus
        /// </summary>
        public static readonly AutoDetectionStatus ACTIVE = new AutoDetectionStatus("ACTIVE");

        /// <summary>
        /// Constant INACTIVE for AutoDetectionStatus
        /// </summary>
        public static readonly AutoDetectionStatus INACTIVE = new AutoDetectionStatus("INACTIVE");

        /// <summary>
        /// Constructs a custom AutoDetectionStatus for a value not among the defined constants.
        /// </summary>
        public AutoDetectionStatus(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AutoDetectionStatus FindValue(string value)
        {
            return FindValue<AutoDetectionStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AutoDetectionStatus(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type BotCategory.
    /// </summary>
    public class BotCategory : ConstantClass
    {
        /// <summary>
        /// Constant Advertising for BotCategory
        /// </summary>
        public static readonly BotCategory Advertising = new BotCategory("advertising");

        /// <summary>
        /// Constant Ai_assistant for BotCategory
        /// </summary>
        public static readonly BotCategory Ai_assistant = new BotCategory("ai_assistant");

        /// <summary>
        /// Constant Ai_content_optimization for BotCategory
        /// </summary>
        public static readonly BotCategory Ai_content_optimization = new BotCategory("ai_content_optimization");

        /// <summary>
        /// Constant Ai_search for BotCategory
        /// </summary>
        public static readonly BotCategory Ai_search = new BotCategory("ai_search");

        /// <summary>
        /// Constant Ai_training for BotCategory
        /// </summary>
        public static readonly BotCategory Ai_training = new BotCategory("ai_training");

        /// <summary>
        /// Constant Archiver for BotCategory
        /// </summary>
        public static readonly BotCategory Archiver = new BotCategory("archiver");

        /// <summary>
        /// Constant Content_fetcher for BotCategory
        /// </summary>
        public static readonly BotCategory Content_fetcher = new BotCategory("content_fetcher");

        /// <summary>
        /// Constant Email_client for BotCategory
        /// </summary>
        public static readonly BotCategory Email_client = new BotCategory("email_client");

        /// <summary>
        /// Constant Http_library for BotCategory
        /// </summary>
        public static readonly BotCategory Http_library = new BotCategory("http_library");

        /// <summary>
        /// Constant Link_checker for BotCategory
        /// </summary>
        public static readonly BotCategory Link_checker = new BotCategory("link_checker");

        /// <summary>
        /// Constant Miscellaneous for BotCategory
        /// </summary>
        public static readonly BotCategory Miscellaneous = new BotCategory("miscellaneous");

        /// <summary>
        /// Constant Monitoring for BotCategory
        /// </summary>
        public static readonly BotCategory Monitoring = new BotCategory("monitoring");

        /// <summary>
        /// Constant Page_preview for BotCategory
        /// </summary>
        public static readonly BotCategory Page_preview = new BotCategory("page_preview");

        /// <summary>
        /// Constant Scraping_framework for BotCategory
        /// </summary>
        public static readonly BotCategory Scraping_framework = new BotCategory("scraping_framework");

        /// <summary>
        /// Constant Search_engine for BotCategory
        /// </summary>
        public static readonly BotCategory Search_engine = new BotCategory("search_engine");

        /// <summary>
        /// Constant Security for BotCategory
        /// </summary>
        public static readonly BotCategory Security = new BotCategory("security");

        /// <summary>
        /// Constant Seo for BotCategory
        /// </summary>
        public static readonly BotCategory Seo = new BotCategory("seo");

        /// <summary>
        /// Constant Social_media for BotCategory
        /// </summary>
        public static readonly BotCategory Social_media = new BotCategory("social_media");

        /// <summary>
        /// Constructs a custom BotCategory for a value not among the defined constants.
        /// </summary>
        public BotCategory(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static BotCategory FindValue(string value)
        {
            return FindValue<BotCategory>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator BotCategory(string value)
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
        /// Constructs a custom ClaimMatchOperatorType for a value not among the defined constants.
        /// </summary>
        public ClaimMatchOperatorType(string value) : base(value) { }

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
    /// Constants used for properties of type CustomMetadataSchemaComplianceStatus.
    /// </summary>
    public class CustomMetadataSchemaComplianceStatus : ConstantClass
    {
        /// <summary>
        /// Constant COMPLIANT for CustomMetadataSchemaComplianceStatus
        /// </summary>
        public static readonly CustomMetadataSchemaComplianceStatus COMPLIANT = new CustomMetadataSchemaComplianceStatus("COMPLIANT");

        /// <summary>
        /// Constant NON_COMPLIANT for CustomMetadataSchemaComplianceStatus
        /// </summary>
        public static readonly CustomMetadataSchemaComplianceStatus NON_COMPLIANT = new CustomMetadataSchemaComplianceStatus("NON_COMPLIANT");

        /// <summary>
        /// Constructs a custom CustomMetadataSchemaComplianceStatus for a value not among the defined constants.
        /// </summary>
        public CustomMetadataSchemaComplianceStatus(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CustomMetadataSchemaComplianceStatus FindValue(string value)
        {
            return FindValue<CustomMetadataSchemaComplianceStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CustomMetadataSchemaComplianceStatus(string value)
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
        /// Constructs a custom EndpointIpAddressType for a value not among the defined constants.
        /// </summary>
        public EndpointIpAddressType(string value) : base(value) { }

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
    /// Constants used for properties of type IdentifierType.
    /// </summary>
    public class IdentifierType : ConstantClass
    {
        /// <summary>
        /// Constant DOMAIN for IdentifierType
        /// </summary>
        public static readonly IdentifierType DOMAIN = new IdentifierType("DOMAIN");

        /// <summary>
        /// Constructs a custom IdentifierType for a value not among the defined constants.
        /// </summary>
        public IdentifierType(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static IdentifierType FindValue(string value)
        {
            return FindValue<IdentifierType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator IdentifierType(string value)
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
        /// Constructs a custom InboundTokenClaimValueType for a value not among the defined constants.
        /// </summary>
        public InboundTokenClaimValueType(string value) : base(value) { }

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
    /// Constants used for properties of type ProvenanceRelation.
    /// </summary>
    public class ProvenanceRelation : ConstantClass
    {
        /// <summary>
        /// Constant DETECTED_FROM for ProvenanceRelation
        /// </summary>
        public static readonly ProvenanceRelation DETECTED_FROM = new ProvenanceRelation("DETECTED_FROM");

        /// <summary>
        /// Constructs a custom ProvenanceRelation for a value not among the defined constants.
        /// </summary>
        public ProvenanceRelation(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ProvenanceRelation FindValue(string value)
        {
            return FindValue<ProvenanceRelation>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ProvenanceRelation(string value)
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
        /// Constant GATEWAY for RecordType
        /// </summary>
        public static readonly RecordType GATEWAY = new RecordType("GATEWAY");

        /// <summary>
        /// Constant MCP for RecordType
        /// </summary>
        public static readonly RecordType MCP = new RecordType("MCP");

        /// <summary>
        /// Constant SKILL for RecordType
        /// </summary>
        public static readonly RecordType SKILL = new RecordType("SKILL");

        /// <summary>
        /// Constant WEB_BOT for RecordType
        /// </summary>
        public static readonly RecordType WEB_BOT = new RecordType("WEB_BOT");

        /// <summary>
        /// Constructs a custom RecordType for a value not among the defined constants.
        /// </summary>
        public RecordType(string value) : base(value) { }

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
        /// Constructs a custom RegistryAuthorizerType for a value not among the defined constants.
        /// </summary>
        public RegistryAuthorizerType(string value) : base(value) { }

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
        /// Constructs a custom RegistryFilterName for a value not among the defined constants.
        /// </summary>
        public RegistryFilterName(string value) : base(value) { }

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
        /// Constructs a custom RegistryRecordCredentialProviderType for a value not among the defined constants.
        /// </summary>
        public RegistryRecordCredentialProviderType(string value) : base(value) { }

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
        /// Constructs a custom RegistryRecordFilterName for a value not among the defined constants.
        /// </summary>
        public RegistryRecordFilterName(string value) : base(value) { }

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
        /// Constant AUTHORIZATION_CODE for RegistryRecordOAuthGrantType
        /// </summary>
        public static readonly RegistryRecordOAuthGrantType AUTHORIZATION_CODE = new RegistryRecordOAuthGrantType("AUTHORIZATION_CODE");

        /// <summary>
        /// Constant CLIENT_CREDENTIALS for RegistryRecordOAuthGrantType
        /// </summary>
        public static readonly RegistryRecordOAuthGrantType CLIENT_CREDENTIALS = new RegistryRecordOAuthGrantType("CLIENT_CREDENTIALS");

        /// <summary>
        /// Constructs a custom RegistryRecordOAuthGrantType for a value not among the defined constants.
        /// </summary>
        public RegistryRecordOAuthGrantType(string value) : base(value) { }

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
        /// Constant CREATE_PENDING_AUTH for RegistryRecordStatus
        /// </summary>
        public static readonly RegistryRecordStatus CREATE_PENDING_AUTH = new RegistryRecordStatus("CREATE_PENDING_AUTH");

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
        /// Constant UPDATE_PENDING_AUTH for RegistryRecordStatus
        /// </summary>
        public static readonly RegistryRecordStatus UPDATE_PENDING_AUTH = new RegistryRecordStatus("UPDATE_PENDING_AUTH");

        /// <summary>
        /// Constant UPDATING for RegistryRecordStatus
        /// </summary>
        public static readonly RegistryRecordStatus UPDATING = new RegistryRecordStatus("UPDATING");

        /// <summary>
        /// Constructs a custom RegistryRecordStatus for a value not among the defined constants.
        /// </summary>
        public RegistryRecordStatus(string value) : base(value) { }

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
        /// Constructs a custom RegistryStatus for a value not among the defined constants.
        /// </summary>
        public RegistryStatus(string value) : base(value) { }

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
    /// Constants used for properties of type SourceType.
    /// </summary>
    public class SourceType : ConstantClass
    {
        /// <summary>
        /// Constant AWSBedrockAgentCoreGateway for SourceType
        /// </summary>
        public static readonly SourceType AWSBedrockAgentCoreGateway = new SourceType("AWS::BedrockAgentCore::Gateway");

        /// <summary>
        /// Constant AWSBedrockAgentCoreRuntime for SourceType
        /// </summary>
        public static readonly SourceType AWSBedrockAgentCoreRuntime = new SourceType("AWS::BedrockAgentCore::Runtime");

        /// <summary>
        /// Constructs a custom SourceType for a value not among the defined constants.
        /// </summary>
        public SourceType(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SourceType FindValue(string value)
        {
            return FindValue<SourceType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SourceType(string value)
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
        /// Constant UnsupportedInRegion for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason UnsupportedInRegion = new ValidationExceptionReason("UnsupportedInRegion");

        /// <summary>
        /// Constructs a custom ValidationExceptionReason for a value not among the defined constants.
        /// </summary>
        public ValidationExceptionReason(string value) : base(value) { }

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
    /// Constants used for properties of type VerificationStatus.
    /// </summary>
    public class VerificationStatus : ConstantClass
    {
        /// <summary>
        /// Constant ACTION_REQUIRED for VerificationStatus
        /// </summary>
        public static readonly VerificationStatus ACTION_REQUIRED = new VerificationStatus("ACTION_REQUIRED");

        /// <summary>
        /// Constant ACTIVE for VerificationStatus
        /// </summary>
        public static readonly VerificationStatus ACTIVE = new VerificationStatus("ACTIVE");

        /// <summary>
        /// Constant DELETING for VerificationStatus
        /// </summary>
        public static readonly VerificationStatus DELETING = new VerificationStatus("DELETING");

        /// <summary>
        /// Constant FAILED for VerificationStatus
        /// </summary>
        public static readonly VerificationStatus FAILED = new VerificationStatus("FAILED");

        /// <summary>
        /// Constant SUSPENDED for VerificationStatus
        /// </summary>
        public static readonly VerificationStatus SUSPENDED = new VerificationStatus("SUSPENDED");

        /// <summary>
        /// Constructs a custom VerificationStatus for a value not among the defined constants.
        /// </summary>
        public VerificationStatus(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static VerificationStatus FindValue(string value)
        {
            return FindValue<VerificationStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator VerificationStatus(string value)
        {
            return FindValue(value);
        }
    }
}
