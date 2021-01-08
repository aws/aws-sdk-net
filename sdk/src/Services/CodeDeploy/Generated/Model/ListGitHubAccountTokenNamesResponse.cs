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
 * Do not modify this file. This file is generated from the codedeploy-2014-10-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CodeDeploy.Model
{
    /// <summary>
    /// Represents the output of a <code>ListGitHubAccountTokenNames</code> operation.
    /// </summary>
    public partial class ListGitHubAccountTokenNamesResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<string> _tokenNameList = new List<string>();

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// If a large amount of information is returned, an identifier is also returned. It can
        /// be used in a subsequent <code>ListGitHubAccountTokenNames</code> call to return the
        /// next set of names in the list. 
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
        /// Gets and sets the property TokenNameList. 
        /// <para>
        /// A list of names of connections to GitHub accounts.
        /// </para>
        /// </summary>
        public List<string> TokenNameList
        {
            get { return this._tokenNameList; }
            set { this._tokenNameList = value; }
        }

        // Check to see if TokenNameList property is set
        internal bool IsSetTokenNameList()
        {
            return this._tokenNameList != null && this._tokenNameList.Count > 0; 
        }

    }
}