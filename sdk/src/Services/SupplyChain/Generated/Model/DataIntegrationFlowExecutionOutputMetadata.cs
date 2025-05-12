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
 * Do not modify this file. This file is generated from the supplychain-2024-01-01.normal.json service model.
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
namespace Amazon.SupplyChain.Model
{
    /// <summary>
    /// The output metadata of the flow execution.
    /// </summary>
    public partial class DataIntegrationFlowExecutionOutputMetadata
    {
        private string _diagnosticReportsRootS3URI;

        /// <summary>
        /// Gets and sets the property DiagnosticReportsRootS3URI. 
        /// <para>
        /// The S3 URI under which all diagnostic files (such as deduped records if any) are stored.
        /// </para>
        /// </summary>
        public string DiagnosticReportsRootS3URI
        {
            get { return this._diagnosticReportsRootS3URI; }
            set { this._diagnosticReportsRootS3URI = value; }
        }

        // Check to see if DiagnosticReportsRootS3URI property is set
        internal bool IsSetDiagnosticReportsRootS3URI()
        {
            return this._diagnosticReportsRootS3URI != null;
        }

    }
}