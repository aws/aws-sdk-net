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
 * Do not modify this file. This file is generated from the opsworkscm-2016-11-01.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.OpsWorksCM
{

    /// <summary>
    /// Constants used for properties of type BackupStatus.
    /// </summary>
    public class BackupStatus : ConstantClass
    {

        /// <summary>
        /// Constant DELETING for BackupStatus
        /// </summary>
        public static readonly BackupStatus DELETING = new BackupStatus("DELETING");
        /// <summary>
        /// Constant FAILED for BackupStatus
        /// </summary>
        public static readonly BackupStatus FAILED = new BackupStatus("FAILED");
        /// <summary>
        /// Constant IN_PROGRESS for BackupStatus
        /// </summary>
        public static readonly BackupStatus IN_PROGRESS = new BackupStatus("IN_PROGRESS");
        /// <summary>
        /// Constant OK for BackupStatus
        /// </summary>
        public static readonly BackupStatus OK = new BackupStatus("OK");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public BackupStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static BackupStatus FindValue(string value)
        {
            return FindValue<BackupStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator BackupStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type BackupType.
    /// </summary>
    public class BackupType : ConstantClass
    {

        /// <summary>
        /// Constant AUTOMATED for BackupType
        /// </summary>
        public static readonly BackupType AUTOMATED = new BackupType("AUTOMATED");
        /// <summary>
        /// Constant MANUAL for BackupType
        /// </summary>
        public static readonly BackupType MANUAL = new BackupType("MANUAL");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public BackupType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static BackupType FindValue(string value)
        {
            return FindValue<BackupType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator BackupType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type MaintenanceStatus.
    /// </summary>
    public class MaintenanceStatus : ConstantClass
    {

        /// <summary>
        /// Constant FAILED for MaintenanceStatus
        /// </summary>
        public static readonly MaintenanceStatus FAILED = new MaintenanceStatus("FAILED");
        /// <summary>
        /// Constant SUCCESS for MaintenanceStatus
        /// </summary>
        public static readonly MaintenanceStatus SUCCESS = new MaintenanceStatus("SUCCESS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MaintenanceStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MaintenanceStatus FindValue(string value)
        {
            return FindValue<MaintenanceStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MaintenanceStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type NodeAssociationStatus.
    /// </summary>
    public class NodeAssociationStatus : ConstantClass
    {

        /// <summary>
        /// Constant FAILED for NodeAssociationStatus
        /// </summary>
        public static readonly NodeAssociationStatus FAILED = new NodeAssociationStatus("FAILED");
        /// <summary>
        /// Constant IN_PROGRESS for NodeAssociationStatus
        /// </summary>
        public static readonly NodeAssociationStatus IN_PROGRESS = new NodeAssociationStatus("IN_PROGRESS");
        /// <summary>
        /// Constant SUCCESS for NodeAssociationStatus
        /// </summary>
        public static readonly NodeAssociationStatus SUCCESS = new NodeAssociationStatus("SUCCESS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public NodeAssociationStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static NodeAssociationStatus FindValue(string value)
        {
            return FindValue<NodeAssociationStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator NodeAssociationStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ServerStatus.
    /// </summary>
    public class ServerStatus : ConstantClass
    {

        /// <summary>
        /// Constant BACKING_UP for ServerStatus
        /// </summary>
        public static readonly ServerStatus BACKING_UP = new ServerStatus("BACKING_UP");
        /// <summary>
        /// Constant CONNECTION_LOST for ServerStatus
        /// </summary>
        public static readonly ServerStatus CONNECTION_LOST = new ServerStatus("CONNECTION_LOST");
        /// <summary>
        /// Constant CREATING for ServerStatus
        /// </summary>
        public static readonly ServerStatus CREATING = new ServerStatus("CREATING");
        /// <summary>
        /// Constant DELETING for ServerStatus
        /// </summary>
        public static readonly ServerStatus DELETING = new ServerStatus("DELETING");
        /// <summary>
        /// Constant FAILED for ServerStatus
        /// </summary>
        public static readonly ServerStatus FAILED = new ServerStatus("FAILED");
        /// <summary>
        /// Constant HEALTHY for ServerStatus
        /// </summary>
        public static readonly ServerStatus HEALTHY = new ServerStatus("HEALTHY");
        /// <summary>
        /// Constant MODIFYING for ServerStatus
        /// </summary>
        public static readonly ServerStatus MODIFYING = new ServerStatus("MODIFYING");
        /// <summary>
        /// Constant RESTORING for ServerStatus
        /// </summary>
        public static readonly ServerStatus RESTORING = new ServerStatus("RESTORING");
        /// <summary>
        /// Constant RUNNING for ServerStatus
        /// </summary>
        public static readonly ServerStatus RUNNING = new ServerStatus("RUNNING");
        /// <summary>
        /// Constant SETUP for ServerStatus
        /// </summary>
        public static readonly ServerStatus SETUP = new ServerStatus("SETUP");
        /// <summary>
        /// Constant TERMINATED for ServerStatus
        /// </summary>
        public static readonly ServerStatus TERMINATED = new ServerStatus("TERMINATED");
        /// <summary>
        /// Constant UNDER_MAINTENANCE for ServerStatus
        /// </summary>
        public static readonly ServerStatus UNDER_MAINTENANCE = new ServerStatus("UNDER_MAINTENANCE");
        /// <summary>
        /// Constant UNHEALTHY for ServerStatus
        /// </summary>
        public static readonly ServerStatus UNHEALTHY = new ServerStatus("UNHEALTHY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ServerStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ServerStatus FindValue(string value)
        {
            return FindValue<ServerStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ServerStatus(string value)
        {
            return FindValue(value);
        }
    }

}