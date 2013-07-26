/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;

using Amazon.Runtime;


namespace Amazon.StorageGateway
{


    /// <summary>Bandwidth Type
    /// </summary>
    public class BandwidthType : ConstantClass
    {


       /// <summary>Constant ALL for BandwidthType
       /// </summary>
        public static readonly BandwidthType ALL = new BandwidthType("ALL");
    

       /// <summary>Constant DOWNLOAD for BandwidthType
       /// </summary>
        public static readonly BandwidthType DOWNLOAD = new BandwidthType("DOWNLOAD");
    

       /// <summary>Constant UPLOAD for BandwidthType
       /// </summary>
        public static readonly BandwidthType UPLOAD = new BandwidthType("UPLOAD");
    

        /// <summary>
        /// Default Constructor
        /// </summary>
        public BandwidthType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static BandwidthType FindValue(string value)
        {
            return FindValue<BandwidthType>(value);
        }

        public static implicit operator BandwidthType(string value)
        {
            return FindValue(value);
        }
    }
    

    /// <summary>Disk Allocation Type
    /// </summary>
    public class DiskAllocationType : ConstantClass
    {


       /// <summary>Constant AVAILABLE for DiskAllocationType
       /// </summary>
        public static readonly DiskAllocationType AVAILABLE = new DiskAllocationType("AVAILABLE");
    

       /// <summary>Constant CACHESTORAGE for DiskAllocationType
       /// </summary>
        public static readonly DiskAllocationType CACHESTORAGE = new DiskAllocationType("CACHE STORAGE");
    

       /// <summary>Constant STOREDISCSIVOLUME for DiskAllocationType
       /// </summary>
        public static readonly DiskAllocationType STOREDISCSIVOLUME = new DiskAllocationType("STORED iSCSI VOLUME");
    

       /// <summary>Constant UPLOADBUFFER for DiskAllocationType
       /// </summary>
        public static readonly DiskAllocationType UPLOADBUFFER = new DiskAllocationType("UPLOAD BUFFER");
    

       /// <summary>Constant WORKINGSTORAGE for DiskAllocationType
       /// </summary>
        public static readonly DiskAllocationType WORKINGSTORAGE = new DiskAllocationType("WORKING STORAGE");
    

        /// <summary>
        /// Default Constructor
        /// </summary>
        public DiskAllocationType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DiskAllocationType FindValue(string value)
        {
            return FindValue<DiskAllocationType>(value);
        }

        public static implicit operator DiskAllocationType(string value)
        {
            return FindValue(value);
        }
    }
    

    /// <summary>Error Code
    /// </summary>
    public class ErrorCode : ConstantClass
    {


       /// <summary>Constant ActivationKeyExpired for ErrorCode
       /// </summary>
        public static readonly ErrorCode ActivationKeyExpired = new ErrorCode("ActivationKeyExpired");
    

       /// <summary>Constant ActivationKeyInvalid for ErrorCode
       /// </summary>
        public static readonly ErrorCode ActivationKeyInvalid = new ErrorCode("ActivationKeyInvalid");
    

       /// <summary>Constant ActivationKeyNotFound for ErrorCode
       /// </summary>
        public static readonly ErrorCode ActivationKeyNotFound = new ErrorCode("ActivationKeyNotFound");
    

       /// <summary>Constant AuthenticationFailure for ErrorCode
       /// </summary>
        public static readonly ErrorCode AuthenticationFailure = new ErrorCode("AuthenticationFailure");
    

       /// <summary>Constant BandwidthThrottleScheduleNotFound for ErrorCode
       /// </summary>
        public static readonly ErrorCode BandwidthThrottleScheduleNotFound = new ErrorCode("BandwidthThrottleScheduleNotFound");
    

       /// <summary>Constant Blocked for ErrorCode
       /// </summary>
        public static readonly ErrorCode Blocked = new ErrorCode("Blocked");
    

       /// <summary>Constant CannotExportSnapshot for ErrorCode
       /// </summary>
        public static readonly ErrorCode CannotExportSnapshot = new ErrorCode("CannotExportSnapshot");
    

       /// <summary>Constant ChapCredentialNotFound for ErrorCode
       /// </summary>
        public static readonly ErrorCode ChapCredentialNotFound = new ErrorCode("ChapCredentialNotFound");
    

       /// <summary>Constant DiskAlreadyAllocated for ErrorCode
       /// </summary>
        public static readonly ErrorCode DiskAlreadyAllocated = new ErrorCode("DiskAlreadyAllocated");
    

       /// <summary>Constant DiskDoesNotExist for ErrorCode
       /// </summary>
        public static readonly ErrorCode DiskDoesNotExist = new ErrorCode("DiskDoesNotExist");
    

       /// <summary>Constant DiskSizeGreaterThanVolumeMaxSize for ErrorCode
       /// </summary>
        public static readonly ErrorCode DiskSizeGreaterThanVolumeMaxSize = new ErrorCode("DiskSizeGreaterThanVolumeMaxSize");
    

       /// <summary>Constant DiskSizeLessThanVolumeSize for ErrorCode
       /// </summary>
        public static readonly ErrorCode DiskSizeLessThanVolumeSize = new ErrorCode("DiskSizeLessThanVolumeSize");
    

       /// <summary>Constant DiskSizeNotGigAligned for ErrorCode
       /// </summary>
        public static readonly ErrorCode DiskSizeNotGigAligned = new ErrorCode("DiskSizeNotGigAligned");
    

       /// <summary>Constant DuplicateCertificateInfo for ErrorCode
       /// </summary>
        public static readonly ErrorCode DuplicateCertificateInfo = new ErrorCode("DuplicateCertificateInfo");
    

       /// <summary>Constant DuplicateSchedule for ErrorCode
       /// </summary>
        public static readonly ErrorCode DuplicateSchedule = new ErrorCode("DuplicateSchedule");
    

       /// <summary>Constant EndpointNotFound for ErrorCode
       /// </summary>
        public static readonly ErrorCode EndpointNotFound = new ErrorCode("EndpointNotFound");
    

       /// <summary>Constant GatewayInternalError for ErrorCode
       /// </summary>
        public static readonly ErrorCode GatewayInternalError = new ErrorCode("GatewayInternalError");
    

       /// <summary>Constant GatewayNotConnected for ErrorCode
       /// </summary>
        public static readonly ErrorCode GatewayNotConnected = new ErrorCode("GatewayNotConnected");
    

       /// <summary>Constant GatewayNotFound for ErrorCode
       /// </summary>
        public static readonly ErrorCode GatewayNotFound = new ErrorCode("GatewayNotFound");
    

       /// <summary>Constant GatewayProxyNetworkConnectionBusy for ErrorCode
       /// </summary>
        public static readonly ErrorCode GatewayProxyNetworkConnectionBusy = new ErrorCode("GatewayProxyNetworkConnectionBusy");
    

       /// <summary>Constant IAMNotSupported for ErrorCode
       /// </summary>
        public static readonly ErrorCode IAMNotSupported = new ErrorCode("IAMNotSupported");
    

       /// <summary>Constant InitiatorInvalid for ErrorCode
       /// </summary>
        public static readonly ErrorCode InitiatorInvalid = new ErrorCode("InitiatorInvalid");
    

       /// <summary>Constant InitiatorNotFound for ErrorCode
       /// </summary>
        public static readonly ErrorCode InitiatorNotFound = new ErrorCode("InitiatorNotFound");
    

       /// <summary>Constant InternalError for ErrorCode
       /// </summary>
        public static readonly ErrorCode InternalError = new ErrorCode("InternalError");
    

       /// <summary>Constant InvalidEndpoint for ErrorCode
       /// </summary>
        public static readonly ErrorCode InvalidEndpoint = new ErrorCode("InvalidEndpoint");
    

       /// <summary>Constant InvalidGateway for ErrorCode
       /// </summary>
        public static readonly ErrorCode InvalidGateway = new ErrorCode("InvalidGateway");
    

       /// <summary>Constant InvalidParameters for ErrorCode
       /// </summary>
        public static readonly ErrorCode InvalidParameters = new ErrorCode("InvalidParameters");
    

       /// <summary>Constant InvalidSchedule for ErrorCode
       /// </summary>
        public static readonly ErrorCode InvalidSchedule = new ErrorCode("InvalidSchedule");
    

       /// <summary>Constant LocalStorageLimitExceeded for ErrorCode
       /// </summary>
        public static readonly ErrorCode LocalStorageLimitExceeded = new ErrorCode("LocalStorageLimitExceeded");
    

       /// <summary>Constant LunAlreadyAllocated for ErrorCode
       /// </summary>
        public static readonly ErrorCode LunAlreadyAllocated = new ErrorCode("LunAlreadyAllocated ");
    

       /// <summary>Constant LunInvalid for ErrorCode
       /// </summary>
        public static readonly ErrorCode LunInvalid = new ErrorCode("LunInvalid");
    

       /// <summary>Constant MaximumContentLengthExceeded for ErrorCode
       /// </summary>
        public static readonly ErrorCode MaximumContentLengthExceeded = new ErrorCode("MaximumContentLengthExceeded");
    

       /// <summary>Constant MaximumTapeCartridgeCountExceeded for ErrorCode
       /// </summary>
        public static readonly ErrorCode MaximumTapeCartridgeCountExceeded = new ErrorCode("MaximumTapeCartridgeCountExceeded");
    

       /// <summary>Constant MaximumVolumeCountExceeded for ErrorCode
       /// </summary>
        public static readonly ErrorCode MaximumVolumeCountExceeded = new ErrorCode("MaximumVolumeCountExceeded");
    

       /// <summary>Constant NetworkConfigurationChanged for ErrorCode
       /// </summary>
        public static readonly ErrorCode NetworkConfigurationChanged = new ErrorCode("NetworkConfigurationChanged");
    

       /// <summary>Constant NoDisksAvailable for ErrorCode
       /// </summary>
        public static readonly ErrorCode NoDisksAvailable = new ErrorCode("NoDisksAvailable");
    

       /// <summary>Constant NotImplemented for ErrorCode
       /// </summary>
        public static readonly ErrorCode NotImplemented = new ErrorCode("NotImplemented");
    

       /// <summary>Constant NotSupported for ErrorCode
       /// </summary>
        public static readonly ErrorCode NotSupported = new ErrorCode("NotSupported");
    

       /// <summary>Constant OperationAborted for ErrorCode
       /// </summary>
        public static readonly ErrorCode OperationAborted = new ErrorCode("OperationAborted");
    

       /// <summary>Constant OutdatedGateway for ErrorCode
       /// </summary>
        public static readonly ErrorCode OutdatedGateway = new ErrorCode("OutdatedGateway");
    

       /// <summary>Constant ParametersNotImplemented for ErrorCode
       /// </summary>
        public static readonly ErrorCode ParametersNotImplemented = new ErrorCode("ParametersNotImplemented");
    

       /// <summary>Constant RegionInvalid for ErrorCode
       /// </summary>
        public static readonly ErrorCode RegionInvalid = new ErrorCode("RegionInvalid");
    

       /// <summary>Constant RequestTimeout for ErrorCode
       /// </summary>
        public static readonly ErrorCode RequestTimeout = new ErrorCode("RequestTimeout");
    

       /// <summary>Constant ServiceUnavailable for ErrorCode
       /// </summary>
        public static readonly ErrorCode ServiceUnavailable = new ErrorCode("ServiceUnavailable");
    

       /// <summary>Constant SnapshotDeleted for ErrorCode
       /// </summary>
        public static readonly ErrorCode SnapshotDeleted = new ErrorCode("SnapshotDeleted");
    

       /// <summary>Constant SnapshotIdInvalid for ErrorCode
       /// </summary>
        public static readonly ErrorCode SnapshotIdInvalid = new ErrorCode("SnapshotIdInvalid");
    

       /// <summary>Constant SnapshotInProgress for ErrorCode
       /// </summary>
        public static readonly ErrorCode SnapshotInProgress = new ErrorCode("SnapshotInProgress");
    

       /// <summary>Constant SnapshotNotFound for ErrorCode
       /// </summary>
        public static readonly ErrorCode SnapshotNotFound = new ErrorCode("SnapshotNotFound");
    

       /// <summary>Constant SnapshotScheduleNotFound for ErrorCode
       /// </summary>
        public static readonly ErrorCode SnapshotScheduleNotFound = new ErrorCode("SnapshotScheduleNotFound");
    

       /// <summary>Constant StagingAreaFull for ErrorCode
       /// </summary>
        public static readonly ErrorCode StagingAreaFull = new ErrorCode("StagingAreaFull");
    

       /// <summary>Constant StorageFailure for ErrorCode
       /// </summary>
        public static readonly ErrorCode StorageFailure = new ErrorCode("StorageFailure");
    

       /// <summary>Constant TapeCartridgeNotFound for ErrorCode
       /// </summary>
        public static readonly ErrorCode TapeCartridgeNotFound = new ErrorCode("TapeCartridgeNotFound");
    

       /// <summary>Constant TargetAlreadyExists for ErrorCode
       /// </summary>
        public static readonly ErrorCode TargetAlreadyExists = new ErrorCode("TargetAlreadyExists");
    

       /// <summary>Constant TargetInvalid for ErrorCode
       /// </summary>
        public static readonly ErrorCode TargetInvalid = new ErrorCode("TargetInvalid");
    

       /// <summary>Constant TargetNotFound for ErrorCode
       /// </summary>
        public static readonly ErrorCode TargetNotFound = new ErrorCode("TargetNotFound");
    

       /// <summary>Constant UnauthorizedOperation for ErrorCode
       /// </summary>
        public static readonly ErrorCode UnauthorizedOperation = new ErrorCode("UnauthorizedOperation");
    

       /// <summary>Constant VolumeAlreadyExists for ErrorCode
       /// </summary>
        public static readonly ErrorCode VolumeAlreadyExists = new ErrorCode("VolumeAlreadyExists");
    

       /// <summary>Constant VolumeIdInvalid for ErrorCode
       /// </summary>
        public static readonly ErrorCode VolumeIdInvalid = new ErrorCode("VolumeIdInvalid");
    

       /// <summary>Constant VolumeInUse for ErrorCode
       /// </summary>
        public static readonly ErrorCode VolumeInUse = new ErrorCode("VolumeInUse");
    

       /// <summary>Constant VolumeNotFound for ErrorCode
       /// </summary>
        public static readonly ErrorCode VolumeNotFound = new ErrorCode("VolumeNotFound");
    

       /// <summary>Constant VolumeNotReady for ErrorCode
       /// </summary>
        public static readonly ErrorCode VolumeNotReady = new ErrorCode("VolumeNotReady");
    

        /// <summary>
        /// Default Constructor
        /// </summary>
        public ErrorCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ErrorCode FindValue(string value)
        {
            return FindValue<ErrorCode>(value);
        }

        public static implicit operator ErrorCode(string value)
        {
            return FindValue(value);
        }
    }
    

    /// <summary>Gateway State
    /// </summary>
    public class GatewayState : ConstantClass
    {


       /// <summary>Constant RUNNING for GatewayState
       /// </summary>
        public static readonly GatewayState RUNNING = new GatewayState("RUNNING");
    

       /// <summary>Constant SHUTDOWN for GatewayState
       /// </summary>
        public static readonly GatewayState SHUTDOWN = new GatewayState("SHUTDOWN");
    

        /// <summary>
        /// Default Constructor
        /// </summary>
        public GatewayState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static GatewayState FindValue(string value)
        {
            return FindValue<GatewayState>(value);
        }

        public static implicit operator GatewayState(string value)
        {
            return FindValue(value);
        }
    }
    

    /// <summary>Gateway Timezone
    /// </summary>
    public class GatewayTimezone : ConstantClass
    {


       /// <summary>Constant GMT for GatewayTimezone
       /// </summary>
        public static readonly GatewayTimezone GMT = new GatewayTimezone("GMT");
    

       /// <summary>Constant GMT_MINUS_100 for GatewayTimezone
       /// </summary>
        public static readonly GatewayTimezone GMT_MINUS_100 = new GatewayTimezone("GMT-1:00");
    

       /// <summary>Constant GMT_MINUS_1000 for GatewayTimezone
       /// </summary>
        public static readonly GatewayTimezone GMT_MINUS_1000 = new GatewayTimezone("GMT-10:00");
    

       /// <summary>Constant GMT_MINUS_1100 for GatewayTimezone
       /// </summary>
        public static readonly GatewayTimezone GMT_MINUS_1100 = new GatewayTimezone("GMT-11:00");
    

       /// <summary>Constant GMT_MINUS_1200 for GatewayTimezone
       /// </summary>
        public static readonly GatewayTimezone GMT_MINUS_1200 = new GatewayTimezone("GMT-12:00");
    

       /// <summary>Constant GMT_MINUS_200 for GatewayTimezone
       /// </summary>
        public static readonly GatewayTimezone GMT_MINUS_200 = new GatewayTimezone("GMT-2:00");
    

       /// <summary>Constant GMT_MINUS_300 for GatewayTimezone
       /// </summary>
        public static readonly GatewayTimezone GMT_MINUS_300 = new GatewayTimezone("GMT-3:00");
    

       /// <summary>Constant GMT_MINUS_330 for GatewayTimezone
       /// </summary>
        public static readonly GatewayTimezone GMT_MINUS_330 = new GatewayTimezone("GMT-3:30");
    

       /// <summary>Constant GMT_MINUS_400 for GatewayTimezone
       /// </summary>
        public static readonly GatewayTimezone GMT_MINUS_400 = new GatewayTimezone("GMT-4:00");
    

       /// <summary>Constant GMT_MINUS_500 for GatewayTimezone
       /// </summary>
        public static readonly GatewayTimezone GMT_MINUS_500 = new GatewayTimezone("GMT-5:00");
    

       /// <summary>Constant GMT_MINUS_600 for GatewayTimezone
       /// </summary>
        public static readonly GatewayTimezone GMT_MINUS_600 = new GatewayTimezone("GMT-6:00");
    

       /// <summary>Constant GMT_MINUS_700 for GatewayTimezone
       /// </summary>
        public static readonly GatewayTimezone GMT_MINUS_700 = new GatewayTimezone("GMT-7:00");
    

       /// <summary>Constant GMT_MINUS_800 for GatewayTimezone
       /// </summary>
        public static readonly GatewayTimezone GMT_MINUS_800 = new GatewayTimezone("GMT-8:00");
    

       /// <summary>Constant GMT_MINUS_900 for GatewayTimezone
       /// </summary>
        public static readonly GatewayTimezone GMT_MINUS_900 = new GatewayTimezone("GMT-9:00");
    

       /// <summary>Constant GMT_PLUS_100 for GatewayTimezone
       /// </summary>
        public static readonly GatewayTimezone GMT_PLUS_100 = new GatewayTimezone("GMT+1:00");
    

       /// <summary>Constant GMT_PLUS_1000 for GatewayTimezone
       /// </summary>
        public static readonly GatewayTimezone GMT_PLUS_1000 = new GatewayTimezone("GMT+10:00");
    

       /// <summary>Constant GMT_PLUS_1100 for GatewayTimezone
       /// </summary>
        public static readonly GatewayTimezone GMT_PLUS_1100 = new GatewayTimezone("GMT+11:00");
    

       /// <summary>Constant GMT_PLUS_1200 for GatewayTimezone
       /// </summary>
        public static readonly GatewayTimezone GMT_PLUS_1200 = new GatewayTimezone("GMT+12:00");
    

       /// <summary>Constant GMT_PLUS_200 for GatewayTimezone
       /// </summary>
        public static readonly GatewayTimezone GMT_PLUS_200 = new GatewayTimezone("GMT+2:00");
    

       /// <summary>Constant GMT_PLUS_300 for GatewayTimezone
       /// </summary>
        public static readonly GatewayTimezone GMT_PLUS_300 = new GatewayTimezone("GMT+3:00");
    

       /// <summary>Constant GMT_PLUS_330 for GatewayTimezone
       /// </summary>
        public static readonly GatewayTimezone GMT_PLUS_330 = new GatewayTimezone("GMT+3:30");
    

       /// <summary>Constant GMT_PLUS_400 for GatewayTimezone
       /// </summary>
        public static readonly GatewayTimezone GMT_PLUS_400 = new GatewayTimezone("GMT+4:00");
    

       /// <summary>Constant GMT_PLUS_430 for GatewayTimezone
       /// </summary>
        public static readonly GatewayTimezone GMT_PLUS_430 = new GatewayTimezone("GMT+4:30");
    

       /// <summary>Constant GMT_PLUS_500 for GatewayTimezone
       /// </summary>
        public static readonly GatewayTimezone GMT_PLUS_500 = new GatewayTimezone("GMT+5:00");
    

       /// <summary>Constant GMT_PLUS_530 for GatewayTimezone
       /// </summary>
        public static readonly GatewayTimezone GMT_PLUS_530 = new GatewayTimezone("GMT+5:30");
    

       /// <summary>Constant GMT_PLUS_545 for GatewayTimezone
       /// </summary>
        public static readonly GatewayTimezone GMT_PLUS_545 = new GatewayTimezone("GMT+5:45");
    

       /// <summary>Constant GMT_PLUS_600 for GatewayTimezone
       /// </summary>
        public static readonly GatewayTimezone GMT_PLUS_600 = new GatewayTimezone("GMT+6:00");
    

       /// <summary>Constant GMT_PLUS_700 for GatewayTimezone
       /// </summary>
        public static readonly GatewayTimezone GMT_PLUS_700 = new GatewayTimezone("GMT+7:00");
    

       /// <summary>Constant GMT_PLUS_800 for GatewayTimezone
       /// </summary>
        public static readonly GatewayTimezone GMT_PLUS_800 = new GatewayTimezone("GMT+8:00");
    

       /// <summary>Constant GMT_PLUS_900 for GatewayTimezone
       /// </summary>
        public static readonly GatewayTimezone GMT_PLUS_900 = new GatewayTimezone("GMT+9:00");
    

       /// <summary>Constant GMT_PLUS_930 for GatewayTimezone
       /// </summary>
        public static readonly GatewayTimezone GMT_PLUS_930 = new GatewayTimezone("GMT+9:30");
    

        /// <summary>
        /// Default Constructor
        /// </summary>
        public GatewayTimezone(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static GatewayTimezone FindValue(string value)
        {
            return FindValue<GatewayTimezone>(value);
        }

        public static implicit operator GatewayTimezone(string value)
        {
            return FindValue(value);
        }
    }
    

    /// <summary>Gateway Type
    /// </summary>
    public class GatewayType : ConstantClass
    {


       /// <summary>Constant CACHED for GatewayType
       /// </summary>
        public static readonly GatewayType CACHED = new GatewayType("CACHED");
    

       /// <summary>Constant STORED for GatewayType
       /// </summary>
        public static readonly GatewayType STORED = new GatewayType("STORED");
    

        /// <summary>
        /// Default Constructor
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

        public static implicit operator GatewayType(string value)
        {
            return FindValue(value);
        }
    }
    

    /// <summary>Volume Status
    /// </summary>
    public class VolumeStatus : ConstantClass
    {


       /// <summary>Constant AVAILABLE for VolumeStatus
       /// </summary>
        public static readonly VolumeStatus AVAILABLE = new VolumeStatus("AVAILABLE");
    

       /// <summary>Constant BOOTSTRAPPING for VolumeStatus
       /// </summary>
        public static readonly VolumeStatus BOOTSTRAPPING = new VolumeStatus("BOOTSTRAPPING");
    

       /// <summary>Constant CREATING for VolumeStatus
       /// </summary>
        public static readonly VolumeStatus CREATING = new VolumeStatus("CREATING");
    

       /// <summary>Constant DELETED for VolumeStatus
       /// </summary>
        public static readonly VolumeStatus DELETED = new VolumeStatus("DELETED");
    

       /// <summary>Constant IRRECOVERABLE for VolumeStatus
       /// </summary>
        public static readonly VolumeStatus IRRECOVERABLE = new VolumeStatus("IRRECOVERABLE");
    

       /// <summary>Constant PASSTHROUGH for VolumeStatus
       /// </summary>
        public static readonly VolumeStatus PASSTHROUGH = new VolumeStatus("PASS THROUGH");
    

       /// <summary>Constant RESTOREANDPASSTHROUGH for VolumeStatus
       /// </summary>
        public static readonly VolumeStatus RESTOREANDPASSTHROUGH = new VolumeStatus("RESTORE AND PASS THROUGH");
    

       /// <summary>Constant RESTORING for VolumeStatus
       /// </summary>
        public static readonly VolumeStatus RESTORING = new VolumeStatus("RESTORING");
    

       /// <summary>Constant UPLOADBUFFERNOTCONFIGURED for VolumeStatus
       /// </summary>
        public static readonly VolumeStatus UPLOADBUFFERNOTCONFIGURED = new VolumeStatus("UPLOAD BUFFER NOT CONFIGURED");
    

       /// <summary>Constant WORKINGSTORAGENOTCONFIGURED for VolumeStatus
       /// </summary>
        public static readonly VolumeStatus WORKINGSTORAGENOTCONFIGURED = new VolumeStatus("WORKING STORAGE NOT CONFIGURED");
    

        /// <summary>
        /// Default Constructor
        /// </summary>
        public VolumeStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static VolumeStatus FindValue(string value)
        {
            return FindValue<VolumeStatus>(value);
        }

        public static implicit operator VolumeStatus(string value)
        {
            return FindValue(value);
        }
    }
    

    /// <summary>Volume Type
    /// </summary>
    public class VolumeType : ConstantClass
    {


       /// <summary>Constant CACHEDISCSI for VolumeType
       /// </summary>
        public static readonly VolumeType CACHEDISCSI = new VolumeType("CACHED iSCSI");
    

       /// <summary>Constant STOREDISCSI for VolumeType
       /// </summary>
        public static readonly VolumeType STOREDISCSI = new VolumeType("STORED iSCSI");
    

        /// <summary>
        /// Default Constructor
        /// </summary>
        public VolumeType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static VolumeType FindValue(string value)
        {
            return FindValue<VolumeType>(value);
        }

        public static implicit operator VolumeType(string value)
        {
            return FindValue(value);
        }
    }
    

}
        
