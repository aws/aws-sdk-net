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

namespace Amazon.Neptunedata.Model
{
    /// <summary>
    /// Container for the parameters to the ListOpenCypherQueries operation.
    /// Lists active openCypher queries. See <a href="https://docs.aws.amazon.com/neptune/latest/userguide/access-graph-opencypher-status.html">Neptune
    /// openCypher status endpoint</a> for more information.
    /// </summary>
    public partial class ListOpenCypherQueriesRequest : AmazonNeptunedataRequest
    {
        private bool? _includeWaiting;

        /// <summary>
        /// Gets and sets the property IncludeWaiting. 
        /// <para>
        ///  When set to <code>TRUE</code> and other parameters are not present, causes status
        /// information to be returned for waiting queries as well as for running queries.
        /// </para>
        /// </summary>
        public bool IncludeWaiting
        {
            get { return this._includeWaiting.GetValueOrDefault(); }
            set { this._includeWaiting = value; }
        }

        // Check to see if IncludeWaiting property is set
        internal bool IsSetIncludeWaiting()
        {
            return this._includeWaiting.HasValue; 
        }

    }
}