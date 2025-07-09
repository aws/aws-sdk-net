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
 * Do not modify this file. This file is generated from the keyspacesstreams-2024-09-09.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.KeyspacesStreams
{

    /// <summary>
    /// Constants used for properties of type OriginType.
    /// </summary>
    public class OriginType : ConstantClass
    {

        /// <summary>
        /// Constant REPLICATION for OriginType
        /// </summary>
        public static readonly OriginType REPLICATION = new OriginType("REPLICATION");
        /// <summary>
        /// Constant TTL for OriginType
        /// </summary>
        public static readonly OriginType TTL = new OriginType("TTL");
        /// <summary>
        /// Constant USER for OriginType
        /// </summary>
        public static readonly OriginType USER = new OriginType("USER");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public OriginType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static OriginType FindValue(string value)
        {
            return FindValue<OriginType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator OriginType(string value)
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
        /// Constant CHILD_SHARDS for ShardFilterType
        /// </summary>
        public static readonly ShardFilterType CHILD_SHARDS = new ShardFilterType("CHILD_SHARDS");

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
    /// Constants used for properties of type StreamStatus.
    /// </summary>
    public class StreamStatus : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for StreamStatus
        /// </summary>
        public static readonly StreamStatus DISABLED = new StreamStatus("DISABLED");
        /// <summary>
        /// Constant DISABLING for StreamStatus
        /// </summary>
        public static readonly StreamStatus DISABLING = new StreamStatus("DISABLING");
        /// <summary>
        /// Constant ENABLED for StreamStatus
        /// </summary>
        public static readonly StreamStatus ENABLED = new StreamStatus("ENABLED");
        /// <summary>
        /// Constant ENABLING for StreamStatus
        /// </summary>
        public static readonly StreamStatus ENABLING = new StreamStatus("ENABLING");

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


    /// <summary>
    /// Constants used for properties of type StreamViewType.
    /// </summary>
    public class StreamViewType : ConstantClass
    {

        /// <summary>
        /// Constant KEYS_ONLY for StreamViewType
        /// </summary>
        public static readonly StreamViewType KEYS_ONLY = new StreamViewType("KEYS_ONLY");
        /// <summary>
        /// Constant NEW_AND_OLD_IMAGES for StreamViewType
        /// </summary>
        public static readonly StreamViewType NEW_AND_OLD_IMAGES = new StreamViewType("NEW_AND_OLD_IMAGES");
        /// <summary>
        /// Constant NEW_IMAGE for StreamViewType
        /// </summary>
        public static readonly StreamViewType NEW_IMAGE = new StreamViewType("NEW_IMAGE");
        /// <summary>
        /// Constant OLD_IMAGE for StreamViewType
        /// </summary>
        public static readonly StreamViewType OLD_IMAGE = new StreamViewType("OLD_IMAGE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public StreamViewType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static StreamViewType FindValue(string value)
        {
            return FindValue<StreamViewType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator StreamViewType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ValidationExceptionType.
    /// </summary>
    public class ValidationExceptionType : ConstantClass
    {

        /// <summary>
        /// Constant ExpiredIterator for ValidationExceptionType
        /// </summary>
        public static readonly ValidationExceptionType ExpiredIterator = new ValidationExceptionType("ExpiredIterator");
        /// <summary>
        /// Constant ExpiredNextToken for ValidationExceptionType
        /// </summary>
        public static readonly ValidationExceptionType ExpiredNextToken = new ValidationExceptionType("ExpiredNextToken");
        /// <summary>
        /// Constant InvalidFormat for ValidationExceptionType
        /// </summary>
        public static readonly ValidationExceptionType InvalidFormat = new ValidationExceptionType("InvalidFormat");
        /// <summary>
        /// Constant TrimmedDataAccess for ValidationExceptionType
        /// </summary>
        public static readonly ValidationExceptionType TrimmedDataAccess = new ValidationExceptionType("TrimmedDataAccess");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ValidationExceptionType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ValidationExceptionType FindValue(string value)
        {
            return FindValue<ValidationExceptionType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ValidationExceptionType(string value)
        {
            return FindValue(value);
        }
    }

}