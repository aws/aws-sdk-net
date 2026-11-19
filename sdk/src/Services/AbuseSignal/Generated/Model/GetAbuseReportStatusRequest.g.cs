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
    /// Container for the parameters to the GetAbuseReportStatus operation. Retrieves the
    /// current processing status of a previously submitted abuse report, including the status,
    /// submission timestamp, and last-update time. <para> You can poll this operation to
    /// track the report's status. <c>PROCESSING</c> confirms that Amazon Web Services received
    /// your report and is processing it. <c>COMPLETED</c> means Amazon Web Services finished
    /// resolving the report, and the response includes a <c>reasonCode</c>. The time to reach
    /// <c>COMPLETED</c> may vary and can take up to several days depending on the scope and
    /// complexity of the suspected abuse. </para> <note> <para> <c>COMPLETED</c> is the only
    /// terminal status. To wait for a report, use the <c>ReportProcessing</c> waiter, which
    /// succeeds when the report reaches <c>PROCESSING</c> or <c>COMPLETED</c>. If you poll
    /// this operation yourself, wait 1–5 seconds between calls. </para> </note>
    /// </summary>
    public partial class GetAbuseReportStatusRequest : AmazonAbuseSignalRequest
    {
        /// <summary>
        /// Gets and sets the property ReportId. 
        /// <para>
        /// The unique identifier of the abuse report to retrieve status for. This is the <c>reportId</c>
        /// that is returned by <a>CreateAbuseReport</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 20, Max = 64)]
        public string ReportId { get; set; }

        /// <summary>
        /// Checks to see if the ReportId property is set.
        /// </summary>
        internal bool IsSetReportId() => this.ReportId != null;
    }
}
