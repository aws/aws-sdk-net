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
 * Do not modify this file. This file is generated from the ce-2017-10-25.normal.json service model.
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
namespace Amazon.CostExplorer.Model
{
    /// <summary>
    /// This is the response object from the GetTags operation.
    /// </summary>
    public partial class GetTagsResponse : AmazonWebServiceResponse
    {
        private string _nextPageToken;
        private int? _returnSize;
        private List<string> _tags = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private int? _totalSize;

        /// <summary>
        /// Gets and sets the property NextPageToken. 
        /// <para>
        /// The token for the next set of retrievable results. Amazon Web Services provides the
        /// token when the response from a previous call has more results than the maximum page
        /// size.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=8192)]
        public string NextPageToken
        {
            get { return this._nextPageToken; }
            set { this._nextPageToken = value; }
        }

        // Check to see if NextPageToken property is set
        internal bool IsSetNextPageToken()
        {
            return this._nextPageToken != null;
        }

        /// <summary>
        /// Gets and sets the property ReturnSize. 
        /// <para>
        /// The number of query results that Amazon Web Services returns at a time.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int? ReturnSize
        {
            get { return this._returnSize; }
            set { this._returnSize = value; }
        }

        // Check to see if ReturnSize property is set
        internal bool IsSetReturnSize()
        {
            return this._returnSize.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags that match your request.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TotalSize. 
        /// <para>
        /// The total number of query results.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int? TotalSize
        {
            get { return this._totalSize; }
            set { this._totalSize = value; }
        }

        // Check to see if TotalSize property is set
        internal bool IsSetTotalSize()
        {
            return this._totalSize.HasValue; 
        }

    }
}