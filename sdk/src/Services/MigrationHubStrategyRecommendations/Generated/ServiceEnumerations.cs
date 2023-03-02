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
 * Do not modify this file. This file is generated from the migrationhubstrategy-2020-02-19.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.MigrationHubStrategyRecommendations
{

    /// <summary>
    /// Constants used for properties of type AntipatternReportStatus.
    /// </summary>
    public class AntipatternReportStatus : ConstantClass
    {

        /// <summary>
        /// Constant FAILED for AntipatternReportStatus
        /// </summary>
        public static readonly AntipatternReportStatus FAILED = new AntipatternReportStatus("FAILED");
        /// <summary>
        /// Constant IN_PROGRESS for AntipatternReportStatus
        /// </summary>
        public static readonly AntipatternReportStatus IN_PROGRESS = new AntipatternReportStatus("IN_PROGRESS");
        /// <summary>
        /// Constant SUCCESS for AntipatternReportStatus
        /// </summary>
        public static readonly AntipatternReportStatus SUCCESS = new AntipatternReportStatus("SUCCESS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AntipatternReportStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AntipatternReportStatus FindValue(string value)
        {
            return FindValue<AntipatternReportStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AntipatternReportStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ApplicationComponentCriteria.
    /// </summary>
    public class ApplicationComponentCriteria : ConstantClass
    {

        /// <summary>
        /// Constant ANALYSIS_STATUS for ApplicationComponentCriteria
        /// </summary>
        public static readonly ApplicationComponentCriteria ANALYSIS_STATUS = new ApplicationComponentCriteria("ANALYSIS_STATUS");
        /// <summary>
        /// Constant APP_NAME for ApplicationComponentCriteria
        /// </summary>
        public static readonly ApplicationComponentCriteria APP_NAME = new ApplicationComponentCriteria("APP_NAME");
        /// <summary>
        /// Constant APP_TYPE for ApplicationComponentCriteria
        /// </summary>
        public static readonly ApplicationComponentCriteria APP_TYPE = new ApplicationComponentCriteria("APP_TYPE");
        /// <summary>
        /// Constant DESTINATION for ApplicationComponentCriteria
        /// </summary>
        public static readonly ApplicationComponentCriteria DESTINATION = new ApplicationComponentCriteria("DESTINATION");
        /// <summary>
        /// Constant ERROR_CATEGORY for ApplicationComponentCriteria
        /// </summary>
        public static readonly ApplicationComponentCriteria ERROR_CATEGORY = new ApplicationComponentCriteria("ERROR_CATEGORY");
        /// <summary>
        /// Constant NOT_DEFINED for ApplicationComponentCriteria
        /// </summary>
        public static readonly ApplicationComponentCriteria NOT_DEFINED = new ApplicationComponentCriteria("NOT_DEFINED");
        /// <summary>
        /// Constant SERVER_ID for ApplicationComponentCriteria
        /// </summary>
        public static readonly ApplicationComponentCriteria SERVER_ID = new ApplicationComponentCriteria("SERVER_ID");
        /// <summary>
        /// Constant STRATEGY for ApplicationComponentCriteria
        /// </summary>
        public static readonly ApplicationComponentCriteria STRATEGY = new ApplicationComponentCriteria("STRATEGY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ApplicationComponentCriteria(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ApplicationComponentCriteria FindValue(string value)
        {
            return FindValue<ApplicationComponentCriteria>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ApplicationComponentCriteria(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ApplicationMode.
    /// </summary>
    public class ApplicationMode : ConstantClass
    {

        /// <summary>
        /// Constant ALL for ApplicationMode
        /// </summary>
        public static readonly ApplicationMode ALL = new ApplicationMode("ALL");
        /// <summary>
        /// Constant KNOWN for ApplicationMode
        /// </summary>
        public static readonly ApplicationMode KNOWN = new ApplicationMode("KNOWN");
        /// <summary>
        /// Constant UNKNOWN for ApplicationMode
        /// </summary>
        public static readonly ApplicationMode UNKNOWN = new ApplicationMode("UNKNOWN");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ApplicationMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ApplicationMode FindValue(string value)
        {
            return FindValue<ApplicationMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ApplicationMode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AppType.
    /// </summary>
    public class AppType : ConstantClass
    {

        /// <summary>
        /// Constant Cassandra for AppType
        /// </summary>
        public static readonly AppType Cassandra = new AppType("Cassandra");
        /// <summary>
        /// Constant DB2 for AppType
        /// </summary>
        public static readonly AppType DB2 = new AppType("DB2");
        /// <summary>
        /// Constant Dotnet for AppType
        /// </summary>
        public static readonly AppType Dotnet = new AppType("Dotnet");
        /// <summary>
        /// Constant DotnetCore for AppType
        /// </summary>
        public static readonly AppType DotnetCore = new AppType("DotnetCore");
        /// <summary>
        /// Constant DotNetFramework for AppType
        /// </summary>
        public static readonly AppType DotNetFramework = new AppType("DotNetFramework");
        /// <summary>
        /// Constant IBMWebSphere for AppType
        /// </summary>
        public static readonly AppType IBMWebSphere = new AppType("IBM WebSphere");
        /// <summary>
        /// Constant IIS for AppType
        /// </summary>
        public static readonly AppType IIS = new AppType("IIS");
        /// <summary>
        /// Constant Java for AppType
        /// </summary>
        public static readonly AppType Java = new AppType("Java");
        /// <summary>
        /// Constant JBoss for AppType
        /// </summary>
        public static readonly AppType JBoss = new AppType("JBoss");
        /// <summary>
        /// Constant MariaDB for AppType
        /// </summary>
        public static readonly AppType MariaDB = new AppType("Maria DB");
        /// <summary>
        /// Constant MongoDB for AppType
        /// </summary>
        public static readonly AppType MongoDB = new AppType("Mongo DB");
        /// <summary>
        /// Constant MySQL for AppType
        /// </summary>
        public static readonly AppType MySQL = new AppType("MySQL");
        /// <summary>
        /// Constant Oracle for AppType
        /// </summary>
        public static readonly AppType Oracle = new AppType("Oracle");
        /// <summary>
        /// Constant OracleWebLogic for AppType
        /// </summary>
        public static readonly AppType OracleWebLogic = new AppType("Oracle WebLogic");
        /// <summary>
        /// Constant Other for AppType
        /// </summary>
        public static readonly AppType Other = new AppType("Other");
        /// <summary>
        /// Constant PostgreSQLServer for AppType
        /// </summary>
        public static readonly AppType PostgreSQLServer = new AppType("PostgreSQLServer");
        /// <summary>
        /// Constant Spring for AppType
        /// </summary>
        public static readonly AppType Spring = new AppType("Spring");
        /// <summary>
        /// Constant SQLServer for AppType
        /// </summary>
        public static readonly AppType SQLServer = new AppType("SQLServer");
        /// <summary>
        /// Constant Sybase for AppType
        /// </summary>
        public static readonly AppType Sybase = new AppType("Sybase");
        /// <summary>
        /// Constant Tomcat for AppType
        /// </summary>
        public static readonly AppType Tomcat = new AppType("Tomcat");
        /// <summary>
        /// Constant Unknown for AppType
        /// </summary>
        public static readonly AppType Unknown = new AppType("Unknown");
        /// <summary>
        /// Constant VisualBasic for AppType
        /// </summary>
        public static readonly AppType VisualBasic = new AppType("Visual Basic");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AppType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AppType FindValue(string value)
        {
            return FindValue<AppType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AppType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AppUnitErrorCategory.
    /// </summary>
    public class AppUnitErrorCategory : ConstantClass
    {

        /// <summary>
        /// Constant CONNECTIVITY_ERROR for AppUnitErrorCategory
        /// </summary>
        public static readonly AppUnitErrorCategory CONNECTIVITY_ERROR = new AppUnitErrorCategory("CONNECTIVITY_ERROR");
        /// <summary>
        /// Constant CREDENTIAL_ERROR for AppUnitErrorCategory
        /// </summary>
        public static readonly AppUnitErrorCategory CREDENTIAL_ERROR = new AppUnitErrorCategory("CREDENTIAL_ERROR");
        /// <summary>
        /// Constant OTHER_ERROR for AppUnitErrorCategory
        /// </summary>
        public static readonly AppUnitErrorCategory OTHER_ERROR = new AppUnitErrorCategory("OTHER_ERROR");
        /// <summary>
        /// Constant PERMISSION_ERROR for AppUnitErrorCategory
        /// </summary>
        public static readonly AppUnitErrorCategory PERMISSION_ERROR = new AppUnitErrorCategory("PERMISSION_ERROR");
        /// <summary>
        /// Constant UNSUPPORTED_ERROR for AppUnitErrorCategory
        /// </summary>
        public static readonly AppUnitErrorCategory UNSUPPORTED_ERROR = new AppUnitErrorCategory("UNSUPPORTED_ERROR");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AppUnitErrorCategory(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AppUnitErrorCategory FindValue(string value)
        {
            return FindValue<AppUnitErrorCategory>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AppUnitErrorCategory(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AssessmentStatus.
    /// </summary>
    public class AssessmentStatus : ConstantClass
    {

        /// <summary>
        /// Constant COMPLETE for AssessmentStatus
        /// </summary>
        public static readonly AssessmentStatus COMPLETE = new AssessmentStatus("COMPLETE");
        /// <summary>
        /// Constant FAILED for AssessmentStatus
        /// </summary>
        public static readonly AssessmentStatus FAILED = new AssessmentStatus("FAILED");
        /// <summary>
        /// Constant IN_PROGRESS for AssessmentStatus
        /// </summary>
        public static readonly AssessmentStatus IN_PROGRESS = new AssessmentStatus("IN_PROGRESS");
        /// <summary>
        /// Constant STOPPED for AssessmentStatus
        /// </summary>
        public static readonly AssessmentStatus STOPPED = new AssessmentStatus("STOPPED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AssessmentStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AssessmentStatus FindValue(string value)
        {
            return FindValue<AssessmentStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AssessmentStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AuthType.
    /// </summary>
    public class AuthType : ConstantClass
    {

        /// <summary>
        /// Constant CERT for AuthType
        /// </summary>
        public static readonly AuthType CERT = new AuthType("CERT");
        /// <summary>
        /// Constant NTLM for AuthType
        /// </summary>
        public static readonly AuthType NTLM = new AuthType("NTLM");
        /// <summary>
        /// Constant SSH for AuthType
        /// </summary>
        public static readonly AuthType SSH = new AuthType("SSH");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AuthType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AuthType FindValue(string value)
        {
            return FindValue<AuthType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AuthType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AwsManagedTargetDestination.
    /// </summary>
    public class AwsManagedTargetDestination : ConstantClass
    {

        /// <summary>
        /// Constant AWSElasticBeanStalk for AwsManagedTargetDestination
        /// </summary>
        public static readonly AwsManagedTargetDestination AWSElasticBeanStalk = new AwsManagedTargetDestination("AWS Elastic BeanStalk");
        /// <summary>
        /// Constant AWSFargate for AwsManagedTargetDestination
        /// </summary>
        public static readonly AwsManagedTargetDestination AWSFargate = new AwsManagedTargetDestination("AWS Fargate");
        /// <summary>
        /// Constant NoneSpecified for AwsManagedTargetDestination
        /// </summary>
        public static readonly AwsManagedTargetDestination NoneSpecified = new AwsManagedTargetDestination("None specified");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AwsManagedTargetDestination(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AwsManagedTargetDestination FindValue(string value)
        {
            return FindValue<AwsManagedTargetDestination>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AwsManagedTargetDestination(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CollectorHealth.
    /// </summary>
    public class CollectorHealth : ConstantClass
    {

        /// <summary>
        /// Constant COLLECTOR_HEALTHY for CollectorHealth
        /// </summary>
        public static readonly CollectorHealth COLLECTOR_HEALTHY = new CollectorHealth("COLLECTOR_HEALTHY");
        /// <summary>
        /// Constant COLLECTOR_UNHEALTHY for CollectorHealth
        /// </summary>
        public static readonly CollectorHealth COLLECTOR_UNHEALTHY = new CollectorHealth("COLLECTOR_UNHEALTHY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CollectorHealth(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CollectorHealth FindValue(string value)
        {
            return FindValue<CollectorHealth>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CollectorHealth(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Condition.
    /// </summary>
    public class Condition : ConstantClass
    {

        /// <summary>
        /// Constant CONTAINS for Condition
        /// </summary>
        public static readonly Condition CONTAINS = new Condition("CONTAINS");
        /// <summary>
        /// Constant EQUALS for Condition
        /// </summary>
        public static readonly Condition EQUALS = new Condition("EQUALS");
        /// <summary>
        /// Constant NOT_CONTAINS for Condition
        /// </summary>
        public static readonly Condition NOT_CONTAINS = new Condition("NOT_CONTAINS");
        /// <summary>
        /// Constant NOT_EQUALS for Condition
        /// </summary>
        public static readonly Condition NOT_EQUALS = new Condition("NOT_EQUALS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Condition(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Condition FindValue(string value)
        {
            return FindValue<Condition>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Condition(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DatabaseManagementPreference.
    /// </summary>
    public class DatabaseManagementPreference : ConstantClass
    {

        /// <summary>
        /// Constant AWSManaged for DatabaseManagementPreference
        /// </summary>
        public static readonly DatabaseManagementPreference AWSManaged = new DatabaseManagementPreference("AWS-managed");
        /// <summary>
        /// Constant NoPreference for DatabaseManagementPreference
        /// </summary>
        public static readonly DatabaseManagementPreference NoPreference = new DatabaseManagementPreference("No preference");
        /// <summary>
        /// Constant SelfManage for DatabaseManagementPreference
        /// </summary>
        public static readonly DatabaseManagementPreference SelfManage = new DatabaseManagementPreference("Self-manage");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DatabaseManagementPreference(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DatabaseManagementPreference FindValue(string value)
        {
            return FindValue<DatabaseManagementPreference>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DatabaseManagementPreference(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DataSourceType.
    /// </summary>
    public class DataSourceType : ConstantClass
    {

        /// <summary>
        /// Constant ApplicationDiscoveryService for DataSourceType
        /// </summary>
        public static readonly DataSourceType ApplicationDiscoveryService = new DataSourceType("ApplicationDiscoveryService");
        /// <summary>
        /// Constant Import for DataSourceType
        /// </summary>
        public static readonly DataSourceType Import = new DataSourceType("Import");
        /// <summary>
        /// Constant MPA for DataSourceType
        /// </summary>
        public static readonly DataSourceType MPA = new DataSourceType("MPA");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DataSourceType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DataSourceType FindValue(string value)
        {
            return FindValue<DataSourceType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DataSourceType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type GroupName.
    /// </summary>
    public class GroupName : ConstantClass
    {

        /// <summary>
        /// Constant ExternalId for GroupName
        /// </summary>
        public static readonly GroupName ExternalId = new GroupName("ExternalId");
        /// <summary>
        /// Constant ExternalSourceType for GroupName
        /// </summary>
        public static readonly GroupName ExternalSourceType = new GroupName("ExternalSourceType");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public GroupName(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static GroupName FindValue(string value)
        {
            return FindValue<GroupName>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator GroupName(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type HeterogeneousTargetDatabaseEngine.
    /// </summary>
    public class HeterogeneousTargetDatabaseEngine : ConstantClass
    {

        /// <summary>
        /// Constant AmazonAurora for HeterogeneousTargetDatabaseEngine
        /// </summary>
        public static readonly HeterogeneousTargetDatabaseEngine AmazonAurora = new HeterogeneousTargetDatabaseEngine("Amazon Aurora");
        /// <summary>
        /// Constant AWSPostgreSQL for HeterogeneousTargetDatabaseEngine
        /// </summary>
        public static readonly HeterogeneousTargetDatabaseEngine AWSPostgreSQL = new HeterogeneousTargetDatabaseEngine("AWS PostgreSQL");
        /// <summary>
        /// Constant Db2LUW for HeterogeneousTargetDatabaseEngine
        /// </summary>
        public static readonly HeterogeneousTargetDatabaseEngine Db2LUW = new HeterogeneousTargetDatabaseEngine("Db2 LUW");
        /// <summary>
        /// Constant MariaDB for HeterogeneousTargetDatabaseEngine
        /// </summary>
        public static readonly HeterogeneousTargetDatabaseEngine MariaDB = new HeterogeneousTargetDatabaseEngine("MariaDB");
        /// <summary>
        /// Constant MicrosoftSQLServer for HeterogeneousTargetDatabaseEngine
        /// </summary>
        public static readonly HeterogeneousTargetDatabaseEngine MicrosoftSQLServer = new HeterogeneousTargetDatabaseEngine("Microsoft SQL Server");
        /// <summary>
        /// Constant MongoDB for HeterogeneousTargetDatabaseEngine
        /// </summary>
        public static readonly HeterogeneousTargetDatabaseEngine MongoDB = new HeterogeneousTargetDatabaseEngine("MongoDB");
        /// <summary>
        /// Constant MySQL for HeterogeneousTargetDatabaseEngine
        /// </summary>
        public static readonly HeterogeneousTargetDatabaseEngine MySQL = new HeterogeneousTargetDatabaseEngine("MySQL");
        /// <summary>
        /// Constant NoneSpecified for HeterogeneousTargetDatabaseEngine
        /// </summary>
        public static readonly HeterogeneousTargetDatabaseEngine NoneSpecified = new HeterogeneousTargetDatabaseEngine("None specified");
        /// <summary>
        /// Constant OracleDatabase for HeterogeneousTargetDatabaseEngine
        /// </summary>
        public static readonly HeterogeneousTargetDatabaseEngine OracleDatabase = new HeterogeneousTargetDatabaseEngine("Oracle Database");
        /// <summary>
        /// Constant SAP for HeterogeneousTargetDatabaseEngine
        /// </summary>
        public static readonly HeterogeneousTargetDatabaseEngine SAP = new HeterogeneousTargetDatabaseEngine("SAP");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public HeterogeneousTargetDatabaseEngine(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static HeterogeneousTargetDatabaseEngine FindValue(string value)
        {
            return FindValue<HeterogeneousTargetDatabaseEngine>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator HeterogeneousTargetDatabaseEngine(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type HomogeneousTargetDatabaseEngine.
    /// </summary>
    public class HomogeneousTargetDatabaseEngine : ConstantClass
    {

        /// <summary>
        /// Constant NoneSpecified for HomogeneousTargetDatabaseEngine
        /// </summary>
        public static readonly HomogeneousTargetDatabaseEngine NoneSpecified = new HomogeneousTargetDatabaseEngine("None specified");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public HomogeneousTargetDatabaseEngine(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static HomogeneousTargetDatabaseEngine FindValue(string value)
        {
            return FindValue<HomogeneousTargetDatabaseEngine>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator HomogeneousTargetDatabaseEngine(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ImportFileTaskStatus.
    /// </summary>
    public class ImportFileTaskStatus : ConstantClass
    {

        /// <summary>
        /// Constant DeleteFailed for ImportFileTaskStatus
        /// </summary>
        public static readonly ImportFileTaskStatus DeleteFailed = new ImportFileTaskStatus("DeleteFailed");
        /// <summary>
        /// Constant DeleteInProgress for ImportFileTaskStatus
        /// </summary>
        public static readonly ImportFileTaskStatus DeleteInProgress = new ImportFileTaskStatus("DeleteInProgress");
        /// <summary>
        /// Constant DeletePartialSuccess for ImportFileTaskStatus
        /// </summary>
        public static readonly ImportFileTaskStatus DeletePartialSuccess = new ImportFileTaskStatus("DeletePartialSuccess");
        /// <summary>
        /// Constant DeleteSuccess for ImportFileTaskStatus
        /// </summary>
        public static readonly ImportFileTaskStatus DeleteSuccess = new ImportFileTaskStatus("DeleteSuccess");
        /// <summary>
        /// Constant ImportFailed for ImportFileTaskStatus
        /// </summary>
        public static readonly ImportFileTaskStatus ImportFailed = new ImportFileTaskStatus("ImportFailed");
        /// <summary>
        /// Constant ImportInProgress for ImportFileTaskStatus
        /// </summary>
        public static readonly ImportFileTaskStatus ImportInProgress = new ImportFileTaskStatus("ImportInProgress");
        /// <summary>
        /// Constant ImportPartialSuccess for ImportFileTaskStatus
        /// </summary>
        public static readonly ImportFileTaskStatus ImportPartialSuccess = new ImportFileTaskStatus("ImportPartialSuccess");
        /// <summary>
        /// Constant ImportSuccess for ImportFileTaskStatus
        /// </summary>
        public static readonly ImportFileTaskStatus ImportSuccess = new ImportFileTaskStatus("ImportSuccess");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ImportFileTaskStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ImportFileTaskStatus FindValue(string value)
        {
            return FindValue<ImportFileTaskStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ImportFileTaskStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type InclusionStatus.
    /// </summary>
    public class InclusionStatus : ConstantClass
    {

        /// <summary>
        /// Constant ExcludeFromAssessment for InclusionStatus
        /// </summary>
        public static readonly InclusionStatus ExcludeFromAssessment = new InclusionStatus("excludeFromAssessment");
        /// <summary>
        /// Constant IncludeInAssessment for InclusionStatus
        /// </summary>
        public static readonly InclusionStatus IncludeInAssessment = new InclusionStatus("includeInAssessment");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public InclusionStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static InclusionStatus FindValue(string value)
        {
            return FindValue<InclusionStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator InclusionStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type NoPreferenceTargetDestination.
    /// </summary>
    public class NoPreferenceTargetDestination : ConstantClass
    {

        /// <summary>
        /// Constant AmazonElasticCloudComputeEC2 for NoPreferenceTargetDestination
        /// </summary>
        public static readonly NoPreferenceTargetDestination AmazonElasticCloudComputeEC2 = new NoPreferenceTargetDestination("Amazon Elastic Cloud Compute (EC2)");
        /// <summary>
        /// Constant AmazonElasticContainerServiceECS for NoPreferenceTargetDestination
        /// </summary>
        public static readonly NoPreferenceTargetDestination AmazonElasticContainerServiceECS = new NoPreferenceTargetDestination("Amazon Elastic Container Service (ECS)");
        /// <summary>
        /// Constant AmazonElasticKubernetesServiceEKS for NoPreferenceTargetDestination
        /// </summary>
        public static readonly NoPreferenceTargetDestination AmazonElasticKubernetesServiceEKS = new NoPreferenceTargetDestination("Amazon Elastic Kubernetes Service (EKS)");
        /// <summary>
        /// Constant AWSElasticBeanStalk for NoPreferenceTargetDestination
        /// </summary>
        public static readonly NoPreferenceTargetDestination AWSElasticBeanStalk = new NoPreferenceTargetDestination("AWS Elastic BeanStalk");
        /// <summary>
        /// Constant AWSFargate for NoPreferenceTargetDestination
        /// </summary>
        public static readonly NoPreferenceTargetDestination AWSFargate = new NoPreferenceTargetDestination("AWS Fargate");
        /// <summary>
        /// Constant NoneSpecified for NoPreferenceTargetDestination
        /// </summary>
        public static readonly NoPreferenceTargetDestination NoneSpecified = new NoPreferenceTargetDestination("None specified");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public NoPreferenceTargetDestination(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static NoPreferenceTargetDestination FindValue(string value)
        {
            return FindValue<NoPreferenceTargetDestination>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator NoPreferenceTargetDestination(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type OSType.
    /// </summary>
    public class OSType : ConstantClass
    {

        /// <summary>
        /// Constant LINUX for OSType
        /// </summary>
        public static readonly OSType LINUX = new OSType("LINUX");
        /// <summary>
        /// Constant WINDOWS for OSType
        /// </summary>
        public static readonly OSType WINDOWS = new OSType("WINDOWS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public OSType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static OSType FindValue(string value)
        {
            return FindValue<OSType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator OSType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type OutputFormat.
    /// </summary>
    public class OutputFormat : ConstantClass
    {

        /// <summary>
        /// Constant Excel for OutputFormat
        /// </summary>
        public static readonly OutputFormat Excel = new OutputFormat("Excel");
        /// <summary>
        /// Constant Json for OutputFormat
        /// </summary>
        public static readonly OutputFormat Json = new OutputFormat("Json");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public OutputFormat(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static OutputFormat FindValue(string value)
        {
            return FindValue<OutputFormat>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator OutputFormat(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PipelineType.
    /// </summary>
    public class PipelineType : ConstantClass
    {

        /// <summary>
        /// Constant AZURE_DEVOPS for PipelineType
        /// </summary>
        public static readonly PipelineType AZURE_DEVOPS = new PipelineType("AZURE_DEVOPS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PipelineType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PipelineType FindValue(string value)
        {
            return FindValue<PipelineType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PipelineType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RecommendationReportStatus.
    /// </summary>
    public class RecommendationReportStatus : ConstantClass
    {

        /// <summary>
        /// Constant FAILED for RecommendationReportStatus
        /// </summary>
        public static readonly RecommendationReportStatus FAILED = new RecommendationReportStatus("FAILED");
        /// <summary>
        /// Constant IN_PROGRESS for RecommendationReportStatus
        /// </summary>
        public static readonly RecommendationReportStatus IN_PROGRESS = new RecommendationReportStatus("IN_PROGRESS");
        /// <summary>
        /// Constant SUCCESS for RecommendationReportStatus
        /// </summary>
        public static readonly RecommendationReportStatus SUCCESS = new RecommendationReportStatus("SUCCESS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RecommendationReportStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RecommendationReportStatus FindValue(string value)
        {
            return FindValue<RecommendationReportStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RecommendationReportStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ResourceSubType.
    /// </summary>
    public class ResourceSubType : ConstantClass
    {

        /// <summary>
        /// Constant Database for ResourceSubType
        /// </summary>
        public static readonly ResourceSubType Database = new ResourceSubType("Database");
        /// <summary>
        /// Constant DatabaseProcess for ResourceSubType
        /// </summary>
        public static readonly ResourceSubType DatabaseProcess = new ResourceSubType("DatabaseProcess");
        /// <summary>
        /// Constant Process for ResourceSubType
        /// </summary>
        public static readonly ResourceSubType Process = new ResourceSubType("Process");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ResourceSubType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ResourceSubType FindValue(string value)
        {
            return FindValue<ResourceSubType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ResourceSubType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RuntimeAnalysisStatus.
    /// </summary>
    public class RuntimeAnalysisStatus : ConstantClass
    {

        /// <summary>
        /// Constant ANALYSIS_FAILED for RuntimeAnalysisStatus
        /// </summary>
        public static readonly RuntimeAnalysisStatus ANALYSIS_FAILED = new RuntimeAnalysisStatus("ANALYSIS_FAILED");
        /// <summary>
        /// Constant ANALYSIS_STARTED for RuntimeAnalysisStatus
        /// </summary>
        public static readonly RuntimeAnalysisStatus ANALYSIS_STARTED = new RuntimeAnalysisStatus("ANALYSIS_STARTED");
        /// <summary>
        /// Constant ANALYSIS_SUCCESS for RuntimeAnalysisStatus
        /// </summary>
        public static readonly RuntimeAnalysisStatus ANALYSIS_SUCCESS = new RuntimeAnalysisStatus("ANALYSIS_SUCCESS");
        /// <summary>
        /// Constant ANALYSIS_TO_BE_SCHEDULED for RuntimeAnalysisStatus
        /// </summary>
        public static readonly RuntimeAnalysisStatus ANALYSIS_TO_BE_SCHEDULED = new RuntimeAnalysisStatus("ANALYSIS_TO_BE_SCHEDULED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RuntimeAnalysisStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RuntimeAnalysisStatus FindValue(string value)
        {
            return FindValue<RuntimeAnalysisStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RuntimeAnalysisStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RunTimeAssessmentStatus.
    /// </summary>
    public class RunTimeAssessmentStatus : ConstantClass
    {

        /// <summary>
        /// Constant DataCollectionTaskFailed for RunTimeAssessmentStatus
        /// </summary>
        public static readonly RunTimeAssessmentStatus DataCollectionTaskFailed = new RunTimeAssessmentStatus("dataCollectionTaskFailed");
        /// <summary>
        /// Constant DataCollectionTaskPartialSuccess for RunTimeAssessmentStatus
        /// </summary>
        public static readonly RunTimeAssessmentStatus DataCollectionTaskPartialSuccess = new RunTimeAssessmentStatus("dataCollectionTaskPartialSuccess");
        /// <summary>
        /// Constant DataCollectionTaskScheduled for RunTimeAssessmentStatus
        /// </summary>
        public static readonly RunTimeAssessmentStatus DataCollectionTaskScheduled = new RunTimeAssessmentStatus("dataCollectionTaskScheduled");
        /// <summary>
        /// Constant DataCollectionTaskStarted for RunTimeAssessmentStatus
        /// </summary>
        public static readonly RunTimeAssessmentStatus DataCollectionTaskStarted = new RunTimeAssessmentStatus("dataCollectionTaskStarted");
        /// <summary>
        /// Constant DataCollectionTaskStopped for RunTimeAssessmentStatus
        /// </summary>
        public static readonly RunTimeAssessmentStatus DataCollectionTaskStopped = new RunTimeAssessmentStatus("dataCollectionTaskStopped");
        /// <summary>
        /// Constant DataCollectionTaskSuccess for RunTimeAssessmentStatus
        /// </summary>
        public static readonly RunTimeAssessmentStatus DataCollectionTaskSuccess = new RunTimeAssessmentStatus("dataCollectionTaskSuccess");
        /// <summary>
        /// Constant DataCollectionTaskToBeScheduled for RunTimeAssessmentStatus
        /// </summary>
        public static readonly RunTimeAssessmentStatus DataCollectionTaskToBeScheduled = new RunTimeAssessmentStatus("dataCollectionTaskToBeScheduled");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RunTimeAssessmentStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RunTimeAssessmentStatus FindValue(string value)
        {
            return FindValue<RunTimeAssessmentStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RunTimeAssessmentStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SelfManageTargetDestination.
    /// </summary>
    public class SelfManageTargetDestination : ConstantClass
    {

        /// <summary>
        /// Constant AmazonElasticCloudComputeEC2 for SelfManageTargetDestination
        /// </summary>
        public static readonly SelfManageTargetDestination AmazonElasticCloudComputeEC2 = new SelfManageTargetDestination("Amazon Elastic Cloud Compute (EC2)");
        /// <summary>
        /// Constant AmazonElasticContainerServiceECS for SelfManageTargetDestination
        /// </summary>
        public static readonly SelfManageTargetDestination AmazonElasticContainerServiceECS = new SelfManageTargetDestination("Amazon Elastic Container Service (ECS)");
        /// <summary>
        /// Constant AmazonElasticKubernetesServiceEKS for SelfManageTargetDestination
        /// </summary>
        public static readonly SelfManageTargetDestination AmazonElasticKubernetesServiceEKS = new SelfManageTargetDestination("Amazon Elastic Kubernetes Service (EKS)");
        /// <summary>
        /// Constant NoneSpecified for SelfManageTargetDestination
        /// </summary>
        public static readonly SelfManageTargetDestination NoneSpecified = new SelfManageTargetDestination("None specified");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SelfManageTargetDestination(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SelfManageTargetDestination FindValue(string value)
        {
            return FindValue<SelfManageTargetDestination>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SelfManageTargetDestination(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ServerCriteria.
    /// </summary>
    public class ServerCriteria : ConstantClass
    {

        /// <summary>
        /// Constant ANALYSIS_STATUS for ServerCriteria
        /// </summary>
        public static readonly ServerCriteria ANALYSIS_STATUS = new ServerCriteria("ANALYSIS_STATUS");
        /// <summary>
        /// Constant DESTINATION for ServerCriteria
        /// </summary>
        public static readonly ServerCriteria DESTINATION = new ServerCriteria("DESTINATION");
        /// <summary>
        /// Constant ERROR_CATEGORY for ServerCriteria
        /// </summary>
        public static readonly ServerCriteria ERROR_CATEGORY = new ServerCriteria("ERROR_CATEGORY");
        /// <summary>
        /// Constant NOT_DEFINED for ServerCriteria
        /// </summary>
        public static readonly ServerCriteria NOT_DEFINED = new ServerCriteria("NOT_DEFINED");
        /// <summary>
        /// Constant OS_NAME for ServerCriteria
        /// </summary>
        public static readonly ServerCriteria OS_NAME = new ServerCriteria("OS_NAME");
        /// <summary>
        /// Constant SERVER_ID for ServerCriteria
        /// </summary>
        public static readonly ServerCriteria SERVER_ID = new ServerCriteria("SERVER_ID");
        /// <summary>
        /// Constant STRATEGY for ServerCriteria
        /// </summary>
        public static readonly ServerCriteria STRATEGY = new ServerCriteria("STRATEGY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ServerCriteria(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ServerCriteria FindValue(string value)
        {
            return FindValue<ServerCriteria>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ServerCriteria(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ServerErrorCategory.
    /// </summary>
    public class ServerErrorCategory : ConstantClass
    {

        /// <summary>
        /// Constant ARCHITECTURE_ERROR for ServerErrorCategory
        /// </summary>
        public static readonly ServerErrorCategory ARCHITECTURE_ERROR = new ServerErrorCategory("ARCHITECTURE_ERROR");
        /// <summary>
        /// Constant CONNECTIVITY_ERROR for ServerErrorCategory
        /// </summary>
        public static readonly ServerErrorCategory CONNECTIVITY_ERROR = new ServerErrorCategory("CONNECTIVITY_ERROR");
        /// <summary>
        /// Constant CREDENTIAL_ERROR for ServerErrorCategory
        /// </summary>
        public static readonly ServerErrorCategory CREDENTIAL_ERROR = new ServerErrorCategory("CREDENTIAL_ERROR");
        /// <summary>
        /// Constant OTHER_ERROR for ServerErrorCategory
        /// </summary>
        public static readonly ServerErrorCategory OTHER_ERROR = new ServerErrorCategory("OTHER_ERROR");
        /// <summary>
        /// Constant PERMISSION_ERROR for ServerErrorCategory
        /// </summary>
        public static readonly ServerErrorCategory PERMISSION_ERROR = new ServerErrorCategory("PERMISSION_ERROR");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ServerErrorCategory(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ServerErrorCategory FindValue(string value)
        {
            return FindValue<ServerErrorCategory>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ServerErrorCategory(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ServerOsType.
    /// </summary>
    public class ServerOsType : ConstantClass
    {

        /// <summary>
        /// Constant AmazonLinux for ServerOsType
        /// </summary>
        public static readonly ServerOsType AmazonLinux = new ServerOsType("AmazonLinux");
        /// <summary>
        /// Constant EndOfSupportWindowsServer for ServerOsType
        /// </summary>
        public static readonly ServerOsType EndOfSupportWindowsServer = new ServerOsType("EndOfSupportWindowsServer");
        /// <summary>
        /// Constant Other for ServerOsType
        /// </summary>
        public static readonly ServerOsType Other = new ServerOsType("Other");
        /// <summary>
        /// Constant Redhat for ServerOsType
        /// </summary>
        public static readonly ServerOsType Redhat = new ServerOsType("Redhat");
        /// <summary>
        /// Constant WindowsServer for ServerOsType
        /// </summary>
        public static readonly ServerOsType WindowsServer = new ServerOsType("WindowsServer");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ServerOsType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ServerOsType FindValue(string value)
        {
            return FindValue<ServerOsType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ServerOsType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Severity.
    /// </summary>
    public class Severity : ConstantClass
    {

        /// <summary>
        /// Constant HIGH for Severity
        /// </summary>
        public static readonly Severity HIGH = new Severity("HIGH");
        /// <summary>
        /// Constant LOW for Severity
        /// </summary>
        public static readonly Severity LOW = new Severity("LOW");
        /// <summary>
        /// Constant MEDIUM for Severity
        /// </summary>
        public static readonly Severity MEDIUM = new Severity("MEDIUM");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Severity(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Severity FindValue(string value)
        {
            return FindValue<Severity>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Severity(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SortOrder.
    /// </summary>
    public class SortOrder : ConstantClass
    {

        /// <summary>
        /// Constant ASC for SortOrder
        /// </summary>
        public static readonly SortOrder ASC = new SortOrder("ASC");
        /// <summary>
        /// Constant DESC for SortOrder
        /// </summary>
        public static readonly SortOrder DESC = new SortOrder("DESC");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SortOrder(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SortOrder FindValue(string value)
        {
            return FindValue<SortOrder>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SortOrder(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SrcCodeOrDbAnalysisStatus.
    /// </summary>
    public class SrcCodeOrDbAnalysisStatus : ConstantClass
    {

        /// <summary>
        /// Constant ANALYSIS_FAILED for SrcCodeOrDbAnalysisStatus
        /// </summary>
        public static readonly SrcCodeOrDbAnalysisStatus ANALYSIS_FAILED = new SrcCodeOrDbAnalysisStatus("ANALYSIS_FAILED");
        /// <summary>
        /// Constant ANALYSIS_PARTIAL_SUCCESS for SrcCodeOrDbAnalysisStatus
        /// </summary>
        public static readonly SrcCodeOrDbAnalysisStatus ANALYSIS_PARTIAL_SUCCESS = new SrcCodeOrDbAnalysisStatus("ANALYSIS_PARTIAL_SUCCESS");
        /// <summary>
        /// Constant ANALYSIS_STARTED for SrcCodeOrDbAnalysisStatus
        /// </summary>
        public static readonly SrcCodeOrDbAnalysisStatus ANALYSIS_STARTED = new SrcCodeOrDbAnalysisStatus("ANALYSIS_STARTED");
        /// <summary>
        /// Constant ANALYSIS_SUCCESS for SrcCodeOrDbAnalysisStatus
        /// </summary>
        public static readonly SrcCodeOrDbAnalysisStatus ANALYSIS_SUCCESS = new SrcCodeOrDbAnalysisStatus("ANALYSIS_SUCCESS");
        /// <summary>
        /// Constant ANALYSIS_TO_BE_SCHEDULED for SrcCodeOrDbAnalysisStatus
        /// </summary>
        public static readonly SrcCodeOrDbAnalysisStatus ANALYSIS_TO_BE_SCHEDULED = new SrcCodeOrDbAnalysisStatus("ANALYSIS_TO_BE_SCHEDULED");
        /// <summary>
        /// Constant CONFIGURED for SrcCodeOrDbAnalysisStatus
        /// </summary>
        public static readonly SrcCodeOrDbAnalysisStatus CONFIGURED = new SrcCodeOrDbAnalysisStatus("CONFIGURED");
        /// <summary>
        /// Constant UNCONFIGURED for SrcCodeOrDbAnalysisStatus
        /// </summary>
        public static readonly SrcCodeOrDbAnalysisStatus UNCONFIGURED = new SrcCodeOrDbAnalysisStatus("UNCONFIGURED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SrcCodeOrDbAnalysisStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SrcCodeOrDbAnalysisStatus FindValue(string value)
        {
            return FindValue<SrcCodeOrDbAnalysisStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SrcCodeOrDbAnalysisStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Strategy.
    /// </summary>
    public class Strategy : ConstantClass
    {

        /// <summary>
        /// Constant Refactor for Strategy
        /// </summary>
        public static readonly Strategy Refactor = new Strategy("Refactor");
        /// <summary>
        /// Constant Rehost for Strategy
        /// </summary>
        public static readonly Strategy Rehost = new Strategy("Rehost");
        /// <summary>
        /// Constant Relocate for Strategy
        /// </summary>
        public static readonly Strategy Relocate = new Strategy("Relocate");
        /// <summary>
        /// Constant Replatform for Strategy
        /// </summary>
        public static readonly Strategy Replatform = new Strategy("Replatform");
        /// <summary>
        /// Constant Repurchase for Strategy
        /// </summary>
        public static readonly Strategy Repurchase = new Strategy("Repurchase");
        /// <summary>
        /// Constant Retain for Strategy
        /// </summary>
        public static readonly Strategy Retain = new Strategy("Retain");
        /// <summary>
        /// Constant Retirement for Strategy
        /// </summary>
        public static readonly Strategy Retirement = new Strategy("Retirement");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Strategy(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Strategy FindValue(string value)
        {
            return FindValue<Strategy>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Strategy(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type StrategyRecommendation.
    /// </summary>
    public class StrategyRecommendation : ConstantClass
    {

        /// <summary>
        /// Constant NotRecommended for StrategyRecommendation
        /// </summary>
        public static readonly StrategyRecommendation NotRecommended = new StrategyRecommendation("notRecommended");
        /// <summary>
        /// Constant Potential for StrategyRecommendation
        /// </summary>
        public static readonly StrategyRecommendation Potential = new StrategyRecommendation("potential");
        /// <summary>
        /// Constant Recommended for StrategyRecommendation
        /// </summary>
        public static readonly StrategyRecommendation Recommended = new StrategyRecommendation("recommended");
        /// <summary>
        /// Constant ViableOption for StrategyRecommendation
        /// </summary>
        public static readonly StrategyRecommendation ViableOption = new StrategyRecommendation("viableOption");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public StrategyRecommendation(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static StrategyRecommendation FindValue(string value)
        {
            return FindValue<StrategyRecommendation>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator StrategyRecommendation(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TargetDatabaseEngine.
    /// </summary>
    public class TargetDatabaseEngine : ConstantClass
    {

        /// <summary>
        /// Constant AmazonAurora for TargetDatabaseEngine
        /// </summary>
        public static readonly TargetDatabaseEngine AmazonAurora = new TargetDatabaseEngine("Amazon Aurora");
        /// <summary>
        /// Constant AWSPostgreSQL for TargetDatabaseEngine
        /// </summary>
        public static readonly TargetDatabaseEngine AWSPostgreSQL = new TargetDatabaseEngine("AWS PostgreSQL");
        /// <summary>
        /// Constant Db2LUW for TargetDatabaseEngine
        /// </summary>
        public static readonly TargetDatabaseEngine Db2LUW = new TargetDatabaseEngine("Db2 LUW");
        /// <summary>
        /// Constant MariaDB for TargetDatabaseEngine
        /// </summary>
        public static readonly TargetDatabaseEngine MariaDB = new TargetDatabaseEngine("MariaDB");
        /// <summary>
        /// Constant MicrosoftSQLServer for TargetDatabaseEngine
        /// </summary>
        public static readonly TargetDatabaseEngine MicrosoftSQLServer = new TargetDatabaseEngine("Microsoft SQL Server");
        /// <summary>
        /// Constant MongoDB for TargetDatabaseEngine
        /// </summary>
        public static readonly TargetDatabaseEngine MongoDB = new TargetDatabaseEngine("MongoDB");
        /// <summary>
        /// Constant MySQL for TargetDatabaseEngine
        /// </summary>
        public static readonly TargetDatabaseEngine MySQL = new TargetDatabaseEngine("MySQL");
        /// <summary>
        /// Constant NoneSpecified for TargetDatabaseEngine
        /// </summary>
        public static readonly TargetDatabaseEngine NoneSpecified = new TargetDatabaseEngine("None specified");
        /// <summary>
        /// Constant OracleDatabase for TargetDatabaseEngine
        /// </summary>
        public static readonly TargetDatabaseEngine OracleDatabase = new TargetDatabaseEngine("Oracle Database");
        /// <summary>
        /// Constant SAP for TargetDatabaseEngine
        /// </summary>
        public static readonly TargetDatabaseEngine SAP = new TargetDatabaseEngine("SAP");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TargetDatabaseEngine(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TargetDatabaseEngine FindValue(string value)
        {
            return FindValue<TargetDatabaseEngine>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TargetDatabaseEngine(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TargetDestination.
    /// </summary>
    public class TargetDestination : ConstantClass
    {

        /// <summary>
        /// Constant AmazonDocumentDB for TargetDestination
        /// </summary>
        public static readonly TargetDestination AmazonDocumentDB = new TargetDestination("Amazon DocumentDB");
        /// <summary>
        /// Constant AmazonDynamoDB for TargetDestination
        /// </summary>
        public static readonly TargetDestination AmazonDynamoDB = new TargetDestination("Amazon DynamoDB");
        /// <summary>
        /// Constant AmazonElasticCloudComputeEC2 for TargetDestination
        /// </summary>
        public static readonly TargetDestination AmazonElasticCloudComputeEC2 = new TargetDestination("Amazon Elastic Cloud Compute (EC2)");
        /// <summary>
        /// Constant AmazonElasticContainerServiceECS for TargetDestination
        /// </summary>
        public static readonly TargetDestination AmazonElasticContainerServiceECS = new TargetDestination("Amazon Elastic Container Service (ECS)");
        /// <summary>
        /// Constant AmazonElasticKubernetesServiceEKS for TargetDestination
        /// </summary>
        public static readonly TargetDestination AmazonElasticKubernetesServiceEKS = new TargetDestination("Amazon Elastic Kubernetes Service (EKS)");
        /// <summary>
        /// Constant AmazonRelationalDatabaseService for TargetDestination
        /// </summary>
        public static readonly TargetDestination AmazonRelationalDatabaseService = new TargetDestination("Amazon Relational Database Service");
        /// <summary>
        /// Constant AmazonRelationalDatabaseServiceOnMySQL for TargetDestination
        /// </summary>
        public static readonly TargetDestination AmazonRelationalDatabaseServiceOnMySQL = new TargetDestination("Amazon Relational Database Service on MySQL");
        /// <summary>
        /// Constant AmazonRelationalDatabaseServiceOnPostgreSQL for TargetDestination
        /// </summary>
        public static readonly TargetDestination AmazonRelationalDatabaseServiceOnPostgreSQL = new TargetDestination("Amazon Relational Database Service on PostgreSQL");
        /// <summary>
        /// Constant AuroraMySQL for TargetDestination
        /// </summary>
        public static readonly TargetDestination AuroraMySQL = new TargetDestination("Aurora MySQL");
        /// <summary>
        /// Constant AuroraPostgreSQL for TargetDestination
        /// </summary>
        public static readonly TargetDestination AuroraPostgreSQL = new TargetDestination("Aurora PostgreSQL");
        /// <summary>
        /// Constant AWSElasticBeanStalk for TargetDestination
        /// </summary>
        public static readonly TargetDestination AWSElasticBeanStalk = new TargetDestination("AWS Elastic BeanStalk");
        /// <summary>
        /// Constant AWSFargate for TargetDestination
        /// </summary>
        public static readonly TargetDestination AWSFargate = new TargetDestination("AWS Fargate");
        /// <summary>
        /// Constant BabelfishForAuroraPostgreSQL for TargetDestination
        /// </summary>
        public static readonly TargetDestination BabelfishForAuroraPostgreSQL = new TargetDestination("Babelfish for Aurora PostgreSQL");
        /// <summary>
        /// Constant NoneSpecified for TargetDestination
        /// </summary>
        public static readonly TargetDestination NoneSpecified = new TargetDestination("None specified");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TargetDestination(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TargetDestination FindValue(string value)
        {
            return FindValue<TargetDestination>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TargetDestination(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TransformationToolName.
    /// </summary>
    public class TransformationToolName : ConstantClass
    {

        /// <summary>
        /// Constant App2Container for TransformationToolName
        /// </summary>
        public static readonly TransformationToolName App2Container = new TransformationToolName("App2Container");
        /// <summary>
        /// Constant ApplicationMigrationService for TransformationToolName
        /// </summary>
        public static readonly TransformationToolName ApplicationMigrationService = new TransformationToolName("Application Migration Service");
        /// <summary>
        /// Constant DatabaseMigrationService for TransformationToolName
        /// </summary>
        public static readonly TransformationToolName DatabaseMigrationService = new TransformationToolName("Database Migration Service");
        /// <summary>
        /// Constant EndOfSupportMigration for TransformationToolName
        /// </summary>
        public static readonly TransformationToolName EndOfSupportMigration = new TransformationToolName("End of Support Migration");
        /// <summary>
        /// Constant InPlaceOperatingSystemUpgrade for TransformationToolName
        /// </summary>
        public static readonly TransformationToolName InPlaceOperatingSystemUpgrade = new TransformationToolName("In Place Operating System Upgrade");
        /// <summary>
        /// Constant NativeSQLServerBackupRestore for TransformationToolName
        /// </summary>
        public static readonly TransformationToolName NativeSQLServerBackupRestore = new TransformationToolName("Native SQL Server Backup/Restore");
        /// <summary>
        /// Constant PortingAssistantForNET for TransformationToolName
        /// </summary>
        public static readonly TransformationToolName PortingAssistantForNET = new TransformationToolName("Porting Assistant For .NET");
        /// <summary>
        /// Constant SchemaConversionTool for TransformationToolName
        /// </summary>
        public static readonly TransformationToolName SchemaConversionTool = new TransformationToolName("Schema Conversion Tool");
        /// <summary>
        /// Constant StrategyRecommendationSupport for TransformationToolName
        /// </summary>
        public static readonly TransformationToolName StrategyRecommendationSupport = new TransformationToolName("Strategy Recommendation Support");
        /// <summary>
        /// Constant WindowsWebApplicationMigrationAssistant for TransformationToolName
        /// </summary>
        public static readonly TransformationToolName WindowsWebApplicationMigrationAssistant = new TransformationToolName("Windows Web Application Migration Assistant");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TransformationToolName(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TransformationToolName FindValue(string value)
        {
            return FindValue<TransformationToolName>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TransformationToolName(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type VersionControl.
    /// </summary>
    public class VersionControl : ConstantClass
    {

        /// <summary>
        /// Constant AZURE_DEVOPS_GIT for VersionControl
        /// </summary>
        public static readonly VersionControl AZURE_DEVOPS_GIT = new VersionControl("AZURE_DEVOPS_GIT");
        /// <summary>
        /// Constant GITHUB for VersionControl
        /// </summary>
        public static readonly VersionControl GITHUB = new VersionControl("GITHUB");
        /// <summary>
        /// Constant GITHUB_ENTERPRISE for VersionControl
        /// </summary>
        public static readonly VersionControl GITHUB_ENTERPRISE = new VersionControl("GITHUB_ENTERPRISE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public VersionControl(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static VersionControl FindValue(string value)
        {
            return FindValue<VersionControl>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator VersionControl(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type VersionControlType.
    /// </summary>
    public class VersionControlType : ConstantClass
    {

        /// <summary>
        /// Constant AZURE_DEVOPS_GIT for VersionControlType
        /// </summary>
        public static readonly VersionControlType AZURE_DEVOPS_GIT = new VersionControlType("AZURE_DEVOPS_GIT");
        /// <summary>
        /// Constant GITHUB for VersionControlType
        /// </summary>
        public static readonly VersionControlType GITHUB = new VersionControlType("GITHUB");
        /// <summary>
        /// Constant GITHUB_ENTERPRISE for VersionControlType
        /// </summary>
        public static readonly VersionControlType GITHUB_ENTERPRISE = new VersionControlType("GITHUB_ENTERPRISE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public VersionControlType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static VersionControlType FindValue(string value)
        {
            return FindValue<VersionControlType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator VersionControlType(string value)
        {
            return FindValue(value);
        }
    }

}