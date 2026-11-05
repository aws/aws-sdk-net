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

namespace Amazon.ApplicationDiscoveryService.Model
{
    /// <summary>
    /// Information regarding the export status of discovered data. The value is an array
    /// of objects.
    /// </summary>
    public partial class ExportInfo
    {
        /// <summary>
        /// Gets and sets the property ConfigurationsDownloadUrl. 
        /// <para>
        /// A URL for an Amazon S3 bucket where you can review the exported data. The URL is displayed
        /// only if the export succeeded.
        /// </para>
        /// </summary>
        public string ConfigurationsDownloadUrl { get; set; }

        /// <summary>
        /// Checks to see if the ConfigurationsDownloadUrl property is set.
        /// </summary>
        internal bool IsSetConfigurationsDownloadUrl() => this.ConfigurationsDownloadUrl != null;

        /// <summary>
        /// Gets and sets the property ExportId. 
        /// <para>
        /// A unique identifier used to query an export.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 200)]
        public string ExportId { get; set; }

        /// <summary>
        /// Checks to see if the ExportId property is set.
        /// </summary>
        internal bool IsSetExportId() => this.ExportId != null;

        /// <summary>
        /// Gets and sets the property ExportRequestTime. 
        /// <para>
        /// The time that the data export was initiated.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? ExportRequestTime { get; set; }

        /// <summary>
        /// Checks to see if the ExportRequestTime property is set.
        /// </summary>
        internal bool IsSetExportRequestTime() => this.ExportRequestTime.HasValue;

        /// <summary>
        /// Gets and sets the property ExportStatus. 
        /// <para>
        /// The status of the data export job.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ExportStatus ExportStatus { get; set; }

        /// <summary>
        /// Checks to see if the ExportStatus property is set.
        /// </summary>
        internal bool IsSetExportStatus() => this.ExportStatus != null;

        /// <summary>
        /// Gets and sets the property IsTruncated. 
        /// <para>
        /// If true, the export of agent information exceeded the size limit for a single export
        /// and the exported data is incomplete for the requested time range. To address this,
        /// select a smaller time range for the export by using <c>startDate</c> and <c>endDate</c>.
        /// </para>
        /// </summary>
        public bool? IsTruncated { get; set; }

        /// <summary>
        /// Checks to see if the IsTruncated property is set.
        /// </summary>
        internal bool IsSetIsTruncated() => this.IsTruncated.HasValue;

        /// <summary>
        /// Gets and sets the property RequestedEndTime. 
        /// <para>
        /// The <c>endTime</c> used in the <c>StartExportTask</c> request. If no <c>endTime</c>
        /// was requested, this result does not appear in <c>ExportInfo</c>.
        /// </para>
        /// </summary>
        public DateTime? RequestedEndTime { get; set; }

        /// <summary>
        /// Checks to see if the RequestedEndTime property is set.
        /// </summary>
        internal bool IsSetRequestedEndTime() => this.RequestedEndTime.HasValue;

        /// <summary>
        /// Gets and sets the property RequestedStartTime. 
        /// <para>
        /// The value of <c>startTime</c> parameter in the <c>StartExportTask</c> request. If
        /// no <c>startTime</c> was requested, this result does not appear in <c>ExportInfo</c>.
        /// </para>
        /// </summary>
        public DateTime? RequestedStartTime { get; set; }

        /// <summary>
        /// Checks to see if the RequestedStartTime property is set.
        /// </summary>
        internal bool IsSetRequestedStartTime() => this.RequestedStartTime.HasValue;

        /// <summary>
        /// Gets and sets the property StatusMessage. 
        /// <para>
        /// A status message provided for API callers.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string StatusMessage { get; set; }

        /// <summary>
        /// Checks to see if the StatusMessage property is set.
        /// </summary>
        internal bool IsSetStatusMessage() => this.StatusMessage != null;
    }
}
