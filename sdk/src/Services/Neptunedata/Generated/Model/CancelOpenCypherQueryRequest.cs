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
    /// Container for the parameters to the CancelOpenCypherQuery operation.
    /// Cancels a specified openCypher query. See <a href="https://docs.aws.amazon.com/neptune/latest/userguide/access-graph-opencypher-status.html">Neptune
    /// openCypher status endpoint</a> for more information.
    /// </summary>
    public partial class CancelOpenCypherQueryRequest : AmazonNeptunedataRequest
    {
        private string _queryId;
        private bool? _silent;

        /// <summary>
        /// Gets and sets the property QueryId. 
        /// <para>
        /// The unique ID of the openCypher query to cancel.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property Silent. 
        /// <para>
        /// If set to <code>TRUE</code>, causes the cancelation of the openCypher query to happen
        /// silently.
        /// </para>
        /// </summary>
        public bool Silent
        {
            get { return this._silent.GetValueOrDefault(); }
            set { this._silent = value; }
        }

        // Check to see if Silent property is set
        internal bool IsSetSilent()
        {
            return this._silent.HasValue; 
        }

    }
}