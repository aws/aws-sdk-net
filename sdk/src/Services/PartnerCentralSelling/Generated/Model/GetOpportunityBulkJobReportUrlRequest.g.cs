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

namespace Amazon.PartnerCentralSelling.Model
{
    /// <summary>
    /// Container for the parameters to the GetOpportunityBulkJobReportUrl operation. Gets
    /// the status of the failed-records report for a finished opportunity bulk job and, when
    /// the report is ready, a temporary URL to download it. <para> A report is available
    /// only after the job is <c>COMPLETED</c> or <c>FAILED</c>. The URL expires after 15
    /// minutes, and the report expires after about 7 days. </para>
    /// </summary>
    public partial class GetOpportunityBulkJobReportUrlRequest : AmazonPartnerCentralSellingRequest
    {
        /// <summary>
        /// Gets and sets the property Catalog. 
        /// <para>
        /// Specifies the catalog for the request. Valid values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>AWS</c>: Production.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Sandbox</c>: Testing environments.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Catalog { get; set; }

        /// <summary>
        /// Checks to see if the Catalog property is set.
        /// </summary>
        internal bool IsSetCatalog() => this.Catalog != null;

        /// <summary>
        /// Gets and sets the property JobId. 
        /// <para>
        /// Specifies the identifier of the bulk job.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string JobId { get; set; }

        /// <summary>
        /// Checks to see if the JobId property is set.
        /// </summary>
        internal bool IsSetJobId() => this.JobId != null;

        /// <summary>
        /// Gets and sets the property ReportFormat. 
        /// <para>
        /// Specifies the format of the report. The only supported value is <c>CSV</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public BulkFileFormat ReportFormat { get; set; }

        /// <summary>
        /// Checks to see if the ReportFormat property is set.
        /// </summary>
        internal bool IsSetReportFormat() => this.ReportFormat != null;

        /// <summary>
        /// Gets and sets the property ReportType. 
        /// <para>
        /// Specifies which records the report covers. If you omit this field, the report covers
        /// the records that failed. <c>ALL_RECORDS</c> isn't supported yet, and a request for
        /// it fails with a <c>ValidationException</c>.
        /// </para>
        /// </summary>
        public BulkReportType ReportType { get; set; }

        /// <summary>
        /// Checks to see if the ReportType property is set.
        /// </summary>
        internal bool IsSetReportType() => this.ReportType != null;
    }
}
