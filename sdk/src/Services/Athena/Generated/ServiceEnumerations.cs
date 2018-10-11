/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

}