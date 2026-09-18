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
    /// Container for the parameters to the GetRecommendedPolicyV2 operation. Retrieves the
    /// recommended policy to remediate a Security Hub finding. <c>GetRecommendedPolicyV2</c>
    /// only supports findings for unused permissions.
    /// </summary>
    public partial class GetRecommendedPolicyV2Request : AmazonSecurityHubRequest
    {
        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of recommendation steps to return.
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
        /// The unique identifier (ID) of Security Hub OCSF findings found under the <c>metadata.uid</c>
        /// field of the finding.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string MetadataUid { get; set; }

        /// <summary>
        /// Checks to see if the MetadataUid property is set.
        /// </summary>
        internal bool IsSetMetadataUid() => this.MetadataUid != null;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token used to paginate the <c>RecommendationSteps</c> list returned. On your first
        /// call to <c>GetRecommendedPolicyV2</c>, omit this parameter or set it to <c>NULL</c>.
        /// For subsequent calls, use the <c>NextToken</c> value returned in the previous response
        /// to retrieve the next page of results.
        /// </para>
        /// </summary>
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;
    }
}
