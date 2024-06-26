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
 * Do not modify this file. This file is generated from the pipes-2015-10-07.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.Pipes
{

    /// <summary>
    /// Constants used for properties of type AssignPublicIp.
    /// </summary>
    public class AssignPublicIp : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for AssignPublicIp
        /// </summary>
        public static readonly AssignPublicIp DISABLED = new AssignPublicIp("DISABLED");
        /// <summary>
        /// Constant ENABLED for AssignPublicIp
        /// </summary>
        public static readonly AssignPublicIp ENABLED = new AssignPublicIp("ENABLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AssignPublicIp(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AssignPublicIp FindValue(string value)
        {
            return FindValue<AssignPublicIp>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AssignPublicIp(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type BatchJobDependencyType.
    /// </summary>
    public class BatchJobDependencyType : ConstantClass
    {

        /// <summary>
        /// Constant N_TO_N for BatchJobDependencyType
        /// </summary>
        public static readonly BatchJobDependencyType N_TO_N = new BatchJobDependencyType("N_TO_N");
        /// <summary>
        /// Constant SEQUENTIAL for BatchJobDependencyType
        /// </summary>
        public static readonly BatchJobDependencyType SEQUENTIAL = new BatchJobDependencyType("SEQUENTIAL");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public BatchJobDependencyType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static BatchJobDependencyType FindValue(string value)
        {
            return FindValue<BatchJobDependencyType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator BatchJobDependencyType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type BatchResourceRequirementType.
    /// </summary>
    public class BatchResourceRequirementType : ConstantClass
    {

        /// <summary>
        /// Constant GPU for BatchResourceRequirementType
        /// </summary>
        public static readonly BatchResourceRequirementType GPU = new BatchResourceRequirementType("GPU");
        /// <summary>
        /// Constant MEMORY for BatchResourceRequirementType
        /// </summary>
        public static readonly BatchResourceRequirementType MEMORY = new BatchResourceRequirementType("MEMORY");
        /// <summary>
        /// Constant VCPU for BatchResourceRequirementType
        /// </summary>
        public static readonly BatchResourceRequirementType VCPU = new BatchResourceRequirementType("VCPU");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public BatchResourceRequirementType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static BatchResourceRequirementType FindValue(string value)
        {
            return FindValue<BatchResourceRequirementType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator BatchResourceRequirementType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DimensionValueType.
    /// </summary>
    public class DimensionValueType : ConstantClass
    {

        /// <summary>
        /// Constant VARCHAR for DimensionValueType
        /// </summary>
        public static readonly DimensionValueType VARCHAR = new DimensionValueType("VARCHAR");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DimensionValueType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DimensionValueType FindValue(string value)
        {
            return FindValue<DimensionValueType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DimensionValueType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DynamoDBStreamStartPosition.
    /// </summary>
    public class DynamoDBStreamStartPosition : ConstantClass
    {

        /// <summary>
        /// Constant LATEST for DynamoDBStreamStartPosition
        /// </summary>
        public static readonly DynamoDBStreamStartPosition LATEST = new DynamoDBStreamStartPosition("LATEST");
        /// <summary>
        /// Constant TRIM_HORIZON for DynamoDBStreamStartPosition
        /// </summary>
        public static readonly DynamoDBStreamStartPosition TRIM_HORIZON = new DynamoDBStreamStartPosition("TRIM_HORIZON");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DynamoDBStreamStartPosition(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DynamoDBStreamStartPosition FindValue(string value)
        {
            return FindValue<DynamoDBStreamStartPosition>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DynamoDBStreamStartPosition(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type EcsEnvironmentFileType.
    /// </summary>
    public class EcsEnvironmentFileType : ConstantClass
    {

        /// <summary>
        /// Constant S3 for EcsEnvironmentFileType
        /// </summary>
        public static readonly EcsEnvironmentFileType S3 = new EcsEnvironmentFileType("s3");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EcsEnvironmentFileType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EcsEnvironmentFileType FindValue(string value)
        {
            return FindValue<EcsEnvironmentFileType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EcsEnvironmentFileType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type EcsResourceRequirementType.
    /// </summary>
    public class EcsResourceRequirementType : ConstantClass
    {

        /// <summary>
        /// Constant GPU for EcsResourceRequirementType
        /// </summary>
        public static readonly EcsResourceRequirementType GPU = new EcsResourceRequirementType("GPU");
        /// <summary>
        /// Constant InferenceAccelerator for EcsResourceRequirementType
        /// </summary>
        public static readonly EcsResourceRequirementType InferenceAccelerator = new EcsResourceRequirementType("InferenceAccelerator");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EcsResourceRequirementType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EcsResourceRequirementType FindValue(string value)
        {
            return FindValue<EcsResourceRequirementType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EcsResourceRequirementType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type EpochTimeUnit.
    /// </summary>
    public class EpochTimeUnit : ConstantClass
    {

        /// <summary>
        /// Constant MICROSECONDS for EpochTimeUnit
        /// </summary>
        public static readonly EpochTimeUnit MICROSECONDS = new EpochTimeUnit("MICROSECONDS");
        /// <summary>
        /// Constant MILLISECONDS for EpochTimeUnit
        /// </summary>
        public static readonly EpochTimeUnit MILLISECONDS = new EpochTimeUnit("MILLISECONDS");
        /// <summary>
        /// Constant NANOSECONDS for EpochTimeUnit
        /// </summary>
        public static readonly EpochTimeUnit NANOSECONDS = new EpochTimeUnit("NANOSECONDS");
        /// <summary>
        /// Constant SECONDS for EpochTimeUnit
        /// </summary>
        public static readonly EpochTimeUnit SECONDS = new EpochTimeUnit("SECONDS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EpochTimeUnit(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EpochTimeUnit FindValue(string value)
        {
            return FindValue<EpochTimeUnit>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EpochTimeUnit(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type IncludeExecutionDataOption.
    /// </summary>
    public class IncludeExecutionDataOption : ConstantClass
    {

        /// <summary>
        /// Constant ALL for IncludeExecutionDataOption
        /// </summary>
        public static readonly IncludeExecutionDataOption ALL = new IncludeExecutionDataOption("ALL");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public IncludeExecutionDataOption(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static IncludeExecutionDataOption FindValue(string value)
        {
            return FindValue<IncludeExecutionDataOption>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator IncludeExecutionDataOption(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type KinesisStreamStartPosition.
    /// </summary>
    public class KinesisStreamStartPosition : ConstantClass
    {

        /// <summary>
        /// Constant AT_TIMESTAMP for KinesisStreamStartPosition
        /// </summary>
        public static readonly KinesisStreamStartPosition AT_TIMESTAMP = new KinesisStreamStartPosition("AT_TIMESTAMP");
        /// <summary>
        /// Constant LATEST for KinesisStreamStartPosition
        /// </summary>
        public static readonly KinesisStreamStartPosition LATEST = new KinesisStreamStartPosition("LATEST");
        /// <summary>
        /// Constant TRIM_HORIZON for KinesisStreamStartPosition
        /// </summary>
        public static readonly KinesisStreamStartPosition TRIM_HORIZON = new KinesisStreamStartPosition("TRIM_HORIZON");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public KinesisStreamStartPosition(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static KinesisStreamStartPosition FindValue(string value)
        {
            return FindValue<KinesisStreamStartPosition>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator KinesisStreamStartPosition(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type LaunchType.
    /// </summary>
    public class LaunchType : ConstantClass
    {

        /// <summary>
        /// Constant EC2 for LaunchType
        /// </summary>
        public static readonly LaunchType EC2 = new LaunchType("EC2");
        /// <summary>
        /// Constant EXTERNAL for LaunchType
        /// </summary>
        public static readonly LaunchType EXTERNAL = new LaunchType("EXTERNAL");
        /// <summary>
        /// Constant FARGATE for LaunchType
        /// </summary>
        public static readonly LaunchType FARGATE = new LaunchType("FARGATE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public LaunchType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LaunchType FindValue(string value)
        {
            return FindValue<LaunchType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator LaunchType(string value)
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
        /// Constant ERROR for LogLevel
        /// </summary>
        public static readonly LogLevel ERROR = new LogLevel("ERROR");
        /// <summary>
        /// Constant INFO for LogLevel
        /// </summary>
        public static readonly LogLevel INFO = new LogLevel("INFO");
        /// <summary>
        /// Constant OFF for LogLevel
        /// </summary>
        public static readonly LogLevel OFF = new LogLevel("OFF");
        /// <summary>
        /// Constant TRACE for LogLevel
        /// </summary>
        public static readonly LogLevel TRACE = new LogLevel("TRACE");

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
    /// Constants used for properties of type MeasureValueType.
    /// </summary>
    public class MeasureValueType : ConstantClass
    {

        /// <summary>
        /// Constant BIGINT for MeasureValueType
        /// </summary>
        public static readonly MeasureValueType BIGINT = new MeasureValueType("BIGINT");
        /// <summary>
        /// Constant BOOLEAN for MeasureValueType
        /// </summary>
        public static readonly MeasureValueType BOOLEAN = new MeasureValueType("BOOLEAN");
        /// <summary>
        /// Constant DOUBLE for MeasureValueType
        /// </summary>
        public static readonly MeasureValueType DOUBLE = new MeasureValueType("DOUBLE");
        /// <summary>
        /// Constant TIMESTAMP for MeasureValueType
        /// </summary>
        public static readonly MeasureValueType TIMESTAMP = new MeasureValueType("TIMESTAMP");
        /// <summary>
        /// Constant VARCHAR for MeasureValueType
        /// </summary>
        public static readonly MeasureValueType VARCHAR = new MeasureValueType("VARCHAR");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MeasureValueType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MeasureValueType FindValue(string value)
        {
            return FindValue<MeasureValueType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MeasureValueType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type MSKStartPosition.
    /// </summary>
    public class MSKStartPosition : ConstantClass
    {

        /// <summary>
        /// Constant LATEST for MSKStartPosition
        /// </summary>
        public static readonly MSKStartPosition LATEST = new MSKStartPosition("LATEST");
        /// <summary>
        /// Constant TRIM_HORIZON for MSKStartPosition
        /// </summary>
        public static readonly MSKStartPosition TRIM_HORIZON = new MSKStartPosition("TRIM_HORIZON");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MSKStartPosition(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MSKStartPosition FindValue(string value)
        {
            return FindValue<MSKStartPosition>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MSKStartPosition(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type OnPartialBatchItemFailureStreams.
    /// </summary>
    public class OnPartialBatchItemFailureStreams : ConstantClass
    {

        /// <summary>
        /// Constant AUTOMATIC_BISECT for OnPartialBatchItemFailureStreams
        /// </summary>
        public static readonly OnPartialBatchItemFailureStreams AUTOMATIC_BISECT = new OnPartialBatchItemFailureStreams("AUTOMATIC_BISECT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public OnPartialBatchItemFailureStreams(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static OnPartialBatchItemFailureStreams FindValue(string value)
        {
            return FindValue<OnPartialBatchItemFailureStreams>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator OnPartialBatchItemFailureStreams(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PipeState.
    /// </summary>
    public class PipeState : ConstantClass
    {

        /// <summary>
        /// Constant CREATE_FAILED for PipeState
        /// </summary>
        public static readonly PipeState CREATE_FAILED = new PipeState("CREATE_FAILED");
        /// <summary>
        /// Constant CREATE_ROLLBACK_FAILED for PipeState
        /// </summary>
        public static readonly PipeState CREATE_ROLLBACK_FAILED = new PipeState("CREATE_ROLLBACK_FAILED");
        /// <summary>
        /// Constant CREATING for PipeState
        /// </summary>
        public static readonly PipeState CREATING = new PipeState("CREATING");
        /// <summary>
        /// Constant DELETE_FAILED for PipeState
        /// </summary>
        public static readonly PipeState DELETE_FAILED = new PipeState("DELETE_FAILED");
        /// <summary>
        /// Constant DELETE_ROLLBACK_FAILED for PipeState
        /// </summary>
        public static readonly PipeState DELETE_ROLLBACK_FAILED = new PipeState("DELETE_ROLLBACK_FAILED");
        /// <summary>
        /// Constant DELETING for PipeState
        /// </summary>
        public static readonly PipeState DELETING = new PipeState("DELETING");
        /// <summary>
        /// Constant RUNNING for PipeState
        /// </summary>
        public static readonly PipeState RUNNING = new PipeState("RUNNING");
        /// <summary>
        /// Constant START_FAILED for PipeState
        /// </summary>
        public static readonly PipeState START_FAILED = new PipeState("START_FAILED");
        /// <summary>
        /// Constant STARTING for PipeState
        /// </summary>
        public static readonly PipeState STARTING = new PipeState("STARTING");
        /// <summary>
        /// Constant STOP_FAILED for PipeState
        /// </summary>
        public static readonly PipeState STOP_FAILED = new PipeState("STOP_FAILED");
        /// <summary>
        /// Constant STOPPED for PipeState
        /// </summary>
        public static readonly PipeState STOPPED = new PipeState("STOPPED");
        /// <summary>
        /// Constant STOPPING for PipeState
        /// </summary>
        public static readonly PipeState STOPPING = new PipeState("STOPPING");
        /// <summary>
        /// Constant UPDATE_FAILED for PipeState
        /// </summary>
        public static readonly PipeState UPDATE_FAILED = new PipeState("UPDATE_FAILED");
        /// <summary>
        /// Constant UPDATE_ROLLBACK_FAILED for PipeState
        /// </summary>
        public static readonly PipeState UPDATE_ROLLBACK_FAILED = new PipeState("UPDATE_ROLLBACK_FAILED");
        /// <summary>
        /// Constant UPDATING for PipeState
        /// </summary>
        public static readonly PipeState UPDATING = new PipeState("UPDATING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PipeState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PipeState FindValue(string value)
        {
            return FindValue<PipeState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PipeState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PipeTargetInvocationType.
    /// </summary>
    public class PipeTargetInvocationType : ConstantClass
    {

        /// <summary>
        /// Constant FIRE_AND_FORGET for PipeTargetInvocationType
        /// </summary>
        public static readonly PipeTargetInvocationType FIRE_AND_FORGET = new PipeTargetInvocationType("FIRE_AND_FORGET");
        /// <summary>
        /// Constant REQUEST_RESPONSE for PipeTargetInvocationType
        /// </summary>
        public static readonly PipeTargetInvocationType REQUEST_RESPONSE = new PipeTargetInvocationType("REQUEST_RESPONSE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PipeTargetInvocationType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PipeTargetInvocationType FindValue(string value)
        {
            return FindValue<PipeTargetInvocationType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PipeTargetInvocationType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PlacementConstraintType.
    /// </summary>
    public class PlacementConstraintType : ConstantClass
    {

        /// <summary>
        /// Constant DistinctInstance for PlacementConstraintType
        /// </summary>
        public static readonly PlacementConstraintType DistinctInstance = new PlacementConstraintType("distinctInstance");
        /// <summary>
        /// Constant MemberOf for PlacementConstraintType
        /// </summary>
        public static readonly PlacementConstraintType MemberOf = new PlacementConstraintType("memberOf");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PlacementConstraintType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PlacementConstraintType FindValue(string value)
        {
            return FindValue<PlacementConstraintType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PlacementConstraintType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PlacementStrategyType.
    /// </summary>
    public class PlacementStrategyType : ConstantClass
    {

        /// <summary>
        /// Constant Binpack for PlacementStrategyType
        /// </summary>
        public static readonly PlacementStrategyType Binpack = new PlacementStrategyType("binpack");
        /// <summary>
        /// Constant Random for PlacementStrategyType
        /// </summary>
        public static readonly PlacementStrategyType Random = new PlacementStrategyType("random");
        /// <summary>
        /// Constant Spread for PlacementStrategyType
        /// </summary>
        public static readonly PlacementStrategyType Spread = new PlacementStrategyType("spread");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PlacementStrategyType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PlacementStrategyType FindValue(string value)
        {
            return FindValue<PlacementStrategyType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PlacementStrategyType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PropagateTags.
    /// </summary>
    public class PropagateTags : ConstantClass
    {

        /// <summary>
        /// Constant TASK_DEFINITION for PropagateTags
        /// </summary>
        public static readonly PropagateTags TASK_DEFINITION = new PropagateTags("TASK_DEFINITION");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PropagateTags(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PropagateTags FindValue(string value)
        {
            return FindValue<PropagateTags>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PropagateTags(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RequestedPipeState.
    /// </summary>
    public class RequestedPipeState : ConstantClass
    {

        /// <summary>
        /// Constant RUNNING for RequestedPipeState
        /// </summary>
        public static readonly RequestedPipeState RUNNING = new RequestedPipeState("RUNNING");
        /// <summary>
        /// Constant STOPPED for RequestedPipeState
        /// </summary>
        public static readonly RequestedPipeState STOPPED = new RequestedPipeState("STOPPED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RequestedPipeState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RequestedPipeState FindValue(string value)
        {
            return FindValue<RequestedPipeState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RequestedPipeState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RequestedPipeStateDescribeResponse.
    /// </summary>
    public class RequestedPipeStateDescribeResponse : ConstantClass
    {

        /// <summary>
        /// Constant DELETED for RequestedPipeStateDescribeResponse
        /// </summary>
        public static readonly RequestedPipeStateDescribeResponse DELETED = new RequestedPipeStateDescribeResponse("DELETED");
        /// <summary>
        /// Constant RUNNING for RequestedPipeStateDescribeResponse
        /// </summary>
        public static readonly RequestedPipeStateDescribeResponse RUNNING = new RequestedPipeStateDescribeResponse("RUNNING");
        /// <summary>
        /// Constant STOPPED for RequestedPipeStateDescribeResponse
        /// </summary>
        public static readonly RequestedPipeStateDescribeResponse STOPPED = new RequestedPipeStateDescribeResponse("STOPPED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RequestedPipeStateDescribeResponse(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RequestedPipeStateDescribeResponse FindValue(string value)
        {
            return FindValue<RequestedPipeStateDescribeResponse>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RequestedPipeStateDescribeResponse(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type S3OutputFormat.
    /// </summary>
    public class S3OutputFormat : ConstantClass
    {

        /// <summary>
        /// Constant Json for S3OutputFormat
        /// </summary>
        public static readonly S3OutputFormat Json = new S3OutputFormat("json");
        /// <summary>
        /// Constant Plain for S3OutputFormat
        /// </summary>
        public static readonly S3OutputFormat Plain = new S3OutputFormat("plain");
        /// <summary>
        /// Constant W3c for S3OutputFormat
        /// </summary>
        public static readonly S3OutputFormat W3c = new S3OutputFormat("w3c");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public S3OutputFormat(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static S3OutputFormat FindValue(string value)
        {
            return FindValue<S3OutputFormat>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator S3OutputFormat(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SelfManagedKafkaStartPosition.
    /// </summary>
    public class SelfManagedKafkaStartPosition : ConstantClass
    {

        /// <summary>
        /// Constant LATEST for SelfManagedKafkaStartPosition
        /// </summary>
        public static readonly SelfManagedKafkaStartPosition LATEST = new SelfManagedKafkaStartPosition("LATEST");
        /// <summary>
        /// Constant TRIM_HORIZON for SelfManagedKafkaStartPosition
        /// </summary>
        public static readonly SelfManagedKafkaStartPosition TRIM_HORIZON = new SelfManagedKafkaStartPosition("TRIM_HORIZON");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SelfManagedKafkaStartPosition(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SelfManagedKafkaStartPosition FindValue(string value)
        {
            return FindValue<SelfManagedKafkaStartPosition>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SelfManagedKafkaStartPosition(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TimeFieldType.
    /// </summary>
    public class TimeFieldType : ConstantClass
    {

        /// <summary>
        /// Constant EPOCH for TimeFieldType
        /// </summary>
        public static readonly TimeFieldType EPOCH = new TimeFieldType("EPOCH");
        /// <summary>
        /// Constant TIMESTAMP_FORMAT for TimeFieldType
        /// </summary>
        public static readonly TimeFieldType TIMESTAMP_FORMAT = new TimeFieldType("TIMESTAMP_FORMAT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TimeFieldType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TimeFieldType FindValue(string value)
        {
            return FindValue<TimeFieldType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TimeFieldType(string value)
        {
            return FindValue(value);
        }
    }

}