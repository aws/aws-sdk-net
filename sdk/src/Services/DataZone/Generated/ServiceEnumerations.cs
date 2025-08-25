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
 * Do not modify this file. This file is generated from the datazone-2018-05-10.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.DataZone
{

    /// <summary>
    /// Constants used for properties of type AcceptRuleBehavior.
    /// </summary>
    public class AcceptRuleBehavior : ConstantClass
    {

        /// <summary>
        /// Constant ALL for AcceptRuleBehavior
        /// </summary>
        public static readonly AcceptRuleBehavior ALL = new AcceptRuleBehavior("ALL");
        /// <summary>
        /// Constant NONE for AcceptRuleBehavior
        /// </summary>
        public static readonly AcceptRuleBehavior NONE = new AcceptRuleBehavior("NONE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AcceptRuleBehavior(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AcceptRuleBehavior FindValue(string value)
        {
            return FindValue<AcceptRuleBehavior>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AcceptRuleBehavior(string value)
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
        /// Constant BASIC for AuthenticationType
        /// </summary>
        public static readonly AuthenticationType BASIC = new AuthenticationType("BASIC");
        /// <summary>
        /// Constant CUSTOM for AuthenticationType
        /// </summary>
        public static readonly AuthenticationType CUSTOM = new AuthenticationType("CUSTOM");
        /// <summary>
        /// Constant OAUTH2 for AuthenticationType
        /// </summary>
        public static readonly AuthenticationType OAUTH2 = new AuthenticationType("OAUTH2");

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
    /// Constants used for properties of type AuthType.
    /// </summary>
    public class AuthType : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for AuthType
        /// </summary>
        public static readonly AuthType DISABLED = new AuthType("DISABLED");
        /// <summary>
        /// Constant IAM_IDC for AuthType
        /// </summary>
        public static readonly AuthType IAM_IDC = new AuthType("IAM_IDC");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AuthType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AuthType FindValue(string value)
        {
            return FindValue<AuthType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AuthType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ChangeAction.
    /// </summary>
    public class ChangeAction : ConstantClass
    {

        /// <summary>
        /// Constant PUBLISH for ChangeAction
        /// </summary>
        public static readonly ChangeAction PUBLISH = new ChangeAction("PUBLISH");
        /// <summary>
        /// Constant UNPUBLISH for ChangeAction
        /// </summary>
        public static readonly ChangeAction UNPUBLISH = new ChangeAction("UNPUBLISH");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ChangeAction(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ChangeAction FindValue(string value)
        {
            return FindValue<ChangeAction>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ChangeAction(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ComputeEnvironments.
    /// </summary>
    public class ComputeEnvironments : ConstantClass
    {

        /// <summary>
        /// Constant ATHENA for ComputeEnvironments
        /// </summary>
        public static readonly ComputeEnvironments ATHENA = new ComputeEnvironments("ATHENA");
        /// <summary>
        /// Constant PYTHON for ComputeEnvironments
        /// </summary>
        public static readonly ComputeEnvironments PYTHON = new ComputeEnvironments("PYTHON");
        /// <summary>
        /// Constant SPARK for ComputeEnvironments
        /// </summary>
        public static readonly ComputeEnvironments SPARK = new ComputeEnvironments("SPARK");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ComputeEnvironments(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ComputeEnvironments FindValue(string value)
        {
            return FindValue<ComputeEnvironments>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ComputeEnvironments(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ConfigurableActionTypeAuthorization.
    /// </summary>
    public class ConfigurableActionTypeAuthorization : ConstantClass
    {

        /// <summary>
        /// Constant HTTPS for ConfigurableActionTypeAuthorization
        /// </summary>
        public static readonly ConfigurableActionTypeAuthorization HTTPS = new ConfigurableActionTypeAuthorization("HTTPS");
        /// <summary>
        /// Constant IAM for ConfigurableActionTypeAuthorization
        /// </summary>
        public static readonly ConfigurableActionTypeAuthorization IAM = new ConfigurableActionTypeAuthorization("IAM");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ConfigurableActionTypeAuthorization(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ConfigurableActionTypeAuthorization FindValue(string value)
        {
            return FindValue<ConfigurableActionTypeAuthorization>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ConfigurableActionTypeAuthorization(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ConnectionStatus.
    /// </summary>
    public class ConnectionStatus : ConstantClass
    {

        /// <summary>
        /// Constant CREATE_FAILED for ConnectionStatus
        /// </summary>
        public static readonly ConnectionStatus CREATE_FAILED = new ConnectionStatus("CREATE_FAILED");
        /// <summary>
        /// Constant CREATING for ConnectionStatus
        /// </summary>
        public static readonly ConnectionStatus CREATING = new ConnectionStatus("CREATING");
        /// <summary>
        /// Constant DELETE_FAILED for ConnectionStatus
        /// </summary>
        public static readonly ConnectionStatus DELETE_FAILED = new ConnectionStatus("DELETE_FAILED");
        /// <summary>
        /// Constant DELETED for ConnectionStatus
        /// </summary>
        public static readonly ConnectionStatus DELETED = new ConnectionStatus("DELETED");
        /// <summary>
        /// Constant DELETING for ConnectionStatus
        /// </summary>
        public static readonly ConnectionStatus DELETING = new ConnectionStatus("DELETING");
        /// <summary>
        /// Constant READY for ConnectionStatus
        /// </summary>
        public static readonly ConnectionStatus READY = new ConnectionStatus("READY");
        /// <summary>
        /// Constant UPDATE_FAILED for ConnectionStatus
        /// </summary>
        public static readonly ConnectionStatus UPDATE_FAILED = new ConnectionStatus("UPDATE_FAILED");
        /// <summary>
        /// Constant UPDATING for ConnectionStatus
        /// </summary>
        public static readonly ConnectionStatus UPDATING = new ConnectionStatus("UPDATING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ConnectionStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ConnectionStatus FindValue(string value)
        {
            return FindValue<ConnectionStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ConnectionStatus(string value)
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
        /// Constant ATHENA for ConnectionType
        /// </summary>
        public static readonly ConnectionType ATHENA = new ConnectionType("ATHENA");
        /// <summary>
        /// Constant BIGQUERY for ConnectionType
        /// </summary>
        public static readonly ConnectionType BIGQUERY = new ConnectionType("BIGQUERY");
        /// <summary>
        /// Constant DATABRICKS for ConnectionType
        /// </summary>
        public static readonly ConnectionType DATABRICKS = new ConnectionType("DATABRICKS");
        /// <summary>
        /// Constant DOCUMENTDB for ConnectionType
        /// </summary>
        public static readonly ConnectionType DOCUMENTDB = new ConnectionType("DOCUMENTDB");
        /// <summary>
        /// Constant DYNAMODB for ConnectionType
        /// </summary>
        public static readonly ConnectionType DYNAMODB = new ConnectionType("DYNAMODB");
        /// <summary>
        /// Constant HYPERPOD for ConnectionType
        /// </summary>
        public static readonly ConnectionType HYPERPOD = new ConnectionType("HYPERPOD");
        /// <summary>
        /// Constant IAM for ConnectionType
        /// </summary>
        public static readonly ConnectionType IAM = new ConnectionType("IAM");
        /// <summary>
        /// Constant MYSQL for ConnectionType
        /// </summary>
        public static readonly ConnectionType MYSQL = new ConnectionType("MYSQL");
        /// <summary>
        /// Constant OPENSEARCH for ConnectionType
        /// </summary>
        public static readonly ConnectionType OPENSEARCH = new ConnectionType("OPENSEARCH");
        /// <summary>
        /// Constant ORACLE for ConnectionType
        /// </summary>
        public static readonly ConnectionType ORACLE = new ConnectionType("ORACLE");
        /// <summary>
        /// Constant POSTGRESQL for ConnectionType
        /// </summary>
        public static readonly ConnectionType POSTGRESQL = new ConnectionType("POSTGRESQL");
        /// <summary>
        /// Constant REDSHIFT for ConnectionType
        /// </summary>
        public static readonly ConnectionType REDSHIFT = new ConnectionType("REDSHIFT");
        /// <summary>
        /// Constant S3 for ConnectionType
        /// </summary>
        public static readonly ConnectionType S3 = new ConnectionType("S3");
        /// <summary>
        /// Constant SAPHANA for ConnectionType
        /// </summary>
        public static readonly ConnectionType SAPHANA = new ConnectionType("SAPHANA");
        /// <summary>
        /// Constant SNOWFLAKE for ConnectionType
        /// </summary>
        public static readonly ConnectionType SNOWFLAKE = new ConnectionType("SNOWFLAKE");
        /// <summary>
        /// Constant SPARK for ConnectionType
        /// </summary>
        public static readonly ConnectionType SPARK = new ConnectionType("SPARK");
        /// <summary>
        /// Constant SQLSERVER for ConnectionType
        /// </summary>
        public static readonly ConnectionType SQLSERVER = new ConnectionType("SQLSERVER");
        /// <summary>
        /// Constant TERADATA for ConnectionType
        /// </summary>
        public static readonly ConnectionType TERADATA = new ConnectionType("TERADATA");
        /// <summary>
        /// Constant VERTICA for ConnectionType
        /// </summary>
        public static readonly ConnectionType VERTICA = new ConnectionType("VERTICA");
        /// <summary>
        /// Constant WORKFLOWS_MWAA for ConnectionType
        /// </summary>
        public static readonly ConnectionType WORKFLOWS_MWAA = new ConnectionType("WORKFLOWS_MWAA");

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
    /// Constants used for properties of type DataAssetActivityStatus.
    /// </summary>
    public class DataAssetActivityStatus : ConstantClass
    {

        /// <summary>
        /// Constant FAILED for DataAssetActivityStatus
        /// </summary>
        public static readonly DataAssetActivityStatus FAILED = new DataAssetActivityStatus("FAILED");
        /// <summary>
        /// Constant PUBLISHING_FAILED for DataAssetActivityStatus
        /// </summary>
        public static readonly DataAssetActivityStatus PUBLISHING_FAILED = new DataAssetActivityStatus("PUBLISHING_FAILED");
        /// <summary>
        /// Constant SKIPPED_ALREADY_IMPORTED for DataAssetActivityStatus
        /// </summary>
        public static readonly DataAssetActivityStatus SKIPPED_ALREADY_IMPORTED = new DataAssetActivityStatus("SKIPPED_ALREADY_IMPORTED");
        /// <summary>
        /// Constant SKIPPED_ARCHIVED for DataAssetActivityStatus
        /// </summary>
        public static readonly DataAssetActivityStatus SKIPPED_ARCHIVED = new DataAssetActivityStatus("SKIPPED_ARCHIVED");
        /// <summary>
        /// Constant SKIPPED_NO_ACCESS for DataAssetActivityStatus
        /// </summary>
        public static readonly DataAssetActivityStatus SKIPPED_NO_ACCESS = new DataAssetActivityStatus("SKIPPED_NO_ACCESS");
        /// <summary>
        /// Constant SUCCEEDED_CREATED for DataAssetActivityStatus
        /// </summary>
        public static readonly DataAssetActivityStatus SUCCEEDED_CREATED = new DataAssetActivityStatus("SUCCEEDED_CREATED");
        /// <summary>
        /// Constant SUCCEEDED_UPDATED for DataAssetActivityStatus
        /// </summary>
        public static readonly DataAssetActivityStatus SUCCEEDED_UPDATED = new DataAssetActivityStatus("SUCCEEDED_UPDATED");
        /// <summary>
        /// Constant UNCHANGED for DataAssetActivityStatus
        /// </summary>
        public static readonly DataAssetActivityStatus UNCHANGED = new DataAssetActivityStatus("UNCHANGED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DataAssetActivityStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DataAssetActivityStatus FindValue(string value)
        {
            return FindValue<DataAssetActivityStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DataAssetActivityStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DataProductItemType.
    /// </summary>
    public class DataProductItemType : ConstantClass
    {

        /// <summary>
        /// Constant ASSET for DataProductItemType
        /// </summary>
        public static readonly DataProductItemType ASSET = new DataProductItemType("ASSET");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DataProductItemType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DataProductItemType FindValue(string value)
        {
            return FindValue<DataProductItemType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DataProductItemType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DataProductStatus.
    /// </summary>
    public class DataProductStatus : ConstantClass
    {

        /// <summary>
        /// Constant CREATE_FAILED for DataProductStatus
        /// </summary>
        public static readonly DataProductStatus CREATE_FAILED = new DataProductStatus("CREATE_FAILED");
        /// <summary>
        /// Constant CREATED for DataProductStatus
        /// </summary>
        public static readonly DataProductStatus CREATED = new DataProductStatus("CREATED");
        /// <summary>
        /// Constant CREATING for DataProductStatus
        /// </summary>
        public static readonly DataProductStatus CREATING = new DataProductStatus("CREATING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DataProductStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DataProductStatus FindValue(string value)
        {
            return FindValue<DataProductStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DataProductStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DataSourceErrorType.
    /// </summary>
    public class DataSourceErrorType : ConstantClass
    {

        /// <summary>
        /// Constant ACCESS_DENIED_EXCEPTION for DataSourceErrorType
        /// </summary>
        public static readonly DataSourceErrorType ACCESS_DENIED_EXCEPTION = new DataSourceErrorType("ACCESS_DENIED_EXCEPTION");
        /// <summary>
        /// Constant CONFLICT_EXCEPTION for DataSourceErrorType
        /// </summary>
        public static readonly DataSourceErrorType CONFLICT_EXCEPTION = new DataSourceErrorType("CONFLICT_EXCEPTION");
        /// <summary>
        /// Constant INTERNAL_SERVER_EXCEPTION for DataSourceErrorType
        /// </summary>
        public static readonly DataSourceErrorType INTERNAL_SERVER_EXCEPTION = new DataSourceErrorType("INTERNAL_SERVER_EXCEPTION");
        /// <summary>
        /// Constant RESOURCE_NOT_FOUND_EXCEPTION for DataSourceErrorType
        /// </summary>
        public static readonly DataSourceErrorType RESOURCE_NOT_FOUND_EXCEPTION = new DataSourceErrorType("RESOURCE_NOT_FOUND_EXCEPTION");
        /// <summary>
        /// Constant SERVICE_QUOTA_EXCEEDED_EXCEPTION for DataSourceErrorType
        /// </summary>
        public static readonly DataSourceErrorType SERVICE_QUOTA_EXCEEDED_EXCEPTION = new DataSourceErrorType("SERVICE_QUOTA_EXCEEDED_EXCEPTION");
        /// <summary>
        /// Constant THROTTLING_EXCEPTION for DataSourceErrorType
        /// </summary>
        public static readonly DataSourceErrorType THROTTLING_EXCEPTION = new DataSourceErrorType("THROTTLING_EXCEPTION");
        /// <summary>
        /// Constant VALIDATION_EXCEPTION for DataSourceErrorType
        /// </summary>
        public static readonly DataSourceErrorType VALIDATION_EXCEPTION = new DataSourceErrorType("VALIDATION_EXCEPTION");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DataSourceErrorType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DataSourceErrorType FindValue(string value)
        {
            return FindValue<DataSourceErrorType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DataSourceErrorType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DataSourceRunStatus.
    /// </summary>
    public class DataSourceRunStatus : ConstantClass
    {

        /// <summary>
        /// Constant FAILED for DataSourceRunStatus
        /// </summary>
        public static readonly DataSourceRunStatus FAILED = new DataSourceRunStatus("FAILED");
        /// <summary>
        /// Constant PARTIALLY_SUCCEEDED for DataSourceRunStatus
        /// </summary>
        public static readonly DataSourceRunStatus PARTIALLY_SUCCEEDED = new DataSourceRunStatus("PARTIALLY_SUCCEEDED");
        /// <summary>
        /// Constant REQUESTED for DataSourceRunStatus
        /// </summary>
        public static readonly DataSourceRunStatus REQUESTED = new DataSourceRunStatus("REQUESTED");
        /// <summary>
        /// Constant RUNNING for DataSourceRunStatus
        /// </summary>
        public static readonly DataSourceRunStatus RUNNING = new DataSourceRunStatus("RUNNING");
        /// <summary>
        /// Constant SUCCESS for DataSourceRunStatus
        /// </summary>
        public static readonly DataSourceRunStatus SUCCESS = new DataSourceRunStatus("SUCCESS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DataSourceRunStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DataSourceRunStatus FindValue(string value)
        {
            return FindValue<DataSourceRunStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DataSourceRunStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DataSourceRunType.
    /// </summary>
    public class DataSourceRunType : ConstantClass
    {

        /// <summary>
        /// Constant PRIORITIZED for DataSourceRunType
        /// </summary>
        public static readonly DataSourceRunType PRIORITIZED = new DataSourceRunType("PRIORITIZED");
        /// <summary>
        /// Constant SCHEDULED for DataSourceRunType
        /// </summary>
        public static readonly DataSourceRunType SCHEDULED = new DataSourceRunType("SCHEDULED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DataSourceRunType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DataSourceRunType FindValue(string value)
        {
            return FindValue<DataSourceRunType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DataSourceRunType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DataSourceStatus.
    /// </summary>
    public class DataSourceStatus : ConstantClass
    {

        /// <summary>
        /// Constant CREATING for DataSourceStatus
        /// </summary>
        public static readonly DataSourceStatus CREATING = new DataSourceStatus("CREATING");
        /// <summary>
        /// Constant DELETING for DataSourceStatus
        /// </summary>
        public static readonly DataSourceStatus DELETING = new DataSourceStatus("DELETING");
        /// <summary>
        /// Constant FAILED_CREATION for DataSourceStatus
        /// </summary>
        public static readonly DataSourceStatus FAILED_CREATION = new DataSourceStatus("FAILED_CREATION");
        /// <summary>
        /// Constant FAILED_DELETION for DataSourceStatus
        /// </summary>
        public static readonly DataSourceStatus FAILED_DELETION = new DataSourceStatus("FAILED_DELETION");
        /// <summary>
        /// Constant FAILED_UPDATE for DataSourceStatus
        /// </summary>
        public static readonly DataSourceStatus FAILED_UPDATE = new DataSourceStatus("FAILED_UPDATE");
        /// <summary>
        /// Constant READY for DataSourceStatus
        /// </summary>
        public static readonly DataSourceStatus READY = new DataSourceStatus("READY");
        /// <summary>
        /// Constant RUNNING for DataSourceStatus
        /// </summary>
        public static readonly DataSourceStatus RUNNING = new DataSourceStatus("RUNNING");
        /// <summary>
        /// Constant UPDATING for DataSourceStatus
        /// </summary>
        public static readonly DataSourceStatus UPDATING = new DataSourceStatus("UPDATING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DataSourceStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DataSourceStatus FindValue(string value)
        {
            return FindValue<DataSourceStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DataSourceStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DataZoneEntityType.
    /// </summary>
    public class DataZoneEntityType : ConstantClass
    {

        /// <summary>
        /// Constant DOMAIN_UNIT for DataZoneEntityType
        /// </summary>
        public static readonly DataZoneEntityType DOMAIN_UNIT = new DataZoneEntityType("DOMAIN_UNIT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DataZoneEntityType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DataZoneEntityType FindValue(string value)
        {
            return FindValue<DataZoneEntityType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DataZoneEntityType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DeploymentMode.
    /// </summary>
    public class DeploymentMode : ConstantClass
    {

        /// <summary>
        /// Constant ON_CREATE for DeploymentMode
        /// </summary>
        public static readonly DeploymentMode ON_CREATE = new DeploymentMode("ON_CREATE");
        /// <summary>
        /// Constant ON_DEMAND for DeploymentMode
        /// </summary>
        public static readonly DeploymentMode ON_DEMAND = new DeploymentMode("ON_DEMAND");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DeploymentMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DeploymentMode FindValue(string value)
        {
            return FindValue<DeploymentMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DeploymentMode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DeploymentStatus.
    /// </summary>
    public class DeploymentStatus : ConstantClass
    {

        /// <summary>
        /// Constant FAILED for DeploymentStatus
        /// </summary>
        public static readonly DeploymentStatus FAILED = new DeploymentStatus("FAILED");
        /// <summary>
        /// Constant IN_PROGRESS for DeploymentStatus
        /// </summary>
        public static readonly DeploymentStatus IN_PROGRESS = new DeploymentStatus("IN_PROGRESS");
        /// <summary>
        /// Constant PENDING_DEPLOYMENT for DeploymentStatus
        /// </summary>
        public static readonly DeploymentStatus PENDING_DEPLOYMENT = new DeploymentStatus("PENDING_DEPLOYMENT");
        /// <summary>
        /// Constant SUCCESSFUL for DeploymentStatus
        /// </summary>
        public static readonly DeploymentStatus SUCCESSFUL = new DeploymentStatus("SUCCESSFUL");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DeploymentStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DeploymentStatus FindValue(string value)
        {
            return FindValue<DeploymentStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DeploymentStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DeploymentType.
    /// </summary>
    public class DeploymentType : ConstantClass
    {

        /// <summary>
        /// Constant CREATE for DeploymentType
        /// </summary>
        public static readonly DeploymentType CREATE = new DeploymentType("CREATE");
        /// <summary>
        /// Constant DELETE for DeploymentType
        /// </summary>
        public static readonly DeploymentType DELETE = new DeploymentType("DELETE");
        /// <summary>
        /// Constant UPDATE for DeploymentType
        /// </summary>
        public static readonly DeploymentType UPDATE = new DeploymentType("UPDATE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DeploymentType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DeploymentType FindValue(string value)
        {
            return FindValue<DeploymentType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DeploymentType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DomainStatus.
    /// </summary>
    public class DomainStatus : ConstantClass
    {

        /// <summary>
        /// Constant AVAILABLE for DomainStatus
        /// </summary>
        public static readonly DomainStatus AVAILABLE = new DomainStatus("AVAILABLE");
        /// <summary>
        /// Constant CREATING for DomainStatus
        /// </summary>
        public static readonly DomainStatus CREATING = new DomainStatus("CREATING");
        /// <summary>
        /// Constant CREATION_FAILED for DomainStatus
        /// </summary>
        public static readonly DomainStatus CREATION_FAILED = new DomainStatus("CREATION_FAILED");
        /// <summary>
        /// Constant DELETED for DomainStatus
        /// </summary>
        public static readonly DomainStatus DELETED = new DomainStatus("DELETED");
        /// <summary>
        /// Constant DELETING for DomainStatus
        /// </summary>
        public static readonly DomainStatus DELETING = new DomainStatus("DELETING");
        /// <summary>
        /// Constant DELETION_FAILED for DomainStatus
        /// </summary>
        public static readonly DomainStatus DELETION_FAILED = new DomainStatus("DELETION_FAILED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DomainStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DomainStatus FindValue(string value)
        {
            return FindValue<DomainStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DomainStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DomainUnitDesignation.
    /// </summary>
    public class DomainUnitDesignation : ConstantClass
    {

        /// <summary>
        /// Constant OWNER for DomainUnitDesignation
        /// </summary>
        public static readonly DomainUnitDesignation OWNER = new DomainUnitDesignation("OWNER");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DomainUnitDesignation(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DomainUnitDesignation FindValue(string value)
        {
            return FindValue<DomainUnitDesignation>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DomainUnitDesignation(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DomainVersion.
    /// </summary>
    public class DomainVersion : ConstantClass
    {

        /// <summary>
        /// Constant V1 for DomainVersion
        /// </summary>
        public static readonly DomainVersion V1 = new DomainVersion("V1");
        /// <summary>
        /// Constant V2 for DomainVersion
        /// </summary>
        public static readonly DomainVersion V2 = new DomainVersion("V2");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DomainVersion(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DomainVersion FindValue(string value)
        {
            return FindValue<DomainVersion>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DomainVersion(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type EdgeDirection.
    /// </summary>
    public class EdgeDirection : ConstantClass
    {

        /// <summary>
        /// Constant DOWNSTREAM for EdgeDirection
        /// </summary>
        public static readonly EdgeDirection DOWNSTREAM = new EdgeDirection("DOWNSTREAM");
        /// <summary>
        /// Constant UPSTREAM for EdgeDirection
        /// </summary>
        public static readonly EdgeDirection UPSTREAM = new EdgeDirection("UPSTREAM");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EdgeDirection(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EdgeDirection FindValue(string value)
        {
            return FindValue<EdgeDirection>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EdgeDirection(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type EnableSetting.
    /// </summary>
    public class EnableSetting : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for EnableSetting
        /// </summary>
        public static readonly EnableSetting DISABLED = new EnableSetting("DISABLED");
        /// <summary>
        /// Constant ENABLED for EnableSetting
        /// </summary>
        public static readonly EnableSetting ENABLED = new EnableSetting("ENABLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EnableSetting(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EnableSetting FindValue(string value)
        {
            return FindValue<EnableSetting>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EnableSetting(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type EntityType.
    /// </summary>
    public class EntityType : ConstantClass
    {

        /// <summary>
        /// Constant ASSET for EntityType
        /// </summary>
        public static readonly EntityType ASSET = new EntityType("ASSET");
        /// <summary>
        /// Constant DATA_PRODUCT for EntityType
        /// </summary>
        public static readonly EntityType DATA_PRODUCT = new EntityType("DATA_PRODUCT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EntityType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EntityType FindValue(string value)
        {
            return FindValue<EntityType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EntityType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type EnvironmentStatus.
    /// </summary>
    public class EnvironmentStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for EnvironmentStatus
        /// </summary>
        public static readonly EnvironmentStatus ACTIVE = new EnvironmentStatus("ACTIVE");
        /// <summary>
        /// Constant CREATE_FAILED for EnvironmentStatus
        /// </summary>
        public static readonly EnvironmentStatus CREATE_FAILED = new EnvironmentStatus("CREATE_FAILED");
        /// <summary>
        /// Constant CREATING for EnvironmentStatus
        /// </summary>
        public static readonly EnvironmentStatus CREATING = new EnvironmentStatus("CREATING");
        /// <summary>
        /// Constant DELETE_FAILED for EnvironmentStatus
        /// </summary>
        public static readonly EnvironmentStatus DELETE_FAILED = new EnvironmentStatus("DELETE_FAILED");
        /// <summary>
        /// Constant DELETED for EnvironmentStatus
        /// </summary>
        public static readonly EnvironmentStatus DELETED = new EnvironmentStatus("DELETED");
        /// <summary>
        /// Constant DELETING for EnvironmentStatus
        /// </summary>
        public static readonly EnvironmentStatus DELETING = new EnvironmentStatus("DELETING");
        /// <summary>
        /// Constant DISABLED for EnvironmentStatus
        /// </summary>
        public static readonly EnvironmentStatus DISABLED = new EnvironmentStatus("DISABLED");
        /// <summary>
        /// Constant EXPIRED for EnvironmentStatus
        /// </summary>
        public static readonly EnvironmentStatus EXPIRED = new EnvironmentStatus("EXPIRED");
        /// <summary>
        /// Constant INACCESSIBLE for EnvironmentStatus
        /// </summary>
        public static readonly EnvironmentStatus INACCESSIBLE = new EnvironmentStatus("INACCESSIBLE");
        /// <summary>
        /// Constant SUSPENDED for EnvironmentStatus
        /// </summary>
        public static readonly EnvironmentStatus SUSPENDED = new EnvironmentStatus("SUSPENDED");
        /// <summary>
        /// Constant UPDATE_FAILED for EnvironmentStatus
        /// </summary>
        public static readonly EnvironmentStatus UPDATE_FAILED = new EnvironmentStatus("UPDATE_FAILED");
        /// <summary>
        /// Constant UPDATING for EnvironmentStatus
        /// </summary>
        public static readonly EnvironmentStatus UPDATING = new EnvironmentStatus("UPDATING");
        /// <summary>
        /// Constant VALIDATION_FAILED for EnvironmentStatus
        /// </summary>
        public static readonly EnvironmentStatus VALIDATION_FAILED = new EnvironmentStatus("VALIDATION_FAILED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EnvironmentStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EnvironmentStatus FindValue(string value)
        {
            return FindValue<EnvironmentStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EnvironmentStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type FilterExpressionType.
    /// </summary>
    public class FilterExpressionType : ConstantClass
    {

        /// <summary>
        /// Constant EXCLUDE for FilterExpressionType
        /// </summary>
        public static readonly FilterExpressionType EXCLUDE = new FilterExpressionType("EXCLUDE");
        /// <summary>
        /// Constant INCLUDE for FilterExpressionType
        /// </summary>
        public static readonly FilterExpressionType INCLUDE = new FilterExpressionType("INCLUDE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FilterExpressionType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FilterExpressionType FindValue(string value)
        {
            return FindValue<FilterExpressionType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FilterExpressionType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type FilterStatus.
    /// </summary>
    public class FilterStatus : ConstantClass
    {

        /// <summary>
        /// Constant INVALID for FilterStatus
        /// </summary>
        public static readonly FilterStatus INVALID = new FilterStatus("INVALID");
        /// <summary>
        /// Constant VALID for FilterStatus
        /// </summary>
        public static readonly FilterStatus VALID = new FilterStatus("VALID");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FilterStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FilterStatus FindValue(string value)
        {
            return FindValue<FilterStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FilterStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type FormTypeStatus.
    /// </summary>
    public class FormTypeStatus : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for FormTypeStatus
        /// </summary>
        public static readonly FormTypeStatus DISABLED = new FormTypeStatus("DISABLED");
        /// <summary>
        /// Constant ENABLED for FormTypeStatus
        /// </summary>
        public static readonly FormTypeStatus ENABLED = new FormTypeStatus("ENABLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FormTypeStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FormTypeStatus FindValue(string value)
        {
            return FindValue<FormTypeStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FormTypeStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type GlossaryStatus.
    /// </summary>
    public class GlossaryStatus : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for GlossaryStatus
        /// </summary>
        public static readonly GlossaryStatus DISABLED = new GlossaryStatus("DISABLED");
        /// <summary>
        /// Constant ENABLED for GlossaryStatus
        /// </summary>
        public static readonly GlossaryStatus ENABLED = new GlossaryStatus("ENABLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public GlossaryStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static GlossaryStatus FindValue(string value)
        {
            return FindValue<GlossaryStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator GlossaryStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type GlossaryTermStatus.
    /// </summary>
    public class GlossaryTermStatus : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for GlossaryTermStatus
        /// </summary>
        public static readonly GlossaryTermStatus DISABLED = new GlossaryTermStatus("DISABLED");
        /// <summary>
        /// Constant ENABLED for GlossaryTermStatus
        /// </summary>
        public static readonly GlossaryTermStatus ENABLED = new GlossaryTermStatus("ENABLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public GlossaryTermStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static GlossaryTermStatus FindValue(string value)
        {
            return FindValue<GlossaryTermStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator GlossaryTermStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type GlossaryUsageRestriction.
    /// </summary>
    public class GlossaryUsageRestriction : ConstantClass
    {

        /// <summary>
        /// Constant ASSET_GOVERNED_TERMS for GlossaryUsageRestriction
        /// </summary>
        public static readonly GlossaryUsageRestriction ASSET_GOVERNED_TERMS = new GlossaryUsageRestriction("ASSET_GOVERNED_TERMS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public GlossaryUsageRestriction(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static GlossaryUsageRestriction FindValue(string value)
        {
            return FindValue<GlossaryUsageRestriction>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator GlossaryUsageRestriction(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type GlueConnectionType.
    /// </summary>
    public class GlueConnectionType : ConstantClass
    {

        /// <summary>
        /// Constant BIGQUERY for GlueConnectionType
        /// </summary>
        public static readonly GlueConnectionType BIGQUERY = new GlueConnectionType("BIGQUERY");
        /// <summary>
        /// Constant DOCUMENTDB for GlueConnectionType
        /// </summary>
        public static readonly GlueConnectionType DOCUMENTDB = new GlueConnectionType("DOCUMENTDB");
        /// <summary>
        /// Constant DYNAMODB for GlueConnectionType
        /// </summary>
        public static readonly GlueConnectionType DYNAMODB = new GlueConnectionType("DYNAMODB");
        /// <summary>
        /// Constant MYSQL for GlueConnectionType
        /// </summary>
        public static readonly GlueConnectionType MYSQL = new GlueConnectionType("MYSQL");
        /// <summary>
        /// Constant OPENSEARCH for GlueConnectionType
        /// </summary>
        public static readonly GlueConnectionType OPENSEARCH = new GlueConnectionType("OPENSEARCH");
        /// <summary>
        /// Constant ORACLE for GlueConnectionType
        /// </summary>
        public static readonly GlueConnectionType ORACLE = new GlueConnectionType("ORACLE");
        /// <summary>
        /// Constant POSTGRESQL for GlueConnectionType
        /// </summary>
        public static readonly GlueConnectionType POSTGRESQL = new GlueConnectionType("POSTGRESQL");
        /// <summary>
        /// Constant REDSHIFT for GlueConnectionType
        /// </summary>
        public static readonly GlueConnectionType REDSHIFT = new GlueConnectionType("REDSHIFT");
        /// <summary>
        /// Constant SAPHANA for GlueConnectionType
        /// </summary>
        public static readonly GlueConnectionType SAPHANA = new GlueConnectionType("SAPHANA");
        /// <summary>
        /// Constant SNOWFLAKE for GlueConnectionType
        /// </summary>
        public static readonly GlueConnectionType SNOWFLAKE = new GlueConnectionType("SNOWFLAKE");
        /// <summary>
        /// Constant SQLSERVER for GlueConnectionType
        /// </summary>
        public static readonly GlueConnectionType SQLSERVER = new GlueConnectionType("SQLSERVER");
        /// <summary>
        /// Constant TERADATA for GlueConnectionType
        /// </summary>
        public static readonly GlueConnectionType TERADATA = new GlueConnectionType("TERADATA");
        /// <summary>
        /// Constant VERTICA for GlueConnectionType
        /// </summary>
        public static readonly GlueConnectionType VERTICA = new GlueConnectionType("VERTICA");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public GlueConnectionType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static GlueConnectionType FindValue(string value)
        {
            return FindValue<GlueConnectionType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator GlueConnectionType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type GovernanceType.
    /// </summary>
    public class GovernanceType : ConstantClass
    {

        /// <summary>
        /// Constant AWS_MANAGED for GovernanceType
        /// </summary>
        public static readonly GovernanceType AWS_MANAGED = new GovernanceType("AWS_MANAGED");
        /// <summary>
        /// Constant USER_MANAGED for GovernanceType
        /// </summary>
        public static readonly GovernanceType USER_MANAGED = new GovernanceType("USER_MANAGED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public GovernanceType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static GovernanceType FindValue(string value)
        {
            return FindValue<GovernanceType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator GovernanceType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type GovernedEntityType.
    /// </summary>
    public class GovernedEntityType : ConstantClass
    {

        /// <summary>
        /// Constant ASSET for GovernedEntityType
        /// </summary>
        public static readonly GovernedEntityType ASSET = new GovernedEntityType("ASSET");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public GovernedEntityType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static GovernedEntityType FindValue(string value)
        {
            return FindValue<GovernedEntityType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator GovernedEntityType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type GroupProfileStatus.
    /// </summary>
    public class GroupProfileStatus : ConstantClass
    {

        /// <summary>
        /// Constant ASSIGNED for GroupProfileStatus
        /// </summary>
        public static readonly GroupProfileStatus ASSIGNED = new GroupProfileStatus("ASSIGNED");
        /// <summary>
        /// Constant NOT_ASSIGNED for GroupProfileStatus
        /// </summary>
        public static readonly GroupProfileStatus NOT_ASSIGNED = new GroupProfileStatus("NOT_ASSIGNED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public GroupProfileStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static GroupProfileStatus FindValue(string value)
        {
            return FindValue<GroupProfileStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator GroupProfileStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type GroupSearchType.
    /// </summary>
    public class GroupSearchType : ConstantClass
    {

        /// <summary>
        /// Constant DATAZONE_SSO_GROUP for GroupSearchType
        /// </summary>
        public static readonly GroupSearchType DATAZONE_SSO_GROUP = new GroupSearchType("DATAZONE_SSO_GROUP");
        /// <summary>
        /// Constant SSO_GROUP for GroupSearchType
        /// </summary>
        public static readonly GroupSearchType SSO_GROUP = new GroupSearchType("SSO_GROUP");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public GroupSearchType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static GroupSearchType FindValue(string value)
        {
            return FindValue<GroupSearchType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator GroupSearchType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type HyperPodOrchestrator.
    /// </summary>
    public class HyperPodOrchestrator : ConstantClass
    {

        /// <summary>
        /// Constant EKS for HyperPodOrchestrator
        /// </summary>
        public static readonly HyperPodOrchestrator EKS = new HyperPodOrchestrator("EKS");
        /// <summary>
        /// Constant SLURM for HyperPodOrchestrator
        /// </summary>
        public static readonly HyperPodOrchestrator SLURM = new HyperPodOrchestrator("SLURM");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public HyperPodOrchestrator(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static HyperPodOrchestrator FindValue(string value)
        {
            return FindValue<HyperPodOrchestrator>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator HyperPodOrchestrator(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type InventorySearchScope.
    /// </summary>
    public class InventorySearchScope : ConstantClass
    {

        /// <summary>
        /// Constant ASSET for InventorySearchScope
        /// </summary>
        public static readonly InventorySearchScope ASSET = new InventorySearchScope("ASSET");
        /// <summary>
        /// Constant DATA_PRODUCT for InventorySearchScope
        /// </summary>
        public static readonly InventorySearchScope DATA_PRODUCT = new InventorySearchScope("DATA_PRODUCT");
        /// <summary>
        /// Constant GLOSSARY for InventorySearchScope
        /// </summary>
        public static readonly InventorySearchScope GLOSSARY = new InventorySearchScope("GLOSSARY");
        /// <summary>
        /// Constant GLOSSARY_TERM for InventorySearchScope
        /// </summary>
        public static readonly InventorySearchScope GLOSSARY_TERM = new InventorySearchScope("GLOSSARY_TERM");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public InventorySearchScope(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static InventorySearchScope FindValue(string value)
        {
            return FindValue<InventorySearchScope>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator InventorySearchScope(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type JobRunMode.
    /// </summary>
    public class JobRunMode : ConstantClass
    {

        /// <summary>
        /// Constant ON_DEMAND for JobRunMode
        /// </summary>
        public static readonly JobRunMode ON_DEMAND = new JobRunMode("ON_DEMAND");
        /// <summary>
        /// Constant SCHEDULED for JobRunMode
        /// </summary>
        public static readonly JobRunMode SCHEDULED = new JobRunMode("SCHEDULED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public JobRunMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static JobRunMode FindValue(string value)
        {
            return FindValue<JobRunMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator JobRunMode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type JobRunStatus.
    /// </summary>
    public class JobRunStatus : ConstantClass
    {

        /// <summary>
        /// Constant ABORTED for JobRunStatus
        /// </summary>
        public static readonly JobRunStatus ABORTED = new JobRunStatus("ABORTED");
        /// <summary>
        /// Constant CANCELED for JobRunStatus
        /// </summary>
        public static readonly JobRunStatus CANCELED = new JobRunStatus("CANCELED");
        /// <summary>
        /// Constant FAILED for JobRunStatus
        /// </summary>
        public static readonly JobRunStatus FAILED = new JobRunStatus("FAILED");
        /// <summary>
        /// Constant IN_PROGRESS for JobRunStatus
        /// </summary>
        public static readonly JobRunStatus IN_PROGRESS = new JobRunStatus("IN_PROGRESS");
        /// <summary>
        /// Constant PARTIALLY_SUCCEEDED for JobRunStatus
        /// </summary>
        public static readonly JobRunStatus PARTIALLY_SUCCEEDED = new JobRunStatus("PARTIALLY_SUCCEEDED");
        /// <summary>
        /// Constant SCHEDULED for JobRunStatus
        /// </summary>
        public static readonly JobRunStatus SCHEDULED = new JobRunStatus("SCHEDULED");
        /// <summary>
        /// Constant SUCCESS for JobRunStatus
        /// </summary>
        public static readonly JobRunStatus SUCCESS = new JobRunStatus("SUCCESS");
        /// <summary>
        /// Constant TIMED_OUT for JobRunStatus
        /// </summary>
        public static readonly JobRunStatus TIMED_OUT = new JobRunStatus("TIMED_OUT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public JobRunStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static JobRunStatus FindValue(string value)
        {
            return FindValue<JobRunStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator JobRunStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type JobType.
    /// </summary>
    public class JobType : ConstantClass
    {

        /// <summary>
        /// Constant LINEAGE for JobType
        /// </summary>
        public static readonly JobType LINEAGE = new JobType("LINEAGE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public JobType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static JobType FindValue(string value)
        {
            return FindValue<JobType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator JobType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type LineageEventProcessingStatus.
    /// </summary>
    public class LineageEventProcessingStatus : ConstantClass
    {

        /// <summary>
        /// Constant FAILED for LineageEventProcessingStatus
        /// </summary>
        public static readonly LineageEventProcessingStatus FAILED = new LineageEventProcessingStatus("FAILED");
        /// <summary>
        /// Constant PROCESSING for LineageEventProcessingStatus
        /// </summary>
        public static readonly LineageEventProcessingStatus PROCESSING = new LineageEventProcessingStatus("PROCESSING");
        /// <summary>
        /// Constant REQUESTED for LineageEventProcessingStatus
        /// </summary>
        public static readonly LineageEventProcessingStatus REQUESTED = new LineageEventProcessingStatus("REQUESTED");
        /// <summary>
        /// Constant SUCCESS for LineageEventProcessingStatus
        /// </summary>
        public static readonly LineageEventProcessingStatus SUCCESS = new LineageEventProcessingStatus("SUCCESS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public LineageEventProcessingStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LineageEventProcessingStatus FindValue(string value)
        {
            return FindValue<LineageEventProcessingStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator LineageEventProcessingStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type LineageImportStatus.
    /// </summary>
    public class LineageImportStatus : ConstantClass
    {

        /// <summary>
        /// Constant FAILED for LineageImportStatus
        /// </summary>
        public static readonly LineageImportStatus FAILED = new LineageImportStatus("FAILED");
        /// <summary>
        /// Constant IN_PROGRESS for LineageImportStatus
        /// </summary>
        public static readonly LineageImportStatus IN_PROGRESS = new LineageImportStatus("IN_PROGRESS");
        /// <summary>
        /// Constant PARTIALLY_SUCCEEDED for LineageImportStatus
        /// </summary>
        public static readonly LineageImportStatus PARTIALLY_SUCCEEDED = new LineageImportStatus("PARTIALLY_SUCCEEDED");
        /// <summary>
        /// Constant SUCCESS for LineageImportStatus
        /// </summary>
        public static readonly LineageImportStatus SUCCESS = new LineageImportStatus("SUCCESS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public LineageImportStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LineageImportStatus FindValue(string value)
        {
            return FindValue<LineageImportStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator LineageImportStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ListingStatus.
    /// </summary>
    public class ListingStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for ListingStatus
        /// </summary>
        public static readonly ListingStatus ACTIVE = new ListingStatus("ACTIVE");
        /// <summary>
        /// Constant CREATING for ListingStatus
        /// </summary>
        public static readonly ListingStatus CREATING = new ListingStatus("CREATING");
        /// <summary>
        /// Constant INACTIVE for ListingStatus
        /// </summary>
        public static readonly ListingStatus INACTIVE = new ListingStatus("INACTIVE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ListingStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ListingStatus FindValue(string value)
        {
            return FindValue<ListingStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ListingStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ManagedPolicyType.
    /// </summary>
    public class ManagedPolicyType : ConstantClass
    {

        /// <summary>
        /// Constant ADD_TO_PROJECT_MEMBER_POOL for ManagedPolicyType
        /// </summary>
        public static readonly ManagedPolicyType ADD_TO_PROJECT_MEMBER_POOL = new ManagedPolicyType("ADD_TO_PROJECT_MEMBER_POOL");
        /// <summary>
        /// Constant CREATE_ASSET_TYPE for ManagedPolicyType
        /// </summary>
        public static readonly ManagedPolicyType CREATE_ASSET_TYPE = new ManagedPolicyType("CREATE_ASSET_TYPE");
        /// <summary>
        /// Constant CREATE_DOMAIN_UNIT for ManagedPolicyType
        /// </summary>
        public static readonly ManagedPolicyType CREATE_DOMAIN_UNIT = new ManagedPolicyType("CREATE_DOMAIN_UNIT");
        /// <summary>
        /// Constant CREATE_ENVIRONMENT for ManagedPolicyType
        /// </summary>
        public static readonly ManagedPolicyType CREATE_ENVIRONMENT = new ManagedPolicyType("CREATE_ENVIRONMENT");
        /// <summary>
        /// Constant CREATE_ENVIRONMENT_FROM_BLUEPRINT for ManagedPolicyType
        /// </summary>
        public static readonly ManagedPolicyType CREATE_ENVIRONMENT_FROM_BLUEPRINT = new ManagedPolicyType("CREATE_ENVIRONMENT_FROM_BLUEPRINT");
        /// <summary>
        /// Constant CREATE_ENVIRONMENT_PROFILE for ManagedPolicyType
        /// </summary>
        public static readonly ManagedPolicyType CREATE_ENVIRONMENT_PROFILE = new ManagedPolicyType("CREATE_ENVIRONMENT_PROFILE");
        /// <summary>
        /// Constant CREATE_FORM_TYPE for ManagedPolicyType
        /// </summary>
        public static readonly ManagedPolicyType CREATE_FORM_TYPE = new ManagedPolicyType("CREATE_FORM_TYPE");
        /// <summary>
        /// Constant CREATE_GLOSSARY for ManagedPolicyType
        /// </summary>
        public static readonly ManagedPolicyType CREATE_GLOSSARY = new ManagedPolicyType("CREATE_GLOSSARY");
        /// <summary>
        /// Constant CREATE_PROJECT for ManagedPolicyType
        /// </summary>
        public static readonly ManagedPolicyType CREATE_PROJECT = new ManagedPolicyType("CREATE_PROJECT");
        /// <summary>
        /// Constant CREATE_PROJECT_FROM_PROJECT_PROFILE for ManagedPolicyType
        /// </summary>
        public static readonly ManagedPolicyType CREATE_PROJECT_FROM_PROJECT_PROFILE = new ManagedPolicyType("CREATE_PROJECT_FROM_PROJECT_PROFILE");
        /// <summary>
        /// Constant DELEGATE_CREATE_ENVIRONMENT_PROFILE for ManagedPolicyType
        /// </summary>
        public static readonly ManagedPolicyType DELEGATE_CREATE_ENVIRONMENT_PROFILE = new ManagedPolicyType("DELEGATE_CREATE_ENVIRONMENT_PROFILE");
        /// <summary>
        /// Constant OVERRIDE_DOMAIN_UNIT_OWNERS for ManagedPolicyType
        /// </summary>
        public static readonly ManagedPolicyType OVERRIDE_DOMAIN_UNIT_OWNERS = new ManagedPolicyType("OVERRIDE_DOMAIN_UNIT_OWNERS");
        /// <summary>
        /// Constant OVERRIDE_PROJECT_OWNERS for ManagedPolicyType
        /// </summary>
        public static readonly ManagedPolicyType OVERRIDE_PROJECT_OWNERS = new ManagedPolicyType("OVERRIDE_PROJECT_OWNERS");
        /// <summary>
        /// Constant USE_ASSET_TYPE for ManagedPolicyType
        /// </summary>
        public static readonly ManagedPolicyType USE_ASSET_TYPE = new ManagedPolicyType("USE_ASSET_TYPE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ManagedPolicyType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ManagedPolicyType FindValue(string value)
        {
            return FindValue<ManagedPolicyType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ManagedPolicyType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type MetadataGenerationRunStatus.
    /// </summary>
    public class MetadataGenerationRunStatus : ConstantClass
    {

        /// <summary>
        /// Constant CANCELED for MetadataGenerationRunStatus
        /// </summary>
        public static readonly MetadataGenerationRunStatus CANCELED = new MetadataGenerationRunStatus("CANCELED");
        /// <summary>
        /// Constant FAILED for MetadataGenerationRunStatus
        /// </summary>
        public static readonly MetadataGenerationRunStatus FAILED = new MetadataGenerationRunStatus("FAILED");
        /// <summary>
        /// Constant IN_PROGRESS for MetadataGenerationRunStatus
        /// </summary>
        public static readonly MetadataGenerationRunStatus IN_PROGRESS = new MetadataGenerationRunStatus("IN_PROGRESS");
        /// <summary>
        /// Constant SUBMITTED for MetadataGenerationRunStatus
        /// </summary>
        public static readonly MetadataGenerationRunStatus SUBMITTED = new MetadataGenerationRunStatus("SUBMITTED");
        /// <summary>
        /// Constant SUCCEEDED for MetadataGenerationRunStatus
        /// </summary>
        public static readonly MetadataGenerationRunStatus SUCCEEDED = new MetadataGenerationRunStatus("SUCCEEDED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MetadataGenerationRunStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MetadataGenerationRunStatus FindValue(string value)
        {
            return FindValue<MetadataGenerationRunStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MetadataGenerationRunStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type MetadataGenerationRunType.
    /// </summary>
    public class MetadataGenerationRunType : ConstantClass
    {

        /// <summary>
        /// Constant BUSINESS_DESCRIPTIONS for MetadataGenerationRunType
        /// </summary>
        public static readonly MetadataGenerationRunType BUSINESS_DESCRIPTIONS = new MetadataGenerationRunType("BUSINESS_DESCRIPTIONS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MetadataGenerationRunType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MetadataGenerationRunType FindValue(string value)
        {
            return FindValue<MetadataGenerationRunType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MetadataGenerationRunType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type MetadataGenerationTargetType.
    /// </summary>
    public class MetadataGenerationTargetType : ConstantClass
    {

        /// <summary>
        /// Constant ASSET for MetadataGenerationTargetType
        /// </summary>
        public static readonly MetadataGenerationTargetType ASSET = new MetadataGenerationTargetType("ASSET");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MetadataGenerationTargetType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MetadataGenerationTargetType FindValue(string value)
        {
            return FindValue<MetadataGenerationTargetType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MetadataGenerationTargetType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type NotificationResourceType.
    /// </summary>
    public class NotificationResourceType : ConstantClass
    {

        /// <summary>
        /// Constant PROJECT for NotificationResourceType
        /// </summary>
        public static readonly NotificationResourceType PROJECT = new NotificationResourceType("PROJECT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public NotificationResourceType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static NotificationResourceType FindValue(string value)
        {
            return FindValue<NotificationResourceType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator NotificationResourceType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type NotificationRole.
    /// </summary>
    public class NotificationRole : ConstantClass
    {

        /// <summary>
        /// Constant DOMAIN_OWNER for NotificationRole
        /// </summary>
        public static readonly NotificationRole DOMAIN_OWNER = new NotificationRole("DOMAIN_OWNER");
        /// <summary>
        /// Constant PROJECT_CONTRIBUTOR for NotificationRole
        /// </summary>
        public static readonly NotificationRole PROJECT_CONTRIBUTOR = new NotificationRole("PROJECT_CONTRIBUTOR");
        /// <summary>
        /// Constant PROJECT_OWNER for NotificationRole
        /// </summary>
        public static readonly NotificationRole PROJECT_OWNER = new NotificationRole("PROJECT_OWNER");
        /// <summary>
        /// Constant PROJECT_SUBSCRIBER for NotificationRole
        /// </summary>
        public static readonly NotificationRole PROJECT_SUBSCRIBER = new NotificationRole("PROJECT_SUBSCRIBER");
        /// <summary>
        /// Constant PROJECT_VIEWER for NotificationRole
        /// </summary>
        public static readonly NotificationRole PROJECT_VIEWER = new NotificationRole("PROJECT_VIEWER");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public NotificationRole(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static NotificationRole FindValue(string value)
        {
            return FindValue<NotificationRole>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator NotificationRole(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type NotificationType.
    /// </summary>
    public class NotificationType : ConstantClass
    {

        /// <summary>
        /// Constant EVENT for NotificationType
        /// </summary>
        public static readonly NotificationType EVENT = new NotificationType("EVENT");
        /// <summary>
        /// Constant TASK for NotificationType
        /// </summary>
        public static readonly NotificationType TASK = new NotificationType("TASK");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public NotificationType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static NotificationType FindValue(string value)
        {
            return FindValue<NotificationType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator NotificationType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type OAuth2GrantType.
    /// </summary>
    public class OAuth2GrantType : ConstantClass
    {

        /// <summary>
        /// Constant AUTHORIZATION_CODE for OAuth2GrantType
        /// </summary>
        public static readonly OAuth2GrantType AUTHORIZATION_CODE = new OAuth2GrantType("AUTHORIZATION_CODE");
        /// <summary>
        /// Constant CLIENT_CREDENTIALS for OAuth2GrantType
        /// </summary>
        public static readonly OAuth2GrantType CLIENT_CREDENTIALS = new OAuth2GrantType("CLIENT_CREDENTIALS");
        /// <summary>
        /// Constant JWT_BEARER for OAuth2GrantType
        /// </summary>
        public static readonly OAuth2GrantType JWT_BEARER = new OAuth2GrantType("JWT_BEARER");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public OAuth2GrantType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static OAuth2GrantType FindValue(string value)
        {
            return FindValue<OAuth2GrantType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator OAuth2GrantType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type OpenLineageRunState.
    /// </summary>
    public class OpenLineageRunState : ConstantClass
    {

        /// <summary>
        /// Constant ABORT for OpenLineageRunState
        /// </summary>
        public static readonly OpenLineageRunState ABORT = new OpenLineageRunState("ABORT");
        /// <summary>
        /// Constant COMPLETE for OpenLineageRunState
        /// </summary>
        public static readonly OpenLineageRunState COMPLETE = new OpenLineageRunState("COMPLETE");
        /// <summary>
        /// Constant FAIL for OpenLineageRunState
        /// </summary>
        public static readonly OpenLineageRunState FAIL = new OpenLineageRunState("FAIL");
        /// <summary>
        /// Constant OTHER for OpenLineageRunState
        /// </summary>
        public static readonly OpenLineageRunState OTHER = new OpenLineageRunState("OTHER");
        /// <summary>
        /// Constant RUNNING for OpenLineageRunState
        /// </summary>
        public static readonly OpenLineageRunState RUNNING = new OpenLineageRunState("RUNNING");
        /// <summary>
        /// Constant START for OpenLineageRunState
        /// </summary>
        public static readonly OpenLineageRunState START = new OpenLineageRunState("START");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public OpenLineageRunState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static OpenLineageRunState FindValue(string value)
        {
            return FindValue<OpenLineageRunState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator OpenLineageRunState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type OverallDeploymentStatus.
    /// </summary>
    public class OverallDeploymentStatus : ConstantClass
    {

        /// <summary>
        /// Constant FAILED_DEPLOYMENT for OverallDeploymentStatus
        /// </summary>
        public static readonly OverallDeploymentStatus FAILED_DEPLOYMENT = new OverallDeploymentStatus("FAILED_DEPLOYMENT");
        /// <summary>
        /// Constant FAILED_VALIDATION for OverallDeploymentStatus
        /// </summary>
        public static readonly OverallDeploymentStatus FAILED_VALIDATION = new OverallDeploymentStatus("FAILED_VALIDATION");
        /// <summary>
        /// Constant IN_PROGRESS for OverallDeploymentStatus
        /// </summary>
        public static readonly OverallDeploymentStatus IN_PROGRESS = new OverallDeploymentStatus("IN_PROGRESS");
        /// <summary>
        /// Constant PENDING_DEPLOYMENT for OverallDeploymentStatus
        /// </summary>
        public static readonly OverallDeploymentStatus PENDING_DEPLOYMENT = new OverallDeploymentStatus("PENDING_DEPLOYMENT");
        /// <summary>
        /// Constant SUCCESSFUL for OverallDeploymentStatus
        /// </summary>
        public static readonly OverallDeploymentStatus SUCCESSFUL = new OverallDeploymentStatus("SUCCESSFUL");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public OverallDeploymentStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static OverallDeploymentStatus FindValue(string value)
        {
            return FindValue<OverallDeploymentStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator OverallDeploymentStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ProjectDesignation.
    /// </summary>
    public class ProjectDesignation : ConstantClass
    {

        /// <summary>
        /// Constant CONTRIBUTOR for ProjectDesignation
        /// </summary>
        public static readonly ProjectDesignation CONTRIBUTOR = new ProjectDesignation("CONTRIBUTOR");
        /// <summary>
        /// Constant OWNER for ProjectDesignation
        /// </summary>
        public static readonly ProjectDesignation OWNER = new ProjectDesignation("OWNER");
        /// <summary>
        /// Constant PROJECT_CATALOG_STEWARD for ProjectDesignation
        /// </summary>
        public static readonly ProjectDesignation PROJECT_CATALOG_STEWARD = new ProjectDesignation("PROJECT_CATALOG_STEWARD");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ProjectDesignation(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ProjectDesignation FindValue(string value)
        {
            return FindValue<ProjectDesignation>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ProjectDesignation(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ProjectStatus.
    /// </summary>
    public class ProjectStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for ProjectStatus
        /// </summary>
        public static readonly ProjectStatus ACTIVE = new ProjectStatus("ACTIVE");
        /// <summary>
        /// Constant DELETE_FAILED for ProjectStatus
        /// </summary>
        public static readonly ProjectStatus DELETE_FAILED = new ProjectStatus("DELETE_FAILED");
        /// <summary>
        /// Constant DELETING for ProjectStatus
        /// </summary>
        public static readonly ProjectStatus DELETING = new ProjectStatus("DELETING");
        /// <summary>
        /// Constant MOVING for ProjectStatus
        /// </summary>
        public static readonly ProjectStatus MOVING = new ProjectStatus("MOVING");
        /// <summary>
        /// Constant UPDATE_FAILED for ProjectStatus
        /// </summary>
        public static readonly ProjectStatus UPDATE_FAILED = new ProjectStatus("UPDATE_FAILED");
        /// <summary>
        /// Constant UPDATING for ProjectStatus
        /// </summary>
        public static readonly ProjectStatus UPDATING = new ProjectStatus("UPDATING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ProjectStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ProjectStatus FindValue(string value)
        {
            return FindValue<ProjectStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ProjectStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Protocol.
    /// </summary>
    public class Protocol : ConstantClass
    {

        /// <summary>
        /// Constant ATHENA for Protocol
        /// </summary>
        public static readonly Protocol ATHENA = new Protocol("ATHENA");
        /// <summary>
        /// Constant GLUE_INTERACTIVE_SESSION for Protocol
        /// </summary>
        public static readonly Protocol GLUE_INTERACTIVE_SESSION = new Protocol("GLUE_INTERACTIVE_SESSION");
        /// <summary>
        /// Constant HTTPS for Protocol
        /// </summary>
        public static readonly Protocol HTTPS = new Protocol("HTTPS");
        /// <summary>
        /// Constant JDBC for Protocol
        /// </summary>
        public static readonly Protocol JDBC = new Protocol("JDBC");
        /// <summary>
        /// Constant LIVY for Protocol
        /// </summary>
        public static readonly Protocol LIVY = new Protocol("LIVY");
        /// <summary>
        /// Constant ODBC for Protocol
        /// </summary>
        public static readonly Protocol ODBC = new Protocol("ODBC");
        /// <summary>
        /// Constant PRISM for Protocol
        /// </summary>
        public static readonly Protocol PRISM = new Protocol("PRISM");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Protocol(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Protocol FindValue(string value)
        {
            return FindValue<Protocol>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Protocol(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RejectRuleBehavior.
    /// </summary>
    public class RejectRuleBehavior : ConstantClass
    {

        /// <summary>
        /// Constant ALL for RejectRuleBehavior
        /// </summary>
        public static readonly RejectRuleBehavior ALL = new RejectRuleBehavior("ALL");
        /// <summary>
        /// Constant NONE for RejectRuleBehavior
        /// </summary>
        public static readonly RejectRuleBehavior NONE = new RejectRuleBehavior("NONE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RejectRuleBehavior(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RejectRuleBehavior FindValue(string value)
        {
            return FindValue<RejectRuleBehavior>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RejectRuleBehavior(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ResolutionStrategy.
    /// </summary>
    public class ResolutionStrategy : ConstantClass
    {

        /// <summary>
        /// Constant MANUAL for ResolutionStrategy
        /// </summary>
        public static readonly ResolutionStrategy MANUAL = new ResolutionStrategy("MANUAL");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ResolutionStrategy(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ResolutionStrategy FindValue(string value)
        {
            return FindValue<ResolutionStrategy>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ResolutionStrategy(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RuleAction.
    /// </summary>
    public class RuleAction : ConstantClass
    {

        /// <summary>
        /// Constant CREATE_LISTING_CHANGE_SET for RuleAction
        /// </summary>
        public static readonly RuleAction CREATE_LISTING_CHANGE_SET = new RuleAction("CREATE_LISTING_CHANGE_SET");
        /// <summary>
        /// Constant CREATE_SUBSCRIPTION_REQUEST for RuleAction
        /// </summary>
        public static readonly RuleAction CREATE_SUBSCRIPTION_REQUEST = new RuleAction("CREATE_SUBSCRIPTION_REQUEST");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RuleAction(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RuleAction FindValue(string value)
        {
            return FindValue<RuleAction>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RuleAction(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RuleScopeSelectionMode.
    /// </summary>
    public class RuleScopeSelectionMode : ConstantClass
    {

        /// <summary>
        /// Constant ALL for RuleScopeSelectionMode
        /// </summary>
        public static readonly RuleScopeSelectionMode ALL = new RuleScopeSelectionMode("ALL");
        /// <summary>
        /// Constant SPECIFIC for RuleScopeSelectionMode
        /// </summary>
        public static readonly RuleScopeSelectionMode SPECIFIC = new RuleScopeSelectionMode("SPECIFIC");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RuleScopeSelectionMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RuleScopeSelectionMode FindValue(string value)
        {
            return FindValue<RuleScopeSelectionMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RuleScopeSelectionMode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RuleTargetType.
    /// </summary>
    public class RuleTargetType : ConstantClass
    {

        /// <summary>
        /// Constant DOMAIN_UNIT for RuleTargetType
        /// </summary>
        public static readonly RuleTargetType DOMAIN_UNIT = new RuleTargetType("DOMAIN_UNIT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RuleTargetType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RuleTargetType FindValue(string value)
        {
            return FindValue<RuleTargetType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RuleTargetType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RuleType.
    /// </summary>
    public class RuleType : ConstantClass
    {

        /// <summary>
        /// Constant METADATA_FORM_ENFORCEMENT for RuleType
        /// </summary>
        public static readonly RuleType METADATA_FORM_ENFORCEMENT = new RuleType("METADATA_FORM_ENFORCEMENT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RuleType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RuleType FindValue(string value)
        {
            return FindValue<RuleType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RuleType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SearchOutputAdditionalAttribute.
    /// </summary>
    public class SearchOutputAdditionalAttribute : ConstantClass
    {

        /// <summary>
        /// Constant FORMS for SearchOutputAdditionalAttribute
        /// </summary>
        public static readonly SearchOutputAdditionalAttribute FORMS = new SearchOutputAdditionalAttribute("FORMS");
        /// <summary>
        /// Constant TEXT_MATCH_RATIONALE for SearchOutputAdditionalAttribute
        /// </summary>
        public static readonly SearchOutputAdditionalAttribute TEXT_MATCH_RATIONALE = new SearchOutputAdditionalAttribute("TEXT_MATCH_RATIONALE");
        /// <summary>
        /// Constant TIME_SERIES_DATA_POINT_FORMS for SearchOutputAdditionalAttribute
        /// </summary>
        public static readonly SearchOutputAdditionalAttribute TIME_SERIES_DATA_POINT_FORMS = new SearchOutputAdditionalAttribute("TIME_SERIES_DATA_POINT_FORMS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SearchOutputAdditionalAttribute(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SearchOutputAdditionalAttribute FindValue(string value)
        {
            return FindValue<SearchOutputAdditionalAttribute>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SearchOutputAdditionalAttribute(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SelfGrantStatus.
    /// </summary>
    public class SelfGrantStatus : ConstantClass
    {

        /// <summary>
        /// Constant GRANT_FAILED for SelfGrantStatus
        /// </summary>
        public static readonly SelfGrantStatus GRANT_FAILED = new SelfGrantStatus("GRANT_FAILED");
        /// <summary>
        /// Constant GRANT_IN_PROGRESS for SelfGrantStatus
        /// </summary>
        public static readonly SelfGrantStatus GRANT_IN_PROGRESS = new SelfGrantStatus("GRANT_IN_PROGRESS");
        /// <summary>
        /// Constant GRANT_PENDING for SelfGrantStatus
        /// </summary>
        public static readonly SelfGrantStatus GRANT_PENDING = new SelfGrantStatus("GRANT_PENDING");
        /// <summary>
        /// Constant GRANTED for SelfGrantStatus
        /// </summary>
        public static readonly SelfGrantStatus GRANTED = new SelfGrantStatus("GRANTED");
        /// <summary>
        /// Constant REVOKE_FAILED for SelfGrantStatus
        /// </summary>
        public static readonly SelfGrantStatus REVOKE_FAILED = new SelfGrantStatus("REVOKE_FAILED");
        /// <summary>
        /// Constant REVOKE_IN_PROGRESS for SelfGrantStatus
        /// </summary>
        public static readonly SelfGrantStatus REVOKE_IN_PROGRESS = new SelfGrantStatus("REVOKE_IN_PROGRESS");
        /// <summary>
        /// Constant REVOKE_PENDING for SelfGrantStatus
        /// </summary>
        public static readonly SelfGrantStatus REVOKE_PENDING = new SelfGrantStatus("REVOKE_PENDING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SelfGrantStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SelfGrantStatus FindValue(string value)
        {
            return FindValue<SelfGrantStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SelfGrantStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SortFieldAccountPool.
    /// </summary>
    public class SortFieldAccountPool : ConstantClass
    {

        /// <summary>
        /// Constant NAME for SortFieldAccountPool
        /// </summary>
        public static readonly SortFieldAccountPool NAME = new SortFieldAccountPool("NAME");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SortFieldAccountPool(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SortFieldAccountPool FindValue(string value)
        {
            return FindValue<SortFieldAccountPool>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SortFieldAccountPool(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SortFieldConnection.
    /// </summary>
    public class SortFieldConnection : ConstantClass
    {

        /// <summary>
        /// Constant NAME for SortFieldConnection
        /// </summary>
        public static readonly SortFieldConnection NAME = new SortFieldConnection("NAME");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SortFieldConnection(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SortFieldConnection FindValue(string value)
        {
            return FindValue<SortFieldConnection>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SortFieldConnection(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SortFieldProject.
    /// </summary>
    public class SortFieldProject : ConstantClass
    {

        /// <summary>
        /// Constant NAME for SortFieldProject
        /// </summary>
        public static readonly SortFieldProject NAME = new SortFieldProject("NAME");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SortFieldProject(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SortFieldProject FindValue(string value)
        {
            return FindValue<SortFieldProject>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SortFieldProject(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SortKey.
    /// </summary>
    public class SortKey : ConstantClass
    {

        /// <summary>
        /// Constant CREATED_AT for SortKey
        /// </summary>
        public static readonly SortKey CREATED_AT = new SortKey("CREATED_AT");
        /// <summary>
        /// Constant UPDATED_AT for SortKey
        /// </summary>
        public static readonly SortKey UPDATED_AT = new SortKey("UPDATED_AT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SortKey(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SortKey FindValue(string value)
        {
            return FindValue<SortKey>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SortKey(string value)
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
        /// Constant ASCENDING for SortOrder
        /// </summary>
        public static readonly SortOrder ASCENDING = new SortOrder("ASCENDING");
        /// <summary>
        /// Constant DESCENDING for SortOrder
        /// </summary>
        public static readonly SortOrder DESCENDING = new SortOrder("DESCENDING");

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
    /// Constants used for properties of type Status.
    /// </summary>
    public class Status : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for Status
        /// </summary>
        public static readonly Status DISABLED = new Status("DISABLED");
        /// <summary>
        /// Constant ENABLED for Status
        /// </summary>
        public static readonly Status ENABLED = new Status("ENABLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Status(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Status FindValue(string value)
        {
            return FindValue<Status>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Status(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SubscriptionGrantOverallStatus.
    /// </summary>
    public class SubscriptionGrantOverallStatus : ConstantClass
    {

        /// <summary>
        /// Constant COMPLETED for SubscriptionGrantOverallStatus
        /// </summary>
        public static readonly SubscriptionGrantOverallStatus COMPLETED = new SubscriptionGrantOverallStatus("COMPLETED");
        /// <summary>
        /// Constant GRANT_AND_REVOKE_FAILED for SubscriptionGrantOverallStatus
        /// </summary>
        public static readonly SubscriptionGrantOverallStatus GRANT_AND_REVOKE_FAILED = new SubscriptionGrantOverallStatus("GRANT_AND_REVOKE_FAILED");
        /// <summary>
        /// Constant GRANT_FAILED for SubscriptionGrantOverallStatus
        /// </summary>
        public static readonly SubscriptionGrantOverallStatus GRANT_FAILED = new SubscriptionGrantOverallStatus("GRANT_FAILED");
        /// <summary>
        /// Constant IN_PROGRESS for SubscriptionGrantOverallStatus
        /// </summary>
        public static readonly SubscriptionGrantOverallStatus IN_PROGRESS = new SubscriptionGrantOverallStatus("IN_PROGRESS");
        /// <summary>
        /// Constant INACCESSIBLE for SubscriptionGrantOverallStatus
        /// </summary>
        public static readonly SubscriptionGrantOverallStatus INACCESSIBLE = new SubscriptionGrantOverallStatus("INACCESSIBLE");
        /// <summary>
        /// Constant PENDING for SubscriptionGrantOverallStatus
        /// </summary>
        public static readonly SubscriptionGrantOverallStatus PENDING = new SubscriptionGrantOverallStatus("PENDING");
        /// <summary>
        /// Constant REVOKE_FAILED for SubscriptionGrantOverallStatus
        /// </summary>
        public static readonly SubscriptionGrantOverallStatus REVOKE_FAILED = new SubscriptionGrantOverallStatus("REVOKE_FAILED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SubscriptionGrantOverallStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SubscriptionGrantOverallStatus FindValue(string value)
        {
            return FindValue<SubscriptionGrantOverallStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SubscriptionGrantOverallStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SubscriptionGrantStatus.
    /// </summary>
    public class SubscriptionGrantStatus : ConstantClass
    {

        /// <summary>
        /// Constant GRANT_FAILED for SubscriptionGrantStatus
        /// </summary>
        public static readonly SubscriptionGrantStatus GRANT_FAILED = new SubscriptionGrantStatus("GRANT_FAILED");
        /// <summary>
        /// Constant GRANT_IN_PROGRESS for SubscriptionGrantStatus
        /// </summary>
        public static readonly SubscriptionGrantStatus GRANT_IN_PROGRESS = new SubscriptionGrantStatus("GRANT_IN_PROGRESS");
        /// <summary>
        /// Constant GRANT_PENDING for SubscriptionGrantStatus
        /// </summary>
        public static readonly SubscriptionGrantStatus GRANT_PENDING = new SubscriptionGrantStatus("GRANT_PENDING");
        /// <summary>
        /// Constant GRANTED for SubscriptionGrantStatus
        /// </summary>
        public static readonly SubscriptionGrantStatus GRANTED = new SubscriptionGrantStatus("GRANTED");
        /// <summary>
        /// Constant REVOKE_FAILED for SubscriptionGrantStatus
        /// </summary>
        public static readonly SubscriptionGrantStatus REVOKE_FAILED = new SubscriptionGrantStatus("REVOKE_FAILED");
        /// <summary>
        /// Constant REVOKE_IN_PROGRESS for SubscriptionGrantStatus
        /// </summary>
        public static readonly SubscriptionGrantStatus REVOKE_IN_PROGRESS = new SubscriptionGrantStatus("REVOKE_IN_PROGRESS");
        /// <summary>
        /// Constant REVOKE_PENDING for SubscriptionGrantStatus
        /// </summary>
        public static readonly SubscriptionGrantStatus REVOKE_PENDING = new SubscriptionGrantStatus("REVOKE_PENDING");
        /// <summary>
        /// Constant REVOKED for SubscriptionGrantStatus
        /// </summary>
        public static readonly SubscriptionGrantStatus REVOKED = new SubscriptionGrantStatus("REVOKED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SubscriptionGrantStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SubscriptionGrantStatus FindValue(string value)
        {
            return FindValue<SubscriptionGrantStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SubscriptionGrantStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SubscriptionRequestStatus.
    /// </summary>
    public class SubscriptionRequestStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACCEPTED for SubscriptionRequestStatus
        /// </summary>
        public static readonly SubscriptionRequestStatus ACCEPTED = new SubscriptionRequestStatus("ACCEPTED");
        /// <summary>
        /// Constant PENDING for SubscriptionRequestStatus
        /// </summary>
        public static readonly SubscriptionRequestStatus PENDING = new SubscriptionRequestStatus("PENDING");
        /// <summary>
        /// Constant REJECTED for SubscriptionRequestStatus
        /// </summary>
        public static readonly SubscriptionRequestStatus REJECTED = new SubscriptionRequestStatus("REJECTED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SubscriptionRequestStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SubscriptionRequestStatus FindValue(string value)
        {
            return FindValue<SubscriptionRequestStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SubscriptionRequestStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SubscriptionStatus.
    /// </summary>
    public class SubscriptionStatus : ConstantClass
    {

        /// <summary>
        /// Constant APPROVED for SubscriptionStatus
        /// </summary>
        public static readonly SubscriptionStatus APPROVED = new SubscriptionStatus("APPROVED");
        /// <summary>
        /// Constant CANCELLED for SubscriptionStatus
        /// </summary>
        public static readonly SubscriptionStatus CANCELLED = new SubscriptionStatus("CANCELLED");
        /// <summary>
        /// Constant REVOKED for SubscriptionStatus
        /// </summary>
        public static readonly SubscriptionStatus REVOKED = new SubscriptionStatus("REVOKED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SubscriptionStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SubscriptionStatus FindValue(string value)
        {
            return FindValue<SubscriptionStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SubscriptionStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TargetEntityType.
    /// </summary>
    public class TargetEntityType : ConstantClass
    {

        /// <summary>
        /// Constant ASSET_TYPE for TargetEntityType
        /// </summary>
        public static readonly TargetEntityType ASSET_TYPE = new TargetEntityType("ASSET_TYPE");
        /// <summary>
        /// Constant DOMAIN_UNIT for TargetEntityType
        /// </summary>
        public static readonly TargetEntityType DOMAIN_UNIT = new TargetEntityType("DOMAIN_UNIT");
        /// <summary>
        /// Constant ENVIRONMENT_BLUEPRINT_CONFIGURATION for TargetEntityType
        /// </summary>
        public static readonly TargetEntityType ENVIRONMENT_BLUEPRINT_CONFIGURATION = new TargetEntityType("ENVIRONMENT_BLUEPRINT_CONFIGURATION");
        /// <summary>
        /// Constant ENVIRONMENT_PROFILE for TargetEntityType
        /// </summary>
        public static readonly TargetEntityType ENVIRONMENT_PROFILE = new TargetEntityType("ENVIRONMENT_PROFILE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TargetEntityType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TargetEntityType FindValue(string value)
        {
            return FindValue<TargetEntityType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TargetEntityType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TaskStatus.
    /// </summary>
    public class TaskStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for TaskStatus
        /// </summary>
        public static readonly TaskStatus ACTIVE = new TaskStatus("ACTIVE");
        /// <summary>
        /// Constant INACTIVE for TaskStatus
        /// </summary>
        public static readonly TaskStatus INACTIVE = new TaskStatus("INACTIVE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TaskStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TaskStatus FindValue(string value)
        {
            return FindValue<TaskStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TaskStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TimeSeriesEntityType.
    /// </summary>
    public class TimeSeriesEntityType : ConstantClass
    {

        /// <summary>
        /// Constant ASSET for TimeSeriesEntityType
        /// </summary>
        public static readonly TimeSeriesEntityType ASSET = new TimeSeriesEntityType("ASSET");
        /// <summary>
        /// Constant LISTING for TimeSeriesEntityType
        /// </summary>
        public static readonly TimeSeriesEntityType LISTING = new TimeSeriesEntityType("LISTING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TimeSeriesEntityType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TimeSeriesEntityType FindValue(string value)
        {
            return FindValue<TimeSeriesEntityType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TimeSeriesEntityType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Timezone.
    /// </summary>
    public class Timezone : ConstantClass
    {

        /// <summary>
        /// Constant AFRICA_JOHANNESBURG for Timezone
        /// </summary>
        public static readonly Timezone AFRICA_JOHANNESBURG = new Timezone("AFRICA_JOHANNESBURG");
        /// <summary>
        /// Constant AMERICA_MONTREAL for Timezone
        /// </summary>
        public static readonly Timezone AMERICA_MONTREAL = new Timezone("AMERICA_MONTREAL");
        /// <summary>
        /// Constant AMERICA_SAO_PAULO for Timezone
        /// </summary>
        public static readonly Timezone AMERICA_SAO_PAULO = new Timezone("AMERICA_SAO_PAULO");
        /// <summary>
        /// Constant ASIA_BAHRAIN for Timezone
        /// </summary>
        public static readonly Timezone ASIA_BAHRAIN = new Timezone("ASIA_BAHRAIN");
        /// <summary>
        /// Constant ASIA_BANGKOK for Timezone
        /// </summary>
        public static readonly Timezone ASIA_BANGKOK = new Timezone("ASIA_BANGKOK");
        /// <summary>
        /// Constant ASIA_CALCUTTA for Timezone
        /// </summary>
        public static readonly Timezone ASIA_CALCUTTA = new Timezone("ASIA_CALCUTTA");
        /// <summary>
        /// Constant ASIA_DUBAI for Timezone
        /// </summary>
        public static readonly Timezone ASIA_DUBAI = new Timezone("ASIA_DUBAI");
        /// <summary>
        /// Constant ASIA_HONG_KONG for Timezone
        /// </summary>
        public static readonly Timezone ASIA_HONG_KONG = new Timezone("ASIA_HONG_KONG");
        /// <summary>
        /// Constant ASIA_JAKARTA for Timezone
        /// </summary>
        public static readonly Timezone ASIA_JAKARTA = new Timezone("ASIA_JAKARTA");
        /// <summary>
        /// Constant ASIA_KUALA_LUMPUR for Timezone
        /// </summary>
        public static readonly Timezone ASIA_KUALA_LUMPUR = new Timezone("ASIA_KUALA_LUMPUR");
        /// <summary>
        /// Constant ASIA_SEOUL for Timezone
        /// </summary>
        public static readonly Timezone ASIA_SEOUL = new Timezone("ASIA_SEOUL");
        /// <summary>
        /// Constant ASIA_SHANGHAI for Timezone
        /// </summary>
        public static readonly Timezone ASIA_SHANGHAI = new Timezone("ASIA_SHANGHAI");
        /// <summary>
        /// Constant ASIA_SINGAPORE for Timezone
        /// </summary>
        public static readonly Timezone ASIA_SINGAPORE = new Timezone("ASIA_SINGAPORE");
        /// <summary>
        /// Constant ASIA_TAIPEI for Timezone
        /// </summary>
        public static readonly Timezone ASIA_TAIPEI = new Timezone("ASIA_TAIPEI");
        /// <summary>
        /// Constant ASIA_TOKYO for Timezone
        /// </summary>
        public static readonly Timezone ASIA_TOKYO = new Timezone("ASIA_TOKYO");
        /// <summary>
        /// Constant AUSTRALIA_MELBOURNE for Timezone
        /// </summary>
        public static readonly Timezone AUSTRALIA_MELBOURNE = new Timezone("AUSTRALIA_MELBOURNE");
        /// <summary>
        /// Constant AUSTRALIA_SYDNEY for Timezone
        /// </summary>
        public static readonly Timezone AUSTRALIA_SYDNEY = new Timezone("AUSTRALIA_SYDNEY");
        /// <summary>
        /// Constant CANADA_CENTRAL for Timezone
        /// </summary>
        public static readonly Timezone CANADA_CENTRAL = new Timezone("CANADA_CENTRAL");
        /// <summary>
        /// Constant CET for Timezone
        /// </summary>
        public static readonly Timezone CET = new Timezone("CET");
        /// <summary>
        /// Constant CST6CDT for Timezone
        /// </summary>
        public static readonly Timezone CST6CDT = new Timezone("CST6CDT");
        /// <summary>
        /// Constant ETC_GMT for Timezone
        /// </summary>
        public static readonly Timezone ETC_GMT = new Timezone("ETC_GMT");
        /// <summary>
        /// Constant ETC_GMT_ADD_0 for Timezone
        /// </summary>
        public static readonly Timezone ETC_GMT_ADD_0 = new Timezone("ETC_GMT_ADD_0");
        /// <summary>
        /// Constant ETC_GMT_ADD_1 for Timezone
        /// </summary>
        public static readonly Timezone ETC_GMT_ADD_1 = new Timezone("ETC_GMT_ADD_1");
        /// <summary>
        /// Constant ETC_GMT_ADD_10 for Timezone
        /// </summary>
        public static readonly Timezone ETC_GMT_ADD_10 = new Timezone("ETC_GMT_ADD_10");
        /// <summary>
        /// Constant ETC_GMT_ADD_11 for Timezone
        /// </summary>
        public static readonly Timezone ETC_GMT_ADD_11 = new Timezone("ETC_GMT_ADD_11");
        /// <summary>
        /// Constant ETC_GMT_ADD_12 for Timezone
        /// </summary>
        public static readonly Timezone ETC_GMT_ADD_12 = new Timezone("ETC_GMT_ADD_12");
        /// <summary>
        /// Constant ETC_GMT_ADD_2 for Timezone
        /// </summary>
        public static readonly Timezone ETC_GMT_ADD_2 = new Timezone("ETC_GMT_ADD_2");
        /// <summary>
        /// Constant ETC_GMT_ADD_3 for Timezone
        /// </summary>
        public static readonly Timezone ETC_GMT_ADD_3 = new Timezone("ETC_GMT_ADD_3");
        /// <summary>
        /// Constant ETC_GMT_ADD_4 for Timezone
        /// </summary>
        public static readonly Timezone ETC_GMT_ADD_4 = new Timezone("ETC_GMT_ADD_4");
        /// <summary>
        /// Constant ETC_GMT_ADD_5 for Timezone
        /// </summary>
        public static readonly Timezone ETC_GMT_ADD_5 = new Timezone("ETC_GMT_ADD_5");
        /// <summary>
        /// Constant ETC_GMT_ADD_6 for Timezone
        /// </summary>
        public static readonly Timezone ETC_GMT_ADD_6 = new Timezone("ETC_GMT_ADD_6");
        /// <summary>
        /// Constant ETC_GMT_ADD_7 for Timezone
        /// </summary>
        public static readonly Timezone ETC_GMT_ADD_7 = new Timezone("ETC_GMT_ADD_7");
        /// <summary>
        /// Constant ETC_GMT_ADD_8 for Timezone
        /// </summary>
        public static readonly Timezone ETC_GMT_ADD_8 = new Timezone("ETC_GMT_ADD_8");
        /// <summary>
        /// Constant ETC_GMT_ADD_9 for Timezone
        /// </summary>
        public static readonly Timezone ETC_GMT_ADD_9 = new Timezone("ETC_GMT_ADD_9");
        /// <summary>
        /// Constant ETC_GMT_NEG_0 for Timezone
        /// </summary>
        public static readonly Timezone ETC_GMT_NEG_0 = new Timezone("ETC_GMT_NEG_0");
        /// <summary>
        /// Constant ETC_GMT_NEG_1 for Timezone
        /// </summary>
        public static readonly Timezone ETC_GMT_NEG_1 = new Timezone("ETC_GMT_NEG_1");
        /// <summary>
        /// Constant ETC_GMT_NEG_10 for Timezone
        /// </summary>
        public static readonly Timezone ETC_GMT_NEG_10 = new Timezone("ETC_GMT_NEG_10");
        /// <summary>
        /// Constant ETC_GMT_NEG_11 for Timezone
        /// </summary>
        public static readonly Timezone ETC_GMT_NEG_11 = new Timezone("ETC_GMT_NEG_11");
        /// <summary>
        /// Constant ETC_GMT_NEG_12 for Timezone
        /// </summary>
        public static readonly Timezone ETC_GMT_NEG_12 = new Timezone("ETC_GMT_NEG_12");
        /// <summary>
        /// Constant ETC_GMT_NEG_13 for Timezone
        /// </summary>
        public static readonly Timezone ETC_GMT_NEG_13 = new Timezone("ETC_GMT_NEG_13");
        /// <summary>
        /// Constant ETC_GMT_NEG_14 for Timezone
        /// </summary>
        public static readonly Timezone ETC_GMT_NEG_14 = new Timezone("ETC_GMT_NEG_14");
        /// <summary>
        /// Constant ETC_GMT_NEG_2 for Timezone
        /// </summary>
        public static readonly Timezone ETC_GMT_NEG_2 = new Timezone("ETC_GMT_NEG_2");
        /// <summary>
        /// Constant ETC_GMT_NEG_3 for Timezone
        /// </summary>
        public static readonly Timezone ETC_GMT_NEG_3 = new Timezone("ETC_GMT_NEG_3");
        /// <summary>
        /// Constant ETC_GMT_NEG_4 for Timezone
        /// </summary>
        public static readonly Timezone ETC_GMT_NEG_4 = new Timezone("ETC_GMT_NEG_4");
        /// <summary>
        /// Constant ETC_GMT_NEG_5 for Timezone
        /// </summary>
        public static readonly Timezone ETC_GMT_NEG_5 = new Timezone("ETC_GMT_NEG_5");
        /// <summary>
        /// Constant ETC_GMT_NEG_6 for Timezone
        /// </summary>
        public static readonly Timezone ETC_GMT_NEG_6 = new Timezone("ETC_GMT_NEG_6");
        /// <summary>
        /// Constant ETC_GMT_NEG_7 for Timezone
        /// </summary>
        public static readonly Timezone ETC_GMT_NEG_7 = new Timezone("ETC_GMT_NEG_7");
        /// <summary>
        /// Constant ETC_GMT_NEG_8 for Timezone
        /// </summary>
        public static readonly Timezone ETC_GMT_NEG_8 = new Timezone("ETC_GMT_NEG_8");
        /// <summary>
        /// Constant ETC_GMT_NEG_9 for Timezone
        /// </summary>
        public static readonly Timezone ETC_GMT_NEG_9 = new Timezone("ETC_GMT_NEG_9");
        /// <summary>
        /// Constant ETC_GMT0 for Timezone
        /// </summary>
        public static readonly Timezone ETC_GMT0 = new Timezone("ETC_GMT0");
        /// <summary>
        /// Constant EUROPE_DUBLIN for Timezone
        /// </summary>
        public static readonly Timezone EUROPE_DUBLIN = new Timezone("EUROPE_DUBLIN");
        /// <summary>
        /// Constant EUROPE_LONDON for Timezone
        /// </summary>
        public static readonly Timezone EUROPE_LONDON = new Timezone("EUROPE_LONDON");
        /// <summary>
        /// Constant EUROPE_PARIS for Timezone
        /// </summary>
        public static readonly Timezone EUROPE_PARIS = new Timezone("EUROPE_PARIS");
        /// <summary>
        /// Constant EUROPE_STOCKHOLM for Timezone
        /// </summary>
        public static readonly Timezone EUROPE_STOCKHOLM = new Timezone("EUROPE_STOCKHOLM");
        /// <summary>
        /// Constant EUROPE_ZURICH for Timezone
        /// </summary>
        public static readonly Timezone EUROPE_ZURICH = new Timezone("EUROPE_ZURICH");
        /// <summary>
        /// Constant ISRAEL for Timezone
        /// </summary>
        public static readonly Timezone ISRAEL = new Timezone("ISRAEL");
        /// <summary>
        /// Constant MEXICO_GENERAL for Timezone
        /// </summary>
        public static readonly Timezone MEXICO_GENERAL = new Timezone("MEXICO_GENERAL");
        /// <summary>
        /// Constant MST7MDT for Timezone
        /// </summary>
        public static readonly Timezone MST7MDT = new Timezone("MST7MDT");
        /// <summary>
        /// Constant PACIFIC_AUCKLAND for Timezone
        /// </summary>
        public static readonly Timezone PACIFIC_AUCKLAND = new Timezone("PACIFIC_AUCKLAND");
        /// <summary>
        /// Constant US_CENTRAL for Timezone
        /// </summary>
        public static readonly Timezone US_CENTRAL = new Timezone("US_CENTRAL");
        /// <summary>
        /// Constant US_EASTERN for Timezone
        /// </summary>
        public static readonly Timezone US_EASTERN = new Timezone("US_EASTERN");
        /// <summary>
        /// Constant US_MOUNTAIN for Timezone
        /// </summary>
        public static readonly Timezone US_MOUNTAIN = new Timezone("US_MOUNTAIN");
        /// <summary>
        /// Constant US_PACIFIC for Timezone
        /// </summary>
        public static readonly Timezone US_PACIFIC = new Timezone("US_PACIFIC");
        /// <summary>
        /// Constant UTC for Timezone
        /// </summary>
        public static readonly Timezone UTC = new Timezone("UTC");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Timezone(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Timezone FindValue(string value)
        {
            return FindValue<Timezone>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Timezone(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TypesSearchScope.
    /// </summary>
    public class TypesSearchScope : ConstantClass
    {

        /// <summary>
        /// Constant ASSET_TYPE for TypesSearchScope
        /// </summary>
        public static readonly TypesSearchScope ASSET_TYPE = new TypesSearchScope("ASSET_TYPE");
        /// <summary>
        /// Constant FORM_TYPE for TypesSearchScope
        /// </summary>
        public static readonly TypesSearchScope FORM_TYPE = new TypesSearchScope("FORM_TYPE");
        /// <summary>
        /// Constant LINEAGE_NODE_TYPE for TypesSearchScope
        /// </summary>
        public static readonly TypesSearchScope LINEAGE_NODE_TYPE = new TypesSearchScope("LINEAGE_NODE_TYPE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TypesSearchScope(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TypesSearchScope FindValue(string value)
        {
            return FindValue<TypesSearchScope>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TypesSearchScope(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type UserAssignment.
    /// </summary>
    public class UserAssignment : ConstantClass
    {

        /// <summary>
        /// Constant AUTOMATIC for UserAssignment
        /// </summary>
        public static readonly UserAssignment AUTOMATIC = new UserAssignment("AUTOMATIC");
        /// <summary>
        /// Constant MANUAL for UserAssignment
        /// </summary>
        public static readonly UserAssignment MANUAL = new UserAssignment("MANUAL");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public UserAssignment(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static UserAssignment FindValue(string value)
        {
            return FindValue<UserAssignment>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator UserAssignment(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type UserDesignation.
    /// </summary>
    public class UserDesignation : ConstantClass
    {

        /// <summary>
        /// Constant PROJECT_CATALOG_CONSUMER for UserDesignation
        /// </summary>
        public static readonly UserDesignation PROJECT_CATALOG_CONSUMER = new UserDesignation("PROJECT_CATALOG_CONSUMER");
        /// <summary>
        /// Constant PROJECT_CATALOG_STEWARD for UserDesignation
        /// </summary>
        public static readonly UserDesignation PROJECT_CATALOG_STEWARD = new UserDesignation("PROJECT_CATALOG_STEWARD");
        /// <summary>
        /// Constant PROJECT_CATALOG_VIEWER for UserDesignation
        /// </summary>
        public static readonly UserDesignation PROJECT_CATALOG_VIEWER = new UserDesignation("PROJECT_CATALOG_VIEWER");
        /// <summary>
        /// Constant PROJECT_CONTRIBUTOR for UserDesignation
        /// </summary>
        public static readonly UserDesignation PROJECT_CONTRIBUTOR = new UserDesignation("PROJECT_CONTRIBUTOR");
        /// <summary>
        /// Constant PROJECT_OWNER for UserDesignation
        /// </summary>
        public static readonly UserDesignation PROJECT_OWNER = new UserDesignation("PROJECT_OWNER");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public UserDesignation(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static UserDesignation FindValue(string value)
        {
            return FindValue<UserDesignation>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator UserDesignation(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type UserProfileStatus.
    /// </summary>
    public class UserProfileStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVATED for UserProfileStatus
        /// </summary>
        public static readonly UserProfileStatus ACTIVATED = new UserProfileStatus("ACTIVATED");
        /// <summary>
        /// Constant ASSIGNED for UserProfileStatus
        /// </summary>
        public static readonly UserProfileStatus ASSIGNED = new UserProfileStatus("ASSIGNED");
        /// <summary>
        /// Constant DEACTIVATED for UserProfileStatus
        /// </summary>
        public static readonly UserProfileStatus DEACTIVATED = new UserProfileStatus("DEACTIVATED");
        /// <summary>
        /// Constant NOT_ASSIGNED for UserProfileStatus
        /// </summary>
        public static readonly UserProfileStatus NOT_ASSIGNED = new UserProfileStatus("NOT_ASSIGNED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public UserProfileStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static UserProfileStatus FindValue(string value)
        {
            return FindValue<UserProfileStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator UserProfileStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type UserProfileType.
    /// </summary>
    public class UserProfileType : ConstantClass
    {

        /// <summary>
        /// Constant IAM for UserProfileType
        /// </summary>
        public static readonly UserProfileType IAM = new UserProfileType("IAM");
        /// <summary>
        /// Constant SSO for UserProfileType
        /// </summary>
        public static readonly UserProfileType SSO = new UserProfileType("SSO");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public UserProfileType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static UserProfileType FindValue(string value)
        {
            return FindValue<UserProfileType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator UserProfileType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type UserSearchType.
    /// </summary>
    public class UserSearchType : ConstantClass
    {

        /// <summary>
        /// Constant DATAZONE_IAM_USER for UserSearchType
        /// </summary>
        public static readonly UserSearchType DATAZONE_IAM_USER = new UserSearchType("DATAZONE_IAM_USER");
        /// <summary>
        /// Constant DATAZONE_SSO_USER for UserSearchType
        /// </summary>
        public static readonly UserSearchType DATAZONE_SSO_USER = new UserSearchType("DATAZONE_SSO_USER");
        /// <summary>
        /// Constant DATAZONE_USER for UserSearchType
        /// </summary>
        public static readonly UserSearchType DATAZONE_USER = new UserSearchType("DATAZONE_USER");
        /// <summary>
        /// Constant SSO_USER for UserSearchType
        /// </summary>
        public static readonly UserSearchType SSO_USER = new UserSearchType("SSO_USER");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public UserSearchType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static UserSearchType FindValue(string value)
        {
            return FindValue<UserSearchType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator UserSearchType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type UserType.
    /// </summary>
    public class UserType : ConstantClass
    {

        /// <summary>
        /// Constant IAM_ROLE for UserType
        /// </summary>
        public static readonly UserType IAM_ROLE = new UserType("IAM_ROLE");
        /// <summary>
        /// Constant IAM_USER for UserType
        /// </summary>
        public static readonly UserType IAM_USER = new UserType("IAM_USER");
        /// <summary>
        /// Constant SSO_USER for UserType
        /// </summary>
        public static readonly UserType SSO_USER = new UserType("SSO_USER");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public UserType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static UserType FindValue(string value)
        {
            return FindValue<UserType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator UserType(string value)
        {
            return FindValue(value);
        }
    }

}