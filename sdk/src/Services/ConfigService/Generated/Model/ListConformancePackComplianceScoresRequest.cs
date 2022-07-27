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
 * Do not modify this file. This file is generated from the config-2014-11-12.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ConfigService.Model
{
    /// <summary>
    /// Container for the parameters to the ListConformancePackComplianceScores operation.
    /// Returns a list of conformance pack compliance scores. A compliance score is the percentage
    /// of the number of compliant rule-resource combinations in a conformance pack compared
    /// to the number of total possible rule-resource combinations in the conformance pack.
    /// This metric provides you with a high-level view of the compliance state of your conformance
    /// packs, and can be used to identify, investigate, and understand compliance deviations
    /// in your conformance packs.
    /// </summary>
    public partial class ListConformancePackComplianceScoresRequest : AmazonConfigServiceRequest
    {
        private ConformancePackComplianceScoresFilters _filters;
        private int? _limit;
        private string _nextToken;
        private SortBy _sortBy;
        private SortOrder _sortOrder;

        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// Filters the results based on the <code>ConformancePackComplianceScoresFilters</code>.
        /// </para>
        /// </summary>
        public ConformancePackComplianceScoresFilters Filters
        {
            get { return this._filters; }
            set { this._filters = value; }
        }

        // Check to see if Filters property is set
        internal bool IsSetFilters()
        {
            return this._filters != null;
        }

        /// <summary>
        /// Gets and sets the property Limit. 
        /// <para>
        /// The maximum number of conformance pack compliance scores returned on each page.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=20)]
        public int Limit
        {
            get { return this._limit.GetValueOrDefault(); }
            set { this._limit = value; }
        }

        // Check to see if Limit property is set
        internal bool IsSetLimit()
        {
            return this._limit.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The <code>nextToken</code> string in a prior request that you can use to get the paginated
        /// response for next set of conformance pack compliance scores.
        /// </para>
        /// </summary>
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

        /// <summary>
        /// Gets and sets the property SortBy. 
        /// <para>
        /// Sorts your conformance pack compliance scores in either ascending or descending order,
        /// depending on <code>SortOrder</code>.
        /// </para>
        /// </summary>
        public SortBy SortBy
        {
            get { return this._sortBy; }
            set { this._sortBy = value; }
        }

        // Check to see if SortBy property is set
        internal bool IsSetSortBy()
        {
            return this._sortBy != null;
        }

        /// <summary>
        /// Gets and sets the property SortOrder. 
        /// <para>
        /// Determines the order in which conformance pack compliance scores are sorted. Either
        /// in ascending or descending order.
        /// </para>
        /// </summary>
        public SortOrder SortOrder
        {
            get { return this._sortOrder; }
            set { this._sortOrder = value; }
        }

        // Check to see if SortOrder property is set
        internal bool IsSetSortOrder()
        {
            return this._sortOrder != null;
        }

    }
}