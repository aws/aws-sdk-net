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
    /// Container for the parameters to the ListExposuresByRemediationV2 operation. Retrieves
    /// the exposure findings tied to a specific remediation target. Results are sorted by
    /// previous severity, highest first, and are paginated.
    /// </summary>
    public partial class ListExposuresByRemediationV2Request : AmazonSecurityHubRequest
    {
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
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token used to paginate the exposures list returned. On your first call to <c>ListExposuresByRemediationV2</c>,
        /// omit this parameter or set it to <c>NULL</c>. For subsequent calls, use the <c>NextToken</c>
        /// value returned in the previous response to retrieve the next page of results.
        /// </para>
        /// </summary>
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property TargetUid. 
        /// <para>
        /// The unique identifier (ID) of an existing remediation target to list exposure findings
        /// for.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2048)]
        public string TargetUid { get; set; }

        /// <summary>
        /// Checks to see if the TargetUid property is set.
        /// </summary>
        internal bool IsSetTargetUid() => this.TargetUid != null;
    }
}
