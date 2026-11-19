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

namespace Amazon.WellArchitected.Model
{
    /// <summary>
    /// Container for the parameters to the SendAgentOrganizationalReportDataToS3 operation.
    /// Writes the data artifact for a completed Organizational Report directly into a caller-owned
    /// S3 bucket. The artifact is written in the requested format to the supplied bucketArn
    /// and objectKey, and the resulting S3 location is returned in deliveredTo. This operation
    /// creates an S3 object and should not be retried indiscriminately. To download the artifact
    /// through a short-lived presigned URL instead, use GetAgentOrganizationalReportData.
    /// </summary>
    public partial class SendAgentOrganizationalReportDataToS3Request : AmazonWellArchitectedRequest
    {
        /// <summary>
        /// Gets and sets the property BucketArn. 
        /// <para>
        /// ARN of the caller-owned S3 bucket that will receive the artifact.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2048)]
        public string BucketArn { get; set; }

        /// <summary>
        /// Checks to see if the BucketArn property is set.
        /// </summary>
        internal bool IsSetBucketArn() => this.BucketArn != null;

        /// <summary>
        /// Gets and sets the property Format. 
        /// <para>
        /// Format of the delivered artifact (CSV, JSON, or PARQUET).
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public OrganizationalReportFormat Format { get; set; }

        /// <summary>
        /// Checks to see if the Format property is set.
        /// </summary>
        internal bool IsSetFormat() => this.Format != null;

        /// <summary>
        /// Gets and sets the property ObjectKey. 
        /// <para>
        /// S3 object key under bucketArn where the artifact will be written.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1024)]
        public string ObjectKey { get; set; }

        /// <summary>
        /// Checks to see if the ObjectKey property is set.
        /// </summary>
        internal bool IsSetObjectKey() => this.ObjectKey != null;

        /// <summary>
        /// Gets and sets the property ReportId. 
        /// <para>
        /// Identifier of the report whose data is being delivered.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ReportId { get; set; }

        /// <summary>
        /// Checks to see if the ReportId property is set.
        /// </summary>
        internal bool IsSetReportId() => this.ReportId != null;
    }
}
