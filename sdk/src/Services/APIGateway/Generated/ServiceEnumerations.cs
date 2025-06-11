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
 * Do not modify this file. This file is generated from the apigateway-2015-07-09.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.APIGateway
{

    /// <summary>
    /// Constants used for properties of type AccessAssociationSourceType.
    /// </summary>
    public class AccessAssociationSourceType : ConstantClass
    {

        /// <summary>
        /// Constant VPCE for AccessAssociationSourceType
        /// </summary>
        public static readonly AccessAssociationSourceType VPCE = new AccessAssociationSourceType("VPCE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AccessAssociationSourceType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AccessAssociationSourceType FindValue(string value)
        {
            return FindValue<AccessAssociationSourceType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AccessAssociationSourceType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ApiKeysFormat.
    /// </summary>
    public class ApiKeysFormat : ConstantClass
    {

        /// <summary>
        /// Constant Csv for ApiKeysFormat
        /// </summary>
        public static readonly ApiKeysFormat Csv = new ApiKeysFormat("csv");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ApiKeysFormat(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ApiKeysFormat FindValue(string value)
        {
            return FindValue<ApiKeysFormat>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ApiKeysFormat(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ApiKeySourceType.
    /// </summary>
    public class ApiKeySourceType : ConstantClass
    {

        /// <summary>
        /// Constant AUTHORIZER for ApiKeySourceType
        /// </summary>
        public static readonly ApiKeySourceType AUTHORIZER = new ApiKeySourceType("AUTHORIZER");
        /// <summary>
        /// Constant HEADER for ApiKeySourceType
        /// </summary>
        public static readonly ApiKeySourceType HEADER = new ApiKeySourceType("HEADER");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ApiKeySourceType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ApiKeySourceType FindValue(string value)
        {
            return FindValue<ApiKeySourceType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ApiKeySourceType(string value)
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
        /// Constant COGNITO_USER_POOLS for AuthorizerType
        /// </summary>
        public static readonly AuthorizerType COGNITO_USER_POOLS = new AuthorizerType("COGNITO_USER_POOLS");
        /// <summary>
        /// Constant REQUEST for AuthorizerType
        /// </summary>
        public static readonly AuthorizerType REQUEST = new AuthorizerType("REQUEST");
        /// <summary>
        /// Constant TOKEN for AuthorizerType
        /// </summary>
        public static readonly AuthorizerType TOKEN = new AuthorizerType("TOKEN");

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
    /// Constants used for properties of type CacheClusterSize.
    /// </summary>
    public class CacheClusterSize : ConstantClass
    {

        /// <summary>
        /// Constant GB_0_5 for CacheClusterSize
        /// </summary>
        public static readonly CacheClusterSize GB_0_5 = new CacheClusterSize("0.5");
        /// <summary>
        /// Constant GB_1_6 for CacheClusterSize
        /// </summary>
        public static readonly CacheClusterSize GB_1_6 = new CacheClusterSize("1.6");
        /// <summary>
        /// Constant GB_118 for CacheClusterSize
        /// </summary>
        public static readonly CacheClusterSize GB_118 = new CacheClusterSize("118");
        /// <summary>
        /// Constant GB_13_5 for CacheClusterSize
        /// </summary>
        public static readonly CacheClusterSize GB_13_5 = new CacheClusterSize("13.5");
        /// <summary>
        /// Constant GB_237 for CacheClusterSize
        /// </summary>
        public static readonly CacheClusterSize GB_237 = new CacheClusterSize("237");
        /// <summary>
        /// Constant GB_28_4 for CacheClusterSize
        /// </summary>
        public static readonly CacheClusterSize GB_28_4 = new CacheClusterSize("28.4");
        /// <summary>
        /// Constant GB_58_2 for CacheClusterSize
        /// </summary>
        public static readonly CacheClusterSize GB_58_2 = new CacheClusterSize("58.2");
        /// <summary>
        /// Constant GB_6_1 for CacheClusterSize
        /// </summary>
        public static readonly CacheClusterSize GB_6_1 = new CacheClusterSize("6.1");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CacheClusterSize(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CacheClusterSize FindValue(string value)
        {
            return FindValue<CacheClusterSize>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CacheClusterSize(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CacheClusterStatus.
    /// </summary>
    public class CacheClusterStatus : ConstantClass
    {

        /// <summary>
        /// Constant AVAILABLE for CacheClusterStatus
        /// </summary>
        public static readonly CacheClusterStatus AVAILABLE = new CacheClusterStatus("AVAILABLE");
        /// <summary>
        /// Constant CREATE_IN_PROGRESS for CacheClusterStatus
        /// </summary>
        public static readonly CacheClusterStatus CREATE_IN_PROGRESS = new CacheClusterStatus("CREATE_IN_PROGRESS");
        /// <summary>
        /// Constant DELETE_IN_PROGRESS for CacheClusterStatus
        /// </summary>
        public static readonly CacheClusterStatus DELETE_IN_PROGRESS = new CacheClusterStatus("DELETE_IN_PROGRESS");
        /// <summary>
        /// Constant FLUSH_IN_PROGRESS for CacheClusterStatus
        /// </summary>
        public static readonly CacheClusterStatus FLUSH_IN_PROGRESS = new CacheClusterStatus("FLUSH_IN_PROGRESS");
        /// <summary>
        /// Constant NOT_AVAILABLE for CacheClusterStatus
        /// </summary>
        public static readonly CacheClusterStatus NOT_AVAILABLE = new CacheClusterStatus("NOT_AVAILABLE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CacheClusterStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CacheClusterStatus FindValue(string value)
        {
            return FindValue<CacheClusterStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CacheClusterStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ConnectionType.
    /// </summary>
    public class ConnectionType : ConstantClass
    {

        /// <summary>
        /// Constant INTERNET for ConnectionType
        /// </summary>
        public static readonly ConnectionType INTERNET = new ConnectionType("INTERNET");
        /// <summary>
        /// Constant VPC_LINK for ConnectionType
        /// </summary>
        public static readonly ConnectionType VPC_LINK = new ConnectionType("VPC_LINK");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ConnectionType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ConnectionType FindValue(string value)
        {
            return FindValue<ConnectionType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ConnectionType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ContentHandlingStrategy.
    /// </summary>
    public class ContentHandlingStrategy : ConstantClass
    {

        /// <summary>
        /// Constant CONVERT_TO_BINARY for ContentHandlingStrategy
        /// </summary>
        public static readonly ContentHandlingStrategy CONVERT_TO_BINARY = new ContentHandlingStrategy("CONVERT_TO_BINARY");
        /// <summary>
        /// Constant CONVERT_TO_TEXT for ContentHandlingStrategy
        /// </summary>
        public static readonly ContentHandlingStrategy CONVERT_TO_TEXT = new ContentHandlingStrategy("CONVERT_TO_TEXT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ContentHandlingStrategy(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ContentHandlingStrategy FindValue(string value)
        {
            return FindValue<ContentHandlingStrategy>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ContentHandlingStrategy(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DocumentationPartType.
    /// </summary>
    public class DocumentationPartType : ConstantClass
    {

        /// <summary>
        /// Constant API for DocumentationPartType
        /// </summary>
        public static readonly DocumentationPartType API = new DocumentationPartType("API");
        /// <summary>
        /// Constant AUTHORIZER for DocumentationPartType
        /// </summary>
        public static readonly DocumentationPartType AUTHORIZER = new DocumentationPartType("AUTHORIZER");
        /// <summary>
        /// Constant METHOD for DocumentationPartType
        /// </summary>
        public static readonly DocumentationPartType METHOD = new DocumentationPartType("METHOD");
        /// <summary>
        /// Constant MODEL for DocumentationPartType
        /// </summary>
        public static readonly DocumentationPartType MODEL = new DocumentationPartType("MODEL");
        /// <summary>
        /// Constant PATH_PARAMETER for DocumentationPartType
        /// </summary>
        public static readonly DocumentationPartType PATH_PARAMETER = new DocumentationPartType("PATH_PARAMETER");
        /// <summary>
        /// Constant QUERY_PARAMETER for DocumentationPartType
        /// </summary>
        public static readonly DocumentationPartType QUERY_PARAMETER = new DocumentationPartType("QUERY_PARAMETER");
        /// <summary>
        /// Constant REQUEST_BODY for DocumentationPartType
        /// </summary>
        public static readonly DocumentationPartType REQUEST_BODY = new DocumentationPartType("REQUEST_BODY");
        /// <summary>
        /// Constant REQUEST_HEADER for DocumentationPartType
        /// </summary>
        public static readonly DocumentationPartType REQUEST_HEADER = new DocumentationPartType("REQUEST_HEADER");
        /// <summary>
        /// Constant RESOURCE for DocumentationPartType
        /// </summary>
        public static readonly DocumentationPartType RESOURCE = new DocumentationPartType("RESOURCE");
        /// <summary>
        /// Constant RESPONSE for DocumentationPartType
        /// </summary>
        public static readonly DocumentationPartType RESPONSE = new DocumentationPartType("RESPONSE");
        /// <summary>
        /// Constant RESPONSE_BODY for DocumentationPartType
        /// </summary>
        public static readonly DocumentationPartType RESPONSE_BODY = new DocumentationPartType("RESPONSE_BODY");
        /// <summary>
        /// Constant RESPONSE_HEADER for DocumentationPartType
        /// </summary>
        public static readonly DocumentationPartType RESPONSE_HEADER = new DocumentationPartType("RESPONSE_HEADER");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DocumentationPartType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DocumentationPartType FindValue(string value)
        {
            return FindValue<DocumentationPartType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DocumentationPartType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DomainNameStatus.
    /// </summary>
    public class DomainNameStatus : ConstantClass
    {

        /// <summary>
        /// Constant AVAILABLE for DomainNameStatus
        /// </summary>
        public static readonly DomainNameStatus AVAILABLE = new DomainNameStatus("AVAILABLE");
        /// <summary>
        /// Constant PENDING for DomainNameStatus
        /// </summary>
        public static readonly DomainNameStatus PENDING = new DomainNameStatus("PENDING");
        /// <summary>
        /// Constant PENDING_CERTIFICATE_REIMPORT for DomainNameStatus
        /// </summary>
        public static readonly DomainNameStatus PENDING_CERTIFICATE_REIMPORT = new DomainNameStatus("PENDING_CERTIFICATE_REIMPORT");
        /// <summary>
        /// Constant PENDING_OWNERSHIP_VERIFICATION for DomainNameStatus
        /// </summary>
        public static readonly DomainNameStatus PENDING_OWNERSHIP_VERIFICATION = new DomainNameStatus("PENDING_OWNERSHIP_VERIFICATION");
        /// <summary>
        /// Constant UPDATING for DomainNameStatus
        /// </summary>
        public static readonly DomainNameStatus UPDATING = new DomainNameStatus("UPDATING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DomainNameStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DomainNameStatus FindValue(string value)
        {
            return FindValue<DomainNameStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DomainNameStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type EndpointType.
    /// </summary>
    public class EndpointType : ConstantClass
    {

        /// <summary>
        /// Constant EDGE for EndpointType
        /// </summary>
        public static readonly EndpointType EDGE = new EndpointType("EDGE");
        /// <summary>
        /// Constant PRIVATE for EndpointType
        /// </summary>
        public static readonly EndpointType PRIVATE = new EndpointType("PRIVATE");
        /// <summary>
        /// Constant REGIONAL for EndpointType
        /// </summary>
        public static readonly EndpointType REGIONAL = new EndpointType("REGIONAL");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EndpointType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EndpointType FindValue(string value)
        {
            return FindValue<EndpointType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EndpointType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type GatewayResponseType.
    /// </summary>
    public class GatewayResponseType : ConstantClass
    {

        /// <summary>
        /// Constant ACCESS_DENIED for GatewayResponseType
        /// </summary>
        public static readonly GatewayResponseType ACCESS_DENIED = new GatewayResponseType("ACCESS_DENIED");
        /// <summary>
        /// Constant API_CONFIGURATION_ERROR for GatewayResponseType
        /// </summary>
        public static readonly GatewayResponseType API_CONFIGURATION_ERROR = new GatewayResponseType("API_CONFIGURATION_ERROR");
        /// <summary>
        /// Constant AUTHORIZER_CONFIGURATION_ERROR for GatewayResponseType
        /// </summary>
        public static readonly GatewayResponseType AUTHORIZER_CONFIGURATION_ERROR = new GatewayResponseType("AUTHORIZER_CONFIGURATION_ERROR");
        /// <summary>
        /// Constant AUTHORIZER_FAILURE for GatewayResponseType
        /// </summary>
        public static readonly GatewayResponseType AUTHORIZER_FAILURE = new GatewayResponseType("AUTHORIZER_FAILURE");
        /// <summary>
        /// Constant BAD_REQUEST_BODY for GatewayResponseType
        /// </summary>
        public static readonly GatewayResponseType BAD_REQUEST_BODY = new GatewayResponseType("BAD_REQUEST_BODY");
        /// <summary>
        /// Constant BAD_REQUEST_PARAMETERS for GatewayResponseType
        /// </summary>
        public static readonly GatewayResponseType BAD_REQUEST_PARAMETERS = new GatewayResponseType("BAD_REQUEST_PARAMETERS");
        /// <summary>
        /// Constant DEFAULT_4XX for GatewayResponseType
        /// </summary>
        public static readonly GatewayResponseType DEFAULT_4XX = new GatewayResponseType("DEFAULT_4XX");
        /// <summary>
        /// Constant DEFAULT_5XX for GatewayResponseType
        /// </summary>
        public static readonly GatewayResponseType DEFAULT_5XX = new GatewayResponseType("DEFAULT_5XX");
        /// <summary>
        /// Constant EXPIRED_TOKEN for GatewayResponseType
        /// </summary>
        public static readonly GatewayResponseType EXPIRED_TOKEN = new GatewayResponseType("EXPIRED_TOKEN");
        /// <summary>
        /// Constant INTEGRATION_FAILURE for GatewayResponseType
        /// </summary>
        public static readonly GatewayResponseType INTEGRATION_FAILURE = new GatewayResponseType("INTEGRATION_FAILURE");
        /// <summary>
        /// Constant INTEGRATION_TIMEOUT for GatewayResponseType
        /// </summary>
        public static readonly GatewayResponseType INTEGRATION_TIMEOUT = new GatewayResponseType("INTEGRATION_TIMEOUT");
        /// <summary>
        /// Constant INVALID_API_KEY for GatewayResponseType
        /// </summary>
        public static readonly GatewayResponseType INVALID_API_KEY = new GatewayResponseType("INVALID_API_KEY");
        /// <summary>
        /// Constant INVALID_SIGNATURE for GatewayResponseType
        /// </summary>
        public static readonly GatewayResponseType INVALID_SIGNATURE = new GatewayResponseType("INVALID_SIGNATURE");
        /// <summary>
        /// Constant MISSING_AUTHENTICATION_TOKEN for GatewayResponseType
        /// </summary>
        public static readonly GatewayResponseType MISSING_AUTHENTICATION_TOKEN = new GatewayResponseType("MISSING_AUTHENTICATION_TOKEN");
        /// <summary>
        /// Constant QUOTA_EXCEEDED for GatewayResponseType
        /// </summary>
        public static readonly GatewayResponseType QUOTA_EXCEEDED = new GatewayResponseType("QUOTA_EXCEEDED");
        /// <summary>
        /// Constant REQUEST_TOO_LARGE for GatewayResponseType
        /// </summary>
        public static readonly GatewayResponseType REQUEST_TOO_LARGE = new GatewayResponseType("REQUEST_TOO_LARGE");
        /// <summary>
        /// Constant RESOURCE_NOT_FOUND for GatewayResponseType
        /// </summary>
        public static readonly GatewayResponseType RESOURCE_NOT_FOUND = new GatewayResponseType("RESOURCE_NOT_FOUND");
        /// <summary>
        /// Constant THROTTLED for GatewayResponseType
        /// </summary>
        public static readonly GatewayResponseType THROTTLED = new GatewayResponseType("THROTTLED");
        /// <summary>
        /// Constant UNAUTHORIZED for GatewayResponseType
        /// </summary>
        public static readonly GatewayResponseType UNAUTHORIZED = new GatewayResponseType("UNAUTHORIZED");
        /// <summary>
        /// Constant UNSUPPORTED_MEDIA_TYPE for GatewayResponseType
        /// </summary>
        public static readonly GatewayResponseType UNSUPPORTED_MEDIA_TYPE = new GatewayResponseType("UNSUPPORTED_MEDIA_TYPE");
        /// <summary>
        /// Constant WAF_FILTERED for GatewayResponseType
        /// </summary>
        public static readonly GatewayResponseType WAF_FILTERED = new GatewayResponseType("WAF_FILTERED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public GatewayResponseType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static GatewayResponseType FindValue(string value)
        {
            return FindValue<GatewayResponseType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator GatewayResponseType(string value)
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
        /// Constant AWS for IntegrationType
        /// </summary>
        public static readonly IntegrationType AWS = new IntegrationType("AWS");
        /// <summary>
        /// Constant AWS_PROXY for IntegrationType
        /// </summary>
        public static readonly IntegrationType AWS_PROXY = new IntegrationType("AWS_PROXY");
        /// <summary>
        /// Constant HTTP for IntegrationType
        /// </summary>
        public static readonly IntegrationType HTTP = new IntegrationType("HTTP");
        /// <summary>
        /// Constant HTTP_PROXY for IntegrationType
        /// </summary>
        public static readonly IntegrationType HTTP_PROXY = new IntegrationType("HTTP_PROXY");
        /// <summary>
        /// Constant MOCK for IntegrationType
        /// </summary>
        public static readonly IntegrationType MOCK = new IntegrationType("MOCK");

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
    /// Constants used for properties of type LocationStatusType.
    /// </summary>
    public class LocationStatusType : ConstantClass
    {

        /// <summary>
        /// Constant DOCUMENTED for LocationStatusType
        /// </summary>
        public static readonly LocationStatusType DOCUMENTED = new LocationStatusType("DOCUMENTED");
        /// <summary>
        /// Constant UNDOCUMENTED for LocationStatusType
        /// </summary>
        public static readonly LocationStatusType UNDOCUMENTED = new LocationStatusType("UNDOCUMENTED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public LocationStatusType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LocationStatusType FindValue(string value)
        {
            return FindValue<LocationStatusType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator LocationStatusType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Op.
    /// </summary>
    public class Op : ConstantClass
    {

        /// <summary>
        /// Constant Add for Op
        /// </summary>
        public static readonly Op Add = new Op("add");
        /// <summary>
        /// Constant Copy for Op
        /// </summary>
        public static readonly Op Copy = new Op("copy");
        /// <summary>
        /// Constant Move for Op
        /// </summary>
        public static readonly Op Move = new Op("move");
        /// <summary>
        /// Constant Remove for Op
        /// </summary>
        public static readonly Op Remove = new Op("remove");
        /// <summary>
        /// Constant Replace for Op
        /// </summary>
        public static readonly Op Replace = new Op("replace");
        /// <summary>
        /// Constant Test for Op
        /// </summary>
        public static readonly Op Test = new Op("test");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Op(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Op FindValue(string value)
        {
            return FindValue<Op>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Op(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PutMode.
    /// </summary>
    public class PutMode : ConstantClass
    {

        /// <summary>
        /// Constant Merge for PutMode
        /// </summary>
        public static readonly PutMode Merge = new PutMode("merge");
        /// <summary>
        /// Constant Overwrite for PutMode
        /// </summary>
        public static readonly PutMode Overwrite = new PutMode("overwrite");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PutMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PutMode FindValue(string value)
        {
            return FindValue<PutMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PutMode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type QuotaPeriodType.
    /// </summary>
    public class QuotaPeriodType : ConstantClass
    {

        /// <summary>
        /// Constant DAY for QuotaPeriodType
        /// </summary>
        public static readonly QuotaPeriodType DAY = new QuotaPeriodType("DAY");
        /// <summary>
        /// Constant MONTH for QuotaPeriodType
        /// </summary>
        public static readonly QuotaPeriodType MONTH = new QuotaPeriodType("MONTH");
        /// <summary>
        /// Constant WEEK for QuotaPeriodType
        /// </summary>
        public static readonly QuotaPeriodType WEEK = new QuotaPeriodType("WEEK");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public QuotaPeriodType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static QuotaPeriodType FindValue(string value)
        {
            return FindValue<QuotaPeriodType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator QuotaPeriodType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ResourceOwner.
    /// </summary>
    public class ResourceOwner : ConstantClass
    {

        /// <summary>
        /// Constant OTHER_ACCOUNTS for ResourceOwner
        /// </summary>
        public static readonly ResourceOwner OTHER_ACCOUNTS = new ResourceOwner("OTHER_ACCOUNTS");
        /// <summary>
        /// Constant SELF for ResourceOwner
        /// </summary>
        public static readonly ResourceOwner SELF = new ResourceOwner("SELF");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ResourceOwner(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ResourceOwner FindValue(string value)
        {
            return FindValue<ResourceOwner>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ResourceOwner(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RoutingMode.
    /// </summary>
    public class RoutingMode : ConstantClass
    {

        /// <summary>
        /// Constant BASE_PATH_MAPPING_ONLY for RoutingMode
        /// </summary>
        public static readonly RoutingMode BASE_PATH_MAPPING_ONLY = new RoutingMode("BASE_PATH_MAPPING_ONLY");
        /// <summary>
        /// Constant ROUTING_RULE_ONLY for RoutingMode
        /// </summary>
        public static readonly RoutingMode ROUTING_RULE_ONLY = new RoutingMode("ROUTING_RULE_ONLY");
        /// <summary>
        /// Constant ROUTING_RULE_THEN_BASE_PATH_MAPPING for RoutingMode
        /// </summary>
        public static readonly RoutingMode ROUTING_RULE_THEN_BASE_PATH_MAPPING = new RoutingMode("ROUTING_RULE_THEN_BASE_PATH_MAPPING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RoutingMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RoutingMode FindValue(string value)
        {
            return FindValue<RoutingMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RoutingMode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SecurityPolicy.
    /// </summary>
    public class SecurityPolicy : ConstantClass
    {

        /// <summary>
        /// Constant TLS_1_0 for SecurityPolicy
        /// </summary>
        public static readonly SecurityPolicy TLS_1_0 = new SecurityPolicy("TLS_1_0");
        /// <summary>
        /// Constant TLS_1_2 for SecurityPolicy
        /// </summary>
        public static readonly SecurityPolicy TLS_1_2 = new SecurityPolicy("TLS_1_2");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SecurityPolicy(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SecurityPolicy FindValue(string value)
        {
            return FindValue<SecurityPolicy>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SecurityPolicy(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type UnauthorizedCacheControlHeaderStrategy.
    /// </summary>
    public class UnauthorizedCacheControlHeaderStrategy : ConstantClass
    {

        /// <summary>
        /// Constant FAIL_WITH_403 for UnauthorizedCacheControlHeaderStrategy
        /// </summary>
        public static readonly UnauthorizedCacheControlHeaderStrategy FAIL_WITH_403 = new UnauthorizedCacheControlHeaderStrategy("FAIL_WITH_403");
        /// <summary>
        /// Constant SUCCEED_WITH_RESPONSE_HEADER for UnauthorizedCacheControlHeaderStrategy
        /// </summary>
        public static readonly UnauthorizedCacheControlHeaderStrategy SUCCEED_WITH_RESPONSE_HEADER = new UnauthorizedCacheControlHeaderStrategy("SUCCEED_WITH_RESPONSE_HEADER");
        /// <summary>
        /// Constant SUCCEED_WITHOUT_RESPONSE_HEADER for UnauthorizedCacheControlHeaderStrategy
        /// </summary>
        public static readonly UnauthorizedCacheControlHeaderStrategy SUCCEED_WITHOUT_RESPONSE_HEADER = new UnauthorizedCacheControlHeaderStrategy("SUCCEED_WITHOUT_RESPONSE_HEADER");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public UnauthorizedCacheControlHeaderStrategy(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static UnauthorizedCacheControlHeaderStrategy FindValue(string value)
        {
            return FindValue<UnauthorizedCacheControlHeaderStrategy>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator UnauthorizedCacheControlHeaderStrategy(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type VpcLinkStatus.
    /// </summary>
    public class VpcLinkStatus : ConstantClass
    {

        /// <summary>
        /// Constant AVAILABLE for VpcLinkStatus
        /// </summary>
        public static readonly VpcLinkStatus AVAILABLE = new VpcLinkStatus("AVAILABLE");
        /// <summary>
        /// Constant DELETING for VpcLinkStatus
        /// </summary>
        public static readonly VpcLinkStatus DELETING = new VpcLinkStatus("DELETING");
        /// <summary>
        /// Constant FAILED for VpcLinkStatus
        /// </summary>
        public static readonly VpcLinkStatus FAILED = new VpcLinkStatus("FAILED");
        /// <summary>
        /// Constant PENDING for VpcLinkStatus
        /// </summary>
        public static readonly VpcLinkStatus PENDING = new VpcLinkStatus("PENDING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public VpcLinkStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static VpcLinkStatus FindValue(string value)
        {
            return FindValue<VpcLinkStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator VpcLinkStatus(string value)
        {
            return FindValue(value);
        }
    }

}