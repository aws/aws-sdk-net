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

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// A summary of the output configuration for a findings export, returned by <c>ListExportJobsV2</c>.
    /// Unlike the configuration returned by <c>GetExportJobV2</c>, it reports only the output
    /// format.
    /// </summary>
    public partial class FindingsOutputSummary
    {
        /// <summary>
        /// Gets and sets the property Format. 
        /// <para>
        /// The output format of the export. <c>CSV</c> produces comma-separated rows that are
        /// suitable for spreadsheets and analysis tools. <c>OCSF_JSON</c> produces newline-delimited
        /// JSON records in the Open Cybersecurity Schema Framework (OCSF) format used elsewhere
        /// in Security Hub.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public FindingsExportFormat Format { get; set; }

        /// <summary>
        /// Checks to see if the Format property is set.
        /// </summary>
        internal bool IsSetFormat() => this.Format != null;
    }
}
