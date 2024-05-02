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
 * Do not modify this file. This file is generated from the appmesh-2019-01-25.normal.json service model.
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
namespace Amazon.AppMesh.Model
{
    /// <summary>
    /// Container for the parameters to the ListTagsForResource operation.
    /// List the tags for an App Mesh resource.
    /// </summary>
    public partial class ListTagsForResourceRequest : AmazonAppMeshRequest
    {
        private int? _limit;
        private string _nextToken;
        private string _resourceArn;

        /// <summary>
        /// Gets and sets the property Limit. 
        /// <para>
        /// The maximum number of tag results returned by <c>ListTagsForResource</c> in paginated
        /// output. When this parameter is used, <c>ListTagsForResource</c> returns only <c>limit</c>
        /// results in a single page along with a <c>nextToken</c> response element. You can see
        /// the remaining results of the initial request by sending another <c>ListTagsForResource</c>
        /// request with the returned <c>nextToken</c> value. This value can be between 1 and
        /// 100. If you don't use this parameter, <c>ListTagsForResource</c> returns up to 100
        /// results and a <c>nextToken</c> value if applicable.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public int? Limit
        {
            get { return this._limit; }
            set { this._limit = value; }
        }

        // Check to see if Limit property is set
        internal bool IsSetLimit()
        {
            return this._limit.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The <c>nextToken</c> value returned from a previous paginated <c>ListTagsForResource</c>
        /// request where <c>limit</c> was used and the results exceeded the value of that parameter.
        /// Pagination continues from the end of the previous results that returned the <c>nextToken</c>
        /// value.
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
        /// Gets and sets the property ResourceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) that identifies the resource to list the tags for.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ResourceArn
        {
            get { return this._resourceArn; }
            set { this._resourceArn = value; }
        }

        // Check to see if ResourceArn property is set
        internal bool IsSetResourceArn()
        {
            return this._resourceArn != null;
        }

    }
}