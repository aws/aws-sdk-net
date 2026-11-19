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
    /// This is the response object from the GetAgentOrganizationalReport operation.
    /// </summary>
    public partial class GetAgentOrganizationalReportResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property CoverageSummary. 
        /// <para>
        /// Coverage and aggregate counts for the report. Present only after the report reaches
        /// COMPLETED.
        /// </para>
        /// </summary>
        public CoverageSummary CoverageSummary { get; set; }

        /// <summary>
        /// Checks to see if the CoverageSummary property is set.
        /// </summary>
        internal bool IsSetCoverageSummary() => this.CoverageSummary != null;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// Timestamp at which the report was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// Filters captured when the report was created. Absent when no filters were supplied
        /// (meaning the report covered the whole organization).
        /// </para>
        /// </summary>
        public OrganizationalReportFilters Filters { get; set; }

        /// <summary>
        /// Checks to see if the Filters property is set.
        /// </summary>
        internal bool IsSetFilters() => this.Filters != null;

        /// <summary>
        /// Gets and sets the property Label. 
        /// <para>
        /// Optional human-readable label supplied by the caller at creation time.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 500)]
        public string Label { get; set; }

        /// <summary>
        /// Checks to see if the Label property is set.
        /// </summary>
        internal bool IsSetLabel() => this.Label != null;

        /// <summary>
        /// Gets and sets the property OrganizationId. 
        /// <para>
        /// Identifier of the AWS Organization the report belongs to. Derived from the caller's
        /// authorization context at creation time and not accepted as a client-supplied input.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string OrganizationId { get; set; }

        /// <summary>
        /// Checks to see if the OrganizationId property is set.
        /// </summary>
        internal bool IsSetOrganizationId() => this.OrganizationId != null;

        /// <summary>
        /// Gets and sets the property OwnerAccountId. 
        /// <para>
        /// AWS account ID of the caller that created the report. Only this account or a delegated
        /// administrator of the same organization may retrieve or delete the report.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string OwnerAccountId { get; set; }

        /// <summary>
        /// Checks to see if the OwnerAccountId property is set.
        /// </summary>
        internal bool IsSetOwnerAccountId() => this.OwnerAccountId != null;

        /// <summary>
        /// Gets and sets the property ReportId. 
        /// <para>
        /// Unique identifier of the Organizational Report assigned by the service at creation
        /// time.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ReportId { get; set; }

        /// <summary>
        /// Checks to see if the ReportId property is set.
        /// </summary>
        internal bool IsSetReportId() => this.ReportId != null;

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// Current lifecycle state of the report.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public OrganizationalReportState State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;
    }
}
