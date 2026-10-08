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

namespace Amazon.SimpleEmailV2.Model
{
    /// <summary>
    /// Container for the parameters to the CreateExportJob operation. Creates an export job
    /// for a data source and destination. <para> Export jobs run asynchronously. This operation
    /// returns a <c>JobId</c>. Call <c>GetExportJob</c> with that ID until <c>JobStatus</c>
    /// is <c>COMPLETED</c>, <c>FAILED</c>, or <c>CANCELLED</c>. When the status is <c>COMPLETED</c>,
    /// download the export file from the pre-signed URL in <c>ExportDestination.S3Url</c>.
    /// When the status is <c>FAILED</c>, see <c>FailureInfo</c>. To store a copy in your
    /// own bucket, upload the downloaded file to your bucket. Do not include <c>S3Url</c>
    /// in the request. </para> <para> You can execute this operation no more than once per
    /// second. </para>
    /// </summary>
    public partial class CreateExportJobRequest : AmazonSimpleEmailServiceV2Request
    {
        /// <summary>
        /// Gets and sets the property ExportDataSource. 
        /// <para>
        /// The data source for the export job.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ExportDataSource ExportDataSource { get; set; }

        /// <summary>
        /// Checks to see if the ExportDataSource property is set.
        /// </summary>
        internal bool IsSetExportDataSource() => this.ExportDataSource != null;

        /// <summary>
        /// Gets and sets the property ExportDestination. 
        /// <para>
        /// The destination for the export job. Specify only <c>DataFormat</c>. Do not include
        /// <c>S3Url</c> in this request. SES writes the export file to a location that it manages
        /// and returns the download URL in <c>GetExportJob</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ExportDestination ExportDestination { get; set; }

        /// <summary>
        /// Checks to see if the ExportDestination property is set.
        /// </summary>
        internal bool IsSetExportDestination() => this.ExportDestination != null;
    }
}
