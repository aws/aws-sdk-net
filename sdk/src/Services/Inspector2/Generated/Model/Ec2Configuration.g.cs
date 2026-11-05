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

namespace Amazon.Inspector2.Model
{
    /// <summary>
    /// Enables agent-based scanning, which scans instances that are not managed by SSM.
    /// </summary>
    public partial class Ec2Configuration
    {
        /// <summary>
        /// Gets and sets the property ActivateVMScanner. 
        /// <para>
        /// Whether to activate Amazon Inspector VM scanner for Amazon EC2 scanning.
        /// </para>
        /// </summary>
        public bool? ActivateVMScanner { get; set; }

        /// <summary>
        /// Checks to see if the ActivateVMScanner property is set.
        /// </summary>
        internal bool IsSetActivateVMScanner() => this.ActivateVMScanner.HasValue;

        /// <summary>
        /// Gets and sets the property ScanMode. 
        /// <para>
        /// The scan method that is applied to the instance.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public Ec2ScanMode ScanMode { get; set; }

        /// <summary>
        /// Checks to see if the ScanMode property is set.
        /// </summary>
        internal bool IsSetScanMode() => this.ScanMode != null;
    }
}
