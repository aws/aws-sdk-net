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
 * Do not modify this file. This file is generated from the neptune-graph-2023-11-29.normal.json service model.
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
namespace Amazon.NeptuneGraph.Model
{
    /// <summary>
    /// This is the response object from the GetQuery operation.
    /// </summary>
    public partial class GetQueryResponse : AmazonWebServiceResponse
    {
        private int? _elapsed;
        private string _id;
        private string _queryString;
        private QueryState _state;
        private int? _waited;

        /// <summary>
        /// Gets and sets the property Elapsed. 
        /// <para>
        /// The number of milliseconds the query has been running.
        /// </para>
        /// </summary>
        public int? Elapsed
        {
            get { return this._elapsed; }
            set { this._elapsed = value; }
        }

        // Check to see if Elapsed property is set
        internal bool IsSetElapsed()
        {
            return this._elapsed.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The ID of the query in question.
        /// </para>
        /// </summary>
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property QueryString. 
        /// <para>
        /// The query in question.
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

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// State of the query.
        /// </para>
        /// </summary>
        public QueryState State
        {
            get { return this._state; }
            set { this._state = value; }
        }

        // Check to see if State property is set
        internal bool IsSetState()
        {
            return this._state != null;
        }

        /// <summary>
        /// Gets and sets the property Waited. 
        /// <para>
        /// Indicates how long the query waited, in milliseconds.
        /// </para>
        /// </summary>
        public int? Waited
        {
            get { return this._waited; }
            set { this._waited = value; }
        }

        // Check to see if Waited property is set
        internal bool IsSetWaited()
        {
            return this._waited.HasValue; 
        }

    }
}