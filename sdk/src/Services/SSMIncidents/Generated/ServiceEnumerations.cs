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
 * Do not modify this file. This file is generated from the ssm-incidents-2018-05-10.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.SSMIncidents
{

    /// <summary>
    /// Constants used for properties of type IncidentRecordStatus.
    /// </summary>
    public class IncidentRecordStatus : ConstantClass
    {

        /// <summary>
        /// Constant OPEN for IncidentRecordStatus
        /// </summary>
        public static readonly IncidentRecordStatus OPEN = new IncidentRecordStatus("OPEN");
        /// <summary>
        /// Constant RESOLVED for IncidentRecordStatus
        /// </summary>
        public static readonly IncidentRecordStatus RESOLVED = new IncidentRecordStatus("RESOLVED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public IncidentRecordStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static IncidentRecordStatus FindValue(string value)
        {
            return FindValue<IncidentRecordStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator IncidentRecordStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ItemType.
    /// </summary>
    public class ItemType : ConstantClass
    {

        /// <summary>
        /// Constant ANALYSIS for ItemType
        /// </summary>
        public static readonly ItemType ANALYSIS = new ItemType("ANALYSIS");
        /// <summary>
        /// Constant ATTACHMENT for ItemType
        /// </summary>
        public static readonly ItemType ATTACHMENT = new ItemType("ATTACHMENT");
        /// <summary>
        /// Constant AUTOMATION for ItemType
        /// </summary>
        public static readonly ItemType AUTOMATION = new ItemType("AUTOMATION");
        /// <summary>
        /// Constant INCIDENT for ItemType
        /// </summary>
        public static readonly ItemType INCIDENT = new ItemType("INCIDENT");
        /// <summary>
        /// Constant INVOLVED_RESOURCE for ItemType
        /// </summary>
        public static readonly ItemType INVOLVED_RESOURCE = new ItemType("INVOLVED_RESOURCE");
        /// <summary>
        /// Constant METRIC for ItemType
        /// </summary>
        public static readonly ItemType METRIC = new ItemType("METRIC");
        /// <summary>
        /// Constant OTHER for ItemType
        /// </summary>
        public static readonly ItemType OTHER = new ItemType("OTHER");
        /// <summary>
        /// Constant PARENT for ItemType
        /// </summary>
        public static readonly ItemType PARENT = new ItemType("PARENT");
        /// <summary>
        /// Constant TASK for ItemType
        /// </summary>
        public static readonly ItemType TASK = new ItemType("TASK");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ItemType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ItemType FindValue(string value)
        {
            return FindValue<ItemType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ItemType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RegionStatus.
    /// </summary>
    public class RegionStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for RegionStatus
        /// </summary>
        public static readonly RegionStatus ACTIVE = new RegionStatus("ACTIVE");
        /// <summary>
        /// Constant CREATING for RegionStatus
        /// </summary>
        public static readonly RegionStatus CREATING = new RegionStatus("CREATING");
        /// <summary>
        /// Constant DELETING for RegionStatus
        /// </summary>
        public static readonly RegionStatus DELETING = new RegionStatus("DELETING");
        /// <summary>
        /// Constant FAILED for RegionStatus
        /// </summary>
        public static readonly RegionStatus FAILED = new RegionStatus("FAILED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RegionStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RegionStatus FindValue(string value)
        {
            return FindValue<RegionStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RegionStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ReplicationSetStatus.
    /// </summary>
    public class ReplicationSetStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for ReplicationSetStatus
        /// </summary>
        public static readonly ReplicationSetStatus ACTIVE = new ReplicationSetStatus("ACTIVE");
        /// <summary>
        /// Constant CREATING for ReplicationSetStatus
        /// </summary>
        public static readonly ReplicationSetStatus CREATING = new ReplicationSetStatus("CREATING");
        /// <summary>
        /// Constant DELETING for ReplicationSetStatus
        /// </summary>
        public static readonly ReplicationSetStatus DELETING = new ReplicationSetStatus("DELETING");
        /// <summary>
        /// Constant FAILED for ReplicationSetStatus
        /// </summary>
        public static readonly ReplicationSetStatus FAILED = new ReplicationSetStatus("FAILED");
        /// <summary>
        /// Constant UPDATING for ReplicationSetStatus
        /// </summary>
        public static readonly ReplicationSetStatus UPDATING = new ReplicationSetStatus("UPDATING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ReplicationSetStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ReplicationSetStatus FindValue(string value)
        {
            return FindValue<ReplicationSetStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ReplicationSetStatus(string value)
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
        /// Constant INCIDENT_RECORD for ResourceType
        /// </summary>
        public static readonly ResourceType INCIDENT_RECORD = new ResourceType("INCIDENT_RECORD");
        /// <summary>
        /// Constant REPLICATION_SET for ResourceType
        /// </summary>
        public static readonly ResourceType REPLICATION_SET = new ResourceType("REPLICATION_SET");
        /// <summary>
        /// Constant RESOURCE_POLICY for ResourceType
        /// </summary>
        public static readonly ResourceType RESOURCE_POLICY = new ResourceType("RESOURCE_POLICY");
        /// <summary>
        /// Constant RESPONSE_PLAN for ResourceType
        /// </summary>
        public static readonly ResourceType RESPONSE_PLAN = new ResourceType("RESPONSE_PLAN");
        /// <summary>
        /// Constant TIMELINE_EVENT for ResourceType
        /// </summary>
        public static readonly ResourceType TIMELINE_EVENT = new ResourceType("TIMELINE_EVENT");

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
    /// Constants used for properties of type ServiceCode.
    /// </summary>
    public class ServiceCode : ConstantClass
    {

        /// <summary>
        /// Constant SsmIncidents for ServiceCode
        /// </summary>
        public static readonly ServiceCode SsmIncidents = new ServiceCode("ssm-incidents");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ServiceCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ServiceCode FindValue(string value)
        {
            return FindValue<ServiceCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ServiceCode(string value)
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
        /// Constant ASCENDING for SortOrder
        /// </summary>
        public static readonly SortOrder ASCENDING = new SortOrder("ASCENDING");
        /// <summary>
        /// Constant DESCENDING for SortOrder
        /// </summary>
        public static readonly SortOrder DESCENDING = new SortOrder("DESCENDING");

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
    /// Constants used for properties of type SsmTargetAccount.
    /// </summary>
    public class SsmTargetAccount : ConstantClass
    {

        /// <summary>
        /// Constant IMPACTED_ACCOUNT for SsmTargetAccount
        /// </summary>
        public static readonly SsmTargetAccount IMPACTED_ACCOUNT = new SsmTargetAccount("IMPACTED_ACCOUNT");
        /// <summary>
        /// Constant RESPONSE_PLAN_OWNER_ACCOUNT for SsmTargetAccount
        /// </summary>
        public static readonly SsmTargetAccount RESPONSE_PLAN_OWNER_ACCOUNT = new SsmTargetAccount("RESPONSE_PLAN_OWNER_ACCOUNT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SsmTargetAccount(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SsmTargetAccount FindValue(string value)
        {
            return FindValue<SsmTargetAccount>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SsmTargetAccount(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TimelineEventSort.
    /// </summary>
    public class TimelineEventSort : ConstantClass
    {

        /// <summary>
        /// Constant EVENT_TIME for TimelineEventSort
        /// </summary>
        public static readonly TimelineEventSort EVENT_TIME = new TimelineEventSort("EVENT_TIME");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TimelineEventSort(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TimelineEventSort FindValue(string value)
        {
            return FindValue<TimelineEventSort>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TimelineEventSort(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type VariableType.
    /// </summary>
    public class VariableType : ConstantClass
    {

        /// <summary>
        /// Constant INCIDENT_RECORD_ARN for VariableType
        /// </summary>
        public static readonly VariableType INCIDENT_RECORD_ARN = new VariableType("INCIDENT_RECORD_ARN");
        /// <summary>
        /// Constant INVOLVED_RESOURCES for VariableType
        /// </summary>
        public static readonly VariableType INVOLVED_RESOURCES = new VariableType("INVOLVED_RESOURCES");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public VariableType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static VariableType FindValue(string value)
        {
            return FindValue<VariableType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator VariableType(string value)
        {
            return FindValue(value);
        }
    }

}