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
 * Do not modify this file. This file is generated from the kinesis-2013-12-02.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.Kinesis
{

    /// <summary>
    /// Constants used for properties of type ConsumerStatus.
    /// </summary>
    public class ConsumerStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for ConsumerStatus
        /// </summary>
        public static readonly ConsumerStatus ACTIVE = new ConsumerStatus("ACTIVE");
        /// <summary>
        /// Constant CREATING for ConsumerStatus
        /// </summary>
        public static readonly ConsumerStatus CREATING = new ConsumerStatus("CREATING");
        /// <summary>
        /// Constant DELETING for ConsumerStatus
        /// </summary>
        public static readonly ConsumerStatus DELETING = new ConsumerStatus("DELETING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ConsumerStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ConsumerStatus FindValue(string value)
        {
            return FindValue<ConsumerStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ConsumerStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type EncryptionType.
    /// </summary>
    public class EncryptionType : ConstantClass
    {

        /// <summary>
        /// Constant KMS for EncryptionType
        /// </summary>
        public static readonly EncryptionType KMS = new EncryptionType("KMS");
        /// <summary>
        /// Constant NONE for EncryptionType
        /// </summary>
        public static readonly EncryptionType NONE = new EncryptionType("NONE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EncryptionType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EncryptionType FindValue(string value)
        {
            return FindValue<EncryptionType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EncryptionType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type MetricsName.
    /// </summary>
    public class MetricsName : ConstantClass
    {

        /// <summary>
        /// Constant ALL for MetricsName
        /// </summary>
        public static readonly MetricsName ALL = new MetricsName("ALL");
        /// <summary>
        /// Constant IncomingBytes for MetricsName
        /// </summary>
        public static readonly MetricsName IncomingBytes = new MetricsName("IncomingBytes");
        /// <summary>
        /// Constant IncomingRecords for MetricsName
        /// </summary>
        public static readonly MetricsName IncomingRecords = new MetricsName("IncomingRecords");
        /// <summary>
        /// Constant IteratorAgeMilliseconds for MetricsName
        /// </summary>
        public static readonly MetricsName IteratorAgeMilliseconds = new MetricsName("IteratorAgeMilliseconds");
        /// <summary>
        /// Constant OutgoingBytes for MetricsName
        /// </summary>
        public static readonly MetricsName OutgoingBytes = new MetricsName("OutgoingBytes");
        /// <summary>
        /// Constant OutgoingRecords for MetricsName
        /// </summary>
        public static readonly MetricsName OutgoingRecords = new MetricsName("OutgoingRecords");
        /// <summary>
        /// Constant ReadProvisionedThroughputExceeded for MetricsName
        /// </summary>
        public static readonly MetricsName ReadProvisionedThroughputExceeded = new MetricsName("ReadProvisionedThroughputExceeded");
        /// <summary>
        /// Constant WriteProvisionedThroughputExceeded for MetricsName
        /// </summary>
        public static readonly MetricsName WriteProvisionedThroughputExceeded = new MetricsName("WriteProvisionedThroughputExceeded");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MetricsName(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MetricsName FindValue(string value)
        {
            return FindValue<MetricsName>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MetricsName(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ScalingType.
    /// </summary>
    public class ScalingType : ConstantClass
    {

        /// <summary>
        /// Constant UNIFORM_SCALING for ScalingType
        /// </summary>
        public static readonly ScalingType UNIFORM_SCALING = new ScalingType("UNIFORM_SCALING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ScalingType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ScalingType FindValue(string value)
        {
            return FindValue<ScalingType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ScalingType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ShardFilterType.
    /// </summary>
    public class ShardFilterType : ConstantClass
    {

        /// <summary>
        /// Constant AFTER_SHARD_ID for ShardFilterType
        /// </summary>
        public static readonly ShardFilterType AFTER_SHARD_ID = new ShardFilterType("AFTER_SHARD_ID");
        /// <summary>
        /// Constant AT_LATEST for ShardFilterType
        /// </summary>
        public static readonly ShardFilterType AT_LATEST = new ShardFilterType("AT_LATEST");
        /// <summary>
        /// Constant AT_TIMESTAMP for ShardFilterType
        /// </summary>
        public static readonly ShardFilterType AT_TIMESTAMP = new ShardFilterType("AT_TIMESTAMP");
        /// <summary>
        /// Constant AT_TRIM_HORIZON for ShardFilterType
        /// </summary>
        public static readonly ShardFilterType AT_TRIM_HORIZON = new ShardFilterType("AT_TRIM_HORIZON");
        /// <summary>
        /// Constant FROM_TIMESTAMP for ShardFilterType
        /// </summary>
        public static readonly ShardFilterType FROM_TIMESTAMP = new ShardFilterType("FROM_TIMESTAMP");
        /// <summary>
        /// Constant FROM_TRIM_HORIZON for ShardFilterType
        /// </summary>
        public static readonly ShardFilterType FROM_TRIM_HORIZON = new ShardFilterType("FROM_TRIM_HORIZON");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ShardFilterType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ShardFilterType FindValue(string value)
        {
            return FindValue<ShardFilterType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ShardFilterType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ShardIteratorType.
    /// </summary>
    public class ShardIteratorType : ConstantClass
    {

        /// <summary>
        /// Constant AFTER_SEQUENCE_NUMBER for ShardIteratorType
        /// </summary>
        public static readonly ShardIteratorType AFTER_SEQUENCE_NUMBER = new ShardIteratorType("AFTER_SEQUENCE_NUMBER");
        /// <summary>
        /// Constant AT_SEQUENCE_NUMBER for ShardIteratorType
        /// </summary>
        public static readonly ShardIteratorType AT_SEQUENCE_NUMBER = new ShardIteratorType("AT_SEQUENCE_NUMBER");
        /// <summary>
        /// Constant AT_TIMESTAMP for ShardIteratorType
        /// </summary>
        public static readonly ShardIteratorType AT_TIMESTAMP = new ShardIteratorType("AT_TIMESTAMP");
        /// <summary>
        /// Constant LATEST for ShardIteratorType
        /// </summary>
        public static readonly ShardIteratorType LATEST = new ShardIteratorType("LATEST");
        /// <summary>
        /// Constant TRIM_HORIZON for ShardIteratorType
        /// </summary>
        public static readonly ShardIteratorType TRIM_HORIZON = new ShardIteratorType("TRIM_HORIZON");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ShardIteratorType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ShardIteratorType FindValue(string value)
        {
            return FindValue<ShardIteratorType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ShardIteratorType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type StreamMode.
    /// </summary>
    public class StreamMode : ConstantClass
    {

        /// <summary>
        /// Constant ON_DEMAND for StreamMode
        /// </summary>
        public static readonly StreamMode ON_DEMAND = new StreamMode("ON_DEMAND");
        /// <summary>
        /// Constant PROVISIONED for StreamMode
        /// </summary>
        public static readonly StreamMode PROVISIONED = new StreamMode("PROVISIONED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public StreamMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static StreamMode FindValue(string value)
        {
            return FindValue<StreamMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator StreamMode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type StreamStatus.
    /// </summary>
    public class StreamStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for StreamStatus
        /// </summary>
        public static readonly StreamStatus ACTIVE = new StreamStatus("ACTIVE");
        /// <summary>
        /// Constant CREATING for StreamStatus
        /// </summary>
        public static readonly StreamStatus CREATING = new StreamStatus("CREATING");
        /// <summary>
        /// Constant DELETING for StreamStatus
        /// </summary>
        public static readonly StreamStatus DELETING = new StreamStatus("DELETING");
        /// <summary>
        /// Constant UPDATING for StreamStatus
        /// </summary>
        public static readonly StreamStatus UPDATING = new StreamStatus("UPDATING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public StreamStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static StreamStatus FindValue(string value)
        {
            return FindValue<StreamStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator StreamStatus(string value)
        {
            return FindValue(value);
        }
    }

}