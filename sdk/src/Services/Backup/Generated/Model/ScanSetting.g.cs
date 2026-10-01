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
    /// Contains configuration settings for malware scanning, including the scanner type,
    /// target resource types, and scanner role.
    /// </summary>
    public partial class ScanSetting
    {
        /// <summary>
        /// Gets and sets the property MalwareScanner. 
        /// <para>
        /// The malware scanner to use for scanning. Currently only <c>GUARDDUTY</c> is supported.
        /// </para>
        /// </summary>
        public MalwareScanner MalwareScanner { get; set; }

        /// <summary>
        /// Checks to see if the MalwareScanner property is set.
        /// </summary>
        internal bool IsSetMalwareScanner() => this.MalwareScanner != null;

        /// <summary>
        /// Gets and sets the property ResourceTypes. 
        /// <para>
        /// An array of resource types to be scanned for malware.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ResourceTypes { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ResourceTypes property is set.
        /// </summary>
        internal bool IsSetResourceTypes() => this.ResourceTypes != null && (this.ResourceTypes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ScannerRoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the IAM role that the scanner uses to access resources;
        /// for example, <c>arn:aws:iam::123456789012:role/ScannerRole</c>.
        /// </para>
        /// </summary>
        public string ScannerRoleArn { get; set; }

        /// <summary>
        /// Checks to see if the ScannerRoleArn property is set.
        /// </summary>
        internal bool IsSetScannerRoleArn() => this.ScannerRoleArn != null;
    }
}
