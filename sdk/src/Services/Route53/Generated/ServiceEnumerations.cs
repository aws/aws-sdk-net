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
 * Do not modify this file. This file is generated from the route53-2013-04-01.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.Route53
{

    /// <summary>
    /// Constants used for properties of type ChangeAction.
    /// </summary>
    public class ChangeAction : ConstantClass
    {

        /// <summary>
        /// Constant CREATE for ChangeAction
        /// </summary>
        public static readonly ChangeAction CREATE = new ChangeAction("CREATE");
        /// <summary>
        /// Constant DELETE for ChangeAction
        /// </summary>
        public static readonly ChangeAction DELETE = new ChangeAction("DELETE");
        /// <summary>
        /// Constant UPSERT for ChangeAction
        /// </summary>
        public static readonly ChangeAction UPSERT = new ChangeAction("UPSERT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ChangeAction(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ChangeAction FindValue(string value)
        {
            return FindValue<ChangeAction>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ChangeAction(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ChangeStatus.
    /// </summary>
    public class ChangeStatus : ConstantClass
    {

        /// <summary>
        /// Constant INSYNC for ChangeStatus
        /// </summary>
        public static readonly ChangeStatus INSYNC = new ChangeStatus("INSYNC");
        /// <summary>
        /// Constant PENDING for ChangeStatus
        /// </summary>
        public static readonly ChangeStatus PENDING = new ChangeStatus("PENDING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ChangeStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ChangeStatus FindValue(string value)
        {
            return FindValue<ChangeStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ChangeStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CloudWatchRegion.
    /// </summary>
    public class CloudWatchRegion : ConstantClass
    {

        /// <summary>
        /// Constant ApNortheast1 for CloudWatchRegion
        /// </summary>
        public static readonly CloudWatchRegion ApNortheast1 = new CloudWatchRegion("ap-northeast-1");
        /// <summary>
        /// Constant ApNortheast2 for CloudWatchRegion
        /// </summary>
        public static readonly CloudWatchRegion ApNortheast2 = new CloudWatchRegion("ap-northeast-2");
        /// <summary>
        /// Constant ApSoutheast1 for CloudWatchRegion
        /// </summary>
        public static readonly CloudWatchRegion ApSoutheast1 = new CloudWatchRegion("ap-southeast-1");
        /// <summary>
        /// Constant ApSoutheast2 for CloudWatchRegion
        /// </summary>
        public static readonly CloudWatchRegion ApSoutheast2 = new CloudWatchRegion("ap-southeast-2");
        /// <summary>
        /// Constant EuCentral1 for CloudWatchRegion
        /// </summary>
        public static readonly CloudWatchRegion EuCentral1 = new CloudWatchRegion("eu-central-1");
        /// <summary>
        /// Constant EuWest1 for CloudWatchRegion
        /// </summary>
        public static readonly CloudWatchRegion EuWest1 = new CloudWatchRegion("eu-west-1");
        /// <summary>
        /// Constant SaEast1 for CloudWatchRegion
        /// </summary>
        public static readonly CloudWatchRegion SaEast1 = new CloudWatchRegion("sa-east-1");
        /// <summary>
        /// Constant UsEast1 for CloudWatchRegion
        /// </summary>
        public static readonly CloudWatchRegion UsEast1 = new CloudWatchRegion("us-east-1");
        /// <summary>
        /// Constant UsWest1 for CloudWatchRegion
        /// </summary>
        public static readonly CloudWatchRegion UsWest1 = new CloudWatchRegion("us-west-1");
        /// <summary>
        /// Constant UsWest2 for CloudWatchRegion
        /// </summary>
        public static readonly CloudWatchRegion UsWest2 = new CloudWatchRegion("us-west-2");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CloudWatchRegion(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CloudWatchRegion FindValue(string value)
        {
            return FindValue<CloudWatchRegion>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CloudWatchRegion(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ComparisonOperator.
    /// </summary>
    public class ComparisonOperator : ConstantClass
    {

        /// <summary>
        /// Constant GreaterThanOrEqualToThreshold for ComparisonOperator
        /// </summary>
        public static readonly ComparisonOperator GreaterThanOrEqualToThreshold = new ComparisonOperator("GreaterThanOrEqualToThreshold");
        /// <summary>
        /// Constant GreaterThanThreshold for ComparisonOperator
        /// </summary>
        public static readonly ComparisonOperator GreaterThanThreshold = new ComparisonOperator("GreaterThanThreshold");
        /// <summary>
        /// Constant LessThanOrEqualToThreshold for ComparisonOperator
        /// </summary>
        public static readonly ComparisonOperator LessThanOrEqualToThreshold = new ComparisonOperator("LessThanOrEqualToThreshold");
        /// <summary>
        /// Constant LessThanThreshold for ComparisonOperator
        /// </summary>
        public static readonly ComparisonOperator LessThanThreshold = new ComparisonOperator("LessThanThreshold");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ComparisonOperator(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ComparisonOperator FindValue(string value)
        {
            return FindValue<ComparisonOperator>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ComparisonOperator(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type HealthCheckRegion.
    /// </summary>
    public class HealthCheckRegion : ConstantClass
    {

        /// <summary>
        /// Constant ApNortheast1 for HealthCheckRegion
        /// </summary>
        public static readonly HealthCheckRegion ApNortheast1 = new HealthCheckRegion("ap-northeast-1");
        /// <summary>
        /// Constant ApSoutheast1 for HealthCheckRegion
        /// </summary>
        public static readonly HealthCheckRegion ApSoutheast1 = new HealthCheckRegion("ap-southeast-1");
        /// <summary>
        /// Constant ApSoutheast2 for HealthCheckRegion
        /// </summary>
        public static readonly HealthCheckRegion ApSoutheast2 = new HealthCheckRegion("ap-southeast-2");
        /// <summary>
        /// Constant EuWest1 for HealthCheckRegion
        /// </summary>
        public static readonly HealthCheckRegion EuWest1 = new HealthCheckRegion("eu-west-1");
        /// <summary>
        /// Constant SaEast1 for HealthCheckRegion
        /// </summary>
        public static readonly HealthCheckRegion SaEast1 = new HealthCheckRegion("sa-east-1");
        /// <summary>
        /// Constant UsEast1 for HealthCheckRegion
        /// </summary>
        public static readonly HealthCheckRegion UsEast1 = new HealthCheckRegion("us-east-1");
        /// <summary>
        /// Constant UsWest1 for HealthCheckRegion
        /// </summary>
        public static readonly HealthCheckRegion UsWest1 = new HealthCheckRegion("us-west-1");
        /// <summary>
        /// Constant UsWest2 for HealthCheckRegion
        /// </summary>
        public static readonly HealthCheckRegion UsWest2 = new HealthCheckRegion("us-west-2");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public HealthCheckRegion(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static HealthCheckRegion FindValue(string value)
        {
            return FindValue<HealthCheckRegion>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator HealthCheckRegion(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type HealthCheckType.
    /// </summary>
    public class HealthCheckType : ConstantClass
    {

        /// <summary>
        /// Constant CALCULATED for HealthCheckType
        /// </summary>
        public static readonly HealthCheckType CALCULATED = new HealthCheckType("CALCULATED");
        /// <summary>
        /// Constant CLOUDWATCH_METRIC for HealthCheckType
        /// </summary>
        public static readonly HealthCheckType CLOUDWATCH_METRIC = new HealthCheckType("CLOUDWATCH_METRIC");
        /// <summary>
        /// Constant HTTP for HealthCheckType
        /// </summary>
        public static readonly HealthCheckType HTTP = new HealthCheckType("HTTP");
        /// <summary>
        /// Constant HTTP_STR_MATCH for HealthCheckType
        /// </summary>
        public static readonly HealthCheckType HTTP_STR_MATCH = new HealthCheckType("HTTP_STR_MATCH");
        /// <summary>
        /// Constant HTTPS for HealthCheckType
        /// </summary>
        public static readonly HealthCheckType HTTPS = new HealthCheckType("HTTPS");
        /// <summary>
        /// Constant HTTPS_STR_MATCH for HealthCheckType
        /// </summary>
        public static readonly HealthCheckType HTTPS_STR_MATCH = new HealthCheckType("HTTPS_STR_MATCH");
        /// <summary>
        /// Constant TCP for HealthCheckType
        /// </summary>
        public static readonly HealthCheckType TCP = new HealthCheckType("TCP");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public HealthCheckType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static HealthCheckType FindValue(string value)
        {
            return FindValue<HealthCheckType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator HealthCheckType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type InsufficientDataHealthStatus.
    /// </summary>
    public class InsufficientDataHealthStatus : ConstantClass
    {

        /// <summary>
        /// Constant Healthy for InsufficientDataHealthStatus
        /// </summary>
        public static readonly InsufficientDataHealthStatus Healthy = new InsufficientDataHealthStatus("Healthy");
        /// <summary>
        /// Constant LastKnownStatus for InsufficientDataHealthStatus
        /// </summary>
        public static readonly InsufficientDataHealthStatus LastKnownStatus = new InsufficientDataHealthStatus("LastKnownStatus");
        /// <summary>
        /// Constant Unhealthy for InsufficientDataHealthStatus
        /// </summary>
        public static readonly InsufficientDataHealthStatus Unhealthy = new InsufficientDataHealthStatus("Unhealthy");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public InsufficientDataHealthStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static InsufficientDataHealthStatus FindValue(string value)
        {
            return FindValue<InsufficientDataHealthStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator InsufficientDataHealthStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ResourceRecordSetFailover.
    /// </summary>
    public class ResourceRecordSetFailover : ConstantClass
    {

        /// <summary>
        /// Constant PRIMARY for ResourceRecordSetFailover
        /// </summary>
        public static readonly ResourceRecordSetFailover PRIMARY = new ResourceRecordSetFailover("PRIMARY");
        /// <summary>
        /// Constant SECONDARY for ResourceRecordSetFailover
        /// </summary>
        public static readonly ResourceRecordSetFailover SECONDARY = new ResourceRecordSetFailover("SECONDARY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ResourceRecordSetFailover(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ResourceRecordSetFailover FindValue(string value)
        {
            return FindValue<ResourceRecordSetFailover>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ResourceRecordSetFailover(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ResourceRecordSetRegion.
    /// </summary>
    public class ResourceRecordSetRegion : ConstantClass
    {

        /// <summary>
        /// Constant ApNortheast1 for ResourceRecordSetRegion
        /// </summary>
        public static readonly ResourceRecordSetRegion ApNortheast1 = new ResourceRecordSetRegion("ap-northeast-1");
        /// <summary>
        /// Constant ApNortheast2 for ResourceRecordSetRegion
        /// </summary>
        public static readonly ResourceRecordSetRegion ApNortheast2 = new ResourceRecordSetRegion("ap-northeast-2");
        /// <summary>
        /// Constant ApSouth1 for ResourceRecordSetRegion
        /// </summary>
        public static readonly ResourceRecordSetRegion ApSouth1 = new ResourceRecordSetRegion("ap-south-1");
        /// <summary>
        /// Constant ApSoutheast1 for ResourceRecordSetRegion
        /// </summary>
        public static readonly ResourceRecordSetRegion ApSoutheast1 = new ResourceRecordSetRegion("ap-southeast-1");
        /// <summary>
        /// Constant ApSoutheast2 for ResourceRecordSetRegion
        /// </summary>
        public static readonly ResourceRecordSetRegion ApSoutheast2 = new ResourceRecordSetRegion("ap-southeast-2");
        /// <summary>
        /// Constant CnNorth1 for ResourceRecordSetRegion
        /// </summary>
        public static readonly ResourceRecordSetRegion CnNorth1 = new ResourceRecordSetRegion("cn-north-1");
        /// <summary>
        /// Constant EuCentral1 for ResourceRecordSetRegion
        /// </summary>
        public static readonly ResourceRecordSetRegion EuCentral1 = new ResourceRecordSetRegion("eu-central-1");
        /// <summary>
        /// Constant EuWest1 for ResourceRecordSetRegion
        /// </summary>
        public static readonly ResourceRecordSetRegion EuWest1 = new ResourceRecordSetRegion("eu-west-1");
        /// <summary>
        /// Constant SaEast1 for ResourceRecordSetRegion
        /// </summary>
        public static readonly ResourceRecordSetRegion SaEast1 = new ResourceRecordSetRegion("sa-east-1");
        /// <summary>
        /// Constant UsEast1 for ResourceRecordSetRegion
        /// </summary>
        public static readonly ResourceRecordSetRegion UsEast1 = new ResourceRecordSetRegion("us-east-1");
        /// <summary>
        /// Constant UsWest1 for ResourceRecordSetRegion
        /// </summary>
        public static readonly ResourceRecordSetRegion UsWest1 = new ResourceRecordSetRegion("us-west-1");
        /// <summary>
        /// Constant UsWest2 for ResourceRecordSetRegion
        /// </summary>
        public static readonly ResourceRecordSetRegion UsWest2 = new ResourceRecordSetRegion("us-west-2");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ResourceRecordSetRegion(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ResourceRecordSetRegion FindValue(string value)
        {
            return FindValue<ResourceRecordSetRegion>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ResourceRecordSetRegion(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RRType.
    /// </summary>
    public class RRType : ConstantClass
    {

        /// <summary>
        /// Constant A for RRType
        /// </summary>
        public static readonly RRType A = new RRType("A");
        /// <summary>
        /// Constant AAAA for RRType
        /// </summary>
        public static readonly RRType AAAA = new RRType("AAAA");
        /// <summary>
        /// Constant CNAME for RRType
        /// </summary>
        public static readonly RRType CNAME = new RRType("CNAME");
        /// <summary>
        /// Constant MX for RRType
        /// </summary>
        public static readonly RRType MX = new RRType("MX");
        /// <summary>
        /// Constant NS for RRType
        /// </summary>
        public static readonly RRType NS = new RRType("NS");
        /// <summary>
        /// Constant PTR for RRType
        /// </summary>
        public static readonly RRType PTR = new RRType("PTR");
        /// <summary>
        /// Constant SOA for RRType
        /// </summary>
        public static readonly RRType SOA = new RRType("SOA");
        /// <summary>
        /// Constant SPF for RRType
        /// </summary>
        public static readonly RRType SPF = new RRType("SPF");
        /// <summary>
        /// Constant SRV for RRType
        /// </summary>
        public static readonly RRType SRV = new RRType("SRV");
        /// <summary>
        /// Constant TXT for RRType
        /// </summary>
        public static readonly RRType TXT = new RRType("TXT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RRType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RRType FindValue(string value)
        {
            return FindValue<RRType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RRType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Statistic.
    /// </summary>
    public class Statistic : ConstantClass
    {

        /// <summary>
        /// Constant Average for Statistic
        /// </summary>
        public static readonly Statistic Average = new Statistic("Average");
        /// <summary>
        /// Constant Maximum for Statistic
        /// </summary>
        public static readonly Statistic Maximum = new Statistic("Maximum");
        /// <summary>
        /// Constant Minimum for Statistic
        /// </summary>
        public static readonly Statistic Minimum = new Statistic("Minimum");
        /// <summary>
        /// Constant SampleCount for Statistic
        /// </summary>
        public static readonly Statistic SampleCount = new Statistic("SampleCount");
        /// <summary>
        /// Constant Sum for Statistic
        /// </summary>
        public static readonly Statistic Sum = new Statistic("Sum");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Statistic(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Statistic FindValue(string value)
        {
            return FindValue<Statistic>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Statistic(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TagResourceType.
    /// </summary>
    public class TagResourceType : ConstantClass
    {

        /// <summary>
        /// Constant Healthcheck for TagResourceType
        /// </summary>
        public static readonly TagResourceType Healthcheck = new TagResourceType("healthcheck");
        /// <summary>
        /// Constant Hostedzone for TagResourceType
        /// </summary>
        public static readonly TagResourceType Hostedzone = new TagResourceType("hostedzone");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TagResourceType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TagResourceType FindValue(string value)
        {
            return FindValue<TagResourceType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TagResourceType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type VPCRegion.
    /// </summary>
    public class VPCRegion : ConstantClass
    {

        /// <summary>
        /// Constant ApNortheast1 for VPCRegion
        /// </summary>
        public static readonly VPCRegion ApNortheast1 = new VPCRegion("ap-northeast-1");
        /// <summary>
        /// Constant ApNortheast2 for VPCRegion
        /// </summary>
        public static readonly VPCRegion ApNortheast2 = new VPCRegion("ap-northeast-2");
        /// <summary>
        /// Constant ApSouth1 for VPCRegion
        /// </summary>
        public static readonly VPCRegion ApSouth1 = new VPCRegion("ap-south-1");
        /// <summary>
        /// Constant ApSoutheast1 for VPCRegion
        /// </summary>
        public static readonly VPCRegion ApSoutheast1 = new VPCRegion("ap-southeast-1");
        /// <summary>
        /// Constant ApSoutheast2 for VPCRegion
        /// </summary>
        public static readonly VPCRegion ApSoutheast2 = new VPCRegion("ap-southeast-2");
        /// <summary>
        /// Constant CnNorth1 for VPCRegion
        /// </summary>
        public static readonly VPCRegion CnNorth1 = new VPCRegion("cn-north-1");
        /// <summary>
        /// Constant EuCentral1 for VPCRegion
        /// </summary>
        public static readonly VPCRegion EuCentral1 = new VPCRegion("eu-central-1");
        /// <summary>
        /// Constant EuWest1 for VPCRegion
        /// </summary>
        public static readonly VPCRegion EuWest1 = new VPCRegion("eu-west-1");
        /// <summary>
        /// Constant SaEast1 for VPCRegion
        /// </summary>
        public static readonly VPCRegion SaEast1 = new VPCRegion("sa-east-1");
        /// <summary>
        /// Constant UsEast1 for VPCRegion
        /// </summary>
        public static readonly VPCRegion UsEast1 = new VPCRegion("us-east-1");
        /// <summary>
        /// Constant UsWest1 for VPCRegion
        /// </summary>
        public static readonly VPCRegion UsWest1 = new VPCRegion("us-west-1");
        /// <summary>
        /// Constant UsWest2 for VPCRegion
        /// </summary>
        public static readonly VPCRegion UsWest2 = new VPCRegion("us-west-2");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public VPCRegion(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static VPCRegion FindValue(string value)
        {
            return FindValue<VPCRegion>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator VPCRegion(string value)
        {
            return FindValue(value);
        }
    }

}