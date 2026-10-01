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

namespace Amazon.Backup.Model
{
    /// <summary>
    /// Contains the results of a security scan, including scanner information, scan state,
    /// and any findings discovered.
    /// </summary>
    public partial class ScanResult
    {
        /// <summary>
        /// Gets and sets the property Findings. 
        /// <para>
        /// An array of findings discovered during the scan.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Findings { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Findings property is set.
        /// </summary>
        internal bool IsSetFindings() => this.Findings != null && (this.Findings.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property LastScanTimestamp. 
        /// <para>
        /// The timestamp of when the last scan was performed, in Unix format and Coordinated
        /// Universal Time (UTC).
        /// </para>
        /// </summary>
        public DateTime? LastScanTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the LastScanTimestamp property is set.
        /// </summary>
        internal bool IsSetLastScanTimestamp() => this.LastScanTimestamp.HasValue;

        /// <summary>
        /// Gets and sets the property MalwareScanner. 
        /// <para>
        /// The malware scanner used to perform the scan. Currently only <c>GUARDDUTY</c> is supported.
        /// </para>
        /// </summary>
        public MalwareScanner MalwareScanner { get; set; }

        /// <summary>
        /// Checks to see if the MalwareScanner property is set.
        /// </summary>
        internal bool IsSetMalwareScanner() => this.MalwareScanner != null;

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
        public ScanJobState ScanJobState { get; set; }

        /// <summary>
        /// Checks to see if the ScanJobState property is set.
        /// </summary>
        internal bool IsSetScanJobState() => this.ScanJobState != null;
    }
}
