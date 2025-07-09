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
 * Do not modify this file. This file is generated from the inspector2-2020-06-08.normal.json service model.
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
namespace Amazon.Inspector2.Model
{
    /// <summary>
    /// Contains information about on-demand scans performed on a code repository.
    /// </summary>
    public partial class CodeRepositoryOnDemandScan
    {
        private DateTime? _lastScanAt;
        private string _lastScannedCommitId;
        private ScanStatus _scanStatus;

        /// <summary>
        /// Gets and sets the property LastScanAt. 
        /// <para>
        /// The timestamp when the last on-demand scan was performed.
        /// </para>
        /// </summary>
        public DateTime? LastScanAt
        {
            get { return this._lastScanAt; }
            set { this._lastScanAt = value; }
        }

        // Check to see if LastScanAt property is set
        internal bool IsSetLastScanAt()
        {
            return this._lastScanAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LastScannedCommitId. 
        /// <para>
        /// The ID of the last commit that was scanned during an on-demand scan.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=40)]
        public string LastScannedCommitId
        {
            get { return this._lastScannedCommitId; }
            set { this._lastScannedCommitId = value; }
        }

        // Check to see if LastScannedCommitId property is set
        internal bool IsSetLastScannedCommitId()
        {
            return this._lastScannedCommitId != null;
        }

        /// <summary>
        /// Gets and sets the property ScanStatus.
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

    }
}