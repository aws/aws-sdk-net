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
    /// Constants used for properties of type AgentManagedRuntimeType.
    /// </summary>
    public class AgentManagedRuntimeType : ConstantClass
    {

        /// <summary>
        /// Constant PYTHON_3_10 for AgentManagedRuntimeType
        /// </summary>
        public static readonly AgentManagedRuntimeType PYTHON_3_10 = new AgentManagedRuntimeType("PYTHON_3_10");
        /// <summary>
        /// Constant PYTHON_3_11 for AgentManagedRuntimeType
        /// </summary>
        public static readonly AgentManagedRuntimeType PYTHON_3_11 = new AgentManagedRuntimeType("PYTHON_3_11");
        /// <summary>
        /// Constant PYTHON_3_12 for AgentManagedRuntimeType
        /// </summary>
        public static readonly AgentManagedRuntimeType PYTHON_3_12 = new AgentManagedRuntimeType("PYTHON_3_12");
        /// <summary>
        /// Constant PYTHON_3_13 for AgentManagedRuntimeType
        /// </summary>
        public static readonly AgentManagedRuntimeType PYTHON_3_13 = new AgentManagedRuntimeType("PYTHON_3_13");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AgentManagedRuntimeType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AgentManagedRuntimeType FindValue(string value)
        {
            return FindValue<AgentManagedRuntimeType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AgentManagedRuntimeType(string value)
        {
            return FindValue(value);
        }
    }


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
        /// Constant AWS_IAM for AuthorizerType
        /// </summary>
        public static readonly AuthorizerType AWS_IAM = new AuthorizerType("AWS_IAM");
        /// <summary>
        /// Constant CUSTOM_JWT for AuthorizerType
        /// </summary>
        public static readonly AuthorizerType CUSTOM_JWT = new AuthorizerType("CUSTOM_JWT");
        /// <summary>
        /// Constant NONE for AuthorizerType
        /// </summary>
        public static readonly AuthorizerType NONE = new AuthorizerType("NONE");

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
    /// Constants used for properties of type BrowserProfileStatus.
    /// </summary>
    public class BrowserProfileStatus : ConstantClass
    {

        /// <summary>
        /// Constant DELETED for BrowserProfileStatus
        /// </summary>
        public static readonly BrowserProfileStatus DELETED = new BrowserProfileStatus("DELETED");
        /// <summary>
        /// Constant DELETING for BrowserProfileStatus
        /// </summary>
        public static readonly BrowserProfileStatus DELETING = new BrowserProfileStatus("DELETING");
        /// <summary>
        /// Constant READY for BrowserProfileStatus
        /// </summary>
        public static readonly BrowserProfileStatus READY = new BrowserProfileStatus("READY");
        /// <summary>
        /// Constant SAVING for BrowserProfileStatus
        /// </summary>
        public static readonly BrowserProfileStatus SAVING = new BrowserProfileStatus("SAVING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public BrowserProfileStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static BrowserProfileStatus FindValue(string value)
        {
            return FindValue<BrowserProfileStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator BrowserProfileStatus(string value)
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
        /// Constant AtlassianOauth2 for CredentialProviderVendorType
        /// </summary>
        public static readonly CredentialProviderVendorType AtlassianOauth2 = new CredentialProviderVendorType("AtlassianOauth2");
        /// <summary>
        /// Constant Auth0Oauth2 for CredentialProviderVendorType
        /// </summary>
        public static readonly CredentialProviderVendorType Auth0Oauth2 = new CredentialProviderVendorType("Auth0Oauth2");
        /// <summary>
        /// Constant CognitoOauth2 for CredentialProviderVendorType
        /// </summary>
        public static readonly CredentialProviderVendorType CognitoOauth2 = new CredentialProviderVendorType("CognitoOauth2");
        /// <summary>
        /// Constant CustomOauth2 for CredentialProviderVendorType
        /// </summary>
        public static readonly CredentialProviderVendorType CustomOauth2 = new CredentialProviderVendorType("CustomOauth2");
        /// <summary>
        /// Constant CyberArkOauth2 for CredentialProviderVendorType
        /// </summary>
        public static readonly CredentialProviderVendorType CyberArkOauth2 = new CredentialProviderVendorType("CyberArkOauth2");
        /// <summary>
        /// Constant DropboxOauth2 for CredentialProviderVendorType
        /// </summary>
        public static readonly CredentialProviderVendorType DropboxOauth2 = new CredentialProviderVendorType("DropboxOauth2");
        /// <summary>
        /// Constant FacebookOauth2 for CredentialProviderVendorType
        /// </summary>
        public static readonly CredentialProviderVendorType FacebookOauth2 = new CredentialProviderVendorType("FacebookOauth2");
        /// <summary>
        /// Constant FusionAuthOauth2 for CredentialProviderVendorType
        /// </summary>
        public static readonly CredentialProviderVendorType FusionAuthOauth2 = new CredentialProviderVendorType("FusionAuthOauth2");
        /// <summary>
        /// Constant GithubOauth2 for CredentialProviderVendorType
        /// </summary>
        public static readonly CredentialProviderVendorType GithubOauth2 = new CredentialProviderVendorType("GithubOauth2");
        /// <summary>
        /// Constant GoogleOauth2 for CredentialProviderVendorType
        /// </summary>
        public static readonly CredentialProviderVendorType GoogleOauth2 = new CredentialProviderVendorType("GoogleOauth2");
        /// <summary>
        /// Constant HubspotOauth2 for CredentialProviderVendorType
        /// </summary>
        public static readonly CredentialProviderVendorType HubspotOauth2 = new CredentialProviderVendorType("HubspotOauth2");
        /// <summary>
        /// Constant LinkedinOauth2 for CredentialProviderVendorType
        /// </summary>
        public static readonly CredentialProviderVendorType LinkedinOauth2 = new CredentialProviderVendorType("LinkedinOauth2");
        /// <summary>
        /// Constant MicrosoftOauth2 for CredentialProviderVendorType
        /// </summary>
        public static readonly CredentialProviderVendorType MicrosoftOauth2 = new CredentialProviderVendorType("MicrosoftOauth2");
        /// <summary>
        /// Constant NotionOauth2 for CredentialProviderVendorType
        /// </summary>
        public static readonly CredentialProviderVendorType NotionOauth2 = new CredentialProviderVendorType("NotionOauth2");
        /// <summary>
        /// Constant OktaOauth2 for CredentialProviderVendorType
        /// </summary>
        public static readonly CredentialProviderVendorType OktaOauth2 = new CredentialProviderVendorType("OktaOauth2");
        /// <summary>
        /// Constant OneLoginOauth2 for CredentialProviderVendorType
        /// </summary>
        public static readonly CredentialProviderVendorType OneLoginOauth2 = new CredentialProviderVendorType("OneLoginOauth2");
        /// <summary>
        /// Constant PingOneOauth2 for CredentialProviderVendorType
        /// </summary>
        public static readonly CredentialProviderVendorType PingOneOauth2 = new CredentialProviderVendorType("PingOneOauth2");
        /// <summary>
        /// Constant RedditOauth2 for CredentialProviderVendorType
        /// </summary>
        public static readonly CredentialProviderVendorType RedditOauth2 = new CredentialProviderVendorType("RedditOauth2");
        /// <summary>
        /// Constant SalesforceOauth2 for CredentialProviderVendorType
        /// </summary>
        public static readonly CredentialProviderVendorType SalesforceOauth2 = new CredentialProviderVendorType("SalesforceOauth2");
        /// <summary>
        /// Constant SlackOauth2 for CredentialProviderVendorType
        /// </summary>
        public static readonly CredentialProviderVendorType SlackOauth2 = new CredentialProviderVendorType("SlackOauth2");
        /// <summary>
        /// Constant SpotifyOauth2 for CredentialProviderVendorType
        /// </summary>
        public static readonly CredentialProviderVendorType SpotifyOauth2 = new CredentialProviderVendorType("SpotifyOauth2");
        /// <summary>
        /// Constant TwitchOauth2 for CredentialProviderVendorType
        /// </summary>
        public static readonly CredentialProviderVendorType TwitchOauth2 = new CredentialProviderVendorType("TwitchOauth2");
        /// <summary>
        /// Constant XOauth2 for CredentialProviderVendorType
        /// </summary>
        public static readonly CredentialProviderVendorType XOauth2 = new CredentialProviderVendorType("XOauth2");
        /// <summary>
        /// Constant YandexOauth2 for CredentialProviderVendorType
        /// </summary>
        public static readonly CredentialProviderVendorType YandexOauth2 = new CredentialProviderVendorType("YandexOauth2");
        /// <summary>
        /// Constant ZoomOauth2 for CredentialProviderVendorType
        /// </summary>
        public static readonly CredentialProviderVendorType ZoomOauth2 = new CredentialProviderVendorType("ZoomOauth2");

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
    /// Constants used for properties of type EvaluatorLevel.
    /// </summary>
    public class EvaluatorLevel : ConstantClass
    {

        /// <summary>
        /// Constant SESSION for EvaluatorLevel
        /// </summary>
        public static readonly EvaluatorLevel SESSION = new EvaluatorLevel("SESSION");
        /// <summary>
        /// Constant TOOL_CALL for EvaluatorLevel
        /// </summary>
        public static readonly EvaluatorLevel TOOL_CALL = new EvaluatorLevel("TOOL_CALL");
        /// <summary>
        /// Constant TRACE for EvaluatorLevel
        /// </summary>
        public static readonly EvaluatorLevel TRACE = new EvaluatorLevel("TRACE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EvaluatorLevel(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EvaluatorLevel FindValue(string value)
        {
            return FindValue<EvaluatorLevel>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EvaluatorLevel(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type EvaluatorStatus.
    /// </summary>
    public class EvaluatorStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for EvaluatorStatus
        /// </summary>
        public static readonly EvaluatorStatus ACTIVE = new EvaluatorStatus("ACTIVE");
        /// <summary>
        /// Constant CREATE_FAILED for EvaluatorStatus
        /// </summary>
        public static readonly EvaluatorStatus CREATE_FAILED = new EvaluatorStatus("CREATE_FAILED");
        /// <summary>
        /// Constant CREATING for EvaluatorStatus
        /// </summary>
        public static readonly EvaluatorStatus CREATING = new EvaluatorStatus("CREATING");
        /// <summary>
        /// Constant DELETING for EvaluatorStatus
        /// </summary>
        public static readonly EvaluatorStatus DELETING = new EvaluatorStatus("DELETING");
        /// <summary>
        /// Constant UPDATE_FAILED for EvaluatorStatus
        /// </summary>
        public static readonly EvaluatorStatus UPDATE_FAILED = new EvaluatorStatus("UPDATE_FAILED");
        /// <summary>
        /// Constant UPDATING for EvaluatorStatus
        /// </summary>
        public static readonly EvaluatorStatus UPDATING = new EvaluatorStatus("UPDATING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EvaluatorStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EvaluatorStatus FindValue(string value)
        {
            return FindValue<EvaluatorStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EvaluatorStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type EvaluatorType.
    /// </summary>
    public class EvaluatorType : ConstantClass
    {

        /// <summary>
        /// Constant Builtin for EvaluatorType
        /// </summary>
        public static readonly EvaluatorType Builtin = new EvaluatorType("Builtin");
        /// <summary>
        /// Constant Custom for EvaluatorType
        /// </summary>
        public static readonly EvaluatorType Custom = new EvaluatorType("Custom");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EvaluatorType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EvaluatorType FindValue(string value)
        {
            return FindValue<EvaluatorType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EvaluatorType(string value)
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
    /// Constants used for properties of type FilterOperator.
    /// </summary>
    public class FilterOperator : ConstantClass
    {

        /// <summary>
        /// Constant Contains for FilterOperator
        /// </summary>
        public static readonly FilterOperator Contains = new FilterOperator("Contains");
        /// <summary>
        /// Constant Equals for FilterOperator
        /// </summary>
        public new static readonly FilterOperator Equals = new FilterOperator("Equals");
        /// <summary>
        /// Constant GreaterThan for FilterOperator
        /// </summary>
        public static readonly FilterOperator GreaterThan = new FilterOperator("GreaterThan");
        /// <summary>
        /// Constant GreaterThanOrEqual for FilterOperator
        /// </summary>
        public static readonly FilterOperator GreaterThanOrEqual = new FilterOperator("GreaterThanOrEqual");
        /// <summary>
        /// Constant LessThan for FilterOperator
        /// </summary>
        public static readonly FilterOperator LessThan = new FilterOperator("LessThan");
        /// <summary>
        /// Constant LessThanOrEqual for FilterOperator
        /// </summary>
        public static readonly FilterOperator LessThanOrEqual = new FilterOperator("LessThanOrEqual");
        /// <summary>
        /// Constant NotContains for FilterOperator
        /// </summary>
        public static readonly FilterOperator NotContains = new FilterOperator("NotContains");
        /// <summary>
        /// Constant NotEquals for FilterOperator
        /// </summary>
        public static readonly FilterOperator NotEquals = new FilterOperator("NotEquals");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FilterOperator(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FilterOperator FindValue(string value)
        {
            return FindValue<FilterOperator>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FilterOperator(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type FindingType.
    /// </summary>
    public class FindingType : ConstantClass
    {

        /// <summary>
        /// Constant ALLOW_ALL for FindingType
        /// </summary>
        public static readonly FindingType ALLOW_ALL = new FindingType("ALLOW_ALL");
        /// <summary>
        /// Constant ALLOW_NONE for FindingType
        /// </summary>
        public static readonly FindingType ALLOW_NONE = new FindingType("ALLOW_NONE");
        /// <summary>
        /// Constant DENY_ALL for FindingType
        /// </summary>
        public static readonly FindingType DENY_ALL = new FindingType("DENY_ALL");
        /// <summary>
        /// Constant DENY_NONE for FindingType
        /// </summary>
        public static readonly FindingType DENY_NONE = new FindingType("DENY_NONE");
        /// <summary>
        /// Constant INVALID for FindingType
        /// </summary>
        public static readonly FindingType INVALID = new FindingType("INVALID");
        /// <summary>
        /// Constant NOT_TRANSLATABLE for FindingType
        /// </summary>
        public static readonly FindingType NOT_TRANSLATABLE = new FindingType("NOT_TRANSLATABLE");
        /// <summary>
        /// Constant VALID for FindingType
        /// </summary>
        public static readonly FindingType VALID = new FindingType("VALID");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FindingType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FindingType FindValue(string value)
        {
            return FindValue<FindingType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FindingType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type GatewayInterceptionPoint.
    /// </summary>
    public class GatewayInterceptionPoint : ConstantClass
    {

        /// <summary>
        /// Constant REQUEST for GatewayInterceptionPoint
        /// </summary>
        public static readonly GatewayInterceptionPoint REQUEST = new GatewayInterceptionPoint("REQUEST");
        /// <summary>
        /// Constant RESPONSE for GatewayInterceptionPoint
        /// </summary>
        public static readonly GatewayInterceptionPoint RESPONSE = new GatewayInterceptionPoint("RESPONSE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public GatewayInterceptionPoint(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static GatewayInterceptionPoint FindValue(string value)
        {
            return FindValue<GatewayInterceptionPoint>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator GatewayInterceptionPoint(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type GatewayPolicyEngineMode.
    /// </summary>
    public class GatewayPolicyEngineMode : ConstantClass
    {

        /// <summary>
        /// Constant ENFORCE for GatewayPolicyEngineMode
        /// </summary>
        public static readonly GatewayPolicyEngineMode ENFORCE = new GatewayPolicyEngineMode("ENFORCE");
        /// <summary>
        /// Constant LOG_ONLY for GatewayPolicyEngineMode
        /// </summary>
        public static readonly GatewayPolicyEngineMode LOG_ONLY = new GatewayPolicyEngineMode("LOG_ONLY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public GatewayPolicyEngineMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static GatewayPolicyEngineMode FindValue(string value)
        {
            return FindValue<GatewayPolicyEngineMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator GatewayPolicyEngineMode(string value)
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
        /// Constant EPISODIC for MemoryStrategyType
        /// </summary>
        public static readonly MemoryStrategyType EPISODIC = new MemoryStrategyType("EPISODIC");
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
    /// Constants used for properties of type MemoryView.
    /// </summary>
    public class MemoryView : ConstantClass
    {

        /// <summary>
        /// Constant Full for MemoryView
        /// </summary>
        public static readonly MemoryView Full = new MemoryView("full");
        /// <summary>
        /// Constant Without_decryption for MemoryView
        /// </summary>
        public static readonly MemoryView Without_decryption = new MemoryView("without_decryption");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MemoryView(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MemoryView FindValue(string value)
        {
            return FindValue<MemoryView>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MemoryView(string value)
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
    /// Constants used for properties of type OAuthGrantType.
    /// </summary>
    public class OAuthGrantType : ConstantClass
    {

        /// <summary>
        /// Constant AUTHORIZATION_CODE for OAuthGrantType
        /// </summary>
        public static readonly OAuthGrantType AUTHORIZATION_CODE = new OAuthGrantType("AUTHORIZATION_CODE");
        /// <summary>
        /// Constant CLIENT_CREDENTIALS for OAuthGrantType
        /// </summary>
        public static readonly OAuthGrantType CLIENT_CREDENTIALS = new OAuthGrantType("CLIENT_CREDENTIALS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public OAuthGrantType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static OAuthGrantType FindValue(string value)
        {
            return FindValue<OAuthGrantType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator OAuthGrantType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type OnlineEvaluationConfigStatus.
    /// </summary>
    public class OnlineEvaluationConfigStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for OnlineEvaluationConfigStatus
        /// </summary>
        public static readonly OnlineEvaluationConfigStatus ACTIVE = new OnlineEvaluationConfigStatus("ACTIVE");
        /// <summary>
        /// Constant CREATE_FAILED for OnlineEvaluationConfigStatus
        /// </summary>
        public static readonly OnlineEvaluationConfigStatus CREATE_FAILED = new OnlineEvaluationConfigStatus("CREATE_FAILED");
        /// <summary>
        /// Constant CREATING for OnlineEvaluationConfigStatus
        /// </summary>
        public static readonly OnlineEvaluationConfigStatus CREATING = new OnlineEvaluationConfigStatus("CREATING");
        /// <summary>
        /// Constant DELETING for OnlineEvaluationConfigStatus
        /// </summary>
        public static readonly OnlineEvaluationConfigStatus DELETING = new OnlineEvaluationConfigStatus("DELETING");
        /// <summary>
        /// Constant UPDATE_FAILED for OnlineEvaluationConfigStatus
        /// </summary>
        public static readonly OnlineEvaluationConfigStatus UPDATE_FAILED = new OnlineEvaluationConfigStatus("UPDATE_FAILED");
        /// <summary>
        /// Constant UPDATING for OnlineEvaluationConfigStatus
        /// </summary>
        public static readonly OnlineEvaluationConfigStatus UPDATING = new OnlineEvaluationConfigStatus("UPDATING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public OnlineEvaluationConfigStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static OnlineEvaluationConfigStatus FindValue(string value)
        {
            return FindValue<OnlineEvaluationConfigStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator OnlineEvaluationConfigStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type OnlineEvaluationExecutionStatus.
    /// </summary>
    public class OnlineEvaluationExecutionStatus : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for OnlineEvaluationExecutionStatus
        /// </summary>
        public static readonly OnlineEvaluationExecutionStatus DISABLED = new OnlineEvaluationExecutionStatus("DISABLED");
        /// <summary>
        /// Constant ENABLED for OnlineEvaluationExecutionStatus
        /// </summary>
        public static readonly OnlineEvaluationExecutionStatus ENABLED = new OnlineEvaluationExecutionStatus("ENABLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public OnlineEvaluationExecutionStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static OnlineEvaluationExecutionStatus FindValue(string value)
        {
            return FindValue<OnlineEvaluationExecutionStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator OnlineEvaluationExecutionStatus(string value)
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
        /// Constant EPISODIC_OVERRIDE for OverrideType
        /// </summary>
        public static readonly OverrideType EPISODIC_OVERRIDE = new OverrideType("EPISODIC_OVERRIDE");
        /// <summary>
        /// Constant SELF_MANAGED for OverrideType
        /// </summary>
        public static readonly OverrideType SELF_MANAGED = new OverrideType("SELF_MANAGED");
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
    /// Constants used for properties of type PolicyEngineStatus.
    /// </summary>
    public class PolicyEngineStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for PolicyEngineStatus
        /// </summary>
        public static readonly PolicyEngineStatus ACTIVE = new PolicyEngineStatus("ACTIVE");
        /// <summary>
        /// Constant CREATE_FAILED for PolicyEngineStatus
        /// </summary>
        public static readonly PolicyEngineStatus CREATE_FAILED = new PolicyEngineStatus("CREATE_FAILED");
        /// <summary>
        /// Constant CREATING for PolicyEngineStatus
        /// </summary>
        public static readonly PolicyEngineStatus CREATING = new PolicyEngineStatus("CREATING");
        /// <summary>
        /// Constant DELETE_FAILED for PolicyEngineStatus
        /// </summary>
        public static readonly PolicyEngineStatus DELETE_FAILED = new PolicyEngineStatus("DELETE_FAILED");
        /// <summary>
        /// Constant DELETING for PolicyEngineStatus
        /// </summary>
        public static readonly PolicyEngineStatus DELETING = new PolicyEngineStatus("DELETING");
        /// <summary>
        /// Constant UPDATE_FAILED for PolicyEngineStatus
        /// </summary>
        public static readonly PolicyEngineStatus UPDATE_FAILED = new PolicyEngineStatus("UPDATE_FAILED");
        /// <summary>
        /// Constant UPDATING for PolicyEngineStatus
        /// </summary>
        public static readonly PolicyEngineStatus UPDATING = new PolicyEngineStatus("UPDATING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PolicyEngineStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PolicyEngineStatus FindValue(string value)
        {
            return FindValue<PolicyEngineStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PolicyEngineStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PolicyGenerationStatus.
    /// </summary>
    public class PolicyGenerationStatus : ConstantClass
    {

        /// <summary>
        /// Constant DELETE_FAILED for PolicyGenerationStatus
        /// </summary>
        public static readonly PolicyGenerationStatus DELETE_FAILED = new PolicyGenerationStatus("DELETE_FAILED");
        /// <summary>
        /// Constant GENERATE_FAILED for PolicyGenerationStatus
        /// </summary>
        public static readonly PolicyGenerationStatus GENERATE_FAILED = new PolicyGenerationStatus("GENERATE_FAILED");
        /// <summary>
        /// Constant GENERATED for PolicyGenerationStatus
        /// </summary>
        public static readonly PolicyGenerationStatus GENERATED = new PolicyGenerationStatus("GENERATED");
        /// <summary>
        /// Constant GENERATING for PolicyGenerationStatus
        /// </summary>
        public static readonly PolicyGenerationStatus GENERATING = new PolicyGenerationStatus("GENERATING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PolicyGenerationStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PolicyGenerationStatus FindValue(string value)
        {
            return FindValue<PolicyGenerationStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PolicyGenerationStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PolicyStatus.
    /// </summary>
    public class PolicyStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for PolicyStatus
        /// </summary>
        public static readonly PolicyStatus ACTIVE = new PolicyStatus("ACTIVE");
        /// <summary>
        /// Constant CREATE_FAILED for PolicyStatus
        /// </summary>
        public static readonly PolicyStatus CREATE_FAILED = new PolicyStatus("CREATE_FAILED");
        /// <summary>
        /// Constant CREATING for PolicyStatus
        /// </summary>
        public static readonly PolicyStatus CREATING = new PolicyStatus("CREATING");
        /// <summary>
        /// Constant DELETE_FAILED for PolicyStatus
        /// </summary>
        public static readonly PolicyStatus DELETE_FAILED = new PolicyStatus("DELETE_FAILED");
        /// <summary>
        /// Constant DELETING for PolicyStatus
        /// </summary>
        public static readonly PolicyStatus DELETING = new PolicyStatus("DELETING");
        /// <summary>
        /// Constant UPDATE_FAILED for PolicyStatus
        /// </summary>
        public static readonly PolicyStatus UPDATE_FAILED = new PolicyStatus("UPDATE_FAILED");
        /// <summary>
        /// Constant UPDATING for PolicyStatus
        /// </summary>
        public static readonly PolicyStatus UPDATING = new PolicyStatus("UPDATING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PolicyStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PolicyStatus FindValue(string value)
        {
            return FindValue<PolicyStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PolicyStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PolicyValidationMode.
    /// </summary>
    public class PolicyValidationMode : ConstantClass
    {

        /// <summary>
        /// Constant FAIL_ON_ANY_FINDINGS for PolicyValidationMode
        /// </summary>
        public static readonly PolicyValidationMode FAIL_ON_ANY_FINDINGS = new PolicyValidationMode("FAIL_ON_ANY_FINDINGS");
        /// <summary>
        /// Constant IGNORE_ALL_FINDINGS for PolicyValidationMode
        /// </summary>
        public static readonly PolicyValidationMode IGNORE_ALL_FINDINGS = new PolicyValidationMode("IGNORE_ALL_FINDINGS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PolicyValidationMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PolicyValidationMode FindValue(string value)
        {
            return FindValue<PolicyValidationMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PolicyValidationMode(string value)
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
    /// Constants used for properties of type RestApiMethod.
    /// </summary>
    public class RestApiMethod : ConstantClass
    {

        /// <summary>
        /// Constant DELETE for RestApiMethod
        /// </summary>
        public static readonly RestApiMethod DELETE = new RestApiMethod("DELETE");
        /// <summary>
        /// Constant GET for RestApiMethod
        /// </summary>
        public static readonly RestApiMethod GET = new RestApiMethod("GET");
        /// <summary>
        /// Constant HEAD for RestApiMethod
        /// </summary>
        public static readonly RestApiMethod HEAD = new RestApiMethod("HEAD");
        /// <summary>
        /// Constant OPTIONS for RestApiMethod
        /// </summary>
        public static readonly RestApiMethod OPTIONS = new RestApiMethod("OPTIONS");
        /// <summary>
        /// Constant PATCH for RestApiMethod
        /// </summary>
        public static readonly RestApiMethod PATCH = new RestApiMethod("PATCH");
        /// <summary>
        /// Constant POST for RestApiMethod
        /// </summary>
        public static readonly RestApiMethod POST = new RestApiMethod("POST");
        /// <summary>
        /// Constant PUT for RestApiMethod
        /// </summary>
        public static readonly RestApiMethod PUT = new RestApiMethod("PUT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RestApiMethod(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RestApiMethod FindValue(string value)
        {
            return FindValue<RestApiMethod>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RestApiMethod(string value)
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
        /// Constant A2A for ServerProtocol
        /// </summary>
        public static readonly ServerProtocol A2A = new ServerProtocol("A2A");
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
        /// Constant SYNCHRONIZE_UNSUCCESSFUL for TargetStatus
        /// </summary>
        public static readonly TargetStatus SYNCHRONIZE_UNSUCCESSFUL = new TargetStatus("SYNCHRONIZE_UNSUCCESSFUL");
        /// <summary>
        /// Constant SYNCHRONIZING for TargetStatus
        /// </summary>
        public static readonly TargetStatus SYNCHRONIZING = new TargetStatus("SYNCHRONIZING");
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