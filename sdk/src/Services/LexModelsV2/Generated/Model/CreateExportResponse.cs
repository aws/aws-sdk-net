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
    /// This is the response object from the CreateExport operation.
    /// </summary>
    public partial class CreateExportResponse : AmazonWebServiceResponse
    {
        private DateTime? _creationDateTime;
        private string _exportId;
        private ExportStatus _exportStatus;
        private ImportExportFileFormat _fileFormat;
        private ExportResourceSpecification _resourceSpecification;

        /// <summary>
        /// Gets and sets the property CreationDateTime. 
        /// <para>
        /// The date and time that the request to export a bot was created.
        /// </para>
        /// </summary>
        public DateTime CreationDateTime
        {
            get { return this._creationDateTime.GetValueOrDefault(); }
            set { this._creationDateTime = value; }
        }

        // Check to see if CreationDateTime property is set
        internal bool IsSetCreationDateTime()
        {
            return this._creationDateTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ExportId. 
        /// <para>
        /// An identifier for a specific request to create an export.
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
        /// The status of the export. When the status is <code>Completed</code>, you can use the
        /// <a href="https://docs.aws.amazon.com/lexv2/latest/APIReference/API_DescribeExport.html">DescribeExport</a>
        /// operation to get the pre-signed S3 URL link to your exported bot or bot locale.
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
        /// Gets and sets the property FileFormat. 
        /// <para>
        /// The file format used for the bot or bot locale definition files.
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
        /// Gets and sets the property ResourceSpecification. 
        /// <para>
        /// A description of the type of resource that was exported, either a bot or a bot locale.
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