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
    /// Contains list of scanned and skipped EBS volumes with details.
    /// </summary>
    public partial class EbsVolumeDetails
    {
        private List<VolumeDetail> _scannedVolumeDetails = AWSConfigs.InitializeCollections ? new List<VolumeDetail>() : null;
        private List<VolumeDetail> _skippedVolumeDetails = AWSConfigs.InitializeCollections ? new List<VolumeDetail>() : null;

        /// <summary>
        /// Gets and sets the property ScannedVolumeDetails. 
        /// <para>
        /// List of EBS volumes that were scanned.
        /// </para>
        /// </summary>
        public List<VolumeDetail> ScannedVolumeDetails
        {
            get { return this._scannedVolumeDetails; }
            set { this._scannedVolumeDetails = value; }
        }

        // Check to see if ScannedVolumeDetails property is set
        internal bool IsSetScannedVolumeDetails()
        {
            return this._scannedVolumeDetails != null && (this._scannedVolumeDetails.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SkippedVolumeDetails. 
        /// <para>
        /// List of EBS volumes that were skipped from the malware scan.
        /// </para>
        /// </summary>
        public List<VolumeDetail> SkippedVolumeDetails
        {
            get { return this._skippedVolumeDetails; }
            set { this._skippedVolumeDetails = value; }
        }

        // Check to see if SkippedVolumeDetails property is set
        internal bool IsSetSkippedVolumeDetails()
        {
            return this._skippedVolumeDetails != null && (this._skippedVolumeDetails.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}