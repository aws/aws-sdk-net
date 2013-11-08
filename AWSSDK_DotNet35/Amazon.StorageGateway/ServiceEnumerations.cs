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
    

}
        
