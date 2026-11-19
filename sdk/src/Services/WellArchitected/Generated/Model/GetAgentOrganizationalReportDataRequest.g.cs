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
    /// Container for the parameters to the GetAgentOrganizationalReportData operation. Retrieves
    /// the data artifact for a completed Organizational Report as a short-lived presigned
    /// S3 URL. The response contains the URL in downloadUrl and its expiration in expiresAt.
    /// To have the service write the artifact directly into a caller-owned bucket instead,
    /// use SendAgentOrganizationalReportDataToS3.
    /// </summary>
    public partial class GetAgentOrganizationalReportDataRequest : AmazonWellArchitectedRequest
    {
        /// <summary>
        /// Gets and sets the property Format. 
        /// <para>
        /// Format of the returned artifact (CSV, JSON, or PARQUET).
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public OrganizationalReportFormat Format { get; set; }

        /// <summary>
        /// Checks to see if the Format property is set.
        /// </summary>
        internal bool IsSetFormat() => this.Format != null;

        /// <summary>
        /// Gets and sets the property ReportId. 
        /// <para>
        /// Identifier of the report whose data is being retrieved.
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
