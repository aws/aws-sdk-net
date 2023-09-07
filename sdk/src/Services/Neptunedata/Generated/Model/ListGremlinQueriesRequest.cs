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
    /// Container for the parameters to the ListGremlinQueries operation.
    /// Lists active Gremlin queries. See <a href="https://docs.aws.amazon.com/neptune/latest/userguide/gremlin-api-status.html">Gremlin
    /// query status API</a> for details about the output.
    /// </summary>
    public partial class ListGremlinQueriesRequest : AmazonNeptunedataRequest
    {
        private bool? _includeWaiting;

        /// <summary>
        /// Gets and sets the property IncludeWaiting. 
        /// <para>
        /// If set to <code>TRUE</code>, the list returned includes waiting queries. The default
        /// is <code>FALSE</code>;
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