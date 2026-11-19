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
    /// Container for the parameters to the GetCustomerAccountBulkJobReportUrl operation.
    /// Use <c>GetCustomerAccountBulkJobReportUrl</c> to get a temporary URL for downloading
    /// the report of a bulk job, such as the list of records that failed. A report is available
    /// only after the job is <c>COMPLETED</c> or <c>FAILED</c>. For a job that is still running,
    /// the request fails with a <c>ConflictException</c>. <para> The report is generated
    /// on request. If <c>ReportStatus</c> is not <c>AVAILABLE</c>, call the operation again
    /// later. </para>
    /// </summary>
    public partial class GetCustomerAccountBulkJobReportUrlRequest : AmazonPartnerCentralSellingRequest
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
        /// Gets and sets the property Identifier. 
        /// <para>
        /// Specifies the ARN or the identifier of the bulk job.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Identifier { get; set; }

        /// <summary>
        /// Checks to see if the Identifier property is set.
        /// </summary>
        internal bool IsSetIdentifier() => this.Identifier != null;

        /// <summary>
        /// Gets and sets the property ReportType. 
        /// <para>
        /// Specifies which records the report covers. If you omit this field, the report covers
        /// the records that failed.
        /// </para>
        /// </summary>
        public BulkReportType ReportType { get; set; }

        /// <summary>
        /// Checks to see if the ReportType property is set.
        /// </summary>
        internal bool IsSetReportType() => this.ReportType != null;
    }
}
