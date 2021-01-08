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
 * Do not modify this file. This file is generated from the appsync-2017-07-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.AppSync.Model
{
    /// <summary>
    /// This is the response object from the ListResolversByFunction operation.
    /// </summary>
    public partial class ListResolversByFunctionResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<Resolver> _resolvers = new List<Resolver>();

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// An identifier that can be used to return the next set of items in the list.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=65536)]
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
        /// Gets and sets the property Resolvers. 
        /// <para>
        /// The list of resolvers.
        /// </para>
        /// </summary>
        public List<Resolver> Resolvers
        {
            get { return this._resolvers; }
            set { this._resolvers = value; }
        }

        // Check to see if Resolvers property is set
        internal bool IsSetResolvers()
        {
            return this._resolvers != null && this._resolvers.Count > 0; 
        }

    }
}