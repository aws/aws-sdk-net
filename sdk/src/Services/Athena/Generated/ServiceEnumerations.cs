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
 * Do not modify this file. This file is generated from the athena-2017-05-18.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.Athena
{

    /// <summary>
    /// Constants used for properties of type CalculationExecutionState.
    /// </summary>
    public class CalculationExecutionState : ConstantClass
    {

        /// <summary>
        /// Constant CANCELED for CalculationExecutionState
        /// </summary>
        public static readonly CalculationExecutionState CANCELED = new CalculationExecutionState("CANCELED");
        /// <summary>
        /// Constant CANCELING for CalculationExecutionState
        /// </summary>
        public static readonly CalculationExecutionState CANCELING = new CalculationExecutionState("CANCELING");
        /// <summary>
        /// Constant COMPLETED for CalculationExecutionState
        /// </summary>
        public static readonly CalculationExecutionState COMPLETED = new CalculationExecutionState("COMPLETED");
        /// <summary>
        /// Constant CREATED for CalculationExecutionState
        /// </summary>
        public static readonly CalculationExecutionState CREATED = new CalculationExecutionState("CREATED");
        /// <summary>
        /// Constant CREATING for CalculationExecutionState
        /// </summary>
        public static readonly CalculationExecutionState CREATING = new CalculationExecutionState("CREATING");
        /// <summary>
        /// Constant FAILED for CalculationExecutionState
        /// </summary>
        public static readonly CalculationExecutionState FAILED = new CalculationExecutionState("FAILED");
        /// <summary>
        /// Constant QUEUED for CalculationExecutionState
        /// </summary>
        public static readonly CalculationExecutionState QUEUED = new CalculationExecutionState("QUEUED");
        /// <summary>
        /// Constant RUNNING for CalculationExecutionState
        /// </summary>
        public static readonly CalculationExecutionState RUNNING = new CalculationExecutionState("RUNNING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CalculationExecutionState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CalculationExecutionState FindValue(string value)
        {
            return FindValue<CalculationExecutionState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CalculationExecutionState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ColumnNullable.
    /// </summary>
    public class ColumnNullable : ConstantClass
    {

        /// <summary>
        /// Constant NOT_NULL for ColumnNullable
        /// </summary>
        public static readonly ColumnNullable NOT_NULL = new ColumnNullable("NOT_NULL");
        /// <summary>
        /// Constant NULLABLE for ColumnNullable
        /// </summary>
        public static readonly ColumnNullable NULLABLE = new ColumnNullable("NULLABLE");
        /// <summary>
        /// Constant UNKNOWN for ColumnNullable
        /// </summary>
        public static readonly ColumnNullable UNKNOWN = new ColumnNullable("UNKNOWN");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ColumnNullable(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ColumnNullable FindValue(string value)
        {
            return FindValue<ColumnNullable>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ColumnNullable(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DataCatalogType.
    /// </summary>
    public class DataCatalogType : ConstantClass
    {

        /// <summary>
        /// Constant GLUE for DataCatalogType
        /// </summary>
        public static readonly DataCatalogType GLUE = new DataCatalogType("GLUE");
        /// <summary>
        /// Constant HIVE for DataCatalogType
        /// </summary>
        public static readonly DataCatalogType HIVE = new DataCatalogType("HIVE");
        /// <summary>
        /// Constant LAMBDA for DataCatalogType
        /// </summary>
        public static readonly DataCatalogType LAMBDA = new DataCatalogType("LAMBDA");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DataCatalogType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DataCatalogType FindValue(string value)
        {
            return FindValue<DataCatalogType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DataCatalogType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type EncryptionOption.
    /// </summary>
    public class EncryptionOption : ConstantClass
    {

        /// <summary>
        /// Constant CSE_KMS for EncryptionOption
        /// </summary>
        public static readonly EncryptionOption CSE_KMS = new EncryptionOption("CSE_KMS");
        /// <summary>
        /// Constant SSE_KMS for EncryptionOption
        /// </summary>
        public static readonly EncryptionOption SSE_KMS = new EncryptionOption("SSE_KMS");
        /// <summary>
        /// Constant SSE_S3 for EncryptionOption
        /// </summary>
        public static readonly EncryptionOption SSE_S3 = new EncryptionOption("SSE_S3");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EncryptionOption(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EncryptionOption FindValue(string value)
        {
            return FindValue<EncryptionOption>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EncryptionOption(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ExecutorState.
    /// </summary>
    public class ExecutorState : ConstantClass
    {

        /// <summary>
        /// Constant CREATED for ExecutorState
        /// </summary>
        public static readonly ExecutorState CREATED = new ExecutorState("CREATED");
        /// <summary>
        /// Constant CREATING for ExecutorState
        /// </summary>
        public static readonly ExecutorState CREATING = new ExecutorState("CREATING");
        /// <summary>
        /// Constant FAILED for ExecutorState
        /// </summary>
        public static readonly ExecutorState FAILED = new ExecutorState("FAILED");
        /// <summary>
        /// Constant REGISTERED for ExecutorState
        /// </summary>
        public static readonly ExecutorState REGISTERED = new ExecutorState("REGISTERED");
        /// <summary>
        /// Constant TERMINATED for ExecutorState
        /// </summary>
        public static readonly ExecutorState TERMINATED = new ExecutorState("TERMINATED");
        /// <summary>
        /// Constant TERMINATING for ExecutorState
        /// </summary>
        public static readonly ExecutorState TERMINATING = new ExecutorState("TERMINATING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ExecutorState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ExecutorState FindValue(string value)
        {
            return FindValue<ExecutorState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ExecutorState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ExecutorType.
    /// </summary>
    public class ExecutorType : ConstantClass
    {

        /// <summary>
        /// Constant COORDINATOR for ExecutorType
        /// </summary>
        public static readonly ExecutorType COORDINATOR = new ExecutorType("COORDINATOR");
        /// <summary>
        /// Constant GATEWAY for ExecutorType
        /// </summary>
        public static readonly ExecutorType GATEWAY = new ExecutorType("GATEWAY");
        /// <summary>
        /// Constant WORKER for ExecutorType
        /// </summary>
        public static readonly ExecutorType WORKER = new ExecutorType("WORKER");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ExecutorType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ExecutorType FindValue(string value)
        {
            return FindValue<ExecutorType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ExecutorType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type NotebookType.
    /// </summary>
    public class NotebookType : ConstantClass
    {

        /// <summary>
        /// Constant IPYNB for NotebookType
        /// </summary>
        public static readonly NotebookType IPYNB = new NotebookType("IPYNB");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public NotebookType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static NotebookType FindValue(string value)
        {
            return FindValue<NotebookType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator NotebookType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type QueryExecutionState.
    /// </summary>
    public class QueryExecutionState : ConstantClass
    {

        /// <summary>
        /// Constant CANCELLED for QueryExecutionState
        /// </summary>
        public static readonly QueryExecutionState CANCELLED = new QueryExecutionState("CANCELLED");
        /// <summary>
        /// Constant FAILED for QueryExecutionState
        /// </summary>
        public static readonly QueryExecutionState FAILED = new QueryExecutionState("FAILED");
        /// <summary>
        /// Constant QUEUED for QueryExecutionState
        /// </summary>
        public static readonly QueryExecutionState QUEUED = new QueryExecutionState("QUEUED");
        /// <summary>
        /// Constant RUNNING for QueryExecutionState
        /// </summary>
        public static readonly QueryExecutionState RUNNING = new QueryExecutionState("RUNNING");
        /// <summary>
        /// Constant SUCCEEDED for QueryExecutionState
        /// </summary>
        public static readonly QueryExecutionState SUCCEEDED = new QueryExecutionState("SUCCEEDED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public QueryExecutionState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static QueryExecutionState FindValue(string value)
        {
            return FindValue<QueryExecutionState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator QueryExecutionState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type S3AclOption.
    /// </summary>
    public class S3AclOption : ConstantClass
    {

        /// <summary>
        /// Constant BUCKET_OWNER_FULL_CONTROL for S3AclOption
        /// </summary>
        public static readonly S3AclOption BUCKET_OWNER_FULL_CONTROL = new S3AclOption("BUCKET_OWNER_FULL_CONTROL");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public S3AclOption(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static S3AclOption FindValue(string value)
        {
            return FindValue<S3AclOption>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator S3AclOption(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SessionState.
    /// </summary>
    public class SessionState : ConstantClass
    {

        /// <summary>
        /// Constant BUSY for SessionState
        /// </summary>
        public static readonly SessionState BUSY = new SessionState("BUSY");
        /// <summary>
        /// Constant CREATED for SessionState
        /// </summary>
        public static readonly SessionState CREATED = new SessionState("CREATED");
        /// <summary>
        /// Constant CREATING for SessionState
        /// </summary>
        public static readonly SessionState CREATING = new SessionState("CREATING");
        /// <summary>
        /// Constant DEGRADED for SessionState
        /// </summary>
        public static readonly SessionState DEGRADED = new SessionState("DEGRADED");
        /// <summary>
        /// Constant FAILED for SessionState
        /// </summary>
        public static readonly SessionState FAILED = new SessionState("FAILED");
        /// <summary>
        /// Constant IDLE for SessionState
        /// </summary>
        public static readonly SessionState IDLE = new SessionState("IDLE");
        /// <summary>
        /// Constant TERMINATED for SessionState
        /// </summary>
        public static readonly SessionState TERMINATED = new SessionState("TERMINATED");
        /// <summary>
        /// Constant TERMINATING for SessionState
        /// </summary>
        public static readonly SessionState TERMINATING = new SessionState("TERMINATING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SessionState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SessionState FindValue(string value)
        {
            return FindValue<SessionState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SessionState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type StatementType.
    /// </summary>
    public class StatementType : ConstantClass
    {

        /// <summary>
        /// Constant DDL for StatementType
        /// </summary>
        public static readonly StatementType DDL = new StatementType("DDL");
        /// <summary>
        /// Constant DML for StatementType
        /// </summary>
        public static readonly StatementType DML = new StatementType("DML");
        /// <summary>
        /// Constant UTILITY for StatementType
        /// </summary>
        public static readonly StatementType UTILITY = new StatementType("UTILITY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public StatementType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static StatementType FindValue(string value)
        {
            return FindValue<StatementType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator StatementType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ThrottleReason.
    /// </summary>
    public class ThrottleReason : ConstantClass
    {

        /// <summary>
        /// Constant CONCURRENT_QUERY_LIMIT_EXCEEDED for ThrottleReason
        /// </summary>
        public static readonly ThrottleReason CONCURRENT_QUERY_LIMIT_EXCEEDED = new ThrottleReason("CONCURRENT_QUERY_LIMIT_EXCEEDED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ThrottleReason(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ThrottleReason FindValue(string value)
        {
            return FindValue<ThrottleReason>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ThrottleReason(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type WorkGroupState.
    /// </summary>
    public class WorkGroupState : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for WorkGroupState
        /// </summary>
        public static readonly WorkGroupState DISABLED = new WorkGroupState("DISABLED");
        /// <summary>
        /// Constant ENABLED for WorkGroupState
        /// </summary>
        public static readonly WorkGroupState ENABLED = new WorkGroupState("ENABLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public WorkGroupState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static WorkGroupState FindValue(string value)
        {
            return FindValue<WorkGroupState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator WorkGroupState(string value)
        {
            return FindValue(value);
        }
    }

}