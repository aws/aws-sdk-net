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
 * Do not modify this file. This file is generated from the detective-2018-10-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Detective.Model
{
    /// <summary>
    /// This is the response object from the ListGraphs operation.
    /// </summary>
    public partial class ListGraphsResponse : AmazonWebServiceResponse
    {
        private List<Graph> _graphList = new List<Graph>();
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property GraphList. 
        /// <para>
        /// A list of behavior graphs that the account is a master for.
        /// </para>
        /// </summary>
        public List<Graph> GraphList
        {
            get { return this._graphList; }
            set { this._graphList = value; }
        }

        // Check to see if GraphList property is set
        internal bool IsSetGraphList()
        {
            return this._graphList != null && this._graphList.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// If there are more behavior graphs remaining in the results, then this is the pagination
        /// token to use to request the next page of behavior graphs.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
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