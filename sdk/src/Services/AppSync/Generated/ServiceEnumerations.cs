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
 * Do not modify this file. This file is generated from the appsync-2017-07-25.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.AppSync
{

    /// <summary>
    /// Constants used for properties of type ApiCacheStatus.
    /// </summary>
    public class ApiCacheStatus : ConstantClass
    {

        /// <summary>
        /// Constant AVAILABLE for ApiCacheStatus
        /// </summary>
        public static readonly ApiCacheStatus AVAILABLE = new ApiCacheStatus("AVAILABLE");
        /// <summary>
        /// Constant CREATING for ApiCacheStatus
        /// </summary>
        public static readonly ApiCacheStatus CREATING = new ApiCacheStatus("CREATING");
        /// <summary>
        /// Constant DELETING for ApiCacheStatus
        /// </summary>
        public static readonly ApiCacheStatus DELETING = new ApiCacheStatus("DELETING");
        /// <summary>
        /// Constant FAILED for ApiCacheStatus
        /// </summary>
        public static readonly ApiCacheStatus FAILED = new ApiCacheStatus("FAILED");
        /// <summary>
        /// Constant MODIFYING for ApiCacheStatus
        /// </summary>
        public static readonly ApiCacheStatus MODIFYING = new ApiCacheStatus("MODIFYING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ApiCacheStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ApiCacheStatus FindValue(string value)
        {
            return FindValue<ApiCacheStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ApiCacheStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ApiCacheType.
    /// </summary>
    public class ApiCacheType : ConstantClass
    {

        /// <summary>
        /// Constant LARGE for ApiCacheType
        /// </summary>
        public static readonly ApiCacheType LARGE = new ApiCacheType("LARGE");
        /// <summary>
        /// Constant LARGE_12X for ApiCacheType
        /// </summary>
        public static readonly ApiCacheType LARGE_12X = new ApiCacheType("LARGE_12X");
        /// <summary>
        /// Constant LARGE_2X for ApiCacheType
        /// </summary>
        public static readonly ApiCacheType LARGE_2X = new ApiCacheType("LARGE_2X");
        /// <summary>
        /// Constant LARGE_4X for ApiCacheType
        /// </summary>
        public static readonly ApiCacheType LARGE_4X = new ApiCacheType("LARGE_4X");
        /// <summary>
        /// Constant LARGE_8X for ApiCacheType
        /// </summary>
        public static readonly ApiCacheType LARGE_8X = new ApiCacheType("LARGE_8X");
        /// <summary>
        /// Constant MEDIUM for ApiCacheType
        /// </summary>
        public static readonly ApiCacheType MEDIUM = new ApiCacheType("MEDIUM");
        /// <summary>
        /// Constant R4_2XLARGE for ApiCacheType
        /// </summary>
        public static readonly ApiCacheType R4_2XLARGE = new ApiCacheType("R4_2XLARGE");
        /// <summary>
        /// Constant R4_4XLARGE for ApiCacheType
        /// </summary>
        public static readonly ApiCacheType R4_4XLARGE = new ApiCacheType("R4_4XLARGE");
        /// <summary>
        /// Constant R4_8XLARGE for ApiCacheType
        /// </summary>
        public static readonly ApiCacheType R4_8XLARGE = new ApiCacheType("R4_8XLARGE");
        /// <summary>
        /// Constant R4_LARGE for ApiCacheType
        /// </summary>
        public static readonly ApiCacheType R4_LARGE = new ApiCacheType("R4_LARGE");
        /// <summary>
        /// Constant R4_XLARGE for ApiCacheType
        /// </summary>
        public static readonly ApiCacheType R4_XLARGE = new ApiCacheType("R4_XLARGE");
        /// <summary>
        /// Constant SMALL for ApiCacheType
        /// </summary>
        public static readonly ApiCacheType SMALL = new ApiCacheType("SMALL");
        /// <summary>
        /// Constant T2_MEDIUM for ApiCacheType
        /// </summary>
        public static readonly ApiCacheType T2_MEDIUM = new ApiCacheType("T2_MEDIUM");
        /// <summary>
        /// Constant T2_SMALL for ApiCacheType
        /// </summary>
        public static readonly ApiCacheType T2_SMALL = new ApiCacheType("T2_SMALL");
        /// <summary>
        /// Constant XLARGE for ApiCacheType
        /// </summary>
        public static readonly ApiCacheType XLARGE = new ApiCacheType("XLARGE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ApiCacheType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ApiCacheType FindValue(string value)
        {
            return FindValue<ApiCacheType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ApiCacheType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ApiCachingBehavior.
    /// </summary>
    public class ApiCachingBehavior : ConstantClass
    {

        /// <summary>
        /// Constant FULL_REQUEST_CACHING for ApiCachingBehavior
        /// </summary>
        public static readonly ApiCachingBehavior FULL_REQUEST_CACHING = new ApiCachingBehavior("FULL_REQUEST_CACHING");
        /// <summary>
        /// Constant OPERATION_LEVEL_CACHING for ApiCachingBehavior
        /// </summary>
        public static readonly ApiCachingBehavior OPERATION_LEVEL_CACHING = new ApiCachingBehavior("OPERATION_LEVEL_CACHING");
        /// <summary>
        /// Constant PER_RESOLVER_CACHING for ApiCachingBehavior
        /// </summary>
        public static readonly ApiCachingBehavior PER_RESOLVER_CACHING = new ApiCachingBehavior("PER_RESOLVER_CACHING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ApiCachingBehavior(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ApiCachingBehavior FindValue(string value)
        {
            return FindValue<ApiCachingBehavior>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ApiCachingBehavior(string value)
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
        /// Constant FAILED for AssociationStatus
        /// </summary>
        public static readonly AssociationStatus FAILED = new AssociationStatus("FAILED");
        /// <summary>
        /// Constant PROCESSING for AssociationStatus
        /// </summary>
        public static readonly AssociationStatus PROCESSING = new AssociationStatus("PROCESSING");
        /// <summary>
        /// Constant SUCCESS for AssociationStatus
        /// </summary>
        public static readonly AssociationStatus SUCCESS = new AssociationStatus("SUCCESS");

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
    /// Constants used for properties of type AuthenticationType.
    /// </summary>
    public class AuthenticationType : ConstantClass
    {

        /// <summary>
        /// Constant AMAZON_COGNITO_USER_POOLS for AuthenticationType
        /// </summary>
        public static readonly AuthenticationType AMAZON_COGNITO_USER_POOLS = new AuthenticationType("AMAZON_COGNITO_USER_POOLS");
        /// <summary>
        /// Constant API_KEY for AuthenticationType
        /// </summary>
        public static readonly AuthenticationType API_KEY = new AuthenticationType("API_KEY");
        /// <summary>
        /// Constant AWS_IAM for AuthenticationType
        /// </summary>
        public static readonly AuthenticationType AWS_IAM = new AuthenticationType("AWS_IAM");
        /// <summary>
        /// Constant AWS_LAMBDA for AuthenticationType
        /// </summary>
        public static readonly AuthenticationType AWS_LAMBDA = new AuthenticationType("AWS_LAMBDA");
        /// <summary>
        /// Constant OPENID_CONNECT for AuthenticationType
        /// </summary>
        public static readonly AuthenticationType OPENID_CONNECT = new AuthenticationType("OPENID_CONNECT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AuthenticationType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AuthenticationType FindValue(string value)
        {
            return FindValue<AuthenticationType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AuthenticationType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AuthorizationType.
    /// </summary>
    public class AuthorizationType : ConstantClass
    {

        /// <summary>
        /// Constant AWS_IAM for AuthorizationType
        /// </summary>
        public static readonly AuthorizationType AWS_IAM = new AuthorizationType("AWS_IAM");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AuthorizationType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AuthorizationType FindValue(string value)
        {
            return FindValue<AuthorizationType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AuthorizationType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type BadRequestReason.
    /// </summary>
    public class BadRequestReason : ConstantClass
    {

        /// <summary>
        /// Constant CODE_ERROR for BadRequestReason
        /// </summary>
        public static readonly BadRequestReason CODE_ERROR = new BadRequestReason("CODE_ERROR");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public BadRequestReason(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static BadRequestReason FindValue(string value)
        {
            return FindValue<BadRequestReason>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator BadRequestReason(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CacheHealthMetricsConfig.
    /// </summary>
    public class CacheHealthMetricsConfig : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for CacheHealthMetricsConfig
        /// </summary>
        public static readonly CacheHealthMetricsConfig DISABLED = new CacheHealthMetricsConfig("DISABLED");
        /// <summary>
        /// Constant ENABLED for CacheHealthMetricsConfig
        /// </summary>
        public static readonly CacheHealthMetricsConfig ENABLED = new CacheHealthMetricsConfig("ENABLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CacheHealthMetricsConfig(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CacheHealthMetricsConfig FindValue(string value)
        {
            return FindValue<CacheHealthMetricsConfig>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CacheHealthMetricsConfig(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ConflictDetectionType.
    /// </summary>
    public class ConflictDetectionType : ConstantClass
    {

        /// <summary>
        /// Constant NONE for ConflictDetectionType
        /// </summary>
        public static readonly ConflictDetectionType NONE = new ConflictDetectionType("NONE");
        /// <summary>
        /// Constant VERSION for ConflictDetectionType
        /// </summary>
        public static readonly ConflictDetectionType VERSION = new ConflictDetectionType("VERSION");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ConflictDetectionType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ConflictDetectionType FindValue(string value)
        {
            return FindValue<ConflictDetectionType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ConflictDetectionType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ConflictHandlerType.
    /// </summary>
    public class ConflictHandlerType : ConstantClass
    {

        /// <summary>
        /// Constant AUTOMERGE for ConflictHandlerType
        /// </summary>
        public static readonly ConflictHandlerType AUTOMERGE = new ConflictHandlerType("AUTOMERGE");
        /// <summary>
        /// Constant LAMBDA for ConflictHandlerType
        /// </summary>
        public static readonly ConflictHandlerType LAMBDA = new ConflictHandlerType("LAMBDA");
        /// <summary>
        /// Constant NONE for ConflictHandlerType
        /// </summary>
        public static readonly ConflictHandlerType NONE = new ConflictHandlerType("NONE");
        /// <summary>
        /// Constant OPTIMISTIC_CONCURRENCY for ConflictHandlerType
        /// </summary>
        public static readonly ConflictHandlerType OPTIMISTIC_CONCURRENCY = new ConflictHandlerType("OPTIMISTIC_CONCURRENCY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ConflictHandlerType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ConflictHandlerType FindValue(string value)
        {
            return FindValue<ConflictHandlerType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ConflictHandlerType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DataSourceIntrospectionStatus.
    /// </summary>
    public class DataSourceIntrospectionStatus : ConstantClass
    {

        /// <summary>
        /// Constant FAILED for DataSourceIntrospectionStatus
        /// </summary>
        public static readonly DataSourceIntrospectionStatus FAILED = new DataSourceIntrospectionStatus("FAILED");
        /// <summary>
        /// Constant PROCESSING for DataSourceIntrospectionStatus
        /// </summary>
        public static readonly DataSourceIntrospectionStatus PROCESSING = new DataSourceIntrospectionStatus("PROCESSING");
        /// <summary>
        /// Constant SUCCESS for DataSourceIntrospectionStatus
        /// </summary>
        public static readonly DataSourceIntrospectionStatus SUCCESS = new DataSourceIntrospectionStatus("SUCCESS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DataSourceIntrospectionStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DataSourceIntrospectionStatus FindValue(string value)
        {
            return FindValue<DataSourceIntrospectionStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DataSourceIntrospectionStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DataSourceLevelMetricsBehavior.
    /// </summary>
    public class DataSourceLevelMetricsBehavior : ConstantClass
    {

        /// <summary>
        /// Constant FULL_REQUEST_DATA_SOURCE_METRICS for DataSourceLevelMetricsBehavior
        /// </summary>
        public static readonly DataSourceLevelMetricsBehavior FULL_REQUEST_DATA_SOURCE_METRICS = new DataSourceLevelMetricsBehavior("FULL_REQUEST_DATA_SOURCE_METRICS");
        /// <summary>
        /// Constant PER_DATA_SOURCE_METRICS for DataSourceLevelMetricsBehavior
        /// </summary>
        public static readonly DataSourceLevelMetricsBehavior PER_DATA_SOURCE_METRICS = new DataSourceLevelMetricsBehavior("PER_DATA_SOURCE_METRICS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DataSourceLevelMetricsBehavior(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DataSourceLevelMetricsBehavior FindValue(string value)
        {
            return FindValue<DataSourceLevelMetricsBehavior>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DataSourceLevelMetricsBehavior(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DataSourceLevelMetricsConfig.
    /// </summary>
    public class DataSourceLevelMetricsConfig : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for DataSourceLevelMetricsConfig
        /// </summary>
        public static readonly DataSourceLevelMetricsConfig DISABLED = new DataSourceLevelMetricsConfig("DISABLED");
        /// <summary>
        /// Constant ENABLED for DataSourceLevelMetricsConfig
        /// </summary>
        public static readonly DataSourceLevelMetricsConfig ENABLED = new DataSourceLevelMetricsConfig("ENABLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DataSourceLevelMetricsConfig(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DataSourceLevelMetricsConfig FindValue(string value)
        {
            return FindValue<DataSourceLevelMetricsConfig>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DataSourceLevelMetricsConfig(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DataSourceType.
    /// </summary>
    public class DataSourceType : ConstantClass
    {

        /// <summary>
        /// Constant AMAZON_BEDROCK_RUNTIME for DataSourceType
        /// </summary>
        public static readonly DataSourceType AMAZON_BEDROCK_RUNTIME = new DataSourceType("AMAZON_BEDROCK_RUNTIME");
        /// <summary>
        /// Constant AMAZON_DYNAMODB for DataSourceType
        /// </summary>
        public static readonly DataSourceType AMAZON_DYNAMODB = new DataSourceType("AMAZON_DYNAMODB");
        /// <summary>
        /// Constant AMAZON_ELASTICSEARCH for DataSourceType
        /// </summary>
        public static readonly DataSourceType AMAZON_ELASTICSEARCH = new DataSourceType("AMAZON_ELASTICSEARCH");
        /// <summary>
        /// Constant AMAZON_EVENTBRIDGE for DataSourceType
        /// </summary>
        public static readonly DataSourceType AMAZON_EVENTBRIDGE = new DataSourceType("AMAZON_EVENTBRIDGE");
        /// <summary>
        /// Constant AMAZON_OPENSEARCH_SERVICE for DataSourceType
        /// </summary>
        public static readonly DataSourceType AMAZON_OPENSEARCH_SERVICE = new DataSourceType("AMAZON_OPENSEARCH_SERVICE");
        /// <summary>
        /// Constant AWS_LAMBDA for DataSourceType
        /// </summary>
        public static readonly DataSourceType AWS_LAMBDA = new DataSourceType("AWS_LAMBDA");
        /// <summary>
        /// Constant HTTP for DataSourceType
        /// </summary>
        public static readonly DataSourceType HTTP = new DataSourceType("HTTP");
        /// <summary>
        /// Constant NONE for DataSourceType
        /// </summary>
        public static readonly DataSourceType NONE = new DataSourceType("NONE");
        /// <summary>
        /// Constant RELATIONAL_DATABASE for DataSourceType
        /// </summary>
        public static readonly DataSourceType RELATIONAL_DATABASE = new DataSourceType("RELATIONAL_DATABASE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DataSourceType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DataSourceType FindValue(string value)
        {
            return FindValue<DataSourceType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DataSourceType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DefaultAction.
    /// </summary>
    public class DefaultAction : ConstantClass
    {

        /// <summary>
        /// Constant ALLOW for DefaultAction
        /// </summary>
        public static readonly DefaultAction ALLOW = new DefaultAction("ALLOW");
        /// <summary>
        /// Constant DENY for DefaultAction
        /// </summary>
        public static readonly DefaultAction DENY = new DefaultAction("DENY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DefaultAction(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DefaultAction FindValue(string value)
        {
            return FindValue<DefaultAction>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DefaultAction(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type EventLogLevel.
    /// </summary>
    public class EventLogLevel : ConstantClass
    {

        /// <summary>
        /// Constant ALL for EventLogLevel
        /// </summary>
        public static readonly EventLogLevel ALL = new EventLogLevel("ALL");
        /// <summary>
        /// Constant DEBUG for EventLogLevel
        /// </summary>
        public static readonly EventLogLevel DEBUG = new EventLogLevel("DEBUG");
        /// <summary>
        /// Constant ERROR for EventLogLevel
        /// </summary>
        public static readonly EventLogLevel ERROR = new EventLogLevel("ERROR");
        /// <summary>
        /// Constant INFO for EventLogLevel
        /// </summary>
        public static readonly EventLogLevel INFO = new EventLogLevel("INFO");
        /// <summary>
        /// Constant NONE for EventLogLevel
        /// </summary>
        public static readonly EventLogLevel NONE = new EventLogLevel("NONE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EventLogLevel(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EventLogLevel FindValue(string value)
        {
            return FindValue<EventLogLevel>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EventLogLevel(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type FieldLogLevel.
    /// </summary>
    public class FieldLogLevel : ConstantClass
    {

        /// <summary>
        /// Constant ALL for FieldLogLevel
        /// </summary>
        public static readonly FieldLogLevel ALL = new FieldLogLevel("ALL");
        /// <summary>
        /// Constant DEBUG for FieldLogLevel
        /// </summary>
        public static readonly FieldLogLevel DEBUG = new FieldLogLevel("DEBUG");
        /// <summary>
        /// Constant ERROR for FieldLogLevel
        /// </summary>
        public static readonly FieldLogLevel ERROR = new FieldLogLevel("ERROR");
        /// <summary>
        /// Constant INFO for FieldLogLevel
        /// </summary>
        public static readonly FieldLogLevel INFO = new FieldLogLevel("INFO");
        /// <summary>
        /// Constant NONE for FieldLogLevel
        /// </summary>
        public static readonly FieldLogLevel NONE = new FieldLogLevel("NONE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FieldLogLevel(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FieldLogLevel FindValue(string value)
        {
            return FindValue<FieldLogLevel>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FieldLogLevel(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type GraphQLApiIntrospectionConfig.
    /// </summary>
    public class GraphQLApiIntrospectionConfig : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for GraphQLApiIntrospectionConfig
        /// </summary>
        public static readonly GraphQLApiIntrospectionConfig DISABLED = new GraphQLApiIntrospectionConfig("DISABLED");
        /// <summary>
        /// Constant ENABLED for GraphQLApiIntrospectionConfig
        /// </summary>
        public static readonly GraphQLApiIntrospectionConfig ENABLED = new GraphQLApiIntrospectionConfig("ENABLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public GraphQLApiIntrospectionConfig(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static GraphQLApiIntrospectionConfig FindValue(string value)
        {
            return FindValue<GraphQLApiIntrospectionConfig>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator GraphQLApiIntrospectionConfig(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type GraphQLApiType.
    /// </summary>
    public class GraphQLApiType : ConstantClass
    {

        /// <summary>
        /// Constant GRAPHQL for GraphQLApiType
        /// </summary>
        public static readonly GraphQLApiType GRAPHQL = new GraphQLApiType("GRAPHQL");
        /// <summary>
        /// Constant MERGED for GraphQLApiType
        /// </summary>
        public static readonly GraphQLApiType MERGED = new GraphQLApiType("MERGED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public GraphQLApiType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static GraphQLApiType FindValue(string value)
        {
            return FindValue<GraphQLApiType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator GraphQLApiType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type GraphQLApiVisibility.
    /// </summary>
    public class GraphQLApiVisibility : ConstantClass
    {

        /// <summary>
        /// Constant GLOBAL for GraphQLApiVisibility
        /// </summary>
        public static readonly GraphQLApiVisibility GLOBAL = new GraphQLApiVisibility("GLOBAL");
        /// <summary>
        /// Constant PRIVATE for GraphQLApiVisibility
        /// </summary>
        public static readonly GraphQLApiVisibility PRIVATE = new GraphQLApiVisibility("PRIVATE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public GraphQLApiVisibility(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static GraphQLApiVisibility FindValue(string value)
        {
            return FindValue<GraphQLApiVisibility>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator GraphQLApiVisibility(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type HandlerBehavior.
    /// </summary>
    public class HandlerBehavior : ConstantClass
    {

        /// <summary>
        /// Constant CODE for HandlerBehavior
        /// </summary>
        public static readonly HandlerBehavior CODE = new HandlerBehavior("CODE");
        /// <summary>
        /// Constant DIRECT for HandlerBehavior
        /// </summary>
        public static readonly HandlerBehavior DIRECT = new HandlerBehavior("DIRECT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public HandlerBehavior(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static HandlerBehavior FindValue(string value)
        {
            return FindValue<HandlerBehavior>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator HandlerBehavior(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type InvokeType.
    /// </summary>
    public class InvokeType : ConstantClass
    {

        /// <summary>
        /// Constant EVENT for InvokeType
        /// </summary>
        public static readonly InvokeType EVENT = new InvokeType("EVENT");
        /// <summary>
        /// Constant REQUEST_RESPONSE for InvokeType
        /// </summary>
        public static readonly InvokeType REQUEST_RESPONSE = new InvokeType("REQUEST_RESPONSE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public InvokeType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static InvokeType FindValue(string value)
        {
            return FindValue<InvokeType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator InvokeType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type MergeType.
    /// </summary>
    public class MergeType : ConstantClass
    {

        /// <summary>
        /// Constant AUTO_MERGE for MergeType
        /// </summary>
        public static readonly MergeType AUTO_MERGE = new MergeType("AUTO_MERGE");
        /// <summary>
        /// Constant MANUAL_MERGE for MergeType
        /// </summary>
        public static readonly MergeType MANUAL_MERGE = new MergeType("MANUAL_MERGE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MergeType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MergeType FindValue(string value)
        {
            return FindValue<MergeType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MergeType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type OperationLevelMetricsConfig.
    /// </summary>
    public class OperationLevelMetricsConfig : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for OperationLevelMetricsConfig
        /// </summary>
        public static readonly OperationLevelMetricsConfig DISABLED = new OperationLevelMetricsConfig("DISABLED");
        /// <summary>
        /// Constant ENABLED for OperationLevelMetricsConfig
        /// </summary>
        public static readonly OperationLevelMetricsConfig ENABLED = new OperationLevelMetricsConfig("ENABLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public OperationLevelMetricsConfig(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static OperationLevelMetricsConfig FindValue(string value)
        {
            return FindValue<OperationLevelMetricsConfig>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator OperationLevelMetricsConfig(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type OutputType.
    /// </summary>
    public class OutputType : ConstantClass
    {

        /// <summary>
        /// Constant JSON for OutputType
        /// </summary>
        public static readonly OutputType JSON = new OutputType("JSON");
        /// <summary>
        /// Constant SDL for OutputType
        /// </summary>
        public static readonly OutputType SDL = new OutputType("SDL");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public OutputType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static OutputType FindValue(string value)
        {
            return FindValue<OutputType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator OutputType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Ownership.
    /// </summary>
    public class Ownership : ConstantClass
    {

        /// <summary>
        /// Constant CURRENT_ACCOUNT for Ownership
        /// </summary>
        public static readonly Ownership CURRENT_ACCOUNT = new Ownership("CURRENT_ACCOUNT");
        /// <summary>
        /// Constant OTHER_ACCOUNTS for Ownership
        /// </summary>
        public static readonly Ownership OTHER_ACCOUNTS = new Ownership("OTHER_ACCOUNTS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Ownership(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Ownership FindValue(string value)
        {
            return FindValue<Ownership>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Ownership(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RelationalDatabaseSourceType.
    /// </summary>
    public class RelationalDatabaseSourceType : ConstantClass
    {

        /// <summary>
        /// Constant RDS_HTTP_ENDPOINT for RelationalDatabaseSourceType
        /// </summary>
        public static readonly RelationalDatabaseSourceType RDS_HTTP_ENDPOINT = new RelationalDatabaseSourceType("RDS_HTTP_ENDPOINT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RelationalDatabaseSourceType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RelationalDatabaseSourceType FindValue(string value)
        {
            return FindValue<RelationalDatabaseSourceType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RelationalDatabaseSourceType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ResolverKind.
    /// </summary>
    public class ResolverKind : ConstantClass
    {

        /// <summary>
        /// Constant PIPELINE for ResolverKind
        /// </summary>
        public static readonly ResolverKind PIPELINE = new ResolverKind("PIPELINE");
        /// <summary>
        /// Constant UNIT for ResolverKind
        /// </summary>
        public static readonly ResolverKind UNIT = new ResolverKind("UNIT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ResolverKind(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ResolverKind FindValue(string value)
        {
            return FindValue<ResolverKind>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ResolverKind(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ResolverLevelMetricsBehavior.
    /// </summary>
    public class ResolverLevelMetricsBehavior : ConstantClass
    {

        /// <summary>
        /// Constant FULL_REQUEST_RESOLVER_METRICS for ResolverLevelMetricsBehavior
        /// </summary>
        public static readonly ResolverLevelMetricsBehavior FULL_REQUEST_RESOLVER_METRICS = new ResolverLevelMetricsBehavior("FULL_REQUEST_RESOLVER_METRICS");
        /// <summary>
        /// Constant PER_RESOLVER_METRICS for ResolverLevelMetricsBehavior
        /// </summary>
        public static readonly ResolverLevelMetricsBehavior PER_RESOLVER_METRICS = new ResolverLevelMetricsBehavior("PER_RESOLVER_METRICS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ResolverLevelMetricsBehavior(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ResolverLevelMetricsBehavior FindValue(string value)
        {
            return FindValue<ResolverLevelMetricsBehavior>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ResolverLevelMetricsBehavior(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ResolverLevelMetricsConfig.
    /// </summary>
    public class ResolverLevelMetricsConfig : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for ResolverLevelMetricsConfig
        /// </summary>
        public static readonly ResolverLevelMetricsConfig DISABLED = new ResolverLevelMetricsConfig("DISABLED");
        /// <summary>
        /// Constant ENABLED for ResolverLevelMetricsConfig
        /// </summary>
        public static readonly ResolverLevelMetricsConfig ENABLED = new ResolverLevelMetricsConfig("ENABLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ResolverLevelMetricsConfig(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ResolverLevelMetricsConfig FindValue(string value)
        {
            return FindValue<ResolverLevelMetricsConfig>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ResolverLevelMetricsConfig(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RuntimeName.
    /// </summary>
    public class RuntimeName : ConstantClass
    {

        /// <summary>
        /// Constant APPSYNC_JS for RuntimeName
        /// </summary>
        public static readonly RuntimeName APPSYNC_JS = new RuntimeName("APPSYNC_JS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RuntimeName(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RuntimeName FindValue(string value)
        {
            return FindValue<RuntimeName>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RuntimeName(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SchemaStatus.
    /// </summary>
    public class SchemaStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for SchemaStatus
        /// </summary>
        public static readonly SchemaStatus ACTIVE = new SchemaStatus("ACTIVE");
        /// <summary>
        /// Constant DELETING for SchemaStatus
        /// </summary>
        public static readonly SchemaStatus DELETING = new SchemaStatus("DELETING");
        /// <summary>
        /// Constant FAILED for SchemaStatus
        /// </summary>
        public static readonly SchemaStatus FAILED = new SchemaStatus("FAILED");
        /// <summary>
        /// Constant NOT_APPLICABLE for SchemaStatus
        /// </summary>
        public static readonly SchemaStatus NOT_APPLICABLE = new SchemaStatus("NOT_APPLICABLE");
        /// <summary>
        /// Constant PROCESSING for SchemaStatus
        /// </summary>
        public static readonly SchemaStatus PROCESSING = new SchemaStatus("PROCESSING");
        /// <summary>
        /// Constant SUCCESS for SchemaStatus
        /// </summary>
        public static readonly SchemaStatus SUCCESS = new SchemaStatus("SUCCESS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SchemaStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SchemaStatus FindValue(string value)
        {
            return FindValue<SchemaStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SchemaStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SourceApiAssociationStatus.
    /// </summary>
    public class SourceApiAssociationStatus : ConstantClass
    {

        /// <summary>
        /// Constant AUTO_MERGE_SCHEDULE_FAILED for SourceApiAssociationStatus
        /// </summary>
        public static readonly SourceApiAssociationStatus AUTO_MERGE_SCHEDULE_FAILED = new SourceApiAssociationStatus("AUTO_MERGE_SCHEDULE_FAILED");
        /// <summary>
        /// Constant DELETION_FAILED for SourceApiAssociationStatus
        /// </summary>
        public static readonly SourceApiAssociationStatus DELETION_FAILED = new SourceApiAssociationStatus("DELETION_FAILED");
        /// <summary>
        /// Constant DELETION_IN_PROGRESS for SourceApiAssociationStatus
        /// </summary>
        public static readonly SourceApiAssociationStatus DELETION_IN_PROGRESS = new SourceApiAssociationStatus("DELETION_IN_PROGRESS");
        /// <summary>
        /// Constant DELETION_SCHEDULED for SourceApiAssociationStatus
        /// </summary>
        public static readonly SourceApiAssociationStatus DELETION_SCHEDULED = new SourceApiAssociationStatus("DELETION_SCHEDULED");
        /// <summary>
        /// Constant MERGE_FAILED for SourceApiAssociationStatus
        /// </summary>
        public static readonly SourceApiAssociationStatus MERGE_FAILED = new SourceApiAssociationStatus("MERGE_FAILED");
        /// <summary>
        /// Constant MERGE_IN_PROGRESS for SourceApiAssociationStatus
        /// </summary>
        public static readonly SourceApiAssociationStatus MERGE_IN_PROGRESS = new SourceApiAssociationStatus("MERGE_IN_PROGRESS");
        /// <summary>
        /// Constant MERGE_SCHEDULED for SourceApiAssociationStatus
        /// </summary>
        public static readonly SourceApiAssociationStatus MERGE_SCHEDULED = new SourceApiAssociationStatus("MERGE_SCHEDULED");
        /// <summary>
        /// Constant MERGE_SUCCESS for SourceApiAssociationStatus
        /// </summary>
        public static readonly SourceApiAssociationStatus MERGE_SUCCESS = new SourceApiAssociationStatus("MERGE_SUCCESS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SourceApiAssociationStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SourceApiAssociationStatus FindValue(string value)
        {
            return FindValue<SourceApiAssociationStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SourceApiAssociationStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TypeDefinitionFormat.
    /// </summary>
    public class TypeDefinitionFormat : ConstantClass
    {

        /// <summary>
        /// Constant JSON for TypeDefinitionFormat
        /// </summary>
        public static readonly TypeDefinitionFormat JSON = new TypeDefinitionFormat("JSON");
        /// <summary>
        /// Constant SDL for TypeDefinitionFormat
        /// </summary>
        public static readonly TypeDefinitionFormat SDL = new TypeDefinitionFormat("SDL");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TypeDefinitionFormat(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TypeDefinitionFormat FindValue(string value)
        {
            return FindValue<TypeDefinitionFormat>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TypeDefinitionFormat(string value)
        {
            return FindValue(value);
        }
    }

}