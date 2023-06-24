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
 * Do not modify this file. This file is generated from the finspace-data-2020-07-13.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.FinSpaceData
{

    /// <summary>
    /// Constants used for properties of type ApiAccess.
    /// </summary>
    public class ApiAccess : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for ApiAccess
        /// </summary>
        public static readonly ApiAccess DISABLED = new ApiAccess("DISABLED");
        /// <summary>
        /// Constant ENABLED for ApiAccess
        /// </summary>
        public static readonly ApiAccess ENABLED = new ApiAccess("ENABLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ApiAccess(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ApiAccess FindValue(string value)
        {
            return FindValue<ApiAccess>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ApiAccess(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ApplicationPermission.
    /// </summary>
    public class ApplicationPermission : ConstantClass
    {

        /// <summary>
        /// Constant AccessNotebooks for ApplicationPermission
        /// </summary>
        public static readonly ApplicationPermission AccessNotebooks = new ApplicationPermission("AccessNotebooks");
        /// <summary>
        /// Constant CreateDataset for ApplicationPermission
        /// </summary>
        public static readonly ApplicationPermission CreateDataset = new ApplicationPermission("CreateDataset");
        /// <summary>
        /// Constant GetTemporaryCredentials for ApplicationPermission
        /// </summary>
        public static readonly ApplicationPermission GetTemporaryCredentials = new ApplicationPermission("GetTemporaryCredentials");
        /// <summary>
        /// Constant ManageAttributeSets for ApplicationPermission
        /// </summary>
        public static readonly ApplicationPermission ManageAttributeSets = new ApplicationPermission("ManageAttributeSets");
        /// <summary>
        /// Constant ManageClusters for ApplicationPermission
        /// </summary>
        public static readonly ApplicationPermission ManageClusters = new ApplicationPermission("ManageClusters");
        /// <summary>
        /// Constant ManageUsersAndGroups for ApplicationPermission
        /// </summary>
        public static readonly ApplicationPermission ManageUsersAndGroups = new ApplicationPermission("ManageUsersAndGroups");
        /// <summary>
        /// Constant ViewAuditData for ApplicationPermission
        /// </summary>
        public static readonly ApplicationPermission ViewAuditData = new ApplicationPermission("ViewAuditData");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ApplicationPermission(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ApplicationPermission FindValue(string value)
        {
            return FindValue<ApplicationPermission>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ApplicationPermission(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ChangeType.
    /// </summary>
    public class ChangeType : ConstantClass
    {

        /// <summary>
        /// Constant APPEND for ChangeType
        /// </summary>
        public static readonly ChangeType APPEND = new ChangeType("APPEND");
        /// <summary>
        /// Constant MODIFY for ChangeType
        /// </summary>
        public static readonly ChangeType MODIFY = new ChangeType("MODIFY");
        /// <summary>
        /// Constant REPLACE for ChangeType
        /// </summary>
        public static readonly ChangeType REPLACE = new ChangeType("REPLACE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ChangeType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ChangeType FindValue(string value)
        {
            return FindValue<ChangeType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ChangeType(string value)
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
        /// Constant BIGINT for ColumnDataType
        /// </summary>
        public static readonly ColumnDataType BIGINT = new ColumnDataType("BIGINT");
        /// <summary>
        /// Constant BINARY for ColumnDataType
        /// </summary>
        public static readonly ColumnDataType BINARY = new ColumnDataType("BINARY");
        /// <summary>
        /// Constant BOOLEAN for ColumnDataType
        /// </summary>
        public static readonly ColumnDataType BOOLEAN = new ColumnDataType("BOOLEAN");
        /// <summary>
        /// Constant CHAR for ColumnDataType
        /// </summary>
        public static readonly ColumnDataType CHAR = new ColumnDataType("CHAR");
        /// <summary>
        /// Constant DATE for ColumnDataType
        /// </summary>
        public static readonly ColumnDataType DATE = new ColumnDataType("DATE");
        /// <summary>
        /// Constant DATETIME for ColumnDataType
        /// </summary>
        public static readonly ColumnDataType DATETIME = new ColumnDataType("DATETIME");
        /// <summary>
        /// Constant DOUBLE for ColumnDataType
        /// </summary>
        public static readonly ColumnDataType DOUBLE = new ColumnDataType("DOUBLE");
        /// <summary>
        /// Constant FLOAT for ColumnDataType
        /// </summary>
        public static readonly ColumnDataType FLOAT = new ColumnDataType("FLOAT");
        /// <summary>
        /// Constant INTEGER for ColumnDataType
        /// </summary>
        public static readonly ColumnDataType INTEGER = new ColumnDataType("INTEGER");
        /// <summary>
        /// Constant SMALLINT for ColumnDataType
        /// </summary>
        public static readonly ColumnDataType SMALLINT = new ColumnDataType("SMALLINT");
        /// <summary>
        /// Constant STRING for ColumnDataType
        /// </summary>
        public static readonly ColumnDataType STRING = new ColumnDataType("STRING");
        /// <summary>
        /// Constant TINYINT for ColumnDataType
        /// </summary>
        public static readonly ColumnDataType TINYINT = new ColumnDataType("TINYINT");

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
    /// Constants used for properties of type DatasetKind.
    /// </summary>
    public class DatasetKind : ConstantClass
    {

        /// <summary>
        /// Constant NON_TABULAR for DatasetKind
        /// </summary>
        public static readonly DatasetKind NON_TABULAR = new DatasetKind("NON_TABULAR");
        /// <summary>
        /// Constant TABULAR for DatasetKind
        /// </summary>
        public static readonly DatasetKind TABULAR = new DatasetKind("TABULAR");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DatasetKind(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DatasetKind FindValue(string value)
        {
            return FindValue<DatasetKind>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DatasetKind(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DatasetStatus.
    /// </summary>
    public class DatasetStatus : ConstantClass
    {

        /// <summary>
        /// Constant FAILED for DatasetStatus
        /// </summary>
        public static readonly DatasetStatus FAILED = new DatasetStatus("FAILED");
        /// <summary>
        /// Constant PENDING for DatasetStatus
        /// </summary>
        public static readonly DatasetStatus PENDING = new DatasetStatus("PENDING");
        /// <summary>
        /// Constant RUNNING for DatasetStatus
        /// </summary>
        public static readonly DatasetStatus RUNNING = new DatasetStatus("RUNNING");
        /// <summary>
        /// Constant SUCCESS for DatasetStatus
        /// </summary>
        public static readonly DatasetStatus SUCCESS = new DatasetStatus("SUCCESS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DatasetStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DatasetStatus FindValue(string value)
        {
            return FindValue<DatasetStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DatasetStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DataViewStatus.
    /// </summary>
    public class DataViewStatus : ConstantClass
    {

        /// <summary>
        /// Constant CANCELLED for DataViewStatus
        /// </summary>
        public static readonly DataViewStatus CANCELLED = new DataViewStatus("CANCELLED");
        /// <summary>
        /// Constant FAILED for DataViewStatus
        /// </summary>
        public static readonly DataViewStatus FAILED = new DataViewStatus("FAILED");
        /// <summary>
        /// Constant FAILED_CLEANUP_FAILED for DataViewStatus
        /// </summary>
        public static readonly DataViewStatus FAILED_CLEANUP_FAILED = new DataViewStatus("FAILED_CLEANUP_FAILED");
        /// <summary>
        /// Constant PENDING for DataViewStatus
        /// </summary>
        public static readonly DataViewStatus PENDING = new DataViewStatus("PENDING");
        /// <summary>
        /// Constant RUNNING for DataViewStatus
        /// </summary>
        public static readonly DataViewStatus RUNNING = new DataViewStatus("RUNNING");
        /// <summary>
        /// Constant STARTING for DataViewStatus
        /// </summary>
        public static readonly DataViewStatus STARTING = new DataViewStatus("STARTING");
        /// <summary>
        /// Constant SUCCESS for DataViewStatus
        /// </summary>
        public static readonly DataViewStatus SUCCESS = new DataViewStatus("SUCCESS");
        /// <summary>
        /// Constant TIMEOUT for DataViewStatus
        /// </summary>
        public static readonly DataViewStatus TIMEOUT = new DataViewStatus("TIMEOUT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DataViewStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DataViewStatus FindValue(string value)
        {
            return FindValue<DataViewStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DataViewStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ErrorCategory.
    /// </summary>
    public class ErrorCategory : ConstantClass
    {

        /// <summary>
        /// Constant ACCESS_DENIED for ErrorCategory
        /// </summary>
        public static readonly ErrorCategory ACCESS_DENIED = new ErrorCategory("ACCESS_DENIED");
        /// <summary>
        /// Constant CANCELLED for ErrorCategory
        /// </summary>
        public static readonly ErrorCategory CANCELLED = new ErrorCategory("CANCELLED");
        /// <summary>
        /// Constant INTERNAL_SERVICE_EXCEPTION for ErrorCategory
        /// </summary>
        public static readonly ErrorCategory INTERNAL_SERVICE_EXCEPTION = new ErrorCategory("INTERNAL_SERVICE_EXCEPTION");
        /// <summary>
        /// Constant RESOURCE_NOT_FOUND for ErrorCategory
        /// </summary>
        public static readonly ErrorCategory RESOURCE_NOT_FOUND = new ErrorCategory("RESOURCE_NOT_FOUND");
        /// <summary>
        /// Constant SERVICE_QUOTA_EXCEEDED for ErrorCategory
        /// </summary>
        public static readonly ErrorCategory SERVICE_QUOTA_EXCEEDED = new ErrorCategory("SERVICE_QUOTA_EXCEEDED");
        /// <summary>
        /// Constant THROTTLING for ErrorCategory
        /// </summary>
        public static readonly ErrorCategory THROTTLING = new ErrorCategory("THROTTLING");
        /// <summary>
        /// Constant USER_RECOVERABLE for ErrorCategory
        /// </summary>
        public static readonly ErrorCategory USER_RECOVERABLE = new ErrorCategory("USER_RECOVERABLE");
        /// <summary>
        /// Constant VALIDATION for ErrorCategory
        /// </summary>
        public static readonly ErrorCategory VALIDATION = new ErrorCategory("VALIDATION");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ErrorCategory(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ErrorCategory FindValue(string value)
        {
            return FindValue<ErrorCategory>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ErrorCategory(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ExportFileFormat.
    /// </summary>
    public class ExportFileFormat : ConstantClass
    {

        /// <summary>
        /// Constant DELIMITED_TEXT for ExportFileFormat
        /// </summary>
        public static readonly ExportFileFormat DELIMITED_TEXT = new ExportFileFormat("DELIMITED_TEXT");
        /// <summary>
        /// Constant PARQUET for ExportFileFormat
        /// </summary>
        public static readonly ExportFileFormat PARQUET = new ExportFileFormat("PARQUET");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ExportFileFormat(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ExportFileFormat FindValue(string value)
        {
            return FindValue<ExportFileFormat>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ExportFileFormat(string value)
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
        /// Constant FAILED for IngestionStatus
        /// </summary>
        public static readonly IngestionStatus FAILED = new IngestionStatus("FAILED");
        /// <summary>
        /// Constant PENDING for IngestionStatus
        /// </summary>
        public static readonly IngestionStatus PENDING = new IngestionStatus("PENDING");
        /// <summary>
        /// Constant RUNNING for IngestionStatus
        /// </summary>
        public static readonly IngestionStatus RUNNING = new IngestionStatus("RUNNING");
        /// <summary>
        /// Constant STOP_REQUESTED for IngestionStatus
        /// </summary>
        public static readonly IngestionStatus STOP_REQUESTED = new IngestionStatus("STOP_REQUESTED");
        /// <summary>
        /// Constant SUCCESS for IngestionStatus
        /// </summary>
        public static readonly IngestionStatus SUCCESS = new IngestionStatus("SUCCESS");

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
    /// Constants used for properties of type LocationType.
    /// </summary>
    public class LocationType : ConstantClass
    {

        /// <summary>
        /// Constant INGESTION for LocationType
        /// </summary>
        public static readonly LocationType INGESTION = new LocationType("INGESTION");
        /// <summary>
        /// Constant SAGEMAKER for LocationType
        /// </summary>
        public static readonly LocationType SAGEMAKER = new LocationType("SAGEMAKER");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public LocationType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LocationType FindValue(string value)
        {
            return FindValue<LocationType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator LocationType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PermissionGroupMembershipStatus.
    /// </summary>
    public class PermissionGroupMembershipStatus : ConstantClass
    {

        /// <summary>
        /// Constant ADDITION_IN_PROGRESS for PermissionGroupMembershipStatus
        /// </summary>
        public static readonly PermissionGroupMembershipStatus ADDITION_IN_PROGRESS = new PermissionGroupMembershipStatus("ADDITION_IN_PROGRESS");
        /// <summary>
        /// Constant ADDITION_SUCCESS for PermissionGroupMembershipStatus
        /// </summary>
        public static readonly PermissionGroupMembershipStatus ADDITION_SUCCESS = new PermissionGroupMembershipStatus("ADDITION_SUCCESS");
        /// <summary>
        /// Constant REMOVAL_IN_PROGRESS for PermissionGroupMembershipStatus
        /// </summary>
        public static readonly PermissionGroupMembershipStatus REMOVAL_IN_PROGRESS = new PermissionGroupMembershipStatus("REMOVAL_IN_PROGRESS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PermissionGroupMembershipStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PermissionGroupMembershipStatus FindValue(string value)
        {
            return FindValue<PermissionGroupMembershipStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PermissionGroupMembershipStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type UserStatus.
    /// </summary>
    public class UserStatus : ConstantClass
    {

        /// <summary>
        /// Constant CREATING for UserStatus
        /// </summary>
        public static readonly UserStatus CREATING = new UserStatus("CREATING");
        /// <summary>
        /// Constant DISABLED for UserStatus
        /// </summary>
        public static readonly UserStatus DISABLED = new UserStatus("DISABLED");
        /// <summary>
        /// Constant ENABLED for UserStatus
        /// </summary>
        public static readonly UserStatus ENABLED = new UserStatus("ENABLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public UserStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static UserStatus FindValue(string value)
        {
            return FindValue<UserStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator UserStatus(string value)
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
        /// Constant APP_USER for UserType
        /// </summary>
        public static readonly UserType APP_USER = new UserType("APP_USER");
        /// <summary>
        /// Constant SUPER_USER for UserType
        /// </summary>
        public static readonly UserType SUPER_USER = new UserType("SUPER_USER");

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