/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the ssm-2014-11-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SimpleSystemsManagement.Model
{
    /// <summary>
    /// Container for the parameters to the GetInventory operation.
    /// Query inventory information.
    /// </summary>
    public partial class GetInventoryRequest : AmazonSimpleSystemsManagementRequest
    {
        private List<InventoryAggregator> _aggregators = new List<InventoryAggregator>();
        private List<InventoryFilter> _filters = new List<InventoryFilter>();
        private int? _maxResults;
        private string _nextToken;
        private List<ResultAttribute> _resultAttributes = new List<ResultAttribute>();

        /// <summary>
        /// Gets and sets the property Aggregators. 
        /// <para>
        /// Returns counts of inventory types based on one or more expressions. For example, if
        /// you aggregate by using an expression that uses the <code>AWS:InstanceInformation.PlatformType</code>
        /// type, you can see a count of how many Windows and Linux instances exist in your inventoried
        /// fleet.
        /// </para>
        /// </summary>
        public List<InventoryAggregator> Aggregators
        {
            get { return this._aggregators; }
            set { this._aggregators = value; }
        }

        // Check to see if Aggregators property is set
        internal bool IsSetAggregators()
        {
            return this._aggregators != null && this._aggregators.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// One or more filters. Use a filter to return a more specific list of results.
        /// </para>
        /// </summary>
        public List<InventoryFilter> Filters
        {
            get { return this._filters; }
            set { this._filters = value; }
        }

        // Check to see if Filters property is set
        internal bool IsSetFilters()
        {
            return this._filters != null && this._filters.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of items to return for this call. The call also returns a token
        /// that you can specify in a subsequent call to get the next set of results.
        /// </para>
        /// </summary>
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
        /// The token for the next set of items to return. (You received this token from a previous
        /// call.)
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
        /// Gets and sets the property ResultAttributes. 
        /// <para>
        /// The list of inventory item types to return.
        /// </para>
        /// </summary>
        public List<ResultAttribute> ResultAttributes
        {
            get { return this._resultAttributes; }
            set { this._resultAttributes = value; }
        }

        // Check to see if ResultAttributes property is set
        internal bool IsSetResultAttributes()
        {
            return this._resultAttributes != null && this._resultAttributes.Count > 0; 
        }

    }
}