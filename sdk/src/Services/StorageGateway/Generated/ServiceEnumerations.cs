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
 * Do not modify this file. This file is generated from the storagegateway-2013-06-30.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.StorageGateway
{

    /// <summary>
    /// Constants used for properties of type ActiveDirectoryStatus.
    /// </summary>
    public class ActiveDirectoryStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACCESS_DENIED for ActiveDirectoryStatus
        /// </summary>
        public static readonly ActiveDirectoryStatus ACCESS_DENIED = new ActiveDirectoryStatus("ACCESS_DENIED");
        /// <summary>
        /// Constant DETACHED for ActiveDirectoryStatus
        /// </summary>
        public static readonly ActiveDirectoryStatus DETACHED = new ActiveDirectoryStatus("DETACHED");
        /// <summary>
        /// Constant INSUFFICIENT_PERMISSIONS for ActiveDirectoryStatus
        /// </summary>
        public static readonly ActiveDirectoryStatus INSUFFICIENT_PERMISSIONS = new ActiveDirectoryStatus("INSUFFICIENT_PERMISSIONS");
        /// <summary>
        /// Constant JOINED for ActiveDirectoryStatus
        /// </summary>
        public static readonly ActiveDirectoryStatus JOINED = new ActiveDirectoryStatus("JOINED");
        /// <summary>
        /// Constant JOINING for ActiveDirectoryStatus
        /// </summary>
        public static readonly ActiveDirectoryStatus JOINING = new ActiveDirectoryStatus("JOINING");
        /// <summary>
        /// Constant NETWORK_ERROR for ActiveDirectoryStatus
        /// </summary>
        public static readonly ActiveDirectoryStatus NETWORK_ERROR = new ActiveDirectoryStatus("NETWORK_ERROR");
        /// <summary>
        /// Constant TIMEOUT for ActiveDirectoryStatus
        /// </summary>
        public static readonly ActiveDirectoryStatus TIMEOUT = new ActiveDirectoryStatus("TIMEOUT");
        /// <summary>
        /// Constant UNKNOWN_ERROR for ActiveDirectoryStatus
        /// </summary>
        public static readonly ActiveDirectoryStatus UNKNOWN_ERROR = new ActiveDirectoryStatus("UNKNOWN_ERROR");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ActiveDirectoryStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ActiveDirectoryStatus FindValue(string value)
        {
            return FindValue<ActiveDirectoryStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ActiveDirectoryStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AutomaticUpdatePolicy.
    /// </summary>
    public class AutomaticUpdatePolicy : ConstantClass
    {

        /// <summary>
        /// Constant ALL_VERSIONS for AutomaticUpdatePolicy
        /// </summary>
        public static readonly AutomaticUpdatePolicy ALL_VERSIONS = new AutomaticUpdatePolicy("ALL_VERSIONS");
        /// <summary>
        /// Constant EMERGENCY_VERSIONS_ONLY for AutomaticUpdatePolicy
        /// </summary>
        public static readonly AutomaticUpdatePolicy EMERGENCY_VERSIONS_ONLY = new AutomaticUpdatePolicy("EMERGENCY_VERSIONS_ONLY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AutomaticUpdatePolicy(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AutomaticUpdatePolicy FindValue(string value)
        {
            return FindValue<AutomaticUpdatePolicy>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AutomaticUpdatePolicy(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AvailabilityMonitorTestStatus.
    /// </summary>
    public class AvailabilityMonitorTestStatus : ConstantClass
    {

        /// <summary>
        /// Constant COMPLETE for AvailabilityMonitorTestStatus
        /// </summary>
        public static readonly AvailabilityMonitorTestStatus COMPLETE = new AvailabilityMonitorTestStatus("COMPLETE");
        /// <summary>
        /// Constant FAILED for AvailabilityMonitorTestStatus
        /// </summary>
        public static readonly AvailabilityMonitorTestStatus FAILED = new AvailabilityMonitorTestStatus("FAILED");
        /// <summary>
        /// Constant PENDING for AvailabilityMonitorTestStatus
        /// </summary>
        public static readonly AvailabilityMonitorTestStatus PENDING = new AvailabilityMonitorTestStatus("PENDING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AvailabilityMonitorTestStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AvailabilityMonitorTestStatus FindValue(string value)
        {
            return FindValue<AvailabilityMonitorTestStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AvailabilityMonitorTestStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CacheReportFilterName.
    /// </summary>
    public class CacheReportFilterName : ConstantClass
    {

        /// <summary>
        /// Constant UploadFailureReason for CacheReportFilterName
        /// </summary>
        public static readonly CacheReportFilterName UploadFailureReason = new CacheReportFilterName("UploadFailureReason");
        /// <summary>
        /// Constant UploadState for CacheReportFilterName
        /// </summary>
        public static readonly CacheReportFilterName UploadState = new CacheReportFilterName("UploadState");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CacheReportFilterName(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CacheReportFilterName FindValue(string value)
        {
            return FindValue<CacheReportFilterName>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CacheReportFilterName(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CacheReportStatus.
    /// </summary>
    public class CacheReportStatus : ConstantClass
    {

        /// <summary>
        /// Constant CANCELED for CacheReportStatus
        /// </summary>
        public static readonly CacheReportStatus CANCELED = new CacheReportStatus("CANCELED");
        /// <summary>
        /// Constant COMPLETED for CacheReportStatus
        /// </summary>
        public static readonly CacheReportStatus COMPLETED = new CacheReportStatus("COMPLETED");
        /// <summary>
        /// Constant ERROR for CacheReportStatus
        /// </summary>
        public static readonly CacheReportStatus ERROR = new CacheReportStatus("ERROR");
        /// <summary>
        /// Constant FAILED for CacheReportStatus
        /// </summary>
        public static readonly CacheReportStatus FAILED = new CacheReportStatus("FAILED");
        /// <summary>
        /// Constant IN_PROGRESS for CacheReportStatus
        /// </summary>
        public static readonly CacheReportStatus IN_PROGRESS = new CacheReportStatus("IN_PROGRESS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CacheReportStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CacheReportStatus FindValue(string value)
        {
            return FindValue<CacheReportStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CacheReportStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CaseSensitivity.
    /// </summary>
    public class CaseSensitivity : ConstantClass
    {

        /// <summary>
        /// Constant CaseSensitive for CaseSensitivity
        /// </summary>
        public static readonly CaseSensitivity CaseSensitive = new CaseSensitivity("CaseSensitive");
        /// <summary>
        /// Constant ClientSpecified for CaseSensitivity
        /// </summary>
        public static readonly CaseSensitivity ClientSpecified = new CaseSensitivity("ClientSpecified");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CaseSensitivity(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CaseSensitivity FindValue(string value)
        {
            return FindValue<CaseSensitivity>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CaseSensitivity(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type EncryptionType.
    /// </summary>
    public class EncryptionType : ConstantClass
    {

        /// <summary>
        /// Constant DsseKms for EncryptionType
        /// </summary>
        public static readonly EncryptionType DsseKms = new EncryptionType("DsseKms");
        /// <summary>
        /// Constant SseKms for EncryptionType
        /// </summary>
        public static readonly EncryptionType SseKms = new EncryptionType("SseKms");
        /// <summary>
        /// Constant SseS3 for EncryptionType
        /// </summary>
        public static readonly EncryptionType SseS3 = new EncryptionType("SseS3");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EncryptionType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EncryptionType FindValue(string value)
        {
            return FindValue<EncryptionType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EncryptionType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ErrorCode.
    /// </summary>
    public class ErrorCode : ConstantClass
    {

        /// <summary>
        /// Constant ActivationKeyExpired for ErrorCode
        /// </summary>
        public static readonly ErrorCode ActivationKeyExpired = new ErrorCode("ActivationKeyExpired");
        /// <summary>
        /// Constant ActivationKeyInvalid for ErrorCode
        /// </summary>
        public static readonly ErrorCode ActivationKeyInvalid = new ErrorCode("ActivationKeyInvalid");
        /// <summary>
        /// Constant ActivationKeyNotFound for ErrorCode
        /// </summary>
        public static readonly ErrorCode ActivationKeyNotFound = new ErrorCode("ActivationKeyNotFound");
        /// <summary>
        /// Constant AuthenticationFailure for ErrorCode
        /// </summary>
        public static readonly ErrorCode AuthenticationFailure = new ErrorCode("AuthenticationFailure");
        /// <summary>
        /// Constant BandwidthThrottleScheduleNotFound for ErrorCode
        /// </summary>
        public static readonly ErrorCode BandwidthThrottleScheduleNotFound = new ErrorCode("BandwidthThrottleScheduleNotFound");
        /// <summary>
        /// Constant Blocked for ErrorCode
        /// </summary>
        public static readonly ErrorCode Blocked = new ErrorCode("Blocked");
        /// <summary>
        /// Constant CannotExportSnapshot for ErrorCode
        /// </summary>
        public static readonly ErrorCode CannotExportSnapshot = new ErrorCode("CannotExportSnapshot");
        /// <summary>
        /// Constant ChapCredentialNotFound for ErrorCode
        /// </summary>
        public static readonly ErrorCode ChapCredentialNotFound = new ErrorCode("ChapCredentialNotFound");
        /// <summary>
        /// Constant DiskAlreadyAllocated for ErrorCode
        /// </summary>
        public static readonly ErrorCode DiskAlreadyAllocated = new ErrorCode("DiskAlreadyAllocated");
        /// <summary>
        /// Constant DiskDoesNotExist for ErrorCode
        /// </summary>
        public static readonly ErrorCode DiskDoesNotExist = new ErrorCode("DiskDoesNotExist");
        /// <summary>
        /// Constant DiskSizeGreaterThanVolumeMaxSize for ErrorCode
        /// </summary>
        public static readonly ErrorCode DiskSizeGreaterThanVolumeMaxSize = new ErrorCode("DiskSizeGreaterThanVolumeMaxSize");
        /// <summary>
        /// Constant DiskSizeLessThanVolumeSize for ErrorCode
        /// </summary>
        public static readonly ErrorCode DiskSizeLessThanVolumeSize = new ErrorCode("DiskSizeLessThanVolumeSize");
        /// <summary>
        /// Constant DiskSizeNotGigAligned for ErrorCode
        /// </summary>
        public static readonly ErrorCode DiskSizeNotGigAligned = new ErrorCode("DiskSizeNotGigAligned");
        /// <summary>
        /// Constant DuplicateCertificateInfo for ErrorCode
        /// </summary>
        public static readonly ErrorCode DuplicateCertificateInfo = new ErrorCode("DuplicateCertificateInfo");
        /// <summary>
        /// Constant DuplicateSchedule for ErrorCode
        /// </summary>
        public static readonly ErrorCode DuplicateSchedule = new ErrorCode("DuplicateSchedule");
        /// <summary>
        /// Constant EndpointNotFound for ErrorCode
        /// </summary>
        public static readonly ErrorCode EndpointNotFound = new ErrorCode("EndpointNotFound");
        /// <summary>
        /// Constant GatewayInternalError for ErrorCode
        /// </summary>
        public static readonly ErrorCode GatewayInternalError = new ErrorCode("GatewayInternalError");
        /// <summary>
        /// Constant GatewayNotConnected for ErrorCode
        /// </summary>
        public static readonly ErrorCode GatewayNotConnected = new ErrorCode("GatewayNotConnected");
        /// <summary>
        /// Constant GatewayNotFound for ErrorCode
        /// </summary>
        public static readonly ErrorCode GatewayNotFound = new ErrorCode("GatewayNotFound");
        /// <summary>
        /// Constant GatewayProxyNetworkConnectionBusy for ErrorCode
        /// </summary>
        public static readonly ErrorCode GatewayProxyNetworkConnectionBusy = new ErrorCode("GatewayProxyNetworkConnectionBusy");
        /// <summary>
        /// Constant IAMNotSupported for ErrorCode
        /// </summary>
        public static readonly ErrorCode IAMNotSupported = new ErrorCode("IAMNotSupported");
        /// <summary>
        /// Constant InitiatorInvalid for ErrorCode
        /// </summary>
        public static readonly ErrorCode InitiatorInvalid = new ErrorCode("InitiatorInvalid");
        /// <summary>
        /// Constant InitiatorNotFound for ErrorCode
        /// </summary>
        public static readonly ErrorCode InitiatorNotFound = new ErrorCode("InitiatorNotFound");
        /// <summary>
        /// Constant InternalError for ErrorCode
        /// </summary>
        public static readonly ErrorCode InternalError = new ErrorCode("InternalError");
        /// <summary>
        /// Constant InvalidEndpoint for ErrorCode
        /// </summary>
        public static readonly ErrorCode InvalidEndpoint = new ErrorCode("InvalidEndpoint");
        /// <summary>
        /// Constant InvalidGateway for ErrorCode
        /// </summary>
        public static readonly ErrorCode InvalidGateway = new ErrorCode("InvalidGateway");
        /// <summary>
        /// Constant InvalidParameters for ErrorCode
        /// </summary>
        public static readonly ErrorCode InvalidParameters = new ErrorCode("InvalidParameters");
        /// <summary>
        /// Constant InvalidSchedule for ErrorCode
        /// </summary>
        public static readonly ErrorCode InvalidSchedule = new ErrorCode("InvalidSchedule");
        /// <summary>
        /// Constant JoinDomainInProgress for ErrorCode
        /// </summary>
        public static readonly ErrorCode JoinDomainInProgress = new ErrorCode("JoinDomainInProgress");
        /// <summary>
        /// Constant LocalStorageLimitExceeded for ErrorCode
        /// </summary>
        public static readonly ErrorCode LocalStorageLimitExceeded = new ErrorCode("LocalStorageLimitExceeded");
        /// <summary>
        /// Constant LunAlreadyAllocated for ErrorCode
        /// </summary>
        public static readonly ErrorCode LunAlreadyAllocated = new ErrorCode("LunAlreadyAllocated ");
        /// <summary>
        /// Constant LunInvalid for ErrorCode
        /// </summary>
        public static readonly ErrorCode LunInvalid = new ErrorCode("LunInvalid");
        /// <summary>
        /// Constant MaximumContentLengthExceeded for ErrorCode
        /// </summary>
        public static readonly ErrorCode MaximumContentLengthExceeded = new ErrorCode("MaximumContentLengthExceeded");
        /// <summary>
        /// Constant MaximumTapeCartridgeCountExceeded for ErrorCode
        /// </summary>
        public static readonly ErrorCode MaximumTapeCartridgeCountExceeded = new ErrorCode("MaximumTapeCartridgeCountExceeded");
        /// <summary>
        /// Constant MaximumVolumeCountExceeded for ErrorCode
        /// </summary>
        public static readonly ErrorCode MaximumVolumeCountExceeded = new ErrorCode("MaximumVolumeCountExceeded");
        /// <summary>
        /// Constant NetworkConfigurationChanged for ErrorCode
        /// </summary>
        public static readonly ErrorCode NetworkConfigurationChanged = new ErrorCode("NetworkConfigurationChanged");
        /// <summary>
        /// Constant NoDisksAvailable for ErrorCode
        /// </summary>
        public static readonly ErrorCode NoDisksAvailable = new ErrorCode("NoDisksAvailable");
        /// <summary>
        /// Constant NotImplemented for ErrorCode
        /// </summary>
        public static readonly ErrorCode NotImplemented = new ErrorCode("NotImplemented");
        /// <summary>
        /// Constant NotSupported for ErrorCode
        /// </summary>
        public static readonly ErrorCode NotSupported = new ErrorCode("NotSupported");
        /// <summary>
        /// Constant OperationAborted for ErrorCode
        /// </summary>
        public static readonly ErrorCode OperationAborted = new ErrorCode("OperationAborted");
        /// <summary>
        /// Constant OutdatedGateway for ErrorCode
        /// </summary>
        public static readonly ErrorCode OutdatedGateway = new ErrorCode("OutdatedGateway");
        /// <summary>
        /// Constant ParametersNotImplemented for ErrorCode
        /// </summary>
        public static readonly ErrorCode ParametersNotImplemented = new ErrorCode("ParametersNotImplemented");
        /// <summary>
        /// Constant RegionInvalid for ErrorCode
        /// </summary>
        public static readonly ErrorCode RegionInvalid = new ErrorCode("RegionInvalid");
        /// <summary>
        /// Constant RequestTimeout for ErrorCode
        /// </summary>
        public static readonly ErrorCode RequestTimeout = new ErrorCode("RequestTimeout");
        /// <summary>
        /// Constant ServiceUnavailable for ErrorCode
        /// </summary>
        public static readonly ErrorCode ServiceUnavailable = new ErrorCode("ServiceUnavailable");
        /// <summary>
        /// Constant SnapshotDeleted for ErrorCode
        /// </summary>
        public static readonly ErrorCode SnapshotDeleted = new ErrorCode("SnapshotDeleted");
        /// <summary>
        /// Constant SnapshotIdInvalid for ErrorCode
        /// </summary>
        public static readonly ErrorCode SnapshotIdInvalid = new ErrorCode("SnapshotIdInvalid");
        /// <summary>
        /// Constant SnapshotInProgress for ErrorCode
        /// </summary>
        public static readonly ErrorCode SnapshotInProgress = new ErrorCode("SnapshotInProgress");
        /// <summary>
        /// Constant SnapshotNotFound for ErrorCode
        /// </summary>
        public static readonly ErrorCode SnapshotNotFound = new ErrorCode("SnapshotNotFound");
        /// <summary>
        /// Constant SnapshotScheduleNotFound for ErrorCode
        /// </summary>
        public static readonly ErrorCode SnapshotScheduleNotFound = new ErrorCode("SnapshotScheduleNotFound");
        /// <summary>
        /// Constant StagingAreaFull for ErrorCode
        /// </summary>
        public static readonly ErrorCode StagingAreaFull = new ErrorCode("StagingAreaFull");
        /// <summary>
        /// Constant StorageFailure for ErrorCode
        /// </summary>
        public static readonly ErrorCode StorageFailure = new ErrorCode("StorageFailure");
        /// <summary>
        /// Constant TapeCartridgeNotFound for ErrorCode
        /// </summary>
        public static readonly ErrorCode TapeCartridgeNotFound = new ErrorCode("TapeCartridgeNotFound");
        /// <summary>
        /// Constant TargetAlreadyExists for ErrorCode
        /// </summary>
        public static readonly ErrorCode TargetAlreadyExists = new ErrorCode("TargetAlreadyExists");
        /// <summary>
        /// Constant TargetInvalid for ErrorCode
        /// </summary>
        public static readonly ErrorCode TargetInvalid = new ErrorCode("TargetInvalid");
        /// <summary>
        /// Constant TargetNotFound for ErrorCode
        /// </summary>
        public static readonly ErrorCode TargetNotFound = new ErrorCode("TargetNotFound");
        /// <summary>
        /// Constant UnauthorizedOperation for ErrorCode
        /// </summary>
        public static readonly ErrorCode UnauthorizedOperation = new ErrorCode("UnauthorizedOperation");
        /// <summary>
        /// Constant VolumeAlreadyExists for ErrorCode
        /// </summary>
        public static readonly ErrorCode VolumeAlreadyExists = new ErrorCode("VolumeAlreadyExists");
        /// <summary>
        /// Constant VolumeIdInvalid for ErrorCode
        /// </summary>
        public static readonly ErrorCode VolumeIdInvalid = new ErrorCode("VolumeIdInvalid");
        /// <summary>
        /// Constant VolumeInUse for ErrorCode
        /// </summary>
        public static readonly ErrorCode VolumeInUse = new ErrorCode("VolumeInUse");
        /// <summary>
        /// Constant VolumeNotFound for ErrorCode
        /// </summary>
        public static readonly ErrorCode VolumeNotFound = new ErrorCode("VolumeNotFound");
        /// <summary>
        /// Constant VolumeNotReady for ErrorCode
        /// </summary>
        public static readonly ErrorCode VolumeNotReady = new ErrorCode("VolumeNotReady");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
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

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ErrorCode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type FileShareType.
    /// </summary>
    public class FileShareType : ConstantClass
    {

        /// <summary>
        /// Constant NFS for FileShareType
        /// </summary>
        public static readonly FileShareType NFS = new FileShareType("NFS");
        /// <summary>
        /// Constant SMB for FileShareType
        /// </summary>
        public static readonly FileShareType SMB = new FileShareType("SMB");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FileShareType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FileShareType FindValue(string value)
        {
            return FindValue<FileShareType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FileShareType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type GatewayCapacity.
    /// </summary>
    public class GatewayCapacity : ConstantClass
    {

        /// <summary>
        /// Constant Large for GatewayCapacity
        /// </summary>
        public static readonly GatewayCapacity Large = new GatewayCapacity("Large");
        /// <summary>
        /// Constant Medium for GatewayCapacity
        /// </summary>
        public static readonly GatewayCapacity Medium = new GatewayCapacity("Medium");
        /// <summary>
        /// Constant Small for GatewayCapacity
        /// </summary>
        public static readonly GatewayCapacity Small = new GatewayCapacity("Small");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public GatewayCapacity(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static GatewayCapacity FindValue(string value)
        {
            return FindValue<GatewayCapacity>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator GatewayCapacity(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type HostEnvironment.
    /// </summary>
    public class HostEnvironment : ConstantClass
    {

        /// <summary>
        /// Constant EC2 for HostEnvironment
        /// </summary>
        public static readonly HostEnvironment EC2 = new HostEnvironment("EC2");
        /// <summary>
        /// Constant HYPERV for HostEnvironment
        /// </summary>
        public static readonly HostEnvironment HYPERV = new HostEnvironment("HYPER-V");
        /// <summary>
        /// Constant KVM for HostEnvironment
        /// </summary>
        public static readonly HostEnvironment KVM = new HostEnvironment("KVM");
        /// <summary>
        /// Constant OTHER for HostEnvironment
        /// </summary>
        public static readonly HostEnvironment OTHER = new HostEnvironment("OTHER");
        /// <summary>
        /// Constant SNOWBALL for HostEnvironment
        /// </summary>
        public static readonly HostEnvironment SNOWBALL = new HostEnvironment("SNOWBALL");
        /// <summary>
        /// Constant VMWARE for HostEnvironment
        /// </summary>
        public static readonly HostEnvironment VMWARE = new HostEnvironment("VMWARE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public HostEnvironment(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static HostEnvironment FindValue(string value)
        {
            return FindValue<HostEnvironment>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator HostEnvironment(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ObjectACL.
    /// </summary>
    public class ObjectACL : ConstantClass
    {

        /// <summary>
        /// Constant AuthenticatedRead for ObjectACL
        /// </summary>
        public static readonly ObjectACL AuthenticatedRead = new ObjectACL("authenticated-read");
        /// <summary>
        /// Constant AwsExecRead for ObjectACL
        /// </summary>
        public static readonly ObjectACL AwsExecRead = new ObjectACL("aws-exec-read");
        /// <summary>
        /// Constant BucketOwnerFullControl for ObjectACL
        /// </summary>
        public static readonly ObjectACL BucketOwnerFullControl = new ObjectACL("bucket-owner-full-control");
        /// <summary>
        /// Constant BucketOwnerRead for ObjectACL
        /// </summary>
        public static readonly ObjectACL BucketOwnerRead = new ObjectACL("bucket-owner-read");
        /// <summary>
        /// Constant Private for ObjectACL
        /// </summary>
        public static readonly ObjectACL Private = new ObjectACL("private");
        /// <summary>
        /// Constant PublicRead for ObjectACL
        /// </summary>
        public static readonly ObjectACL PublicRead = new ObjectACL("public-read");
        /// <summary>
        /// Constant PublicReadWrite for ObjectACL
        /// </summary>
        public static readonly ObjectACL PublicReadWrite = new ObjectACL("public-read-write");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ObjectACL(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ObjectACL FindValue(string value)
        {
            return FindValue<ObjectACL>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ObjectACL(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PoolStatus.
    /// </summary>
    public class PoolStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for PoolStatus
        /// </summary>
        public static readonly PoolStatus ACTIVE = new PoolStatus("ACTIVE");
        /// <summary>
        /// Constant DELETED for PoolStatus
        /// </summary>
        public static readonly PoolStatus DELETED = new PoolStatus("DELETED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PoolStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PoolStatus FindValue(string value)
        {
            return FindValue<PoolStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PoolStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RetentionLockType.
    /// </summary>
    public class RetentionLockType : ConstantClass
    {

        /// <summary>
        /// Constant COMPLIANCE for RetentionLockType
        /// </summary>
        public static readonly RetentionLockType COMPLIANCE = new RetentionLockType("COMPLIANCE");
        /// <summary>
        /// Constant GOVERNANCE for RetentionLockType
        /// </summary>
        public static readonly RetentionLockType GOVERNANCE = new RetentionLockType("GOVERNANCE");
        /// <summary>
        /// Constant NONE for RetentionLockType
        /// </summary>
        public static readonly RetentionLockType NONE = new RetentionLockType("NONE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RetentionLockType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RetentionLockType FindValue(string value)
        {
            return FindValue<RetentionLockType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RetentionLockType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SMBSecurityStrategy.
    /// </summary>
    public class SMBSecurityStrategy : ConstantClass
    {

        /// <summary>
        /// Constant ClientSpecified for SMBSecurityStrategy
        /// </summary>
        public static readonly SMBSecurityStrategy ClientSpecified = new SMBSecurityStrategy("ClientSpecified");
        /// <summary>
        /// Constant MandatoryEncryption for SMBSecurityStrategy
        /// </summary>
        public static readonly SMBSecurityStrategy MandatoryEncryption = new SMBSecurityStrategy("MandatoryEncryption");
        /// <summary>
        /// Constant MandatoryEncryptionNoAes128 for SMBSecurityStrategy
        /// </summary>
        public static readonly SMBSecurityStrategy MandatoryEncryptionNoAes128 = new SMBSecurityStrategy("MandatoryEncryptionNoAes128");
        /// <summary>
        /// Constant MandatorySigning for SMBSecurityStrategy
        /// </summary>
        public static readonly SMBSecurityStrategy MandatorySigning = new SMBSecurityStrategy("MandatorySigning");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SMBSecurityStrategy(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SMBSecurityStrategy FindValue(string value)
        {
            return FindValue<SMBSecurityStrategy>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SMBSecurityStrategy(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TapeStorageClass.
    /// </summary>
    public class TapeStorageClass : ConstantClass
    {

        /// <summary>
        /// Constant DEEP_ARCHIVE for TapeStorageClass
        /// </summary>
        public static readonly TapeStorageClass DEEP_ARCHIVE = new TapeStorageClass("DEEP_ARCHIVE");
        /// <summary>
        /// Constant GLACIER for TapeStorageClass
        /// </summary>
        public static readonly TapeStorageClass GLACIER = new TapeStorageClass("GLACIER");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TapeStorageClass(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TapeStorageClass FindValue(string value)
        {
            return FindValue<TapeStorageClass>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TapeStorageClass(string value)
        {
            return FindValue(value);
        }
    }

}