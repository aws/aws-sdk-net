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
 * Do not modify this file. This file is generated from the neptunedata-2023-08-01.normal.json service model.
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
namespace Amazon.Neptunedata.Model
{
    /// <summary>
    /// This is the response object from the GetOpenCypherQueryStatus operation.
    /// </summary>
    public partial class GetOpenCypherQueryStatusResponse : AmazonWebServiceResponse
    {
        private QueryEvalStats _queryEvalStats;
        private string _queryId;
        private string _queryString;

        /// <summary>
        /// Gets and sets the property QueryEvalStats. 
        /// <para>
        /// The openCypher query evaluation status.
        /// </para>
        /// </summary>
        public QueryEvalStats QueryEvalStats
        {
            get { return this._queryEvalStats; }
            set { this._queryEvalStats = value; }
        }

        // Check to see if QueryEvalStats property is set
        internal bool IsSetQueryEvalStats()
        {
            return this._queryEvalStats != null;
        }

        /// <summary>
        /// Gets and sets the property QueryId. 
        /// <para>
        /// The unique ID of the query for which status is being returned.
        /// </para>
        /// </summary>
        public string QueryId
        {
            get { return this._queryId; }
            set { this._queryId = value; }
        }

        // Check to see if QueryId property is set
        internal bool IsSetQueryId()
        {
            return this._queryId != null;
        }

        /// <summary>
        /// Gets and sets the property QueryString. 
        /// <para>
        /// The openCypher query string.
        /// </para>
        /// </summary>
        public string QueryString
        {
            get { return this._queryString; }
            set { this._queryString = value; }
        }

        // Check to see if QueryString property is set
        internal bool IsSetQueryString()
        {
            return this._queryString != null;
        }

    }
}