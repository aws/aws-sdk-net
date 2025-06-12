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
 * Do not modify this file. This file is generated from the inspector2-2020-06-08.normal.json service model.
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
namespace Amazon.Inspector2.Model
{
    /// <summary>
    /// This is the response object from the ListCoverageStatistics operation.
    /// </summary>
    public partial class ListCoverageStatisticsResponse : AmazonWebServiceResponse
    {
        private List<Counts> _countsByGroup = AWSConfigs.InitializeCollections ? new List<Counts>() : null;
        private string _nextToken;
        private long? _totalCounts;

        /// <summary>
        /// Gets and sets the property CountsByGroup. 
        /// <para>
        /// An array with the number for each group.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=5)]
        public List<Counts> CountsByGroup
        {
            get { return this._countsByGroup; }
            set { this._countsByGroup = value; }
        }

        // Check to see if CountsByGroup property is set
        internal bool IsSetCountsByGroup()
        {
            return this._countsByGroup != null && (this._countsByGroup.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// A token to use for paginating results that are returned in the response. Set the value
        /// of this parameter to null for the first request to a list action. For subsequent calls,
        /// use the <c>NextToken</c> value returned from the previous request to continue listing
        /// results after the first page.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1000000)]
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
        /// Gets and sets the property TotalCounts. 
        /// <para>
        /// The total number for all groups.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public long? TotalCounts
        {
            get { return this._totalCounts; }
            set { this._totalCounts = value; }
        }

        // Check to see if TotalCounts property is set
        internal bool IsSetTotalCounts()
        {
            return this._totalCounts.HasValue; 
        }

    }
}