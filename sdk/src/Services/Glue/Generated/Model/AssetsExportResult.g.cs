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

namespace Amazon.Glue.Model
{
    /// <summary>
    /// The export setting and current export state for asset metadata.
    /// </summary>
    public partial class AssetsExportResult
    {
        /// <summary>
        /// Gets and sets the property S3TablesExport. 
        /// <para>
        /// Whether asset metadata is exported to S3 Tables. Valid values are <c>ENABLED</c> and
        /// <c>DISABLED</c>.
        /// </para>
        /// </summary>
        public ExportSetting S3TablesExport { get; set; }

        /// <summary>
        /// Checks to see if the S3TablesExport property is set.
        /// </summary>
        internal bool IsSetS3TablesExport() => this.S3TablesExport != null;

        /// <summary>
        /// Gets and sets the property S3TablesExportState. 
        /// <para>
        /// The current state of the asset metadata export to S3 Tables.
        /// </para>
        /// </summary>
        public S3TablesExportState S3TablesExportState { get; set; }

        /// <summary>
        /// Checks to see if the S3TablesExportState property is set.
        /// </summary>
        internal bool IsSetS3TablesExportState() => this.S3TablesExportState != null;
    }
}
