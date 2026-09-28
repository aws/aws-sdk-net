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
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using Amazon.Runtime;

namespace Amazon.SupplyChain
{
    /// <summary>
    /// Constants used for properties of type ConfigurationJobStatus.
    /// </summary>
    public class ConfigurationJobStatus : ConstantClass
    {
        /// <summary>
        /// Constant FAILED for ConfigurationJobStatus
        /// </summary>
        public static readonly ConfigurationJobStatus FAILED = new ConfigurationJobStatus("FAILED");

        /// <summary>
        /// Constant IN_PROGRESS for ConfigurationJobStatus
        /// </summary>
        public static readonly ConfigurationJobStatus IN_PROGRESS = new ConfigurationJobStatus("IN_PROGRESS");

        /// <summary>
        /// Constant NEW for ConfigurationJobStatus
        /// </summary>
        public static readonly ConfigurationJobStatus NEW = new ConfigurationJobStatus("NEW");

        /// <summary>
        /// Constant QUEUED for ConfigurationJobStatus
        /// </summary>
        public static readonly ConfigurationJobStatus QUEUED = new ConfigurationJobStatus("QUEUED");

        /// <summary>
        /// Constant SUCCESS for ConfigurationJobStatus
        /// </summary>
        public static readonly ConfigurationJobStatus SUCCESS = new ConfigurationJobStatus("SUCCESS");

        /// <summary>
        /// Constructs a custom ConfigurationJobStatus for a value not among the defined constants.
        /// </summary>
        public ConfigurationJobStatus(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ConfigurationJobStatus FindValue(string value)
        {
            return FindValue<ConfigurationJobStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ConfigurationJobStatus(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type DataIntegrationEventDatasetLoadStatus.
    /// </summary>
    public class DataIntegrationEventDatasetLoadStatus : ConstantClass
    {
        /// <summary>
        /// Constant FAILED for DataIntegrationEventDatasetLoadStatus
        /// </summary>
        public static readonly DataIntegrationEventDatasetLoadStatus FAILED = new DataIntegrationEventDatasetLoadStatus("FAILED");

        /// <summary>
        /// Constant IN_PROGRESS for DataIntegrationEventDatasetLoadStatus
        /// </summary>
        public static readonly DataIntegrationEventDatasetLoadStatus IN_PROGRESS = new DataIntegrationEventDatasetLoadStatus("IN_PROGRESS");

        /// <summary>
        /// Constant SUCCEEDED for DataIntegrationEventDatasetLoadStatus
        /// </summary>
        public static readonly DataIntegrationEventDatasetLoadStatus SUCCEEDED = new DataIntegrationEventDatasetLoadStatus("SUCCEEDED");

        /// <summary>
        /// Constructs a custom DataIntegrationEventDatasetLoadStatus for a value not among the defined constants.
        /// </summary>
        public DataIntegrationEventDatasetLoadStatus(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DataIntegrationEventDatasetLoadStatus FindValue(string value)
        {
            return FindValue<DataIntegrationEventDatasetLoadStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DataIntegrationEventDatasetLoadStatus(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type DataIntegrationEventDatasetOperationType.
    /// </summary>
    public class DataIntegrationEventDatasetOperationType : ConstantClass
    {
        /// <summary>
        /// Constant APPEND for DataIntegrationEventDatasetOperationType
        /// </summary>
        public static readonly DataIntegrationEventDatasetOperationType APPEND = new DataIntegrationEventDatasetOperationType("APPEND");

        /// <summary>
        /// Constant DELETE for DataIntegrationEventDatasetOperationType
        /// </summary>
        public static readonly DataIntegrationEventDatasetOperationType DELETE = new DataIntegrationEventDatasetOperationType("DELETE");

        /// <summary>
        /// Constant UPSERT for DataIntegrationEventDatasetOperationType
        /// </summary>
        public static readonly DataIntegrationEventDatasetOperationType UPSERT = new DataIntegrationEventDatasetOperationType("UPSERT");

        /// <summary>
        /// Constructs a custom DataIntegrationEventDatasetOperationType for a value not among the defined constants.
        /// </summary>
        public DataIntegrationEventDatasetOperationType(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DataIntegrationEventDatasetOperationType FindValue(string value)
        {
            return FindValue<DataIntegrationEventDatasetOperationType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DataIntegrationEventDatasetOperationType(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type DataIntegrationEventType.
    /// </summary>
    public class DataIntegrationEventType : ConstantClass
    {
        /// <summary>
        /// Constant ScnDataDataset for DataIntegrationEventType
        /// </summary>
        public static readonly DataIntegrationEventType ScnDataDataset = new DataIntegrationEventType("scn.data.dataset");

        /// <summary>
        /// Constant ScnDataForecast for DataIntegrationEventType
        /// </summary>
        public static readonly DataIntegrationEventType ScnDataForecast = new DataIntegrationEventType("scn.data.forecast");

        /// <summary>
        /// Constant ScnDataInboundorder for DataIntegrationEventType
        /// </summary>
        public static readonly DataIntegrationEventType ScnDataInboundorder = new DataIntegrationEventType("scn.data.inboundorder");

        /// <summary>
        /// Constant ScnDataInboundorderline for DataIntegrationEventType
        /// </summary>
        public static readonly DataIntegrationEventType ScnDataInboundorderline = new DataIntegrationEventType("scn.data.inboundorderline");

        /// <summary>
        /// Constant ScnDataInboundorderlineschedule for DataIntegrationEventType
        /// </summary>
        public static readonly DataIntegrationEventType ScnDataInboundorderlineschedule = new DataIntegrationEventType("scn.data.inboundorderlineschedule");

        /// <summary>
        /// Constant ScnDataInventorylevel for DataIntegrationEventType
        /// </summary>
        public static readonly DataIntegrationEventType ScnDataInventorylevel = new DataIntegrationEventType("scn.data.inventorylevel");

        /// <summary>
        /// Constant ScnDataOutboundorderline for DataIntegrationEventType
        /// </summary>
        public static readonly DataIntegrationEventType ScnDataOutboundorderline = new DataIntegrationEventType("scn.data.outboundorderline");

        /// <summary>
        /// Constant ScnDataOutboundshipment for DataIntegrationEventType
        /// </summary>
        public static readonly DataIntegrationEventType ScnDataOutboundshipment = new DataIntegrationEventType("scn.data.outboundshipment");

        /// <summary>
        /// Constant ScnDataProcessheader for DataIntegrationEventType
        /// </summary>
        public static readonly DataIntegrationEventType ScnDataProcessheader = new DataIntegrationEventType("scn.data.processheader");

        /// <summary>
        /// Constant ScnDataProcessoperation for DataIntegrationEventType
        /// </summary>
        public static readonly DataIntegrationEventType ScnDataProcessoperation = new DataIntegrationEventType("scn.data.processoperation");

        /// <summary>
        /// Constant ScnDataProcessproduct for DataIntegrationEventType
        /// </summary>
        public static readonly DataIntegrationEventType ScnDataProcessproduct = new DataIntegrationEventType("scn.data.processproduct");

        /// <summary>
        /// Constant ScnDataReservation for DataIntegrationEventType
        /// </summary>
        public static readonly DataIntegrationEventType ScnDataReservation = new DataIntegrationEventType("scn.data.reservation");

        /// <summary>
        /// Constant ScnDataShipment for DataIntegrationEventType
        /// </summary>
        public static readonly DataIntegrationEventType ScnDataShipment = new DataIntegrationEventType("scn.data.shipment");

        /// <summary>
        /// Constant ScnDataShipmentstop for DataIntegrationEventType
        /// </summary>
        public static readonly DataIntegrationEventType ScnDataShipmentstop = new DataIntegrationEventType("scn.data.shipmentstop");

        /// <summary>
        /// Constant ScnDataShipmentstoporder for DataIntegrationEventType
        /// </summary>
        public static readonly DataIntegrationEventType ScnDataShipmentstoporder = new DataIntegrationEventType("scn.data.shipmentstoporder");

        /// <summary>
        /// Constant ScnDataSupplyplan for DataIntegrationEventType
        /// </summary>
        public static readonly DataIntegrationEventType ScnDataSupplyplan = new DataIntegrationEventType("scn.data.supplyplan");

        /// <summary>
        /// Constructs a custom DataIntegrationEventType for a value not among the defined constants.
        /// </summary>
        public DataIntegrationEventType(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DataIntegrationEventType FindValue(string value)
        {
            return FindValue<DataIntegrationEventType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DataIntegrationEventType(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type DataIntegrationFlowDedupeStrategyType.
    /// </summary>
    public class DataIntegrationFlowDedupeStrategyType : ConstantClass
    {
        /// <summary>
        /// Constant FIELD_PRIORITY for DataIntegrationFlowDedupeStrategyType
        /// </summary>
        public static readonly DataIntegrationFlowDedupeStrategyType FIELD_PRIORITY = new DataIntegrationFlowDedupeStrategyType("FIELD_PRIORITY");

        /// <summary>
        /// Constructs a custom DataIntegrationFlowDedupeStrategyType for a value not among the defined constants.
        /// </summary>
        public DataIntegrationFlowDedupeStrategyType(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DataIntegrationFlowDedupeStrategyType FindValue(string value)
        {
            return FindValue<DataIntegrationFlowDedupeStrategyType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DataIntegrationFlowDedupeStrategyType(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type DataIntegrationFlowExecutionStatus.
    /// </summary>
    public class DataIntegrationFlowExecutionStatus : ConstantClass
    {
        /// <summary>
        /// Constant FAILED for DataIntegrationFlowExecutionStatus
        /// </summary>
        public static readonly DataIntegrationFlowExecutionStatus FAILED = new DataIntegrationFlowExecutionStatus("FAILED");

        /// <summary>
        /// Constant IN_PROGRESS for DataIntegrationFlowExecutionStatus
        /// </summary>
        public static readonly DataIntegrationFlowExecutionStatus IN_PROGRESS = new DataIntegrationFlowExecutionStatus("IN_PROGRESS");

        /// <summary>
        /// Constant SUCCEEDED for DataIntegrationFlowExecutionStatus
        /// </summary>
        public static readonly DataIntegrationFlowExecutionStatus SUCCEEDED = new DataIntegrationFlowExecutionStatus("SUCCEEDED");

        /// <summary>
        /// Constructs a custom DataIntegrationFlowExecutionStatus for a value not among the defined constants.
        /// </summary>
        public DataIntegrationFlowExecutionStatus(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DataIntegrationFlowExecutionStatus FindValue(string value)
        {
            return FindValue<DataIntegrationFlowExecutionStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DataIntegrationFlowExecutionStatus(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type DataIntegrationFlowFieldPriorityDedupeSortOrder.
    /// </summary>
    public class DataIntegrationFlowFieldPriorityDedupeSortOrder : ConstantClass
    {
        /// <summary>
        /// Constant ASC for DataIntegrationFlowFieldPriorityDedupeSortOrder
        /// </summary>
        public static readonly DataIntegrationFlowFieldPriorityDedupeSortOrder ASC = new DataIntegrationFlowFieldPriorityDedupeSortOrder("ASC");

        /// <summary>
        /// Constant DESC for DataIntegrationFlowFieldPriorityDedupeSortOrder
        /// </summary>
        public static readonly DataIntegrationFlowFieldPriorityDedupeSortOrder DESC = new DataIntegrationFlowFieldPriorityDedupeSortOrder("DESC");

        /// <summary>
        /// Constructs a custom DataIntegrationFlowFieldPriorityDedupeSortOrder for a value not among the defined constants.
        /// </summary>
        public DataIntegrationFlowFieldPriorityDedupeSortOrder(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DataIntegrationFlowFieldPriorityDedupeSortOrder FindValue(string value)
        {
            return FindValue<DataIntegrationFlowFieldPriorityDedupeSortOrder>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DataIntegrationFlowFieldPriorityDedupeSortOrder(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type DataIntegrationFlowFileType.
    /// </summary>
    public class DataIntegrationFlowFileType : ConstantClass
    {
        /// <summary>
        /// Constant CSV for DataIntegrationFlowFileType
        /// </summary>
        public static readonly DataIntegrationFlowFileType CSV = new DataIntegrationFlowFileType("CSV");

        /// <summary>
        /// Constant JSON for DataIntegrationFlowFileType
        /// </summary>
        public static readonly DataIntegrationFlowFileType JSON = new DataIntegrationFlowFileType("JSON");

        /// <summary>
        /// Constant PARQUET for DataIntegrationFlowFileType
        /// </summary>
        public static readonly DataIntegrationFlowFileType PARQUET = new DataIntegrationFlowFileType("PARQUET");

        /// <summary>
        /// Constructs a custom DataIntegrationFlowFileType for a value not among the defined constants.
        /// </summary>
        public DataIntegrationFlowFileType(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DataIntegrationFlowFileType FindValue(string value)
        {
            return FindValue<DataIntegrationFlowFileType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DataIntegrationFlowFileType(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type DataIntegrationFlowLoadType.
    /// </summary>
    public class DataIntegrationFlowLoadType : ConstantClass
    {
        /// <summary>
        /// Constant INCREMENTAL for DataIntegrationFlowLoadType
        /// </summary>
        public static readonly DataIntegrationFlowLoadType INCREMENTAL = new DataIntegrationFlowLoadType("INCREMENTAL");

        /// <summary>
        /// Constant REPLACE for DataIntegrationFlowLoadType
        /// </summary>
        public static readonly DataIntegrationFlowLoadType REPLACE = new DataIntegrationFlowLoadType("REPLACE");

        /// <summary>
        /// Constructs a custom DataIntegrationFlowLoadType for a value not among the defined constants.
        /// </summary>
        public DataIntegrationFlowLoadType(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DataIntegrationFlowLoadType FindValue(string value)
        {
            return FindValue<DataIntegrationFlowLoadType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DataIntegrationFlowLoadType(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type DataIntegrationFlowSourceType.
    /// </summary>
    public class DataIntegrationFlowSourceType : ConstantClass
    {
        /// <summary>
        /// Constant DATASET for DataIntegrationFlowSourceType
        /// </summary>
        public static readonly DataIntegrationFlowSourceType DATASET = new DataIntegrationFlowSourceType("DATASET");

        /// <summary>
        /// Constant S3 for DataIntegrationFlowSourceType
        /// </summary>
        public static readonly DataIntegrationFlowSourceType S3 = new DataIntegrationFlowSourceType("S3");

        /// <summary>
        /// Constructs a custom DataIntegrationFlowSourceType for a value not among the defined constants.
        /// </summary>
        public DataIntegrationFlowSourceType(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DataIntegrationFlowSourceType FindValue(string value)
        {
            return FindValue<DataIntegrationFlowSourceType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DataIntegrationFlowSourceType(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type DataIntegrationFlowTargetType.
    /// </summary>
    public class DataIntegrationFlowTargetType : ConstantClass
    {
        /// <summary>
        /// Constant DATASET for DataIntegrationFlowTargetType
        /// </summary>
        public static readonly DataIntegrationFlowTargetType DATASET = new DataIntegrationFlowTargetType("DATASET");

        /// <summary>
        /// Constant S3 for DataIntegrationFlowTargetType
        /// </summary>
        public static readonly DataIntegrationFlowTargetType S3 = new DataIntegrationFlowTargetType("S3");

        /// <summary>
        /// Constructs a custom DataIntegrationFlowTargetType for a value not among the defined constants.
        /// </summary>
        public DataIntegrationFlowTargetType(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DataIntegrationFlowTargetType FindValue(string value)
        {
            return FindValue<DataIntegrationFlowTargetType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DataIntegrationFlowTargetType(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type DataIntegrationFlowTransformationType.
    /// </summary>
    public class DataIntegrationFlowTransformationType : ConstantClass
    {
        /// <summary>
        /// Constant NONE for DataIntegrationFlowTransformationType
        /// </summary>
        public static readonly DataIntegrationFlowTransformationType NONE = new DataIntegrationFlowTransformationType("NONE");

        /// <summary>
        /// Constant SQL for DataIntegrationFlowTransformationType
        /// </summary>
        public static readonly DataIntegrationFlowTransformationType SQL = new DataIntegrationFlowTransformationType("SQL");

        /// <summary>
        /// Constructs a custom DataIntegrationFlowTransformationType for a value not among the defined constants.
        /// </summary>
        public DataIntegrationFlowTransformationType(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DataIntegrationFlowTransformationType FindValue(string value)
        {
            return FindValue<DataIntegrationFlowTransformationType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DataIntegrationFlowTransformationType(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type DataLakeDatasetPartitionTransformType.
    /// </summary>
    public class DataLakeDatasetPartitionTransformType : ConstantClass
    {
        /// <summary>
        /// Constant DAY for DataLakeDatasetPartitionTransformType
        /// </summary>
        public static readonly DataLakeDatasetPartitionTransformType DAY = new DataLakeDatasetPartitionTransformType("DAY");

        /// <summary>
        /// Constant HOUR for DataLakeDatasetPartitionTransformType
        /// </summary>
        public static readonly DataLakeDatasetPartitionTransformType HOUR = new DataLakeDatasetPartitionTransformType("HOUR");

        /// <summary>
        /// Constant IDENTITY for DataLakeDatasetPartitionTransformType
        /// </summary>
        public static readonly DataLakeDatasetPartitionTransformType IDENTITY = new DataLakeDatasetPartitionTransformType("IDENTITY");

        /// <summary>
        /// Constant MONTH for DataLakeDatasetPartitionTransformType
        /// </summary>
        public static readonly DataLakeDatasetPartitionTransformType MONTH = new DataLakeDatasetPartitionTransformType("MONTH");

        /// <summary>
        /// Constant YEAR for DataLakeDatasetPartitionTransformType
        /// </summary>
        public static readonly DataLakeDatasetPartitionTransformType YEAR = new DataLakeDatasetPartitionTransformType("YEAR");

        /// <summary>
        /// Constructs a custom DataLakeDatasetPartitionTransformType for a value not among the defined constants.
        /// </summary>
        public DataLakeDatasetPartitionTransformType(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DataLakeDatasetPartitionTransformType FindValue(string value)
        {
            return FindValue<DataLakeDatasetPartitionTransformType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DataLakeDatasetPartitionTransformType(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type DataLakeDatasetSchemaFieldType.
    /// </summary>
    public class DataLakeDatasetSchemaFieldType : ConstantClass
    {
        /// <summary>
        /// Constant DOUBLE for DataLakeDatasetSchemaFieldType
        /// </summary>
        public static readonly DataLakeDatasetSchemaFieldType DOUBLE = new DataLakeDatasetSchemaFieldType("DOUBLE");

        /// <summary>
        /// Constant INT for DataLakeDatasetSchemaFieldType
        /// </summary>
        public static readonly DataLakeDatasetSchemaFieldType INT = new DataLakeDatasetSchemaFieldType("INT");

        /// <summary>
        /// Constant LONG for DataLakeDatasetSchemaFieldType
        /// </summary>
        public static readonly DataLakeDatasetSchemaFieldType LONG = new DataLakeDatasetSchemaFieldType("LONG");

        /// <summary>
        /// Constant STRING for DataLakeDatasetSchemaFieldType
        /// </summary>
        public static readonly DataLakeDatasetSchemaFieldType STRING = new DataLakeDatasetSchemaFieldType("STRING");

        /// <summary>
        /// Constant TIMESTAMP for DataLakeDatasetSchemaFieldType
        /// </summary>
        public static readonly DataLakeDatasetSchemaFieldType TIMESTAMP = new DataLakeDatasetSchemaFieldType("TIMESTAMP");

        /// <summary>
        /// Constructs a custom DataLakeDatasetSchemaFieldType for a value not among the defined constants.
        /// </summary>
        public DataLakeDatasetSchemaFieldType(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DataLakeDatasetSchemaFieldType FindValue(string value)
        {
            return FindValue<DataLakeDatasetSchemaFieldType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DataLakeDatasetSchemaFieldType(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type InstanceState.
    /// </summary>
    public class InstanceState : ConstantClass
    {
        /// <summary>
        /// Constant Active for InstanceState
        /// </summary>
        public static readonly InstanceState Active = new InstanceState("Active");

        /// <summary>
        /// Constant CreateFailed for InstanceState
        /// </summary>
        public static readonly InstanceState CreateFailed = new InstanceState("CreateFailed");

        /// <summary>
        /// Constant DeleteFailed for InstanceState
        /// </summary>
        public static readonly InstanceState DeleteFailed = new InstanceState("DeleteFailed");

        /// <summary>
        /// Constant Deleted for InstanceState
        /// </summary>
        public static readonly InstanceState Deleted = new InstanceState("Deleted");

        /// <summary>
        /// Constant Deleting for InstanceState
        /// </summary>
        public static readonly InstanceState Deleting = new InstanceState("Deleting");

        /// <summary>
        /// Constant Initializing for InstanceState
        /// </summary>
        public static readonly InstanceState Initializing = new InstanceState("Initializing");

        /// <summary>
        /// Constructs a custom InstanceState for a value not among the defined constants.
        /// </summary>
        public InstanceState(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static InstanceState FindValue(string value)
        {
            return FindValue<InstanceState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator InstanceState(string value)
        {
            return FindValue(value);
        }
    }
}
