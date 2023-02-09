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
 * Do not modify this file. This file is generated from the models.lex.v2-2020-08-07.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.LexModelsV2.Model
{
    /// <summary>
    /// This is the response object from the DeleteExport operation.
    /// </summary>
    public partial class DeleteExportResponse : AmazonWebServiceResponse
    {
        private string _exportId;
        private ExportStatus _exportStatus;

        /// <summary>
        /// Gets and sets the property ExportId. 
        /// <para>
        /// The unique identifier of the deleted export.
        /// </para>
        /// </summary>
        [AWSProperty(Min=10, Max=10)]
        public string ExportId
        {
            get { return this._exportId; }
            set { this._exportId = value; }
        }

        // Check to see if ExportId property is set
        internal bool IsSetExportId()
        {
            return this._exportId != null;
        }

        /// <summary>
        /// Gets and sets the property ExportStatus. 
        /// <para>
        /// The current status of the deletion. When the deletion is complete, the export will
        /// no longer be returned by the <a href="https://docs.aws.amazon.com/lexv2/latest/APIReference/API_ListExports.html">ListExports</a>
        /// operation and calls to the <a href="https://docs.aws.amazon.com/lexv2/latest/APIReference/API_DescribeExport.html">
        /// DescribeExport</a> operation with the export identifier will fail.
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

    }
}