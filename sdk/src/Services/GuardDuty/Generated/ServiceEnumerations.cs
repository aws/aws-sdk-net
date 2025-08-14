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
 * Do not modify this file. This file is generated from the guardduty-2017-11-28.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.GuardDuty
{

    /// <summary>
    /// Constants used for properties of type AdminStatus.
    /// </summary>
    public class AdminStatus : ConstantClass
    {

        /// <summary>
        /// Constant DISABLE_IN_PROGRESS for AdminStatus
        /// </summary>
        public static readonly AdminStatus DISABLE_IN_PROGRESS = new AdminStatus("DISABLE_IN_PROGRESS");
        /// <summary>
        /// Constant ENABLED for AdminStatus
        /// </summary>
        public static readonly AdminStatus ENABLED = new AdminStatus("ENABLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AdminStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AdminStatus FindValue(string value)
        {
            return FindValue<AdminStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AdminStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AutoEnableMembers.
    /// </summary>
    public class AutoEnableMembers : ConstantClass
    {

        /// <summary>
        /// Constant ALL for AutoEnableMembers
        /// </summary>
        public static readonly AutoEnableMembers ALL = new AutoEnableMembers("ALL");
        /// <summary>
        /// Constant NEW for AutoEnableMembers
        /// </summary>
        public static readonly AutoEnableMembers NEW = new AutoEnableMembers("NEW");
        /// <summary>
        /// Constant NONE for AutoEnableMembers
        /// </summary>
        public static readonly AutoEnableMembers NONE = new AutoEnableMembers("NONE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AutoEnableMembers(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AutoEnableMembers FindValue(string value)
        {
            return FindValue<AutoEnableMembers>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AutoEnableMembers(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ClusterStatus.
    /// </summary>
    public class ClusterStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for ClusterStatus
        /// </summary>
        public static readonly ClusterStatus ACTIVE = new ClusterStatus("ACTIVE");
        /// <summary>
        /// Constant CREATING for ClusterStatus
        /// </summary>
        public static readonly ClusterStatus CREATING = new ClusterStatus("CREATING");
        /// <summary>
        /// Constant DELETING for ClusterStatus
        /// </summary>
        public static readonly ClusterStatus DELETING = new ClusterStatus("DELETING");
        /// <summary>
        /// Constant FAILED for ClusterStatus
        /// </summary>
        public static readonly ClusterStatus FAILED = new ClusterStatus("FAILED");
        /// <summary>
        /// Constant PENDING for ClusterStatus
        /// </summary>
        public static readonly ClusterStatus PENDING = new ClusterStatus("PENDING");
        /// <summary>
        /// Constant UPDATING for ClusterStatus
        /// </summary>
        public static readonly ClusterStatus UPDATING = new ClusterStatus("UPDATING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ClusterStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ClusterStatus FindValue(string value)
        {
            return FindValue<ClusterStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ClusterStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CoverageFilterCriterionKey.
    /// </summary>
    public class CoverageFilterCriterionKey : ConstantClass
    {

        /// <summary>
        /// Constant ACCOUNT_ID for CoverageFilterCriterionKey
        /// </summary>
        public static readonly CoverageFilterCriterionKey ACCOUNT_ID = new CoverageFilterCriterionKey("ACCOUNT_ID");
        /// <summary>
        /// Constant ADDON_VERSION for CoverageFilterCriterionKey
        /// </summary>
        public static readonly CoverageFilterCriterionKey ADDON_VERSION = new CoverageFilterCriterionKey("ADDON_VERSION");
        /// <summary>
        /// Constant AGENT_VERSION for CoverageFilterCriterionKey
        /// </summary>
        public static readonly CoverageFilterCriterionKey AGENT_VERSION = new CoverageFilterCriterionKey("AGENT_VERSION");
        /// <summary>
        /// Constant CLUSTER_ARN for CoverageFilterCriterionKey
        /// </summary>
        public static readonly CoverageFilterCriterionKey CLUSTER_ARN = new CoverageFilterCriterionKey("CLUSTER_ARN");
        /// <summary>
        /// Constant CLUSTER_NAME for CoverageFilterCriterionKey
        /// </summary>
        public static readonly CoverageFilterCriterionKey CLUSTER_NAME = new CoverageFilterCriterionKey("CLUSTER_NAME");
        /// <summary>
        /// Constant COVERAGE_STATUS for CoverageFilterCriterionKey
        /// </summary>
        public static readonly CoverageFilterCriterionKey COVERAGE_STATUS = new CoverageFilterCriterionKey("COVERAGE_STATUS");
        /// <summary>
        /// Constant ECS_CLUSTER_NAME for CoverageFilterCriterionKey
        /// </summary>
        public static readonly CoverageFilterCriterionKey ECS_CLUSTER_NAME = new CoverageFilterCriterionKey("ECS_CLUSTER_NAME");
        /// <summary>
        /// Constant EKS_CLUSTER_NAME for CoverageFilterCriterionKey
        /// </summary>
        public static readonly CoverageFilterCriterionKey EKS_CLUSTER_NAME = new CoverageFilterCriterionKey("EKS_CLUSTER_NAME");
        /// <summary>
        /// Constant INSTANCE_ID for CoverageFilterCriterionKey
        /// </summary>
        public static readonly CoverageFilterCriterionKey INSTANCE_ID = new CoverageFilterCriterionKey("INSTANCE_ID");
        /// <summary>
        /// Constant MANAGEMENT_TYPE for CoverageFilterCriterionKey
        /// </summary>
        public static readonly CoverageFilterCriterionKey MANAGEMENT_TYPE = new CoverageFilterCriterionKey("MANAGEMENT_TYPE");
        /// <summary>
        /// Constant RESOURCE_TYPE for CoverageFilterCriterionKey
        /// </summary>
        public static readonly CoverageFilterCriterionKey RESOURCE_TYPE = new CoverageFilterCriterionKey("RESOURCE_TYPE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CoverageFilterCriterionKey(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CoverageFilterCriterionKey FindValue(string value)
        {
            return FindValue<CoverageFilterCriterionKey>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CoverageFilterCriterionKey(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CoverageSortKey.
    /// </summary>
    public class CoverageSortKey : ConstantClass
    {

        /// <summary>
        /// Constant ACCOUNT_ID for CoverageSortKey
        /// </summary>
        public static readonly CoverageSortKey ACCOUNT_ID = new CoverageSortKey("ACCOUNT_ID");
        /// <summary>
        /// Constant ADDON_VERSION for CoverageSortKey
        /// </summary>
        public static readonly CoverageSortKey ADDON_VERSION = new CoverageSortKey("ADDON_VERSION");
        /// <summary>
        /// Constant CLUSTER_NAME for CoverageSortKey
        /// </summary>
        public static readonly CoverageSortKey CLUSTER_NAME = new CoverageSortKey("CLUSTER_NAME");
        /// <summary>
        /// Constant COVERAGE_STATUS for CoverageSortKey
        /// </summary>
        public static readonly CoverageSortKey COVERAGE_STATUS = new CoverageSortKey("COVERAGE_STATUS");
        /// <summary>
        /// Constant ECS_CLUSTER_NAME for CoverageSortKey
        /// </summary>
        public static readonly CoverageSortKey ECS_CLUSTER_NAME = new CoverageSortKey("ECS_CLUSTER_NAME");
        /// <summary>
        /// Constant EKS_CLUSTER_NAME for CoverageSortKey
        /// </summary>
        public static readonly CoverageSortKey EKS_CLUSTER_NAME = new CoverageSortKey("EKS_CLUSTER_NAME");
        /// <summary>
        /// Constant INSTANCE_ID for CoverageSortKey
        /// </summary>
        public static readonly CoverageSortKey INSTANCE_ID = new CoverageSortKey("INSTANCE_ID");
        /// <summary>
        /// Constant ISSUE for CoverageSortKey
        /// </summary>
        public static readonly CoverageSortKey ISSUE = new CoverageSortKey("ISSUE");
        /// <summary>
        /// Constant UPDATED_AT for CoverageSortKey
        /// </summary>
        public static readonly CoverageSortKey UPDATED_AT = new CoverageSortKey("UPDATED_AT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CoverageSortKey(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CoverageSortKey FindValue(string value)
        {
            return FindValue<CoverageSortKey>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CoverageSortKey(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CoverageStatisticsType.
    /// </summary>
    public class CoverageStatisticsType : ConstantClass
    {

        /// <summary>
        /// Constant COUNT_BY_COVERAGE_STATUS for CoverageStatisticsType
        /// </summary>
        public static readonly CoverageStatisticsType COUNT_BY_COVERAGE_STATUS = new CoverageStatisticsType("COUNT_BY_COVERAGE_STATUS");
        /// <summary>
        /// Constant COUNT_BY_RESOURCE_TYPE for CoverageStatisticsType
        /// </summary>
        public static readonly CoverageStatisticsType COUNT_BY_RESOURCE_TYPE = new CoverageStatisticsType("COUNT_BY_RESOURCE_TYPE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CoverageStatisticsType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CoverageStatisticsType FindValue(string value)
        {
            return FindValue<CoverageStatisticsType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CoverageStatisticsType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CoverageStatus.
    /// </summary>
    public class CoverageStatus : ConstantClass
    {

        /// <summary>
        /// Constant HEALTHY for CoverageStatus
        /// </summary>
        public static readonly CoverageStatus HEALTHY = new CoverageStatus("HEALTHY");
        /// <summary>
        /// Constant UNHEALTHY for CoverageStatus
        /// </summary>
        public static readonly CoverageStatus UNHEALTHY = new CoverageStatus("UNHEALTHY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CoverageStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CoverageStatus FindValue(string value)
        {
            return FindValue<CoverageStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CoverageStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CriterionKey.
    /// </summary>
    public class CriterionKey : ConstantClass
    {

        /// <summary>
        /// Constant ACCOUNT_ID for CriterionKey
        /// </summary>
        public static readonly CriterionKey ACCOUNT_ID = new CriterionKey("ACCOUNT_ID");
        /// <summary>
        /// Constant EC2_INSTANCE_ARN for CriterionKey
        /// </summary>
        public static readonly CriterionKey EC2_INSTANCE_ARN = new CriterionKey("EC2_INSTANCE_ARN");
        /// <summary>
        /// Constant GUARDDUTY_FINDING_ID for CriterionKey
        /// </summary>
        public static readonly CriterionKey GUARDDUTY_FINDING_ID = new CriterionKey("GUARDDUTY_FINDING_ID");
        /// <summary>
        /// Constant SCAN_ID for CriterionKey
        /// </summary>
        public static readonly CriterionKey SCAN_ID = new CriterionKey("SCAN_ID");
        /// <summary>
        /// Constant SCAN_START_TIME for CriterionKey
        /// </summary>
        public static readonly CriterionKey SCAN_START_TIME = new CriterionKey("SCAN_START_TIME");
        /// <summary>
        /// Constant SCAN_STATUS for CriterionKey
        /// </summary>
        public static readonly CriterionKey SCAN_STATUS = new CriterionKey("SCAN_STATUS");
        /// <summary>
        /// Constant SCAN_TYPE for CriterionKey
        /// </summary>
        public static readonly CriterionKey SCAN_TYPE = new CriterionKey("SCAN_TYPE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CriterionKey(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CriterionKey FindValue(string value)
        {
            return FindValue<CriterionKey>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CriterionKey(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DataSource.
    /// </summary>
    public class DataSource : ConstantClass
    {

        /// <summary>
        /// Constant CLOUD_TRAIL for DataSource
        /// </summary>
        public static readonly DataSource CLOUD_TRAIL = new DataSource("CLOUD_TRAIL");
        /// <summary>
        /// Constant DNS_LOGS for DataSource
        /// </summary>
        public static readonly DataSource DNS_LOGS = new DataSource("DNS_LOGS");
        /// <summary>
        /// Constant EC2_MALWARE_SCAN for DataSource
        /// </summary>
        public static readonly DataSource EC2_MALWARE_SCAN = new DataSource("EC2_MALWARE_SCAN");
        /// <summary>
        /// Constant FLOW_LOGS for DataSource
        /// </summary>
        public static readonly DataSource FLOW_LOGS = new DataSource("FLOW_LOGS");
        /// <summary>
        /// Constant KUBERNETES_AUDIT_LOGS for DataSource
        /// </summary>
        public static readonly DataSource KUBERNETES_AUDIT_LOGS = new DataSource("KUBERNETES_AUDIT_LOGS");
        /// <summary>
        /// Constant S3_LOGS for DataSource
        /// </summary>
        public static readonly DataSource S3_LOGS = new DataSource("S3_LOGS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DataSource(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DataSource FindValue(string value)
        {
            return FindValue<DataSource>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DataSource(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DataSourceStatus.
    /// </summary>
    public class DataSourceStatus : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for DataSourceStatus
        /// </summary>
        public static readonly DataSourceStatus DISABLED = new DataSourceStatus("DISABLED");
        /// <summary>
        /// Constant ENABLED for DataSourceStatus
        /// </summary>
        public static readonly DataSourceStatus ENABLED = new DataSourceStatus("ENABLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DataSourceStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DataSourceStatus FindValue(string value)
        {
            return FindValue<DataSourceStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DataSourceStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DestinationType.
    /// </summary>
    public class DestinationType : ConstantClass
    {

        /// <summary>
        /// Constant S3 for DestinationType
        /// </summary>
        public static readonly DestinationType S3 = new DestinationType("S3");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DestinationType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DestinationType FindValue(string value)
        {
            return FindValue<DestinationType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DestinationType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DetectorFeature.
    /// </summary>
    public class DetectorFeature : ConstantClass
    {

        /// <summary>
        /// Constant EBS_MALWARE_PROTECTION for DetectorFeature
        /// </summary>
        public static readonly DetectorFeature EBS_MALWARE_PROTECTION = new DetectorFeature("EBS_MALWARE_PROTECTION");
        /// <summary>
        /// Constant EKS_AUDIT_LOGS for DetectorFeature
        /// </summary>
        public static readonly DetectorFeature EKS_AUDIT_LOGS = new DetectorFeature("EKS_AUDIT_LOGS");
        /// <summary>
        /// Constant EKS_RUNTIME_MONITORING for DetectorFeature
        /// </summary>
        public static readonly DetectorFeature EKS_RUNTIME_MONITORING = new DetectorFeature("EKS_RUNTIME_MONITORING");
        /// <summary>
        /// Constant LAMBDA_NETWORK_LOGS for DetectorFeature
        /// </summary>
        public static readonly DetectorFeature LAMBDA_NETWORK_LOGS = new DetectorFeature("LAMBDA_NETWORK_LOGS");
        /// <summary>
        /// Constant RDS_LOGIN_EVENTS for DetectorFeature
        /// </summary>
        public static readonly DetectorFeature RDS_LOGIN_EVENTS = new DetectorFeature("RDS_LOGIN_EVENTS");
        /// <summary>
        /// Constant RUNTIME_MONITORING for DetectorFeature
        /// </summary>
        public static readonly DetectorFeature RUNTIME_MONITORING = new DetectorFeature("RUNTIME_MONITORING");
        /// <summary>
        /// Constant S3_DATA_EVENTS for DetectorFeature
        /// </summary>
        public static readonly DetectorFeature S3_DATA_EVENTS = new DetectorFeature("S3_DATA_EVENTS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DetectorFeature(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DetectorFeature FindValue(string value)
        {
            return FindValue<DetectorFeature>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DetectorFeature(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DetectorFeatureResult.
    /// </summary>
    public class DetectorFeatureResult : ConstantClass
    {

        /// <summary>
        /// Constant CLOUD_TRAIL for DetectorFeatureResult
        /// </summary>
        public static readonly DetectorFeatureResult CLOUD_TRAIL = new DetectorFeatureResult("CLOUD_TRAIL");
        /// <summary>
        /// Constant DNS_LOGS for DetectorFeatureResult
        /// </summary>
        public static readonly DetectorFeatureResult DNS_LOGS = new DetectorFeatureResult("DNS_LOGS");
        /// <summary>
        /// Constant EBS_MALWARE_PROTECTION for DetectorFeatureResult
        /// </summary>
        public static readonly DetectorFeatureResult EBS_MALWARE_PROTECTION = new DetectorFeatureResult("EBS_MALWARE_PROTECTION");
        /// <summary>
        /// Constant EKS_AUDIT_LOGS for DetectorFeatureResult
        /// </summary>
        public static readonly DetectorFeatureResult EKS_AUDIT_LOGS = new DetectorFeatureResult("EKS_AUDIT_LOGS");
        /// <summary>
        /// Constant EKS_RUNTIME_MONITORING for DetectorFeatureResult
        /// </summary>
        public static readonly DetectorFeatureResult EKS_RUNTIME_MONITORING = new DetectorFeatureResult("EKS_RUNTIME_MONITORING");
        /// <summary>
        /// Constant FLOW_LOGS for DetectorFeatureResult
        /// </summary>
        public static readonly DetectorFeatureResult FLOW_LOGS = new DetectorFeatureResult("FLOW_LOGS");
        /// <summary>
        /// Constant LAMBDA_NETWORK_LOGS for DetectorFeatureResult
        /// </summary>
        public static readonly DetectorFeatureResult LAMBDA_NETWORK_LOGS = new DetectorFeatureResult("LAMBDA_NETWORK_LOGS");
        /// <summary>
        /// Constant RDS_LOGIN_EVENTS for DetectorFeatureResult
        /// </summary>
        public static readonly DetectorFeatureResult RDS_LOGIN_EVENTS = new DetectorFeatureResult("RDS_LOGIN_EVENTS");
        /// <summary>
        /// Constant RUNTIME_MONITORING for DetectorFeatureResult
        /// </summary>
        public static readonly DetectorFeatureResult RUNTIME_MONITORING = new DetectorFeatureResult("RUNTIME_MONITORING");
        /// <summary>
        /// Constant S3_DATA_EVENTS for DetectorFeatureResult
        /// </summary>
        public static readonly DetectorFeatureResult S3_DATA_EVENTS = new DetectorFeatureResult("S3_DATA_EVENTS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DetectorFeatureResult(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DetectorFeatureResult FindValue(string value)
        {
            return FindValue<DetectorFeatureResult>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DetectorFeatureResult(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DetectorStatus.
    /// </summary>
    public class DetectorStatus : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for DetectorStatus
        /// </summary>
        public static readonly DetectorStatus DISABLED = new DetectorStatus("DISABLED");
        /// <summary>
        /// Constant ENABLED for DetectorStatus
        /// </summary>
        public static readonly DetectorStatus ENABLED = new DetectorStatus("ENABLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DetectorStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DetectorStatus FindValue(string value)
        {
            return FindValue<DetectorStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DetectorStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type EbsSnapshotPreservation.
    /// </summary>
    public class EbsSnapshotPreservation : ConstantClass
    {

        /// <summary>
        /// Constant NO_RETENTION for EbsSnapshotPreservation
        /// </summary>
        public static readonly EbsSnapshotPreservation NO_RETENTION = new EbsSnapshotPreservation("NO_RETENTION");
        /// <summary>
        /// Constant RETENTION_WITH_FINDING for EbsSnapshotPreservation
        /// </summary>
        public static readonly EbsSnapshotPreservation RETENTION_WITH_FINDING = new EbsSnapshotPreservation("RETENTION_WITH_FINDING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EbsSnapshotPreservation(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EbsSnapshotPreservation FindValue(string value)
        {
            return FindValue<EbsSnapshotPreservation>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EbsSnapshotPreservation(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type FeatureAdditionalConfiguration.
    /// </summary>
    public class FeatureAdditionalConfiguration : ConstantClass
    {

        /// <summary>
        /// Constant EC2_AGENT_MANAGEMENT for FeatureAdditionalConfiguration
        /// </summary>
        public static readonly FeatureAdditionalConfiguration EC2_AGENT_MANAGEMENT = new FeatureAdditionalConfiguration("EC2_AGENT_MANAGEMENT");
        /// <summary>
        /// Constant ECS_FARGATE_AGENT_MANAGEMENT for FeatureAdditionalConfiguration
        /// </summary>
        public static readonly FeatureAdditionalConfiguration ECS_FARGATE_AGENT_MANAGEMENT = new FeatureAdditionalConfiguration("ECS_FARGATE_AGENT_MANAGEMENT");
        /// <summary>
        /// Constant EKS_ADDON_MANAGEMENT for FeatureAdditionalConfiguration
        /// </summary>
        public static readonly FeatureAdditionalConfiguration EKS_ADDON_MANAGEMENT = new FeatureAdditionalConfiguration("EKS_ADDON_MANAGEMENT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FeatureAdditionalConfiguration(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FeatureAdditionalConfiguration FindValue(string value)
        {
            return FindValue<FeatureAdditionalConfiguration>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FeatureAdditionalConfiguration(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type FeatureStatus.
    /// </summary>
    public class FeatureStatus : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for FeatureStatus
        /// </summary>
        public static readonly FeatureStatus DISABLED = new FeatureStatus("DISABLED");
        /// <summary>
        /// Constant ENABLED for FeatureStatus
        /// </summary>
        public static readonly FeatureStatus ENABLED = new FeatureStatus("ENABLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FeatureStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FeatureStatus FindValue(string value)
        {
            return FindValue<FeatureStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FeatureStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Feedback.
    /// </summary>
    public class Feedback : ConstantClass
    {

        /// <summary>
        /// Constant NOT_USEFUL for Feedback
        /// </summary>
        public static readonly Feedback NOT_USEFUL = new Feedback("NOT_USEFUL");
        /// <summary>
        /// Constant USEFUL for Feedback
        /// </summary>
        public static readonly Feedback USEFUL = new Feedback("USEFUL");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Feedback(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Feedback FindValue(string value)
        {
            return FindValue<Feedback>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Feedback(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type FilterAction.
    /// </summary>
    public class FilterAction : ConstantClass
    {

        /// <summary>
        /// Constant ARCHIVE for FilterAction
        /// </summary>
        public static readonly FilterAction ARCHIVE = new FilterAction("ARCHIVE");
        /// <summary>
        /// Constant NOOP for FilterAction
        /// </summary>
        public static readonly FilterAction NOOP = new FilterAction("NOOP");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FilterAction(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FilterAction FindValue(string value)
        {
            return FindValue<FilterAction>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FilterAction(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type FindingPublishingFrequency.
    /// </summary>
    public class FindingPublishingFrequency : ConstantClass
    {

        /// <summary>
        /// Constant FIFTEEN_MINUTES for FindingPublishingFrequency
        /// </summary>
        public static readonly FindingPublishingFrequency FIFTEEN_MINUTES = new FindingPublishingFrequency("FIFTEEN_MINUTES");
        /// <summary>
        /// Constant ONE_HOUR for FindingPublishingFrequency
        /// </summary>
        public static readonly FindingPublishingFrequency ONE_HOUR = new FindingPublishingFrequency("ONE_HOUR");
        /// <summary>
        /// Constant SIX_HOURS for FindingPublishingFrequency
        /// </summary>
        public static readonly FindingPublishingFrequency SIX_HOURS = new FindingPublishingFrequency("SIX_HOURS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FindingPublishingFrequency(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FindingPublishingFrequency FindValue(string value)
        {
            return FindValue<FindingPublishingFrequency>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FindingPublishingFrequency(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type FindingResourceType.
    /// </summary>
    public class FindingResourceType : ConstantClass
    {

        /// <summary>
        /// Constant ACCESS_KEY for FindingResourceType
        /// </summary>
        public static readonly FindingResourceType ACCESS_KEY = new FindingResourceType("ACCESS_KEY");
        /// <summary>
        /// Constant CONTAINER for FindingResourceType
        /// </summary>
        public static readonly FindingResourceType CONTAINER = new FindingResourceType("CONTAINER");
        /// <summary>
        /// Constant EC2_INSTANCE for FindingResourceType
        /// </summary>
        public static readonly FindingResourceType EC2_INSTANCE = new FindingResourceType("EC2_INSTANCE");
        /// <summary>
        /// Constant EC2_NETWORK_INTERFACE for FindingResourceType
        /// </summary>
        public static readonly FindingResourceType EC2_NETWORK_INTERFACE = new FindingResourceType("EC2_NETWORK_INTERFACE");
        /// <summary>
        /// Constant EKS_CLUSTER for FindingResourceType
        /// </summary>
        public static readonly FindingResourceType EKS_CLUSTER = new FindingResourceType("EKS_CLUSTER");
        /// <summary>
        /// Constant KUBERNETES_WORKLOAD for FindingResourceType
        /// </summary>
        public static readonly FindingResourceType KUBERNETES_WORKLOAD = new FindingResourceType("KUBERNETES_WORKLOAD");
        /// <summary>
        /// Constant S3_BUCKET for FindingResourceType
        /// </summary>
        public static readonly FindingResourceType S3_BUCKET = new FindingResourceType("S3_BUCKET");
        /// <summary>
        /// Constant S3_OBJECT for FindingResourceType
        /// </summary>
        public static readonly FindingResourceType S3_OBJECT = new FindingResourceType("S3_OBJECT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FindingResourceType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FindingResourceType FindValue(string value)
        {
            return FindValue<FindingResourceType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FindingResourceType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type FindingStatisticType.
    /// </summary>
    public class FindingStatisticType : ConstantClass
    {

        /// <summary>
        /// Constant COUNT_BY_SEVERITY for FindingStatisticType
        /// </summary>
        public static readonly FindingStatisticType COUNT_BY_SEVERITY = new FindingStatisticType("COUNT_BY_SEVERITY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FindingStatisticType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FindingStatisticType FindValue(string value)
        {
            return FindValue<FindingStatisticType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FindingStatisticType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type FreeTrialFeatureResult.
    /// </summary>
    public class FreeTrialFeatureResult : ConstantClass
    {

        /// <summary>
        /// Constant CLOUD_TRAIL for FreeTrialFeatureResult
        /// </summary>
        public static readonly FreeTrialFeatureResult CLOUD_TRAIL = new FreeTrialFeatureResult("CLOUD_TRAIL");
        /// <summary>
        /// Constant DNS_LOGS for FreeTrialFeatureResult
        /// </summary>
        public static readonly FreeTrialFeatureResult DNS_LOGS = new FreeTrialFeatureResult("DNS_LOGS");
        /// <summary>
        /// Constant EBS_MALWARE_PROTECTION for FreeTrialFeatureResult
        /// </summary>
        public static readonly FreeTrialFeatureResult EBS_MALWARE_PROTECTION = new FreeTrialFeatureResult("EBS_MALWARE_PROTECTION");
        /// <summary>
        /// Constant EC2_RUNTIME_MONITORING for FreeTrialFeatureResult
        /// </summary>
        public static readonly FreeTrialFeatureResult EC2_RUNTIME_MONITORING = new FreeTrialFeatureResult("EC2_RUNTIME_MONITORING");
        /// <summary>
        /// Constant EKS_AUDIT_LOGS for FreeTrialFeatureResult
        /// </summary>
        public static readonly FreeTrialFeatureResult EKS_AUDIT_LOGS = new FreeTrialFeatureResult("EKS_AUDIT_LOGS");
        /// <summary>
        /// Constant EKS_RUNTIME_MONITORING for FreeTrialFeatureResult
        /// </summary>
        public static readonly FreeTrialFeatureResult EKS_RUNTIME_MONITORING = new FreeTrialFeatureResult("EKS_RUNTIME_MONITORING");
        /// <summary>
        /// Constant FARGATE_RUNTIME_MONITORING for FreeTrialFeatureResult
        /// </summary>
        public static readonly FreeTrialFeatureResult FARGATE_RUNTIME_MONITORING = new FreeTrialFeatureResult("FARGATE_RUNTIME_MONITORING");
        /// <summary>
        /// Constant FLOW_LOGS for FreeTrialFeatureResult
        /// </summary>
        public static readonly FreeTrialFeatureResult FLOW_LOGS = new FreeTrialFeatureResult("FLOW_LOGS");
        /// <summary>
        /// Constant LAMBDA_NETWORK_LOGS for FreeTrialFeatureResult
        /// </summary>
        public static readonly FreeTrialFeatureResult LAMBDA_NETWORK_LOGS = new FreeTrialFeatureResult("LAMBDA_NETWORK_LOGS");
        /// <summary>
        /// Constant RDS_LOGIN_EVENTS for FreeTrialFeatureResult
        /// </summary>
        public static readonly FreeTrialFeatureResult RDS_LOGIN_EVENTS = new FreeTrialFeatureResult("RDS_LOGIN_EVENTS");
        /// <summary>
        /// Constant S3_DATA_EVENTS for FreeTrialFeatureResult
        /// </summary>
        public static readonly FreeTrialFeatureResult S3_DATA_EVENTS = new FreeTrialFeatureResult("S3_DATA_EVENTS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FreeTrialFeatureResult(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FreeTrialFeatureResult FindValue(string value)
        {
            return FindValue<FreeTrialFeatureResult>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FreeTrialFeatureResult(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type GroupByType.
    /// </summary>
    public class GroupByType : ConstantClass
    {

        /// <summary>
        /// Constant ACCOUNT for GroupByType
        /// </summary>
        public static readonly GroupByType ACCOUNT = new GroupByType("ACCOUNT");
        /// <summary>
        /// Constant DATE for GroupByType
        /// </summary>
        public static readonly GroupByType DATE = new GroupByType("DATE");
        /// <summary>
        /// Constant FINDING_TYPE for GroupByType
        /// </summary>
        public static readonly GroupByType FINDING_TYPE = new GroupByType("FINDING_TYPE");
        /// <summary>
        /// Constant RESOURCE for GroupByType
        /// </summary>
        public static readonly GroupByType RESOURCE = new GroupByType("RESOURCE");
        /// <summary>
        /// Constant SEVERITY for GroupByType
        /// </summary>
        public static readonly GroupByType SEVERITY = new GroupByType("SEVERITY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public GroupByType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static GroupByType FindValue(string value)
        {
            return FindValue<GroupByType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator GroupByType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type IndicatorType.
    /// </summary>
    public class IndicatorType : ConstantClass
    {

        /// <summary>
        /// Constant ATTACK_TACTIC for IndicatorType
        /// </summary>
        public static readonly IndicatorType ATTACK_TACTIC = new IndicatorType("ATTACK_TACTIC");
        /// <summary>
        /// Constant ATTACK_TECHNIQUE for IndicatorType
        /// </summary>
        public static readonly IndicatorType ATTACK_TECHNIQUE = new IndicatorType("ATTACK_TECHNIQUE");
        /// <summary>
        /// Constant CRYPTOMINING_DOMAIN for IndicatorType
        /// </summary>
        public static readonly IndicatorType CRYPTOMINING_DOMAIN = new IndicatorType("CRYPTOMINING_DOMAIN");
        /// <summary>
        /// Constant CRYPTOMINING_IP for IndicatorType
        /// </summary>
        public static readonly IndicatorType CRYPTOMINING_IP = new IndicatorType("CRYPTOMINING_IP");
        /// <summary>
        /// Constant CRYPTOMINING_PROCESS for IndicatorType
        /// </summary>
        public static readonly IndicatorType CRYPTOMINING_PROCESS = new IndicatorType("CRYPTOMINING_PROCESS");
        /// <summary>
        /// Constant HIGH_RISK_API for IndicatorType
        /// </summary>
        public static readonly IndicatorType HIGH_RISK_API = new IndicatorType("HIGH_RISK_API");
        /// <summary>
        /// Constant MALICIOUS_DOMAIN for IndicatorType
        /// </summary>
        public static readonly IndicatorType MALICIOUS_DOMAIN = new IndicatorType("MALICIOUS_DOMAIN");
        /// <summary>
        /// Constant MALICIOUS_IP for IndicatorType
        /// </summary>
        public static readonly IndicatorType MALICIOUS_IP = new IndicatorType("MALICIOUS_IP");
        /// <summary>
        /// Constant MALICIOUS_PROCESS for IndicatorType
        /// </summary>
        public static readonly IndicatorType MALICIOUS_PROCESS = new IndicatorType("MALICIOUS_PROCESS");
        /// <summary>
        /// Constant SUSPICIOUS_NETWORK for IndicatorType
        /// </summary>
        public static readonly IndicatorType SUSPICIOUS_NETWORK = new IndicatorType("SUSPICIOUS_NETWORK");
        /// <summary>
        /// Constant SUSPICIOUS_PROCESS for IndicatorType
        /// </summary>
        public static readonly IndicatorType SUSPICIOUS_PROCESS = new IndicatorType("SUSPICIOUS_PROCESS");
        /// <summary>
        /// Constant SUSPICIOUS_USER_AGENT for IndicatorType
        /// </summary>
        public static readonly IndicatorType SUSPICIOUS_USER_AGENT = new IndicatorType("SUSPICIOUS_USER_AGENT");
        /// <summary>
        /// Constant TOR_IP for IndicatorType
        /// </summary>
        public static readonly IndicatorType TOR_IP = new IndicatorType("TOR_IP");
        /// <summary>
        /// Constant UNUSUAL_API_FOR_ACCOUNT for IndicatorType
        /// </summary>
        public static readonly IndicatorType UNUSUAL_API_FOR_ACCOUNT = new IndicatorType("UNUSUAL_API_FOR_ACCOUNT");
        /// <summary>
        /// Constant UNUSUAL_ASN_FOR_ACCOUNT for IndicatorType
        /// </summary>
        public static readonly IndicatorType UNUSUAL_ASN_FOR_ACCOUNT = new IndicatorType("UNUSUAL_ASN_FOR_ACCOUNT");
        /// <summary>
        /// Constant UNUSUAL_ASN_FOR_USER for IndicatorType
        /// </summary>
        public static readonly IndicatorType UNUSUAL_ASN_FOR_USER = new IndicatorType("UNUSUAL_ASN_FOR_USER");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public IndicatorType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static IndicatorType FindValue(string value)
        {
            return FindValue<IndicatorType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator IndicatorType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type IpSetFormat.
    /// </summary>
    public class IpSetFormat : ConstantClass
    {

        /// <summary>
        /// Constant ALIEN_VAULT for IpSetFormat
        /// </summary>
        public static readonly IpSetFormat ALIEN_VAULT = new IpSetFormat("ALIEN_VAULT");
        /// <summary>
        /// Constant FIRE_EYE for IpSetFormat
        /// </summary>
        public static readonly IpSetFormat FIRE_EYE = new IpSetFormat("FIRE_EYE");
        /// <summary>
        /// Constant OTX_CSV for IpSetFormat
        /// </summary>
        public static readonly IpSetFormat OTX_CSV = new IpSetFormat("OTX_CSV");
        /// <summary>
        /// Constant PROOF_POINT for IpSetFormat
        /// </summary>
        public static readonly IpSetFormat PROOF_POINT = new IpSetFormat("PROOF_POINT");
        /// <summary>
        /// Constant STIX for IpSetFormat
        /// </summary>
        public static readonly IpSetFormat STIX = new IpSetFormat("STIX");
        /// <summary>
        /// Constant TXT for IpSetFormat
        /// </summary>
        public static readonly IpSetFormat TXT = new IpSetFormat("TXT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public IpSetFormat(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static IpSetFormat FindValue(string value)
        {
            return FindValue<IpSetFormat>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator IpSetFormat(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type IpSetStatus.
    /// </summary>
    public class IpSetStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVATING for IpSetStatus
        /// </summary>
        public static readonly IpSetStatus ACTIVATING = new IpSetStatus("ACTIVATING");
        /// <summary>
        /// Constant ACTIVE for IpSetStatus
        /// </summary>
        public static readonly IpSetStatus ACTIVE = new IpSetStatus("ACTIVE");
        /// <summary>
        /// Constant DEACTIVATING for IpSetStatus
        /// </summary>
        public static readonly IpSetStatus DEACTIVATING = new IpSetStatus("DEACTIVATING");
        /// <summary>
        /// Constant DELETE_PENDING for IpSetStatus
        /// </summary>
        public static readonly IpSetStatus DELETE_PENDING = new IpSetStatus("DELETE_PENDING");
        /// <summary>
        /// Constant DELETED for IpSetStatus
        /// </summary>
        public static readonly IpSetStatus DELETED = new IpSetStatus("DELETED");
        /// <summary>
        /// Constant ERROR for IpSetStatus
        /// </summary>
        public static readonly IpSetStatus ERROR = new IpSetStatus("ERROR");
        /// <summary>
        /// Constant INACTIVE for IpSetStatus
        /// </summary>
        public static readonly IpSetStatus INACTIVE = new IpSetStatus("INACTIVE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public IpSetStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static IpSetStatus FindValue(string value)
        {
            return FindValue<IpSetStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator IpSetStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type KubernetesResourcesTypes.
    /// </summary>
    public class KubernetesResourcesTypes : ConstantClass
    {

        /// <summary>
        /// Constant CRONJOBS for KubernetesResourcesTypes
        /// </summary>
        public static readonly KubernetesResourcesTypes CRONJOBS = new KubernetesResourcesTypes("CRONJOBS");
        /// <summary>
        /// Constant DAEMONSETS for KubernetesResourcesTypes
        /// </summary>
        public static readonly KubernetesResourcesTypes DAEMONSETS = new KubernetesResourcesTypes("DAEMONSETS");
        /// <summary>
        /// Constant DEPLOYMENTS for KubernetesResourcesTypes
        /// </summary>
        public static readonly KubernetesResourcesTypes DEPLOYMENTS = new KubernetesResourcesTypes("DEPLOYMENTS");
        /// <summary>
        /// Constant JOBS for KubernetesResourcesTypes
        /// </summary>
        public static readonly KubernetesResourcesTypes JOBS = new KubernetesResourcesTypes("JOBS");
        /// <summary>
        /// Constant PODS for KubernetesResourcesTypes
        /// </summary>
        public static readonly KubernetesResourcesTypes PODS = new KubernetesResourcesTypes("PODS");
        /// <summary>
        /// Constant REPLICASETS for KubernetesResourcesTypes
        /// </summary>
        public static readonly KubernetesResourcesTypes REPLICASETS = new KubernetesResourcesTypes("REPLICASETS");
        /// <summary>
        /// Constant REPLICATIONCONTROLLERS for KubernetesResourcesTypes
        /// </summary>
        public static readonly KubernetesResourcesTypes REPLICATIONCONTROLLERS = new KubernetesResourcesTypes("REPLICATIONCONTROLLERS");
        /// <summary>
        /// Constant STATEFULSETS for KubernetesResourcesTypes
        /// </summary>
        public static readonly KubernetesResourcesTypes STATEFULSETS = new KubernetesResourcesTypes("STATEFULSETS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public KubernetesResourcesTypes(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static KubernetesResourcesTypes FindValue(string value)
        {
            return FindValue<KubernetesResourcesTypes>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator KubernetesResourcesTypes(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type MalwareProtectionPlanStatus.
    /// </summary>
    public class MalwareProtectionPlanStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for MalwareProtectionPlanStatus
        /// </summary>
        public static readonly MalwareProtectionPlanStatus ACTIVE = new MalwareProtectionPlanStatus("ACTIVE");
        /// <summary>
        /// Constant ERROR for MalwareProtectionPlanStatus
        /// </summary>
        public static readonly MalwareProtectionPlanStatus ERROR = new MalwareProtectionPlanStatus("ERROR");
        /// <summary>
        /// Constant WARNING for MalwareProtectionPlanStatus
        /// </summary>
        public static readonly MalwareProtectionPlanStatus WARNING = new MalwareProtectionPlanStatus("WARNING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MalwareProtectionPlanStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MalwareProtectionPlanStatus FindValue(string value)
        {
            return FindValue<MalwareProtectionPlanStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MalwareProtectionPlanStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type MalwareProtectionPlanTaggingActionStatus.
    /// </summary>
    public class MalwareProtectionPlanTaggingActionStatus : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for MalwareProtectionPlanTaggingActionStatus
        /// </summary>
        public static readonly MalwareProtectionPlanTaggingActionStatus DISABLED = new MalwareProtectionPlanTaggingActionStatus("DISABLED");
        /// <summary>
        /// Constant ENABLED for MalwareProtectionPlanTaggingActionStatus
        /// </summary>
        public static readonly MalwareProtectionPlanTaggingActionStatus ENABLED = new MalwareProtectionPlanTaggingActionStatus("ENABLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MalwareProtectionPlanTaggingActionStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MalwareProtectionPlanTaggingActionStatus FindValue(string value)
        {
            return FindValue<MalwareProtectionPlanTaggingActionStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MalwareProtectionPlanTaggingActionStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ManagementType.
    /// </summary>
    public class ManagementType : ConstantClass
    {

        /// <summary>
        /// Constant AUTO_MANAGED for ManagementType
        /// </summary>
        public static readonly ManagementType AUTO_MANAGED = new ManagementType("AUTO_MANAGED");
        /// <summary>
        /// Constant DISABLED for ManagementType
        /// </summary>
        public static readonly ManagementType DISABLED = new ManagementType("DISABLED");
        /// <summary>
        /// Constant MANUAL for ManagementType
        /// </summary>
        public static readonly ManagementType MANUAL = new ManagementType("MANUAL");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ManagementType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ManagementType FindValue(string value)
        {
            return FindValue<ManagementType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ManagementType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type MfaStatus.
    /// </summary>
    public class MfaStatus : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for MfaStatus
        /// </summary>
        public static readonly MfaStatus DISABLED = new MfaStatus("DISABLED");
        /// <summary>
        /// Constant ENABLED for MfaStatus
        /// </summary>
        public static readonly MfaStatus ENABLED = new MfaStatus("ENABLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MfaStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MfaStatus FindValue(string value)
        {
            return FindValue<MfaStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MfaStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type NetworkDirection.
    /// </summary>
    public class NetworkDirection : ConstantClass
    {

        /// <summary>
        /// Constant INBOUND for NetworkDirection
        /// </summary>
        public static readonly NetworkDirection INBOUND = new NetworkDirection("INBOUND");
        /// <summary>
        /// Constant OUTBOUND for NetworkDirection
        /// </summary>
        public static readonly NetworkDirection OUTBOUND = new NetworkDirection("OUTBOUND");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public NetworkDirection(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static NetworkDirection FindValue(string value)
        {
            return FindValue<NetworkDirection>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator NetworkDirection(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type OrderBy.
    /// </summary>
    public class OrderBy : ConstantClass
    {

        /// <summary>
        /// Constant ASC for OrderBy
        /// </summary>
        public static readonly OrderBy ASC = new OrderBy("ASC");
        /// <summary>
        /// Constant DESC for OrderBy
        /// </summary>
        public static readonly OrderBy DESC = new OrderBy("DESC");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public OrderBy(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static OrderBy FindValue(string value)
        {
            return FindValue<OrderBy>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator OrderBy(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type OrgFeature.
    /// </summary>
    public class OrgFeature : ConstantClass
    {

        /// <summary>
        /// Constant EBS_MALWARE_PROTECTION for OrgFeature
        /// </summary>
        public static readonly OrgFeature EBS_MALWARE_PROTECTION = new OrgFeature("EBS_MALWARE_PROTECTION");
        /// <summary>
        /// Constant EKS_AUDIT_LOGS for OrgFeature
        /// </summary>
        public static readonly OrgFeature EKS_AUDIT_LOGS = new OrgFeature("EKS_AUDIT_LOGS");
        /// <summary>
        /// Constant EKS_RUNTIME_MONITORING for OrgFeature
        /// </summary>
        public static readonly OrgFeature EKS_RUNTIME_MONITORING = new OrgFeature("EKS_RUNTIME_MONITORING");
        /// <summary>
        /// Constant LAMBDA_NETWORK_LOGS for OrgFeature
        /// </summary>
        public static readonly OrgFeature LAMBDA_NETWORK_LOGS = new OrgFeature("LAMBDA_NETWORK_LOGS");
        /// <summary>
        /// Constant RDS_LOGIN_EVENTS for OrgFeature
        /// </summary>
        public static readonly OrgFeature RDS_LOGIN_EVENTS = new OrgFeature("RDS_LOGIN_EVENTS");
        /// <summary>
        /// Constant RUNTIME_MONITORING for OrgFeature
        /// </summary>
        public static readonly OrgFeature RUNTIME_MONITORING = new OrgFeature("RUNTIME_MONITORING");
        /// <summary>
        /// Constant S3_DATA_EVENTS for OrgFeature
        /// </summary>
        public static readonly OrgFeature S3_DATA_EVENTS = new OrgFeature("S3_DATA_EVENTS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public OrgFeature(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static OrgFeature FindValue(string value)
        {
            return FindValue<OrgFeature>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator OrgFeature(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type OrgFeatureAdditionalConfiguration.
    /// </summary>
    public class OrgFeatureAdditionalConfiguration : ConstantClass
    {

        /// <summary>
        /// Constant EC2_AGENT_MANAGEMENT for OrgFeatureAdditionalConfiguration
        /// </summary>
        public static readonly OrgFeatureAdditionalConfiguration EC2_AGENT_MANAGEMENT = new OrgFeatureAdditionalConfiguration("EC2_AGENT_MANAGEMENT");
        /// <summary>
        /// Constant ECS_FARGATE_AGENT_MANAGEMENT for OrgFeatureAdditionalConfiguration
        /// </summary>
        public static readonly OrgFeatureAdditionalConfiguration ECS_FARGATE_AGENT_MANAGEMENT = new OrgFeatureAdditionalConfiguration("ECS_FARGATE_AGENT_MANAGEMENT");
        /// <summary>
        /// Constant EKS_ADDON_MANAGEMENT for OrgFeatureAdditionalConfiguration
        /// </summary>
        public static readonly OrgFeatureAdditionalConfiguration EKS_ADDON_MANAGEMENT = new OrgFeatureAdditionalConfiguration("EKS_ADDON_MANAGEMENT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public OrgFeatureAdditionalConfiguration(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static OrgFeatureAdditionalConfiguration FindValue(string value)
        {
            return FindValue<OrgFeatureAdditionalConfiguration>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator OrgFeatureAdditionalConfiguration(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type OrgFeatureStatus.
    /// </summary>
    public class OrgFeatureStatus : ConstantClass
    {

        /// <summary>
        /// Constant ALL for OrgFeatureStatus
        /// </summary>
        public static readonly OrgFeatureStatus ALL = new OrgFeatureStatus("ALL");
        /// <summary>
        /// Constant NEW for OrgFeatureStatus
        /// </summary>
        public static readonly OrgFeatureStatus NEW = new OrgFeatureStatus("NEW");
        /// <summary>
        /// Constant NONE for OrgFeatureStatus
        /// </summary>
        public static readonly OrgFeatureStatus NONE = new OrgFeatureStatus("NONE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public OrgFeatureStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static OrgFeatureStatus FindValue(string value)
        {
            return FindValue<OrgFeatureStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator OrgFeatureStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ProfileSubtype.
    /// </summary>
    public class ProfileSubtype : ConstantClass
    {

        /// <summary>
        /// Constant FREQUENT for ProfileSubtype
        /// </summary>
        public static readonly ProfileSubtype FREQUENT = new ProfileSubtype("FREQUENT");
        /// <summary>
        /// Constant INFREQUENT for ProfileSubtype
        /// </summary>
        public static readonly ProfileSubtype INFREQUENT = new ProfileSubtype("INFREQUENT");
        /// <summary>
        /// Constant RARE for ProfileSubtype
        /// </summary>
        public static readonly ProfileSubtype RARE = new ProfileSubtype("RARE");
        /// <summary>
        /// Constant UNSEEN for ProfileSubtype
        /// </summary>
        public static readonly ProfileSubtype UNSEEN = new ProfileSubtype("UNSEEN");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ProfileSubtype(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ProfileSubtype FindValue(string value)
        {
            return FindValue<ProfileSubtype>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ProfileSubtype(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ProfileType.
    /// </summary>
    public class ProfileType : ConstantClass
    {

        /// <summary>
        /// Constant FREQUENCY for ProfileType
        /// </summary>
        public static readonly ProfileType FREQUENCY = new ProfileType("FREQUENCY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ProfileType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ProfileType FindValue(string value)
        {
            return FindValue<ProfileType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ProfileType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PublicAccessStatus.
    /// </summary>
    public class PublicAccessStatus : ConstantClass
    {

        /// <summary>
        /// Constant ALLOWED for PublicAccessStatus
        /// </summary>
        public static readonly PublicAccessStatus ALLOWED = new PublicAccessStatus("ALLOWED");
        /// <summary>
        /// Constant BLOCKED for PublicAccessStatus
        /// </summary>
        public static readonly PublicAccessStatus BLOCKED = new PublicAccessStatus("BLOCKED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PublicAccessStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PublicAccessStatus FindValue(string value)
        {
            return FindValue<PublicAccessStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PublicAccessStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PublicAclIgnoreBehavior.
    /// </summary>
    public class PublicAclIgnoreBehavior : ConstantClass
    {

        /// <summary>
        /// Constant IGNORED for PublicAclIgnoreBehavior
        /// </summary>
        public static readonly PublicAclIgnoreBehavior IGNORED = new PublicAclIgnoreBehavior("IGNORED");
        /// <summary>
        /// Constant NOT_IGNORED for PublicAclIgnoreBehavior
        /// </summary>
        public static readonly PublicAclIgnoreBehavior NOT_IGNORED = new PublicAclIgnoreBehavior("NOT_IGNORED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PublicAclIgnoreBehavior(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PublicAclIgnoreBehavior FindValue(string value)
        {
            return FindValue<PublicAclIgnoreBehavior>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PublicAclIgnoreBehavior(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PublicBucketRestrictBehavior.
    /// </summary>
    public class PublicBucketRestrictBehavior : ConstantClass
    {

        /// <summary>
        /// Constant NOT_RESTRICTED for PublicBucketRestrictBehavior
        /// </summary>
        public static readonly PublicBucketRestrictBehavior NOT_RESTRICTED = new PublicBucketRestrictBehavior("NOT_RESTRICTED");
        /// <summary>
        /// Constant RESTRICTED for PublicBucketRestrictBehavior
        /// </summary>
        public static readonly PublicBucketRestrictBehavior RESTRICTED = new PublicBucketRestrictBehavior("RESTRICTED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PublicBucketRestrictBehavior(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PublicBucketRestrictBehavior FindValue(string value)
        {
            return FindValue<PublicBucketRestrictBehavior>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PublicBucketRestrictBehavior(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PublishingStatus.
    /// </summary>
    public class PublishingStatus : ConstantClass
    {

        /// <summary>
        /// Constant PENDING_VERIFICATION for PublishingStatus
        /// </summary>
        public static readonly PublishingStatus PENDING_VERIFICATION = new PublishingStatus("PENDING_VERIFICATION");
        /// <summary>
        /// Constant PUBLISHING for PublishingStatus
        /// </summary>
        public static readonly PublishingStatus PUBLISHING = new PublishingStatus("PUBLISHING");
        /// <summary>
        /// Constant STOPPED for PublishingStatus
        /// </summary>
        public static readonly PublishingStatus STOPPED = new PublishingStatus("STOPPED");
        /// <summary>
        /// Constant UNABLE_TO_PUBLISH_FIX_DESTINATION_PROPERTY for PublishingStatus
        /// </summary>
        public static readonly PublishingStatus UNABLE_TO_PUBLISH_FIX_DESTINATION_PROPERTY = new PublishingStatus("UNABLE_TO_PUBLISH_FIX_DESTINATION_PROPERTY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PublishingStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PublishingStatus FindValue(string value)
        {
            return FindValue<PublishingStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PublishingStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ResourceType.
    /// </summary>
    public class ResourceType : ConstantClass
    {

        /// <summary>
        /// Constant EC2 for ResourceType
        /// </summary>
        public static readonly ResourceType EC2 = new ResourceType("EC2");
        /// <summary>
        /// Constant ECS for ResourceType
        /// </summary>
        public static readonly ResourceType ECS = new ResourceType("ECS");
        /// <summary>
        /// Constant EKS for ResourceType
        /// </summary>
        public static readonly ResourceType EKS = new ResourceType("EKS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ResourceType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ResourceType FindValue(string value)
        {
            return FindValue<ResourceType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ResourceType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ScanCriterionKey.
    /// </summary>
    public class ScanCriterionKey : ConstantClass
    {

        /// <summary>
        /// Constant EC2_INSTANCE_TAG for ScanCriterionKey
        /// </summary>
        public static readonly ScanCriterionKey EC2_INSTANCE_TAG = new ScanCriterionKey("EC2_INSTANCE_TAG");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ScanCriterionKey(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ScanCriterionKey FindValue(string value)
        {
            return FindValue<ScanCriterionKey>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ScanCriterionKey(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ScanResult.
    /// </summary>
    public class ScanResult : ConstantClass
    {

        /// <summary>
        /// Constant CLEAN for ScanResult
        /// </summary>
        public static readonly ScanResult CLEAN = new ScanResult("CLEAN");
        /// <summary>
        /// Constant INFECTED for ScanResult
        /// </summary>
        public static readonly ScanResult INFECTED = new ScanResult("INFECTED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ScanResult(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ScanResult FindValue(string value)
        {
            return FindValue<ScanResult>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ScanResult(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ScanStatus.
    /// </summary>
    public class ScanStatus : ConstantClass
    {

        /// <summary>
        /// Constant COMPLETED for ScanStatus
        /// </summary>
        public static readonly ScanStatus COMPLETED = new ScanStatus("COMPLETED");
        /// <summary>
        /// Constant FAILED for ScanStatus
        /// </summary>
        public static readonly ScanStatus FAILED = new ScanStatus("FAILED");
        /// <summary>
        /// Constant RUNNING for ScanStatus
        /// </summary>
        public static readonly ScanStatus RUNNING = new ScanStatus("RUNNING");
        /// <summary>
        /// Constant SKIPPED for ScanStatus
        /// </summary>
        public static readonly ScanStatus SKIPPED = new ScanStatus("SKIPPED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ScanStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ScanStatus FindValue(string value)
        {
            return FindValue<ScanStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ScanStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ScanType.
    /// </summary>
    public class ScanType : ConstantClass
    {

        /// <summary>
        /// Constant GUARDDUTY_INITIATED for ScanType
        /// </summary>
        public static readonly ScanType GUARDDUTY_INITIATED = new ScanType("GUARDDUTY_INITIATED");
        /// <summary>
        /// Constant ON_DEMAND for ScanType
        /// </summary>
        public static readonly ScanType ON_DEMAND = new ScanType("ON_DEMAND");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ScanType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ScanType FindValue(string value)
        {
            return FindValue<ScanType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ScanType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SignalType.
    /// </summary>
    public class SignalType : ConstantClass
    {

        /// <summary>
        /// Constant CLOUD_TRAIL for SignalType
        /// </summary>
        public static readonly SignalType CLOUD_TRAIL = new SignalType("CLOUD_TRAIL");
        /// <summary>
        /// Constant DNS_LOGS for SignalType
        /// </summary>
        public static readonly SignalType DNS_LOGS = new SignalType("DNS_LOGS");
        /// <summary>
        /// Constant EKS_AUDIT_LOGS for SignalType
        /// </summary>
        public static readonly SignalType EKS_AUDIT_LOGS = new SignalType("EKS_AUDIT_LOGS");
        /// <summary>
        /// Constant FINDING for SignalType
        /// </summary>
        public static readonly SignalType FINDING = new SignalType("FINDING");
        /// <summary>
        /// Constant FLOW_LOGS for SignalType
        /// </summary>
        public static readonly SignalType FLOW_LOGS = new SignalType("FLOW_LOGS");
        /// <summary>
        /// Constant RUNTIME_MONITORING for SignalType
        /// </summary>
        public static readonly SignalType RUNTIME_MONITORING = new SignalType("RUNTIME_MONITORING");
        /// <summary>
        /// Constant S3_DATA_EVENTS for SignalType
        /// </summary>
        public static readonly SignalType S3_DATA_EVENTS = new SignalType("S3_DATA_EVENTS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SignalType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SignalType FindValue(string value)
        {
            return FindValue<SignalType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SignalType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ThreatEntitySetFormat.
    /// </summary>
    public class ThreatEntitySetFormat : ConstantClass
    {

        /// <summary>
        /// Constant ALIEN_VAULT for ThreatEntitySetFormat
        /// </summary>
        public static readonly ThreatEntitySetFormat ALIEN_VAULT = new ThreatEntitySetFormat("ALIEN_VAULT");
        /// <summary>
        /// Constant FIRE_EYE for ThreatEntitySetFormat
        /// </summary>
        public static readonly ThreatEntitySetFormat FIRE_EYE = new ThreatEntitySetFormat("FIRE_EYE");
        /// <summary>
        /// Constant OTX_CSV for ThreatEntitySetFormat
        /// </summary>
        public static readonly ThreatEntitySetFormat OTX_CSV = new ThreatEntitySetFormat("OTX_CSV");
        /// <summary>
        /// Constant PROOF_POINT for ThreatEntitySetFormat
        /// </summary>
        public static readonly ThreatEntitySetFormat PROOF_POINT = new ThreatEntitySetFormat("PROOF_POINT");
        /// <summary>
        /// Constant STIX for ThreatEntitySetFormat
        /// </summary>
        public static readonly ThreatEntitySetFormat STIX = new ThreatEntitySetFormat("STIX");
        /// <summary>
        /// Constant TXT for ThreatEntitySetFormat
        /// </summary>
        public static readonly ThreatEntitySetFormat TXT = new ThreatEntitySetFormat("TXT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ThreatEntitySetFormat(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ThreatEntitySetFormat FindValue(string value)
        {
            return FindValue<ThreatEntitySetFormat>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ThreatEntitySetFormat(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ThreatEntitySetStatus.
    /// </summary>
    public class ThreatEntitySetStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVATING for ThreatEntitySetStatus
        /// </summary>
        public static readonly ThreatEntitySetStatus ACTIVATING = new ThreatEntitySetStatus("ACTIVATING");
        /// <summary>
        /// Constant ACTIVE for ThreatEntitySetStatus
        /// </summary>
        public static readonly ThreatEntitySetStatus ACTIVE = new ThreatEntitySetStatus("ACTIVE");
        /// <summary>
        /// Constant DEACTIVATING for ThreatEntitySetStatus
        /// </summary>
        public static readonly ThreatEntitySetStatus DEACTIVATING = new ThreatEntitySetStatus("DEACTIVATING");
        /// <summary>
        /// Constant DELETE_PENDING for ThreatEntitySetStatus
        /// </summary>
        public static readonly ThreatEntitySetStatus DELETE_PENDING = new ThreatEntitySetStatus("DELETE_PENDING");
        /// <summary>
        /// Constant DELETED for ThreatEntitySetStatus
        /// </summary>
        public static readonly ThreatEntitySetStatus DELETED = new ThreatEntitySetStatus("DELETED");
        /// <summary>
        /// Constant ERROR for ThreatEntitySetStatus
        /// </summary>
        public static readonly ThreatEntitySetStatus ERROR = new ThreatEntitySetStatus("ERROR");
        /// <summary>
        /// Constant INACTIVE for ThreatEntitySetStatus
        /// </summary>
        public static readonly ThreatEntitySetStatus INACTIVE = new ThreatEntitySetStatus("INACTIVE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ThreatEntitySetStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ThreatEntitySetStatus FindValue(string value)
        {
            return FindValue<ThreatEntitySetStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ThreatEntitySetStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ThreatIntelSetFormat.
    /// </summary>
    public class ThreatIntelSetFormat : ConstantClass
    {

        /// <summary>
        /// Constant ALIEN_VAULT for ThreatIntelSetFormat
        /// </summary>
        public static readonly ThreatIntelSetFormat ALIEN_VAULT = new ThreatIntelSetFormat("ALIEN_VAULT");
        /// <summary>
        /// Constant FIRE_EYE for ThreatIntelSetFormat
        /// </summary>
        public static readonly ThreatIntelSetFormat FIRE_EYE = new ThreatIntelSetFormat("FIRE_EYE");
        /// <summary>
        /// Constant OTX_CSV for ThreatIntelSetFormat
        /// </summary>
        public static readonly ThreatIntelSetFormat OTX_CSV = new ThreatIntelSetFormat("OTX_CSV");
        /// <summary>
        /// Constant PROOF_POINT for ThreatIntelSetFormat
        /// </summary>
        public static readonly ThreatIntelSetFormat PROOF_POINT = new ThreatIntelSetFormat("PROOF_POINT");
        /// <summary>
        /// Constant STIX for ThreatIntelSetFormat
        /// </summary>
        public static readonly ThreatIntelSetFormat STIX = new ThreatIntelSetFormat("STIX");
        /// <summary>
        /// Constant TXT for ThreatIntelSetFormat
        /// </summary>
        public static readonly ThreatIntelSetFormat TXT = new ThreatIntelSetFormat("TXT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ThreatIntelSetFormat(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ThreatIntelSetFormat FindValue(string value)
        {
            return FindValue<ThreatIntelSetFormat>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ThreatIntelSetFormat(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ThreatIntelSetStatus.
    /// </summary>
    public class ThreatIntelSetStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVATING for ThreatIntelSetStatus
        /// </summary>
        public static readonly ThreatIntelSetStatus ACTIVATING = new ThreatIntelSetStatus("ACTIVATING");
        /// <summary>
        /// Constant ACTIVE for ThreatIntelSetStatus
        /// </summary>
        public static readonly ThreatIntelSetStatus ACTIVE = new ThreatIntelSetStatus("ACTIVE");
        /// <summary>
        /// Constant DEACTIVATING for ThreatIntelSetStatus
        /// </summary>
        public static readonly ThreatIntelSetStatus DEACTIVATING = new ThreatIntelSetStatus("DEACTIVATING");
        /// <summary>
        /// Constant DELETE_PENDING for ThreatIntelSetStatus
        /// </summary>
        public static readonly ThreatIntelSetStatus DELETE_PENDING = new ThreatIntelSetStatus("DELETE_PENDING");
        /// <summary>
        /// Constant DELETED for ThreatIntelSetStatus
        /// </summary>
        public static readonly ThreatIntelSetStatus DELETED = new ThreatIntelSetStatus("DELETED");
        /// <summary>
        /// Constant ERROR for ThreatIntelSetStatus
        /// </summary>
        public static readonly ThreatIntelSetStatus ERROR = new ThreatIntelSetStatus("ERROR");
        /// <summary>
        /// Constant INACTIVE for ThreatIntelSetStatus
        /// </summary>
        public static readonly ThreatIntelSetStatus INACTIVE = new ThreatIntelSetStatus("INACTIVE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ThreatIntelSetStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ThreatIntelSetStatus FindValue(string value)
        {
            return FindValue<ThreatIntelSetStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ThreatIntelSetStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TrustedEntitySetFormat.
    /// </summary>
    public class TrustedEntitySetFormat : ConstantClass
    {

        /// <summary>
        /// Constant ALIEN_VAULT for TrustedEntitySetFormat
        /// </summary>
        public static readonly TrustedEntitySetFormat ALIEN_VAULT = new TrustedEntitySetFormat("ALIEN_VAULT");
        /// <summary>
        /// Constant FIRE_EYE for TrustedEntitySetFormat
        /// </summary>
        public static readonly TrustedEntitySetFormat FIRE_EYE = new TrustedEntitySetFormat("FIRE_EYE");
        /// <summary>
        /// Constant OTX_CSV for TrustedEntitySetFormat
        /// </summary>
        public static readonly TrustedEntitySetFormat OTX_CSV = new TrustedEntitySetFormat("OTX_CSV");
        /// <summary>
        /// Constant PROOF_POINT for TrustedEntitySetFormat
        /// </summary>
        public static readonly TrustedEntitySetFormat PROOF_POINT = new TrustedEntitySetFormat("PROOF_POINT");
        /// <summary>
        /// Constant STIX for TrustedEntitySetFormat
        /// </summary>
        public static readonly TrustedEntitySetFormat STIX = new TrustedEntitySetFormat("STIX");
        /// <summary>
        /// Constant TXT for TrustedEntitySetFormat
        /// </summary>
        public static readonly TrustedEntitySetFormat TXT = new TrustedEntitySetFormat("TXT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TrustedEntitySetFormat(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TrustedEntitySetFormat FindValue(string value)
        {
            return FindValue<TrustedEntitySetFormat>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TrustedEntitySetFormat(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TrustedEntitySetStatus.
    /// </summary>
    public class TrustedEntitySetStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVATING for TrustedEntitySetStatus
        /// </summary>
        public static readonly TrustedEntitySetStatus ACTIVATING = new TrustedEntitySetStatus("ACTIVATING");
        /// <summary>
        /// Constant ACTIVE for TrustedEntitySetStatus
        /// </summary>
        public static readonly TrustedEntitySetStatus ACTIVE = new TrustedEntitySetStatus("ACTIVE");
        /// <summary>
        /// Constant DEACTIVATING for TrustedEntitySetStatus
        /// </summary>
        public static readonly TrustedEntitySetStatus DEACTIVATING = new TrustedEntitySetStatus("DEACTIVATING");
        /// <summary>
        /// Constant DELETE_PENDING for TrustedEntitySetStatus
        /// </summary>
        public static readonly TrustedEntitySetStatus DELETE_PENDING = new TrustedEntitySetStatus("DELETE_PENDING");
        /// <summary>
        /// Constant DELETED for TrustedEntitySetStatus
        /// </summary>
        public static readonly TrustedEntitySetStatus DELETED = new TrustedEntitySetStatus("DELETED");
        /// <summary>
        /// Constant ERROR for TrustedEntitySetStatus
        /// </summary>
        public static readonly TrustedEntitySetStatus ERROR = new TrustedEntitySetStatus("ERROR");
        /// <summary>
        /// Constant INACTIVE for TrustedEntitySetStatus
        /// </summary>
        public static readonly TrustedEntitySetStatus INACTIVE = new TrustedEntitySetStatus("INACTIVE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TrustedEntitySetStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TrustedEntitySetStatus FindValue(string value)
        {
            return FindValue<TrustedEntitySetStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TrustedEntitySetStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type UsageFeature.
    /// </summary>
    public class UsageFeature : ConstantClass
    {

        /// <summary>
        /// Constant CLOUD_TRAIL for UsageFeature
        /// </summary>
        public static readonly UsageFeature CLOUD_TRAIL = new UsageFeature("CLOUD_TRAIL");
        /// <summary>
        /// Constant DNS_LOGS for UsageFeature
        /// </summary>
        public static readonly UsageFeature DNS_LOGS = new UsageFeature("DNS_LOGS");
        /// <summary>
        /// Constant EBS_MALWARE_PROTECTION for UsageFeature
        /// </summary>
        public static readonly UsageFeature EBS_MALWARE_PROTECTION = new UsageFeature("EBS_MALWARE_PROTECTION");
        /// <summary>
        /// Constant EC2_RUNTIME_MONITORING for UsageFeature
        /// </summary>
        public static readonly UsageFeature EC2_RUNTIME_MONITORING = new UsageFeature("EC2_RUNTIME_MONITORING");
        /// <summary>
        /// Constant EKS_AUDIT_LOGS for UsageFeature
        /// </summary>
        public static readonly UsageFeature EKS_AUDIT_LOGS = new UsageFeature("EKS_AUDIT_LOGS");
        /// <summary>
        /// Constant EKS_RUNTIME_MONITORING for UsageFeature
        /// </summary>
        public static readonly UsageFeature EKS_RUNTIME_MONITORING = new UsageFeature("EKS_RUNTIME_MONITORING");
        /// <summary>
        /// Constant FARGATE_RUNTIME_MONITORING for UsageFeature
        /// </summary>
        public static readonly UsageFeature FARGATE_RUNTIME_MONITORING = new UsageFeature("FARGATE_RUNTIME_MONITORING");
        /// <summary>
        /// Constant FLOW_LOGS for UsageFeature
        /// </summary>
        public static readonly UsageFeature FLOW_LOGS = new UsageFeature("FLOW_LOGS");
        /// <summary>
        /// Constant LAMBDA_NETWORK_LOGS for UsageFeature
        /// </summary>
        public static readonly UsageFeature LAMBDA_NETWORK_LOGS = new UsageFeature("LAMBDA_NETWORK_LOGS");
        /// <summary>
        /// Constant RDS_DBI_PROTECTION_PROVISIONED for UsageFeature
        /// </summary>
        public static readonly UsageFeature RDS_DBI_PROTECTION_PROVISIONED = new UsageFeature("RDS_DBI_PROTECTION_PROVISIONED");
        /// <summary>
        /// Constant RDS_DBI_PROTECTION_SERVERLESS for UsageFeature
        /// </summary>
        public static readonly UsageFeature RDS_DBI_PROTECTION_SERVERLESS = new UsageFeature("RDS_DBI_PROTECTION_SERVERLESS");
        /// <summary>
        /// Constant RDS_LOGIN_EVENTS for UsageFeature
        /// </summary>
        public static readonly UsageFeature RDS_LOGIN_EVENTS = new UsageFeature("RDS_LOGIN_EVENTS");
        /// <summary>
        /// Constant S3_DATA_EVENTS for UsageFeature
        /// </summary>
        public static readonly UsageFeature S3_DATA_EVENTS = new UsageFeature("S3_DATA_EVENTS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public UsageFeature(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static UsageFeature FindValue(string value)
        {
            return FindValue<UsageFeature>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator UsageFeature(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type UsageStatisticType.
    /// </summary>
    public class UsageStatisticType : ConstantClass
    {

        /// <summary>
        /// Constant SUM_BY_ACCOUNT for UsageStatisticType
        /// </summary>
        public static readonly UsageStatisticType SUM_BY_ACCOUNT = new UsageStatisticType("SUM_BY_ACCOUNT");
        /// <summary>
        /// Constant SUM_BY_DATA_SOURCE for UsageStatisticType
        /// </summary>
        public static readonly UsageStatisticType SUM_BY_DATA_SOURCE = new UsageStatisticType("SUM_BY_DATA_SOURCE");
        /// <summary>
        /// Constant SUM_BY_FEATURES for UsageStatisticType
        /// </summary>
        public static readonly UsageStatisticType SUM_BY_FEATURES = new UsageStatisticType("SUM_BY_FEATURES");
        /// <summary>
        /// Constant SUM_BY_RESOURCE for UsageStatisticType
        /// </summary>
        public static readonly UsageStatisticType SUM_BY_RESOURCE = new UsageStatisticType("SUM_BY_RESOURCE");
        /// <summary>
        /// Constant TOP_ACCOUNTS_BY_FEATURE for UsageStatisticType
        /// </summary>
        public static readonly UsageStatisticType TOP_ACCOUNTS_BY_FEATURE = new UsageStatisticType("TOP_ACCOUNTS_BY_FEATURE");
        /// <summary>
        /// Constant TOP_RESOURCES for UsageStatisticType
        /// </summary>
        public static readonly UsageStatisticType TOP_RESOURCES = new UsageStatisticType("TOP_RESOURCES");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public UsageStatisticType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static UsageStatisticType FindValue(string value)
        {
            return FindValue<UsageStatisticType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator UsageStatisticType(string value)
        {
            return FindValue(value);
        }
    }

}