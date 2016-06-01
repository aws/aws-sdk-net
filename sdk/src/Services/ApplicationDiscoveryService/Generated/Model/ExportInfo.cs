/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ApplicationDiscoveryService.Model
{
    /// <summary>
    /// Information regarding the export status of the discovered data. The value is an array
    /// of objects.
    /// </summary>
    public partial class ExportInfo
    {
        private string _configurationsDownloadUrl;
        private string _exportId;
        private DateTime? _exportRequestTime;
        private ExportStatus _exportStatus;
        private string _statusMessage;

        /// <summary>
        /// Gets and sets the property ConfigurationsDownloadUrl. 
        /// <para>
        /// A URL for an Amazon S3 bucket where you can review the configuration data. The URL
        /// is displayed only if the export succeeded.
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
        /// A unique identifier that you can use to query the export.
        /// </para>
        /// </summary>
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
        /// The time the configuration data export was initiated.
        /// </para>
        /// </summary>
        public DateTime ExportRequestTime
        {
            get { return this._exportRequestTime.GetValueOrDefault(); }
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
        /// The status of the configuration data export. The status can succeed, fail, or be in-progress.
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
        /// Gets and sets the property StatusMessage. 
        /// <para>
        /// Helpful status messages for API callers. For example: Too many exports in the last
        /// 6 hours. Export in progress. Export was successful.
        /// </para>
        /// </summary>
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