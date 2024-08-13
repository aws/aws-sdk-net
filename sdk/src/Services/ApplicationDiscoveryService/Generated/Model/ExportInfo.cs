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
 * Do not modify this file. This file is generated from the discovery-2015-11-01.normal.json service model.
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
namespace Amazon.ApplicationDiscoveryService.Model
{
    /// <summary>
    /// Information regarding the export status of discovered data. The value is an array
    /// of objects.
    /// </summary>
    public partial class ExportInfo
    {
        private string _configurationsDownloadUrl;
        private string _exportId;
        private DateTime? _exportRequestTime;
        private ExportStatus _exportStatus;
        private bool? _isTruncated;
        private DateTime? _requestedEndTime;
        private DateTime? _requestedStartTime;
        private string _statusMessage;

        /// <summary>
        /// Gets and sets the property ConfigurationsDownloadUrl. 
        /// <para>
        /// A URL for an Amazon S3 bucket where you can review the exported data. The URL is displayed
        /// only if the export succeeded.
        /// </para>
        /// </summary>
        public string ConfigurationsDownloadUrl
        {
            get { return this._configurationsDownloadUrl; }
            set { this._configurationsDownloadUrl = value; }
        }

        // Check to see if ConfigurationsDownloadUrl property is set
        internal bool IsSetConfigurationsDownloadUrl()
        {
            return this._configurationsDownloadUrl != null;
        }

        /// <summary>
        /// Gets and sets the property ExportId. 
        /// <para>
        /// A unique identifier used to query an export.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=200)]
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
        /// Gets and sets the property ExportRequestTime. 
        /// <para>
        /// The time that the data export was initiated.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? ExportRequestTime
        {
            get { return this._exportRequestTime; }
            set { this._exportRequestTime = value; }
        }

        // Check to see if ExportRequestTime property is set
        internal bool IsSetExportRequestTime()
        {
            return this._exportRequestTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ExportStatus. 
        /// <para>
        /// The status of the data export job.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property IsTruncated. 
        /// <para>
        /// If true, the export of agent information exceeded the size limit for a single export
        /// and the exported data is incomplete for the requested time range. To address this,
        /// select a smaller time range for the export by using <c>startDate</c> and <c>endDate</c>.
        /// </para>
        /// </summary>
        public bool? IsTruncated
        {
            get { return this._isTruncated; }
            set { this._isTruncated = value; }
        }

        // Check to see if IsTruncated property is set
        internal bool IsSetIsTruncated()
        {
            return this._isTruncated.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RequestedEndTime. 
        /// <para>
        /// The <c>endTime</c> used in the <c>StartExportTask</c> request. If no <c>endTime</c>
        /// was requested, this result does not appear in <c>ExportInfo</c>.
        /// </para>
        /// </summary>
        public DateTime? RequestedEndTime
        {
            get { return this._requestedEndTime; }
            set { this._requestedEndTime = value; }
        }

        // Check to see if RequestedEndTime property is set
        internal bool IsSetRequestedEndTime()
        {
            return this._requestedEndTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RequestedStartTime. 
        /// <para>
        /// The value of <c>startTime</c> parameter in the <c>StartExportTask</c> request. If
        /// no <c>startTime</c> was requested, this result does not appear in <c>ExportInfo</c>.
        /// </para>
        /// </summary>
        public DateTime? RequestedStartTime
        {
            get { return this._requestedStartTime; }
            set { this._requestedStartTime = value; }
        }

        // Check to see if RequestedStartTime property is set
        internal bool IsSetRequestedStartTime()
        {
            return this._requestedStartTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StatusMessage. 
        /// <para>
        /// A status message provided for API callers.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string StatusMessage
        {
            get { return this._statusMessage; }
            set { this._statusMessage = value; }
        }

        // Check to see if StatusMessage property is set
        internal bool IsSetStatusMessage()
        {
            return this._statusMessage != null;
        }

    }
}