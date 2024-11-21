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
 * Do not modify this file. This file is generated from the xray-2016-04-12.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.XRay
{

    /// <summary>
    /// Constants used for properties of type EncryptionStatus.
    /// </summary>
    public class EncryptionStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for EncryptionStatus
        /// </summary>
        public static readonly EncryptionStatus ACTIVE = new EncryptionStatus("ACTIVE");
        /// <summary>
        /// Constant UPDATING for EncryptionStatus
        /// </summary>
        public static readonly EncryptionStatus UPDATING = new EncryptionStatus("UPDATING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EncryptionStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EncryptionStatus FindValue(string value)
        {
            return FindValue<EncryptionStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EncryptionStatus(string value)
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
    /// Constants used for properties of type InsightCategory.
    /// </summary>
    public class InsightCategory : ConstantClass
    {

        /// <summary>
        /// Constant FAULT for InsightCategory
        /// </summary>
        public static readonly InsightCategory FAULT = new InsightCategory("FAULT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public InsightCategory(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static InsightCategory FindValue(string value)
        {
            return FindValue<InsightCategory>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator InsightCategory(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type InsightState.
    /// </summary>
    public class InsightState : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for InsightState
        /// </summary>
        public static readonly InsightState ACTIVE = new InsightState("ACTIVE");
        /// <summary>
        /// Constant CLOSED for InsightState
        /// </summary>
        public static readonly InsightState CLOSED = new InsightState("CLOSED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public InsightState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static InsightState FindValue(string value)
        {
            return FindValue<InsightState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator InsightState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RetrievalStatus.
    /// </summary>
    public class RetrievalStatus : ConstantClass
    {

        /// <summary>
        /// Constant CANCELLED for RetrievalStatus
        /// </summary>
        public static readonly RetrievalStatus CANCELLED = new RetrievalStatus("CANCELLED");
        /// <summary>
        /// Constant COMPLETE for RetrievalStatus
        /// </summary>
        public static readonly RetrievalStatus COMPLETE = new RetrievalStatus("COMPLETE");
        /// <summary>
        /// Constant FAILED for RetrievalStatus
        /// </summary>
        public static readonly RetrievalStatus FAILED = new RetrievalStatus("FAILED");
        /// <summary>
        /// Constant RUNNING for RetrievalStatus
        /// </summary>
        public static readonly RetrievalStatus RUNNING = new RetrievalStatus("RUNNING");
        /// <summary>
        /// Constant SCHEDULED for RetrievalStatus
        /// </summary>
        public static readonly RetrievalStatus SCHEDULED = new RetrievalStatus("SCHEDULED");
        /// <summary>
        /// Constant TIMEOUT for RetrievalStatus
        /// </summary>
        public static readonly RetrievalStatus TIMEOUT = new RetrievalStatus("TIMEOUT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RetrievalStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RetrievalStatus FindValue(string value)
        {
            return FindValue<RetrievalStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RetrievalStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SamplingStrategyName.
    /// </summary>
    public class SamplingStrategyName : ConstantClass
    {

        /// <summary>
        /// Constant FixedRate for SamplingStrategyName
        /// </summary>
        public static readonly SamplingStrategyName FixedRate = new SamplingStrategyName("FixedRate");
        /// <summary>
        /// Constant PartialScan for SamplingStrategyName
        /// </summary>
        public static readonly SamplingStrategyName PartialScan = new SamplingStrategyName("PartialScan");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SamplingStrategyName(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SamplingStrategyName FindValue(string value)
        {
            return FindValue<SamplingStrategyName>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SamplingStrategyName(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TimeRangeType.
    /// </summary>
    public class TimeRangeType : ConstantClass
    {

        /// <summary>
        /// Constant Event for TimeRangeType
        /// </summary>
        public static readonly TimeRangeType Event = new TimeRangeType("Event");
        /// <summary>
        /// Constant Service for TimeRangeType
        /// </summary>
        public static readonly TimeRangeType Service = new TimeRangeType("Service");
        /// <summary>
        /// Constant TraceId for TimeRangeType
        /// </summary>
        public static readonly TimeRangeType TraceId = new TimeRangeType("TraceId");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TimeRangeType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TimeRangeType FindValue(string value)
        {
            return FindValue<TimeRangeType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TimeRangeType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TraceFormatType.
    /// </summary>
    public class TraceFormatType : ConstantClass
    {

        /// <summary>
        /// Constant OTEL for TraceFormatType
        /// </summary>
        public static readonly TraceFormatType OTEL = new TraceFormatType("OTEL");
        /// <summary>
        /// Constant XRAY for TraceFormatType
        /// </summary>
        public static readonly TraceFormatType XRAY = new TraceFormatType("XRAY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TraceFormatType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TraceFormatType FindValue(string value)
        {
            return FindValue<TraceFormatType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TraceFormatType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TraceSegmentDestination.
    /// </summary>
    public class TraceSegmentDestination : ConstantClass
    {

        /// <summary>
        /// Constant CloudWatchLogs for TraceSegmentDestination
        /// </summary>
        public static readonly TraceSegmentDestination CloudWatchLogs = new TraceSegmentDestination("CloudWatchLogs");
        /// <summary>
        /// Constant XRay for TraceSegmentDestination
        /// </summary>
        public static readonly TraceSegmentDestination XRay = new TraceSegmentDestination("XRay");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TraceSegmentDestination(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TraceSegmentDestination FindValue(string value)
        {
            return FindValue<TraceSegmentDestination>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TraceSegmentDestination(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TraceSegmentDestinationStatus.
    /// </summary>
    public class TraceSegmentDestinationStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for TraceSegmentDestinationStatus
        /// </summary>
        public static readonly TraceSegmentDestinationStatus ACTIVE = new TraceSegmentDestinationStatus("ACTIVE");
        /// <summary>
        /// Constant PENDING for TraceSegmentDestinationStatus
        /// </summary>
        public static readonly TraceSegmentDestinationStatus PENDING = new TraceSegmentDestinationStatus("PENDING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TraceSegmentDestinationStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TraceSegmentDestinationStatus FindValue(string value)
        {
            return FindValue<TraceSegmentDestinationStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TraceSegmentDestinationStatus(string value)
        {
            return FindValue(value);
        }
    }

}