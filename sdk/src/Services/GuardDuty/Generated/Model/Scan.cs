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
 * Do not modify this file. This file is generated from the guardduty-2017-11-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.GuardDuty.Model
{
    /// <summary>
    /// Contains information about a malware scan.
    /// </summary>
    public partial class Scan
    {
        private string _accountId;
        private string _adminDetectorId;
        private List<VolumeDetail> _attachedVolumes = new List<VolumeDetail>();
        private string _detectorId;
        private string _failureReason;
        private long? _fileCount;
        private ResourceDetails _resourceDetails;
        private DateTime? _scanEndTime;
        private string _scanId;
        private ScanResultDetails _scanResultDetails;
        private DateTime? _scanStartTime;
        private ScanStatus _scanStatus;
        private long? _totalBytes;
        private TriggerDetails _triggerDetails;

        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// The ID for the account that belongs to the scan.
        /// </para>
        /// </summary>
        [AWSProperty(Min=12, Max=12)]
        public string AccountId
        {
            get { return this._accountId; }
            set { this._accountId = value; }
        }

        // Check to see if AccountId property is set
        internal bool IsSetAccountId()
        {
            return this._accountId != null;
        }

        /// <summary>
        /// Gets and sets the property AdminDetectorId. 
        /// <para>
        /// The unique detector ID of the administrator account that the request is associated
        /// with. Note that this value will be the same as the one used for <code>DetectorId</code>
        /// if the account is an administrator.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=300)]
        public string AdminDetectorId
        {
            get { return this._adminDetectorId; }
            set { this._adminDetectorId = value; }
        }

        // Check to see if AdminDetectorId property is set
        internal bool IsSetAdminDetectorId()
        {
            return this._adminDetectorId != null;
        }

        /// <summary>
        /// Gets and sets the property AttachedVolumes. 
        /// <para>
        /// List of volumes that were attached to the original instance to be scanned.
        /// </para>
        /// </summary>
        public List<VolumeDetail> AttachedVolumes
        {
            get { return this._attachedVolumes; }
            set { this._attachedVolumes = value; }
        }

        // Check to see if AttachedVolumes property is set
        internal bool IsSetAttachedVolumes()
        {
            return this._attachedVolumes != null && this._attachedVolumes.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property DetectorId. 
        /// <para>
        /// The unique ID of the detector that the request is associated with.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=300)]
        public string DetectorId
        {
            get { return this._detectorId; }
            set { this._detectorId = value; }
        }

        // Check to see if DetectorId property is set
        internal bool IsSetDetectorId()
        {
            return this._detectorId != null;
        }

        /// <summary>
        /// Gets and sets the property FailureReason. 
        /// <para>
        /// Represents the reason for FAILED scan status.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=200)]
        public string FailureReason
        {
            get { return this._failureReason; }
            set { this._failureReason = value; }
        }

        // Check to see if FailureReason property is set
        internal bool IsSetFailureReason()
        {
            return this._failureReason != null;
        }

        /// <summary>
        /// Gets and sets the property FileCount. 
        /// <para>
        /// Represents the number of files that were scanned.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public long FileCount
        {
            get { return this._fileCount.GetValueOrDefault(); }
            set { this._fileCount = value; }
        }

        // Check to see if FileCount property is set
        internal bool IsSetFileCount()
        {
            return this._fileCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ResourceDetails. 
        /// <para>
        /// Represents the resources that were scanned in the scan entry.
        /// </para>
        /// </summary>
        public ResourceDetails ResourceDetails
        {
            get { return this._resourceDetails; }
            set { this._resourceDetails = value; }
        }

        // Check to see if ResourceDetails property is set
        internal bool IsSetResourceDetails()
        {
            return this._resourceDetails != null;
        }

        /// <summary>
        /// Gets and sets the property ScanEndTime. 
        /// <para>
        /// The timestamp of when the scan was finished.
        /// </para>
        /// </summary>
        public DateTime ScanEndTime
        {
            get { return this._scanEndTime.GetValueOrDefault(); }
            set { this._scanEndTime = value; }
        }

        // Check to see if ScanEndTime property is set
        internal bool IsSetScanEndTime()
        {
            return this._scanEndTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ScanId. 
        /// <para>
        /// The unique scan ID associated with a scan entry.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=200)]
        public string ScanId
        {
            get { return this._scanId; }
            set { this._scanId = value; }
        }

        // Check to see if ScanId property is set
        internal bool IsSetScanId()
        {
            return this._scanId != null;
        }

        /// <summary>
        /// Gets and sets the property ScanResultDetails. 
        /// <para>
        /// Represents the result of the scan.
        /// </para>
        /// </summary>
        public ScanResultDetails ScanResultDetails
        {
            get { return this._scanResultDetails; }
            set { this._scanResultDetails = value; }
        }

        // Check to see if ScanResultDetails property is set
        internal bool IsSetScanResultDetails()
        {
            return this._scanResultDetails != null;
        }

        /// <summary>
        /// Gets and sets the property ScanStartTime. 
        /// <para>
        /// The timestamp of when the scan was triggered.
        /// </para>
        /// </summary>
        public DateTime ScanStartTime
        {
            get { return this._scanStartTime.GetValueOrDefault(); }
            set { this._scanStartTime = value; }
        }

        // Check to see if ScanStartTime property is set
        internal bool IsSetScanStartTime()
        {
            return this._scanStartTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ScanStatus. 
        /// <para>
        /// An enum value representing possible scan statuses.
        /// </para>
        /// </summary>
        public ScanStatus ScanStatus
        {
            get { return this._scanStatus; }
            set { this._scanStatus = value; }
        }

        // Check to see if ScanStatus property is set
        internal bool IsSetScanStatus()
        {
            return this._scanStatus != null;
        }

        /// <summary>
        /// Gets and sets the property TotalBytes. 
        /// <para>
        /// Represents total bytes that were scanned.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public long TotalBytes
        {
            get { return this._totalBytes.GetValueOrDefault(); }
            set { this._totalBytes = value; }
        }

        // Check to see if TotalBytes property is set
        internal bool IsSetTotalBytes()
        {
            return this._totalBytes.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TriggerDetails. 
        /// <para>
        /// Specifies the reason why the scan was initiated.
        /// </para>
        /// </summary>
        public TriggerDetails TriggerDetails
        {
            get { return this._triggerDetails; }
            set { this._triggerDetails = value; }
        }

        // Check to see if TriggerDetails property is set
        internal bool IsSetTriggerDetails()
        {
            return this._triggerDetails != null;
        }

    }
}