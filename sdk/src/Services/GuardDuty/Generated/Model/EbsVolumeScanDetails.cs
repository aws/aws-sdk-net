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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.GuardDuty.Model
{
    /// <summary>
    /// Contains details from the malware scan that created a finding.
    /// </summary>
    public partial class EbsVolumeScanDetails
    {
        private DateTime? _scanCompletedAt;
        private ScanDetections _scanDetections;
        private string _scanId;
        private DateTime? _scanStartedAt;
        private ScanType _scanType;
        private List<string> _sources = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _triggerFindingId;

        /// <summary>
        /// Gets and sets the property ScanCompletedAt. 
        /// <para>
        /// Returns the completion date and time of the malware scan.
        /// </para>
        /// </summary>
        public DateTime? ScanCompletedAt
        {
            get { return this._scanCompletedAt; }
            set { this._scanCompletedAt = value; }
        }

        // Check to see if ScanCompletedAt property is set
        internal bool IsSetScanCompletedAt()
        {
            return this._scanCompletedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ScanDetections. 
        /// <para>
        /// Contains a complete view providing malware scan result details.
        /// </para>
        /// </summary>
        public ScanDetections ScanDetections
        {
            get { return this._scanDetections; }
            set { this._scanDetections = value; }
        }

        // Check to see if ScanDetections property is set
        internal bool IsSetScanDetections()
        {
            return this._scanDetections != null;
        }

        /// <summary>
        /// Gets and sets the property ScanId. 
        /// <para>
        /// Unique Id of the malware scan that generated the finding.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property ScanStartedAt. 
        /// <para>
        /// Returns the start date and time of the malware scan.
        /// </para>
        /// </summary>
        public DateTime? ScanStartedAt
        {
            get { return this._scanStartedAt; }
            set { this._scanStartedAt = value; }
        }

        // Check to see if ScanStartedAt property is set
        internal bool IsSetScanStartedAt()
        {
            return this._scanStartedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ScanType. 
        /// <para>
        /// Specifies the scan type that invoked the malware scan.
        /// </para>
        /// </summary>
        public ScanType ScanType
        {
            get { return this._scanType; }
            set { this._scanType = value; }
        }

        // Check to see if ScanType property is set
        internal bool IsSetScanType()
        {
            return this._scanType != null;
        }

        /// <summary>
        /// Gets and sets the property Sources. 
        /// <para>
        /// Contains list of threat intelligence sources used to detect threats.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Sources
        {
            get { return this._sources; }
            set { this._sources = value; }
        }

        // Check to see if Sources property is set
        internal bool IsSetSources()
        {
            return this._sources != null && (this._sources.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TriggerFindingId. 
        /// <para>
        /// GuardDuty finding ID that triggered a malware scan.
        /// </para>
        /// </summary>
        public string TriggerFindingId
        {
            get { return this._triggerFindingId; }
            set { this._triggerFindingId = value; }
        }

        // Check to see if TriggerFindingId property is set
        internal bool IsSetTriggerFindingId()
        {
            return this._triggerFindingId != null;
        }

    }
}