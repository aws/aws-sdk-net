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

namespace Amazon.LexModelsV2.Model
{
    /// <summary>
    /// This is the response object from the DeleteExport operation.
    /// </summary>
    public partial class DeleteExportResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property ExportId. 
        /// <para>
        /// The unique identifier of the deleted export.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 10, Max = 10)]
        public string ExportId { get; set; }

        /// <summary>
        /// Checks to see if the ExportId property is set.
        /// </summary>
        internal bool IsSetExportId() => this.ExportId != null;

        /// <summary>
        /// Gets and sets the property ExportStatus. 
        /// <para>
        /// The current status of the deletion. When the deletion is complete, the export will
        /// no longer be returned by the <a href="https://docs.aws.amazon.com/lexv2/latest/APIReference/API_ListExports.html">ListExports</a>
        /// operation and calls to the <a href="https://docs.aws.amazon.com/lexv2/latest/APIReference/API_DescribeExport.html">
        /// DescribeExport</a> operation with the export identifier will fail.
        /// </para>
        /// </summary>
        public ExportStatus ExportStatus { get; set; }

        /// <summary>
        /// Checks to see if the ExportStatus property is set.
        /// </summary>
        internal bool IsSetExportStatus() => this.ExportStatus != null;
    }
}
