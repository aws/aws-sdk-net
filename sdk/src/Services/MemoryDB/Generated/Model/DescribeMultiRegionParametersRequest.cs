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
 * Do not modify this file. This file is generated from the memorydb-2021-01-01.normal.json service model.
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
namespace Amazon.MemoryDB.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeMultiRegionParameters operation.
    /// Returns the detailed parameter list for a particular multi-region parameter group.
    /// </summary>
    public partial class DescribeMultiRegionParametersRequest : AmazonMemoryDBRequest
    {
        private int? _maxResults;
        private string _multiRegionParameterGroupName;
        private string _nextToken;
        private string _source;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of records to include in the response. If more records exist than
        /// the specified MaxResults value, a token is included in the response so that the remaining
        /// results can be retrieved.
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
        /// Gets and sets the property MultiRegionParameterGroupName. 
        /// <para>
        /// The name of the multi-region parameter group to return details for.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string MultiRegionParameterGroupName
        {
            get { return this._multiRegionParameterGroupName; }
            set { this._multiRegionParameterGroupName = value; }
        }

        // Check to see if MultiRegionParameterGroupName property is set
        internal bool IsSetMultiRegionParameterGroupName()
        {
            return this._multiRegionParameterGroupName != null;
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// An optional token returned from a prior request. Use this token for pagination of
        /// results from this action. If this parameter is specified, the response includes only
        /// results beyond the token, up to the value specified by MaxResults.
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
        /// Gets and sets the property Source. 
        /// <para>
        /// The parameter types to return. Valid values: user | system | engine-default
        /// </para>
        /// </summary>
        public string Source
        {
            get { return this._source; }
            set { this._source = value; }
        }

        // Check to see if Source property is set
        internal bool IsSetSource()
        {
            return this._source != null;
        }

    }
}