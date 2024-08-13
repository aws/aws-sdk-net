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
 * Do not modify this file. This file is generated from the kendra-2019-02-03.normal.json service model.
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
namespace Amazon.Kendra.Model
{
    /// <summary>
    /// Container for the parameters to the ListGroupsOlderThanOrderingId operation.
    /// Provides a list of groups that are mapped to users before a given ordering or timestamp
    /// identifier.
    /// 
    ///  
    /// <para>
    ///  <c>ListGroupsOlderThanOrderingId</c> is currently not supported in the Amazon Web
    /// Services GovCloud (US-West) region.
    /// </para>
    /// </summary>
    public partial class ListGroupsOlderThanOrderingIdRequest : AmazonKendraRequest
    {
        private string _dataSourceId;
        private string _indexId;
        private int? _maxResults;
        private string _nextToken;
        private long? _orderingId;

        /// <summary>
        /// Gets and sets the property DataSourceId. 
        /// <para>
        /// The identifier of the data source for getting a list of groups mapped to users before
        /// a given ordering timestamp identifier.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public string DataSourceId
        {
            get { return this._dataSourceId; }
            set { this._dataSourceId = value; }
        }

        // Check to see if DataSourceId property is set
        internal bool IsSetDataSourceId()
        {
            return this._dataSourceId != null;
        }

        /// <summary>
        /// Gets and sets the property IndexId. 
        /// <para>
        /// The identifier of the index for getting a list of groups mapped to users before a
        /// given ordering or timestamp identifier.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=36, Max=36)]
        public string IndexId
        {
            get { return this._indexId; }
            set { this._indexId = value; }
        }

        // Check to see if IndexId property is set
        internal bool IsSetIndexId()
        {
            return this._indexId != null;
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        ///  The maximum number of returned groups that are mapped to users before a given ordering
        /// or timestamp identifier. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public int? MaxResults
        {
            get { return this._maxResults; }
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
        ///  If the previous response was incomplete (because there is more data to retrieve),
        /// Amazon Kendra returns a pagination token in the response. You can use this pagination
        /// token to retrieve the next set of groups that are mapped to users before a given ordering
        /// or timestamp identifier. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=800)]
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
        /// Gets and sets the property OrderingId. 
        /// <para>
        /// The timestamp identifier used for the latest <c>PUT</c> or <c>DELETE</c> action for
        /// mapping users to their groups.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=32535158400000)]
        public long? OrderingId
        {
            get { return this._orderingId; }
            set { this._orderingId = value; }
        }

        // Check to see if OrderingId property is set
        internal bool IsSetOrderingId()
        {
            return this._orderingId.HasValue; 
        }

    }
}