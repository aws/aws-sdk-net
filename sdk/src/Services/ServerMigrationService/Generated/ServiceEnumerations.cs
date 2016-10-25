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
 * Do not modify this file. This file is generated from the sms-2016-10-24.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.ServerMigrationService
{

    /// <summary>
    /// Constants used for properties of type ConnectorCapability.
    /// </summary>
    public class ConnectorCapability : ConstantClass
    {

        /// <summary>
        /// Constant VSPHERE for ConnectorCapability
        /// </summary>
        public static readonly ConnectorCapability VSPHERE = new ConnectorCapability("VSPHERE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ConnectorCapability(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ConnectorCapability FindValue(string value)
        {
            return FindValue<ConnectorCapability>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ConnectorCapability(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ConnectorStatus.
    /// </summary>
    public class ConnectorStatus : ConstantClass
    {

        /// <summary>
        /// Constant HEALTHY for ConnectorStatus
        /// </summary>
        public static readonly ConnectorStatus HEALTHY = new ConnectorStatus("HEALTHY");
        /// <summary>
        /// Constant UNHEALTHY for ConnectorStatus
        /// </summary>
        public static readonly ConnectorStatus UNHEALTHY = new ConnectorStatus("UNHEALTHY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ConnectorStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ConnectorStatus FindValue(string value)
        {
            return FindValue<ConnectorStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ConnectorStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type LicenseType.
    /// </summary>
    public class LicenseType : ConstantClass
    {

        /// <summary>
        /// Constant AWS for LicenseType
        /// </summary>
        public static readonly LicenseType AWS = new LicenseType("AWS");
        /// <summary>
        /// Constant BYOL for LicenseType
        /// </summary>
        public static readonly LicenseType BYOL = new LicenseType("BYOL");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public LicenseType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LicenseType FindValue(string value)
        {
            return FindValue<LicenseType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator LicenseType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ReplicationJobState.
    /// </summary>
    public class ReplicationJobState : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for ReplicationJobState
        /// </summary>
        public static readonly ReplicationJobState ACTIVE = new ReplicationJobState("ACTIVE");
        /// <summary>
        /// Constant DELETED for ReplicationJobState
        /// </summary>
        public static readonly ReplicationJobState DELETED = new ReplicationJobState("DELETED");
        /// <summary>
        /// Constant DELETING for ReplicationJobState
        /// </summary>
        public static readonly ReplicationJobState DELETING = new ReplicationJobState("DELETING");
        /// <summary>
        /// Constant FAILED for ReplicationJobState
        /// </summary>
        public static readonly ReplicationJobState FAILED = new ReplicationJobState("FAILED");
        /// <summary>
        /// Constant PENDING for ReplicationJobState
        /// </summary>
        public static readonly ReplicationJobState PENDING = new ReplicationJobState("PENDING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ReplicationJobState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ReplicationJobState FindValue(string value)
        {
            return FindValue<ReplicationJobState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ReplicationJobState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ReplicationRunState.
    /// </summary>
    public class ReplicationRunState : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for ReplicationRunState
        /// </summary>
        public static readonly ReplicationRunState ACTIVE = new ReplicationRunState("ACTIVE");
        /// <summary>
        /// Constant COMPLETED for ReplicationRunState
        /// </summary>
        public static readonly ReplicationRunState COMPLETED = new ReplicationRunState("COMPLETED");
        /// <summary>
        /// Constant DELETED for ReplicationRunState
        /// </summary>
        public static readonly ReplicationRunState DELETED = new ReplicationRunState("DELETED");
        /// <summary>
        /// Constant DELETING for ReplicationRunState
        /// </summary>
        public static readonly ReplicationRunState DELETING = new ReplicationRunState("DELETING");
        /// <summary>
        /// Constant FAILED for ReplicationRunState
        /// </summary>
        public static readonly ReplicationRunState FAILED = new ReplicationRunState("FAILED");
        /// <summary>
        /// Constant MISSED for ReplicationRunState
        /// </summary>
        public static readonly ReplicationRunState MISSED = new ReplicationRunState("MISSED");
        /// <summary>
        /// Constant PENDING for ReplicationRunState
        /// </summary>
        public static readonly ReplicationRunState PENDING = new ReplicationRunState("PENDING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ReplicationRunState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ReplicationRunState FindValue(string value)
        {
            return FindValue<ReplicationRunState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ReplicationRunState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ReplicationRunType.
    /// </summary>
    public class ReplicationRunType : ConstantClass
    {

        /// <summary>
        /// Constant AUTOMATIC for ReplicationRunType
        /// </summary>
        public static readonly ReplicationRunType AUTOMATIC = new ReplicationRunType("AUTOMATIC");
        /// <summary>
        /// Constant ON_DEMAND for ReplicationRunType
        /// </summary>
        public static readonly ReplicationRunType ON_DEMAND = new ReplicationRunType("ON_DEMAND");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ReplicationRunType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ReplicationRunType FindValue(string value)
        {
            return FindValue<ReplicationRunType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ReplicationRunType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ServerCatalogStatus.
    /// </summary>
    public class ServerCatalogStatus : ConstantClass
    {

        /// <summary>
        /// Constant AVAILABLE for ServerCatalogStatus
        /// </summary>
        public static readonly ServerCatalogStatus AVAILABLE = new ServerCatalogStatus("AVAILABLE");
        /// <summary>
        /// Constant DELETED for ServerCatalogStatus
        /// </summary>
        public static readonly ServerCatalogStatus DELETED = new ServerCatalogStatus("DELETED");
        /// <summary>
        /// Constant EXPIRED for ServerCatalogStatus
        /// </summary>
        public static readonly ServerCatalogStatus EXPIRED = new ServerCatalogStatus("EXPIRED");
        /// <summary>
        /// Constant IMPORTING for ServerCatalogStatus
        /// </summary>
        public static readonly ServerCatalogStatus IMPORTING = new ServerCatalogStatus("IMPORTING");
        /// <summary>
        /// Constant NOT_IMPORTED for ServerCatalogStatus
        /// </summary>
        public static readonly ServerCatalogStatus NOT_IMPORTED = new ServerCatalogStatus("NOT_IMPORTED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ServerCatalogStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ServerCatalogStatus FindValue(string value)
        {
            return FindValue<ServerCatalogStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ServerCatalogStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ServerType.
    /// </summary>
    public class ServerType : ConstantClass
    {

        /// <summary>
        /// Constant VIRTUAL_MACHINE for ServerType
        /// </summary>
        public static readonly ServerType VIRTUAL_MACHINE = new ServerType("VIRTUAL_MACHINE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ServerType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ServerType FindValue(string value)
        {
            return FindValue<ServerType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ServerType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type VmManagerType.
    /// </summary>
    public class VmManagerType : ConstantClass
    {

        /// <summary>
        /// Constant VSPHERE for VmManagerType
        /// </summary>
        public static readonly VmManagerType VSPHERE = new VmManagerType("VSPHERE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public VmManagerType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static VmManagerType FindValue(string value)
        {
            return FindValue<VmManagerType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator VmManagerType(string value)
        {
            return FindValue(value);
        }
    }

}