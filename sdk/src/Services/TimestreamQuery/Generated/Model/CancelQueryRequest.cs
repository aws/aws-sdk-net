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
 * Do not modify this file. This file is generated from the timestream-query-2018-11-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.TimestreamQuery.Model
{
    /// <summary>
    /// Container for the parameters to the CancelQuery operation.
    /// Cancels a query that has been issued. Cancellation is guaranteed only if the query
    /// has not completed execution before the cancellation request was issued. Because cancellation
    /// is an idempotent operation, subsequent cancellation requests will return a <code>CancellationMessage</code>,
    /// indicating that the query has already been canceled.
    /// </summary>
    public partial class CancelQueryRequest : AmazonTimestreamQueryRequest
    {
        private string _queryId;

        /// <summary>
        /// Gets and sets the property QueryId. 
        /// <para>
        ///  The id of the query that needs to be cancelled. <code>QueryID</code> is returned
        /// as part of QueryResult. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
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

    }
}