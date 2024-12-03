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
 * Do not modify this file. This file is generated from the application-insights-2018-11-25.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.ApplicationInsights
{

    /// <summary>
    /// Constants used for properties of type CloudWatchEventSource.
    /// </summary>
    public class CloudWatchEventSource : ConstantClass
    {

        /// <summary>
        /// Constant CODE_DEPLOY for CloudWatchEventSource
        /// </summary>
        public static readonly CloudWatchEventSource CODE_DEPLOY = new CloudWatchEventSource("CODE_DEPLOY");
        /// <summary>
        /// Constant EC2 for CloudWatchEventSource
        /// </summary>
        public static readonly CloudWatchEventSource EC2 = new CloudWatchEventSource("EC2");
        /// <summary>
        /// Constant HEALTH for CloudWatchEventSource
        /// </summary>
        public static readonly CloudWatchEventSource HEALTH = new CloudWatchEventSource("HEALTH");
        /// <summary>
        /// Constant RDS for CloudWatchEventSource
        /// </summary>
        public static readonly CloudWatchEventSource RDS = new CloudWatchEventSource("RDS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CloudWatchEventSource(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CloudWatchEventSource FindValue(string value)
        {
            return FindValue<CloudWatchEventSource>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CloudWatchEventSource(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ConfigurationEventResourceType.
    /// </summary>
    public class ConfigurationEventResourceType : ConstantClass
    {

        /// <summary>
        /// Constant CLOUDFORMATION for ConfigurationEventResourceType
        /// </summary>
        public static readonly ConfigurationEventResourceType CLOUDFORMATION = new ConfigurationEventResourceType("CLOUDFORMATION");
        /// <summary>
        /// Constant CLOUDWATCH_ALARM for ConfigurationEventResourceType
        /// </summary>
        public static readonly ConfigurationEventResourceType CLOUDWATCH_ALARM = new ConfigurationEventResourceType("CLOUDWATCH_ALARM");
        /// <summary>
        /// Constant CLOUDWATCH_LOG for ConfigurationEventResourceType
        /// </summary>
        public static readonly ConfigurationEventResourceType CLOUDWATCH_LOG = new ConfigurationEventResourceType("CLOUDWATCH_LOG");
        /// <summary>
        /// Constant SSM_ASSOCIATION for ConfigurationEventResourceType
        /// </summary>
        public static readonly ConfigurationEventResourceType SSM_ASSOCIATION = new ConfigurationEventResourceType("SSM_ASSOCIATION");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ConfigurationEventResourceType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ConfigurationEventResourceType FindValue(string value)
        {
            return FindValue<ConfigurationEventResourceType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ConfigurationEventResourceType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ConfigurationEventStatus.
    /// </summary>
    public class ConfigurationEventStatus : ConstantClass
    {

        /// <summary>
        /// Constant ERROR for ConfigurationEventStatus
        /// </summary>
        public static readonly ConfigurationEventStatus ERROR = new ConfigurationEventStatus("ERROR");
        /// <summary>
        /// Constant INFO for ConfigurationEventStatus
        /// </summary>
        public static readonly ConfigurationEventStatus INFO = new ConfigurationEventStatus("INFO");
        /// <summary>
        /// Constant WARN for ConfigurationEventStatus
        /// </summary>
        public static readonly ConfigurationEventStatus WARN = new ConfigurationEventStatus("WARN");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ConfigurationEventStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ConfigurationEventStatus FindValue(string value)
        {
            return FindValue<ConfigurationEventStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ConfigurationEventStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DiscoveryType.
    /// </summary>
    public class DiscoveryType : ConstantClass
    {

        /// <summary>
        /// Constant ACCOUNT_BASED for DiscoveryType
        /// </summary>
        public static readonly DiscoveryType ACCOUNT_BASED = new DiscoveryType("ACCOUNT_BASED");
        /// <summary>
        /// Constant RESOURCE_GROUP_BASED for DiscoveryType
        /// </summary>
        public static readonly DiscoveryType RESOURCE_GROUP_BASED = new DiscoveryType("RESOURCE_GROUP_BASED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DiscoveryType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DiscoveryType FindValue(string value)
        {
            return FindValue<DiscoveryType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DiscoveryType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type FeedbackKey.
    /// </summary>
    public class FeedbackKey : ConstantClass
    {

        /// <summary>
        /// Constant INSIGHTS_FEEDBACK for FeedbackKey
        /// </summary>
        public static readonly FeedbackKey INSIGHTS_FEEDBACK = new FeedbackKey("INSIGHTS_FEEDBACK");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FeedbackKey(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FeedbackKey FindValue(string value)
        {
            return FindValue<FeedbackKey>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FeedbackKey(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type FeedbackValue.
    /// </summary>
    public class FeedbackValue : ConstantClass
    {

        /// <summary>
        /// Constant NOT_SPECIFIED for FeedbackValue
        /// </summary>
        public static readonly FeedbackValue NOT_SPECIFIED = new FeedbackValue("NOT_SPECIFIED");
        /// <summary>
        /// Constant NOT_USEFUL for FeedbackValue
        /// </summary>
        public static readonly FeedbackValue NOT_USEFUL = new FeedbackValue("NOT_USEFUL");
        /// <summary>
        /// Constant USEFUL for FeedbackValue
        /// </summary>
        public static readonly FeedbackValue USEFUL = new FeedbackValue("USEFUL");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FeedbackValue(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FeedbackValue FindValue(string value)
        {
            return FindValue<FeedbackValue>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FeedbackValue(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type GroupingType.
    /// </summary>
    public class GroupingType : ConstantClass
    {

        /// <summary>
        /// Constant ACCOUNT_BASED for GroupingType
        /// </summary>
        public static readonly GroupingType ACCOUNT_BASED = new GroupingType("ACCOUNT_BASED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public GroupingType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static GroupingType FindValue(string value)
        {
            return FindValue<GroupingType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator GroupingType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type LogFilter.
    /// </summary>
    public class LogFilter : ConstantClass
    {

        /// <summary>
        /// Constant ERROR for LogFilter
        /// </summary>
        public static readonly LogFilter ERROR = new LogFilter("ERROR");
        /// <summary>
        /// Constant INFO for LogFilter
        /// </summary>
        public static readonly LogFilter INFO = new LogFilter("INFO");
        /// <summary>
        /// Constant WARN for LogFilter
        /// </summary>
        public static readonly LogFilter WARN = new LogFilter("WARN");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public LogFilter(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LogFilter FindValue(string value)
        {
            return FindValue<LogFilter>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator LogFilter(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type OsType.
    /// </summary>
    public class OsType : ConstantClass
    {

        /// <summary>
        /// Constant LINUX for OsType
        /// </summary>
        public static readonly OsType LINUX = new OsType("LINUX");
        /// <summary>
        /// Constant WINDOWS for OsType
        /// </summary>
        public static readonly OsType WINDOWS = new OsType("WINDOWS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public OsType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static OsType FindValue(string value)
        {
            return FindValue<OsType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator OsType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RecommendationType.
    /// </summary>
    public class RecommendationType : ConstantClass
    {

        /// <summary>
        /// Constant ALL for RecommendationType
        /// </summary>
        public static readonly RecommendationType ALL = new RecommendationType("ALL");
        /// <summary>
        /// Constant INFRA_ONLY for RecommendationType
        /// </summary>
        public static readonly RecommendationType INFRA_ONLY = new RecommendationType("INFRA_ONLY");
        /// <summary>
        /// Constant WORKLOAD_ONLY for RecommendationType
        /// </summary>
        public static readonly RecommendationType WORKLOAD_ONLY = new RecommendationType("WORKLOAD_ONLY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RecommendationType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RecommendationType FindValue(string value)
        {
            return FindValue<RecommendationType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RecommendationType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ResolutionMethod.
    /// </summary>
    public class ResolutionMethod : ConstantClass
    {

        /// <summary>
        /// Constant AUTOMATIC for ResolutionMethod
        /// </summary>
        public static readonly ResolutionMethod AUTOMATIC = new ResolutionMethod("AUTOMATIC");
        /// <summary>
        /// Constant MANUAL for ResolutionMethod
        /// </summary>
        public static readonly ResolutionMethod MANUAL = new ResolutionMethod("MANUAL");
        /// <summary>
        /// Constant UNRESOLVED for ResolutionMethod
        /// </summary>
        public static readonly ResolutionMethod UNRESOLVED = new ResolutionMethod("UNRESOLVED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ResolutionMethod(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ResolutionMethod FindValue(string value)
        {
            return FindValue<ResolutionMethod>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ResolutionMethod(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SeverityLevel.
    /// </summary>
    public class SeverityLevel : ConstantClass
    {

        /// <summary>
        /// Constant High for SeverityLevel
        /// </summary>
        public static readonly SeverityLevel High = new SeverityLevel("High");
        /// <summary>
        /// Constant Informative for SeverityLevel
        /// </summary>
        public static readonly SeverityLevel Informative = new SeverityLevel("Informative");
        /// <summary>
        /// Constant Low for SeverityLevel
        /// </summary>
        public static readonly SeverityLevel Low = new SeverityLevel("Low");
        /// <summary>
        /// Constant Medium for SeverityLevel
        /// </summary>
        public static readonly SeverityLevel Medium = new SeverityLevel("Medium");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SeverityLevel(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SeverityLevel FindValue(string value)
        {
            return FindValue<SeverityLevel>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SeverityLevel(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Status.
    /// </summary>
    public class Status : ConstantClass
    {

        /// <summary>
        /// Constant IGNORE for Status
        /// </summary>
        public static readonly Status IGNORE = new Status("IGNORE");
        /// <summary>
        /// Constant PENDING for Status
        /// </summary>
        public static readonly Status PENDING = new Status("PENDING");
        /// <summary>
        /// Constant RECOVERING for Status
        /// </summary>
        public static readonly Status RECOVERING = new Status("RECOVERING");
        /// <summary>
        /// Constant RECURRING for Status
        /// </summary>
        public static readonly Status RECURRING = new Status("RECURRING");
        /// <summary>
        /// Constant RESOLVED for Status
        /// </summary>
        public static readonly Status RESOLVED = new Status("RESOLVED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Status(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Status FindValue(string value)
        {
            return FindValue<Status>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Status(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Tier.
    /// </summary>
    public class Tier : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE_DIRECTORY for Tier
        /// </summary>
        public static readonly Tier ACTIVE_DIRECTORY = new Tier("ACTIVE_DIRECTORY");
        /// <summary>
        /// Constant CUSTOM for Tier
        /// </summary>
        public static readonly Tier CUSTOM = new Tier("CUSTOM");
        /// <summary>
        /// Constant DEFAULT for Tier
        /// </summary>
        public static readonly Tier DEFAULT = new Tier("DEFAULT");
        /// <summary>
        /// Constant DOT_NET_CORE for Tier
        /// </summary>
        public static readonly Tier DOT_NET_CORE = new Tier("DOT_NET_CORE");
        /// <summary>
        /// Constant DOT_NET_WEB for Tier
        /// </summary>
        public static readonly Tier DOT_NET_WEB = new Tier("DOT_NET_WEB");
        /// <summary>
        /// Constant DOT_NET_WEB_TIER for Tier
        /// </summary>
        public static readonly Tier DOT_NET_WEB_TIER = new Tier("DOT_NET_WEB_TIER");
        /// <summary>
        /// Constant DOT_NET_WORKER for Tier
        /// </summary>
        public static readonly Tier DOT_NET_WORKER = new Tier("DOT_NET_WORKER");
        /// <summary>
        /// Constant JAVA_JMX for Tier
        /// </summary>
        public static readonly Tier JAVA_JMX = new Tier("JAVA_JMX");
        /// <summary>
        /// Constant MYSQL for Tier
        /// </summary>
        public static readonly Tier MYSQL = new Tier("MYSQL");
        /// <summary>
        /// Constant ORACLE for Tier
        /// </summary>
        public static readonly Tier ORACLE = new Tier("ORACLE");
        /// <summary>
        /// Constant POSTGRESQL for Tier
        /// </summary>
        public static readonly Tier POSTGRESQL = new Tier("POSTGRESQL");
        /// <summary>
        /// Constant SAP_ASE_HIGH_AVAILABILITY for Tier
        /// </summary>
        public static readonly Tier SAP_ASE_HIGH_AVAILABILITY = new Tier("SAP_ASE_HIGH_AVAILABILITY");
        /// <summary>
        /// Constant SAP_ASE_SINGLE_NODE for Tier
        /// </summary>
        public static readonly Tier SAP_ASE_SINGLE_NODE = new Tier("SAP_ASE_SINGLE_NODE");
        /// <summary>
        /// Constant SAP_HANA_HIGH_AVAILABILITY for Tier
        /// </summary>
        public static readonly Tier SAP_HANA_HIGH_AVAILABILITY = new Tier("SAP_HANA_HIGH_AVAILABILITY");
        /// <summary>
        /// Constant SAP_HANA_MULTI_NODE for Tier
        /// </summary>
        public static readonly Tier SAP_HANA_MULTI_NODE = new Tier("SAP_HANA_MULTI_NODE");
        /// <summary>
        /// Constant SAP_HANA_SINGLE_NODE for Tier
        /// </summary>
        public static readonly Tier SAP_HANA_SINGLE_NODE = new Tier("SAP_HANA_SINGLE_NODE");
        /// <summary>
        /// Constant SAP_NETWEAVER_DISTRIBUTED for Tier
        /// </summary>
        public static readonly Tier SAP_NETWEAVER_DISTRIBUTED = new Tier("SAP_NETWEAVER_DISTRIBUTED");
        /// <summary>
        /// Constant SAP_NETWEAVER_HIGH_AVAILABILITY for Tier
        /// </summary>
        public static readonly Tier SAP_NETWEAVER_HIGH_AVAILABILITY = new Tier("SAP_NETWEAVER_HIGH_AVAILABILITY");
        /// <summary>
        /// Constant SAP_NETWEAVER_STANDARD for Tier
        /// </summary>
        public static readonly Tier SAP_NETWEAVER_STANDARD = new Tier("SAP_NETWEAVER_STANDARD");
        /// <summary>
        /// Constant SHAREPOINT for Tier
        /// </summary>
        public static readonly Tier SHAREPOINT = new Tier("SHAREPOINT");
        /// <summary>
        /// Constant SQL_SERVER for Tier
        /// </summary>
        public static readonly Tier SQL_SERVER = new Tier("SQL_SERVER");
        /// <summary>
        /// Constant SQL_SERVER_ALWAYSON_AVAILABILITY_GROUP for Tier
        /// </summary>
        public static readonly Tier SQL_SERVER_ALWAYSON_AVAILABILITY_GROUP = new Tier("SQL_SERVER_ALWAYSON_AVAILABILITY_GROUP");
        /// <summary>
        /// Constant SQL_SERVER_FAILOVER_CLUSTER_INSTANCE for Tier
        /// </summary>
        public static readonly Tier SQL_SERVER_FAILOVER_CLUSTER_INSTANCE = new Tier("SQL_SERVER_FAILOVER_CLUSTER_INSTANCE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Tier(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Tier FindValue(string value)
        {
            return FindValue<Tier>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Tier(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type UpdateStatus.
    /// </summary>
    public class UpdateStatus : ConstantClass
    {

        /// <summary>
        /// Constant RESOLVED for UpdateStatus
        /// </summary>
        public static readonly UpdateStatus RESOLVED = new UpdateStatus("RESOLVED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public UpdateStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static UpdateStatus FindValue(string value)
        {
            return FindValue<UpdateStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator UpdateStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Visibility.
    /// </summary>
    public class Visibility : ConstantClass
    {

        /// <summary>
        /// Constant IGNORED for Visibility
        /// </summary>
        public static readonly Visibility IGNORED = new Visibility("IGNORED");
        /// <summary>
        /// Constant VISIBLE for Visibility
        /// </summary>
        public static readonly Visibility VISIBLE = new Visibility("VISIBLE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Visibility(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Visibility FindValue(string value)
        {
            return FindValue<Visibility>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Visibility(string value)
        {
            return FindValue(value);
        }
    }

}