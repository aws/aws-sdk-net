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
    /// The configuration for a findings export: the output format, an optional set of filters,
    /// and the fields to include.
    /// </summary>
    public partial class FindingsOutput
    {
        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// An optional set of OCSF finding filters that restrict which findings are exported.
        /// The filter structure is the same as the one used by <c>GetFindingsV2</c>. If you omit
        /// this member, Security Hub exports all findings available to the caller. When echoed
        /// by <c>GetExportJobV2</c>, relative date ranges are returned unresolved.
        /// </para>
        /// </summary>
        public OcsfFindingFilters Filters { get; set; }

        /// <summary>
        /// Checks to see if the Filters property is set.
        /// </summary>
        internal bool IsSetFilters() => this.Filters != null;

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

        /// <summary>
        /// Gets and sets the property SelectedFields. 
        /// <para>
        /// The OCSF finding fields to include in the export, specified as OCSF field paths (for
        /// example, <c>finding_info.title</c> or <c>severity</c>). You can specify from 1 to
        /// 50 fields.
        /// </para>
        ///  
        /// <para>
        /// Whether this parameter is required depends on the value of <c>Format</c>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>CSV</c> – Required. The field paths that you specify become the columns of the
        /// output, in the order that you provide them. If you omit this parameter, the request
        /// returns a <c>ValidationException</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>OCSF_JSON</c> – Not supported. This format includes each finding in full, so field
        /// selection doesn't apply. If you specify this parameter, the request returns a <c>ValidationException</c>.
        /// </para>
        ///  </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 50)]
        public List<string> SelectedFields { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the SelectedFields property is set.
        /// </summary>
        internal bool IsSetSelectedFields() => this.SelectedFields != null && (this.SelectedFields.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
