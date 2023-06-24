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
 * Do not modify this file. This file is generated from the guardduty-2017-11-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.GuardDuty.Model
{
    /// <summary>
    /// Container for the parameters to the ListCoverage operation.
    /// Lists coverage details for your GuardDuty account. If you're a GuardDuty administrator,
    /// you can retrieve all resources associated with the active member accounts in your
    /// organization.
    /// 
    ///  
    /// <para>
    /// Make sure the accounts have EKS Runtime Monitoring enabled and GuardDuty agent running
    /// on their EKS nodes.
    /// </para>
    /// </summary>
    public partial class ListCoverageRequest : AmazonGuardDutyRequest
    {
        private string _detectorId;
        private CoverageFilterCriteria _filterCriteria;
        private int? _maxResults;
        private string _nextToken;
        private CoverageSortCriteria _sortCriteria;

        /// <summary>
        /// Gets and sets the property DetectorId. 
        /// <para>
        /// The unique ID of the detector whose coverage details you want to retrieve.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=300)]
        public string DetectorId
        {
            get { return this._detectorId; }
            set { this._detectorId = value; }
        }

        // Check to see if DetectorId property is set
        internal bool IsSetDetectorId()
        {
            return this._detectorId != null;
        }

        /// <summary>
        /// Gets and sets the property FilterCriteria. 
        /// <para>
        /// Represents the criteria used to filter the coverage details.
        /// </para>
        /// </summary>
        public CoverageFilterCriteria FilterCriteria
        {
            get { return this._filterCriteria; }
            set { this._filterCriteria = value; }
        }

        // Check to see if FilterCriteria property is set
        internal bool IsSetFilterCriteria()
        {
            return this._filterCriteria != null;
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to return in the response.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public int MaxResults
        {
            get { return this._maxResults.GetValueOrDefault(); }
            set { this._maxResults = value; }
        }

        // Check to see if MaxResults property is set
        internal bool IsSetMaxResults()
        {
            return this._maxResults.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// A token to use for paginating results that are returned in the response. Set the value
        /// of this parameter to null for the first request to a list action. For subsequent calls,
        /// use the NextToken value returned from the previous request to continue listing results
        /// after the first page.
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
        /// Gets and sets the property SortCriteria. 
        /// <para>
        /// Represents the criteria used to sort the coverage details.
        /// </para>
        /// </summary>
        public CoverageSortCriteria SortCriteria
        {
            get { return this._sortCriteria; }
            set { this._sortCriteria = value; }
        }

        // Check to see if SortCriteria property is set
        internal bool IsSetSortCriteria()
        {
            return this._sortCriteria != null;
        }

    }
}