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
 * Do not modify this file. This file is generated from the logs-2014-03-28.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.CloudWatchLogs
{

    /// <summary>
    /// Constants used for properties of type AnomalyDetectorStatus.
    /// </summary>
    public class AnomalyDetectorStatus : ConstantClass
    {

        /// <summary>
        /// Constant ANALYZING for AnomalyDetectorStatus
        /// </summary>
        public static readonly AnomalyDetectorStatus ANALYZING = new AnomalyDetectorStatus("ANALYZING");
        /// <summary>
        /// Constant DELETED for AnomalyDetectorStatus
        /// </summary>
        public static readonly AnomalyDetectorStatus DELETED = new AnomalyDetectorStatus("DELETED");
        /// <summary>
        /// Constant FAILED for AnomalyDetectorStatus
        /// </summary>
        public static readonly AnomalyDetectorStatus FAILED = new AnomalyDetectorStatus("FAILED");
        /// <summary>
        /// Constant INITIALIZING for AnomalyDetectorStatus
        /// </summary>
        public static readonly AnomalyDetectorStatus INITIALIZING = new AnomalyDetectorStatus("INITIALIZING");
        /// <summary>
        /// Constant PAUSED for AnomalyDetectorStatus
        /// </summary>
        public static readonly AnomalyDetectorStatus PAUSED = new AnomalyDetectorStatus("PAUSED");
        /// <summary>
        /// Constant TRAINING for AnomalyDetectorStatus
        /// </summary>
        public static readonly AnomalyDetectorStatus TRAINING = new AnomalyDetectorStatus("TRAINING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AnomalyDetectorStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AnomalyDetectorStatus FindValue(string value)
        {
            return FindValue<AnomalyDetectorStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AnomalyDetectorStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DataProtectionStatus.
    /// </summary>
    public class DataProtectionStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVATED for DataProtectionStatus
        /// </summary>
        public static readonly DataProtectionStatus ACTIVATED = new DataProtectionStatus("ACTIVATED");
        /// <summary>
        /// Constant ARCHIVED for DataProtectionStatus
        /// </summary>
        public static readonly DataProtectionStatus ARCHIVED = new DataProtectionStatus("ARCHIVED");
        /// <summary>
        /// Constant DELETED for DataProtectionStatus
        /// </summary>
        public static readonly DataProtectionStatus DELETED = new DataProtectionStatus("DELETED");
        /// <summary>
        /// Constant DISABLED for DataProtectionStatus
        /// </summary>
        public static readonly DataProtectionStatus DISABLED = new DataProtectionStatus("DISABLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DataProtectionStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DataProtectionStatus FindValue(string value)
        {
            return FindValue<DataProtectionStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DataProtectionStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DeliveryDestinationType.
    /// </summary>
    public class DeliveryDestinationType : ConstantClass
    {

        /// <summary>
        /// Constant CWL for DeliveryDestinationType
        /// </summary>
        public static readonly DeliveryDestinationType CWL = new DeliveryDestinationType("CWL");
        /// <summary>
        /// Constant FH for DeliveryDestinationType
        /// </summary>
        public static readonly DeliveryDestinationType FH = new DeliveryDestinationType("FH");
        /// <summary>
        /// Constant S3 for DeliveryDestinationType
        /// </summary>
        public static readonly DeliveryDestinationType S3 = new DeliveryDestinationType("S3");
        /// <summary>
        /// Constant XRAY for DeliveryDestinationType
        /// </summary>
        public static readonly DeliveryDestinationType XRAY = new DeliveryDestinationType("XRAY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DeliveryDestinationType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DeliveryDestinationType FindValue(string value)
        {
            return FindValue<DeliveryDestinationType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DeliveryDestinationType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Distribution.
    /// </summary>
    public class Distribution : ConstantClass
    {

        /// <summary>
        /// Constant ByLogStream for Distribution
        /// </summary>
        public static readonly Distribution ByLogStream = new Distribution("ByLogStream");
        /// <summary>
        /// Constant Random for Distribution
        /// </summary>
        public static readonly Distribution Random = new Distribution("Random");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Distribution(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Distribution FindValue(string value)
        {
            return FindValue<Distribution>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Distribution(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type EntityRejectionErrorType.
    /// </summary>
    public class EntityRejectionErrorType : ConstantClass
    {

        /// <summary>
        /// Constant EntitySizeTooLarge for EntityRejectionErrorType
        /// </summary>
        public static readonly EntityRejectionErrorType EntitySizeTooLarge = new EntityRejectionErrorType("EntitySizeTooLarge");
        /// <summary>
        /// Constant InvalidAttributes for EntityRejectionErrorType
        /// </summary>
        public static readonly EntityRejectionErrorType InvalidAttributes = new EntityRejectionErrorType("InvalidAttributes");
        /// <summary>
        /// Constant InvalidEntity for EntityRejectionErrorType
        /// </summary>
        public static readonly EntityRejectionErrorType InvalidEntity = new EntityRejectionErrorType("InvalidEntity");
        /// <summary>
        /// Constant InvalidKeyAttributes for EntityRejectionErrorType
        /// </summary>
        public static readonly EntityRejectionErrorType InvalidKeyAttributes = new EntityRejectionErrorType("InvalidKeyAttributes");
        /// <summary>
        /// Constant InvalidTypeValue for EntityRejectionErrorType
        /// </summary>
        public static readonly EntityRejectionErrorType InvalidTypeValue = new EntityRejectionErrorType("InvalidTypeValue");
        /// <summary>
        /// Constant MissingRequiredFields for EntityRejectionErrorType
        /// </summary>
        public static readonly EntityRejectionErrorType MissingRequiredFields = new EntityRejectionErrorType("MissingRequiredFields");
        /// <summary>
        /// Constant UnsupportedLogGroupType for EntityRejectionErrorType
        /// </summary>
        public static readonly EntityRejectionErrorType UnsupportedLogGroupType = new EntityRejectionErrorType("UnsupportedLogGroupType");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EntityRejectionErrorType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EntityRejectionErrorType FindValue(string value)
        {
            return FindValue<EntityRejectionErrorType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EntityRejectionErrorType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type EvaluationFrequency.
    /// </summary>
    public class EvaluationFrequency : ConstantClass
    {

        /// <summary>
        /// Constant FIFTEEN_MIN for EvaluationFrequency
        /// </summary>
        public static readonly EvaluationFrequency FIFTEEN_MIN = new EvaluationFrequency("FIFTEEN_MIN");
        /// <summary>
        /// Constant FIVE_MIN for EvaluationFrequency
        /// </summary>
        public static readonly EvaluationFrequency FIVE_MIN = new EvaluationFrequency("FIVE_MIN");
        /// <summary>
        /// Constant ONE_HOUR for EvaluationFrequency
        /// </summary>
        public static readonly EvaluationFrequency ONE_HOUR = new EvaluationFrequency("ONE_HOUR");
        /// <summary>
        /// Constant ONE_MIN for EvaluationFrequency
        /// </summary>
        public static readonly EvaluationFrequency ONE_MIN = new EvaluationFrequency("ONE_MIN");
        /// <summary>
        /// Constant TEN_MIN for EvaluationFrequency
        /// </summary>
        public static readonly EvaluationFrequency TEN_MIN = new EvaluationFrequency("TEN_MIN");
        /// <summary>
        /// Constant THIRTY_MIN for EvaluationFrequency
        /// </summary>
        public static readonly EvaluationFrequency THIRTY_MIN = new EvaluationFrequency("THIRTY_MIN");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EvaluationFrequency(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EvaluationFrequency FindValue(string value)
        {
            return FindValue<EvaluationFrequency>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EvaluationFrequency(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type EventSource.
    /// </summary>
    public class EventSource : ConstantClass
    {

        /// <summary>
        /// Constant AWSWAF for EventSource
        /// </summary>
        public static readonly EventSource AWSWAF = new EventSource("AWSWAF");
        /// <summary>
        /// Constant CloudTrail for EventSource
        /// </summary>
        public static readonly EventSource CloudTrail = new EventSource("CloudTrail");
        /// <summary>
        /// Constant EKSAudit for EventSource
        /// </summary>
        public static readonly EventSource EKSAudit = new EventSource("EKSAudit");
        /// <summary>
        /// Constant Route53Resolver for EventSource
        /// </summary>
        public static readonly EventSource Route53Resolver = new EventSource("Route53Resolver");
        /// <summary>
        /// Constant VPCFlow for EventSource
        /// </summary>
        public static readonly EventSource VPCFlow = new EventSource("VPCFlow");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EventSource(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EventSource FindValue(string value)
        {
            return FindValue<EventSource>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EventSource(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ExportTaskStatusCode.
    /// </summary>
    public class ExportTaskStatusCode : ConstantClass
    {

        /// <summary>
        /// Constant CANCELLED for ExportTaskStatusCode
        /// </summary>
        public static readonly ExportTaskStatusCode CANCELLED = new ExportTaskStatusCode("CANCELLED");
        /// <summary>
        /// Constant COMPLETED for ExportTaskStatusCode
        /// </summary>
        public static readonly ExportTaskStatusCode COMPLETED = new ExportTaskStatusCode("COMPLETED");
        /// <summary>
        /// Constant FAILED for ExportTaskStatusCode
        /// </summary>
        public static readonly ExportTaskStatusCode FAILED = new ExportTaskStatusCode("FAILED");
        /// <summary>
        /// Constant PENDING for ExportTaskStatusCode
        /// </summary>
        public static readonly ExportTaskStatusCode PENDING = new ExportTaskStatusCode("PENDING");
        /// <summary>
        /// Constant PENDING_CANCEL for ExportTaskStatusCode
        /// </summary>
        public static readonly ExportTaskStatusCode PENDING_CANCEL = new ExportTaskStatusCode("PENDING_CANCEL");
        /// <summary>
        /// Constant RUNNING for ExportTaskStatusCode
        /// </summary>
        public static readonly ExportTaskStatusCode RUNNING = new ExportTaskStatusCode("RUNNING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ExportTaskStatusCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ExportTaskStatusCode FindValue(string value)
        {
            return FindValue<ExportTaskStatusCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ExportTaskStatusCode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type FlattenedElement.
    /// </summary>
    public class FlattenedElement : ConstantClass
    {

        /// <summary>
        /// Constant First for FlattenedElement
        /// </summary>
        public static readonly FlattenedElement First = new FlattenedElement("first");
        /// <summary>
        /// Constant Last for FlattenedElement
        /// </summary>
        public static readonly FlattenedElement Last = new FlattenedElement("last");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FlattenedElement(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FlattenedElement FindValue(string value)
        {
            return FindValue<FlattenedElement>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FlattenedElement(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type IndexSource.
    /// </summary>
    public class IndexSource : ConstantClass
    {

        /// <summary>
        /// Constant ACCOUNT for IndexSource
        /// </summary>
        public static readonly IndexSource ACCOUNT = new IndexSource("ACCOUNT");
        /// <summary>
        /// Constant LOG_GROUP for IndexSource
        /// </summary>
        public static readonly IndexSource LOG_GROUP = new IndexSource("LOG_GROUP");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public IndexSource(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static IndexSource FindValue(string value)
        {
            return FindValue<IndexSource>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator IndexSource(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type InheritedProperty.
    /// </summary>
    public class InheritedProperty : ConstantClass
    {

        /// <summary>
        /// Constant ACCOUNT_DATA_PROTECTION for InheritedProperty
        /// </summary>
        public static readonly InheritedProperty ACCOUNT_DATA_PROTECTION = new InheritedProperty("ACCOUNT_DATA_PROTECTION");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public InheritedProperty(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static InheritedProperty FindValue(string value)
        {
            return FindValue<InheritedProperty>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator InheritedProperty(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type IntegrationStatus.
    /// </summary>
    public class IntegrationStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for IntegrationStatus
        /// </summary>
        public static readonly IntegrationStatus ACTIVE = new IntegrationStatus("ACTIVE");
        /// <summary>
        /// Constant FAILED for IntegrationStatus
        /// </summary>
        public static readonly IntegrationStatus FAILED = new IntegrationStatus("FAILED");
        /// <summary>
        /// Constant PROVISIONING for IntegrationStatus
        /// </summary>
        public static readonly IntegrationStatus PROVISIONING = new IntegrationStatus("PROVISIONING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public IntegrationStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static IntegrationStatus FindValue(string value)
        {
            return FindValue<IntegrationStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator IntegrationStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type IntegrationType.
    /// </summary>
    public class IntegrationType : ConstantClass
    {

        /// <summary>
        /// Constant OPENSEARCH for IntegrationType
        /// </summary>
        public static readonly IntegrationType OPENSEARCH = new IntegrationType("OPENSEARCH");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public IntegrationType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static IntegrationType FindValue(string value)
        {
            return FindValue<IntegrationType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator IntegrationType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type LogGroupClass.
    /// </summary>
    public class LogGroupClass : ConstantClass
    {

        /// <summary>
        /// Constant DELIVERY for LogGroupClass
        /// </summary>
        public static readonly LogGroupClass DELIVERY = new LogGroupClass("DELIVERY");
        /// <summary>
        /// Constant INFREQUENT_ACCESS for LogGroupClass
        /// </summary>
        public static readonly LogGroupClass INFREQUENT_ACCESS = new LogGroupClass("INFREQUENT_ACCESS");
        /// <summary>
        /// Constant STANDARD for LogGroupClass
        /// </summary>
        public static readonly LogGroupClass STANDARD = new LogGroupClass("STANDARD");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public LogGroupClass(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LogGroupClass FindValue(string value)
        {
            return FindValue<LogGroupClass>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator LogGroupClass(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type OCSFVersion.
    /// </summary>
    public class OCSFVersion : ConstantClass
    {

        /// <summary>
        /// Constant V11 for OCSFVersion
        /// </summary>
        public static readonly OCSFVersion V11 = new OCSFVersion("V1.1");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public OCSFVersion(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static OCSFVersion FindValue(string value)
        {
            return FindValue<OCSFVersion>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator OCSFVersion(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type OpenSearchResourceStatusType.
    /// </summary>
    public class OpenSearchResourceStatusType : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for OpenSearchResourceStatusType
        /// </summary>
        public static readonly OpenSearchResourceStatusType ACTIVE = new OpenSearchResourceStatusType("ACTIVE");
        /// <summary>
        /// Constant ERROR for OpenSearchResourceStatusType
        /// </summary>
        public static readonly OpenSearchResourceStatusType ERROR = new OpenSearchResourceStatusType("ERROR");
        /// <summary>
        /// Constant NOT_FOUND for OpenSearchResourceStatusType
        /// </summary>
        public static readonly OpenSearchResourceStatusType NOT_FOUND = new OpenSearchResourceStatusType("NOT_FOUND");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public OpenSearchResourceStatusType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static OpenSearchResourceStatusType FindValue(string value)
        {
            return FindValue<OpenSearchResourceStatusType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator OpenSearchResourceStatusType(string value)
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
        /// Constant LastEventTime for OrderBy
        /// </summary>
        public static readonly OrderBy LastEventTime = new OrderBy("LastEventTime");
        /// <summary>
        /// Constant LogStreamName for OrderBy
        /// </summary>
        public static readonly OrderBy LogStreamName = new OrderBy("LogStreamName");

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
    /// Constants used for properties of type OutputFormat.
    /// </summary>
    public class OutputFormat : ConstantClass
    {

        /// <summary>
        /// Constant Json for OutputFormat
        /// </summary>
        public static readonly OutputFormat Json = new OutputFormat("json");
        /// <summary>
        /// Constant Parquet for OutputFormat
        /// </summary>
        public static readonly OutputFormat Parquet = new OutputFormat("parquet");
        /// <summary>
        /// Constant Plain for OutputFormat
        /// </summary>
        public static readonly OutputFormat Plain = new OutputFormat("plain");
        /// <summary>
        /// Constant Raw for OutputFormat
        /// </summary>
        public static readonly OutputFormat Raw = new OutputFormat("raw");
        /// <summary>
        /// Constant W3c for OutputFormat
        /// </summary>
        public static readonly OutputFormat W3c = new OutputFormat("w3c");

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
    /// Constants used for properties of type PolicyScope.
    /// </summary>
    public class PolicyScope : ConstantClass
    {

        /// <summary>
        /// Constant ACCOUNT for PolicyScope
        /// </summary>
        public static readonly PolicyScope ACCOUNT = new PolicyScope("ACCOUNT");
        /// <summary>
        /// Constant RESOURCE for PolicyScope
        /// </summary>
        public static readonly PolicyScope RESOURCE = new PolicyScope("RESOURCE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PolicyScope(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PolicyScope FindValue(string value)
        {
            return FindValue<PolicyScope>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PolicyScope(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PolicyType.
    /// </summary>
    public class PolicyType : ConstantClass
    {

        /// <summary>
        /// Constant DATA_PROTECTION_POLICY for PolicyType
        /// </summary>
        public static readonly PolicyType DATA_PROTECTION_POLICY = new PolicyType("DATA_PROTECTION_POLICY");
        /// <summary>
        /// Constant FIELD_INDEX_POLICY for PolicyType
        /// </summary>
        public static readonly PolicyType FIELD_INDEX_POLICY = new PolicyType("FIELD_INDEX_POLICY");
        /// <summary>
        /// Constant METRIC_EXTRACTION_POLICY for PolicyType
        /// </summary>
        public static readonly PolicyType METRIC_EXTRACTION_POLICY = new PolicyType("METRIC_EXTRACTION_POLICY");
        /// <summary>
        /// Constant SUBSCRIPTION_FILTER_POLICY for PolicyType
        /// </summary>
        public static readonly PolicyType SUBSCRIPTION_FILTER_POLICY = new PolicyType("SUBSCRIPTION_FILTER_POLICY");
        /// <summary>
        /// Constant TRANSFORMER_POLICY for PolicyType
        /// </summary>
        public static readonly PolicyType TRANSFORMER_POLICY = new PolicyType("TRANSFORMER_POLICY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PolicyType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PolicyType FindValue(string value)
        {
            return FindValue<PolicyType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PolicyType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type QueryLanguage.
    /// </summary>
    public class QueryLanguage : ConstantClass
    {

        /// <summary>
        /// Constant CWLI for QueryLanguage
        /// </summary>
        public static readonly QueryLanguage CWLI = new QueryLanguage("CWLI");
        /// <summary>
        /// Constant PPL for QueryLanguage
        /// </summary>
        public static readonly QueryLanguage PPL = new QueryLanguage("PPL");
        /// <summary>
        /// Constant SQL for QueryLanguage
        /// </summary>
        public static readonly QueryLanguage SQL = new QueryLanguage("SQL");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public QueryLanguage(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static QueryLanguage FindValue(string value)
        {
            return FindValue<QueryLanguage>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator QueryLanguage(string value)
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
        /// Constant Cancelled for QueryStatus
        /// </summary>
        public static readonly QueryStatus Cancelled = new QueryStatus("Cancelled");
        /// <summary>
        /// Constant Complete for QueryStatus
        /// </summary>
        public static readonly QueryStatus Complete = new QueryStatus("Complete");
        /// <summary>
        /// Constant Failed for QueryStatus
        /// </summary>
        public static readonly QueryStatus Failed = new QueryStatus("Failed");
        /// <summary>
        /// Constant Running for QueryStatus
        /// </summary>
        public static readonly QueryStatus Running = new QueryStatus("Running");
        /// <summary>
        /// Constant Scheduled for QueryStatus
        /// </summary>
        public static readonly QueryStatus Scheduled = new QueryStatus("Scheduled");
        /// <summary>
        /// Constant Timeout for QueryStatus
        /// </summary>
        public static readonly QueryStatus Timeout = new QueryStatus("Timeout");
        /// <summary>
        /// Constant Unknown for QueryStatus
        /// </summary>
        public static readonly QueryStatus Unknown = new QueryStatus("Unknown");

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
    /// Constants used for properties of type Scope.
    /// </summary>
    public class Scope : ConstantClass
    {

        /// <summary>
        /// Constant ALL for Scope
        /// </summary>
        public static readonly Scope ALL = new Scope("ALL");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Scope(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Scope FindValue(string value)
        {
            return FindValue<Scope>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Scope(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type StandardUnit.
    /// </summary>
    public class StandardUnit : ConstantClass
    {

        /// <summary>
        /// Constant Bits for StandardUnit
        /// </summary>
        public static readonly StandardUnit Bits = new StandardUnit("Bits");
        /// <summary>
        /// Constant BitsSecond for StandardUnit
        /// </summary>
        public static readonly StandardUnit BitsSecond = new StandardUnit("Bits/Second");
        /// <summary>
        /// Constant Bytes for StandardUnit
        /// </summary>
        public static readonly StandardUnit Bytes = new StandardUnit("Bytes");
        /// <summary>
        /// Constant BytesSecond for StandardUnit
        /// </summary>
        public static readonly StandardUnit BytesSecond = new StandardUnit("Bytes/Second");
        /// <summary>
        /// Constant Count for StandardUnit
        /// </summary>
        public static readonly StandardUnit Count = new StandardUnit("Count");
        /// <summary>
        /// Constant CountSecond for StandardUnit
        /// </summary>
        public static readonly StandardUnit CountSecond = new StandardUnit("Count/Second");
        /// <summary>
        /// Constant Gigabits for StandardUnit
        /// </summary>
        public static readonly StandardUnit Gigabits = new StandardUnit("Gigabits");
        /// <summary>
        /// Constant GigabitsSecond for StandardUnit
        /// </summary>
        public static readonly StandardUnit GigabitsSecond = new StandardUnit("Gigabits/Second");
        /// <summary>
        /// Constant Gigabytes for StandardUnit
        /// </summary>
        public static readonly StandardUnit Gigabytes = new StandardUnit("Gigabytes");
        /// <summary>
        /// Constant GigabytesSecond for StandardUnit
        /// </summary>
        public static readonly StandardUnit GigabytesSecond = new StandardUnit("Gigabytes/Second");
        /// <summary>
        /// Constant Kilobits for StandardUnit
        /// </summary>
        public static readonly StandardUnit Kilobits = new StandardUnit("Kilobits");
        /// <summary>
        /// Constant KilobitsSecond for StandardUnit
        /// </summary>
        public static readonly StandardUnit KilobitsSecond = new StandardUnit("Kilobits/Second");
        /// <summary>
        /// Constant Kilobytes for StandardUnit
        /// </summary>
        public static readonly StandardUnit Kilobytes = new StandardUnit("Kilobytes");
        /// <summary>
        /// Constant KilobytesSecond for StandardUnit
        /// </summary>
        public static readonly StandardUnit KilobytesSecond = new StandardUnit("Kilobytes/Second");
        /// <summary>
        /// Constant Megabits for StandardUnit
        /// </summary>
        public static readonly StandardUnit Megabits = new StandardUnit("Megabits");
        /// <summary>
        /// Constant MegabitsSecond for StandardUnit
        /// </summary>
        public static readonly StandardUnit MegabitsSecond = new StandardUnit("Megabits/Second");
        /// <summary>
        /// Constant Megabytes for StandardUnit
        /// </summary>
        public static readonly StandardUnit Megabytes = new StandardUnit("Megabytes");
        /// <summary>
        /// Constant MegabytesSecond for StandardUnit
        /// </summary>
        public static readonly StandardUnit MegabytesSecond = new StandardUnit("Megabytes/Second");
        /// <summary>
        /// Constant Microseconds for StandardUnit
        /// </summary>
        public static readonly StandardUnit Microseconds = new StandardUnit("Microseconds");
        /// <summary>
        /// Constant Milliseconds for StandardUnit
        /// </summary>
        public static readonly StandardUnit Milliseconds = new StandardUnit("Milliseconds");
        /// <summary>
        /// Constant None for StandardUnit
        /// </summary>
        public static readonly StandardUnit None = new StandardUnit("None");
        /// <summary>
        /// Constant Percent for StandardUnit
        /// </summary>
        public static readonly StandardUnit Percent = new StandardUnit("Percent");
        /// <summary>
        /// Constant Seconds for StandardUnit
        /// </summary>
        public static readonly StandardUnit Seconds = new StandardUnit("Seconds");
        /// <summary>
        /// Constant Terabits for StandardUnit
        /// </summary>
        public static readonly StandardUnit Terabits = new StandardUnit("Terabits");
        /// <summary>
        /// Constant TerabitsSecond for StandardUnit
        /// </summary>
        public static readonly StandardUnit TerabitsSecond = new StandardUnit("Terabits/Second");
        /// <summary>
        /// Constant Terabytes for StandardUnit
        /// </summary>
        public static readonly StandardUnit Terabytes = new StandardUnit("Terabytes");
        /// <summary>
        /// Constant TerabytesSecond for StandardUnit
        /// </summary>
        public static readonly StandardUnit TerabytesSecond = new StandardUnit("Terabytes/Second");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public StandardUnit(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static StandardUnit FindValue(string value)
        {
            return FindValue<StandardUnit>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator StandardUnit(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type State.
    /// </summary>
    public class State : ConstantClass
    {

        /// <summary>
        /// Constant Active for State
        /// </summary>
        public static readonly State Active = new State("Active");
        /// <summary>
        /// Constant Baseline for State
        /// </summary>
        public static readonly State Baseline = new State("Baseline");
        /// <summary>
        /// Constant Suppressed for State
        /// </summary>
        public static readonly State Suppressed = new State("Suppressed");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public State(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static State FindValue(string value)
        {
            return FindValue<State>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator State(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SuppressionState.
    /// </summary>
    public class SuppressionState : ConstantClass
    {

        /// <summary>
        /// Constant SUPPRESSED for SuppressionState
        /// </summary>
        public static readonly SuppressionState SUPPRESSED = new SuppressionState("SUPPRESSED");
        /// <summary>
        /// Constant UNSUPPRESSED for SuppressionState
        /// </summary>
        public static readonly SuppressionState UNSUPPRESSED = new SuppressionState("UNSUPPRESSED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SuppressionState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SuppressionState FindValue(string value)
        {
            return FindValue<SuppressionState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SuppressionState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SuppressionType.
    /// </summary>
    public class SuppressionType : ConstantClass
    {

        /// <summary>
        /// Constant INFINITE for SuppressionType
        /// </summary>
        public static readonly SuppressionType INFINITE = new SuppressionType("INFINITE");
        /// <summary>
        /// Constant LIMITED for SuppressionType
        /// </summary>
        public static readonly SuppressionType LIMITED = new SuppressionType("LIMITED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SuppressionType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SuppressionType FindValue(string value)
        {
            return FindValue<SuppressionType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SuppressionType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SuppressionUnit.
    /// </summary>
    public class SuppressionUnit : ConstantClass
    {

        /// <summary>
        /// Constant HOURS for SuppressionUnit
        /// </summary>
        public static readonly SuppressionUnit HOURS = new SuppressionUnit("HOURS");
        /// <summary>
        /// Constant MINUTES for SuppressionUnit
        /// </summary>
        public static readonly SuppressionUnit MINUTES = new SuppressionUnit("MINUTES");
        /// <summary>
        /// Constant SECONDS for SuppressionUnit
        /// </summary>
        public static readonly SuppressionUnit SECONDS = new SuppressionUnit("SECONDS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SuppressionUnit(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SuppressionUnit FindValue(string value)
        {
            return FindValue<SuppressionUnit>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SuppressionUnit(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Type.
    /// </summary>
    public class Type : ConstantClass
    {

        /// <summary>
        /// Constant Boolean for Type
        /// </summary>
        public static readonly Type Boolean = new Type("boolean");
        /// <summary>
        /// Constant Double for Type
        /// </summary>
        public static readonly Type Double = new Type("double");
        /// <summary>
        /// Constant Integer for Type
        /// </summary>
        public static readonly Type Integer = new Type("integer");
        /// <summary>
        /// Constant String for Type
        /// </summary>
        public static readonly Type String = new Type("string");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Type(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Type FindValue(string value)
        {
            return FindValue<Type>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Type(string value)
        {
            return FindValue(value);
        }
    }

}