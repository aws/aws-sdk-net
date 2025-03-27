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
 * Do not modify this file. This file is generated from the gameliftstreams-2018-05-10.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.GameLiftStreams
{

    /// <summary>
    /// Constants used for properties of type ApplicationStatus.
    /// </summary>
    public class ApplicationStatus : ConstantClass
    {

        /// <summary>
        /// Constant DELETING for ApplicationStatus
        /// </summary>
        public static readonly ApplicationStatus DELETING = new ApplicationStatus("DELETING");
        /// <summary>
        /// Constant ERROR for ApplicationStatus
        /// </summary>
        public static readonly ApplicationStatus ERROR = new ApplicationStatus("ERROR");
        /// <summary>
        /// Constant INITIALIZED for ApplicationStatus
        /// </summary>
        public static readonly ApplicationStatus INITIALIZED = new ApplicationStatus("INITIALIZED");
        /// <summary>
        /// Constant PROCESSING for ApplicationStatus
        /// </summary>
        public static readonly ApplicationStatus PROCESSING = new ApplicationStatus("PROCESSING");
        /// <summary>
        /// Constant READY for ApplicationStatus
        /// </summary>
        public static readonly ApplicationStatus READY = new ApplicationStatus("READY");

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
    /// Constants used for properties of type ApplicationStatusReason.
    /// </summary>
    public class ApplicationStatusReason : ConstantClass
    {

        /// <summary>
        /// Constant AccessDenied for ApplicationStatusReason
        /// </summary>
        public static readonly ApplicationStatusReason AccessDenied = new ApplicationStatusReason("accessDenied");
        /// <summary>
        /// Constant InternalError for ApplicationStatusReason
        /// </summary>
        public static readonly ApplicationStatusReason InternalError = new ApplicationStatusReason("internalError");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ApplicationStatusReason(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ApplicationStatusReason FindValue(string value)
        {
            return FindValue<ApplicationStatusReason>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ApplicationStatusReason(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ExportFilesStatus.
    /// </summary>
    public class ExportFilesStatus : ConstantClass
    {

        /// <summary>
        /// Constant FAILED for ExportFilesStatus
        /// </summary>
        public static readonly ExportFilesStatus FAILED = new ExportFilesStatus("FAILED");
        /// <summary>
        /// Constant PENDING for ExportFilesStatus
        /// </summary>
        public static readonly ExportFilesStatus PENDING = new ExportFilesStatus("PENDING");
        /// <summary>
        /// Constant SUCCEEDED for ExportFilesStatus
        /// </summary>
        public static readonly ExportFilesStatus SUCCEEDED = new ExportFilesStatus("SUCCEEDED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ExportFilesStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ExportFilesStatus FindValue(string value)
        {
            return FindValue<ExportFilesStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ExportFilesStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Protocol.
    /// </summary>
    public class Protocol : ConstantClass
    {

        /// <summary>
        /// Constant WebRTC for Protocol
        /// </summary>
        public static readonly Protocol WebRTC = new Protocol("WebRTC");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Protocol(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Protocol FindValue(string value)
        {
            return FindValue<Protocol>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Protocol(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ReplicationStatusType.
    /// </summary>
    public class ReplicationStatusType : ConstantClass
    {

        /// <summary>
        /// Constant COMPLETED for ReplicationStatusType
        /// </summary>
        public static readonly ReplicationStatusType COMPLETED = new ReplicationStatusType("COMPLETED");
        /// <summary>
        /// Constant REPLICATING for ReplicationStatusType
        /// </summary>
        public static readonly ReplicationStatusType REPLICATING = new ReplicationStatusType("REPLICATING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ReplicationStatusType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ReplicationStatusType FindValue(string value)
        {
            return FindValue<ReplicationStatusType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ReplicationStatusType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RuntimeEnvironmentType.
    /// </summary>
    public class RuntimeEnvironmentType : ConstantClass
    {

        /// <summary>
        /// Constant PROTON for RuntimeEnvironmentType
        /// </summary>
        public static readonly RuntimeEnvironmentType PROTON = new RuntimeEnvironmentType("PROTON");
        /// <summary>
        /// Constant UBUNTU for RuntimeEnvironmentType
        /// </summary>
        public static readonly RuntimeEnvironmentType UBUNTU = new RuntimeEnvironmentType("UBUNTU");
        /// <summary>
        /// Constant WINDOWS for RuntimeEnvironmentType
        /// </summary>
        public static readonly RuntimeEnvironmentType WINDOWS = new RuntimeEnvironmentType("WINDOWS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RuntimeEnvironmentType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RuntimeEnvironmentType FindValue(string value)
        {
            return FindValue<RuntimeEnvironmentType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RuntimeEnvironmentType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type StreamClass.
    /// </summary>
    public class StreamClass : ConstantClass
    {

        /// <summary>
        /// Constant Gen4n_high for StreamClass
        /// </summary>
        public static readonly StreamClass Gen4n_high = new StreamClass("gen4n_high");
        /// <summary>
        /// Constant Gen4n_ultra for StreamClass
        /// </summary>
        public static readonly StreamClass Gen4n_ultra = new StreamClass("gen4n_ultra");
        /// <summary>
        /// Constant Gen4n_win2022 for StreamClass
        /// </summary>
        public static readonly StreamClass Gen4n_win2022 = new StreamClass("gen4n_win2022");
        /// <summary>
        /// Constant Gen5n_high for StreamClass
        /// </summary>
        public static readonly StreamClass Gen5n_high = new StreamClass("gen5n_high");
        /// <summary>
        /// Constant Gen5n_ultra for StreamClass
        /// </summary>
        public static readonly StreamClass Gen5n_ultra = new StreamClass("gen5n_ultra");
        /// <summary>
        /// Constant Gen5n_win2022 for StreamClass
        /// </summary>
        public static readonly StreamClass Gen5n_win2022 = new StreamClass("gen5n_win2022");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public StreamClass(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static StreamClass FindValue(string value)
        {
            return FindValue<StreamClass>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator StreamClass(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type StreamGroupLocationStatus.
    /// </summary>
    public class StreamGroupLocationStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVATING for StreamGroupLocationStatus
        /// </summary>
        public static readonly StreamGroupLocationStatus ACTIVATING = new StreamGroupLocationStatus("ACTIVATING");
        /// <summary>
        /// Constant ACTIVE for StreamGroupLocationStatus
        /// </summary>
        public static readonly StreamGroupLocationStatus ACTIVE = new StreamGroupLocationStatus("ACTIVE");
        /// <summary>
        /// Constant ERROR for StreamGroupLocationStatus
        /// </summary>
        public static readonly StreamGroupLocationStatus ERROR = new StreamGroupLocationStatus("ERROR");
        /// <summary>
        /// Constant REMOVING for StreamGroupLocationStatus
        /// </summary>
        public static readonly StreamGroupLocationStatus REMOVING = new StreamGroupLocationStatus("REMOVING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public StreamGroupLocationStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static StreamGroupLocationStatus FindValue(string value)
        {
            return FindValue<StreamGroupLocationStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator StreamGroupLocationStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type StreamGroupStatus.
    /// </summary>
    public class StreamGroupStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVATING for StreamGroupStatus
        /// </summary>
        public static readonly StreamGroupStatus ACTIVATING = new StreamGroupStatus("ACTIVATING");
        /// <summary>
        /// Constant ACTIVE for StreamGroupStatus
        /// </summary>
        public static readonly StreamGroupStatus ACTIVE = new StreamGroupStatus("ACTIVE");
        /// <summary>
        /// Constant ACTIVE_WITH_ERRORS for StreamGroupStatus
        /// </summary>
        public static readonly StreamGroupStatus ACTIVE_WITH_ERRORS = new StreamGroupStatus("ACTIVE_WITH_ERRORS");
        /// <summary>
        /// Constant DELETING for StreamGroupStatus
        /// </summary>
        public static readonly StreamGroupStatus DELETING = new StreamGroupStatus("DELETING");
        /// <summary>
        /// Constant ERROR for StreamGroupStatus
        /// </summary>
        public static readonly StreamGroupStatus ERROR = new StreamGroupStatus("ERROR");
        /// <summary>
        /// Constant UPDATING_LOCATIONS for StreamGroupStatus
        /// </summary>
        public static readonly StreamGroupStatus UPDATING_LOCATIONS = new StreamGroupStatus("UPDATING_LOCATIONS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public StreamGroupStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static StreamGroupStatus FindValue(string value)
        {
            return FindValue<StreamGroupStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator StreamGroupStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type StreamGroupStatusReason.
    /// </summary>
    public class StreamGroupStatusReason : ConstantClass
    {

        /// <summary>
        /// Constant InternalError for StreamGroupStatusReason
        /// </summary>
        public static readonly StreamGroupStatusReason InternalError = new StreamGroupStatusReason("internalError");
        /// <summary>
        /// Constant NoAvailableInstances for StreamGroupStatusReason
        /// </summary>
        public static readonly StreamGroupStatusReason NoAvailableInstances = new StreamGroupStatusReason("noAvailableInstances");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public StreamGroupStatusReason(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static StreamGroupStatusReason FindValue(string value)
        {
            return FindValue<StreamGroupStatusReason>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator StreamGroupStatusReason(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type StreamSessionStatus.
    /// </summary>
    public class StreamSessionStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVATING for StreamSessionStatus
        /// </summary>
        public static readonly StreamSessionStatus ACTIVATING = new StreamSessionStatus("ACTIVATING");
        /// <summary>
        /// Constant ACTIVE for StreamSessionStatus
        /// </summary>
        public static readonly StreamSessionStatus ACTIVE = new StreamSessionStatus("ACTIVE");
        /// <summary>
        /// Constant CONNECTED for StreamSessionStatus
        /// </summary>
        public static readonly StreamSessionStatus CONNECTED = new StreamSessionStatus("CONNECTED");
        /// <summary>
        /// Constant ERROR for StreamSessionStatus
        /// </summary>
        public static readonly StreamSessionStatus ERROR = new StreamSessionStatus("ERROR");
        /// <summary>
        /// Constant PENDING_CLIENT_RECONNECTION for StreamSessionStatus
        /// </summary>
        public static readonly StreamSessionStatus PENDING_CLIENT_RECONNECTION = new StreamSessionStatus("PENDING_CLIENT_RECONNECTION");
        /// <summary>
        /// Constant RECONNECTING for StreamSessionStatus
        /// </summary>
        public static readonly StreamSessionStatus RECONNECTING = new StreamSessionStatus("RECONNECTING");
        /// <summary>
        /// Constant TERMINATED for StreamSessionStatus
        /// </summary>
        public static readonly StreamSessionStatus TERMINATED = new StreamSessionStatus("TERMINATED");
        /// <summary>
        /// Constant TERMINATING for StreamSessionStatus
        /// </summary>
        public static readonly StreamSessionStatus TERMINATING = new StreamSessionStatus("TERMINATING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public StreamSessionStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static StreamSessionStatus FindValue(string value)
        {
            return FindValue<StreamSessionStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator StreamSessionStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type StreamSessionStatusReason.
    /// </summary>
    public class StreamSessionStatusReason : ConstantClass
    {

        /// <summary>
        /// Constant ApplicationLogS3DestinationError for StreamSessionStatusReason
        /// </summary>
        public static readonly StreamSessionStatusReason ApplicationLogS3DestinationError = new StreamSessionStatusReason("applicationLogS3DestinationError");
        /// <summary>
        /// Constant InternalError for StreamSessionStatusReason
        /// </summary>
        public static readonly StreamSessionStatusReason InternalError = new StreamSessionStatusReason("internalError");
        /// <summary>
        /// Constant InvalidSignalRequest for StreamSessionStatusReason
        /// </summary>
        public static readonly StreamSessionStatusReason InvalidSignalRequest = new StreamSessionStatusReason("invalidSignalRequest");
        /// <summary>
        /// Constant PlacementTimeout for StreamSessionStatusReason
        /// </summary>
        public static readonly StreamSessionStatusReason PlacementTimeout = new StreamSessionStatusReason("placementTimeout");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public StreamSessionStatusReason(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static StreamSessionStatusReason FindValue(string value)
        {
            return FindValue<StreamSessionStatusReason>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator StreamSessionStatusReason(string value)
        {
            return FindValue(value);
        }
    }

}