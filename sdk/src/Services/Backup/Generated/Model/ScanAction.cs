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
    /// Defines a scanning action that specifies the malware scanner and scan mode to use.
    /// </summary>
    public partial class ScanAction
    {
        private MalwareScanner _malwareScanner;
        private ScanMode _scanMode;

        /// <summary>
        /// Gets and sets the property MalwareScanner. 
        /// <para>
        /// The malware scanner to use for the scan action. Currently only <c>GUARDDUTY</c> is
        /// supported.
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
        /// Gets and sets the property ScanMode. 
        /// <para>
        /// The scanning mode to use for the scan action.
        /// </para>
        ///  
        /// <para>
        /// Valid values: <c>FULL_SCAN</c> | <c>INCREMENTAL_SCAN</c>.
        /// </para>
        /// </summary>
        public ScanMode ScanMode
        {
            get { return this._scanMode; }
            set { this._scanMode = value; }
        }

        // Check to see if ScanMode property is set
        internal bool IsSetScanMode()
        {
            return this._scanMode != null;
        }

    }
}