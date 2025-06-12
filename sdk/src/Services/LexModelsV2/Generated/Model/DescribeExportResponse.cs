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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.LexModelsV2.Model
{
    /// <summary>
    /// This is the response object from the DescribeExport operation.
    /// </summary>
    public partial class DescribeExportResponse : AmazonWebServiceResponse
    {
        private DateTime? _creationDateTime;
        private string _downloadUrl;
        private string _exportId;
        private ExportStatus _exportStatus;
        private List<string> _failureReasons = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private ImportExportFileFormat _fileFormat;
        private DateTime? _lastUpdatedDateTime;
        private ExportResourceSpecification _resourceSpecification;

        /// <summary>
        /// Gets and sets the property CreationDateTime. 
        /// <para>
        /// The date and time that the export was created.
        /// </para>
        /// </summary>
        public DateTime? CreationDateTime
        {
            get { return this._creationDateTime; }
            set { this._creationDateTime = value; }
        }

        // Check to see if CreationDateTime property is set
        internal bool IsSetCreationDateTime()
        {
            return this._creationDateTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DownloadUrl. 
        /// <para>
        /// A pre-signed S3 URL that points to the bot or bot locale archive. The URL is only
        /// available for 5 minutes after calling the <c>DescribeExport</c> operation.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string DownloadUrl
        {
            get { return this._downloadUrl; }
            set { this._downloadUrl = value; }
        }

        // Check to see if DownloadUrl property is set
        internal bool IsSetDownloadUrl()
        {
            return this._downloadUrl != null;
        }

        /// <summary>
        /// Gets and sets the property ExportId. 
        /// <para>
        /// The unique identifier of the described export.
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
        /// The status of the export. When the status is <c>Complete</c> the export archive file
        /// is available for download.
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
        /// Gets and sets the property FailureReasons. 
        /// <para>
        /// If the <c>exportStatus</c> is failed, contains one or more reasons why the export
        /// could not be completed.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> FailureReasons
        {
            get { return this._failureReasons; }
            set { this._failureReasons = value; }
        }

        // Check to see if FailureReasons property is set
        internal bool IsSetFailureReasons()
        {
            return this._failureReasons != null && (this._failureReasons.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property FileFormat. 
        /// <para>
        /// The file format used in the files that describe the resource. 
        /// </para>
        /// </summary>
        public ImportExportFileFormat FileFormat
        {
            get { return this._fileFormat; }
            set { this._fileFormat = value; }
        }

        // Check to see if FileFormat property is set
        internal bool IsSetFileFormat()
        {
            return this._fileFormat != null;
        }

        /// <summary>
        /// Gets and sets the property LastUpdatedDateTime. 
        /// <para>
        /// The last date and time that the export was updated.
        /// </para>
        /// </summary>
        public DateTime? LastUpdatedDateTime
        {
            get { return this._lastUpdatedDateTime; }
            set { this._lastUpdatedDateTime = value; }
        }

        // Check to see if LastUpdatedDateTime property is set
        internal bool IsSetLastUpdatedDateTime()
        {
            return this._lastUpdatedDateTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ResourceSpecification. 
        /// <para>
        /// The bot, bot ID, and optional locale ID of the exported bot or bot locale.
        /// </para>
        /// </summary>
        public ExportResourceSpecification ResourceSpecification
        {
            get { return this._resourceSpecification; }
            set { this._resourceSpecification = value; }
        }

        // Check to see if ResourceSpecification property is set
        internal bool IsSetResourceSpecification()
        {
            return this._resourceSpecification != null;
        }

    }
}