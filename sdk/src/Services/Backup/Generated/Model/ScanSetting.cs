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
    /// Contains configuration settings for malware scanning, including the scanner type,
    /// target resource types, and scanner role.
    /// </summary>
    public partial class ScanSetting
    {
        private MalwareScanner _malwareScanner;
        private List<string> _resourceTypes = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _scannerRoleArn;

        /// <summary>
        /// Gets and sets the property MalwareScanner. 
        /// <para>
        /// The malware scanner to use for scanning. Currently only <c>GUARDDUTY</c> is supported.
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
        /// Gets and sets the property ResourceTypes. 
        /// <para>
        /// An array of resource types to be scanned for malware.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ResourceTypes
        {
            get { return this._resourceTypes; }
            set { this._resourceTypes = value; }
        }

        // Check to see if ResourceTypes property is set
        internal bool IsSetResourceTypes()
        {
            return this._resourceTypes != null && (this._resourceTypes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ScannerRoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the IAM role that the scanner uses to access resources;
        /// for example, <c>arn:aws:iam::123456789012:role/ScannerRole</c>.
        /// </para>
        /// </summary>
        public string ScannerRoleArn
        {
            get { return this._scannerRoleArn; }
            set { this._scannerRoleArn = value; }
        }

        // Check to see if ScannerRoleArn property is set
        internal bool IsSetScannerRoleArn()
        {
            return this._scannerRoleArn != null;
        }

    }
}