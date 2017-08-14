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
 * Do not modify this file. This file is generated from the cloudhsmv2-2017-04-28.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.CloudHSMV2
{

    /// <summary>
    /// Constants used for properties of type BackupPolicy.
    /// </summary>
    public class BackupPolicy : ConstantClass
    {

        /// <summary>
        /// Constant DEFAULT for BackupPolicy
        /// </summary>
        public static readonly BackupPolicy DEFAULT = new BackupPolicy("DEFAULT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public BackupPolicy(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static BackupPolicy FindValue(string value)
        {
            return FindValue<BackupPolicy>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator BackupPolicy(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type BackupState.
    /// </summary>
    public class BackupState : ConstantClass
    {

        /// <summary>
        /// Constant CREATE_IN_PROGRESS for BackupState
        /// </summary>
        public static readonly BackupState CREATE_IN_PROGRESS = new BackupState("CREATE_IN_PROGRESS");
        /// <summary>
        /// Constant DELETED for BackupState
        /// </summary>
        public static readonly BackupState DELETED = new BackupState("DELETED");
        /// <summary>
        /// Constant READY for BackupState
        /// </summary>
        public static readonly BackupState READY = new BackupState("READY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public BackupState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static BackupState FindValue(string value)
        {
            return FindValue<BackupState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator BackupState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ClusterState.
    /// </summary>
    public class ClusterState : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for ClusterState
        /// </summary>
        public static readonly ClusterState ACTIVE = new ClusterState("ACTIVE");
        /// <summary>
        /// Constant CREATE_IN_PROGRESS for ClusterState
        /// </summary>
        public static readonly ClusterState CREATE_IN_PROGRESS = new ClusterState("CREATE_IN_PROGRESS");
        /// <summary>
        /// Constant DEGRADED for ClusterState
        /// </summary>
        public static readonly ClusterState DEGRADED = new ClusterState("DEGRADED");
        /// <summary>
        /// Constant DELETE_IN_PROGRESS for ClusterState
        /// </summary>
        public static readonly ClusterState DELETE_IN_PROGRESS = new ClusterState("DELETE_IN_PROGRESS");
        /// <summary>
        /// Constant DELETED for ClusterState
        /// </summary>
        public static readonly ClusterState DELETED = new ClusterState("DELETED");
        /// <summary>
        /// Constant INITIALIZE_IN_PROGRESS for ClusterState
        /// </summary>
        public static readonly ClusterState INITIALIZE_IN_PROGRESS = new ClusterState("INITIALIZE_IN_PROGRESS");
        /// <summary>
        /// Constant INITIALIZED for ClusterState
        /// </summary>
        public static readonly ClusterState INITIALIZED = new ClusterState("INITIALIZED");
        /// <summary>
        /// Constant UNINITIALIZED for ClusterState
        /// </summary>
        public static readonly ClusterState UNINITIALIZED = new ClusterState("UNINITIALIZED");
        /// <summary>
        /// Constant UPDATE_IN_PROGRESS for ClusterState
        /// </summary>
        public static readonly ClusterState UPDATE_IN_PROGRESS = new ClusterState("UPDATE_IN_PROGRESS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ClusterState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ClusterState FindValue(string value)
        {
            return FindValue<ClusterState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ClusterState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type HsmState.
    /// </summary>
    public class HsmState : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for HsmState
        /// </summary>
        public static readonly HsmState ACTIVE = new HsmState("ACTIVE");
        /// <summary>
        /// Constant CREATE_IN_PROGRESS for HsmState
        /// </summary>
        public static readonly HsmState CREATE_IN_PROGRESS = new HsmState("CREATE_IN_PROGRESS");
        /// <summary>
        /// Constant DEGRADED for HsmState
        /// </summary>
        public static readonly HsmState DEGRADED = new HsmState("DEGRADED");
        /// <summary>
        /// Constant DELETE_IN_PROGRESS for HsmState
        /// </summary>
        public static readonly HsmState DELETE_IN_PROGRESS = new HsmState("DELETE_IN_PROGRESS");
        /// <summary>
        /// Constant DELETED for HsmState
        /// </summary>
        public static readonly HsmState DELETED = new HsmState("DELETED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public HsmState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static HsmState FindValue(string value)
        {
            return FindValue<HsmState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator HsmState(string value)
        {
            return FindValue(value);
        }
    }

}