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
 * Do not modify this file. This file is generated from the fsx-2018-03-01.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.FSx
{

    /// <summary>
    /// Constants used for properties of type ActiveDirectoryErrorType.
    /// </summary>
    public class ActiveDirectoryErrorType : ConstantClass
    {

        /// <summary>
        /// Constant DOMAIN_NOT_FOUND for ActiveDirectoryErrorType
        /// </summary>
        public static readonly ActiveDirectoryErrorType DOMAIN_NOT_FOUND = new ActiveDirectoryErrorType("DOMAIN_NOT_FOUND");
        /// <summary>
        /// Constant INCOMPATIBLE_DOMAIN_MODE for ActiveDirectoryErrorType
        /// </summary>
        public static readonly ActiveDirectoryErrorType INCOMPATIBLE_DOMAIN_MODE = new ActiveDirectoryErrorType("INCOMPATIBLE_DOMAIN_MODE");
        /// <summary>
        /// Constant INVALID_DOMAIN_STAGE for ActiveDirectoryErrorType
        /// </summary>
        public static readonly ActiveDirectoryErrorType INVALID_DOMAIN_STAGE = new ActiveDirectoryErrorType("INVALID_DOMAIN_STAGE");
        /// <summary>
        /// Constant WRONG_VPC for ActiveDirectoryErrorType
        /// </summary>
        public static readonly ActiveDirectoryErrorType WRONG_VPC = new ActiveDirectoryErrorType("WRONG_VPC");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ActiveDirectoryErrorType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ActiveDirectoryErrorType FindValue(string value)
        {
            return FindValue<ActiveDirectoryErrorType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ActiveDirectoryErrorType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type BackupLifecycle.
    /// </summary>
    public class BackupLifecycle : ConstantClass
    {

        /// <summary>
        /// Constant AVAILABLE for BackupLifecycle
        /// </summary>
        public static readonly BackupLifecycle AVAILABLE = new BackupLifecycle("AVAILABLE");
        /// <summary>
        /// Constant CREATING for BackupLifecycle
        /// </summary>
        public static readonly BackupLifecycle CREATING = new BackupLifecycle("CREATING");
        /// <summary>
        /// Constant DELETED for BackupLifecycle
        /// </summary>
        public static readonly BackupLifecycle DELETED = new BackupLifecycle("DELETED");
        /// <summary>
        /// Constant FAILED for BackupLifecycle
        /// </summary>
        public static readonly BackupLifecycle FAILED = new BackupLifecycle("FAILED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public BackupLifecycle(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static BackupLifecycle FindValue(string value)
        {
            return FindValue<BackupLifecycle>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator BackupLifecycle(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type BackupType.
    /// </summary>
    public class BackupType : ConstantClass
    {

        /// <summary>
        /// Constant AUTOMATIC for BackupType
        /// </summary>
        public static readonly BackupType AUTOMATIC = new BackupType("AUTOMATIC");
        /// <summary>
        /// Constant USER_INITIATED for BackupType
        /// </summary>
        public static readonly BackupType USER_INITIATED = new BackupType("USER_INITIATED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public BackupType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static BackupType FindValue(string value)
        {
            return FindValue<BackupType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator BackupType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type FileSystemLifecycle.
    /// </summary>
    public class FileSystemLifecycle : ConstantClass
    {

        /// <summary>
        /// Constant AVAILABLE for FileSystemLifecycle
        /// </summary>
        public static readonly FileSystemLifecycle AVAILABLE = new FileSystemLifecycle("AVAILABLE");
        /// <summary>
        /// Constant CREATING for FileSystemLifecycle
        /// </summary>
        public static readonly FileSystemLifecycle CREATING = new FileSystemLifecycle("CREATING");
        /// <summary>
        /// Constant DELETING for FileSystemLifecycle
        /// </summary>
        public static readonly FileSystemLifecycle DELETING = new FileSystemLifecycle("DELETING");
        /// <summary>
        /// Constant FAILED for FileSystemLifecycle
        /// </summary>
        public static readonly FileSystemLifecycle FAILED = new FileSystemLifecycle("FAILED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FileSystemLifecycle(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FileSystemLifecycle FindValue(string value)
        {
            return FindValue<FileSystemLifecycle>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FileSystemLifecycle(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type FileSystemMaintenanceOperation.
    /// </summary>
    public class FileSystemMaintenanceOperation : ConstantClass
    {

        /// <summary>
        /// Constant BACKING_UP for FileSystemMaintenanceOperation
        /// </summary>
        public static readonly FileSystemMaintenanceOperation BACKING_UP = new FileSystemMaintenanceOperation("BACKING_UP");
        /// <summary>
        /// Constant PATCHING for FileSystemMaintenanceOperation
        /// </summary>
        public static readonly FileSystemMaintenanceOperation PATCHING = new FileSystemMaintenanceOperation("PATCHING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FileSystemMaintenanceOperation(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FileSystemMaintenanceOperation FindValue(string value)
        {
            return FindValue<FileSystemMaintenanceOperation>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FileSystemMaintenanceOperation(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type FileSystemType.
    /// </summary>
    public class FileSystemType : ConstantClass
    {

        /// <summary>
        /// Constant LUSTRE for FileSystemType
        /// </summary>
        public static readonly FileSystemType LUSTRE = new FileSystemType("LUSTRE");
        /// <summary>
        /// Constant WINDOWS for FileSystemType
        /// </summary>
        public static readonly FileSystemType WINDOWS = new FileSystemType("WINDOWS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FileSystemType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FileSystemType FindValue(string value)
        {
            return FindValue<FileSystemType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FileSystemType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type FilterName.
    /// </summary>
    public class FilterName : ConstantClass
    {

        /// <summary>
        /// Constant BackupType for FilterName
        /// </summary>
        public static readonly FilterName BackupType = new FilterName("backup-type");
        /// <summary>
        /// Constant FileSystemId for FilterName
        /// </summary>
        public static readonly FilterName FileSystemId = new FilterName("file-system-id");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FilterName(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FilterName FindValue(string value)
        {
            return FindValue<FilterName>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FilterName(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ServiceLimit.
    /// </summary>
    public class ServiceLimit : ConstantClass
    {

        /// <summary>
        /// Constant FILE_SYSTEM_COUNT for ServiceLimit
        /// </summary>
        public static readonly ServiceLimit FILE_SYSTEM_COUNT = new ServiceLimit("FILE_SYSTEM_COUNT");
        /// <summary>
        /// Constant TOTAL_STORAGE for ServiceLimit
        /// </summary>
        public static readonly ServiceLimit TOTAL_STORAGE = new ServiceLimit("TOTAL_STORAGE");
        /// <summary>
        /// Constant TOTAL_THROUGHPUT_CAPACITY for ServiceLimit
        /// </summary>
        public static readonly ServiceLimit TOTAL_THROUGHPUT_CAPACITY = new ServiceLimit("TOTAL_THROUGHPUT_CAPACITY");
        /// <summary>
        /// Constant TOTAL_USER_INITIATED_BACKUPS for ServiceLimit
        /// </summary>
        public static readonly ServiceLimit TOTAL_USER_INITIATED_BACKUPS = new ServiceLimit("TOTAL_USER_INITIATED_BACKUPS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ServiceLimit(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ServiceLimit FindValue(string value)
        {
            return FindValue<ServiceLimit>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ServiceLimit(string value)
        {
            return FindValue(value);
        }
    }

}