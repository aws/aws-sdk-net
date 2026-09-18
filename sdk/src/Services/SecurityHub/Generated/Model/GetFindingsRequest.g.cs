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
    /// Container for the parameters to the GetFindings operation. Returns a list of findings
    /// that match the specified criteria. <para> If cross-Region aggregation is enabled,
    /// then when you call <c>GetFindings</c> from the home Region, the results include all
    /// of the matching findings from both the home Region and linked Regions. </para>
    /// </summary>
    public partial class GetFindingsRequest : AmazonSecurityHubRequest
    {
        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// The finding attributes used to define a condition to filter the returned findings.
        /// </para>
        ///  
        /// <para>
        /// You can filter by up to 10 finding attributes. For each attribute, you can provide
        /// up to 20 filter values.
        /// </para>
        ///  
        /// <para>
        /// Note that in the available filter fields, <c>WorkflowState</c> is deprecated. To search
        /// for a finding based on its workflow status, use <c>WorkflowStatus</c>.
        /// </para>
        /// </summary>
        public AwsSecurityFindingFilters Filters { get; set; }

        /// <summary>
        /// Checks to see if the Filters property is set.
        /// </summary>
        internal bool IsSetFilters() => this.Filters != null;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of findings to return.
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
        /// The token that is required for pagination. On your first call to the <c>GetFindings</c>
        /// operation, set the value of this parameter to <c>NULL</c>.
        /// </para>
        ///  
        /// <para>
        /// For subsequent calls to the operation, to continue listing data, set the value of
        /// this parameter to the value returned from the previous response.
        /// </para>
        /// </summary>
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property SortCriteria. 
        /// <para>
        /// The finding attributes used to sort the list of returned findings.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<SortCriterion> SortCriteria { get; set; } = AWSConfigs.InitializeCollections ? new List<SortCriterion>() : null;

        /// <summary>
        /// Checks to see if the SortCriteria property is set.
        /// </summary>
        internal bool IsSetSortCriteria() => this.SortCriteria != null && (this.SortCriteria.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
