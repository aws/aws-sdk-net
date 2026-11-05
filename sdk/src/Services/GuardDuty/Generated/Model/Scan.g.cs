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
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618,CS1570

namespace Amazon.GuardDuty.Model
{
    /// <summary>
    /// Contains information about malware scans associated with GuardDuty Malware Protection
    /// for EC2.
    /// </summary>
    public partial class Scan
    {
        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// The ID for the account that belongs to the scan.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 12, Max = 12)]
        public string AccountId { get; set; }

        /// <summary>
        /// Checks to see if the AccountId property is set.
        /// </summary>
        internal bool IsSetAccountId() => this.AccountId != null;

        /// <summary>
        /// Gets and sets the property AdminDetectorId. 
        /// <para>
        /// The unique detector ID of the administrator account that the request is associated
        /// with. If the account is an administrator, the <c>AdminDetectorId</c> will be the same
        /// as the one used for <c>DetectorId</c>.
        /// </para>
        ///  
        /// <para>
        /// To find the <c>detectorId</c> in the current Region, see the Settings page in the
        /// GuardDuty console, or run the <a href="https://docs.aws.amazon.com/guardduty/latest/APIReference/API_ListDetectors.html">ListDetectors</a>
        /// API.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 300)]
        public string AdminDetectorId { get; set; }

        /// <summary>
        /// Checks to see if the AdminDetectorId property is set.
        /// </summary>
        internal bool IsSetAdminDetectorId() => this.AdminDetectorId != null;

        /// <summary>
        /// Gets and sets the property AttachedVolumes. 
        /// <para>
        /// List of volumes that were attached to the original instance to be scanned.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<VolumeDetail> AttachedVolumes { get; set; } = AWSConfigs.InitializeCollections ? new List<VolumeDetail>() : null;

        /// <summary>
        /// Checks to see if the AttachedVolumes property is set.
        /// </summary>
        internal bool IsSetAttachedVolumes() => this.AttachedVolumes != null && (this.AttachedVolumes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property DetectorId. 
        /// <para>
        /// The unique ID of the detector that is associated with the request.
        /// </para>
        ///  
        /// <para>
        /// To find the <c>detectorId</c> in the current Region, see the Settings page in the
        /// GuardDuty console, or run the <a href="https://docs.aws.amazon.com/guardduty/latest/APIReference/API_ListDetectors.html">ListDetectors</a>
        /// API.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 300)]
        public string DetectorId { get; set; }

        /// <summary>
        /// Checks to see if the DetectorId property is set.
        /// </summary>
        internal bool IsSetDetectorId() => this.DetectorId != null;

        /// <summary>
        /// Gets and sets the property FailureReason. 
        /// <para>
        /// Represents the reason for <c>FAILED</c> scan status.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 200)]
        public string FailureReason { get; set; }

        /// <summary>
        /// Checks to see if the FailureReason property is set.
        /// </summary>
        internal bool IsSetFailureReason() => this.FailureReason != null;

        /// <summary>
        /// Gets and sets the property FileCount. 
        /// <para>
        /// Represents the number of files that were scanned.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public long? FileCount { get; set; }

        /// <summary>
        /// Checks to see if the FileCount property is set.
        /// </summary>
        internal bool IsSetFileCount() => this.FileCount.HasValue;

        /// <summary>
        /// Gets and sets the property ResourceDetails. 
        /// <para>
        /// Represents the resources that were scanned in the scan entry.
        /// </para>
        /// </summary>
        public ResourceDetails ResourceDetails { get; set; }

        /// <summary>
        /// Checks to see if the ResourceDetails property is set.
        /// </summary>
        internal bool IsSetResourceDetails() => this.ResourceDetails != null;

        /// <summary>
        /// Gets and sets the property ScanEndTime. 
        /// <para>
        /// The timestamp of when the scan was finished.
        /// </para>
        /// </summary>
        public DateTime? ScanEndTime { get; set; }

        /// <summary>
        /// Checks to see if the ScanEndTime property is set.
        /// </summary>
        internal bool IsSetScanEndTime() => this.ScanEndTime.HasValue;

        /// <summary>
        /// Gets and sets the property ScanId. 
        /// <para>
        /// The unique scan ID associated with a scan entry.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 200)]
        public string ScanId { get; set; }

        /// <summary>
        /// Checks to see if the ScanId property is set.
        /// </summary>
        internal bool IsSetScanId() => this.ScanId != null;

        /// <summary>
        /// Gets and sets the property ScanResultDetails. 
        /// <para>
        /// Represents the result of the scan.
        /// </para>
        /// </summary>
        public ScanResultDetails ScanResultDetails { get; set; }

        /// <summary>
        /// Checks to see if the ScanResultDetails property is set.
        /// </summary>
        internal bool IsSetScanResultDetails() => this.ScanResultDetails != null;

        /// <summary>
        /// Gets and sets the property ScanStartTime. 
        /// <para>
        /// The timestamp of when the scan was triggered.
        /// </para>
        /// </summary>
        public DateTime? ScanStartTime { get; set; }

        /// <summary>
        /// Checks to see if the ScanStartTime property is set.
        /// </summary>
        internal bool IsSetScanStartTime() => this.ScanStartTime.HasValue;

        /// <summary>
        /// Gets and sets the property ScanStatus. 
        /// <para>
        /// An enum value representing possible scan statuses.
        /// </para>
        /// </summary>
        public ScanStatus ScanStatus { get; set; }

        /// <summary>
        /// Checks to see if the ScanStatus property is set.
        /// </summary>
        internal bool IsSetScanStatus() => this.ScanStatus != null;

        /// <summary>
        /// Gets and sets the property ScanType. 
        /// <para>
        /// Specifies the scan type that invoked the malware scan.
        /// </para>
        /// </summary>
        public ScanType ScanType { get; set; }

        /// <summary>
        /// Checks to see if the ScanType property is set.
        /// </summary>
        internal bool IsSetScanType() => this.ScanType != null;

        /// <summary>
        /// Gets and sets the property TotalBytes. 
        /// <para>
        /// Represents total bytes that were scanned.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public long? TotalBytes { get; set; }

        /// <summary>
        /// Checks to see if the TotalBytes property is set.
        /// </summary>
        internal bool IsSetTotalBytes() => this.TotalBytes.HasValue;

        /// <summary>
        /// Gets and sets the property TriggerDetails. 
        /// <para>
        /// Specifies the reason why the scan was initiated.
        /// </para>
        /// </summary>
        public TriggerDetails TriggerDetails { get; set; }

        /// <summary>
        /// Checks to see if the TriggerDetails property is set.
        /// </summary>
        internal bool IsSetTriggerDetails() => this.TriggerDetails != null;
    }
}
