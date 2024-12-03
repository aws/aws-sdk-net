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
 * Do not modify this file. This file is generated from the mailmanager-2023-10-17.normal.json service model.
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
namespace Amazon.MailManager.Model
{
    /// <summary>
    /// Container for the parameters to the StartArchiveExport operation.
    /// Initiates an export of emails from the specified archive.
    /// </summary>
    public partial class StartArchiveExportRequest : AmazonMailManagerRequest
    {
        private string _archiveId;
        private ExportDestinationConfiguration _exportDestinationConfiguration;
        private ArchiveFilters _filters;
        private DateTime? _fromTimestamp;
        private bool? _includeMetadata;
        private int? _maxResults;
        private DateTime? _toTimestamp;

        /// <summary>
        /// Gets and sets the property ArchiveId. 
        /// <para>
        /// The identifier of the archive to export emails from.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=3, Max=66)]
        public string ArchiveId
        {
            get { return this._archiveId; }
            set { this._archiveId = value; }
        }

        // Check to see if ArchiveId property is set
        internal bool IsSetArchiveId()
        {
            return this._archiveId != null;
        }

        /// <summary>
        /// Gets and sets the property ExportDestinationConfiguration. 
        /// <para>
        /// Details on where to deliver the exported email data.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ExportDestinationConfiguration ExportDestinationConfiguration
        {
            get { return this._exportDestinationConfiguration; }
            set { this._exportDestinationConfiguration = value; }
        }

        // Check to see if ExportDestinationConfiguration property is set
        internal bool IsSetExportDestinationConfiguration()
        {
            return this._exportDestinationConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// Criteria to filter which emails are included in the export.
        /// </para>
        /// </summary>
        public ArchiveFilters Filters
        {
            get { return this._filters; }
            set { this._filters = value; }
        }

        // Check to see if Filters property is set
        internal bool IsSetFilters()
        {
            return this._filters != null;
        }

        /// <summary>
        /// Gets and sets the property FromTimestamp. 
        /// <para>
        /// The start of the timestamp range to include emails from.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? FromTimestamp
        {
            get { return this._fromTimestamp; }
            set { this._fromTimestamp = value; }
        }

        // Check to see if FromTimestamp property is set
        internal bool IsSetFromTimestamp()
        {
            return this._fromTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IncludeMetadata. 
        /// <para>
        /// Whether to include message metadata as JSON files in the export.
        /// </para>
        /// </summary>
        public bool? IncludeMetadata
        {
            get { return this._includeMetadata; }
            set { this._includeMetadata = value; }
        }

        // Check to see if IncludeMetadata property is set
        internal bool IsSetIncludeMetadata()
        {
            return this._includeMetadata.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of email items to include in the export.
        /// </para>
        /// </summary>
        public int? MaxResults
        {
            get { return this._maxResults; }
            set { this._maxResults = value; }
        }

        // Check to see if MaxResults property is set
        internal bool IsSetMaxResults()
        {
            return this._maxResults.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ToTimestamp. 
        /// <para>
        /// The end of the timestamp range to include emails from.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? ToTimestamp
        {
            get { return this._toTimestamp; }
            set { this._toTimestamp = value; }
        }

        // Check to see if ToTimestamp property is set
        internal bool IsSetToTimestamp()
        {
            return this._toTimestamp.HasValue; 
        }

    }
}