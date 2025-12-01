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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
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
namespace Amazon.Connect.Model
{
    /// <summary>
    /// This is the response object from the SearchViews operation.
    /// </summary>
    public partial class SearchViewsResponse : AmazonWebServiceResponse
    {
        private long? _approximateTotalCount;
        private string _nextToken;
        private List<View> _views = AWSConfigs.InitializeCollections ? new List<View>() : null;

        /// <summary>
        /// Gets and sets the property ApproximateTotalCount. 
        /// <para>
        /// The approximate total number of views that match the search criteria.
        /// </para>
        /// </summary>
        public long ApproximateTotalCount
        {
            get { return this._approximateTotalCount.GetValueOrDefault(); }
            set { this._approximateTotalCount = value; }
        }

        // Check to see if ApproximateTotalCount property is set
        internal bool IsSetApproximateTotalCount()
        {
            return this._approximateTotalCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// If there are additional results, this is the token for the next set of results.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2500)]
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
        /// Gets and sets the property Views. 
        /// <para>
        /// A list of views that match the search criteria.
        /// </para>
        /// </summary>
        public List<View> Views
        {
            get { return this._views; }
            set { this._views = value; }
        }

        // Check to see if Views property is set
        internal bool IsSetViews()
        {
            return this._views != null && (this._views.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}