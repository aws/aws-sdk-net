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
    /// Contains the results of a security scan, including scanner information, scan state,
    /// and any findings discovered.
    /// </summary>
    public partial class ScanResult
    {
        private List<string> _findings = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private DateTime? _lastScanTimestamp;
        private MalwareScanner _malwareScanner;
        private ScanJobState _scanJobState;

        /// <summary>
        /// Gets and sets the property Findings. 
        /// <para>
        /// An array of findings discovered during the scan.
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
        /// Gets and sets the property LastScanTimestamp. 
        /// <para>
        /// The timestamp of when the last scan was performed, in Unix format and Coordinated
        /// Universal Time (UTC).
        /// </para>
        /// </summary>
        public DateTime? LastScanTimestamp
        {
            get { return this._lastScanTimestamp; }
            set { this._lastScanTimestamp = value; }
        }

        // Check to see if LastScanTimestamp property is set
        internal bool IsSetLastScanTimestamp()
        {
            return this._lastScanTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MalwareScanner. 
        /// <para>
        /// The malware scanner used to perform the scan. Currently only <c>GUARDDUTY</c> is supported.
        /// </para>
        /// </summary>
        public MalwareScanner MalwareScanner
        {
            get { return this._malwareScanner; }
            set { this._malwareScanner = value; }
        }

        // Check to see if MalwareScanner property is set
        internal bool IsSetMalwareScanner()
        {
            return this._malwareScanner != null;
        }

        /// <summary>
        /// Gets and sets the property ScanJobState. 
        /// <para>
        /// The final state of the scan job.
        /// </para>
        ///  
        /// <para>
        /// Valid values: <c>COMPLETED</c> | <c>FAILED</c> | <c>CANCELED</c>.
        /// </para>
        /// </summary>
        public ScanJobState ScanJobState
        {
            get { return this._scanJobState; }
            set { this._scanJobState = value; }
        }

        // Check to see if ScanJobState property is set
        internal bool IsSetScanJobState()
        {
            return this._scanJobState != null;
        }

    }
}