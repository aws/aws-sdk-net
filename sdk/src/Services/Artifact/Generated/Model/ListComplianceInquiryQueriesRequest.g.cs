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

namespace Amazon.Artifact.Model
{
    /// <summary>
    /// Container for the parameters to the ListComplianceInquiryQueries operation. List queries
    /// within a compliance inquiry.
    /// </summary>
    public partial class ListComplianceInquiryQueriesRequest : AmazonArtifactRequest
    {
        /// <summary>
        /// Gets and sets the property ComplianceInquiryId. 
        /// <para>
        /// Unique resource ID for the compliance inquiry.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ComplianceInquiryId { get; set; }

        /// <summary>
        /// Checks to see if the ComplianceInquiryId property is set.
        /// </summary>
        internal bool IsSetComplianceInquiryId() => this.ComplianceInquiryId != null;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// Maximum number of resources to return in the paginated response.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 300)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// Pagination token to request the next page of resources.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;
    }
}
