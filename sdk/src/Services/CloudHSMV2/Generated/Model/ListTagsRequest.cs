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
 * Do not modify this file. This file is generated from the cloudhsmv2-2017-04-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudHSMV2.Model
{
    /// <summary>
    /// Container for the parameters to the ListTags operation.
    /// Gets a list of tags for the specified AWS CloudHSM cluster.
    /// 
    ///  
    /// <para>
    /// This is a paginated operation, which means that each response might contain only a
    /// subset of all the tags. When the response contains only a subset of tags, it includes
    /// a <code>NextToken</code> value. Use this value in a subsequent <code>ListTags</code>
    /// request to get more tags. When you receive a response with no <code>NextToken</code>
    /// (or an empty or null value), that means there are no more tags to get.
    /// </para>
    /// </summary>
    public partial class ListTagsRequest : AmazonCloudHSMV2Request
    {
        private int? _maxResults;
        private string _nextToken;
        private string _resourceId;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of tags to return in the response. When there are more tags than
        /// the number you specify, the response contains a <code>NextToken</code> value.
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
        /// The <code>NextToken</code> value that you received in the previous response. Use this
        /// value to get more tags.
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
        /// Gets and sets the property ResourceId. 
        /// <para>
        /// The cluster identifier (ID) for the cluster whose tags you are getting. To find the
        /// cluster ID, use <a>DescribeClusters</a>.
        /// </para>
        /// </summary>
        public string ResourceId
        {
            get { return this._resourceId; }
            set { this._resourceId = value; }
        }

        // Check to see if ResourceId property is set
        internal bool IsSetResourceId()
        {
            return this._resourceId != null;
        }

    }
}