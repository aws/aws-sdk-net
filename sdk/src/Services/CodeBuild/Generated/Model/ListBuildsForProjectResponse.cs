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
 * Do not modify this file. This file is generated from the codebuild-2016-10-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CodeBuild.Model
{
    /// <summary>
    /// This is the response object from the ListBuildsForProject operation.
    /// </summary>
    public partial class ListBuildsForProjectResponse : AmazonWebServiceResponse
    {
        private List<string> _ids = new List<string>();
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property Ids. 
        /// <para>
        /// A list of build IDs for the specified build project, with each build ID representing
        /// a single build.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public List<string> Ids
        {
            get { return this._ids; }
            set { this._ids = value; }
        }

        // Check to see if Ids property is set
        internal bool IsSetIds()
        {
            return this._ids != null && this._ids.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// If there are more than 100 items in the list, only the first 100 items are returned,
        /// along with a unique string called a <i>nextToken</i>. To get the next batch of items
        /// in the list, call this operation again, adding the next token to the call.
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

    }
}