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
 * Do not modify this file. This file is generated from the dynamodb-2012-08-10.normal.json service model.
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
namespace Amazon.DynamoDBv2.Model
{
    /// <summary>
    /// Summary information about an export task.
    /// </summary>
    public partial class ExportSummary
    {
        private string _exportArn;
        private ExportStatus _exportStatus;
        private ExportType _exportType;

        /// <summary>
        /// Gets and sets the property ExportArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the export.
        /// </para>
        /// </summary>
        [AWSProperty(Min=37, Max=1024)]
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

        /// <summary>
        /// Gets and sets the property ExportStatus. 
        /// <para>
        /// Export can be in one of the following states: IN_PROGRESS, COMPLETED, or FAILED.
        /// </para>
        /// </summary>
        public ExportStatus ExportStatus
        {
            get { return this._exportStatus; }
            set { this._exportStatus = value; }
        }

        // Check to see if ExportStatus property is set
        internal bool IsSetExportStatus()
        {
            return this._exportStatus != null;
        }

        /// <summary>
        /// Gets and sets the property ExportType. 
        /// <para>
        /// The type of export that was performed. Valid values are <c>FULL_EXPORT</c> or <c>INCREMENTAL_EXPORT</c>.
        /// </para>
        /// </summary>
        public ExportType ExportType
        {
            get { return this._exportType; }
            set { this._exportType = value; }
        }

        // Check to see if ExportType property is set
        internal bool IsSetExportType()
        {
            return this._exportType != null;
        }

    }
}