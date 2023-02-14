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
    /// Constants used for properties of type DataSourceType.
    /// </summary>
    public class DataSourceType : ConstantClass
    {

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
    /// Constants used for properties of type FieldLogLevel.
    /// </summary>
    public class FieldLogLevel : ConstantClass
    {

        /// <summary>
        /// Constant ALL for FieldLogLevel
        /// </summary>
        public static readonly FieldLogLevel ALL = new FieldLogLevel("ALL");
        /// <summary>
        /// Constant ERROR for FieldLogLevel
        /// </summary>
        public static readonly FieldLogLevel ERROR = new FieldLogLevel("ERROR");
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