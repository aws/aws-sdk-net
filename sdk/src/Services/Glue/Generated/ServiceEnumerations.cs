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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.Glue
{

    /// <summary>
    /// Constants used for properties of type ConnectionPropertyKey.
    /// </summary>
    public class ConnectionPropertyKey : ConstantClass
    {

        /// <summary>
        /// Constant CONFIG_FILES for ConnectionPropertyKey
        /// </summary>
        public static readonly ConnectionPropertyKey CONFIG_FILES = new ConnectionPropertyKey("CONFIG_FILES");
        /// <summary>
        /// Constant HOST for ConnectionPropertyKey
        /// </summary>
        public static readonly ConnectionPropertyKey HOST = new ConnectionPropertyKey("HOST");
        /// <summary>
        /// Constant INSTANCE_ID for ConnectionPropertyKey
        /// </summary>
        public static readonly ConnectionPropertyKey INSTANCE_ID = new ConnectionPropertyKey("INSTANCE_ID");
        /// <summary>
        /// Constant JDBC_CONNECTION_URL for ConnectionPropertyKey
        /// </summary>
        public static readonly ConnectionPropertyKey JDBC_CONNECTION_URL = new ConnectionPropertyKey("JDBC_CONNECTION_URL");
        /// <summary>
        /// Constant JDBC_DRIVER_CLASS_NAME for ConnectionPropertyKey
        /// </summary>
        public static readonly ConnectionPropertyKey JDBC_DRIVER_CLASS_NAME = new ConnectionPropertyKey("JDBC_DRIVER_CLASS_NAME");
        /// <summary>
        /// Constant JDBC_DRIVER_JAR_URI for ConnectionPropertyKey
        /// </summary>
        public static readonly ConnectionPropertyKey JDBC_DRIVER_JAR_URI = new ConnectionPropertyKey("JDBC_DRIVER_JAR_URI");
        /// <summary>
        /// Constant JDBC_ENGINE for ConnectionPropertyKey
        /// </summary>
        public static readonly ConnectionPropertyKey JDBC_ENGINE = new ConnectionPropertyKey("JDBC_ENGINE");
        /// <summary>
        /// Constant JDBC_ENGINE_VERSION for ConnectionPropertyKey
        /// </summary>
        public static readonly ConnectionPropertyKey JDBC_ENGINE_VERSION = new ConnectionPropertyKey("JDBC_ENGINE_VERSION");
        /// <summary>
        /// Constant PASSWORD for ConnectionPropertyKey
        /// </summary>
        public static readonly ConnectionPropertyKey PASSWORD = new ConnectionPropertyKey("PASSWORD");
        /// <summary>
        /// Constant PORT for ConnectionPropertyKey
        /// </summary>
        public static readonly ConnectionPropertyKey PORT = new ConnectionPropertyKey("PORT");
        /// <summary>
        /// Constant USERNAME for ConnectionPropertyKey
        /// </summary>
        public static readonly ConnectionPropertyKey USERNAME = new ConnectionPropertyKey("USERNAME");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ConnectionPropertyKey(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ConnectionPropertyKey FindValue(string value)
        {
            return FindValue<ConnectionPropertyKey>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ConnectionPropertyKey(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ConnectionType.
    /// </summary>
    public class ConnectionType : ConstantClass
    {

        /// <summary>
        /// Constant JDBC for ConnectionType
        /// </summary>
        public static readonly ConnectionType JDBC = new ConnectionType("JDBC");
        /// <summary>
        /// Constant SFTP for ConnectionType
        /// </summary>
        public static readonly ConnectionType SFTP = new ConnectionType("SFTP");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ConnectionType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ConnectionType FindValue(string value)
        {
            return FindValue<ConnectionType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ConnectionType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CrawlerState.
    /// </summary>
    public class CrawlerState : ConstantClass
    {

        /// <summary>
        /// Constant READY for CrawlerState
        /// </summary>
        public static readonly CrawlerState READY = new CrawlerState("READY");
        /// <summary>
        /// Constant RUNNING for CrawlerState
        /// </summary>
        public static readonly CrawlerState RUNNING = new CrawlerState("RUNNING");
        /// <summary>
        /// Constant STOPPING for CrawlerState
        /// </summary>
        public static readonly CrawlerState STOPPING = new CrawlerState("STOPPING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CrawlerState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CrawlerState FindValue(string value)
        {
            return FindValue<CrawlerState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CrawlerState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DeleteBehavior.
    /// </summary>
    public class DeleteBehavior : ConstantClass
    {

        /// <summary>
        /// Constant DELETE_FROM_DATABASE for DeleteBehavior
        /// </summary>
        public static readonly DeleteBehavior DELETE_FROM_DATABASE = new DeleteBehavior("DELETE_FROM_DATABASE");
        /// <summary>
        /// Constant DEPRECATE_IN_DATABASE for DeleteBehavior
        /// </summary>
        public static readonly DeleteBehavior DEPRECATE_IN_DATABASE = new DeleteBehavior("DEPRECATE_IN_DATABASE");
        /// <summary>
        /// Constant LOG for DeleteBehavior
        /// </summary>
        public static readonly DeleteBehavior LOG = new DeleteBehavior("LOG");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DeleteBehavior(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DeleteBehavior FindValue(string value)
        {
            return FindValue<DeleteBehavior>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DeleteBehavior(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type JobRunState.
    /// </summary>
    public class JobRunState : ConstantClass
    {

        /// <summary>
        /// Constant FAILED for JobRunState
        /// </summary>
        public static readonly JobRunState FAILED = new JobRunState("FAILED");
        /// <summary>
        /// Constant RUNNING for JobRunState
        /// </summary>
        public static readonly JobRunState RUNNING = new JobRunState("RUNNING");
        /// <summary>
        /// Constant STARTING for JobRunState
        /// </summary>
        public static readonly JobRunState STARTING = new JobRunState("STARTING");
        /// <summary>
        /// Constant STOPPED for JobRunState
        /// </summary>
        public static readonly JobRunState STOPPED = new JobRunState("STOPPED");
        /// <summary>
        /// Constant STOPPING for JobRunState
        /// </summary>
        public static readonly JobRunState STOPPING = new JobRunState("STOPPING");
        /// <summary>
        /// Constant SUCCEEDED for JobRunState
        /// </summary>
        public static readonly JobRunState SUCCEEDED = new JobRunState("SUCCEEDED");
        /// <summary>
        /// Constant TIMEOUT for JobRunState
        /// </summary>
        public static readonly JobRunState TIMEOUT = new JobRunState("TIMEOUT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public JobRunState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static JobRunState FindValue(string value)
        {
            return FindValue<JobRunState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator JobRunState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Language.
    /// </summary>
    public class Language : ConstantClass
    {

        /// <summary>
        /// Constant PYTHON for Language
        /// </summary>
        public static readonly Language PYTHON = new Language("PYTHON");
        /// <summary>
        /// Constant SCALA for Language
        /// </summary>
        public static readonly Language SCALA = new Language("SCALA");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Language(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Language FindValue(string value)
        {
            return FindValue<Language>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Language(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type LastCrawlStatus.
    /// </summary>
    public class LastCrawlStatus : ConstantClass
    {

        /// <summary>
        /// Constant CANCELLED for LastCrawlStatus
        /// </summary>
        public static readonly LastCrawlStatus CANCELLED = new LastCrawlStatus("CANCELLED");
        /// <summary>
        /// Constant FAILED for LastCrawlStatus
        /// </summary>
        public static readonly LastCrawlStatus FAILED = new LastCrawlStatus("FAILED");
        /// <summary>
        /// Constant SUCCEEDED for LastCrawlStatus
        /// </summary>
        public static readonly LastCrawlStatus SUCCEEDED = new LastCrawlStatus("SUCCEEDED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public LastCrawlStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LastCrawlStatus FindValue(string value)
        {
            return FindValue<LastCrawlStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator LastCrawlStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Logical.
    /// </summary>
    public class Logical : ConstantClass
    {

        /// <summary>
        /// Constant AND for Logical
        /// </summary>
        public static readonly Logical AND = new Logical("AND");
        /// <summary>
        /// Constant ANY for Logical
        /// </summary>
        public static readonly Logical ANY = new Logical("ANY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Logical(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Logical FindValue(string value)
        {
            return FindValue<Logical>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Logical(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type LogicalOperator.
    /// </summary>
    public class LogicalOperator : ConstantClass
    {

        /// <summary>
        /// Constant EQUALS for LogicalOperator
        /// </summary>
        public static readonly LogicalOperator EQUALS = new LogicalOperator("EQUALS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public LogicalOperator(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LogicalOperator FindValue(string value)
        {
            return FindValue<LogicalOperator>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator LogicalOperator(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PrincipalType.
    /// </summary>
    public class PrincipalType : ConstantClass
    {

        /// <summary>
        /// Constant GROUP for PrincipalType
        /// </summary>
        public static readonly PrincipalType GROUP = new PrincipalType("GROUP");
        /// <summary>
        /// Constant ROLE for PrincipalType
        /// </summary>
        public static readonly PrincipalType ROLE = new PrincipalType("ROLE");
        /// <summary>
        /// Constant USER for PrincipalType
        /// </summary>
        public static readonly PrincipalType USER = new PrincipalType("USER");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PrincipalType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PrincipalType FindValue(string value)
        {
            return FindValue<PrincipalType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PrincipalType(string value)
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
        /// Constant ARCHIVE for ResourceType
        /// </summary>
        public static readonly ResourceType ARCHIVE = new ResourceType("ARCHIVE");
        /// <summary>
        /// Constant FILE for ResourceType
        /// </summary>
        public static readonly ResourceType FILE = new ResourceType("FILE");
        /// <summary>
        /// Constant JAR for ResourceType
        /// </summary>
        public static readonly ResourceType JAR = new ResourceType("JAR");

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
    /// Constants used for properties of type ScheduleState.
    /// </summary>
    public class ScheduleState : ConstantClass
    {

        /// <summary>
        /// Constant NOT_SCHEDULED for ScheduleState
        /// </summary>
        public static readonly ScheduleState NOT_SCHEDULED = new ScheduleState("NOT_SCHEDULED");
        /// <summary>
        /// Constant SCHEDULED for ScheduleState
        /// </summary>
        public static readonly ScheduleState SCHEDULED = new ScheduleState("SCHEDULED");
        /// <summary>
        /// Constant TRANSITIONING for ScheduleState
        /// </summary>
        public static readonly ScheduleState TRANSITIONING = new ScheduleState("TRANSITIONING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ScheduleState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ScheduleState FindValue(string value)
        {
            return FindValue<ScheduleState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ScheduleState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TriggerState.
    /// </summary>
    public class TriggerState : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVATED for TriggerState
        /// </summary>
        public static readonly TriggerState ACTIVATED = new TriggerState("ACTIVATED");
        /// <summary>
        /// Constant ACTIVATING for TriggerState
        /// </summary>
        public static readonly TriggerState ACTIVATING = new TriggerState("ACTIVATING");
        /// <summary>
        /// Constant CREATED for TriggerState
        /// </summary>
        public static readonly TriggerState CREATED = new TriggerState("CREATED");
        /// <summary>
        /// Constant CREATING for TriggerState
        /// </summary>
        public static readonly TriggerState CREATING = new TriggerState("CREATING");
        /// <summary>
        /// Constant DEACTIVATED for TriggerState
        /// </summary>
        public static readonly TriggerState DEACTIVATED = new TriggerState("DEACTIVATED");
        /// <summary>
        /// Constant DEACTIVATING for TriggerState
        /// </summary>
        public static readonly TriggerState DEACTIVATING = new TriggerState("DEACTIVATING");
        /// <summary>
        /// Constant DELETING for TriggerState
        /// </summary>
        public static readonly TriggerState DELETING = new TriggerState("DELETING");
        /// <summary>
        /// Constant UPDATING for TriggerState
        /// </summary>
        public static readonly TriggerState UPDATING = new TriggerState("UPDATING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TriggerState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TriggerState FindValue(string value)
        {
            return FindValue<TriggerState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TriggerState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TriggerType.
    /// </summary>
    public class TriggerType : ConstantClass
    {

        /// <summary>
        /// Constant CONDITIONAL for TriggerType
        /// </summary>
        public static readonly TriggerType CONDITIONAL = new TriggerType("CONDITIONAL");
        /// <summary>
        /// Constant ON_DEMAND for TriggerType
        /// </summary>
        public static readonly TriggerType ON_DEMAND = new TriggerType("ON_DEMAND");
        /// <summary>
        /// Constant SCHEDULED for TriggerType
        /// </summary>
        public static readonly TriggerType SCHEDULED = new TriggerType("SCHEDULED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TriggerType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TriggerType FindValue(string value)
        {
            return FindValue<TriggerType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TriggerType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type UpdateBehavior.
    /// </summary>
    public class UpdateBehavior : ConstantClass
    {

        /// <summary>
        /// Constant LOG for UpdateBehavior
        /// </summary>
        public static readonly UpdateBehavior LOG = new UpdateBehavior("LOG");
        /// <summary>
        /// Constant UPDATE_IN_DATABASE for UpdateBehavior
        /// </summary>
        public static readonly UpdateBehavior UPDATE_IN_DATABASE = new UpdateBehavior("UPDATE_IN_DATABASE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public UpdateBehavior(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static UpdateBehavior FindValue(string value)
        {
            return FindValue<UpdateBehavior>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator UpdateBehavior(string value)
        {
            return FindValue(value);
        }
    }

}