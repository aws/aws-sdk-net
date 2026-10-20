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
    /// This is the response object from the UpdateExport operation.
    /// </summary>
    public partial class UpdateExportResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property CreationDateTime. 
        /// <para>
        /// The date and time that the export was created.
        /// </para>
        /// </summary>
        public DateTime? CreationDateTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationDateTime property is set.
        /// </summary>
        internal bool IsSetCreationDateTime() => this.CreationDateTime.HasValue;

        /// <summary>
        /// Gets and sets the property ExportId. 
        /// <para>
        /// The unique identifier Amazon Lex assigned to the export.
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
        /// The status of the export. When the status is <c>Completed</c> the export archive is
        /// available for download.
        /// </para>
        /// </summary>
        public ExportStatus ExportStatus { get; set; }

        /// <summary>
        /// Checks to see if the ExportStatus property is set.
        /// </summary>
        internal bool IsSetExportStatus() => this.ExportStatus != null;

        /// <summary>
        /// Gets and sets the property FileFormat. 
        /// <para>
        /// The file format used for the files that define the resource. The <c>TSV</c> format
        /// is required to export a custom vocabulary only; otherwise use <c>LexJson</c> format.
        /// </para>
        /// </summary>
        public ImportExportFileFormat FileFormat { get; set; }

        /// <summary>
        /// Checks to see if the FileFormat property is set.
        /// </summary>
        internal bool IsSetFileFormat() => this.FileFormat != null;

        /// <summary>
        /// Gets and sets the property LastUpdatedDateTime. 
        /// <para>
        /// The date and time that the export was last updated.
        /// </para>
        /// </summary>
        public DateTime? LastUpdatedDateTime { get; set; }

        /// <summary>
        /// Checks to see if the LastUpdatedDateTime property is set.
        /// </summary>
        internal bool IsSetLastUpdatedDateTime() => this.LastUpdatedDateTime.HasValue;

        /// <summary>
        /// Gets and sets the property ResourceSpecification. 
        /// <para>
        /// A description of the type of resource that was exported, either a bot or a bot locale.
        /// </para>
        /// </summary>
        public ExportResourceSpecification ResourceSpecification { get; set; }

        /// <summary>
        /// Checks to see if the ResourceSpecification property is set.
        /// </summary>
        internal bool IsSetResourceSpecification() => this.ResourceSpecification != null;
    }
}
