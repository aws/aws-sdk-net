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
 * Do not modify this file. This file is generated from the iot-2015-05-28.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.IoT
{

    /// <summary>
    /// Constants used for properties of type ActionType.
    /// </summary>
    public class ActionType : ConstantClass
    {

        /// <summary>
        /// Constant CONNECT for ActionType
        /// </summary>
        public static readonly ActionType CONNECT = new ActionType("CONNECT");
        /// <summary>
        /// Constant PUBLISH for ActionType
        /// </summary>
        public static readonly ActionType PUBLISH = new ActionType("PUBLISH");
        /// <summary>
        /// Constant RECEIVE for ActionType
        /// </summary>
        public static readonly ActionType RECEIVE = new ActionType("RECEIVE");
        /// <summary>
        /// Constant SUBSCRIBE for ActionType
        /// </summary>
        public static readonly ActionType SUBSCRIBE = new ActionType("SUBSCRIBE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ActionType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ActionType FindValue(string value)
        {
            return FindValue<ActionType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ActionType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AuthDecision.
    /// </summary>
    public class AuthDecision : ConstantClass
    {

        /// <summary>
        /// Constant ALLOWED for AuthDecision
        /// </summary>
        public static readonly AuthDecision ALLOWED = new AuthDecision("ALLOWED");
        /// <summary>
        /// Constant EXPLICIT_DENY for AuthDecision
        /// </summary>
        public static readonly AuthDecision EXPLICIT_DENY = new AuthDecision("EXPLICIT_DENY");
        /// <summary>
        /// Constant IMPLICIT_DENY for AuthDecision
        /// </summary>
        public static readonly AuthDecision IMPLICIT_DENY = new AuthDecision("IMPLICIT_DENY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AuthDecision(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AuthDecision FindValue(string value)
        {
            return FindValue<AuthDecision>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AuthDecision(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AuthorizerStatus.
    /// </summary>
    public class AuthorizerStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for AuthorizerStatus
        /// </summary>
        public static readonly AuthorizerStatus ACTIVE = new AuthorizerStatus("ACTIVE");
        /// <summary>
        /// Constant INACTIVE for AuthorizerStatus
        /// </summary>
        public static readonly AuthorizerStatus INACTIVE = new AuthorizerStatus("INACTIVE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AuthorizerStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AuthorizerStatus FindValue(string value)
        {
            return FindValue<AuthorizerStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AuthorizerStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AutoRegistrationStatus.
    /// </summary>
    public class AutoRegistrationStatus : ConstantClass
    {

        /// <summary>
        /// Constant DISABLE for AutoRegistrationStatus
        /// </summary>
        public static readonly AutoRegistrationStatus DISABLE = new AutoRegistrationStatus("DISABLE");
        /// <summary>
        /// Constant ENABLE for AutoRegistrationStatus
        /// </summary>
        public static readonly AutoRegistrationStatus ENABLE = new AutoRegistrationStatus("ENABLE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AutoRegistrationStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AutoRegistrationStatus FindValue(string value)
        {
            return FindValue<AutoRegistrationStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AutoRegistrationStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CACertificateStatus.
    /// </summary>
    public class CACertificateStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for CACertificateStatus
        /// </summary>
        public static readonly CACertificateStatus ACTIVE = new CACertificateStatus("ACTIVE");
        /// <summary>
        /// Constant INACTIVE for CACertificateStatus
        /// </summary>
        public static readonly CACertificateStatus INACTIVE = new CACertificateStatus("INACTIVE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CACertificateStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CACertificateStatus FindValue(string value)
        {
            return FindValue<CACertificateStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CACertificateStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CannedAccessControlList.
    /// </summary>
    public class CannedAccessControlList : ConstantClass
    {

        /// <summary>
        /// Constant AuthenticatedRead for CannedAccessControlList
        /// </summary>
        public static readonly CannedAccessControlList AuthenticatedRead = new CannedAccessControlList("authenticated-read");
        /// <summary>
        /// Constant AwsExecRead for CannedAccessControlList
        /// </summary>
        public static readonly CannedAccessControlList AwsExecRead = new CannedAccessControlList("aws-exec-read");
        /// <summary>
        /// Constant BucketOwnerFullControl for CannedAccessControlList
        /// </summary>
        public static readonly CannedAccessControlList BucketOwnerFullControl = new CannedAccessControlList("bucket-owner-full-control");
        /// <summary>
        /// Constant BucketOwnerRead for CannedAccessControlList
        /// </summary>
        public static readonly CannedAccessControlList BucketOwnerRead = new CannedAccessControlList("bucket-owner-read");
        /// <summary>
        /// Constant LogDeliveryWrite for CannedAccessControlList
        /// </summary>
        public static readonly CannedAccessControlList LogDeliveryWrite = new CannedAccessControlList("log-delivery-write");
        /// <summary>
        /// Constant Private for CannedAccessControlList
        /// </summary>
        public static readonly CannedAccessControlList Private = new CannedAccessControlList("private");
        /// <summary>
        /// Constant PublicRead for CannedAccessControlList
        /// </summary>
        public static readonly CannedAccessControlList PublicRead = new CannedAccessControlList("public-read");
        /// <summary>
        /// Constant PublicReadWrite for CannedAccessControlList
        /// </summary>
        public static readonly CannedAccessControlList PublicReadWrite = new CannedAccessControlList("public-read-write");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CannedAccessControlList(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CannedAccessControlList FindValue(string value)
        {
            return FindValue<CannedAccessControlList>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CannedAccessControlList(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CertificateStatus.
    /// </summary>
    public class CertificateStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for CertificateStatus
        /// </summary>
        public static readonly CertificateStatus ACTIVE = new CertificateStatus("ACTIVE");
        /// <summary>
        /// Constant INACTIVE for CertificateStatus
        /// </summary>
        public static readonly CertificateStatus INACTIVE = new CertificateStatus("INACTIVE");
        /// <summary>
        /// Constant PENDING_ACTIVATION for CertificateStatus
        /// </summary>
        public static readonly CertificateStatus PENDING_ACTIVATION = new CertificateStatus("PENDING_ACTIVATION");
        /// <summary>
        /// Constant PENDING_TRANSFER for CertificateStatus
        /// </summary>
        public static readonly CertificateStatus PENDING_TRANSFER = new CertificateStatus("PENDING_TRANSFER");
        /// <summary>
        /// Constant REGISTER_INACTIVE for CertificateStatus
        /// </summary>
        public static readonly CertificateStatus REGISTER_INACTIVE = new CertificateStatus("REGISTER_INACTIVE");
        /// <summary>
        /// Constant REVOKED for CertificateStatus
        /// </summary>
        public static readonly CertificateStatus REVOKED = new CertificateStatus("REVOKED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CertificateStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CertificateStatus FindValue(string value)
        {
            return FindValue<CertificateStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CertificateStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DynamoKeyType.
    /// </summary>
    public class DynamoKeyType : ConstantClass
    {

        /// <summary>
        /// Constant NUMBER for DynamoKeyType
        /// </summary>
        public static readonly DynamoKeyType NUMBER = new DynamoKeyType("NUMBER");
        /// <summary>
        /// Constant STRING for DynamoKeyType
        /// </summary>
        public static readonly DynamoKeyType STRING = new DynamoKeyType("STRING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DynamoKeyType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DynamoKeyType FindValue(string value)
        {
            return FindValue<DynamoKeyType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DynamoKeyType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type EventType.
    /// </summary>
    public class EventType : ConstantClass
    {

        /// <summary>
        /// Constant JOB for EventType
        /// </summary>
        public static readonly EventType JOB = new EventType("JOB");
        /// <summary>
        /// Constant JOB_EXECUTION for EventType
        /// </summary>
        public static readonly EventType JOB_EXECUTION = new EventType("JOB_EXECUTION");
        /// <summary>
        /// Constant THING for EventType
        /// </summary>
        public static readonly EventType THING = new EventType("THING");
        /// <summary>
        /// Constant THING_GROUP for EventType
        /// </summary>
        public static readonly EventType THING_GROUP = new EventType("THING_GROUP");
        /// <summary>
        /// Constant THING_GROUP_HIERARCHY for EventType
        /// </summary>
        public static readonly EventType THING_GROUP_HIERARCHY = new EventType("THING_GROUP_HIERARCHY");
        /// <summary>
        /// Constant THING_GROUP_MEMBERSHIP for EventType
        /// </summary>
        public static readonly EventType THING_GROUP_MEMBERSHIP = new EventType("THING_GROUP_MEMBERSHIP");
        /// <summary>
        /// Constant THING_TYPE for EventType
        /// </summary>
        public static readonly EventType THING_TYPE = new EventType("THING_TYPE");
        /// <summary>
        /// Constant THING_TYPE_ASSOCIATION for EventType
        /// </summary>
        public static readonly EventType THING_TYPE_ASSOCIATION = new EventType("THING_TYPE_ASSOCIATION");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EventType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EventType FindValue(string value)
        {
            return FindValue<EventType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EventType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type IndexStatus.
    /// </summary>
    public class IndexStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for IndexStatus
        /// </summary>
        public static readonly IndexStatus ACTIVE = new IndexStatus("ACTIVE");
        /// <summary>
        /// Constant BUILDING for IndexStatus
        /// </summary>
        public static readonly IndexStatus BUILDING = new IndexStatus("BUILDING");
        /// <summary>
        /// Constant REBUILDING for IndexStatus
        /// </summary>
        public static readonly IndexStatus REBUILDING = new IndexStatus("REBUILDING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public IndexStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static IndexStatus FindValue(string value)
        {
            return FindValue<IndexStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator IndexStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type JobExecutionStatus.
    /// </summary>
    public class JobExecutionStatus : ConstantClass
    {

        /// <summary>
        /// Constant CANCELED for JobExecutionStatus
        /// </summary>
        public static readonly JobExecutionStatus CANCELED = new JobExecutionStatus("CANCELED");
        /// <summary>
        /// Constant FAILED for JobExecutionStatus
        /// </summary>
        public static readonly JobExecutionStatus FAILED = new JobExecutionStatus("FAILED");
        /// <summary>
        /// Constant IN_PROGRESS for JobExecutionStatus
        /// </summary>
        public static readonly JobExecutionStatus IN_PROGRESS = new JobExecutionStatus("IN_PROGRESS");
        /// <summary>
        /// Constant QUEUED for JobExecutionStatus
        /// </summary>
        public static readonly JobExecutionStatus QUEUED = new JobExecutionStatus("QUEUED");
        /// <summary>
        /// Constant REJECTED for JobExecutionStatus
        /// </summary>
        public static readonly JobExecutionStatus REJECTED = new JobExecutionStatus("REJECTED");
        /// <summary>
        /// Constant REMOVED for JobExecutionStatus
        /// </summary>
        public static readonly JobExecutionStatus REMOVED = new JobExecutionStatus("REMOVED");
        /// <summary>
        /// Constant SUCCEEDED for JobExecutionStatus
        /// </summary>
        public static readonly JobExecutionStatus SUCCEEDED = new JobExecutionStatus("SUCCEEDED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public JobExecutionStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static JobExecutionStatus FindValue(string value)
        {
            return FindValue<JobExecutionStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator JobExecutionStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type JobStatus.
    /// </summary>
    public class JobStatus : ConstantClass
    {

        /// <summary>
        /// Constant CANCELED for JobStatus
        /// </summary>
        public static readonly JobStatus CANCELED = new JobStatus("CANCELED");
        /// <summary>
        /// Constant COMPLETED for JobStatus
        /// </summary>
        public static readonly JobStatus COMPLETED = new JobStatus("COMPLETED");
        /// <summary>
        /// Constant DELETION_IN_PROGRESS for JobStatus
        /// </summary>
        public static readonly JobStatus DELETION_IN_PROGRESS = new JobStatus("DELETION_IN_PROGRESS");
        /// <summary>
        /// Constant IN_PROGRESS for JobStatus
        /// </summary>
        public static readonly JobStatus IN_PROGRESS = new JobStatus("IN_PROGRESS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public JobStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static JobStatus FindValue(string value)
        {
            return FindValue<JobStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator JobStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type LogLevel.
    /// </summary>
    public class LogLevel : ConstantClass
    {

        /// <summary>
        /// Constant DEBUG for LogLevel
        /// </summary>
        public static readonly LogLevel DEBUG = new LogLevel("DEBUG");
        /// <summary>
        /// Constant DISABLED for LogLevel
        /// </summary>
        public static readonly LogLevel DISABLED = new LogLevel("DISABLED");
        /// <summary>
        /// Constant ERROR for LogLevel
        /// </summary>
        public static readonly LogLevel ERROR = new LogLevel("ERROR");
        /// <summary>
        /// Constant INFO for LogLevel
        /// </summary>
        public static readonly LogLevel INFO = new LogLevel("INFO");
        /// <summary>
        /// Constant WARN for LogLevel
        /// </summary>
        public static readonly LogLevel WARN = new LogLevel("WARN");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public LogLevel(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LogLevel FindValue(string value)
        {
            return FindValue<LogLevel>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator LogLevel(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type LogTargetType.
    /// </summary>
    public class LogTargetType : ConstantClass
    {

        /// <summary>
        /// Constant DEFAULT for LogTargetType
        /// </summary>
        public static readonly LogTargetType DEFAULT = new LogTargetType("DEFAULT");
        /// <summary>
        /// Constant THING_GROUP for LogTargetType
        /// </summary>
        public static readonly LogTargetType THING_GROUP = new LogTargetType("THING_GROUP");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public LogTargetType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LogTargetType FindValue(string value)
        {
            return FindValue<LogTargetType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator LogTargetType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type MessageFormat.
    /// </summary>
    public class MessageFormat : ConstantClass
    {

        /// <summary>
        /// Constant JSON for MessageFormat
        /// </summary>
        public static readonly MessageFormat JSON = new MessageFormat("JSON");
        /// <summary>
        /// Constant RAW for MessageFormat
        /// </summary>
        public static readonly MessageFormat RAW = new MessageFormat("RAW");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MessageFormat(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MessageFormat FindValue(string value)
        {
            return FindValue<MessageFormat>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MessageFormat(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type OTAUpdateStatus.
    /// </summary>
    public class OTAUpdateStatus : ConstantClass
    {

        /// <summary>
        /// Constant CREATE_COMPLETE for OTAUpdateStatus
        /// </summary>
        public static readonly OTAUpdateStatus CREATE_COMPLETE = new OTAUpdateStatus("CREATE_COMPLETE");
        /// <summary>
        /// Constant CREATE_FAILED for OTAUpdateStatus
        /// </summary>
        public static readonly OTAUpdateStatus CREATE_FAILED = new OTAUpdateStatus("CREATE_FAILED");
        /// <summary>
        /// Constant CREATE_IN_PROGRESS for OTAUpdateStatus
        /// </summary>
        public static readonly OTAUpdateStatus CREATE_IN_PROGRESS = new OTAUpdateStatus("CREATE_IN_PROGRESS");
        /// <summary>
        /// Constant CREATE_PENDING for OTAUpdateStatus
        /// </summary>
        public static readonly OTAUpdateStatus CREATE_PENDING = new OTAUpdateStatus("CREATE_PENDING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public OTAUpdateStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static OTAUpdateStatus FindValue(string value)
        {
            return FindValue<OTAUpdateStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator OTAUpdateStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ReportType.
    /// </summary>
    public class ReportType : ConstantClass
    {

        /// <summary>
        /// Constant ERRORS for ReportType
        /// </summary>
        public static readonly ReportType ERRORS = new ReportType("ERRORS");
        /// <summary>
        /// Constant RESULTS for ReportType
        /// </summary>
        public static readonly ReportType RESULTS = new ReportType("RESULTS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ReportType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ReportType FindValue(string value)
        {
            return FindValue<ReportType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ReportType(string value)
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
        /// Constant Cancelled for Status
        /// </summary>
        public static readonly Status Cancelled = new Status("Cancelled");
        /// <summary>
        /// Constant Cancelling for Status
        /// </summary>
        public static readonly Status Cancelling = new Status("Cancelling");
        /// <summary>
        /// Constant Completed for Status
        /// </summary>
        public static readonly Status Completed = new Status("Completed");
        /// <summary>
        /// Constant Failed for Status
        /// </summary>
        public static readonly Status Failed = new Status("Failed");
        /// <summary>
        /// Constant InProgress for Status
        /// </summary>
        public static readonly Status InProgress = new Status("InProgress");

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
    /// Constants used for properties of type TargetSelection.
    /// </summary>
    public class TargetSelection : ConstantClass
    {

        /// <summary>
        /// Constant CONTINUOUS for TargetSelection
        /// </summary>
        public static readonly TargetSelection CONTINUOUS = new TargetSelection("CONTINUOUS");
        /// <summary>
        /// Constant SNAPSHOT for TargetSelection
        /// </summary>
        public static readonly TargetSelection SNAPSHOT = new TargetSelection("SNAPSHOT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TargetSelection(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TargetSelection FindValue(string value)
        {
            return FindValue<TargetSelection>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TargetSelection(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ThingIndexingMode.
    /// </summary>
    public class ThingIndexingMode : ConstantClass
    {

        /// <summary>
        /// Constant OFF for ThingIndexingMode
        /// </summary>
        public static readonly ThingIndexingMode OFF = new ThingIndexingMode("OFF");
        /// <summary>
        /// Constant REGISTRY for ThingIndexingMode
        /// </summary>
        public static readonly ThingIndexingMode REGISTRY = new ThingIndexingMode("REGISTRY");
        /// <summary>
        /// Constant REGISTRY_AND_SHADOW for ThingIndexingMode
        /// </summary>
        public static readonly ThingIndexingMode REGISTRY_AND_SHADOW = new ThingIndexingMode("REGISTRY_AND_SHADOW");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ThingIndexingMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ThingIndexingMode FindValue(string value)
        {
            return FindValue<ThingIndexingMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ThingIndexingMode(string value)
        {
            return FindValue(value);
        }
    }

}