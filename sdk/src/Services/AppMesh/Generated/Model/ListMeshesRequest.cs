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

namespace Amazon.AppMesh.Model
{
    /// <summary>
    /// Container for the parameters to the ListMeshes operation.
    /// Returns a list of existing service meshes.
    /// </summary>
    public partial class ListMeshesRequest : AmazonAppMeshRequest
    {
        private int? _limit;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property Limit. 
        /// <para>
        /// The maximum number of results returned by <code>ListMeshes</code> in paginated output.
        /// When you use this parameter, <code>ListMeshes</code> returns only <code>limit</code>
        /// results in a single page along with a <code>nextToken</code> response element. You
        /// can see the remaining results of the initial request by sending another <code>ListMeshes</code>
        /// request with the returned <code>nextToken</code> value. This value can be between
        /// 1 and 100. If you don't use this parameter, <code>ListMeshes</code> returns up to
        /// 100 results and a <code>nextToken</code> value if applicable.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public int Limit
        {
            get { return this._limit.GetValueOrDefault(); }
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
        /// The <code>nextToken</code> value returned from a previous paginated <code>ListMeshes</code>
        /// request where <code>limit</code> was used and the results exceeded the value of that
        /// parameter. Pagination continues from the end of the previous results that returned
        /// the <code>nextToken</code> value.
        /// </para>
        ///  <note> 
        /// <para>
        /// This token should be treated as an opaque identifier that is used only to retrieve
        /// the next items in a list and not for other programmatic purposes.
        /// </para>
        ///  </note>
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

    }
}