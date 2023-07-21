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
 * Do not modify this file. This file is generated from the ssm-sap-2018-05-10.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.SsmSap
{

    /// <summary>
    /// Constants used for properties of type ApplicationDiscoveryStatus.
    /// </summary>
    public class ApplicationDiscoveryStatus : ConstantClass
    {

        /// <summary>
        /// Constant DELETING for ApplicationDiscoveryStatus
        /// </summary>
        public static readonly ApplicationDiscoveryStatus DELETING = new ApplicationDiscoveryStatus("DELETING");
        /// <summary>
        /// Constant REFRESH_FAILED for ApplicationDiscoveryStatus
        /// </summary>
        public static readonly ApplicationDiscoveryStatus REFRESH_FAILED = new ApplicationDiscoveryStatus("REFRESH_FAILED");
        /// <summary>
        /// Constant REGISTERING for ApplicationDiscoveryStatus
        /// </summary>
        public static readonly ApplicationDiscoveryStatus REGISTERING = new ApplicationDiscoveryStatus("REGISTERING");
        /// <summary>
        /// Constant REGISTRATION_FAILED for ApplicationDiscoveryStatus
        /// </summary>
        public static readonly ApplicationDiscoveryStatus REGISTRATION_FAILED = new ApplicationDiscoveryStatus("REGISTRATION_FAILED");
        /// <summary>
        /// Constant SUCCESS for ApplicationDiscoveryStatus
        /// </summary>
        public static readonly ApplicationDiscoveryStatus SUCCESS = new ApplicationDiscoveryStatus("SUCCESS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ApplicationDiscoveryStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ApplicationDiscoveryStatus FindValue(string value)
        {
            return FindValue<ApplicationDiscoveryStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ApplicationDiscoveryStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ApplicationStatus.
    /// </summary>
    public class ApplicationStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVATED for ApplicationStatus
        /// </summary>
        public static readonly ApplicationStatus ACTIVATED = new ApplicationStatus("ACTIVATED");
        /// <summary>
        /// Constant DELETING for ApplicationStatus
        /// </summary>
        public static readonly ApplicationStatus DELETING = new ApplicationStatus("DELETING");
        /// <summary>
        /// Constant FAILED for ApplicationStatus
        /// </summary>
        public static readonly ApplicationStatus FAILED = new ApplicationStatus("FAILED");
        /// <summary>
        /// Constant REGISTERING for ApplicationStatus
        /// </summary>
        public static readonly ApplicationStatus REGISTERING = new ApplicationStatus("REGISTERING");
        /// <summary>
        /// Constant STARTING for ApplicationStatus
        /// </summary>
        public static readonly ApplicationStatus STARTING = new ApplicationStatus("STARTING");
        /// <summary>
        /// Constant STOPPED for ApplicationStatus
        /// </summary>
        public static readonly ApplicationStatus STOPPED = new ApplicationStatus("STOPPED");
        /// <summary>
        /// Constant STOPPING for ApplicationStatus
        /// </summary>
        public static readonly ApplicationStatus STOPPING = new ApplicationStatus("STOPPING");
        /// <summary>
        /// Constant UNKNOWN for ApplicationStatus
        /// </summary>
        public static readonly ApplicationStatus UNKNOWN = new ApplicationStatus("UNKNOWN");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ApplicationStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ApplicationStatus FindValue(string value)
        {
            return FindValue<ApplicationStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ApplicationStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ApplicationType.
    /// </summary>
    public class ApplicationType : ConstantClass
    {

        /// <summary>
        /// Constant HANA for ApplicationType
        /// </summary>
        public static readonly ApplicationType HANA = new ApplicationType("HANA");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ApplicationType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ApplicationType FindValue(string value)
        {
            return FindValue<ApplicationType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ApplicationType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type BackintMode.
    /// </summary>
    public class BackintMode : ConstantClass
    {

        /// <summary>
        /// Constant AWSBackup for BackintMode
        /// </summary>
        public static readonly BackintMode AWSBackup = new BackintMode("AWSBackup");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public BackintMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static BackintMode FindValue(string value)
        {
            return FindValue<BackintMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator BackintMode(string value)
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
        /// Constant MAINTENANCE for ClusterStatus
        /// </summary>
        public static readonly ClusterStatus MAINTENANCE = new ClusterStatus("MAINTENANCE");
        /// <summary>
        /// Constant NONE for ClusterStatus
        /// </summary>
        public static readonly ClusterStatus NONE = new ClusterStatus("NONE");
        /// <summary>
        /// Constant OFFLINE for ClusterStatus
        /// </summary>
        public static readonly ClusterStatus OFFLINE = new ClusterStatus("OFFLINE");
        /// <summary>
        /// Constant ONLINE for ClusterStatus
        /// </summary>
        public static readonly ClusterStatus ONLINE = new ClusterStatus("ONLINE");
        /// <summary>
        /// Constant STANDBY for ClusterStatus
        /// </summary>
        public static readonly ClusterStatus STANDBY = new ClusterStatus("STANDBY");

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
    /// Constants used for properties of type ComponentStatus.
    /// </summary>
    public class ComponentStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVATED for ComponentStatus
        /// </summary>
        public static readonly ComponentStatus ACTIVATED = new ComponentStatus("ACTIVATED");
        /// <summary>
        /// Constant RUNNING for ComponentStatus
        /// </summary>
        public static readonly ComponentStatus RUNNING = new ComponentStatus("RUNNING");
        /// <summary>
        /// Constant RUNNING_WITH_ERROR for ComponentStatus
        /// </summary>
        public static readonly ComponentStatus RUNNING_WITH_ERROR = new ComponentStatus("RUNNING_WITH_ERROR");
        /// <summary>
        /// Constant STARTING for ComponentStatus
        /// </summary>
        public static readonly ComponentStatus STARTING = new ComponentStatus("STARTING");
        /// <summary>
        /// Constant STOPPED for ComponentStatus
        /// </summary>
        public static readonly ComponentStatus STOPPED = new ComponentStatus("STOPPED");
        /// <summary>
        /// Constant STOPPING for ComponentStatus
        /// </summary>
        public static readonly ComponentStatus STOPPING = new ComponentStatus("STOPPING");
        /// <summary>
        /// Constant UNDEFINED for ComponentStatus
        /// </summary>
        public static readonly ComponentStatus UNDEFINED = new ComponentStatus("UNDEFINED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ComponentStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ComponentStatus FindValue(string value)
        {
            return FindValue<ComponentStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ComponentStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ComponentType.
    /// </summary>
    public class ComponentType : ConstantClass
    {

        /// <summary>
        /// Constant HANA for ComponentType
        /// </summary>
        public static readonly ComponentType HANA = new ComponentType("HANA");
        /// <summary>
        /// Constant HANA_NODE for ComponentType
        /// </summary>
        public static readonly ComponentType HANA_NODE = new ComponentType("HANA_NODE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ComponentType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ComponentType FindValue(string value)
        {
            return FindValue<ComponentType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ComponentType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CredentialType.
    /// </summary>
    public class CredentialType : ConstantClass
    {

        /// <summary>
        /// Constant ADMIN for CredentialType
        /// </summary>
        public static readonly CredentialType ADMIN = new CredentialType("ADMIN");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CredentialType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CredentialType FindValue(string value)
        {
            return FindValue<CredentialType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CredentialType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DatabaseStatus.
    /// </summary>
    public class DatabaseStatus : ConstantClass
    {

        /// <summary>
        /// Constant ERROR for DatabaseStatus
        /// </summary>
        public static readonly DatabaseStatus ERROR = new DatabaseStatus("ERROR");
        /// <summary>
        /// Constant RUNNING for DatabaseStatus
        /// </summary>
        public static readonly DatabaseStatus RUNNING = new DatabaseStatus("RUNNING");
        /// <summary>
        /// Constant STARTING for DatabaseStatus
        /// </summary>
        public static readonly DatabaseStatus STARTING = new DatabaseStatus("STARTING");
        /// <summary>
        /// Constant STOPPED for DatabaseStatus
        /// </summary>
        public static readonly DatabaseStatus STOPPED = new DatabaseStatus("STOPPED");
        /// <summary>
        /// Constant UNKNOWN for DatabaseStatus
        /// </summary>
        public static readonly DatabaseStatus UNKNOWN = new DatabaseStatus("UNKNOWN");
        /// <summary>
        /// Constant WARNING for DatabaseStatus
        /// </summary>
        public static readonly DatabaseStatus WARNING = new DatabaseStatus("WARNING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DatabaseStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DatabaseStatus FindValue(string value)
        {
            return FindValue<DatabaseStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DatabaseStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DatabaseType.
    /// </summary>
    public class DatabaseType : ConstantClass
    {

        /// <summary>
        /// Constant SYSTEM for DatabaseType
        /// </summary>
        public static readonly DatabaseType SYSTEM = new DatabaseType("SYSTEM");
        /// <summary>
        /// Constant TENANT for DatabaseType
        /// </summary>
        public static readonly DatabaseType TENANT = new DatabaseType("TENANT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DatabaseType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DatabaseType FindValue(string value)
        {
            return FindValue<DatabaseType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DatabaseType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type FilterOperator.
    /// </summary>
    public class FilterOperator : ConstantClass
    {

        /// <summary>
        /// Constant Equals for FilterOperator
        /// </summary>
        public static readonly FilterOperator Equals = new FilterOperator("Equals");
        /// <summary>
        /// Constant GreaterThanOrEquals for FilterOperator
        /// </summary>
        public static readonly FilterOperator GreaterThanOrEquals = new FilterOperator("GreaterThanOrEquals");
        /// <summary>
        /// Constant LessThanOrEquals for FilterOperator
        /// </summary>
        public static readonly FilterOperator LessThanOrEquals = new FilterOperator("LessThanOrEquals");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FilterOperator(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FilterOperator FindValue(string value)
        {
            return FindValue<FilterOperator>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FilterOperator(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type HostRole.
    /// </summary>
    public class HostRole : ConstantClass
    {

        /// <summary>
        /// Constant LEADER for HostRole
        /// </summary>
        public static readonly HostRole LEADER = new HostRole("LEADER");
        /// <summary>
        /// Constant STANDBY for HostRole
        /// </summary>
        public static readonly HostRole STANDBY = new HostRole("STANDBY");
        /// <summary>
        /// Constant UNKNOWN for HostRole
        /// </summary>
        public static readonly HostRole UNKNOWN = new HostRole("UNKNOWN");
        /// <summary>
        /// Constant WORKER for HostRole
        /// </summary>
        public static readonly HostRole WORKER = new HostRole("WORKER");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public HostRole(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static HostRole FindValue(string value)
        {
            return FindValue<HostRole>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator HostRole(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type OperationMode.
    /// </summary>
    public class OperationMode : ConstantClass
    {

        /// <summary>
        /// Constant DELTA_DATASHIPPING for OperationMode
        /// </summary>
        public static readonly OperationMode DELTA_DATASHIPPING = new OperationMode("DELTA_DATASHIPPING");
        /// <summary>
        /// Constant LOGREPLAY for OperationMode
        /// </summary>
        public static readonly OperationMode LOGREPLAY = new OperationMode("LOGREPLAY");
        /// <summary>
        /// Constant LOGREPLAY_READACCESS for OperationMode
        /// </summary>
        public static readonly OperationMode LOGREPLAY_READACCESS = new OperationMode("LOGREPLAY_READACCESS");
        /// <summary>
        /// Constant NONE for OperationMode
        /// </summary>
        public static readonly OperationMode NONE = new OperationMode("NONE");
        /// <summary>
        /// Constant PRIMARY for OperationMode
        /// </summary>
        public static readonly OperationMode PRIMARY = new OperationMode("PRIMARY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public OperationMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static OperationMode FindValue(string value)
        {
            return FindValue<OperationMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator OperationMode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type OperationStatus.
    /// </summary>
    public class OperationStatus : ConstantClass
    {

        /// <summary>
        /// Constant ERROR for OperationStatus
        /// </summary>
        public static readonly OperationStatus ERROR = new OperationStatus("ERROR");
        /// <summary>
        /// Constant INPROGRESS for OperationStatus
        /// </summary>
        public static readonly OperationStatus INPROGRESS = new OperationStatus("INPROGRESS");
        /// <summary>
        /// Constant SUCCESS for OperationStatus
        /// </summary>
        public static readonly OperationStatus SUCCESS = new OperationStatus("SUCCESS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public OperationStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static OperationStatus FindValue(string value)
        {
            return FindValue<OperationStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator OperationStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PermissionActionType.
    /// </summary>
    public class PermissionActionType : ConstantClass
    {

        /// <summary>
        /// Constant RESTORE for PermissionActionType
        /// </summary>
        public static readonly PermissionActionType RESTORE = new PermissionActionType("RESTORE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PermissionActionType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PermissionActionType FindValue(string value)
        {
            return FindValue<PermissionActionType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PermissionActionType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ReplicationMode.
    /// </summary>
    public class ReplicationMode : ConstantClass
    {

        /// <summary>
        /// Constant ASYNC for ReplicationMode
        /// </summary>
        public static readonly ReplicationMode ASYNC = new ReplicationMode("ASYNC");
        /// <summary>
        /// Constant NONE for ReplicationMode
        /// </summary>
        public static readonly ReplicationMode NONE = new ReplicationMode("NONE");
        /// <summary>
        /// Constant PRIMARY for ReplicationMode
        /// </summary>
        public static readonly ReplicationMode PRIMARY = new ReplicationMode("PRIMARY");
        /// <summary>
        /// Constant SYNC for ReplicationMode
        /// </summary>
        public static readonly ReplicationMode SYNC = new ReplicationMode("SYNC");
        /// <summary>
        /// Constant SYNCMEM for ReplicationMode
        /// </summary>
        public static readonly ReplicationMode SYNCMEM = new ReplicationMode("SYNCMEM");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ReplicationMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ReplicationMode FindValue(string value)
        {
            return FindValue<ReplicationMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ReplicationMode(string value)
        {
            return FindValue(value);
        }
    }

}