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
 * Do not modify this file. This file is generated from the cloudtrail-2013-11-01.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.CloudTrail
{

    /// <summary>
    /// Constants used for properties of type BillingMode.
    /// </summary>
    public class BillingMode : ConstantClass
    {

        /// <summary>
        /// Constant EXTENDABLE_RETENTION_PRICING for BillingMode
        /// </summary>
        public static readonly BillingMode EXTENDABLE_RETENTION_PRICING = new BillingMode("EXTENDABLE_RETENTION_PRICING");
        /// <summary>
        /// Constant FIXED_RETENTION_PRICING for BillingMode
        /// </summary>
        public static readonly BillingMode FIXED_RETENTION_PRICING = new BillingMode("FIXED_RETENTION_PRICING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public BillingMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static BillingMode FindValue(string value)
        {
            return FindValue<BillingMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator BillingMode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DashboardStatus.
    /// </summary>
    public class DashboardStatus : ConstantClass
    {

        /// <summary>
        /// Constant CREATED for DashboardStatus
        /// </summary>
        public static readonly DashboardStatus CREATED = new DashboardStatus("CREATED");
        /// <summary>
        /// Constant CREATING for DashboardStatus
        /// </summary>
        public static readonly DashboardStatus CREATING = new DashboardStatus("CREATING");
        /// <summary>
        /// Constant DELETING for DashboardStatus
        /// </summary>
        public static readonly DashboardStatus DELETING = new DashboardStatus("DELETING");
        /// <summary>
        /// Constant UPDATED for DashboardStatus
        /// </summary>
        public static readonly DashboardStatus UPDATED = new DashboardStatus("UPDATED");
        /// <summary>
        /// Constant UPDATING for DashboardStatus
        /// </summary>
        public static readonly DashboardStatus UPDATING = new DashboardStatus("UPDATING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DashboardStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DashboardStatus FindValue(string value)
        {
            return FindValue<DashboardStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DashboardStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DashboardType.
    /// </summary>
    public class DashboardType : ConstantClass
    {

        /// <summary>
        /// Constant CUSTOM for DashboardType
        /// </summary>
        public static readonly DashboardType CUSTOM = new DashboardType("CUSTOM");
        /// <summary>
        /// Constant MANAGED for DashboardType
        /// </summary>
        public static readonly DashboardType MANAGED = new DashboardType("MANAGED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DashboardType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DashboardType FindValue(string value)
        {
            return FindValue<DashboardType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DashboardType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DeliveryStatus.
    /// </summary>
    public class DeliveryStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACCESS_DENIED for DeliveryStatus
        /// </summary>
        public static readonly DeliveryStatus ACCESS_DENIED = new DeliveryStatus("ACCESS_DENIED");
        /// <summary>
        /// Constant ACCESS_DENIED_SIGNING_FILE for DeliveryStatus
        /// </summary>
        public static readonly DeliveryStatus ACCESS_DENIED_SIGNING_FILE = new DeliveryStatus("ACCESS_DENIED_SIGNING_FILE");
        /// <summary>
        /// Constant CANCELLED for DeliveryStatus
        /// </summary>
        public static readonly DeliveryStatus CANCELLED = new DeliveryStatus("CANCELLED");
        /// <summary>
        /// Constant FAILED for DeliveryStatus
        /// </summary>
        public static readonly DeliveryStatus FAILED = new DeliveryStatus("FAILED");
        /// <summary>
        /// Constant FAILED_SIGNING_FILE for DeliveryStatus
        /// </summary>
        public static readonly DeliveryStatus FAILED_SIGNING_FILE = new DeliveryStatus("FAILED_SIGNING_FILE");
        /// <summary>
        /// Constant PENDING for DeliveryStatus
        /// </summary>
        public static readonly DeliveryStatus PENDING = new DeliveryStatus("PENDING");
        /// <summary>
        /// Constant RESOURCE_NOT_FOUND for DeliveryStatus
        /// </summary>
        public static readonly DeliveryStatus RESOURCE_NOT_FOUND = new DeliveryStatus("RESOURCE_NOT_FOUND");
        /// <summary>
        /// Constant SUCCESS for DeliveryStatus
        /// </summary>
        public static readonly DeliveryStatus SUCCESS = new DeliveryStatus("SUCCESS");
        /// <summary>
        /// Constant UNKNOWN for DeliveryStatus
        /// </summary>
        public static readonly DeliveryStatus UNKNOWN = new DeliveryStatus("UNKNOWN");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DeliveryStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DeliveryStatus FindValue(string value)
        {
            return FindValue<DeliveryStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DeliveryStatus(string value)
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
        /// Constant AWS_SERVICE for DestinationType
        /// </summary>
        public static readonly DestinationType AWS_SERVICE = new DestinationType("AWS_SERVICE");
        /// <summary>
        /// Constant EVENT_DATA_STORE for DestinationType
        /// </summary>
        public static readonly DestinationType EVENT_DATA_STORE = new DestinationType("EVENT_DATA_STORE");

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
    /// Constants used for properties of type EventCategory.
    /// </summary>
    public class EventCategory : ConstantClass
    {

        /// <summary>
        /// Constant Insight for EventCategory
        /// </summary>
        public static readonly EventCategory Insight = new EventCategory("insight");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EventCategory(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EventCategory FindValue(string value)
        {
            return FindValue<EventCategory>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EventCategory(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type EventDataStoreStatus.
    /// </summary>
    public class EventDataStoreStatus : ConstantClass
    {

        /// <summary>
        /// Constant CREATED for EventDataStoreStatus
        /// </summary>
        public static readonly EventDataStoreStatus CREATED = new EventDataStoreStatus("CREATED");
        /// <summary>
        /// Constant ENABLED for EventDataStoreStatus
        /// </summary>
        public static readonly EventDataStoreStatus ENABLED = new EventDataStoreStatus("ENABLED");
        /// <summary>
        /// Constant PENDING_DELETION for EventDataStoreStatus
        /// </summary>
        public static readonly EventDataStoreStatus PENDING_DELETION = new EventDataStoreStatus("PENDING_DELETION");
        /// <summary>
        /// Constant STARTING_INGESTION for EventDataStoreStatus
        /// </summary>
        public static readonly EventDataStoreStatus STARTING_INGESTION = new EventDataStoreStatus("STARTING_INGESTION");
        /// <summary>
        /// Constant STOPPED_INGESTION for EventDataStoreStatus
        /// </summary>
        public static readonly EventDataStoreStatus STOPPED_INGESTION = new EventDataStoreStatus("STOPPED_INGESTION");
        /// <summary>
        /// Constant STOPPING_INGESTION for EventDataStoreStatus
        /// </summary>
        public static readonly EventDataStoreStatus STOPPING_INGESTION = new EventDataStoreStatus("STOPPING_INGESTION");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EventDataStoreStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EventDataStoreStatus FindValue(string value)
        {
            return FindValue<EventDataStoreStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EventDataStoreStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type FederationStatus.
    /// </summary>
    public class FederationStatus : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for FederationStatus
        /// </summary>
        public static readonly FederationStatus DISABLED = new FederationStatus("DISABLED");
        /// <summary>
        /// Constant DISABLING for FederationStatus
        /// </summary>
        public static readonly FederationStatus DISABLING = new FederationStatus("DISABLING");
        /// <summary>
        /// Constant ENABLED for FederationStatus
        /// </summary>
        public static readonly FederationStatus ENABLED = new FederationStatus("ENABLED");
        /// <summary>
        /// Constant ENABLING for FederationStatus
        /// </summary>
        public static readonly FederationStatus ENABLING = new FederationStatus("ENABLING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FederationStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FederationStatus FindValue(string value)
        {
            return FindValue<FederationStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FederationStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ImportFailureStatus.
    /// </summary>
    public class ImportFailureStatus : ConstantClass
    {

        /// <summary>
        /// Constant FAILED for ImportFailureStatus
        /// </summary>
        public static readonly ImportFailureStatus FAILED = new ImportFailureStatus("FAILED");
        /// <summary>
        /// Constant RETRY for ImportFailureStatus
        /// </summary>
        public static readonly ImportFailureStatus RETRY = new ImportFailureStatus("RETRY");
        /// <summary>
        /// Constant SUCCEEDED for ImportFailureStatus
        /// </summary>
        public static readonly ImportFailureStatus SUCCEEDED = new ImportFailureStatus("SUCCEEDED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ImportFailureStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ImportFailureStatus FindValue(string value)
        {
            return FindValue<ImportFailureStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ImportFailureStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ImportStatus.
    /// </summary>
    public class ImportStatus : ConstantClass
    {

        /// <summary>
        /// Constant COMPLETED for ImportStatus
        /// </summary>
        public static readonly ImportStatus COMPLETED = new ImportStatus("COMPLETED");
        /// <summary>
        /// Constant FAILED for ImportStatus
        /// </summary>
        public static readonly ImportStatus FAILED = new ImportStatus("FAILED");
        /// <summary>
        /// Constant IN_PROGRESS for ImportStatus
        /// </summary>
        public static readonly ImportStatus IN_PROGRESS = new ImportStatus("IN_PROGRESS");
        /// <summary>
        /// Constant INITIALIZING for ImportStatus
        /// </summary>
        public static readonly ImportStatus INITIALIZING = new ImportStatus("INITIALIZING");
        /// <summary>
        /// Constant STOPPED for ImportStatus
        /// </summary>
        public static readonly ImportStatus STOPPED = new ImportStatus("STOPPED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ImportStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ImportStatus FindValue(string value)
        {
            return FindValue<ImportStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ImportStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type InsightsMetricDataType.
    /// </summary>
    public class InsightsMetricDataType : ConstantClass
    {

        /// <summary>
        /// Constant FillWithZeros for InsightsMetricDataType
        /// </summary>
        public static readonly InsightsMetricDataType FillWithZeros = new InsightsMetricDataType("FillWithZeros");
        /// <summary>
        /// Constant NonZeroData for InsightsMetricDataType
        /// </summary>
        public static readonly InsightsMetricDataType NonZeroData = new InsightsMetricDataType("NonZeroData");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public InsightsMetricDataType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static InsightsMetricDataType FindValue(string value)
        {
            return FindValue<InsightsMetricDataType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator InsightsMetricDataType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type InsightType.
    /// </summary>
    public class InsightType : ConstantClass
    {

        /// <summary>
        /// Constant ApiCallRateInsight for InsightType
        /// </summary>
        public static readonly InsightType ApiCallRateInsight = new InsightType("ApiCallRateInsight");
        /// <summary>
        /// Constant ApiErrorRateInsight for InsightType
        /// </summary>
        public static readonly InsightType ApiErrorRateInsight = new InsightType("ApiErrorRateInsight");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public InsightType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static InsightType FindValue(string value)
        {
            return FindValue<InsightType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator InsightType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type LookupAttributeKey.
    /// </summary>
    public class LookupAttributeKey : ConstantClass
    {

        /// <summary>
        /// Constant AccessKeyId for LookupAttributeKey
        /// </summary>
        public static readonly LookupAttributeKey AccessKeyId = new LookupAttributeKey("AccessKeyId");
        /// <summary>
        /// Constant EventId for LookupAttributeKey
        /// </summary>
        public static readonly LookupAttributeKey EventId = new LookupAttributeKey("EventId");
        /// <summary>
        /// Constant EventName for LookupAttributeKey
        /// </summary>
        public static readonly LookupAttributeKey EventName = new LookupAttributeKey("EventName");
        /// <summary>
        /// Constant EventSource for LookupAttributeKey
        /// </summary>
        public static readonly LookupAttributeKey EventSource = new LookupAttributeKey("EventSource");
        /// <summary>
        /// Constant ReadOnly for LookupAttributeKey
        /// </summary>
        public static readonly LookupAttributeKey ReadOnly = new LookupAttributeKey("ReadOnly");
        /// <summary>
        /// Constant ResourceName for LookupAttributeKey
        /// </summary>
        public static readonly LookupAttributeKey ResourceName = new LookupAttributeKey("ResourceName");
        /// <summary>
        /// Constant ResourceType for LookupAttributeKey
        /// </summary>
        public static readonly LookupAttributeKey ResourceType = new LookupAttributeKey("ResourceType");
        /// <summary>
        /// Constant Username for LookupAttributeKey
        /// </summary>
        public static readonly LookupAttributeKey Username = new LookupAttributeKey("Username");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public LookupAttributeKey(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LookupAttributeKey FindValue(string value)
        {
            return FindValue<LookupAttributeKey>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator LookupAttributeKey(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type MaxEventSize.
    /// </summary>
    public class MaxEventSize : ConstantClass
    {

        /// <summary>
        /// Constant Large for MaxEventSize
        /// </summary>
        public static readonly MaxEventSize Large = new MaxEventSize("Large");
        /// <summary>
        /// Constant Standard for MaxEventSize
        /// </summary>
        public static readonly MaxEventSize Standard = new MaxEventSize("Standard");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MaxEventSize(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MaxEventSize FindValue(string value)
        {
            return FindValue<MaxEventSize>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MaxEventSize(string value)
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
        /// Constant CANCELLED for QueryStatus
        /// </summary>
        public static readonly QueryStatus CANCELLED = new QueryStatus("CANCELLED");
        /// <summary>
        /// Constant FAILED for QueryStatus
        /// </summary>
        public static readonly QueryStatus FAILED = new QueryStatus("FAILED");
        /// <summary>
        /// Constant FINISHED for QueryStatus
        /// </summary>
        public static readonly QueryStatus FINISHED = new QueryStatus("FINISHED");
        /// <summary>
        /// Constant QUEUED for QueryStatus
        /// </summary>
        public static readonly QueryStatus QUEUED = new QueryStatus("QUEUED");
        /// <summary>
        /// Constant RUNNING for QueryStatus
        /// </summary>
        public static readonly QueryStatus RUNNING = new QueryStatus("RUNNING");
        /// <summary>
        /// Constant TIMED_OUT for QueryStatus
        /// </summary>
        public static readonly QueryStatus TIMED_OUT = new QueryStatus("TIMED_OUT");

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
    /// Constants used for properties of type ReadWriteType.
    /// </summary>
    public class ReadWriteType : ConstantClass
    {

        /// <summary>
        /// Constant All for ReadWriteType
        /// </summary>
        public static readonly ReadWriteType All = new ReadWriteType("All");
        /// <summary>
        /// Constant ReadOnly for ReadWriteType
        /// </summary>
        public static readonly ReadWriteType ReadOnly = new ReadWriteType("ReadOnly");
        /// <summary>
        /// Constant WriteOnly for ReadWriteType
        /// </summary>
        public static readonly ReadWriteType WriteOnly = new ReadWriteType("WriteOnly");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ReadWriteType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ReadWriteType FindValue(string value)
        {
            return FindValue<ReadWriteType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ReadWriteType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RefreshScheduleFrequencyUnit.
    /// </summary>
    public class RefreshScheduleFrequencyUnit : ConstantClass
    {

        /// <summary>
        /// Constant DAYS for RefreshScheduleFrequencyUnit
        /// </summary>
        public static readonly RefreshScheduleFrequencyUnit DAYS = new RefreshScheduleFrequencyUnit("DAYS");
        /// <summary>
        /// Constant HOURS for RefreshScheduleFrequencyUnit
        /// </summary>
        public static readonly RefreshScheduleFrequencyUnit HOURS = new RefreshScheduleFrequencyUnit("HOURS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RefreshScheduleFrequencyUnit(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RefreshScheduleFrequencyUnit FindValue(string value)
        {
            return FindValue<RefreshScheduleFrequencyUnit>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RefreshScheduleFrequencyUnit(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RefreshScheduleStatus.
    /// </summary>
    public class RefreshScheduleStatus : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for RefreshScheduleStatus
        /// </summary>
        public static readonly RefreshScheduleStatus DISABLED = new RefreshScheduleStatus("DISABLED");
        /// <summary>
        /// Constant ENABLED for RefreshScheduleStatus
        /// </summary>
        public static readonly RefreshScheduleStatus ENABLED = new RefreshScheduleStatus("ENABLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RefreshScheduleStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RefreshScheduleStatus FindValue(string value)
        {
            return FindValue<RefreshScheduleStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RefreshScheduleStatus(string value)
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
        /// Constant RequestContext for Type
        /// </summary>
        public static readonly Type RequestContext = new Type("RequestContext");
        /// <summary>
        /// Constant TagContext for Type
        /// </summary>
        public static readonly Type TagContext = new Type("TagContext");

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