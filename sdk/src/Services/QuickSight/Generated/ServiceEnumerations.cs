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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.QuickSight
{

    /// <summary>
    /// Constants used for properties of type AnalysisErrorType.
    /// </summary>
    public class AnalysisErrorType : ConstantClass
    {

        /// <summary>
        /// Constant ACCESS_DENIED for AnalysisErrorType
        /// </summary>
        public static readonly AnalysisErrorType ACCESS_DENIED = new AnalysisErrorType("ACCESS_DENIED");
        /// <summary>
        /// Constant COLUMN_GEOGRAPHIC_ROLE_MISMATCH for AnalysisErrorType
        /// </summary>
        public static readonly AnalysisErrorType COLUMN_GEOGRAPHIC_ROLE_MISMATCH = new AnalysisErrorType("COLUMN_GEOGRAPHIC_ROLE_MISMATCH");
        /// <summary>
        /// Constant COLUMN_REPLACEMENT_MISSING for AnalysisErrorType
        /// </summary>
        public static readonly AnalysisErrorType COLUMN_REPLACEMENT_MISSING = new AnalysisErrorType("COLUMN_REPLACEMENT_MISSING");
        /// <summary>
        /// Constant COLUMN_TYPE_MISMATCH for AnalysisErrorType
        /// </summary>
        public static readonly AnalysisErrorType COLUMN_TYPE_MISMATCH = new AnalysisErrorType("COLUMN_TYPE_MISMATCH");
        /// <summary>
        /// Constant DATA_SET_NOT_FOUND for AnalysisErrorType
        /// </summary>
        public static readonly AnalysisErrorType DATA_SET_NOT_FOUND = new AnalysisErrorType("DATA_SET_NOT_FOUND");
        /// <summary>
        /// Constant INTERNAL_FAILURE for AnalysisErrorType
        /// </summary>
        public static readonly AnalysisErrorType INTERNAL_FAILURE = new AnalysisErrorType("INTERNAL_FAILURE");
        /// <summary>
        /// Constant PARAMETER_NOT_FOUND for AnalysisErrorType
        /// </summary>
        public static readonly AnalysisErrorType PARAMETER_NOT_FOUND = new AnalysisErrorType("PARAMETER_NOT_FOUND");
        /// <summary>
        /// Constant PARAMETER_TYPE_INVALID for AnalysisErrorType
        /// </summary>
        public static readonly AnalysisErrorType PARAMETER_TYPE_INVALID = new AnalysisErrorType("PARAMETER_TYPE_INVALID");
        /// <summary>
        /// Constant PARAMETER_VALUE_INCOMPATIBLE for AnalysisErrorType
        /// </summary>
        public static readonly AnalysisErrorType PARAMETER_VALUE_INCOMPATIBLE = new AnalysisErrorType("PARAMETER_VALUE_INCOMPATIBLE");
        /// <summary>
        /// Constant SOURCE_NOT_FOUND for AnalysisErrorType
        /// </summary>
        public static readonly AnalysisErrorType SOURCE_NOT_FOUND = new AnalysisErrorType("SOURCE_NOT_FOUND");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AnalysisErrorType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AnalysisErrorType FindValue(string value)
        {
            return FindValue<AnalysisErrorType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AnalysisErrorType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AnalysisFilterAttribute.
    /// </summary>
    public class AnalysisFilterAttribute : ConstantClass
    {

        /// <summary>
        /// Constant QUICKSIGHT_USER for AnalysisFilterAttribute
        /// </summary>
        public static readonly AnalysisFilterAttribute QUICKSIGHT_USER = new AnalysisFilterAttribute("QUICKSIGHT_USER");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AnalysisFilterAttribute(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AnalysisFilterAttribute FindValue(string value)
        {
            return FindValue<AnalysisFilterAttribute>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AnalysisFilterAttribute(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AssignmentStatus.
    /// </summary>
    public class AssignmentStatus : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for AssignmentStatus
        /// </summary>
        public static readonly AssignmentStatus DISABLED = new AssignmentStatus("DISABLED");
        /// <summary>
        /// Constant DRAFT for AssignmentStatus
        /// </summary>
        public static readonly AssignmentStatus DRAFT = new AssignmentStatus("DRAFT");
        /// <summary>
        /// Constant ENABLED for AssignmentStatus
        /// </summary>
        public static readonly AssignmentStatus ENABLED = new AssignmentStatus("ENABLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AssignmentStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AssignmentStatus FindValue(string value)
        {
            return FindValue<AssignmentStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AssignmentStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ColumnDataType.
    /// </summary>
    public class ColumnDataType : ConstantClass
    {

        /// <summary>
        /// Constant DATETIME for ColumnDataType
        /// </summary>
        public static readonly ColumnDataType DATETIME = new ColumnDataType("DATETIME");
        /// <summary>
        /// Constant DECIMAL for ColumnDataType
        /// </summary>
        public static readonly ColumnDataType DECIMAL = new ColumnDataType("DECIMAL");
        /// <summary>
        /// Constant INTEGER for ColumnDataType
        /// </summary>
        public static readonly ColumnDataType INTEGER = new ColumnDataType("INTEGER");
        /// <summary>
        /// Constant STRING for ColumnDataType
        /// </summary>
        public static readonly ColumnDataType STRING = new ColumnDataType("STRING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ColumnDataType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ColumnDataType FindValue(string value)
        {
            return FindValue<ColumnDataType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ColumnDataType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DashboardBehavior.
    /// </summary>
    public class DashboardBehavior : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for DashboardBehavior
        /// </summary>
        public static readonly DashboardBehavior DISABLED = new DashboardBehavior("DISABLED");
        /// <summary>
        /// Constant ENABLED for DashboardBehavior
        /// </summary>
        public static readonly DashboardBehavior ENABLED = new DashboardBehavior("ENABLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DashboardBehavior(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DashboardBehavior FindValue(string value)
        {
            return FindValue<DashboardBehavior>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DashboardBehavior(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DashboardErrorType.
    /// </summary>
    public class DashboardErrorType : ConstantClass
    {

        /// <summary>
        /// Constant ACCESS_DENIED for DashboardErrorType
        /// </summary>
        public static readonly DashboardErrorType ACCESS_DENIED = new DashboardErrorType("ACCESS_DENIED");
        /// <summary>
        /// Constant COLUMN_GEOGRAPHIC_ROLE_MISMATCH for DashboardErrorType
        /// </summary>
        public static readonly DashboardErrorType COLUMN_GEOGRAPHIC_ROLE_MISMATCH = new DashboardErrorType("COLUMN_GEOGRAPHIC_ROLE_MISMATCH");
        /// <summary>
        /// Constant COLUMN_REPLACEMENT_MISSING for DashboardErrorType
        /// </summary>
        public static readonly DashboardErrorType COLUMN_REPLACEMENT_MISSING = new DashboardErrorType("COLUMN_REPLACEMENT_MISSING");
        /// <summary>
        /// Constant COLUMN_TYPE_MISMATCH for DashboardErrorType
        /// </summary>
        public static readonly DashboardErrorType COLUMN_TYPE_MISMATCH = new DashboardErrorType("COLUMN_TYPE_MISMATCH");
        /// <summary>
        /// Constant DATA_SET_NOT_FOUND for DashboardErrorType
        /// </summary>
        public static readonly DashboardErrorType DATA_SET_NOT_FOUND = new DashboardErrorType("DATA_SET_NOT_FOUND");
        /// <summary>
        /// Constant INTERNAL_FAILURE for DashboardErrorType
        /// </summary>
        public static readonly DashboardErrorType INTERNAL_FAILURE = new DashboardErrorType("INTERNAL_FAILURE");
        /// <summary>
        /// Constant PARAMETER_NOT_FOUND for DashboardErrorType
        /// </summary>
        public static readonly DashboardErrorType PARAMETER_NOT_FOUND = new DashboardErrorType("PARAMETER_NOT_FOUND");
        /// <summary>
        /// Constant PARAMETER_TYPE_INVALID for DashboardErrorType
        /// </summary>
        public static readonly DashboardErrorType PARAMETER_TYPE_INVALID = new DashboardErrorType("PARAMETER_TYPE_INVALID");
        /// <summary>
        /// Constant PARAMETER_VALUE_INCOMPATIBLE for DashboardErrorType
        /// </summary>
        public static readonly DashboardErrorType PARAMETER_VALUE_INCOMPATIBLE = new DashboardErrorType("PARAMETER_VALUE_INCOMPATIBLE");
        /// <summary>
        /// Constant SOURCE_NOT_FOUND for DashboardErrorType
        /// </summary>
        public static readonly DashboardErrorType SOURCE_NOT_FOUND = new DashboardErrorType("SOURCE_NOT_FOUND");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DashboardErrorType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DashboardErrorType FindValue(string value)
        {
            return FindValue<DashboardErrorType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DashboardErrorType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DashboardFilterAttribute.
    /// </summary>
    public class DashboardFilterAttribute : ConstantClass
    {

        /// <summary>
        /// Constant QUICKSIGHT_USER for DashboardFilterAttribute
        /// </summary>
        public static readonly DashboardFilterAttribute QUICKSIGHT_USER = new DashboardFilterAttribute("QUICKSIGHT_USER");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DashboardFilterAttribute(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DashboardFilterAttribute FindValue(string value)
        {
            return FindValue<DashboardFilterAttribute>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DashboardFilterAttribute(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DashboardUIState.
    /// </summary>
    public class DashboardUIState : ConstantClass
    {

        /// <summary>
        /// Constant COLLAPSED for DashboardUIState
        /// </summary>
        public static readonly DashboardUIState COLLAPSED = new DashboardUIState("COLLAPSED");
        /// <summary>
        /// Constant EXPANDED for DashboardUIState
        /// </summary>
        public static readonly DashboardUIState EXPANDED = new DashboardUIState("EXPANDED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DashboardUIState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DashboardUIState FindValue(string value)
        {
            return FindValue<DashboardUIState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DashboardUIState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DataSetImportMode.
    /// </summary>
    public class DataSetImportMode : ConstantClass
    {

        /// <summary>
        /// Constant DIRECT_QUERY for DataSetImportMode
        /// </summary>
        public static readonly DataSetImportMode DIRECT_QUERY = new DataSetImportMode("DIRECT_QUERY");
        /// <summary>
        /// Constant SPICE for DataSetImportMode
        /// </summary>
        public static readonly DataSetImportMode SPICE = new DataSetImportMode("SPICE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DataSetImportMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DataSetImportMode FindValue(string value)
        {
            return FindValue<DataSetImportMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DataSetImportMode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DataSourceErrorInfoType.
    /// </summary>
    public class DataSourceErrorInfoType : ConstantClass
    {

        /// <summary>
        /// Constant ACCESS_DENIED for DataSourceErrorInfoType
        /// </summary>
        public static readonly DataSourceErrorInfoType ACCESS_DENIED = new DataSourceErrorInfoType("ACCESS_DENIED");
        /// <summary>
        /// Constant CONFLICT for DataSourceErrorInfoType
        /// </summary>
        public static readonly DataSourceErrorInfoType CONFLICT = new DataSourceErrorInfoType("CONFLICT");
        /// <summary>
        /// Constant COPY_SOURCE_NOT_FOUND for DataSourceErrorInfoType
        /// </summary>
        public static readonly DataSourceErrorInfoType COPY_SOURCE_NOT_FOUND = new DataSourceErrorInfoType("COPY_SOURCE_NOT_FOUND");
        /// <summary>
        /// Constant ENGINE_VERSION_NOT_SUPPORTED for DataSourceErrorInfoType
        /// </summary>
        public static readonly DataSourceErrorInfoType ENGINE_VERSION_NOT_SUPPORTED = new DataSourceErrorInfoType("ENGINE_VERSION_NOT_SUPPORTED");
        /// <summary>
        /// Constant GENERIC_SQL_FAILURE for DataSourceErrorInfoType
        /// </summary>
        public static readonly DataSourceErrorInfoType GENERIC_SQL_FAILURE = new DataSourceErrorInfoType("GENERIC_SQL_FAILURE");
        /// <summary>
        /// Constant TIMEOUT for DataSourceErrorInfoType
        /// </summary>
        public static readonly DataSourceErrorInfoType TIMEOUT = new DataSourceErrorInfoType("TIMEOUT");
        /// <summary>
        /// Constant UNKNOWN for DataSourceErrorInfoType
        /// </summary>
        public static readonly DataSourceErrorInfoType UNKNOWN = new DataSourceErrorInfoType("UNKNOWN");
        /// <summary>
        /// Constant UNKNOWN_HOST for DataSourceErrorInfoType
        /// </summary>
        public static readonly DataSourceErrorInfoType UNKNOWN_HOST = new DataSourceErrorInfoType("UNKNOWN_HOST");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DataSourceErrorInfoType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DataSourceErrorInfoType FindValue(string value)
        {
            return FindValue<DataSourceErrorInfoType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DataSourceErrorInfoType(string value)
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
        /// Constant ADOBE_ANALYTICS for DataSourceType
        /// </summary>
        public static readonly DataSourceType ADOBE_ANALYTICS = new DataSourceType("ADOBE_ANALYTICS");
        /// <summary>
        /// Constant AMAZON_ELASTICSEARCH for DataSourceType
        /// </summary>
        public static readonly DataSourceType AMAZON_ELASTICSEARCH = new DataSourceType("AMAZON_ELASTICSEARCH");
        /// <summary>
        /// Constant ATHENA for DataSourceType
        /// </summary>
        public static readonly DataSourceType ATHENA = new DataSourceType("ATHENA");
        /// <summary>
        /// Constant AURORA for DataSourceType
        /// </summary>
        public static readonly DataSourceType AURORA = new DataSourceType("AURORA");
        /// <summary>
        /// Constant AURORA_POSTGRESQL for DataSourceType
        /// </summary>
        public static readonly DataSourceType AURORA_POSTGRESQL = new DataSourceType("AURORA_POSTGRESQL");
        /// <summary>
        /// Constant AWS_IOT_ANALYTICS for DataSourceType
        /// </summary>
        public static readonly DataSourceType AWS_IOT_ANALYTICS = new DataSourceType("AWS_IOT_ANALYTICS");
        /// <summary>
        /// Constant GITHUB for DataSourceType
        /// </summary>
        public static readonly DataSourceType GITHUB = new DataSourceType("GITHUB");
        /// <summary>
        /// Constant JIRA for DataSourceType
        /// </summary>
        public static readonly DataSourceType JIRA = new DataSourceType("JIRA");
        /// <summary>
        /// Constant MARIADB for DataSourceType
        /// </summary>
        public static readonly DataSourceType MARIADB = new DataSourceType("MARIADB");
        /// <summary>
        /// Constant MYSQL for DataSourceType
        /// </summary>
        public static readonly DataSourceType MYSQL = new DataSourceType("MYSQL");
        /// <summary>
        /// Constant ORACLE for DataSourceType
        /// </summary>
        public static readonly DataSourceType ORACLE = new DataSourceType("ORACLE");
        /// <summary>
        /// Constant POSTGRESQL for DataSourceType
        /// </summary>
        public static readonly DataSourceType POSTGRESQL = new DataSourceType("POSTGRESQL");
        /// <summary>
        /// Constant PRESTO for DataSourceType
        /// </summary>
        public static readonly DataSourceType PRESTO = new DataSourceType("PRESTO");
        /// <summary>
        /// Constant REDSHIFT for DataSourceType
        /// </summary>
        public static readonly DataSourceType REDSHIFT = new DataSourceType("REDSHIFT");
        /// <summary>
        /// Constant S3 for DataSourceType
        /// </summary>
        public static readonly DataSourceType S3 = new DataSourceType("S3");
        /// <summary>
        /// Constant SALESFORCE for DataSourceType
        /// </summary>
        public static readonly DataSourceType SALESFORCE = new DataSourceType("SALESFORCE");
        /// <summary>
        /// Constant SERVICENOW for DataSourceType
        /// </summary>
        public static readonly DataSourceType SERVICENOW = new DataSourceType("SERVICENOW");
        /// <summary>
        /// Constant SNOWFLAKE for DataSourceType
        /// </summary>
        public static readonly DataSourceType SNOWFLAKE = new DataSourceType("SNOWFLAKE");
        /// <summary>
        /// Constant SPARK for DataSourceType
        /// </summary>
        public static readonly DataSourceType SPARK = new DataSourceType("SPARK");
        /// <summary>
        /// Constant SQLSERVER for DataSourceType
        /// </summary>
        public static readonly DataSourceType SQLSERVER = new DataSourceType("SQLSERVER");
        /// <summary>
        /// Constant TERADATA for DataSourceType
        /// </summary>
        public static readonly DataSourceType TERADATA = new DataSourceType("TERADATA");
        /// <summary>
        /// Constant TIMESTREAM for DataSourceType
        /// </summary>
        public static readonly DataSourceType TIMESTREAM = new DataSourceType("TIMESTREAM");
        /// <summary>
        /// Constant TWITTER for DataSourceType
        /// </summary>
        public static readonly DataSourceType TWITTER = new DataSourceType("TWITTER");

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
    /// Constants used for properties of type Edition.
    /// </summary>
    public class Edition : ConstantClass
    {

        /// <summary>
        /// Constant ENTERPRISE for Edition
        /// </summary>
        public static readonly Edition ENTERPRISE = new Edition("ENTERPRISE");
        /// <summary>
        /// Constant STANDARD for Edition
        /// </summary>
        public static readonly Edition STANDARD = new Edition("STANDARD");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Edition(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Edition FindValue(string value)
        {
            return FindValue<Edition>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Edition(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type EmbeddingIdentityType.
    /// </summary>
    public class EmbeddingIdentityType : ConstantClass
    {

        /// <summary>
        /// Constant ANONYMOUS for EmbeddingIdentityType
        /// </summary>
        public static readonly EmbeddingIdentityType ANONYMOUS = new EmbeddingIdentityType("ANONYMOUS");
        /// <summary>
        /// Constant IAM for EmbeddingIdentityType
        /// </summary>
        public static readonly EmbeddingIdentityType IAM = new EmbeddingIdentityType("IAM");
        /// <summary>
        /// Constant QUICKSIGHT for EmbeddingIdentityType
        /// </summary>
        public static readonly EmbeddingIdentityType QUICKSIGHT = new EmbeddingIdentityType("QUICKSIGHT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EmbeddingIdentityType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EmbeddingIdentityType FindValue(string value)
        {
            return FindValue<EmbeddingIdentityType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EmbeddingIdentityType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ExceptionResourceType.
    /// </summary>
    public class ExceptionResourceType : ConstantClass
    {

        /// <summary>
        /// Constant ACCOUNT_SETTINGS for ExceptionResourceType
        /// </summary>
        public static readonly ExceptionResourceType ACCOUNT_SETTINGS = new ExceptionResourceType("ACCOUNT_SETTINGS");
        /// <summary>
        /// Constant DATA_SET for ExceptionResourceType
        /// </summary>
        public static readonly ExceptionResourceType DATA_SET = new ExceptionResourceType("DATA_SET");
        /// <summary>
        /// Constant DATA_SOURCE for ExceptionResourceType
        /// </summary>
        public static readonly ExceptionResourceType DATA_SOURCE = new ExceptionResourceType("DATA_SOURCE");
        /// <summary>
        /// Constant GROUP for ExceptionResourceType
        /// </summary>
        public static readonly ExceptionResourceType GROUP = new ExceptionResourceType("GROUP");
        /// <summary>
        /// Constant IAMPOLICY_ASSIGNMENT for ExceptionResourceType
        /// </summary>
        public static readonly ExceptionResourceType IAMPOLICY_ASSIGNMENT = new ExceptionResourceType("IAMPOLICY_ASSIGNMENT");
        /// <summary>
        /// Constant INGESTION for ExceptionResourceType
        /// </summary>
        public static readonly ExceptionResourceType INGESTION = new ExceptionResourceType("INGESTION");
        /// <summary>
        /// Constant NAMESPACE for ExceptionResourceType
        /// </summary>
        public static readonly ExceptionResourceType NAMESPACE = new ExceptionResourceType("NAMESPACE");
        /// <summary>
        /// Constant USER for ExceptionResourceType
        /// </summary>
        public static readonly ExceptionResourceType USER = new ExceptionResourceType("USER");
        /// <summary>
        /// Constant VPC_CONNECTION for ExceptionResourceType
        /// </summary>
        public static readonly ExceptionResourceType VPC_CONNECTION = new ExceptionResourceType("VPC_CONNECTION");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ExceptionResourceType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ExceptionResourceType FindValue(string value)
        {
            return FindValue<ExceptionResourceType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ExceptionResourceType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type FileFormat.
    /// </summary>
    public class FileFormat : ConstantClass
    {

        /// <summary>
        /// Constant CLF for FileFormat
        /// </summary>
        public static readonly FileFormat CLF = new FileFormat("CLF");
        /// <summary>
        /// Constant CSV for FileFormat
        /// </summary>
        public static readonly FileFormat CSV = new FileFormat("CSV");
        /// <summary>
        /// Constant ELF for FileFormat
        /// </summary>
        public static readonly FileFormat ELF = new FileFormat("ELF");
        /// <summary>
        /// Constant JSON for FileFormat
        /// </summary>
        public static readonly FileFormat JSON = new FileFormat("JSON");
        /// <summary>
        /// Constant TSV for FileFormat
        /// </summary>
        public static readonly FileFormat TSV = new FileFormat("TSV");
        /// <summary>
        /// Constant XLSX for FileFormat
        /// </summary>
        public static readonly FileFormat XLSX = new FileFormat("XLSX");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FileFormat(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FileFormat FindValue(string value)
        {
            return FindValue<FileFormat>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FileFormat(string value)
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
        /// Constant StringEquals for FilterOperator
        /// </summary>
        public static readonly FilterOperator StringEquals = new FilterOperator("StringEquals");

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
    /// Constants used for properties of type GeoSpatialCountryCode.
    /// </summary>
    public class GeoSpatialCountryCode : ConstantClass
    {

        /// <summary>
        /// Constant US for GeoSpatialCountryCode
        /// </summary>
        public static readonly GeoSpatialCountryCode US = new GeoSpatialCountryCode("US");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public GeoSpatialCountryCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static GeoSpatialCountryCode FindValue(string value)
        {
            return FindValue<GeoSpatialCountryCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator GeoSpatialCountryCode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type GeoSpatialDataRole.
    /// </summary>
    public class GeoSpatialDataRole : ConstantClass
    {

        /// <summary>
        /// Constant CITY for GeoSpatialDataRole
        /// </summary>
        public static readonly GeoSpatialDataRole CITY = new GeoSpatialDataRole("CITY");
        /// <summary>
        /// Constant COUNTRY for GeoSpatialDataRole
        /// </summary>
        public static readonly GeoSpatialDataRole COUNTRY = new GeoSpatialDataRole("COUNTRY");
        /// <summary>
        /// Constant COUNTY for GeoSpatialDataRole
        /// </summary>
        public static readonly GeoSpatialDataRole COUNTY = new GeoSpatialDataRole("COUNTY");
        /// <summary>
        /// Constant LATITUDE for GeoSpatialDataRole
        /// </summary>
        public static readonly GeoSpatialDataRole LATITUDE = new GeoSpatialDataRole("LATITUDE");
        /// <summary>
        /// Constant LONGITUDE for GeoSpatialDataRole
        /// </summary>
        public static readonly GeoSpatialDataRole LONGITUDE = new GeoSpatialDataRole("LONGITUDE");
        /// <summary>
        /// Constant POSTCODE for GeoSpatialDataRole
        /// </summary>
        public static readonly GeoSpatialDataRole POSTCODE = new GeoSpatialDataRole("POSTCODE");
        /// <summary>
        /// Constant STATE for GeoSpatialDataRole
        /// </summary>
        public static readonly GeoSpatialDataRole STATE = new GeoSpatialDataRole("STATE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public GeoSpatialDataRole(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static GeoSpatialDataRole FindValue(string value)
        {
            return FindValue<GeoSpatialDataRole>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator GeoSpatialDataRole(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type IdentityStore.
    /// </summary>
    public class IdentityStore : ConstantClass
    {

        /// <summary>
        /// Constant QUICKSIGHT for IdentityStore
        /// </summary>
        public static readonly IdentityStore QUICKSIGHT = new IdentityStore("QUICKSIGHT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public IdentityStore(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static IdentityStore FindValue(string value)
        {
            return FindValue<IdentityStore>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator IdentityStore(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type IdentityType.
    /// </summary>
    public class IdentityType : ConstantClass
    {

        /// <summary>
        /// Constant IAM for IdentityType
        /// </summary>
        public static readonly IdentityType IAM = new IdentityType("IAM");
        /// <summary>
        /// Constant QUICKSIGHT for IdentityType
        /// </summary>
        public static readonly IdentityType QUICKSIGHT = new IdentityType("QUICKSIGHT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public IdentityType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static IdentityType FindValue(string value)
        {
            return FindValue<IdentityType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator IdentityType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type IngestionErrorType.
    /// </summary>
    public class IngestionErrorType : ConstantClass
    {

        /// <summary>
        /// Constant ACCOUNT_CAPACITY_LIMIT_EXCEEDED for IngestionErrorType
        /// </summary>
        public static readonly IngestionErrorType ACCOUNT_CAPACITY_LIMIT_EXCEEDED = new IngestionErrorType("ACCOUNT_CAPACITY_LIMIT_EXCEEDED");
        /// <summary>
        /// Constant CONNECTION_FAILURE for IngestionErrorType
        /// </summary>
        public static readonly IngestionErrorType CONNECTION_FAILURE = new IngestionErrorType("CONNECTION_FAILURE");
        /// <summary>
        /// Constant CUSTOMER_ERROR for IngestionErrorType
        /// </summary>
        public static readonly IngestionErrorType CUSTOMER_ERROR = new IngestionErrorType("CUSTOMER_ERROR");
        /// <summary>
        /// Constant DATA_SET_DELETED for IngestionErrorType
        /// </summary>
        public static readonly IngestionErrorType DATA_SET_DELETED = new IngestionErrorType("DATA_SET_DELETED");
        /// <summary>
        /// Constant DATA_SET_NOT_SPICE for IngestionErrorType
        /// </summary>
        public static readonly IngestionErrorType DATA_SET_NOT_SPICE = new IngestionErrorType("DATA_SET_NOT_SPICE");
        /// <summary>
        /// Constant DATA_SET_SIZE_LIMIT_EXCEEDED for IngestionErrorType
        /// </summary>
        public static readonly IngestionErrorType DATA_SET_SIZE_LIMIT_EXCEEDED = new IngestionErrorType("DATA_SET_SIZE_LIMIT_EXCEEDED");
        /// <summary>
        /// Constant DATA_SOURCE_AUTH_FAILED for IngestionErrorType
        /// </summary>
        public static readonly IngestionErrorType DATA_SOURCE_AUTH_FAILED = new IngestionErrorType("DATA_SOURCE_AUTH_FAILED");
        /// <summary>
        /// Constant DATA_SOURCE_CONNECTION_FAILED for IngestionErrorType
        /// </summary>
        public static readonly IngestionErrorType DATA_SOURCE_CONNECTION_FAILED = new IngestionErrorType("DATA_SOURCE_CONNECTION_FAILED");
        /// <summary>
        /// Constant DATA_SOURCE_NOT_FOUND for IngestionErrorType
        /// </summary>
        public static readonly IngestionErrorType DATA_SOURCE_NOT_FOUND = new IngestionErrorType("DATA_SOURCE_NOT_FOUND");
        /// <summary>
        /// Constant DATA_TOLERANCE_EXCEPTION for IngestionErrorType
        /// </summary>
        public static readonly IngestionErrorType DATA_TOLERANCE_EXCEPTION = new IngestionErrorType("DATA_TOLERANCE_EXCEPTION");
        /// <summary>
        /// Constant FAILURE_TO_ASSUME_ROLE for IngestionErrorType
        /// </summary>
        public static readonly IngestionErrorType FAILURE_TO_ASSUME_ROLE = new IngestionErrorType("FAILURE_TO_ASSUME_ROLE");
        /// <summary>
        /// Constant FAILURE_TO_PROCESS_JSON_FILE for IngestionErrorType
        /// </summary>
        public static readonly IngestionErrorType FAILURE_TO_PROCESS_JSON_FILE = new IngestionErrorType("FAILURE_TO_PROCESS_JSON_FILE");
        /// <summary>
        /// Constant IAM_ROLE_NOT_AVAILABLE for IngestionErrorType
        /// </summary>
        public static readonly IngestionErrorType IAM_ROLE_NOT_AVAILABLE = new IngestionErrorType("IAM_ROLE_NOT_AVAILABLE");
        /// <summary>
        /// Constant INGESTION_CANCELED for IngestionErrorType
        /// </summary>
        public static readonly IngestionErrorType INGESTION_CANCELED = new IngestionErrorType("INGESTION_CANCELED");
        /// <summary>
        /// Constant INGESTION_SUPERSEDED for IngestionErrorType
        /// </summary>
        public static readonly IngestionErrorType INGESTION_SUPERSEDED = new IngestionErrorType("INGESTION_SUPERSEDED");
        /// <summary>
        /// Constant INTERNAL_SERVICE_ERROR for IngestionErrorType
        /// </summary>
        public static readonly IngestionErrorType INTERNAL_SERVICE_ERROR = new IngestionErrorType("INTERNAL_SERVICE_ERROR");
        /// <summary>
        /// Constant INVALID_DATA_SOURCE_CONFIG for IngestionErrorType
        /// </summary>
        public static readonly IngestionErrorType INVALID_DATA_SOURCE_CONFIG = new IngestionErrorType("INVALID_DATA_SOURCE_CONFIG");
        /// <summary>
        /// Constant INVALID_DATAPREP_SYNTAX for IngestionErrorType
        /// </summary>
        public static readonly IngestionErrorType INVALID_DATAPREP_SYNTAX = new IngestionErrorType("INVALID_DATAPREP_SYNTAX");
        /// <summary>
        /// Constant INVALID_DATE_FORMAT for IngestionErrorType
        /// </summary>
        public static readonly IngestionErrorType INVALID_DATE_FORMAT = new IngestionErrorType("INVALID_DATE_FORMAT");
        /// <summary>
        /// Constant IOT_DATA_SET_FILE_EMPTY for IngestionErrorType
        /// </summary>
        public static readonly IngestionErrorType IOT_DATA_SET_FILE_EMPTY = new IngestionErrorType("IOT_DATA_SET_FILE_EMPTY");
        /// <summary>
        /// Constant IOT_FILE_NOT_FOUND for IngestionErrorType
        /// </summary>
        public static readonly IngestionErrorType IOT_FILE_NOT_FOUND = new IngestionErrorType("IOT_FILE_NOT_FOUND");
        /// <summary>
        /// Constant OAUTH_TOKEN_FAILURE for IngestionErrorType
        /// </summary>
        public static readonly IngestionErrorType OAUTH_TOKEN_FAILURE = new IngestionErrorType("OAUTH_TOKEN_FAILURE");
        /// <summary>
        /// Constant PASSWORD_AUTHENTICATION_FAILURE for IngestionErrorType
        /// </summary>
        public static readonly IngestionErrorType PASSWORD_AUTHENTICATION_FAILURE = new IngestionErrorType("PASSWORD_AUTHENTICATION_FAILURE");
        /// <summary>
        /// Constant PERMISSION_DENIED for IngestionErrorType
        /// </summary>
        public static readonly IngestionErrorType PERMISSION_DENIED = new IngestionErrorType("PERMISSION_DENIED");
        /// <summary>
        /// Constant QUERY_TIMEOUT for IngestionErrorType
        /// </summary>
        public static readonly IngestionErrorType QUERY_TIMEOUT = new IngestionErrorType("QUERY_TIMEOUT");
        /// <summary>
        /// Constant ROW_SIZE_LIMIT_EXCEEDED for IngestionErrorType
        /// </summary>
        public static readonly IngestionErrorType ROW_SIZE_LIMIT_EXCEEDED = new IngestionErrorType("ROW_SIZE_LIMIT_EXCEEDED");
        /// <summary>
        /// Constant S3_FILE_INACCESSIBLE for IngestionErrorType
        /// </summary>
        public static readonly IngestionErrorType S3_FILE_INACCESSIBLE = new IngestionErrorType("S3_FILE_INACCESSIBLE");
        /// <summary>
        /// Constant S3_MANIFEST_ERROR for IngestionErrorType
        /// </summary>
        public static readonly IngestionErrorType S3_MANIFEST_ERROR = new IngestionErrorType("S3_MANIFEST_ERROR");
        /// <summary>
        /// Constant S3_UPLOADED_FILE_DELETED for IngestionErrorType
        /// </summary>
        public static readonly IngestionErrorType S3_UPLOADED_FILE_DELETED = new IngestionErrorType("S3_UPLOADED_FILE_DELETED");
        /// <summary>
        /// Constant SOURCE_API_LIMIT_EXCEEDED_FAILURE for IngestionErrorType
        /// </summary>
        public static readonly IngestionErrorType SOURCE_API_LIMIT_EXCEEDED_FAILURE = new IngestionErrorType("SOURCE_API_LIMIT_EXCEEDED_FAILURE");
        /// <summary>
        /// Constant SOURCE_RESOURCE_LIMIT_EXCEEDED for IngestionErrorType
        /// </summary>
        public static readonly IngestionErrorType SOURCE_RESOURCE_LIMIT_EXCEEDED = new IngestionErrorType("SOURCE_RESOURCE_LIMIT_EXCEEDED");
        /// <summary>
        /// Constant SPICE_TABLE_NOT_FOUND for IngestionErrorType
        /// </summary>
        public static readonly IngestionErrorType SPICE_TABLE_NOT_FOUND = new IngestionErrorType("SPICE_TABLE_NOT_FOUND");
        /// <summary>
        /// Constant SQL_EXCEPTION for IngestionErrorType
        /// </summary>
        public static readonly IngestionErrorType SQL_EXCEPTION = new IngestionErrorType("SQL_EXCEPTION");
        /// <summary>
        /// Constant SQL_INVALID_PARAMETER_VALUE for IngestionErrorType
        /// </summary>
        public static readonly IngestionErrorType SQL_INVALID_PARAMETER_VALUE = new IngestionErrorType("SQL_INVALID_PARAMETER_VALUE");
        /// <summary>
        /// Constant SQL_NUMERIC_OVERFLOW for IngestionErrorType
        /// </summary>
        public static readonly IngestionErrorType SQL_NUMERIC_OVERFLOW = new IngestionErrorType("SQL_NUMERIC_OVERFLOW");
        /// <summary>
        /// Constant SQL_SCHEMA_MISMATCH_ERROR for IngestionErrorType
        /// </summary>
        public static readonly IngestionErrorType SQL_SCHEMA_MISMATCH_ERROR = new IngestionErrorType("SQL_SCHEMA_MISMATCH_ERROR");
        /// <summary>
        /// Constant SQL_TABLE_NOT_FOUND for IngestionErrorType
        /// </summary>
        public static readonly IngestionErrorType SQL_TABLE_NOT_FOUND = new IngestionErrorType("SQL_TABLE_NOT_FOUND");
        /// <summary>
        /// Constant SSL_CERTIFICATE_VALIDATION_FAILURE for IngestionErrorType
        /// </summary>
        public static readonly IngestionErrorType SSL_CERTIFICATE_VALIDATION_FAILURE = new IngestionErrorType("SSL_CERTIFICATE_VALIDATION_FAILURE");
        /// <summary>
        /// Constant UNRESOLVABLE_HOST for IngestionErrorType
        /// </summary>
        public static readonly IngestionErrorType UNRESOLVABLE_HOST = new IngestionErrorType("UNRESOLVABLE_HOST");
        /// <summary>
        /// Constant UNROUTABLE_HOST for IngestionErrorType
        /// </summary>
        public static readonly IngestionErrorType UNROUTABLE_HOST = new IngestionErrorType("UNROUTABLE_HOST");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public IngestionErrorType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static IngestionErrorType FindValue(string value)
        {
            return FindValue<IngestionErrorType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator IngestionErrorType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type IngestionRequestSource.
    /// </summary>
    public class IngestionRequestSource : ConstantClass
    {

        /// <summary>
        /// Constant MANUAL for IngestionRequestSource
        /// </summary>
        public static readonly IngestionRequestSource MANUAL = new IngestionRequestSource("MANUAL");
        /// <summary>
        /// Constant SCHEDULED for IngestionRequestSource
        /// </summary>
        public static readonly IngestionRequestSource SCHEDULED = new IngestionRequestSource("SCHEDULED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public IngestionRequestSource(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static IngestionRequestSource FindValue(string value)
        {
            return FindValue<IngestionRequestSource>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator IngestionRequestSource(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type IngestionRequestType.
    /// </summary>
    public class IngestionRequestType : ConstantClass
    {

        /// <summary>
        /// Constant EDIT for IngestionRequestType
        /// </summary>
        public static readonly IngestionRequestType EDIT = new IngestionRequestType("EDIT");
        /// <summary>
        /// Constant FULL_REFRESH for IngestionRequestType
        /// </summary>
        public static readonly IngestionRequestType FULL_REFRESH = new IngestionRequestType("FULL_REFRESH");
        /// <summary>
        /// Constant INCREMENTAL_REFRESH for IngestionRequestType
        /// </summary>
        public static readonly IngestionRequestType INCREMENTAL_REFRESH = new IngestionRequestType("INCREMENTAL_REFRESH");
        /// <summary>
        /// Constant INITIAL_INGESTION for IngestionRequestType
        /// </summary>
        public static readonly IngestionRequestType INITIAL_INGESTION = new IngestionRequestType("INITIAL_INGESTION");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public IngestionRequestType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static IngestionRequestType FindValue(string value)
        {
            return FindValue<IngestionRequestType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator IngestionRequestType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type IngestionStatus.
    /// </summary>
    public class IngestionStatus : ConstantClass
    {

        /// <summary>
        /// Constant CANCELLED for IngestionStatus
        /// </summary>
        public static readonly IngestionStatus CANCELLED = new IngestionStatus("CANCELLED");
        /// <summary>
        /// Constant COMPLETED for IngestionStatus
        /// </summary>
        public static readonly IngestionStatus COMPLETED = new IngestionStatus("COMPLETED");
        /// <summary>
        /// Constant FAILED for IngestionStatus
        /// </summary>
        public static readonly IngestionStatus FAILED = new IngestionStatus("FAILED");
        /// <summary>
        /// Constant INITIALIZED for IngestionStatus
        /// </summary>
        public static readonly IngestionStatus INITIALIZED = new IngestionStatus("INITIALIZED");
        /// <summary>
        /// Constant QUEUED for IngestionStatus
        /// </summary>
        public static readonly IngestionStatus QUEUED = new IngestionStatus("QUEUED");
        /// <summary>
        /// Constant RUNNING for IngestionStatus
        /// </summary>
        public static readonly IngestionStatus RUNNING = new IngestionStatus("RUNNING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public IngestionStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static IngestionStatus FindValue(string value)
        {
            return FindValue<IngestionStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator IngestionStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type InputColumnDataType.
    /// </summary>
    public class InputColumnDataType : ConstantClass
    {

        /// <summary>
        /// Constant BIT for InputColumnDataType
        /// </summary>
        public static readonly InputColumnDataType BIT = new InputColumnDataType("BIT");
        /// <summary>
        /// Constant BOOLEAN for InputColumnDataType
        /// </summary>
        public static readonly InputColumnDataType BOOLEAN = new InputColumnDataType("BOOLEAN");
        /// <summary>
        /// Constant DATETIME for InputColumnDataType
        /// </summary>
        public static readonly InputColumnDataType DATETIME = new InputColumnDataType("DATETIME");
        /// <summary>
        /// Constant DECIMAL for InputColumnDataType
        /// </summary>
        public static readonly InputColumnDataType DECIMAL = new InputColumnDataType("DECIMAL");
        /// <summary>
        /// Constant INTEGER for InputColumnDataType
        /// </summary>
        public static readonly InputColumnDataType INTEGER = new InputColumnDataType("INTEGER");
        /// <summary>
        /// Constant JSON for InputColumnDataType
        /// </summary>
        public static readonly InputColumnDataType JSON = new InputColumnDataType("JSON");
        /// <summary>
        /// Constant STRING for InputColumnDataType
        /// </summary>
        public static readonly InputColumnDataType STRING = new InputColumnDataType("STRING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public InputColumnDataType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static InputColumnDataType FindValue(string value)
        {
            return FindValue<InputColumnDataType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator InputColumnDataType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type JoinType.
    /// </summary>
    public class JoinType : ConstantClass
    {

        /// <summary>
        /// Constant INNER for JoinType
        /// </summary>
        public static readonly JoinType INNER = new JoinType("INNER");
        /// <summary>
        /// Constant LEFT for JoinType
        /// </summary>
        public static readonly JoinType LEFT = new JoinType("LEFT");
        /// <summary>
        /// Constant OUTER for JoinType
        /// </summary>
        public static readonly JoinType OUTER = new JoinType("OUTER");
        /// <summary>
        /// Constant RIGHT for JoinType
        /// </summary>
        public static readonly JoinType RIGHT = new JoinType("RIGHT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public JoinType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static JoinType FindValue(string value)
        {
            return FindValue<JoinType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator JoinType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type NamespaceErrorType.
    /// </summary>
    public class NamespaceErrorType : ConstantClass
    {

        /// <summary>
        /// Constant INTERNAL_SERVICE_ERROR for NamespaceErrorType
        /// </summary>
        public static readonly NamespaceErrorType INTERNAL_SERVICE_ERROR = new NamespaceErrorType("INTERNAL_SERVICE_ERROR");
        /// <summary>
        /// Constant PERMISSION_DENIED for NamespaceErrorType
        /// </summary>
        public static readonly NamespaceErrorType PERMISSION_DENIED = new NamespaceErrorType("PERMISSION_DENIED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public NamespaceErrorType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static NamespaceErrorType FindValue(string value)
        {
            return FindValue<NamespaceErrorType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator NamespaceErrorType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type NamespaceStatus.
    /// </summary>
    public class NamespaceStatus : ConstantClass
    {

        /// <summary>
        /// Constant CREATED for NamespaceStatus
        /// </summary>
        public static readonly NamespaceStatus CREATED = new NamespaceStatus("CREATED");
        /// <summary>
        /// Constant CREATING for NamespaceStatus
        /// </summary>
        public static readonly NamespaceStatus CREATING = new NamespaceStatus("CREATING");
        /// <summary>
        /// Constant DELETING for NamespaceStatus
        /// </summary>
        public static readonly NamespaceStatus DELETING = new NamespaceStatus("DELETING");
        /// <summary>
        /// Constant NON_RETRYABLE_FAILURE for NamespaceStatus
        /// </summary>
        public static readonly NamespaceStatus NON_RETRYABLE_FAILURE = new NamespaceStatus("NON_RETRYABLE_FAILURE");
        /// <summary>
        /// Constant RETRYABLE_FAILURE for NamespaceStatus
        /// </summary>
        public static readonly NamespaceStatus RETRYABLE_FAILURE = new NamespaceStatus("RETRYABLE_FAILURE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public NamespaceStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static NamespaceStatus FindValue(string value)
        {
            return FindValue<NamespaceStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator NamespaceStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ResourceStatus.
    /// </summary>
    public class ResourceStatus : ConstantClass
    {

        /// <summary>
        /// Constant CREATION_FAILED for ResourceStatus
        /// </summary>
        public static readonly ResourceStatus CREATION_FAILED = new ResourceStatus("CREATION_FAILED");
        /// <summary>
        /// Constant CREATION_IN_PROGRESS for ResourceStatus
        /// </summary>
        public static readonly ResourceStatus CREATION_IN_PROGRESS = new ResourceStatus("CREATION_IN_PROGRESS");
        /// <summary>
        /// Constant CREATION_SUCCESSFUL for ResourceStatus
        /// </summary>
        public static readonly ResourceStatus CREATION_SUCCESSFUL = new ResourceStatus("CREATION_SUCCESSFUL");
        /// <summary>
        /// Constant DELETED for ResourceStatus
        /// </summary>
        public static readonly ResourceStatus DELETED = new ResourceStatus("DELETED");
        /// <summary>
        /// Constant UPDATE_FAILED for ResourceStatus
        /// </summary>
        public static readonly ResourceStatus UPDATE_FAILED = new ResourceStatus("UPDATE_FAILED");
        /// <summary>
        /// Constant UPDATE_IN_PROGRESS for ResourceStatus
        /// </summary>
        public static readonly ResourceStatus UPDATE_IN_PROGRESS = new ResourceStatus("UPDATE_IN_PROGRESS");
        /// <summary>
        /// Constant UPDATE_SUCCESSFUL for ResourceStatus
        /// </summary>
        public static readonly ResourceStatus UPDATE_SUCCESSFUL = new ResourceStatus("UPDATE_SUCCESSFUL");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ResourceStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ResourceStatus FindValue(string value)
        {
            return FindValue<ResourceStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ResourceStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RowLevelPermissionPolicy.
    /// </summary>
    public class RowLevelPermissionPolicy : ConstantClass
    {

        /// <summary>
        /// Constant DENY_ACCESS for RowLevelPermissionPolicy
        /// </summary>
        public static readonly RowLevelPermissionPolicy DENY_ACCESS = new RowLevelPermissionPolicy("DENY_ACCESS");
        /// <summary>
        /// Constant GRANT_ACCESS for RowLevelPermissionPolicy
        /// </summary>
        public static readonly RowLevelPermissionPolicy GRANT_ACCESS = new RowLevelPermissionPolicy("GRANT_ACCESS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RowLevelPermissionPolicy(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RowLevelPermissionPolicy FindValue(string value)
        {
            return FindValue<RowLevelPermissionPolicy>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RowLevelPermissionPolicy(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TemplateErrorType.
    /// </summary>
    public class TemplateErrorType : ConstantClass
    {

        /// <summary>
        /// Constant ACCESS_DENIED for TemplateErrorType
        /// </summary>
        public static readonly TemplateErrorType ACCESS_DENIED = new TemplateErrorType("ACCESS_DENIED");
        /// <summary>
        /// Constant DATA_SET_NOT_FOUND for TemplateErrorType
        /// </summary>
        public static readonly TemplateErrorType DATA_SET_NOT_FOUND = new TemplateErrorType("DATA_SET_NOT_FOUND");
        /// <summary>
        /// Constant INTERNAL_FAILURE for TemplateErrorType
        /// </summary>
        public static readonly TemplateErrorType INTERNAL_FAILURE = new TemplateErrorType("INTERNAL_FAILURE");
        /// <summary>
        /// Constant SOURCE_NOT_FOUND for TemplateErrorType
        /// </summary>
        public static readonly TemplateErrorType SOURCE_NOT_FOUND = new TemplateErrorType("SOURCE_NOT_FOUND");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TemplateErrorType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TemplateErrorType FindValue(string value)
        {
            return FindValue<TemplateErrorType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TemplateErrorType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TextQualifier.
    /// </summary>
    public class TextQualifier : ConstantClass
    {

        /// <summary>
        /// Constant DOUBLE_QUOTE for TextQualifier
        /// </summary>
        public static readonly TextQualifier DOUBLE_QUOTE = new TextQualifier("DOUBLE_QUOTE");
        /// <summary>
        /// Constant SINGLE_QUOTE for TextQualifier
        /// </summary>
        public static readonly TextQualifier SINGLE_QUOTE = new TextQualifier("SINGLE_QUOTE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TextQualifier(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TextQualifier FindValue(string value)
        {
            return FindValue<TextQualifier>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TextQualifier(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ThemeErrorType.
    /// </summary>
    public class ThemeErrorType : ConstantClass
    {

        /// <summary>
        /// Constant INTERNAL_FAILURE for ThemeErrorType
        /// </summary>
        public static readonly ThemeErrorType INTERNAL_FAILURE = new ThemeErrorType("INTERNAL_FAILURE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ThemeErrorType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ThemeErrorType FindValue(string value)
        {
            return FindValue<ThemeErrorType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ThemeErrorType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ThemeType.
    /// </summary>
    public class ThemeType : ConstantClass
    {

        /// <summary>
        /// Constant ALL for ThemeType
        /// </summary>
        public static readonly ThemeType ALL = new ThemeType("ALL");
        /// <summary>
        /// Constant CUSTOM for ThemeType
        /// </summary>
        public static readonly ThemeType CUSTOM = new ThemeType("CUSTOM");
        /// <summary>
        /// Constant QUICKSIGHT for ThemeType
        /// </summary>
        public static readonly ThemeType QUICKSIGHT = new ThemeType("QUICKSIGHT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ThemeType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ThemeType FindValue(string value)
        {
            return FindValue<ThemeType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ThemeType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type UserRole.
    /// </summary>
    public class UserRole : ConstantClass
    {

        /// <summary>
        /// Constant ADMIN for UserRole
        /// </summary>
        public static readonly UserRole ADMIN = new UserRole("ADMIN");
        /// <summary>
        /// Constant AUTHOR for UserRole
        /// </summary>
        public static readonly UserRole AUTHOR = new UserRole("AUTHOR");
        /// <summary>
        /// Constant READER for UserRole
        /// </summary>
        public static readonly UserRole READER = new UserRole("READER");
        /// <summary>
        /// Constant RESTRICTED_AUTHOR for UserRole
        /// </summary>
        public static readonly UserRole RESTRICTED_AUTHOR = new UserRole("RESTRICTED_AUTHOR");
        /// <summary>
        /// Constant RESTRICTED_READER for UserRole
        /// </summary>
        public static readonly UserRole RESTRICTED_READER = new UserRole("RESTRICTED_READER");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public UserRole(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static UserRole FindValue(string value)
        {
            return FindValue<UserRole>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator UserRole(string value)
        {
            return FindValue(value);
        }
    }

}