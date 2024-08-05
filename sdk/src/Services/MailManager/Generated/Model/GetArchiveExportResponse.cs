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
    /// The response containing details of the specified archive export job.
    /// </summary>
    public partial class GetArchiveExportResponse : AmazonWebServiceResponse
    {
        private string _archiveId;
        private ExportDestinationConfiguration _exportDestinationConfiguration;
        private ArchiveFilters _filters;
        private DateTime? _fromTimestamp;
        private int? _maxResults;
        private ExportStatus _status;
        private DateTime? _toTimestamp;

        /// <summary>
        /// Gets and sets the property ArchiveId. 
        /// <para>
        /// The identifier of the archive the email export was performed from.
        /// </para>
        /// </summary>
        [AWSProperty(Min=3, Max=66)]
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
        /// Where the exported emails are being delivered.
        /// </para>
        /// </summary>
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
        /// The criteria used to filter emails included in the export.
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
        /// The start of the timestamp range the exported emails cover.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of email items included in the export.
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
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the export job.
        /// </para>
        /// </summary>
        public ExportStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property ToTimestamp. 
        /// <para>
        /// The end of the date range the exported emails cover.
        /// </para>
        /// </summary>
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