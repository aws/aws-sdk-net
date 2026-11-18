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
    /// Container for the parameters to the CreateAbuseReport operation. Submits a structured
    /// report. Amazon Web Services validates it and returns a report ID. A successful response
    /// confirms that Amazon Web Services received your report. It doesn't mean that Amazon
    /// Web Services has reached an outcome. Use <a>GetAbuseReportStatus</a> with the report
    /// ID to check the report's status and outcome. <para> This operation is idempotent within
    /// a time window. If you provide a <c>clientToken</c>, duplicate requests within 24 hours
    /// return the existing report ID. If you omit it, the service generates a token scoped
    /// to 5 minutes. </para> <important> <para> <b>Cross-Region data residency:</b> By submitting
    /// a report, you instruct Amazon Web Services to store it in all supported Regions (<c>us-east-1</c>,
    /// <c>us-west-2</c>, and <c>eu-west-2</c>), including across the United States and Europe.
    /// If data must remain in a single Region, do not include it in the report. </para> </important>
    /// </summary>
    public partial class CreateAbuseReportRequest : AmazonAbuseSignalRequest
    {
        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// An optional, client-provided idempotency token that ensures the operation completes
        /// no more than once. If the token matches a previous request within 24 hours, the service
        /// returns the existing report ID instead of creating a new report. When you omit this
        /// token, the service automatically generates one that is scoped to a 5-minute window.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property CorrelationId. 
        /// <para>
        /// An optional correlation ID for tracking the report in the reporter's system. The service
        /// echoes this value back in responses, and you can use it to filter reports with <a>ListAbuseReportStatuses</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string CorrelationId { get; set; }

        /// <summary>
        /// Checks to see if the CorrelationId property is set.
        /// </summary>
        internal bool IsSetCorrelationId() => this.CorrelationId != null;

        /// <summary>
        /// Gets and sets the property Report. 
        /// <para>
        /// The abuse report data in XARF format. Provide the report under the <c>xarf</c> key.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true)]
        public ReportData Report { get; set; }

        /// <summary>
        /// Checks to see if the Report property is set.
        /// </summary>
        internal bool IsSetReport() => this.Report != null;
    }
}
