/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the mturk-requester-2017-01-17.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.MTurk.Model
{
    /// <summary>
    /// This is the response object from the ListHITs operation.
    /// </summary>
    public partial class ListHITsResponse : AmazonWebServiceResponse
    {
        private List<HIT> _hiTs = new List<HIT>();
        private string _nextToken;
        private int? _numResults;

        /// <summary>
        /// Gets and sets the property HITs. 
        /// <para>
        ///  The list of HIT elements returned by the query.
        /// </para>
        /// </summary>
        public List<HIT> HITs
        {
            get { return this._hiTs; }
            set { this._hiTs = value; }
        }

        // Check to see if HITs property is set
        internal bool IsSetHITs()
        {
            return this._hiTs != null && this._hiTs.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NextToken.
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
        /// Gets and sets the property NumResults. 
        /// <para>
        /// The number of HITs on this page in the filtered results list, equivalent to the number
        /// of HITs being returned by this call.
        /// </para>
        /// </summary>
        public int NumResults
        {
            get { return this._numResults.GetValueOrDefault(); }
            set { this._numResults = value; }
        }

        // Check to see if NumResults property is set
        internal bool IsSetNumResults()
        {
            return this._numResults.HasValue; 
        }

    }
}