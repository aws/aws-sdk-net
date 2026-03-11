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
 * Do not modify this file. This file is generated from the neptune-graph-2023-11-29.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.NeptuneGraph
{

    /// <summary>
    /// Constants used for properties of type BlankNodeHandling.
    /// </summary>
    public class BlankNodeHandling : ConstantClass
    {

        /// <summary>
        /// Constant ConvertToIri for BlankNodeHandling
        /// </summary>
        public static readonly BlankNodeHandling ConvertToIri = new BlankNodeHandling("convertToIri");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public BlankNodeHandling(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static BlankNodeHandling FindValue(string value)
        {
            return FindValue<BlankNodeHandling>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator BlankNodeHandling(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ConflictExceptionReason.
    /// </summary>
    public class ConflictExceptionReason : ConstantClass
    {

        /// <summary>
        /// Constant CONCURRENT_MODIFICATION for ConflictExceptionReason
        /// </summary>
        public static readonly ConflictExceptionReason CONCURRENT_MODIFICATION = new ConflictExceptionReason("CONCURRENT_MODIFICATION");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ConflictExceptionReason(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ConflictExceptionReason FindValue(string value)
        {
            return FindValue<ConflictExceptionReason>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ConflictExceptionReason(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ExplainMode.
    /// </summary>
    public class ExplainMode : ConstantClass
    {

        /// <summary>
        /// Constant DETAILS for ExplainMode
        /// </summary>
        public static readonly ExplainMode DETAILS = new ExplainMode("DETAILS");
        /// <summary>
        /// Constant STATIC for ExplainMode
        /// </summary>
        public static readonly ExplainMode STATIC = new ExplainMode("STATIC");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ExplainMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ExplainMode FindValue(string value)
        {
            return FindValue<ExplainMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ExplainMode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ExportFormat.
    /// </summary>
    public class ExportFormat : ConstantClass
    {

        /// <summary>
        /// Constant CSV for ExportFormat
        /// </summary>
        public static readonly ExportFormat CSV = new ExportFormat("CSV");
        /// <summary>
        /// Constant PARQUET for ExportFormat
        /// </summary>
        public static readonly ExportFormat PARQUET = new ExportFormat("PARQUET");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ExportFormat(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ExportFormat FindValue(string value)
        {
            return FindValue<ExportFormat>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ExportFormat(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ExportTaskStatus.
    /// </summary>
    public class ExportTaskStatus : ConstantClass
    {

        /// <summary>
        /// Constant CANCELLED for ExportTaskStatus
        /// </summary>
        public static readonly ExportTaskStatus CANCELLED = new ExportTaskStatus("CANCELLED");
        /// <summary>
        /// Constant CANCELLING for ExportTaskStatus
        /// </summary>
        public static readonly ExportTaskStatus CANCELLING = new ExportTaskStatus("CANCELLING");
        /// <summary>
        /// Constant DELETED for ExportTaskStatus
        /// </summary>
        public static readonly ExportTaskStatus DELETED = new ExportTaskStatus("DELETED");
        /// <summary>
        /// Constant EXPORTING for ExportTaskStatus
        /// </summary>
        public static readonly ExportTaskStatus EXPORTING = new ExportTaskStatus("EXPORTING");
        /// <summary>
        /// Constant FAILED for ExportTaskStatus
        /// </summary>
        public static readonly ExportTaskStatus FAILED = new ExportTaskStatus("FAILED");
        /// <summary>
        /// Constant INITIALIZING for ExportTaskStatus
        /// </summary>
        public static readonly ExportTaskStatus INITIALIZING = new ExportTaskStatus("INITIALIZING");
        /// <summary>
        /// Constant SUCCEEDED for ExportTaskStatus
        /// </summary>
        public static readonly ExportTaskStatus SUCCEEDED = new ExportTaskStatus("SUCCEEDED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ExportTaskStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ExportTaskStatus FindValue(string value)
        {
            return FindValue<ExportTaskStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ExportTaskStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Format.
    /// </summary>
    public class Format : ConstantClass
    {

        /// <summary>
        /// Constant CSV for Format
        /// </summary>
        public static readonly Format CSV = new Format("CSV");
        /// <summary>
        /// Constant NTRIPLES for Format
        /// </summary>
        public static readonly Format NTRIPLES = new Format("NTRIPLES");
        /// <summary>
        /// Constant OPEN_CYPHER for Format
        /// </summary>
        public static readonly Format OPEN_CYPHER = new Format("OPEN_CYPHER");
        /// <summary>
        /// Constant PARQUET for Format
        /// </summary>
        public static readonly Format PARQUET = new Format("PARQUET");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Format(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Format FindValue(string value)
        {
            return FindValue<Format>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Format(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type GraphStatus.
    /// </summary>
    public class GraphStatus : ConstantClass
    {

        /// <summary>
        /// Constant AVAILABLE for GraphStatus
        /// </summary>
        public static readonly GraphStatus AVAILABLE = new GraphStatus("AVAILABLE");
        /// <summary>
        /// Constant CREATING for GraphStatus
        /// </summary>
        public static readonly GraphStatus CREATING = new GraphStatus("CREATING");
        /// <summary>
        /// Constant DELETING for GraphStatus
        /// </summary>
        public static readonly GraphStatus DELETING = new GraphStatus("DELETING");
        /// <summary>
        /// Constant FAILED for GraphStatus
        /// </summary>
        public static readonly GraphStatus FAILED = new GraphStatus("FAILED");
        /// <summary>
        /// Constant IMPORTING for GraphStatus
        /// </summary>
        public static readonly GraphStatus IMPORTING = new GraphStatus("IMPORTING");
        /// <summary>
        /// Constant RESETTING for GraphStatus
        /// </summary>
        public static readonly GraphStatus RESETTING = new GraphStatus("RESETTING");
        /// <summary>
        /// Constant SNAPSHOTTING for GraphStatus
        /// </summary>
        public static readonly GraphStatus SNAPSHOTTING = new GraphStatus("SNAPSHOTTING");
        /// <summary>
        /// Constant STARTING for GraphStatus
        /// </summary>
        public static readonly GraphStatus STARTING = new GraphStatus("STARTING");
        /// <summary>
        /// Constant STOPPED for GraphStatus
        /// </summary>
        public static readonly GraphStatus STOPPED = new GraphStatus("STOPPED");
        /// <summary>
        /// Constant STOPPING for GraphStatus
        /// </summary>
        public static readonly GraphStatus STOPPING = new GraphStatus("STOPPING");
        /// <summary>
        /// Constant UPDATING for GraphStatus
        /// </summary>
        public static readonly GraphStatus UPDATING = new GraphStatus("UPDATING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public GraphStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static GraphStatus FindValue(string value)
        {
            return FindValue<GraphStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator GraphStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type GraphSummaryMode.
    /// </summary>
    public class GraphSummaryMode : ConstantClass
    {

        /// <summary>
        /// Constant BASIC for GraphSummaryMode
        /// </summary>
        public static readonly GraphSummaryMode BASIC = new GraphSummaryMode("BASIC");
        /// <summary>
        /// Constant DETAILED for GraphSummaryMode
        /// </summary>
        public static readonly GraphSummaryMode DETAILED = new GraphSummaryMode("DETAILED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public GraphSummaryMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static GraphSummaryMode FindValue(string value)
        {
            return FindValue<GraphSummaryMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator GraphSummaryMode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ImportTaskStatus.
    /// </summary>
    public class ImportTaskStatus : ConstantClass
    {

        /// <summary>
        /// Constant ANALYZING_DATA for ImportTaskStatus
        /// </summary>
        public static readonly ImportTaskStatus ANALYZING_DATA = new ImportTaskStatus("ANALYZING_DATA");
        /// <summary>
        /// Constant CANCELLED for ImportTaskStatus
        /// </summary>
        public static readonly ImportTaskStatus CANCELLED = new ImportTaskStatus("CANCELLED");
        /// <summary>
        /// Constant CANCELLING for ImportTaskStatus
        /// </summary>
        public static readonly ImportTaskStatus CANCELLING = new ImportTaskStatus("CANCELLING");
        /// <summary>
        /// Constant DELETED for ImportTaskStatus
        /// </summary>
        public static readonly ImportTaskStatus DELETED = new ImportTaskStatus("DELETED");
        /// <summary>
        /// Constant EXPORTING for ImportTaskStatus
        /// </summary>
        public static readonly ImportTaskStatus EXPORTING = new ImportTaskStatus("EXPORTING");
        /// <summary>
        /// Constant FAILED for ImportTaskStatus
        /// </summary>
        public static readonly ImportTaskStatus FAILED = new ImportTaskStatus("FAILED");
        /// <summary>
        /// Constant IMPORTING for ImportTaskStatus
        /// </summary>
        public static readonly ImportTaskStatus IMPORTING = new ImportTaskStatus("IMPORTING");
        /// <summary>
        /// Constant INITIALIZING for ImportTaskStatus
        /// </summary>
        public static readonly ImportTaskStatus INITIALIZING = new ImportTaskStatus("INITIALIZING");
        /// <summary>
        /// Constant REPROVISIONING for ImportTaskStatus
        /// </summary>
        public static readonly ImportTaskStatus REPROVISIONING = new ImportTaskStatus("REPROVISIONING");
        /// <summary>
        /// Constant ROLLING_BACK for ImportTaskStatus
        /// </summary>
        public static readonly ImportTaskStatus ROLLING_BACK = new ImportTaskStatus("ROLLING_BACK");
        /// <summary>
        /// Constant SUCCEEDED for ImportTaskStatus
        /// </summary>
        public static readonly ImportTaskStatus SUCCEEDED = new ImportTaskStatus("SUCCEEDED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ImportTaskStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ImportTaskStatus FindValue(string value)
        {
            return FindValue<ImportTaskStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ImportTaskStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type MultiValueHandlingType.
    /// </summary>
    public class MultiValueHandlingType : ConstantClass
    {

        /// <summary>
        /// Constant PICK_FIRST for MultiValueHandlingType
        /// </summary>
        public static readonly MultiValueHandlingType PICK_FIRST = new MultiValueHandlingType("PICK_FIRST");
        /// <summary>
        /// Constant TO_LIST for MultiValueHandlingType
        /// </summary>
        public static readonly MultiValueHandlingType TO_LIST = new MultiValueHandlingType("TO_LIST");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MultiValueHandlingType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MultiValueHandlingType FindValue(string value)
        {
            return FindValue<MultiValueHandlingType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MultiValueHandlingType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ParquetType.
    /// </summary>
    public class ParquetType : ConstantClass
    {

        /// <summary>
        /// Constant COLUMNAR for ParquetType
        /// </summary>
        public static readonly ParquetType COLUMNAR = new ParquetType("COLUMNAR");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ParquetType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ParquetType FindValue(string value)
        {
            return FindValue<ParquetType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ParquetType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PlanCacheType.
    /// </summary>
    public class PlanCacheType : ConstantClass
    {

        /// <summary>
        /// Constant AUTO for PlanCacheType
        /// </summary>
        public static readonly PlanCacheType AUTO = new PlanCacheType("AUTO");
        /// <summary>
        /// Constant DISABLED for PlanCacheType
        /// </summary>
        public static readonly PlanCacheType DISABLED = new PlanCacheType("DISABLED");
        /// <summary>
        /// Constant ENABLED for PlanCacheType
        /// </summary>
        public static readonly PlanCacheType ENABLED = new PlanCacheType("ENABLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PlanCacheType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PlanCacheType FindValue(string value)
        {
            return FindValue<PlanCacheType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PlanCacheType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PrivateGraphEndpointStatus.
    /// </summary>
    public class PrivateGraphEndpointStatus : ConstantClass
    {

        /// <summary>
        /// Constant AVAILABLE for PrivateGraphEndpointStatus
        /// </summary>
        public static readonly PrivateGraphEndpointStatus AVAILABLE = new PrivateGraphEndpointStatus("AVAILABLE");
        /// <summary>
        /// Constant CREATING for PrivateGraphEndpointStatus
        /// </summary>
        public static readonly PrivateGraphEndpointStatus CREATING = new PrivateGraphEndpointStatus("CREATING");
        /// <summary>
        /// Constant DELETING for PrivateGraphEndpointStatus
        /// </summary>
        public static readonly PrivateGraphEndpointStatus DELETING = new PrivateGraphEndpointStatus("DELETING");
        /// <summary>
        /// Constant FAILED for PrivateGraphEndpointStatus
        /// </summary>
        public static readonly PrivateGraphEndpointStatus FAILED = new PrivateGraphEndpointStatus("FAILED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PrivateGraphEndpointStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PrivateGraphEndpointStatus FindValue(string value)
        {
            return FindValue<PrivateGraphEndpointStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PrivateGraphEndpointStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type QueryLanguage.
    /// </summary>
    public class QueryLanguage : ConstantClass
    {

        /// <summary>
        /// Constant OPEN_CYPHER for QueryLanguage
        /// </summary>
        public static readonly QueryLanguage OPEN_CYPHER = new QueryLanguage("OPEN_CYPHER");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public QueryLanguage(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static QueryLanguage FindValue(string value)
        {
            return FindValue<QueryLanguage>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator QueryLanguage(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type QueryState.
    /// </summary>
    public class QueryState : ConstantClass
    {

        /// <summary>
        /// Constant CANCELLING for QueryState
        /// </summary>
        public static readonly QueryState CANCELLING = new QueryState("CANCELLING");
        /// <summary>
        /// Constant RUNNING for QueryState
        /// </summary>
        public static readonly QueryState RUNNING = new QueryState("RUNNING");
        /// <summary>
        /// Constant WAITING for QueryState
        /// </summary>
        public static readonly QueryState WAITING = new QueryState("WAITING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public QueryState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static QueryState FindValue(string value)
        {
            return FindValue<QueryState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator QueryState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type QueryStateInput.
    /// </summary>
    public class QueryStateInput : ConstantClass
    {

        /// <summary>
        /// Constant ALL for QueryStateInput
        /// </summary>
        public static readonly QueryStateInput ALL = new QueryStateInput("ALL");
        /// <summary>
        /// Constant CANCELLING for QueryStateInput
        /// </summary>
        public static readonly QueryStateInput CANCELLING = new QueryStateInput("CANCELLING");
        /// <summary>
        /// Constant RUNNING for QueryStateInput
        /// </summary>
        public static readonly QueryStateInput RUNNING = new QueryStateInput("RUNNING");
        /// <summary>
        /// Constant WAITING for QueryStateInput
        /// </summary>
        public static readonly QueryStateInput WAITING = new QueryStateInput("WAITING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public QueryStateInput(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static QueryStateInput FindValue(string value)
        {
            return FindValue<QueryStateInput>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator QueryStateInput(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SnapshotStatus.
    /// </summary>
    public class SnapshotStatus : ConstantClass
    {

        /// <summary>
        /// Constant AVAILABLE for SnapshotStatus
        /// </summary>
        public static readonly SnapshotStatus AVAILABLE = new SnapshotStatus("AVAILABLE");
        /// <summary>
        /// Constant CREATING for SnapshotStatus
        /// </summary>
        public static readonly SnapshotStatus CREATING = new SnapshotStatus("CREATING");
        /// <summary>
        /// Constant DELETING for SnapshotStatus
        /// </summary>
        public static readonly SnapshotStatus DELETING = new SnapshotStatus("DELETING");
        /// <summary>
        /// Constant FAILED for SnapshotStatus
        /// </summary>
        public static readonly SnapshotStatus FAILED = new SnapshotStatus("FAILED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SnapshotStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SnapshotStatus FindValue(string value)
        {
            return FindValue<SnapshotStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SnapshotStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type UnprocessableExceptionReason.
    /// </summary>
    public class UnprocessableExceptionReason : ConstantClass
    {

        /// <summary>
        /// Constant INTERNAL_LIMIT_EXCEEDED for UnprocessableExceptionReason
        /// </summary>
        public static readonly UnprocessableExceptionReason INTERNAL_LIMIT_EXCEEDED = new UnprocessableExceptionReason("INTERNAL_LIMIT_EXCEEDED");
        /// <summary>
        /// Constant MEMORY_LIMIT_EXCEEDED for UnprocessableExceptionReason
        /// </summary>
        public static readonly UnprocessableExceptionReason MEMORY_LIMIT_EXCEEDED = new UnprocessableExceptionReason("MEMORY_LIMIT_EXCEEDED");
        /// <summary>
        /// Constant PARTITION_FULL for UnprocessableExceptionReason
        /// </summary>
        public static readonly UnprocessableExceptionReason PARTITION_FULL = new UnprocessableExceptionReason("PARTITION_FULL");
        /// <summary>
        /// Constant QUERY_TIMEOUT for UnprocessableExceptionReason
        /// </summary>
        public static readonly UnprocessableExceptionReason QUERY_TIMEOUT = new UnprocessableExceptionReason("QUERY_TIMEOUT");
        /// <summary>
        /// Constant STORAGE_LIMIT_EXCEEDED for UnprocessableExceptionReason
        /// </summary>
        public static readonly UnprocessableExceptionReason STORAGE_LIMIT_EXCEEDED = new UnprocessableExceptionReason("STORAGE_LIMIT_EXCEEDED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public UnprocessableExceptionReason(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static UnprocessableExceptionReason FindValue(string value)
        {
            return FindValue<UnprocessableExceptionReason>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator UnprocessableExceptionReason(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ValidationExceptionReason.
    /// </summary>
    public class ValidationExceptionReason : ConstantClass
    {

        /// <summary>
        /// Constant BAD_REQUEST for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason BAD_REQUEST = new ValidationExceptionReason("BAD_REQUEST");
        /// <summary>
        /// Constant CONSTRAINT_VIOLATION for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason CONSTRAINT_VIOLATION = new ValidationExceptionReason("CONSTRAINT_VIOLATION");
        /// <summary>
        /// Constant ILLEGAL_ARGUMENT for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason ILLEGAL_ARGUMENT = new ValidationExceptionReason("ILLEGAL_ARGUMENT");
        /// <summary>
        /// Constant MALFORMED_QUERY for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason MALFORMED_QUERY = new ValidationExceptionReason("MALFORMED_QUERY");
        /// <summary>
        /// Constant QUERY_CANCELLED for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason QUERY_CANCELLED = new ValidationExceptionReason("QUERY_CANCELLED");
        /// <summary>
        /// Constant QUERY_TOO_LARGE for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason QUERY_TOO_LARGE = new ValidationExceptionReason("QUERY_TOO_LARGE");
        /// <summary>
        /// Constant UNSUPPORTED_OPERATION for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason UNSUPPORTED_OPERATION = new ValidationExceptionReason("UNSUPPORTED_OPERATION");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ValidationExceptionReason(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ValidationExceptionReason FindValue(string value)
        {
            return FindValue<ValidationExceptionReason>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ValidationExceptionReason(string value)
        {
            return FindValue(value);
        }
    }

}