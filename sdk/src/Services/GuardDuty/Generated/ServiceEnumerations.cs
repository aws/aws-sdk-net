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
        /// Constant RDS_LOGIN_EVENTS for DetectorFeature
        /// </summary>
        public static readonly DetectorFeature RDS_LOGIN_EVENTS = new DetectorFeature("RDS_LOGIN_EVENTS");
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
        /// Constant FLOW_LOGS for DetectorFeatureResult
        /// </summary>
        public static readonly DetectorFeatureResult FLOW_LOGS = new DetectorFeatureResult("FLOW_LOGS");
        /// <summary>
        /// Constant RDS_LOGIN_EVENTS for DetectorFeatureResult
        /// </summary>
        public static readonly DetectorFeatureResult RDS_LOGIN_EVENTS = new DetectorFeatureResult("RDS_LOGIN_EVENTS");
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
        /// Constant EKS_AUDIT_LOGS for FreeTrialFeatureResult
        /// </summary>
        public static readonly FreeTrialFeatureResult EKS_AUDIT_LOGS = new FreeTrialFeatureResult("EKS_AUDIT_LOGS");
        /// <summary>
        /// Constant FLOW_LOGS for FreeTrialFeatureResult
        /// </summary>
        public static readonly FreeTrialFeatureResult FLOW_LOGS = new FreeTrialFeatureResult("FLOW_LOGS");
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
        /// Constant RDS_LOGIN_EVENTS for OrgFeature
        /// </summary>
        public static readonly OrgFeature RDS_LOGIN_EVENTS = new OrgFeature("RDS_LOGIN_EVENTS");
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
    /// Constants used for properties of type OrgFeatureStatus.
    /// </summary>
    public class OrgFeatureStatus : ConstantClass
    {

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
        /// Constant EKS_AUDIT_LOGS for UsageFeature
        /// </summary>
        public static readonly UsageFeature EKS_AUDIT_LOGS = new UsageFeature("EKS_AUDIT_LOGS");
        /// <summary>
        /// Constant EKS_RUNTIME_MONITORING for UsageFeature
        /// </summary>
        public static readonly UsageFeature EKS_RUNTIME_MONITORING = new UsageFeature("EKS_RUNTIME_MONITORING");
        /// <summary>
        /// Constant FLOW_LOGS for UsageFeature
        /// </summary>
        public static readonly UsageFeature FLOW_LOGS = new UsageFeature("FLOW_LOGS");
        /// <summary>
        /// Constant LAMBDA_NETWORK_LOGS for UsageFeature
        /// </summary>
        public static readonly UsageFeature LAMBDA_NETWORK_LOGS = new UsageFeature("LAMBDA_NETWORK_LOGS");
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