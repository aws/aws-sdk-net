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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.FSx.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeDataRepositoryAssociations operation.
    /// Returns the description of specific Amazon FSx for Lustre or Amazon File Cache data
    /// repository associations, if one or more <c>AssociationIds</c> values are provided
    /// in the request, or if filters are used in the request. Data repository associations
    /// are supported on Amazon File Cache resources and all FSx for Lustre 2.12 and 2,15
    /// file systems, excluding <c>scratch_1</c> deployment type.
    /// 
    ///  
    /// <para>
    /// You can use filters to narrow the response to include just data repository associations
    /// for specific file systems (use the <c>file-system-id</c> filter with the ID of the
    /// file system) or caches (use the <c>file-cache-id</c> filter with the ID of the cache),
    /// or data repository associations for a specific repository type (use the <c>data-repository-type</c>
    /// filter with a value of <c>S3</c> or <c>NFS</c>). If you don't use filters, the response
    /// returns all data repository associations owned by your Amazon Web Services account
    /// in the Amazon Web Services Region of the endpoint that you're calling.
    /// </para>
    ///  
    /// <para>
    /// When retrieving all data repository associations, you can paginate the response by
    /// using the optional <c>MaxResults</c> parameter to limit the number of data repository
    /// associations returned in a response. If more data repository associations remain,
    /// a <c>NextToken</c> value is returned in the response. In this case, send a later request
    /// with the <c>NextToken</c> request parameter set to the value of <c>NextToken</c> from
    /// the last response.
    /// </para>
    /// </summary>
    public partial class DescribeDataRepositoryAssociationsRequest : AmazonFSxRequest
    {
        private List<string> _associationIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<Filter> _filters = AWSConfigs.InitializeCollections ? new List<Filter>() : null;
        private int? _maxResults;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property AssociationIds. 
        /// <para>
        /// IDs of the data repository associations whose descriptions you want to retrieve (String).
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
            return this._associationIds != null && (this._associationIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Filters.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
            return this._filters != null && (this._filters.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of resources to return in the response. This value must be an integer
        /// greater than zero.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=25)]
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