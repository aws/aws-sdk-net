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
 * Do not modify this file. This file is generated from the iotsitewise-2019-12-02.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IoTSiteWise.Model
{
    /// <summary>
    /// Container for the parameters to the BatchGetAssetPropertyAggregates operation.
    /// Gets aggregated values (for example, average, minimum, and maximum) for one or more
    /// asset properties. For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/query-industrial-data.html#aggregates">Querying
    /// aggregates</a> in the <i>IoT SiteWise User Guide</i>.
    /// </summary>
    public partial class BatchGetAssetPropertyAggregatesRequest : AmazonIoTSiteWiseRequest
    {
        private List<BatchGetAssetPropertyAggregatesEntry> _entries = AWSConfigs.InitializeCollections ? new List<BatchGetAssetPropertyAggregatesEntry>() : null;
        private int? _maxResults;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property Entries. 
        /// <para>
        /// The list of asset property aggregate entries for the batch get request. You can specify
        /// up to 16 entries per request.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<BatchGetAssetPropertyAggregatesEntry> Entries
        {
            get { return this._entries; }
            set { this._entries = value; }
        }

        // Check to see if Entries property is set
        internal bool IsSetEntries()
        {
            return this._entries != null && (this._entries.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to return for each paginated request. A result set is
        /// returned in the two cases, whichever occurs first.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The size of the result set is equal to 1 MB.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The number of data points in the result set is equal to the value of <c>maxResults</c>.
        /// The maximum value of <c>maxResults</c> is 4000.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Min=1)]
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
        /// The token to be used for the next set of paginated results.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=4096)]
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

    }
}