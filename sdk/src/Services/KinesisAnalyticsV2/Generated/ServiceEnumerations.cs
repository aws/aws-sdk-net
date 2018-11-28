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
 * Do not modify this file. This file is generated from the kinesisanalyticsv2-2018-05-23.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.KinesisAnalyticsV2
{

    /// <summary>
    /// Constants used for properties of type ApplicationRestoreType.
    /// </summary>
    public class ApplicationRestoreType : ConstantClass
    {

        /// <summary>
        /// Constant RESTORE_FROM_CUSTOM_SNAPSHOT for ApplicationRestoreType
        /// </summary>
        public static readonly ApplicationRestoreType RESTORE_FROM_CUSTOM_SNAPSHOT = new ApplicationRestoreType("RESTORE_FROM_CUSTOM_SNAPSHOT");
        /// <summary>
        /// Constant RESTORE_FROM_LATEST_SNAPSHOT for ApplicationRestoreType
        /// </summary>
        public static readonly ApplicationRestoreType RESTORE_FROM_LATEST_SNAPSHOT = new ApplicationRestoreType("RESTORE_FROM_LATEST_SNAPSHOT");
        /// <summary>
        /// Constant SKIP_RESTORE_FROM_SNAPSHOT for ApplicationRestoreType
        /// </summary>
        public static readonly ApplicationRestoreType SKIP_RESTORE_FROM_SNAPSHOT = new ApplicationRestoreType("SKIP_RESTORE_FROM_SNAPSHOT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ApplicationRestoreType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ApplicationRestoreType FindValue(string value)
        {
            return FindValue<ApplicationRestoreType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ApplicationRestoreType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ApplicationStatus.
    /// </summary>
    public class ApplicationStatus : ConstantClass
    {

        /// <summary>
        /// Constant DELETING for ApplicationStatus
        /// </summary>
        public static readonly ApplicationStatus DELETING = new ApplicationStatus("DELETING");
        /// <summary>
        /// Constant READY for ApplicationStatus
        /// </summary>
        public static readonly ApplicationStatus READY = new ApplicationStatus("READY");
        /// <summary>
        /// Constant RUNNING for ApplicationStatus
        /// </summary>
        public static readonly ApplicationStatus RUNNING = new ApplicationStatus("RUNNING");
        /// <summary>
        /// Constant STARTING for ApplicationStatus
        /// </summary>
        public static readonly ApplicationStatus STARTING = new ApplicationStatus("STARTING");
        /// <summary>
        /// Constant STOPPING for ApplicationStatus
        /// </summary>
        public static readonly ApplicationStatus STOPPING = new ApplicationStatus("STOPPING");
        /// <summary>
        /// Constant UPDATING for ApplicationStatus
        /// </summary>
        public static readonly ApplicationStatus UPDATING = new ApplicationStatus("UPDATING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ApplicationStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ApplicationStatus FindValue(string value)
        {
            return FindValue<ApplicationStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ApplicationStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CodeContentType.
    /// </summary>
    public class CodeContentType : ConstantClass
    {

        /// <summary>
        /// Constant PLAINTEXT for CodeContentType
        /// </summary>
        public static readonly CodeContentType PLAINTEXT = new CodeContentType("PLAINTEXT");
        /// <summary>
        /// Constant ZIPFILE for CodeContentType
        /// </summary>
        public static readonly CodeContentType ZIPFILE = new CodeContentType("ZIPFILE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CodeContentType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CodeContentType FindValue(string value)
        {
            return FindValue<CodeContentType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CodeContentType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ConfigurationType.
    /// </summary>
    public class ConfigurationType : ConstantClass
    {

        /// <summary>
        /// Constant CUSTOM for ConfigurationType
        /// </summary>
        public static readonly ConfigurationType CUSTOM = new ConfigurationType("CUSTOM");
        /// <summary>
        /// Constant DEFAULT for ConfigurationType
        /// </summary>
        public static readonly ConfigurationType DEFAULT = new ConfigurationType("DEFAULT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ConfigurationType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ConfigurationType FindValue(string value)
        {
            return FindValue<ConfigurationType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ConfigurationType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type InputStartingPosition.
    /// </summary>
    public class InputStartingPosition : ConstantClass
    {

        /// <summary>
        /// Constant LAST_STOPPED_POINT for InputStartingPosition
        /// </summary>
        public static readonly InputStartingPosition LAST_STOPPED_POINT = new InputStartingPosition("LAST_STOPPED_POINT");
        /// <summary>
        /// Constant NOW for InputStartingPosition
        /// </summary>
        public static readonly InputStartingPosition NOW = new InputStartingPosition("NOW");
        /// <summary>
        /// Constant TRIM_HORIZON for InputStartingPosition
        /// </summary>
        public static readonly InputStartingPosition TRIM_HORIZON = new InputStartingPosition("TRIM_HORIZON");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public InputStartingPosition(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static InputStartingPosition FindValue(string value)
        {
            return FindValue<InputStartingPosition>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator InputStartingPosition(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type LogLevel.
    /// </summary>
    public class LogLevel : ConstantClass
    {

        /// <summary>
        /// Constant DEBUG for LogLevel
        /// </summary>
        public static readonly LogLevel DEBUG = new LogLevel("DEBUG");
        /// <summary>
        /// Constant ERROR for LogLevel
        /// </summary>
        public static readonly LogLevel ERROR = new LogLevel("ERROR");
        /// <summary>
        /// Constant INFO for LogLevel
        /// </summary>
        public static readonly LogLevel INFO = new LogLevel("INFO");
        /// <summary>
        /// Constant WARN for LogLevel
        /// </summary>
        public static readonly LogLevel WARN = new LogLevel("WARN");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public LogLevel(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LogLevel FindValue(string value)
        {
            return FindValue<LogLevel>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator LogLevel(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type MetricsLevel.
    /// </summary>
    public class MetricsLevel : ConstantClass
    {

        /// <summary>
        /// Constant APPLICATION for MetricsLevel
        /// </summary>
        public static readonly MetricsLevel APPLICATION = new MetricsLevel("APPLICATION");
        /// <summary>
        /// Constant OPERATOR for MetricsLevel
        /// </summary>
        public static readonly MetricsLevel OPERATOR = new MetricsLevel("OPERATOR");
        /// <summary>
        /// Constant PARALLELISM for MetricsLevel
        /// </summary>
        public static readonly MetricsLevel PARALLELISM = new MetricsLevel("PARALLELISM");
        /// <summary>
        /// Constant TASK for MetricsLevel
        /// </summary>
        public static readonly MetricsLevel TASK = new MetricsLevel("TASK");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MetricsLevel(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MetricsLevel FindValue(string value)
        {
            return FindValue<MetricsLevel>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MetricsLevel(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RecordFormatType.
    /// </summary>
    public class RecordFormatType : ConstantClass
    {

        /// <summary>
        /// Constant CSV for RecordFormatType
        /// </summary>
        public static readonly RecordFormatType CSV = new RecordFormatType("CSV");
        /// <summary>
        /// Constant JSON for RecordFormatType
        /// </summary>
        public static readonly RecordFormatType JSON = new RecordFormatType("JSON");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RecordFormatType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RecordFormatType FindValue(string value)
        {
            return FindValue<RecordFormatType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RecordFormatType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RuntimeEnvironment.
    /// </summary>
    public class RuntimeEnvironment : ConstantClass
    {

        /// <summary>
        /// Constant FLINK1_6 for RuntimeEnvironment
        /// </summary>
        public static readonly RuntimeEnvironment FLINK1_6 = new RuntimeEnvironment("FLINK-1_6");
        /// <summary>
        /// Constant SQL1_0 for RuntimeEnvironment
        /// </summary>
        public static readonly RuntimeEnvironment SQL1_0 = new RuntimeEnvironment("SQL-1_0");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RuntimeEnvironment(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RuntimeEnvironment FindValue(string value)
        {
            return FindValue<RuntimeEnvironment>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RuntimeEnvironment(string value)
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
        /// Constant READY for SnapshotStatus
        /// </summary>
        public static readonly SnapshotStatus READY = new SnapshotStatus("READY");

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

}