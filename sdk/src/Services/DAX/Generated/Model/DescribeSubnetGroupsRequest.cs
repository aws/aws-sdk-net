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
 * Do not modify this file. This file is generated from the dax-2017-04-19.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.DAX.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeSubnetGroups operation.
    /// Returns a list of subnet group descriptions. If a subnet group name is specified,
    /// the list will contain only the description of that group.
    /// </summary>
    public partial class DescribeSubnetGroupsRequest : AmazonDAXRequest
    {
        private int? _maxResults;
        private string _nextToken;
        private List<string> _subnetGroupNames = new List<string>();

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to include in the response. If more results exist than
        /// the specified <code>MaxResults</code> value, a token is included in the response so
        /// that the remaining results can be retrieved.
        /// </para>
        ///  
        /// <para>
        /// The value for <code>MaxResults</code> must be between 20 and 100.
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
        /// An optional token returned from a prior request. Use this token for pagination of
        /// results from this action. If this parameter is specified, the response includes only
        /// results beyond the token, up to the value specified by <code>MaxResults</code>.
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
        /// Gets and sets the property SubnetGroupNames. 
        /// <para>
        /// The name of the subnet group.
        /// </para>
        /// </summary>
        public List<string> SubnetGroupNames
        {
            get { return this._subnetGroupNames; }
            set { this._subnetGroupNames = value; }
        }

        // Check to see if SubnetGroupNames property is set
        internal bool IsSetSubnetGroupNames()
        {
            return this._subnetGroupNames != null && this._subnetGroupNames.Count > 0; 
        }

    }
}