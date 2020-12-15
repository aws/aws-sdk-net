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
 * Do not modify this file. This file is generated from the iotanalytics-2017-11-27.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.IoTAnalytics
{

    /// <summary>
    /// Constants used for properties of type ChannelStatus.
    /// </summary>
    public class ChannelStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for ChannelStatus
        /// </summary>
        public static readonly ChannelStatus ACTIVE = new ChannelStatus("ACTIVE");
        /// <summary>
        /// Constant CREATING for ChannelStatus
        /// </summary>
        public static readonly ChannelStatus CREATING = new ChannelStatus("CREATING");
        /// <summary>
        /// Constant DELETING for ChannelStatus
        /// </summary>
        public static readonly ChannelStatus DELETING = new ChannelStatus("DELETING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ChannelStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ChannelStatus FindValue(string value)
        {
            return FindValue<ChannelStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ChannelStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ComputeType.
    /// </summary>
    public class ComputeType : ConstantClass
    {

        /// <summary>
        /// Constant ACU_1 for ComputeType
        /// </summary>
        public static readonly ComputeType ACU_1 = new ComputeType("ACU_1");
        /// <summary>
        /// Constant ACU_2 for ComputeType
        /// </summary>
        public static readonly ComputeType ACU_2 = new ComputeType("ACU_2");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ComputeType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ComputeType FindValue(string value)
        {
            return FindValue<ComputeType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ComputeType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DatasetActionType.
    /// </summary>
    public class DatasetActionType : ConstantClass
    {

        /// <summary>
        /// Constant CONTAINER for DatasetActionType
        /// </summary>
        public static readonly DatasetActionType CONTAINER = new DatasetActionType("CONTAINER");
        /// <summary>
        /// Constant QUERY for DatasetActionType
        /// </summary>
        public static readonly DatasetActionType QUERY = new DatasetActionType("QUERY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DatasetActionType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DatasetActionType FindValue(string value)
        {
            return FindValue<DatasetActionType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DatasetActionType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DatasetContentState.
    /// </summary>
    public class DatasetContentState : ConstantClass
    {

        /// <summary>
        /// Constant CREATING for DatasetContentState
        /// </summary>
        public static readonly DatasetContentState CREATING = new DatasetContentState("CREATING");
        /// <summary>
        /// Constant FAILED for DatasetContentState
        /// </summary>
        public static readonly DatasetContentState FAILED = new DatasetContentState("FAILED");
        /// <summary>
        /// Constant SUCCEEDED for DatasetContentState
        /// </summary>
        public static readonly DatasetContentState SUCCEEDED = new DatasetContentState("SUCCEEDED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DatasetContentState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DatasetContentState FindValue(string value)
        {
            return FindValue<DatasetContentState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DatasetContentState(string value)
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
        /// Constant ACTIVE for DatasetStatus
        /// </summary>
        public static readonly DatasetStatus ACTIVE = new DatasetStatus("ACTIVE");
        /// <summary>
        /// Constant CREATING for DatasetStatus
        /// </summary>
        public static readonly DatasetStatus CREATING = new DatasetStatus("CREATING");
        /// <summary>
        /// Constant DELETING for DatasetStatus
        /// </summary>
        public static readonly DatasetStatus DELETING = new DatasetStatus("DELETING");

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
    /// Constants used for properties of type DatastoreStatus.
    /// </summary>
    public class DatastoreStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for DatastoreStatus
        /// </summary>
        public static readonly DatastoreStatus ACTIVE = new DatastoreStatus("ACTIVE");
        /// <summary>
        /// Constant CREATING for DatastoreStatus
        /// </summary>
        public static readonly DatastoreStatus CREATING = new DatastoreStatus("CREATING");
        /// <summary>
        /// Constant DELETING for DatastoreStatus
        /// </summary>
        public static readonly DatastoreStatus DELETING = new DatastoreStatus("DELETING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DatastoreStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DatastoreStatus FindValue(string value)
        {
            return FindValue<DatastoreStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DatastoreStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type FileFormatType.
    /// </summary>
    public class FileFormatType : ConstantClass
    {

        /// <summary>
        /// Constant JSON for FileFormatType
        /// </summary>
        public static readonly FileFormatType JSON = new FileFormatType("JSON");
        /// <summary>
        /// Constant PARQUET for FileFormatType
        /// </summary>
        public static readonly FileFormatType PARQUET = new FileFormatType("PARQUET");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FileFormatType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FileFormatType FindValue(string value)
        {
            return FindValue<FileFormatType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FileFormatType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type LoggingLevel.
    /// </summary>
    public class LoggingLevel : ConstantClass
    {

        /// <summary>
        /// Constant ERROR for LoggingLevel
        /// </summary>
        public static readonly LoggingLevel ERROR = new LoggingLevel("ERROR");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public LoggingLevel(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LoggingLevel FindValue(string value)
        {
            return FindValue<LoggingLevel>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator LoggingLevel(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ReprocessingStatus.
    /// </summary>
    public class ReprocessingStatus : ConstantClass
    {

        /// <summary>
        /// Constant CANCELLED for ReprocessingStatus
        /// </summary>
        public static readonly ReprocessingStatus CANCELLED = new ReprocessingStatus("CANCELLED");
        /// <summary>
        /// Constant FAILED for ReprocessingStatus
        /// </summary>
        public static readonly ReprocessingStatus FAILED = new ReprocessingStatus("FAILED");
        /// <summary>
        /// Constant RUNNING for ReprocessingStatus
        /// </summary>
        public static readonly ReprocessingStatus RUNNING = new ReprocessingStatus("RUNNING");
        /// <summary>
        /// Constant SUCCEEDED for ReprocessingStatus
        /// </summary>
        public static readonly ReprocessingStatus SUCCEEDED = new ReprocessingStatus("SUCCEEDED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ReprocessingStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ReprocessingStatus FindValue(string value)
        {
            return FindValue<ReprocessingStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ReprocessingStatus(string value)
        {
            return FindValue(value);
        }
    }

}