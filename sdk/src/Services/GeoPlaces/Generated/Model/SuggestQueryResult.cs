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
 * Do not modify this file. This file is generated from the geo-places-2020-11-19.normal.json service model.
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
namespace Amazon.GeoPlaces.Model
{
    /// <summary>
    /// The suggested query results.
    /// </summary>
    public partial class SuggestQueryResult
    {
        private string _queryId;
        private QueryType _queryType;

        /// <summary>
        /// Gets and sets the property QueryId. 
        /// <para>
        /// QueryId can be used to complete a follow up query through the SearchText API. The
        /// QueryId retains context from the original Suggest request such as filters, political
        /// view and language. See the SearchText API documentation for more details <a href="https://docs.aws.amazon.com/latest/APIReference/API_geoplaces_SearchText.html">SearchText
        /// API docs</a>.
        /// </para>
        ///  <note> 
        /// <para>
        /// The fields <c>QueryText</c>, and <c>QueryID</c> are mutually exclusive.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=500)]
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
        /// Gets and sets the property QueryType. 
        /// <para>
        /// The query type. Category queries will search for places which have an entry matching
        /// the given category, for example "doctor office". BusinessChain queries will search
        /// for instances of a given business.
        /// </para>
        /// </summary>
        public QueryType QueryType
        {
            get { return this._queryType; }
            set { this._queryType = value; }
        }

        // Check to see if QueryType property is set
        internal bool IsSetQueryType()
        {
            return this._queryType != null;
        }

    }
}