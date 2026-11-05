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

namespace Amazon.ConfigService.Model
{
    /// <summary>
    /// Container for the parameters to the ListConformancePackComplianceScores operation.
    /// Returns a list of conformance pack compliance scores. A compliance score is the percentage
    /// of the number of compliant rule-resource combinations in a conformance pack compared
    /// to the number of total possible rule-resource combinations in the conformance pack.
    /// This metric provides you with a high-level view of the compliance state of your conformance
    /// packs. You can use it to identify, investigate, and understand the level of compliance
    /// in your conformance packs. <note> <para> Conformance packs with no evaluation results
    /// will have a compliance score of <c>INSUFFICIENT_DATA</c>. </para> </note>
    /// </summary>
    public partial class ListConformancePackComplianceScoresRequest : AmazonConfigServiceRequest
    {
        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// Filters the results based on the <c>ConformancePackComplianceScoresFilters</c>.
        /// </para>
        /// </summary>
        public ConformancePackComplianceScoresFilters Filters { get; set; }

        /// <summary>
        /// Checks to see if the Filters property is set.
        /// </summary>
        internal bool IsSetFilters() => this.Filters != null;

        /// <summary>
        /// Gets and sets the property Limit. 
        /// <para>
        /// The maximum number of conformance pack compliance scores returned on each page.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 20)]
        public int? Limit { get; set; }

        /// <summary>
        /// Checks to see if the Limit property is set.
        /// </summary>
        internal bool IsSetLimit() => this.Limit.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The <c>nextToken</c> string in a prior request that you can use to get the paginated
        /// response for the next set of conformance pack compliance scores.
        /// </para>
        /// </summary>
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property SortBy. 
        /// <para>
        /// Sorts your conformance pack compliance scores in either ascending or descending order,
        /// depending on <c>SortOrder</c>.
        /// </para>
        ///  
        /// <para>
        /// By default, conformance pack compliance scores are sorted in alphabetical order by
        /// name of the conformance pack. Enter <c>SCORE</c>, to sort conformance pack compliance
        /// scores by the numerical value of the compliance score.
        /// </para>
        /// </summary>
        public SortBy SortBy { get; set; }

        /// <summary>
        /// Checks to see if the SortBy property is set.
        /// </summary>
        internal bool IsSetSortBy() => this.SortBy != null;

        /// <summary>
        /// Gets and sets the property SortOrder. 
        /// <para>
        /// Determines the order in which conformance pack compliance scores are sorted. Either
        /// in ascending or descending order.
        /// </para>
        ///  
        /// <para>
        /// By default, conformance pack compliance scores are sorted in alphabetical order by
        /// name of the conformance pack. Conformance pack compliance scores are sorted in reverse
        /// alphabetical order if you enter <c>DESCENDING</c>.
        /// </para>
        ///  
        /// <para>
        /// You can sort conformance pack compliance scores by the numerical value of the compliance
        /// score by entering <c>SCORE</c> in the <c>SortBy</c> action. When compliance scores
        /// are sorted by <c>SCORE</c>, conformance packs with a compliance score of <c>INSUFFICIENT_DATA</c>
        /// will be last when sorting by ascending order and first when sorting by descending
        /// order.
        /// </para>
        /// </summary>
        public SortOrder SortOrder { get; set; }

        /// <summary>
        /// Checks to see if the SortOrder property is set.
        /// </summary>
        internal bool IsSetSortOrder() => this.SortOrder != null;
    }
}
