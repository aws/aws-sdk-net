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
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

namespace Amazon.StorageGateway.Model
{
    /// <summary>
    /// <para>Provides additional information about an error that was returned by the service as an or. See the <c>errorCode</c> and
    /// <c>errorDetails</c> members for more information about the error.</para>
    /// </summary>
    public class StorageGatewayError
    {
        
        private ErrorCode errorCode;
        private Dictionary<string,string> errorDetails = new Dictionary<string,string>();

        /// <summary>
        /// Additional information about the error.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Allowed Values</term>
        ///         <description>ActivationKeyExpired, ActivationKeyInvalid, ActivationKeyNotFound, GatewayInternalError, GatewayNotConnected, GatewayNotFound, GatewayProxyNetworkConnectionBusy, AuthenticationFailure, BandwidthThrottleScheduleNotFound, Blocked, CannotExportSnapshot, ChapCredentialNotFound, DiskAlreadyAllocated, DiskDoesNotExist, DiskSizeGreaterThanVolumeMaxSize, DiskSizeLessThanVolumeSize, DiskSizeNotGigAligned, DuplicateCertificateInfo, DuplicateSchedule, EndpointNotFound, IAMNotSupported, InitiatorInvalid, InitiatorNotFound, InternalError, InvalidGateway, InvalidEndpoint, InvalidParameters, InvalidSchedule, LocalStorageLimitExceeded, LunAlreadyAllocated , LunInvalid, MaximumContentLengthExceeded, MaximumTapeCartridgeCountExceeded, MaximumVolumeCountExceeded, NetworkConfigurationChanged, NoDisksAvailable, NotImplemented, NotSupported, OperationAborted, OutdatedGateway, ParametersNotImplemented, RegionInvalid, RequestTimeout, ServiceUnavailable, SnapshotDeleted, SnapshotIdInvalid, SnapshotInProgress, SnapshotNotFound, SnapshotScheduleNotFound, StagingAreaFull, StorageFailure, TapeCartridgeNotFound, TargetAlreadyExists, TargetInvalid, TargetNotFound, UnauthorizedOperation, VolumeAlreadyExists, VolumeIdInvalid, VolumeInUse, VolumeNotFound, VolumeNotReady</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public ErrorCode ErrorCode
        {
            get { return this.errorCode; }
            set { this.errorCode = value; }
        }

        // Check to see if ErrorCode property is set
        internal bool IsSetErrorCode()
        {
            return this.errorCode != null;
        }

        /// <summary>
        /// Human-readable text that provides detail about the error that occured.
        ///  
        /// </summary>
        public Dictionary<string,string> ErrorDetails
        {
            get { return this.errorDetails; }
            set { this.errorDetails = value; }
        }

        // Check to see if ErrorDetails property is set
        internal bool IsSetErrorDetails()
        {
            return this.errorDetails != null;
        }
    }
}
