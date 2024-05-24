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
 * Do not modify this file. This file is generated from the inspector-scan-2023-08-08.normal.json service model.
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
namespace Amazon.InspectorScan.Model
{
    /// <summary>
    /// Container for the parameters to the ScanSbom operation.
    /// Scans a provided CycloneDX 1.5 SBOM and reports on any vulnerabilities discovered
    /// in that SBOM. You can generate compatible SBOMs for your resources using the <a href="">Amazon
    /// Inspector SBOM generator</a>.
    /// </summary>
    public partial class ScanSbomRequest : AmazonInspectorScanRequest
    {
        private OutputFormat _outputFormat;
        private Amazon.Runtime.Documents.Document _sbom;

        /// <summary>
        /// Gets and sets the property OutputFormat. 
        /// <para>
        /// The output format for the vulnerability report.
        /// </para>
        /// </summary>
        public OutputFormat OutputFormat
        {
            get { return this._outputFormat; }
            set { this._outputFormat = value; }
        }

        // Check to see if OutputFormat property is set
        internal bool IsSetOutputFormat()
        {
            return this._outputFormat != null;
        }

        /// <summary>
        /// Gets and sets the property Sbom. 
        /// <para>
        /// The JSON file for the SBOM you want to scan. The SBOM must be in CycloneDX 1.5 format.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public Amazon.Runtime.Documents.Document Sbom
        {
            get { return this._sbom; }
            set { this._sbom = value; }
        }

        // Check to see if Sbom property is set
        internal bool IsSetSbom()
        {
            return !this._sbom.IsNull();
        }

    }
}