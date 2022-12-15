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
 * Do not modify this file. This file is generated from the backup-gateway-2021-01-01.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.BackupGateway
{

    /// <summary>
    /// Constants used for properties of type GatewayType.
    /// </summary>
    public class GatewayType : ConstantClass
    {

        /// <summary>
        /// Constant BACKUP_VM for GatewayType
        /// </summary>
        public static readonly GatewayType BACKUP_VM = new GatewayType("BACKUP_VM");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public GatewayType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static GatewayType FindValue(string value)
        {
            return FindValue<GatewayType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator GatewayType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type HypervisorState.
    /// </summary>
    public class HypervisorState : ConstantClass
    {

        /// <summary>
        /// Constant ERROR for HypervisorState
        /// </summary>
        public static readonly HypervisorState ERROR = new HypervisorState("ERROR");
        /// <summary>
        /// Constant OFFLINE for HypervisorState
        /// </summary>
        public static readonly HypervisorState OFFLINE = new HypervisorState("OFFLINE");
        /// <summary>
        /// Constant ONLINE for HypervisorState
        /// </summary>
        public static readonly HypervisorState ONLINE = new HypervisorState("ONLINE");
        /// <summary>
        /// Constant PENDING for HypervisorState
        /// </summary>
        public static readonly HypervisorState PENDING = new HypervisorState("PENDING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public HypervisorState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static HypervisorState FindValue(string value)
        {
            return FindValue<HypervisorState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator HypervisorState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SyncMetadataStatus.
    /// </summary>
    public class SyncMetadataStatus : ConstantClass
    {

        /// <summary>
        /// Constant CREATED for SyncMetadataStatus
        /// </summary>
        public static readonly SyncMetadataStatus CREATED = new SyncMetadataStatus("CREATED");
        /// <summary>
        /// Constant FAILED for SyncMetadataStatus
        /// </summary>
        public static readonly SyncMetadataStatus FAILED = new SyncMetadataStatus("FAILED");
        /// <summary>
        /// Constant PARTIALLY_FAILED for SyncMetadataStatus
        /// </summary>
        public static readonly SyncMetadataStatus PARTIALLY_FAILED = new SyncMetadataStatus("PARTIALLY_FAILED");
        /// <summary>
        /// Constant RUNNING for SyncMetadataStatus
        /// </summary>
        public static readonly SyncMetadataStatus RUNNING = new SyncMetadataStatus("RUNNING");
        /// <summary>
        /// Constant SUCCEEDED for SyncMetadataStatus
        /// </summary>
        public static readonly SyncMetadataStatus SUCCEEDED = new SyncMetadataStatus("SUCCEEDED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SyncMetadataStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SyncMetadataStatus FindValue(string value)
        {
            return FindValue<SyncMetadataStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SyncMetadataStatus(string value)
        {
            return FindValue(value);
        }
    }

}