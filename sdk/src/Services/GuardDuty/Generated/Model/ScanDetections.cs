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
    /// Contains a complete view providing malware scan result details.
    /// </summary>
    public partial class ScanDetections
    {
        private HighestSeverityThreatDetails _highestSeverityThreatDetails;
        private ScannedItemCount _scannedItemCount;
        private ThreatDetectedByName _threatDetectedByName;
        private ThreatsDetectedItemCount _threatsDetectedItemCount;

        /// <summary>
        /// Gets and sets the property HighestSeverityThreatDetails. 
        /// <para>
        /// Details of the highest severity threat detected during malware scan and number of
        /// infected files.
        /// </para>
        /// </summary>
        public HighestSeverityThreatDetails HighestSeverityThreatDetails
        {
            get { return this._highestSeverityThreatDetails; }
            set { this._highestSeverityThreatDetails = value; }
        }

        // Check to see if HighestSeverityThreatDetails property is set
        internal bool IsSetHighestSeverityThreatDetails()
        {
            return this._highestSeverityThreatDetails != null;
        }

        /// <summary>
        /// Gets and sets the property ScannedItemCount. 
        /// <para>
        /// Total number of scanned files.
        /// </para>
        /// </summary>
        public ScannedItemCount ScannedItemCount
        {
            get { return this._scannedItemCount; }
            set { this._scannedItemCount = value; }
        }

        // Check to see if ScannedItemCount property is set
        internal bool IsSetScannedItemCount()
        {
            return this._scannedItemCount != null;
        }

        /// <summary>
        /// Gets and sets the property ThreatDetectedByName. 
        /// <para>
        /// Contains details about identified threats organized by threat name.
        /// </para>
        /// </summary>
        public ThreatDetectedByName ThreatDetectedByName
        {
            get { return this._threatDetectedByName; }
            set { this._threatDetectedByName = value; }
        }

        // Check to see if ThreatDetectedByName property is set
        internal bool IsSetThreatDetectedByName()
        {
            return this._threatDetectedByName != null;
        }

        /// <summary>
        /// Gets and sets the property ThreatsDetectedItemCount. 
        /// <para>
        /// Total number of infected files.
        /// </para>
        /// </summary>
        public ThreatsDetectedItemCount ThreatsDetectedItemCount
        {
            get { return this._threatsDetectedItemCount; }
            set { this._threatsDetectedItemCount = value; }
        }

        // Check to see if ThreatsDetectedItemCount property is set
        internal bool IsSetThreatsDetectedItemCount()
        {
            return this._threatsDetectedItemCount != null;
        }

    }
}