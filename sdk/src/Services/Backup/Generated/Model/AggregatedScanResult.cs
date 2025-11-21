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
 * Do not modify this file. This file is generated from the backup-2018-11-15.normal.json service model.
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
namespace Amazon.Backup.Model
{
    /// <summary>
    /// Contains aggregated scan results across multiple scan operations, providing a summary
    /// of scan status and findings.
    /// </summary>
    public partial class AggregatedScanResult
    {
        private bool? _failedScan;
        private List<string> _findings = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private DateTime? _lastComputed;

        /// <summary>
        /// Gets and sets the property FailedScan. 
        /// <para>
        /// A Boolean value indicating whether any of the aggregated scans failed.
        /// </para>
        /// </summary>
        public bool? FailedScan
        {
            get { return this._failedScan; }
            set { this._failedScan = value; }
        }

        // Check to see if FailedScan property is set
        internal bool IsSetFailedScan()
        {
            return this._failedScan.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Findings. 
        /// <para>
        /// An array of findings discovered across all aggregated scans.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Findings
        {
            get { return this._findings; }
            set { this._findings = value; }
        }

        // Check to see if Findings property is set
        internal bool IsSetFindings()
        {
            return this._findings != null && (this._findings.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property LastComputed. 
        /// <para>
        /// The timestamp when the aggregated scan result was last computed, in Unix format and
        /// Coordinated Universal Time (UTC).
        /// </para>
        /// </summary>
        public DateTime? LastComputed
        {
            get { return this._lastComputed; }
            set { this._lastComputed = value; }
        }

        // Check to see if LastComputed property is set
        internal bool IsSetLastComputed()
        {
            return this._lastComputed.HasValue; 
        }

    }
}