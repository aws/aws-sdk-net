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
 * Do not modify this file. This file is generated from the bedrock-agentcore-control-2023-06-05.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.BedrockAgentCoreControl
{

    /// <summary>
    /// Constants used for properties of type AgentRuntimeEndpointStatus.
    /// </summary>
    public class AgentRuntimeEndpointStatus : ConstantClass
    {

        /// <summary>
        /// Constant CREATE_FAILED for AgentRuntimeEndpointStatus
        /// </summary>
        public static readonly AgentRuntimeEndpointStatus CREATE_FAILED = new AgentRuntimeEndpointStatus("CREATE_FAILED");
        /// <summary>
        /// Constant CREATING for AgentRuntimeEndpointStatus
        /// </summary>
        public static readonly AgentRuntimeEndpointStatus CREATING = new AgentRuntimeEndpointStatus("CREATING");
        /// <summary>
        /// Constant DELETING for AgentRuntimeEndpointStatus
        /// </summary>
        public static readonly AgentRuntimeEndpointStatus DELETING = new AgentRuntimeEndpointStatus("DELETING");
        /// <summary>
        /// Constant READY for AgentRuntimeEndpointStatus
        /// </summary>
        public static readonly AgentRuntimeEndpointStatus READY = new AgentRuntimeEndpointStatus("READY");
        /// <summary>
        /// Constant UPDATE_FAILED for AgentRuntimeEndpointStatus
        /// </summary>
        public static readonly AgentRuntimeEndpointStatus UPDATE_FAILED = new AgentRuntimeEndpointStatus("UPDATE_FAILED");
        /// <summary>
        /// Constant UPDATING for AgentRuntimeEndpointStatus
        /// </summary>
        public static readonly AgentRuntimeEndpointStatus UPDATING = new AgentRuntimeEndpointStatus("UPDATING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AgentRuntimeEndpointStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AgentRuntimeEndpointStatus FindValue(string value)
        {
            return FindValue<AgentRuntimeEndpointStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AgentRuntimeEndpointStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AgentRuntimeStatus.
    /// </summary>
    public class AgentRuntimeStatus : ConstantClass
    {

        /// <summary>
        /// Constant CREATE_FAILED for AgentRuntimeStatus
        /// </summary>
        public static readonly AgentRuntimeStatus CREATE_FAILED = new AgentRuntimeStatus("CREATE_FAILED");
        /// <summary>
        /// Constant CREATING for AgentRuntimeStatus
        /// </summary>
        public static readonly AgentRuntimeStatus CREATING = new AgentRuntimeStatus("CREATING");
        /// <summary>
        /// Constant DELETING for AgentRuntimeStatus
        /// </summary>
        public static readonly AgentRuntimeStatus DELETING = new AgentRuntimeStatus("DELETING");
        /// <summary>
        /// Constant READY for AgentRuntimeStatus
        /// </summary>
        public static readonly AgentRuntimeStatus READY = new AgentRuntimeStatus("READY");
        /// <summary>
        /// Constant UPDATE_FAILED for AgentRuntimeStatus
        /// </summary>
        public static readonly AgentRuntimeStatus UPDATE_FAILED = new AgentRuntimeStatus("UPDATE_FAILED");
        /// <summary>
        /// Constant UPDATING for AgentRuntimeStatus
        /// </summary>
        public static readonly AgentRuntimeStatus UPDATING = new AgentRuntimeStatus("UPDATING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AgentRuntimeStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AgentRuntimeStatus FindValue(string value)
        {
            return FindValue<AgentRuntimeStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AgentRuntimeStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ApiKeyCredentialLocation.
    /// </summary>
    public class ApiKeyCredentialLocation : ConstantClass
    {

        /// <summary>
        /// Constant HEADER for ApiKeyCredentialLocation
        /// </summary>
        public static readonly ApiKeyCredentialLocation HEADER = new ApiKeyCredentialLocation("HEADER");
        /// <summary>
        /// Constant QUERY_PARAMETER for ApiKeyCredentialLocation
        /// </summary>
        public static readonly ApiKeyCredentialLocation QUERY_PARAMETER = new ApiKeyCredentialLocation("QUERY_PARAMETER");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ApiKeyCredentialLocation(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ApiKeyCredentialLocation FindValue(string value)
        {
            return FindValue<ApiKeyCredentialLocation>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ApiKeyCredentialLocation(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AuthorizerType.
    /// </summary>
    public class AuthorizerType : ConstantClass
    {

        /// <summary>
        /// Constant CUSTOM_JWT for AuthorizerType
        /// </summary>
        public static readonly AuthorizerType CUSTOM_JWT = new AuthorizerType("CUSTOM_JWT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AuthorizerType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AuthorizerType FindValue(string value)
        {
            return FindValue<AuthorizerType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AuthorizerType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type BrowserNetworkMode.
    /// </summary>
    public class BrowserNetworkMode : ConstantClass
    {

        /// <summary>
        /// Constant PUBLIC for BrowserNetworkMode
        /// </summary>
        public static readonly BrowserNetworkMode PUBLIC = new BrowserNetworkMode("PUBLIC");
        /// <summary>
        /// Constant VPC for BrowserNetworkMode
        /// </summary>
        public static readonly BrowserNetworkMode VPC = new BrowserNetworkMode("VPC");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public BrowserNetworkMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static BrowserNetworkMode FindValue(string value)
        {
            return FindValue<BrowserNetworkMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator BrowserNetworkMode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type BrowserStatus.
    /// </summary>
    public class BrowserStatus : ConstantClass
    {

        /// <summary>
        /// Constant CREATE_FAILED for BrowserStatus
        /// </summary>
        public static readonly BrowserStatus CREATE_FAILED = new BrowserStatus("CREATE_FAILED");
        /// <summary>
        /// Constant CREATING for BrowserStatus
        /// </summary>
        public static readonly BrowserStatus CREATING = new BrowserStatus("CREATING");
        /// <summary>
        /// Constant DELETE_FAILED for BrowserStatus
        /// </summary>
        public static readonly BrowserStatus DELETE_FAILED = new BrowserStatus("DELETE_FAILED");
        /// <summary>
        /// Constant DELETED for BrowserStatus
        /// </summary>
        public static readonly BrowserStatus DELETED = new BrowserStatus("DELETED");
        /// <summary>
        /// Constant DELETING for BrowserStatus
        /// </summary>
        public static readonly BrowserStatus DELETING = new BrowserStatus("DELETING");
        /// <summary>
        /// Constant READY for BrowserStatus
        /// </summary>
        public static readonly BrowserStatus READY = new BrowserStatus("READY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public BrowserStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static BrowserStatus FindValue(string value)
        {
            return FindValue<BrowserStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator BrowserStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CodeInterpreterNetworkMode.
    /// </summary>
    public class CodeInterpreterNetworkMode : ConstantClass
    {

        /// <summary>
        /// Constant PUBLIC for CodeInterpreterNetworkMode
        /// </summary>
        public static readonly CodeInterpreterNetworkMode PUBLIC = new CodeInterpreterNetworkMode("PUBLIC");
        /// <summary>
        /// Constant SANDBOX for CodeInterpreterNetworkMode
        /// </summary>
        public static readonly CodeInterpreterNetworkMode SANDBOX = new CodeInterpreterNetworkMode("SANDBOX");
        /// <summary>
        /// Constant VPC for CodeInterpreterNetworkMode
        /// </summary>
        public static readonly CodeInterpreterNetworkMode VPC = new CodeInterpreterNetworkMode("VPC");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CodeInterpreterNetworkMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CodeInterpreterNetworkMode FindValue(string value)
        {
            return FindValue<CodeInterpreterNetworkMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CodeInterpreterNetworkMode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CodeInterpreterStatus.
    /// </summary>
    public class CodeInterpreterStatus : ConstantClass
    {

        /// <summary>
        /// Constant CREATE_FAILED for CodeInterpreterStatus
        /// </summary>
        public static readonly CodeInterpreterStatus CREATE_FAILED = new CodeInterpreterStatus("CREATE_FAILED");
        /// <summary>
        /// Constant CREATING for CodeInterpreterStatus
        /// </summary>
        public static readonly CodeInterpreterStatus CREATING = new CodeInterpreterStatus("CREATING");
        /// <summary>
        /// Constant DELETE_FAILED for CodeInterpreterStatus
        /// </summary>
        public static readonly CodeInterpreterStatus DELETE_FAILED = new CodeInterpreterStatus("DELETE_FAILED");
        /// <summary>
        /// Constant DELETED for CodeInterpreterStatus
        /// </summary>
        public static readonly CodeInterpreterStatus DELETED = new CodeInterpreterStatus("DELETED");
        /// <summary>
        /// Constant DELETING for CodeInterpreterStatus
        /// </summary>
        public static readonly CodeInterpreterStatus DELETING = new CodeInterpreterStatus("DELETING");
        /// <summary>
        /// Constant READY for CodeInterpreterStatus
        /// </summary>
        public static readonly CodeInterpreterStatus READY = new CodeInterpreterStatus("READY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CodeInterpreterStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CodeInterpreterStatus FindValue(string value)
        {
            return FindValue<CodeInterpreterStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CodeInterpreterStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CredentialProviderType.
    /// </summary>
    public class CredentialProviderType : ConstantClass
    {

        /// <summary>
        /// Constant API_KEY for CredentialProviderType
        /// </summary>
        public static readonly CredentialProviderType API_KEY = new CredentialProviderType("API_KEY");
        /// <summary>
        /// Constant GATEWAY_IAM_ROLE for CredentialProviderType
        /// </summary>
        public static readonly CredentialProviderType GATEWAY_IAM_ROLE = new CredentialProviderType("GATEWAY_IAM_ROLE");
        /// <summary>
        /// Constant OAUTH for CredentialProviderType
        /// </summary>
        public static readonly CredentialProviderType OAUTH = new CredentialProviderType("OAUTH");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CredentialProviderType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CredentialProviderType FindValue(string value)
        {
            return FindValue<CredentialProviderType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CredentialProviderType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CredentialProviderVendorType.
    /// </summary>
    public class CredentialProviderVendorType : ConstantClass
    {

        /// <summary>
        /// Constant CustomOauth2 for CredentialProviderVendorType
        /// </summary>
        public static readonly CredentialProviderVendorType CustomOauth2 = new CredentialProviderVendorType("CustomOauth2");
        /// <summary>
        /// Constant GithubOauth2 for CredentialProviderVendorType
        /// </summary>
        public static readonly CredentialProviderVendorType GithubOauth2 = new CredentialProviderVendorType("GithubOauth2");
        /// <summary>
        /// Constant GoogleOauth2 for CredentialProviderVendorType
        /// </summary>
        public static readonly CredentialProviderVendorType GoogleOauth2 = new CredentialProviderVendorType("GoogleOauth2");
        /// <summary>
        /// Constant MicrosoftOauth2 for CredentialProviderVendorType
        /// </summary>
        public static readonly CredentialProviderVendorType MicrosoftOauth2 = new CredentialProviderVendorType("MicrosoftOauth2");
        /// <summary>
        /// Constant SalesforceOauth2 for CredentialProviderVendorType
        /// </summary>
        public static readonly CredentialProviderVendorType SalesforceOauth2 = new CredentialProviderVendorType("SalesforceOauth2");
        /// <summary>
        /// Constant SlackOauth2 for CredentialProviderVendorType
        /// </summary>
        public static readonly CredentialProviderVendorType SlackOauth2 = new CredentialProviderVendorType("SlackOauth2");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CredentialProviderVendorType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CredentialProviderVendorType FindValue(string value)
        {
            return FindValue<CredentialProviderVendorType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CredentialProviderVendorType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ExceptionLevel.
    /// </summary>
    public class ExceptionLevel : ConstantClass
    {

        /// <summary>
        /// Constant DEBUG for ExceptionLevel
        /// </summary>
        public static readonly ExceptionLevel DEBUG = new ExceptionLevel("DEBUG");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ExceptionLevel(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ExceptionLevel FindValue(string value)
        {
            return FindValue<ExceptionLevel>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ExceptionLevel(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type GatewayProtocolType.
    /// </summary>
    public class GatewayProtocolType : ConstantClass
    {

        /// <summary>
        /// Constant MCP for GatewayProtocolType
        /// </summary>
        public static readonly GatewayProtocolType MCP = new GatewayProtocolType("MCP");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public GatewayProtocolType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static GatewayProtocolType FindValue(string value)
        {
            return FindValue<GatewayProtocolType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator GatewayProtocolType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type GatewayStatus.
    /// </summary>
    public class GatewayStatus : ConstantClass
    {

        /// <summary>
        /// Constant CREATING for GatewayStatus
        /// </summary>
        public static readonly GatewayStatus CREATING = new GatewayStatus("CREATING");
        /// <summary>
        /// Constant DELETING for GatewayStatus
        /// </summary>
        public static readonly GatewayStatus DELETING = new GatewayStatus("DELETING");
        /// <summary>
        /// Constant FAILED for GatewayStatus
        /// </summary>
        public static readonly GatewayStatus FAILED = new GatewayStatus("FAILED");
        /// <summary>
        /// Constant READY for GatewayStatus
        /// </summary>
        public static readonly GatewayStatus READY = new GatewayStatus("READY");
        /// <summary>
        /// Constant UPDATE_UNSUCCESSFUL for GatewayStatus
        /// </summary>
        public static readonly GatewayStatus UPDATE_UNSUCCESSFUL = new GatewayStatus("UPDATE_UNSUCCESSFUL");
        /// <summary>
        /// Constant UPDATING for GatewayStatus
        /// </summary>
        public static readonly GatewayStatus UPDATING = new GatewayStatus("UPDATING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public GatewayStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static GatewayStatus FindValue(string value)
        {
            return FindValue<GatewayStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator GatewayStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type KeyType.
    /// </summary>
    public class KeyType : ConstantClass
    {

        /// <summary>
        /// Constant CustomerManagedKey for KeyType
        /// </summary>
        public static readonly KeyType CustomerManagedKey = new KeyType("CustomerManagedKey");
        /// <summary>
        /// Constant ServiceManagedKey for KeyType
        /// </summary>
        public static readonly KeyType ServiceManagedKey = new KeyType("ServiceManagedKey");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public KeyType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static KeyType FindValue(string value)
        {
            return FindValue<KeyType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator KeyType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type MemoryStatus.
    /// </summary>
    public class MemoryStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for MemoryStatus
        /// </summary>
        public static readonly MemoryStatus ACTIVE = new MemoryStatus("ACTIVE");
        /// <summary>
        /// Constant CREATING for MemoryStatus
        /// </summary>
        public static readonly MemoryStatus CREATING = new MemoryStatus("CREATING");
        /// <summary>
        /// Constant DELETING for MemoryStatus
        /// </summary>
        public static readonly MemoryStatus DELETING = new MemoryStatus("DELETING");
        /// <summary>
        /// Constant FAILED for MemoryStatus
        /// </summary>
        public static readonly MemoryStatus FAILED = new MemoryStatus("FAILED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MemoryStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MemoryStatus FindValue(string value)
        {
            return FindValue<MemoryStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MemoryStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type MemoryStrategyStatus.
    /// </summary>
    public class MemoryStrategyStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for MemoryStrategyStatus
        /// </summary>
        public static readonly MemoryStrategyStatus ACTIVE = new MemoryStrategyStatus("ACTIVE");
        /// <summary>
        /// Constant CREATING for MemoryStrategyStatus
        /// </summary>
        public static readonly MemoryStrategyStatus CREATING = new MemoryStrategyStatus("CREATING");
        /// <summary>
        /// Constant DELETING for MemoryStrategyStatus
        /// </summary>
        public static readonly MemoryStrategyStatus DELETING = new MemoryStrategyStatus("DELETING");
        /// <summary>
        /// Constant FAILED for MemoryStrategyStatus
        /// </summary>
        public static readonly MemoryStrategyStatus FAILED = new MemoryStrategyStatus("FAILED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MemoryStrategyStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MemoryStrategyStatus FindValue(string value)
        {
            return FindValue<MemoryStrategyStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MemoryStrategyStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type MemoryStrategyType.
    /// </summary>
    public class MemoryStrategyType : ConstantClass
    {

        /// <summary>
        /// Constant CUSTOM for MemoryStrategyType
        /// </summary>
        public static readonly MemoryStrategyType CUSTOM = new MemoryStrategyType("CUSTOM");
        /// <summary>
        /// Constant SEMANTIC for MemoryStrategyType
        /// </summary>
        public static readonly MemoryStrategyType SEMANTIC = new MemoryStrategyType("SEMANTIC");
        /// <summary>
        /// Constant SUMMARIZATION for MemoryStrategyType
        /// </summary>
        public static readonly MemoryStrategyType SUMMARIZATION = new MemoryStrategyType("SUMMARIZATION");
        /// <summary>
        /// Constant USER_PREFERENCE for MemoryStrategyType
        /// </summary>
        public static readonly MemoryStrategyType USER_PREFERENCE = new MemoryStrategyType("USER_PREFERENCE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MemoryStrategyType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MemoryStrategyType FindValue(string value)
        {
            return FindValue<MemoryStrategyType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MemoryStrategyType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type NetworkMode.
    /// </summary>
    public class NetworkMode : ConstantClass
    {

        /// <summary>
        /// Constant PUBLIC for NetworkMode
        /// </summary>
        public static readonly NetworkMode PUBLIC = new NetworkMode("PUBLIC");
        /// <summary>
        /// Constant VPC for NetworkMode
        /// </summary>
        public static readonly NetworkMode VPC = new NetworkMode("VPC");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public NetworkMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static NetworkMode FindValue(string value)
        {
            return FindValue<NetworkMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator NetworkMode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type OverrideType.
    /// </summary>
    public class OverrideType : ConstantClass
    {

        /// <summary>
        /// Constant SEMANTIC_OVERRIDE for OverrideType
        /// </summary>
        public static readonly OverrideType SEMANTIC_OVERRIDE = new OverrideType("SEMANTIC_OVERRIDE");
        /// <summary>
        /// Constant SUMMARY_OVERRIDE for OverrideType
        /// </summary>
        public static readonly OverrideType SUMMARY_OVERRIDE = new OverrideType("SUMMARY_OVERRIDE");
        /// <summary>
        /// Constant USER_PREFERENCE_OVERRIDE for OverrideType
        /// </summary>
        public static readonly OverrideType USER_PREFERENCE_OVERRIDE = new OverrideType("USER_PREFERENCE_OVERRIDE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public OverrideType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static OverrideType FindValue(string value)
        {
            return FindValue<OverrideType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator OverrideType(string value)
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
        /// Constant CUSTOM for ResourceType
        /// </summary>
        public static readonly ResourceType CUSTOM = new ResourceType("CUSTOM");
        /// <summary>
        /// Constant SYSTEM for ResourceType
        /// </summary>
        public static readonly ResourceType SYSTEM = new ResourceType("SYSTEM");

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
    /// Constants used for properties of type SchemaType.
    /// </summary>
    public class SchemaType : ConstantClass
    {

        /// <summary>
        /// Constant Array for SchemaType
        /// </summary>
        public static readonly SchemaType Array = new SchemaType("array");
        /// <summary>
        /// Constant Boolean for SchemaType
        /// </summary>
        public static readonly SchemaType Boolean = new SchemaType("boolean");
        /// <summary>
        /// Constant Integer for SchemaType
        /// </summary>
        public static readonly SchemaType Integer = new SchemaType("integer");
        /// <summary>
        /// Constant Number for SchemaType
        /// </summary>
        public static readonly SchemaType Number = new SchemaType("number");
        /// <summary>
        /// Constant Object for SchemaType
        /// </summary>
        public static readonly SchemaType Object = new SchemaType("object");
        /// <summary>
        /// Constant String for SchemaType
        /// </summary>
        public static readonly SchemaType String = new SchemaType("string");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SchemaType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SchemaType FindValue(string value)
        {
            return FindValue<SchemaType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SchemaType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SearchType.
    /// </summary>
    public class SearchType : ConstantClass
    {

        /// <summary>
        /// Constant SEMANTIC for SearchType
        /// </summary>
        public static readonly SearchType SEMANTIC = new SearchType("SEMANTIC");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SearchType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SearchType FindValue(string value)
        {
            return FindValue<SearchType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SearchType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ServerProtocol.
    /// </summary>
    public class ServerProtocol : ConstantClass
    {

        /// <summary>
        /// Constant HTTP for ServerProtocol
        /// </summary>
        public static readonly ServerProtocol HTTP = new ServerProtocol("HTTP");
        /// <summary>
        /// Constant MCP for ServerProtocol
        /// </summary>
        public static readonly ServerProtocol MCP = new ServerProtocol("MCP");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ServerProtocol(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ServerProtocol FindValue(string value)
        {
            return FindValue<ServerProtocol>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ServerProtocol(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TargetStatus.
    /// </summary>
    public class TargetStatus : ConstantClass
    {

        /// <summary>
        /// Constant CREATING for TargetStatus
        /// </summary>
        public static readonly TargetStatus CREATING = new TargetStatus("CREATING");
        /// <summary>
        /// Constant DELETING for TargetStatus
        /// </summary>
        public static readonly TargetStatus DELETING = new TargetStatus("DELETING");
        /// <summary>
        /// Constant FAILED for TargetStatus
        /// </summary>
        public static readonly TargetStatus FAILED = new TargetStatus("FAILED");
        /// <summary>
        /// Constant READY for TargetStatus
        /// </summary>
        public static readonly TargetStatus READY = new TargetStatus("READY");
        /// <summary>
        /// Constant UPDATE_UNSUCCESSFUL for TargetStatus
        /// </summary>
        public static readonly TargetStatus UPDATE_UNSUCCESSFUL = new TargetStatus("UPDATE_UNSUCCESSFUL");
        /// <summary>
        /// Constant UPDATING for TargetStatus
        /// </summary>
        public static readonly TargetStatus UPDATING = new TargetStatus("UPDATING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TargetStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TargetStatus FindValue(string value)
        {
            return FindValue<TargetStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TargetStatus(string value)
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