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
 * Do not modify this file. This file is generated from the codecommit-2015-04-13.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CodeCommit.Model
{
    /// <summary>
    /// This is the response object from the GetDifferences operation.
    /// </summary>
    public partial class GetDifferencesResponse : AmazonWebServiceResponse
    {
        private List<Difference> _differences = new List<Difference>();
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property Differences. 
        /// <para>
        /// A data type object that contains information about the differences, including whether
        /// the difference is added, modified, or deleted (A, D, M).
        /// </para>
        /// </summary>
        public List<Difference> Differences
        {
            get { return this._differences; }
            set { this._differences = value; }
        }

        // Check to see if Differences property is set
        internal bool IsSetDifferences()
        {
            return this._differences != null && this._differences.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// An enumeration token that can be used in a request to return the next batch of the
        /// results.
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