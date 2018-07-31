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
    /// Constants used for properties of type AlertTargetType.
    /// </summary>
    public class AlertTargetType : ConstantClass
    {

        /// <summary>
        /// Constant SNS for AlertTargetType
        /// </summary>
        public static readonly AlertTargetType SNS = new AlertTargetType("SNS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AlertTargetType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AlertTargetType FindValue(string value)
        {
            return FindValue<AlertTargetType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AlertTargetType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AuditCheckRunStatus.
    /// </summary>
    public class AuditCheckRunStatus : ConstantClass
    {

        /// <summary>
        /// Constant CANCELED for AuditCheckRunStatus
        /// </summary>
        public static readonly AuditCheckRunStatus CANCELED = new AuditCheckRunStatus("CANCELED");
        /// <summary>
        /// Constant COMPLETED_COMPLIANT for AuditCheckRunStatus
        /// </summary>
        public static readonly AuditCheckRunStatus COMPLETED_COMPLIANT = new AuditCheckRunStatus("COMPLETED_COMPLIANT");
        /// <summary>
        /// Constant COMPLETED_NON_COMPLIANT for AuditCheckRunStatus
        /// </summary>
        public static readonly AuditCheckRunStatus COMPLETED_NON_COMPLIANT = new AuditCheckRunStatus("COMPLETED_NON_COMPLIANT");
        /// <summary>
        /// Constant FAILED for AuditCheckRunStatus
        /// </summary>
        public static readonly AuditCheckRunStatus FAILED = new AuditCheckRunStatus("FAILED");
        /// <summary>
        /// Constant IN_PROGRESS for AuditCheckRunStatus
        /// </summary>
        public static readonly AuditCheckRunStatus IN_PROGRESS = new AuditCheckRunStatus("IN_PROGRESS");
        /// <summary>
        /// Constant WAITING_FOR_DATA_COLLECTION for AuditCheckRunStatus
        /// </summary>
        public static readonly AuditCheckRunStatus WAITING_FOR_DATA_COLLECTION = new AuditCheckRunStatus("WAITING_FOR_DATA_COLLECTION");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AuditCheckRunStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AuditCheckRunStatus FindValue(string value)
        {
            return FindValue<AuditCheckRunStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AuditCheckRunStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AuditFindingSeverity.
    /// </summary>
    public class AuditFindingSeverity : ConstantClass
    {

        /// <summary>
        /// Constant CRITICAL for AuditFindingSeverity
        /// </summary>
        public static readonly AuditFindingSeverity CRITICAL = new AuditFindingSeverity("CRITICAL");
        /// <summary>
        /// Constant HIGH for AuditFindingSeverity
        /// </summary>
        public static readonly AuditFindingSeverity HIGH = new AuditFindingSeverity("HIGH");
        /// <summary>
        /// Constant LOW for AuditFindingSeverity
        /// </summary>
        public static readonly AuditFindingSeverity LOW = new AuditFindingSeverity("LOW");
        /// <summary>
        /// Constant MEDIUM for AuditFindingSeverity
        /// </summary>
        public static readonly AuditFindingSeverity MEDIUM = new AuditFindingSeverity("MEDIUM");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AuditFindingSeverity(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AuditFindingSeverity FindValue(string value)
        {
            return FindValue<AuditFindingSeverity>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AuditFindingSeverity(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AuditFrequency.
    /// </summary>
    public class AuditFrequency : ConstantClass
    {

        /// <summary>
        /// Constant BIWEEKLY for AuditFrequency
        /// </summary>
        public static readonly AuditFrequency BIWEEKLY = new AuditFrequency("BIWEEKLY");
        /// <summary>
        /// Constant DAILY for AuditFrequency
        /// </summary>
        public static readonly AuditFrequency DAILY = new AuditFrequency("DAILY");
        /// <summary>
        /// Constant MONTHLY for AuditFrequency
        /// </summary>
        public static readonly AuditFrequency MONTHLY = new AuditFrequency("MONTHLY");
        /// <summary>
        /// Constant WEEKLY for AuditFrequency
        /// </summary>
        public static readonly AuditFrequency WEEKLY = new AuditFrequency("WEEKLY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AuditFrequency(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AuditFrequency FindValue(string value)
        {
            return FindValue<AuditFrequency>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AuditFrequency(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AuditNotificationType.
    /// </summary>
    public class AuditNotificationType : ConstantClass
    {

        /// <summary>
        /// Constant SNS for AuditNotificationType
        /// </summary>
        public static readonly AuditNotificationType SNS = new AuditNotificationType("SNS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AuditNotificationType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AuditNotificationType FindValue(string value)
        {
            return FindValue<AuditNotificationType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AuditNotificationType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AuditTaskStatus.
    /// </summary>
    public class AuditTaskStatus : ConstantClass
    {

        /// <summary>
        /// Constant CANCELED for AuditTaskStatus
        /// </summary>
        public static readonly AuditTaskStatus CANCELED = new AuditTaskStatus("CANCELED");
        /// <summary>
        /// Constant COMPLETED for AuditTaskStatus
        /// </summary>
        public static readonly AuditTaskStatus COMPLETED = new AuditTaskStatus("COMPLETED");
        /// <summary>
        /// Constant FAILED for AuditTaskStatus
        /// </summary>
        public static readonly AuditTaskStatus FAILED = new AuditTaskStatus("FAILED");
        /// <summary>
        /// Constant IN_PROGRESS for AuditTaskStatus
        /// </summary>
        public static readonly AuditTaskStatus IN_PROGRESS = new AuditTaskStatus("IN_PROGRESS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AuditTaskStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AuditTaskStatus FindValue(string value)
        {
            return FindValue<AuditTaskStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AuditTaskStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AuditTaskType.
    /// </summary>
    public class AuditTaskType : ConstantClass
    {

        /// <summary>
        /// Constant ON_DEMAND_AUDIT_TASK for AuditTaskType
        /// </summary>
        public static readonly AuditTaskType ON_DEMAND_AUDIT_TASK = new AuditTaskType("ON_DEMAND_AUDIT_TASK");
        /// <summary>
        /// Constant SCHEDULED_AUDIT_TASK for AuditTaskType
        /// </summary>
        public static readonly AuditTaskType SCHEDULED_AUDIT_TASK = new AuditTaskType("SCHEDULED_AUDIT_TASK");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AuditTaskType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AuditTaskType FindValue(string value)
        {
            return FindValue<AuditTaskType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AuditTaskType(string value)
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
    /// Constants used for properties of type ComparisonOperator.
    /// </summary>
    public class ComparisonOperator : ConstantClass
    {

        /// <summary>
        /// Constant GreaterThan for ComparisonOperator
        /// </summary>
        public static readonly ComparisonOperator GreaterThan = new ComparisonOperator("greater-than");
        /// <summary>
        /// Constant GreaterThanEquals for ComparisonOperator
        /// </summary>
        public static readonly ComparisonOperator GreaterThanEquals = new ComparisonOperator("greater-than-equals");
        /// <summary>
        /// Constant InCidrSet for ComparisonOperator
        /// </summary>
        public static readonly ComparisonOperator InCidrSet = new ComparisonOperator("in-cidr-set");
        /// <summary>
        /// Constant InPortSet for ComparisonOperator
        /// </summary>
        public static readonly ComparisonOperator InPortSet = new ComparisonOperator("in-port-set");
        /// <summary>
        /// Constant LessThan for ComparisonOperator
        /// </summary>
        public static readonly ComparisonOperator LessThan = new ComparisonOperator("less-than");
        /// <summary>
        /// Constant LessThanEquals for ComparisonOperator
        /// </summary>
        public static readonly ComparisonOperator LessThanEquals = new ComparisonOperator("less-than-equals");
        /// <summary>
        /// Constant NotInCidrSet for ComparisonOperator
        /// </summary>
        public static readonly ComparisonOperator NotInCidrSet = new ComparisonOperator("not-in-cidr-set");
        /// <summary>
        /// Constant NotInPortSet for ComparisonOperator
        /// </summary>
        public static readonly ComparisonOperator NotInPortSet = new ComparisonOperator("not-in-port-set");

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
    /// Constants used for properties of type DayOfWeek.
    /// </summary>
    public class DayOfWeek : ConstantClass
    {

        /// <summary>
        /// Constant FRI for DayOfWeek
        /// </summary>
        public static readonly DayOfWeek FRI = new DayOfWeek("FRI");
        /// <summary>
        /// Constant MON for DayOfWeek
        /// </summary>
        public static readonly DayOfWeek MON = new DayOfWeek("MON");
        /// <summary>
        /// Constant SAT for DayOfWeek
        /// </summary>
        public static readonly DayOfWeek SAT = new DayOfWeek("SAT");
        /// <summary>
        /// Constant SUN for DayOfWeek
        /// </summary>
        public static readonly DayOfWeek SUN = new DayOfWeek("SUN");
        /// <summary>
        /// Constant THU for DayOfWeek
        /// </summary>
        public static readonly DayOfWeek THU = new DayOfWeek("THU");
        /// <summary>
        /// Constant TUE for DayOfWeek
        /// </summary>
        public static readonly DayOfWeek TUE = new DayOfWeek("TUE");
        /// <summary>
        /// Constant WED for DayOfWeek
        /// </summary>
        public static readonly DayOfWeek WED = new DayOfWeek("WED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DayOfWeek(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DayOfWeek FindValue(string value)
        {
            return FindValue<DayOfWeek>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DayOfWeek(string value)
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
        /// Constant CA_CERTIFICATE for EventType
        /// </summary>
        public static readonly EventType CA_CERTIFICATE = new EventType("CA_CERTIFICATE");
        /// <summary>
        /// Constant CERTIFICATE for EventType
        /// </summary>
        public static readonly EventType CERTIFICATE = new EventType("CERTIFICATE");
        /// <summary>
        /// Constant JOB for EventType
        /// </summary>
        public static readonly EventType JOB = new EventType("JOB");
        /// <summary>
        /// Constant JOB_EXECUTION for EventType
        /// </summary>
        public static readonly EventType JOB_EXECUTION = new EventType("JOB_EXECUTION");
        /// <summary>
        /// Constant POLICY for EventType
        /// </summary>
        public static readonly EventType POLICY = new EventType("POLICY");
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
    /// Constants used for properties of type ResourceType.
    /// </summary>
    public class ResourceType : ConstantClass
    {

        /// <summary>
        /// Constant ACCOUNT_SETTINGS for ResourceType
        /// </summary>
        public static readonly ResourceType ACCOUNT_SETTINGS = new ResourceType("ACCOUNT_SETTINGS");
        /// <summary>
        /// Constant CA_CERTIFICATE for ResourceType
        /// </summary>
        public static readonly ResourceType CA_CERTIFICATE = new ResourceType("CA_CERTIFICATE");
        /// <summary>
        /// Constant CLIENT_ID for ResourceType
        /// </summary>
        public static readonly ResourceType CLIENT_ID = new ResourceType("CLIENT_ID");
        /// <summary>
        /// Constant COGNITO_IDENTITY_POOL for ResourceType
        /// </summary>
        public static readonly ResourceType COGNITO_IDENTITY_POOL = new ResourceType("COGNITO_IDENTITY_POOL");
        /// <summary>
        /// Constant DEVICE_CERTIFICATE for ResourceType
        /// </summary>
        public static readonly ResourceType DEVICE_CERTIFICATE = new ResourceType("DEVICE_CERTIFICATE");
        /// <summary>
        /// Constant IOT_POLICY for ResourceType
        /// </summary>
        public static readonly ResourceType IOT_POLICY = new ResourceType("IOT_POLICY");

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


    /// <summary>
    /// Constants used for properties of type ViolationEventType.
    /// </summary>
    public class ViolationEventType : ConstantClass
    {

        /// <summary>
        /// Constant AlarmCleared for ViolationEventType
        /// </summary>
        public static readonly ViolationEventType AlarmCleared = new ViolationEventType("alarm-cleared");
        /// <summary>
        /// Constant AlarmInvalidated for ViolationEventType
        /// </summary>
        public static readonly ViolationEventType AlarmInvalidated = new ViolationEventType("alarm-invalidated");
        /// <summary>
        /// Constant InAlarm for ViolationEventType
        /// </summary>
        public static readonly ViolationEventType InAlarm = new ViolationEventType("in-alarm");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ViolationEventType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ViolationEventType FindValue(string value)
        {
            return FindValue<ViolationEventType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ViolationEventType(string value)
        {
            return FindValue(value);
        }
    }

}