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
 * Do not modify this file. This file is generated from the fsx-2018-03-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.FSx.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeDataRepositoryAssociations operation.
    /// Returns the description of specific Amazon FSx for Lustre or Amazon File Cache data
    /// repository associations, if one or more <code>AssociationIds</code> values are provided
    /// in the request, or if filters are used in the request. Data repository associations
    /// are supported only for Amazon FSx for Lustre file systems with the <code>Persistent_2</code>
    /// deployment type and for Amazon File Cache resources.
    /// 
    ///  
    /// <para>
    /// You can use filters to narrow the response to include just data repository associations
    /// for specific file systems (use the <code>file-system-id</code> filter with the ID
    /// of the file system) or caches (use the <code>file-cache-id</code> filter with the
    /// ID of the cache), or data repository associations for a specific repository type (use
    /// the <code>data-repository-type</code> filter with a value of <code>S3</code> or <code>NFS</code>).
    /// If you don't use filters, the response returns all data repository associations owned
    /// by your Amazon Web Services account in the Amazon Web Services Region of the endpoint
    /// that you're calling.
    /// </para>
    ///  
    /// <para>
    /// When retrieving all data repository associations, you can paginate the response by
    /// using the optional <code>MaxResults</code> parameter to limit the number of data repository
    /// associations returned in a response. If more data repository associations remain,
    /// a <code>NextToken</code> value is returned in the response. In this case, send a later
    /// request with the <code>NextToken</code> request parameter set to the value of <code>NextToken</code>
    /// from the last response.
    /// </para>
    /// </summary>
    public partial class DescribeDataRepositoryAssociationsRequest : AmazonFSxRequest
    {
        private List<string> _associationIds = new List<string>();
        private List<Filter> _filters = new List<Filter>();
        private int? _maxResults;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property AssociationIds. 
        /// <para>
        /// IDs of the data repository associations whose descriptions you want to retrieve (String).
        /// </para>
        /// </summary>
        [AWSProperty(Max=50)]
        public List<string> AssociationIds
        {
            get { return this._associationIds; }
            set { this._associationIds = value; }
        }

        // Check to see if AssociationIds property is set
        internal bool IsSetAssociationIds()
        {
            return this._associationIds != null && this._associationIds.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Filters.
        /// </summary>
        [AWSProperty(Max=10)]
        public List<Filter> Filters
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
        /// The maximum number of resources to return in the response. This value must be an integer
        /// greater than zero.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=25)]
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
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
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