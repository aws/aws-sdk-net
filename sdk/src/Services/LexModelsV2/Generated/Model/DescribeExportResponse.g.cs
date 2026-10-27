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
    /// This is the response object from the DescribeExport operation.
    /// </summary>
    public partial class DescribeExportResponse : AmazonWebServiceResponse
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
        /// Gets and sets the property DownloadUrl. 
        /// <para>
        /// A pre-signed S3 URL that points to the bot or bot locale archive. The URL is only
        /// available for 5 minutes after calling the <c>DescribeExport</c> operation.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string DownloadUrl { get; set; }

        /// <summary>
        /// Checks to see if the DownloadUrl property is set.
        /// </summary>
        internal bool IsSetDownloadUrl() => this.DownloadUrl != null;

        /// <summary>
        /// Gets and sets the property ExportId. 
        /// <para>
        /// The unique identifier of the described export.
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
        /// The status of the export. When the status is <c>Complete</c> the export archive file
        /// is available for download.
        /// </para>
        /// </summary>
        public ExportStatus ExportStatus { get; set; }

        /// <summary>
        /// Checks to see if the ExportStatus property is set.
        /// </summary>
        internal bool IsSetExportStatus() => this.ExportStatus != null;

        /// <summary>
        /// Gets and sets the property FailureReasons. 
        /// <para>
        /// If the <c>exportStatus</c> is failed, contains one or more reasons why the export
        /// could not be completed.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> FailureReasons { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the FailureReasons property is set.
        /// </summary>
        internal bool IsSetFailureReasons() => this.FailureReasons != null && (this.FailureReasons.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property FileFormat. 
        /// <para>
        /// The file format used in the files that describe the resource. 
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
        /// The last date and time that the export was updated.
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
        /// The bot, bot ID, and optional locale ID of the exported bot or bot locale.
        /// </para>
        /// </summary>
        public ExportResourceSpecification ResourceSpecification { get; set; }

        /// <summary>
        /// Checks to see if the ResourceSpecification property is set.
        /// </summary>
        internal bool IsSetResourceSpecification() => this.ResourceSpecification != null;
    }
}
