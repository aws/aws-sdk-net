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
 * Do not modify this file. This file is generated from the networkflowmonitor-2023-04-19.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.NetworkFlowMonitor
{

    /// <summary>
    /// Constants used for properties of type DestinationCategory.
    /// </summary>
    public class DestinationCategory : ConstantClass
    {

        /// <summary>
        /// Constant AMAZON_DYNAMODB for DestinationCategory
        /// </summary>
        public static readonly DestinationCategory AMAZON_DYNAMODB = new DestinationCategory("AMAZON_DYNAMODB");
        /// <summary>
        /// Constant AMAZON_S3 for DestinationCategory
        /// </summary>
        public static readonly DestinationCategory AMAZON_S3 = new DestinationCategory("AMAZON_S3");
        /// <summary>
        /// Constant INTER_AZ for DestinationCategory
        /// </summary>
        public static readonly DestinationCategory INTER_AZ = new DestinationCategory("INTER_AZ");
        /// <summary>
        /// Constant INTER_REGION for DestinationCategory
        /// </summary>
        public static readonly DestinationCategory INTER_REGION = new DestinationCategory("INTER_REGION");
        /// <summary>
        /// Constant INTER_VPC for DestinationCategory
        /// </summary>
        public static readonly DestinationCategory INTER_VPC = new DestinationCategory("INTER_VPC");
        /// <summary>
        /// Constant INTRA_AZ for DestinationCategory
        /// </summary>
        public static readonly DestinationCategory INTRA_AZ = new DestinationCategory("INTRA_AZ");
        /// <summary>
        /// Constant UNCLASSIFIED for DestinationCategory
        /// </summary>
        public static readonly DestinationCategory UNCLASSIFIED = new DestinationCategory("UNCLASSIFIED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DestinationCategory(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DestinationCategory FindValue(string value)
        {
            return FindValue<DestinationCategory>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DestinationCategory(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type MetricUnit.
    /// </summary>
    public class MetricUnit : ConstantClass
    {

        /// <summary>
        /// Constant Bits for MetricUnit
        /// </summary>
        public static readonly MetricUnit Bits = new MetricUnit("Bits");
        /// <summary>
        /// Constant BitsSecond for MetricUnit
        /// </summary>
        public static readonly MetricUnit BitsSecond = new MetricUnit("Bits/Second");
        /// <summary>
        /// Constant Bytes for MetricUnit
        /// </summary>
        public static readonly MetricUnit Bytes = new MetricUnit("Bytes");
        /// <summary>
        /// Constant BytesSecond for MetricUnit
        /// </summary>
        public static readonly MetricUnit BytesSecond = new MetricUnit("Bytes/Second");
        /// <summary>
        /// Constant Count for MetricUnit
        /// </summary>
        public static readonly MetricUnit Count = new MetricUnit("Count");
        /// <summary>
        /// Constant CountSecond for MetricUnit
        /// </summary>
        public static readonly MetricUnit CountSecond = new MetricUnit("Count/Second");
        /// <summary>
        /// Constant Gigabits for MetricUnit
        /// </summary>
        public static readonly MetricUnit Gigabits = new MetricUnit("Gigabits");
        /// <summary>
        /// Constant GigabitsSecond for MetricUnit
        /// </summary>
        public static readonly MetricUnit GigabitsSecond = new MetricUnit("Gigabits/Second");
        /// <summary>
        /// Constant Gigabytes for MetricUnit
        /// </summary>
        public static readonly MetricUnit Gigabytes = new MetricUnit("Gigabytes");
        /// <summary>
        /// Constant GigabytesSecond for MetricUnit
        /// </summary>
        public static readonly MetricUnit GigabytesSecond = new MetricUnit("Gigabytes/Second");
        /// <summary>
        /// Constant Kilobits for MetricUnit
        /// </summary>
        public static readonly MetricUnit Kilobits = new MetricUnit("Kilobits");
        /// <summary>
        /// Constant KilobitsSecond for MetricUnit
        /// </summary>
        public static readonly MetricUnit KilobitsSecond = new MetricUnit("Kilobits/Second");
        /// <summary>
        /// Constant Kilobytes for MetricUnit
        /// </summary>
        public static readonly MetricUnit Kilobytes = new MetricUnit("Kilobytes");
        /// <summary>
        /// Constant KilobytesSecond for MetricUnit
        /// </summary>
        public static readonly MetricUnit KilobytesSecond = new MetricUnit("Kilobytes/Second");
        /// <summary>
        /// Constant Megabits for MetricUnit
        /// </summary>
        public static readonly MetricUnit Megabits = new MetricUnit("Megabits");
        /// <summary>
        /// Constant MegabitsSecond for MetricUnit
        /// </summary>
        public static readonly MetricUnit MegabitsSecond = new MetricUnit("Megabits/Second");
        /// <summary>
        /// Constant Megabytes for MetricUnit
        /// </summary>
        public static readonly MetricUnit Megabytes = new MetricUnit("Megabytes");
        /// <summary>
        /// Constant MegabytesSecond for MetricUnit
        /// </summary>
        public static readonly MetricUnit MegabytesSecond = new MetricUnit("Megabytes/Second");
        /// <summary>
        /// Constant Microseconds for MetricUnit
        /// </summary>
        public static readonly MetricUnit Microseconds = new MetricUnit("Microseconds");
        /// <summary>
        /// Constant Milliseconds for MetricUnit
        /// </summary>
        public static readonly MetricUnit Milliseconds = new MetricUnit("Milliseconds");
        /// <summary>
        /// Constant None for MetricUnit
        /// </summary>
        public static readonly MetricUnit None = new MetricUnit("None");
        /// <summary>
        /// Constant Percent for MetricUnit
        /// </summary>
        public static readonly MetricUnit Percent = new MetricUnit("Percent");
        /// <summary>
        /// Constant Seconds for MetricUnit
        /// </summary>
        public static readonly MetricUnit Seconds = new MetricUnit("Seconds");
        /// <summary>
        /// Constant Terabits for MetricUnit
        /// </summary>
        public static readonly MetricUnit Terabits = new MetricUnit("Terabits");
        /// <summary>
        /// Constant TerabitsSecond for MetricUnit
        /// </summary>
        public static readonly MetricUnit TerabitsSecond = new MetricUnit("Terabits/Second");
        /// <summary>
        /// Constant Terabytes for MetricUnit
        /// </summary>
        public static readonly MetricUnit Terabytes = new MetricUnit("Terabytes");
        /// <summary>
        /// Constant TerabytesSecond for MetricUnit
        /// </summary>
        public static readonly MetricUnit TerabytesSecond = new MetricUnit("Terabytes/Second");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MetricUnit(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MetricUnit FindValue(string value)
        {
            return FindValue<MetricUnit>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MetricUnit(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type MonitorLocalResourceType.
    /// </summary>
    public class MonitorLocalResourceType : ConstantClass
    {

        /// <summary>
        /// Constant AWSAvailabilityZone for MonitorLocalResourceType
        /// </summary>
        public static readonly MonitorLocalResourceType AWSAvailabilityZone = new MonitorLocalResourceType("AWS::AvailabilityZone");
        /// <summary>
        /// Constant AWSEC2Subnet for MonitorLocalResourceType
        /// </summary>
        public static readonly MonitorLocalResourceType AWSEC2Subnet = new MonitorLocalResourceType("AWS::EC2::Subnet");
        /// <summary>
        /// Constant AWSEC2VPC for MonitorLocalResourceType
        /// </summary>
        public static readonly MonitorLocalResourceType AWSEC2VPC = new MonitorLocalResourceType("AWS::EC2::VPC");
        /// <summary>
        /// Constant AWSRegion for MonitorLocalResourceType
        /// </summary>
        public static readonly MonitorLocalResourceType AWSRegion = new MonitorLocalResourceType("AWS::Region");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MonitorLocalResourceType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MonitorLocalResourceType FindValue(string value)
        {
            return FindValue<MonitorLocalResourceType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MonitorLocalResourceType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type MonitorMetric.
    /// </summary>
    public class MonitorMetric : ConstantClass
    {

        /// <summary>
        /// Constant DATA_TRANSFERRED for MonitorMetric
        /// </summary>
        public static readonly MonitorMetric DATA_TRANSFERRED = new MonitorMetric("DATA_TRANSFERRED");
        /// <summary>
        /// Constant RETRANSMISSIONS for MonitorMetric
        /// </summary>
        public static readonly MonitorMetric RETRANSMISSIONS = new MonitorMetric("RETRANSMISSIONS");
        /// <summary>
        /// Constant ROUND_TRIP_TIME for MonitorMetric
        /// </summary>
        public static readonly MonitorMetric ROUND_TRIP_TIME = new MonitorMetric("ROUND_TRIP_TIME");
        /// <summary>
        /// Constant TIMEOUTS for MonitorMetric
        /// </summary>
        public static readonly MonitorMetric TIMEOUTS = new MonitorMetric("TIMEOUTS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MonitorMetric(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MonitorMetric FindValue(string value)
        {
            return FindValue<MonitorMetric>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MonitorMetric(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type MonitorRemoteResourceType.
    /// </summary>
    public class MonitorRemoteResourceType : ConstantClass
    {

        /// <summary>
        /// Constant AWSAvailabilityZone for MonitorRemoteResourceType
        /// </summary>
        public static readonly MonitorRemoteResourceType AWSAvailabilityZone = new MonitorRemoteResourceType("AWS::AvailabilityZone");
        /// <summary>
        /// Constant AWSAWSService for MonitorRemoteResourceType
        /// </summary>
        public static readonly MonitorRemoteResourceType AWSAWSService = new MonitorRemoteResourceType("AWS::AWSService");
        /// <summary>
        /// Constant AWSEC2Subnet for MonitorRemoteResourceType
        /// </summary>
        public static readonly MonitorRemoteResourceType AWSEC2Subnet = new MonitorRemoteResourceType("AWS::EC2::Subnet");
        /// <summary>
        /// Constant AWSEC2VPC for MonitorRemoteResourceType
        /// </summary>
        public static readonly MonitorRemoteResourceType AWSEC2VPC = new MonitorRemoteResourceType("AWS::EC2::VPC");
        /// <summary>
        /// Constant AWSRegion for MonitorRemoteResourceType
        /// </summary>
        public static readonly MonitorRemoteResourceType AWSRegion = new MonitorRemoteResourceType("AWS::Region");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MonitorRemoteResourceType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MonitorRemoteResourceType FindValue(string value)
        {
            return FindValue<MonitorRemoteResourceType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MonitorRemoteResourceType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type MonitorStatus.
    /// </summary>
    public class MonitorStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for MonitorStatus
        /// </summary>
        public static readonly MonitorStatus ACTIVE = new MonitorStatus("ACTIVE");
        /// <summary>
        /// Constant DELETING for MonitorStatus
        /// </summary>
        public static readonly MonitorStatus DELETING = new MonitorStatus("DELETING");
        /// <summary>
        /// Constant ERROR for MonitorStatus
        /// </summary>
        public static readonly MonitorStatus ERROR = new MonitorStatus("ERROR");
        /// <summary>
        /// Constant INACTIVE for MonitorStatus
        /// </summary>
        public static readonly MonitorStatus INACTIVE = new MonitorStatus("INACTIVE");
        /// <summary>
        /// Constant PENDING for MonitorStatus
        /// </summary>
        public static readonly MonitorStatus PENDING = new MonitorStatus("PENDING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MonitorStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MonitorStatus FindValue(string value)
        {
            return FindValue<MonitorStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MonitorStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type QueryStatus.
    /// </summary>
    public class QueryStatus : ConstantClass
    {

        /// <summary>
        /// Constant CANCELED for QueryStatus
        /// </summary>
        public static readonly QueryStatus CANCELED = new QueryStatus("CANCELED");
        /// <summary>
        /// Constant FAILED for QueryStatus
        /// </summary>
        public static readonly QueryStatus FAILED = new QueryStatus("FAILED");
        /// <summary>
        /// Constant QUEUED for QueryStatus
        /// </summary>
        public static readonly QueryStatus QUEUED = new QueryStatus("QUEUED");
        /// <summary>
        /// Constant RUNNING for QueryStatus
        /// </summary>
        public static readonly QueryStatus RUNNING = new QueryStatus("RUNNING");
        /// <summary>
        /// Constant SUCCEEDED for QueryStatus
        /// </summary>
        public static readonly QueryStatus SUCCEEDED = new QueryStatus("SUCCEEDED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public QueryStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static QueryStatus FindValue(string value)
        {
            return FindValue<QueryStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator QueryStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ScopeStatus.
    /// </summary>
    public class ScopeStatus : ConstantClass
    {

        /// <summary>
        /// Constant DEACTIVATED for ScopeStatus
        /// </summary>
        public static readonly ScopeStatus DEACTIVATED = new ScopeStatus("DEACTIVATED");
        /// <summary>
        /// Constant DEACTIVATING for ScopeStatus
        /// </summary>
        public static readonly ScopeStatus DEACTIVATING = new ScopeStatus("DEACTIVATING");
        /// <summary>
        /// Constant FAILED for ScopeStatus
        /// </summary>
        public static readonly ScopeStatus FAILED = new ScopeStatus("FAILED");
        /// <summary>
        /// Constant IN_PROGRESS for ScopeStatus
        /// </summary>
        public static readonly ScopeStatus IN_PROGRESS = new ScopeStatus("IN_PROGRESS");
        /// <summary>
        /// Constant SUCCEEDED for ScopeStatus
        /// </summary>
        public static readonly ScopeStatus SUCCEEDED = new ScopeStatus("SUCCEEDED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ScopeStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ScopeStatus FindValue(string value)
        {
            return FindValue<ScopeStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ScopeStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TargetType.
    /// </summary>
    public class TargetType : ConstantClass
    {

        /// <summary>
        /// Constant ACCOUNT for TargetType
        /// </summary>
        public static readonly TargetType ACCOUNT = new TargetType("ACCOUNT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TargetType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TargetType FindValue(string value)
        {
            return FindValue<TargetType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TargetType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type WorkloadInsightsMetric.
    /// </summary>
    public class WorkloadInsightsMetric : ConstantClass
    {

        /// <summary>
        /// Constant DATA_TRANSFERRED for WorkloadInsightsMetric
        /// </summary>
        public static readonly WorkloadInsightsMetric DATA_TRANSFERRED = new WorkloadInsightsMetric("DATA_TRANSFERRED");
        /// <summary>
        /// Constant RETRANSMISSIONS for WorkloadInsightsMetric
        /// </summary>
        public static readonly WorkloadInsightsMetric RETRANSMISSIONS = new WorkloadInsightsMetric("RETRANSMISSIONS");
        /// <summary>
        /// Constant TIMEOUTS for WorkloadInsightsMetric
        /// </summary>
        public static readonly WorkloadInsightsMetric TIMEOUTS = new WorkloadInsightsMetric("TIMEOUTS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public WorkloadInsightsMetric(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static WorkloadInsightsMetric FindValue(string value)
        {
            return FindValue<WorkloadInsightsMetric>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator WorkloadInsightsMetric(string value)
        {
            return FindValue(value);
        }
    }

}