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
 * Do not modify this file. This file is generated from the finspace-data-2020-07-13.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.FinSpaceData.Model
{
    /// <summary>
    /// Response to ListChangesetsResponse. This returns a list of dataset changesets that
    /// match the query criteria.
    /// </summary>
    public partial class ListChangesetsResponse : AmazonWebServiceResponse
    {
        private List<ChangesetSummary> _changesets = new List<ChangesetSummary>();
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property Changesets. 
        /// <para>
        /// List of Changesets found.
        /// </para>
        /// </summary>
        public List<ChangesetSummary> Changesets
        {
            get { return this._changesets; }
            set { this._changesets = value; }
        }

        // Check to see if Changesets property is set
        internal bool IsSetChangesets()
        {
            return this._changesets != null && this._changesets.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// A token that indicates where a results page should begin.
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