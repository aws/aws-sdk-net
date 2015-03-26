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
 * Do not modify this file. This file is generated from the datapipeline-2012-10-29.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.DataPipeline.Model
{
    /// <summary>
    /// Contains the output from the <a>QueryObjects</a> action.
    /// </summary>
    public partial class QueryObjectsResponse : AmazonWebServiceResponse
    {
        private bool? _hasMoreResults;
        private List<string> _ids = new List<string>();
        private string _marker;

        /// <summary>
        /// Gets and sets the property HasMoreResults. 
        /// <para>
        /// If <code>True</code>, there are more results that can be obtained by a subsequent
        /// call to <a>QueryObjects</a>.
        /// </para>
        /// </summary>
        public bool HasMoreResults
        {
            get { return this._hasMoreResults.GetValueOrDefault(); }
            set { this._hasMoreResults = value; }
        }

        // Check to see if HasMoreResults property is set
        internal bool IsSetHasMoreResults()
        {
            return this._hasMoreResults.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Ids. 
        /// <para>
        /// A list of identifiers that match the query selectors.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property Marker. 
        /// <para>
        ///  The starting point for the results to be returned. As long as the action returns
        /// <code>HasMoreResults</code> as <code>True</code>, you can call <a>QueryObjects</a>
        /// again and pass the marker value from the response to retrieve the next set of results.
        /// 
        /// </para>
        /// </summary>
        public string Marker
        {
            get { return this._marker; }
            set { this._marker = value; }
        }

        // Check to see if Marker property is set
        internal bool IsSetMarker()
        {
            return this._marker != null;
        }

    }
}