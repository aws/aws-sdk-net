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
 * Do not modify this file. This file is generated from the outposts-2019-12-03.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Outposts.Model
{
    /// <summary>
    /// Container for the parameters to the ListCatalogItems operation.
    /// Use to create a list of every item in the catalog. Add filters to your request to
    /// return a more specific list of results. Use filters to match an item class, storage
    /// option, or EC2 family. 
    /// 
    ///  
    /// <para>
    /// If you specify multiple filters, the filters are joined with an <code>AND</code>,
    /// and the request returns only results that match all of the specified filters.
    /// </para>
    /// </summary>
    public partial class ListCatalogItemsRequest : AmazonOutpostsRequest
    {
        private List<string> _ec2FamilyFilter = new List<string>();
        private List<string> _itemClassFilter = new List<string>();
        private int? _maxResults;
        private string _nextToken;
        private List<string> _supportedStorageFilter = new List<string>();

        /// <summary>
        /// Gets and sets the property EC2FamilyFilter. 
        /// <para>
        ///  A filter for EC2 family options for items in the catalog. 
        /// </para>
        ///  
        /// <para>
        /// Filter values are case sensitive. If you specify multiple values for a filter, the
        /// values are joined with an <code>OR</code>, and the request returns all results that
        /// match any of the specified values.
        /// </para>
        /// </summary>
        public List<string> EC2FamilyFilter
        {
            get { return this._ec2FamilyFilter; }
            set { this._ec2FamilyFilter = value; }
        }

        // Check to see if EC2FamilyFilter property is set
        internal bool IsSetEC2FamilyFilter()
        {
            return this._ec2FamilyFilter != null && this._ec2FamilyFilter.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ItemClassFilter. 
        /// <para>
        ///  A filter for the class of items in the catalog. 
        /// </para>
        ///  
        /// <para>
        /// Filter values are case sensitive. If you specify multiple values for a filter, the
        /// values are joined with an <code>OR</code>, and the request returns all results that
        /// match any of the specified values.
        /// </para>
        /// </summary>
        public List<string> ItemClassFilter
        {
            get { return this._itemClassFilter; }
            set { this._itemClassFilter = value; }
        }

        // Check to see if ItemClassFilter property is set
        internal bool IsSetItemClassFilter()
        {
            return this._itemClassFilter != null && this._itemClassFilter.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property MaxResults.
        /// </summary>
        [AWSProperty(Min=1, Max=1000)]
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
        [AWSProperty(Min=1, Max=1005)]
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
        /// Gets and sets the property SupportedStorageFilter. 
        /// <para>
        ///  A filter for the storage options of items in the catalog. 
        /// </para>
        ///  
        /// <para>
        /// Filter values are case sensitive. If you specify multiple values for a filter, the
        /// values are joined with an <code>OR</code>, and the request returns all results that
        /// match any of the specified values.
        /// </para>
        /// </summary>
        public List<string> SupportedStorageFilter
        {
            get { return this._supportedStorageFilter; }
            set { this._supportedStorageFilter = value; }
        }

        // Check to see if SupportedStorageFilter property is set
        internal bool IsSetSupportedStorageFilter()
        {
            return this._supportedStorageFilter != null && this._supportedStorageFilter.Count > 0; 
        }

    }
}