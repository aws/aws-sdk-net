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
    /// Contains details from the malware scan that created a finding.
    /// </summary>
    public partial class EbsVolumeScanDetails
    {
        /// <summary>
        /// Gets and sets the property ScanCompletedAt. 
        /// <para>
        /// Returns the completion date and time of the malware scan.
        /// </para>
        /// </summary>
        public DateTime? ScanCompletedAt { get; set; }

        /// <summary>
        /// Checks to see if the ScanCompletedAt property is set.
        /// </summary>
        internal bool IsSetScanCompletedAt() => this.ScanCompletedAt.HasValue;

        /// <summary>
        /// Gets and sets the property ScanDetections. 
        /// <para>
        /// Contains a complete view providing malware scan result details.
        /// </para>
        /// </summary>
        public ScanDetections ScanDetections { get; set; }

        /// <summary>
        /// Checks to see if the ScanDetections property is set.
        /// </summary>
        internal bool IsSetScanDetections() => this.ScanDetections != null;

        /// <summary>
        /// Gets and sets the property ScanId. 
        /// <para>
        /// Unique Id of the malware scan that generated the finding.
        /// </para>
        /// </summary>
        public string ScanId { get; set; }

        /// <summary>
        /// Checks to see if the ScanId property is set.
        /// </summary>
        internal bool IsSetScanId() => this.ScanId != null;

        /// <summary>
        /// Gets and sets the property ScanStartedAt. 
        /// <para>
        /// Returns the start date and time of the malware scan.
        /// </para>
        /// </summary>
        public DateTime? ScanStartedAt { get; set; }

        /// <summary>
        /// Checks to see if the ScanStartedAt property is set.
        /// </summary>
        internal bool IsSetScanStartedAt() => this.ScanStartedAt.HasValue;

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
        /// Gets and sets the property Sources. 
        /// <para>
        /// Contains list of threat intelligence sources used to detect threats.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Sources { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Sources property is set.
        /// </summary>
        internal bool IsSetSources() => this.Sources != null && (this.Sources.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TriggerFindingId. 
        /// <para>
        /// GuardDuty finding ID that triggered a malware scan.
        /// </para>
        /// </summary>
        public string TriggerFindingId { get; set; }

        /// <summary>
        /// Checks to see if the TriggerFindingId property is set.
        /// </summary>
        internal bool IsSetTriggerFindingId() => this.TriggerFindingId != null;
    }
}
