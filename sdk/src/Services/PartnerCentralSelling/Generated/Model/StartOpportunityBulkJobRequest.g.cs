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
    /// Container for the parameters to the StartOpportunityBulkJob operation. The <c>StartOpportunityBulkJob</c>
    /// operation creates or updates many opportunities in AWS Partner Central (Partner Central)
    /// from a single CSV file. The column headers in the file determine whether the job creates
    /// or updates opportunities. <para> Returns a <c>JobId</c> for the job. Use <c>ListOpportunityBulkJobs</c>
    /// to track the job, <c>ListOpportunityBulkJobResults</c> to review each record, and
    /// <c>GetOpportunityBulkJobReportUrl</c> to download a report of the failed records.
    /// </para>
    /// </summary>
    public partial class StartOpportunityBulkJobRequest : AmazonPartnerCentralSellingRequest
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
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive identifier that you provide to ensure the operation completes
        /// no more than one time. If this token matches a previous request with the same parameters,
        /// the operation returns the <c>JobId</c> of the original job. If you reuse the token
        /// with different parameters, the request fails with a <c>ConflictException</c>.
        /// </para>
        /// </summary>
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property FileFormat. 
        /// <para>
        /// Specifies the format of the input file. The only supported value is <c>CSV</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public BulkFileFormat FileFormat { get; set; }

        /// <summary>
        /// Checks to see if the FileFormat property is set.
        /// </summary>
        internal bool IsSetFileFormat() => this.FileFormat != null;

        /// <summary>
        /// Gets and sets the property FileURI. 
        /// <para>
        /// Specifies the location of the CSV file that contains the opportunities to create or
        /// update. Use one of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// An <c>s3://</c> URI of a file that you uploaded to Partner Central for your account.
        /// You can add only the <c>versionId</c> query parameter.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// An <c>https://</c> presigned Amazon S3 URL
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// The file must be a plain-text CSV file no larger than 100 MB.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 1, Max = 2000)]
        public string FileURI { get; set; }

        /// <summary>
        /// Checks to see if the FileURI property is set.
        /// </summary>
        internal bool IsSetFileURI() => this.FileURI != null;
    }
}
