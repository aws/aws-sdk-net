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

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Container for the parameters to the GetRemediationsV2 operation. Retrieves remediation
    /// targets for the account, or for all member accounts if the caller is the delegated
    /// administrator. Results are sorted by priority, highest first, and are paginated. Use
    /// <c>TargetUid</c> or <c>MetadataUid</c> to scope the request to a single target or
    /// finding.
    /// </summary>
    public partial class GetRemediationsV2Request : AmazonSecurityHubRequest
    {
        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// Filters remediation targets based on a set of criteria. You can't use <c>Filters</c>
        /// together with <c>TargetUid</c> or <c>MetadataUid</c>.
        /// </para>
        /// </summary>
        public RemediationFilters Filters { get; set; }

        /// <summary>
        /// Checks to see if the Filters property is set.
        /// </summary>
        internal bool IsSetFilters() => this.Filters != null;

        /// <summary>
        /// Gets and sets the property GuidanceFormat. 
        /// <para>
        /// The format of the remediation guidance examples to return. Valid values are <c>All</c>,
        /// <c>AwsCli</c>, <c>Cli</c>, <c>Python</c>, <c>Terraform</c>, <c>Cdk</c>, <c>CloudFormation</c>,
        /// <c>IaC</c>, and <c>Template</c>. If you don't specify a value, all formats are returned.
        /// Applies only when <c>ShowGuidance</c> is <c>true</c>.
        /// </para>
        /// </summary>
        public GuidanceFormat GuidanceFormat { get; set; }

        /// <summary>
        /// Checks to see if the GuidanceFormat property is set.
        /// </summary>
        internal bool IsSetGuidanceFormat() => this.GuidanceFormat != null;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to return. Valid range is 1-100. If you don't specify
        /// a value, the operation returns up to 25 results.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property MetadataUid. 
        /// <para>
        /// The unique identifier (ID) of the Security Hub exposure finding, found under the <c>metadata.uid</c>
        /// field of the finding. Returns the remediation targets associated with that finding.
        /// You can't use <c>MetadataUid</c> together with <c>TargetUid</c> or <c>Filters</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string MetadataUid { get; set; }

        /// <summary>
        /// Checks to see if the MetadataUid property is set.
        /// </summary>
        internal bool IsSetMetadataUid() => this.MetadataUid != null;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token used to paginate the remediations target list returned. On your first call
        /// to <c>GetRemediationsV2</c>, omit this parameter or set it to <c>NULL</c>. For subsequent
        /// calls, use the <c>NextToken</c> value returned in the previous response to retrieve
        /// the next page of results.
        /// </para>
        /// </summary>
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property ShowGuidance. 
        /// <para>
        /// Specifies whether to show remediation target guidance.
        /// </para>
        /// </summary>
        public bool? ShowGuidance { get; set; }

        /// <summary>
        /// Checks to see if the ShowGuidance property is set.
        /// </summary>
        internal bool IsSetShowGuidance() => this.ShowGuidance.HasValue;

        /// <summary>
        /// Gets and sets the property TargetUid. 
        /// <para>
        /// The unique identifier (ID) of an existing remediation target to return. Returns the
        /// single matching target. You can't use <c>TargetUid</c> together with <c>MetadataUid</c>
        /// or <c>Filters</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string TargetUid { get; set; }

        /// <summary>
        /// Checks to see if the TargetUid property is set.
        /// </summary>
        internal bool IsSetTargetUid() => this.TargetUid != null;
    }
}
