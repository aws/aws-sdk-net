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

namespace Amazon.AbuseSignal.Model
{
    /// <summary>
    /// Status information for an individual abuse report. The ListAbuseReportStatuses operation
    /// returns this structure in its reports list.
    /// </summary>
    public partial class ReportStatusListItem
    {
        /// <summary>
        /// Gets and sets the property CorrelationId. 
        /// <para>
        /// The reporter-provided correlation ID for cross-referencing.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string CorrelationId { get; set; }

        /// <summary>
        /// Checks to see if the CorrelationId property is set.
        /// </summary>
        internal bool IsSetCorrelationId() => this.CorrelationId != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A human-readable description of the status.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property ReasonCode. 
        /// <para>
        /// A code that explains the resolution outcome. This value is present only after the
        /// report reaches the terminal <c>COMPLETED</c> status; it is absent while the report
        /// is <c>QUEUED</c> or <c>PROCESSING</c>.
        /// </para>
        /// </summary>
        public ReasonCode ReasonCode { get; set; }

        /// <summary>
        /// Checks to see if the ReasonCode property is set.
        /// </summary>
        internal bool IsSetReasonCode() => this.ReasonCode != null;

        /// <summary>
        /// Gets and sets the property ReportId. 
        /// <para>
        /// The unique identifier of the abuse report.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 20, Max = 64)]
        public string ReportId { get; set; }

        /// <summary>
        /// Checks to see if the ReportId property is set.
        /// </summary>
        internal bool IsSetReportId() => this.ReportId != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current processing status of the abuse report. Valid values are <c>QUEUED</c>
        /// (the report has been received and queued for processing), <c>PROCESSING</c> (the report
        /// has been received and is being processed), and <c>COMPLETED</c> (downstream resolution
        /// is finished).
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ReportSubmissionStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
