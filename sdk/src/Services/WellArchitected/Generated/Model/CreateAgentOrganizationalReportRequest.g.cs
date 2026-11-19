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
    /// Container for the parameters to the CreateAgentOrganizationalReport operation. Creates
    /// an Organizational Report, which is an asynchronously-materialized, point-in-time snapshot
    /// of recommendations across all Agent Profiles within the caller's AWS Organization.
    /// You can optionally narrow the scope with filters. The operation is idempotent on the
    /// caller-supplied clientToken. The AWS Organization the report belongs to is inferred
    /// from the caller's authorization context. Reports are retained for 90 days from creation,
    /// after which they are automatically deleted. Use DeleteAgentOrganizationalReport to
    /// delete a report earlier.
    /// </summary>
    public partial class CreateAgentOrganizationalReportRequest : AmazonWellArchitectedRequest
    {
        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A caller-supplied idempotency token. Two create calls sharing the same token within
        /// the service's idempotency window return the same reportId.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// Optional filters narrowing the report's scope. Absent means the report covers the
        /// whole organization.
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
        /// Optional human-readable label (1-500 characters) that helps callers distinguish reports
        /// created with the same filters. Carried through list and get responses.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 500)]
        public string Label { get; set; }

        /// <summary>
        /// Checks to see if the Label property is set.
        /// </summary>
        internal bool IsSetLabel() => this.Label != null;
    }
}
