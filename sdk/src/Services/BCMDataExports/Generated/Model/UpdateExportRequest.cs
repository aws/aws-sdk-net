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
 * Do not modify this file. This file is generated from the bcm-data-exports-2023-11-26.normal.json service model.
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
namespace Amazon.BCMDataExports.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateExport operation.
    /// Updates an existing data export by overwriting all export parameters. All export parameters
    /// must be provided in the UpdateExport request.
    /// </summary>
    public partial class UpdateExportRequest : AmazonBCMDataExportsRequest
    {
        private Export _export;
        private string _exportArn;

        /// <summary>
        /// Gets and sets the property Export. 
        /// <para>
        /// The name and query details for the export.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public Export Export
        {
            get { return this._export; }
            set { this._export = value; }
        }

        // Check to see if Export property is set
        internal bool IsSetExport()
        {
            return this._export != null;
        }

        /// <summary>
        /// Gets and sets the property ExportArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) for this export.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=2048)]
        public string ExportArn
        {
            get { return this._exportArn; }
            set { this._exportArn = value; }
        }

        // Check to see if ExportArn property is set
        internal bool IsSetExportArn()
        {
            return this._exportArn != null;
        }

    }
}