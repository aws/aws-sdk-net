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
 * Do not modify this file. This file is generated from the discovery-2015-11-01.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.ApplicationDiscoveryService
{

    /// <summary>
    /// Constants used for properties of type AgentStatus.
    /// </summary>
    public class AgentStatus : ConstantClass
    {

        /// <summary>
        /// Constant BLACKLISTED for AgentStatus
        /// </summary>
        public static readonly AgentStatus BLACKLISTED = new AgentStatus("BLACKLISTED");
        /// <summary>
        /// Constant HEALTHY for AgentStatus
        /// </summary>
        public static readonly AgentStatus HEALTHY = new AgentStatus("HEALTHY");
        /// <summary>
        /// Constant RUNNING for AgentStatus
        /// </summary>
        public static readonly AgentStatus RUNNING = new AgentStatus("RUNNING");
        /// <summary>
        /// Constant SHUTDOWN for AgentStatus
        /// </summary>
        public static readonly AgentStatus SHUTDOWN = new AgentStatus("SHUTDOWN");
        /// <summary>
        /// Constant UNHEALTHY for AgentStatus
        /// </summary>
        public static readonly AgentStatus UNHEALTHY = new AgentStatus("UNHEALTHY");
        /// <summary>
        /// Constant UNKNOWN for AgentStatus
        /// </summary>
        public static readonly AgentStatus UNKNOWN = new AgentStatus("UNKNOWN");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AgentStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AgentStatus FindValue(string value)
        {
            return FindValue<AgentStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AgentStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type BatchDeleteConfigurationTaskStatus.
    /// </summary>
    public class BatchDeleteConfigurationTaskStatus : ConstantClass
    {

        /// <summary>
        /// Constant COMPLETED for BatchDeleteConfigurationTaskStatus
        /// </summary>
        public static readonly BatchDeleteConfigurationTaskStatus COMPLETED = new BatchDeleteConfigurationTaskStatus("COMPLETED");
        /// <summary>
        /// Constant DELETING for BatchDeleteConfigurationTaskStatus
        /// </summary>
        public static readonly BatchDeleteConfigurationTaskStatus DELETING = new BatchDeleteConfigurationTaskStatus("DELETING");
        /// <summary>
        /// Constant FAILED for BatchDeleteConfigurationTaskStatus
        /// </summary>
        public static readonly BatchDeleteConfigurationTaskStatus FAILED = new BatchDeleteConfigurationTaskStatus("FAILED");
        /// <summary>
        /// Constant INITIALIZING for BatchDeleteConfigurationTaskStatus
        /// </summary>
        public static readonly BatchDeleteConfigurationTaskStatus INITIALIZING = new BatchDeleteConfigurationTaskStatus("INITIALIZING");
        /// <summary>
        /// Constant VALIDATING for BatchDeleteConfigurationTaskStatus
        /// </summary>
        public static readonly BatchDeleteConfigurationTaskStatus VALIDATING = new BatchDeleteConfigurationTaskStatus("VALIDATING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public BatchDeleteConfigurationTaskStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static BatchDeleteConfigurationTaskStatus FindValue(string value)
        {
            return FindValue<BatchDeleteConfigurationTaskStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator BatchDeleteConfigurationTaskStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type BatchDeleteImportDataErrorCode.
    /// </summary>
    public class BatchDeleteImportDataErrorCode : ConstantClass
    {

        /// <summary>
        /// Constant INTERNAL_SERVER_ERROR for BatchDeleteImportDataErrorCode
        /// </summary>
        public static readonly BatchDeleteImportDataErrorCode INTERNAL_SERVER_ERROR = new BatchDeleteImportDataErrorCode("INTERNAL_SERVER_ERROR");
        /// <summary>
        /// Constant NOT_FOUND for BatchDeleteImportDataErrorCode
        /// </summary>
        public static readonly BatchDeleteImportDataErrorCode NOT_FOUND = new BatchDeleteImportDataErrorCode("NOT_FOUND");
        /// <summary>
        /// Constant OVER_LIMIT for BatchDeleteImportDataErrorCode
        /// </summary>
        public static readonly BatchDeleteImportDataErrorCode OVER_LIMIT = new BatchDeleteImportDataErrorCode("OVER_LIMIT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public BatchDeleteImportDataErrorCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static BatchDeleteImportDataErrorCode FindValue(string value)
        {
            return FindValue<BatchDeleteImportDataErrorCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator BatchDeleteImportDataErrorCode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ConfigurationItemType.
    /// </summary>
    public class ConfigurationItemType : ConstantClass
    {

        /// <summary>
        /// Constant APPLICATION for ConfigurationItemType
        /// </summary>
        public static readonly ConfigurationItemType APPLICATION = new ConfigurationItemType("APPLICATION");
        /// <summary>
        /// Constant CONNECTION for ConfigurationItemType
        /// </summary>
        public static readonly ConfigurationItemType CONNECTION = new ConfigurationItemType("CONNECTION");
        /// <summary>
        /// Constant PROCESS for ConfigurationItemType
        /// </summary>
        public static readonly ConfigurationItemType PROCESS = new ConfigurationItemType("PROCESS");
        /// <summary>
        /// Constant SERVER for ConfigurationItemType
        /// </summary>
        public static readonly ConfigurationItemType SERVER = new ConfigurationItemType("SERVER");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ConfigurationItemType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ConfigurationItemType FindValue(string value)
        {
            return FindValue<ConfigurationItemType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ConfigurationItemType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ContinuousExportStatus.
    /// </summary>
    public class ContinuousExportStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for ContinuousExportStatus
        /// </summary>
        public static readonly ContinuousExportStatus ACTIVE = new ContinuousExportStatus("ACTIVE");
        /// <summary>
        /// Constant ERROR for ContinuousExportStatus
        /// </summary>
        public static readonly ContinuousExportStatus ERROR = new ContinuousExportStatus("ERROR");
        /// <summary>
        /// Constant INACTIVE for ContinuousExportStatus
        /// </summary>
        public static readonly ContinuousExportStatus INACTIVE = new ContinuousExportStatus("INACTIVE");
        /// <summary>
        /// Constant START_FAILED for ContinuousExportStatus
        /// </summary>
        public static readonly ContinuousExportStatus START_FAILED = new ContinuousExportStatus("START_FAILED");
        /// <summary>
        /// Constant START_IN_PROGRESS for ContinuousExportStatus
        /// </summary>
        public static readonly ContinuousExportStatus START_IN_PROGRESS = new ContinuousExportStatus("START_IN_PROGRESS");
        /// <summary>
        /// Constant STOP_FAILED for ContinuousExportStatus
        /// </summary>
        public static readonly ContinuousExportStatus STOP_FAILED = new ContinuousExportStatus("STOP_FAILED");
        /// <summary>
        /// Constant STOP_IN_PROGRESS for ContinuousExportStatus
        /// </summary>
        public static readonly ContinuousExportStatus STOP_IN_PROGRESS = new ContinuousExportStatus("STOP_IN_PROGRESS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ContinuousExportStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ContinuousExportStatus FindValue(string value)
        {
            return FindValue<ContinuousExportStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ContinuousExportStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DataSource.
    /// </summary>
    public class DataSource : ConstantClass
    {

        /// <summary>
        /// Constant AGENT for DataSource
        /// </summary>
        public static readonly DataSource AGENT = new DataSource("AGENT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DataSource(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DataSource FindValue(string value)
        {
            return FindValue<DataSource>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DataSource(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DeleteAgentErrorCode.
    /// </summary>
    public class DeleteAgentErrorCode : ConstantClass
    {

        /// <summary>
        /// Constant AGENT_IN_USE for DeleteAgentErrorCode
        /// </summary>
        public static readonly DeleteAgentErrorCode AGENT_IN_USE = new DeleteAgentErrorCode("AGENT_IN_USE");
        /// <summary>
        /// Constant INTERNAL_SERVER_ERROR for DeleteAgentErrorCode
        /// </summary>
        public static readonly DeleteAgentErrorCode INTERNAL_SERVER_ERROR = new DeleteAgentErrorCode("INTERNAL_SERVER_ERROR");
        /// <summary>
        /// Constant NOT_FOUND for DeleteAgentErrorCode
        /// </summary>
        public static readonly DeleteAgentErrorCode NOT_FOUND = new DeleteAgentErrorCode("NOT_FOUND");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DeleteAgentErrorCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DeleteAgentErrorCode FindValue(string value)
        {
            return FindValue<DeleteAgentErrorCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DeleteAgentErrorCode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DeletionConfigurationItemType.
    /// </summary>
    public class DeletionConfigurationItemType : ConstantClass
    {

        /// <summary>
        /// Constant SERVER for DeletionConfigurationItemType
        /// </summary>
        public static readonly DeletionConfigurationItemType SERVER = new DeletionConfigurationItemType("SERVER");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DeletionConfigurationItemType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DeletionConfigurationItemType FindValue(string value)
        {
            return FindValue<DeletionConfigurationItemType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DeletionConfigurationItemType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ExportDataFormat.
    /// </summary>
    public class ExportDataFormat : ConstantClass
    {

        /// <summary>
        /// Constant CSV for ExportDataFormat
        /// </summary>
        public static readonly ExportDataFormat CSV = new ExportDataFormat("CSV");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ExportDataFormat(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ExportDataFormat FindValue(string value)
        {
            return FindValue<ExportDataFormat>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ExportDataFormat(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ExportStatus.
    /// </summary>
    public class ExportStatus : ConstantClass
    {

        /// <summary>
        /// Constant FAILED for ExportStatus
        /// </summary>
        public static readonly ExportStatus FAILED = new ExportStatus("FAILED");
        /// <summary>
        /// Constant IN_PROGRESS for ExportStatus
        /// </summary>
        public static readonly ExportStatus IN_PROGRESS = new ExportStatus("IN_PROGRESS");
        /// <summary>
        /// Constant SUCCEEDED for ExportStatus
        /// </summary>
        public static readonly ExportStatus SUCCEEDED = new ExportStatus("SUCCEEDED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ExportStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ExportStatus FindValue(string value)
        {
            return FindValue<ExportStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ExportStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type FileClassification.
    /// </summary>
    public class FileClassification : ConstantClass
    {

        /// <summary>
        /// Constant IMPORT_TEMPLATE for FileClassification
        /// </summary>
        public static readonly FileClassification IMPORT_TEMPLATE = new FileClassification("IMPORT_TEMPLATE");
        /// <summary>
        /// Constant MODELIZEIT_EXPORT for FileClassification
        /// </summary>
        public static readonly FileClassification MODELIZEIT_EXPORT = new FileClassification("MODELIZEIT_EXPORT");
        /// <summary>
        /// Constant RVTOOLS_EXPORT for FileClassification
        /// </summary>
        public static readonly FileClassification RVTOOLS_EXPORT = new FileClassification("RVTOOLS_EXPORT");
        /// <summary>
        /// Constant VMWARE_NSX_EXPORT for FileClassification
        /// </summary>
        public static readonly FileClassification VMWARE_NSX_EXPORT = new FileClassification("VMWARE_NSX_EXPORT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FileClassification(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FileClassification FindValue(string value)
        {
            return FindValue<FileClassification>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FileClassification(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ImportStatus.
    /// </summary>
    public class ImportStatus : ConstantClass
    {

        /// <summary>
        /// Constant DELETE_COMPLETE for ImportStatus
        /// </summary>
        public static readonly ImportStatus DELETE_COMPLETE = new ImportStatus("DELETE_COMPLETE");
        /// <summary>
        /// Constant DELETE_FAILED for ImportStatus
        /// </summary>
        public static readonly ImportStatus DELETE_FAILED = new ImportStatus("DELETE_FAILED");
        /// <summary>
        /// Constant DELETE_FAILED_LIMIT_EXCEEDED for ImportStatus
        /// </summary>
        public static readonly ImportStatus DELETE_FAILED_LIMIT_EXCEEDED = new ImportStatus("DELETE_FAILED_LIMIT_EXCEEDED");
        /// <summary>
        /// Constant DELETE_IN_PROGRESS for ImportStatus
        /// </summary>
        public static readonly ImportStatus DELETE_IN_PROGRESS = new ImportStatus("DELETE_IN_PROGRESS");
        /// <summary>
        /// Constant IMPORT_COMPLETE for ImportStatus
        /// </summary>
        public static readonly ImportStatus IMPORT_COMPLETE = new ImportStatus("IMPORT_COMPLETE");
        /// <summary>
        /// Constant IMPORT_COMPLETE_WITH_ERRORS for ImportStatus
        /// </summary>
        public static readonly ImportStatus IMPORT_COMPLETE_WITH_ERRORS = new ImportStatus("IMPORT_COMPLETE_WITH_ERRORS");
        /// <summary>
        /// Constant IMPORT_FAILED for ImportStatus
        /// </summary>
        public static readonly ImportStatus IMPORT_FAILED = new ImportStatus("IMPORT_FAILED");
        /// <summary>
        /// Constant IMPORT_FAILED_RECORD_LIMIT_EXCEEDED for ImportStatus
        /// </summary>
        public static readonly ImportStatus IMPORT_FAILED_RECORD_LIMIT_EXCEEDED = new ImportStatus("IMPORT_FAILED_RECORD_LIMIT_EXCEEDED");
        /// <summary>
        /// Constant IMPORT_FAILED_SERVER_LIMIT_EXCEEDED for ImportStatus
        /// </summary>
        public static readonly ImportStatus IMPORT_FAILED_SERVER_LIMIT_EXCEEDED = new ImportStatus("IMPORT_FAILED_SERVER_LIMIT_EXCEEDED");
        /// <summary>
        /// Constant IMPORT_FAILED_UNSUPPORTED_FILE_TYPE for ImportStatus
        /// </summary>
        public static readonly ImportStatus IMPORT_FAILED_UNSUPPORTED_FILE_TYPE = new ImportStatus("IMPORT_FAILED_UNSUPPORTED_FILE_TYPE");
        /// <summary>
        /// Constant IMPORT_IN_PROGRESS for ImportStatus
        /// </summary>
        public static readonly ImportStatus IMPORT_IN_PROGRESS = new ImportStatus("IMPORT_IN_PROGRESS");
        /// <summary>
        /// Constant INTERNAL_ERROR for ImportStatus
        /// </summary>
        public static readonly ImportStatus INTERNAL_ERROR = new ImportStatus("INTERNAL_ERROR");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ImportStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ImportStatus FindValue(string value)
        {
            return FindValue<ImportStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ImportStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ImportTaskFilterName.
    /// </summary>
    public class ImportTaskFilterName : ConstantClass
    {

        /// <summary>
        /// Constant FILE_CLASSIFICATION for ImportTaskFilterName
        /// </summary>
        public static readonly ImportTaskFilterName FILE_CLASSIFICATION = new ImportTaskFilterName("FILE_CLASSIFICATION");
        /// <summary>
        /// Constant IMPORT_TASK_ID for ImportTaskFilterName
        /// </summary>
        public static readonly ImportTaskFilterName IMPORT_TASK_ID = new ImportTaskFilterName("IMPORT_TASK_ID");
        /// <summary>
        /// Constant NAME for ImportTaskFilterName
        /// </summary>
        public static readonly ImportTaskFilterName NAME = new ImportTaskFilterName("NAME");
        /// <summary>
        /// Constant STATUS for ImportTaskFilterName
        /// </summary>
        public static readonly ImportTaskFilterName STATUS = new ImportTaskFilterName("STATUS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ImportTaskFilterName(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ImportTaskFilterName FindValue(string value)
        {
            return FindValue<ImportTaskFilterName>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ImportTaskFilterName(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type OfferingClass.
    /// </summary>
    public class OfferingClass : ConstantClass
    {

        /// <summary>
        /// Constant CONVERTIBLE for OfferingClass
        /// </summary>
        public static readonly OfferingClass CONVERTIBLE = new OfferingClass("CONVERTIBLE");
        /// <summary>
        /// Constant STANDARD for OfferingClass
        /// </summary>
        public static readonly OfferingClass STANDARD = new OfferingClass("STANDARD");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public OfferingClass(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static OfferingClass FindValue(string value)
        {
            return FindValue<OfferingClass>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator OfferingClass(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type OrderString.
    /// </summary>
    public class OrderString : ConstantClass
    {

        /// <summary>
        /// Constant ASC for OrderString
        /// </summary>
        public static readonly OrderString ASC = new OrderString("ASC");
        /// <summary>
        /// Constant DESC for OrderString
        /// </summary>
        public static readonly OrderString DESC = new OrderString("DESC");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public OrderString(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static OrderString FindValue(string value)
        {
            return FindValue<OrderString>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator OrderString(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PurchasingOption.
    /// </summary>
    public class PurchasingOption : ConstantClass
    {

        /// <summary>
        /// Constant ALL_UPFRONT for PurchasingOption
        /// </summary>
        public static readonly PurchasingOption ALL_UPFRONT = new PurchasingOption("ALL_UPFRONT");
        /// <summary>
        /// Constant NO_UPFRONT for PurchasingOption
        /// </summary>
        public static readonly PurchasingOption NO_UPFRONT = new PurchasingOption("NO_UPFRONT");
        /// <summary>
        /// Constant PARTIAL_UPFRONT for PurchasingOption
        /// </summary>
        public static readonly PurchasingOption PARTIAL_UPFRONT = new PurchasingOption("PARTIAL_UPFRONT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PurchasingOption(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PurchasingOption FindValue(string value)
        {
            return FindValue<PurchasingOption>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PurchasingOption(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Tenancy.
    /// </summary>
    public class Tenancy : ConstantClass
    {

        /// <summary>
        /// Constant DEDICATED for Tenancy
        /// </summary>
        public static readonly Tenancy DEDICATED = new Tenancy("DEDICATED");
        /// <summary>
        /// Constant SHARED for Tenancy
        /// </summary>
        public static readonly Tenancy SHARED = new Tenancy("SHARED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Tenancy(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Tenancy FindValue(string value)
        {
            return FindValue<Tenancy>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Tenancy(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TermLength.
    /// </summary>
    public class TermLength : ConstantClass
    {

        /// <summary>
        /// Constant ONE_YEAR for TermLength
        /// </summary>
        public static readonly TermLength ONE_YEAR = new TermLength("ONE_YEAR");
        /// <summary>
        /// Constant THREE_YEAR for TermLength
        /// </summary>
        public static readonly TermLength THREE_YEAR = new TermLength("THREE_YEAR");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TermLength(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TermLength FindValue(string value)
        {
            return FindValue<TermLength>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TermLength(string value)
        {
            return FindValue(value);
        }
    }

}