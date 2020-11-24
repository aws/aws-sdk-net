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
 * Do not modify this file. This file is generated from the appflow-2020-08-23.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.Appflow
{

    /// <summary>
    /// Constants used for properties of type AggregationType.
    /// </summary>
    public class AggregationType : ConstantClass
    {

        /// <summary>
        /// Constant None for AggregationType
        /// </summary>
        public static readonly AggregationType None = new AggregationType("None");
        /// <summary>
        /// Constant SingleFile for AggregationType
        /// </summary>
        public static readonly AggregationType SingleFile = new AggregationType("SingleFile");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AggregationType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AggregationType FindValue(string value)
        {
            return FindValue<AggregationType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AggregationType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AmplitudeConnectorOperator.
    /// </summary>
    public class AmplitudeConnectorOperator : ConstantClass
    {

        /// <summary>
        /// Constant BETWEEN for AmplitudeConnectorOperator
        /// </summary>
        public static readonly AmplitudeConnectorOperator BETWEEN = new AmplitudeConnectorOperator("BETWEEN");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AmplitudeConnectorOperator(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AmplitudeConnectorOperator FindValue(string value)
        {
            return FindValue<AmplitudeConnectorOperator>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AmplitudeConnectorOperator(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ConnectionMode.
    /// </summary>
    public class ConnectionMode : ConstantClass
    {

        /// <summary>
        /// Constant Private for ConnectionMode
        /// </summary>
        public static readonly ConnectionMode Private = new ConnectionMode("Private");
        /// <summary>
        /// Constant Public for ConnectionMode
        /// </summary>
        public static readonly ConnectionMode Public = new ConnectionMode("Public");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ConnectionMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ConnectionMode FindValue(string value)
        {
            return FindValue<ConnectionMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ConnectionMode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ConnectorType.
    /// </summary>
    public class ConnectorType : ConstantClass
    {

        /// <summary>
        /// Constant Amplitude for ConnectorType
        /// </summary>
        public static readonly ConnectorType Amplitude = new ConnectorType("Amplitude");
        /// <summary>
        /// Constant Datadog for ConnectorType
        /// </summary>
        public static readonly ConnectorType Datadog = new ConnectorType("Datadog");
        /// <summary>
        /// Constant Dynatrace for ConnectorType
        /// </summary>
        public static readonly ConnectorType Dynatrace = new ConnectorType("Dynatrace");
        /// <summary>
        /// Constant EventBridge for ConnectorType
        /// </summary>
        public static readonly ConnectorType EventBridge = new ConnectorType("EventBridge");
        /// <summary>
        /// Constant Googleanalytics for ConnectorType
        /// </summary>
        public static readonly ConnectorType Googleanalytics = new ConnectorType("Googleanalytics");
        /// <summary>
        /// Constant Infornexus for ConnectorType
        /// </summary>
        public static readonly ConnectorType Infornexus = new ConnectorType("Infornexus");
        /// <summary>
        /// Constant Marketo for ConnectorType
        /// </summary>
        public static readonly ConnectorType Marketo = new ConnectorType("Marketo");
        /// <summary>
        /// Constant Redshift for ConnectorType
        /// </summary>
        public static readonly ConnectorType Redshift = new ConnectorType("Redshift");
        /// <summary>
        /// Constant S3 for ConnectorType
        /// </summary>
        public static readonly ConnectorType S3 = new ConnectorType("S3");
        /// <summary>
        /// Constant Salesforce for ConnectorType
        /// </summary>
        public static readonly ConnectorType Salesforce = new ConnectorType("Salesforce");
        /// <summary>
        /// Constant Servicenow for ConnectorType
        /// </summary>
        public static readonly ConnectorType Servicenow = new ConnectorType("Servicenow");
        /// <summary>
        /// Constant Singular for ConnectorType
        /// </summary>
        public static readonly ConnectorType Singular = new ConnectorType("Singular");
        /// <summary>
        /// Constant Slack for ConnectorType
        /// </summary>
        public static readonly ConnectorType Slack = new ConnectorType("Slack");
        /// <summary>
        /// Constant Snowflake for ConnectorType
        /// </summary>
        public static readonly ConnectorType Snowflake = new ConnectorType("Snowflake");
        /// <summary>
        /// Constant Trendmicro for ConnectorType
        /// </summary>
        public static readonly ConnectorType Trendmicro = new ConnectorType("Trendmicro");
        /// <summary>
        /// Constant Upsolver for ConnectorType
        /// </summary>
        public static readonly ConnectorType Upsolver = new ConnectorType("Upsolver");
        /// <summary>
        /// Constant Veeva for ConnectorType
        /// </summary>
        public static readonly ConnectorType Veeva = new ConnectorType("Veeva");
        /// <summary>
        /// Constant Zendesk for ConnectorType
        /// </summary>
        public static readonly ConnectorType Zendesk = new ConnectorType("Zendesk");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ConnectorType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ConnectorType FindValue(string value)
        {
            return FindValue<ConnectorType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ConnectorType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DatadogConnectorOperator.
    /// </summary>
    public class DatadogConnectorOperator : ConstantClass
    {

        /// <summary>
        /// Constant ADDITION for DatadogConnectorOperator
        /// </summary>
        public static readonly DatadogConnectorOperator ADDITION = new DatadogConnectorOperator("ADDITION");
        /// <summary>
        /// Constant BETWEEN for DatadogConnectorOperator
        /// </summary>
        public static readonly DatadogConnectorOperator BETWEEN = new DatadogConnectorOperator("BETWEEN");
        /// <summary>
        /// Constant DIVISION for DatadogConnectorOperator
        /// </summary>
        public static readonly DatadogConnectorOperator DIVISION = new DatadogConnectorOperator("DIVISION");
        /// <summary>
        /// Constant EQUAL_TO for DatadogConnectorOperator
        /// </summary>
        public static readonly DatadogConnectorOperator EQUAL_TO = new DatadogConnectorOperator("EQUAL_TO");
        /// <summary>
        /// Constant MASK_ALL for DatadogConnectorOperator
        /// </summary>
        public static readonly DatadogConnectorOperator MASK_ALL = new DatadogConnectorOperator("MASK_ALL");
        /// <summary>
        /// Constant MASK_FIRST_N for DatadogConnectorOperator
        /// </summary>
        public static readonly DatadogConnectorOperator MASK_FIRST_N = new DatadogConnectorOperator("MASK_FIRST_N");
        /// <summary>
        /// Constant MASK_LAST_N for DatadogConnectorOperator
        /// </summary>
        public static readonly DatadogConnectorOperator MASK_LAST_N = new DatadogConnectorOperator("MASK_LAST_N");
        /// <summary>
        /// Constant MULTIPLICATION for DatadogConnectorOperator
        /// </summary>
        public static readonly DatadogConnectorOperator MULTIPLICATION = new DatadogConnectorOperator("MULTIPLICATION");
        /// <summary>
        /// Constant NO_OP for DatadogConnectorOperator
        /// </summary>
        public static readonly DatadogConnectorOperator NO_OP = new DatadogConnectorOperator("NO_OP");
        /// <summary>
        /// Constant PROJECTION for DatadogConnectorOperator
        /// </summary>
        public static readonly DatadogConnectorOperator PROJECTION = new DatadogConnectorOperator("PROJECTION");
        /// <summary>
        /// Constant SUBTRACTION for DatadogConnectorOperator
        /// </summary>
        public static readonly DatadogConnectorOperator SUBTRACTION = new DatadogConnectorOperator("SUBTRACTION");
        /// <summary>
        /// Constant VALIDATE_NON_NEGATIVE for DatadogConnectorOperator
        /// </summary>
        public static readonly DatadogConnectorOperator VALIDATE_NON_NEGATIVE = new DatadogConnectorOperator("VALIDATE_NON_NEGATIVE");
        /// <summary>
        /// Constant VALIDATE_NON_NULL for DatadogConnectorOperator
        /// </summary>
        public static readonly DatadogConnectorOperator VALIDATE_NON_NULL = new DatadogConnectorOperator("VALIDATE_NON_NULL");
        /// <summary>
        /// Constant VALIDATE_NON_ZERO for DatadogConnectorOperator
        /// </summary>
        public static readonly DatadogConnectorOperator VALIDATE_NON_ZERO = new DatadogConnectorOperator("VALIDATE_NON_ZERO");
        /// <summary>
        /// Constant VALIDATE_NUMERIC for DatadogConnectorOperator
        /// </summary>
        public static readonly DatadogConnectorOperator VALIDATE_NUMERIC = new DatadogConnectorOperator("VALIDATE_NUMERIC");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DatadogConnectorOperator(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DatadogConnectorOperator FindValue(string value)
        {
            return FindValue<DatadogConnectorOperator>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DatadogConnectorOperator(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DataPullMode.
    /// </summary>
    public class DataPullMode : ConstantClass
    {

        /// <summary>
        /// Constant Complete for DataPullMode
        /// </summary>
        public static readonly DataPullMode Complete = new DataPullMode("Complete");
        /// <summary>
        /// Constant Incremental for DataPullMode
        /// </summary>
        public static readonly DataPullMode Incremental = new DataPullMode("Incremental");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DataPullMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DataPullMode FindValue(string value)
        {
            return FindValue<DataPullMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DataPullMode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DynatraceConnectorOperator.
    /// </summary>
    public class DynatraceConnectorOperator : ConstantClass
    {

        /// <summary>
        /// Constant ADDITION for DynatraceConnectorOperator
        /// </summary>
        public static readonly DynatraceConnectorOperator ADDITION = new DynatraceConnectorOperator("ADDITION");
        /// <summary>
        /// Constant BETWEEN for DynatraceConnectorOperator
        /// </summary>
        public static readonly DynatraceConnectorOperator BETWEEN = new DynatraceConnectorOperator("BETWEEN");
        /// <summary>
        /// Constant DIVISION for DynatraceConnectorOperator
        /// </summary>
        public static readonly DynatraceConnectorOperator DIVISION = new DynatraceConnectorOperator("DIVISION");
        /// <summary>
        /// Constant EQUAL_TO for DynatraceConnectorOperator
        /// </summary>
        public static readonly DynatraceConnectorOperator EQUAL_TO = new DynatraceConnectorOperator("EQUAL_TO");
        /// <summary>
        /// Constant MASK_ALL for DynatraceConnectorOperator
        /// </summary>
        public static readonly DynatraceConnectorOperator MASK_ALL = new DynatraceConnectorOperator("MASK_ALL");
        /// <summary>
        /// Constant MASK_FIRST_N for DynatraceConnectorOperator
        /// </summary>
        public static readonly DynatraceConnectorOperator MASK_FIRST_N = new DynatraceConnectorOperator("MASK_FIRST_N");
        /// <summary>
        /// Constant MASK_LAST_N for DynatraceConnectorOperator
        /// </summary>
        public static readonly DynatraceConnectorOperator MASK_LAST_N = new DynatraceConnectorOperator("MASK_LAST_N");
        /// <summary>
        /// Constant MULTIPLICATION for DynatraceConnectorOperator
        /// </summary>
        public static readonly DynatraceConnectorOperator MULTIPLICATION = new DynatraceConnectorOperator("MULTIPLICATION");
        /// <summary>
        /// Constant NO_OP for DynatraceConnectorOperator
        /// </summary>
        public static readonly DynatraceConnectorOperator NO_OP = new DynatraceConnectorOperator("NO_OP");
        /// <summary>
        /// Constant PROJECTION for DynatraceConnectorOperator
        /// </summary>
        public static readonly DynatraceConnectorOperator PROJECTION = new DynatraceConnectorOperator("PROJECTION");
        /// <summary>
        /// Constant SUBTRACTION for DynatraceConnectorOperator
        /// </summary>
        public static readonly DynatraceConnectorOperator SUBTRACTION = new DynatraceConnectorOperator("SUBTRACTION");
        /// <summary>
        /// Constant VALIDATE_NON_NEGATIVE for DynatraceConnectorOperator
        /// </summary>
        public static readonly DynatraceConnectorOperator VALIDATE_NON_NEGATIVE = new DynatraceConnectorOperator("VALIDATE_NON_NEGATIVE");
        /// <summary>
        /// Constant VALIDATE_NON_NULL for DynatraceConnectorOperator
        /// </summary>
        public static readonly DynatraceConnectorOperator VALIDATE_NON_NULL = new DynatraceConnectorOperator("VALIDATE_NON_NULL");
        /// <summary>
        /// Constant VALIDATE_NON_ZERO for DynatraceConnectorOperator
        /// </summary>
        public static readonly DynatraceConnectorOperator VALIDATE_NON_ZERO = new DynatraceConnectorOperator("VALIDATE_NON_ZERO");
        /// <summary>
        /// Constant VALIDATE_NUMERIC for DynatraceConnectorOperator
        /// </summary>
        public static readonly DynatraceConnectorOperator VALIDATE_NUMERIC = new DynatraceConnectorOperator("VALIDATE_NUMERIC");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DynatraceConnectorOperator(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DynatraceConnectorOperator FindValue(string value)
        {
            return FindValue<DynatraceConnectorOperator>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DynatraceConnectorOperator(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ExecutionStatus.
    /// </summary>
    public class ExecutionStatus : ConstantClass
    {

        /// <summary>
        /// Constant Error for ExecutionStatus
        /// </summary>
        public static readonly ExecutionStatus Error = new ExecutionStatus("Error");
        /// <summary>
        /// Constant InProgress for ExecutionStatus
        /// </summary>
        public static readonly ExecutionStatus InProgress = new ExecutionStatus("InProgress");
        /// <summary>
        /// Constant Successful for ExecutionStatus
        /// </summary>
        public static readonly ExecutionStatus Successful = new ExecutionStatus("Successful");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ExecutionStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ExecutionStatus FindValue(string value)
        {
            return FindValue<ExecutionStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ExecutionStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type FileType.
    /// </summary>
    public class FileType : ConstantClass
    {

        /// <summary>
        /// Constant CSV for FileType
        /// </summary>
        public static readonly FileType CSV = new FileType("CSV");
        /// <summary>
        /// Constant JSON for FileType
        /// </summary>
        public static readonly FileType JSON = new FileType("JSON");
        /// <summary>
        /// Constant PARQUET for FileType
        /// </summary>
        public static readonly FileType PARQUET = new FileType("PARQUET");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FileType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FileType FindValue(string value)
        {
            return FindValue<FileType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FileType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type FlowStatus.
    /// </summary>
    public class FlowStatus : ConstantClass
    {

        /// <summary>
        /// Constant Active for FlowStatus
        /// </summary>
        public static readonly FlowStatus Active = new FlowStatus("Active");
        /// <summary>
        /// Constant Deleted for FlowStatus
        /// </summary>
        public static readonly FlowStatus Deleted = new FlowStatus("Deleted");
        /// <summary>
        /// Constant Deprecated for FlowStatus
        /// </summary>
        public static readonly FlowStatus Deprecated = new FlowStatus("Deprecated");
        /// <summary>
        /// Constant Draft for FlowStatus
        /// </summary>
        public static readonly FlowStatus Draft = new FlowStatus("Draft");
        /// <summary>
        /// Constant Errored for FlowStatus
        /// </summary>
        public static readonly FlowStatus Errored = new FlowStatus("Errored");
        /// <summary>
        /// Constant Suspended for FlowStatus
        /// </summary>
        public static readonly FlowStatus Suspended = new FlowStatus("Suspended");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FlowStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FlowStatus FindValue(string value)
        {
            return FindValue<FlowStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FlowStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type GoogleAnalyticsConnectorOperator.
    /// </summary>
    public class GoogleAnalyticsConnectorOperator : ConstantClass
    {

        /// <summary>
        /// Constant BETWEEN for GoogleAnalyticsConnectorOperator
        /// </summary>
        public static readonly GoogleAnalyticsConnectorOperator BETWEEN = new GoogleAnalyticsConnectorOperator("BETWEEN");
        /// <summary>
        /// Constant PROJECTION for GoogleAnalyticsConnectorOperator
        /// </summary>
        public static readonly GoogleAnalyticsConnectorOperator PROJECTION = new GoogleAnalyticsConnectorOperator("PROJECTION");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public GoogleAnalyticsConnectorOperator(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static GoogleAnalyticsConnectorOperator FindValue(string value)
        {
            return FindValue<GoogleAnalyticsConnectorOperator>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator GoogleAnalyticsConnectorOperator(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type InforNexusConnectorOperator.
    /// </summary>
    public class InforNexusConnectorOperator : ConstantClass
    {

        /// <summary>
        /// Constant ADDITION for InforNexusConnectorOperator
        /// </summary>
        public static readonly InforNexusConnectorOperator ADDITION = new InforNexusConnectorOperator("ADDITION");
        /// <summary>
        /// Constant BETWEEN for InforNexusConnectorOperator
        /// </summary>
        public static readonly InforNexusConnectorOperator BETWEEN = new InforNexusConnectorOperator("BETWEEN");
        /// <summary>
        /// Constant DIVISION for InforNexusConnectorOperator
        /// </summary>
        public static readonly InforNexusConnectorOperator DIVISION = new InforNexusConnectorOperator("DIVISION");
        /// <summary>
        /// Constant EQUAL_TO for InforNexusConnectorOperator
        /// </summary>
        public static readonly InforNexusConnectorOperator EQUAL_TO = new InforNexusConnectorOperator("EQUAL_TO");
        /// <summary>
        /// Constant MASK_ALL for InforNexusConnectorOperator
        /// </summary>
        public static readonly InforNexusConnectorOperator MASK_ALL = new InforNexusConnectorOperator("MASK_ALL");
        /// <summary>
        /// Constant MASK_FIRST_N for InforNexusConnectorOperator
        /// </summary>
        public static readonly InforNexusConnectorOperator MASK_FIRST_N = new InforNexusConnectorOperator("MASK_FIRST_N");
        /// <summary>
        /// Constant MASK_LAST_N for InforNexusConnectorOperator
        /// </summary>
        public static readonly InforNexusConnectorOperator MASK_LAST_N = new InforNexusConnectorOperator("MASK_LAST_N");
        /// <summary>
        /// Constant MULTIPLICATION for InforNexusConnectorOperator
        /// </summary>
        public static readonly InforNexusConnectorOperator MULTIPLICATION = new InforNexusConnectorOperator("MULTIPLICATION");
        /// <summary>
        /// Constant NO_OP for InforNexusConnectorOperator
        /// </summary>
        public static readonly InforNexusConnectorOperator NO_OP = new InforNexusConnectorOperator("NO_OP");
        /// <summary>
        /// Constant PROJECTION for InforNexusConnectorOperator
        /// </summary>
        public static readonly InforNexusConnectorOperator PROJECTION = new InforNexusConnectorOperator("PROJECTION");
        /// <summary>
        /// Constant SUBTRACTION for InforNexusConnectorOperator
        /// </summary>
        public static readonly InforNexusConnectorOperator SUBTRACTION = new InforNexusConnectorOperator("SUBTRACTION");
        /// <summary>
        /// Constant VALIDATE_NON_NEGATIVE for InforNexusConnectorOperator
        /// </summary>
        public static readonly InforNexusConnectorOperator VALIDATE_NON_NEGATIVE = new InforNexusConnectorOperator("VALIDATE_NON_NEGATIVE");
        /// <summary>
        /// Constant VALIDATE_NON_NULL for InforNexusConnectorOperator
        /// </summary>
        public static readonly InforNexusConnectorOperator VALIDATE_NON_NULL = new InforNexusConnectorOperator("VALIDATE_NON_NULL");
        /// <summary>
        /// Constant VALIDATE_NON_ZERO for InforNexusConnectorOperator
        /// </summary>
        public static readonly InforNexusConnectorOperator VALIDATE_NON_ZERO = new InforNexusConnectorOperator("VALIDATE_NON_ZERO");
        /// <summary>
        /// Constant VALIDATE_NUMERIC for InforNexusConnectorOperator
        /// </summary>
        public static readonly InforNexusConnectorOperator VALIDATE_NUMERIC = new InforNexusConnectorOperator("VALIDATE_NUMERIC");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public InforNexusConnectorOperator(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static InforNexusConnectorOperator FindValue(string value)
        {
            return FindValue<InforNexusConnectorOperator>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator InforNexusConnectorOperator(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type MarketoConnectorOperator.
    /// </summary>
    public class MarketoConnectorOperator : ConstantClass
    {

        /// <summary>
        /// Constant ADDITION for MarketoConnectorOperator
        /// </summary>
        public static readonly MarketoConnectorOperator ADDITION = new MarketoConnectorOperator("ADDITION");
        /// <summary>
        /// Constant BETWEEN for MarketoConnectorOperator
        /// </summary>
        public static readonly MarketoConnectorOperator BETWEEN = new MarketoConnectorOperator("BETWEEN");
        /// <summary>
        /// Constant DIVISION for MarketoConnectorOperator
        /// </summary>
        public static readonly MarketoConnectorOperator DIVISION = new MarketoConnectorOperator("DIVISION");
        /// <summary>
        /// Constant GREATER_THAN for MarketoConnectorOperator
        /// </summary>
        public static readonly MarketoConnectorOperator GREATER_THAN = new MarketoConnectorOperator("GREATER_THAN");
        /// <summary>
        /// Constant LESS_THAN for MarketoConnectorOperator
        /// </summary>
        public static readonly MarketoConnectorOperator LESS_THAN = new MarketoConnectorOperator("LESS_THAN");
        /// <summary>
        /// Constant MASK_ALL for MarketoConnectorOperator
        /// </summary>
        public static readonly MarketoConnectorOperator MASK_ALL = new MarketoConnectorOperator("MASK_ALL");
        /// <summary>
        /// Constant MASK_FIRST_N for MarketoConnectorOperator
        /// </summary>
        public static readonly MarketoConnectorOperator MASK_FIRST_N = new MarketoConnectorOperator("MASK_FIRST_N");
        /// <summary>
        /// Constant MASK_LAST_N for MarketoConnectorOperator
        /// </summary>
        public static readonly MarketoConnectorOperator MASK_LAST_N = new MarketoConnectorOperator("MASK_LAST_N");
        /// <summary>
        /// Constant MULTIPLICATION for MarketoConnectorOperator
        /// </summary>
        public static readonly MarketoConnectorOperator MULTIPLICATION = new MarketoConnectorOperator("MULTIPLICATION");
        /// <summary>
        /// Constant NO_OP for MarketoConnectorOperator
        /// </summary>
        public static readonly MarketoConnectorOperator NO_OP = new MarketoConnectorOperator("NO_OP");
        /// <summary>
        /// Constant PROJECTION for MarketoConnectorOperator
        /// </summary>
        public static readonly MarketoConnectorOperator PROJECTION = new MarketoConnectorOperator("PROJECTION");
        /// <summary>
        /// Constant SUBTRACTION for MarketoConnectorOperator
        /// </summary>
        public static readonly MarketoConnectorOperator SUBTRACTION = new MarketoConnectorOperator("SUBTRACTION");
        /// <summary>
        /// Constant VALIDATE_NON_NEGATIVE for MarketoConnectorOperator
        /// </summary>
        public static readonly MarketoConnectorOperator VALIDATE_NON_NEGATIVE = new MarketoConnectorOperator("VALIDATE_NON_NEGATIVE");
        /// <summary>
        /// Constant VALIDATE_NON_NULL for MarketoConnectorOperator
        /// </summary>
        public static readonly MarketoConnectorOperator VALIDATE_NON_NULL = new MarketoConnectorOperator("VALIDATE_NON_NULL");
        /// <summary>
        /// Constant VALIDATE_NON_ZERO for MarketoConnectorOperator
        /// </summary>
        public static readonly MarketoConnectorOperator VALIDATE_NON_ZERO = new MarketoConnectorOperator("VALIDATE_NON_ZERO");
        /// <summary>
        /// Constant VALIDATE_NUMERIC for MarketoConnectorOperator
        /// </summary>
        public static readonly MarketoConnectorOperator VALIDATE_NUMERIC = new MarketoConnectorOperator("VALIDATE_NUMERIC");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MarketoConnectorOperator(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MarketoConnectorOperator FindValue(string value)
        {
            return FindValue<MarketoConnectorOperator>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MarketoConnectorOperator(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Operator.
    /// </summary>
    public class Operator : ConstantClass
    {

        /// <summary>
        /// Constant ADDITION for Operator
        /// </summary>
        public static readonly Operator ADDITION = new Operator("ADDITION");
        /// <summary>
        /// Constant BETWEEN for Operator
        /// </summary>
        public static readonly Operator BETWEEN = new Operator("BETWEEN");
        /// <summary>
        /// Constant CONTAINS for Operator
        /// </summary>
        public static readonly Operator CONTAINS = new Operator("CONTAINS");
        /// <summary>
        /// Constant DIVISION for Operator
        /// </summary>
        public static readonly Operator DIVISION = new Operator("DIVISION");
        /// <summary>
        /// Constant EQUAL_TO for Operator
        /// </summary>
        public static readonly Operator EQUAL_TO = new Operator("EQUAL_TO");
        /// <summary>
        /// Constant GREATER_THAN for Operator
        /// </summary>
        public static readonly Operator GREATER_THAN = new Operator("GREATER_THAN");
        /// <summary>
        /// Constant GREATER_THAN_OR_EQUAL_TO for Operator
        /// </summary>
        public static readonly Operator GREATER_THAN_OR_EQUAL_TO = new Operator("GREATER_THAN_OR_EQUAL_TO");
        /// <summary>
        /// Constant LESS_THAN for Operator
        /// </summary>
        public static readonly Operator LESS_THAN = new Operator("LESS_THAN");
        /// <summary>
        /// Constant LESS_THAN_OR_EQUAL_TO for Operator
        /// </summary>
        public static readonly Operator LESS_THAN_OR_EQUAL_TO = new Operator("LESS_THAN_OR_EQUAL_TO");
        /// <summary>
        /// Constant MASK_ALL for Operator
        /// </summary>
        public static readonly Operator MASK_ALL = new Operator("MASK_ALL");
        /// <summary>
        /// Constant MASK_FIRST_N for Operator
        /// </summary>
        public static readonly Operator MASK_FIRST_N = new Operator("MASK_FIRST_N");
        /// <summary>
        /// Constant MASK_LAST_N for Operator
        /// </summary>
        public static readonly Operator MASK_LAST_N = new Operator("MASK_LAST_N");
        /// <summary>
        /// Constant MULTIPLICATION for Operator
        /// </summary>
        public static readonly Operator MULTIPLICATION = new Operator("MULTIPLICATION");
        /// <summary>
        /// Constant NO_OP for Operator
        /// </summary>
        public static readonly Operator NO_OP = new Operator("NO_OP");
        /// <summary>
        /// Constant NOT_EQUAL_TO for Operator
        /// </summary>
        public static readonly Operator NOT_EQUAL_TO = new Operator("NOT_EQUAL_TO");
        /// <summary>
        /// Constant PROJECTION for Operator
        /// </summary>
        public static readonly Operator PROJECTION = new Operator("PROJECTION");
        /// <summary>
        /// Constant SUBTRACTION for Operator
        /// </summary>
        public static readonly Operator SUBTRACTION = new Operator("SUBTRACTION");
        /// <summary>
        /// Constant VALIDATE_NON_NEGATIVE for Operator
        /// </summary>
        public static readonly Operator VALIDATE_NON_NEGATIVE = new Operator("VALIDATE_NON_NEGATIVE");
        /// <summary>
        /// Constant VALIDATE_NON_NULL for Operator
        /// </summary>
        public static readonly Operator VALIDATE_NON_NULL = new Operator("VALIDATE_NON_NULL");
        /// <summary>
        /// Constant VALIDATE_NON_ZERO for Operator
        /// </summary>
        public static readonly Operator VALIDATE_NON_ZERO = new Operator("VALIDATE_NON_ZERO");
        /// <summary>
        /// Constant VALIDATE_NUMERIC for Operator
        /// </summary>
        public static readonly Operator VALIDATE_NUMERIC = new Operator("VALIDATE_NUMERIC");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Operator(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Operator FindValue(string value)
        {
            return FindValue<Operator>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Operator(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type OperatorPropertiesKeys.
    /// </summary>
    public class OperatorPropertiesKeys : ConstantClass
    {

        /// <summary>
        /// Constant CONCAT_FORMAT for OperatorPropertiesKeys
        /// </summary>
        public static readonly OperatorPropertiesKeys CONCAT_FORMAT = new OperatorPropertiesKeys("CONCAT_FORMAT");
        /// <summary>
        /// Constant DATA_TYPE for OperatorPropertiesKeys
        /// </summary>
        public static readonly OperatorPropertiesKeys DATA_TYPE = new OperatorPropertiesKeys("DATA_TYPE");
        /// <summary>
        /// Constant DESTINATION_DATA_TYPE for OperatorPropertiesKeys
        /// </summary>
        public static readonly OperatorPropertiesKeys DESTINATION_DATA_TYPE = new OperatorPropertiesKeys("DESTINATION_DATA_TYPE");
        /// <summary>
        /// Constant LOWER_BOUND for OperatorPropertiesKeys
        /// </summary>
        public static readonly OperatorPropertiesKeys LOWER_BOUND = new OperatorPropertiesKeys("LOWER_BOUND");
        /// <summary>
        /// Constant MASK_LENGTH for OperatorPropertiesKeys
        /// </summary>
        public static readonly OperatorPropertiesKeys MASK_LENGTH = new OperatorPropertiesKeys("MASK_LENGTH");
        /// <summary>
        /// Constant MASK_VALUE for OperatorPropertiesKeys
        /// </summary>
        public static readonly OperatorPropertiesKeys MASK_VALUE = new OperatorPropertiesKeys("MASK_VALUE");
        /// <summary>
        /// Constant MATH_OPERATION_FIELDS_ORDER for OperatorPropertiesKeys
        /// </summary>
        public static readonly OperatorPropertiesKeys MATH_OPERATION_FIELDS_ORDER = new OperatorPropertiesKeys("MATH_OPERATION_FIELDS_ORDER");
        /// <summary>
        /// Constant SOURCE_DATA_TYPE for OperatorPropertiesKeys
        /// </summary>
        public static readonly OperatorPropertiesKeys SOURCE_DATA_TYPE = new OperatorPropertiesKeys("SOURCE_DATA_TYPE");
        /// <summary>
        /// Constant SUBFIELD_CATEGORY_MAP for OperatorPropertiesKeys
        /// </summary>
        public static readonly OperatorPropertiesKeys SUBFIELD_CATEGORY_MAP = new OperatorPropertiesKeys("SUBFIELD_CATEGORY_MAP");
        /// <summary>
        /// Constant TRUNCATE_LENGTH for OperatorPropertiesKeys
        /// </summary>
        public static readonly OperatorPropertiesKeys TRUNCATE_LENGTH = new OperatorPropertiesKeys("TRUNCATE_LENGTH");
        /// <summary>
        /// Constant UPPER_BOUND for OperatorPropertiesKeys
        /// </summary>
        public static readonly OperatorPropertiesKeys UPPER_BOUND = new OperatorPropertiesKeys("UPPER_BOUND");
        /// <summary>
        /// Constant VALIDATION_ACTION for OperatorPropertiesKeys
        /// </summary>
        public static readonly OperatorPropertiesKeys VALIDATION_ACTION = new OperatorPropertiesKeys("VALIDATION_ACTION");
        /// <summary>
        /// Constant VALUE for OperatorPropertiesKeys
        /// </summary>
        public static readonly OperatorPropertiesKeys VALUE = new OperatorPropertiesKeys("VALUE");
        /// <summary>
        /// Constant VALUES for OperatorPropertiesKeys
        /// </summary>
        public static readonly OperatorPropertiesKeys VALUES = new OperatorPropertiesKeys("VALUES");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public OperatorPropertiesKeys(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static OperatorPropertiesKeys FindValue(string value)
        {
            return FindValue<OperatorPropertiesKeys>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator OperatorPropertiesKeys(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PrefixFormat.
    /// </summary>
    public class PrefixFormat : ConstantClass
    {

        /// <summary>
        /// Constant DAY for PrefixFormat
        /// </summary>
        public static readonly PrefixFormat DAY = new PrefixFormat("DAY");
        /// <summary>
        /// Constant HOUR for PrefixFormat
        /// </summary>
        public static readonly PrefixFormat HOUR = new PrefixFormat("HOUR");
        /// <summary>
        /// Constant MINUTE for PrefixFormat
        /// </summary>
        public static readonly PrefixFormat MINUTE = new PrefixFormat("MINUTE");
        /// <summary>
        /// Constant MONTH for PrefixFormat
        /// </summary>
        public static readonly PrefixFormat MONTH = new PrefixFormat("MONTH");
        /// <summary>
        /// Constant YEAR for PrefixFormat
        /// </summary>
        public static readonly PrefixFormat YEAR = new PrefixFormat("YEAR");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PrefixFormat(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PrefixFormat FindValue(string value)
        {
            return FindValue<PrefixFormat>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PrefixFormat(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PrefixType.
    /// </summary>
    public class PrefixType : ConstantClass
    {

        /// <summary>
        /// Constant FILENAME for PrefixType
        /// </summary>
        public static readonly PrefixType FILENAME = new PrefixType("FILENAME");
        /// <summary>
        /// Constant PATH for PrefixType
        /// </summary>
        public static readonly PrefixType PATH = new PrefixType("PATH");
        /// <summary>
        /// Constant PATH_AND_FILENAME for PrefixType
        /// </summary>
        public static readonly PrefixType PATH_AND_FILENAME = new PrefixType("PATH_AND_FILENAME");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PrefixType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PrefixType FindValue(string value)
        {
            return FindValue<PrefixType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PrefixType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type S3ConnectorOperator.
    /// </summary>
    public class S3ConnectorOperator : ConstantClass
    {

        /// <summary>
        /// Constant ADDITION for S3ConnectorOperator
        /// </summary>
        public static readonly S3ConnectorOperator ADDITION = new S3ConnectorOperator("ADDITION");
        /// <summary>
        /// Constant BETWEEN for S3ConnectorOperator
        /// </summary>
        public static readonly S3ConnectorOperator BETWEEN = new S3ConnectorOperator("BETWEEN");
        /// <summary>
        /// Constant DIVISION for S3ConnectorOperator
        /// </summary>
        public static readonly S3ConnectorOperator DIVISION = new S3ConnectorOperator("DIVISION");
        /// <summary>
        /// Constant EQUAL_TO for S3ConnectorOperator
        /// </summary>
        public static readonly S3ConnectorOperator EQUAL_TO = new S3ConnectorOperator("EQUAL_TO");
        /// <summary>
        /// Constant GREATER_THAN for S3ConnectorOperator
        /// </summary>
        public static readonly S3ConnectorOperator GREATER_THAN = new S3ConnectorOperator("GREATER_THAN");
        /// <summary>
        /// Constant GREATER_THAN_OR_EQUAL_TO for S3ConnectorOperator
        /// </summary>
        public static readonly S3ConnectorOperator GREATER_THAN_OR_EQUAL_TO = new S3ConnectorOperator("GREATER_THAN_OR_EQUAL_TO");
        /// <summary>
        /// Constant LESS_THAN for S3ConnectorOperator
        /// </summary>
        public static readonly S3ConnectorOperator LESS_THAN = new S3ConnectorOperator("LESS_THAN");
        /// <summary>
        /// Constant LESS_THAN_OR_EQUAL_TO for S3ConnectorOperator
        /// </summary>
        public static readonly S3ConnectorOperator LESS_THAN_OR_EQUAL_TO = new S3ConnectorOperator("LESS_THAN_OR_EQUAL_TO");
        /// <summary>
        /// Constant MASK_ALL for S3ConnectorOperator
        /// </summary>
        public static readonly S3ConnectorOperator MASK_ALL = new S3ConnectorOperator("MASK_ALL");
        /// <summary>
        /// Constant MASK_FIRST_N for S3ConnectorOperator
        /// </summary>
        public static readonly S3ConnectorOperator MASK_FIRST_N = new S3ConnectorOperator("MASK_FIRST_N");
        /// <summary>
        /// Constant MASK_LAST_N for S3ConnectorOperator
        /// </summary>
        public static readonly S3ConnectorOperator MASK_LAST_N = new S3ConnectorOperator("MASK_LAST_N");
        /// <summary>
        /// Constant MULTIPLICATION for S3ConnectorOperator
        /// </summary>
        public static readonly S3ConnectorOperator MULTIPLICATION = new S3ConnectorOperator("MULTIPLICATION");
        /// <summary>
        /// Constant NO_OP for S3ConnectorOperator
        /// </summary>
        public static readonly S3ConnectorOperator NO_OP = new S3ConnectorOperator("NO_OP");
        /// <summary>
        /// Constant NOT_EQUAL_TO for S3ConnectorOperator
        /// </summary>
        public static readonly S3ConnectorOperator NOT_EQUAL_TO = new S3ConnectorOperator("NOT_EQUAL_TO");
        /// <summary>
        /// Constant PROJECTION for S3ConnectorOperator
        /// </summary>
        public static readonly S3ConnectorOperator PROJECTION = new S3ConnectorOperator("PROJECTION");
        /// <summary>
        /// Constant SUBTRACTION for S3ConnectorOperator
        /// </summary>
        public static readonly S3ConnectorOperator SUBTRACTION = new S3ConnectorOperator("SUBTRACTION");
        /// <summary>
        /// Constant VALIDATE_NON_NEGATIVE for S3ConnectorOperator
        /// </summary>
        public static readonly S3ConnectorOperator VALIDATE_NON_NEGATIVE = new S3ConnectorOperator("VALIDATE_NON_NEGATIVE");
        /// <summary>
        /// Constant VALIDATE_NON_NULL for S3ConnectorOperator
        /// </summary>
        public static readonly S3ConnectorOperator VALIDATE_NON_NULL = new S3ConnectorOperator("VALIDATE_NON_NULL");
        /// <summary>
        /// Constant VALIDATE_NON_ZERO for S3ConnectorOperator
        /// </summary>
        public static readonly S3ConnectorOperator VALIDATE_NON_ZERO = new S3ConnectorOperator("VALIDATE_NON_ZERO");
        /// <summary>
        /// Constant VALIDATE_NUMERIC for S3ConnectorOperator
        /// </summary>
        public static readonly S3ConnectorOperator VALIDATE_NUMERIC = new S3ConnectorOperator("VALIDATE_NUMERIC");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public S3ConnectorOperator(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static S3ConnectorOperator FindValue(string value)
        {
            return FindValue<S3ConnectorOperator>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator S3ConnectorOperator(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SalesforceConnectorOperator.
    /// </summary>
    public class SalesforceConnectorOperator : ConstantClass
    {

        /// <summary>
        /// Constant ADDITION for SalesforceConnectorOperator
        /// </summary>
        public static readonly SalesforceConnectorOperator ADDITION = new SalesforceConnectorOperator("ADDITION");
        /// <summary>
        /// Constant BETWEEN for SalesforceConnectorOperator
        /// </summary>
        public static readonly SalesforceConnectorOperator BETWEEN = new SalesforceConnectorOperator("BETWEEN");
        /// <summary>
        /// Constant CONTAINS for SalesforceConnectorOperator
        /// </summary>
        public static readonly SalesforceConnectorOperator CONTAINS = new SalesforceConnectorOperator("CONTAINS");
        /// <summary>
        /// Constant DIVISION for SalesforceConnectorOperator
        /// </summary>
        public static readonly SalesforceConnectorOperator DIVISION = new SalesforceConnectorOperator("DIVISION");
        /// <summary>
        /// Constant EQUAL_TO for SalesforceConnectorOperator
        /// </summary>
        public static readonly SalesforceConnectorOperator EQUAL_TO = new SalesforceConnectorOperator("EQUAL_TO");
        /// <summary>
        /// Constant GREATER_THAN for SalesforceConnectorOperator
        /// </summary>
        public static readonly SalesforceConnectorOperator GREATER_THAN = new SalesforceConnectorOperator("GREATER_THAN");
        /// <summary>
        /// Constant GREATER_THAN_OR_EQUAL_TO for SalesforceConnectorOperator
        /// </summary>
        public static readonly SalesforceConnectorOperator GREATER_THAN_OR_EQUAL_TO = new SalesforceConnectorOperator("GREATER_THAN_OR_EQUAL_TO");
        /// <summary>
        /// Constant LESS_THAN for SalesforceConnectorOperator
        /// </summary>
        public static readonly SalesforceConnectorOperator LESS_THAN = new SalesforceConnectorOperator("LESS_THAN");
        /// <summary>
        /// Constant LESS_THAN_OR_EQUAL_TO for SalesforceConnectorOperator
        /// </summary>
        public static readonly SalesforceConnectorOperator LESS_THAN_OR_EQUAL_TO = new SalesforceConnectorOperator("LESS_THAN_OR_EQUAL_TO");
        /// <summary>
        /// Constant MASK_ALL for SalesforceConnectorOperator
        /// </summary>
        public static readonly SalesforceConnectorOperator MASK_ALL = new SalesforceConnectorOperator("MASK_ALL");
        /// <summary>
        /// Constant MASK_FIRST_N for SalesforceConnectorOperator
        /// </summary>
        public static readonly SalesforceConnectorOperator MASK_FIRST_N = new SalesforceConnectorOperator("MASK_FIRST_N");
        /// <summary>
        /// Constant MASK_LAST_N for SalesforceConnectorOperator
        /// </summary>
        public static readonly SalesforceConnectorOperator MASK_LAST_N = new SalesforceConnectorOperator("MASK_LAST_N");
        /// <summary>
        /// Constant MULTIPLICATION for SalesforceConnectorOperator
        /// </summary>
        public static readonly SalesforceConnectorOperator MULTIPLICATION = new SalesforceConnectorOperator("MULTIPLICATION");
        /// <summary>
        /// Constant NO_OP for SalesforceConnectorOperator
        /// </summary>
        public static readonly SalesforceConnectorOperator NO_OP = new SalesforceConnectorOperator("NO_OP");
        /// <summary>
        /// Constant NOT_EQUAL_TO for SalesforceConnectorOperator
        /// </summary>
        public static readonly SalesforceConnectorOperator NOT_EQUAL_TO = new SalesforceConnectorOperator("NOT_EQUAL_TO");
        /// <summary>
        /// Constant PROJECTION for SalesforceConnectorOperator
        /// </summary>
        public static readonly SalesforceConnectorOperator PROJECTION = new SalesforceConnectorOperator("PROJECTION");
        /// <summary>
        /// Constant SUBTRACTION for SalesforceConnectorOperator
        /// </summary>
        public static readonly SalesforceConnectorOperator SUBTRACTION = new SalesforceConnectorOperator("SUBTRACTION");
        /// <summary>
        /// Constant VALIDATE_NON_NEGATIVE for SalesforceConnectorOperator
        /// </summary>
        public static readonly SalesforceConnectorOperator VALIDATE_NON_NEGATIVE = new SalesforceConnectorOperator("VALIDATE_NON_NEGATIVE");
        /// <summary>
        /// Constant VALIDATE_NON_NULL for SalesforceConnectorOperator
        /// </summary>
        public static readonly SalesforceConnectorOperator VALIDATE_NON_NULL = new SalesforceConnectorOperator("VALIDATE_NON_NULL");
        /// <summary>
        /// Constant VALIDATE_NON_ZERO for SalesforceConnectorOperator
        /// </summary>
        public static readonly SalesforceConnectorOperator VALIDATE_NON_ZERO = new SalesforceConnectorOperator("VALIDATE_NON_ZERO");
        /// <summary>
        /// Constant VALIDATE_NUMERIC for SalesforceConnectorOperator
        /// </summary>
        public static readonly SalesforceConnectorOperator VALIDATE_NUMERIC = new SalesforceConnectorOperator("VALIDATE_NUMERIC");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SalesforceConnectorOperator(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SalesforceConnectorOperator FindValue(string value)
        {
            return FindValue<SalesforceConnectorOperator>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SalesforceConnectorOperator(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ScheduleFrequencyType.
    /// </summary>
    public class ScheduleFrequencyType : ConstantClass
    {

        /// <summary>
        /// Constant BYMINUTE for ScheduleFrequencyType
        /// </summary>
        public static readonly ScheduleFrequencyType BYMINUTE = new ScheduleFrequencyType("BYMINUTE");
        /// <summary>
        /// Constant DAILY for ScheduleFrequencyType
        /// </summary>
        public static readonly ScheduleFrequencyType DAILY = new ScheduleFrequencyType("DAILY");
        /// <summary>
        /// Constant HOURLY for ScheduleFrequencyType
        /// </summary>
        public static readonly ScheduleFrequencyType HOURLY = new ScheduleFrequencyType("HOURLY");
        /// <summary>
        /// Constant MONTHLY for ScheduleFrequencyType
        /// </summary>
        public static readonly ScheduleFrequencyType MONTHLY = new ScheduleFrequencyType("MONTHLY");
        /// <summary>
        /// Constant ONCE for ScheduleFrequencyType
        /// </summary>
        public static readonly ScheduleFrequencyType ONCE = new ScheduleFrequencyType("ONCE");
        /// <summary>
        /// Constant WEEKLY for ScheduleFrequencyType
        /// </summary>
        public static readonly ScheduleFrequencyType WEEKLY = new ScheduleFrequencyType("WEEKLY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ScheduleFrequencyType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ScheduleFrequencyType FindValue(string value)
        {
            return FindValue<ScheduleFrequencyType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ScheduleFrequencyType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ServiceNowConnectorOperator.
    /// </summary>
    public class ServiceNowConnectorOperator : ConstantClass
    {

        /// <summary>
        /// Constant ADDITION for ServiceNowConnectorOperator
        /// </summary>
        public static readonly ServiceNowConnectorOperator ADDITION = new ServiceNowConnectorOperator("ADDITION");
        /// <summary>
        /// Constant BETWEEN for ServiceNowConnectorOperator
        /// </summary>
        public static readonly ServiceNowConnectorOperator BETWEEN = new ServiceNowConnectorOperator("BETWEEN");
        /// <summary>
        /// Constant CONTAINS for ServiceNowConnectorOperator
        /// </summary>
        public static readonly ServiceNowConnectorOperator CONTAINS = new ServiceNowConnectorOperator("CONTAINS");
        /// <summary>
        /// Constant DIVISION for ServiceNowConnectorOperator
        /// </summary>
        public static readonly ServiceNowConnectorOperator DIVISION = new ServiceNowConnectorOperator("DIVISION");
        /// <summary>
        /// Constant EQUAL_TO for ServiceNowConnectorOperator
        /// </summary>
        public static readonly ServiceNowConnectorOperator EQUAL_TO = new ServiceNowConnectorOperator("EQUAL_TO");
        /// <summary>
        /// Constant GREATER_THAN for ServiceNowConnectorOperator
        /// </summary>
        public static readonly ServiceNowConnectorOperator GREATER_THAN = new ServiceNowConnectorOperator("GREATER_THAN");
        /// <summary>
        /// Constant GREATER_THAN_OR_EQUAL_TO for ServiceNowConnectorOperator
        /// </summary>
        public static readonly ServiceNowConnectorOperator GREATER_THAN_OR_EQUAL_TO = new ServiceNowConnectorOperator("GREATER_THAN_OR_EQUAL_TO");
        /// <summary>
        /// Constant LESS_THAN for ServiceNowConnectorOperator
        /// </summary>
        public static readonly ServiceNowConnectorOperator LESS_THAN = new ServiceNowConnectorOperator("LESS_THAN");
        /// <summary>
        /// Constant LESS_THAN_OR_EQUAL_TO for ServiceNowConnectorOperator
        /// </summary>
        public static readonly ServiceNowConnectorOperator LESS_THAN_OR_EQUAL_TO = new ServiceNowConnectorOperator("LESS_THAN_OR_EQUAL_TO");
        /// <summary>
        /// Constant MASK_ALL for ServiceNowConnectorOperator
        /// </summary>
        public static readonly ServiceNowConnectorOperator MASK_ALL = new ServiceNowConnectorOperator("MASK_ALL");
        /// <summary>
        /// Constant MASK_FIRST_N for ServiceNowConnectorOperator
        /// </summary>
        public static readonly ServiceNowConnectorOperator MASK_FIRST_N = new ServiceNowConnectorOperator("MASK_FIRST_N");
        /// <summary>
        /// Constant MASK_LAST_N for ServiceNowConnectorOperator
        /// </summary>
        public static readonly ServiceNowConnectorOperator MASK_LAST_N = new ServiceNowConnectorOperator("MASK_LAST_N");
        /// <summary>
        /// Constant MULTIPLICATION for ServiceNowConnectorOperator
        /// </summary>
        public static readonly ServiceNowConnectorOperator MULTIPLICATION = new ServiceNowConnectorOperator("MULTIPLICATION");
        /// <summary>
        /// Constant NO_OP for ServiceNowConnectorOperator
        /// </summary>
        public static readonly ServiceNowConnectorOperator NO_OP = new ServiceNowConnectorOperator("NO_OP");
        /// <summary>
        /// Constant NOT_EQUAL_TO for ServiceNowConnectorOperator
        /// </summary>
        public static readonly ServiceNowConnectorOperator NOT_EQUAL_TO = new ServiceNowConnectorOperator("NOT_EQUAL_TO");
        /// <summary>
        /// Constant PROJECTION for ServiceNowConnectorOperator
        /// </summary>
        public static readonly ServiceNowConnectorOperator PROJECTION = new ServiceNowConnectorOperator("PROJECTION");
        /// <summary>
        /// Constant SUBTRACTION for ServiceNowConnectorOperator
        /// </summary>
        public static readonly ServiceNowConnectorOperator SUBTRACTION = new ServiceNowConnectorOperator("SUBTRACTION");
        /// <summary>
        /// Constant VALIDATE_NON_NEGATIVE for ServiceNowConnectorOperator
        /// </summary>
        public static readonly ServiceNowConnectorOperator VALIDATE_NON_NEGATIVE = new ServiceNowConnectorOperator("VALIDATE_NON_NEGATIVE");
        /// <summary>
        /// Constant VALIDATE_NON_NULL for ServiceNowConnectorOperator
        /// </summary>
        public static readonly ServiceNowConnectorOperator VALIDATE_NON_NULL = new ServiceNowConnectorOperator("VALIDATE_NON_NULL");
        /// <summary>
        /// Constant VALIDATE_NON_ZERO for ServiceNowConnectorOperator
        /// </summary>
        public static readonly ServiceNowConnectorOperator VALIDATE_NON_ZERO = new ServiceNowConnectorOperator("VALIDATE_NON_ZERO");
        /// <summary>
        /// Constant VALIDATE_NUMERIC for ServiceNowConnectorOperator
        /// </summary>
        public static readonly ServiceNowConnectorOperator VALIDATE_NUMERIC = new ServiceNowConnectorOperator("VALIDATE_NUMERIC");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ServiceNowConnectorOperator(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ServiceNowConnectorOperator FindValue(string value)
        {
            return FindValue<ServiceNowConnectorOperator>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ServiceNowConnectorOperator(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SingularConnectorOperator.
    /// </summary>
    public class SingularConnectorOperator : ConstantClass
    {

        /// <summary>
        /// Constant ADDITION for SingularConnectorOperator
        /// </summary>
        public static readonly SingularConnectorOperator ADDITION = new SingularConnectorOperator("ADDITION");
        /// <summary>
        /// Constant DIVISION for SingularConnectorOperator
        /// </summary>
        public static readonly SingularConnectorOperator DIVISION = new SingularConnectorOperator("DIVISION");
        /// <summary>
        /// Constant EQUAL_TO for SingularConnectorOperator
        /// </summary>
        public static readonly SingularConnectorOperator EQUAL_TO = new SingularConnectorOperator("EQUAL_TO");
        /// <summary>
        /// Constant MASK_ALL for SingularConnectorOperator
        /// </summary>
        public static readonly SingularConnectorOperator MASK_ALL = new SingularConnectorOperator("MASK_ALL");
        /// <summary>
        /// Constant MASK_FIRST_N for SingularConnectorOperator
        /// </summary>
        public static readonly SingularConnectorOperator MASK_FIRST_N = new SingularConnectorOperator("MASK_FIRST_N");
        /// <summary>
        /// Constant MASK_LAST_N for SingularConnectorOperator
        /// </summary>
        public static readonly SingularConnectorOperator MASK_LAST_N = new SingularConnectorOperator("MASK_LAST_N");
        /// <summary>
        /// Constant MULTIPLICATION for SingularConnectorOperator
        /// </summary>
        public static readonly SingularConnectorOperator MULTIPLICATION = new SingularConnectorOperator("MULTIPLICATION");
        /// <summary>
        /// Constant NO_OP for SingularConnectorOperator
        /// </summary>
        public static readonly SingularConnectorOperator NO_OP = new SingularConnectorOperator("NO_OP");
        /// <summary>
        /// Constant PROJECTION for SingularConnectorOperator
        /// </summary>
        public static readonly SingularConnectorOperator PROJECTION = new SingularConnectorOperator("PROJECTION");
        /// <summary>
        /// Constant SUBTRACTION for SingularConnectorOperator
        /// </summary>
        public static readonly SingularConnectorOperator SUBTRACTION = new SingularConnectorOperator("SUBTRACTION");
        /// <summary>
        /// Constant VALIDATE_NON_NEGATIVE for SingularConnectorOperator
        /// </summary>
        public static readonly SingularConnectorOperator VALIDATE_NON_NEGATIVE = new SingularConnectorOperator("VALIDATE_NON_NEGATIVE");
        /// <summary>
        /// Constant VALIDATE_NON_NULL for SingularConnectorOperator
        /// </summary>
        public static readonly SingularConnectorOperator VALIDATE_NON_NULL = new SingularConnectorOperator("VALIDATE_NON_NULL");
        /// <summary>
        /// Constant VALIDATE_NON_ZERO for SingularConnectorOperator
        /// </summary>
        public static readonly SingularConnectorOperator VALIDATE_NON_ZERO = new SingularConnectorOperator("VALIDATE_NON_ZERO");
        /// <summary>
        /// Constant VALIDATE_NUMERIC for SingularConnectorOperator
        /// </summary>
        public static readonly SingularConnectorOperator VALIDATE_NUMERIC = new SingularConnectorOperator("VALIDATE_NUMERIC");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SingularConnectorOperator(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SingularConnectorOperator FindValue(string value)
        {
            return FindValue<SingularConnectorOperator>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SingularConnectorOperator(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SlackConnectorOperator.
    /// </summary>
    public class SlackConnectorOperator : ConstantClass
    {

        /// <summary>
        /// Constant ADDITION for SlackConnectorOperator
        /// </summary>
        public static readonly SlackConnectorOperator ADDITION = new SlackConnectorOperator("ADDITION");
        /// <summary>
        /// Constant BETWEEN for SlackConnectorOperator
        /// </summary>
        public static readonly SlackConnectorOperator BETWEEN = new SlackConnectorOperator("BETWEEN");
        /// <summary>
        /// Constant DIVISION for SlackConnectorOperator
        /// </summary>
        public static readonly SlackConnectorOperator DIVISION = new SlackConnectorOperator("DIVISION");
        /// <summary>
        /// Constant EQUAL_TO for SlackConnectorOperator
        /// </summary>
        public static readonly SlackConnectorOperator EQUAL_TO = new SlackConnectorOperator("EQUAL_TO");
        /// <summary>
        /// Constant GREATER_THAN for SlackConnectorOperator
        /// </summary>
        public static readonly SlackConnectorOperator GREATER_THAN = new SlackConnectorOperator("GREATER_THAN");
        /// <summary>
        /// Constant GREATER_THAN_OR_EQUAL_TO for SlackConnectorOperator
        /// </summary>
        public static readonly SlackConnectorOperator GREATER_THAN_OR_EQUAL_TO = new SlackConnectorOperator("GREATER_THAN_OR_EQUAL_TO");
        /// <summary>
        /// Constant LESS_THAN for SlackConnectorOperator
        /// </summary>
        public static readonly SlackConnectorOperator LESS_THAN = new SlackConnectorOperator("LESS_THAN");
        /// <summary>
        /// Constant LESS_THAN_OR_EQUAL_TO for SlackConnectorOperator
        /// </summary>
        public static readonly SlackConnectorOperator LESS_THAN_OR_EQUAL_TO = new SlackConnectorOperator("LESS_THAN_OR_EQUAL_TO");
        /// <summary>
        /// Constant MASK_ALL for SlackConnectorOperator
        /// </summary>
        public static readonly SlackConnectorOperator MASK_ALL = new SlackConnectorOperator("MASK_ALL");
        /// <summary>
        /// Constant MASK_FIRST_N for SlackConnectorOperator
        /// </summary>
        public static readonly SlackConnectorOperator MASK_FIRST_N = new SlackConnectorOperator("MASK_FIRST_N");
        /// <summary>
        /// Constant MASK_LAST_N for SlackConnectorOperator
        /// </summary>
        public static readonly SlackConnectorOperator MASK_LAST_N = new SlackConnectorOperator("MASK_LAST_N");
        /// <summary>
        /// Constant MULTIPLICATION for SlackConnectorOperator
        /// </summary>
        public static readonly SlackConnectorOperator MULTIPLICATION = new SlackConnectorOperator("MULTIPLICATION");
        /// <summary>
        /// Constant NO_OP for SlackConnectorOperator
        /// </summary>
        public static readonly SlackConnectorOperator NO_OP = new SlackConnectorOperator("NO_OP");
        /// <summary>
        /// Constant PROJECTION for SlackConnectorOperator
        /// </summary>
        public static readonly SlackConnectorOperator PROJECTION = new SlackConnectorOperator("PROJECTION");
        /// <summary>
        /// Constant SUBTRACTION for SlackConnectorOperator
        /// </summary>
        public static readonly SlackConnectorOperator SUBTRACTION = new SlackConnectorOperator("SUBTRACTION");
        /// <summary>
        /// Constant VALIDATE_NON_NEGATIVE for SlackConnectorOperator
        /// </summary>
        public static readonly SlackConnectorOperator VALIDATE_NON_NEGATIVE = new SlackConnectorOperator("VALIDATE_NON_NEGATIVE");
        /// <summary>
        /// Constant VALIDATE_NON_NULL for SlackConnectorOperator
        /// </summary>
        public static readonly SlackConnectorOperator VALIDATE_NON_NULL = new SlackConnectorOperator("VALIDATE_NON_NULL");
        /// <summary>
        /// Constant VALIDATE_NON_ZERO for SlackConnectorOperator
        /// </summary>
        public static readonly SlackConnectorOperator VALIDATE_NON_ZERO = new SlackConnectorOperator("VALIDATE_NON_ZERO");
        /// <summary>
        /// Constant VALIDATE_NUMERIC for SlackConnectorOperator
        /// </summary>
        public static readonly SlackConnectorOperator VALIDATE_NUMERIC = new SlackConnectorOperator("VALIDATE_NUMERIC");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SlackConnectorOperator(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SlackConnectorOperator FindValue(string value)
        {
            return FindValue<SlackConnectorOperator>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SlackConnectorOperator(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TaskType.
    /// </summary>
    public class TaskType : ConstantClass
    {

        /// <summary>
        /// Constant Arithmetic for TaskType
        /// </summary>
        public static readonly TaskType Arithmetic = new TaskType("Arithmetic");
        /// <summary>
        /// Constant Filter for TaskType
        /// </summary>
        public static readonly TaskType Filter = new TaskType("Filter");
        /// <summary>
        /// Constant Map for TaskType
        /// </summary>
        public static readonly TaskType Map = new TaskType("Map");
        /// <summary>
        /// Constant Mask for TaskType
        /// </summary>
        public static readonly TaskType Mask = new TaskType("Mask");
        /// <summary>
        /// Constant Merge for TaskType
        /// </summary>
        public static readonly TaskType Merge = new TaskType("Merge");
        /// <summary>
        /// Constant Truncate for TaskType
        /// </summary>
        public static readonly TaskType Truncate = new TaskType("Truncate");
        /// <summary>
        /// Constant Validate for TaskType
        /// </summary>
        public static readonly TaskType Validate = new TaskType("Validate");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TaskType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TaskType FindValue(string value)
        {
            return FindValue<TaskType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TaskType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TrendmicroConnectorOperator.
    /// </summary>
    public class TrendmicroConnectorOperator : ConstantClass
    {

        /// <summary>
        /// Constant ADDITION for TrendmicroConnectorOperator
        /// </summary>
        public static readonly TrendmicroConnectorOperator ADDITION = new TrendmicroConnectorOperator("ADDITION");
        /// <summary>
        /// Constant DIVISION for TrendmicroConnectorOperator
        /// </summary>
        public static readonly TrendmicroConnectorOperator DIVISION = new TrendmicroConnectorOperator("DIVISION");
        /// <summary>
        /// Constant EQUAL_TO for TrendmicroConnectorOperator
        /// </summary>
        public static readonly TrendmicroConnectorOperator EQUAL_TO = new TrendmicroConnectorOperator("EQUAL_TO");
        /// <summary>
        /// Constant MASK_ALL for TrendmicroConnectorOperator
        /// </summary>
        public static readonly TrendmicroConnectorOperator MASK_ALL = new TrendmicroConnectorOperator("MASK_ALL");
        /// <summary>
        /// Constant MASK_FIRST_N for TrendmicroConnectorOperator
        /// </summary>
        public static readonly TrendmicroConnectorOperator MASK_FIRST_N = new TrendmicroConnectorOperator("MASK_FIRST_N");
        /// <summary>
        /// Constant MASK_LAST_N for TrendmicroConnectorOperator
        /// </summary>
        public static readonly TrendmicroConnectorOperator MASK_LAST_N = new TrendmicroConnectorOperator("MASK_LAST_N");
        /// <summary>
        /// Constant MULTIPLICATION for TrendmicroConnectorOperator
        /// </summary>
        public static readonly TrendmicroConnectorOperator MULTIPLICATION = new TrendmicroConnectorOperator("MULTIPLICATION");
        /// <summary>
        /// Constant NO_OP for TrendmicroConnectorOperator
        /// </summary>
        public static readonly TrendmicroConnectorOperator NO_OP = new TrendmicroConnectorOperator("NO_OP");
        /// <summary>
        /// Constant PROJECTION for TrendmicroConnectorOperator
        /// </summary>
        public static readonly TrendmicroConnectorOperator PROJECTION = new TrendmicroConnectorOperator("PROJECTION");
        /// <summary>
        /// Constant SUBTRACTION for TrendmicroConnectorOperator
        /// </summary>
        public static readonly TrendmicroConnectorOperator SUBTRACTION = new TrendmicroConnectorOperator("SUBTRACTION");
        /// <summary>
        /// Constant VALIDATE_NON_NEGATIVE for TrendmicroConnectorOperator
        /// </summary>
        public static readonly TrendmicroConnectorOperator VALIDATE_NON_NEGATIVE = new TrendmicroConnectorOperator("VALIDATE_NON_NEGATIVE");
        /// <summary>
        /// Constant VALIDATE_NON_NULL for TrendmicroConnectorOperator
        /// </summary>
        public static readonly TrendmicroConnectorOperator VALIDATE_NON_NULL = new TrendmicroConnectorOperator("VALIDATE_NON_NULL");
        /// <summary>
        /// Constant VALIDATE_NON_ZERO for TrendmicroConnectorOperator
        /// </summary>
        public static readonly TrendmicroConnectorOperator VALIDATE_NON_ZERO = new TrendmicroConnectorOperator("VALIDATE_NON_ZERO");
        /// <summary>
        /// Constant VALIDATE_NUMERIC for TrendmicroConnectorOperator
        /// </summary>
        public static readonly TrendmicroConnectorOperator VALIDATE_NUMERIC = new TrendmicroConnectorOperator("VALIDATE_NUMERIC");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TrendmicroConnectorOperator(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TrendmicroConnectorOperator FindValue(string value)
        {
            return FindValue<TrendmicroConnectorOperator>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TrendmicroConnectorOperator(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TriggerType.
    /// </summary>
    public class TriggerType : ConstantClass
    {

        /// <summary>
        /// Constant Event for TriggerType
        /// </summary>
        public static readonly TriggerType Event = new TriggerType("Event");
        /// <summary>
        /// Constant OnDemand for TriggerType
        /// </summary>
        public static readonly TriggerType OnDemand = new TriggerType("OnDemand");
        /// <summary>
        /// Constant Scheduled for TriggerType
        /// </summary>
        public static readonly TriggerType Scheduled = new TriggerType("Scheduled");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TriggerType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TriggerType FindValue(string value)
        {
            return FindValue<TriggerType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TriggerType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type VeevaConnectorOperator.
    /// </summary>
    public class VeevaConnectorOperator : ConstantClass
    {

        /// <summary>
        /// Constant ADDITION for VeevaConnectorOperator
        /// </summary>
        public static readonly VeevaConnectorOperator ADDITION = new VeevaConnectorOperator("ADDITION");
        /// <summary>
        /// Constant BETWEEN for VeevaConnectorOperator
        /// </summary>
        public static readonly VeevaConnectorOperator BETWEEN = new VeevaConnectorOperator("BETWEEN");
        /// <summary>
        /// Constant CONTAINS for VeevaConnectorOperator
        /// </summary>
        public static readonly VeevaConnectorOperator CONTAINS = new VeevaConnectorOperator("CONTAINS");
        /// <summary>
        /// Constant DIVISION for VeevaConnectorOperator
        /// </summary>
        public static readonly VeevaConnectorOperator DIVISION = new VeevaConnectorOperator("DIVISION");
        /// <summary>
        /// Constant EQUAL_TO for VeevaConnectorOperator
        /// </summary>
        public static readonly VeevaConnectorOperator EQUAL_TO = new VeevaConnectorOperator("EQUAL_TO");
        /// <summary>
        /// Constant GREATER_THAN for VeevaConnectorOperator
        /// </summary>
        public static readonly VeevaConnectorOperator GREATER_THAN = new VeevaConnectorOperator("GREATER_THAN");
        /// <summary>
        /// Constant GREATER_THAN_OR_EQUAL_TO for VeevaConnectorOperator
        /// </summary>
        public static readonly VeevaConnectorOperator GREATER_THAN_OR_EQUAL_TO = new VeevaConnectorOperator("GREATER_THAN_OR_EQUAL_TO");
        /// <summary>
        /// Constant LESS_THAN for VeevaConnectorOperator
        /// </summary>
        public static readonly VeevaConnectorOperator LESS_THAN = new VeevaConnectorOperator("LESS_THAN");
        /// <summary>
        /// Constant LESS_THAN_OR_EQUAL_TO for VeevaConnectorOperator
        /// </summary>
        public static readonly VeevaConnectorOperator LESS_THAN_OR_EQUAL_TO = new VeevaConnectorOperator("LESS_THAN_OR_EQUAL_TO");
        /// <summary>
        /// Constant MASK_ALL for VeevaConnectorOperator
        /// </summary>
        public static readonly VeevaConnectorOperator MASK_ALL = new VeevaConnectorOperator("MASK_ALL");
        /// <summary>
        /// Constant MASK_FIRST_N for VeevaConnectorOperator
        /// </summary>
        public static readonly VeevaConnectorOperator MASK_FIRST_N = new VeevaConnectorOperator("MASK_FIRST_N");
        /// <summary>
        /// Constant MASK_LAST_N for VeevaConnectorOperator
        /// </summary>
        public static readonly VeevaConnectorOperator MASK_LAST_N = new VeevaConnectorOperator("MASK_LAST_N");
        /// <summary>
        /// Constant MULTIPLICATION for VeevaConnectorOperator
        /// </summary>
        public static readonly VeevaConnectorOperator MULTIPLICATION = new VeevaConnectorOperator("MULTIPLICATION");
        /// <summary>
        /// Constant NO_OP for VeevaConnectorOperator
        /// </summary>
        public static readonly VeevaConnectorOperator NO_OP = new VeevaConnectorOperator("NO_OP");
        /// <summary>
        /// Constant NOT_EQUAL_TO for VeevaConnectorOperator
        /// </summary>
        public static readonly VeevaConnectorOperator NOT_EQUAL_TO = new VeevaConnectorOperator("NOT_EQUAL_TO");
        /// <summary>
        /// Constant PROJECTION for VeevaConnectorOperator
        /// </summary>
        public static readonly VeevaConnectorOperator PROJECTION = new VeevaConnectorOperator("PROJECTION");
        /// <summary>
        /// Constant SUBTRACTION for VeevaConnectorOperator
        /// </summary>
        public static readonly VeevaConnectorOperator SUBTRACTION = new VeevaConnectorOperator("SUBTRACTION");
        /// <summary>
        /// Constant VALIDATE_NON_NEGATIVE for VeevaConnectorOperator
        /// </summary>
        public static readonly VeevaConnectorOperator VALIDATE_NON_NEGATIVE = new VeevaConnectorOperator("VALIDATE_NON_NEGATIVE");
        /// <summary>
        /// Constant VALIDATE_NON_NULL for VeevaConnectorOperator
        /// </summary>
        public static readonly VeevaConnectorOperator VALIDATE_NON_NULL = new VeevaConnectorOperator("VALIDATE_NON_NULL");
        /// <summary>
        /// Constant VALIDATE_NON_ZERO for VeevaConnectorOperator
        /// </summary>
        public static readonly VeevaConnectorOperator VALIDATE_NON_ZERO = new VeevaConnectorOperator("VALIDATE_NON_ZERO");
        /// <summary>
        /// Constant VALIDATE_NUMERIC for VeevaConnectorOperator
        /// </summary>
        public static readonly VeevaConnectorOperator VALIDATE_NUMERIC = new VeevaConnectorOperator("VALIDATE_NUMERIC");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public VeevaConnectorOperator(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static VeevaConnectorOperator FindValue(string value)
        {
            return FindValue<VeevaConnectorOperator>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator VeevaConnectorOperator(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type WriteOperationType.
    /// </summary>
    public class WriteOperationType : ConstantClass
    {

        /// <summary>
        /// Constant INSERT for WriteOperationType
        /// </summary>
        public static readonly WriteOperationType INSERT = new WriteOperationType("INSERT");
        /// <summary>
        /// Constant UPDATE for WriteOperationType
        /// </summary>
        public static readonly WriteOperationType UPDATE = new WriteOperationType("UPDATE");
        /// <summary>
        /// Constant UPSERT for WriteOperationType
        /// </summary>
        public static readonly WriteOperationType UPSERT = new WriteOperationType("UPSERT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public WriteOperationType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static WriteOperationType FindValue(string value)
        {
            return FindValue<WriteOperationType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator WriteOperationType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ZendeskConnectorOperator.
    /// </summary>
    public class ZendeskConnectorOperator : ConstantClass
    {

        /// <summary>
        /// Constant ADDITION for ZendeskConnectorOperator
        /// </summary>
        public static readonly ZendeskConnectorOperator ADDITION = new ZendeskConnectorOperator("ADDITION");
        /// <summary>
        /// Constant DIVISION for ZendeskConnectorOperator
        /// </summary>
        public static readonly ZendeskConnectorOperator DIVISION = new ZendeskConnectorOperator("DIVISION");
        /// <summary>
        /// Constant GREATER_THAN for ZendeskConnectorOperator
        /// </summary>
        public static readonly ZendeskConnectorOperator GREATER_THAN = new ZendeskConnectorOperator("GREATER_THAN");
        /// <summary>
        /// Constant MASK_ALL for ZendeskConnectorOperator
        /// </summary>
        public static readonly ZendeskConnectorOperator MASK_ALL = new ZendeskConnectorOperator("MASK_ALL");
        /// <summary>
        /// Constant MASK_FIRST_N for ZendeskConnectorOperator
        /// </summary>
        public static readonly ZendeskConnectorOperator MASK_FIRST_N = new ZendeskConnectorOperator("MASK_FIRST_N");
        /// <summary>
        /// Constant MASK_LAST_N for ZendeskConnectorOperator
        /// </summary>
        public static readonly ZendeskConnectorOperator MASK_LAST_N = new ZendeskConnectorOperator("MASK_LAST_N");
        /// <summary>
        /// Constant MULTIPLICATION for ZendeskConnectorOperator
        /// </summary>
        public static readonly ZendeskConnectorOperator MULTIPLICATION = new ZendeskConnectorOperator("MULTIPLICATION");
        /// <summary>
        /// Constant NO_OP for ZendeskConnectorOperator
        /// </summary>
        public static readonly ZendeskConnectorOperator NO_OP = new ZendeskConnectorOperator("NO_OP");
        /// <summary>
        /// Constant PROJECTION for ZendeskConnectorOperator
        /// </summary>
        public static readonly ZendeskConnectorOperator PROJECTION = new ZendeskConnectorOperator("PROJECTION");
        /// <summary>
        /// Constant SUBTRACTION for ZendeskConnectorOperator
        /// </summary>
        public static readonly ZendeskConnectorOperator SUBTRACTION = new ZendeskConnectorOperator("SUBTRACTION");
        /// <summary>
        /// Constant VALIDATE_NON_NEGATIVE for ZendeskConnectorOperator
        /// </summary>
        public static readonly ZendeskConnectorOperator VALIDATE_NON_NEGATIVE = new ZendeskConnectorOperator("VALIDATE_NON_NEGATIVE");
        /// <summary>
        /// Constant VALIDATE_NON_NULL for ZendeskConnectorOperator
        /// </summary>
        public static readonly ZendeskConnectorOperator VALIDATE_NON_NULL = new ZendeskConnectorOperator("VALIDATE_NON_NULL");
        /// <summary>
        /// Constant VALIDATE_NON_ZERO for ZendeskConnectorOperator
        /// </summary>
        public static readonly ZendeskConnectorOperator VALIDATE_NON_ZERO = new ZendeskConnectorOperator("VALIDATE_NON_ZERO");
        /// <summary>
        /// Constant VALIDATE_NUMERIC for ZendeskConnectorOperator
        /// </summary>
        public static readonly ZendeskConnectorOperator VALIDATE_NUMERIC = new ZendeskConnectorOperator("VALIDATE_NUMERIC");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ZendeskConnectorOperator(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ZendeskConnectorOperator FindValue(string value)
        {
            return FindValue<ZendeskConnectorOperator>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ZendeskConnectorOperator(string value)
        {
            return FindValue(value);
        }
    }

}